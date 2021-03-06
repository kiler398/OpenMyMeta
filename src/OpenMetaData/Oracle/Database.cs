using System;
using System.Data;
using System.Data.OleDb;

namespace OMeta.Oracle
{
 
	public class OracleDatabase : Database
	{
		public OracleDatabase()
		{

		}

		override public DataSet ExecuteSql(string sql)
		{
			OleDbConnection cn = new OleDbConnection(dbRoot.ConnectionString);
			cn.Open();
			//cn.ChangeDatabase(this.Name);

			return this.ExecuteIntoRecordset(sql, cn);
		}

		public override string Name
		{
			get
			{
				object o = _row["SCHEMA_NAME"];

				if(DBNull.Value == o)
				{
					return string.Empty;
				}
				else
				{
					return (string)o;
				}
			}
		}

	}
}
