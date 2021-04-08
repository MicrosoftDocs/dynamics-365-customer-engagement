---
title: "Create a Microsoft Word mail-merge document with Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: de3bac06-c80f-40f8-bf8f-6e0735e8350e
caps.latest.revision: 36
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
# Create a Microsoft Word mail-merge document with Dynamics 365 for Outlook
You can use [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] with [!INCLUDE[pn_MS_Word_Full](../../includes/pn-ms-word-full.md)] to create documents for your customers that display [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data.  
  
 With mail merge, you can:  
  
- Create new templates or use an existing template to generate form letters for yourself or, with the appropriate permissions, for the whole organization.  
  
- Send form letters or form email messages to contacts, accounts, or marketing mailing lists.  
  
- Resend old letters to new recipients.  
  
- Create faxes.  
  
- Create quotes.  
  
  In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], only one mail merge can be run at a time. If you receive the message "[!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] Mail Merge is already running" and want to discontinue a mail merge, close and then reopen [!INCLUDE[pn_MS_Word_Full](../../includes/pn-ms-word-full.md)] or [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)].  
  
  To use mail merge, your email format must be HTML.  
  
  Record types that use mail merge:  
  
- Account  
  
- Campaign  
  
   To use mail merge with a campaign, you must first distribute a mail campaign activity to a selected marketing list.  
  
- Contact  
  
- Lead  
  
- Opportunity  
  
- List Member in Marketing List  
  
- Quick Campaign  
  
   In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you can create a mail merge, and then at the end of the process, create a quick campaign.  
  
- Quote  
  
   With mail merge, you can print only one quote at a time.  
  
### Create a mail merge document  
  
1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], open the list of records you want.  
  
   > [!TIP]
   >  This list can be the results of an [Advanced Find search](../../customerengagement/on-premises/basics/save-advanced-find-search.md).  
  
2. In the list, select the record you want to add to the mail-merge recipient list.  
  
3. On the **Add** tab, in the **Marketing** group, click or tap **Mail Merge**.  
  
4. If you have other languages installed, you can select a language to filter the list of templates.  
  
    In the **Mail Merge** dialog box, select the type of document you want to use.  
  
5. Choose whether you want to start with a blank document or a template. If you select a template option, click or tap the **Lookup** button ![Lookup button](../media/lookup-button-4.gif "Lookup button") to select a template.  
  
    New mail merge templates are created in the Settings area. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Work with mail merge templates](/power-platform/admin/work-mail-merge-templates)
  
6. If necessary, you can add or delete data fields.  
  
    [!INCLUDE[pn_MS_Word_Full](../../includes/pn-ms-word-full.md)] supports up to 62 data fields, of which  [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] reserves two data fields to store the primary key and the record owner.  
  
7. Click or tap **Download**.  
  
    [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] automatically opens a  [!INCLUDE[pn_ms_Word_short](../../includes/pn-ms-word-short.md)] document. You may need to select [!INCLUDE[pn_MS_Word_Full](../../includes/pn-ms-word-full.md)] in the task bar.  
  
    This is not your mail-merge document. This is an interim page.  
  
8. In the **Mail Merge Recipient** dialog box, verify that the list is accurate, and then click or tap **OK**.  
  
9. To continue the mail merge, follow the instructions provided by the Mail Merge pane. For more information, see the [!INCLUDE[pn_MS_Word_Full](../../includes/pn-ms-word-full.md)] Help documentation for mail merge.  
  
    > [!TIP]
    > -   To display the information you want and select the format, in the Mail Merge wizard, click or tap **Address Block** and then **Greeting Line**.  
    > -   To add data fields to display more information, click or tap **More Items**. You can use up to 62 data fields.  
  
10. If you have either created a new template or updated an existing template, you can upload the template.  
  
    -   To save the document as a template, on the **Complete the merge** pane, click or tap **Upload Template to Dynamics 365 apps**.  
  
11. If you have saved the document as a template, you can go back and edit the template with **Settings** > **Business** > **Templates**. Click or tap your template to review and edit it.  
  
### See also  
 [Work with templates](../../customerengagement/on-premises/admin/work-with-templates.md)<br />
 [Send bulk email to customers](../../customerengagement/on-premises/basics/send-bulk-email-customers.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]