using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string IdCondition { get; }
        string Update { get; }
        string FullName { get; }
        string IdColumn { get; }
        void SetId(int id);
        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}
