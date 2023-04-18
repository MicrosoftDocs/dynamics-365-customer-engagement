---
title: Schema details to build a metadata mapping template
description: Learn about how to map external source metadata to knowledge article metadata.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: conceptual 
ms.date: 04/18/2023
ms.custom: bap-template 
---

# Schema details to build a metadata mapping template (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

This article describes the schema details required to map information from external data providers to the knowledge article entities, and how you can prepare your own schema mapping JSON file using various fields and attributes.

### Fields

The following table lists the fields and field details that you must use in your JSON schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|Name     |Name of the field definition |No     |A string indicating the name of the field. |
|UniqueTargetFieldName     |Is the unique identifier or alternate key of the knowledge article entity. Typically, this field is the ID on the content provider side. |Yes     |A string indicating the name of the field. You can set the value to "msydn_externalreferenceid" |
|ContentTargetFieldName     | Field value shouldn't be changed. |Yes     |Set the value to "content". |
|ApiPathLeafName     |Field value should not be changed. |Yes     |Set the value to "knowledgearticles". |
|List&lt;FieldDefinitions&gt;   |Is a list of field definitions. |Yes     |A set of definitions for the fields. See the following table for the list of supported fields for setting field definitions. |

### Field definitions

The following table lists the required and optional attributes that you can use in your metadata mapping schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|TargetFieldName     |Is the logical field name of the target attribute in the knowledge article entity. |Yes |Any string indicating the name of the target field |
|TargetFieldType    |Indicates the type of the target field. |Yes  |A string indicating the type of the field. |
|DocFieldSource    | Indicates how the source field value will be identified and resolved at run time |Yes     |Set the value to one of the following source types: <UL><li>Regex</li><li>Meta</li><li>Constant</li><li>Url</li><li>Document</li></ul>To know about these data types, refer to the following Field source types section. |
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

- After you’ve listed the mandatory fields and attribute information, you can include any additional metadata mappings and set your own custom values for them. For example, you can include a Meta type of **DocFieldSource** and set any custom values for the attribute, as follows.

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

When you're mapping information from external data providers to knowledge article entities, if the source value is of a different data type, you'll have to transform the value before you can map it to the target knowledge field. More information: [Transform and map external source data to corresponding target knowledge attribute](create-a-conversion-plugin.md)

## See Also

[Manage integrated search providers (preview)](add-search-provider.md#manage-integrated-search-providers-preview)<br>
[View and use insights for search providers (preview)](view-and-use-insights.md)
