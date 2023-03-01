---
title: Transform, map external source data to knowledge fields
description: Learn how you can convert and map source values with different types to the corresponding knowledge attribute.
author: gandhamm
ms.author: mgandham
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/01/2023
ms.custom: bap-template
search.audienceType: 
  - developer
---

# Transform, map external source data to knowledge fields

When you're mapping information from external data providers to knowledge article entities, if the source value is of a different data type, you'll have to transform the value before you can map it to the target knowledge attribute. You can create a plug-in and register it on `Create` and `Update` messages so that the target knowledge article attributes have values that are inline with the articles from the external providers.

To transform and map the source values, perform the following steps:

1. Create a custom field in the `KnowledgeArticle` entity. More information: [How to create and edit columns](/power-apps/maker/data-platform/create-edit-fields).
1.  Map the required external source value to the newly created custom field. More information: [Configure knowledge article schema mapping (preview)](int-data-mapping.md). This is a temporary mapping from which your plug-in picks up the source value.
1. Create a plug-in. For more information, see: [Create a plug-in project](/power-apps/developer/data-platform/tutorial-write-plug-in#create-a-plug-in-project).
1. You can write your own code to convert the external source value and map it to the required target knowledge article attribute.  
In this example, we'll show how you can map a source value that's of the type **String** to an article field attribute of type **OptionSet**. In the plug-in that you created, replace the entire class with the following sample code.

      
 ``` C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Services;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerApps.Samples
{
    /// <summary>
    /// The plug-in shows the sample code to map the external source value to the target attribute, when they're of different types
    /// </summary>
    /// <remarks>
    /// To showcase the capabilities of the plugin, we have added 2 new attributes to the KnowledgeArticle entity.
    /// The first attribute new_documentationcentersourcevalue is a String attribute that is mapped to the external source value. This is a temporary mapping that stores the source value.
    /// The plugin picks up the source value from new_documentationcentersourcevalue. The source value can take the following values: Develop, Content, and Test.
    ///The second attribute, new_documentationcenter, is the target attribute of type OptionSet to which the source value must actually be mapped to.
    /// Develop with value 100000000, Content with value 100000001, and Test with value 100000002
    /// The goal of this plugin to read the value from the new_documentationcentersourcevalue, retrieve the option set metadata of the target attribute new_documentationcenter, and map it to the value in new_documentationcentersourcevalue.
    /// </remarks>
    public sealed class KnowledgePlugin : IPlugin
    {
        /// <summary>
        /// Execute method that is required by the IPlugin interface.
        /// </summary>
        /// <param name="serviceProvider">The service provider from which you can obtain the
        /// tracing service, plug-in execution context, organization service, and more.</param>
        public void Execute(IServiceProvider serviceProvider)
        {
            //Extract the tracing service for use in debugging sandboxed plug-ins.
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));

            // The InputParameters collection contains all the data passed in the message request.
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                // Obtain the target entity from the input parameters.
                Entity entity = (Entity)context.InputParameters["Target"];

                // Verify that the target entity represents knowledgearticle.
                if (entity.LogicalName != "knowledgearticle")
                {
                    tracingService.Trace("KnowledgePlugin: Plugin is incorrectly called for the entity: " + entity.LogicalName);
                    return;
                }

                //Skip the plugin for RootArticles
                const string isRootArticleAttributeName = "isrootarticle";
                bool isRootArticle = entity.GetAttributeValue<bool>(isRootArticleAttributeName);
                if (isRootArticle)
                {
                    tracingService.Trace("KnowledgePlugin: Returning for Root Article");
                    return;
                }

                try
                {
                    const string sourceValueAttributeName = "new_documentationcentersourcevalue";
                    const string targetValueAttributeName = "new_documentationcenter";

                    //Get the source value
                    string sourceValue = entity.GetAttributeValue<string>(sourceValueAttributeName);
                    if (string.IsNullOrEmpty(sourceValue))
                    {
                        tracingService.Trace("KnowledgePlugin: " + sourceValueAttributeName + " is not set");
                        return;
                    }

                    // Obtain the organization service reference.
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    // Retrieve the option set metadata of the target field.
                    OptionSetMetadata retrievedOptionSetMetadata = RetrieveOptionSet(service, entity, targetValueAttributeName, tracingService);

                    // Check if the source data value is present in the retrieved target option set metadata.
                    OptionMetadata matchedOptionMetadata = retrievedOptionSetMetadata?.Options?.First(optionMetadata => optionMetadata.Label.UserLocalizedLabel.Label == sourceValue);
                    if (matchedOptionMetadata == null || matchedOptionMetadata.Value == null)
                    {
                        tracingService.Trace("KnowledgePlugin: Matching OptionMetadata is not found");
                        return;
                    }

                    // Map the option set value of the string new_documentationcentersourcevalue to the target option set new_documentationcenter.
                    int optionSetValue = (int)matchedOptionMetadata.Value;
                    entity[targetValueAttributeName] = new OptionSetValue(optionSetValue);
                    tracingService.Trace("KnowledgePlugin: Successfully set the value.");
                }
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the KnowledgePlugin plug-in." + ex + "\n InnerException: " + ex.InnerException);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("Exception in KnowledgePlugin: {0}", ex);
                    throw ex;
                }
            }
        }

        /// <summary> 
        /// Fetch the optionset metadata from the entity metadata
        /// </summary>
        /// <param name="service">Organization Details</param>
        /// <param name="entity">Entity record</param>
        /// <param name="targetValueAttributeName">Optionset Attribute Name</param>
        /// <param name="tracingService">Tracing Service</param>
        private OptionSetMetadata RetrieveOptionSet(IOrganizationService service, Entity entity, string targetValueAttributeName, ITracingService tracingService)
        {
            RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest
            {
                LogicalName = entity.LogicalName,
                EntityFilters = EntityFilters.Attributes,
                RetrieveAsIfPublished = true
            };
            RetrieveEntityResponse retrieveEntityResponse = (RetrieveEntityResponse)service.Execute(retrieveEntityRequest);
            EntityMetadata metadata = retrieveEntityResponse.EntityMetadata;
            PicklistAttributeMetadata picklistMetadata = metadata.Attributes.FirstOrDefault(attribute => string.Equals(attribute.LogicalName, targetValueAttributeName, StringComparison.OrdinalIgnoreCase)) as PicklistAttributeMetadata;
            return picklistMetadata.OptionSet;
        }
    }
}


```
	  
3. Register the plug-in on `Create` and `Update` SDK messages of the KnowledgeArticle entity in the PreOperation stage. More information: [Register a plug-in](/power-apps/developer/data-platform/register-plug-in)

## See Also

[Manage integrated search providers (preview)](add-search-provider.md)<br>
[View and use insights for search providers (preview)](view-and-use-insights.md)
