---
title: "Timeline Overview for Users | MicrosoftDocs"
description: "Timeline Overview for Users"
ms.date: 07/27/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Use Timeline

Timeline is a control that allows you to view different activity types that are connected to an entity record and occur over time in a single stream. Some activities that can be logged in the timeline are notes, phone calls, emails, appointments, and tasks.

Timeline allows you to:

- Quickly access on the command bar to perform common actions with ease.
- Filter and view your important activities using multiple filter options.
- View and manage email conversation threads with ease.

## How to use timeline functionality

The following is an overview of how the timeline functionality works in each section on the entity form. The timeline section on the entity form is rich in features and functionality to help you navigate and streamline efforts.

The icons displayed in the top right nav in the Timeline give quick access to the following capabilities, when enabled by your system administrator:

- [Create a timeline record](#create-a-timeline-record)
- [Work with Filters](#work-with-filters)
- [Work with Records](#work-with-records)
- [Explore more commands](#more-commands)
- [Search Records](#search-records-on-timeline)
- [Add attachments](#add-an-attachment-to-a-note-in-timeline) 

## Create a timeline record

When enabled by your system administrator, the **Create a timeline record** ![](media\timeline-create-a-record-icon.png "Create a timeline record") icon allows you to quickly create appointments, send emails, and make notes and posts and associate them with other records. You can select the plus icon to view the options that are available for use.

 > [!div class="mx-imgBorder"]
 > ![Create a timeline record](media\timeline-create-a-timeline-record.png "Create a timeline record")

For information on timeline record configuration, see:
- [How to configure activity record types](customer-service-hub-user-guide-timeline-admin.md#how-to-configure-activity-record-types)
- [Enable the ability to create directly from timeline](customer-service-hub-user-guide-timeline-admin.md#enable-the-ability-to-create-directly-from-timeline)

## Work with filters

When enabled by your system administrator, the timeline **Filter** further streamlines your productivity by allowing you to customize your experience and view data relevant to you. 

- **1:** The ![](media\timeline-filter-icon.png "Filter") icon allows you to **Filter**.
- **2:** A list of items that is enabled by your system administrator is displayed that you can filter.  

    ![Timeline filter functionality](media\timeline-filter-1.png "Timeline filter functionality")

For more information on timeline filter functionality and configurations see:
- [Enable filter pane](customer-service-hub-user-guide-timeline-admin.md#enable-filter-pane) 
- [How to filter activity types on timeline]() 

## Work with records

When working with records, you have key information at-a-glance, can view more by expanding records, and when you hover over a record, you have actions you can use.

### Expand all records

 When enabled by your system administrator, you can view timeline records at-a-glance in a collapsed format or expand a record to see more details for ease of use.

- **1:** When you select the ![](media\timeline-expand-icon.png "Expand all records") icon, it expands all records listed on your timeline.
- **2:** When the caret is in the upright position (^) in the bottom right corner, the record is displayed in the expanded view and a list of commands appear in the top right corner. Also, when you hover over an activity you want to view, the background turns grey.  When you hover away from the record, the background becomes transparent again.
- **3:** When the caret is in the down position (˅), the record is collapsed.

    ![Expand all records functionality](media\timeline-expand-all-records-1.png "Expand all records functionality")

For more information on expanding record functionality and configuration, see:
- [Expand all records in timeline](customer-service-hub-user-guide-timeline-admin.md#expand-all-records-in-timeline)
- [Expand records with images in timeline](customer-service-hub-user-guide-timeline-admin.md#expand-records-with-images-in-timeline)

## More Commands

The **More commands** icon contains refresh, sort, and email functionalities.

- **1:** When you select the **More commands** (![](media\timeline-more-commands.icon.png "More commands")) icon, the additional options are displayed.
- **2:** The **Refresh timeline** command allows you to update the details in the timeline.
- **3:** The **Sort newer to older** / **Sort older to newer** command allows you sort records.
- **4:** The **Always show email as conversations / Always show email as individual messages** command enables or disables threaded emails.

    ![More commands timeline functionality](media\timeline-more-commands.png "More commands timeline functionality")

For information on using the **More commands** feature and configuration, see:
- [Quick entry record type and sort order default](customer-service-hub-user-guide-timeline-admin.md#quick-entry-record-type-and-sort-order-default)
- Threaded email views in timeline

## Threaded email views in timeline

To save valuable space, emails with multiple replies are consolidated into email threads and collapsed.

- **1:** Emails with multiple responses are grouped into threaded emails.
- **2:** To view the complete string of email responses, you can select **Show more** in the bottom left corner of the last visible email in the thread.
- **3:** When expanded, the most recent 10 email responses in the thread will display.  To display more, select **Show more** to expand the view again.
- **4:** Emails in the same thread are displayed as linked together.

![Timeline threaded email view functionality](media\timeline-threaded-email-views-1.png "Timeline threaded email view functionality")

### Enable threaded email views in timeline

Enabling the threaded email view is done via the timeline configuration in Power Apps. Threaded email views must be done in this setting for each specific timeline, for the specific form, for the specific entity.

You can use any of the following options for enabling threaded email views in timeline:

**Option 1:** 
1. Select the ![](media\timeline-more-commands.icon.png "More commands") **More commands** icon on the timeline, which will display a flyout menu.
2. Select **Always show email as conversations**. Now your emails will display in timeline threaded together.

![Enable threaded email timeline view - option 1](media\timeline-threaded-email-views-2.png "Enable threaded email timeline view - option 1")

**Option 2:**
1. On the command bar, select **Settings** > **Personalization Settings**. The **Set Personal Options** dialog box appears.
4. Select the **Email** tab.
5. Select the **Show emails as conversation on Timeline** check box.
6. Select **OK**.

    > ![Enable threaded email timeline view - option 2](media\timeline-threaded-email-views-3.png "Enable threaded email timeline view - option 2")

>[!Note]
> The **emails as conversation view** is based on the user's preference. Personal setting are tied to the user and not the form, which means once you enable the threaded email view, the setting is applied to all your timeline views. 

## Search records on timeline

When enabled by your system administrator, you can easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title or subject of the record or body or description fields of the record and displays the record for you.

- **1:** Use the **Search** bar on timeline to quickly find records.
- **2:** When you enter keywords or phrases, the search feature will retrieve and display results below the search bar.
- **3:** The keywords that you use to perform your search will be highlighted.

![Enable threaded email timeline view - option 2](media\timeline-search-records-1.png "Enable threaded email timeline view - option 2")

For more information, see, [Enable search bar](customer-service-hub-user-guide-timeline-admin.md#enable-search-bar).

## Work with notes and posts

Notes allows you to record richly formatted information and images for reference, summary, or investigation. You can easily add a mention to another user or a reference to a timeline record using Posts.  

### Add a note or post to a record on timeline

You can either add a **Note** or a **Post** to a record on timeline only if your system administrator has enabled the features.

1.	You can enter a **Note** to add to a record. If your system administrator does not have **Notes** enabled, you cannot add an attachment. Also, you can only add one attachment per note.
2.	You can enter a **Post** to add to a record.

![Add a note or post to a record on timeline](media\timeline-add-a-note-or-post-to-a-record.png "Add a note or post to a record on timeline")

### Access command bar to perform actions

When you hover the cursor on or expand an activity, post, and note, the command bar appears with the options specific to the activity, such as marking an activity complete, assigning it to others, adding it to a queue, converting it to a case, liking a post, replying to a post, editing a note, or deleting the activity.

The following is an overview of the command bar icons and the actions they support: 

|Icon | Name | Description |
|-----|------|-------------|
| ![](media\email-assign-icon.png "Assign icon") |Assign | Lets you assign a task.|
| ![](media\email-close-activity-icon.png "Close activity icon")|Close Activity| Lets you close the activity record.|
| ![](media\email-add-to-queue-icon.png "Add to queue icon") |Add to Queue| Lets you add a task to a queue.|
| ![](media\email-open-record-icon.png "Open record icon")|Open Record| Lets you open a record.|
| ![](media\email-delete-icon.png "Delete icon")|Delete| Lets you delete the record.|
| ![](media\email-reply-icon.png "Reply icon")|Reply| Lets you reply to an email. **Note**: This command is only available for Email.|
| ![](media\email-reply-all-icon.png "Replay all icon")|Reply All| Lets you reply to all for an email. **Note**: This command is only available on Email.|
| ![](media\email-forward-icon.png "Forward icon ")|Forward|Lets you forward an email. **Note**: This command is only available on Email.|
| ![](media\email-like-a-post-icon.png "Like a post icon")|Like this post| Lets you like a post. **Note**: This command is only available on Posts.|
| ![](media\email-edit-icon.png "Edit icon")|Edit this note|Lets you edit a note. **Note**: This command is only available on Notes.|

Not all records can perform the same actions:
1. Each record has a different set of actions associated with it. 
2. Only the actions associated with that record are displayed in the command bar.  

![Command bar actions in timeline](media\timeline-access-command-bar-actions-1.png "Command bar actions")

## Work with notes

The message box has a rich text editor that enables you to use rich text and create well-formatted content.

1. Enter a **Title**.
2. Use the rich text editor to format and structure your messages.
3. Expand the rich text editing tool to access the full menu of formatting features.
4. Use the paperclip to attach files to your note.
5. View and confirm file has been attached to your note.
6. Select **Add note** to save.

![Timeline notes rich text editor](media\timeline-take-a-note.png "Timeline notes rich text editor")

> [!NOTE]
> - Only **Notes** have rich text capability, and it is only available in the timeline. 
> - You can only format the message body of a note, not the title.
> - The rich text editor is available only for Unified Interface.
> - If you create a rich text editor note in Unified Interface and then view the note in the Web Client, it will display in HTML syntax.

For more information on the rich text editor feature, the following is a list of functionality:
  
|Icon | Name | Shortcut key | Description |
|----------------------|-------------------------|-----------------------------|-----------------------------|
|![Format Painter](../customer-service/media/format-painter.png "Format Painter")| Format Painter | Ctrl+Shift+C, Ctrl+Shift+V | Apply the look of a particular section to another section. |
|![Font](../customer-service/media/format-font.png "Font") | Font | Ctrl+Shift+F | Select a font of your choice. The default font is Segoe UI.<br /><br /> **Note**: When you select any formatted content, the font name for that content displays. If your selection contains multiple fonts, the topmost font name of your selection is displayed. |
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
|![Align Right](../customer-service/media/align-right.png "Align Right")| Align Right | Ctrl+R | Align  content to the right on the page. (Commonly used for a formal appearance.) |
|![Link](../customer-service/media/format-link.png "Link")| Link |  | Create a link in your document for quick access to web pages and files.<br /><br />Pasted or typed URL text is converted into a link. For example, "http://myexample.com" will become "<a href="http://myexample.com">http://myexample.com</a>".<br /><br /> In the **Link** dialog box, choose the type of link you'd like to insert.<br /><br />The **Link Info** tab allows you to choose the link type as well as set the link protocol and URL.<br /><br />The **Target** tab is only available for the URL link type. It specifies the location where the link will open after you select it. |
|![Remove Link](../customer-service/media/remove-link.png "Unlink")| Unlink |  | Delete a link in your email or document.<br /><br />When you place the cursor on a link, the **Unlink** button on the toolbar becomes active. Select the button to remove the link and make it plain text. |
|![Superscript](../customer-service/media/format-superscript.png "Superscript")| Superscript |  | Type small letters just above the line of text. |
|![Subscript](../customer-service/media/format-subscript.png "Subscript")| Subscript |  | Type  small letters just below the line of text. |
|![Strikethrough](../customer-service/media/format-strikethrough.png "Strikethrough")| Strikethrough |  | Cross out text by drawing a line through it. |
|![Insert Image](media\insert-picture.png "Insert Image")| Insert Image|	|You can insert an image by directly copying and pasting it inline in the editor, dragging and dropping it from your desktop or local folder directly into the editor, or by typing a URL. The following formats are supported: .PNG, .JPG., or .GIF.<br /><br />To insert an image inline in your article: <br />1. Drag and drop the image or copy and paste it directly into the article. <br />2. Drag any corner of the image to resize it.<br /><br />To insert an image using a URL or navigating to the local image:<br />1. Choose Insert Image.<br />2. In the **Image** property dialog, choose from the following options:<br /><ul><li>Select **Browse** to navigate to the image on your computer.</li><li>Or specify the web address of the image, and properties to define how the image will appear in the email or article.</li><br />**Note:**<ul><li>If the image is located on the external server, use the full absolute path. </li><li>If the image is located on a local server, you can use a relative path. </li><li>If you want the image to be linked to a target, add a URL for the image.</li><li>You can also specify if you want the targeted page to open in a new window, topmost window, same window, or parent window.</li></ul>
|![Left to Right](../customer-service/media/left-to-right.png "Left to Right")| Left to Right |  | Change the text to left-to-right for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. This is the default setting.|
|![Right to Left](../customer-service/media/right-to-left.png "Right to Left")| Right to Left |  | Change the text to right-to-left for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. The default setting is left-to-right. |
|![Undo Typing](../customer-service/media/undo-typing.png "Undo Typing")| Undo Typing |  | Undo changes you made to the content. |
|![Redo Typing](../customer-service/media/redo-typing.png "Redo Typing")| Redo Typing |  | Redo changes you made to the content. |
|![Clear All Formatting](../customer-service/media/clear-formatting.png "Clear All Formatting")| Clear All Formatting |  | Remove all formatting from a selection of text, leaving only the normal, unformatted text. |
|![Add a Table](../customer-service/media/add-table.png "Add a Table")| Add a Table |  | Add a table to your content. <br /><br />After adding a table, you can do any of the following:<br /><ul><li>Resize table columns by clicking and dragging your mouse to resize to the columns to the desired width.</li><li>Select one or several cells within a table and apply specific formatting, add links to the selection, or cut, copy, or paste entire rows or columns.</li><li>Right-click to access the properties. This supports features such as cell type, width and height, word wrapping, alignment, merging and splitting cells horizontally and vertically, inserting or deleting rows and columns, row and column span, and cell and border color.</li></ul>|
|![Expand Toolbar](../customer-service/media/show-more.png "Expand Toolbar")| Expand Toolbar |  | Appears when the toolbar is collapsed. Click to expand the toolbar and make all options visible. |

The rich text editor is enabled by default. Your system administrator can enable or disable the editor for you. For more information, see [Enable rich-text editor for notes in timeline](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-or-disable-rich-text-editor-for-notes-in-timeline "Enable rich-text editor for notes in timeline").

## Work with posts

### Add a mention or reference to a team member in a post on timeline

To add a mention or to reference a team member in a **Post**, use the following steps:

1.	In the box that appears, type @ sign. When you type @, a flyout menu opens with a list of users you’ve recently used.
2.	You can select one of the user records, or start typing the keyword. When you start typing, the records in the flyout menu are refreshed to match the keyword. In the background, the **Dynamics 365 Quick Find** search is in use.
3.	If you don’t find a record, you can switch to different views. To do this, select **Advanced**. The **Lookup Records** pane opens.
4.	In the **Lookup Records** pane, you can switch between the **Recent records** and **All records** view to find a record.

> [!NOTE]
> You can mention only a system user in a post.

![Add a mention or reference to a team member in a post on timeline](media\timeline-add-a-mention-to-team-member-in-a-post-1.png "Add a mention or reference to a team member in a post on timeline")

### Add references in a post to timeline records

To add a reference to a timeline record in a **Post**, use the following steps:

1.	In the **timeline** section, select the ![](media\timeline-create-a-record-icon.png "Create a timeline record")  icon
2.	Select **Post**.
3.	To add a link, type **#** in the box that appears.  
4.	When you type #, a flyout menu opens with a list of records that you have recently accessed. These records could be of any record type, such as accounts, contacts or leads.
5.	You can select one of the records or start typing the keyword. When you start typing, the records in the flyout menu are refreshed to match the keyword. In this case, too, the search happens using the **Dynamics 365 Quick Find** search. The icons beside the record names in the flyout menu indicate the record types, which help you determine the record to select.  
6.	If you don’t find a record, you can either switch to different views or create a new record. To do this, select **Advanced**. The **Lookup Records** pane opens.
7.	In the **Lookup Records** pane, switch between the **Recent records** and **All records view** to find a record.  
8.	Select **Change View** to find to see records from a different view. For example, if you want to find one of your open opportunities, select **Change View** > **Opportunities** > **My Open Opportunities**. The records in the **Lookup Records** pane will be refreshed to show only the open opportunities you own.  
9.	If you don’t find a record you are looking for, select **New Record** to create a record.

![Add references to timeline records](media\timeline-add-links-to-records-1.png "Add references to timeline records")

For more information on Notes and Post functionality and configuration, see:
- [Record types shown](customer-service-hub-user-guide-timeline-admin.md#record-types-shown)
- [Quick entry record type](customer-service-hub-user-guide-timeline-admin.md#quick-entry-record-type-and-sort-order-default) 
- [Record Settings](customer-service-hub-user-guide-timeline-admin.md#record-settings) 
- [Notes on timeline](customer-service-hub-user-guide-timeline-admin.md#notes-on-timeline)

## Add an attachment to a note in timeline

You can add an attachment, such as a file, to a note in timeline to share with users.

> [!NOTE]
> Your system administrator must first enable notes for you to add an attachment.

1. Select the ![](media\timelilne-paperclip-icon.png "paperclip icon") paperclip icon to attach a file to a note. You can only add an attachment to a note that is attached to a record. 
2. Select the file you want to attach. You can only add one file per note.

   The Edit note screen will appear, and your attachment will be displayed at the bottom of the Edit note screen.
   
3. Select **Add note** to save and close the Edit note screen.

![Add an attachment to a note in timeline](media\timeline-add-an-attachment-to-a-note.png "Add an attachment to a note in timeline")


### See Also

[Timeline FAQs](timeline-faqs.md)  
