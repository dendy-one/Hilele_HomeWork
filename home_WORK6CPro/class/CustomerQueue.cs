class CustomerQueue
{
    private Queue<string> queue = new Queue<string>();

    public void AddCustomer(string name)
    {
        queue.Enqueue(name);
    }

    public string ServeCustomer()
    {
        return queue.Dequeue();
    }

    public int GetQueueLength()
    {
        return queue.Count;
    }
}
