using Amethyst.Paw.SQL.Model.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model
{
	public class ProjectContext
	{

		public NameCase KeywordNameCase { get; set; }
		
		public NameCase SchemeNameCase { get; set; }
		public NameCase TableNameCase { get; set; }
		public NameCase ColumnNameCase { get; set; }
		public NameCase TypeNameCase { get; set; }

		public ProjectContext()
		{
			this.KeywordNameCase = NameCase.UpperCase;
			this.SchemeNameCase = NameCase.CamelCase;
			this.TableNameCase = NameCase.CamelCase;
			this.ColumnNameCase = NameCase.CamelCase;
			this.TypeNameCase = NameCase.UpperCase;
		}

		public string TransformKeyword(string keyword)
		{
			switch (KeywordNameCase)
			{
				case NameCase.UpperCase: return keyword.ToUpper();
				case NameCase.LowerCase: return keyword.ToLower();
				default: return keyword;
			}
		}

		public string TransformScheme(string scheme)
		{
			switch (SchemeNameCase)
			{
				case NameCase.UpperCase: return scheme.ToUpper();
				case NameCase.LowerCase: return scheme.ToLower();
				default: return scheme;
			}
		}

		public string TransformTable(string table)
		{
			switch (TableNameCase)
			{
				case NameCase.UpperCase: return table.ToUpper();
				case NameCase.LowerCase: return table.ToLower();
				default: return table;
			}
		}

		public string TransformColumn(string column)
		{
			switch (ColumnNameCase)
			{
				case NameCase.UpperCase: return column.ToUpper();
				case NameCase.LowerCase: return column.ToLower();
				default: return column;
			}
		}

		public string TransformType(string type)
		{
			switch (TypeNameCase)
			{
				case NameCase.UpperCase: return type.ToUpper();
				case NameCase.LowerCase: return type.ToLower();
				default: return type;
			}
		}

	}
}
