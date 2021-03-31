---
title: "Software requirements for Dynamics 365 Server | Microsoft Docs"
ms.custom: ""
ms.date: "05/15/2019"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 1f5d3be8-bec4-44b2-86c7-e4dbd18a8eae
caps.latest.revision: 91
author: Mattp123
ms.author: matp
manager: kvivek
---
# Software requirements for Microsoft Dynamics 365 Server

This topic lists the software and application requirements for this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  

::: moniker range="op-9-1"
## Windows Server operating system

 This version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] can be installed only on [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] 64-bit-based computers. The specific versions and editions of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] that are supported for installing and running this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] are listed in the following sections.  
  
> [!IMPORTANT]
>  The following [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] versions are not supported for installing and running this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]:  
>   
> -   [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Essentials  
> -   [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)]  family of operating systems  
>  -   [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] family of operating systems   
> -   The [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)] family of operating systems  

  
### Supported Windows Server editions
 The following editions of the [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] operating system are supported for installing and running [!INCLUDE[pn_crm_2016_server](../includes/pn-crm-2016-server.md)]:  

- Windows Server 2019 Standard
- Windows Server 2019 Datacenter
- [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Standard
- [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Datacenter  
  
### Server Core installations  
 With the exception of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] roles, you can install any [!INCLUDE[pn_microsoft_dynamics_crm_2016_server](../includes/pn-microsoft-dynamics-crm-2016-server.md)] server role on a Server Core installation of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]. Server Core is a minimal server installation option for the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] family of operating systems. Server Core provides a low-maintenance server environment with limited functionality. For more information about Server Core as implemented on [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)], see [Server Core for Windows Server 2016](https://docs.microsoft.com/windows-server/get-started/sconfig-on-ws2016)  
  
> [!IMPORTANT]
>  To install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] on a Server Core [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], you must run Setup in silent mode from the command line. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the command prompt to install Microsoft Dynamics 365 Server](use-command-prompt-install-dynamics-365-server.md)  -->
>   
>  The [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] role cannot be installed on a Windows Server running as Server Core.  
>   
>  [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)] cannot be installed on Server Core. This is because [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], which is required by [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)], cannot be installed on a Windows Server running Server Core.  
  
<a name="Server_virtualization"></a>   
## Server virtualization  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers can be deployed in a virtualized environment by using Windows Server with [!INCLUDE[pn_Hyper-V](../includes/pn-hyper-v.md)] or virtualization solutions from vendors who participate in the Microsoft Windows Server Virtualization Validation Program (SVVP). You must understand the limitations and best practices of server virtualization before you try to virtualize your deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].   
  
<a name="Active_directory_modes"></a>   
## Active Directory modes  
 The computer that [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is running on must be a member of a domain that is running in one of the following [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service forest and domain functional levels:  
  
-   [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)]  
  
-   [!INCLUDE[pn_Windows_Server_2008_R2](../includes/pn-windows-server-2008-r2.md)]  
  
-   [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)]  
  
-   [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] 

-   Windows Server 2016  
  
 For more information about [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain and forest functional levels, see [Forest and Domain Functional Levels](/windows-server/identity/ad-ds/active-directory-functional-levels). 
  
> [!IMPORTANT]
>  -   The computer that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Server is running on shouldn’t function as an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controller.  
> -   When you use the Add Users Wizard, only users from trusted domains in the current forest will be displayed. Users from trusted external forests aren’t supported and don’t appear in the wizard.  
  
<a name="sql_server_editions"></a>   
## SQL Server editions  
 Any one of the following [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] editions is required, running, and available for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  

- Microsoft SQL Server 2019 Enterprise
- Microsoft SQL Server 2019 Standard
- Microsoft SQL Server 2019 Developer (for non-production use only)
- Microsoft SQL Server 2017 Enterprise
- Microsoft SQL Server 2017 Standard
- Microsoft SQL Server 2017 Developer (for non-production use only)
- Microsoft SQL Server 2016 Enterprise, with Service Pack 2    
- Microsoft SQL Server 2016 Standard, with Service Pack 2  
- Microsoft SQL Server 2016 Developer, with Service Pack 2 (for non-production use only)   
  
> [!IMPORTANT] 
> -  [!INCLUDE[pn_ms_SQL_Server_Express_long](../includes/pn-ms-sql-server-express-long.md)] editions are not supported for use with this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  

<a name="Claims_and_IFD_requirements"></a>   
## Accessing Microsoft Dynamics 365 Customer Engagement (on-premises) from the internet - Claims-based authentication and IFD requirements  
 The following items are required or recommended for [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)]. This article assumes you will be using [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] as the [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)]. 
  
> [!IMPORTANT]
>  Exposing the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website to the internet is not supported unless claims-based authentication is used and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is configured for [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)].  
>   
>  Similarly, Outlook Anywhere (RPC over HTTP) is not supported as a solution to connect [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to an on-premises deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] over the internet. The on-premises deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] must be configured for [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)]. <!-- as described in the topic [Configure IFD for Microsoft Dynamics 365 Customer Engagement (on-premises)](configure-ifd-for-dynamics-365.md).  -->
>   
>  In order for [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] to successfully connect to a new deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you must run a Repair of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] on the server running [!INCLUDE[pn_iis](../includes/pn-iis.md)] where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role is installed *after* the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)] is successfully completed. <!-- For repair instructions, see [Uninstall, change, or repair Microsoft Dynamics 365 Server](uninstall-change-repair-dynamics-365-server.md).  -->

## See also  
 [Microsoft SQL Server hardware requirements for Microsoft Dynamics 365 Server](sql-server-hardware-requirements-dynamics-365-server.md)   
 [Microsoft Dynamics 365 Customer Engagement (on-premises) reporting requirements](microsoft-dynamics-365-reporting-requirements.md)

::: moniker-end

::: moniker range="op-9-0"
  
<a name="windows_server_ops"></a>   
## Windows Server operating system  
 This version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] can be installed only on [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] 64-bit-based computers. The specific versions and editions of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] that are supported for installing and running this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] are listed in the following sections.  
  
> [!IMPORTANT]
>  The following [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] versions are not supported for installing and running this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]:  
>   
> -   [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Essentials  
> -   [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)]  family of operating systems  
>  -   [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] family of operating systems   
> -   The [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)] family of operating systems  

  
### Supported Windows Server 2016 editions  
 The following editions of the [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] operating system are supported for installing and running [!INCLUDE[pn_crm_2016_server](../includes/pn-crm-2016-server.md)]:  
  
-   [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Standard  
  
-   [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] Datacenter  
  
<!-- >> [!IMPORTANT]
>  To use [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] with Microsoft Dynamics 365 Server, see [Configure the AD FS server for claims-based authentication](configure-the-ad-fs-server-for-claims-based-authentication.md) and [Configure the AD FS server for IFD](configure-the-ad-fs-server-for-ifd.md).  -->
  
 
### Server Core installations  
 With the exception of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] roles, you can install any [!INCLUDE[pn_microsoft_dynamics_crm_2016_server](../includes/pn-microsoft-dynamics-crm-2016-server.md)] server role on a Server Core installation of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]. Server Core is a minimal server installation option for the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] family of operating systems. Server Core provides a low-maintenance server environment with limited functionality. For more information about Server Core as implemented on [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)], see [Server Core for Windows Server 2016](https://docs.microsoft.com/windows-server/get-started/sconfig-on-ws2016)  
  
> [!IMPORTANT]
>  To install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] on a Server Core [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], you must run Setup in silent mode from the command line. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the command prompt to install Microsoft Dynamics 365 Server](use-command-prompt-install-dynamics-365-server.md)  -->
>   
>  The [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] role cannot be installed on a Windows Server running as Server Core.  
>   
>  [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)] cannot be installed on Server Core. This is because [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], which is required by [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)], cannot be installed on a Windows Server running Server Core.  
  
<a name="Server_virtualization"></a>   
## Server virtualization  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers can be deployed in a virtualized environment by using [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)] with [!INCLUDE[pn_Hyper-V](../includes/pn-hyper-v.md)] or virtualization solutions from vendors who participate in the Microsoft Windows Server Virtualization Validation Program (SVVP). You must understand the limitations and best practices of server virtualization before you try to virtualize your installation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].   
  
<a name="Active_directory_modes"></a>   
## Active Directory modes  
 The computer that [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is running on must be a member of a domain that is running in one of the following [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service forest and domain functional levels:  
  
-   [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)]  
  
-   [!INCLUDE[pn_Windows_Server_2008_R2](../includes/pn-windows-server-2008-r2.md)]  
  
-   [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)]  
  
-   [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] 

-   Windows Server 2016  
  
 For more information about [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain and forest functional levels, see [Forest and Domain Functional Levels](/windows-server/identity/ad-ds/active-directory-functional-levels). 
  
> [!IMPORTANT]
>  -   The computer that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Server is running on shouldn’t function as an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controller.  
> -   When you use the Add Users Wizard, only users from trusted domains in the current forest will be displayed. Users from trusted external forests aren’t supported and don’t appear in the wizard.  
> -   Installing [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] in an LDAP directory that is running in Active Directory Application Mode (ADAM) is not supported.  
  
<a name="IIS"></a>   
## Internet Information Services (IIS)  
 This version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] supports [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] version 10.  
  
 We recommend that you install and run [!INCLUDE[pn_iis](../includes/pn-iis.md)] in Native Mode before you install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. However, if [!INCLUDE[pn_iis](../includes/pn-iis.md)] is not installed and it is required for a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server role, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] will install it.  
  
> [!IMPORTANT]
>  [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] can’t use a website that has more than one HTTP or HTTPS binding. Although [!INCLUDE[pn_iis](../includes/pn-iis.md)] supports multiple HTTP and HTTPS bindings, there is a limitation in using additional bindings with [!INCLUDE[pn_WCF_long](../includes/pn-wcf-long.md)]. [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] is required when you use [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)]. Before you install or upgrade, you must remove the additional bindings from the website used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or select a different website.  
  
<a name="sql_server_editions"></a>   
## SQL Server editions  
 Any one of the following [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] editions is required, running, and available for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
  
-   Microsoft SQL Server 2017 Enterprise<sup>1</sup>     
-   Microsoft SQL Server 2017 Standard<sup>1</sup>   
-   Microsoft SQL Server 2017 Developer (for non-production use only)<sup>1</sup> 
-   Microsoft SQL Server 2016 Enterprise, with Service Pack 2    
-   Microsoft SQL Server 2016 Standard, with Service Pack 2  
-   Microsoft SQL Server 2016 Developer, with Service Pack 2 (for non-production use only)   
  
> [!IMPORTANT] 
> - <sup>1</sup>Requires [Microsoft Dynamics 365 Server, v9.0 (on-premises) Update 0.3](https://www.microsoft.com/download/details.aspx?id=58153).
> -  [!INCLUDE[pn_ms_SQL_Server_Express_long](../includes/pn-ms-sql-server-express-long.md)] editions are not supported for use with this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  

  
<a name="Claims_and_IFD_requirements"></a>   
## Accessing Microsoft Dynamics 365 Customer Engagement (on-premises) from the internet - Claims-based authentication and IFD requirements  
 The following items are required or recommended for [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)]. This topic assumes you will be using [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] as the [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)]. <!-- For more information about configuring [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for claims-based authentication, see [Configure IFD for Microsoft Dynamics 365 Customer Engagement (on-premises)](configure-ifd-for-dynamics-365.md).  -->
  
> [!IMPORTANT]
>  Exposing the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website to the internet is not supported unless claims-based authentication is used and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is configured for [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)].  
>   
>  Similarly, Outlook Anywhere (RPC over HTTP) is not supported as a solution to connect [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to an on-premises deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] over the internet. The on-premises deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] must be configured for [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)]. <!-- as described in the topic [Configure IFD for Microsoft Dynamics 365 Customer Engagement (on-premises)](configure-ifd-for-dynamics-365.md).  -->
>   
>  In order for [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] to successfully connect to a new deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you must run a Repair of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] on the server running [!INCLUDE[pn_iis](../includes/pn-iis.md)] where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role is installed *after* the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)] is successfully completed. <!-- For repair instructions, see [Uninstall, change, or repair Microsoft Dynamics 365 Server](uninstall-change-repair-dynamics-365-server.md).  -->
  
-   The computer where [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is installed must have access to a [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)] service, such as [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] federation server. [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] supports the following [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] versions: 
    - [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] 2.1 ([!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)])  
    - [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)]  Windows Server 2012 R2 AD FS ([!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)])
    - [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] Windows Server 2016 AD FS.  
  
-   Note the following conditions for the web components before you configure [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)]:  
  
    -   If you are installing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] in a single server configuration, be aware that [!INCLUDE[pn_Active_Directory_Fed_Svc2](../includes/pn-active-directory-fed-svc2.md)] installs on the default website. Therefore, you must create a new website for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
    -   When you run the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)], [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] must be running on a website that is configured to use [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)]. [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] will not configure the website for [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)].  
  
    -   We recommend that the [!INCLUDE[pn_iis](../includes/pn-iis.md)] website where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application will be installed requires [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)].  
  
    -   The website should have a single binding. Multiple IIS bindings, such as a website with an HTTPS and an HTTP binding or two HTTPS or two HTTP bindings, are not supported for running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
    -   Access to the [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] federation metadata file from the computer where the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] is run. Note the following:  </br>
  
        -   The federation metadata endpoint must use the web services trust model (WS-Trust) 1.3 standard. Endpoints that use a previous standard, such as the WS-Trust 2005 standard, are not supported. In [!INCLUDE[pn_Active_Directory_Fed_Svc2](../includes/pn-active-directory-fed-svc2.md)], all WS-Trust 1.3 endpoints contain /trust/13/ in the URL path.  
  
    -   Encryption certificates. The following encryption certificates are required. You can use the same encryption certificate for both purposes, such as when you use a wildcard certificate:  
  
        > [!IMPORTANT]
        >  If you use a certificate that is created by using a custom certificate request, the template that was used must be the **Legacy key** template. Custom certificate requests created by using the **CNG key** template are incompatible with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information about custom certificate request templates, see [Create a Custom Certificate Request](https://technet.microsoft.com/library/cc730929.aspx).  
  
        -   Claims encryption. Claims-based authentication requires identities to provide an encryption certificate for authentication. This certificate should be trusted by the computer where you are installing [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] so it must be located in the local Personal store where the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] is running.  
  
        -   [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] (HTTPS) encryption. The certificates for [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] encryption should be valid for host names similar to org.contoso.com, auth.contoso.com, and dev.contoso.com. To satisfy this requirement, you can use a single wildcard certificate (*.contoso.com), a certificate that supports Subject Alternative Names, or individual certificates for each name. Individual certificates for each host name are only valid if you use different servers for each web server role. Multiple [!INCLUDE[pn_iis](../includes/pn-iis.md)] bindings, such as a website with two HTTPS or two HTTP bindings, aren’t supported for running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information about available options, contact your certification authority service company or your certification authority administrator.  
  
-   The **[!INCLUDE[ui_CRMAppPool](../includes/ui-crmapppool.md)]** account of each Microsoft Dynamics 365 Customer Engagement (on-premises) website must have read permission to the private key of the encryption certificate specified when configuring claims-based authentication. You can use the Certificates [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] snap-in to edit permissions for the encryption certificate found in the Personal store of the local computer account.  
  
<a name="software_component_prerequisites"></a>   
## Software component prerequisites  
 The following [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] components must be installed and running on the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] before you install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]:  
  
-   SQL word breakers  
  
     This is only required for some [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] language editions. For more information about word breaker versions for languages supported by [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], see [Configure and Manage Word Breakers and Stemmers for Search](https://go.microsoft.com/fwlink/p/?linkid=127754).  
  
-   [!INCLUDE[pn_SQL_Server_Agent](../includes/pn-sql-server-agent.md)] service  
  
-   [!INCLUDE[pn_SQL_Server_Full_Text_Indexing](../includes/pn-sql-server-full-text-indexing.md)]  
  
 The following components must be installed and running on the computer where  [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] will be installed:  
  
-   Services  
  
    -   [!INCLUDE[pn_Indexing_Service](../includes/pn-indexing-service.md)]  
  
         To install this service, see the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] documentation.  
  
    -   [!INCLUDE[pn_IIS_Admin](../includes/pn-iis-admin.md)]  
  
    -   World Wide Web Publishing  
  
    -   Net.Tcp Port Sharing Service  
  
-   Windows Data Access Components (MDAC)  
  
-   [!INCLUDE[pn_microsoft_ASP.NET](../includes/pn-microsoft-asp-net.md)] (Must be registered, but does not have to be running.)  
  
<a name="verify_prerequisites"></a>   
## Verify prerequisites  
 Before you install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you should understand the following:  
  
-   [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] can be, but is not required to be, installed on the same computer as [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
-   If [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] are installed on different computers, both computers must be in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service domain.  
  
-   [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] can be installed by using either [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] or mixed-mode authentication. ([!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] is recommended for increased security and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will use only [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)]).  
  
-   The service account that [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] uses to log on to the network must be either a domain user account (recommended) or one of the built-in system accounts supported by SQL Server (Network Service, Local Service, or Local System). Installation of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] will fail if the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service account is the local administrator.  
  
-   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service must be started and can be configured to automatically start when the computer is started.  
  
-   The [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] service must be started and configured to automatically start when the computer is started.  
  
-   The [!INCLUDE[pn_SQL_Server_Agent](../includes/pn-sql-server-agent.md)] service must be started. This service can be configured to automatically start when the computer is started.  
  
-   Although it is optional, we recommend that you accept the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] default settings for Collation Designator, Sort Order, and SQL Collation. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports both case-sensitive and case-insensitive sort orders.  
  
-   [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] requires at least one network protocol to be enabled to authenticate by using [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. By default, [!INCLUDE[pn_TCP/IP](../includes/pn_tcp_ip_md.md)] protocol is enabled when you install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. You can view network protocols in [!INCLUDE[pn_SQL_Server_Configuration_Manager](../includes/pn-sql-server-configuration-manager.md)].  
  
## See also  
 [Microsoft SQL Server hardware requirements for Microsoft Dynamics 365 Server](sql-server-hardware-requirements-dynamics-365-server.md)   
 [Microsoft Dynamics 365 Customer Engagement (on-premises) reporting requirements](microsoft-dynamics-365-reporting-requirements.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]