---
title: "Migrate settings from the Email Router to server-side synchronization  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 8b1637ff-34c6-489d-ad1c-4f3c8159ae91
caps.latest.revision: 22
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Migrate settings from the Email Router to server-side synchronization 

> [!NOTE]
> The Microsoft Dynamics CRM Email Router has been deprecated. We strongly recommend that you migrate all email routing functionality to use the server-side synchronization feature. 

Server-side synchronization is a method in Dynamics 365 Customer Engagement (on-premises) that you can use to set up email and synchronize your appointments, contacts, and tasks. With server-side synchronization, you can centrally manage mailboxes and profiles, and also track errors about email processing. If your organization is currently using the Email Router, but wants to start using server-side synchronization instead, you can easily migrate the configuration settings from the Email Router to server-side synchronization to set up email.  
  
> [!NOTE]
>  An organization can only use either the Email Router or server-side synchronization to process email. You can define what to use in the **Email** tab of System Settings in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. If you select server-side synchronization, the Email Router stops functioning for the organization.  
> 
>  To switch from [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] synchronization to server-side synchronization, simply change the synchronization method in mailbox records to server-side synchronization. That’s all you have to do to make the change from [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronization to server-side synchronization.  

  
 During migration, the old incoming and outgoing profiles for the user and queue mailboxes are merged to create a new email server profile that will be used by server-side synchronization.  
  
1. [!INCLUDE[proc_settings_email_config](../includes/proc-settings-email-config.md)]  
  
2. Choose **Migrate Email Router Data**.  
  
3. In the Email Router Data Migration wizard, in the three text boxes, choose **Browse**, and select the three files specified at the top of the page in the same order. If you must migrate data from multiple email routers, choose **More Email Routers** and again select the three files. You can migrate data from up to four email routers at once.  
  
   > [!NOTE]
   >  The maximum combined size of all the files from all the email routers that you can upload at a time is 32 MB.  
  
4. Choose **Next**.  
  
5. On the **Select Email Server Profiles to Migrate** page, the incoming and outgoing email server profiles of the Email Router are listed and the details about the new email server profile for server-side synchronization is also listed. If you want to migrate the profile, in **Migrate Server Profile**, choose **Yes**.  
  
    In the Email Router, incoming and outgoing email server profiles are different and each user or queue is associated with both incoming and outgoing profiles. However, with server-side synchronization, the incoming and outgoing settings are defined in a single profile and a user or queue is associated with this profile. Thus, when you migrate the data, the data from two server profiles is combined into one. The **Select Email Server Profiles to Migrate** page shows details about the new email server profile that will be created.  
  
6. Choose **Next**.  
  
7. The **Migration Review Summary** page shows what data will be migrated. Choose **Start**.  
  
   After the migration is complete, you’ll see the summary of the migrated data. You must test the email configuration for the mailboxes after the migration is complete. To be able to start email processing through server-side synchronization, in the **Process Email From** field in the **System Settings** dialog box, select **Server-Side Synchronization**.  
  
## Best practices  
 Here are some recommendations for migrating from Email Router to server-side synchronization.  
  
1.  Check to make sure the synchronization filters do not pick up data which is older than two weeks.  These are the default settings, so unless you’ve changed something, you won't need  to reconfigure them. See [Server-side synchronization](../admin/server-side-synchronization.md).  
  
2.  In the email server profile (**Settings** > **Email Configuration** > **Email Server Profiles**), verify that the migration tool sets the **Process Email From** field to 24 hours.  
  
3.  Test and enable no more than 200 mailboxes at a time and every 5 hours, in order to allow the mapping table to rebuild.  
  
4.  Start with the queues mailboxes, and then migrate the users’ mailboxes.  
  
### See also  
 [Monitor email processing errors](../admin/monitor-email-processing-errors.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]