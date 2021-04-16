---
title: "Localize product property values (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Add, update, retrieve, query, and translate the localized values for product name attributes."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1635a343-2896-4cdb-a6fb-3c5113a32470
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Localize product property values

Product names may be localized for different regions. With Dynamics 365 Customer Engagement (on-premises) you can provide localized labels for certain product attributes so that people will see the localized names that match their language preferences. This topic is about how developers can interact with this feature. For step-by-step instructions to use this feature in the application, see the previous versions documentation on [Translate product names and properties into multiple languages](/previous-versions/dynamicscrm-2016/admins-customizers-dynamics-365/mt826708(v=crm.8)).  

<a name="BKMK_supportedAttributes"></a>   
## Attributes that support localized property values  
 The following list contains the attributes that support localizable values:  
  
- `Product.Name`  
  
- `DynamicProperty.Name`  
  
- `DynamicPropertyOptionSetItem.DynamicPropertyOptionName`  
  
- `DynamicPropertyOptionSetItem.DynamicPropertyOptionDescription`  
  
  The <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> and <xref:Microsoft.Xrm.Sdk.Metadata.MemoAttributeMetadata> classes have a read-only `IsLocalizable` Boolean property that is `false` for all attributes except the four in the preceding table.  
  
<a name="BKMK_retrieving"></a>   
## Retrieve localized property values  
 You don’t need to do anything differently to retrieve the localized value that matches the user’s language preference. If a localized value exists for the user’s preferred language, it will be returned. If a localized value doesn’t exist, the value for the organization’s base language will be returned. This behavior maintains backwards compatibility; any code you currently have using the product name attribute will continue to work using any localized values. If the localization of property values is incomplete, people may see mixed language values.  
  
 To retrieve all the localized labels for a specific localizable attribute, use the <xref:Microsoft.Crm.Sdk.Messages.RetrieveLocLabelsRequest> message.  
  
<a name="BKMK_Query"></a>   
## Query using localized values  
 When you query entities with conditions using values for localized attributes, the conditions will be evaluated using your preferred language first and will revert to the base language if there is no localized value for that attribute. Query results for localized attribute values will be those for your preferred language if they exist. Otherwise, the results will use the base language values.  
  
<a name="BKMK_CreatingOrUpdating"></a>   
## Create or update records with localizable attributes  
 Records with localized attributes are read-only unless your preferred language is the organization’s base language. You can only create records with localized property values using the organization’s base language. If you update the base language value for a localizable attribute any localized values for that attribute are not changed except if you clear the value for the base language. If you set the base language value to null or an empty string, all localized values for that property will also be cleared.  
  
 To add or update localized labels for any specific localized attribute, use the <xref:Microsoft.Crm.Sdk.Messages.SetLocLabelsRequest> message or import translated values. Any changes to the localizable attributes will appear in the audit history for the record. The language code identifier (LCID) for the localized value will appear in the audit history.  
  
<a name="BKMK_Translating"></a>   
## Translate localizable attributes  
 The process of localizing localizable attributes programmatically is similar to the process used to translate localized solution labels. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Translate customized entity and attribute text](customize-labels-support-multiple-languages.md#BKMK_TranslatingCustomizedEntityAndAttributeText)  
  
 Unlike translating metadata values, the user exporting and importing localized attributes values does not have to have the system administrator security role. The sales manager security role has the privileges necessary to translate localizable attributes. The person translating localized property values can only export those records they have access to view and update those records they have privileges to update.  
  
 To translate localizable attributes programmatically you must first export the current localized label definitions using <xref:Microsoft.Crm.Sdk.Messages.ExportFieldTranslationRequest>. The <xref:Microsoft.Crm.Sdk.Messages.ExportFieldTranslationResponse>.`ExportTranslationFile` property contains a `byte[]` for a compressed crmFieldTranslations.zip file containing a  [Content_types].xml file and a crmFieldTranslations.xml file that can be opened using [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)]. The **Localized Labels** worksheet contains a column with an LCID value for each provisioned language for the organization. The column with the base language values will be populated and the columns for each provisioned language will contain any previously localized values. This file can be edited by a translator to provide localized labels for the localizable properties.  
  
> [!TIP]
>  If you want to perform a bulk update of just the base language names, you can also edit the base language values.  
  
 After the crmFieldTranslations.xml file is edited to provide localized labels, compress it together with the [Content_types].xml file and set that file as the `TranslationFile` property of the <xref:Microsoft.Crm.Sdk.Messages.ImportFieldTranslationRequest>.  
  
### Modify the values included when exporting translated property values  
 The values that are included in the exported translations are controlled by customizable views associated with the entities that support localizable property values. Only the product entity displays this view in the customization user interface. These views are named **Export Field Translations**. The following table provides the `SavedQueryId` for these views.  
  
|Entity|`SavedQueryId`|Default `FetchXml`|  
|------------|--------------------|------------------------|  
|product|9cfe2a9f-13c4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"<br /> distinct="false"><br /> \<entity name="product"><br /> \<attribute name="name" /><br /> \</entity><br />\</fetch>|  
|dynamicproperty|4833cf48-1ac4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"><br /> \<entity name="dynamicproperty"><br /> \<attribute name="name" /><br /> \</entity><br />\</fetch>|  
|dynamicpropertyoptionsetitem|d64cce30-1fc4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"><br /> \<entity name="dynamicpropertyoptionsetitem"><br /> \<attribute name="dynamicpropertyoptionname" /><br /> \<attribute name="dynamicpropertyoptiondescription" /><br /> \</entity><br />\</fetch>|  
  
 You can edit the `FetchXml` property of these views to filter out any attribute property values you do not want to include. For example, you may want to exclude archived records or only include those updated after a certain date.  
  
### Monitor the progress of field translation import jobs  
 The system job entity contains the following views to monitor the progress of field translation import jobs:  
  
- All Field Translation Import Jobs  
  
- Completed Field Translation Import Jobs  
  
- In Progress Field Translation Import Jobs  
  
- My Field Translation Import Jobs  
  
- Not Started Field Translation Import Jobs  
  
  The following conditions will cause errors when importing translation jobs:  
  
|                                                                           Message                                                                           |                                                                                                  Description                                                                                                   |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|             **Warning**: You don’t have write permissions to one or more of the rows specified in the import file for worksheet {0}, Line {1}.              |                            The person running the import may not have write permissions to a row included in the imported file.<br /><br /> Processing of other rows will continue.                            |
|                          **Warning**: The base language translation string present in worksheet {0}, row {1}, column {2} is null.                           |                                             A base language value cannot be cleared by importing translations.<br /><br /> Processing of other rows will continue                                              |
|                           **Warning**: The number of cells in row {0} don’t match the number of cells in row 1 in worksheet {1}.                            |                                              All rows in the spreadsheet must have the same number of cells.<br /><br /> Processing of other rows will continue.                                               |
|                                     **Warning**: An invalid Entity name was found in worksheet {0}, Line {1}, Column A.                                     |                                           There is no valid entity in the system using a name in the worksheet.<br /><br /> Processing of other rows will continue.                                            |
|                                 **Warning**: An invalid Object Column Name was found in worksheet {0}, Line {1}, Column C.                                  |                                    There is no valid localizable attribute in the system using a name in the worksheet.<br /><br /> Processing of other rows will continue.                                    |
|                                      **Warning**: An invalid Object Id was found in worksheet {0}, Line {1}, Column B.                                      |                                           There is no matching record in the organization for item in this row.<br /><br /> Processing of other rows will continue.                                            |
|                                                       **Error**: No rows were found in worksheet {0}.                                                       |                                                                                       The worksheet to import is empty.                                                                                        |
|                             **Error**: The Organization ID present in worksheet {0} does not match the current Organization ID.                             |                                                              You can only import translations into the same organization they were exported from.                                                              |
|                              **Warning**: An invalid language code was found in worksheet {0}, Column {1}. &#124; Details: {2}                              | The LCID in the column isn’t a valid integer or the Language pack for the language is not installed.<br /><br /> The translations in the column are ignored.<br /><br /> [!INCLUDE[LCID](../includes/lcid.md)] |
|                                        **Error**: A duplicate language code was found in worksheet {0}, Column {1}.                                         |                                                                                Each column must have a different language code.                                                                                |
| **Error**: The translation file is invalid. The compressed file must contain the following files at its root: CrmFieldTranslations.xml, [Content_Types].xml |                                                          The compressed (zip) file to be imported must contain only the files described in the error.                                                          |
|                                   **Error**: The translations file is invalid or doesn’t conform to the required schema.                                    |  The CrmFieldTranslations.xml file included in the compressed (zip) file must be a file that was exported from the system and only edited to provide localized values. Other changes may invalidate the file.  |
  
<a name="BKMK_uinstallingLanguage"></a>   
## Uninstall a language  
 Any localized labels provided for a language that is uninstalled will remain in the system so that they’ll be in place if the language is reinstalled.  
  
### See also  
 [Product catalog entities](product-catalog-entities.md)   
 [Translate customized entity and attribute text](customize-labels-support-multiple-languages.md#BKMK_TranslatingCustomizedEntityAndAttributeText)   
 [Translate product names and properties into multiple languages](/previous-versions/dynamicscrm-2016/admins-customizers-dynamics-365/mt826708(v=crm.8))


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]