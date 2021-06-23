---
title: "Import data (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Overview of the data import feature, which enables data upload from various customer relationship management systems and other data sources."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: nabuthuk
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

---
# Import data

If you want to import data into Dynamics 365 Customer Engagement (on-premises), you can use the *data import* feature. Data import lets you upload data from various customer relationship management systems and data sources into Dynamics 365 Customer Engagement (on-premises). You can import data into standard and customized attributes of most business and custom entities. You can also include related data, such as notes and attachments.  
  
Dynamics 365 Customer Engagement (on-premises) include a web application tool called Import Data Wizard. You use this tool to import data records from one or more comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files.  
  
 For more information about the Import Data Wizard, see Dynamics 365 Customer Engagement (on-premises) Help.  
  
 The Dynamics 365 Customer Engagement (on-premises) web services provide the following additional capabilities that aren’t available in the Import Data Wizard:  
  
- Create data maps that include complex transformation mapping, such as concatenation, split, and replace.  
  
- Define custom transformation mapping.  
  
- View source data that is stored inside the temporary parse tables.  
  
- Access error logs to build custom error reporting tools with improved error logging views.  
  
- Run data import by using command-line scripts.  
  
- Add `LookupMap`XML tags in the data map to indicate that the data lookup will be initiated and performed on a source file that is used in the import.  
  
- Add custom `OwnerMetadata`XML tags in the data map to match the user records in the source file with the records of the user (system user) in Dynamics 365 Customer Engagement (on-premises).  
  
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
  
- Upload the transformed data into the target Dynamics 365 Server.  
  
  You can import data from one source file or several source files. A source file can contain data for one entity type or multiple entity types.  
  
  Parsing, transforming, and uploading of data is done by the asynchronous jobs that run in the background.  
  
> [!NOTE]
> By default, all custom entities are enabled for import. To determine if a business entity is enabled for import, see the entity metadata for the specific entity. If an entity is enabled for import, the entity metadata property `IsImportable` is set to `true`. The value of this property can’t be changed for the out-of-the-box business entities. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
>
> We recommend limiting your import to 20K rows or fewer.

## Prepare for source files
 
Before you can import data into Dynamics 365 Customer Engagement (on-premises), you must create the source data files. The data source files that you use in an import must be formatted as comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files. The use of source files enables the transfer of data from database systems that use different formats into Dynamics 365 Customer Engagement (on-premises). To learn more, see [Prepare Source Files](/powerapps/developer/common-data-service/prepare-source-files-import) in the Dataverse documentation. 
  
## Create data maps

To import data into Dynamics 365 Customer Engagement (on-premises), you must provide the appropriate data maps. To learn more, see [Create Data Maps](/powerapps/developer/common-data-service/create-data-maps-for-import) in the Dataverse documentation.  
  
## Add transformation data

Use transformation mapping to modify data before importing it. For example, split a full name that is contained in the source file into a first name and a last name to match the target attributes for an entity. To learn more, see [Add Transformation Mapping](/powerapps/developer/common-data-service/add-transformation-mappings-import) in the Dataverse documentation.
  
## Data import

The configuration information that is required for importing data is contained in the data import (`Import`) entity and the import source file (`ImportFile`) entity. To learn more, see [Configure Data Import](/powerapps/developer/common-data-service/configure-data-import) in the Dataverse documentation. 
  
## Run data import

Data import runs directly on the Dynamics 365 Server. To run data import, set up asynchronous jobs to run in the background that do the following, in this order:

- Parse source data that is contained in the import file.
- Transform parsed data by using the data map.
- Upload transformed data into Dynamics 365 Customer Engagement (on-premises).
- All Dynamics 365 Customer Engagement (on-premises) users who have appropriate permissions can run data import. To learn more, see [Run Data Import](/powerapps/developer/common-data-service/run-data-import) in the Dataverse documentation.
  
## Data import entities

The Dynamics 365 Customer Engagement (on-premises) data import entities are used to create data maps, configure and run data imports, and log failure information. To learn more, see [Data Import Entities](/powerapps/developer/common-data-service/data-import-entities) in the Dataverse documentation.  
  
## Related Sections 

[Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)
[Sample: Export and Import a Data Map](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ExportImportDataMap)  
[Sample: Import Data Using Complex Data Map](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ImportComplexDataMap)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]