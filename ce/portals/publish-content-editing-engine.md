---
title: "Use the front-side editing engine to publish content for a portal in Dynamics 365  | MicrosoftDocs"
description: "Learn how to use the front-side editing engine to publish content for a portal."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: be8f4571-2f44-404a-b4db-b7086b79597b
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Use the front-side editing engine to publish content

Use the content editor to edit text, create links and display images on webpage.

To use the content editor, you need the appropriate permissions and the content to be modified must be in the page template. 

To modify the content, select **open the content editor**, point to the content to be modified, and then select the blue edit button that appears in the upper-left corner.

## Content editor commands and controls

The editor toolbar has a number of buttons to help with content editing. Move the mouse cursor over a button to see a tool tip for the buttons function. The table below also has more detail about the available buttons, listed in the order they appear in the toolbar.

| Button                                       | Description                                                                                                                                                                                                                         |
|--------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Save                                       | Saves the changes made to the content and closes the editor.                                                                                                                                                                        |
| Cancel All Changes                         | Discards any changes made and closes the editor.                                                                                                                                                                                    |
| Toggle Full Screen Mode                    | Resizes the editor to the size of the containing browser window.
  | Bold, Italic, Underline, Strikethrough     | Makes selected text bold, italic, underline, or strikethrough as well as newly typed text.                                                                                                                                          |
| Align Left, Center, Right, Full            | Aligns selected text to the left, center, right, or full as well as newly typed text.                                                                                                                                               |
| Direction Left to Right, Right to Left     | Changes the direction of the written text to be left to right or right to left.                                                                                                                                                     |
| Edit CSS Style                             | Opens a dialog to an interface that allows full control over the CSS styling of selected text as well as newly typed text. To set the style of a single word or selection of text, simply select the text, then in the Edit CSS Style dialog select the "Insert span at selection" option. Overusing custom styling can greatly reduce the consistency of the content's look and feel between pages. It is recommended to use this method only when absolutely necessary. |                                                   |
| Format                                     | Changes the selected text as well as newly typed text to the pre-defined style selected.                                                                                                                                            |
| Help                                       | Opens a dialog about TinyMCE.                                                                                                                                                                                                       |
| Cut, Copy, Paste                           | Cuts, copies, or pastes the selected text to and from the clipboard.                                                                                                                                                                |
| Paste as Plain Text                        | Pastes text from the clipboard with all formatting and styling removed.                                                                                                                                                             |
| Paste from Word                            | Pastes text from the clipboard while trying to maintain formatting and styling that originated from [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Word.                                                                                                                 |
| Find, Find/Replace                         | Opens a dialog for searching content and optionally replacing found content.                                                                                                                                                        |
| Insert/Remove Bulleted List, Numbered List | Inserts a bulleted or numbered list for selected text or at the text cursor if the list isn't already present. If the list is already present, it will be removed.                                                                  |
| Decrease, Increase Indent                  | Reduces or increases the indentation of the text or a list item.                                                                                                                                                                    |
| Block Quote                                | Places the selected text or newly typed text within a quote block.                                                                                                                                                                  |
| Undo, Redo                                 | Will undo the previous change or redo an undone change. Only changes that have been done since the editor was opened can be undone. Changes that have been saved or canceled cannot be undone, or re-done. |                                                                               |
| Insert/Edit Link                           | Inserts or edits a hyperlink for selected text. See Create a Link below for more details about this feature.                                                                                                                        |
| Unlink                                     | Changes a hyperlink back to text.                                                                                                                                                                                                   |
| Insert/Edit Anchor                         | Inserts or edits an anchor link for selected text.                                                                                                                                                                                  |
| Insert/Edit Image                          | Inserts or edits an image into the content. See Insert an Image below for more details about this feature.                                                                                                                          |
| Insert/Edit Embedded Media                 | Inserts or edits embedded media such as a video or application.                                                                                                                                                                     |
| Cleanup Messy Code                         | Tries to remove invalid markup that may have come from pasting.                                                                                                                                                                     |
| Edit HTML Source                           | Opens a dialog containing the HTML source for the content. The HTML can be directly modified and updated from this window. This dialog will not validate the HTML! It is recommended that only users with knowledge of HTML use this feature. |                                                                                                               |
| Insert/Edit Table to Merge Table Cells     | Inserts or edits tables and their rows, cells, and properties.                                                                                                                                                                      |
| Insert Horizontal Line                     | Inserts a horizontal line at the text cursor.                                                                                                                                                                                       |
| Remove Formatting                          | Removes the formatting and styling for the selected text.                                                                                                                                                                           |
| Show/Hide Guidelines/Invisible Elements    | Toggles table border guidelines and other invisible elements on or off.                                                                                                                                                             |
| Subscript, Superscript                     | Makes selected text subscript or superscript as well as newly typed text.                                                                                                                                                           |
| Insert Special Character                   | Opens a dialog containing special characters and inserts the selected character at the text cursor.                                                                                                                                 |
||

>[!Note] 
> When in Full Screen Mode, the **Save** and **Cancel All Changes** buttons will not be available. To save or cancel, select **Toggle Full Screen Mode** to return to the regular mode where the buttons are available.

## Create a link

From within the content editor, select the text to make a hyperlink for and select **Insert/Edit Link**. Enter the properties for the hyperlink and select **Insert**. Select **Save** in the content editor toolbar to save the change.

### Link properties and commands

| Name           | Description                                                                                                                                                                                                                |
|----------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Link URL       | The URL to link to. It can be any properly formatted URL, external to the website or within the same website. If within, it can be relative and it can be looked up using Browse (found just right of the Link URL field). |
| Browse         | Opens a file picker for the website. The URL for the selected page or file will be placed into the Link URL field when selected. See Using the File Picker.                                                                |
| Target         | Specifies whether the link will be opened in the same or a new browser window when selected. If not set, the link will open in the same window by default.                                                                  |
| Title          | A descriptive title for the hyperlink. Usually displayed when the mouse cursor hovers on the hyperlink.                                                                                                                    |
| Insert, Update | Makes or updates the hyperlink with the specified properties and closes the dialog. Note that the change is only done in the content editor until the save button has been selected in the content editor toolbar. |                                                                                           |
| Cancel         | Discards any changes made and closes the dialog.                                                                                                                                                                           |
||

## Insert an image

From within the content editor, put the text cursor where you want to insert an image and select **Insert/Edit Image**. Enter the properties for the image, and then select **Insert**. Select **Save** in the content editor toolbar to save the change.

### Image properties and commands

| Name              | Description                                                                                                                                                                                                                                                                           |
|-------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Image URL         | The URL for the image. It can be any properly formatted URL to an image, external to the website or within the same website. It's recommended that the URL be within. When within, it can be relative and it can be looked up using Browse (found just right of the Image URL field). |
| Browse            | Opens a file picker for the website. The URL for the selected image file will be placed into the Image URL field when selected. See Using the File Picker.                                                                                                                            |
| Image Description | Specifies the alt attribute for the image. It's read by screen readers, and is typically seen when the image doesn't load properly.                                                                                                                                                   |
| Title             | A descriptive title for the hyperlink. Usually displayed when the mouse cursor hovers on the image.                                                                                                                                                                                   |
| Preview           | Provides a preview of the image being inserted or updated.                                                                                                                                                                                                                            |
| Appearance (Tab)  | Provides options for overriding the actual image properties, its styling, and its placement.                                                                                                                                                                                          |
| Advanced (Tab)    | Provides advanced options that may need page template support.                                                                                                                                                                                                                        |
| Insert, Update    | Makes or updates the image with the specified properties and closes the dialog. The change is only done in the content editor until **Save** has been selected in the content editor toolbar. |                                                                                                                                                      |
| Cancel            | Discards any changes made and closes the dialog.                                                                                                                                                                                                                                      |
||

## Browse pages and files by using the file picker

The file picker provides a way to browse pages and files that belong to the same website. New files can be uploaded using the file picker as well. The file picker is available when adding a link or an image through the content editor. Select the icon that looks like a [!INCLUDE[pn-ms-windows-short](../includes/pn-ms-windows-short.md)] Explorer window to open the file picker. Browse to a page or file by using the left tree view and double-click the page or file in the rightmost list view to select it.

To upload new files,

1. Navigate to the folder to upload the file to and select the disk icon with a green plus on it.
2. In the dialog box that opens, select **Browse** and pick a file to upload. Do the same in the next field to add more than one file.
3. Select **Ok** to upload the selected files.

### File picker commands

The table below has more detail about the available buttons, listed in the order they appear in the toolbar.

| Name                    | Description                                                                                                                                  |
|-------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|
| Back                    | Move to the folder that was being viewed previously.                                                                                         |
| Reload                  | Refresh the folder's view.                                                                                                                   |
| Select file             | Use the selected page or file's URL.                                                                                                         |
| Open                    | View the page or file in a new browser window.                                                                                               |
| Upload files            | Opens a dialog for uploading new files. Select **OK** to upload new files immediately to the folder. |                                             |
| Copy, Cut               | Disabled                                                                                                                                     |
| Remove                  | Deletes the selected file. Only files can be removed and not pages. Pages should be removed by using the **Delete** button in the content publishing toolbar. |  |
| Get Info                | Displays additional information about the selected page or file.                                                                             |
| Preview with Quick Look | View the file and some information about it in a small overlay window.                                                                       |
| View as icons           | Displays the folder contents as icons.                                                                                                       |
| View as list            | Displays the folder contents as a table with more details about each item.                                                                   |
| Help                    | Opens a dialog about elFinder: Web file manager.                                                                                             |
||

### See also

[How to provision a portal](provision-portal.md)  
[Get started with the portal content editor](get-started-portal-content-editor.md)  
[Customize content by using content snippets](customize-content-snippets.md)
