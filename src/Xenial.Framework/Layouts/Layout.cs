﻿#pragma warning disable CA1724 //Conflicts with Winforms: Should not conflict in practice

using System;
using System.Linq.Expressions;

using DevExpress.ExpressApp.Layout;

using Xenial.Framework.Layouts.Items;
using Xenial.Framework.Layouts.Items.LeafNodes;

#pragma warning disable CA1822 //By design for fluent interface

namespace Xenial.Framework.Layouts
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial class LayoutBuilder<TModelClass> : LayoutBuilder
        where TModelClass : class
    {
        /// <summary>
        /// Properties the editor.
        /// </summary>
        /// <typeparam name="TProperty">The type of the t property.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutPropertyEditorItem&lt;TModelClass&gt;.</returns>
        /// <autogeneratedoc />
        public LayoutPropertyEditorItem<TModelClass> PropertyEditor<TProperty>(Expression<Func<TModelClass, TProperty>> expression)
            => LayoutPropertyEditorItem<TModelClass>.CreatePropertyEditor(expression);
    }

    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial class LayoutBuilder
    {
        /// <summary>
        /// Properties the editor.
        /// </summary>
        /// <typeparam name="TModelClass">The type of the t model class.</typeparam>
        /// <typeparam name="TProperty">The type of the t property.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutPropertyEditorItem&lt;TModelClass&gt;.</returns>
        public LayoutPropertyEditorItem<TModelClass> PropertyEditor<TModelClass, TProperty>(Expression<Func<TModelClass, TProperty>> expression)
            where TModelClass : class
            => LayoutPropertyEditorItem<TModelClass>.CreatePropertyEditor(expression);

        /// <summary>
        /// Empties the space item.
        /// </summary>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutEmptySpaceItem.</returns>
        /// <autogeneratedoc />
        public LayoutEmptySpaceItem EmptySpaceItem()
            => LayoutEmptySpaceItem.Create();

        /// <summary>
        /// Empties the space item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutEmptySpaceItem.</returns>
        /// <autogeneratedoc />
        public LayoutEmptySpaceItem EmptySpaceItem(string id)
            => LayoutEmptySpaceItem.Create(id);

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public LayoutGroupItem LayoutGroup()
            => LayoutGroupItem.Create();

        /// <summary>
        /// Creates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public LayoutGroupItem LayoutGroup(string id)
            => LayoutGroupItem.Create(id);

        /// <summary>
        /// Creates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="flowDirection">The flow direction.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public LayoutGroupItem LayoutGroup(string id, FlowDirection flowDirection)
            => LayoutGroupItem.Create(id, flowDirection);

        /// <summary>
        /// Horizontals the group.
        /// </summary>
        /// <returns>HorizontalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem HorizontalGroup()
            => HorizontalLayoutGroupItem.Create();

        /// <summary>
        /// Horizontals the group.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>HorizontalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem HorizontalGroup(string id)
            => HorizontalLayoutGroupItem.Create(id);

        /// <summary>
        /// Verticals the group.
        /// </summary>
        /// <returns>VerticalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public VerticalLayoutGroupItem VerticalGroup()
            => VerticalLayoutGroupItem.Create();

        /// <summary>
        /// Verticals the group.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>VerticalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public VerticalLayoutGroupItem VerticalGroup(string id)
            => VerticalLayoutGroupItem.Create(id);

        /// <summary>
        /// Tabbeds the group.
        /// </summary>
        /// <returns>LayoutTabbedGroupItem.</returns>
        /// <autogeneratedoc />
        public LayoutTabbedGroupItem TabbedGroup()
            => LayoutTabbedGroupItem.Create();

        /// <summary>
        /// Tabbeds the group.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>LayoutTabbedGroupItem.</returns>
        /// <autogeneratedoc />
        public LayoutTabbedGroupItem TabbedGroup(string id)
            => LayoutTabbedGroupItem.Create(id);
    }
}
