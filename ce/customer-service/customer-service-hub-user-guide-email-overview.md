---
title: "Use email in customer engagement apps | MicrosoftDocs"
description: "Learn how to use email in customer engagement apps. "
ms.date: 10/05/2020
ms.service:
  "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
ms.reviewer: nenellim
---

# Use email
Having the ability to communicate effectively with customers can lead to increased sales and customer satisfaction. The email capability in customer engagement apps empowers users with the ability to respond and provide timely customer interaction effortlessly through quick email access with enhanced features and functionality. Users can compose, reply, and review emails, as well as quickly attach and send images that add value and support to customer communication using streamlined functionality. You can also ensure interactions between users and customers are consistent and professional by using email templates with rich text and images. 

The following is an overview of email features and functionality that shows you: 
- [Understand the email experience](customer-service-hub-user-guide-email-overview.md#understand-the-email-experience)
- [How to view, compose, and respond to emails](customer-service-hub-user-guide-email-overview.md#how-to-view-compose-and-respond-to-emails)
- [How to use rich text editor toolbar in email](customer-service-hub-user-guide-email-overview.md#how-to-use-the-rich-text-editor-toolbar-in-email)
- [How to use email templates](customer-service-hub-user-guide-email-overview.md#how-to-use-email-templates)
- [How to attach a file in email](customer-service-hub-user-guide-email-overview.md#how-to-attach-a-file-to-email)
- [How to view and insert images in email](customer-service-hub-user-guide-email-overview.md#how-to-view-and-insert-images-in-email) 
- [How to create a signature for emails and queues](customer-service-hub-user-guide-email-overview.md#how-to-create-a-signature-for-emails-and-queues)

## Understand the email experience
You can work in either the **navigate-to** email or the **contextual** email experience. The difference between the navigate-to vs. contextual email experience is where the email displays on your screen. Both experiences use the same **Enhanced Email** form, which is enabled by default out-of-the-box (OOTB).

> [!Important]
> **Contextual** email is also referred to as **Enhanced** email. Please be aware there is no special functionality associated with the **Contextual / Enhanced** email experience, other than it is a pop-up experience. 

<ul>
<li><b>Navigate-to email experience</b>: always displays in a new screen. </li>
<li><b>Contextual email experience</b>: can only be initiated from the Timeline and displays email in a pop-up screen.
<ul>
<li>Allows you to move to different pages without losing email content.</li>
<li>Minimize the email window to return to the records you were working on.</li>
<li>Simultaneously view, compose, and reply to five emails in pop-up windows when enabled. </li></ul></ul>

> [!Note] 
> The existing enhanced email form will be deactivated with the general availability of the 2020 release wave 2 features. In the latest version of the Sales app (build 9.0.2006.5005), you'll notice that the name of the existing enhanced email form is changed to Enhanced Email (deprecated). A new form named Enhanced Email has been introduced with the new enhanced capabilities like quick preview or multiple email attachments. If you don't opt in for early access of the 2020 release wave 2 features, this form will be presented in a Read-only mode.

The following highlights the difference between the **navigate-to** and **contextual** email experience in the Timeline based on how your system administrator has configured your email:

1.	Select **Create a timeline record**

  ![Navigate to email vs contextual email experience](media\create-a-record-icon-1.png "Navigate to email vs contextual email experience")

2. Select **Email**

  ![Navigate to email vs contextual email experience](media\create-a-record-icon-1a.png "Navigate to email vs contextual email experience")

Depending on the experience you are using, your email will display as follows:

|Navigate-to Email Experience | | Contextual Email Experience|
|-----------------------------|-|----------------|
| ![Navigate to email vs contextual email experience](media\navigate-to-email-view-1c.png "Navigate to email vs contextual email experience") ||  ![Navigate to email vs contextual email experience](media\contextual-email-view-1a.png "Navigate to email vs contextual email experience")|
|The **Navigate-to** email will display in a new screen.||The **Contextual** email will display in a pop-up window on your current screen.|

> [!Important]
> - The pop-up window only opens when the height and width of your screen size is at least 400 x 650 pixels or greater. If lower, **navigate-to** email will be the default experience.
> - The **Contextual** email experience is available only for Timeline.

>[!Note]
> - If you use customized forms in email, you will still be able to see and use them. The **Enhanced Email** form showcases various email capabilities and functionality and just a standard form. 

For more information, see: 
- [Enable the enhanced email experience](customer-service-hub-user-guide-email-admin.md#how-to-enable-the-enhanced-email-experience)

## How to view, compose and respond to emails
Users can view, create, and send emails faster with streamlined access that helps users compose, reply, and send emails using rich text editing and drag-and-drop attachment features and functionalities.

### How to view an email
You can view and respond to emails across your Dynamics 365 app. 

For example, users can view and access emails in the Customer Service hub by going to **Service** and  using the following steps:

1. Select **Activities**
2. Select **All Activities** and select an email list you want to view from the drop down.

  ![How to view an email](media\email-how-to-view-an-email-1b.png "How to view an email")

3. When the email list appears, select the email you want to open and view. 

  ![How to view an email](media\email-how-to-view-an-email-1c.png "How to view an email")

### How to compose an email
Email capabilities like rich text editing and drag-and-drop or copy-and-paste images enriches customer interactions.

For example, you can create emails by going to **Service**, and using the following steps:

1. Select **Activities**

2. On the command bar, select **Email**. It opens an email in a new window. 

![How to compose an email](media\email-how-to-compose-an-email-1a.png "How to compose an email")

Anatomy of the email form: 

  ![How to compose an email](media\email-how-to-compose-an-email-1g.png "How to compose an email")

Legend

1. The name displayed in the **From** field is automatically populated based on the user who is currently signed in.

2. The **Expand** ![Expand icon](media\email-expand-icon.png "expand email") icon allows you to compose your email in a full-screen view and minimize when done.

3. The **rich text editor** tool bar helps you  format emails. The editor is displayed as a single line that can be expanded to view the full list of editing features by default.<BR>
  For more information, see [Editor functionality](customer-service-hub-user-guide-email-overview.md#formatting-options) and [Accessibility shortcuts](customer-service-hub-user-guide-email-overview.md#accessibility-shortcuts). 

4. The body is where you compose and/or reply to an emails.

5. Use **Insert Signature** to personalize your message.  

6. The **Insert Template** is used to apply an email template. <BR>
For more information, see [Insert an email template](customer-service-hub-user-guide-email-overview.md#how-to-insert-an-email-template).

> [!Note]
> The **To** box must contain a recipient to select a template.

7. Use **New Attachment** to add a file to your email.

8. The **Attach File** ![attach file icon](media\email-new-attachment-icon.png "attach file icon") icon functionality is used to drag-and-drop or copy-and-paste attachments. 

> [!Note] 
> After you save your email, you can use Attach file and New Attachments interchangeably.

9.	Select ![Send email icon](media\email-send-icon.png "Send email icon")  **Send** when you are done.


>[!Important]
> - The **From** and **To** fields are automatically populated based on the user and the account and contact of the original record.
 
For more information on enhanced email and configurations, see [Enable the enhanced email experience](customer-service-hub-user-guide-email-admin.md#how-to-enable-the-enhanced-email-experience).

### How to respond to an email
Depending on where you are in your app, how you reply to an email will function differently. An example from the Customer Service hub is provided below.

**Composing an email in activities and cases**

If your system administrator has enabled email, the email option displays on the navigation bar and in the activities command bar. When composing an email in entity records from **Activities**, you must set the reply field.  

Accessing email in entities:

![How to respond to an email](media\email-how-to-respond-to-an-email-1b.png "How to respond to an email")

1. From the navigation bar, select the plus ![](media\email-plus-icon.png "email icon") icon.

2. From the drop-down list, select **Activities**, then **email**

3. You can also select **Email** on the command bar.

>[!Note]
> Email option will only appear in the drop-down list and the command bar when enabled by your system administrator.

### Responding to emails in timeline
When replying to emails in Timeline, the command bar in the top-right corner provides you with reply options. When you select an option, your email automatically is set and opens in that state ready for you to begin your message.  

Use the following command options when working with emails in the timeline:

![Respond to emails in timeline](media\email-respond-in-timeline-1a.png "Responding to emails in timeline") 

1. Reply
2. Reply All
3. Forward 

## How to use the rich text editor toolbar in email
The rich text editor toolbar provides features and functionality that allows you to work with rich text formats in emails to better communicate with your customers.    

### Formatting options
The following table describes the different formatting features and functionality options available in the rich text editor that you can use in the email form:

|Icon | Name | Shortcut key | Description |
|----------------------|-------------------------|-----------------------------|-----------------------------|
|![Format Painter](../customer-service/media/format-painter.png "Format Painter")| Format Painter | Ctrl+Shift+C, Ctrl+Shift+V | Apply the look of a particular section to another section. |
|![Font](../customer-service/media/format-font.png "Font") | Font | Ctrl+Shift+F | Select your desired font. The default font is Segoe UI.<br /><br /> **Note**: When you select any formatted content, the font name for that content displays. If your selection contains multiple fonts, the topmost font name of your selection is displayed. |
|![Font Size](../customer-service/media/font-size.png "Font Size") | Font size | Ctrl+Shift+P | Change the size of your text. The default size is 12.<br /><br /> **Note**: When you select any formatted content, the font size for that content displays. If your selection contains multiple font sizes, the topmost font name of your selection is displayed.|
|![Bold](../customer-service/media/format-bold.png "Bold")| Bold | Ctrl+B | Make your text bold. |
|![Italic](../customer-service/media/format-italic.png "Italic")| Italic | Ctrl+I | Italicize your text. |
|![Underline](../customer-service/media/format-underline.png "Underline")| Underline | Ctrl+U | Underline your text. |
|![Text Highlight Color](../customer-service/media/text-highlight-color.png "Text Highlight Color")| Text Highlight Color |  | Make your text stand out by highlighting it in a bright color. |
|![Font Color](../customer-service/media/font-color.png "Font Color")| Font Color |  | Change the color of your text. |
|![Bullets](../customer-service/media/format-bullets.png "Bullets")| Bullets |  | Create a bulleted list. |
|![Numbering](../customer-service/media/format-numbering.png "Numbering")| Numbering |  | Create a numbered list. |
|![Decrease Indent](../customer-service/media/decrease-indent.png "Decrease Indent")| Decrease Indent |  | Move your paragraph closer to the margin. |
|![Increase Indent](../customer-service/media/increase-indent.png "Increase Indent")| Increase Indent |  | Move your paragraph farther away from the margin. |
|![Block Quote](../customer-service/media/block-quote.png "Block Quote")| Block Quote |  | Apply a block-level quotation format in your content. |
|![Align Left](../customer-service/media/align-left.png "Align Left")| Align Left | Ctrl+L | Align your content with the left margin. (Commonly used for body text to make it easier to read.) |
|![Align Center](../customer-service/media/align-center.png "Align Center")| Align Center | Ctrl+E | Center your content on the page. (Commonly used for a formal appearance.) |
|![Align Right](../customer-service/media/align-right.png "Align Right")| Align Right | Ctrl+R | Center your content on the page. (Commonly used for a formal appearance.) |
|![Link](../customer-service/media/format-link.png "Link")| Link |  | Create a link in your document for quick access to web pages and files.<br /><br />Pasted or typed URL text is converted into a link. For example, "http://myexample.com" will become "<a href="http://myexample.com">http://myexample.com</a>".<br /><br /> In the **Link** dialog box, choose the type of link you'd like to insert.<br /><br />The **Link Info** tab allows you to choose the link type as well as set the link protocol and URL.<br /><br />The **Target** tab is only available for the URL link type. It specifies the location where the link will open after you select it. |
|![Remove Link](../customer-service/media/remove-link.png "Unlink")| Unlink |  | Delete a link in your email or document.<br /><br />When you place the cursor on a link, the **Unlink** button on the toolbar becomes active. Select the button to remove the link and make it plain text. |
|![Superscript](../customer-service/media/format-superscript.png "Superscript")| Superscript |  | Type very small letters just above the line of text. |
|![Subscript](../customer-service/media/format-subscript.png "Subscript")| Subscript |  | Type very small letters just below the line of text. |
|![Strikethrough](../customer-service/media/format-strikethrough.png "Strikethrough")| Strikethrough |  | Cross out text by drawing a line through it. |
|![Insert Image](media\insert-picture.png "Insert Image")| Insert Image|	|You can insert an image by directly copying and pasting it inline in the editor, dragging and dropping it from your desktop or local folder directly into the editor, or by typing a URL. The following formats are supported: .PNG, .JPG., or .GIF.<br /><br />To insert an image inline in your article: <br />1. Drag and drop the image or copy and paste it directly into the article. <br />2. Drag any corner of the image to resize it.<br /><br />To insert an image using a URL or navigating to the local image:<br />1. Choose Insert Image.<br />2. In the **Image** property dialog, choose from the following options:<br /><ul><li>Select **Browse** to navigate to the image on your computer.</li><li>Or specify the web address of the image, and properties to define how the image will appear in the email or article.</li><br />**Note:**<ul><li>If the image is located on the external server, use the full absolute path. </li><li>If the image is located on a local server, you can use a relative path. </li><li>If you want the image to be linked to a target, add a URL for the image.</li><li>You can also specify if you want the targeted page to open in a new window, topmost window, same window, or parent window.</li></ul>
|![Left to Right](../customer-service/media/left-to-right.png "Left to Right")| Left to Right |  | Change the text to left-to-right for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. This is the default setting.|
|![Right to Left](../customer-service/media/right-to-left.png "Right to Left")| Right to Left |  | Change the text to right-to-left for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. The default setting is left-to-right. |
|![Undo Typing](../customer-service/media/undo-typing.png "Undo Typing")| Undo Typing |  | Undo changes you made to the content. |
|![Redo Typing](../customer-service/media/redo-typing.png "Redo Typing")| Redo Typing |  | Redo changes you made to the content. |
|![Clear All Formatting](../customer-service/media/clear-formatting.png "Clear All Formatting")| Clear All Formatting |  | Remove all formatting from a selection of text, leaving only the normal, unformatted text. |
|![Add a Table](../customer-service/media/add-table.png "Add a Table")| Add a Table |  | Add a table to your content. <br /><br />After adding a table, you can do any of the following:<br /><br /><ul><li>Resize table columns by clicking and dragging your mouse to resize to the columns to the desired width.</li><li>Select one or several cells within a table and apply specific formatting, add links to the selection, or cut, copy, or paste entire rows or columns.</li><li>Right-click to access the properties. This supports features such as cell type, width and height, word wrapping, alignment, merging and splitting cells horizontally and vertically, inserting or deleting rows and columns, row and column span, and cell and border color.</li></ul>|
|![Expand Toolbar](../customer-service/media/show-more.png "Expand Toolbar")| Expand Toolbar |  | Displays when the toolbar is collapsed and not all options appear. Click to expand the toolbar and make all options visible. |

> [!Note]
> You can access your browser's context menu by pressing **Ctrl** + right-click. This is useful if you need to use your browser's built-in spell checker. Otherwise, you can use the right-click to provide contextual formatting for any element you might be using.

## Accessibility shortcuts

The following table outlines a list of accessibility shortcuts available when using email. You can access this list while composing email by pressing **Alt+0**.

|Type | Shortcut key | Description |
|----------------------|-------------------------|-----------------------------|
| General | Alt+F11 | Toggle full-screen view. |
| Tab navigation | Alt+Ctrl+0 | Go to menu bar. |
| Tab navigation | Alt+1 | Go to the rich-text editor. |
| Tab navigation | Alt+2 | Go to the HTML editor. |
| Tab navigation | Alt+3 | Go to the preview view. |
| General editor commands | Alt+F10 | Navigate to the editor toolbar. Move to the next and previous toolbar group with Tab and Shift+Tab. Move to the next and previous toolbar button with Right Arrow or Left Arrow. Press Space or Enter to activate the toolbar button. |
| General editor commands |  | Editor dialog: Inside a dialog, press Tab to navigate to the next dialog element, press Shift+Tab to move to the previous dialog element, press Enter to submit the dialog, press ESC to cancel the dialog. When a dialog has multiple tabs, the tab list can be reached either with Alt+F10 or with Tab, following the dialog tabbing order. With a tab list focused, move to the next and previous tab with Right and Left Arrow, respectively.. |
| General editor commands |  | Editor list box: Inside a list box, move to next list item with Tab or Down Arrow. Move to previous list item with Shift+Tab or Up Arrow. Press Space or Enter to select the list option. Press ESC to close the list box. |
| Base commands | Ctrl+Z | Undo command. |
| Base commands | Shift+Ctrl+Z | Redo command. |
| Base commands | Ctrl+B | Bold command. |
| Base commands | Ctrl+I | Italic command. |
| Base commands | Ctrl+U | Underline command. |
| Base commands | Alt+0 | Accessibility help. |
| Base commands | Esc | Cancel operation. |

## How to use email templates
Email templates provide multiple benefits. Using email templates saves users time and allows you to create consistent, professional, preformatted email messages you can use when communicating to customers. 

### How to insert an email template

- If you have created an email template, it can be accessed from the command bar by selecting **Insert Template**. <BR><BR>![How to insert an email template](media\email-how-to-insert-an-email-template-1a.png "How to insert an email template")

**Insert an email template overview**  

Once you select **Insert Template**, the following window appears displaying a list of existing **Email templates** that are available to use.

**Email template selection window**

![How to insert an email template](media\email-how-to-insert-an-email-template-1b.png "How to insert an email template")

Legend

1. **Language**. Templates are loaded as per the selected language.

2. **search**. You can use search to find a template. Search does not support regular expressions and only works when using the name of that specific template.  

3. **All templates**. All existing templates that have been created are displayed in this window  which you can browse and choose from.

4. **Preview**. When you select an email template, a preview of the template is displayed here. The preview shows you the content so you can pick the template that best meets your needs. After inserting an email template, you can modify the content as needed.

5. **Apply template** to insert the content to your  email.

> [!Note] 
> If you try to insert an email template on a device with a smaller screen size, you'll only see an option to search and select a template.

### How to create an email template

Email templates are a fast and easy way to send repetitive and reoccuring emails to multiple customers. You can view, create, and edit any email templates you have created.

When creating a template, you have the option to work with a blank or existing template:

- When you select **New** from the  **Email Templates** command bar a drop-down list appears with the option to **Start with a blank template** or **Start with existing templates**.

![How to create an email template](media\email-how-to-create-an-email-template-1a.png "How to create an email to a template")


### Start with a blank template option

When you **Start with a blank template** you will need to build and add all the data to the template.

The following screen appears when you **Create an email template**:

![Start with a blank template option](media\email-create-an-email-template-1a.png "Start with a blank template option")

Legend 

1. **Template name**. Assign your email template a detailed name you want to save for future use.

2. **Permission level**. You can share the template you create with your **Organization** or as  **Individual** for personal use.

3. **Category**. The default for this field is set to **User**.

4. **Language**. You can display your installed language packs in this field. **Language** also helps to categorize your templates. 

5. **Create**. Once an email is formatted, you can create it to a template.

**New customer template overview**

When you create a **New Customer Template**, the following example page displays that allows you to make edits. 

![New Customer Template](media\email-new-customer-template-1b.png "New Customer Template")

Legend 

1. **New Attachments**. Allows you to include attachements to your template. 

2. **Subject**. Allows you to change the subject line.

3. **Insert dynamic text**. Allows you to use dynamic text in both the Subject line and body of the email.

### Start with existing templates

**Start with existing templates** will automatically be populated with the pre-established meta-data from the existing template that you can customize. 

**Create a new email template overview**

The following **Create a new email template** screen appears, which allows you to customize your template

![Start with existing templates](media\email-start-with-existing-templates-1a.png "Start with existing templates")

1. **search**. Allows you to search for templates. Search does not support regular expressions and it works on the template name only.

2. **Browse**. Allows you to browse through out-of-the-box email templates. 

A list of available out-of-the-box email templates (global and entity specific) will display in alphabetical order. Global templates are shown as the type User. If you've created a custom email template, it will also be displayed here. 

3. **Details**. Allows you to preview the email template.  When you select an email template, you can preview the content so you can pick the template that best meets your needs. After inserting an email template, you can modify the template content as needed.

3. **Select**. Allows you to insert the template content into your email.

> [!Important] 
> When you begin working in the new environment, do not edit your templates in the old legacy web client; otherwise you will lose your inline images and strip out some of the advanced formatting and functionality.

### Working with existing templates

When you select an existing template, the following display appears:

![Creating email template copies](media\email-template-copy-1a.png "Creating email template copies")

- **Name**. The new template you created from the existing template will display **– Copy** at the end of the template name to identify it is a copy of an existing template.

- **Template Editor**. All of the data is carried over from the existing template which can be edited and modify.

## How to convert an email to a template
When you have composed an email that you would like to reuse with other customers, you can convert it to an email template to use in the future.

### Convert an email into a template 

When you have composed and formatted an email message that you would like to save as template, select the downward-facing caret (v) next to **Insert Template** and select **Convert to an email template** from the drop-down list.

  ![How to convert an email to a template](media\email-how-to-insert-an-email-template-1c.png "How to convert an email to a template")

**Convert an email to a template overview**  

The following window will display with a list you can customize.

  ![How to convert an email to a template](media\email-how-to-insert-an-email-template-1d.png "How to convert an email to a template")

Legend 

1. **Template name**. Assign your email template a detailed name you want to save for future use.

2. **Permission level**. You can share the template you create with your **Organization** or as  **Individual** for personal use.

3. **Category**. The default for this field is set to **User**.

4. **Language**. You can display your installed language packs in this field. **Language** also helps to categorize your templates. 

5. **Convert**. Once an email is formatted, you can convert it to an email template.

## Working with email templates

### View an email template

You can view a complete list of all the email templates you have created by: 

- Go to the **Templates** section on the left nav 
- Select **Email templates**
- A list of **All Email Templates** is displayed, which you can edit and update.

### How to insert dynamic text in an email template form

![How to insert dynamic text in an email template form](media\email-how-to-insert-dynamic-text-1a.png "How to insert dynamic text in an email template form")

Legend 

1. **Add data fields**. When you add data fields, the template adds **Record type** and **Field name** fields below. You can add as many data fields you want.

2. **Record type**. You can then customize the record types. Default is set to account.

3. **Field name**. You can customize the field names. Default is set to account name.

4. **More Commands**. The **More commands** ![More commands icon](media\timeline-more-commands-icon.png "more commands icon") icon sllows you to edit the order of the record types using the **Move Up** or **Move down** functionality to align records in a customized order.

5. **Default text**. Allows you to select the style of text for the subject and body of your email template. If no text is selected, it will display using the default text.

6. Select **Insert** to save the form.

> [!Note] 
> If you click in an area on the form that does not support dyanmic text, it displays **Unable to insert**.

For more information on creating email templates and configurations, see [Create templates for email](https://docs.microsoft.com/power-platform/admin/create-templates-email).

## How to attach a file to email

Having the ability to attach file(s) to a message is one of the most useful features of email. You can attach a file using one of the two ways:

![How to attach a file to email](media\email-how-to-attach-file-to-email-1a.png "How to attach a file to email")

1. **Attach file**. Located in the top nav bar, **Attach file** allows you to do file attachments.
2. **New Attachments**. Located above the rich text editor, the **New Attachements** ![](media\email-new-attachment-icon.png "new attachment") icon allows you to use drag-and-drop or copy-and-paste functionality. 

> [!Note] 
> Once you save your email, you can use **Attach file** and **New Attachments** interchangeably.

> [!Important] 
> The default file size limit for an email file attachment is 5MB. The size limitations on email file attachments can be increased by your system administrators. 

### Work with attachments

You can attach an unlimited number of files to an email; however, there are file size limitations that are managed by your system administrator. 

**Enhanced email** is the default email form, however you can switch forms by doing the following:

1. Under the email subject name, click on the caret (v) next to **Email**
2.	A drop-down appears with a list of email form options you can choose from.<BR><BR>
![Work with attachments](media\email-work-with-attachments-1a.png "Work with attachments")

File attachments display differently, depending on the email form you are working in. You can switch email forms without losing information.

**Email form file attachement** 

![Work with attachments](media\email-work-with-attachments-2a.png "Work with attachments")

1. **Email**. This display confirms which email form you are working in. 

2. **Attachment**. This section displays a list of file attachments in a vertical view and only displays the first three attachments.

3. **File count**. This displays when you have more files than what can be viewed and allows you to see the total number of attached files on the left side under the last attachment with the option to page over to see more images.

**Enhanced Email form file attachment** 
![Work with attachments](media\email-work-with-attachments-3b.png "Work with attachments")

1. **Enhanced Email**. This display confirms you are working in the **Enhanced email** form.

2. **Attached files**. This section displays all your email attachements in a tile view above your message horizontally. The defaulted setting for the maxiumn number of files that can display is five attachments before displaying the page forward functionality.

3. **File count**. This displays when you have files that occupy more than two rows and allows you to see the total number of attached files on the left side under the last attachment they the option to page over to see more images.

4. **Attachment Commands**. This allow you to use the select, select all, sort, delete, and download functionality when working with your file attachements.  

### Working with the attachment command bar
When you’ve attached one or more files to a message, you can manage them using the file attachment commands.  

### Select commands

The **Select** commands allow you to select individual files or multiple files at once.

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-1a.png "Working with the attachment command bar")

1. **Select All**. This commande is located on the right, above your attached files and allows you to select all file attachements at once. 

> [!Note] 
> **Select All** only selects files that are visible. If you have multiple pages of file attachments, you will need to go to that page and select those files independently.

2. **Tile Color Transparency**. The background color of selected file attachments changes to light grey to identify which files have been selected.

3. **Check box** You can also verify which files have been selected by viewing whether the checkbox in the top-right corner of the file attachment is selected. 

Formatting of file attachments in email can be realign based on the device being used and format it is being worked in.

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-2a.png "Working with the attachment command bar")

1. **Format Display** Regardless of format display, file attachments will only display the number of files that are enabled by your system administrator.

2. **Page view**. The page view displays the total number of email attachments and always is displayed under the file attachments. 

### Delete and download commands
These are two of the most important commands when working with images. 

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-3a.png "Working with the attachment command bar")

1. **Delete**. This command works with the **Select** commands. You must first select a file before you can delete it. A confirmation request appears, requiring you to confirm you want to delete the file(s) you’ve selected.

2. **Download**. This command also works with the **Select** commands and your browser download settings, allowing you to download an individual file or multiple files at once.  

### How to preview images attachments

![How to preview images attachments](media\email-how-to-preview-images-attachments-1a.png "How to preview images attachments")

1. **More options**. This command provides a list of actions for that file type.

2. **Non-preview image**. Only non-preview image types allow you to either download or delete the attached file.

3. **Preview image types**. Allow you to **preview, download,** or **delete** the attached file. When you select the **preview** option, a pop-up window appears, displaying the image with the image name listed below.


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

## How to view and insert images in email
The use of visual aids helps users convey a tremendous amount of information with just a glance. Having the ability to view and insert inline images in email using the drag-and-drop or copy-and-paste functionality is a very powerful tool for users.  

When you drag-and-drop or copy and paste the image into the email:

1.	You can adjust the image size.  

2.	When you have completed your edits, select **Save** or **Save & Close**.

> [!Note]
> There is a 1 MB file size limitation when adding an inline image to an email.

![How to view and insert images in email](media\email-how-to-view-and-insert-images-in-email-1.png "How to view and insert images in email")

## How to create a signature for emails and queues
Email signatures are an important and valuable tool for users. Email signatures are like electronic business cards you include when you send an email, and can promote professional branding for your company.  

### How to add an email signature
Adding an email signature is easy and can be done at any point while you are composing an email.

To add an email signature:

1.	On the command bar, select **Insert Signature**.
   The **Insert Signature** page is displayed.
   
2.	From the drop-down list, select an existing signature or select **New Email Signature** to create one.

![How to add an email signature](media\email-how-to-add-an-email-signature-1.png "How to add an email signature")

### How to create an email signature
You can quickly create an email signature at any point while you are composing an email.

When you select **New Email Signature**

1.	In the **Details** section, enter the name of the email signature.

2.	In the **Signature editor**, create your email signature.

3.	When you are finished, select **Save**.

![How to create an email signature](media\email-how-to-create-an-email-signature-1.png "How to create an email signature")

> [!Note] 
> You can include inline images, such as a business logo, in an email signatures, as long as they are under 1 MB in size.

### Manage email signature lists

To view the list of email signatures you have created:

1.	Under **Templates** section, select **Email signatures**.
    **My Email Signatures** displays, showing all you email signatures you can edit and update.
    
2.	Select your default signature for email. Only one signature per user can be set as **Is Default**.

    Email signatures can only be **Viewable By** the user.

![Manage email signature lists](media\email-manage-email-signature-lists-1.png "Manage email signature lists")

### Change email signature default setting
While you can create multiple email signatures depending on you needs, only one can be set as your default email.   

To change your default email signature setting:
1.	Select the email signature you want to set as default. This will change the command bar to display **Edit**.

2.	Select **Edit**.
    A new page opens, where you can update the email default setting. While you are on this page, you can also delete one or multiple email signatures just by selecting them.

![Change email signature default setting](media\email-change-email-signature-default-setting-1.png "Change email signature default setting")

### See Also

[Configure email](https://go.microsoft.com/fwlink/p/?linkid=2142941)  
[Email FAQs](email-faqs.md)  
