---
title: "Insert email templates in customer engagement apps | MicrosoftDocs"
description: "Learn how to insert an email template in customer engagement apps."
author: lalexms
ms.author: laalexan
ms.date: 01/18/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
ms.reviewer: nenellim
---


# Insert an email template

   ![Insert an email template](media\email-how-to-insert-an-email-template-1a.png "How to insert an email template")

   - If you have created an email template, it can be accessed from the command bar by selecting **Insert Template**. <BR><BR>

**Insert an email template overview**  

Once you select **Insert Template**, the following window appears displaying a list of existing **Email templates** that are available to use.

Add note - intermediary window

#### Email template selection window

   ![Email template selection window](media\email-how-to-insert-an-email-template-1b.png "Email template selection window")

   Legend
   1. **Language**. Templates are loaded as per the selected language.
   2. **search**. You can use search to find a template. Search does not support regular expressions and only works when using the name of that specific template.  
   3. **All templates**. All existing templates that have been created are displayed in this window  which you can browse and choose from.
   4. **Preview**. When you select an email template, a preview of the template is displayed here. The preview shows you the content so you can pick the template that best meets your needs. After inserting an email template, you can modify the content as needed.
   5. **Apply template** to insert the content to your  email.

      > [!Note] 
      > If you try to insert an email template on a device with a smaller screen size, you'll only see an option to search and select a template.

## Convert an email to a template
When you have composed an email that you would like to reuse with other customers, you can convert it to an email template to use in the future.

### Convert an email into a template 

   ![How to convert an email to a template](media\email-how-to-insert-an-email-template-1c.png "How to convert an email to a template")

   When you have composed and formatted an email message that you would like to save as template, select the downward-facing caret (v) next to **Insert Template** and select **Convert to an email template** from the drop-down list.

#### Convert an email to a template overview
The following window will display with a list you can customize.

   ![How to convert an email to a template](media\email-how-to-insert-an-email-template-1d.png "How to convert an email to a template")

Legend 
   1. **Template name**. Assign your email template a detailed name you want to save for future use.
   2. **Permission level**. You can share the template you create with your **Organization** or as  **Individual** for personal use.
   3. **Category**. The default for this field is set to **User**.
   4. **Language**. You can display your installed language packs in this field. **Language** also helps to categorize your templates. 
   5. **Convert**. Once an email is formatted, you can convert it to an email template.

## Work with email templates

### View an email template

You can view a complete list of all the email templates you have created by: 

- Go to the **Templates** section on the left nav 
- Select **Email templates**
- A list of **All Email Templates** is displayed, which you can edit and update.

### Insert dynamic text in an email template form

   ![How to insert dynamic text in an email template form](media\email-how-to-insert-dynamic-text-1a.png "How to insert dynamic text in an email template form")

   Legend 
   1. **Add data fields**. When you add data fields, the template adds **Record type** and **Field name** fields below. You can add as many data fields you want.
   2. **Record type**. You can then customize the record types. Default is set to account.
   3. **Field name**. You can customize the field names. Default is set to account name.
   4. **More Commands**. The **More commands** ![More commands icon](media\timeline-more-commands-icon.png "more commands icon") icon allows you to edit the order of the record types using the **Move Up** or **Move down** functionality to align records in a customized order.
   5. **Default text**. Allows you to select the style of text for the subject and body of your email template. If no text is selected, it will display using the default text.
   6. **Insert**. When done this command inserts and saves your form.

      > [!Note] 
      > If you click in an area on the form that does not support dynamic text, it displays **Unable to insert**.

   For more information on creating email templates and configurations, see [Create templates for email](https://docs.microsoft.com/power-platform/admin/create-templates-email).

