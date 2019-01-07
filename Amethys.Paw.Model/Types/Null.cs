using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Types
{
	public class Null<T> : Amethyst.Paw.SQL.Model.Entity.Type<T>
	{

		public Type Owner { get; private set; }

		public Null() : base("null", true)
		{
			Owner = typeof(T);
		}

	}
}
