---
title: "Configure an Internet-facing deployment | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: bec4c1f2-10c0-4e62-8a27-b7b6d2adfb0f
caps.latest.revision: 16
author: Mattp123
ms.author: matp
manager: kvivek
---
# Configure an Internet-facing deployment



Configuring an [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] lets users get to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] from the internet, outside the company firewall, without using a virtual private network (VPN). [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configured for internet access uses claims-based authentication to verify credentials of external users. When you configure [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for internet access, integrated Windows authentication must remain in place for users accessing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] through your LAN or WAN.  
  
> [!IMPORTANT]
>  Claims-based authentication is required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] access. If [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is deployed in the same domain where all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users are located or users are located in a trusted domain, claims-based authentication is not required for intranet [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] access.  
>   
>  Before you run the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)], a [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)], such as [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] must be available.
  
#### Configure Internet-facing deployment (IFD)  
  
1.  Start the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
2.  If you have not already done so, configure claims-based authentication.  
  
     [Configure claims-based authentication](configure-claims-based-authentication.md) 
  
3.  Open the Internet-Facing Deployment Configuration Wizard in one of two ways:  
  
    -   In the **Actions** pane, select **Configure Internet-Facing Deployment**.  
  
    -   In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, right-click **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**, and then select **Configure Internet-Facing Deployment**.  
  
4.  Review the page, and then select **Next**.  
  
5.  On the **Make [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] available to users who connect through the Internet** page, type the *domains* for the specified [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles, and then select **Next**.  
  
    > [!NOTE]
    > -   Specify domains, not servers.  
    > -   If your deployment is on a single server or servers in the same domain, the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] Domain** and **[!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] Domain** will be identical.  
    > -   The **[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] Domain** must be a subdomain of the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] Domain**. By default, "dev." is pre-pended to the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] Domain** to make the **[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] Domain**.  
    > -   The domains must be valid for the [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)] certificate's common name or names.  
  
     For more information about web addresses, see [Install Microsoft Dynamics CRM Server on multiple computers](https://technet.microsoft.com/library/hh699803.aspx).  
  
6.  In the **Enter the external domain where your Internet-facing servers are located** box, type the external domain information where your internet-facing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers are located, and then select **Next**.  
  
     The domain you specify must be a subdomain of the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] Domain** specified in the previous step. By default, "auth." is pre-pended to the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] Domain**.  
  
7.  On the **System Checks**  page, review the results, fix any problems, and then select **Next**.  
  
8.  On the **Review your selections and then click Apply** page, verify your selections, and then select **Apply**.  
  
9. Select **Finish**.  
  
10. If you experience issues connecting to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] through an external address, reset [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)].  
  
     Restart [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)]. To do this, select **Start**, select **Run**, type `IISRESET`, and then select **OK**.  
  
11. Configure relying parties for IFD.  
  
    > [!IMPORTANT]
    > You must configure a relying party for IFD. For more information, see [Configure the AD FS server for IFD](https://technet.microsoft.com/library/gg188600.aspx).  
  
## See also  
 [Configure claims-based authentication](configure-claims-based-authentication.md)   
 [Disable an Internet-facing deployment](disable-an-internet-facing-deployment.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]