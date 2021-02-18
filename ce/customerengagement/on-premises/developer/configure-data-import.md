---
title: "Configure data import (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Configuration information that is required for importing data is contained in the data import entity and the import source file entity. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - data importing, configuring
  - configuring data importing, tasks for
  - importing data, configuring
  - configuring data importing, by using the import (data import) and import file (import source file) entities
ms.assetid: e0b5bdd7-b307-4b26-9171-518cb00ed7b0
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure data import

The configuration information that is required for importing data is contained in the data import (`Import`) entity and the import source file (`ImportFile`) entity.  
  
 To configure data import, do the following:  
  
- Use the `Import.ModeCode` attribute to specify whether to create or update data during import. If you are using early bound types, you can use the `ImportModeCode` enumeration. For a list of the ModeCode values, see the picklist values for this entity. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
  
- Use the `ImportFile.FileTypeCode` attribute to specify the type of the import file. If you are using early bound types, you can use the `ImportFileType` enumeration. For a list of the FileTypeCode values, see the picklist values for this entity. This attribute is only available in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
- Use the `ImportFile.DataDelimiterCode` attribute to specify the single character data delimiter in the import file. If you are using early bound types, you can use the `ImportDataDelimiter` enumeration. For a list of the ImportDataDelimiter values, see the picklist values for this entity.  
  
- Use the `ImportFile.FieldDelimiterCode` attribute to specify the single character field delimiter in the import file. If you are using early bound types, you can use the `ImportFieldDelimiter` enumeration. For a list of the FieldDelimiterCode values, see the picklist values for this entity.  
  
- Set `ImportFile.IsFirstRowHeader` to `true` to indicate that the first row in the source file contains column headings or to `false` to indicate that the first row contains actual data. If set to `false`, default column headings are generated.  
  
- Set `ImportFile.ImportId` to the ID of the import (data import) that the import file is associated with.  
  
- Set `ImportFile.ImportMapId` to the ID of the associated import map (data map).  
  
- Set `ImportFile.EnableDuplicateDetection` to `true` to enable duplicate detection during data import.  
  
- Read the content of the source file into the `ImportFile.Content`.  
  
> [!IMPORTANT]
>  We do not recommend updating records by using data import programmatically. To update, use the data export and import capabilities of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Web application. Use **Export to Excel** to export records to an XML Spreadsheet 2003 (.xml) file. This is the only valid source file type for the Update mode. Re-importing data from the XML Spreadsheet 2003 (.xml) source file ensures that the data integrity in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is maintained. To import updated data, use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Import Data Wizard. For more information about the Import Data Wizard, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Help.  
  
### See also  
 [Import Data in Dynamics 365 Customer Engagement (on-premises)](import-data.md)   
 [Blog Post: How to Import attachments programmatically](https://blogs.msdn.com/b/crm/archive/2012/08/06/how-to-import-attachments-programmatically.aspx)   
 [Run Data Import](run-data-import.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]