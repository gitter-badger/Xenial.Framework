﻿using System;
using System.Collections.Generic;
using System.Linq;

using DevExpress.Blazor;
using DevExpress.ExpressApp.Blazor.Components;
using DevExpress.ExpressApp.Blazor.Components.Models;

using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;

using Microsoft.AspNetCore.Components;

using Xenial.Framework.TokenEditors.Blazor.Editors;
using Xenial.Framework.TokenEditors.Model;

namespace Xenial.Framework.TokenEditors.Blazor.Editors
{
    /// <summary>
    /// Class TokenStringPropertyEditor.
    /// Implements the <see cref="DevExpress.ExpressApp.Blazor.Editors.BlazorPropertyEditorBase" />
    /// </summary>
    /// <seealso cref="DevExpress.ExpressApp.Blazor.Editors.BlazorPropertyEditorBase" />
    /// <autogeneratedoc />
    [XenialCheckLicence]
    public sealed partial class TokenStringPropertyEditor : BlazorPropertyEditorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStringPropertyEditor"/> class.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="model">The model.</param>
        /// <autogeneratedoc />
        public TokenStringPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

        internal class XenialStringToStringAdapter : DxTagBoxAdapter<DataItem<object>, object>
        {
            public XenialStringToStringAdapter(DxTagBoxModel<DataItem<object>, object> componentModel) : base(componentModel) { }
            public override object? GetValue()
            {
                var values = (IEnumerable<object>)base.GetValue();
                return values != null ? string.Join(CheckedListBoxItemsDisplayTextProvider.MultiTextSeparator + " ", values) : null;
            }
            public override void SetValue(object value)
            {
                var str = (string)value;
                object[]? values = !string.IsNullOrEmpty(str) ? str.Split(CheckedListBoxItemsDisplayTextProvider.MultiTextSeparator).Select(str => str.Trim()).ToArray() : null;
                base.SetValue(values);
            }
        }

        /// <summary>
        /// Creates the component adapter.
        /// </summary>
        /// <returns>IComponentAdapter.</returns>
        protected override IComponentAdapter CreateComponentAdapter()
        {
            var componentModel = new DxTagBoxModel<DataItem<object>, object>();
            var data = new List<DataItem<object>>();

            componentModel.Data = data;
            componentModel.ValueFieldName = nameof(DataItem<object>.Value);
            componentModel.TextFieldName = nameof(DataItem<object>.Text);

            foreach (var item in (Model.PredefinedValues ?? string.Empty).Split(";").Where(val => !string.IsNullOrEmpty(val)))
            {
                data.Add(new DataItem<object>(item, item));
            }

            var currentObjectVal = this.GetPropertyValue(CurrentObject);
            if (currentObjectVal is string currentObjectValStr)
            {
                foreach (var item in currentObjectValStr.Split(";").Where(val => !string.IsNullOrEmpty(val)))
                {
                    data.Add(new DataItem<object>(item, item));
                }
            }

            if (Model is IXenialTokenStringModelPropertyEditor model)
            {
                componentModel.FilteringMode = model.XenialTokenStringPopupFilterMode switch
                {
                    TokenPopupFilterMode.StartsWith => DataGridFilteringMode.StartsWith,
                    TokenPopupFilterMode.Contains => DataGridFilteringMode.Contains,
                    _ => componentModel.FilteringMode
                };
            }

            return new XenialStringToStringAdapter(componentModel);
        }

        /// <summary>
        /// Creates the view component core.
        /// </summary>
        /// <param name="dataContext">The data context.</param>
        /// <returns>RenderFragment.</returns>
        /// <autogeneratedoc />
        protected override RenderFragment CreateViewComponentCore(object dataContext)
        {
            var displayTextModel = new DisplayTextModel();
            displayTextModel.DisplayText = GetPropertyDisplayValue(dataContext);
            return DisplayTextRenderer.Create(displayTextModel);
        }

        private string GetPropertyDisplayValue(object dataContext)
            => CheckedListBoxItemsDisplayTextProvider.GetDisplayText((string)this.GetPropertyValue(dataContext), PropertyName, dataContext as ICheckedListBoxItemsProvider);
    }
}

namespace DevExpress.ExpressApp.Editors
{
    /// <summary>
    /// Class TokenStringPropertyEditorBlazorExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static class TokenStringPropertyEditorBlazorExtensions
    {
        /// <summary>
        /// Uses the token objects property editor.
        /// </summary>
        /// <param name="editorDescriptorsFactory">The editor descriptors factory.</param>
        /// <returns>EditorDescriptorsFactory.</returns>
        /// <exception cref="System.ArgumentNullException">editorDescriptorsFactory</exception>
        /// <autogeneratedoc />
        public static EditorDescriptorsFactory UseTokenStringPropertyEditorsBlazor(this EditorDescriptorsFactory editorDescriptorsFactory)
        {
            _ = editorDescriptorsFactory ?? throw new ArgumentNullException(nameof(editorDescriptorsFactory));

            editorDescriptorsFactory.RegisterPropertyEditor(
                Xenial.Framework.TokenEditors.PubTernal.TokenEditorAliases.TokenStringPropertyEditor,
                typeof(string),
                typeof(TokenStringPropertyEditor),
                false
            );

            return editorDescriptorsFactory;
        }
    }
}
