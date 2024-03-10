namespace CustomList;

internal interface ICustomList<in T>
{
    void Add(T item);
}
