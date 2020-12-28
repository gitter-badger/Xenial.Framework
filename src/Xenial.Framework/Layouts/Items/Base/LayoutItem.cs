﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#pragma warning disable CA1710 //Rename Type to end in Collection -> By Design
#pragma warning disable CA2227 //Collection fields should not have a setter: By Design

namespace Xenial.Framework.Layouts.Items.Base
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial record LayoutItem : LayoutItemNode, ICollection<LayoutItemNode>, IEnumerable<LayoutItemNode>
    {
        /// <summary>
        /// Gets the is leaf.
        /// </summary>
        /// <value>The is leaf.</value>
        /// <autogeneratedoc />
        internal override bool IsLeaf => false;

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        /// <autogeneratedoc />
        internal protected LinkedList<LayoutItemNode> ChildNodes { get; internal set; } = new();

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        /// <autogeneratedoc />
        public virtual ICollection<LayoutItemNode> Children => ChildNodes;

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <autogeneratedoc />
        public int Count => ChildNodes.Count;

        /// <summary>
        /// Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        /// <autogeneratedoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds the specified node.
        /// </summary>
        /// <param name="item">The node.</param>
        /// <autogeneratedoc />
        public void Add(LayoutItemNode item)
        {
            _ = item ?? throw new ArgumentNullException(nameof(item));

            if (!Equals(item.Parent))
            {
                item.Parent = this;
            }
            if (!ChildNodes.Contains(item))
            {
                ChildNodes.AddLast(item);
            }
        }

        /// <summary>
        /// Adds the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <autogeneratedoc />
        public void Add(params LayoutItemNode[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Removes the specified node.
        /// </summary>
        /// <param name="item">The node.</param>
        /// <autogeneratedoc />
        public bool Remove(LayoutItemNode item)
        {
            _ = item ?? throw new ArgumentNullException(nameof(item));

            if (ChildNodes.Contains(item))
            {
                var value = ChildNodes.Remove(item);
                item.Parent = null;
                return value;
            }
            return false;
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>System.Collections.Generic.IEnumerator&lt;Xenial.Framework.Layouts.Items.Base.LayoutItemNode&gt;.</returns>
        /// <autogeneratedoc />
        public IEnumerator<LayoutItemNode> GetEnumerator() => ChildNodes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Clears this instance.
        /// </summary>
        /// <autogeneratedoc />
        public void Clear()
        {
            while (ChildNodes.Count > 0
                && ChildNodes.First?.Value is LayoutItemNode itemNode
            )
            {
                itemNode.ParentItem = null;
                ChildNodes.Remove(itemNode);
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="item">The node.</param>
        /// <returns>bool.</returns>
        /// <autogeneratedoc />
        public bool Contains(LayoutItemNode item)
        {
            _ = item ?? throw new ArgumentNullException(nameof(item));
            return ChildNodes.Contains(item);
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        /// <autogeneratedoc />
        public void CopyTo(LayoutItemNode[] array, int arrayIndex)
            => throw new NotImplementedException();


        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        /// <value>My property.</value>
        /// <autogeneratedoc />
        public string? MyProp { get; set; }
    }
}
