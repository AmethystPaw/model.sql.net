using Amethyst.Paw.SQL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model
{
    class Database
    {

        public IList<Schema> Schema { get; private set; }

        public Database(): this(new List<Schema>())
        {
        }

        public Database(IList<Schema> schema)
        {
            Schema = schema;
        }
    }
}
