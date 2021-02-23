---
title: "Setup cannot find the Dynamics 365 for Customer Engagement database primary key constraints | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 470bc02b-ea44-49af-a6f7-2e08337f6a5f
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Setup cannot find the Microsoft Dynamics 365 for Customer Engagement database primary key constraints
The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] previous version system database table primary key constraints are missing. This is a warning and Setup can continue.  
  
 ## Cause
  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system database primary key constraints that were originally installed were not found. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade.  
  
 ## Solution
  
 If the upgrade does not successfully complete, contact Microsoft Customer Support Services. For a complete list of Microsoft Customer Support Services telephone numbers and information about support costs, visit the Microsoft [Help and Support Contact](https://go.microsoft.com/fwlink/p/?LinkId=99244) webpage.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]