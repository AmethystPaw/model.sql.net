using Amethyst.Paw.SQL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amethyst.Paw.SQL.Model.Converter
{
    public abstract class TypeConverter<T>
    {
					
        public abstract T Convert(string value);

        public abstract string Restore(T value, Column column);

    }
}
