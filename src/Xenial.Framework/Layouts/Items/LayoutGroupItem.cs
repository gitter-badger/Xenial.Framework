﻿using System;

using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model;
using DevExpress.Utils;

using Xenial.Framework.Layouts.Items.Base;
using Xenial.Framework.Layouts.Items.PubTernal;

using Locations = DevExpress.Persistent.Base.Locations;
using ToolTipIconType = DevExpress.Persistent.Base.ToolTipIconType;

namespace Xenial.Framework.Layouts.Items
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial record LayoutGroupItem
        : LayoutItem,
        ILayoutElementWithCaptionOptions,
        ILayoutElementWithCaption,
        ILayoutToolTip,
        ILayoutToolTipOptions,
        ILayoutGroupItem
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static LayoutGroupItem Create()
            => new();

        /// <summary>
        /// Creates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static LayoutGroupItem Create(string id)
            => new(id);

        /// <summary>
        /// Creates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="flowDirection">The flow direction.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static LayoutGroupItem Create(string id, FlowDirection flowDirection)
            => new(id, flowDirection);

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <autogeneratedoc />
        public LayoutGroupItem()
            => Direction = FlowDirection.Vertical;

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <autogeneratedoc />
        public LayoutGroupItem(string id)
            : this(id, FlowDirection.Vertical) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="flowDirection">The flow direction.</param>
        /// <autogeneratedoc />
        public LayoutGroupItem(string id, FlowDirection flowDirection)
        {
            Id = Slugifier.GenerateSlug(id);
            Direction = flowDirection;
        }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>The direction.</value>
        /// <autogeneratedoc />
        public FlowDirection Direction { get; init; }

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>The name of the image.</value>
        /// <autogeneratedoc />
        public string? ImageName { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        /// <autogeneratedoc />
        public string? Caption { get; set; }

        /// <summary>
        /// Gets or sets the show caption.
        /// </summary>
        /// <value>The show caption.</value>
        /// <autogeneratedoc />
        public bool? ShowCaption { get; set; }

        /// <summary>
        /// Gets or sets the caption horizontal alignment.
        /// </summary>
        /// <value>The caption horizontal align.</value>
        /// <autogeneratedoc />
        public HorzAlignment? CaptionHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the caption location.
        /// </summary>
        /// <value>The caption location.</value>
        /// <autogeneratedoc />
        public Locations? CaptionLocation { get; set; }

        /// <summary>
        /// Gets or sets the caption vertical alignment.
        /// </summary>
        /// <value>The caption vertical align.</value>
        /// <autogeneratedoc />
        public VertAlignment? CaptionVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the caption word wrap.
        /// </summary>
        /// <value>The caption word wrap.</value>
        /// <autogeneratedoc />
        public WordWrap? CaptionWordWrap { get; set; }

        /// <summary>
        /// Gets or sets the is collapsible group.
        /// </summary>
        /// <value>The is collapsible group.</value>
        /// <autogeneratedoc />
        public bool? IsCollapsibleGroup { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>The tool tip.</value>
        /// <autogeneratedoc />
        public string? ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the type of the tool tip icon.
        /// </summary>
        /// <value>The type of the tool tip icon.</value>
        /// <autogeneratedoc />
        public ToolTipIconType? ToolTipIconType { get; set; }

        /// <summary>
        /// Gets or sets the tool tip title.
        /// </summary>
        /// <value>The tool tip title.</value>
        /// <autogeneratedoc />
        public string? ToolTipTitle { get; set; }

        /// <summary>
        /// Gets or sets the layout group options.
        /// </summary>
        /// <value>The layout group options.</value>
        /// <autogeneratedoc />
        public Action<IModelLayoutGroup>? LayoutGroupOptions { get; set; }
    }
}
