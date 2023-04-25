---
title: "iFrame and web resource support for mobile in Dynamics 365 Customer Engagement (on-premises)"
description: "You can add iFrames and web resources to forms and dashboards in a custom business app, and they'll appear in Dynamics 365 for phones and tablets as well."
ms.custom: 
ms.date: 12/04/2018
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: d4bcbe8e-75c5-4489-b8f1-50641a87f684
caps.latest.revision: 22
ms.author: matp
search.audienceType: 
  - customizer

---
# iFrame and web resource support for mobile

You can add iFrames and web resources in forms and dashboards in a custom business app, and they will appear in Dynamics 365 for tablets and phones as well. For example, if you add a news feed to a dashboard in a custom business app, the news feed will also appear in the tablet and phone app. 

For more information about using iFrames and web resources, see [Create web resources and iFrame content for use with the Dynamics 365 for tablets client](../developer/create-web-resources-iframe-mobile.md). 
  
> [!NOTE]
>  iFrames and web resources are supported on [!INCLUDE[tn_Apple_ipad](../includes/tn-apple-ipad.md)], [!INCLUDE[tn_android](../includes/tn-android.md)], and [!INCLUDE[pn_windows_10](../includes/pn-windows-10.md)] tablets. Tablets running Windows 8.1 and earlier are not supported.  
> 
> [!IMPORTANT]
> The option to add iFrames and web resources support for phones was introduced in the [!INCLUDE[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)].
  
## Known issues  
  
- You can't use popups for authentication or other purposes from within iFrames and web resources on [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for mobile.  
  
- Authentication for embedded sites isn't available.  
  
- Errors and memory leaks in iFrames and web resources can cause [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for mobile to stop responding, and can cause client side data loss.  
  
- Some iFrames and web resources can adversely affect application performance.  
  
- [!INCLUDE[pn_MS_Silverlight_full](../includes/pn-ms-silverlight-full.md)] and image web resources aren't available on [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for mobile.  
  
### See also  
 [Create web resources](create-edit-web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
