using Common.Domain;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DBBroker
{
     public class BrokerDB
    {
        private DBConnection connection;
        public BrokerDB()
        {
            connection = new DBConnection();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }
        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public IEntity Add(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            if (string.IsNullOrWhiteSpace(entity.IdColumn))
            {
                cmd.CommandText = $"INSERT INTO {entity.TableName} VALUES ({entity.Values})";
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = $"INSERT INTO {entity.TableName} OUTPUT INSERTED.{entity.IdColumn} VALUES ({entity.Values})";
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                entity.SetId(id);
            }
            cmd.Dispose();
            return entity;
        }

        public void Delete(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.IdCondition}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public IEntity Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {entity.TableName} SET {entity.Update} WHERE {entity.IdCondition}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return entity;
        }

        public List<IEntity> GetAll(IEntity entity, string condition = "", string join = "")
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {entity.TableName}";
            if (!String.IsNullOrEmpty(condition))
            {
                command.CommandText += $" {join} WHERE {condition}";
            }
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }


    }
}