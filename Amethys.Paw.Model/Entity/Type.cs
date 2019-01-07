using Amethyst.Paw.SQL.Model.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
    public class Type<T> : BasicType
    {

        public TypeConverter<T> Converter { get; private set; }

        public Type(string Name, bool IsNumber) : this(Name, IsNumber, null)
        {
        }

        public Type(string name, bool isNumber, TypeConverter<T> Converter) : base(name, isNumber)
        {
			this.Converter = Converter;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
