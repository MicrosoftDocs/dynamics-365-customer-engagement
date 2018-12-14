---
title: "Add a phone call, task, email, or appointment activity to a case or record (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 08/29/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: b72fe4a3-30b8-4dc4-9b93-e87e5cdb7ef0
caps.latest.revision: 39
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Add a phone call, task, email, or appointment activity to a case or record 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The activity and notes area helps you keep track of all the interactions with your customers. Record all important conversations with the customer or the communication with your team members regarding a record in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. Add a phone call, task, notes, email, or appointments right within the case, account, contact, lead, or opportunity records without navigating to a different area and opening another form.  
  
 All activities that you add from within a record appear in the **Activities** area. If the **Regarding** field of an activity is set, the activity appears in the activity wall of the regarding record. You can filter the list to show just the activities that are in progress or the ones that are overdue. Click or tap the inline **Complete** link to close the activity as **Completed**.  
  
 ![Add activities in Dynamics 365 for Customer Engagement](../customer-service/media/add-activities-dynamics-crm.png "Add activities in Dynamics 365 for Customer Engagement")  

> [!NOTE]
> **Change conversation view**
> 
> By default, email in the Activities area are displayed as a conversation with emails grouped according to subject and tracking ID. To change the view so that emails are not grouped:
> 1. Open an entity such as an account.
> 2. On the top menu bar, select **Form**.
> 3. Select the blank field in the **Social Pane**.
> 4. On the top menu bar, select **Change Properties**.
> 5. In Activities Tab Properties, select the **Web Client Properties** tab.
> 6. Select the **Activity Wall** tab.
> 7. Uncheck **Show email in conversation** view and select **Save**.
> <br>
> ![Show email in conversation view](media/show-email-in-conversation-view.png)
  
## Add a phone call  
  
1.  Open the record you want to add the activity to.  
  
2.  If you do not see the **Add Phone Call** area open in the middle of the page, click **Activities** > **Add Phone Call**.  
  
3.  In the Description area, provide a summary of the conversation with the customer. You must fill in this area before you can save the phone call.  
  
     The **Call With** field is automatically populated with the customer name you select in the account or contact field. You can select a different contact, account, lead, or user record if required.  
  
4.  By default, the direction is set to **Outgoing**. You can change it to **Incoming** by clicking or tapping the **Phone Support** button in the list of case records. To select multiple records, click **Look Up More Records**, and then in the **Look Up Records** dialog box, select the records.  
  
5.  Select the **Left voice mail** check box if you make an outgoing call to a customer and leave a voice mail for them. You can also select this check box if a customer leaves a voice mail message when they call you.  
  
6.  Click **OK** to save the activity.  
  
> [!NOTE]
>  By default, every phone call activity that you add in context of a record is marked Completed when the record is saved at least once. If you do not want every phone call activity to be marked Completed by default, you can use the OrgDBOrgSetting MakeSocialPanePhoneCallCompleted and set it to **false**.  [Learn more about OrgDBOrgSettings](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm). 
> 
>  However, if you add a phone call activity to an unsaved record, or if you create a new activity and then set the **Regarding** field of the activity to another entity record, the activity is set to an Open state. You can click the **Complete** link to close the activity as **Completed**. The **Complete** link is available only after you save the case record at least once. 
  
## Add a task  
  
1. Open the record you want to add the activity to.  
  
2. In the middle of the page, click **Activities** > **Add Task**.  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
4. The **Owner** field is set to the current user by default. If you want to reassign the task, click the lookup icon, and then select another user or team.  
  
5. Click **OK** to save the task.  
  
## Add an email  
 To add an email activity to a record, you must first save the record you are adding the activity to.  
  
1. Open the record you want to add the activity to.  
  
2. In the middle of the page, click **Activities** > **More Commands**![More Commands button in Appointment Activity](../customer-service/media/morecommands.gif "More Commands button in Appointment Activity") > **Email**.  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
4. To save the record, click **Save**.  
  
5. To add an attachment to the email, under **Attachments**, on the right, click **+**.  
  
6. To use a template for the email body, in the email editor, click **Insert Template**, and then select the template.  
  
7. To attach an article to the email, in the email editor, click **Insert Article**, and then add the article.  
  
8. Click **Save**.  
  
## Add an appointment  
 To add an appointment activity to a record, you must first save the record you are adding the activity to.  
  
1. Open the record you want to add the activity to.  
  
2. In the middle of the page, click **Activities** > **More Commands**![More Commands button in Appointment Activity](../customer-service/media/morecommands.gif "More Commands button in Appointment Activity") > **Appointment**.  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
4. To save the record, click **Save**.  
  
## Add notes  
 You can also easily add notes in the activities area. And if you’re on the latest version of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], you have the benefits of using OneNote to take or review customer notes from within your Dynamics 365 for Customer Engagement appsapp records. For more information on OneNote, see: [Set up OneNote integration in Dynamics 365 for Customer Engagement](../admin/set-up-onenote-integration-in-dynamics-365.md).  
  
 This doesn’t replace the current Notes feature, but gives you another way to access notes stored in OneNote.  
  
 ![Add notes or OneNote notes in Dynamics 365 for Customer Engagement apps](../customer-service/media/addnotesoronenotenotes.png "Add notes or OneNote notes in Dynamics 365 for Customer Engagement apps")  
  
1.  Open the record you want to add the activity to.  
  
2.  In the middle of the page, click **Notes** or **OneNote**. Then do one of the following:  
  
- In the **Notes** area, start typing your notes.  
  
- In the **OneNote** area, select a notebook to make entries.  
  
  ![Add Meeting Notes in OneNote](../customer-service/media/addonenotenotes.png "Add Meeting Notes in OneNote")  
  
  > [!NOTE]
  >  The notebook is stored in the associated SharePoint folder for the record. If there is more than one associated folder, the notebook is created in the first folder. For more information see, [Set up OneNote integration in Dynamics 365 for Customer Engagement appsapp](../admin/set-up-onenote-integration-in-dynamics-365.md).  
  
## Create an activity and associate it with a customer  
 You can also create an activity from the Activity area and then link it to a customer or support case.  
  
1. Go to your work area.  
  
2. [!INCLUDE[proc_activities](../includes/proc-activities.md)]  
  
3. On the command bar, select and add an activity. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
4. Use the **Regarding** field on the activity form to associate it with a customer or support case.  
  
### See Also  
 [Set up OneNote integration in Dynamics 365 for Customer Engagement](../admin/set-up-onenote-integration-in-dynamics-365.md)   
 [Create and manage a case (Customer Service)](../customer-service/user-guide-customer-service.md)</br>
 [Create and manage a case (Customer Service)](../customer-service/user-guide-customer-service-hub.md)
 
