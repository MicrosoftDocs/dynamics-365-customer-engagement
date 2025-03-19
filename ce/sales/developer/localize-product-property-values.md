---
title: Localize product property values (Dynamics 365 Sales)
description: Add, update, retrieve, query, and translate the localized values for product name attributes.
ms.date: 03/01/2023
ms.topic: how-to
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---
# Localize product property values

Product names could be localized for different regions. With Dynamics 365 Sales, you can provide localized labels for certain product attributes so that people can see the localized names that match their language preferences. This article is about how developers can interact with this feature. For step-by-step instructions to use this feature in the application, see the previous versions documentation on [Translate product names and properties into multiple languages](/previous-versions/dynamicscrm-2016/admins-customizers-dynamics-365/mt826708(v=crm.8)).  

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
 You don’t need to do anything differently to retrieve the localized value that matches the user’s language preference. If a localized value exists for the user’s preferred language, it is returned. If a localized value doesn’t exist, the value for the organization’s base language is returned. This behavior maintains backwards compatibility; any code that currently uses the product name attribute will continue to work using any localized values. If the localization of property values is incomplete, users might see mixed language values.  
  
 To retrieve all the localized labels for a specific localizable attribute, use the <xref:Microsoft.Crm.Sdk.Messages.RetrieveLocLabelsRequest> message.  
  
<a name="BKMK_Query"></a>   
## Query using localized values  
 When you query tables with conditions using values for localized attributes, the conditions are evaluated using your preferred language first. If there are no localized values for the attribute, the query reverts to the base language. Query results for localized attribute values is returned in your preferred language if they exist. Otherwise, the results are returned in your base language.  
  
<a name="BKMK_CreatingOrUpdating"></a>   
## Create or update records with localizable attributes  
 Records with localized attributes are read-only unless your preferred language is the organization’s base language. You can only create records with localized property values using the organization’s base language. If you update the base language value for a localizable attribute any localized values for that attribute aren't changed except if you clear the value for the base language. If you set the base language value to null or an empty string, all localized values for that property are also be cleared.  
  
 To add or update localized labels for any specific localized attribute, use the <xref:Microsoft.Crm.Sdk.Messages.SetLocLabelsRequest> message or import translated values. Any changes to the localizable attributes appear in the audit history for the record. The language code identifier (LCID) for the localized value appears in the audit history.  
  
<a name="BKMK_Translating"></a>   
## Translate localizable attributes  
 The process of localizing localizable attributes programmatically is similar to the process used to translate localized solution labels. [!INCLUDE[proc_more_information][Translate customized table and column text](/power-apps/developer/data-platform/customize-labels-support-multiple-languages#translate-customized-table-and-column-text)

 Unlike translating metadata values, the user exporting and importing localized attributes values doesn't have to have the system administrator security role. The sales manager security role has the privileges necessary to translate localizable attributes. The person translating localized property values can only export those records they have access to view and update those records they have privileges to update.  
  
 To translate localizable attributes programmatically, you must first export the current localized label definitions using <xref:Microsoft.Crm.Sdk.Messages.ExportFieldTranslationRequest>. The <xref:Microsoft.Crm.Sdk.Messages.ExportFieldTranslationResponse>.`ExportTranslationFile` property contains a `byte[]` for a compressed crmFieldTranslations.zip file containing a  [Content_types].xml file and a crmFieldTranslations.xml file that can be opened using [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)]. The **Localized Labels** worksheet contains a column with an LCID value for each provisioned language for the organization. The column with the base language values are populated and the columns for each provisioned language contain any previously localized values. This file can be edited by a translator to provide localized labels for the localizable properties.  
  
> [!TIP]
>  If you want to perform a bulk update of just the base language names, you can also edit the base language values.  
  
 After the crmFieldTranslations.xml file is edited to provide localized labels, compress it together with the [Content_types].xml file and set that file as the `TranslationFile` property of the <xref:Microsoft.Crm.Sdk.Messages.ImportFieldTranslationRequest>.  
  
### Modify the values included when exporting translated property values  
 The values that are included in the exported translations are controlled by customizable views associated with the tables that support localizable property values. Only the product tables display this view in the customization user interface. These views are named **Export Field Translations**. The following table provides the `SavedQueryId` for these views.  
  
|Table|`SavedQueryId`|Default `FetchXml`|  
|------------|--------------------|------------------------|  
|product|9cfe2a9f-13c4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"<br /> distinct="false"><br /> \<entity name="product"><br /> \<attribute name="name" /><br /> \</entity><br />\</fetch>|  
|dynamicproperty|4833cf48-1ac4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"><br /> \<entity name="dynamicproperty"><br /> \<attribute name="name" /><br /> \</entity><br />\</fetch>|  
|dynamicpropertyoptionsetitem|d64cce30-1fc4-e311-8f2e-00155d9d2505|<fetch version="1.0"<br /> output-format="xml-platform"<br /> mapping="logical"><br /> \<entity name="dynamicpropertyoptionsetitem"><br /> \<attribute name="dynamicpropertyoptionname" /><br /> \<attribute name="dynamicpropertyoptiondescription" /><br /> \</entity><br />\</fetch>|  
  
 You can edit the `FetchXml` property of these views to filter out any attribute property values you don't want to include. For example, you might want to exclude archived records or only include those records updated after a certain date.  
  
### Monitor the progress of field translation import jobs  
 The system job tables contain the following views to monitor the progress of field translation import jobs:  
  
- All Field Translation Import Jobs  
  
- Completed Field Translation Import Jobs  
  
- In Progress Field Translation Import Jobs  
  
- My Field Translation Import Jobs  
  
- Not Started Field Translation Import Jobs  
  
  The following conditions cause errors when importing translation jobs:  
  
| Message | Description | 
|---------|-------------|
| **Warning**: You don’t have write permissions to one or more of the rows specified in the import file for worksheet {0}, Line {1}. | The person running the import might not have write permissions to a row included in the imported file.<br /><br /> Processing of other rows will continue. |
| **Warning**: The base language translation strings present in worksheet {0}, row {1}, column {2} is null. | A base language value can't be cleared by importing translations.<br /><br /> Processing of other rows will continue |
| **Warning**: The number of cells in row {0} don’t match the number of cells in row 1 in worksheet {1}. | All rows in the spreadsheet must have the same number of cells.<br /><br /> Processing of other rows will continue. |
| **Warning**: An invalid Table name was found in worksheet {0}, Line {1}, Column A. | There's no valid table in the system using a name in the worksheet.<br /><br /> Processing of other rows will continue. |
| **Warning**: An invalid Object Column Name was found in worksheet {0}, Line {1}, Column C. | There's no valid localizable attribute in the system using a name in the worksheet.<br /><br /> Processing of other rows will continue. |
| **Warning**: An invalid Object ID was found in worksheet {0}, Line {1}, Column B. | There's no matching record in the organization for item in this row.<br /><br /> Processing of other rows will continue. |
| **Error**: No rows were found in worksheet {0}. | The worksheet to import is empty. |
| **Error**: The Organization ID present in worksheet {0} doesn't match the current Organization ID. | You can only import translations into the same organization they were exported from. |
| **Warning**: An invalid language code was found in worksheet {0}, Column {1}. &#124; Details: {2} | The LCID in the column isn’t a valid integer or the Language pack for the language isn't installed.<br /><br /> The translations in the column are ignored.<br /><br /> [!INCLUDE[LCID](../../includes/lcid.md)] |
| **Error**: A duplicate language code was found in worksheet {0}, Column {1}. | Each column must have a different language code. |
| **Error**: The translation file is invalid. The compressed file must contain the following files at its root: CrmFieldTranslations.xml, [Content_Types].xml |  The compressed (zip) file to be imported must contain only the files described in the error. |
| **Error**: The translations file is invalid or doesn’t conform to the required schema. | The CrmFieldTranslations.xml file included in the compressed (zip) file must be a file that was exported from the system and only edited to provide localized values. Other changes can invalidate the file. |
  
<a name="BKMK_uinstallingLanguage"></a>   
## Uninstall a language  
 Any localized labels provided for a language that is uninstalled remains in the system so that they are in place if the language is reinstalled.  
  
## Related information  
 [Product catalog tables](product-catalog-entities.md)  
[Translate customized table and column text](/power-apps/developer/data-platform/customize-labels-support-multiple-languages#translate-customized-table-and-column-text)
 [Translate product names and properties into multiple languages](/previous-versions/dynamicscrm-2016/admins-customizers-dynamics-365/mt826708(v=crm.8))


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
