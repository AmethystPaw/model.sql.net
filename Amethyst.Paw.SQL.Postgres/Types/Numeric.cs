using Amethyst.Paw.SQL.Model.Converter;
using Amethyst.Paw.SQL.Model.Entity;
using Amethyst.Paw.SQL.Model.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Postgres.Types
{
	public class Numeric : Amethyst.Paw.SQL.Model.Entity.Type<Numeric>
	{

		public static int MAX_PRECISION = 131072;
		public static int MAX_SCALE = 163383;

		public static NaN<Numeric> NaN = new NaN<Numeric>();

		public int Precision { get; set; }
		public int Scale { get; set; }

		public Numeric() : this(-1, -1)
		{
		}

		public Numeric(int precision) : this(precision, 0)
		{
		}

		public Numeric(int precision, int scale) : base("NUMERIC", true, new NumericConverter())
		{
			this.Precision = precision;
			this.Scale = scale;
		}

		public class NumericConverter : TypeConverter<Numeric>
		{
			public override Numeric Convert(string value)
			{
				value = value.ToUpper();
				if (!value.StartsWith("NUMERIC"))
					throw new InvalidCastException(value);
				if (value.EndsWith("NUMERIC"))
					return new Numeric();
				int index = value.IndexOf(",");
				if (index == -1)
					return new Numeric(int.Parse(value.Substring(7, value.Length - 1 - 7)));
				else
					return new Numeric(
						int.Parse(value.Substring(7, index - 7)),
						int.Parse(value.Substring(index + 1, value.Length - 1 - index))
					);

			}

			public override string Restore(Numeric value, Column column)
			{
				throw new NotImplementedException();
			}
		}
	}
}
