using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Types
{
	public class NaN<T> : Amethyst.Paw.SQL.Model.Entity.Type<T>
	{

		public Type Owner { get; private set; }

		public NaN() : base("NaN", true)
		{
			Owner = typeof(T);
		}

	}
}
