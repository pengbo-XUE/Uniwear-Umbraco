//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.16.0
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
	/// <summary>Carousel Images</summary>
	[PublishedModel("carouselImages")]
	public partial class CarouselImages : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const string ModelTypeAlias = "carouselImages";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CarouselImages, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CarouselImages(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// carousel Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("carouselImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops CarouselImage => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("carouselImage");

		///<summary>
		/// linked Page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("linkedPage")]
		public virtual string LinkedPage => this.Value<string>("linkedPage");
	}
}
