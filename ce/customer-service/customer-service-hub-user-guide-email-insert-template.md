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

## Attach a file to email

Having the ability to attach file(s) to a message is one of the most useful features of email. You can attach a file using one of the two ways:

   ![How to attach a file to email](media\email-how-to-attach-file-to-email-1a.png "How to attach a file to email")

   1. **Attach file**. Located in the top nav bar, **Attach file** allows you to do file attachments.
   2. **New Attachments**. Located above the rich text editor, the **New Attachments** ![](media\email-new-attachment-icon.png "new attachment") icon allows you to use drag-and-drop or copy-and-paste functionality. 

      > [!Note] 
      > Once you save your email, you can use **Attach file** and **New Attachments** interchangeably.

      > [!Important] 
      > The default file size limit for an email file attachment is 5MB. The size limitations on email file attachments can be increased by your system administrators. 

## Work with attachments

You can attach an unlimited number of files to an email; however, there are file size limitations that are managed by your system administrator. 

**Enhanced email** is the default email form, however you can switch forms by doing the following:

   ![Work with attachments](media\email-work-with-attachments-1a.png "Work with attachments")
   
   1. Under the email subject name, click on the caret (v) next to **Email**
   2.	A drop-down appears with a list of email form options you can choose from.<BR><BR>

File attachments display differently, depending on the email form you are working in. You can switch email forms without losing information.

### Email form file attachment

   ![Work with attachments](media\email-work-with-attachments-2a.png "Work with attachments")

   1. **Email**. This display confirms which email form you are working in. 
   2. **Attachment**. This section displays a list of file attachments in a vertical view and only displays the first three attachments.
   3. **File count**. This displays when you have more files than what can be viewed and allows you to see the total number of attached files on the left side under the last attachment with the option to page over to see more images.

#### Enhanced email form file attachment
   ![Work with attachments](media\email-work-with-attachments-13b.png "Work with attachments")

   1. **Enhanced Email**. This display confirms you are working in the **Enhanced email** form.
   2. **Attached files**. This section displays all your email  attachments in a tile view above your message horizontally. The defaulted setting for the maximum number of files that can display is five attachments before displaying the page forward functionality.
   3. **File count**. This displays when you have files that occupy more than two rows and allows you to see the total number of attached files on the left side under the last attachment they the option to page over to see more images.
   4. **Attachment Commands**. This allow you to use the select, select all, sort, delete, and download functionality when working with your file attachments.  

## Work with the attachment command bar
When you’ve attached one or more files to a message, you can manage them using the file attachment commands.  

## Select commands

Select commands allow you to select individual files or multiple files at once.

   ![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-11a.png "Working with the attachment command bar")

   Legend
   1. **Select All**. This command is located on the right, above your attached files and allows you to select all file attachments at once. 

      > [!Note] 
      > **Select All** only selects files that are visible. If you have multiple pages of file attachments, you will need to go to that page and select those files independently.

   2. **Tile Color Transparency**. The background color of selected file attachments changes to light grey to identify which files have been selected.
   3. **Check box** You can also verify which files have been selected by viewing whether the checkbox in the top-right corner of the file attachment is selected. 

Formatting of file attachments in email can be realign based on the device being used and format it is being worked in.

  ![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-12a.png "Working with the attachment command bar")

   1. **Format Display** Regardless of format display, file attachments will only display the number of files that are enabled by your system administrator.
   2. **Page view**. The page view displays the total number of email attachments and always is displayed under the file attachments. 

### Delete and download commands
These are two of the most important commands when working with images. 

   ![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-13a.png "Working with the attachment command bar")

   1. **Delete**. This command works with the **Select** commands. You must first select a file before you can delete it. A confirmation request appears, requiring you to confirm you want to delete the file(s) you’ve selected.
   2. **Download**. This command also works with the **Select** commands and your browser download settings, allowing you to download an individual file or multiple files at once.  

## Preview image attachments

   ![How to preview images attachments](media\email-how-to-preview-images-attachments-11a.png "How to preview images attachments")

   1. **More options**. This command provides a list of actions for that file type.
   2. **Non-preview image**. Only non-preview image types allow you to either **export selected records**, **download**, or **delete** the attached file.
   3. **Preview image types**. Allow you to **export selected record**, **preview**, **download**, or **delete** the attached file. When you select the **preview** option, a pop-up window appears, displaying the image with the image name listed below.

### Supported email file attachments
The following is a list of file image types that are supported:

|image type	 |supports preview	|supported inline (in editor)|
|------------|-------------------|----------------------------|
|BMP.bmp     | Yes               | Yes                        |
|GIF.gif     | Yes               | Yes                        |
|ICO.ico     | Yes               | Yes                        |
|JPG.jpg     | Yes               | Yes                        |
|PNG.png     | Yes               | Yes                        |
|SVG.svg     | Yes               | Yes                        |
|PDF.pdf     | Yes (preview not supported on IE) | No         |

## View and insert images in email

The use of visual aids helps users convey a tremendous amount of information with just a glance. Having the ability to view and insert inline images in email using the drag-and-drop or copy-and-paste functionality is a very powerful tool for users. Additionally, you can browse to a file or reference an online URL using the image toolbar button.

You can drag-and-drop or copy-and-paste images into the email.

   ![How to view and insert images in email](media\email-how-to-view-and-insert-images-in-email-1b.png "How to view and insert images in email")

   1. **Email images** You can adjust the image size.  
   2. **Save**. When you complete your edits, select **Save** or **Save & Close**.

      > [!Note]
      > There is a 1 MB file size limitation when adding an inline image to an email for email templates. (For new or replied emails, there isn't a limit to the email size (it becomes part of the total email size).

