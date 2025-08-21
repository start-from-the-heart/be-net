namespace LibraryManagementSystem.Entity.Helper
{
    public static class TextFileManager
    {
        public static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static void AppendToFile(string path, string content)
        {
            File.AppendAllText(path, content + Environment.NewLine);
        }

        public static string ReadFromFile(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
        }
    }
}