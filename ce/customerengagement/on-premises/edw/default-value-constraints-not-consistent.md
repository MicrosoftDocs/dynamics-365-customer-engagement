---
title: "Default value constraints are not consistent for upgrade | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 694ae64b-4da2-4e59-9c47-0a9f41dadf28
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Default value constraints are not consistent for upgrade

## Cause
  
 The current default value constraints are not consistent with the originally installed [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system database default-value constraints. This is a warning and Setup can continue. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade.  
  
## Solution
  
 If the upgrade does not successfully complete, contact Microsoft Customer Support Services. For a complete list of Microsoft Customer Support Services telephone numbers and information about support costs, visit the Microsoft [Help and Support Contact](https://go.microsoft.com/fwlink/p/?LinkId=99244) webpage.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]