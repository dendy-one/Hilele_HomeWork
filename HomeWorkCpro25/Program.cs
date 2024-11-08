using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tcpClient = new TCPClient("example.com", 80);
            tcpClient.Connect();
            tcpClient.SendMessage("Hello, TCP Server");
            Console.WriteLine(tcpClient.ReceiveMessage());
            tcpClient.Close();
            
            var udpClient = new UDPClient("example.com", 8080);
            udpClient.SendMessage("Hello, UDP Server");
            Console.WriteLine(udpClient.ReceiveMessage());
            udpClient.Close();

            var httpClient = new HTTPClient("https://jsonplaceholder.typicode.com");
            Console.WriteLine(await httpClient.SendGetRequest("/todos/1"));
            Console.WriteLine(await httpClient.SendPostRequest("/posts", new StringContent("{\"title\": \"foo\", \"body\": \"bar\", \"userId\": 1}", Encoding.UTF8, "application/json")));

        }
    }

    
}
