using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class TCPClient
{
    private string host;
    private int port;
    private TcpClient client;

    public TCPClient(string host, int port)
    {
        this.host = host;
        this.port = port;
        this.client = new TcpClient();
    }

    public void Connect()
    {
        client.Connect(host, port);
    }

    public void SendMessage(string message)
    {
        NetworkStream stream = client.GetStream();
        byte[] data = Encoding.ASCII.GetBytes(message);
        stream.Write(data, 0, data.Length);
    }

    public string ReceiveMessage()
    {
        NetworkStream stream = client.GetStream();
        byte[] data = new byte[256];
        int bytes = stream.Read(data, 0, data.Length);
        return Encoding.ASCII.GetString(data, 0, bytes);
    }

    public void Close()
    {
        client.Close();
    }
}
