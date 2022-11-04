namespace Lab05_belousov;

public class MyList<T>
{
    private T[] _items;
    private int _size;

    private int _capacity;

    public MyList(int capacity)
    {
        if (capacity < 0)
        {
            throw new Exception("capacity is negative");
        }

        _items = new T[capacity];
    }

    public MyList(params T[] args)
    {
        _items = new T[args.Length];
        _size = args.Length;
        _capacity = args.Length;
        for (uint i = 0; i < _size; ++i)
        {
            _items[i] = args[i];
        }
    }

    public void Add(T item)
    {
        if (_size == _capacity)
        {
            _capacity = 2 * _size;
            T[] new_array = new T[_capacity];
            for (uint i = 0; i < _items.Length; ++i)
            {
                new_array[i] = _items[i];
            }
            _items = new_array;
        }
        
        ++_size;
        _items[Count - 1] = item;
    }
    

    public int Count => _size;
    public int Capacity => _capacity;

    public T this[uint index] => _items[index];
}