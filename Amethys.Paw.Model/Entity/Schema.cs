using Amethyst.Paw.SQL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
    public class Schema
    {

		public string Name { get; set; }

        public IList<Table> Tables { get; private set; }

        public Schema(string name, IList<Table> tables)
        {
			Name = name;
            Tables = tables;
        }

        public Schema() : this(null, new List<Table>())
        {
        }

		public override string ToString()
		{
			return Name;
		}
	}
}
