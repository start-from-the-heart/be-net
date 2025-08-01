use AutoParts

--CREATE TABLE product_category (
--    id SMALLINT PRIMARY KEY,
--    category_name VARCHAR(255) NOT NULL,
--    parent_category_id SMALLINT,
--    FOREIGN KEY (parent_category_id) REFERENCES product_category(id)
--);

--CREATE TABLE application_status (
--    id BIGINT PRIMARY KEY,
--    status_name VARCHAR(255) NOT NULL
--);

--CREATE TABLE seller (
--    id BIGINT PRIMARY KEY,
--    seller_name VARCHAR(255) NOT NULL,
--    address TEXT,
--    mobile_number TEXT
--);

--CREATE TABLE vehicle_type (
--    id BIGINT PRIMARY KEY,
--    vehicle_type_name VARCHAR(255) NOT NULL
--);

--CREATE TABLE vehicles (
--    id BIGINT PRIMARY KEY,
--    model_name VARCHAR(255) NOT NULL,
--    manufacturer_name VARCHAR(255),
--    vehicle_type_id BIGINT,
--    FOREIGN KEY (vehicle_type_id) REFERENCES vehicle_type(id)
--);

--CREATE TABLE applications (
--    app_id BIGINT PRIMARY KEY,
--    headline TEXT,
--    price_gel INT,
--    price_usd INT,
--    app_register_date DATE,
--    status_id BIGINT,
--    category_id SMALLINT,
--    vehicle_type_id BIGINT,
--    seller_id BIGINT,
--    item_condition VARCHAR(255),
--    insert_date DATE,
--    FOREIGN KEY (status_id) REFERENCES application_status(id),
--    FOREIGN KEY (category_id) REFERENCES product_category(id),
--    FOREIGN KEY (vehicle_type_id) REFERENCES vehicle_type(id),
--    FOREIGN KEY (seller_id) REFERENCES seller(id)
--);

--CREATE TABLE compatibility (
--    app_id BIGINT,
--    bottom_year SMALLINT,
--    top_year SMALLINT,
--    vehicles_id BIGINT,
--    PRIMARY KEY (app_id, vehicles_id),
--    FOREIGN KEY (app_id) REFERENCES applications(app_id),
--    FOREIGN KEY (vehicles_id) REFERENCES vehicles(id)
--);

--CREATE TABLE [User](
--	user_id VARCHAR(100) PRIMARY KEY,
--	user_name VARCHAR(30),
--	age INT,
--	phone VARCHAR(50),
--	address VARCHAR(100),
--	password VARCHAR(100)
--)

--CREATE TABLE [Token](
--	user_id VARCHAR(100) PRIMARY KEY,
--	token TEXT,
--)


--select cp.app_id,cp.bottom_year, ac.app_register_date from compatibility cp
--join applications ac on cp.app_id = ac.app_id
--where cp.app_id = '10074150'



--select cp.bottom_year, cp.app_id,ac.app_register_date, ac.category_id from compatibility cp
--join applications ac on cp.app_id = ac.app_id
--where cp.bottom_year = 2024 or ac.category_id = 613
--group by cp.bottom_year, cp.app_id,ac.app_register_date, ac.category_id
--order by cp.app_id


--where cp.bottom_year = 2024 and ac.category_id = 613 
--select * from compatibility cp
--right join  applications ac on cp.app_id = ac.app_id
--SET STATISTICS IO ON
--SET STATISTICS TIME ON

---- select top
--select app_id, headline,*
--from applications
--where headline like '%SU%'

--with getmaxpricegel as 
--(
--	select max(price_gel) as 'price_gel'
--	from applications
--	group by price_gel, price_usd
--	having price_usd = min(price_usd)
--)

--create view GetValueCount as (
--	select max(price_gel) as 'price_gel'
--	from applications
--	group by price_gel, price_usd
--	having price_usd = min(price_usd)
--)

--select * from GetValueCount
--start index substring = 1
--select *, SUBSTRING(v.manufacturer_name, 1 ,3) as 'sub'
--from compatibility c
--join vehicles v on c.vehicles_id = v.id
--where vehicle_type_id = 1

--create procedure GetSellerTop 
--	@sellerID nvarchar(50)
--as
--Begin
--	select top 1 COUNT(a.seller_id) as CountData,s.seller_name, CAST(s.seller_name AS NVARCHAR(255)) AS seller_name
--	from applications a
--	join seller s on a.seller_id = s.id
--	group by a.seller_id, s.seller_name, CAST(s.seller_name AS NVARCHAR(255))
--	order by CountData desc
--end

-- Call store
--exec GetSellerTop @sellerID = '1'

--Remove Store
--drop procedure GetSellerTop


BEGIN TRANSACTION;

UPDATE seller
SET address = 'Blocked'
WHERE id = 79;

Begin TRANSACTION
	Begin try 
		UPDATE [dbo].[seller]
		   SET 
			  [address] = 'HaNoi'
			  ,[mobile_number] = '012556344'
		 WHERE id = 79;

		 INSERT INTO [dbo].[applications]
		    ([app_id]
           ,[headline]
           ,[price_gel]
           ,[price_usd]
           ,[app_register_date]
           ,[status_id]
           ,[category_id]
           ,[vehicle_type_id]
           ,[seller_id]
           ,[item_condition]
           ,[insert_date])
     VALUES
           (3
           ,'Hello'
           ,1
           ,20
           ,'2025/03/14'
           ,1
           ,20
           ,1
           ,79
           ,'Test'
           ,'2025/03/04');
		 COMMIT TRANSACTION;
	end try
	BEGIN CATCH
		ROLLBACK TRANSACTION;

		PRINT ERROR_MESSAGE();
	END CATCH;

--create function fn_GetFullName(@first nvarchar(50), @last nvarchar(50))
--returns nvarchar(50)
--as 
--	begin
--		return @last + '' + @first
--	end;

-- Call Function Scalar Function
--SELECT dbo.fn_GetFullName('Anh', 'Nguyen') AS FullName;

-- create Table-Valued Function (trả về bảng)
--create function GetAllicationByID(@application_id int)
--returns table
--return (
--	select * from applications
--		where app_id = @application_id
--);

-- Call Function Table-Valued
--select * from  GetAllicationByID(1)

-- check sesstion block 
--SELECT 
--    r.session_id,
--    r.blocking_session_id,
--    r.status,
--    r.wait_type,
--    r.wait_time,
--    r.cpu_time,
--    r.total_elapsed_time,
--    t.text AS running_sql_text,
--    qp.query_plan
--FROM sys.dm_exec_requests r
--JOIN sys.dm_exec_sessions s ON r.session_id = s.session_id
--CROSS APPLY sys.dm_exec_sql_text(r.sql_handle) AS t
--OUTER APPLY sys.dm_exec_query_plan(r.plan_handle) AS qp
--WHERE r.blocking_session_id <> 0;

----Cound Block
--SELECT 
--    t.text AS [SQL Text],
--    COUNT(*) AS [BlockedCount]
--FROM sys.dm_exec_requests r
--JOIN sys.dm_exec_sessions s ON r.session_id = s.session_id
--CROSS APPLY sys.dm_exec_sql_text(r.sql_handle) AS t
--WHERE r.blocking_session_id <> 0
--GROUP BY t.text
--ORDER BY [BlockedCount] DESC;



-- tach ra lam 2 tab
--BEGIN TRANSACTION;
--BEGIN TRY 
--    UPDATE [dbo].[seller]
--       SET 
--          [address] = 'HaNoi',
--          [mobile_number] = '012556344'
--     WHERE id = 79; 

--    INSERT INTO [dbo].[applications]
--        ([app_id], [headline], [price_gel], [price_usd],
--         [app_register_date], [status_id], [category_id], 
--         [vehicle_type_id], [seller_id], [item_condition], [insert_date])
--    VALUES
--        (3, 'Hello', 1, 20, '2025-03-14', 1, 20, 1, 79, 'Test', '2025-03-04');

--    COMMIT TRANSACTION;
--END TRY
--BEGIN CATCH
--    ROLLBACK TRANSACTION;
--    PRINT ERROR_MESSAGE();
--END CATCH;

---- tab 2

--BEGIN TRANSACTION;

--UPDATE seller
--SET address = 'Blocked'
--WHERE id = 79;
--COMMIT
