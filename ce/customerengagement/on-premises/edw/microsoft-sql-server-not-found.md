---
title: "Microsoft SQL Server not found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: b611cc51-afe7-4aeb-a057-1e5dff466c25
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft SQL Server not found

## Cause
  
 Setup cannot find the specified [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. The following causes are possible reasons for this failure:  
  
-   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is not installed on the specified computer or the edition installed is not supported.  
  
-   The edition of Windows Server installed is not supported.  
  
-   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] (MSSQLSERVER) service is not started (and set to automatic) on the specified computer.  
  
-   If [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is installed on a different computer from [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], a network connectivity problem may be preventing this test from completing.  
  
 ## Solution
  
 Verify the following conditions and then run Setup again:  
  
-   The specified computer has [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] installed and the version is supported. See [SQL Server edition](sql-server-edition.md). If the version you are running is earlier than the versions in the list, you must upgrade the computer.  
  
-   The specified computer has [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)] or [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)] 64-bit or later version installed.  
  
-   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service is started (and set to automatic) on the specified computer. See the procedure later in this topic.  
  
-   If [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is installed on a different computer, verify network connectivity.  
  
### Start [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] services  
  
1.  Enter *services.msc* in the search box and press **Enter**.  
  
2.  Right-click **[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] (MSSQLSERVER)**, and then select **Start**.  
  
3.  Close the Services application.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]