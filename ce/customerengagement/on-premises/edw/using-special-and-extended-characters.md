---
title: "Using special and extended characters | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: bb43b8b3-a439-470f-8cf4-fe14876d14dd
caps.latest.revision: 11
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Using special and extended characters
The following table lists the requirements for using special and extended characters in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] features:  
  
-   Special characters, including ! @ # $ % ^ & * ( ) - [ ] { }/ \ &#124; \` ~ \< > ' " ; : ? , . (period) and \<Alt> + \<number>.  
  
-   Some language-specific characters.  
  
-   Characters between decimal numbers 128 and 255 of the ASCII character chart.  
  
|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Feature|Requirement|  
|-----------------------------------------------------------------------------|-----------------|  
|Naming the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]|Some DNS servers cannot recognize server names that use characters between decimal numbers 128 and 255 of the ASCII character chart.|  
|All [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] features|Special characters / \ &#124; : * ? ‘ “ \< > ; - . and empty spaces should not be used:<br /><br /> -   In the folder name or path to the folder where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] features are installed.<br />-   In the folder name of the Microsoft Dynamics 365 for Customer Engagement website.|  
|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user names|All valid characters accepted by [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] can be used, except the ampersand (&).|  
|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] custom attribute names|Special characters / \ &#124; : * ? ‘ “ \< > ; - . and empty spaces cannot be used.|  
|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data|All special and extended characters can be used in the data stored in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.|



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]