using System.Web.UI;

namespace HansKindberg.Web.UI
{
	public class StringItemControl : ItemControl<string>
	{
		#region Constructors

		public StringItemControl(string value) : base(value) {}

		#endregion
	}

	public class IntegerItemControl : ItemControl<int>
	{
		#region Constructors

		public IntegerItemControl(int value) : base(value) {}

		#endregion
	}

	public class ItemControl<T> : Control, INamingContainer
	{
		#region Fields

		private readonly T _value;

		#endregion

		#region Constructors

		public ItemControl(T value)
		{
			this._value = value;
		}

		#endregion

		#region Properties

		public virtual T Value
		{
			get { return this._value; }
		}

		#endregion
	}
}