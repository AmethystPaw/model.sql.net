using Amethyst.Paw.SQL.Model;
using Amethyst.Paw.SQL.Model.Converter;
using Amethyst.Paw.SQL.Model.Entity;
using Amethyst.Paw.SQL.Postgres.Types;
using System;
using System.Linq;
using Xunit;

namespace Amethyst.Paw.SQL.Postgres.Test
{
	public class TableGeneratorTest
	{

		private Table table;

		public TableGeneratorTest()
		{
			table = new Table
			{
				Name = "Test Table",
				PhysicalName = "TestTable"
			};
			table.Columns.Add(new Column("column_1", new Numeric(4, 1)));
		}

		[Fact]
		public void CreateTable()
		{
			Project project = new PostgresProject();
			Transformer transformer = project.Transformer();

			var result = transformer.GenerateTable(table);
			Console.WriteLine(result);
			Assert.Equal("CREATE TestTable (\n\tcolumn_1 NUMERIC\n);", result);
		}
	}
}
