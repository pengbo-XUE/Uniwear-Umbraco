//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>[Vendr Checkout] Checkout Page</summary>
	[PublishedModel("vendrCheckoutCheckoutPage")]
	public partial class VendrCheckoutCheckoutPage : VendrCheckoutBasePage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const string ModelTypeAlias = "vendrCheckoutCheckoutPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<VendrCheckoutCheckoutPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public VendrCheckoutCheckoutPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hide from Navigation: Hide the checkout page from the sites main navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => this.Value<bool>("umbracoNaviHide");

		///<summary>
		/// Checkout Back Page: The page to go back to when backing out of the checkout flow.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrCheckoutBackPage")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent VendrCheckoutBackPage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("vendrCheckoutBackPage");

		///<summary>
		/// Collect Shipping Info: Select whether to collect shipping information or not. Not necessary if you are only dealing with digital downloads.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrCollectShippingInfo")]
		public virtual bool VendrCollectShippingInfo => this.Value<bool>("vendrCollectShippingInfo");

		///<summary>
		/// Order Line Property Aliases: Comma separated list of order line property aliases to display in the order summary.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrOrderLinePropertyAliases")]
		public virtual string VendrOrderLinePropertyAliases => this.Value<string>("vendrOrderLinePropertyAliases");

		///<summary>
		/// Privacy Policy Page: The page on the site containing the privacy policy.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrPrivacyPolicyPage")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent VendrPrivacyPolicyPage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("vendrPrivacyPolicyPage");

		///<summary>
		/// Store Address: The address of the web store to appear in the footer of order emails.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrStoreAddress")]
		public virtual string VendrStoreAddress => this.Value<string>("vendrStoreAddress");

		///<summary>
		/// Store Logo: A logo image for the store to appear at the top of the checkout screens and order emails.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrStoreLogo")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent VendrStoreLogo => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("vendrStoreLogo");

		///<summary>
		/// Terms and Conditions Page: The page on the site containing the terms and conditions.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrTermsAndConditionsPage")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent VendrTermsAndConditionsPage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("vendrTermsAndConditionsPage");

		///<summary>
		/// Theme Color: The theme color to use for colored elements of the checkout pages.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("vendrThemeColor")]
		public virtual string VendrThemeColor => this.Value<string>("vendrThemeColor");
	}
}
