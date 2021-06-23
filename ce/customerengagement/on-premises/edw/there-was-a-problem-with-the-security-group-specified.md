---
title: "There was a problem with the security group specified | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 7a2bdf7a-20e6-45c6-9b77-2f8a8298859c
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# There was a problem with the security group specified

## Cause 1 

Predefined security groups have been defined in the Setup XML file. However, one or more of the following security groups have not been specified:  
  
-   PrivUserGroup  
  
-   SqlAccessGroup  
  
-   ReportingGroup  
  
-   PrivReportingGroup  
  
 ## Cause 2
 
 The security group specified does not exist in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
 ## Cause 3
 
 The security group specified is not in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the computer that will run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
 ## Cause 4

 The group type is not security or the group scope is incorrect for a mixed-mode domain.  
  
## Solution 1

 Make sure that the security group is defined in the Setup XML. For more information about this [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup XML element, see [Sample server XML configuration file for installing with pre-created groups](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699720(v=crm.8)).  
  
## Solution 2

 Make sure that the group exists in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] and is in the same domain as the computer that will run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. Additionally, you must use the correct syntax, such as *CN=PrivUserGroup,OU=Dynamics 365 for Customer Engagement,DC=sales,DC=contoso,DC=com*.  
  
## Solution 3

 The security group specified must be located in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the computer that will run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
## Solution 4

 All groups used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] must be security groups. For mixed-mode domains, the group scope must be global.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]