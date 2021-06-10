---
title: "Create data maps for import (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Data maps are required to import data, and contain mappings between the data contained in the source file and the respective entity attributes."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ceb6ccb2-8a9f-4d96-9f93-8d7281e127fa
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create data maps for import

To import data into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you must provide the appropriate data maps.  
  
 You can download examples of data maps from [Microsoft Downloads: DataImportMaps.zip](https://download.microsoft.com/download/D/5/F/D5F73E15-439B-4EBC-BFFB-C6837B146C76/DataImportMaps.zip).
  
 You use data maps to map the data contained in the source file to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] entity attributes. You must map every column in the source file to an appropriate attribute. The data in the unmapped columns is not imported during the data import operation.  
  
 The data map is represented by the import map (data map) entity. You can create a new map by using the <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message or update an existing map by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method. The map has a unique name that is contained in the `ImportMap.Name` attribute. You can specify the name of the import source for which this data map is created by using the `ImportMap.Source` attribute.  
  
<a name="BKMK_Column"></a>   
## Column, list value, and lookup mappings  
 To map a column, a list value, or lookup value in the source file to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] attribute, use the following mappings:  
  
 **Column Mapping**  
  
 Maps a column in a source file to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] entity attribute. For column mapping, use the column mapping (`ColumnMapping`) entity. You can use 1:1 (one-to-one) or 1:N (one-to-many) relationships between source and target attributes. For example, you can map account address information to the billing and shipping addresses in an order.  
  
 **List Value Mapping**  
  
 Maps a list value in a source file to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] attribute of the <xref:Microsoft.Xrm.Sdk.OptionSetValue> type. For list value mapping, use the picklist mapping (`PicklistMapping`) entity.  
  
 If a value specified in the source file column is a list value, such as an OptionSetValue, Status, State, and Boolean, you must provide a list value mapping additionally to a column mapping. For example, map the "bill" and "ship" list values in the source file to the bill and ship values of the <xref:Microsoft.Xrm.Sdk.OptionSetValue> type.  
  
 **Lookup Mapping**  
  
 Maps a lookup value in a source file to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] attribute of the <xref:Microsoft.Xrm.Sdk.EntityReference> type. For lookup mapping, use the lookup mapping (`LookupMapping`) entity.  
  
 If the value specified in the source file references an entity, you must provide a lookup mapping for this value. Use the `LookupMapping.LookupSourceCode` attribute to specify whether to search for the referenced entity inside the source file or inside [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. If you are using early bound types, you can use the `LookupSourceType` enumeration to set the lookup values. To search inside the source file, use the `LookupSourceType.Source` value. To search inside [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], use the `LookupSourceType.System` value. For a list of the LookupSourceCode values, see the picklist values for this entity. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)] You can provide multiple lookup mappings. The asynchronous transformation job processes all available mappings. It finds the referenced records and updates the parse table with the record unique identifiers. For more information, see [Run Data Import](run-data-import.md).  
  
<a name="BKMK_Owner"></a>   
## Owner mapping  
 Use owner mapping to map a user specified in the source file to a user in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For logging information, use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user logon name. For owner mapping, use the owner mapping (`OwnerMapping`) entity.  
  
<a name="BKMK_Notes"></a>   
## Notes and attachments  
 Mapping for notes and attachments is handled differently from other entities. Notes and attachments are used to append additional information to a record in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Notes are stored as text and attachments are stored as files in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database.  
  
 To create a note in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], set the `Annotation.IsDocument` attribute in the annotation (note) entity to `false`. To create an attachment, set `IsDocument` to `true`.  
  
 Use the following settings for mapping notes and attachments:  
  
- Set the `ColumnMapping.SourceAttributeName` attribute to “`true`” or “`false`”. The “`true`” value indicates an attachment. The “`false`” value indicates a note.  
  
- Set the `ColumnMapping.TargetAttributeName` attribute to `IsDocument`.  
  
- Set the `ColumnMapping.ProcessCode` attribute to the `ImportProcessCode.Internal` value of the `ImportProcessCode` enumeration, if you are using early bound types. For a list of the ProcessCode values, see the picklist values for this entity.  
  
  If the source data represents a note, map the text of the note to the `Annotation.NoteText` attribute. If you are working with Salesforce files, they are usually stored on the disk under unique identification numbers. To import an attachment, you must map a file identification number that is contained in the source file to the `Annotation.DocumentBody` attribute. The `DocumentBody` attribute stores the contents of the attachment.  
  
  The import asynchronous job checks for mappings that have the source attribute name set to “`true`” and “`false`” to discover notes and attachments. If it finds an attachment mapping, it looks for the specified files on the disk and uploads the file contents as attachments into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. If a file is not found, an error is returned.  
  
  If you do not provide mapping for an annotation (note) entity, the import job generates a default mapping for the note.  
  
> [!NOTE]
> [!INCLUDE[sdk_MaxUploadFileSize](../includes/sdk-maxuploadfilesize.md)] However, an attachment size cannot exceed the maximum HTTP request size (the default is 16MB). For the change to take effect, reset [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)]. To do this, click **Start**, click **Run**, type `iisreset`, and then click **OK**.  
  
<a name="BKMK_ImportExport"></a>   
## Import and export data maps  
 You can export an existing data map to an XML file and import XML data mappings into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. To export a data map from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], use the <xref:Microsoft.Crm.Sdk.Messages.ExportMappingsImportMapRequest> message. To import XML data mappings and create a data map in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], use the <xref:Microsoft.Crm.Sdk.Messages.ImportMappingsImportMapRequest> message.  
  
### See also  
 [Import Data in Dynamics 365 Customer Engagement (on-premises)](import-data.md)   
 [Add Transformation Mapping](add-transformation-mappings-import.md)   
 [Add Transformation Mappings for Import](add-transformation-mappings-import.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]