using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
    public class ForeignKey
    {

        public string Name { get; private set; }

        public IList<Column> FromColumn { get; private set; }
        public IList<Column> ToColumn { get; private set; }
        public Table Target { get; set; }

    }
}
