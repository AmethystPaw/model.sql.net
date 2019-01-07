using Amethyst.Paw.SQL.Model;
using Amethyst.Paw.SQL.Model.Converter;
using Amethyst.Paw.SQL.Postgres.Generator;

namespace Amethyst.Paw.SQL.Postgres
{
    public class PostgresProject : Project
    {
        public override Transformer Transformer()
        {
			return new PostgresTransformer();
        }
    }
}