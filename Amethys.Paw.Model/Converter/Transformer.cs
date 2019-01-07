using Amethyst.Paw.SQL.Model.Entity;

namespace Amethyst.Paw.SQL.Model.Converter
{
    public abstract class Transformer
    {

		public ProjectContext Context { get; set; }

		public Transformer(ProjectContext defaultContext)
		{
			this.Context = defaultContext;
		}

		public abstract string All();

        public string GenerateProject(Project project)
		{
			return GenerateProject(Context, project);
		}
		public abstract string GenerateProject(ProjectContext context, Project project);

		public string GenerateColumn(Column column)
		{
			return GenerateColumn(Context, column);
		}
		public abstract string GenerateColumn(ProjectContext context, Column column);

		public string GenerateTable(Table table)
		{
			return GenerateTable(Context, table);
		}
		public string GenerateTable(ProjectContext context, Table table)
		{
			return GenerateTable(Context, null, table);
		}
		public string GenerateTable(Schema schema, Table table)
		{
			return GenerateTable(Context, schema, table);
		}
		public abstract string GenerateTable(ProjectContext context, Schema schema, Table table);
	}
}