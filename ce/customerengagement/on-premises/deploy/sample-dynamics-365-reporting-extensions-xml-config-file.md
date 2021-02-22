---
title: "Sample Dynamics 365 Reporting Extensions XML configuration file | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 4793de36-fbeb-4ae1-af86-c860e9011982
caps.latest.revision: 11
ms.author: matp
author: Mattp123
manager: kvivek
---
# Sample Dynamics 365 Reporting Extensions XML configuration file



The following XML configuration sample will search, and if found download and apply, updates to Setup. It will optin to [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)],  then look for the  configuration database on a [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] named `SQLServer` and install the [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_legacy](../includes/pn-microsoft-dynamics-crm-reporting-extensions-legacy.md)] on the local [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instance that is named `SQLReportServerInstance`. Additionally, [!INCLUDE[pn_Setup](../includes/pn-setup.md)] will add or remove any members to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] related security groups in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service as needed and install the monitoring service configured for an existing domain user account named *CRMMonitoringService*.  
  
```xml  
<crmsetup>  
<srsdataconnector>  
<configdbserver>SQLServer</configdbserver>   
<autogroupmanagementoff>0</autogroupmanagementoff>  
<instancename>SQLReportServerInstance</instancename>  
<patch update="true" />   
<muoptin optin="true" />  
<MonitoringServiceAccount type=”DomainUser”>  
  <ServiceAccountLogin>Contoso\CRMMonitoringService</ServiceAccountLogin>  
  <ServiceAccountPassword>password</ServiceAccountPassword>  
</MonitoringServiceAccount>  
</srsdataconnector>  
</crmsetup>  
```  
  
### Logging  
 By default, Setup creates a file that is named **SrsDataConnectorSetup.log** in the %appdata%\Microsoft\MSCRM\Logs folder on the computer where [!INCLUDE[pn_Setup](../includes/pn-setup.md)] is run.  
  
## See Also  
 [Microsoft Dynamics 365 Reporting Extensions XML configuration file](dynamics-365-reporting-extensions-xml-config-file.md)  </br> 
 [Command example Microsoft Dynamics 365 Report Authoring Extension](install-report-authoring-extension-command-prompt.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]