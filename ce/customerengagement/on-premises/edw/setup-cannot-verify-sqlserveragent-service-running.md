---
title: "Setup cannot verify that the SQLSERVERAGENT service is running on the specified computer | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 84cc701b-1157-4139-9813-d575401665b7
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Setup cannot verify that the SQLSERVERAGENT service is running on the specified computer

## Cause
  
 The causes of this error message are as follows:  
  
-   The user who is running Setup does not have local administrator permissions for the computer on which [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] is running.  
  
-   The SQLSERVERAGENT service is not running on the specified computer where [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running.  
  
 ## Solution
  
### Verify permission or start the SQLSERVERAGENT service  
  
-   Verify that you have local administrator permissions for the computer on which [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running, and if it is necessary, grant the necessary permissions.  
  
-   Verify the SQLSERVERAGENT service is running on the computer on which [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running. If the service is not running, start it.  
  
### Start the SQLSERVERAGENT service  
  
1.  In the search box enter *services.msc*, and then press **ENTER**.  
  
2.  Right-click **SQL Server Agent (MSSQLSERVER)**, and then select **Start**.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]