---
title: "Timeline Overview | Microsoft Docs"
description: "Timeline Overivew"
ms.date: 07/23/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Introduction to Timeline 

Timeline shows you information such as accounts or cases, arranged in a single stream. Managing activities in the timeline is faster and provides quick data viewability allowing you to see a combined view of customer's interactions across various channels, such as phone, email, even social activities. Create and view notes and posts connected to an entity record. Timeline control makes displaying information easy and efficient.

Timeline allows you to:
- Identify key activities with simple icons.
- Quick access on the command bar to perform common actions with ease.
- Filter and view activities important to you using multiple filter options.
- View and manage email conversation threads with ease.
- Expand and collapse activities effortlessly.

## How to use timeline functionality 

Before going into the timeline configuration, it is best to have an overview of the timeline functionality.  The following is an overview of how the timeline functionality works in each section on the entity form.  The timeline section on the entity form is rich in features and functionality to help you navigate and streamline efforts. 

Timeline iconography is displayed in the top right nav in the timeline:

- [Create a timeline record](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#create-a-timeline-record)
- [Working with Filters](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#filter)
- [Working with Records](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#expand-all-records)
- [More Commands](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#more-commands)
- [Search Records](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#search-records-on-timeline)
- [Attachments](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#add-an-attachment-to-a-note-in-timeline) 
- [Working with Posts and Notes](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#add-a-note-or-post-to-a-record-on-timeline)

## Create a timeline record
The Create a timeline record allows you to quickly create appointments, send emails, even make notes and posts and associate them to other records. 

1.	The **Create a timeline record** icon when expanded provides a shortcut for creating a variety of records.
2.	When you click on **Create a timeline record**, it displays a pop-up listing all the record types you enabled in the **Activities record settings**.

    ![Create a timeline record](media\timeline-create-a-timeline-record-1.png "Create a timeline record")

For information on timeline record functionality and configuration, see:
- [How to configure activity record types]()
- [Enable the ability to create directly from timeline]()

## Working with filters 

The timeline **Filter** further streamlines your productivity by allowing you to customize your experience and view on the data that is relevant to your needs. 

1. The **Filter** icon, when enabled, allows you to data filtering options for viewing data in the timeline section on the entity form. 
2. When expanded, the **Filter** allows you filter and view data in a variety of options.  

    ![Timeline filter functionality](media\timeline-filter-1.png "Timeline filter functionality")

For more information on timeline filter functionality and configuration see:
- [Enable filter pane](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#enable-filter-pane) 
- [How to filter activity types on timeline]() 

## Working with records
When working with records you have key information at a glance and view more by expanding records, and when you hover over a record you have actions you can use.

### Expand all records

You can view at a glance timeline records in a collapsed format or expand a record to see more details for ease of use.

1.	All records listed on the form are displayed with a transparent white background. However, when you hover over an activity that you want to view, the background for that specific item turns grey.  Once you leave that record, the background becomes transparent again.
2.	When the caret in the bottom right corner of the record is in the upright position (^) it is in the expanded view. When an record is in the expanded view it will display a list of commands in the top right corner. 
3.	When the caret is in the down position (˅) the record is collapsed.

    ![Expand all records functionality](media\timeline-expand-all-records-1.png "Expand all records functionality")

For more information on how to expand record functionality and configuration see:
- [Expand all records in timeline]()
- [Expand records with images in timeline]()

## More Commands

The more commands icon houses refresh, sort, and email functionality.

1. Click on the **More commands** icon ( ) on the timeline which will display a pop-out.
2.	**Refresh timeline** allows you to update the details in the timeline.
3.	**Sort newer to older** / **Sort older to newer** allows you sort records.
4.	**Always show email as conversations / Always show email as individual messages** enables or disables treaded emails. 

    ![More commands timeline functionality](media\timeline-more-commands.png "More commands timeline functionality")

For more information on using the more command functionality and configuration see:
- [Quick entry record type and sort order default]()
- [Enable threaded email views in timeline]()

## Threaded email views in timeline

To save valuable space, emails with multiple replies are consolidated into email treads and collapsed.

<ol type="a">
<li>Emails with multiple responses are grouped into treaded emails.</li>
<li>To view the complete string of email responses, click on show more in the bottom left corner of the last visible email in the tread.</li>
<li>When expanded, that last 10 most recent email responses in the tread will display.  To display more, click show more to expand view again.</li>
<li>Emails that are tied together in the same thread display a linking line to one another.</li>
</ol>

![Timeline threaded email view functionality](media\timeline-threaded-email-views-1.png "Timeline threaded email view functionality")

### Enable threaded tmail views in timeline 

Enabling the threaded email view is done via the timeline configuration in Power Apps.  Threaded email views must be done in this setting for each specific timeline, for the specific form, for the specific entity. 

There are a couple of options for enabling threaded email views in timeline:

**Option 1:** 
<ol type="a">
<li>Click on the <b>More commands</b> icon on the timeline which will display a pop-out.</li>
<li>Select <b>Always show email as conversations</b>
</li>
</ol>

![Enable threaded email timeline view - option 1](media\timeline-threaded-email-views-2.png "Enable threaded email timeline view - option 1")

**Option 2:**
<ol type="a">
<li>From Power Apps, go to <b>Setting</b></li>
<li>Select <b>Personalize Settings</b></li>
<li>The Set Personal Options pop-up will appear.  Click on the <b>Email</b> tab</li>
<li>Check the box next to <b>Show emails as conversation on Timeline</b></li>
<li>Click <b>OK</b>
</li>
</ol>

![Enable threaded email timeline view - option 2](media\timeline-threaded-email-views-3.png "Enable threaded email timeline view - option 2")

## Search records on timeline

You can easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title of the record or body and description fields of the record then displays the record for you. 

1.	When enabled, you can use the **Search** bar on timeline to quickly find records
2.	When you enter keywords or phrases, the search feature will retrieve and display results below the search bar. 
3.	Keywords you used to perform your search will be highlighted.

![Enable threaded email timeline view - option 2](media\timeline-search-records-1.png "Enable threaded email timeline view - option 2")

For more information on search functionality and configuration see:
- [Enable search bar]()

## Add an attachment to a note in timeline

You can add an attachment to a note in timeline to help users when you have file to share.

1.	Click on the paperclip icon to attach a file to a note. You can only add an attachment to a note which is attached to a record. 
2. 	Select file you want to attach. You can only add one file per note.
3. 	Edit note screen will appear.
4.	Your attachment will display at the bottom of the edit note screen.
5. 	**Add note** to save and close the edit note screen.

![Add an attachment to a note in timeline](media\timeline-add-an-attachment-to-a-note.png "Add an attachment to a note in timeline")

> [!IMPORTANT]
> If you do not have Notes enabled, you can not do an attachment. Also, you can only add one (1) attachment per note.

## Working with posts and notes

You can easily add a mention to another user or a reference to a timeline record using Posts.  Notes allows you to record richly formatted information for refrence, summary, or investigation.

## Add a mention or reference to a team member in a post on timeline

To add a mention or to reference a team member in a **Post**, use the following steps:

1.	In the box that appears, type @ sign. When you type @, a flyout opens with a list of users you’ve recently used.
2.	You can select one of the user records, or start typing the keyword. When you start typing, the records in the flyout are refreshed to match the keyword. In the backend, the search happens using **Dynamics 365 Quick Find** search.
3.	If you don’t find a record, you can either switch to different views. To do this, select Advanced.  It opens the **Lookup Records** pane.
4.	In the **Lookup Records** pane, you can switch between the **Recent records** and **All records** view to find a record.  

> [!NOTE]
> You can mention only a system user in a post.

![Add a mention or reference to a team member in a post on timeline](media\timeline-add-a-mention-to-team-member-in-a-post-1.png "Add a mention or reference to a team member in a post on timeline")

## Add references in a post to timeline records 
To add a reference to a timeline record in a **Post**, use the following steps:

1.	In the **timeline** section, select the **+** icon
2.	Select **Post**.
3.	To add a link, type **#** in the box that appears.  
4.	When you type #, a flyout opens with a list of records that you have recently accessed. These records could be of any record type, such as accounts, contacts or leads.  
5.	You can select one of the record or start typing the keyword. When you start typing, the records in the flyout are refreshed to match the keyword. In this case, too, the search happens using the **Dynamics 365 Quick Find** search. The icons beside the record names in the flyout indicate the record types, which help you determine which record to select.  
6.	If you don’t find a record, you can either switch to different views or create a new record. To do this, select **Advanced**.  It opens the **Lookup Records** pane.
7.	In the **Lookup Records** pane, switch between the **Recent records** and **All records view** to find a record.  
8.	Select **Change View** to find to see records from a different view. For example, if you want to find one of your open opportunities, select **Change View** > **Opportunities** > **My Open Opportunities**. The records in the **Lookup Records** pane will be refreshed to show only the open opportunities you own.  
9.	If you don’t find a record you are looking for, select **New Record** to create a record.

![Add references to timeline records](media\timeline-add-links-to-records-1.png "Add references to timeline records")


## Add a note or post to a record on timeline

You can either add a **Note** or a **Post** to a record on timeline if you enable the features. 

1.	You can enter a **Note** to add to a record. If you do not have **Notes** enabled, you cannot do an attachment. Also, you can only add one (1) attachment per note.
2.	You can enter a **Post** to add to a record.

![Add a note or post to a record on timeline](media\timeline-add-a-note-or-post-to-a-record.png "Add a note or post to a record on timeline")

The message box has a rich text editor that enables you to use rich text and create well formatted content.

<!---why is this not displaying in letter formate?-->
<ol type="a">

<li>Enter a Subject in <b>Subject</b> field</li>
<li>Use the rich text editor to format and structure your messages.</li>
<li>Expand the rich text editing tool to access the full menu of formatting features.</li>
<li>Use the paperclip to attach files to your note.</li>
<li>View and confirm file has been attached to your note.</li>
<li>Click Add note to send.</li>
</ol>

![Timeline notes rich text editor](media\timeline-take-a-note.png "Timeline notes rich text editor")

<!---why is note call out not displaying?-->

> [!NOTE]
> - Only Notes have rich text capability. 
> - You can only format the message (body) of a note, not the title.
> - Rich text editor is only available for Unified Interface, not the web client.
> - If you create a rich text editor note in the Unified Interface, and then view the note in the Web Client, it will display in HTML syntax.

For more information on Notes and Post functionality and configuration see:
- [Record types shown]() 
- [Quick entry record type]() 
- [Record Settings]() 
- [Notes on timeline]() 

For more information on the rich text editor feature, here is a listing of it's functionality:
  
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
|![Left to Right](../customer-service/media/left-to-right.png "Left to Right")| Left to Right |  | Change the text to left-to-right for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. This is the default setting.|
|![Right to Left](../customer-service/media/right-to-left.png "Right to Left")| Right to Left |  | Change the text to right-to-left for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. The default setting is left-to-right. |
|![Undo Typing](../customer-service/media/undo-typing.png "Undo Typing")| Undo Typing |  | Undo changes you made to the content. |
|![Redo Typing](../customer-service/media/redo-typing.png "Redo Typing")| Redo Typing |  | Redo changes you made to the content. |
|![Clear All Formatting](../customer-service/media/clear-formatting.png "Clear All Formatting")| Clear All Formatting |  | Remove all formatting from a selection of text, leaving only the normal, unformatted text. |
|![Add a Table](../customer-service/media/add-table.png "Add a Table")| Add a Table |  | Add a table to your content. <br /><br />After adding a table, you can do any of the following:<br /><br /><ul><li>Resize table columns by clicking and dragging your mouse to resize to the columns to the desired width.</li><li>Select one or several cells within a table and apply specific formatting, add links to the selection, or cut, copy, or paste entire rows or columns.</li><li>Right-click to access the properties. This supports features such as cell type, width and height, word wrapping, alignment, merging and splitting cells horizontally and vertically, inserting or deleting rows and columns, row and column span, and cell and border color.</li></ul>|
|![Expand Toolbar](../customer-service/media/show-more.png "Expand Toolbar")| Expand Toolbar |  | Displays when the toolbar is collapsed and not all options appear. Click to expand the toolbar and make all options visible. |

The rich text editor is enabled by default. Your   Administrator can enable or disable the editor for you. For more information, see [Enable rich-text editor for notes in timeline](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-or-disable-rich-text-editor-for-notes-in-timeline "Enable rich-text editor for notes in timeline").

## Timeline configurations 

The timeline configuration experience enables the timeline to show a customer’s history across cases, accounts, or contacts. This experience gives Administrators the ability to configure the information displayed in each timeline to help users have the best understanding of the customer’s history so they can deliver more personalized service. 

The timeline control provides an easy and immersive experience to view a customer’s history across cases, accounts, or contacts which gives users a better understanding of the customer’s history and helps them deliver more personalized service in an efficient and effective manner. 

## How to navigate to timeline configurations

Timelines are located on forms within entities.  To access timeline configurations, you must start with the entity list.  You can access the entity list a couple of ways depending on the model driven app you are using.

Important: When you are accessing timeline and are not taken to the new form designer experience, please refer to Example 2 to ensure access to the latest experience.

**Example 1:**  
To access the entity list via the **Customer Service Hub**, go to:
1.	Go to **Customer Service Hub** app
2.	Click on **Settings**
3.	Select **Advanced Settings**

![How to navigate to timeline configurations - Option 1](media\timeline-access-option-1.png "How to navigate to timeline configurations - Option 1")

**Example 2:**  
To access the entities list via **Power Apps**, go to:
1.	Go to **Power Apps** URL: [make.powerapps.com](make.powerapps.com "make.powerapps.com")
2.	Under Data section
3.	Select Entities

![How to navigate to timeline configurations - Option 2](media\timeline-access-option-2.png "How to navigate to timeline configurations - Option 2")

## Select an entity form for timeline configuration

Every instance of the timeline that’s applied on a form can be configured.  Example: An Account entity will have forms, and each form can have a timeline that can be configured.  However, there’s only one timeline per form.  

To begin, select the entity and form where you want to add and configure your timeline. 
1.	The following is a list of entities. You can add a timeline to any entity.
2.	For this example, we selected the **Account** entity.
3.	From the **Account** entity landing page there is list of tabs at the top, select **Forms**.
4.	The **Forms** landing page displays a list of **Form types**. Timelines can only be used on **Main** form types.
5.	For this example, we selected **Account for Interactive experiences**. 

![How to navigate to timeline configurations](media\timeline-configuration-1.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-2.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-3.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-4.png "How to navigate to timeline configurations")

## Adding or removing a timeline from an entity form

Timeline is a component and you will need to access **Components** to make timeline configurations. Once you have selected a **Main** form type, the following landing page will appear:

1.	From the left nav, select **Components**.  
2.    In the left nav, scroll down to the **Timeline** component, then drag and drop in a section on the form. 
3.	If **Timeline** component is greyed out, it means it already exists on the form. You can only have one timeline per form.
4.	To remove the **Timeline** component from a form, highlight the inside **Timeline** component area and hit the **Delete** key.  This will remove the **Timeline** component from the form.

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-1.png "Adding or removing a timeline from an entity form")

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-2.png "Adding or removing a timeline from an entity form")

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-3.png "Adding or removing a timeline from an entity form")

> [!Note] 
> Since the timeline component relies exclusively on underlining related data, it will always say Almost there when added to the timeline section. Since we are in a create and/or edit state on the form, there’s no underlining data, therefore the area is blank.

## Understanding the timeline component on the form

In the body of the entity form located in the center there is an area titled TIMELINE section and within that section is another area titled Timeline.  The following outlines and clarifies the different between these two:     

1.	The outside section (titled **TIMELINE**) is what houses the **Timeline** component. 
2.	When you click on the **TIMELINE** section, the **Display options** under the **Properties** tab in the right nav change to support the **TIMELINE** section.
3.	Inside the **TIMELINE** section is where the **Timeline** component is located.
4.	When you click on the **Timeline** component, the **Display options** under the **Properties** tab in the right nav change to support the **Timeline** component items.

![Understanding the timeline component on the form](media\timeline-component-1.png "Understanding the timeline component on the form")

![Understanding the timeline component on the form](media\timeline-component-2.png "Understanding the timeline component on the form")

## How to configure timeline component

The timeline component is rich in features and functionality that can be configured and tailored to support specific business needs.  The Timeline form is comprised of features and functionality you configure in the timeline component which is then displayed in the entity form.

The following overview provides a detailed breakdown of each timeline feature, what it supports, how it is configured, and how it is displayed in the corresponding timeline section on the entity form:

- Display options 
  - [Timeline component name](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#timeline-component-name)
  - [Records shown on page](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#records-shown-on-page)
  - [Record types shown](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#record-types-shown) 
  - [Advanced](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#advanced)

- Record settings 
  - [Activities](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#advanced)
  -	[Notes](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#notes)
  -	[Posts](https://docs.microsoft.com/en-us/dynamics365/customer-service/customer-service-hub-timeline-overview#posts)

- [How to create and add custom activities](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-custom-activity-in-timeline)

## Display options 

### Timeline component name

The **Name** field under the **Properties** tab in the **Display options** section is only there as Admin’s reference. 

1.	In the **Name** field, you can change Timeline to another name.
2.	For this example we changed the **Name** field to, **Bob**. 
3.	The **Name** ‘Bob’ does not display on the rendered form.  The name change is for Admin reference only. 
4.	If you use the Name feature, there are character limitations.  For example, you cannot have spaces, you must use underscores (_).

![Display options - Timeline component name](media\timeline-component-name-display-options-1.png "Display options - Timeline component name")

![Display options - Timeline component name](media\timeline-component-name-display-options-2.png "Display options - Timeline component name")

## Records shown on page

This section allows you to control the number records that appear before displaying Load more at the bottom of the section.

1.	The default setting on the Records shown on page is set to 10 records. You can update this to any number, there is no limit.
2.	Pre the default setting shown in this example, the form shows a max. of 10 records, but you can display up to 50 records.
3.	Once records exceed 10, Load more feature appears at the bottom of the form to display more records. 

![Display options - Records shown on page](media\timeline-records-shown-on-page-display-options-1.png "Display options - Records shown on page")

## Record types shown

There are three (3) primary record types which include: activities, notes, and posts.  All record types are enabled by default.

- **Activities** can have a large number of customizable sub-activity record types to support business needs. Depending on what you have installed, Admin can create, add, and display a number of different customized sub-activity record types under the Activity section of the drop-down menu on the timeline.    
- **Notes** allow you to capture notes related to the entity record. Use notes to grab thoughts, summary information, and provide feedback on a case for example and include edits whenever you want. 
- **Posts.**  There are two types of posts, Auto Posts and User Posts. 
    - **Auto Posts** are system generated and notify you of account activity that has occurred. 
    - **User Posts** allows you leave a message for another user on a record.

This section allows you to enable these record types to display in timeline. 

1.	To enable **Record types shown** for Activities, Notes, and Posts on a form simply check the box next to the record  type you want to show.
2.	To confirm the record type is displaying on the form, click on the plus icon (+) in the top right nav in timeline. 
3.	A drop down will appear and display the list of enabled record types.
4.	When you enable **Activities**, you see **Activity** record types: Applications, email, phone calls, tasks on the form.
5.	When you enable **Notes**, you see Note record types on the form.
6.	When you enable **Posts**, you see Post record types on the form.

![Display options - Record types shown](media\timeline-record-types-shown-display-options-1.png "Display options - Record types shown")

> [!Note]
> Activities, noted, and posts are standard entities. If your administrator or system customizer has configured other entities, then those will appear.

## Activity, note, post icons and date / timestamp display on timelines

The timeline shows a simple icon before the activity, post, note, and custom entity making it easy for you to identify the record type. Dates and timestamps will always appear on each record on the bottom right of the preview.

<ol type="a">
<li>Activity record icons</li>
<li>Note icons</li>
<li>Post icons</li>
<li>Date/timestamp display can be viewed at all times.</li>
</ol>

![Display options - Activity, note, post icons and date / timestamp display on timelines](media\timeline-activity-note-post-icons-and-timestamp-display-display-options-1.png "Display options - Activity, note, post icons and date / timestamp display on timelines")

## Advanced

The **Advanced** feature works across and is independent of all record types and is collapsed by default.  Also, when enabling and disabling **Advanced** features you will not be able to view updates (even though it may appear there is activity occurring on the timeline component) until you save and publish your configuration updates and refresh the entity form. 

**Advanced** covers common settings that span across an activity, note, or post, which are the three (3) primary record types that appear in the timeline section. 

### Quick entry record type and sort order default

The following is a detailed overview of the **Advanced** configuration options starting with selecting your **quick entry record type**:

1.	Click on **Advanced** to expand this feature in the configuration view.
2.	The **Quick entry record** type provides you with quick access to create either a **Note** or a **Post**.  The default setting for this feature is set to **Notes**.  
3.	When you select **Notes** it will display under the search bar in timeline. Also, you will see a paperclip icon which allows you to attach files. You can only attach files to Notes.
4.	When you select **Posts** it will display under the search bar in timeline. 
5.	The **Sort order default** feature controls the order of how all data is sorted on the timeline.  The default setting for this feature is set to Descending. 

![Display options - Advanced - Quick entry record type and sort order default](media\timeline-quick-entry-record-type-and-sort-order-default-display-settings-advanced-1.png "Display options - Advanced - Quick entry record type and sort order default")

## Enable filter pane

Using filters provides a quick option to sort and look for specific data quickly. 
 
6.	The **filter pane** feature allows you to enable or disable filter functionality on timeline. It is enabled by default.
7.	Enable the **filter pane** by checking the box next to the feature.  This will enable the filter icon to display on the timeline.
8.	To disable the **filter pane**, uncheck the box next to the feature and the filter icon will no longer appear on the timeline. 

![Display options - Advanced - Enable filter pane](media\timeline-enable-filter-pane-display-options-advanced-1.png "Display options - Advanced - Enable filter pane")

## How to filter activity types on timeline

Filters are valuable for sorting data. You can quickly filter activities, posts, and notes with multiple options to see what matters to you. The filter is available for the activities, posts, notes, and custom entities that are present in timeline. Timeline filters and displays the records and the count that are present in the timeline.

You can customize data using the data filters and either choose to keep filters in place or clear them when you are done.

<ol type="a">
<li> When the **Filter** icon is transparent on the entity form, it means there are no items that have been chosen to filter by and there the filter is unpopulated.</li>
<li> When the **Filter** icon is filled in, it means filters has been selected and set. To view what filters have been selected you can just click on the Filter icon and the display will open showing which filters have been set.</li>
<li> When you click on the **Filter** icon the following list appears.</li>
<li> You can select how you want to filter your data by checking the box next to the filter.</li>
<li> You can clear filters by clicking on the **Clear all filters** icon. </li>
</ol>

![Display options - Advanced - How to filter activity types on timeline](media\timeline-how-to-filter-activity-types-display-options-advanced-1.png "Display options - Advanced - How to filter activity types on timeline")

When you select the filter icon, the Filter by menu is displayed and you can filter items based on the following categories:

|Category                   |Sub-category                            |
|---------------------------|----------------------------------------|
|Record type                |<li>Notes</li>                          |
|                           |<li>Posts</li>                          |
|                           |<li>Activities</li>                     |
|Activity type              |<li>Appointment</li>                    |
|                           |<li>Campaign Activity</li>              |
|                           |<li>Campaign Response</li>              |
|                           |<li>Email</li>                          |
|                           |<li>Fax                                 |
|                           |<li>Case Resolution</li>                |
|                           |<li>Letter</li>                         |
|                           |<li>Opportunity Case</li>               |
|                           |<li>Order Case</li>                     |
|                           |<li>Phone Call</li>                     |
|                           |<li>Quote Close</li>                    |
|                           |<li>Recurring Appointment</li>          |
|                           |<li>Social Activity</li>                |
|                           |<li>Task</li>                           |
|                           |<li>Project Service Approval</li>       |
|                           |<li>Booking Alert</li>                  |
|                           |<li>Conversation</li>                   |
|                           |<li>Session</li>                        |
|                           |<li>Customer Voice survey invite</li>   |
|                           |<li>Customer Voice survey response</li> | 
|                           |<li>Custom activities (as configured by your administrator)</li>|
|Activity status            |<li>Active</li>                         |
|                           |<li>Overdue</li>                        |
|                           |<li>Closed</li>                         |
|Activity due date (active) |<li>Next 30 days</li>                   |
|                           |<li>Next 7 days</li>                    |
|                           |<li>Next 24 hours</li>                  |
|                           |<li>Last 24 hours</li>                  |
|                           |<li>Last 7 days</li>                    |
|                           |<li>Last 30 days</li>                   |
|Posts by                   |<li>Auto post</li>                      |
|                           |<li>Users</li>                          |
|Modified date              |<li>Last 24 hours</li>                  |
|                           |<li>Last 7 days</li>                    |
|                           |<li>Last 30 days</li>                   |

When you use the filter based on an activity status then those activities, notes, and posts are displayed:

<ol type="a">
<li> Select an activity item. In this example we selected **Overdue**.</li>
<li> Based on our selection, all activity items with an **overdue status** now appear.</li>
<li> **Filter** icon is filled in telling you a filter item has been selected.</li>
<li> To clear filter selections, click on the **Clear all filters** icon to clear all filters.</li>
</ol>

![Display options - Advanced - How to filter activity types on timeline](media\timeline-how-to-filter-activity-types-display-options-advanced-2.png "Display options - Advanced - How to filter activity types on timeline")

## Expand filter pane 

The **Expand filter pane** feature provides quick access to sorting options withing timeline.  It is enabled by default.

7.	The **Expand filter pane by default** feature displays an expanded filter pane at the top of the form anytime it is opened and refreshed and is disabled by default.
8.	Enable the **Expand filter pane** by checking the box next to the feature.  This will enable the filter pane to appear at the top of the form anytime the form is opened and refreshed.
9.	To disable the **Expand filter pane**, uncheck the box next to the feature and the filter pane will not appear on the timeline.

![Display options - Advanced - Expand filter pane ](media\timeline-expand-filter-pane-display-options-advanced-1.png "Display options - Advanced - Expand filter pane")

## Enable search bar

You can easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title of the record or body and description fields of the record then displays the record for you. 

10.	The **search bar** feature enables the **Search timeline** bar functionality and is enabled by default.
12.	Enable the **search bar** feature and it will display a **search bar** at the top of the timeline form.
13.	To disable the search bar uncheck the box next to the feature and the search bar will no longer on the timeline. 

![Display options - Advanced - Enable search bar](media\timeline-enable-search-bar-display-options-advanced-1.png "Display options - Advanced - Enable search bar")

## Expand all records in timeline

**Expand all records by default** displays all activities in an expanded view in timeline. 

13.	**Expand all records** is disabled by default.
14.	Enable the **Expand all records** by checking the box next to the feature, this will now allow records to expand and display in the form by default each time it is opened. 
15.	To disable **Expand all records**, uncheck the box next to the feature it will no longer display activities in an expanded view.

![Display options - Advanced - Expand all records in timeline](media\timeline-expand-all-records-display-options-advanced-1.png "Display options - Advanced - Expand all records in timeline")

### Expand records with images in timeline

You can send and receive records with images, but they will not display when the record is collapsed. Records with images must be expanded to be viewed.

<ol type="a">
<li> Records when collapsed provide a visual summary.</li>
<li> To expand an individual record, click anywhere on the timeline record to expand and collapse.  In the bottom right corner of the record you will see a caret.  When the caret is facing downward (˅) it tells you the record is collapsed. When the caret is facing upward (^)it tells you the record it expanded.</li>
<li> Records with images will often display the following notice. When you click on this message the warning will go away. 

![Expand records with images in timeline](media\timeline-expand-records-with-images-display-optiones-advanced-1.png)

If you don’t see a message and the image is not displaying, see [Timeline FAQs](timeline-faqs.md) for more information. </li>
<li> Once you click on the warning message, the image will display.</li>

![Display options - Advanced - Expand records with images in timeline](media\timeline-expand-records-with-images-display-optiones-advanced-2.png "Display options - Advanced - Expand records with images in timeline")

## Enable “What you’ve missed” summary

**What you’ve missed** helps you stay on top of updates and changes made records by displaying updates at the top of the timeline when you access a record. 

16.	The **What you’ve missed** feature displays new records you have not seen and it is disabled by default.
17.	To enable **What you’ve missed**, click the box next to the feature. Now when you view a customer’s account, a box will appear at the top of the timeline section notifying you updates. 
18.	To disable **What you’ve missed**, uncheck the box next to the feature and you will notifications will not display when you access an account.

![Display options - Advanced - Enable “What you’ve missed” summary](media\timeline-what-you-missed-display-options-advanced-1.png "Display options - Advanced - Enable “What you’ve missed” summary")

## Record Settings

The **Record types to show** is tied to the **Record settings** which supports Activities, Notes, and Posts in the timeline.

1.	The **Record settings** allows you manage the settings within the record types. 
2.	**Activities** record type is tied to **Activities** in record settings.
3.	**Notes** record type is tied to **Notes** in record settings.
4.	**Posts** record type is tied to **Posts** in record settings.
5.	To enable or disable a record type simply check or uncheck the box and that record type will either display or no longer appear in the **Record settings** section.

![Display options - Advanced - Record Settings](media\timeline-record-settings-display-options-advanced-1.png "Display options - Advanced - Record Settings")

## How to configure activity record types

When you expand the **Activities record settings** on the timeline component section a list will display showing all the activity types that can be either enabled or disabled on the entity form. 

1.	Click the upward facing caret (^) to expand and view **Activities** under **Record settings**.
2.	Once expanded, a list of **Activity types** is displayed.
3.	When you click on an **Activity type** a pop-up window appears. 
4.	To enable an **Activity type**, click the box next to Enable and select Done.
5.	To disable an **Activity type**, uncheck the box next to **Enable** and select **Done**. This will grey out all other items in the box and disable the activity type from displaying on the timeline.  This also disables the activity type from being created or viewed in timeline.  
6.	When you enable an **Activity type**, it will appear in a drop down box when you click on the **Create a timeline record** icon (+) in the top right nav in the timeline section of the entity record. 
7.	Also, the **Activity type** can be viewed in the body of the timeline section of the form. 

> [!NOTE]
> A check mark appears on the right next to enabled **Activity types**.  Additional settings for a record type are disabled until you enable the record type.  

![Display options - Advanced - How to configure activity record types](media\timeline-how-to-configure-activity-record-types-display-options-advanced-1.png "Display options - Advanced - How to configure activity record types")

### Enable status tags on activity record types

Status tags match the status filter and displays in the timeline to help you to see at a glance the **Active**, **Overdue**, or **Closed** state of the activity record, such as on a task, appointment or email.  Admin can enable or disable status tags for any **Activity type** in the **Record settings**. Status tags are enabled by default.

8.	Check the box next to **Enable status tag** functionality to display status tags on activity types on the timeline.  
9.	When enabled, status tags such as **Active**, **Overdue**, or **Closed** will appear in the timeline for that activity.

![Display options - Advanced - Enable status tags on activity record types](media\timeline-enable-status-tags-on-activity-record-types-display-options-advanced-1.png "Display options - Advanced - Enable status tags on activity record types")

### Enable the ability to create directly from timeline

Having the ability to quickly click and create an activity such as, an email, task, appointment, etc. streamlines productivity.  Admins have the ability to enable activity types so they can be created directly on the timeline.    

10.	Check the box next to **Create directly from timeline** to enable.
11.	When enabled, the activity type will appear in a drop down box when you click on the Create a timeline record icon (+) in the top right nav in the timeline section of the entity record.

![Display options - Advanced - Enable the ability to create directly from timeline](media\timeline-enable-ability-to-create-directly-from-timeline-1.png "Display options - Advanced - Enable the ability to create directly from timeline")

### Create and use card forms in timeline

Records are displayed using the defult setting for each activity type. However, if you want to display record information for an appointment or email, for example, you can either edit the existing card form, use a different card form from record settings, or customize your own. 

12.	You can change the default card settings to a different card form if one has been created.  
13.	If you create a new card form, you must go to the parent entity and add the new form of card type there before it will appear in the timeline list for configeration.  If **Default** is displayed, you are not using the card form.  You can not use the **Email card form** in timeline unless you select and publish it first.	

> [!NOTE]
> Not all activity types allow you to create card types, so the default selection will be you’re only option for those records.

![Display options - Advanced - Create and use card forms in timeline](media\timeline-create-and-use-card-forms-display-options-advanced-1.png "Display options - Advanced - Create and use card forms in timeline")

### How to customize a card from in timeline

All card forms are broken out into the following four (4) sections:

<ol type="a">
<li><b>ColorStrip Section.</b> This section does not appear on the timeline record. The <b>ColorStrip</b> is located on the left of the card form.</li><br>

<li><b>Header Section.</b> This section is displayed on the timeline recrod, however only the first two (2) fields are displayed on the timeline record. For this example, only the <b>Subject</b> and <b>Modified On</b> fields are visible.</li><br>

<li><b>Details Section.</b> This section is displayed on timeline record, however only the first three (3) fields are displayed on the timeline record. For this example, only the <b>To</b>, <b>CC</b>, and <b>Description</b> fields are visible on the timeline record.</li><br>

<li><b>Footer Section.</b>	This section is not displayed on the timeline record. </li><br>

<li><b>Entity Fields.</b> You can select which fields you want to add to your card form from the field options listed on the right.  You can customize your card form by dragging and dropping the fields you want to use into the sections you want that field to appear in on the timeline record.</li>
</ol>

![Display options - Advanced - How to customize a card from in timeline](media\timeline-customize-card-form-display-option-advanced-1.png "Display options - Advanced - How to customize a card from in timeline")

Each indvidual card form has to be customized for each activity record such as email, tasks, posts, etc. 

**Header Section**<br>
The displays the title/subject in your timeline email form. You can have up to six (6) fields in the Header section, only the first two (2) fields will be seen on the timeline record. Also empty fields will be ignored by the form in all sections.<br>

<ol>
f.  <b>Header - Field 1.</b> Regardless of the field you choose, it will appear as a bold header at the top of your timeline record. For this example we selected <b>Subject</b> for this field.<br>

g.	<b>Header - Field 2.</b> Again regardless of the field you choose, this field appears in the bottom right corner of the timeline record.  For this example we selected <b>Modified On</b> for this field.
</ol>

**Details Section** <br>
This displays in the body of your the timeline email record. You can have up to four (4) fields in the <b>Detail</b> section, but only the first three (3) fields are seen on the timeline record.

<ol>
h.	<b>Details - Field 1.</b> As before, regardless of the field you choose, this field will always appear below the Header - Field 1 as a sub-header on the timeline record. For this example we selected <b>To</b> for this field. <!--Depending on the font setting in your browser, the font for this section will display differently.--><br>

i.	<b>Details - Field 2.</b> This field will display one line of text in a summary view on the timeline record.  When you expand your timeline record,  content in this field is fully displayed with format. For this example we selected <b>CC</b> for this field.<br>

j.	<b>Details - Field 3.</b> This field follows the content in Details -Field 2 and is part of the main body of your timline record that is only viewable when you expand the record. For this example we selected <b>Description</b> for this field.
</ol>

**Footer Section**<br>
This section is not visible on the timeline record.  

<ol>
k.	<b>Footer – Field 1.</b> For this example we selected <b>Owner</b> for this field.<br>

l.	<b>Footer – Field 2.</b> For this example we selected <b>Regarding</b> for this field.<br>

m.	<b>Footer – Field 3.</b> For this example we selected <b>Priortiy</b> for this field.
</ol>

![Display options - Advanced - How to customize a card from in timeline](media\timeline-how-to-configure-activity-record-types-display-options-advanced-2.png "Display options - Advanced - How to customize a card from in timeline")

### How to set date in the sort activities by feature in timeline

How you view data is important and setting a default display view of your data varies based on the needs of your business. Admins can choose how data is sorted and create a default sort setting for **Activity types** in **Record settings**. **Last Updated** is on all activities which is why it is set as the default in accending order.    

14.	The **Sort activity by** feature in the **Activities record settings** allows you to control how data is sorted in timeline.  
15.	When you click on the **Sort activities by** field, a list appears. You can select from this list how you want your data to be sorted and displayed on timeline in the form.

There are some unique date fields, for example:<br> 

<ol>
16a. <b>Date sent.</b> This only occures in email. If you sort by Date sent, most activities will not contain a Date Sent and therefore will be grouped together without any ordering.<br>
16b. <b>Sort date.</b>  You cannot create a custom date field.  If you create one, it will not display, so in answer to this, **Sort date** was created.  It does not have a value and therefore allows you to choose your own.  Is empty by default.
</ol>

> [!IMPORTANT]
> Sort date is intended for users to programatically program and map each activity with a date of choice to have more control.  It’s a cusomization option that allows you to sort activities any way you want by whatever date you want.  You will have to populate each field and it requires that you update all activities to populate the Sort date with a value.  However, once you complete configurability you have flexiblity to sort anyway you want.  

> [!NOTE]
> Sort dates have to be configured for each timeline instance and set up must be completed in all three main forms for the Account enity in order to work.

![Display options - Advanced - How to set date in the sort activities by feature in timeline](media\timeline-how-to-set-date-in-sort-activities-by-feature-1.png "Display options - Advanced - How to set date in the sort activities by feature in timeline")

## How to set create activities form type in timeline

The **Create activities** feature allows you to choose which type of form you want to work in based on your business needs.  

- **Quick create form** appears in a model on the right. There are some activities which do not support quick create that will always use email for example. For more information, see [Create or edit model-driven app quick create forms for a streamlined data entry experience](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-edit-quick-create-forms).

- **Main form** navigates you to the activity entity main form. For more information, see [Create or edit a model-driven app main form for an entity](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-edit-main-forms).

17.	 Click on **Create activities** using feature to select either a **Quick create form** or **Main form**.

> [!NOTE]
> If a **quick create** form for an activity has not been created, then the main form will be used. If **quick create** form is not supported, such as with email, the **main form** will always be used. 

![Display options - Advanced - How to set create activities form type in timeline](media\timeline-how-to-set-create-activities-form-type-1.png "Display options - Advanced - How to set create activities form type in timeline")

## Timeline performance impacts

You only want to enable activites that you need on this form. When working with 10 or more **Activity types**, you will receive a warning notice letting you know the number of activity types you have selected impacts the performance speed on your timeline.  To improve timeline performance speed, consider limiting activity types to 10 or less. 

18.	Warning notice will display when you select more than 10 activity types

![Display options - Advanced - Timeline performance impacts](media\timeline-performance-impacts-1.png "Display options - Advanced - Timeline performance impacts")

## Posts on timeline

You can enable sort fields on **Posts**.

1.	Sort **Posts** by **Date created** fields. **Date created** on **Post** is enabled by default.
2.	Enable **Date created** by clicking the check box next to the **Posts** feature
3.	Disable **Date created** by unclicking the check box next to the **Posts** feature
4.	Enable **Posts** with **Date created** on timeline

![Posts on timeline](media\timeline-posts-1.png "Posts on timeline")


## Notes on timeline

You can enable sort fields on **Notes**.

1.	Sort **Posts** by **Date created** fields. **Date created** on **Notes** is enabled by default.
2.	**Enable Date** created by clicking the check box next to the **Notes** feature
3.	Disable **Date created** by unclicking the check box next to the **Notes** feature
4.	Enable **Notes** with **Date created** on timeline

![Notes on timeline](media\timeline-notes-1.png "Notes on timeline")

## How to create and add custom activities to timeline

You can create custom entities to display on the timeline by enabling specific options during the creation of the entity. See the [How to create and add custom activities](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-custom-activity-in-timeline) for a step by step guide.

## Save and publish timeline updates and changes

Before you can view any configuration changes on the entity form, you must save and publish your updates first on the timeline component. 

1.	Before you can publish, you must **Save** any changes made in the timeline component first
2.	Once your configuration changes are saved, select **Publish**.  Timeline updates are now live in your timeline environment and can be viewed.

    ![Save and publish timeline updates and changes](media\timeline-save-and-publish-updates-and-changes-1.png "Save and publish timeline updates and changes")

## How to configure dashboard timelines

Timelines can be configured and put on a dashboard. However, dashboards are not supported by Power Apps and therefore can only be use in the [name of the legacy experience – ask Shubhada]. For more information see [Set up timeline section (control)](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/set-up-timeline-control).

> [!NOTE]
> Capabilities on a dashboard timeline are different than those in an embedded dashboard timeline.  For more information see [Create or edit model-driven app dashboards](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-edit-dashboards).

### See Also

[Timeline FAQs](timeline-faqs.md)

[Set up timeline section (control)](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/set-up-timeline-control)
