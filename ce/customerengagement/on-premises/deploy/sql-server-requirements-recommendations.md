---
title: "SQL Server requirements and recommendations for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: be02a7d8-d0a6-44b2-8e45-7216bb7045e5
caps.latest.revision: 26
author: Mattp123
ms.author: matp
manager: kvivek
---
# SQL Server requirements and recommendations for Microsoft Dynamics 365 Customer Engagement (on-premises)



The following requirements and recommendations apply to new and existing installations of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
<a name="sql_gen_rec"></a>   
## General requirements and recommendations  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] requires an instance of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] be installed, running, and available. All installations of the supported [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] editions can be used as the reporting server. However, the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] edition must match the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] edition.  
  
-   For a list of supported [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] editions, see [SQL Server editions](software-requirements-for-microsoft-dynamics-365-server.md#sql_server_editions).  
  
-   When [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] are installed on different computers, they must be in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain.  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup, Dynamics 365 Customer Engagement (on-premises) PowerShell cmdlets, and [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] support the default instance or a named instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
-   Although you can install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] by using either [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] or mixed-mode authentication, [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] is a prerequisite for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
-   The service account that [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] uses to log on to the network must be either a domain user account (recommended) or the Network Service account (you can’t use a local user account on the server). Using a low-privilege account strategy is recommended to help avoid compromising the security of the server.  
  
-   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service must be started. This service should be configured to automatically start when the computer is started.  
  
-   [!INCLUDE[pn_SQL_Server_Agent](../includes/pn-sql-server-agent.md)] must be started. This service should be configured to automatically start when the computer is started.  
  
-   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Full-Text Search must be installed and started. This service should be configured to automatically start when the computer is started.  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup requires a network library to authenticate [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. By default, [!INCLUDE[pn_TCP/IP](../includes/pn_tcp_ip_md.md)] network libraries are enabled when you install [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]. [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] can use both [!INCLUDE[pn_TCP/IP](../includes/pn_tcp_ip_md.md)] or Named Pipes for authentication. However, the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] must be configured for at least one of the two network libraries.  
  
-   We recommend that the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] be located on the same local area network (LAN) as the computer that is running the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] [!INCLUDE[Back_End_Server](../includes/back-end-server.md)] roles. <!-- For a description of the server roles, see [Dynamics 365 Server roles](microsoft-dynamics-365-server-roles.md). --> 
  
-   The computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] must be configured to have sufficient disk space, memory, and processing power to support the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] environment. For more information, see [Microsoft Dynamics 365 Server hardware requirements](microsoft-dynamics-365-server-hardware-requirements.md).  
  
-   Although it’s optional, consider accepting the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] default settings for Collation Designator, Sort Order, and SQL Collation. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports the following collation orders:  
  
    -   Case-sensitive  
  
    -   Case-insensitive  
  
    -   Accent-sensitive  
  
    -   Accent-insensitive  
  
    -   Binary sort order (such as Latin1_General_100_BIN)  
  
    > [!NOTE]
    > [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] sets the collation order at the database level. This setting might differ from that set at the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] level.  
  
-   Review all [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] installation options and be prepared to make the needed selections when you run Setup. For more information, see [SQL Server Installation](/sql/database-engine/install-windows/installation-for-sql-server?view=sql-server-2017).  
  
-   If you plan to install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] in a location other than the default file location, see [File Locations for Default and Named Instances of SQL Server](/sql/sql-server/install/file-locations-for-default-and-named-instances-of-sql-server?view=sql-server-2017).  
  
     You should also consider where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases are located on the server, and the hard-disk configuration that will support them.  
  
    > [!NOTE]
    >  To achieve the best combination of disk fault tolerance and performance, consider the many specifications for redundant array of independent disks (RAID) available from hardware vendors. Format the disks where the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database files reside for the fault-tolerance requirements of the application and performance parameters for the I/O activity occurring on that partition.  
  
-   We recommend that common language runtime (CLR) be enabled on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that hosts the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database. CLR can show a significant improvement in performance for some features such as time zone conversions when you run dashboards, charts, advanced finds, and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] interactive service hub experience. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [CLR Integration - Enabling](/sql/relational-databases/clr-integration/clr-integration-enabling?view=sql-server-2017)  
<!--  
<a name="sql2016_perf"></a>   
## Improve performance when you use  Microsoft Dynamics 365 Customer Engagement (on-premises) with SQL Server 2016  
 The following settings can help improve [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application performance and should be configured on the SQL Server 2016 instance where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization databases are serviced.  
  
-   Make sure you are running SQL Server 2016 with Cumulative Update 2 (CU2). [Server & Tools Blogs: Cumulative Update #2 for SQL Server 2016 RTM](/archive/blogs/sqlreleaseservices/cumulative-update-2-for-sql-server-2016-rtm)  
  
-   Configure the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instance where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database is maintained with trace flag 1224. This setting disables lock escalation based on the number of locks and helps reduce CPU usage on SQL Server 2016.  
  
     To determine the existing trace flag 1224 setting, run the following T-SQL statement. A return value of 0 for status in the output indicates trace flag 1224 is not enabled.  
  
    ```  
    DBCC TRACESTATUS (1224)  
    ```  
  
     To set trace flag 1224 as a startup option, add the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database engine startup option `-T1224`. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Database Engine Service Startup Options](/sql/database-engine/configure-windows/database-engine-service-startup-options?view=sql-server-2017)  
  
-   If not already set, configure [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization databases to use compatibility level **110**, which is the compatibility level for [!INCLUDE[pn_SQL_Server_2012](../includes/pn-sql-server-2012.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [View or Change the Compatibility Level of a Database](/sql/relational-databases/databases/view-or-change-the-compatibility-level-of-a-database?view=sql-server-2017)  
  
-   Configure the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database to use indirect checkpoints and a target recovery time  of 60 seconds.  By default, new databases created with SQL Server 2016 use indirect checkpoints and have a default target recover time of 60 seconds. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change the Target Recovery Time of a Database (SQL Server)](/sql/relational-databases/logs/change-the-target-recovery-time-of-a-database-sql-server)  
  
     To determine the existing target recovery time, run the following T-SQL statement, where *\<dbname>* is the name of the organization database. A return value of 0 indicates a target recover time has not been set.  
  
    ```  
    SELECT target_recovery_time_in_seconds FROM sys.databases WHERE name = ‘<dbname>’  
    ```  
  
     To set the target recover time of a database to 60 seconds, run the following T-SQL statement.  
  
    ```  
    ALTER DATABASE <dbname> SET TARGET_RECOVERY_TIME = 60 seconds;  
    ```  
  
 For information about SQL Server 2016 performance benefits, see [SQL Server Customer Advisory Team blog post: How SQL Server 2016 Cumulative Update 2 (CU2) can improve performance of highly concurrent workloads](/archive/blogs/sqlcat/sqlsweet16-episode-8-how-sql-server-2016-cumulative-update-2-cu2-can-improve-performance-of-highly-concurrent-workloads).  
-->
  
## See also  
[Microsoft SQL Server hardware requirements for Microsoft Dynamics 365 Server](sql-server-hardware-requirements-dynamics-365-server.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]