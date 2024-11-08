using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UDPClient
{
    private string host;
    private int port;
    private UdpClient client;

    public UDPClient(string host, int port)
    {
        this.host = host;
        this.port = port;
        this.client = new UdpClient();
    }

    public void SendMessage(string message)
    {
        byte[] data = Encoding.ASCII.GetBytes(message);
        client.Send(data, data.Length, host, port);
    }

    public string ReceiveMessage()
    {
        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
        byte[] data = client.Receive(ref remoteEndPoint);
        return Encoding.ASCII.GetString(data);
    }

    public void Close()
    {
        client.Close();
    }
}
