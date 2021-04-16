---
title: "Indexes on the Microsoft Dynamics 365 for Customer Engagement database are not consistent | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9a96d3c7-7d16-4c39-907f-5b6a23777049
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Indexes on the Microsoft Dynamics 365 for Customer Engagement database are not consistent

## Cause
  
 The indexes in the current [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database are not consistent with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] previous version database indexes. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade. View the Setup log file for information about database objects that have been removed from the database during the upgrade. Notice that the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] out-of-box reports will not work until they are installed.  
  
 ## Solution
  
 If the upgrade does not successfully complete, contact Microsoft Customer Support Services. For a complete list of Microsoft Customer Support Services telephone numbers and information about support costs, visit the Microsoft [Help and Support Contact](https://go.microsoft.com/fwlink/p/?LinkId=99244) webpage.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]