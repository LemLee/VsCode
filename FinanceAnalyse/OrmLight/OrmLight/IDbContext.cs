using System.Data;
namespace OrmLight;
public interface IDbContext
{
    IDbConnection Connection { get; set; }
    IDB GetDatabase(string name);

}
