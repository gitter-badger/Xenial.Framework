﻿using System;

using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Persistent.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

using Xenial.Framework.TokenEditors.Model;
using Xenial.Framework.TokenEditors.Win.Editors;

namespace Xenial.Framework.TokenEditors.Win.Editors
{
    /// <summary>
    /// Class TokenStringPropertyEditor.
    /// Implements the <see cref="DevExpress.ExpressApp.Win.Editors.DXPropertyEditor" />
    /// </summary>
    /// <seealso cref="DevExpress.ExpressApp.Win.Editors.DXPropertyEditor" />
    [XenialCheckLicence]
    public sealed partial class TokenStringPropertyEditor : DXPropertyEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStringPropertyEditor"/> class.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="model">The model.</param>
        /// <autogeneratedoc />
        public TokenStringPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

        /// <summary>
        /// Creates the repository item.
        /// </summary>
        /// <returns>RepositoryItem.</returns>
        /// <autogeneratedoc />
        protected override RepositoryItem CreateRepositoryItem() => ApplyModelOptions(new RepositoryItemTokenEdit());

        private RepositoryItemTokenEdit ApplyModelOptions(RepositoryItemTokenEdit tokenEdit)
        {
            if (Model is ITokenStringModelPropertyEditor model)
            {
                tokenEdit.DropDownShowMode = model.TokenDropDownShowMode switch
                {
                    TokenDropDownShowMode.Default => TokenEditDropDownShowMode.Default,
                    TokenDropDownShowMode.Regular => TokenEditDropDownShowMode.Regular,
                    TokenDropDownShowMode.Outlook => TokenEditDropDownShowMode.Outlook,
                    _ => tokenEdit.DropDownShowMode
                };

                tokenEdit.PopupFilterMode = model.TokenPopupFilterMode switch
                {
                    TokenPopupFilterMode.StartsWith => TokenEditPopupFilterMode.StartWith,
                    TokenPopupFilterMode.Contains => TokenEditPopupFilterMode.Contains,
                    _ => tokenEdit.PopupFilterMode
                };
            }
            return tokenEdit;
        }

        /// <summary>
        /// Creates the control core.
        /// </summary>
        /// <returns>System.Object.</returns>
        /// <autogeneratedoc />
        protected override object CreateControlCore() => new TokenEdit();

        /// <summary>
        /// Provides access to the control that represents the current Property Editor in a UI.
        /// </summary>
        /// <value>A DevExpress.XtraEditors.BaseEdit object representing a control used to display the current Property Editor in a UI.</value>
        /// <autogeneratedoc />
        public new TokenEdit Control => (TokenEdit)base.Control;

        /// <summary>
        /// Setups the repository item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <autogeneratedoc />
        protected override void SetupRepositoryItem(RepositoryItem item)
        {
            base.SetupRepositoryItem(item);
            if (item is RepositoryItemTokenEdit tokenEdit)
            {
                tokenEdit.BeginUpdate();
                try
                {
                    ApplyModelOptions(tokenEdit);
                    tokenEdit.EditValueType = TokenEditValueType.String;
                    tokenEdit.ShowDropDown = true;
                    tokenEdit.EditMode = TokenEditMode.Manual;

                    tokenEdit.EditValueSeparatorChar = ';';
                    tokenEdit.Separators.Clear();
                    tokenEdit.Separators.Add(";");
                    tokenEdit.Separators.Add(",");

                    tokenEdit.PopupFilterMode = TokenEditPopupFilterMode.Contains;

                    tokenEdit.ValidateToken -= TokenEdit_ValidateToken;
                    tokenEdit.ValidateToken += TokenEdit_ValidateToken;

                    void TokenEdit_ValidateToken(object? _, TokenEditValidateTokenEventArgs e)
                        => e.IsValid = true;

                    InitTokens();
                }
                finally
                {
                    tokenEdit.EndUpdate();
                }

                void InitTokens()
                {
                    tokenEdit.Tokens.BeginUpdate();
                    try
                    {
                        if (Model is not null && !string.IsNullOrEmpty(Model.PredefinedValues))
                        {
                            foreach (var predefinedValue in Model.PredefinedValues.Split(';'))
                            {
                                tokenEdit.Tokens.AddToken(predefinedValue);
                            }
                        }
                    }
                    finally
                    {
                        tokenEdit.Tokens.EndUpdate();
                    }
                }
            }
        }
    }
}

namespace DevExpress.ExpressApp.Editors
{
    /// <summary>
    /// Class P.
    /// </summary>
    /// <autogeneratedoc />
    public static class TokenStringPropertyEditorWinExtensions
    {
        /// <summary>
        /// Uses the token objects property editor.
        /// </summary>
        /// <param name="editorDescriptorsFactory">The editor descriptors factory.</param>
        /// <returns>EditorDescriptorsFactory.</returns>
        /// <exception cref="System.ArgumentNullException">editorDescriptorsFactory</exception>
        /// <autogeneratedoc />
        public static EditorDescriptorsFactory UseTokenStringPropertyEditorsWin(this EditorDescriptorsFactory editorDescriptorsFactory)
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
