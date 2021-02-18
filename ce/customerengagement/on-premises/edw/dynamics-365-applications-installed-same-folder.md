---
title: "Microsoft Dynamics 365 for Customer Engagement applications cannot be installed in the same folder | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 4d26c434-d40d-434c-8ad1-c7ca3e2f6063
caps.latest.revision: 5
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft Dynamics 365 for Customer Engagement applications cannot be installed in the same folder

## Cause
  
 [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] can be installed on the same computer, but cannot be installed in the same folder. However, we do not recommend installing both [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] on the same computer because of reduced server performance.  
  
 ## Solution
  
 To ensure these applications work correctly, if [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] are installed on the same computer, the program files must be installed in different folders. By default, the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] program files are installed in the C:\Program Files\Microsoft Dynamics 365 for Customer Engagement folder. To install [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], do not use the default folder as shown on the Install Location screen during Setup. Instead, manually change the install location to a different folder and then complete Setup.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]