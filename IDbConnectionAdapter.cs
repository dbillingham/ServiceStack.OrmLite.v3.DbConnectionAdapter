namespace iSAMS.Api.Database
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Interface for database connection adapter.
    /// </summary>
    public interface IDbConnectionAdapter : IDbConnection
    {
        #region Public Methods and Operators

        IDbTransaction BeginTransaction();

        IDbTransaction BeginTransaction(IsolationLevel isolationLevel);

        List<T> ByExampleWhere<T>(object anonType);

        List<T> ByExampleWhere<T>(object anonType, bool excludeNulls);

        /// <summary>
        /// Alias for CreateTableIfNotExists
        /// </summary>
        void CreateTable<T>() where T : new();

        void CreateTable<T>(bool overwrite) where T : new();

        void CreateTable(bool overwrite, Type modelType);

        void CreateTableIfNotExists(params Type[] tableTypes);

        void CreateTableIfNotExists<T>() where T : new();

        void CreateTableIfNotExists(Type modelType);

        void CreateTables(bool overwrite, params Type[] tableTypes);

        void Delete<T>(params T[] objs) where T : new();

        void Delete<T>(string sqlFilter, params object[] filterParams) where T : new();

        void Delete(Type tableType, string sqlFilter, params object[] filterParams);

        void DeleteAll<T>(IEnumerable<T> objs) where T : new();

        void DeleteAll<T>();

        void DeleteAll(Type tableType);

        void DeleteById<T>(object id) where T : new();

        /// <summary>
        /// Performs a DeleteById() except argument is passed as a parameter to the generated SQL
        /// </summary>
        void DeleteByIdParam<T>(object id) where T : new();

        void DeleteByIds<T>(IEnumerable idValues) where T : new();

        /// <summary>
        /// Alias for GetDictionary
        /// </summary>
        Dictionary<K, V> Dictionary<K, V>(string sql, params object[] sqlParams);

        void DropAndCreateTable<T>() where T : new();

        void DropAndCreateTable(Type modelType);

        void DropAndCreateTables(params Type[] tableTypes);

        void DropTable(Type modelType);

        void DropTable<T>() where T : new();

        void DropTables(params Type[] tableTypes);

        IEnumerable<T> Each<T>();

        IEnumerable<T> Each<T>(string filter, params object[] filterParams);

        IEnumerable<T> EachWhere<T>(object anonType);

        int ExecuteNonQuery(string sql);

        int ExecuteNonQuery(string sql, object anonType);

        int ExecuteNonQuery(string sql, Dictionary<string, object> dict);

        void ExecuteProcedure<T>(T obj);

        int ExecuteSql(string sql);

        bool Exists<T>(string sqlFilter, params object[] filterParams);

        bool Exists<T>(object record);

        T First<T>(string filter, params object[] filterParams);

        T First<T>(string filter);

        T FirstOrDefault<T>(string filter, params object[] filterParams);

        T FirstOrDefault<T>(string filter);

        T GetById<T>(object idValue);

        T GetByIdOrDefault<T>(object idValue);

        /// <summary>
        /// Performs an GetById() except argument is passed as a parameter to the generated SQL
        /// </summary>
        T GetByIdParam<T>(object idValue);

        List<T> GetByIds<T>(IEnumerable idValues);

        Dictionary<K, V> GetDictionary<K, V>(string sql, params object[] sqlParams);

        List<T> GetFirstColumn<T>(string sql, params object[] sqlParams);

        HashSet<T> GetFirstColumnDistinct<T>(string sql, params object[] sqlParams);

        HashSet<T> GetHashSet<T>(string sql, params object[] sqlParams);

        long GetLastInsertId();

        string GetLastSql();

        List<T> GetList<T>(string sql, params object[] sqlParams);

        long GetLongScalar();

        Dictionary<K, List<V>> GetLookup<K, V>(string sql, params object[] sqlParams);

        T GetScalar<T>(string sql, params object[] sqlParams);

        bool HasChildren<T>(object record);

        /// <summary>
        /// Alias for GetHashSet
        /// </summary>
        HashSet<T> HashSet<T>(string sql, params object[] sqlParams);

        /// <summary>
        /// Alias for GetById
        /// </summary>
        T Id<T>(object idValue);

        /// <summary>
        /// Alias for GetByIds
        /// </summary>
        T IdOrDefault<T>(object idValue);

        /// <summary>
        /// Alias for GetByIds
        /// </summary>
        List<T> Ids<T>(IEnumerable idValues);

        void Insert<T>(params T[] objs) where T : new();

        void InsertAll<T>(IEnumerable<T> objs) where T : new();

        /// <summary>
        /// Performs an Insert() except arguments are passed as parameters to the generated SQL
        /// </summary>
        long InsertParam<T>(T obj, bool selectIdentity = false) where T : new();

        /// <summary>
        /// Alias for GetList
        /// </summary>
        List<T> List<T>(string sql, params object[] sqlParams);

        /// <summary>
        /// Alias for GetLookup
        /// </summary>
        Dictionary<K, List<V>> Lookup<K, V>(string sql, params object[] sqlParams);

        List<T> Query<T>(string sql);

        List<T> Query<T>(string sql, object anonType);

        List<T> Query<T>(string sql, Dictionary<string, object> dict);

        List<T> QueryByExample<T>(string sql, object anonType = null);

        T QueryById<T>(object value);

        IEnumerable<T> QueryEach<T>(string sql, object anonType = null);

        T QueryScalar<T>(object anonType);

        T QueryScalar<T>(string sql, object anonType = null);

        T QuerySingle<T>(object anonType);

        T QuerySingle<T>(string sql, object anonType = null);

        void Save<T>(T obj) where T : new();

        void Save<T>(params T[] objs) where T : new();

        void SaveAll<T>(IEnumerable<T> objs) where T : new();

        /// <summary>
        /// Alias for Scalar
        /// </summary>
        T Scalar<T>(string sql, params object[] sqlParams);

        List<T> Select<T>();

        List<T> Select<T>(string sqlFilter, params object[] filterParams);

        List<TModel> Select<TModel>(Type fromTableType);

        List<TModel> Select<TModel>(Type fromTableType, string sqlFilter, params object[] filterParams);

        List<TOutputModel> SelectFromProcedure<TOutputModel>(object fromObjWithProperties);

        List<TOutputModel> SelectFromProcedure<TOutputModel>(object fromObjWithProperties, string sqlFilter, params object[] filterParams) where TOutputModel : new();

        /// <summary>
        /// Alias for First
        /// </summary>
        T Single<T>(string filter, params object[] filterParams);

        /// <summary>
        /// Alias for First
        /// </summary>
        T Single<T>(string filter);

        /// <summary>
        /// Alias for FirstOrDefault
        /// </summary>
        T SingleOrDefault<T>(string filter, params object[] filterParams);

        /// <summary>
        /// Alias for FirstOrDefault
        /// </summary>
        T SingleOrDefault<T>(string filter);

        T SingleWhere<T>(string name, object value);

        List<T> SqlList<T>(string sql);

        List<T> SqlList<T>(string sql, object anonType);

        List<T> SqlList<T>(string sql, Dictionary<string, object> dict);

        T SqlScalar<T>(string sql, object anonType = null);

        T SqlScalar<T>(string sql, Dictionary<string, object> dict);

        bool TableExists(string tableName);

        void Update<T>(params T[] objs) where T : new();

        void UpdateAll<T>(IEnumerable<T> objs) where T : new();

        /// <summary>
        /// Performs an Update<T>() except arguments are passed as parameters to the generated SQL
        /// </summary>
        void UpdateParam<T>(T obj) where T : new();

        List<T> Where<T>(string name, object value);

        List<T> Where<T>(object anonType);

        List<T> Where<T>(System.Linq.Expressions.Expression<Func<T, bool>> Predicate);

        #endregion
    }
}