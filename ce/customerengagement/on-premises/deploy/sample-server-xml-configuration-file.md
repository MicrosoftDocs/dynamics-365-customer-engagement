---
title: "Sample server XML configuration file | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 438b672c-2eea-4bcc-b07d-7ad031aba12d
caps.latest.revision: 22
ms.author: matp
author: Mattp123
manager: kvivek
---
# Sample server XML configuration file



The following configuration file installs an update file that is located on an internal share, installs a Full Server with all Dynamics 365 Server features, and creates new databases on the default instance of a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is named *SQLServer*.  
  
```xml  
<CRMSetup>  
<Server>  
<Patch update="true">\\ServerName\ShareName\patchfile.msp</Patch>  
<LicenseKey>XXXXX-XXXXX-XXXXX-XXXXX-XXXXX</LicenseKey>  
<SqlServer>SQLServer</SqlServer>  
<Database create="true"/>  
<Reporting URL="https://MyReportingServer/ReportServer"/>  
<OrganizationCollation>Latin1_General_CI_AI</OrganizationCollation>  
<basecurrency isocurrencycode="USD" currencyname="US Dollar" currencysymbol="$" currencyprecision="2"/>  
<Organization>Organization Display Name</Organization>  
<OrganizationUniqueName>Organization-Name</OrganizationUniqueName>  
<OU>OU=value,DC=subdomain,DC=subdomain,DC=subdomain,DC=com</OU>  
<WebsiteUrl create="true" port="5555"> </WebsiteUrl>  
<InstallDir>c:\Program Files\Microsoft Dynamics CRM</InstallDir>  
  
<CrmServiceAccount type="DomainUser">  
  <ServiceAccountLogin>Contoso\CRMAppService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</CrmServiceAccount>  
  
<SandboxServiceAccount type="DomainUser">  
  <ServiceAccountLogin>Contoso\CRMSandboxService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</SandboxServiceAccount>  
  
<DeploymentServiceAccount type="DomainUser">  
  <ServiceAccountLogin>Contoso\CRMDeploymentService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</DeploymentServiceAccount>  
  
<AsyncServiceAccount type="DomainUser">  
  <ServiceAccountLogin>Contoso\CRMAsyncService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</AsyncServiceAccount>  
  
<VSSWriterServiceAccount type="DomainUser">   
  <ServiceAccountLogin>Contoso\CRMVSSWriterService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</VSSWriterServiceAccount>  
  
<MonitoringServiceAccount type="DomainUser">  
  <ServiceAccountLogin>Contoso\CRMMonitoringService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</MonitoringServiceAccount>  
  
  <SQM optin="true"/>  
 <muoptin optin="true"/>  
  
<!-- Settings for IFD installation. May be skipped for intranet-only deployment or to configure IFD later. -->  
 <ifdsettings enabled="false">  
      <!-- Define what address considered internal, required only if enabled=true -->  
      <internalnetworkaddress>10.0.0.1-255.0.0.0</internalnetworkaddress>  
      <!-- Define URLs with IFD authentication, required only if enabled=true -->  
      <rootdomainscheme>http</rootdomainscheme>  
      <sdkrootdomain>api.contoso.com</sdkrootdomain>  
      <webapplicationrootdomain>app.contoso.com</webapplicationrootdomain>  
      <discoveryrootdomain>disc.contoso.com</discoveryrootdomain>  
 </ifdsettings>  
  
 <Email>  
  <IncomingExchangeServer name="ExchangeServerName"/>  
 </Email>  
  
 </Server>  
</CRMSetup>  
  
```  
  
> [!CAUTION]
>  Maintaining the configuration file that has `ServiceAccountLogin` and `ServiceAccountPassword` values specified is a security risk because you are storing a password in plain text. Delete these elements as soon as the configuration file is used to install Dynamics 365 Server.  
  
## See Also  
 [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md)  </br>
 [Sample server XML configuration file for installing with pre-created groups](sample-server-xml-config-file-pre-created-groups.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]