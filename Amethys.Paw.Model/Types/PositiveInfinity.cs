using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Types
{
	public class PositiveInfinity<T> : Amethyst.Paw.SQL.Model.Entity.Type<T>
	{

		public Type Owner { get; private set; }

		public PositiveInfinity() : base("infinity", true)
		{
			this.Owner = typeof(T);
		}

	}
}
