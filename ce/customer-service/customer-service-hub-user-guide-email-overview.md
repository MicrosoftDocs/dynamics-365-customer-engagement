---
title: "Email Overview for Users | MicrosoftDocs"
description: "Email Overview for Users"
ms.date: 08/03/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
ms.reviewer: nenellim
---

# Use Email 
[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Having the ability to communicate effectively with customers can lead to increased sales and customer satisfaction. Dynamics 365 email empowers users with the ability to respond and provide timely customer interaction effortlessly through quick email access with enhanced features and functionality. Users can compose, reply, and review emails, as well as quickly attach and send images that add value and support to customer communication using streamlined functionality. You can also ensure interactions between users and customers are consistent and professional by using email templates with rich text and images. 

The following is an overview of email features and functionality that shows you: 
- [Understand the email experience](customer-service-hub-user-guide-email-overview.md.#understand-the-email-experience)
- [How to view, compose, and respond to emails](customer-service-hub-user-guide-email-overview.md#how-to-view-compose-and-respond-to-emails)
- [How to use rich text editor toolbar in email](customer-service-hub-user-guide-email-overview.md#how-to-use-the-rich-text-editor-toolbar-in-email)
- [How to use email templates](customer-service-hub-user-guide-email-overview.md#how-to-use-email-templates)
- [How to attach a file in email](customer-service-hub-user-guide-email-overview.md#how-to-attach-a-file-to-email)
- [How to view and insert images in email](customer-service-hub-user-guide-email-overview.md#how-to-view-and-insert-images-in-email) 
- [How to create a signature for emails and queues](customer-service-hub-user-guide-email-overviewmd#how-to-create-a-signature-for-emails-and-queues)

## Understand the email experience
You can work in either the **navigate-to** email or the **contextual** email experience. The difference between the navigate-to vs. contextual email experience is where the email displays on your screen. Both experiences use the same **Enhanced Email** form, which is enabled by default out-of-the-box (OOTB).

> [!Important]
> **Contextual** email is also referred to as **Enhanced** email. Please be aware there is no special functionality associated with the **Contextural / Enhanced** email experience, other than it is a pop-up experience. 

<ul>
<li><b>Navigate-to email experience</b>: always displays in a new screen. </li>
<li><b>Contextual email experience</b>: can only be intiated from the Timeline and displays email in a pop-up screen.
<ul>
<li>Allows you to move to different pages without losing email content.</li>
<li>Minimize the email window to return to the records you were working on.</li>
<li>Simultaneously view, compose, and reply to five (5) emails in pop-up windows when enabled. </li></ul></ul>

The following highlights the difference between the **navigate-to** and **contextual** email experience in the Timeline based on how you system administrator has configured your email:
1.	Click on **Create a timeline** record.

2.	Select **Email**.

3.	**Navigate-to** email will display in a new screen.

4.	**Contextual** email will display in a pop-up window on your current screen.

![Navigate to email vs contextual email experience](media\email-navigate-vs-contextual-email-1.png "Navigate to email vs contextual email experience")
![Navigate to email vs contextual email experience](media\email-navigate-vs-contextual-email-2.png "Navigate to email vs contextual email experience")

> [!Important]
> - The pop-up window only opens when the height and width of your screen size is at least 400 x 650 pixels or greater. If lower, **navigate-to** email will be the default experience.
> - The **Contextual** email experience is available only for in Timeline.

>[!Note]
> - If you use customized forms in email, you will still be able to see and use them. The **Enhanced Email** form showcases various email capabilities and functionality and just a standard form. 

For more information see: 
- [Enable the enhanced email experience](customer-service-hub-user-guide-email-overview.md#enable-the-enhanced-email-experience)

## How to view, compose and respond to emails
Users can view, create, and send emails faster with streamlined access that helps users compose, reply, and send emails using rich text editing and drag-and-drop attachment features and functionalities.

### How to view an email
You can view and respond to emails across your Dynamics 365 app.

For example, users can view and access emails the Customer Service hub by going to **Service**, then using the following steps:
1.	Select **Activities**.

2.	When select **All Activities** a drop-down list appears. 

3.	Select an email list you want to view.

4.	When your email list appears, select the email you want to open and view. 

![How to view an email](media\email-how-to-view-an-email-1.png "How to view an email")

![How to view an email](media\email-how-to-view-an-email-2.png "How to view an email")

### How to compose an email
Feature and functionality updates have streamlined the user’s ability to quickly create email with rich text editing capability, and drag-and-drop or copy-and-paste images to enrich customer interactions.

For example, users can create emails by going to **Service**, and then using the following steps:

1.	Select **Activities**

2.	On the command bar, when you select **Email**, it opens an email in a new window. 

![How to compose an email](media\email-how-to-compose-an-email-1.png "How to compose an email")

Use the following features and functionality to tailor emails:

1.	The name displayed in the **Form** field is automatically populated based on the user who is currently signed in.

2.	Use the ![](media\email-expand-icon.png "expand email") expand icon to maximize the screen to compose your email in a full-screen view and minimize.

3.	Use the body of the email to compose and/or reply to emails. 

4.	You can select **Insert Template** to apply an email template. <br /> 

For more information, see [Insert an email template](customer-service-hub-user-guide-email-overview.md#insert-an-email-template).

> [!Note]
> The **To** box must contain a recipient to select a template.

5.	Use the rich text editor to format emails. The editor is displayed as a single line that can be expanded to view the full list of editing features by default. <br />
  For more information, see [Editor functionality and accessibility shortcuts](customer-service-hub-user-guide-email-overview.md#editor-functionality-and-accessibility-shortcuts). 
  
6.	Add ![](media\email-new-attachment-icon.png "email attachment icon") **New Attachments** using the drag-and-drop or copy-and-paste functionality. 

7.	Use **Attach file** to add a file to your email.<br />

> [!Note] 
> Once you save your email, you can use Attach file and New Attachments interchangeably.

8.	Use **Insert Signature** to personalize your message.  

9.	Select ![](media\email-send-icon.png "Send email icon")  **Send** when you are done.

![How to compose and email](media\email-compose-email-1.png "How to compose and email")

>[!Important]
> - The **From** and **To** fields are automatically populated based on the user and the account and contact of the original record.
 
For more information on enhanced email and configurations, see [Enable the enhanced email experience](customer-service-hub-user-guide-email-overview.md#enable-the-enhanced-email-experience).

### How to respond to an email
Depending where you are in your app, how you reply to an email will function differently. An example from the Customer Service hub is provide below.

- **Compsing an email in activities and cases**
When your system administrator has email enabled, the email option will appear on the global navigation and in the activities command bar. When composing an email in entities from **Activities**, you must set the reply field.  

Use the following to access email in entities:

1.	On the **Global Navigation** bar, select the [](media\email-plus-icon.png "email icon") plus icon.

2.	From the drop-down list, select **Activities** then **email**. 

3.	You can also select **Email** from the top nav.

>[!Note]
> Email option will only appear in the drop-down and top nav when enabled by your system administrator.

![How to respond to an email](media\email-how-to-respond-to-an-email-1.png "How to respond to an email")

### Responding to emails in timeline
When replying to emails in Timeline, the command bar in the top-right corner provides you with reply options. When you select an option, your email automatically is set and opens in that state ready for you to begin your message.  

Use the following command options when working with emails in Timeline:

 - **Reply**

 -	**Reply All**
 
 -	**Forward** 

![Respond to emails in timeline](media\email-respond-in-timeline-1.png "Responding to emails in timeline") 

## How to use the rich text editor toolbar in email
The rich text editor toolbar provides features and functionality that allows you to work with rich text formats in emails to better communicate with your customers.    

### Formatting options
The following table provides a detailed overview of the different formatting features and functionality options available in the rich text editor that you can when using email:

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

>[!Note]
> You can access your browser's context menu by pressing **Ctrl** + right-click. This is useful if you need to use your browser's built-in spell checker. Otherwise, you can use the right-click to provide contextual formatting for any element you might be using.

## Accessiblity shortcuts

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
Email templates provide multiple benefits. Using email templates save users time and allows you to create consistent professional preformatted email messages agents can quickly use when communicating to customers. 

### How to insert an email template
Use the normal insert template when you have an email template created that you want to use. 

You can insert the normal insert template while composing an email by:

1.	Selecting **Insert Template** on the command bar.

   A list of available **Email templates** will display in a window displaying existing templates. 
   
2.	You can see templates of a particular language by selecting a language from the **Language** list. To see templates of a different locale, select a language from the **Language** list. The templates are loaded as per the selected language.

3.	You can either **search** for a template or browse through the list and select it. The search does not support regular expressions and it works on the template name only.  

4.	When you select an email template, a preview is displayed on the right side of the window. The preview shows you the content so you can pick the template that best meets your needs. After inserting an email template, you can modify the content as needed.

5.	Select **Apply template** to insert the content in the email.

> [!Note] 
> If you try to insert an email template on a device with a smaller screen size, you'll only see an option to search and select a template.

![How to insert an email template](media\email-how-to-insert-an-email-template-1.png "How to insert an email template")

### How to convert an email to a template
When you have composed an email that you would like to reuse with other customers, you can convert it to an email template to use in the future.

When you have the message composed as you want it, then:

1.	Select the downward-facing caret (V) next to **Insert Template**.

2.	A drop-down list will appear, select **Convert to an email template**.

    A window will display with a list you can customize.

3.	Enter the **Template name** you want to save your new template as.

4.	Enter a **Permission level** to share with the **Organization** or just use as an **Individual**.

5.	Select a **Category** type. The default is set to **User**.

6.	**Language** displays your installed language packs. **Language** helps to categorize your templates. 

7.	Select **Connect** when you are finished.

![How to convert an email to a template](media\email-how-to-convert-an-email-to-a-template-1.png "How to convert an email to a template")

### How to create an email template
Email templates are a fast and easy way to send repetitive emails to multiple customers. You can view, create, and edit any email template you have created.

When creating a template, you have the option to work with a blank or existing template:

1.	From the **Email Templates** command bar at the top, select **New**.

2.	A drop-down appears with the choice to select either **Start with a blank template** or **Start with existing templates**.

![How to create an email template](media\email-how-to-create-an-email-template-1.png "How to create an email to a template")

### Start with existing templates
If you select to **Start with existing templates**, it will automatically be populated with the pre-established meta-data from the existing template that you can customize. 

When the **Create a new email template** screen appears:

1.	You can either **search** for a template or browse through the list and select it. The search does not support regular expressions and it works on the template name only.

  A list of available **Email templates** will display in a window that displays a list of all out-of-the-box email templates (global and entity specific), in alphabetical order. Global templates are shown as the type User. If you've created a custom email template, it will also be available here. 

2.	When you select an email template, a **Details** field that provides a preview on the right side of the window. The preview shows you the content so you can pick the template that best meets your needs. After inserting an email template, you can modify the content as needed.

3.	**Select** to apply template to insert the content in the email.

> [!Important]
> As you begin working in the new environment, do not edit your templates in the old legacy web client; otherwise you will lose your inline images and strip some of the advanced formatting and functionality.

![Start with existing templates](media\email-start-with-existing-templates-1.png "Start with existing templates")

When you have selected an existing template, it will display as follows:

-The new template you created from the existing template will display with a **– Copy** at the end of the template name to identify it is a copy of an existing template.

- All of the data has been carried over, which you can edit and modify.

![Creating email template copies](media\email-template-copy-1.png "Creating email template copies")

### Start with a blank template option

If you select to **Start with a blank template** you will need to build and add all the data to the template.

When the **Create an email template** screen appears:

1.	Enter the **Template name** you want to save your new template as.

2.	Enter a **Permission level** to share with the **Organization** or just use as an **Individual**.

3.	Select a **Category type**. The default is set to **User**.

4.	**Language** displays your installed language packs. **Language** helps to categorize your templates. 

5.	When you are finished, select **Create**.

![Start with a blank template option](media\email-create-an-email-template-1.png "Start with a blank template option")

When you create a **New Customer Template**, it displays in a page that allows you to make edits, such as: 

- Add a **Subject** field.

- Add **New Attachments** if you would like to include files.

- **Insert dynamic text** both for the Subject line and body of the email.

![New Customer Template](media\email-new-customer-template-1.png "New Customer Template")

## Working with email templates

### View an email templates
You can see a complete list of all the email templates you created.  

To view your email signatures:

1.	Under the **Templates** section, select **Email templates**.

2.	**All Email Templates** is displayed, which allows you to edit and update.

![Working with email templates](media\email-view-an-email-templates-1.png "Working with email templates")

### How to insert dynamic text in an email template form

1.	When you **Add data fields**, it adds **Record type** and **Field name** fields below. You can add as many data fields you want.

2.	You can then customize the **Record type**. 

3.	You can customize the **Field name**.

4.	**Set Default** text for the subject and body. If no text is selected, it will display using the default text.

5.	The **More Commands** ![](media\timeline-more-commands-icon.png "more commands icon") icon allows you to edit the order of the record types.

6.	Use the **Move Up** or **Move down** to align reocords in a cutomize order.

7.	Select **Insert** to save the form.

> [!Note] 
> If you click in an area on the form that does not support dyanmic text, it displays **Unable to insert**.

![How to insert dynamic text in an email template form](media\email-how-to-insert-dynamic-text-1.png "How to insert dynamic text in an email template form")

For more information on creating email templates and configurations, see [Create templates for email](https://docs.microsoft.com/power-platform/admin/create-templates-email).

## How to attach a file to email
Having the ability to attach file(s) to a message is one of the most useful features of email. 

You can attach a file using one of the two options:

-	Use **Attach file** to add a file to your email.

-	Add ![](media\email-new-attachment-icon.png "new attachment") **New Attachments** using the drag-and-drop or copy-and-paste functionality. 

> [!Note] 
> When you save your email, you can use **Attach file** and **New Attachments** interchangeably.

> [!Important] 
> The default file size limit for an email file attachment is 5 MB. The size limitations on email file attachments can be increased by your system administrators. 

![How to attach a file to email](media\email-how-to-attach-file-to-email-1.png "How to attach a file to email")

### Work with attachments
You can attach an unlimited number of files to an email; however, there are file size limitations that are managed by your system administrator. 

The **Enhanced Email** is the default form; however, you can easily switch forms by doing the following:

1.	In your email, just under the email subject name, click on the caret next to **Email** (V).
2.	A drop-down appears with a list of email form options you can choose from.

![Work with attachments](media\email-work-with-attachments-1.png "Work with attachments")

File attachments display differently, depending on the email form you are working in. You can switch email forms without losing information.

The **Email form** is displayed as follows:

-	The display confirms which email form you are working in. 

-	The **Attachment** section displays a list of file attachments in a vertical view and only displays the first three attachments.

-	**File count** displays when you have more files than what can be viewed and allows you to see the total number of attached files on the left side under the last attachment with the option to page over to see more images.

![Work with attachments](media\email-work-with-attachments-2.png "Work with attachments")

**Enhanced Email form** file attachment view is laid out as follows:

-	**Enhanced Email** confirms you are working out of the **Enhanced Email** form.

-	**Attached files** are displayed in a tile view above your message horizontally. The defaulted setting displays five file attachments before displaying the page forward functionality.

-	**File count** displays when you have files that occupy more than two rows and allows you to see the total number of attached files on the left side under the last attachment they the option to page over to see more images.

-	**Attachment Commands** allow you to select, select all, sort, delete, and download.

![Work with attachments](media\email-work-with-attachments-3.png "Work with attachments")

### Working with the attachment command bar
When you’ve attached one or more files to a message, you can manage them using the file attachment commands.  

### Select commands

The **Select** command allows you select individual files or streamline efforts by allowing you select multiple files at once.

-	**Select All command** is located on the right, above your attached files.

-	When you use **Select All**, it highlights all of the selected files.

-	You can verify which files have been selected by viewing whether the checkbox in the top-right corner of the file attachment is selected. 

> [!Note] 
> **Select All** only selects the files that are visible. If you have multiple pages of file attachments, you will need to go to that page and select those files independently.     

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-1.png "Working with the attachment command bar")

Formatting of file attachments in email can realign based on the device it’s being viewed on and the format it is being worked in.

- Regardless of format display, file attachments will only display the number of files that are enabled by your system administrator.

=	Page view functionality that provides the total number of email attachments will always display under the files. 

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-2.png "Working with the attachment command bar")

#### Delete and download commands
These are two of the most important commands when working with images. 

-	The **Delete** command works with the **Select** commands. You must first select a file before you can delete it. A confirmation request appears, requiring you to confirm whether you want to delete the file(s) you’ve selected.
-	The **Download** command also works with the **Select** commands and your browser download settings, allowing you to download an individual file or multiple files at once.  

![Working with the attachment command bar](media\email-working-with-the-attachment-command-bar-3.png "Working with the attachment command bar")

### How to preview images attachments

Use the following commands to preview attached images:

-	**More options** command provides a list of actions for that file type.

-	**Non-preview image** types only allow you to either download or delete the attached file.

-	**Preview image types** allow you to **preview, download,** or **delete** the attached file. When you select the **preview** option, a pop-up window appears, displaying the image with the image name listed below.

![How to preview images attachments](media\email-how-to-preview-images-attachments-1.png "How to preview images attachments")

### Supported email file attachments
The following is a lit of file image types that are supported:

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

[Email FAQs](email-faqs.md)
