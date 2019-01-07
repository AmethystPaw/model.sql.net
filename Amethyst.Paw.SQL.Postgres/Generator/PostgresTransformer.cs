using Amethyst.Paw.SQL.Model;
using Amethyst.Paw.SQL.Model.Converter;
using Amethyst.Paw.SQL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Postgres.Generator
{
	public class PostgresTransformer : Transformer
	{

		public PostgresTransformer() : base(new ProjectContext())
		{
		}

		public PostgresTransformer(ProjectContext context) : base(context)
		{
		}

		public override string All()
		{
			throw new NotImplementedException();
		}

		public override string GenerateColumn(ProjectContext context, Column column)
		{
			StringBuilder rs = new StringBuilder();

			rs.Append(context.TransformTable(column.PhysicalName));
			rs.Append(" ");
			rs.Append(context.TransformType(column.Type.Name));

			if (!column.Nullable)
				rs.Append(context.TransformKeyword(" not null"));

			if (column.InPrimaryKey)
				rs.Append(context.TransformKeyword(" Primary Key"));

			if (column.Unique)
				rs.Append(context.TransformKeyword(" Unique"));

			if (column.HasDefaultValue)
				rs.Append(context.TransformKeyword(" Default "))
					.Append(column.DefaultValue == null
						? context.TransformKeyword("null")
						: context.TransformKeyword(column.DefaultValue));

			return rs.ToString();
		}

		public override string GenerateProject(ProjectContext context, Project project)
		{
			throw new NotImplementedException();
		}

		public override string GenerateTable(ProjectContext context, Schema schema, Table table)
		{
			StringBuilder res = new StringBuilder();

			res.Append(context.TransformKeyword("create "));
			if (schema != null)
				res
					.Append(context.TransformScheme(schema.Name))
					.Append(".");
			res.Append(context.TransformTable(table.PhysicalName));
			res.Append(" (\n");

			char intend = '\t';
			foreach (Column col in table.Columns)
			{
				res.Append(intend);
				res.Append(GenerateColumn(context, col));
				res.Append(',');
				res.Append('\n');
			}

			if (table.Columns.Count > 0)
				res.Remove(res.Length - 2, 2);

			res.Append('\n');
			res.Append(");");

			return res.ToString();
		}
	}
}
