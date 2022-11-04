using System.Globalization;

namespace MyDictionary;
using System.Collections;
public class MyDictionary<Key, T> : IEnumerable
{
    private Item<Key, T>[] _items;
    private int _size;
    private int _capacity;
    public MyDictionary(params Item<Key, T>[] items)
    {
        _items = new Item<Key, T>[items.Length];
        _size = items.Length;
        _capacity = items.Length;
        for (int i = 0; i < _size; ++i)
        {
            _items[i] = items[i];
        }
    }
    
    public void Add(Key k, T val)
    {
        if (_size == _capacity)
        {
            _capacity = 2 * _size;
            Item<Key, T>[] new_array = new Item<Key, T>[_capacity];
            for (uint i = 0; i < _items.Length; ++i)
            {
                new_array[i] = _items[i];
            }
            _items = new_array;
        }
        ++_size;
        _items[Count - 1] = new Item<Key, T>(k, val);
    }

    public IEnumerator GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    public int Count => _size;
    public int Capacity => _capacity;

    public Item<Key, T> this[Key k]
    {
        get
        {
            for (int i = 0; i < _size; ++i)
            {
                if (_items[i].GetKey.Equals(k))
                {
                    return _items[i];
                }
            }
            throw new Exception("There is no such element");
        }
    }
}

public class Item<Key, T>
{
    private Key _key;
    private T value;
    public Item(Key k, T val) => (_key, value) = (k, val);
    public Key GetKey => _key;
    public T GetValue => value;

    public override string ToString()
    {
        string? item_info = Convert.ToString(GetKey);
        item_info += $" {Convert.ToString(value)}";
        return item_info;
    }
}