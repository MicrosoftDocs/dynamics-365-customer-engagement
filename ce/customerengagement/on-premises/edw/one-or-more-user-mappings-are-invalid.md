---
title: "One or more user mappings are invalid | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 97eace4e-604d-4267-926a-8011a7ca2b99
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# One or more user mappings are invalid

## Cause
  
 One or more user mapping are invalid. For example, either one of the following mappings is true:  
  
-   There is more than one [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user mapped to the same Active Directory account. You cannot map more than one [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user to the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] account.  
  
-   A user is cross-mapped between two different [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domains. Cross-mapping can occur when the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] user log-on name is mapped to a different user in the source domain where the same user log-on name exists. For example, cross-mapping can occur when:  
  
    -   You have two [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domains, such as DomainA, the target domain where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database will be imported to, and DomainB, the source domain where the organization database is from.  
  
    -   You map a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user, that has a user log-on name user1 from DomainB to a user from DomainA that has the user log-on name user2.  
  
    -   DomainA also has a user with the user log-on name user1.  
  
    -   You map any other [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user from DomainB, to user1 from DomainA.  
        In this scenario, any other users from DomainB cannot be mapped to user1 from DomainA.  
  
## Solution
  
 To resolve this issue, do the following:  
  
-   Make sure that each [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user is mapped to a single [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] account.  
  
-   If you have cross-mapped users, we recommend that you map together the users that have the same log-on name. After the import is complete you can change the user log-on name in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]