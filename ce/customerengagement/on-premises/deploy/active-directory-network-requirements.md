---
title: "Active Directory and network requirements for Microsoft Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
ms.assetid: e3e8a7d4-54ac-423b-a168-2c28678f9ef6
caps.latest.revision: 24
author: Mattp123
ms.author: matp
manager: kvivek
---
# Active Directory and network requirements for Microsoft Dynamics 365 Customer Engagement (on-premises)




[!INCLUDE[pn_Active_Directory_Domain_Services](../includes/pn-active-directory-domain-services.md)] is a feature of the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] operating system. AD DS provides a directory and security structure for network applications such as [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 As with most applications that rely on a directory service, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] has dependencies that are important for operation, such as use of AD DS to store user and group information and to create application security.  
  
 [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] should only be installed on a [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] that is a domain member. The domain where the server is located must be running in one of the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain functional levels listed in the [Active Directory modes](software-requirements-for-microsoft-dynamics-365-server.md#Active_directory_modes) topic.  
  
## Federation and claims-based authentication support  
 When you configure [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for Internet-facing access it requires federated services that support claims-based authentication. We recommend [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] in [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn-ms-windows-server-long.md)].  
  
## Active Directory Federation Services  
 [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] is a highly secure, highly extensible, and Internet-scalable identity access solution that allows organizations to authenticate users from partner organizations. Using AD FS in [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn-ms-windows-server-long.md)], you can easily and very securely grant external users access to your organization’s domain resources. AD FS can also simplify integration between untrusted resources and domain resources within your own organization.  
  
 AD FS is available as a server role in [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)].  
  
## Digital certificates  
 [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] requires two types of digital certificates:  
  
-   **Claims encryption**. Claims-based authentication requires identities to provide an encryption certificate for authentication. This certificate should be trusted by the computer where you are installing [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], so it must be located in the local Personal store where the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] is running.  
  
-   **[!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] (HTTPS) encryption**. The certificates for [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] encryption should be valid for host names similar to org.contoso.com, auth.contoso.com, and dev.contoso.com. To satisfy this requirement you can use a single wildcard certificate (*.contoso.com), a certificate that supports subject alternative names, or individual certificates for each name. Individual certificates for each host name are only valid if you use different servers for each web server role. Multiple [!INCLUDE[pn_iis](../includes/pn-iis.md)] bindings, such as a website with two HTTPS or two HTTP bindings, aren’t supported for running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information about the options that are available to you, contact your certification authority service company or your certification authority administrator.  
  
 To meet these requirements, your organization should have a public key infrastructure or a contract with a digital certificate provider such as VeriSign, GoDaddy, or Comodo.  
  
## IPv6 Support  
 This version of  [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] works with IPv6 either alone or together with IPv4 within environments that have networks where IPv6 is supported.  
  
## See Also  
-   **Claims encryption**. Claims-based authentication requires identities to provide an encryption certificate for authentication. This certificate should be trusted by the computer on which you are installing [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], so it must be located in the local Personal store where the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] is running.  
  
-   **[!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] (HTTPS) encryption**. The certificates for [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] encryption should be valid for host names similar to org.contoso.com, auth.contoso.com, and dev.contoso.com. To satisfy this requirement, you can use a single wildcard certificate (\*.contoso.com), a certificate that supports subject alternative names, or individual certificates for each name. Individual certificates for each host name are only valid if you use different servers for each web server role. Multiple [!INCLUDE[pn_iis](../includes/pn-iis.md)] bindings, such as a website with two HTTPS or two HTTP bindings, aren’t supported for running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information about the options that are available to you, contact your certification authority service company or your certification authority administrator.  
  
 To meet these requirements, your organization should have a public key infrastructure or a contract with a digital certificate provider such as VeriSign, GoDaddy, or Comodo.  
  
## IPv6 support  
 This version of  [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] works with IPv6 either alone or together with IPv4 within environments that have networks where IPv6 is supported.  
  
## See also  
 [Prerequisites and considerations for planning your deployment of Dynamics 365](prerequisites-considerations-planning-deployment.md) <br />
 [Software requirements for Dynamics 365 Server](software-requirements-for-microsoft-dynamics-365-server.md)   <br />
 [SQL Server installation and configuration](sql-server-installation-and-configuration.md) 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]