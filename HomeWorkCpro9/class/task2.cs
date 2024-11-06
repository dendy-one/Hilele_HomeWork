class Task2
    {
        public static async Task RunAsync()
        {
            string url = "https://example.com"; 
            string filePath = "downloaded_data.txt"; 

            await DownloadDataAsync(url, filePath);

            Console.WriteLine($"Дані завантажено та збережено у файлі {filePath}");
        }
         static async Task DownloadDataAsync(string url, string filePath)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();
                    await File.WriteAllTextAsync(
                        filePath, content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при завантаженні даних: {ex.Message}");
                }
            }
        }
    }