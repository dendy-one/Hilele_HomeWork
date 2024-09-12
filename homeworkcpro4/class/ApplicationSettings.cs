public class ApplicationSettings
{
    public string AppName { get; set; }
    public string Version { get; set; }

    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
        public int Timeout { get; set; }

        public override string ToString()
        {
            return $"ConnectionString: {ConnectionString}, Timeout: {Timeout} сек.";
        }
    }

    public DatabaseSettings DbSettings { get; set; } = new DatabaseSettings();

    public string GetFullSettings()
    {
        return $"Назва програми: {AppName}, Версія: {Version}, Налаштування бази даних: {DbSettings}";
    }
}