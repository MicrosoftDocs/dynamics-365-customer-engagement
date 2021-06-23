---
title: "Test internal claims-based authentication | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f02dd026-70aa-4024-8491-42eeeca051df
caps.latest.revision: 22
ms.author: matp
author: Mattp123
manager: kvivek
---
# Test internal claims-based authentication



You should now be able to access [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] internally using claims authentication. Browse to the internal [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] webpage (for example, https://internalcrm.contoso.com).  
  
 You will be required to log on several times to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] webpage. Subsequent visits to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website will only require one log on. In the browser, notice that the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] URL is loaded and then directed back to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.  
  
## Troubleshooting  
 If the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website does not display, at a command prompt, run the `iisreset` command, and then try browsing to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website again.  
  
 Try adding the following sites to your Trusted sites in your browser:  
  
-   https://sts1.contoso.com – change to what use in DNS  
  
-   https://internalcrm.contoso.com – change to what you use in DNS  
  
## See Also  
 [Implement claims-based authentication: internal access](implement-claims-based-authentication-internal-access.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]