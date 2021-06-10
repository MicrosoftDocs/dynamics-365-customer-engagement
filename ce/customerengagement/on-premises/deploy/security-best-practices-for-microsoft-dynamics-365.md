---
title: "Security best practices for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 7f994f43-58d2-44c9-bbce-54baa3278d29
caps.latest.revision: 22
ms.author: matp
author: Mattp123
manager: kvivek
---
# Security best practices for Dynamics 365 Customer Engagement (on-premises)



[!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] is a mature web service that is included with [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] depends on an efficient and secure [!INCLUDE[pn_iis](../includes/pn-iis.md)] web service. Consider the following:  
  
-   In the `machine.config` and `web.config` configuration files you can determine whether debugging is enabled, and also if detailed error messages are sent to the client. You should make sure that debugging is disabled on all production servers, and that a generic error message is sent to the client if a problem occurs. This avoids unnecessary information about the web server configuration being sent to the client.  
  
-   Make sure that the latest operating system and [!INCLUDE[pn_iis](../includes/pn-iis.md)] service packs and updates are applied. For the latest information, see the [Microsoft Security](https://go.microsoft.com/fwlink/p/?linkid=92540) website.  
  
-   Dynamics 365 Server Setup creates application pools called **[!INCLUDE[ui_CRMAppPool](../includes/ui-crmapppool.md)]** and **[!INCLUDE[ui_CRMDeploymentServiceAppPool](../includes/ui-crmdeploymentserviceapppool.md)]** that operate under user credentials that you specify during Setup. To facilitate a least-privileged model, we recommend that you specify separate domain user accounts for these application pools instead of using the Network Service account. Additionally, we recommend that no other [!INCLUDE[pn_ASP.NET_short](../includes/pn-asp-net-short.md)]-connected application be installed under these application pools. For information about the minimum permissions required for these components, see [Minimum permissions required for Microsoft Dynamics 365 Setup and services](security-considerations-for-microsoft-dynamics-365.md#BKMK_MinimumPermissions).  
  
> [!IMPORTANT]
>  -   Make sure all websites that are running on the same computer as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website also have access to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] database.  
> -   If you use a domain user account, before you run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)], you may need to verify that the service principal name (SPN) is set correctly for that account, and if necessary, set the correct SPN. For more information about SPNs and how to set them, see [How to use SPNs when you configure Web applications that are hosted on IIS](https://go.microsoft.com/fwlink/p/?linkid=99582).  
  
## Service principal name management in Microsoft Dynamics 365  
 The service principal name (SPN) attribute is a multivalued, nonlinked attribute that is built from the DNS host name. The SPN is used during mutual authentication between the client and the server hosting a particular service. The client finds a computer account based on the SPN of the service that it’s trying to connect to.  
  
 The [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] installer deploys role-specific services and web application pools that operate under user credentials specified during [!INCLUDE[pn_Setup](../includes/pn-setup.md)]. To review the complete list of these roles and their permission requirements, see [Minimum permissions required for Microsoft Dynamics 365 Setup and services](security-considerations-for-microsoft-dynamics-365.md#BKMK_MinimumPermissions).  
  
 When you deploy a hosted [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] infrastructure, two of these roles may require additional consideration:  
  
-   [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)]  
  
-   Application Service  
  
 In web farm scenarios, as is the case for a hosted offering, the recommendation is to leave kernel-mode authentication enabled. In addition, you should closely consider using separate domain user accounts to run these services because:  
  
-   Having separate service accounts for these server roles facilitates being able to implement hardware load balancing.  
  
-   The [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] server role requires elevated permissions to provision organizations in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] database. If you want to adhere to a least-privileged model, the safest approach for implementing SPNs in a hosted [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] infrastructure involves having the [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] run under a different domain user account than the Application Service.  
  
 If you follow this suggestion to use separate domain accounts for these server roles, you should check to make sure that the SPN is correct for each account before you start Dynamics 365 Server Setup. This will make it easier for you to set the correct SPN when necessary.  
  
 If kernel-mode authentication is enabled, the SPNs will be defined for the machine account, regardless of the specified service account. When you implement a web farm, enable kernel-mode authentication and change the local **ApplicationHost.config** file.  
  
 If application and deployment web services are running on the same system, and kernel-mode authentication is disabled, you could configure both services to run under the same domain user account to prevent duplicate SPN issues. If you can’t enable kernel-mode authentication, install the Application and Deployment web services on separate systems. The SPNs may still need to be created manually since kernel-mode authentication is disabled.  
  
 <!-- For more information about SPNs and how to set them, see [Service Principal Name (SPN) checklist for Kerberos authentication with IIS 7.0/7.5](https://go.microsoft.com/fwlink/p/?linkid=213659)  -->
  
## See Also  
 [Security considerations for Microsoft Dynamics 365](security-considerations-for-microsoft-dynamics-365.md)   </br>
 [Microsoft Dynamics 365 administration best practices](best-practices-on-premises-deployments.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]