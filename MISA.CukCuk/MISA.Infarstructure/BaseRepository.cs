using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Enums;
using MISA.ApplicationCore.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Z.Dapper.Plus;
namespace MISA.Infarstructure
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : BaseEntity
    {
        #region DECLARE
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection = null;
        protected string _tableName;
        #endregion

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MISACukCukConnectionString");
            _dbConnection = new MySqlConnection(_connectionString);
            _tableName = typeof(TEntity).Name;
        }
        /// <summary>
        /// Thực hiện thêm 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        public int Add(TEntity entity)
        {
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                entity.GetType().GetProperty($"{_tableName}Id").SetValue(entity, Guid.NewGuid());
                var rowAffects = _dbConnection.BulkInsert(entity);
                //try
                //{
                //    var parameters = MappingDbType(entity);
                //    // Thực hiện thêm khách hàng:
                //    rowAffects = _dbConnection.Execute($"Proc_Insert{_tableName}", parameters, commandType: CommandType.StoredProcedure);
                //    transaction.Commit();
                //}
                //catch (Exception ex)
                //{
                //    transaction.Rollback();
                //}
                transaction.Commit();
                return rowAffects.Actions.Count();
            }
            // Trả về kết quả (số bản ghi thêm mới được)
            
        }
        /// <summary>
        /// Thực hiện xóa
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)

        public int Delete(Guid employeeId)
        {

            var res = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                res = _dbConnection.Execute($"DELETE FROM {_tableName} WHERE {_tableName}Id = '{employeeId.ToString()}'", commandType: CommandType.Text);
                transaction.Commit();
            }
            return res;
        }

        public virtual IEnumerable<TEntity> GetEntities()
        {
            // Kết nối tới CSDL:
            // Khởi tạo các commandText:
            var entities = _dbConnection.Query<TEntity>($"Proc_Get{_tableName}s", commandType: CommandType.StoredProcedure);
            // Trả về về dữ liệu:
            return entities;
        }

        /// <summary>
        /// Lấy dữ liệu theo Id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)

        public TEntity GetEntityById(Guid entityId)
        {
            // Khởi tạo kết nối với Db:
            var parameters = new DynamicParameters();
            parameters.Add($"{_tableName}Id", entityId, DbType.String);
            // Thực thi commandText:
            var rowAffects = _dbConnection.Query<TEntity>($"Proc_Get{_tableName}ById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault() ;
            // Trả về kết quả (số bản ghi thêm mới được)
            return rowAffects;
        }

        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>số bản ghi</returns>
        /// createdby ngochtb(02/12/2020)
        public int Update(TEntity entity)
        {
            //// Khởi tạo kết nối với Db:
            //var parameters = MappingDbType(entity);
            //// Thực thi commandText:
            //var rowAffects = _dbConnection.Execute($"Proc_Update{_tableName}", parameters, commandType: CommandType.StoredProcedure);
            //// Trả về kết quả (số bản ghi thêm mới được)
            var rowAffects = _dbConnection.BulkUpdate(entity).Actions.Count();
            return rowAffects;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        private DynamicParameters MappingDbType(TEntity entity)
        {
            var properties = entity.GetType().GetProperties();
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;
                if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
                {
                    parameters.Add($"@{propertyName}", propertyValue, DbType.String);
                }
                else if (propertyType == typeof(bool) || propertyType == typeof(bool?))
                {
                    var dbValue = ((bool)propertyValue == true ? 1 : 0);
                    parameters.Add($"@{propertyName}", dbValue, DbType.Int32);
                }
                else
                {
                    parameters.Add($"@{propertyName}", propertyValue);
                }

            }
            return parameters;
        }
        /// <summary>
        /// Lấy dữ liệu theo thuộc tính
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        public TEntity GetEntityByProperty(TEntity entity, PropertyInfo property)
        {
            var propertyName = property.Name;
            var propertyValue = property.GetValue(entity);
            var keyValue = entity.GetType().GetProperty($"{_tableName}Id").GetValue(entity);
            var query = string.Empty;
            if (entity.EntityState == EntityState.AddNew)
                query = $"SELECT * FROM {_tableName} WHERE {propertyName} = '{propertyValue}'";
            else if (entity.EntityState == EntityState.Update)
                query = $"SELECT * FROM {_tableName} WHERE {propertyName} = '{propertyValue}' AND {_tableName}Id <> '{keyValue}'";
            else
                return null;
            var entityReturn = _dbConnection.Query<TEntity>(query, commandType: CommandType.Text).FirstOrDefault();
            return entityReturn;
        }

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }
    }
}
