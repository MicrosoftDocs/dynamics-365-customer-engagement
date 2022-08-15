---
title: "Triggers are detected in the Microsoft Dynamics 365 for Customer Engagement database | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 890850e8-bee3-437a-9b2e-5037dd6ac57a
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Triggers are detected in the Microsoft Dynamics 365 for Customer Engagement database

## Cause
  
 Setup detected triggers in the existing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database. Setup will try to re-create or remove these database objects during the upgrade. However, in certain situations this can cause the upgrade to fail. Note that if these database objects have been manually added to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, they may be removed during the upgrade.  
  
## Solution
  
 This is a warning and Setup can continue. However, in some circumstances triggers can cause the upgrade to fail. We recommend that you remove all triggers from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases before you continue running Setup. After Setup is complete you can add them back.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]