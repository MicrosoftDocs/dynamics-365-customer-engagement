---
title: "Work with mail merge templates for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
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
ms.assetid: 3b9afe9f-cd04-4543-998e-558f61e9ebf4
caps.latest.revision: 26
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Work with mail merge templates

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

You can use mail merge templates with Office Word to create customer-ready letters, faxes, e-mail messages, and quotes.  
  
 [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-short.md)] templates are created and edited in [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)], but can be uploaded to [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps to use with mail merge and share with other users. Only [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)] .xml documents can be used as templates. To learn more about how to create mail merge templates, see the online Help in [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-short.md)].  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_templates](../includes/proc-settings-templates.md)]  
  
3. Click **Mail Merge Templates**.  
  
4. To create a new mail merge template, click **New**.  
  
5. In the **Mail Merge Templates** form, enter a **Name** and an **Associated Entity** (record type).  
  
6. You can enter a description of the template. This is not displayed to the recipient.  
  
7. Enter the **Ownership** and **Owner** information. Use the handy tooltips as a guide.  
  
8. If you have enabled additional languages, you can select one for the template.  
  
9. To attach the template, click **Browse**, search for the template on your computer, and then click **Attach**. Only .xml documents can be uploaded.  
  
10. When you’re done, click **Save and close**.  
  
> [!NOTE]
>  To change a personal template to a shared one, after you save the record on the template form, on the **More Actions** menu, click **Make Available to Organization**. To revert the template to a personal one, click **Make Personal**.  
  
### See also  
