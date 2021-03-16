---
title: "Track Outlook contacts in Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: ce639d6e-1cad-4db0-9c46-640af2020c40
caps.latest.revision: 47
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
# Track Outlook contacts in Dynamics 365 for Outlook
When you track a contact in [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)], a copy of that contact record is saved in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] and synchronized with the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] record. After your contacts are tracked, you’ll be able to see any email, tasks, appointments, and account records associated with those contacts. You can access the records in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].

 Tracking contacts in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is a manual process. This gives you the ability to keep your personal contacts separate from your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] contacts. Synchronization of contacts from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is automatic, however. Any contacts that you own in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] will automatically be available in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. If you sync [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] on your mobile device, you can also access your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] contact records on that device.

1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], choose **People** in the navigation pane, and then select up to 20 contacts.

   > [!TIP]
   >  If you want to select more than 20 contacts, or if you want to track all your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], you can use the **Add Contacts** wizard. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use a wizard to add and track multiple Outlook contacts in Dynamics 365 for Outlook](use-wizard-add-track-multiple-outlook-contacts.md)  
  
2. To track the contact, do one of the following:  
  
   - To track the contact record without linking it to a parent (account) record in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], on the **Home** tab, in the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, choose **Track**.  
  
      -Or-  
  
   - To track the contact and link it to a parent (account) record in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], on the **Home** tab, in the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, choose **Set Parent**, and then search for the parent record in the **Look Up Record** dialog box. After you find the record you want, choose **Add**.  
  
      When you choose the **Track** button or the **Set Parent** button, a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] pane (also known as the “tracking pane”) appears at the bottom of the contact record. This pane shows that the contact is tracked and provides links to related records. If you choose the **Set Parent** button, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] also provides a link to the parent record. [Tell me more about how tracking works](https://go.microsoft.com/fwlink/p/?LinkID=510100)  
  
      In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the **Tracked in Dynamics 365 apps** icon ![trackincrm](../media/trackincrm.gif "trackincrm") is displayed next to any tracked contacts.  
  
3. To add additional information about the contact to the Contact form in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], choose the contact, and then in the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, choose **View in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]**.  
  
   **Notes**  
  
- To add additional information about the contact to the Contact form in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], choose the contact, and then in the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, choose **View in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]**.  
  
- If the contact is linked to a parent record, you can open the parent record from the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contact record in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. In the contacts list,  open the record. In the **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** group, choose **View Parent** (or select the link in the tracking pane).  
  
- The **Company** field for an [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contact is not automatically added to the parent account of the new [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] contact. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)]. [Set personal options that affect tracking and synchronization between Dynamics 365 apps and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-exchange.md)  
  
## Avoiding duplicate contact records  
 When you track contacts, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] checks for duplicate records. [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] also checks for duplicates when you synchronize records manually or go online if you’re been working offline.  
  
 If [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] detects that a contact might be a potential duplicate, instead of saving the contact, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] displays the **Duplicates Detected** dialog box.  
  
 Here’s what you need to do if this happens:  
  
1.  In the **Potential duplicate records** list, double-click or tap the record.  
  
2.  If your new or updated record is not a duplicate, to create the new record, choose **Save Record**.  
  
     \- OR -  
  
     If your new or updated record is a duplicate, to cancel your changes, choose **Cancel**.  
  
3.  If the duplicate-detection rule identified potential duplicate records in other record types, review records from each record type listed.  
  
> [!IMPORTANT]
>  Duplicate detection can take place only if duplicate detection is enabled and if at least one duplicate-detection rule exists for the record type.  
  
### See also  
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   
 [Use a wizard to add and track multiple Outlook contacts in Dynamics 365 for Outlook](use-wizard-add-track-multiple-outlook-contacts.md)   
 [Set personal options that affect tracking and synchronization between Dynamics 365 apps and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-exchange.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]