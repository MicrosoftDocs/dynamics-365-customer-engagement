---
title: Schema details to build a metadata mapping template
description: Learn about how to map external source metadata to knowledge article metadata.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: overview
ms.date: 06/27/2025
ms.custom: bap-template
---

# Schema details to build a metadata mapping template

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability.md)]


This article describes the schema details required to map information from external data providers to the knowledge article entities, and how you can prepare your own schema mapping JSON file using various fields and attributes.

### Fields

The following table lists the fields and field details that you must use in your JSON schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|Name     |Name of the field definition |No     |A string indicating the name of the field. |
|UniqueTargetFieldName     |The unique identifier or alternate key of the knowledge article entity. Typically, this field is the ID on the content provider side. |Yes     |A string indicating the name of the field. You can set the value to "msydn_externalreferenceid" |
|ContentTargetFieldName     | Field value shouldn't be changed. |Yes     |Set the value to "content". |
|ApiPathLeafName     |Field value shouldn't be changed. |Yes     |Set the value to "knowledgearticles". |
|List&lt;FieldDefinitions&gt;   |Is a list of field definitions. |Yes     |A set of definitions for the fields. See the following table for the list of supported fields for setting field definitions. |

### Field definitions

The following table lists the required and optional attributes that you can use in your metadata mapping schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|TargetFieldName     |Is the logical field name of the target attribute in the knowledge article entity. |Yes |Any string indicating the name of the target field |
|TargetFieldType    |Indicates the type of the target field. |Yes  |A string indicating the type of the field. |
|DocFieldSource    | Indicates how the source field value is identified and resolved at run time |Yes     |Set the value to one of the following source types: <UL><li>Regex</li><li>Meta</li><li>Constant</li><li>Url</li><li>Document</li></ul>To know about these data types, refer to the following Field source types section. |
|DocFieldPattern  |Indicates the nature of the target field to be fetched. |No  |Set this value based on the DocFieldSource value. See the examples below on how to set DocFieldPatterns. |
|MaxLength    |Is the maximum length of the string that can be stored in the target field. |No. Can be used when **TargetFieldType** attribute is of type String    |Int |
|UseRegexCapture    |Stores the regex pattern that can be applied to the URL. |No. Can be used when the **TargetFieldType** attribute is of type String and **DocFieldSource** attribute is of type Url. |Url or String. |

### Field source types

The data in the external search providers can be set to any of the following field source types:
 
- **Regex**: Use to indicate a regular expression type of data.
- **Meta**: Use to indicate that the target field value is obtained from a &lt;meta&gt; tag in the source article
- **Constant**: Use to set a static value for the target field.
- **Url**: Use to indicate the URL of the external source document.
- **Document**: Use to indicate the HTML content of the article.


## Considerations to build your own metadata mapping template

When you develop your own mapping schema, you must be sure to configure a few mandatory fields and set default values for some field definitions.

Your mapping template must include:

-  The **UniqueTargetFieldName**, **ContentTargetFieldName**, and **ApiPathLeafName** fields. These fields must be set to their required values as follows:
    - Set the **UniqueTargetFieldName** to the out-of-the-box **msdyn_externalreferenceid** field or to a custom field. If you’re using a custom field, then ensure that you add the field as an alternate Key. More information: [Define alternate keys to reference Dynamics 365 records](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn949335(v=crm.8)).
    - Include the **ContentTargetFieldName** field and set its value to "content".
    - Include the **ApiPathLeafName** field and set its value to "knowledgearticles".
    - Ensure that you provide mappings for both the **UniqueTargetField** and **ContentTargetField** fields in the **FieldDefinitions** list.

     Your mapping schema would look like:

    ```JSON

      {
        "Name": "{To be filled by you}",
        "UniqueTargetFieldName": "msdyn_externalreferenceid",
        "ContentTargetFieldName": "content",
        "ApiPathLeafName": "knowledgearticles"
        "FieldDefinitions": []
      }

    ```
- You must include the below **FieldDefinitions** list and populate its attributes such as **FieldUse**, **DocFieldSource**, **TargetFieldName**, and **TargetFieldType** with default values.  Be sure to include the following fields and attributes with their values, “as-is”, in your template. However, the Docfieldsource and Docfieldpattern for the title and content value fields can be set by you to either **Regex**, **Meta**, **Document**, **Constant**, or **Url**.

    ```JSON

      {
        "FieldUse": "Create",
        "DocFieldSource": "ArticlePublicNumber",
        "TargetFieldName": "articlepublicnumber",
        "TargetFieldType": "String"
      },
      {
         "DocFieldSource": "Constant",
         "DocFieldPattern": "true",
         "TargetFieldName": "msdyn_isingestedarticle",
         "TargetFieldType": "Boolean"
      },
      {
         "DocFieldSource": "Url",
         "TargetFieldName": "msdyn_ingestedarticleurl",
         "TargetFieldType": "String"
      },
      {
         "DocFieldSource": "DataProvider",
         "TargetFieldName": "msdyn_integratedsearchproviderid@odata.bind",
         "TargetFieldType": "String"
      },
      {
         "DocFieldSource": "Regex",
         "DocFieldPattern": "<title>(.*?)</title>",
         "TargetFieldName": "title",
         "TargetFieldType": "String"
      },
      {
         "DocFieldSource": "Url",
         "TargetFieldName": "msdyn_externalreferenceid",
         "TargetFieldType": "String",
         "UseRegexCapture": "^https://.*?/(.*?)/.*/.*?([0-9A-F]{8}[-](?:[0-9A-F]{4}[-]){3}[0-9A-F]{12})$"
     }, 
      {
         "DocFieldSource": "Document",
         "TargetFieldName": "content",
         "TargetFieldType": "String"
      }

    ```

- After you listed the mandatory fields and attribute information, you can include any additional metadata mappings and set your own custom values for them. For example, you can include a Meta type of **DocFieldSource** and set any custom values for the attribute, as follows.

    ```JSON

       {
         "DocFieldSource": "Meta",
         "DocFieldPattern": "description",
         "TargetFieldName": "description",
         "TargetFieldType": "String",
         "MaxLength": 155
        }

    ```

## Sample metadata mapping template

You can use the following metadata mapping JSON sample as template to build your own custom mapping template.

```JSON

   {
     "Name": "Integrated Search Data Provider Name",
     "UniqueTargetFieldName": "msdyn_externalreferenceid",
     "ContentTargetFieldName": "content",
     "ApiPathLeafName": "knowledgearticles",
     "FieldDefinitions": [
     {
       "FieldUse": "Create",
       "DocFieldSource": "ArticlePublicNumber",
       "TargetFieldName": "articlepublicnumber",
       "TargetFieldType": "String"
      },
      {
        "DocFieldSource": "Constant",
        "DocFieldPattern": "true",
        "TargetFieldName": "msdyn_isingestedarticle",
        "TargetFieldType": "Boolean"
      },
      {
        "DocFieldSource": "Url",
        "TargetFieldName": "msdyn_ingestedarticleurl",
        "TargetFieldType": "String"  
      },
      {
        "DocFieldSource": "DataProvider",
        "TargetFieldName": "msdyn_integratedsearchproviderid@odata.bind",
        "TargetFieldType": "String"
      },
      {
        "DocFieldSource": "Regex",
        "DocFieldPattern": "<title>(.*?)</title>",
        "TargetFieldName": "title",
        "TargetFieldType": "String"
       },
       {
          "DocFieldSource": "Meta",
          "DocFieldPattern": "description",
          "TargetFieldName": "description",
          "TargetFieldType": "String",
          "MaxLength": 155
       },
       {
          "DocFieldSource": "Document",
          "TargetFieldName": "content",
          "TargetFieldType": "String"
        },
        {
          "DocFieldSource": "Url",
          "TargetFieldName": "msdyn_externalreferenceid",
          "TargetFieldType": "String",
          "UseRegexCapture": "^https://.*?/(.*?)/.*/.*?([0-9A-F]{8}[-](?:[0-9A-F]{4}[-]){3}[0-9A-F]{12})$"
        }
    ]
 }

```

### Transform, map external source data to knowledge fields

When you're mapping information from external data providers to knowledge article entities, if the source value is of a different data type, you must transform the value before you can map it to the target knowledge attribute. You can create a plug-in and register it on `Create` and `Update` messages so that the target knowledge article attributes have values that are inline with the articles from the external providers.

To transform and map the source values, perform the following steps:

1. Create a custom field in the `KnowledgeArticle` entity. Learn more at [How to create and edit columns](/power-apps/maker/data-platform/create-edit-fields).
1.  Map the required external source value to the newly created custom field. Learn more at [Configure knowledge article schema mapping (preview)](../administer/int-data-mapping.md). This is a temporary mapping from which your plug-in picks up the source value.
1. Create a plug-in. Learn more at [Create a plug-in project](/power-apps/developer/data-platform/tutorial-write-plug-in#create-a-plug-in-project).
1. You can write your own code to convert the external source value and map it to the required target knowledge article attribute.  
In this example, we show how you can map a source value that's of the type **String** to an article field attribute of type **OptionSet**. In the plug-in that you created, replace the entire class with the following sample code.

      
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

## Related information

[Manage integrated search providers](../administer/add-search-provider.md#manage-integrated-search-providers)  
[View and use insights for search providers](../administer/view-and-use-insights.md)
