using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
    public class Table
    {

        public string Name { get; set; }
        public string PhysicalName { get; set; }
		public string Description { get; set; }

        public IList<Column> Columns { get; private set; }
        public IList<Index> Indecies { get; private set; }
        public IList<ForeignKey> ForeignKeys { get; private set; }

        public Table()
        {
            Name = null;
            PhysicalName = null;
            Columns = new List<Column>();
            Indecies = new List<Index>();
            ForeignKeys = new List<ForeignKey>();
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
