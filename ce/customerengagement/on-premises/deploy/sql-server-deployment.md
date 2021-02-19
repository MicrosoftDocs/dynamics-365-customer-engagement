---
title: "SQL Server deployment | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 90fd46d5-66be-4465-9a37-ba4ee99be386
caps.latest.revision: 35
ms.author: matp
author: Mattp123
manager: kvivek
---
# SQL Server deployment



If your organization uses [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] for applications other than [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], performance may degrade as resources are consumed by other applications. If you use a computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is used for other applications, you must carefully analyze the effect that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will have on the existing installation of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. For information about monitoring [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], see [Performance Monitoring and Tuning Tools](/sql/relational-databases/performance/performance-monitoring-and-tuning-tools?view=sql-server-2017).  
  
 For best results, we recommend that you maintain the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases on a computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and that will support only [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and no other databases or database applications.  
 
  
<a name="BKMK_SQLServerDep"></a>   
## SQL Server deployment considerations  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is a database-intensive application. Before you deploy [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to an instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], you should consider the following requirements and database configurations:  
  
-   **Modification of system tables.** The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] system tables should not be modified before you install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. Some database applications may modify the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] system tables. If this occurs, problems with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and data may result.  
  
-   **Indexing.** Full-text indexing must be installed. This is required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] knowledge-base functionality.  
  
-   **Compatibility level.** During an upgrade or a new installation, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] sets the organization database compatibility level to 130, which is the compatibility level of Microsoft SQL Server 2016.  
  
-   **Autogrowth**. By default, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database files are created to have an autogrowth setting of 1 MB. If you perform intensive database transactions, such as large data imports, consider increasing the autogrowth value to improve performance. For information about how to change the autogrowth setting for a database, see the [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)] Help.  
  
-   **Max server memory.** We recommend that, if you run [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] on a computer that is also running other applications, that the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] max server memory be set to no more than one half of the installed RAM. By default, max server memory is set to 2147483647 megabytes in recent versions of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], which has demonstrated resource issues with [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] during intensive use of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][MSDN: Server Memory Options](https://msdn.microsoft.com/library/ms178067.aspx)  
  
-   **Max degree of parallelism.** We recommend if you experience poor [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] performance, which can occur due to complex index statements, that the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] max degree of parallelism be set to 1 to help improve overall application performance on multiprocessor systems. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][MSDN: Configure max degree of parallelism Option](https://msdn.microsoft.com/library/ms189094.aspx)  
  
-   **RCSI.** Running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that uses a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] configured for read committed snapshot isolation (RCSI) is supported for use with this version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
<a name="BKMK_LanguageLocale"></a>   
## Language locale collation and sort order  
 Installing [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] in a language other than English (U.S.) may require changing the Collation designator. The following table indicates the Collation designator to use for some of the available languages.  
  
|Windows Locale|Locale Identifier (LCID)|Collation Designator|Code Page|  
|--------------------|--------------------------------|--------------------------|---------------|  
|Danish|0X406|Danish_Norwegian|1252|  
|Dutch (Standard)|0X413|Latin1_General|1252|  
|English (United States)|0X409|Latin1_General|1252|  
|French (France)|0X40C|French|1252|  
|German (Germany)|0X407|Latin1_General|1252|  
|Italian|0X410|Latin1_General|1252|  
|Portuguese (Brazil)|0X416|Latin1_General|1252|  
|Spanish (Traditional Sort)|0XC0A|Modern_Spanish|1252|  
  
<a name="BKMK_DiskConfig"></a>   
## Disk configurations and file locations  
 For the default instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], the default directory for data files is \Program Files\Microsoft SQL Server\MSSQL*\<ver>*.MSSQLSERVER\MSSQL\DATA, where *\<ver>* is the major version of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], such as 13 for SQL Server 2016. You can specify a file path other than the default for both program and data files.  
  
> [!NOTE]
>  The default locations for program and data files are not necessarily the best locations. For the best combination of disk fault tolerance and performance, consider the RAID specifications available from hardware vendors. You can create the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases on your partitions, especially for these files, and specify the existing databases when you run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]. The databases created by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] are noted in the specified data file location. For more information, see [SQL Server data file location](sql-server-deployment.md#BKMK_SQLServerData) later in this topic.  
  
 By default, tools are installed in \Program Files\Microsoft SQL Server\110\Tools on the system drive. This folder contains the default and named files shared by all instances of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. Tools include [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn-ms-sql-management-studio-long.md)], the T-SQL command line utility, and the OSQL SQL query tool.  
  
 [!INCLUDE[pn_Microsoft_SQL_Server_Setup](../includes/pn-microsoft-sql-server-setup.md)] also installs files in the Windows system directory. The system file location cannot be changed.  
  
<a name="BKMK_SQLServerProg"></a>   
## SQL Server program file location  
 The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] program files are located in \Program Files\Microsoft SQL Server\MSSQL*\<ver>*.MSSQLSERVER\MSSQL\Binn.  
  
 The binary file location is in the root directory where Setup creates the folders that contain program files and other files that typically do not change this path as you use [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. Although these files are not read-only, the folders do not contain data, logs, back-up files, or replication data. Therefore, the space requirements for these files should increase only marginally as [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is used, and over time as updates are applied.  
  
> [!IMPORTANT]
>  Program files cannot be installed on a removable disk drive.  
  
<a name="BKMK_SQLServerData"></a>   
## SQL Server data file location  
 Each SQL Server database consists of one or more database files and one or more transaction log files. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] creates at least two databases:  
  
-   **MSCRM_CONFIG.** This database contains [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] metadata, such as configuration and location information that is specific to each organization database.  
  
-   **OrganizationName*_MSCRM.** This is the organization database where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data is stored, such as all records and activities. [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] supports multiple organizations so that you can have multiple-organization databases.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] also relies on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] system databases to store [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configuration information. These databases include the master and msdb databases. The database files that accompany a database contain all its data and properties. Transaction log files contain a record of the write activity in the database, such as when a row is added, changed, or removed. Transaction log files are binary and cannot be used for auditing database activity.  
  
 For backup and recovery information for [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases including transaction log files, see [MSDN: Back Up and Restore of SQL Server Databases](/sql/relational-databases/backup-restore/back-up-and-restore-of-sql-server-databases?view=sql-server-2017).  
  
<a name="BKMK_db_rename"></a>   
## Microsoft Dynamics 365 database renaming considerations  
 As described earlier, a [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] deployment contains the following databases:  
  
-   A single MSCRM_CONFIG database  
  
-   One or more (for multi-tenant deployments) *OrganizationName*_MSCRM databases  
  
 The configuration database, MSCRM_CONFIG, cannot be renamed. If the MSCRM_CONFIG database is renamed, the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system will not function correctly.  
  
 Organization databases, OrganizationName_MSCRM, can be renamed by following the guidelines and considerations described here.  
  
### Organization database names  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization databases use both a display and a unique name.  
  
-   **Display name.** This is the name that appears in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application, such as the upper-right corner of the main application screen. The display name can contain spaces and be up to 250 characters long.  
  
-   **Unique name.** This is the name that is used to create the URL to connect to the application and is appended with **_MSCRM**. It is also the physical name of the database as it appears in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] applications, such as [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn-ms-sql-management-studio-long.md)]. This name cannot contain spaces and cannot be more than 30 characters long.  
  
### Organization database renaming  
 The display name may be changed by using the [!INCLUDE[pn_Edit_Organization_Wizard](../includes/pn-edit-organization-wizard.md)] in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]. The basic steps are to disable the organization, and then run the [!INCLUDE[pn_Edit_Organization_Wizard](../includes/pn-edit-organization-wizard.md)]. For more information, see [Edit an organization's attributes](edit-an-organization-s-attributes.md).  
  
 Although we do not recommend it, you can change the name of an organization’s unique database name (*OrganizationName*_MSCRM). To change the database unique name, follow these steps:  
  
> [!WARNING]
>  Renaming the unique database name for an organization has not been fully tested by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] and may cause unexpected results. We cannot guarantee that problems caused by performing this procedure can be resolved. Rename the organization database unique name at your own risk.  
  
> [!IMPORTANT]
>  Before you start the following procedure, take a full back up of the organization database that you want to rename.  
  
 The following steps require you to already have a functioning organization database that was created by [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] or imported by a supported [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] method.  
  
1.  Restore the backup of the organization database to your [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that uses the name that you want and that is supported by [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
2.  Import the renamed organization database to your existing Microsoft Dynamics 365 deployment by using the [!INCLUDE[pn_Import_Organization_Wizard](../includes/pn-import-organization-wizard.md)] in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
3.  During the import, enter into the organization database a display name and unique name that are unrelated to the original database name.  
  
4.  Follow the instructions on your screen to complete the import.  
  
5.  Ensure that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users have the new URL that will be created as a result of the organization rename.  
  
<a name="BKMK_SQLTransparentData"></a>   
## SQL Server transparent data encryption (TDE)  
 The [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] transparent data encryption (TDE) feature is supported for use with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. However, based on test results conducted internally, using this feature can cause a decrease in overall performance of approximately 10% when run against an encrypted database with the same workload.  
  
<a name="OLTP"></a>   
## SQL Server In-Memory OLTP  
 Currently, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database tables do not support [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] in-memory online transaction processing (OLTP). For more information about OLTP, see [In-Memory OLTP (In-Memory Optimization)](https://technet.microsoft.com/library/dn133186.aspx).  
  
## See Also  
 [SQL Server installation and configuration](sql-server-installation-and-configuration.md) </br>
 [SQL Server requirements and recommendations for Microsoft Dynamics 365](sql-server-requirements-recommendations.md)   




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]