---
title: "Why does the Dynamics 365 Customer Engagement email message I sent have a Pending Send status? | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 98ee8425-c7dc-46e3-b721-7c3edca4bf0d
caps.latest.revision: 6
author: "brycho"
ms.author: "brycho"
---
# Why does the email message I sent have a "Pending Send" status?
If you create an email message in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and click the **Send** button, the message will not be sent unless email integration has been correctly configured and enabled for sending email from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  If the status of the email appears as "Pending Send" and is not sent, contact your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your Dynamics 365 administrator or support person](../basics/find-dynamics-365-administrator-support-person.md)  
  
 If you are the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator, verify that the user who sent the email is enabled for sending email. To do this:  
  
1.  Click **Settings**, and then click **Email Configuration**.  
  
2.  Click **Mailboxes**, and then change the view to **Active Mailboxes.**  
  
3.  Select the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mailbox record for the user who sent the email, and then click the **Edit** button.  
  
4.  Verify the user is correctly configured and enabled for sending email:  
  
    -   If the user’s [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mailbox record is configured to use server-side synchronization for outgoing email, verify the user’s email address is approved and is also tested and enabled.  For more information about configuring server-side synchronization, see [set up server-side synchronization of email, appointments, contacts, and tasks](https://technet.microsoft.com/library/dn531109.aspx).  
  
    -   If the user is configured to use [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] for outgoing email, verify the user has [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] installed and configured.  See [Set up Dynamics 365 for Outlook](set-up-outlook.md).  
  
### See also  
 [Integrate your email system with Microsoft Dynamics 365](https://technet.microsoft.com/library/dn832099.aspx)