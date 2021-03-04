---
title: "Create or edit an appointment (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: shubhadaj
ms.assetid: 50af7faf-8578-4244-9710-f05544b97f38
caps.latest.revision: 41
ms.author: shujoshi
manager: sakudes
search.audienceType: 
  - enduser

---
# Create or edit an appointment

Block time to meet or talk to your customers by using appointments. You can modify any of the information in an open appointment. If you change the date and times of the appointment, the appointment will be rechecked for schedule conflicts.  

> [!NOTE]
> Recurring appointments are not supported on the Dynamics 365 App for Outlook, Dynamics 365 for phones app, and when you run the web client on your mobile phone web browser. 

The calendar displays canceled and completed appointments and service activities. 

To remove an appointment or service activity from the calendar, delete the record.  
  
1. To create an appointment or a recurring appointment on the Service Calendar, on the nav bar, go to **Service** > **Service Calendar**.   
  
   To create an appointment or recurring appointment in the **Activities** area, on the nav bar, go to **Sales** > **Activities**.   
  
2. On the command bar, select **Appointment**.  
  
3. Type or change information in the text boxes. You can point to a field to get a tip on what data to enter.  
  
4. If this is a recurring appointment, select **Recurrence**, and then select the time, pattern, and date range you want.  
  
5. Select **Save**. If any participants have a schedule conflict, a warning appears. You can select **Ignore and Save** to save the appointment anyway.  
 
If you want to add an attachment, make sure you save the appointment first. Then, in the **Attachments** section, select the **Add attachment record** button ![Add Appointment button](../basics/media/plus-sign-icon.png "Add Appointment button") (you may have to scroll to the right to see the button) and browse for the file. The attachment size limitation is the same as the email attachment size limitation, which can be changed by your system administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Email tab](../admin/system-settings-dialog-box-email-tab.md)

> [!IMPORTANT]
>  If you plan to include appointments in solutions, we strongly recommend that you don’t include only appointments and only recurring appointments in separate solutions. If you install and uninstall separate solutions with different appointment types, you’ll encounter a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] error and you’ll have to recreate the appointments. 

## Create draft appointments synchronizing with Exchange

Create an appointment in Dynamics 365 Customer Engagement (on-premises) and **Save as Draft** without synchronizing with Exchange. The appointment form will have a **Save as Draft** option and a **Send** option, so that you can save, add details and update an appointment activity without synchronizing to Exchange. Note, you will need to be on version 9.x (build 9.0.2.2081).

To enable this capabilities, an admin will need enable the *OrgDBOrgSetting* in Dynamics 365. 

1. Follow the instructions [in this article](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) for steps to extract the tool.
2. After extracting the tool, enable the *OrgDBOrgSetting AllowSaveAsDraftAppointment*.

You can also use [this tool](https://github.com/seanmcne/OrgDbOrgSettings/releases/) to edit *OrgDBOrgSetting AllowSaveAsDraftAppointment*.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]