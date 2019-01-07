using System;
using System.Collections.Generic;
using System.Text;

namespace Amethyst.Paw.SQL.Model.Entity
{
	public class BasicType
	{

		public string Name { get; private set; }

		public bool IsNumber { get; private set; }

		public BasicType(string name, bool isNumber)
		{
			this.Name = name;
			this.IsNumber = isNumber;
		}

	}
}
