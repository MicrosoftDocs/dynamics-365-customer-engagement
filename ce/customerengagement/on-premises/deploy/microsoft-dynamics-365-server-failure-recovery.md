---
title: "Microsoft Dynamics 365 Server failure recovery | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: fd3400ef-18f5-430e-9a46-0bf38b21024f
caps.latest.revision: 11
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Server failure recovery



Most of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configuration information is stored on the computer that’s running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. Therefore, the information can be recovered if all, or part, of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] fails. [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)] entries on [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] are recovered when you run the repair program or reinstall processes for [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)].  
  
 We recommend that you keep a record of your current [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] update level. Then, if failure recovery is required, the appropriate update can be reapplied.  
  
1.  Install the operating system on another server and join the same [!INCLUDE[pn_Active_Directory_Domain_Services](../includes/pn-active-directory-domain-services.md)] domain as the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
2.  Install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. During [!INCLUDE[pn_Setup](../includes/pn-setup.md)], select **Connect to, and if necessary, upgrade an existing deployment** when prompted. If [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] was also installed on the computer that failed, install the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] after [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is completed.  
  
3.  If the ISV.config or web.config files have been changed from their default settings, restore these files from backup.  
  
4.  Publish all customizations. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Publishing customizations](/powerapps/maker/common-data-service/publish-changes-for-use-customer-service-hub
)  
  
## See Also  
 [Failure Recovery](microsoft-dynamics-365-failure-recovery.md)   </br>
 [Microsoft Dynamics 365 PowerShell Reference](/powershell/dynamics365/customer-engagement/overview)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]