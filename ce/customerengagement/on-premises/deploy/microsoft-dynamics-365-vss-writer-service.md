---
title: "Dynamics 365 VSS writer service | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 600f8305-bbe6-487b-a3bd-0249bb8e371f
caps.latest.revision: 12
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 VSS writer service



The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Volume Shadow Copy Service (VSS) Writer Service provides added functionality for backing up and restoring [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases through the VSS framework.  
  
 VSS is a set of Component Object Model (COM) application programming interfaces (APIs) that provides standardized interfaces, enabling backup and restoration software, such as Systems Center Data Protection Manager, to centrally manage the backup and restore operations on a variety of applications. VSS also implements a framework that enables volume backups to be performed while applications on a system continue to write to the volumes.  
   
  
<a name="BKMK_dependencie"></a>   
## Dependencies  
  
-   [!INCLUDE[pn_system_center_2012](../includes/pn-system-center-2012.md)] [!INCLUDE[pn_data_protection_manager_dpm](../includes/pn-data-protection-manager-dpm.md)]  
  
-   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] VSS Writer. The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] VSS Writer service, which is available with [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)], must be started for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer service to work correctly.  
  
> [!IMPORTANT]
>  Earlier versions of [!INCLUDE[pn_ms_System_Center_short](../includes/pn-ms-system-center-short.md)] DPM aren’t supported.  
  
<a name="BMMK_permissions"></a>   
## Permissions required  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer runs as a service and can be run either under Network Service or a domain user account. For information about the required permissions, see [Minimum permissions required for Microsoft Dynamics 365 Setup and services](security-considerations-for-microsoft-dynamics-365.md#BKMK_MinimumPermissions).  
  
<a name="BKMK_Features"></a>   
## Features  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer supports:  
  
-   Backup and restore of the configuration (MSCRM_CONFIG) and multiple organization (*organizationName*_MSCRM) databases.  
  
-   The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application doesn’t need to be offline while databases are backed up.  
  
-   During a database restore, the application is automatically taken offline, and after successful restoration, brought back online again.  
  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer doesn’t support:  
  
-   Backup and restore of [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] databases that are integrated with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For these databases, use the [SharePoint VSS Writer](/SharePoint/administration/prepare-to-back-up-and-restore).  
  
-   Backup and restore of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] databases that are used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] reporting. For these databases, use the [SQL Server VSS Writer](https://technet.microsoft.com/library/ms175536.aspx).  
  
<a name="BKMK_Steps"></a>   
## Steps required to use with System Center Data Protection Manager  
 The following command needs to be executed in the DPM Management Shell on the computer where [!INCLUDE[pn_system_center_2012](../includes/pn-system-center-2012.md)] DPM is running so that Data Protection Manager can recognize the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer. The user running the command must be a member of the administrators group on the local computer.  
  
```  
Set-DPMGlobalproperty -dpmservername DPM_SRVR_NAME -registeredwriters APPS_VSS_WRITER_ID  
```  
  
 DPM_SRVR_NAME is the name of the computer where [!INCLUDE[pn_system_center_2012](../includes/pn-system-center-2012.md)] DPM is running.  
  
 APPS_VSS_WRITER_ID is the unique identifier of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer service, which is always `74bf91e0-e0fa-4ba9-9258-48f4fd1d0445`.  
  
## See also  
 [Microsoft Dynamics 365 Customer Engagement (on-premises) data protection and recovery](microsoft-dynamics-365-data-protection-and-recovery.md)   </br>
 [Back up the Microsoft Dynamics 365 Customer Engagement (on-premises) System](back-up-the-microsoft-dynamics-365-system.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]