---
title: Extend transformer logic on templates (Dynamics 365 Customer Service) | MicrosoftDocs
description: This topic provides information on how customers can overwrite transformer logic in Dynamics 365 Customer Service.
ms.date: 03/04/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---
# Extend transformer logic on templates

Transformer logic refers to moving the values of specific fields from the knowledge article template to the knowledge article. Standard fields are supported out of the box. Organizations can overwrite the out-of-the-box transformer logic by creating a plug-in and registering it as a `msdyn_GetKAObjectFromTemplate` message.

To extend the transformer logic for your knowledge article templates:

1. Create a plug-in by performing the steps mentioned in [Create a plug-in project](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_create).
2. You can write your own mapping logic with the transformed `kaobject` using `context.OutputParameters["Result"]` as Entity. In this example, we'll show how you can build the knowledge article template transformer with the help of two new attributes, Article Type and Audience. In the plug-in that you created, replace the entire class with the following sample code:

```/// <summary>
	/// The plugin shows a sample of how to build a Knowledge Article Template Transformer
	/// </summary>
	/// <remarks>
	/// To showcase the capabilities of the transformer, we have added 2 new attributes to the Knowledge Article Template entity. These attributes have also been added to the form.
	/// The first is Article Type with the logical name new_articletype that is of type Option Set and points to a Global Option Set called Article Type
	/// The second is Audience with the logical name new_audience, also of type Option Set. This is a local option set and has 3 values - 
	/// Employee with value 100000000, Managers with value 100000001 and Public with value 100000002
	/// Similarly, we have 2 new attributes on the Knowledge Article entity which have been added to the Knowledge Article for Interactive Experience form.
	/// The first is Article Type with the logical name new_kaarticletype that is of type Option Set and points to the same Global Option Set Article Type described earlier.
	/// The second is the Disclaimer with the logical name new_disclaimer that is of type Single Line of Text. To ensure that it behaves like a disclaimer, we have ensured that it is
	/// not editable on the form.
	/// 
	/// The core goal of the transformer is to copy over the Option Set value from the Article Type of the template record to the Article Type of the article record.
	/// Having the same Global Option Set ensures that we don't need to worry about mapping the values of one to the other. But that is also possible as can be seen with the other attribute transform.
	/// Based on the audience of the template record, the disclaimer on the article record is populated.
	/// </remarks>
	public class TemplatePlugin : IPlugin
	{
		#region Constants
		private const string TemplateIdParam = "TemplateId";
		private const string ResultParam = "Result";
		private const string KATemplateLogicalName = "msdyn_knowledgearticletemplate";

		private const string KA_ArticleTypeName = "new_kaarticletype";
		private const string Tmpl_ArticleTypeName = "new_articletype";

		private const string KA_DisclaimerName = "new_disclaimer";
		private const string Tmpl_AudienceName = "new_audience";

		private const int Audience_Employee = 100000000;
		private const int Audience_Managers = 100000001;
		private const int Audience_Public = 100000002;
		#endregion

		public void Execute(IServiceProvider serviceProvider)
		{
			// Get all required services
			IOrganizationServiceFactory ServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
			IPluginExecutionContext Context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
			IOrganizationService OrganizationService = ServiceFactory.CreateOrganizationService(Context.UserId);
			ITracingService TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

			try
			{
				string templateIdStr = Context.InputParameters[TemplateIdParam] as string;
				Guid TemplateId = new Guid(templateIdStr);

				
				Entity template = new Entity(KATemplateLogicalName);
				template = OrganizationService.Retrieve(template.LogicalName, TemplateId, new ColumnSet(GetColumns().ToArray()));
				
				Entity kaobject = Context.OutputParameters[ResultParam] as Entity;

				TransformKAObject(kaobject, template);

			}
			catch (Exception ex)
			{
				TracingService.Trace("Exception: {0}", ex.Message);
				throw;
			}
		}

		#region Private Methods

		/// <summary>
		/// Returns a list of all the columns to be retrieved from the template
		/// </summary>
		/// <returns>The list of columns to retrieve from the template</returns>
		private List<string> GetColumns()
		{
			return new List<string> { Tmpl_ArticleTypeName, Tmpl_AudienceName };
		}

		/// <summary>
		/// Transforms the <paramref name="templateEntity"/> template record to the <paramref name="kaEntity"/> entity record
		/// </summary>
		/// <param name="kaEntity">The knowledge article entity record to transform</param>
		/// <param name="templateEntity">The template entity used to transform the article record</param>
		private void TransformKAObject(Entity kaEntity, Entity templateEntity)
		{
			foreach (var attribute in templateEntity.Attributes)
			{
				if (!GetColumns().Contains(attribute.Key))
				{
					continue;
				}
				kaEntity[GetKAAttributeName(attribute.Key)] = GetKAConvertor(attribute.Key)(attribute.Value);
			}
		}

		/// <summary>
		/// Gets the mapped attribute name for the article entity for the corresponding template attribute
		/// </summary>
		/// <param name="templateAttributeName">The attribute name used for retrieving the mapping</param>
		/// <returns>The attribute name of the knowledge article entity that maps to the <paramref name="templateAttributeName"/> template entity attribute</returns>
		private string GetKAAttributeName(string templateAttributeName)
		{
			switch (templateAttributeName)
			{
				case Tmpl_ArticleTypeName:
					return KA_ArticleTypeName;
				case Tmpl_AudienceName:
					return KA_DisclaimerName;
				default:
					return string.Empty;
			}
		}

		/// <summary>
		/// Gets the object convertor for the article entity for the corresponding template attribute
		/// </summary>
		/// <param name="templateAttributeName">The attribute name used for retrieving the mapping</param>
		/// <returns>A function that can transform the value stored in the template entity <paramref name="templateAttributeName"/> attribute to the knowledge article entity</returns>
		private Func<object, object> GetKAConvertor(string templateAttributeName)
		{
			switch (templateAttributeName)
			{
				case Tmpl_ArticleTypeName:
					return (object templateValue) =>
					{
						return templateValue;
					};
				case Tmpl_AudienceName:
					return (object templateValue) =>
					{
						var audienceVal = templateValue as OptionSetValue;
						switch (audienceVal.Value)
						{
							case Audience_Employee:
								return "Internal Use Only";
							case Audience_Managers:
								return "For Managers Only";
							case Audience_Public:
							default:
								return "Generally Available";
						}
					};
				default:
					return (object templateValue) =>
					{
						return null;
					};
			}
		}
		#endregion
	}
```
3. Follow the steps mentioned in [Register a plug-in](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_register) to register your plug-in.
4. Now, when you create a knowledge article from a template, the values of the option sets are transformed and inserted in the article.

## See also

[Create a knowledge article using template](create-knowledge-article-using-template.md)<br />
[Tutorial: Write and register a plug-in](/powerapps/developer/common-data-service/tutorial-write-plug-in)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
