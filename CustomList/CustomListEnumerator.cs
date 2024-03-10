using System.Collections;

namespace CustomList;

internal class CustomListEnumerator<T> : IEnumerator
{
    private readonly T[] _items;
    private readonly int _size;
    private int _position = -1;

    public CustomListEnumerator(T[] items, int size)
    {
        _items = items;
        _size = size;
    }

    public T Current
    {
        get
        {
            try
            {
                return _items[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public bool MoveNext()
    {
        _position++;
        return _position < _size;
    }

    public void Reset()
    {
        _position = -1;
    }
}
