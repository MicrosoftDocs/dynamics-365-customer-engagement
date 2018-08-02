---
title: "iFrame and web resource support in Dynamics 365 for tablets | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
author: "mduelae"
ms.assetid: d4bcbe8e-75c5-4489-b8f1-50641a87f684
caps.latest.revision: 24
ms.author: "mkaur"
manager: "kvivek"
---
# iFrame and web resource support in Dynamics 365 for tablets

[!INCLUDE[cc-applies-to-update-8-2-0](../../../../includes/cc_applies_to_update_8_2_0.md)]

You can add iFrames and web resources in forms and dashboards in the [!INCLUDE[pn_microsoftcrm](../../../../includes/pn-microsoftcrm.md)] web app, and they will appear in [!INCLUDE[pn_moca_short](../../../../includes/pn-moca-short.md)] as well. For example, if you add a news feed to a dashboard in the web app, the news feed will also appear in the tablet app. For more information about using iFrames and web resources, see [MSDN: Create web resources and iFrame content for use with the Dynamics 365 for tablets client](https://msdn.microsoft.com/library/dn858562.aspx).  
  
> [!NOTE]
>  iFrames and web resources are supported on [!INCLUDE[tn_Apple_ipad](../../../../includes/tn-apple-ipad.md)], [!INCLUDE[tn_android](../../../../includes/tn-android.md)], and [!INCLUDE[pn_windows_10](../../../../includes/pn-windows-10.md)] tablets. Tablets running Windows 8.1 and earlier are not supported.  
> 
> [!IMPORTANT]
>  [!INCLUDE[cc_feature_included_with_update_2016](../../../../includes/cc-feature-included-with-update-2016.md)]  
  
## Known issues  
  
- You can’t use popups for authentication or other purposes from within iFrames and web resources on [!INCLUDE[pn_moca_short](../../../../includes/pn-moca-short.md)].  
  
- Authentication for embedded sites isn’t available.  
  
- Errors and memory leaks in iFrames and web resources can cause [!INCLUDE[pn_moca_short](../../../../includes/pn-moca-short.md)] to stop responding, and can cause client side data loss.  
  
- Some iFrames and web resources can adversely affect application performance.  
  
- [!INCLUDE[pn_MS_Silverlight_full](../../../../includes/pn-ms-silverlight-full.md)] and image web resources aren’t available on [!INCLUDE[pn_moca_short](../../../../includes/pn-moca-short.md)].  
  
### See also  
 [MSDN: Create web resources and iFrame content for use with the Dynamics 365 for tablets client](https://msdn.microsoft.com/library/dn858562.aspx)
