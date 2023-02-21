---
title: Develop metadata mapping schema for knowledge articles (preview)
description: Concept description 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: conceptual 
ms.date: 03/01/2023
ms.custom: bap-template 
---

# Develop metadata mapping schema for knowledge articles (preview)

This article describes the schema details required to map information from external data providers to the knowledge article entities, and how you can prepare your own schema mapping JSON file using various fields and attributes.

### Fields

The following table lists the fields and field details that you must use in your JSON schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|Name     |Name of the field definition |No     |A string indicating the name of the field. |
|UniqueTargetFieldName     |Is the unique identifier or alternate key of the knowledge article entity. Typically, this field is the ID on the content provider side. |Yes     |A string indicating the name of the field. |
|ContentTargetFieldName     | Is the logical name of the attribute to be used. |Yes     |Set the value to "content". |
|ApiPathLeafName     |Field value should not be changed. |Yes     |Set the value to "knowledgearticles". |
|List&lt;FieldDefinitions&gt;   |Is a list of field definitions. |Yes     |A set of definitions for the fields. See the following table for the list of supported fields for setting field definitions. |

### Field definitions

The following table lists the required and optional attributes that you can use in your metadata mapping schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|TargetFieldName     |Is the logical field name of the target attribute in the knowledge article entity. |Yes |Any string indicating the name of the target field |
|TargetFieldType    |Indicates the type of the target field. |Yes  |A string indicating the name of the field. |
|DocFieldSource    | Indicates how the source field value will be identified and resolved at run time |Yes     |Set the value to one of the following source types: <UL><li>Regex</li><li>Meta</li><li>Constant</li><li>Url</li><li>Document</li></ul>To know about these data types, see Field source types. |
|DocFieldPattern  |Indicates the nature of the target field to be fetched. |No  |Set the value to "knowledgearticles". |
|MaxLength    |Is the maximum length of the string that can be stored in the target field. |No. Can be used when **TargetFieldType** attribute is of type String    |Int |
|UseRegexCapture    |Stores the regex pattern that can be applied to the URL. |No. Can be used when the **TargetFieldType** attribute is of type String and **DocFieldSource** attribute is of type Url. |Url or String. |

### Field source types

The data in the external search providers can be set to any of the following field source types:
 
- **Regex**: Use to indicate a regular expression type of data.
- **Meta**: Use to indicate that the target field value is obtained from a &lt;meta&gt; tag in the source article
- **Constant**: Use to indicate that the target field is a website or URL.
- **Document**: Use to indicate the HTML content of the article.

## Build your own metadata mapping template

When you develop your own mapping schema, you must be sure to configure a few mandatory fields and set default values for some field definitions.

Your mapping template must include:

-  The fields **UniqueTargetFieldName**, **ContentTargetFieldName**, and **ApiPathLeafName**. These fields must be set to their required values as follows:
    - Set the **UniqueTargetFieldName** to the out-of-the-box **msdyn_externalreferenceid** field or to a custom field. If you’re setting the **UniqueTargetFieldName** field to **msdyn_externalreferenceid**, then ensure that the definition for **msdyn_externalreferenceid** exists in Dataverse. If you’re using a custom field, then ensure that you add the field as an alternate Key. More information: [Define alternate keys to reference Dynamics 365 records](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn949335(v=crm.8)).
    - The **ContentTargetFieldName** field must be included and set to "content".
    - The **ApiPathLeafName** field must be included and set to "knowledgearticles".
    -  Ensure that you have mapped both the **UniqueTargetField** and **ContentTargetField** fields in the **FieldDefinitions** list.

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
- You must include the FieldDefinitions list and populate its attributes such as **FieldUse**, **DocFieldSource**, **TargetFieldName**, and **TargetFieldType** with default values. You must also include the title field. However, the value for the field can be set by you to either **Regex**, **Meta**, **Document**, **Constant**, or **Url**. 

   Be sure to include the following fields and attributes with their values, “as-is”, in your template.

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
         "TargetFieldType": "Bool"
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
         "DocFieldSource": "Document",
         "TargetFieldName": "content",
         "TargetFieldType": "String"
        }

    ```

- After you’ve listed the mandatory fields and attribute information, you can include any additional metadata mappings and set your own custom values for them. For example, you can include a Meta or Url type of **DocFieldSource** and set any custom values for the attribute, as follows.

    ```JSON

       {
         "DocFieldSource": "Meta",
         "DocFieldPattern": "description",
         "TargetFieldName": "description",
         "TargetFieldType": "String",
         "MaxLength": 155
       },
       {
         "DocFieldSource": "Url",
         "TargetFieldName": "msdyn_externalreferenceid",
         "TargetFieldType": "String",
         "UseRegexCapture": "^https://.*?/(.*?)/.*/.*?([0-9A-F]{8}[-](?:[0-9A-F]{4}[-]){3}[0-9A-F]{12})$"
        }

    ```

## Sample metadata mapping template

You can use the following metadata mapping JSON sample as template to build your own custom mapping template.

```JSON

 {
     "Name": "{To be filled by customer}",
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
        "TargetFieldType": "Bool"
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