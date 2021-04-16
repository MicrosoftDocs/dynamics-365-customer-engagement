---
title: "Statistics are detected in the Microsoft Dynamics 365 for Customer Engagement database | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: bfa3e891-7563-4144-b5f5-50b66dc1a7ad
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Statistics are detected in the Microsoft Dynamics 365 for Customer Engagement database

## Cause
  
 Setup detected statistics in the existing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade. View the Setup log file for information about database objects that have been removed from the database during upgrade. Notice that the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] out-of-box reports will not work until they are installed.  
  
## Solution
  
 This is a warning and Setup can continue. However, during upgrade all statistics are deleted from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database tables.  
  
 In rare circumstances, statistics in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] METABASE tables can cause Setup to fail. If this happens, manually delete the statistics so that Setup can continue. For more information, see [Statistics](/sql/relational-databases/statistics/statistics?view=sql-server-2017).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]