---
title: "Track Outlook email by moving it to a tracked Exchange folder | MicrosoftDocs"
ms.custom:
ms.date: 01/11/2016
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
  - Dynamics 365 apps (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: 2a46ffd4-9f2c-438e-a5c6-61e86d885949
caps.latest.revision: 38
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
# Track Outlook email by moving it to a tracked Exchange folder


## How to
 Track customer interactions wherever you are, and from virtually any device by using folder tracking. After you set up a tracked folder, you can drag or move email to that folder to track it automatically in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. Additionally, if you set a regarding record (such as a specific account or opportunity record) for the folder, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] automatically links all email in that folder to that specific record. Tracked folders work in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], [!INCLUDE[pn_Exchange_Online](../../includes/pn-exchange-online.md)], [!INCLUDE[pn_outlook_web_app](../../includes/pn-outlook-web-app.md)], or any other mobile app that supports [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)].

 ![Exchange email folder tracking in Dynamics 365 apps](../media/exchange-folder-tracking-dynamics-crm.png "Exchange email folder tracking in Dynamics 365 apps")  

> [!TIP]
>  Tracked folders work with [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] Inbox rules. This makes it easy to automatically route email messages to a particular folder. For example, set up an [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] rule that automatically routes email from a Contoso contact to a tracked Contoso folder, which is linked to a specific Contoso opportunity. [Tell me more about setting up rules](https://go.microsoft.com/fwlink/p/?LinkID=528086).

<a name="Requirements"></a>
### Requirements for using tracked folders

- [!INCLUDE[cc_feature_included_with_2015_update_1](../../includes/cc-feature-included-with-2015-update-1.md)]

- The tracking folders feature must also be enabled by your administrator. For more information, contact your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] administrator. For admin information on enabling tracked folders, see [Configure Outlook or Exchange folder-level tracking](/power-platform/admin/configure-outlook-exchange-folder-level-tracking)

- Your organization must use server-side synchronization as your email synchronization method. If you don’t know which synchronization method your organization uses, contact your Dynamics 365 apps administrator. For admin information about setting up server-side synchronization, see [Set up server-side synchronization of email, appointments, contacts, and tasks](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks) 

<a name="Setup"></a>
### Set up a tracked folder

1. Go to **Options**:

   - In the web app: On the nav bar, click **Options** ![Options button for Dynamics 365 apps](../media/optionsbutton.png "Options button for Dynamics 365 apps").  

   - In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]: Click **File** > **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** > **Options**.

2. In the **Set Personal Options** dialog box, click the **Email** tab, and then under **Select the email messages to track in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]**, click **Configure Folder Tracking Rules**.

3. In the **Folder-Level Tracking** dialog box, under **Exchange Folder**, click **+ New Folder Mapping**, click the down arrow in the box that appears, and then select the folder you want to track.

    ![Folder Tracking Rules dialog box in Dynamics 365 apps](../media/outlook-folder-tracking.png "Folder Tracking Rules dialog box in Dynamics 365 apps")  

   > [!NOTE]
   >  You can only track folders or subfolders inside your Exchange Inbox. Only the folder you select will be tracked. For example, if you select a folder that includes subfolders, the subfolders aren’t tracked unless you specifically select them in this dialog box. The maximum number of folders you can track is 25.

4. If you want to link the folder to a specific record—for example, an account or opportunity—under **Regarding Record in Dynamics 365 apps**, click the **Lookup** button ![Lookup button graphic](../media/lookup-button-dynamics-crm.png "Lookup button graphic"), and then search for the record.  

5. Repeat steps 3 and 4 for any additional folders you want to track and (optionally) link to regarding records.

6. When you’re done adding and linking folders, click **Save**.

<a name="BestPractices"></a>
### Best practices for folder tracking

- Make sure to take advantage of folder tracking on your mobile devices. If your device supports [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] email, folder tracking will work automatically. You don’t need to install anything. Just drag or move email to a tracked folder to automatically track that email in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].

- Whether you set a regarding record for a folder or not depends on how you plan to use the folder:

  - If you receive a small volume of email from many different customers, you may want to create a single folder called “Track in Dynamics 365 apps” (or similar name) that isn’t linked to a particular record. That way, you can drag messages to that folder to track them automatically. If you later want to link an email message in that folder to a specific [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] record, open that activity record in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], and then fill in the Regarding field.  

  - If you receive large volumes of email from a particular customer, create a folder (or use an existing folder) just for that customer and link it to a specific record. For example, create a Contoso folder and set the regarding record to a Contoso account record or opportunity record.

- You can set up multiple folders that link to the same regarding record. For example, you could link a Contoso Sales Proposal folder and a Contoso Legal Matters folder to the same Contoso account record.

- It’s best not to use the same folder for different records over a period of time. For example, let’s say you’re tracking email communications for an opportunity with Customer 1, but you’ve won the opportunity, and now you don’t need to track further communications with that customer. You may be tempted to simply change the regarding record for that folder to a new customer (Customer 2) you’re working with. If you do that, however, all email in that folder, including the email pertaining to Customer 1, will be associated with Customer 2. So it’s best in this case to create a new folder associated with Customer 2, and then set the regarding record for that new folder to Customer 2. Then you can delete the regarding record for the Customer 1 folder.

- You can include an untracked folder inside a tracked folder. For example, let’s say you want to store personal email from a Contoso contact. You can create a Personal subfolder under the Contoso folder and leave it untracked.

- If you no longer need to track a folder, it’s a good idea to untrack it for performance reasons. To untrack a folder, remove it from the **Folder-Level Tracking** dialog box.

<a name="WhatHappens"></a>
### What happens when you untrack, move, delete, or rename folders, or change the regarding record?
 The following table shows what happens when untrack, move, or delete folders, or change the regarding record linked to a tracked folder.


|                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|-------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                                   **Action**                                                                    |                                                                                                                                                                                                                                                                                                                                 **Result**                                                                                                                                                                                                                                                                                                                                 |
|                                  Untrack a folder by deleting it from the **Folder-Level Tracking** dialog box                                  |                                                                                                                                                                                                                              All email messages previously included in that folder will still be tracked, and the regarding record will still be linked to those email messages. New email messages you add to that folder won’t be tracked.                                                                                                                                                                                                                               |
| Delete a folder from [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] |                                                                                                                                                                                                                                  All email messages included in that folder will be deleted from Outlook or Exchange Online. Email messages already tracked through that folder will not be deleted from Microsoft Dynamics 365 apps, however.                                                                                                                                                                                                                                  |
|   Move a folder in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)]   |                                                                                                                                                                                                                                                            The folder and all its contents will continue to be tracked. If you move a folder outside your Inbox, folder-level tracking rules will be disabled.                                                                                                                                                                                                                                                             |
|  Rename a folder in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)]  |                                           The folder and all its contents will continue to be tracked. **Tip:**  When you rename folders, the software uses the [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] folder ID for tracking purposes – it’s not dependent on the actual name of the folder. This is important to know if you delete a folder, and then rename a new folder with the same name as the deleted folder. For example, let’s say you delete Folder 1, create Folder 2, and then rename Folder 2 to be Folder 1. The tracking information for the original Folder 1 won’t be retained in this case.                                            |
|         Remove the link between a tracked folder and a specific record by deleting the link in the **Folder-Level Tracking** dialog box         |                                                                                                                                                                                                                                                                   All messages in that folder that were previously linked will continue to be linked. New messages added to that folder won’t be linked.                                                                                                                                                                                                                                                                   |
|                       Move an email message in a tracked folder that’s linked to a specific record to a different folder                        |                                                                                                                                                                                                                        If the new folder doesn’t have a regarding record, the email message will continue to be linked to the original record. If the new folder has a regarding record, the email message will be linked to that regarding record.                                                                                                                                                                                                                        |
|        Manually change the regarding record for an email message that’s linked to a different regarding record through a tracked folder         | The tracked folder rule takes precedence. When the folder is synchronized, the email message will be re-linked to the record specified in the folder tracking rule, even if you change the regarding record manually. To change the regarding record in this case, do one of the following:<br /><br /> -   Move the message to a tracked folder linked to the record you want.<br />-   Remove the  link to the regarding record  in the **Folder-Level Tracking** dialog box before you manually change the regarding record.<br />-   Move the specific email message outside the tracked folder, and then manually change the regarding record for that email message. |
|                         Two users move the same email message to separate folders that have different regarding records                         |                                                                                                                                                                                                                                                               You can only set one regarding record for an email message. In this case, the record that’s processed first is linked to the regarding record.                                                                                                                                                                                                                                                               |

## Watch this video
 Want to see folder tracking in action? [This demo](https://www.youtube.com/embed/HiNpINvFKq8) puts it all together for you.

### Video transcript
 A big part of working in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] is creating and recording different types of activities that revolve around a sales or service process, such as sending emails, creating opportunities, and assigning tasks. If you want to associate an activity with a more specific record and opportunity for example, you can set the regarding record for that activity.

 By using folder-level tracking, you can easily track and set the regarding record for an email by dragging or moving it into an [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] folder.

 Let's take a look at a scenario with folder-level tracking.

 Nancy, a dedicated sales rep, finds and qualifies leads. Nancy has just started to work on a new opportunity called Northwind Traders. She wants to track and associate all the emails that relate to this opportunity.

 First, Nancy needs to create a folder in [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)]. She already has folders for her current accounts and opportunities, so she simply creates a new folder under the Opportunities folder. Then she needs to map the [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] folder she has just created to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].

 Nancy clicks **Options**, and clicks the **Email** tab. She clicks **Configure** and creates a new mapping between the [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] folder and the requested [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] record ‒ Northwind Traders in our example. Now, whenever Nancy gets an email that relates to Northwind Traders, she can simply drag and drop the email into the folder she created.

 The new email will be associated to the Northwind Traders opportunity within [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. Also, Nancy can track emails while she's on the go by using her mobile device. She can simply move the email to the Northwind Traders folder using her native email application.

 Finally, since Morgan is the main contact person in Northwind Traders, all the emails from him relate to this opportunity. Instead of manually copying the emails from Morgan, Nancy can create an [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] rule that will automatically copy all the emails that Morgan sends to the Northwind Traders' folder.

 By doing so, the emails will be automatically tracked in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and will be associated to the Northwind Traders opportunity.

 Folder-level tracking allows you to easily track and associate emails to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], manually from any device, or automatically by setting [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] rules.

### See also  
 [Track Outlook email by choosing a button in Dynamics 365 for Outlook](track-outlook-email-by-choosing-button.md)   
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)   
 [Configure Outlook or Exchange folder-level tracking](/power-platform/admin/configure-outlook-exchange-folder-level-tracking)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]