---
title: "Microsoft Dynamics 365 for Outlook failure recovery | MicrosoftDocs"
ms.custom:
ms.date: 11/28/2016
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: fb14fa58-89e9-49a6-b94c-61de90d58a54
caps.latest.revision: 22
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Outlook
---
# Microsoft Dynamics 365 for Outlook failure recovery
[!INCLUDE[pn_crm_for_outlook_full](../../includes/pn-crm-for-outlook-full.md)] with “Go offline” capability uses [!INCLUDE[pn_ms_SQL_Server_Express_long](../../includes/pn-ms-sql-server-express-long.md)] for local data storage on the user’s computer. This enables [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] users to work offline and later synchronize local data with [!INCLUDE[pn_SQL_Server_short](../../includes/pn-sql-server-short.md)] (on-premises) or [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] when [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is brought online again.

 In some cases, [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] users may want to back up the local [!INCLUDE[pn_ms_SQL_Server_Express_long](../../includes/pn-ms-sql-server-express-long.md)] database. This is especially useful when [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] users are offline for prolonged periods. The following table indicates different methods that can be used for backing up the SQL database used with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].


|              Backup method              |                                                                                                                                                                                                                                                                                          What to back up                                                                                                                                                                                                                                                                                          |                                                                                                                                      Comments                                                                                                                                       |
|-----------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|             Offline backup              | Contents of [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data directory.<br /><br /> The default location of 64-bit [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] on 32-bit [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)]:  %programfiles%\Microsoft Dynamics 365 apps\\*LocaleCode*\sql\7<br /><br /> The default location of 32-bit [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] on 64-bit [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)]:  %programfiles(x86)%\Microsoft Dynamics 365 apps\\*LocaleCode*\sql\7 | Before you start the backup, make sure that the [!INCLUDE[pn_SQL_Server_short](../../includes/pn-sql-server-short.md)] (CRM) service is stopped. Restart the service after the backup is complete.<br /><br /> *LocaleCode* is the 4-digit number representing the language locale. |
|   Online backup using Microsoft tools   |                                                                                                                                                                                                                                                                      **MSDE_MSCRM7.mdf**<br /><br /> **MSDE_MSCRM7_log.LDF**                                                                                                                                                                                                                                                                      |                                                             Use [!INCLUDE[pn_ms_SQL_Server_Mgmt_Studio_Express_long](../../includes/pn-ms-sql-server-mgmt-studio-express-long.md)] or sqlcmd.exe (a command-line tool).                                                             |
| Online backup using non-Microsoft tools |                                                                                                                                                                                                                                                                      **MSDE_MSCRM7.mdf**<br /><br /> **MSDE_MSCRM7_log.LDF**                                                                                                                                                                                                                                                                      |                                                                         Look for tools that are compatible with [!INCLUDE[pn_ms_SQL_Server_Express_long](../../includes/pn-ms-sql-server-express-long.md)].                                                                         |

## Backup and recovery tools
 [!INCLUDE[pn_ms_sql_2012_express](../../includes/pn-ms-sql-2012-express.md)] provides a graphical management tool (SQL Server Management Studio Express (SQLManagementStudio)) that includes backup and recovery features. You can download SQL Server Management Studio Express at [Microsoft SQL Server® 2012 Service Pack 2 (SP2) Express](https://www.microsoft.com/download/details.aspx?id=43351).

## Restoring from backup
 If there is a problem with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] offline synchronization, the backup can be used to restore [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] functionality. [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] should be in offline mode before you restore the backup. When restored, you can then connect to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] (online mode). The data that isn’t already on the server will be transferred to the server from the client. Be careful when reconnecting to the server. If you restore from an outdated backup, the existing data on the server may have subsequently changed and you run the risk of overwriting current data on the server with older data from the offline client backup.



[!INCLUDE[footer-include](../../includes/footer-banner.md)]