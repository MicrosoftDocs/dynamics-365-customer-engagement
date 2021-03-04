---
title: "Why does the Customer Engagement (on-premises) email message I sent have a Pending Send status? | MicrosoftDocs"
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
ms.assetid: 98ee8425-c7dc-46e3-b721-7c3edca4bf0d
caps.latest.revision: 6
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin

---
# Why does the email message I sent have a "Pending Send" status?

If you create an email message in Dynamics 365 Customer Engagement (on-premises) and click the **Send** button, the message will not be sent unless email integration has been correctly configured and enabled for sending email from Customer Engagement (on-premises).  If the status of the email appears as "Pending Send" and is not sent, contact your Customer Engagement (on-premises) administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your administrator or support person](../basics/find-administrator-support.md)  
  
 If you are the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] administrator, verify that the user who sent the email is enabled for sending email. To do this:  
  
1. Click **Settings**, and then click **Email Configuration**.  
  
2. Click **Mailboxes**, and then change the view to **Active Mailboxes.**  
  
3. Select the Customer Engagement (on-premises) mailbox record for the user who sent the email, and then click the **Edit** button.  
  
4. Verify the user is correctly configured and enabled for sending email:  
  
   - If the user’s Customer Engagement (on-premises) mailbox record is configured to use server-side synchronization for outgoing email, verify the user’s email address is approved and is also tested and enabled.  For more information about configuring server-side synchronization, see [Set up server-side synchronization of email, appointments, contacts, and tasks](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md).  
  
### See also  
 [Integrate your email system](../admin/integrate-synchronize-your-email-system.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]