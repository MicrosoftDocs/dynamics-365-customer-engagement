---
title: "Microsoft SQL Server and Microsoft Dynamics 365 Server must be in the same domain | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 2b0bbb6b-753d-41c7-b958-b9c5042e05b4
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft SQL Server and Microsoft Dynamics 365 Server must be in the same domain

## Cause
  
 [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and the instance of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] that is being used for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data must be in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service domain.  
  
## Solution
  
 Make sure that the computer you are trying to connect to (the one that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]) is in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]