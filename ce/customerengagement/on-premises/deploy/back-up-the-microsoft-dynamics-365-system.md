---
title: "Back up the Dynamics 365 Customer Engagement (on-premises) system | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 30f8e3fe-972f-4bf8-9f53-e9218ca432be
caps.latest.revision: 27
ms.author: matp
author: Mattp123
manager: kvivek
---
# Back up the Dynamics 365 Customer Engagement (on-premises) system



To recover from any scenario, you must back up all needed information and store a copy off site. A backup plan should be created and rehearsed for all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] components and services to make sure that, if a disk or other failure occurs, the maximum amount of data is recoverable.  
  
<a name="BKMK_Backup"></a>   
## Backup requirements summary  
 Backup requirements vary according to the servers involved. The following table is a summary of what to back up for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
|Server|What to back up|Comments|  
|------------|---------------------|--------------|  
|Domain controller|Full System State|None.|  
|[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]|MSCRM_CONFIG<br /><br /> OrganizationName_MSCRM<br /><br /> master<br /><br /> msdb<br /><br /> *ReportServer*<br /><br /> *ReportServer*tempdb|The OrganizationName_MSCRM and *ReportServer* databases should have full database backups and transaction log backups.<br /><br /> For databases that are rarely updated, such as msdb, you may select only full database backup.<br /><br /> Backups of the master and msdb databases aren’t required by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] but should be part of an overall backup strategy.|  
|SharePoint|Backup recommended if [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration is enabled.|If you have enabled [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] document management, we recommend that you back up the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] databases. For more information, see the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] documentation.|  
|[!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)]|Backup not required by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].|Backup may be required for [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)]. For more information, see [Backup, restore and disaster recovery](https://technet.microsoft.com/library/dd876874\(v=exchg.150\).aspx).|  
|Microsoft Dynamics 365 Server|web.config<br /><br /> (Default location: c:\Program Files\Microsoft Dynamics CRM\CRMWeb)<br /><br /> [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)]:<br /><br /> HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM|The web.config file is required only if the file has been changed from the default settings.<br /><br /> [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)] subkey.|  
  
<a name="BKMK_SelectBackup"></a>   
## Selecting a backup technology and type  
 [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] includes Volume Shadow Copy Service (VSS) support that can be used in conjunction with System Center Data Protection Manager to centrally manage the backup and restore operations for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information, see [Microsoft Dynamics 365 VSS Writer](microsoft-dynamics-365-vss-writer-service.md) and [Data Protection Manager](/previous-versions/system-center/system-center-2012-R2/hh758173(v=sc.12)).  
  
 [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] Backup in [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)] supports external and internal hard disks, optical media drives, removable media drives, and [!INCLUDE[pn_Hyper-V](../includes/pn-hyper-v.md)] virtual machines for local storage. Additionally, [!INCLUDE[pn_windowsserver2012](../includes/pn-windowsserver2012.md)] supports online backup by using [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] Online Backup. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Azure Backup](https://azure.microsoft.com/services/backup/)  
  
 To perform a scheduled backup, as a best practice, use an external hard disk that supports at least USB 2.0 or IEEE 1394.  
  
 In Windows Server, you can perform three types of backup:  
  
-   System state backup, which includes all the files that are required to recover [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
-   Critical-volumes backup, which includes all the volumes that contain system state files.  
  
-   Full server backup, which includes all volumes on the server.  

<!--   
<a name="BKMK_BackupWinServ"></a>   
## Backing up Windows Server  
 [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] has backup tools that let you back up important company data to disk, removable media, or cloud. The scheduling capability found in the [!INCLUDE[pn_Backup_and_Restore_Wizard](../includes/pn-backup-and-restore-wizard.md)] provides data backup for the server itself and workstations in the small business network. The data backed up includes security information, file and share permissions, and registry data. For data security, only a member of the Administrators or Backup Operators group can perform a backup. Individual files and directories on the server can be restored by using the [!INCLUDE[pn_Backup_and_Restore_Wizard](../includes/pn-backup-and-restore-wizard.md)].  
  
<a name="BKMK_BackupAD"></a>   
## Backing up Active Directory  
 You can use [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] Backup to protect your operating system state, volumes, files, and application data. For instructions about how to back up [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], see [Windows Server Backup Feature Overview](/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/jj614621(v=ws.11)) and [Windows Server 2012: Planning for Active Directory Forest Recovery](https://www.microsoft.com/download/details.aspx?id=16506).  
  
 Although we recommend that you back up [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], the only way to avoid data loss is to have multiple [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controllers. Then, if a domain controller fails, the other domain controllers will have a complete copy of the directory. With a backup, you have data only as recent as your last backup.  -->
  
<a name="BKMK_BackupSQL"></a>   
## Backing up SQL Server, including Reporting Services  
 Windows Server Backup uses Volume Shadow Copy Services (VSS) to protect [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] application data. An alternative solution that can be used while [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] runs is the built-in backup features of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)].  
  
 If you use [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)] to create a backup of the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases, you can run a backup job from the [!INCLUDE[pn_Backup_and_Restore_Wizard](../includes/pn-backup-and-restore-wizard.md)] to include database backups that [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] created. Schedule the backup routing in [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] to run first, followed by a backup job run in the [!INCLUDE[pn_Backup_and_Restore_Wizard](../includes/pn-backup-and-restore-wizard.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Back Up and Restore of SQL Server Databases](/sql/relational-databases/backup-restore/back-up-and-restore-of-sql-server-databases?view=sql-server-2016)  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] creates at least two [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]-specific databases on [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. In addition, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] requires the default master and msdb[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases for database services and the default report server [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases for [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)]. The databases that make up a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system on [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] are as follows:  
  
-   OrganizationName_MSCRM  
  
-   MSCRM_CONFIG  
  
-   ReportServer  
  
-   ReportServertempdb  
  
-   master  
  
-   msdb  
  
> [!NOTE]
>  For multitenant deployments, your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment will include more than one *OrganizationName*_MSCRM database.  
  
 The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] backup plan should address each of these databases to make sure that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] could recover if one, or all, databases fail. If your organization already has [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] or another database application, your database administrator may have a database backup strategy. However, if this is the first database application in your organization, you can create and maintain scheduled jobs to perform the necessary backups by using the Maintenance Plan Wizard in [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)]. To start the Maintenance Plan Wizard, in [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)], expand the server, expand the **Management** folder, right-click the **Maintenance Plans** folder, and then select **Maintenance Plan Wizard**.  
  
 Your backup plan for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases provides you a backup set that includes a full database backup and some number of transaction log backups, depending on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] installation and the frequency with which you determine whether you must have backups.   
  
 For databases that are updated infrequently, such as the msdb database, you might perform only full database backups. The *OrganizationName*_MSCRM, MSCRM_CONFIG, and *ReportServer* databases should have both full database and transaction-log backups.  
  
 Databases on which transaction log backups will be performed must have the Full recovery model database property set. You can set this property through [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)].  
  
 Schedule full database backups frequently enough to reduce the number of restores after a failure. For example, if one day's data loss is acceptable, you can back up the transaction log one time per day, and back up the database one time per week. If only one hour's maximum data loss is acceptable, you can back up the transaction log one time per hour. To reduce the number of restores, back up the database one time per day.  
  
 To create a database maintenance plan for scheduled backups, run the Maintenance Plan Wizard from [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)]. Select the option to back up the database as part of the maintenance plan for a full database backup. Select the option to back up the transaction log as part of the maintenance plan for a transaction log backup.  
  
 Your computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] should also be designed with a level of fault-tolerance that is correct for a database server. This includes a RAID-5 disk array for your databases and a RAID-1 (mirror) for your transaction logs. With the correct level of hardware fault-tolerance, restoring from backup should be a very uncommon occurrence.   
  
<a name="BKMK_BackupCRM"></a>   
## Backing up Microsoft Dynamics 365 Server  
 Backing up and restoring the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] basically involves the following data:  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] database files (explained previously)  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] program files  
  
-   [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website files  
  
 For information about how to back up solutions and customizations that have been implemented outside of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application, contact your solution vendor.  
  
> [!NOTE]
>  We recommend that you keep a record of your current [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] update version. Therefore, if failure recovery is required, the appropriate update can be reapplied.  
  
 By default, all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] program files are located in the following folders:  
  
-   C:\Program Files\Microsoft Dynamics CRM\  
  
-   C:\Program Files\Microsoft Dynamics 365 Reporting Extensions\  
  
 By default, the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website files are located in the following folder:  
  
-   C:\Program Files\Microsoft Dynamics CRM\CRMWeb  
  
## See Also  
 [Microsoft Dynamics 365 data protection and recovery](microsoft-dynamics-365-data-protection-and-recovery.md) </br>
 [Exporting and importing customizations and solutions](exporting-and-importing-customizations-and-solutions.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]