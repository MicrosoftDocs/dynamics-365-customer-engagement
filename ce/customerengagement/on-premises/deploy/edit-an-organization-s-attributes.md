---
title: "Edit an organization's attributes | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ff791d05-326a-42be-a9fb-912a8bb497d0
caps.latest.revision: 15
author: Mattp123
ms.author: matp
manager: kvivek
---
# Edit an organization's attributes



Before you can edit an organization, you must disable it. After you make the changes, re-enable the organization.  
  
 You can change the display name and [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] computer where the organization database is located. Also, you can change the [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)] URL, which specifies where the [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)] is installed.  
  
 You cannot change the name of the organization.  
  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the Disable-CrmOrganization and Edit-CrmOrganization commands in the [Microsoft Dynamics 365 Customer Engagement (on-premises) PowerShell Reference](/powershell/module/microsoft.crm.powershell/?view=dynamics365ce-ps).  
  
### Edit an organization  
  
1.  In the console tree, select **Organizations**.  
  
2.  Right-click the organization you want to edit, select **Disable**, and then select **Yes**.  
  
3.  Right-click the organization again, and then select **Edit Organization**.  
  
4.  In the **Edit Organization Wizard**, change the following as necessary:  
  
    -   **Display Name**. Type a name for the organization.  
  
    -   **[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]**. Type the name of the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] where the organization database is located. Be aware that, before you can change the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] for an organization, the organization database must be located on the new [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], attached, and available. The Edit Organization Wizard does not move the database for you. For more information about how to move a database in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], see [Database Detach and Attach](/sql/relational-databases/databases/database-detach-and-attach-sql-server?view=sql-server-2017).  
  
    -   **SQL Server Reporting Services URL**. Type the URL of the computer that is running [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] where the [!INCLUDE[pn_crm_report_ext_SRS_short](../includes/pn-crm-report-ext-srs-short.md)] is installed.  
  
5.  Select **Next**.  
  
     The **System Checks** page appears. This page is a summary of all system requirements to create new organization settings. Failed tests must be corrected and all errors resolved before the settings can be applied. If necessary, cancel the Edit Organization Wizard, fix the problem, and then try again.  
  
6.  When no errors, or only warnings, appear, select **Next**.  
  
7.  On the **Ready to Apply Changes** page, select **Apply**.  
  
8.  On the **Edit Organization** page, select **Finish**.  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Disable or enable a server](disable-or-enable-a-server.md)   
 [Manage servers](manage-servers.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]