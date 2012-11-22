using System.Collections.Generic;

namespace WebApplication
{
	public partial class Default : System.Web.UI.Page
	{
		#region Fields

		private readonly IEnumerable<int> _integerDataSource = new[] {1, 2, 3, 4};
		private readonly IEnumerable<string> _stringDataSource = new[] {"A", "B", "C", "D"};

		#endregion

		#region Properties

		protected virtual IEnumerable<int> IntegerDataSource
		{
			get { return this._integerDataSource; }
		}

		protected virtual IEnumerable<string> StringDataSource
		{
			get { return this._stringDataSource; }
		}

		#endregion

		#region Eventhandlers

		protected override void OnPreRender(System.EventArgs e)
		{
			this.stringTemplatedControl.DataBind();
			this.integerTemplatedControl.DataBind();

			base.OnPreRender(e);
		}

		#endregion
	}
}