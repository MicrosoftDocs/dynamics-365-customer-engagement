---
title: "Sample XML configuration file that installs only the WebApplicationServer and OrganizationWebService roles | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: fadac870-19d6-404c-806f-23be45caa93e
caps.latest.revision: 13
ms.author: matp
author: Mattp123
manager: kvivek
---
# Sample XML configuration file that installs only the WebApplicationServer and OrganizationWebService roles

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

The following example installs only the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] and [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] server roles on the local computer. In order to use this configuration file the configuration database must already exist on the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] that is named *SQLServer*. The feature will be installed in the default [!INCLUDE[pn_iis](../includes/pn-iis.md)] website. To specify a different website, use the `<WebsiteUrl>` element. For more information, see [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md).  
  
> [!NOTE]
>  The [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] requires the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]. Therefore, even when you specify only the WebApplicationServer role name, the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] (OrganizationWebService) will automatically be installed.  
  
```xml  
<CRMSetup>  
<Server>  
<Patch update="true">\\server\share\patchfile.msp</Patch>  
<LicenseKey>XXXXX-XXXXX-XXXXX-XXXXX-XXXXX</LicenseKey>  
<SqlServer>SQLServer</SqlServer>  
<Database create="false" />  
<InstallDir>c:\Program Files\Microsoft Dynamics CRM</InstallDir>  
<WebsiteUrl create="true" port="5555"> </WebsiteUrl>  
<Roles>  
   <Role name="WebApplicationServer"/>  
</Roles>  
<SQM optin="true" />  
<MUoptin optin="true" />  
<CrmServiceAccount type="DomainUser">  
   <ServiceAccountLogin>contoso\user1</ServiceAccountLogin>  
   <ServiceAccountPassword>password</ServiceAccountPassword>  
</CrmServiceAccount>  
<MonitoringServiceAccount type=”DomainUser”>  
<ServiceAccountLogin>Contoso\CRMMonitoringService</ServiceAccountLogin>  
<ServiceAccountPassword>password</ServiceAccountPassword>  
</MonitoringServiceAccount>  
</Server>  
</CRMSetup>  
```  
  
> [!CAUTION]
>  Maintaining the configuration file that has <`ServiceAccountLogin`> and <`ServiceAccountPassword`> values specified is a security risk because you are storing a password in plain text. Delete these elements as soon as the configuration file is used to install Dynamics 365 Server.  
  
## See Also  
 [Install Microsoft Dynamics 365 roles](install-using-command-prompt.md)  </br> 
 [Sample XML configuration file that installs only the HelpServer role](sample-xml-configuration-file-helpserver.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]