using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
    public class Index
    {

        public string Name { get; set; }
        public string PhysicalName { get; set; }

        public bool Unique { get; set; }

        public IList<Column> Columns { get; private set; }

    }
}
