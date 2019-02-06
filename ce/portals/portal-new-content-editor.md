---
title: "Get started with the new portal content editor in Dynamics 365 for Customer Engagement  | MicrosoftDocs"
description: "Learn how to use the new content editor for portal."
ms.custom: 
  - dyn365-portal
ms.date: 12/03/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 67A4A84F-DE74-44BC-8331-A3E53878B677
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Get started with the new portal content editor

> [!IMPORTANT]
> - [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)] 
> 
> **Send us feedback**
>
> We'd love your feedback on the new portal content editor! To send us feedback, register your account on the [Microsoft Insider program](https://experience.dynamics.com/insider/), and then [submit your feedback](https://go.microsoft.com/fwlink/p/?linkid=2030693).

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal allows customization by using [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] entities and some WYSIWYG support through its front-end editing tools in the portal runtime. A new and simplified portal editor is now available for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal customizers that will help to reduce the learning curve on [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal customization and increase a customizer's productivity.

> [!NOTE]
> - Portal’s out-of-the-box administrator web role and any contact linked to that web role can use the new editor.
> - Only contacts with a web role that has the following authorizations will be able to navigate to the new editor.
>   - The following website access permissions should be enabled:
>       - Manage Content Snippets
>       - Manage Site Markers
>       - Manage Web Link Sets
>       - Preview Unpublished Entities <br/>
>       More information: [Create website access permissions](website-access-permission.md)
>   - Webpage access permission must be set to **Grant Change** on the Home (root) page of the portal website needs to be enabled. More information: [Control webpage access for portals](webpage-access-control.md)
> - Drag and drop is not currently supported on the canvas. It will come in a subsequent release.

## Use the new editor

1.	Sign in to the portal with administrator credentials. A message is displayed at the top of the screen to try the new editor.

2.	Select **Try new Editor** to open the new editor.

    > [!div class=mx-imgBorder]
    > ![Try new editor](media/try-new-editor.png "Try new editor")

    The new editor opens:

    > [!div class=mx-imgBorder]
    > ![New editor](media/new-editor.png "New editor")

3.	Select a content snippet to select its text, and then edit it. Format options are displayed for changing the font size and style.

    > [!div class=mx-imgBorder]
    > ![Format text](media/format-text.png "Format text")

4.	After making the changes, click outside the content snippet boundary to save the changes. The status is displayed in the content snippet and footer.

5.	To view the source of the content snippet, select the content snippet, and then select the source code icon **</>** in the footer. The source code is displayed in the **Source code editor** pane at the bottom of the screen. The changes you made earlier are updated in the source code.

    > [!div class=mx-imgBorder]
    > ![Source code editor](media/source-code-editor.png "Source code editor")

## Add and edit a text box in a content snippet

1.	Select a content snippet or a text box in the content snippet, and then select **Components** from the pane on the left side of the screen.

    > [!div class=mx-imgBorder]
    > ![Components icon](media/components-icon.png "Components icon")

    The **Components** pane opens.

    > [!div class=mx-imgBorder]
    > ![Components pane](media/components-pane.png "Components pane")

2.	Under **HTML controls**, select **Text** to add a text box. You can edit the text as per your requirement. 

3.  To edit the text in a text box, select the text box, and then select the **Edit** icon.

    > [!div class=mx-imgBorder]
    > ![Edit text in a text box](media/text-edit.png "Edit text in a text box")

    > [!NOTE]
    > You can also double-click a text box to start editing the text.

4.	Click outside the content snippet to save the changes. You can also view changes in the source code editor.

## Add and edit an image in a content snippet

1.	Select a content snippet or a text box in the content snippet, and then select **Components** from the pane on the left side of the screen.

    > [!div class=mx-imgBorder]
    > ![Components icon](media/components-icon.png "Components icon")

    The **Components** pane opens.

    > [!div class=mx-imgBorder]
    > ![Components pane](media/components-pane.png "Components pane")

2.	Under **HTML controls**, select **Images**. The image placeholder is added on the canvas.

    > [!div class=mx-imgBorder]
    > ![Image placeholder](media/image-placeholder.png "Image placeholder")

3.	In the **Properties** pane, perform the following actions:

    - In the **URL** field, modify the link of the image. Only secured links are accepted—that is, https:// is mandatory.

    - To resize the image, update values in the **Width** and **Height** fields.

        > [!div class=mx-imgBorder]
        > ![Image properties](media/image-properties.png "Image properties")
    
    > [!NOTE]
    > You can also select the image on the canvas and drag the handles to resize it.

4.	Click outside the content snippet to save the changes. You can also view changes in the source code editor.

## Add and edit an IFrame in a content snippet

1.	Select a content snippet or a text box in the content snippet, and then select **Components** from the pane on the left side of the screen.

    > [!div class=mx-imgBorder]
    > ![Components icon](media/components-icon.png "Components icon")

    The **Components** pane opens.

    > [!div class=mx-imgBorder]
    > ![Components pane](media/components-pane.png "Components pane")

2.	Under **HTML controls**, select **IFrame**. The IFrame placeholder is added on the canvas.

    > [!div class=mx-imgBorder]
    > ![IFrame placeholder](media/iframe-placeholder.png "IFrame placeholder")

3.	In the **Properties** pane, perform the following actions:

    - In the **Link** field, modify the link of the IFrame. Only secured links are accepted—that is, https:// is mandatory.
    
    - To resize the IFrame, update values in the **Width** and **Height** fields.

        > [!div class=mx-imgBorder]
        > ![IFrame properties](media/iframe-properties.png "IFrame properties")
    
    > [!NOTE]
    > You can also select the IFrame on the canvas and drag the handles to resize it.

4.	Click outside the content snippet to save the changes. You can also view changes in the source code editor.

## Add web templates or portal components in a content snippet

> [!NOTE]
> You cannot edit a web template or a portal component. 

1.	Select a content snippet or a text box in the content snippet, and then select **Components** from the pane on the left side of the screen.

    > [!div class=mx-imgBorder]
    > ![Components icon](media/components-icon.png "Components icon")

    The **Components** pane opens.

    > [!div class=mx-imgBorder]
    > ![Components pane](media/components-pane.png "Components pane")

2.	Select a web template or a portal component.

There are two types of web templates:
- Web templates that require no input (for example, Breadcrumb): You can add a breadcrumb on the content snippet. After adding the breadcrumb, click outside the content snippet to save changes and render the breadcrumb.

- Web templates that require specific inputs:

    - **Ad**: For the Ad control, the advertisement placement name is required. You must specify the placement name from the portal app. If the placement name is not available, you must create it.

      You cannot add an advertisement name from the Properties pane. However, you can modify it through the source code editor as follows:

      `{% include ‘ad’ ad_name: ‘Name’%}`

    - **Ad Template**: For the Ad Template control, the advertisement name is required. You must specify the name from the portal app. If the advertisement is not available, you must create it. You can also edit its value through the source code editor.

    - **Entity List**: For the Entity List control, the entity list name is required. You must specify the name from the portal app. If the entity list is not available, you must create it. You can also edit its value through the source code editor.

    - **Entity List Filter**: For the Entity List Filter control, the entity list name is required. You must specify the name from the portal app. If the entity list is not available, you must create it. You can also edit its value through the source code editor.

    - **Entity List Grid**: For the Entity List Grid control, the entity list name is required. You must specify the name from the portal app. If the entity list is not available, you must create it. You can also edit its value through the source code editor.

    - **Entity Form**: For the Entity Form control, the entity form name is required. You must specify the name from the portal app. If the entity form is not available, you must create it. You can also edit its value through the source code editor.

    - **Web Form**: For the Web Form control, the web form name is required. You must specify the name from the portal app. If the web form is not available, you must create it. You can also edit its value through the source code editor.

    - **Poll**: For the Poll control, the poll placement name is required. You must specify the placement name from the portal app. If the placement name is not available, you must create it. 

      You cannot add a poll name from the Properties pane. However, you can modify it through the source code editor as follows:

      `{% include ‘poll’ poll_name: ‘Name’%}`

    - **Poll Template**: For the Poll Template control, the poll name is required. You must specify the name from the portal app. If the poll is not available, you must create it. You can also edit its value through the source code editor.

    - **Random Ad**: For the Random Ad control, advertisement placement name is required. You must specify the name from the portal app. If the advertisement placement is not available, you must create it. You can also edit its value through the source code editor.

    - **Random Poll**: For the Random Poll control, poll placement name is required. You must specify the name from the portal app. If the poll placement is not available, you must create it. You can also edit its value through the source code editor.

    - **Snippet**: For the Snippet control, you can go to the source code editor and insert the following code to render the content snippet:

      `{% include ‘snippet’ snippet_name: ‘Name’%}`
    
    > [!NOTE]
    > Snippet rendering is not supported through properties of the snippet. The usability will be improved in a subsequent update.

## Navigate to another page

After making changes to a page, you might want to make changes to other pages in your portal. To navigate to another page, select the required header link, and then select **Go to Link**.

> [!div class=mx-imgBorder]
> ![Navigate to another page](media/move-to-another-page.png "Navigate to another page")

## Go back to the old editor

If you want to go back to the old editor, select **Back to classic editor** in the header.

> [!div class=mx-imgBorder]
> ![Go back to the old editor](media/back-to-classic-editor.png "Go back to the old editor")

## Test language change in editor

To use multiple languages in the editor, you must have a language pack installed in portal solutions and also enabled on the portal. Once multiple language is enabled for the portal, you can see the language change option in the header of the portal runtime. More information: [Enable multiple languages for a portal](enable-multiple-language-support.md)

After selecting the new language, navigate to the new editor to see content in the portal in the selected language.

> [!div class=mx-imgBorder]
> ![Test language change in editor](media/language-change.png "Test language change in editor")

## Known issues

- When you edit the content snippet of the page heading and press the spacebar at the end points of text block, white space is displayed over the page.
- Default font size is not displayed for the selected text.
