---
title: "Dynamics 365 for tablets and IFD | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 5ae8ee8a-7161-429d-90f6-1300263a2679
caps.latest.revision: 11
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 for tablets and IFD



[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on-premises deployments require Internet Facing Deployment (IFD) for users to access their data on their tablets. If you have your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website available over the internet but it is not using the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] IFD configuration, **it is not supported**.  To verify that your on-premises deployment is configured for IFD, open [!INCLUDE[pn_Deployment_Manager_long](../includes/pn-deployment-manager-long.md)] on your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Server.  The Authentication Summary section should show that both Claims-Based Authentication and Internet-Facing Deployment are enabled.  
  
 ![Dynamics 365 IFD settings](media/crm-ua-moca-claims.png "Dynamics 365 IFD settings")  
  
> [!IMPORTANT]
>  For [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] to successfully connect to a new deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you must run a Repair of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on the server running [!INCLUDE[pn_iis](../includes/pn-iis.md)] where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role is installed *after* the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)] is successfully completed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Uninstall, change, or repair Microsoft Dynamics 365 Server](uninstall-change-repair-dynamics-365-server.md).  
  
## See Also  
 [Setup overview for mobile apps](/dynamics365/customer-engagement/mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets)   
 [Configure IFD for Microsoft Dynamics 365](configure-ifd-for-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]