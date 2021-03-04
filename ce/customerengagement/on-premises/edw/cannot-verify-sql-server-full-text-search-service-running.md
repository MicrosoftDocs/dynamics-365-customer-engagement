---
title: "Setup cannot verify that the SQL Server Full-Text Search Service is running | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: dcd7bf41-86d8-4055-88d8-7e1cdebf3547
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Setup cannot verify that the SQL Server Full-Text Search Service is running

## Cause
  
 Setup cannot verify that the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] Full-Text Search service is running. This service is required for searching articles in the knowledge base in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. The service is named **[!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] FullText Search (MSSQLSERVER)**. This issue can occur when either, or both, of the following situations are true:  
  
-   The [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] Full-Text Search service is not running on the specified computer.  
  
-   You do not have the needed permissions for the specified computer.  
  
 ## Solution
  
### Start the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] Full-Text Search service  
  
1.  Select **Start**, point to **Administrative Tools**, and then select **Services**.  
  
2.  Right-click **SQL Server FullText Search (MSSQLSERVER)**, and then select **Start**.  
  
3.  Close the Services application.  
  
### Verify permission  
  
-   Verify that you have local administrator permissions for the computer on which [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] is running, and if it is necessary, grant the needed permissions.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]