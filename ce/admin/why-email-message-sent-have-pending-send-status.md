---
title: "Why does the Dynamics 365 for Customer Engagement apps email message I sent have a Pending Send status? | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 98ee8425-c7dc-46e3-b721-7c3edca4bf0d
caps.latest.revision: 6
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Why does the email message I sent have a "Pending Send" status?

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

If you create an email message in [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps and click the **Send** button, the message will not be sent unless email integration has been correctly configured and enabled for sending email from [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps.  If the status of the email appears as "Pending Send" and is not sent, contact your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your Dynamics 365 for Customer Engagement administrator or support person](../basics/find-administrator-support.md)  
  
 If you are the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] administrator, verify that the user who sent the email is enabled for sending email. To do this:  
  
1. Click **Settings**, and then click **Email Configuration**.  
  
2. Click **Mailboxes**, and then change the view to **Active Mailboxes.**  
  
3. Select the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps mailbox record for the user who sent the email, and then click the **Edit** button.  
  
4. Verify the user is correctly configured and enabled for sending email:  
  
   - If the user’s [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps mailbox record is configured to use server-side synchronization for outgoing email, verify the user’s email address is approved and is also tested and enabled.  For more information about configuring server-side synchronization, see [set up server-side synchronization of email, appointments, contacts, and tasks](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md).  
  
### See also  
 [Integrate your email system with Microsoft Dynamics 365 for Customer Engagement](../admin/integrate-synchronize-your-email-system.md)
