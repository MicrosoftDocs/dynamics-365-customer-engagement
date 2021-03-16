---
title: "Active Directory organizational unit cannot be found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 0075dd46-f150-4c46-9204-4af5e73eaa00
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Active Directory organizational unit cannot be found

## Cause
  
 Setup could not find the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] organizational unit. There can be several causes for this, including the following reasons:  
  
-   The specified [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] organizational unit does not exist.  
  
-   The specified [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] organizational unit is invalid.  
  
-   There is a problem with resolving the organizational unit name in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
 ## Solution
  
 Verify the organizational unit exists, is valid, and has a name that can be resolved. Perform the following steps on the computer on which you are running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup.  
  
### Verify the organizational unit  
  
1.  Select **Start**, type dsa.msc or select **Run** and type dsa.msc, and then press Enter.  
  
2.  Expand the domain, and then locate the organizational unit that you want. If there is a problem connecting to the domain, you must correct the problem before you can complete Setup. A likely cause of domain-controller connection problems is domain name server (DNS) resolution issues.  
  
3.  After you verify you can connect to the organization unit, close [!INCLUDE[pn_Active_Directory_Users_Computers](../includes/pn-active-directory-users-computers.md)], and then continue running Setup.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]