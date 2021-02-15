---
title: "Microsoft Dynamics 365 Monitoring Service | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: ec8cb740-8ef2-46b8-9349-7bed1c418815
caps.latest.revision: 12
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Monitoring Service



The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Monitoring Service is an NT-style service that monitors all [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles running on the local computer. The monitoring service doesn’t transmit information outside the computer where the service is running. The monitoring service is installed with the installation of any [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role.  
  
 The monitoring service validates the health of the server roles that are running on the local computer by running a series of tests. By default, monitoring occurs every 15 minutes and 10 records are maintained before the earliest record is replaced. Some tests performed by the monitoring service require that the organization be set for monitoring. For more information, see [Change monitoring settings](microsoft-dynamics-365-monitoring-service.md#BKMK_changemon) later in this topic.  
  
## View monitoring results  
 Events are recorded under the `MSCRMMonitoringServerRole` source in the Application area of Event Viewer.  
  
 By default, detailed monitoring results are saved as XML files located in C:\Program Files\Microsoft Dynamics CRM\Monitoring\results.  
  
> [!TIP]
>  Use a web browser to view the monitoring logs. To do this in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], right-click the monitoring XML file, select **Open with**, and then select [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
 Additionally, you can record monitoring results to the configuration database as described later in this topic. Then you can use a SQL statement such as the following to view monitoring information for the deployment.  
  
```  
USE MSCRM_CONFIG SELECT * FROM MonitoringResults ORDER BY EndTime  
```  
  
<a name="BKMK_changemon"></a>   
## Change monitoring settings  
 The following [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] commands perform these operations.  
  
-   Displays the current monitoring settings.  
  
-   Sets the monitoring service to record a maximum of 10 results to the MonitoringResults table in the configuration database (`MSCRM_CONFIG`) in addition to recording to XML files in a file folder.  
  
     Sets the *testorg* organization for organization-level monitoring, and sets the monitoring organization user account and password.  
  
-   Displays the current monitoring settings, again.  
  
> [!NOTE]
>  Although this example configures two separate options, you don’t have to configure both options together. The first option is to store monitoring records in the configuration database, and the second option is to set the monitoring organization, account, and password.  
  
```  
Add-PSSnapin Microsoft.Crm.PowerShell  
Get-CrmSetting -SettingType MonitoringSettings  
$set =Get-CrmSetting -SettingType Monitoringsettings  
$set.StoreResultsInDatabase = "true"  
$set.ResultsToKeepInDatabase = "10"  
$set.MonitoringOrganizationUniqueName ="testorg"  
$set.MonitoringOrganizationUserAccount = "contoso\administrator"  
$set.MonitoringOrganizationUserPassword = "password"  
Set-CrmSetting -Setting $set  
Get-CrmSetting -SettingType MonitoringSettings  
  
```  
  
> [!IMPORTANT]
>  After you make a change to the monitoring service settings, you may need to restart the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Monitoring Service to incorporate the change.  
  
## See Also  
 [Dynamics 365 PowerShell Reference](/powershell/dynamics365/customer-engagement/overview) </br>  
 [Operating Dynamics 365](operating-microsoft-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]