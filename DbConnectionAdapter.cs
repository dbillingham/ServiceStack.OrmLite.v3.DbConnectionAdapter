using System.Collections.Generic;
using System.Data;

using ServiceStack.OrmLite;

/// <summary>
/// Implementation for database connection wrapper class.
/// </summary>
public class DbConnectionAdapter : IDbConnectionAdapter
{
	#region Fields

	private readonly IDbConnection _connection;

	#endregion

	#region Constructors and Destructors

	public DbConnectionAdapter(IDbConnection connection)
	{
		this._connection = connection;
	}

	#endregion

	#region Public Properties

	public string ConnectionString
	{
		get
		{
			return this._connection.ConnectionString;
		}
		set
		{
			this._connection.ConnectionString = value;
		}
	}

	public int ConnectionTimeout
	{
		get
		{
			return this._connection.ConnectionTimeout;
		}
	}

	public string Database
	{
		get
		{
			return this._connection.Database;
		}
	}

	public System.Data.ConnectionState State
	{
		get
		{
			return this._connection.State;
		}
	}

	#endregion

	#region Public Methods and Operators

	public IDbTransaction BeginTransaction(IsolationLevel il)
	{
		return this._connection.BeginTransaction(il);
	}

	public IDbTransaction BeginTransaction()
	{
		return this._connection.BeginTransaction();
	}

	public List<T> ByExampleWhere<T>(object anonType)
	{
		return this._connection.ByExampleWhere<T>(anonType);
	}

	public List<T> ByExampleWhere<T>(object anonType, bool excludeNulls)
	{
		return this._connection.ByExampleWhere<T>(anonType, excludeNulls);
	}

	public void ChangeDatabase(string databaseName)
	{
		this._connection.ChangeDatabase(databaseName);
	}

	public void Close()
	{
		this._connection.Close();
	}

	public IDbCommand CreateCommand()
	{
		return this._connection.CreateCommand();
	}

	public void CreateTable<T>() where T : new()
	{
		this._connection.CreateTable<T>();
	}

	public void CreateTable<T>(bool overwrite) where T : new()
	{
		this._connection.CreateTable<T>(overwrite);
	}

	public void CreateTable(bool overwrite, System.Type modelType)
	{
		this._connection.CreateTable(overwrite, modelType);
	}

	public void CreateTableIfNotExists(params System.Type[] tableTypes)
	{
		this._connection.CreateTableIfNotExists(tableTypes);
	}

	public void CreateTableIfNotExists<T>() where T : new()
	{
		this._connection.CreateTableIfNotExists<T>();
	}

	public void CreateTableIfNotExists(System.Type modelType)
	{
		this._connection.CreateTableIfNotExists(modelType);
	}

	public void CreateTables(bool overwrite, params System.Type[] tableTypes)
	{
		this._connection.CreateTables(overwrite, tableTypes);
	}

	public void Delete<T>(params T[] objs) where T : new()
	{
		this._connection.Delete(objs);
	}

	public void Delete<T>(string sqlFilter, params object[] filterParams) where T : new()
	{
		this._connection.Delete<T>(sqlFilter, filterParams);
	}

	public void Delete(System.Type tableType, string sqlFilter, params object[] filterParams)
	{
		this._connection.Delete(tableType, sqlFilter, filterParams);
	}

	public void DeleteAll<T>(IEnumerable<T> objs) where T : new()
	{
		this._connection.DeleteAll(objs);
	}

	public void DeleteAll<T>()
	{
		this._connection.DeleteAll<T>();
	}

	public void DeleteAll(System.Type tableType)
	{
		this._connection.DeleteAll(tableType);
	}

	public void DeleteById<T>(object id) where T : new()
	{
		this._connection.DeleteById<T>(id);
	}

	public void DeleteByIdParam<T>(object id) where T : new()
	{
		this._connection.DeleteByIdParam<T>(id);
	}

	public void DeleteByIds<T>(System.Collections.IEnumerable idValues) where T : new()
	{
		this._connection.DeleteByIds<T>(idValues);
	}

	public Dictionary<K, V> Dictionary<K, V>(string sql, params object[] sqlParams)
	{
		return this._connection.Dictionary<K, V>(sql, sqlParams);
	}

	public void Dispose()
	{
		this._connection.Dispose();
	}

	public void DropAndCreateTable<T>() where T : new()
	{
		this._connection.DropAndCreateTable<T>();
	}

	public void DropAndCreateTable(System.Type modelType)
	{
		this._connection.DropAndCreateTable(modelType);
	}

	public void DropAndCreateTables(params System.Type[] tableTypes)
	{
		this._connection.DropAndCreateTables(tableTypes);
	}

	public void DropTable(System.Type modelType)
	{
		this._connection.DropTable(modelType);
	}

	public void DropTable<T>() where T : new()
	{
		this._connection.DropTable<T>();
	}

	public void DropTables(params System.Type[] tableTypes)
	{
		this._connection.DropTables(tableTypes);
	}

	public IEnumerable<T> Each<T>()
	{
		return this._connection.Each<T>();
	}

	public IEnumerable<T> Each<T>(string filter, params object[] filterParams)
	{
		return this._connection.Each<T>(filter, filterParams);
	}

	public IEnumerable<T> EachWhere<T>(object anonType)
	{
		return this._connection.EachWhere<T>(anonType);
	}

	public int ExecuteNonQuery(string sql)
	{
		return this._connection.ExecuteNonQuery(sql);
	}

	public int ExecuteNonQuery(string sql, object anonType)
	{
		return this._connection.ExecuteNonQuery(sql, anonType);
	}

	public int ExecuteNonQuery(string sql, Dictionary<string, object> dict)
	{
		return this._connection.ExecuteNonQuery(sql, dict);
	}

	public void ExecuteProcedure<T>(T obj)
	{
		this._connection.ExecuteProcedure(obj);
	}

	public int ExecuteSql(string sql)
	{
		return this._connection.ExecuteSql(sql);
	}

	public bool Exists<T>(string sqlFilter, params object[] filterParams)
	{
		return this._connection.Exists<T>(sqlFilter, filterParams);
	}

	public bool Exists<T>(object record)
	{
		return this._connection.Exists<T>(record);
	}

	public T First<T>(string filter, params object[] filterParams)
	{
		return this._connection.First<T>(filter, filterParams);
	}

	public T First<T>(string filter)
	{
		return this._connection.First<T>(filter);
	}

	public T FirstOrDefault<T>(string filter, params object[] filterParams)
	{
		return this._connection.FirstOrDefault<T>(filter, filterParams);
	}

	public T FirstOrDefault<T>(string filter)
	{
		return this._connection.FirstOrDefault<T>(filter);
	}

	public T GetById<T>(object idValue)
	{
		return this._connection.GetById<T>(idValue);
	}

	public T GetByIdOrDefault<T>(object idValue)
	{
		return this._connection.GetByIdOrDefault<T>(idValue);
	}

	public T GetByIdParam<T>(object idValue)
	{
		return this._connection.GetByIdParam<T>(idValue);
	}

	public List<T> GetByIds<T>(System.Collections.IEnumerable idValues)
	{
		return this._connection.GetByIds<T>(idValues);
	}

	public Dictionary<K, V> GetDictionary<K, V>(string sql, params object[] sqlParams)
	{
		return this._connection.GetDictionary<K, V>(sql, sqlParams);
	}

	public List<T> GetFirstColumn<T>(string sql, params object[] sqlParams)
	{
		return this._connection.GetFirstColumn<T>(sql, sqlParams);
	}

	public HashSet<T> GetFirstColumnDistinct<T>(string sql, params object[] sqlParams)
	{
		return this._connection.GetFirstColumnDistinct<T>(sql, sqlParams);
	}

	public HashSet<T> GetHashSet<T>(string sql, params object[] sqlParams)
	{
		return this._connection.GetHashSet<T>(sql, sqlParams);
	}

	public long GetLastInsertId()
	{
		return this._connection.GetLastInsertId();
	}

	public string GetLastSql()
	{
		return this._connection.GetLastSql();
	}

	public List<T> GetList<T>(string sql, params object[] sqlParams)
	{
		return this._connection.GetList<T>(sql, sqlParams);
	}

	public long GetLongScalar()
	{
		return this._connection.GetLongScalar();
	}

	public Dictionary<K, List<V>> GetLookup<K, V>(string sql, params object[] sqlParams)
	{
		return this._connection.GetLookup<K, V>(sql, sqlParams);
	}

	public T GetScalar<T>(string sql, params object[] sqlParams)
	{
		return this._connection.GetScalar<T>(sql, sqlParams);
	}

	public bool HasChildren<T>(object record)
	{
		return this._connection.HasChildren<T>(record);
	}

	public HashSet<T> HashSet<T>(string sql, params object[] sqlParams)
	{
		return this._connection.HashSet<T>(sql, sqlParams);
	}

	public T Id<T>(object idValue)
	{
		return this._connection.Id<T>(idValue);
	}

	public T IdOrDefault<T>(object idValue)
	{
		return this._connection.IdOrDefault<T>(idValue);
	}

	public List<T> Ids<T>(System.Collections.IEnumerable idValues)
	{
		return this._connection.Ids<T>(idValues);
	}

	public void Insert<T>(params T[] objs) where T : new()
	{
		this._connection.Insert(objs);
	}

	public void InsertAll<T>(IEnumerable<T> objs) where T : new()
	{
		this._connection.InsertAll(objs);
	}

	public long InsertParam<T>(T obj, bool selectIdentity = false) where T : new()
	{
		return this._connection.InsertParam(obj, selectIdentity);
	}

	public List<T> List<T>(string sql, params object[] sqlParams)
	{
		return this._connection.List<T>(sql, sqlParams);
	}

	public Dictionary<K, List<V>> Lookup<K, V>(string sql, params object[] sqlParams)
	{
		return this._connection.Lookup<K, V>(sql, sqlParams);
	}

	public void Open()
	{
		this._connection.Open();
	}

	public List<T> Query<T>(string sql)
	{
		return this._connection.Query<T>(sql);
	}

	public List<T> Query<T>(string sql, object anonType)
	{
		return this._connection.Query<T>(sql, anonType);
	}

	public List<T> Query<T>(string sql, Dictionary<string, object> dict)
	{
		return this._connection.Query<T>(sql, dict);
	}

	public List<T> QueryByExample<T>(string sql, object anonType = null)
	{
		return this._connection.QueryByExample<T>(sql, anonType);
	}

	public T QueryById<T>(object value)
	{
		return this._connection.QueryById<T>(value);
	}

	public IEnumerable<T> QueryEach<T>(string sql, object anonType = null)
	{
		return this._connection.QueryEach<T>(sql, anonType);
	}

	public T QueryScalar<T>(object anonType)
	{
		return this._connection.QueryScalar<T>(anonType);
	}

	public T QueryScalar<T>(string sql, object anonType = null)
	{
		return this._connection.QueryScalar<T>(sql, anonType);
	}

	public T QuerySingle<T>(object anonType)
	{
		return this._connection.QuerySingle<T>(anonType);
	}

	public T QuerySingle<T>(string sql, object anonType = null)
	{
		return this._connection.QuerySingle<T>(sql, anonType);
	}

	public void Save<T>(T obj) where T : new()
	{
		this._connection.Save(obj);
	}

	public void Save<T>(params T[] objs) where T : new()
	{
		this._connection.Save(objs);
	}

	public void SaveAll<T>(IEnumerable<T> objs) where T : new()
	{
		this._connection.SaveAll(objs);
	}

	public T Scalar<T>(string sql, params object[] sqlParams)
	{
		return this._connection.Scalar<T>(sql, sqlParams);
	}

	public List<T> Select<T>()
	{
		return this._connection.Select<T>();
	}

	public List<T> Select<T>(string sqlFilter, params object[] filterParams)
	{
		return this._connection.Select<T>(sqlFilter, filterParams);
	}

	public List<TModel> Select<TModel>(System.Type fromTableType)
	{
		return this._connection.Select<TModel>(fromTableType);
	}

	public List<TModel> Select<TModel>(System.Type fromTableType, string sqlFilter, params object[] filterParams)
	{
		return this._connection.Select<TModel>(fromTableType, sqlFilter, filterParams);
	}

	public List<TOutputModel> SelectFromProcedure<TOutputModel>(object fromObjWithProperties)
	{
		return this._connection.SelectFromProcedure<TOutputModel>(fromObjWithProperties);
	}

	public List<TOutputModel> SelectFromProcedure<TOutputModel>(object fromObjWithProperties, string sqlFilter, params object[] filterParams) where TOutputModel : new()
	{
		return this._connection.SelectFromProcedure<TOutputModel>(fromObjWithProperties, sqlFilter, filterParams);
	}

	public T Single<T>(string filter, params object[] filterParams)
	{
		return this._connection.Single<T>(filter, filterParams);
	}

	public T Single<T>(string filter)
	{
		return this._connection.Single<T>(filter);
	}

	public T SingleOrDefault<T>(string filter, params object[] filterParams)
	{
		return this._connection.SingleOrDefault<T>(filter, filterParams);
	}

	public T SingleOrDefault<T>(string filter)
	{
		return this._connection.SingleOrDefault<T>(filter);
	}

	public T SingleWhere<T>(string name, object value)
	{
		return this._connection.SingleWhere<T>(name, value);
	}

	public List<T> SqlList<T>(string sql)
	{
		return this._connection.SqlList<T>(sql);
	}

	public List<T> SqlList<T>(string sql, object anonType)
	{
		return this._connection.SqlList<T>(sql, anonType);
	}

	public List<T> SqlList<T>(string sql, Dictionary<string, object> dict)
	{
		return this._connection.SqlList<T>(sql, dict);
	}

	public T SqlScalar<T>(string sql, object anonType = null)
	{
		return this._connection.SqlScalar<T>(sql, anonType);
	}

	public T SqlScalar<T>(string sql, Dictionary<string, object> dict)
	{
		return this._connection.SqlScalar<T>(sql, dict);
	}

	public bool TableExists(string tableName)
	{
		return this._connection.TableExists(tableName);
	}

	public void Update<T>(params T[] objs) where T : new()
	{
		this._connection.Update(objs);
	}

	public void UpdateAll<T>(IEnumerable<T> objs) where T : new()
	{
		this._connection.UpdateAll(objs);
	}

	public void UpdateParam<T>(T obj) where T : new()
	{
		this._connection.UpdateParam(obj);
	}

	public List<T> Where<T>(string name, object value)
	{
		return this._connection.Where<T>(name, value);
	}

	public List<T> Where<T>(object anonType)
	{
		return this._connection.Where<T>(anonType);
	}

	public List<T> Where<T>(System.Linq.Expressions.Expression<System.Func<T, bool>> Predicate)
	{
		return this._connection.Where(Predicate);
	}

	#endregion
}