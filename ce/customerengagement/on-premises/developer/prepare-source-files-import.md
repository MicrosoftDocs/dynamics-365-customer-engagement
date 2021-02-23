---
title: "Prepare source files for import (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Data import supports source files formatted as comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files."
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
  - preparing source files for importing, providing maps for multiple-entity data
  - importing source files, preparing source files for importing
  - importing source files
  - preparing source files for importing, creating data source files
  - importing source files, creating data source files
  - preparing source files for importing, allowable separators for field values
  - preparing source files for importing, types of contents for allowable source files
  - preparing source files for importing, allowable characters for field values
ms.assetid: 78230676-f2ed-453a-aba0-887c860329e0
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Prepare source files for import

Before you can import data into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you must create the source data files.  
  
The data source files that you use in an import must be formatted as comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files. The use of source files enables the transfer of data from database systems that use different formats into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
A source file may contain data for one entity type or multiple entity types, such as accounts and contacts. For the source files that contain multiple entity data, you must provide a map that includes the `<EntitiesPerFile>` tag. Set the value of this tag to “Multiple” to indicate that there is more than one entity type in the source file. Add the `Dedupe = “Eliminate”` attribute to the `<EntityMap>` tag. This assures that if the file contains duplicate rows for the entity type, a single row is used to minimize lookup related errors.  
  
You can download an example of a data map with multiple entity types from [Microsoft Downloads: DataImportMaps.zip](https://download.microsoft.com/download/D/5/F/D5F73E15-439B-4EBC-BFFB-C6837B146C76/DataImportMaps.zip). Look at the `MapForSalesForceContactAccount.xml` file.  
  
 The field values in the source file can be separated by commas, tabs, or other characters that are defined in the `ImportFile.FieldDelimiterCode` attribute.  
  
> [!NOTE]
>  Do not use non-printable characters, **null** (\0) or break (\b), as delimiters for the field values.  
  
 The first row in the source file should contain column headings. If you do not include headings, use the `ImportFile.IsFirstRowHeader` attribute to specify that the first row represents actual data. In this case, default column headings are created with the names Col1, Col2, and so on.  
  
### See also  
 [Import Data in Dynamics 365 Customer Engagement (on-premises)](import-data.md)   
 [Create Data Maps](create-data-maps-for-import.md)   
 [Blog Post: How to Import attachments programmatically](https://blogs.msdn.com/b/crm/archive/2012/08/06/how-to-import-attachments-programmatically.aspx)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]