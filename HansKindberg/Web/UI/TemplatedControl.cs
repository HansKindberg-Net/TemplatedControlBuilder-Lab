using System;
using System.ComponentModel;
using System.Web.UI;

namespace HansKindberg.Web.UI
{
	public class StringTemplatedControl : TemplatedControl<StringItemControl> {}

	public class IntegerTemplatedControl : TemplatedControl<IntegerItemControl> {}

	[ControlBuilder(typeof(TemplatedControlBuilder))]
	[ParseChildren(ChildrenAsProperties = true), PersistChildren(false)]
	public abstract class TemplatedControl<TTemplateContainer> : Control, INamingContainer where TTemplateContainer : Control, INamingContainer
	{
		#region Properties

		[Category("Information")]
		public virtual object DataSource { get; set; }

		[Category("Information"), TemplateContainer(typeof(string))]
		public virtual ITemplate ItemTemplate { get; set; }

		#endregion

		#region Methods

		protected internal virtual void AddTemplate(Control container, ITemplate template)
		{
			if(container == null)
				throw new ArgumentNullException("container");

			if(template == null)
				throw new ArgumentNullException("template");

			template.InstantiateIn(container);
			this.Controls.Add(container);
		}

		protected override void CreateChildControls()
		{
			//if(this.ItemTemplate != null)
			//	this.AddTemplate(new );
		}

		#endregion
	}
}