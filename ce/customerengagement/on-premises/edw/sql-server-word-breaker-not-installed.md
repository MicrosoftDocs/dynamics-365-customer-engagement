---
title: "The SQL Server word breaker for the selected language is not installed | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 0ff70af7-ac3e-4dd9-a870-feaae03199c0
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The SQL Server word breaker for the selected language is not installed

## Cause
  
 The [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] word breakers component for full-text indexing is not installed or is not available. The default word breaker (neutral word breaker) will be used. The word breaker component is required for searching the knowledge base articles in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Solution
  
 This is a warning and Setup can continue. However, to resolve this issue, select one of the following options:  
  
-   Install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] full-text indexing. Word breakers are installed when you install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] full-text indexing. For more information about full-text search word breakers, see the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] documentation.  
  
-   If full-text indexing is installed, but the word breaker for the selected language is not installed or is not available, the word breaker for the default instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], which is English, will be used. Some third-party word breakers are supported with [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. Contact your vendor for more information. For more information about full-text search word breakers, see the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] documentation.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]