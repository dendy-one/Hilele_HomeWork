﻿public class Storage<T>
{
    private T _item;

    public void SetItem(T item)
    {
        _item = item;
    }

    public T GetItem()
    {
        return _item;
    }
}