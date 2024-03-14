using System.Collections;

namespace CustomList;

internal class CustomList<T> : ICustomList<T>, IEnumerable
{
    private T[] _items = new T[2];
    private int _size = 0;

    public T this[int index]
    {
        get
        {
            return _items[index];
        }
        set
        {
            if (index < _size)
            {
                _items[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public int Count
    {
        get
        {
            return _size;
        }
    }

    public void Add(T item)
    {
        if (_size == _items.Length)
        {
            ResizeArray();
        }

        var index = _size++;
        _items[index] = item;
    }

    public IEnumerator GetEnumerator()
    {
        for(var i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }

    private void ResizeArray()
    {
        var bufferArray = _items;
        _items = new T[bufferArray.Length * 2];

        for (var i = 0; i < bufferArray.Length; i++)
        {
            _items[i] = bufferArray[i];
        }
    }
}
