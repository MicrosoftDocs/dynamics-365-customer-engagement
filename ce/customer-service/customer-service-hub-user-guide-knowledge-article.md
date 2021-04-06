---
title: Understand Knowledge Management in Customer Service Hub in Dynamics 365 Customer Service | Microsoft Docs
description: Understand Knowledge Management in Customer Service Hub for Customer Service Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 03/12/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage knowledge articles

Reduce call handling times with knowledge articles in the Customer Service Hub application.
  
With the knowledge management module, you can create and manage knowledge articles that your users may be looking for. 

Knowledge articles can address any number of issues your customers encounter while using your organization's product or services. Types of Knowledge articles can include solutions to common issues, product or feature documentation, answers to frequently asked questions (FAQs), product briefs, and more. Use the rich text editor to create knowledge articles, format your content or embed videos and images.  
  
> [!IMPORTANT]
> Knowledge management is available out-of-the-box through the Customer Service Hub app module, and it can work with other customer apps as well. The articles that are created in the Customer Service Hub will be available in the Dynamics 365 Customer Service app as read-only records.  

> [!NOTE]
> The entities `KBArticle`, `KBArticleTemplate` and `KBArticleComment` are now deprecated. This means that we do not expect you to use these entities anymore. You must use the newer `KnowledgeArticle` entity for knowledge management in Dynamics 365 Customer Service. More information: [Work with Knowledge articles](work-knowledge-articles.md).

## Knowledge management process

 The following diagram describes the default process for creating and using knowledge articles in the Customer Service Hub. Create an article and mark it for review. The reviewer can approve or reject the article. If the article is rejected, it is sent back for edits or updates. If the article is approved, it is published on the portal. It is also available in search and can also be translated.
  
 ![Knowledge management process in Dynamics 365 Customer Service](../customer-service/media/v8-km-walkthrough.png "Knowledge management process in Dynamics 365 Customer Service")  
  

## Create a knowledge article

Turn your customer questions, issues, and feedback into knowledge articles, so other service reps can benefit from them. Add images and videos to your articles to explain things better and make the articles engaging.  You can author, edit, search, publish, and translate the knowledge articles in the Customer Service Hub. 
  
1. Make sure that you have Create and Read permissions on the Knowledge Article entity. By default, these permissions are added to the Knowledge Manager, Customer Service Manager, or Customer Service Representative role.  
  
2. In the Customer Service Hub sitemap, go to **Service** > **Knowledge Articles**.  
  
3. On the command bar, select **New**.  
  
    You’ll be on the **Content** tab of the knowledge article.
  
4. In the **Article Content** section, fill in the following details:  
  
   - **Title**. Type a descriptive title that communicates the subject and purpose of the article in a concise manner.  
  
   - **Keywords**. Type keywords for the article. These keywords are used for searching the knowledge base for articles. Separate keywords with commas.  
  
   - **Description**. Type a short overview of the article. This appears in the search results and is used for search engine optimization.  
  
     ![Add content to the knowledge article](../customer-service/media/v9-add-content-article.png "Add content to the knowledge article")  
  
5. In the **Content** section, add the content for your knowledge article.  
  
   > [!NOTE]
   >  As soon as you select inside the editor space, the rich text editor command bar appears. Use the rich text editor command bar options to format and style your content. If you cannot use the features, your editing space is too small. If this is the case, you will need to resize to a larger space. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the rich text editor to create knowledge articles and emails](#use-the-rich-text-editor-to-create-knowledge-articles-and-emails)
  
6. Select **Save**. 
   
   As the article is saved, the Business Process flow bar appears for the article. The stages are **New Process**, **Author**, **Review**, and **Publish**. The Business Process flow bar guides you to drive the article towards completeness. You can customize the stages in the Business Process flow to suit your  requirements.

7. On the Business process bar, select **Author**.  
8. In the **Set Keywords** text box, add keywords for your article.
  
9. In the **Article Subject** drop-down list, choose the subject of the article to help with article searches.  
  
10. In the **Assign Primary Author** drop-down list, choose a person who is responsible for maintaining the article content. By default, the user who creates the article is the primary author.  
 
    You can  mark the article complete by selecting the checkbox at this stage.

> [!TIP]
> Select the icon ![flyout icon](media/flyout.png) to pin the stage flyout vertically.
  
Posts about knowledge article-related activities will begin appearing in the **Timeline** section.  

## Personalize your language preferences for authoring knowledge articles

If your administrator has enabled language personalization, you can select your preferred language when authoring knowledge articles.

1. In **Customer Service Hub**, go to **Service** > **Knowledge** > **Knowledge Personalization**.
2. Do one of the following:
   - Select the **Authoring** tab, and then toggle Use organization’s language to **No**.
   - From the drop-down list, select your preferred language.
3. Select **Save**.
   When you create a new knowledge article, the default language you selected is used.
4. If you need to change the language for a specific article only, select the **Summary** tab, and then select your preferred language in the **Language** field.
5. Select **Save**.

## Create knowledge articles using templates

Knowledge Authors can use the templates to create knowledge articles quickly and the fields for the knowledge article are pre-populated according to the selected template. To create knowledge articles using templates:
 
1. Make sure that you have Create and Read permissions on the Knowledge Article entity. By default, these permissions are added to the Knowledge Manager, Customer Service Manager, or Customer Service Representative role.  
  
2. In the Customer Service Hub sitemap, go to **Service** > **Knowledge Articles**.  

    A list of available articles is displayed. 

3.	To create an article from a template, select **+ New From Template**.
  
4.	On the **Select Knowledge Article Template** dialog box, select the template to use as a base on which you author the article and select **OK**. In this example, we are selecting the template as **Getting Started With Template**.

    > [!div class=mx-imgBorder]
    > ![Select knowledge article template](media/ka-select-template.png "Select knowledge article template")
  
    You observe that some fields are pre-populated as defined in the template.

5.	In the **New Knowledge Article** page, edit the fields as required. 

    > [!div class=mx-imgBorder]
    > ![New knowledge article page](media/ka-new-article-page.png "New knowledge article page")
  
6.	Select **Save**.

    The article is saved, and you can take it to the next stage to approve and publish the article to make it available for users.

> [!NOTE] 
> To learn how to create knowledge articles templates, see [Create knowledge article template](create-templates-knowledge-article.md)


## Use the rich text editor to create knowledge articles and emails
Create rich and well-formatted content for emails or knowledge articles using the new rich text editor in the Customer Service Hub. The editor brings common word processor features like advanced styling, linking, find and replace, and insert images and tables.  

The **Content** editor panel consists of three tabs:

- **Designer**: Author and edit the article here. Benefit from the enhanced and rich text editing capabilities.
- **HTML**: View the HTML preview of the content here. You can author or edit the article in the HTML tab also.
- **Preview**: See how your content would look like on devices like Desktop, Tablet, or Mobile.

Additionally, you can perform **Undo**, **Redo**, and **Full Screen** in the Content editor panel. 
  
### Designer

You can choose a specific format or style for the content you’re writing. The following table outlines the different formatting options of the rich text editor.

   > [!Note]
   > You can access your browser's context menu by pressing **Ctrl** + right-click. This is useful if you need to use your browser's built-in spell checker. Otherwise, you can use the right-click to provide contextual formatting for any element you might be using.

|Icon | Name | Shortcut key | Description |
|----------------------|-------------------------|-----------------------------|-----------------------------|
|![Format Painter](../customer-service/media/format-painter.png "Format Painter")| Format Painter | Ctrl+Shift+C, Ctrl+Shift+V | Apply the look of a particular section to another section. **Note**: Copy formatting only works with inline styles, and won't copy or apply block-level styles. |
|![Styles](../customer-service/media/format-styles.png "Style") | Formatting Styles | | Apply predefined sets of formatting features to make it easier to keep the presentation of the text consistent. To make the choice easier, the style names are displayed in a style that they represent, giving you a preview of what the text will look like. **Note**: This option is available in the expanded mode only.
|![Paragraph Format](../customer-service/media/paragraph-format.png "Paragraph Format") | Paragraph Format | | Apply predefined block-level combinations of formatting options. A paragraph format can only be applied to a block-level element, like a `paragraph` or a `div` element. **Note:**  This option is available in the expanded mode only. |
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
|![Image](../customer-service/media/insert-picture.png "Image") | Image | | Insert an image.<br /><br /> You can insert an image by directly copying and pasting it inline in the editor, dragging and dropping it from your desktop or local folder directly into the editor, or by typing a URL. The following formats are supported: .PNG, .JPG., or .GIF. For details on using inline images, see [Use inline images](#use-inline-images).|
|![Left to Right](../customer-service/media/left-to-right.png "Left to Right")| Left to Right |  | Change the text to left-to-right for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. This is the default setting.|
|![Right to Left](../customer-service/media/right-to-left.png "Right to Left")| Right to Left |  | Change the text to right-to-left for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. The default setting is left-to-right. |
|![Undo Typing](../customer-service/media/undo-typing.png "Undo Typing")| Undo Typing |  | Undo changes you made to the content. |
|![Redo Typing](../customer-service/media/redo-typing.png "Redo Typing")| Redo Typing |  | Redo changes you made to the content. |
|![Clear All Formatting](../customer-service/media/clear-formatting.png "Clear All Formatting")| Clear All Formatting |  | Remove all formatting from a selection of text, leaving only the normal, unformatted text. |
|![Add a Table](../customer-service/media/add-table.png "Add a Table")| Add a Table |  | Add a table to your content. <br /><br />After adding a table, you can do any of the following:<br /><br /><ul><li>Resize table columns by clicking and dragging your mouse to resize to the columns to the desired width.</li><li>Select one or several cells within a table and apply specific formatting, add links to the selection, or cut, copy, or paste entire rows or columns.</li><li>Right-click to access the properties. This supports features such as cell type, width and height, word wrapping, alignment, merging and splitting cells horizontally and vertically, inserting or deleting rows and columns, row and column span, and cell and border color.</li></ul>|
|![Create Collapsible Section](../customer-service/media/collapsible-section.png "Create Collapsible Section") | Create Collapsible Section | | Create a section that can be collapsed or expanded. This is useful in articles with a lot of information. Collapsed sections help agents find relative information more quickly by scanning the titles within an article. Collapsible sections include title and body fields to type text into, and you can nest collapsible sections to make it easier to scan longer articles to find the most relevant sections quickly. You can also select text you have already typed and then click the collapse icon to turn it into a collapsible section. <br /> <br /> If you create a collapsible section and then later want to delete it, place your cursor within the section, and then click **Delete** on your keyboard, or right-click within the collapsible section and select **Cut**. |
|![Embed Media](../customer-service/media/embed-media.png "Embed Media")| Embed Media | | To embed videos into your content:<br /><br /> 1.  Place the cursor where you want to insert the video, and then on the toolbar, select the **Embed Media** button.<br />     The **Embed Video** dialog box opens.<br />2.  Enter the embed link of the video provided by the video hosting provider, and then select **OK**. |
|![Create Div Container](../customer-service/media/div-container.png "Create Div Container") | Create Div Container | | Create a `div` container to apply formatting to a larger document fragment that extends beyond one block.<br /><br /> The **General** tab lets you manually add a stylesheet class that is applied to the div element.<br /><br /> The **Advanced** tab lets you configure additional div element options such as assigning it an ID, a language code, a text direction, an advisory title, or CSS style properties. **Note:**  This option is available in the expanded mode only. |
|![Create Anchor](../customer-service/media/create-anchor.png "Create Anchor") | Create Anchor | | You can add anchors in document text and then link to them for easier navigation.<br /><br />**Note**: The anchor feature only works when an article is open. It doesn't work if you are viewing an article from the **Preview** tab.<br /><br /> To add an anchor:<br /><br /> 1.  Place the cursor where you want to insert an anchor, and then on the toolbar, select the **Anchor** button.<br />     The **Anchor Properties** dialog box opens.<br />2.  Enter a name for the anchor, and then select **OK**.<br />     The **Anchor** button ![Anchor tool on the rich text editor toolbar](../customer-service/media/v8-rte-anchor--button.png "Anchor tool on the rich text editor toolbar") appears in the area where you created the anchor.<br /><br /> You can now use the **Link** button to link to your anchor. |   
  
> [!IMPORTANT]
>  You can’t use client-side code (script tags or [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]) in articles or emails. If you want to associate CSS or [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], use web resources. 
> 
> [!NOTE]
> In mobile devices, where you have comparatively smaller screen sizes, limited set of formatting options will be displayed.

#### Use inline images

You can insert an image by directly copying and pasting it inline in the editor, dragging and dropping it from your desktop or local folder directly into the editor, or by typing a URL. 

Before using inline images, keep in mind the following: 

- The following formats are supported: .PNG, .JPG., or .GIF
- The following browsers are supported: Microsoft Edge, Chrome, Firefox, Safari


**Drag and drop an image**

> [!Note]
> You can only drag and drop an image in an editable area of the editor.

1. Drag and drop the image either on top of the content or in the middle of the content in the editor.

2. Drag any corner of the image to resize it to your desired size in the editor.

**Copy and paste an image**

> [!Note]
> To copy and paste images, you must open the image file and then copy and paste it into the editor. <br>You can drag and drop or copy and paste an image from Microsoft Word into the editor. One or two images can be copied at a time, as long as the total size of the images together doesn't exceed 5 MB.

1. Open the image file that you want to copy to the editor.

2. Right-click the image, then select **Copy**.

3. Go to the desired location in the editor where you want to insert the image, and then either right-click and select **Paste**, or select press **Ctrl+V**.

**Insert a URL for an image**

To insert an image by using a URL or navigating to the local image:

1. In the editor, choose **Insert Image**.
2. In the **Image** property dialog, choose from the following options:
   - Specify the web address of the image, and also specify properties to define how the image will appear in the email or article.
   **Note:** If the image is located on the external server, use the full absolute path. If the image is located on a local server, you can use a relative path. If you want the image to be a selectable link, add a URL for the image. You can also specify if you want the targeted page to open in a new window, topmost window, same window, or parent window.
   - Select **Browse** to navigate to the image on your computer.

  
### HTML

You can author and edit the article in the HTML tab of the Content editor panel, using HTML tags.

![HTML panel](media/html-panel.png "HTML pane in content editor for knowledge article")


### Preview

You can preview the content to view its compatibility on multiple devices, like Tablets, or Phones.

![Preview panel](media/preview-panel.png "Preview pane in content editor for knowledge article")

> [!NOTE]
> This is an indicative preview. Content rendered can be different in the actual device or screen.


## Add a knowledge article rich text editor control to a form
By default, the rich text editor functionality is available for use with knowledge articles and emails, but if you want to use it in another form, you can add it by doing the following:

1. In Power Apps, go to the form where you want to add the rich text editor control, and double-click a field where you can enter single or multiple lines of text to open **Field Properties**. 

2. On the **Field Properties** dialog, select the **Controls** tab.

3. Under **Control**, select **Rich Text Editor Control.

    > [!div class=mx-imgBorder]
    > ![Select the Controls tab on the properties page](media/csh-rte-add-form.png "Select the Controls tab, and then select the rich text editor control")

3. Under **Rich Text Editor Control** properties, select the pencil icon next to **RichTextEditorControl_URL**. 
    
    > [!div class=mx-imgBorder]
    > ![Select the Rich Text Editor control](media/csh-rte-edit-control.png "Select the Rich Text Editor Control and pencil icon to add text")
    
    The properties configuration page is displayed.

4. In the **Bind to a static value** field, enter the following text: **webResources/msdyncrm_/RichTextEditorControl/KnowledgeArticleRTEconfig.js** 

    > [!div class=mx-imgBorder]
    > ![Enter value in Bind to a static filed](media/csh-rte-enter-static-value.png "Enter the value in the Bind to a static value field")

5. Select **OK** > **OK**, and then select **Save and Publish**.


For more information about rich text control properties, see [Rich text editor control configuration options](https://docs.microsoft.com/powerapps/maker/model-driven-apps/rich-text-editor-control#rich-text-editor-control-configuration-options).

  
## Mark a knowledge article for review  
 To make sure the content you’ve created is accurate, have someone review it.  
  
 You can mark an article for review or directly assign it to a specific person or queue. When you mark an article for review, it starts appearing in the knowledge manager’s dashboard. The knowledge manager can then assign the article to specific team members or a queue for review.  
  
1.  In the article you want to mark for review, in the **Status Reason** drop-down list, select **Needs Review**.  
  
2.  On the Business process flow, select **Author**.  
  
3.  In the **Mark for Review** field, select **Mark Complete**.  

    ![Knowledge article review](media/ka-review.png)
  
4.  To assign the knowledge article to another reviewer or team, on the command bar, select **Assign** and select the user or a team.  
  
5.  To add the article to a queue so reviewers can pick it from there, on the command bar, select **Add to Queue**, and then select the queue.  
  
 
## Review and reject or approve a knowledge article  
 It’s important to review articles for accuracy before they’re published or made available to others.  
  
> [!IMPORTANT]
>  To approve a knowledge article, you must have **Approve** permissions for the knowledge article record type. This permission is added by default to the Knowledge Manager, Customer Service Manager, Customer Service Representative, or System Administrator role or equivalent permissions.  
  
|To|Do this|  
|--------|-------------|  
|Pick an article assigned to you|Go to **Service** > **My Knowledge Dashboard**, and then see the **My Active Articles** stream.<br /><br /> **-OR-**<br /><br /> In the Customer Service Hub, go to **Service** > **Queue Items**, and then select the **Items available to work on** view.|  
|To suggest review feedback|1.  On the Business process bar, in the **Review** stage, in the **Review** field, select **Reject**. Give the reason for rejection in the **Reject Knowledge Article** flyout. <br />2.  To add details about the changes you want in the knowledge article, go to **Summary** tab and in the **Timeline** section, select **+** to add a note.<br /><br /> The rejected article is  assigned back to the primary author of the knowledge article.|  
|Approve the content of the article|When you approve the content of an article, it means that the content is ready to be consumed by other customer service reps, and also ready to be published.<br /><br /> On the Business process bar, in the **Review** stage, in the **Review** field, select **Approve**.<br /><br /> The article is now ready to be published.|  
  
 
## Update knowledge articles to capture feedback  
 Make sure that your articles are up to date and accurate at all times by updating them based on feedback you receive.  
  
1.  In the Customer Service Hub, go to **Service** > **Knowledge Articles**.  
  
2.  Select the article you want to edit.  
  
     If the reviewer has suggested any changes from their review, you can see them as notes in the **Timeline** section.  
  
3.  Update the article based on the feedback.  
  
4.  Select **Save**.  
  
5.  To assign the article back to the reviewer for approval or publishing, on the command bar, select **Assign**, and then select a user or a team  
  
## Update published knowledge articles  
 When a knowledge article is in the Published (or Scheduled) state, only the users who have the Publish privilege can update it.  
  
1.  In the Customer Service Hub, go to **Service** > **Knowledge Articles**.  
  
2.  Select the published article you want to edit.  
  
3.  On the command bar, select **Update**.  
  
4.  Update the article based on the feedback.  
  
If the article has information that complements an existing knowledge article, associate the existing article with the current knowledge article.  
  
1.  In the knowledge article, on the command bar, select **More** > **Relate Article**.  
  
2.  In the **Select Article to Associate** field, select the **Lookup** button, select an existing article, and then, select **Associate**.  
  
     The associated article appears in the **Related Articles** list in the **Related Information** section of the **Summary** tab.  
  
 
## Create and manage article versions  
 Article versioning helps you manage updates to your knowledge articles without disrupting the live or published articles. By creating major and minor versions of a knowledge article, you can keep your articles up to date with the latest information while keeping track of changes throughout the lifecycle of your products and services.  
  
 This capability helps you to keep accurate records of the features your organization provides and go back to previous versions if you need to.  
  
1.  In the Customer Service Hub, select **Services** and choose **Knowledge Articles**.  
  
2.  Open the article you want to create a new version for.  
  
3.  In the knowledge article, select **Create Major Version** or **Create Minor Version**.  
  
     An example of a major version would be when your documentation changes to detail a new feature or functionality,  while a minor version might be a change to the user interface with no change to functionality.  
  
     The new version of your article will contain all of the same content, information, and permissions as the current version. The **Version Major** or **Version Minor** field will automatically update to reflect the new version number.  
  
    > [!NOTE]
    >  You won’t able to make any changes to the **Major Version Number**, **Minor Version Number**, **Language**, or **Article Public Number** fields when creating a new major or minor version of an article.  
  
4.  After you have reviewed the article, make any changes that you want to the new version. You can update the article title, content, keywords, and description to reflect any changes to your products, features, or services.  
  
### Review and publish your new version  
 When you are done making changes, you can push the new version of your article through your standard article workflow. When you are finished reviewing and are ready to publish, on the command bar, select **More** > **Publish**, and then choose how and when you want to publish your new version. You can publish your new version immediately, schedule it to publish at a future date, or leave it as a draft to manually publish later. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule or publish an article](#schedule-or-publish-an-article) 
  
### Manage article versions  
 Managing your article versions means publishing and archiving different versions of each article to provide the most accurate information to your customers and internal employees. Keep in mind that only one version of an article can be published at a time; it’s important to keep track of the changes that are made to each version and publish them when it is appropriate.  
  
1.  In the knowledge article, select the **Summary** tab.  
  
2.  In the **Related Information** section, select the **Related Versions** button to display a list of all major and minor versions of the article.  
  
3.  In the **Related versions** list, open the version you want to delete.  
  
4.  Select the **More** button, and then select **Send to Trash**.  
  
5.  When prompted, select **OK**.  
  
     Deleting an article version is permanent and can’t be undone. You won’t be able to go back to that version of the article, so make sure that you don’t need any of the information. It’s a good idea to create a local backup of any versions you delete.  
  
## Translate a knowledge article in multiple languages  
 Your knowledge content needs to reach all of your customers, no matter what market or region they are from. The knowledge management capability in Dynamics 365 Customer Service helps you translate your articles so that you can provide the same self-help content in multiple languages without having to manage multiple copies of the same article. By using the translation feature, you can quickly and efficiently provide 24-hour service to all of your customers.  
  
1. Open the article you want to translate, and on the command bar, select **Translate**.  
  
2. In the **Create new translation** dialog box, in the **Pick a language** drop-down list, choose the language you want.  
  
3. In the **Create new version** field, choose whether to create a new major or minor version for your translation.  
  
    You can translate articles into any language that’s supported by the Customer Service Hub.  
  
4. Select **Create**.  
  
5. Enter your translated text in the appropriate fields. You can enter translated text for the following fields:  
  
   -   Title  
  
   -   Keywords  
  
   -   Article Description  
  
   -   Content  
  
6. When you are finished reviewing and are ready to publish, select **More** > **Publish**. Choose how and when you want to publish your new version. You can publish your new version immediately, schedule it to publish at a future date, or leave it as a draft to manually publish later. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule or publish an article](#schedule-or-publish-an-article)
  
### Manage article translations  
 After you have published a translation for an article, you can manage it and any other translations by selecting the **Summary** tab of the knowledge article.  
  
1.  In the **Related Information** section, select **Related Translations**.  
  
2.  Open the translation you want to view. Keep in mind that there may be multiple versions for each language. You can sort the translations by selecting the column headers of the **Related Translations** section.  
  
     From here, you can:  
  
    -   Edit or update a translation  
  
    -   Create a new major or minor version of a translation  
  
    -   Delete a translation or version of a translation  
  

## Schedule or publish an article  
 After the content in the article is complete and reviewed, you can publish the article to the portal to make it available to your customers. You can publish the article immediately or schedule it for a later time. 
  
> [!IMPORTANT]
>  If your organization is using a portal for publishing the knowledge articles, your customizer can write a plug-in that can pick the published articles and post on your portal, and also report the article views back.  
  
1.  Make sure that you have the Publish and Update permission on the Knowledge Article record type. These permissions are added by default to the Knowledge Manager, Customer Service Manager, Customer Service Representative, or System Administrator role.  
  
2.  In the Customer Service Hub, go to **Service** > **Knowledge Articles**.  
  
3.  Open a knowledge article that’s in the Approved state.  
  
4.  To make it easy to find knowledge articles related to specific products, associate the knowledge article with a product.  
  
    1.  On the command bar, select **More** > **Relate Product**.  
  
    2.  In the **Select Product to Associate with** field, select the **Lookup** button, elect a product this article is about, and then, select **Associate**.  
  
         The associated article appears in the **Related Products** list in the **Related Information** section of the **Summary** tab.  
  
5.  On the Business process bar, select the **Publish** stage.  
  
6.  In **the Set Product Associations** field, select **Mark as Complete**.  
  
7.  If you want to schedule the article to publish on a later date, on the **Summary** tab, in the **Publish On** field, select a date and time to publish the article.  
  
8.  On the command bar, select **More** > **Publish**.  
  
    -   In the **Publish** field, select whether you want to publish the knowledge article right away or in the future. To publish the article in the future, in the **Publishing Date Time** field, select a date and time.  
  
    -   In the **Published Status** field, select what status the article should be in after it is published. By default, **Published** is selected.  
  
    -   In the **Expiration Date** field, select a date and time when you want the published article to expire. Expired articles are no longer available in searches.  
  
    -   If you’ve set an expiration date, in the **Expiration Status** field, select the status the knowledge article should be set to after it expires.  
  
    -   To publish all approved related translated articles with the article, in the **Publish Approved related translations with Article**, select **Yes**.  
  
    -   Select **Publish**. 

        ![Knowledge article publish](media/ka-publish.png)


## Track basic details of an article  

Use the **Summary** tab to track some basic details of the article. In the **Summary** tab, you can:

- View or edit **Basic settings** for the article. These include details like Language, Article Public Number, and many more.
- View or edit **Publish settings** for the article
- See the **Timeline**. Add notes, or view what you have missed.
- View related information about the article in the **Related Information** section. These include related versions, translations, categories, articles, and products

  
### Track knowledge article analytics  
 Tracking your content helps you and your authoring team assess its value to your organization and your customers. Knowing and understanding when, where, and how many times an article was viewed tells you how much your customers and team members rely on the information that it contains. This data is extremely useful when creating future content curation plans and can help you decide what content you will deliver in the future, as well as how you deliver it, where you deploy it, and what style or structure you use to write it.  
  
 To view an article’s view counts and other statistics, open the article you want to track, and then select the **Analytics** tab.  
  
- **Views**. Shows you the total number of times that this article has been viewed. This figure represents the total views of all versions and all translations of this article combined. It also shows individual article views on specific days. You can select the column headers to sort by chronological order or by the number of views. 

- **Feedback**. Captures all the feedback and ratings on the knowledge articles and update  the articles  accordingly. If your articles are published on a portal, customers and users can provide their feedback and also give ratings on an article.   The Feedback subgrid shows all feedback received for the current knowledge article.  

   The **Rating** field calculates the average rating of the article based on the amount of feedback and number of ratings received.  
   > [!NOTE]
   > Rating and view count numbers are rollup fields that are not updated instantly. For more details, see [Define rollup fields](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/define-rollup-fields).

- **Cases**. Shows a list of the cases that have used this article. Double-click a case to view its details.  
  
     By reviewing cases that have used your articles, you can gain valuable insights into the questions that customers are asking, as well as what avenues they tried before asking for help. This data can help you expose your knowledge articles better and provide more useful information to your customers and team members.  
  
  
#### Add feedback to an article  
  
1. In the **Feedback** subgrid, select **Create Feedback**. You can also select ![Add a record button](../customer-service/media/add-recordbutton.gif "Add a record button") in the nav bar and then go to **Feedback** to create a feedback.  
  
2. In the **Create Feedback** flyout, fill in the information:  
  
   - **Title**. Type a descriptive  title for the feedback. For example, if the feedback is about customer satisfaction, type that.  
   - **Regarding**. Look for relevant records to associate the feedback.
  
   - **Source**. Select whether the feedback is internal or from a portal. If you received the feedback via a phone call, you can select **Internal**.  
  
   - **Comments**. Type any feedback comments that you want.  
  
   - **Rating**. Type a number to specify how useful the related record is. For example, if you are tracking the customer satisfaction for a case, and you want to rate it a 2 on a scale of 1 - 10, type 2.  
  
   - **Minimum Rating Value** and **Maximum Rating Value**. Specify a minimum and maximum rating to define a rating scale. For example, you want to give a rating of 2  on the scale of 1 - 10, type 1 as the minimum rating and 10 as the maximum rating.  
  
   - **Created by (Contact)**. If you're creating the feedback on behalf of a customer contact, select the contact here.  
  
        The **Created By** and **Closed By** fields are automatically populated with the user who creates or deactivates the feedback record.  
  
   - Dynamics 365 Customer Service automatically calculates the **Normalized Rating** based on the following formula: **(Rating - Minimum Rating)/ (Maximum Rating - Minimum Rating)**.  
  
3. Select **Save**.

   ![Knowledge article feedback](media/ka-feedback.png)

> [!NOTE]
> You can also update the owner of the feedback in the flyout.

 
## Monitor knowledge articles with dashboards  
 Knowledge managers and authors can now monitor the status of knowledge articles using the two  default dashboards available in the Customer Service Hub.  
  
> [!NOTE]
>  If these dashboards don’t offer what you need, you can create new interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure interactive experience dashboards](https://technet.microsoft.com/library/d1446a95-14bf-4b15-a905-72fce07f4c76.aspx)  
  
### My knowledge Dashboard  
 This dashboard is designed for authors to give them a visual snapshot of the number and status of knowledge articles they’re working on. It helps them quickly know things like article expiring in the month and articles in review.  
  
 ![My Knowledge Dashboard for authors](../customer-service/media/v9-my-knowledge-dashboard.PNG "My Knowledge Dashboard for authors")  
  
-   **Streams** show data from views or queues. In the My Knowledge Dashboard, the stream shows the active articles assigned to the author.  
  
-   **Charts** provide a count of relevant records in the streams, such as articles by status, articles by owner, or articles by subject. They also act as visual filters. You can drill down in a chart to see data that interests you the most.  
  
-   **Tiles** give authors an aggregated view of data in the streams and help them monitor the volume of their knowledge articles.  
  
### Knowledge Manager  
 This dashboard is designed specifically for knowledge managers. As a knowledge manager, you can quickly know the most popular articles, articles that need review, highest-rated articles, or articles that are about to expire, and take necessary actions on the articles from here.  
  
 ![Dashboard for knowledge managers](../customer-service/media/v9-knowledge-manager-dashboard.PNG "Dashboard for knowledge managers")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use interactive dashboards to effectively manage service cases](customer-service-hub-user-guide-dashboard.md)

#### Manage versions in alternate keys for knowledge article entity
If you are creating an alternate key for Knowledge article entity, include the major or minor version in the key to maintain uniqueness. Also, if you are using translations, include the language code along with the version in the key to ensure a seamless translation experience. To know more about alternate keys, see [Define alternate keys for an entity](../developer/define-alternate-keys-entity.md).

## Prevent duplicate workflows with knowledge article operations   
If you use [workflow processes](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/workflow-processes) to perform knowledge article operations, such as:
- Create a knowledge article
-	Update a knowledge article

The update operation is further classified into sub-operations, such as:
-	Update a knowledge article version
-	Manage a knowledge article version
-	Translate a knowledge article

For the create and update operations, be aware of the following when using the workflow process:
Whenever you create a new knowledge article manually, the system creates two articles: a root article and a base article, which means:

If you use a workflow process that is triggered on a create operation, the workflow is triggered twice—once each for the creation of base article and root article.

When you use a workflow process to perform the following update operations, the workflow is triggered twice—once each for the base article and the root article:
-	Create major version
-	Create minor version
-	Translate
  
   > [!NOTE]
   >  Other update operations, such as updating a field or approve/publish do not trigger the second workflow.

To avoid triggering the workflow twice, in the workflow itself, set the trigger condition for the knowledge article as follows: For a create operation, set the root article to Yes. For an update operation, set the root article to No. 

Follow these steps:
  
1. Sign in to Customer Service Hub.  
  
2. Select **Settings** > **Advanced Settings**. Advanced Settings opens in a new browser tab.
  
3. In the navigation bar, select **Settings** > **Processes**.

4. Select the knowledge article flow you created. The workflow process opens in a new browser window.
  
5. In the **General** tab, select the **Add Step** drop-down list, and then select **Check Condition**. A new step will be added.

    > [!div class=mx-imgBorder]
    > ![Select Check Condition](media/workflows-check-condition.png "Select Check Condition from the Add Step drop-down list")
  
6. In the step, select **<condition> (click to configure)**. The **Specify condition** page opens in a new browser window.

    > [!div class=mx-imgBorder]
    > ![Select the condition to configure](media/workflows-configure-condition.png "Select the condition to configure")
  
7. From the entity drop-down, select **Knowledge Article**.

8. From the field drop-down, select **Root Article**.

9. From the condition drop-down, select **Equals**.

10. From the value drop-down, select a value:
    - **Yes** for the create operation.
    - **No** for the update operation.

    > [!div class=mx-imgBorder]
    > ![Set workflow condition](media/workflows-set-condition.png "Select the applicable value for the workflow condition from the drop-down list")

11.	Select **Save and Close** to save the condition and close the window.

12.	In the workflow process window, select **Save and Close** to save the condition and close the window.

Now, when you perform a create or update operation, the workflow process will trigger only once. 

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create knowledge article template](create-templates-knowledge-article.md)

[Set up knowledge management using embedded knowledge search](set-up-knowledge-management-embedded-knowledge-search.md)

[Use Workflow processes to automate processes that don't require user interaction](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/workflow-processes)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
