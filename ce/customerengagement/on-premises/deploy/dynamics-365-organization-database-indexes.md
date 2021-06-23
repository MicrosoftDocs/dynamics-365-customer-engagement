---
title: "Dynamics 365 Customer Engagement (on-premises) organization database indexes | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 51961448-d371-4cbd-a531-c98f0c7a99d6
caps.latest.revision: 6
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 Customer Engagement (on-premises) organization database indexes



The indexes that are created in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database are designed to provide fast retrieval of commonly requested data from tables and views stored on a [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]. Here are a few characteristics for the indexes that are created in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database.  
  
-   Depending on the version and update applied, a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database without any customizations or installed solutions (out-of-box database) has between 1,000 and 1,600 total indexes.  
  
-   Later versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] have more features and, subsequently, more database objects such as tables and indexes.  
  
-   At least five new indexes are created whenever you create a new entity or reference a new column in a quick find.  
  
-   Installing a solution increases the number of total indexes.  
  
## How to get a list of all indexes stored in an organization database  
 To get a list of all indexes, run the following sample SQL query against the organization database.  
  
```  
SELECT s.name +'.'+t.name AS 'table_name',i.name,i.index_id  
FROM sys.schemas s JOIN sys.tables t ON s.schema_id=t.schema_id  
JOIN sys.indexes i ON t.object_id=i.object_id LEFT OUTER  JOIN sys.objects o   
ON o.parent_object_id=t.object_id AND i.name=o.name  
WHERE i.name is not null  
  
```  
  
 For an approximation of the out-of-box indexes in an organization database that corresponds to a specific version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], select from these links to download [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] worksheets that contain lists of indexes.  
  
-   [Microsoft Download Center: List of Dynamics CRM 2016 RTM out-of-box indexes](https://download.microsoft.com/download/A/2/1/A215C09C-2BCD-42B1-869F-57C137E32AC4/CRM2016RTMIndexes.xlsx)  
  
-   [Microsoft Download Center: List of Dynamics CRM 2015 Update 0.2 out-of-box indexes](https://download.microsoft.com/download/A/2/1/A215C09C-2BCD-42B1-869F-57C137E32AC4/CRM2015UR0.2Indexes.xlsx)  
  
-   [Microsoft Download Center: List of Dynamics CRM 2013 Service Pack 1 out-of-box indexes](https://download.microsoft.com/download/A/2/1/A215C09C-2BCD-42B1-869F-57C137E32AC4/CRM2013SP1UR2Indexes.xlsx)  
  
-   [Microsoft Download Center: List of Dynamics CRM 2011 Update Rollup 18 out-of-box indexes](https://download.microsoft.com/download/A/2/1/A215C09C-2BCD-42B1-869F-57C137E32AC4/CRM2011UR18Indexes.xlsx)  
  
 For more information about [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] indexes, see [SQL Server Index Architecture and Design Guide]/sql/relational-databases/sql-server-index-design-guide?view=sql-server-2016).  
  
## See Also  
 [Operating Microsoft Dynamics 365 Customer Engagement (on-premises)](operating-microsoft-dynamics-365.md) </br>  
 [Microsoft Dynamics 365 Customer Engagement (on-premises) data protection and recovery](microsoft-dynamics-365-data-protection-and-recovery.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]