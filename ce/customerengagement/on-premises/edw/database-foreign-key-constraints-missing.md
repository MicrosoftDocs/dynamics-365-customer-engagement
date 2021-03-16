---
title: "Microsoft Dynamics 365 for Customer Engagement database foreign key constraints are missing | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 29424c71-4e80-4ec4-a440-6fb734ec6c34
caps.latest.revision: 9
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft Dynamics 365 for Customer Engagement database foreign key constraints are missing
The original system database table foreign key constraints from the previous version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] are missing.  
  
## Cause
  
 The system database foreign key constraints that were originally installed were not found. This is a warning and Setup can continue. Setup will try to re-create the foreign key constraints during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that foreign key constraints that have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database may be removed during the upgrade.  
  
 ## Solution
  
 If the upgrade does not successfully complete, contact Microsoft Customer Support Services. For a complete list of Microsoft Customer Support Services telephone numbers and information about support costs, visit the Microsoft [Help and Support Contact](https://go.microsoft.com/fwlink/p/?LinkId=99244) webpage.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]