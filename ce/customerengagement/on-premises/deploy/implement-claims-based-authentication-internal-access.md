---
title: "Implement claims-based authentication: internal access | Microsoft Docs"
description: Learn how to implement claims-based authentication for internal access with Dynamics 365 Customer Engagement (on-premises)
ms.custom: ""
ms.date: "02/23/2022"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: c2fe949d-e610-4210-9016-ef016657831c
caps.latest.revision: 19
ms.author: matp
author: Mattp123
---
# Implement claims-based authentication: internal access

Enabling claims-based authentication for internal access to [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] data involves the following steps:  
  
1.  Deploy and configure [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)].  
  
2.  Configure the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server for claims-based authentication.  
  
3.  Configure the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server for claims-based authentication.  
  
4.  Test internal claims-based authentication.  
  
 Claims-based authentication is not a requirement for intranet [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] access. However, claims-based authentication is required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] IFD access.  
  
## Known issue

### “An error occurred. Please try again or contact your system administrator if error persists” message returned in app and sitemap designers

When IFD is enabled, you can’t access the app designer or sitemap designer of a Unified Interface app using the IFD configured internal URL, such as `https://internalcrm.contoso.com/orgname`. You must use the external URL that has been configured for IFD such as `https://orgname.contoso.com`.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
