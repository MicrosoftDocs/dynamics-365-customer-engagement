---
title: "Track Outlook appointments in Dynamics 365 for Outlook | MicrosoftDocs"
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
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: 430d8700-ae27-49b7-a4c1-0e0fcc49fa50
caps.latest.revision: 18
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
# Track Outlook appointments in Dynamics 365 for Outlook
You can track an appointment in [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to save a copy of that appointment record as an activity in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] synchronizes the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] record with the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] record so you can view or edit the appointment in either tool. If you sync [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] on your mobile device, you can also access your appointment records on that device.

 Tracking appointments in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is a manual process. This gives you the ability to keep your personal appointments separate from your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] appointments. Synchronization of appointments from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is automatic, however. You can use [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] to view any appointment records that you own that were created in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].

 If you’re using [!INCLUDE[pn_crm_2015_outlook](../../includes/pn-crm-2015-outlook.md)] or later, you can also synchronize appointment attachments if your system administrator has enabled this capability. You can then view and update the attachments in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].

> [!IMPORTANT]
>  To synchronize appointments between [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] and [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address must match your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] email address. You can’t synchronize to or from multiple email addresses.

## Track an appointment

1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], create an appointment as you normally would in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].

2. If you want to insert an attachment, click the **Insert** tab, and then select an attachment. Note that some file extensions may be blocked by your system administrator. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [System Settings dialog box - General tab](/power-platform/admin/system-settings-dialog-box-general-tab)

    [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] doesn’t support inline attachments (attachments included in the body of the message).

   > [!NOTE]
   >  The maximum size for an attachment is 5MB, although this can be increased to 32 MB by a system administrator.  
  
3. To track the appointment, do one of the following:  
  
   - To track the appointment without linking it to a particular record in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], on the **Appointment** tab, in the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, click **Track**.  
  
      -Or-  
  
   - To track the task and link it to a particular [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] record (for example, a specific account), click **Set Regarding**, click **More**, and then search for the record in the **Look Up Record** dialog box. After you find the record you want, select **Add**.  
  
     When you click the **Track** button or the **Set Regarding** button, you’ll see a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] pane (also known as the “tracking pane”) at the bottom of the appointment record. This pane shows that the record is tracked and provides links to related records. If you set a Regarding value, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] also provides a link to the Regarding record. [Tell me more about how tracking works.](../../customerengagement/on-premises/basics/basics-guide.md)  
  
   **Notes**  
  
- To stop tracking an appointment, open the appointment record, and then click the **Untrack** button.  
  
- After an appointment attachment is synchronized, if different users update the attachment in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]**and**[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], the latest update will be saved.  
  
- After an appointment is synchronized, if you or another user changes the subject of the appointment in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], the appointment will be untracked (no longer synchronized).  
  
- You can’t synchronize attachments in recurring appointments or service appointments in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
### See also  
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]