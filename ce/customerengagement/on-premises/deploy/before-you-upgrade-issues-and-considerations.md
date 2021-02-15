---
title: "Before you upgrade: issues and considerations | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 89f41190-e266-450d-b3c9-95b09eef5f63
caps.latest.revision: 38
ms.author: matp
author: Mattp123
manager: kvivek
---
# Before you upgrade: issues and considerations



This topic describes how you can upgrade to Dynamics 365 for Customer Enagagement, version 9.0.  
  
<a name="BKMK_NotSupported"></a>   
### Microsoft Dynamics 2016 software and components not supported for upgrade  
 The following products and components can’t be upgraded during Setup. If you upgrade a [!INCLUDE[pn_crm_2016_legacy](../includes/pn-crm-2016-legacy.md)] system that includes the product or component listed, or you install these components after you install Dynamics 365, these products or solutions may not function correctly. We recommend that you uninstall or manually remove the component before you upgrade Dynamics 365 Server.  
  
-  Dynamics CRM 2016 Reporting Extensions 
  
-  Dynamics CRM 2016 Email Router  
  
  
<a name="BKMK_prevver"></a>   
## Upgrading from earlier versions of Microsoft Dynamics CRM Server 
 
 Earlier versions of Microsoft Dynamics CRM Server are not supported for in-place upgrade. However, you can migrate or in-place upgrade the older version by using a trial product key. For example, you can upgrade [!INCLUDE[pn_crm_2013_server](../includes/pn-crm-2013-server.md)] SP1 to [!INCLUDE[pn_crm_2015_server](../includes/pn-crm-2015-server.md)] using a trial product key, and then either migrate or in-place upgrade to [!INCLUDE[pn_crm_server_2016_legacy](../includes/pn-crm-server-2016-legacy.md)] also using using a trial product key. Finally, apply [December 2016 Update for Dynamics 365](https://www.microsoft.com/download/details.aspx?id=54515).  
  
## See Also  
 [Upgrading from Microsoft Dynamics 365](plan-your-upgrade-to-microsoft-dynamics-365-server.md)   




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]