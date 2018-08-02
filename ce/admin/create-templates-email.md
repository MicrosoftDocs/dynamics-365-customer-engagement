---
title: "Create templates for email for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: b47eec74-e83c-4cfe-b7a0-a9195a3ac4da
caps.latest.revision: 35
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Create templates for email

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Save time when creating multiple email messages by making email templates. Email templates contain prefilled data that you specify, so you don’t have to reenter the same information for each article.  
  
 An email template is attached to an email activity after the activity is created. Typically, each type of email activity has its own email template type; for example, an email activity created from a case record would use a case email template. You can also create global templates that are available for any record type, or personal templates available only to you, or organizational templates available to anyone in your organization.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_templates](../includes/proc-settings-templates.md)]  
  
3. Choose **Email Templates**.  
  
4. On the Actions toolbar, click or tap **New**.  
  
5. In the **Email Template Type** dialog box, in the **Template Type** list, select the type, and then click or tap **OK**.  
  
   > [!IMPORTANT]
   >  If you choose a specific record type, such as lead or opportunity, the template is available only for that record type. This cannot be changed. To use the same content for another record type, create a new template.  
  
6. On the **Email Templates** form, enter a **Title** and **Subject**.  
  
7. You can type a description of the template. This is not displayed to the recipient.  
  
8. Type the text you want to send in this message. Use the Formatting toolbar to edit the text.  
  
   > [!TIP]
   > - Although you cannot insert images or HTML directly into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] email messages or email templates, you can use the copy feature in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to copy an image from a website and paste it into the email message or email template.  The image is available as long as the website is accessible.  
   > - To include a hyperlink in an email template, type the URL including the http://, for example, http://contoso.com. Do not include a period or comma or a space after the URL or the link will break. Select the link text and click **Make this a Hyperlink** (![Make this a Hyperlink](../admin/media/make-this-hyperlink.png "Make this a Hyperlink")).  
   > 
   >    A link is automatically added to the  URL and the text is underlined and changed to blue.  
   > - To  include data fields in a hyperlink:  
   > 
   >   1. Select the link text and data fields. For example: http://contoso.com/q?{!User : City;}  
   >   2. Click **Make this a Hyperlink** (![Make this a Hyperlink](../admin/media/make-this-hyperlink.png "Make this a Hyperlink")).  
   > 
   >      The text and data fields will be converted to a hyperlink. For example: \<a href="http://contoso.com/q?{!User : City;}">http://contoso.com/q?{!User : City;}\</a>.  
   > 
   >      The hyperlink text will appear as a link when the template is used in an email.  
   > - There is no spell check built into [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. There might be third-party solutions available. For more information, visit [Microsoft Dynamics Solution Finder](https://www.microsoft.com/dynamics365/partners).  
   > - The Formatting toolbar has limited fonts and font sizes. However, you can copy and paste content from [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-full.md)]. This allows you to take advantage of features such as spell checking and some advanced text formatting. To single-space a line of text, at the end of the line press **Shift+Enter**.  
  
9. To insert data fields to display information such as a customer's name or data from a quote, from a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record, click or tap **Insert/Update**, and then in the **Data Field Values** dialog box, click or tap **Add**.  
  
10. In the **Add Data Value** dialog box, select the **Record type** and **Field**, and then click or tap **OK**.  
  
11. Click or tap **OK** again to insert the data.  
  
12. To enter customers' first and last names, you'll need to repeat these three data-insertion steps; first and last names are separate data values.  
  
    > [!TIP]
    >  Use the **Default Text** box to define what text is displayed if the record does not have data for the field.  
  
13. Click or tap **Save** or **Save and Close**.  
  
> [!NOTE]
> - To change a shared template to a personal one or a personal template to a shared one, on the template form, on the **Actions**![action](../admin/media/action-button.gif "action") menu, click or tap **Revert to Personal Template**, or click or tap **Make Template Available to Organization**.  
> - If you use an email template as a signature in another template, insert the signature template first. Otherwise, the Subject line will be overwritten.  
> - If you need to back up your templates, or export them for use in a different implementation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can export them as part of exporting customizations. More information: [Export your customizations as a solution](../customize/use-solutions-for-your-customizations.md).  
  
### See also  
 [Work with templates](work-with-templates.md)
