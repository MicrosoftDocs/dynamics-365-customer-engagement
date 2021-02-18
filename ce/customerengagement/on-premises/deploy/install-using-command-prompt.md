---
title: "Install Microsoft Dynamics 365 Server roles using the command prompt | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 83f0f6ac-3b36-451f-ab22-16948961fe9c
caps.latest.revision: 19
ms.author: matp
author: Mattp123
manager: kvivek
---
# Install Microsoft Dynamics 365 Server roles using the command prompt



By default, Setup installs all Dynamics 365 Server roles on the local computer. However, when you are installing Dynamics 365 Server, you can select to install one or more server roles. Additionally, you can install the same server role or roles on two or more computers, which can provide load balancing benefits. To do this, you can either select the roles that you want by running the Dynamics 365 Server Setup or you can configure an XML configuration file and then run Setup at a command prompt on the computer where you want the role installed.  
  
> [!NOTE]
>  You can run Setup at a command prompt or from Programs and Features in the [!INCLUDE[pn_Control_Panel](../includes/pn-control-panel.md)] to add or remove server roles to a computer that already has one or more server roles installed.  
  
 For more information about server roles, see [Microsoft Dynamics 365 server roles](microsoft-dynamics-365-server-roles.md).  
  
### Parameters  
 The supported command prompt parameters are the same as those previously described under [Install Microsoft Dynamics 365 Server](install-dynamics-365-server-command-prompt.md) in this guide.  
  
## Server role XML configuration file  
 The **/config** [*drive*:] [[*path*] *configfilename.xml*]] command-line parameter provides [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] with required information. The information supplied by the XML configuration file is what is required by each installation screen.  
  
> [!IMPORTANT]
>  The XML elements must be in English (US). An XML configuration file that has localized XML elements will not work correctly.  
  
 An explanation of each XML element and a sample XML file follows:  
  
 `<Roles>`   
 `<Role Name="RoleName1" Action="Add" / "Remove"/>`   
 `<Role Name="RoleName2" Action="Add" / "Remove"/>`  
 **Name**. The name of the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role. For available server role names, see [Microsoft Dynamics 365 2103 server role names used in the XML configuration file](install-using-command-prompt.md#BKMK_XMLserverrolenames).  
  
 **Action**. This attribute is only required when you reconfigure an existing deployment by adding or removing server roles.  
  
 `</Roles>`  
  
<a name="BKMK_XMLserverrolenames"></a>   
### Microsoft Dynamics 365 Server role names used in the XML configuration file  
 `WebApplicationServer`  
 Installs the components that are needed to run the Web application server.  
  
 `OrganizationWebService`  
 Installs the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] components that are needed to run applications that use the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].  
  
 `DiscoveryWebService`  
 Installs the [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)] component users need to find the organization that they are a member of in a multi-tenant deployment.  
  
 `HelpServer`  
 Installs the components that are needed to make [!INCLUDE[pn_Microsoft_Dynamics_CRM_Help](../includes/pn-microsoft-dynamics-crm-help.md)] available to users.  
  
 `AsynchronousProcessingService`  
 Installs the [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)]. This service is used to process queued asynchronous events, such as bulk email or data import.  
  
 `EmailConnector`  
 Installs the service and related files that handle sending and receiving of email messages by connecting to an external email server.  
  
 `SandboxProcessingService`  
 Installs the components that are needed to provide custom code execution isolation.  
  
 `DeploymentTools`  
 Installs [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] and [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets that you can use to automate deployment tasks. [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] is a [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] snap-in that system administrators can use to manage organizations, servers, and licenses for deployments of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 `DeploymentWebService`  
 Installs the [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] component that is required to manage the deployment by using the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)], such as create an organization or remove a [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role from a user.  
  
 `VSSWriter`  
 Installs the interface that can be used to back up and restore [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data by using the Windows Server Volume Shadow Copy Service (VSS) infrastructure.  
  
> [!IMPORTANT]
>  Although you cannot specify a group of server roles ([!INCLUDE[Front_End_Server](../includes/front-end-server.md)], [!INCLUDE[Back_End_Server](../includes/back-end-server.md)] or [!INCLUDE[pn_Deployment_Administration_Server](../includes/pn-deployment-administration-server.md)]), you can specify all server roles in the server role group, such as the following XML sample snippet that installs all [!INCLUDE[Front_End_Server](../includes/front-end-server.md)] roles.  
  
```xml  
<Roles>  
<Role Name="WebApplicationServer" />  
<Role Name="OrganizationWebService" />  
<Role Name="DiscoveryWebService" />  
<Role Name="HelpServer" />  
</Roles>  
```  
  
## See Also  
 [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md)  </br> 
 [Sample XML configuration file that installs only the WebApplicationServer role](sample-xml-config-webapp-organizationweb.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]