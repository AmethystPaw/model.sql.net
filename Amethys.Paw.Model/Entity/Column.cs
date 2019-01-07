using System;

namespace Amethyst.Paw.SQL.Model.Entity
{
    /// <summary>
    /// Колонка таблица.
    /// </summary>
    public class Column
    {

		private string _defaultValue;

        public Amethyst.Paw.SQL.Model.Entity.BasicType Type { get; private set; }
        public Sequence Sequence { get; set; }

        public string Name { get; set; }
        public string PhysicalName { get; set; }
		public bool HasDefaultValue { get; set; }
		public string DefaultValue
		{
			get
			{
				return _defaultValue;
			}

			set
			{
				HasDefaultValue = true;
				_defaultValue = value;
			}
		}

		public bool InPrimaryKey { get; set; }
        public bool Nullable { get; set; }
		public bool Unique { get; set; }

        public int Precision { get; set; }
        public int Scale { get; set; }

        public string Description { get; set; }

		public Column(string name, BasicType type)
		{
			this.Type = type;
			this.Name = name;
			this.PhysicalName = name;
			this.InPrimaryKey = false;
			this.Nullable = true;
			this.Unique = false;
			this.Description = null;
			this.DefaultValue = null;
			this.HasDefaultValue = false;
		}

        public override string ToString()
        {
            return Name;
        }

    }
}
