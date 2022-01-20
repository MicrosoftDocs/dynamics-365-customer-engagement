---
title: "Deleting records that have been tracked with Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: 6747eed5-e264-43a1-8f27-ea0d46afaaa1
caps.latest.revision: 12
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
# Deleting records that have been tracked with Dynamics 365 for Outlook
You can use [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to track email messages, contacts, tasks, and appointments. When you track an item, a copy of that record is saved as an activity in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] and synchronized with the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] record. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md).  
  
 The following rules apply whether you synchronize records with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)].  
  
## Email messages  
  
- Deleting a tracked email message in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] does not delete the email message from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
- Deleting an email message in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] does not delete the tracked message from [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
  
- If you stop tracking an email message in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] asks whether you want to delete the email message in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
## Appointments  
 Deleting a tracked appointment in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] deletes the appointment in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. Deleting a tracked appointment in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] deletes the appointment in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] if the following is true:  
  
- The appointment date is in present or future.
  
- You are the owner or organizer of the appointment record.  
  
  If you stop tracking an appointment, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] asks whether you want to delete the appointment from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. The appointment record is deleted in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] if the following is true:  
  
- The appointment date is in present or future.
  
- You are the owner of the appointment record.
  
## Contacts  
  
- Deleting a tracked contact in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] does not delete the contact record from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
- If you are not the owner of the contact record, deleting a contact from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] deletes the tracked contact from [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
  
- If you are the owner of the contact record, deleting a contact from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] does not delete the contact from [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
  
- If you are the owner of the contact record, and you stop tracking the contact, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] asks whether you want to delete the contact record from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
- If you are not the owner of the contact record and you stop tracking the contact, [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] deletes the contact record.  
  
## Tasks  
  
- Deleting a tracked task in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] deletes the task activity record in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
- Deleting the task activity record in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] deletes the task in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] if the task is current.  
  
- If you stop tracking the task, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] asks whether you want to delete the task in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
### See also  
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   


[!INCLUDE[footer-include](../../includes/footer-banner.md)]