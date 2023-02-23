using System.Linq.Expressions;
namespace OrmLight
{
    public interface IDBSelect<T>
    {
         IDBWhere<T> Where();
         IDBGroupBy<T> GroupBy();
    }
}