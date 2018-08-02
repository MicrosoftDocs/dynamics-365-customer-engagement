---
title: "When would I want to use this check box in Dynamics 365 Customer Engagement? | MicrosoftDocs"
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
ms.assetid: e6794669-552e-4614-80f9-13add84f2fae
caps.latest.revision: 20
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# When would I want to use this check box?

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

 A user can be a member of more than one [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization, but an [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] mailbox (email address) can only synchronize emails, appointments, contacts, and tasks with one organization, and a user that belongs to that organization can only synchronize emails, appointments, contacts, and tasks with one Exchange mailbox. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] stores the organization ID (`OrgID`) for the synchronizing organization and the last time the user synced in Exchange.  
  
 You can use the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box to overwrite the setting stored in Exchange if you want to change the primary synchronizing organization. Why would you want to do this? In most cases, you won’t need to. Most users are members of just one organization. When an admin starts the synchronization for the user’s Exchange mailbox by testing and enabling the mailbox through server-side synchronization, the user’s mailbox is automatically set to synchronize appointments, contacts, and tasks with that organization.  
  
 However, you may want to select the check box in the following situations:  
  
- The `OrgID` setting in Exchange can inadvertently be overwritten in certain circumstances. For example, let’s say a user is a member of two organizations: one in North America and one in Japan. The admin for the North American organization sets up the user’s mailbox through server-side synchronization. Then the admin for the organization in Japan sets up the same user’s mailbox through server-side synchronization, overwriting the `OrgID` setting stored in Exchange. The user will only be able to synchronize appointments, contacts, and tasks with the organization in Japan. To reset the user’s mailbox, select the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box.  
  
- In some cases, you may not know the state of the configuration stored in Exchange, but the user’s Exchange mailbox is not able to synchronize for some reason. In this case, select the check box to start synchronizing the mailbox with the appropriate organization.  
  
- If an admin has migrated users from one organization to another, a user’s mailbox might still be set to synchronize with the old organization. In this case, select the check box to start synchronizing the mailbox with the appropriate organization.  
  
  To make sure an administrator doesn’t inadvertently set a non-primary organization as the synchronizing organization, it’s a best practice to set the synchronization method for the non-primary organization to **None**.  
  
## Set the synchronization method to “None” for the non-primary organization  
  
1. [!INCLUDE[proc_settings_email_config](../includes/proc-settings-email-config.md)]  
  
2. Choose **Mailbox**.  
  
3. Choose the mailbox record to open it.  
  
4. In the **Mailbox** dialog box, under **Synchronization Method**, select **None** in the **Appointments, Contacts, and Tasks** list.  
  
### See also  
 [Set up server-side synchronization of email, appointments, contacts, and tasks](set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)
