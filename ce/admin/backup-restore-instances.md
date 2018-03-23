---
title: "Backup and restore instances of Dynamics 365 (online) | MicrosoftDocs"
ms.custom: ""
ms.date: 02/26/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 82d04aae-5557-44da-9658-d1cf1b1c4825
caps.latest.revision: 4
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Backup and restore instances

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Protecting your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data and providing continuous availability of service is important for you and for us. You have multiple options for backing up and restoring your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances.   
  
<a name="BKMK_DailySystemBackup"></a>  
 
## Daily system backups  
 Good news! Some backups take place without you having to do anything.  
  
 About [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] **system backups**:  
  
-   All your instances are backed up.  
  
-   System backups occur daily.  
  
-   System backups are retained up to three days. Check your expiration date.  

  ![Expires On column that shows the expiration dates for backups](media/Expires66.png "Expires On column that shows the expiration dates for backups")

-   System backups do not count against your storage limits.  
  
-   System backups are identified as created by **System** on the **Manage backups** page.  
  
 ![Backup & Restore tab in the Dynamics 365 Administration Center](../admin/media/backup-and-restore-tab.png "Backup & Restore tab in the Dynamics 365 Administration Center")  
  
### See your system backups  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup & Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
 System-created backups appear under **Created By** as **System**.  
  
 ![System-created backups appear under Created By as System.](../admin/media/backup-system-restore-point.png "System-created backups appear under Created By as System.")  
  
<a name="BKMK_ODBCRMManaged"></a>   

## On-demand backup: Dynamics 365 managed  
 Automated system backups are great, but you will want to be able to make your own backups before making some significant customization change or applying a version update. You can do this with on-demand [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] managed  backups.  
  
> [!NOTE]
>  A backup is created for you when we update your instance.  
  
 About [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] managed **on-demand backups**:  
  
-   You can back up Production and Sandbox instances.  
  
- **You can only restore to a Sandbox instance**. To restore to a Production instance, first switch it to a Sandbox instance. See [Switch an instance](../admin/switch-instance.md).  
  
-   Only [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] or later versions are supported for backup.  <!-- At present, you cannot create on-demand backups for [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)]. -->
  
-   On-demand backups are retained for up to three days. Check your expiration date.  
  
 ![On-demand backup expiration date](../admin/media/on-demand-backup-expiration-date.png "On-demand backup expiration date")  
  
-   You are not limited in the number of on-demand backups you can make.

-   On-demand backups do not count against your storage limits.  

-   On-demand backups are identified by having a label you created and by the presence of **Edit** &#124; **Delete** &#124; **Restore** in the details section. System backups have only **Restore**.  
  
 ![Edit, Delete, and Restore buttons for Dynamics 365 on-demand backups.](../admin/media/managed-backup.png "Edit, Delete, and Restore buttons for Dynamics 365 on-demand backups.")  
  
<a name="BKMK_CreateCRMBackup"></a>   

### Create an on-demand backup of a Dynamics 365 instance  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup & Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
5.  Click **New backup**.  
  
 ![New backup button](../admin/media/new-backup-button.png "New backup button")  
  
6.  Type a label and any notes to help identify this backup for future restoration.  
  
7.  Click **Create**.  
  
 ![Form for creating a new Dynamics 365 (online) backup.](../admin/media/online-backup.png "Form for creating a new Dynamics 365 (online) backup.")  
  
 A notification will be displayed to confirm the backup is being created.  The status column in the list provides the status of the backup.  
  
> [!NOTE]
>  The instance remains available while being backed up.  
  
<a name="BKMK_EditBackups"></a>   

### Edit a Dynamics 365 on-demand backup  
 Edit a backup to change its label and your notes about the backup.  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup and Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
5.  Choose an on-demand backup from the list of backups.  
  
6.  Click **Edit**.  
  
 ![Edit backup button](../admin/media/edit-backup-button.png "Edit backup button")  
  
7.  Change the information as needed, and then click **Save**.  
  
<a name="BKMK_RestoreBackups"></a>   

### Restore a Dynamics 365 on-demand backup  
 You can only restore to Sandbox instances. To restore to a Production instance, first switch it to a Sandbox instance, restore to it, and then switch it back to a Production instance. See [Switch an instance](../admin/switch-instance.md).  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup and Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
5.  Choose an on demand backup from the list of backups.  
  
6.  Click **Restore**.  
  
 ![Restore button](../admin/media/restore-button.png "Restore button")  
  
7.  Click **Select target**  to pick a target instance.  
  
8.  Click **Next**. Verify the details, and then click **Restore**.  
  
 ![Restore an on-demand backup page](../admin/media/restore-backup-page.png "Restore an on-demand backup page")  
  
 A notification will be displayed confirming that the backup is being restored.  It can take some time for the restoration to complete.  
  
> [!NOTE]
>  The instance remains unavailable while being restored.  
  
<a name="BKMK_DeleteCRMBackup"></a>   

### Delete a Dynamics 365 on-demand backup  
 You can use the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)] to delete [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]-managed, on-demand backups.  You can't delete system backups.  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup & Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
5.  Choose an on-demand backup from the list of backups.  
  
6.  Click **Delete**.  
  
 ![Delete backup button](../admin/media/delete-backup-button.png "Delete backup button")  
  
7.  Click **Confirm**.  
 
<!-- 
<a name="BKMK_ODBAzureManaged"></a>   

## On-demand backup: Azure managed  
 Using [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] to store and manage your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] backup provides some benefits you should consider.  
  
 About [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] managed on demand backups:  
  
-   You must have an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] account to use [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage.  
  
    > [!TIP]
    >  If you don't have an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage account and need to create one, see [About Azure storage accounts](https://docs.microsoft.com/azure/storage/storage-create-storage-account).  
  
-   You can create multiple [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] backups for each instance.  
  
-   You can back up Production and Sandbox instances.  
  
- **You can only restore to a Sandbox instance**. To restore to a Production instance, first switch it to a Sandbox instance. See [Switch an instance](../admin/switch-instance.md).  
  
- [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] backups do not count against your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] storage limit.  
  
- [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] backups are retained until you delete them.  
  
    > [!IMPORTANT]
    >  We support restoring [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] backups that are supported online and not more than three years old.  
  
- [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] backups are identified as **Azure Storage** in the details section.  
  
 ![How to identify Azure storage.](../admin/media/on-demand-azure-backup-identification.png "How to identify Azure storage.")  
  
<a name="BKMK_CreateAzureBackupConfigStorage"></a>   

### Create an Azure on-demand backup  
 Follow these steps to configure [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage and do a backup.  
  
> [!TIP]
>  If you don't have an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage account and need to create one, see [About Azure storage accounts](https://docs.microsoft.com/azure/storage/storage-create-storage-account).  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator or Delegated Admin security roles.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Backup & Restore** tab.  
  
4.  Choose an instance from the **Backups for** drop-down list.  
  
5.  If you've already configured Azure storage, you can skip to step 9.  
  
6.  Click **Configure Azure Storage**.  
  
 ![Click Configure Azure storage](../admin/media/click-configure-azure-storage.png "Click Configure Azure storage")  
  
7.  Enter the following settings from your [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage account.  
  
    |Settings|Example|  
    |--------------|-------------|  
    |Storage account name|myazureaccount|  
    |Secondary access key|XrmGWqu############V5Bc0nFIGjGWiWhHTdMxkA5Mb4WjJ0rDV+3USWW/6fAWCrszrkr############q4nw==|  
    |Container name|myazurecontainer|  
  
     For guidance on how to get these settings, see [Get the information you need from your Azure storage account](#BKMK_GetAzureInfo) further down in this topic.  
  
8.  Click **Validate**, and then click **Configure**.  
  
 ![Configure Azure storage.](../admin/media/configure-azure-storage.png "Configure Azure storage.")  
  
9. Click **New Backup**.  
  
10. Type a label and any notes to help identify this backup for future restoration.  
  
 ![Enter backup settings.](../admin/media/on-demand-backup-enter-settings.png "Enter backup settings.")  
  
11. Verify that **Azure Storage** is selected as the storage type, and then click **Create**.  
  
<a name="BKMK_GetAzureInfo"></a>   

### Get the information you need from your Azure storage account  
 To use [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage for your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance backups, you need to set up a connection between [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Here's how you get the settings from [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] to make the connection. You'll enter these settings in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)] when you configure [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage.  
  
1.  Sign in to the [Azure portal](https://portal.azure.com/).  
  
2.  Click **More services** > **Storage accounts**, and choose your storage account. Make note of the storage account name. This is used for the first field in **Configure Azure storage**.  
  
 ![Note the Azure storage account name.](../admin/media/azure-storage-account-name-dialog.png "Note the Azure storage account name.")  
  
3.  Click Access keys, and then for **key 2** click **Copy**. Paste this into the second field in **Configure Azure storage**.  
  
 ![Copy the Azure storage access key.](../admin/media/azure-storage-access-key.png "Copy the Azure storage access key.")  
  
4.  Scroll down and click **Containers**. Make note of the storage container name. This is used for the third field in **Configure Azure storage**.  
  
 ![Note the Azure storage container name.](../admin/media/azure-storage-container-name.png "Note the Azure storage container name.")  
  
<a name="BKMK_EditRestoreDeleteAzurebackup"></a>   

### Edit, Restore, or Delete an Azure on-demand backup  
 The process for editing, restoring, or deleting an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] on-demand backup is mostly the same process as  for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] on-demand backup.  See the related [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] sections above.  
  
 Note the following:  
  
-   When you delete an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] on-demand backup, the backup is not removed from [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] storage. Use the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] portal to remove the backup.  
  
-->
### See also  
 [Switch an instance](../admin/switch-instance.md)   
