---
title: "After the upgrade | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: ba745854-2569-4fc9-82f2-8aa41e0eac79
caps.latest.revision: 28
ms.author: matp
author: Mattp123
manager: kvivek
---
# After the upgrade



After Setup completes the upgrade, perform the following tasks.  
  
## Post-upgrade steps for servers  
  
1.  If you have additional network load balanced servers or [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server roles installed on other computers, upgrade or uninstall and reinstall [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on those servers as described in [Install Microsoft Dynamics 365 Front End Server and Back End Server roles](install-dynamics-365-front-back-end-server-roles.md).  
  
2.  Install the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)]. You must install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] before you can import and upgrade organizations not upgraded during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]. More information: [Install Microsoft Dynamics 365 Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md) 
  
3.  If you had [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] provisioned in the deployment, download and install [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)] [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] for the languages that you want. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Upgrade and deploy a Language Pack](upgrade-and-enable-a-language-pack.md)  
  
4.  If available, install the latest update. More information:  [Update Microsoft Dynamics 365](update-microsoft-dynamics-crm.md)
  
5.  If needed, import organizations. During import, each organization will be upgraded. To do this, use the [Import-CrmOrganization](https://docs.microsoft.com/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps) [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command. Alternatively, you can use [!INCLUDE[pn_Deployment_Manager_long](../includes/pn-deployment-manager-long.md)].  
  
6.  In [!INCLUDE[pn_ms_SQL_SRS_ReportManager_long](../includes/pn-ms-sql-srs-reportmanager-long.md)], re-create any custom data sources under the *OrganizationName*_MSCRM folders.  
  
7.  Some organization data is encrypted using encryption keys. These keys should be copied as part of your failure recovery procedures. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Data Encryption](../admin/data-encryption.md)  
  
8.  Verify that the system jobs and workflows are running. More information: [Monitor and manage workflow processes](/flow/monitor-manage-processes) 
  
9. Although not required, we recommend that you register [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Post-upgrade steps for clients  
 To ease the upgrade process, [!INCLUDE [pn-crm-for-outlook-short](../includes/pn-crm-for-outlook-short.md)] (8.2) is compatible with [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)].  
  
> [!IMPORTANT]
>  The Dynamics 365 for Outlook **Go offline** functionality is no longer available with this release of Dynamics 365 Customer Engagement (on-premises).  
  
#### Upgrade clients  
  
1.  Run [!INCLUDE [pn-dynamics-365-for-outlook-v-90](../includes/pn-dynamics-365-for-outlook-v-90.md)] Setup on every [!INCLUDE [pn-crm-for-outlook-short](../includes/pn-crm-for-outlook-short.md)] (8.2) user's computer. To distribute the upgrade, use [!INCLUDE[pn_ms_System_Center_long](../includes/pn-ms-system-center-long.md)] or Microsoft Group Policy to push the upgrade to users. For more information about Group Policy distribution, see [Deploy Microsoft Dynamics 365 for Outlook by using Group Policy](../../../outlook-addin/admin-guide/deploy-using-group-policy.md).  
  
2.  After the upgrade is complete, verify that [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] has the latest updates.  
  
3.  Test the functionality from [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] and from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Upgrade Microsoft Dynamics 365 for Outlook](../../../outlook-addin/admin-guide/upgrade.md)  
  
## See Also  
 [Upgrade Dynamics 365 Server](upgrade-from-microsoft-dynamics-365-server.md)  




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]