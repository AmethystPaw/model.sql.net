using Amethyst.Paw.SQL.Model;
using Amethyst.Paw.SQL.Model.Context;
using Amethyst.Paw.SQL.Model.Converter;
using Amethyst.Paw.SQL.Model.Entity;
using Amethyst.Paw.SQL.Postgres.Types;
using System;
using System.Linq;
using Xunit;

namespace Amethyst.Paw.SQL.Postgres.Test
{
	public class ColumnGeneratorTest
	{

		private readonly Column Column = new Column("Test Column", new Numeric(3))
		{
			Description = "Тестовая колонка",
			PhysicalName = "testColumn",
			Nullable = true,
			InPrimaryKey = true
		};

		private readonly Column ColumnNull = new Column("Test Column", new Numeric(3))
		{
			Description = "Тестовая колонка NULL",
			PhysicalName = "testColumnNull",
			DefaultValue = "null",
			Nullable = true,
			InPrimaryKey = true
		};

		[Fact]
		public void CreateColumnUpper()
		{
			Project project = new PostgresProject();
			Transformer transformer = project.Transformer();

			var result = transformer.GenerateColumn(Column);
			Console.WriteLine(result);
			Assert.Equal("testColumn NUMERIC PRIMARY KEY", result);
		}

		[Fact]
		public void CreateColumnLower()
		{
			Project project = new PostgresProject();
			Transformer transformer = project.Transformer();

			ProjectContext context = new ProjectContext
			{
				KeywordNameCase = NameCase.LowerCase,
				TypeNameCase = NameCase.LowerCase
			};

			var result = transformer.GenerateColumn(context, Column);
			Console.WriteLine(result);
			Assert.Equal("testColumn numeric primary key", result);
		}

		[Fact]
		public void DefaultNull()
		{
			Project project = new PostgresProject();
			Transformer transformer = project.Transformer();

			var result = transformer.GenerateColumn(ColumnNull);
			Console.WriteLine(result);
			Assert.Equal("testColumnNull NUMERIC PRIMARY KEY DEFAULT NULL", result);
		}

		//[Fact]
		//public void DefaultNullString()
		//{

		//}
	}
}
