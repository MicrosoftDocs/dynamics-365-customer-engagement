---
title: "Work with reusable content blocks (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to create reusable content blocks and use them in your page and email designs in Dynamics 365 Marketing."
ms.date: 04/24/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create content blocks that you can reuse in multiple designs

Content blocks let you establish a block of common content that you can reuse in multiple emails, forms, and/or pages. Use them to establish common headers, footers, and other blocks of content that you would like to standardize across your communications.

Content blocks work like templates. They include a fixed collection of content that you add all at once to a design. Once added, the content is copied into your design and doesn't maintain any connection to the original block content, which means that if you edit a content block itself, or its content in a particular design, other designs that already use that block won't be affected.

You can lock the content of a content block to prevent it from being changed in any design where it is used. Use this to gain improved control over common content and/or design choices.

> [!IMPORTANT]
> Even if you choose to lock a content block, users that have access to the designer's **HTML** tab will still be able to edit it by modifying the code directly. To prevent this, administrators can use designer feature protection to limit access to the **HTML** tab by some or all users. More information: [Control access to designer features](designer-feature-protection.md)

> [!NOTE]
> When you first create a content block, it's considered to be in a draft state and therefore isn't available for use in your designs until you select **Go live** for that block on the command bar. This helps make sure that other users don't use your content block until you're finished designing it. However, unlike most go-live entities, content blocks aren't published to an external service when they go live, they just become available for use with other entities in Dynamics 365 Marketing. More information: [Go live with publishable entities and track their status](go-live.md).

<a name="create-block"></a>

## Create a content block and go live

To create and publish a content block:

1. Go to **Marketing** > **Marketing content** > **Content blocks**.

1. Select a listed content block to edit it or select **New** on the command bar to create a new one.

1. A [content designer](design-digital-content.md) opens. It works just like other content designers in Dynamics 365 Marketing.

1. Design your content by doing one of the following:

    - If you are working in the graphical designer (the **Design** > **Designer** tab), then you can only include a single design element in your content block, and only text and image elements are supported. Drag either a text element or an image element from the **Toolbox** to the canvas and configure your element as usual. More information: [Design elements reference](content-blocks-reference.md)
    - If you are comfortable working with HTML code, and if a single design element won't meet your needs for the content block, then you can create much more complex content by working on the **Design** > **HTML** tab instead of the **Design** > **Designer** tab. However, you still can't add code to create more than one design element within the content block.

    > [!NOTE]
    > Any CSS styles that you include in your content block could be overruled by styles in the document where you eventually host the content. If you want to prevent this, design your content blocks with inline styles that include the `!important` attribute.

    > [!NOTE]
    > When you are designing a content block in the graphical designer, the image element requires that you specify the image using a URL rather than select one from the file browser. You can still use images stored in your file library, but you must look up the URL first by going to **Marketing** > **Marketing content** > **Files**.

1. Select **Save** in the toolbar to save your work.

1. Open the **Details** tab and make the following settings:

    - **Name**: Assign a name to the content block.
    - **Availability**: Choose the types of designs where you'd like to make this content block available (emails, forms, and/or pages).
    - **Protected**: Choose whether you and other users will be able to apply in-line edits to the block's content (in the **Designer** view) after the block is placed into a design.

1. When you are done designing your content, select **Go live** from the command bar to make it available to other entities in Dynamics 365 Marketing.

## View, delete, or edit your content blocks

To work with your existing content blocks, go to **Marketing** > **Marketing content** > **Content blocks**. This opens a standard list view, where you can create or delete content blocks using check boxes and buttons in the command bar. Select any listed content block to view or edit it. The settings here are the same as those described in [Create a content block and go live](#create-block).

If you open a content block that is already live, then it is locked for editing. To unlock it, choose one of the following buttons on the command bar:

- **Edit**: Select this button to unlock the content block for editing but keep it live. The block will remain live while you edit, so if anyone else uses it in a design before you save, they will get the previous version. When you are done editing, select **Save** to save your changes and go live with the new version at the same time (this will also lock the block again).
- **Stop**: Select this button to take down the live version of the content block. The content then becomes editable to you, but you won't be able to use the content block in any new designs until you publish it again. When stopped, you can save your work without going live, but the block will remain unavailable for use until you select **Go Live**.

> [!NOTE]
> When you edit and save a content block, designs that already use the block will _not_ be updated to match your changes (and vice versa). Block contents are simply copied into the design where they are used as soon as you add the block.

More information: [Go live with publishable entities and track their status](go-live.md)

## Use content blocks in an email, form, or page

To add a content block to an email, form, or page design:

1. Open or create an [email message](email-design.md), [marketing page](create-deploy-marketing-pages.md), or [marketing form](create-deploy-marketing-pages.md).

2. Drag a content-block element from the **Toolbox** panel to the appropriate location in your design.

3. Select the new content-block element, open the **Properties** panel, and use the **Content block** lookup field to find and select the block that contains the content you want to include here.

4. Continue working with your design and go live when you are ready to start using it in other designs.

> [!NOTE]
> If a content block is unprotected, you can directly edit its elements and properties after inserting it into an email template. 
> 
> If you create a contact block outside of the Marketing app, it must contain user ownership, html hierarchy, and custom attributes that the content editor recognizes. To learn more about custom attributes for Marketing, visit [Use custom attributes to enable designer features in emails, pages, and forms](./custom-template-attributes.md).


[!INCLUDE[footer-include](../includes/footer-banner.md)]