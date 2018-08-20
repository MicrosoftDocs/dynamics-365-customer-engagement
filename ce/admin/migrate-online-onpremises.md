---
title: "Migrate Microsoft Dynamics 365 (online) to Microsoft Dynamics 365 (on-premises) | MicrosoftDocs"
description: "Follow theses steps to migrate from Microsoft Dynamics 365 (online) to Microsoft Dynamics 365 (on-premises)."
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "Mattp123"
ms.assetid: e7e8ea24-0872-42e6-bec3-bcf362a26450
caps.latest.revision: 15
ms.author: "matp"
manager: "kvivek"
---
# Migrate Microsoft Dynamics 365 (online) to Microsoft Dynamics 365 (on-premises)

[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

This document describes the steps needed to migrate from an instance of [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] to a [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises deployment. To complete the migration, follow the steps provided here in the order presented..  
  
> [!IMPORTANT]
>  This document assumes that you already have a deployment of [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises. For information about how to deploy [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)], see [Microsoft Dynamics CRM Server installation](https://technet.microsoft.com/library/hh699742.aspx).  
>   
>  To migrate from [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] to [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)], you must have [!INCLUDE[pn_crm_2015](../includes/pn_crm_2015.md)] or a later version.  
  
<a name="BKMK_feat_and_cust"></a>   

## Feature and customization changes when you migrate from Microsoft Dynamics CRM Online 2016 Update to Microsoft Dynamics CRM 2016 on-premises  
 Before you migrate from [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] to [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises, be aware of the following behaviors or issues. These characteristics will appear after you import a [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] organization into a [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises deployment.  
  
### Managed solutions  
 All managed solutions that have a dependency on a feature introduced in [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] will be removed from the organization that is prepared for migration. For example, this applies if the solution includes one or more of the following features:  
  
-   A rollup field that uses the AVG operator or aggregates data across all activities related to a record.  
  
-   A calculated field that computes the difference between two dates by using DIFFINDAYS, DIFFINHOURS, DIFFINMINUTES, DIFFINMONTHS, DIFFINWEEKS, or DIFFINYEARS.  
  
 Additionally, you can’t export record creation or update rules from [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] to [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises. [!INCLUDE[proc_more_information](../includes/proc_more_information.md)][Help & Training: Set up rules to automatically create or update records in Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkID=533523)  
  
### Unmanaged solutions  
 Any field in an unmanaged solution that includes a feature introduced in [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] will be removed from the organization. For example, this applies if the field includes one of the following features:  
  
-   A rollup field that uses the AVG operator or aggregates data across all activities related to a record.  
  
-   A calculated field that computes the difference between two dates by using DIFFINDAYS, DIFFINHOURS, DIFFINMINUTES, DIFFINMONTHS, DIFFINWEEKS, or DIFFINYEARS.  
  
 Additionally, these behaviors appear:  
  
-   You can’t export record creation or update rules from [!INCLUDE[pn_crm_online_2016_update](../includes/pn_crm_online_2016_update.md)] to [!INCLUDE[pn_crm_2016](../includes/pn_crm_2016.md)] on-premises. [!INCLUDE[proc_more_information](../includes/proc_more_information.md)][Help & Training: Set up rules to automatically create or update records in Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkID=533523)  
  
-   Records with date and time fields having values earlier than January 1, 1900 are considered invalid and will return an error message, such as “Invalid Date/Time The date/time format is not valid, or the value is outside the supported range.” When this issue occurs you can’t open forms, view lists, or process workflows from an entity record that has a date and time value that’s before January 1, 1900.  
  
<a name="BKMK_copykey"></a>   

## Copy your Dynamics 365 (online) organization encryption key  
 During the import of the [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] database into your [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] deployment, you must provide the organization database encryption key used for your instance of [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)].  
  
1.  Sign in to the instance of [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] that you want to migrate as a user with the system administrator security role.  
  
2.  Go to Settings > Data Management.  
  
3.  Choose **Data Encryption**.  
  
4.  In the Data Encryption dialog box, select **Show Encryption Key**, in the **Current encryption key** box select the encryption key, and copy it to the clipboard.  
  
5.  Paste the encryption key in to a text editor, such as Notepad.  
  
    > [!WARNING]
    >  By default, [!INCLUDE[pn_microsoftcrm](../includes/pn_microsoftcrm.md)] generates a passphrase that is a random collection of Unicode characters. Therefore, you must save the system-generated passphrase by using an application and file that supports Unicode characters. Some text editors, such as Notepad use ANSI coding by default. Before you save the passphrase using Notepad, select **Save As**, and then in the **Encoding** list, select **Unicode**.  
  
6.  As a best practice, save the file that contains the encryption key on a computer in a secure location on an encrypted hard drive.  
  
<a name="BKMK_requestBU"></a>   

## Request a backup of your organization database  
 To request a backup of your [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] database contact [!INCLUDE[pn_ms_Customer_Support_Services](../includes/pn_ms_Customer_Support_Services.md)] for [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)]. For contact information, see [Contact Technical Support](http://go.microsoft.com/fwlink/p/?LinkID=526506).  
  
<a name="BKMK_restoreBU"></a>   

## Restore the Microsoft Dynamics 365 (online) database  
 The backup of your [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] database must be restored by using a server running the same or a later version of [!INCLUDE[pn_MS_SQL_Server](../includes/pn_MS_SQL_Server.md)] as the database you receive.  You will be able to request the version you need before you receive the database.  
  
 Restore the copy of the [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] database to a computer running [!INCLUDE[pn_SQL_Server_short](../includes/pn_SQL_Server_short.md)] in the target [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] deployment. To do this, follow the steps here.  
  
> [!IMPORTANT]
>  Your [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] database may be encrypted with a certificate. For more information, see  [“Cannot find server certificate with thumbprint” error message when you try to restore a Dynamics 365 organization database](#BKMK_cert) later in this topic.  
  
#### Restore a Microsoft Dynamics 365 (online) organization database to SQL Server  
  
1.  Open [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn_ms_SQL_Management_Studio_long.md)], and then connect to the appropriate instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn_SQL_Server_short.md)].  
  
2.  In Object Explorer, right-click **Databases**, and then click **Restore Database**.  
  
3.  Type the name of a new database in the **To database** open text box.  The database name must include _MSCRM in the name. For example the database name is Contoso_MSCRM.  
  
4.  On the **General** page, in the **Source** section, click **Device**.  
  
5.  Click the browse button in the **Device** option. This opens the **Select backup devices** window.  
  
6.  In the **Select backup devices** window, click **Add** to open the **Locate Backup File** window.  
  
7.  Select the file you want to use for the restore operation, and then click **OK**.  
  
8.  Click **OK** to close the **Select backup device** window.  
  
9. Mark the checkbox in the **Restore column next to the backup set** option.  
  
10. Click **OK** to begin the restore process.  
  
<a name="BKMK_applyUpdates"></a>   

## Apply the latest updates to the Dynamics 365 on-premises deployment  
 You must apply the latest [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] updates before you import the Dynamics 365 (online) database. [!INCLUDE[proc_more_information](../includes/proc_more_information.md)][Microsoft Dynamics CRM 2016 Updates and Hotfixes](https://support.microsoft.com/kb/3142345)  
  
<a name="BKMK_importDB"></a>   

## Import the Dynamics 365 (online) database into the Dynamics 365 on-premises deployment  
 How long it takes to complete the import of the organization database depends on several factors. These factors include the size of the database you are importing, the number of users, and the hardware you use to complete the import.  
  
> [!NOTE]
>  The procedure described here uses [!INCLUDE[pn_Deployment_Manager_long](../includes/pn_Deployment_Manager_long.md)]. [!INCLUDE[pn_deploymentmanager](../includes/pn_deploymentmanager.md)] is an MMC snap-in that is included with [!INCLUDE[pn_microsoftcrm_server](../includes/pn_microsoftcrm_server.md)]. Alternatively, your can run [!INCLUDE[pn_PowerShell](../includes/pn_PowerShell.md)] commands to complete the import. [!INCLUDE[proc_more_information](../includes/proc_more_information.md)][Import-CrmOrganization](https://technet.microsoft.com/library/dn833059.aspx)  
>   
>  To import an organization, you must have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn_Deployment_Administrator.md)][!INCLUDE[pn_microsoftcrm](../includes/pn_microsoftcrm.md)] role.  
  
#### Import an organization database using Deployment Manager  
  
1.  On the [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn_ms_Windows_Server_long.md)] running the [!INCLUDE[pn_microsoftcrm_server](../includes/pn_microsoftcrm_server.md)][!INCLUDE[pn_Deployment_Tools](../includes/pn_Deployment_Tools.md)] server role, start **Deployment Manager** (DMSnapin.msc).  
  
2.  Start the [!INCLUDE[pn_Import_Organization_Wizard](../includes/pn_Import_Organization_Wizard.md)]. Right-click **Organizations**, and then click **Import Organization**.  
  
    > [!NOTE]
    >  You will receive a message if you attempt to import into a [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] version that allows only one organization per deployment. The message notifies you that proceeding will deactivate, but not delete, the existing organization.  
  
3.  Select the [!INCLUDE[pn_SQL_Server_short](../includes/pn_SQL_Server_short.md)] and database. In the **Select SQL Server** window, select the [!INCLUDE[pn_MS_SQL_Server](../includes/pn_MS_SQL_Server.md)] where the organization database is restored in the **SQL Server** list, and then select the organization database in the **Organization database** list. Click **Next**.  
  
4.  Specify the organization name. Enter the display name and name for the organization in the **Specify the Organization Settings** window. The **Display name** will appear in [!INCLUDE[pn_microsoftcrm](../includes/pn_microsoftcrm.md)] applications. The **Unique Database name** will be used as the database name in [!INCLUDE[pn_SQL_Server_short](../includes/pn_SQL_Server_short.md)] and will also be used to construct the URL for client applications.  Notice that the values you enter don’t need to match the names that you used with [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)]. Click **Next**.  
  
5.  Specify the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn_SQL_Server_Reporting.md)] server. In the **Specify Reporting Services Server** window, type the [!INCLUDE[pn_reporting_services_short](../includes/pn_reporting_services_short.md)] server URL for the organization in the **Report Server URL** field. Click **Next**.  
  
6.  Select the method for mapping users. Map users from the [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] deployment to the [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] deployment. Users must already exist in Active Directory for the [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)] deployment. The [!INCLUDE[pn_Import_Organization_Wizard](../includes/pn_Import_Organization_Wizard.md)] does not create the users automatically. To complete the mappings, the user running the import operation must be mapped to a user in [!INCLUDE[pn_microsoftcrm](../includes/pn_microsoftcrm.md)]. For more information about how to map users, see [Import an organization](https://technet.microsoft.com/library/dn905200.aspx).  
  
7.  In the System Checks window you receive the results of several environment diagnostic checks. If you receive a red alert, the issue must be resolved prior to completing the wizard. If you receive a yellow warning, you may proceed with the import. Click **Next**.  
  
     Due to versioning differences between [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] and [!INCLUDE[pn_crm_op_edition](../includes/pn_crm_op_edition.md)], you may receive a warning. This warning is expected and in most cases shouldn’t prevent the import from completing.  After you successfully complete the steps in this document, the versioning will be correct.  
  
8.  Begin the import. In the Ready to Import window, verify that the information is correct, and then click **Import**.  
  
9. Complete the import. After the import is complete, the Import Organization window appears.  Click **View** the log file to view the log file that is created during the import. If the import is successful, click **Finish**.  
  
     The import log is stored in the C:\Documents and Settings\\\Application Data\Microsoft\MSCRM\Logs folder.  
  
10. Activate encryption  
  
    1.  As a user with System Administrator security role privileges, sign-in to the organization that was just imported, then go to Settings > Data Management.  
  
    2.  Choose **Data Encryption**.  
  
    3.  In the **Activate Encryption Key** box enter the encryption key that you copied earlier, and then select **Activate**.  
  
    4.  Select **OK** in the confirmation message and then choose **Close** to exit the Data Encryption page.  
  
    5.  We recommend that you copy the key to a safe place.  
  
<a name="BKMK_cert"></a> 
  
## “Cannot find server certificate with thumbprint” error message when you try to restore a Dynamics 365 organization database  
 When you try to restore a [!INCLUDE[pn_microsoftcrm](../includes/pn_microsoftcrm.md)] organization database, you may receive the following error message.  
  
 An exception occurred while executing a Transact-SQL statement or batch. (Microsoft.SqlServer.ConnectionInfo)  
  
 Additional Information: Cannot find server certificate with thumbprint.  
  
 This error message occurs because the database that is to be restored is using Transparent Data Encryption (TDE). A certificate must be present to restore the database.  
  
 To resolve this issue, follow these steps.  
  
1.  Obtain the certificate. [!INCLUDE[pn_CRM_online](../includes/pn_CRM_Online.md)] customers receive the certificate as part of the power of choice backup of your database. Additional instructions may also be included.  
  
2.  Execute the following SQL statements in the order specified to import the certificate where:  
  
    -   CustomerGeneratedStrongPassword is the password you want to use to create the master key.  
  
    -   DomainName, GUID, .cer, .pvk, and Certificate secured password provided are values that are included in the information sent to you from [!INCLUDE[cc_Microsoft](../includes/cc_Microsoft.md)] for importing the TDE certificate.  
  
    ```  
    use master  
    GO  
  
    /* Check if DMK (##MS_DatabaseMasterKey##) exists. */  
    select * from sys.symmetric_keys  
    GO  
  
    /* If key does not exist, create database master key */  
    CREATE MASTER KEY ENCRYPTION BY PASSWORD = '<CustomerGenerated-StrongPassword>'  
    GO  
  
    /* Verify that the database master key is created */  
    select * from sys.symmetric_keys  
    GO  
  
    /* Import the certificate provided for TDE Database backup. TDE certificate name will also be provided in email */   
    CREATE CERTIFICATE LTOP_<DomainName>_<GUID> FROM FILE = 'D:\<>_1.cer' WITH PRIVATE KEY (FILE = 'D:\<>_1.pvk', DECRYPTION BY PASSWORD = '<Certificate secured password provided>')  
  
    ```  
  
3.  Restore the organization database. To do this, see [Restore the Microsoft Dynamics 365 (online) database](#BKMK_restoreBU).  
  
> [!IMPORTANT]
>  We strongly recommend that you store your TDE certificate in a secure location.  If the certificate is lost and the database is encrypted, you will lose your data. For more information about TDE encryption, see [TechNet: Move a TDE Protected Database to Another SQL Server](https://technet.microsoft.com/library/ff773063.aspx).  
  
## See Also  
 [Subscription Management for Dynamics 365 (online)](../Topic/Subscription%20Management%20for%20Dynamics%20365%20\(online\).md)   
 [Add interoperation features to Microsoft Dynamics 365 (online)](../Topic/Add%20interoperation%20features%20to%20Microsoft%20Dynamics%20365%20\(online\).md)
