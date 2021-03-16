---
title: "Import an organization | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: c4a9106e-26e2-482d-acd7-2f66b722efee
caps.latest.revision: 16
author: Mattp123
ms.author: matp
manager: kvivek
---
# Import an organization



You can import an existing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization with the Import Organization Wizard. You can use this wizard when you move [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] to another computer. Use the Import Organization Wizard to import an organization from any domain in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service forest.  
  
> [!IMPORTANT]
>  -   Before you import, upgrade, or update a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization, you should back up the configuration and organization databases.  
> -   You cannot import a database that is already deployed in the target [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
> -   If the Import Organization Wizard detects that the organization you are importing is from an earlier version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], the organization database will be upgraded to the new version.  
> -   We recommend that for each organization you upgrade, the volume has free space that is at least three times the size of the organization database file and four times the size of the log file. That way, if a single organization database and log file are located on the same volume and are 1 gigabyte in total, you should have at least 7 gigabytes of available disk space before you perform the upgrade.  
> -   Before you can import an organization with the Import Organization Wizard, the organization database must be restored and attached to [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].   
> -   The encryption key is required to activate data encryption when you import an organization database into a new deployment; a deployment that has had the configuration database (MSCRM_CONFIG) re-created after the organization was encrypted; or a restore from an earlier backup that doesn’t contain the encryption key. You can copy the original encryption key to Notepad and paste it into the Settings > Data Management > Data Encryption dialog after the organization import is completed. When you activate data encryption after redeployment, we recommend you use [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to paste the encryption key into the Data Encryption dialog box. For more information about data encryption, see [Enhance security by encrypting your data](../admin/data-encryption.md).  
  
> [!TIP]
>  The procedure described here can be implemented by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the Import-CrmOrganization command in the [Microsoft Dynamics 365 Customer Engagement (on-premises) PowerShell Reference](/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps).  
  
#### Import an organization  
  
1.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, right-click **Organizations**, and then select **Import Organization** to open the Import Organization Wizard.  
  
2.  On the **Select SQL Server** page, in the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] box, type or select the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization database is located.  
  
3.  In the **Organization database** list, select the organization that you want to import.  
  
4.  Select **Next**.  
  
5.  On the **Specify the Organization Settings** page, accept the default **Display Name** for the imported organization or type a new **Display Name**.  
  
6.  Accept the default **Unique Database Name** for the imported organization or type a new **Unique Database Name**.  
  
7.  Select **Next**.  
  
8.  On the **Specify Reporting Services Server** page, accept the default entry or type the URL for the Microsoft SQL Report Server to be used by the organization you import.  
  
9. On the **Select Method for Mapping Users** page, select one of the following options:  
    -   **Automatically Map Users**. This selection automatically maps the users' [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] account names to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] accounts.  
  
         Users in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain are verified against the current domain user information. If the organization being imported has users added with their User Principal Name (UPN), the user information will be mapped across without any changes or validation.  
  
    -   **Select Custom Mapping Options**. This selection lets you specify custom user account matching options.  
  
10. Select **Next**.  
  
11. If you selected **Select Custom Mapping Options**, you’ll see custom user mapping options. Select from the following options:  
  
    -   **Keep existing user mappings**. Select this option to keep the existing user mappings in the organization database. Typically, you select this option if you are importing an organization database that is located in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] where the organization is to be imported.  
  
         For users external to the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain, who were added with their UPN, the user information will be mapped across without any changes or validation.  
  
    -   **Manually map users**. Select this option to manually map each user, typing each user's ID into the mapping table.  
  
    -   **Generate a new mapping file**. Select this option to create a sample XML mapping file. Then, you can exit the Import Organization Wizard, change the user mapping file to select how users are imported, and run the Import Organization Wizard again. The default behavior is to create the user mapping file in the folder \<*drive*>:\Program Files\Microsoft Dynamics CRM\Tools.  
  
    -   **Auto-map users**. Select this option to automatically map the user settings by selecting from the following options:  
  
        -   **[!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] account name**. Select this option to use the user logon name that is set in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. Users in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain are verified against the current domain user information.  
  
        -   **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] full name to [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] full name**. Select this option to use the display or full name that is set in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
        -   **Prefix**. Select this option to create a prefix, with an appended numeric value, for each user.  
  
        -   **Use existing mapping file**. Select this option if you have created a mapping file to import users. Then, type the full path and file name in the box provided, or select **Browse** to find and select the user mapping file.  
  
            > [!NOTE]
            >  In all the Auto-map methods, users entered with their UPNs are mapped across without any changes.  
  
12. Select **Next** to open the **System Requirements** page.  
  
     This page shows a summary of all system requirements to create a new organization. Failed tests must be corrected before a new organization can be created. If necessary, cancel the Import Organization Wizard, fix the problem, resolve all errors, and then start the Import Organization Wizard again.  
  
13. If no errors, or only warnings, appear, select **Next**.  
  
14. On the **Ready to Import** page, select **Import**.  
  
15. On the **Import Organization** page, select **Finish**.  
  
## See also  
 [Manage organizations](manage-organizations.md)   </br>
 [Troubleshoot organization import and upgrade issues](troubleshoot-organization-import-and-upgrade-issues.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]