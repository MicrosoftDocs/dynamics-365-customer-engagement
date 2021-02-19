---
title: "The full-text indexes on the Microsoft Dynamics 365 for Customer Engagement database are not consistent with previous versions full-text indexes | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: a8c46a63-ef00-4ccf-8893-ee362598f230
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The full-text indexes on the Microsoft Dynamics 365 for Customer Engagement database are not consistent with previous versions' full-text indexes

## Cause
  
 The indexes in the current [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database are not consistent with the previous version database indexes. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the previous version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade. View the Setup log file for information about database objects that have been removed from the database during upgrade. Notice that the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] out-of-box reports will not work until they are installed.  
  
 ## Solution
  
 If the upgrade does not successfully complete, contact Microsoft Customer Support Services. For a complete list of Microsoft Customer Support Services telephone numbers and information about support costs, visit the Microsoft [Help and Support Contact](https://go.microsoft.com/fwlink/p/?LinkId=99244) webpage.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]