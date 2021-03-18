---
title: "Microsoft Dynamics 365 Server roles | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 21b80748-851d-4dc6-aceb-b6b569531b09
caps.latest.revision: 44
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Server roles



With [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you can install specific server functionality, components, and services on different computers. These components and services correspond to specific server roles. For example, customers who have larger user bases can install the Front End Server role on two or more servers that run [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] to increase throughput performance for users. Or, a Full Server role can be installed on one computer and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] on another. If a server role is missing, [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] displays a message in the **Messages** area.  
  
 Use one of the following options to install server roles:  
  
-   Run the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup Wizard to select one or more server role groups or one or more individual server roles. If [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is already installed, you can use Programs and Features in Control Panel to add or remove server roles.  
  
-   Configure an XML Setup configuration file and then run Setup at the command prompt to specify a server role group or one or more individual server roles. You cannot explicitly select the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] "role" for installation during [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup. This is a logical role that [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] sets when you specify a particular instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], either local or on another computer (recommended) for use in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. For more information, see [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md).  
  
> [!NOTE]
>  At any time after the initial installation of server roles, you can add or remove server roles in Programs and Features. For more information, see [Uninstall, change, or repair Microsoft Dynamics 365 Server](uninstall-change-repair-dynamics-365-server.md).  
  
> [!IMPORTANT]
>  If you have a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment that includes one or more Front End Server and [!INCLUDE[Back_End_Server](../includes/back-end-server.md)] roles, the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] must be installed on the computer that has the Front End Server role. If you have deployed individual server roles, the Language Packs must be installed on the computers that are running the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] and the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] roles.  
  
<a name="BKMK_AvailableGroup"></a>   
## Available group server roles  
 Although these server role groups are recommended for most deployments, any individual server role may be installed during Setup.  
  
 All server roles must be running in your organization’s network to provide a fully functioning system.  
  
|Server Role Group|Description|Scope|Installation Method|  
|-----------------------|-----------------|-----------|-------------------------|  
|Full Server|Contains all roles from Front End Server, [!INCLUDE[Back_End_Server](../includes/back-end-server.md)], and [!INCLUDE[pn_Deployment_Administration_Server](../includes/pn-deployment-administration-server.md)]. By default, [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup deploys the system as Full Server. In a Full Server deployment, server roles are not listed separately in Control Panel. To view the installed roles or make changes, right-click **Microsoft Dynamics 365 Server** , select **Uninstall/Change**, and then select **Configure**.|Deployment|Full|  
|Front End Server|Enables the server roles for running client applications and applications developed with the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].|Deployment|Group or Full|  
|[!INCLUDE[Back_End_Server](../includes/back-end-server.md)]|Includes the server roles that handle processing asynchronous events, such as workflows and custom plug-ins, database maintenance, and email routing. These roles are usually not exposed to the Internet.<br /><br /> For a list of server roles that are included in this group, see the following table.|Deployment|Group or Full|  
|[!INCLUDE[pn_Deployment_Administration_Server](../includes/pn-deployment-administration-server.md)]|Enables the server roles for components that are used to manage the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment either by using the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] or the deployment tools. Also includes the interface for database disaster recovery support.<br /><br /> For a list of server roles that are included in this group, see the following table.|Deployment|Group or Full|  
  
<a name="BKMK_AvailableIndividual"></a>   
## Available individual server roles  
  
|Server Role|Description|Server Group|Scope|Installation Method|  
|-----------------|-----------------|------------------|-----------|-------------------------|  
|[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]|Finds the organization that a user belongs to in a multi-tenant deployment.|Front End Server|Deployment|Individual, Group, or Full|  
|[!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]|Supports running applications that use the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].|Front End Server|Deployment|Individual, Group, or Full|  
|[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]|Runs the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] that is used to connect users to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data. The [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role requires the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] role.|Front End Server|Deployment|Individual, Group, or Full|  
|Help Server|Makes [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Help available to users.|Front End Server|Deployment|Individual, Group, or Full|  
|Asynchronous Service|Processes queued asynchronous events, such as workflows, bulk e-mail, or data import.|[!INCLUDE[Back_End_Server](../includes/back-end-server.md)]|Deployment|Individual, Group, or Full|  
|[!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)]|Enables an isolated environment to allow for the execution of custom code, such as plug-ins. This isolated environment reduces the possibility of custom code affecting the operation of the organizations.|[!INCLUDE[Back_End_Server](../includes/back-end-server.md)]|Deployment|Individual, Group, or Full|  
|Email Integration Service|Handles sending and receiving of email messages by connecting to an external email server.|[!INCLUDE[Back_End_Server](../includes/back-end-server.md)]|Deployment|Individual, Group, or Full|  
|[!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)]|Publishes the web service that provides the deployment interface described in the [Microsoft Dynamics CRM SDK](https://msdn.microsoft.com/library/hh547453.aspx), such as those used to create an organization or manage the list of Deployment Administrators for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.|Deployment  Administration Server|Deployment|Individual, Group, or Full|  
|Deployment Tools|Consists of the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] and [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] administrators can use the [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets to automate [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] tasks.<br /><br /> [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] is a [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] snap-in that deployment administrators can use to manage organizations, servers, and licenses for deployments of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].|Deployment  Administration Server|Deployment|Individual, Group, or Full|  
|Microsoft Dynamics 365 VSS Writer|The Microsoft Dynamics 365 VSS Writer service provides an interface to backup and restore Dynamics 365 data by using the Windows Server Volume Shadow Copy Service (VSS) infrastructure.|Deployment  Administration Server|Deployment|Individual, Group, or Full|  
|[!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)]|Provides reporting functionality by interfacing with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)].|N/A|Deployment|Individual by using srsDataConnectorSetup.exe.|  
|[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]|Installs the MSCRM_CONFIG database on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].|N/A|Deployment|Individual during [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup or from [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]**Edit Organization Wizard**.|  
  
<a name="BKMK_ScopeDef"></a>   
## Scope definition  
  
-   **Deployment**. Each instance of the server role services the entire deployment.  
  
-   **Organization**. Each instance of the server role services an organization. Therefore, you can use a different server role instance for a given organization.  
  
<a name="BKMK_InstallMeth"></a>   
## Installation method definition  
  
-   **Individual , Group, or Full**. During [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup, you can install a server role individually, install one of the three predefined groups of server roles, or perform a Full Server installation that includes all roles. Or, you can select multiple individual server roles.  
  
-   **[!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)]** . Install this role using srsDataConnectorSetup.exe on the computer where [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] is running.  
  
 <!-- For more information about [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server roles and multiple server deployment, see [Install Microsoft Dynamics 365 Server on multiple computers](install-dynamics-365-server-multiple-computers.md).  -->
  
<a name="BMKM_processasync"></a>   
## Install the Microsoft Dynamics 365 Asynchronous Service to process only asynchronous events or email  
 The Microsoft Dynamics 365 Asynchronous Processing Service (NT style service) can be used to process asynchronous events and email, accounts, contacts, and tasks using server-side synchronization. Depending on what server roles you select during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)], you can configure the [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)] to have the following features.  
  
-   Selecting both [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)] and Email Integration Service server roles installs the Asynchronous Processing Service that will be configured to process both asynchronous events and email, accounts, contacts, and tasks using server-side synchronization.  
  
-   Selecting only the [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)] server role installs the Asynchronous Processing Service that will be configured to process only asynchronous events.  
  
-   Selecting only the Email Integration Service server role, installs the Asynchronous Processing Service that will be configured to only process email, accounts, contacts, and tasks by using server-side synchronization.  
  
 Given these options, you can separate asynchronous events from server-side synchronization to help improve [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system performance and simplify monitoring.  
  
<a name="BKMK_RoleReq"></a>   
## Microsoft Dynamics 365 Server role requirements  
 The following table describes the components necessary for each [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role. An "X" indicates the component is required for the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role to install and function. Notice that, in most cases if a component is not already installed, [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup will install it.  
  
### Microsoft Dynamics 365 Server Role Prerequisites  
  
|Component|[!INCLUDE[Back_End_Server](../includes/back-end-server.md)]|Front End Server|[!INCLUDE[pn_Deployment_Administration_Server](../includes/pn-deployment-administration-server.md)]|  
|---------------|---------------------------------------------------------------------|----------------------|-----------------------------------------------------------------------------------------|  
|[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] ReportViewer control||X||  
|[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Native Client|X|X|X|  
|Microsoft Application Error Reporting Tool|X|X|X|  
|Microsoft Visual C++ Runtime Library|X|X|X|  
|[!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] Web Server Role||X|X|  
|Indexing Service||X||  
|[!INCLUDE[pn_NET_Framework_4_long](../includes/pn-net-framework-4-long.md)]|X|X|X|  
|[!INCLUDE[pn_ms_chart_controls_short](../includes/pn-ms-chart-controls-short.md)] for Microsoft [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)]||X||  
|[!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] platform SDK|X|X|X|  
|[!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)]|||X|  
|Microsoft URL Rewrite Module for IIS||X||  
|File Server Resource Manager||X||  
  
 The following table describes the group membership for the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] that is used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. An “X” indicates the group membership required for the service to function.  
  
### Group Membership Requirements  
  
|Service|PrivUserGroup|SQLAccessGroup|PrivReportingGroup|ReportingGroup|  
|-------------|-------------------|--------------------|------------------------|--------------------|  
|[!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] service account|X|X|||  
|Web Application Service*|X|X|||  
|Asynchronous Service service account|X|X|||  
|[!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)] service account**|||||  
|[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service account||X|||  
|[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server account|X||X||  
|[!INCLUDE[pn_emailrouter](../includes/pn-emailrouter.md)] service account|X||||  
|Installing User/Service account||||X|  
|Individual user accounts in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]||||X|  
|Unzip Service service account|X||||  
|Microsoft Dynamics 365 VSS Writer service account|X|X|||  
  
 \* The Web Application Service identity is applied to the CRMAppPool application pool. Subsequently, this identity is used by the Organization Service, Web Application, and Microsoft Dynamics CRM platform.  
  
 ** The Sandbox Service does not need any [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] group membership.  
  
> [!NOTE]
>  [!INCLUDE[pn_emailrouter](../includes/pn-emailrouter.md)] runs as a local system.  
  
> [!IMPORTANT]
>  -   The Installing user should be a separate service account, but it should not be used to run any services.  
> -   If any of the service accounts are created as users in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you may encounter various problems, some of which are potential security issues.  
  
## See Also  
 [Microsoft Dynamics 365 multiple-server deployment](microsoft-dynamics-365-multiple-server-deployment.md)   </br>
 [Support for Microsoft Dynamics 365 multiple-server topologies](dynamics-365-multiple-server-topologies.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]