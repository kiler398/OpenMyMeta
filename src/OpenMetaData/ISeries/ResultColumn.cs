using System;
using System.Data;
using System.Data.OleDb;

namespace OMeta.ISeries
{
 
	public class ISeriesResultColumn : ResultColumn
	{
		public ISeriesResultColumn()
		{

		}

		#region Properties

		override public string Alias
		{
			get
			{
				return name;
			}
		}

		override public string DataTypeName
		{
			get
			{
				return typeName;
			}
		}

		override public System.Int32 Ordinal
		{
			get
			{
				return ordinal;
			}
		}

		internal string name = "";
		internal string typeName = "";
		internal System.Int32 ordinal = 0;

		#endregion
	}
}
