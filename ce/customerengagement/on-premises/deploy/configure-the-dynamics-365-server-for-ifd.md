---
title: "Configure the Microsoft Dynamics 365 server for IFD | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 45ccc7e6-39a9-4ced-aaee-2ffc3b8024de
caps.latest.revision: 16
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure the Microsoft Dynamics 365 server for IFD



With internal claims authentication access enabled on [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you can now enable external claims access through IFD.  
  
## Configure an Internet-facing deployment using the Configure Internet-Facing Deployment Wizard  
  
1.  Start the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
2.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, right-click **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**, and then select **Configure Internet-Facing Deployment**.  
  
3.  Select **Next**.  
  
4.  On the **Make [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] available to users who connect through the Internet** page, type the domains for the specified [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles, and then select **Next**.  
  
    > [!IMPORTANT]
    >  -   Specify domains, not servers.  
    > -   If your deployment is on a single server or on servers that are in the same domain, the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] domain and [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] domain will be identical.  
    > -   The [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] domain must be a resolvable host name and not a root domain. For example: dev.contoso.com.  
    > -   The [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] domain must not match an organization's Fully Qualified Domain Name (FQDN). For example, the [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] domain should not be: orgname.contoso.com.  
    > -   The domains must be valid for the [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] certificate's common name or names.  
    > -   The domains must be set to resolve correctly in DNS to your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers holding the server roles.  
    > -   The domains can be in a different domain than the domain which the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers reside.  
    >   
    >  Example domains:  
    >   
    >  -   [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] domain: **contoso.com**  
    > -   [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] domain: **contoso.com**  
    > -   [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] domain: **dev.contoso.com**  
  
     With the example settings above, if your organization name was "orgname", clients would access your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website with the following URL: **https://orgname.contoso.com**.  
  
     ![Configure IFD server role domains](media/crm-itpro-claimswp-configifd.PNG "Configure IFD server role domains")  
  
5.  In the **Enter the external domain where your Internet-facing servers are located** box, type the external domain information where your Internet-facing [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] servers are located, and then select **Next**.  
  
     The domain you specify must be a sub-domain of the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] domain specified in the previous step. By default, "auth." is pre-pended to the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] domain.  
  
    > [!IMPORTANT]
    >  -   The external domain is used by the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server when retrieving the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] IFD federationmetadata.xml file.  
    > -   The external domain must not contain an organization name.  
    > -   The external domain must not contain an underscore character (“_”).  
    > -   The external domain must be valid for the [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] certificate's common name or names.  
    > -   The external domain must be set to resolve correctly in DNS to your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server holding the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role.  
  
     Example domain:  
  
    -   External domain: **auth.contoso.com**  
  
     ![Configure IFD external domain](media/crm-itpro-claimswp-configifdext.PNG "Configure IFD external domain")  
  
6.  On the **System Checks** page, review the results, fix any problems, and then select **Next**.  
  
7.  On the **Review your selections and then click Apply** page, verify your selections, and then select **Apply**.  
  
8.  Select **Finish**.  
  
9. Run the following command at a command prompt: *iisreset*  
  
10. If you have not already done so, add host records in DNS for the IFD endpoints (for example: orgname.contoso.com, auth.contoso.com, dev.contoso.com)  
  
#### To Configure an Internet-facing deployment using Windows PowerShell  
  
1.  Open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] prompt.  
  
2.  Add the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)][!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] snap-in:  
  
    ```  
    PS > Add-PSSnapin Microsoft.Crm.PowerShell   
    ```  
  
3.  Get the IFD settings:  
  
    ```  
    PS > $ifd = Get-CrmSetting -SettingType "IfdSettings"  
    ```  
  
4.  Configure the IFD object:  
  
    ```  
    PS > $ifd.Enabled = 1 (or $true) PS > $ifd.DiscoveryWebServiceRootDomain = Discovery_Web_Service_DomainPS > $ifd.ExternalDomain = External_Server_DomainPS > $ifd.OrganizationWebServiceRootDomain= Organization_Web_Service_DomainPS > $ifd.WebApplicationRootDomain = Web_Application_Server_Domain  
    ```  
  
     where:  
  
    -   1 = "true".  
  
    -   Discovery_Web_Service_Domain is the [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] domain.  
  
    -   External_Server_Domain is the external server domain.  
  
    -   Organization_Web_Service_Domain is the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] domain.  
  
    -   Web_Application_Server_Domain is the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] domain.  
  
     For the domain paths, the values for the paths must be in the form:  
  
     server:port  
  
     or  
  
     server.domain.tld:port,  
  
     where:  
  
    -   *server* is the computer name  
  
    -   *domain* is the complete sub domain path where the computer is located  
  
    -   *tld* is the top level domain, such as com or org  
  
    -   The *:port* designation is required if you are not using the standard http port (80) or https port (443).  
  
     Typically, in a Full Server or Front-end Server role deployment, the path values are the same. However, if you deploy [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on multiple servers with separate server roles, that is, where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)], [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)], or [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] server roles are located on different servers, these path values will be different:  
  
    -   [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]. WebApplicationServerName.domain.tld:port  
  
    -   [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]. OrganizationWebServiceServerName.domain.tld:port  
  
    -   [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]. DiscoveryWebServiceServerName.domain.tld:port  
  
5.  Set the Internet-facing deployment object.  
  
    ```  
    PS > Set-CrmSetting $ifd  
    ```  
  
## See Also  
 [Implement claims-based authentication: external access](implement-claims-based-authentication-external-access.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]