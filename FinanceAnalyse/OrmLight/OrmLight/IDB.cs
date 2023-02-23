namespace OrmLight
{
    public interface IDB
    {
        string Name {get;}
        IDBSelect<T> Select<T>();
    }
}