---
title: "Create a signature for your email or for a queue (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 1f9aff52-59b9-4be0-a5fe-c797d3f98155
caps.latest.revision: 11
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Create a signature for your email or for a queue

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use an email signature in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement to save time and be consistent in your responses. The owner of an email signature can be a user or a team.  
  
## Create an email signature  
 To edit a signature if you are not a system administrator:  
  
1. Click the **Settings** button ![Options button for Dynamics 365 for Customer Engagement apps](../basics/media/optionsbutton.png "Options button for Dynamics 365 for Customer Engagement apps") in the upper-right corner of the screen.  
  
2. Click **Options**, and then click the **Email Signatures** tab.  
  
   To edit a signature if you are a system administrator:  
  
3. [!INCLUDE[proc_settings_templates](../includes/proc-settings-templates.md)]  
  
4. Choose **Email Signatures**.  
  
   To create a new email signature:  
  
5. On the Actions toolbar, click **New**.  
  
6. On the **Email Signature: New Email Signature** page, enter the following values:  
  
   - **Owner:** The user or team that owns this signature.  
  
   - **Language:** If you have multiple language packages installed, select the language for the signature you're composing.  
  
   - **Title:** The title for this email signature.  
  
7. Click **Set as Default** to make this the default email signature.  
  
8. Click **Save and Close**.  
  
## Using email signatures  
 If you have a default signature, when you create a new email in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] (for example, **Sales** > **Activities** > **Email**), an email signature is automatically added to the email based on the user you enter in the **From** field. An email signature must be defined for the user.  
  
 To change or add a signature, click **Insert Signature** on the menu bar on an email form.  
  
 When you open the Email Signatures page, email signatures you own are displayed. Change the view to **All Email Signatures** to see signatures created by others.  
  
## Things to know about email signatures  
  
- The owner of an email signature can create, update, or delete it.  
  
- Each user or team can have no more than one default email signature.  
  
- When you change the owner of an email signature, the signature reverts to non-default. For example, a signature is a default for user A. User A assigns it to queue X and queue X already has a default signature. The signature  assigned will be non-default for queue X. If queue X does not have a default signature, the new signature will become the default signature.  
  
- If the **From** field is changed to a user, the user email signature will appear. When you click **Insert Signature**, all the signatures that the user owns will appear. If the **From** field is changed to a queue,  the default email signature of the owner of the queue will appear. The owner of a queue can be a user or a team. When you click **Insert Signature**, all the email signatures that are owned by the queue owner (user or a team) will appear.  
  
  ![Email signature for user responding to an email](../basics/media/email-signature-user-responding-an-email.png "Email signature for user responding to an email")  
  
- If the **From** field is changed to a queue,  the default email signature of the owner of the queue will appear. The owner of a queue can be a user or a team. When you click **Insert Signature**, all the email signatures that are owned by the queue owner (user or a team) will appear.  
  
  ![Email signature for a queue responding to email](../basics/media/email-signature-queue-responding-email.png "Email signature for a queue responding to email")  
  
### See also  
 [Work with templates](../admin/work-with-templates.md)
