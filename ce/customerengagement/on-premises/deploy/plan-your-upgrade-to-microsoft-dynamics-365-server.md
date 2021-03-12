---
title: "Plan your upgrade to Microsoft Dynamics 365 Server | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1755c489-1b3e-490e-acfb-d1ff68384ff4
caps.latest.revision: 55
author: Mattp123
ms.author: matp
manager: kvivek
---
# Plan your upgrade to Microsoft Dynamics 365 Server

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

This section provides guidelines for preparing for an upgrade to [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)]. Performing these tasks in advance can help minimize system downtime and ensure a successful upgrade. Also, this section describes how [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] upgrades your current system and what happens to items such as existing reports, customizations, and solutions.  
  
 [!INCLUDE [pn-crm-8-2-0-op](../includes/pn-crm-8-2-0-op.md)] (8.2) server roles are not compatible with a [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] deployment. Therefore, after you upgrade the first server, other [!INCLUDE [pn-crm-8-2-0-op-subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)] server roles that are running in the deployment will become disabled. As each server is upgraded, the corresponding server will be enabled.  
  
 You can upgrade [!INCLUDE [pn-crm-8-2-0-op-subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)] server roles in any order. However, to have a fully functioning [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)]  deployment, all servers and server roles must be upgraded.  
  
> [!IMPORTANT]
>  The only supported upgrade path to [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] is upgrade from [!INCLUDE [pn-crm-8-2-0-op-subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)], or later update, to [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)].   
  
## Recommended upgrade steps  
 To ease the upgrade process and minimize downtime, we recommend that you follow these basic steps when you upgrade [!INCLUDE [pn-microsoft-dynamics-crm-2016-server](../includes/pn-microsoft-dynamics-crm-2016-server.md)].  
  
1.  We recommend that you apply the latest available update before you begin the upgrade. More information: [Microsoft Dynamics 365 Customer Engagement (on-premises) On-Premise Cumulative Updates](https://support.microsoft.com/help/3142345/microsoft-dynamics-365-onpremise-cumulative-updates)  
  
2. Copy the organization encryption key for all organizations that will be upgraded. The encryption key is required to activate data encryption when you import an organization database into a new instance of SQL Server. More information: [Copy your organization data encryption key](../admin/data-encryption.md#copy-your-organization-data-encryption-key)

3. Install (recommended) or upgrade all server roles to [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)]. 

4. Import organizations into the new or upgraded deployment. During the import, organizations will also be upgraded.
  
<a name="BKMK_Upgradeoptions"></a>   
## Microsoft Dynamics Server upgrade options  
 There are three different upgrade options:  
  
-   **Migrate by using a new instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]**. We recommend this option for upgrading the deployment. Although this option requires a different computer for [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] and a different instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], it provides the least amount of potential downtime for users since the existing deployment can remain functional until the upgrade is completed and verified.  
  
-   **Migrate by using the same instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].** This option requires a different computer for [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)], but will upgrade in-place the configuration and default organization databases using the same instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. If issues occur during the upgrade, you must roll back to the previous  version to avoid significant downtime.  
  
-   **In-place upgrade.** Although this option doesn’t require a different computer for [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] or a different instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], it poses the greatest risk if upgrade issues occur because a rollback and reinstall of the previous version of Dynamics 365 Server will be required to avoid potential downtime.  
  
 For the latest product information, see the [Microsoft Dynamics 365 Customer Engagement (on-premises), version 9.0 Readme](https://go.microsoft.com/fwlink/?linkid=2020048).  
  
> [!IMPORTANT]
>  Always run a full backup of the [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] databases before you upgrade to a new version of the product. <!-- For information about database backups, see [Back up the Microsoft Dynamics 365 Customer Engagement (on-premises) System](back-up-the-microsoft-dynamics-365-system.md).  -->
>   
>  During an in-place upgrade, only the organization that you specify to upgrade is upgraded. If the deployment contains additional organizations, those organizations are disabled and are not upgraded. You must upgrade those organizations using the `Import-CrmOrganization` [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command or by using [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dynamics 365 Customer Engagement (on-premises) PowerShell Reference](/powershell/dynamics365/customer-engagement/overview) <!-- and [Import an organization](import-an-organization.md)  -->
>   
>  For each organization that you upgrade, we recommend that the volume have free space that is at least three times the size of the organization database file (organizationName_MSCRM.mdf) and four times the size of the log file (organizationName_MSCRM.ldf). For example, if a single organization database and log file are located on the same volume where the MDF file is 326 MB and the LDF file is 56 MB, the recommended available space should be at least 1.2 GB to allow for growth ((326 x 3) + (56 x 4)). Notice that the database files that expand during upgrade do not reduce in size after the upgrade is complete.  
  
  
<a name="BKMK_UpgradeKey"></a>   
## Upgrade product key  
 Before the upgrade, obtain the product key that you will enter during the upgrade.   
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Microsoft Dynamics 365 Customer Engagement (on-premises) editions and licensing](microsoft-dynamics-365-editions-and-licensing.md)  
  
<a name="BKMK_UserPermissions"></a>   
## User permissions and privileges  
 To perform a successful upgrade, the user who runs [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] Server Setup must:  
  
-   Have an account in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the server or servers that are being upgraded.  
  
-   Be a member of both the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] Role and the [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] [!INCLUDE[pn_System_Administrator_Role](../includes/pn-system-administrator-role.md)] for any organizations that will be upgraded.  
  
    > [!IMPORTANT]
    >  The upgrade will fail if the user who is running the upgrade has a disabled [!INCLUDE[pn_System_Administrator_Role](../includes/pn-system-administrator-role.md)].  
  
-   Have administrator rights on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server associated with the deployment that is being upgraded.  
  
-   Have sufficient permissions to create new security groups and add members to those groups in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] organizational unit that contains the existing [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] groups.  
  
<a name="BKMK_SharingSQL"></a>   
## Sharing a SQL Server  
 Only one [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] deployment per instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is supported. This is because each  deployment requires its own MSCRM_CONFIG database, and multiple instances of the MSCRM_CONFIG database can’t coexist on the same instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. If you have multiple [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instances running on the same computer, you can host the databases for multiple [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] deployments on the same computer. However, this might decrease system performance.  
  
<a name="BKMK_TipsUpgrade"></a>   
## Tips for a successful upgrade  
 The following issues, if applicable to your current deployment, should be resolved before you start the upgrade.  
  
### Do not exceed the maximum number of fields  
 If you have more than 1023 fields defined for an entity, you must delete the additional fields before you run the upgrade, or the upgrade will fail with the following message:  
  
 CREATE VIEW failed because column *'column_name'* in view *'view_name'* exceeds the maximum of 1024 columns.  
  
### Remove custom database objects  
 The [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] databases often change from one major release to the next because of database redesign.  
  
 We suggest that, if you have added custom database objects such as triggers, statistics, stored procedures, and certain indexes, you remove those objects from the configuration and organization databases. In many cases, [!INCLUDE[pn_Setup](../includes/pn-setup.md)] displays a warning when these objects are detected.  
  
### Remove the ignorechecks registry subkey  
 If you have manually added the ignorechecks registry subkey on the existing [!INCLUDE [pn-dyn-365](../includes/pn-dyn-365.md)] server, remove it before you start the upgrade. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [You cannot deploy Dynamics 365 Customer Engagement (on-premises) by using an account that does not have local administrator permissions on Microsoft SQL Server](https://support.microsoft.com/kb/974584)  
  
<!--  
## Next steps  
 Read more about upgrade in the following topics:  
  
-   [Before you upgrade: issues and considerations](before-you-upgrade-issues-and-considerations.md)  
-   [Upgrade the Microsoft Dynamics 365 Server](upgrade-the-microsoft-dynamics-deployment.md)  
-   [Upgrade Microsoft Dynamics CRM for Outlook](../outlook-addin/admin-guide/upgrade.md)  -->
  
## See Also  
[Import an organization](import-an-organization.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]