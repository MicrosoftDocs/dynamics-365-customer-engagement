---
title: "Import data (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Overview of the data import feature, which enables data upload from various customer relationship management systems and other data sources."
ms.custom: 
ms.date: 05/09/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - Import Data wizard, capabilities of the
  - importing data in Microsoft Dynamics CRM, data import defined
  - importing data in Microsoft Dynamics CRM, capabilities of the Import Data wizard
  - importing data in Microsoft Dynamics CRM, overview
  - importing data in Microsoft Dynamics CRM, uploading data from different CRM systems and sources into Microsoft Dynamics CRM
  - uploading data from different systems and sources into Microsoft Dynamics CRM
  - importing data in Microsoft Dynamics CRM, general tasks
ms.assetid: 4ab8f0b9-eb38-45b1-9026-b0415f1ab30e
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Import data

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

If you want to import data into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps, you can use the *data import* feature. Data import lets you upload data from various customer relationship management systems and data sources into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps. You can import data into standard and customized attributes of most business and custom entities. You can also include related data, such as notes and attachments.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps include a web application tool called Import Data Wizard. You use this tool to import data records from one or more comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files.  
  
 For more information about the Import Data Wizard, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps Help.  
  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web services provide the following additional capabilities that aren’t available in the Import Data Wizard:  
  
- Create data maps that include complex transformation mapping, such as concatenation, split, and replace.  
  
- Define custom transformation mapping.  
  
- View source data that is stored inside the temporary parse tables.  
  
- Access error logs to build custom error reporting tools with improved error logging views.  
  
- Run data import by using command-line scripts.  
  
- Add `LookupMap`XML tags in the data map to indicate that the data lookup will be initiated and performed on a source file that is used in the import.  
  
- Add custom `OwnerMetadata`XML tags in the data map to match the user records in the source file with the records of the user (system user) in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps.  
  
- Use optional validation checks.  
  
  > [!NOTE]
  >  Validation isn’t optional in the Import Data Wizard.  
  
  To implement data import, you typically do the following:  
  
- Create a comma-separated values (CSV), XML Spreadsheet 2003 (XMLSS), or text source file.  
  
- Create a data map or use an existing data map.  
  
- Associate an import file with a data map.  
  
- Upload the content from a source file to the associated import file.  
  
- Parse the import file.  
  
- Transform the parsed data.  
  
- Upload the transformed data into the target [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] apps server.  
  
  You can import data from one source file or several source files. A source file can contain data for one entity type or multiple entity types.  
  
  Parsing, transforming, and uploading of data is done by the asynchronous jobs that run in the background.  
  
> [!NOTE]
> By default, all custom entities are enabled for import. To determine if a business entity is enabled for import, see the entity metadata for the specific entity. If an entity is enabled for import, the entity metadata property `IsImportable` is set to `true`. The value of this property can’t be changed for the out-of-the-box business entities. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
>
> We recommend limiting your import to 20K rows or fewer.

## In This Section  
 [Prepare Source Files](prepare-source-files-import.md)  
  
 [Create Data Maps](create-data-maps-for-import.md)  
  
 [Add Transformation Mapping](add-transformation-mappings-import.md)  
  
 [Configure Data Import](configure-data-import.md)  
  
 [Run Data Import](run-data-import.md)  
  
 [Data Import Entities](data-import-entities.md)  
  
 [Sample: Export and Import a Data Map](sample-export-import-data-map.md)  
  
 [Sample: Import Data Using Complex Data Map](sample-import-data-complex-data-map.md)  
  
## Related Sections  
 [Data Management in Dynamics 365 for Customer Engagement apps](manage-data.md)
