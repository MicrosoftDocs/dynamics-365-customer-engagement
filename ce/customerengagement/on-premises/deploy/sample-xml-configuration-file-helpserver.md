---
title: "Sample XML configuration file that installs only the HelpServer role | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 98f6d099-f0f6-4184-9c1a-0b8047683a36
caps.latest.revision: 16
ms.author: matp
author: Mattp123
manager: kvivek
---
# Sample XML configuration file that installs only the HelpServer role



The following example installs only the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] role on the local computer.  
  
```xml  
<CRMSetup>   
<Server>   
<Patch update="true"/>   
<LicenseKey>XXXXX-XXXXX-XXXXX-XXXXX-XXXXX</LicenseKey>  
 <SqlServer>SQLServerName</SqlServer>   
<Database create="false"/>   
<WebsiteUrl create="true" port="5555">LM/W3SVC/1</WebsiteUrl>   
<Help anonymous="true">https://LocalHost/Help</Help>   
<InstallDir>c:\Program Files\Microsoft Dynamics CRM</InstallDir>   
<Roles>    
 <Role name="HelpServer"/>  
</Roles>   
<SQM optin="true"/>   
<MUoptin optin="true"/>   
<CrmServiceAccount type="DomainUser">  
 <ServiceAccountLogin>contoso\CRMHelpservice</ServiceAccountLogin>  
 <ServiceAccountPassword>password</ServiceAccountPassword>  
</CrmServiceAccount>  
<MonitoringServiceAccount type=”DomainUser”>  
 <ServiceAccountLogin>Contoso\CRMMonitoringService</ServiceAccountLogin>  
 <ServiceAccountPassword>password</ServiceAccountPassword>  
</MonitoringServiceAccount>  
</Server>   
</CRMSetup>  
```  
  
> [!IMPORTANT]
>  Unless you use `Help anonymous="true"`, the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] contents in [!INCLUDE[pn_iis](../includes/pn-iis.md)] will not be configured for anonymous access. If the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] application isn’t configured for anonymous access, users may be prompted repeatedly for authentication credentials when they access [!INCLUDE[pn_Microsoft_Dynamics_CRM_Help](../includes/pn-microsoft-dynamics-crm-help.md)].  
>   
>  By default, the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] uses the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] web address that appears in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]. Additionally, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] does not update the URL when you install the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] on a separate computer. You must change the URL manually. To change the URL, run the following [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands in the following topic on the computer that is running the [!INCLUDE[pn_Deployment_Tools](../includes/pn-deployment-tools.md)] server role.  
  
### Change the Dynamics 365 HelpServer URL  
 The following [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets change the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] URL to *https://crmhelpserver.contoso.com*, an Internet-facing [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] configured for [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)]. Before you can run the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] cmdlets, you must register them first. For more information, see [Configure the Dynamics 365 PowerShell cmdlets](administer-the-deployment-using-windows-powershell.md).  
  
 View existing web address settings. Notice that, if the HelpServerUrl web address setting appears blank when you run the following [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command, the [!INCLUDE[pn_Help_Server](../includes/pn-help-server.md)] is using the same web address as the Web Application Server (WebAppRootDomain).  
  
```  
Get-CrmSetting WebAddressSettings  
```  
  
 Set the Help Server url.  
  
```  
$websetting = Get-CrmSetting WebAddressSettings  
$websetting.HelpServerUrl = “https://crmhelpserver.contoso.com”  
Set-CrmSetting $websetting   
```  
  
 Verify the new URL by viewing the web address settings again.  
  
```  
Get-CrmSetting WebAddressSettings  
```  
  
## See Also  
 [Sample XML configuration file that installs only the WebApplicationServer role](sample-xml-config-webapp-organizationweb.md)   </br>
 [Install Microsoft Dynamics 365 Server roles using the command prompt](install-using-command-prompt.md)   </br>
 [Install Microsoft Dynamics 365 Reporting Extensions using the command prompt](install-dynamics-365-reporting-extensions-command.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]