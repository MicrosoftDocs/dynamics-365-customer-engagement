---
title: "Import data (all record types)  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 4483edc9-999d-4761-a9d1-d18fc130b615
caps.latest.revision: 19
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin

---
# Import data (all record types) from multiple sources

Importing data is often the first important task that you need to perform after you have installed Customer Engagement. You can import data from various [Dynamics 365 Customer Engagement (on-premises) systems and data sources into standard and customized fields of most business and custom entities in Customer Engagement (on-premises). You can include related data, such as notes and attachments. To assure data integrity, you can enable duplicate detection that prevents importing duplicate records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Detect duplicate data](../admin/detect-duplicate-data.md). For more complex data import scenarios, you can write code using the data import web service. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Import data using web services](../developer/import-data.md).
  
 Preliminary steps before you import the data into Customer Engagement (on-premises) include:  
  
1. Preparing source data files in one of the following formats: comma-separated values (.csv), XML Spreadsheet 2003 (.xml), Compressed (.zip) or text files. You can import data from one source file or several source files. A source file can contain data for one entity type or multiple entity types.  
  
2. Preparing data maps for mapping data contained in the source file to the Customer Engagement (on-premises) record fields. You must map every column in the source file to an appropriate field. Unmapped data isn’t imported. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Select a data map](../basics/select-data-map.md)  
  
There are several ways to import data into Customer Engagement (on-premises):  

> [!NOTE]
> We recommend limiting your import to 20K rows or fewer.
  
1. To import large volumes of data, we recommend a programmatic way, as most efficient. When you import data programmatically, you gain additional capabilities that are not available when you use other methods of importing data. These advanced capabilities include viewing stored source data, accessing error logs and creating data maps that include complex transformation mapping, such as concatenation, split, and replace. See [Import data](../developer/import-data.md).
  
2. For smaller import jobs, you can use the Import Data Wizard tool included in the Customer Engagement (on-premises) web application. For information about the Import Data Wizard or how to import specific record types, see [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md).  
  
   > [!NOTE]
   >  For the Import Data Wizard, the maximum file size for .zip files is 32 MB; for the other file formats, it’s 8 MB.  
   > 
   >  With the Import Data Wizard, you can specify the “Map Automatically” option. The wizard automatically maps all the files and the column headings with Customer Engagement (on-premises) record types and fields if:  
   > 
   > - The file names exactly match the display name of the record type.  
   >   -   The column headings of the file you are importing exactly match the display names of the fields in the record.  
  
3. To add data for an individual record, the quickest way is to use **Quick Create** from the nav bar or **New** from the entity form.  
  
### See also  
 [Detect duplicate data](../admin/detect-duplicate-data.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]