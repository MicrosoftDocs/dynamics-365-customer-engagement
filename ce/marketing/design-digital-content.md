---
title: "Use the designer tool (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Basics of how to use the designer tool to create emails, landing pages, and forms in Dynamics 365 for Marketing"
keywords: "designer; content block; block; template"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 28762c17-02f7-4883-a9d8-e606858de7bd
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Design your digital content

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides an advanced digital-content designer for creating, styling, and previewing the various types of digital content that you can produce and manage with the system, including:

- Marketing email messages and templates  
    [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Prepare marketing email messages](prepare-marketing-emails.md)
- Marketing pages and templates  
    [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and deploy marketing pages](create-deploy-marketing-pages.md)
- Marketing forms and templates  
    [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create, view and manage marketing forms](create-deploy-marketing-pages.md#create-view-and-manage-marketing-forms)

The designer features a drag-and-drop interface for building and working with the design, plus an optional HTML editor for working directly with code and a preview tool that can show how your design will look on various form factors and orientations.

The designer adapts itself to your current context (email, landing page, and so on) to provide only those design elements and settings that apply there, but its basic functionality remains the same. It also provides a "foreign content mode", which is activated if you paste HTML from a third-party application directly into the HTML code editor; in this case, the designer 0 know which type of content you are designing and therefore hides context-specific features and provides a more generic design interface.

This topic describes how to work with the designer in general, in all contexts. For more information about how the designer fits into the various specific contexts, and for details specific to just one context, see the topics linked in the list at the start of this introduction.

## Start by choosing a template

Most non-template entities that provide the content designer also support templates, so when you first create a marketing email, page, or form, you'll be asked to choose a template.

![Select an Email Template window](media/select-template-email.png "Choose an email template")

The template picker provides many controls for searching, sorting, and filtering the templates. Use these controls to find templates that might meet your requirements, then select a template to see a preview and more details about it in the **Preview** area. When you've found the right template, select **Select** to apply it to your new design.

The template you choose will initiate your design by establishing the following:

- **Column layout**: Sets the basic layout, such as one-column, two-column, and so on. To change this later, you'll need to use the HTML code editor; the graphical editor doesn't provide tools to change the column layout.
- **Page or form type**: If you're creating a marketing page or form, this tells whether the page is a subscription center, forward-to-a-friend, or landing page and establishes the basic capabilities of the page or form.
- **Sample design and content**: Some templates already include basic design elements, such as logos, typography, color palette, sample content, and more. Other templates provide a blank page that includes only the page type and column layout. You can freely change the sample design and content as you edit and design the page.

After you've chosen a template, the designer shows your selected template content and you can start editing it. Your new email, page, or form is created as a simple copy of the template, so any local changes you make won't affect the template, and any future changes to a template won't affect anything you created based on it.

## Work with the designer

Most of the time you spend creating a marketing email, page, or form, you'll be using the designer or the HTML editor to add content, configure content blocks, load images, apply styles, and more.

![The designer toolbar and content area](media/designer-tools-ill.png "The designer toolbar and content area")

The designer features a toolbar and a content area. The toolbar provides a few basic commands and three navigation tabs (**Design**, **HTML**, and **Preview**), which control what you can see and do in the content area.

### Use the graphical designer

Choose **Designer** in the designer toolbar to open the graphical designer. It lets you assemble and design your content without using any code at all. In most cases, you'll never need to go to the **HTML** view unless you want to.

![The designer canvas and toolbox](media/designer-canvas-ill.png "The designer canvas and toolbox")

The graphical designer provides an editable preview (canvas), where you can select, edit, or remove content; and a set of tabs for adding content blocks and working with the design:

- **Toolbox**: To add a new element to your design, drag a block from here to an appropriate place in the canvas. Each block represents a specific type of content, such as a text block, image, or input form. The settings and features of each block vary by type.
- **Properties**: Most blocks need to be configured to work. For example, an image needs to point to an image file, a form needs to point to a marketing-form record, and a button needs some text and a destination. When you add a new block, that block is automatically selected and its **Properties** tab opens so you can set it up. To configure (or reconfigure) any block already in your design, select it first, and then open the **Properties** tab.
- **Style**: Use these settings to apply color, spacing, and other graphical options for the overall design.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Content blocks reference](content-blocks-reference.md)

### Work directly in HTML

If you prefer to work directly with HTML code, open the designer's **HTML** tab. You might do this to touch up a few properties that you can't get to by using the graphical editor, or you might paste in HTML code that you created by using some other program. You could also add advanced scripts and styling to introduce new functionality. For example, if you're designing a marketing page, you might write scripts to implement the following features:

- Change the properties of one field (or form) based on the values of another field, for example:
    - Make the **Customer No.** field visible only if **Existing customer** is true.
    - Make the **Customer No.** required if **Existing customer** is true.
    - Clear the **State** address field if the **Country** field is changed.
    - Change the list of **State** values based on the country chosen.
    - Change the styles of fields to make them visible, required, and so on.
- Add custom field-value validations (either when the form is submitted or the field value is changed), such as requiring that **Customer No** has only six digits.
- Perform actions on form load or submission, such as:
    - Hide certain fields by default
    - Disable the submit button until all mandatory fields are filled
    - Set field values based on values passed in the calling URL
    - Set field values based on values passed in the calling URL.

Be careful when working here, though, because the graphical editor expects specific types of markup to implement its drag-and-drop components. Without this markup, you won't be able to edit your content blocks any more and might even break them.

The HTML editor provides a few handy code-editing features such as syntax coloring and line numbers.

### Preview your design

Though the drag-and-drop editor provides an editable preview, this preview is still just an approximation, and includes a few compromises in its presentation to allow for its editing features. To get a better idea of how your design will look, go to the designer's **Preview** tab.

![Preview mode selector](media/preview-mode-ill.png "Choose a preview mode")

Use the buttons in the left column of the **Preview** tab to see how your design will look on different screen sizes and orientations, such as desktop, tablet landscape, or mobile portrait. The preview also reflects the responsive design features built into many of the templates. However, the preview doesn't run any custom scripts you might have added (such as for validating form input).

> [!NOTE]
> Marketing email messages can be trickier to design than webpages because they typically contain dynamic content, and email clients vary much more widely in the way they render HTML. Therefore, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides a few extra features for previewing your emails that aren't available for marketing pages or forms. These include sample contact records, a choice of content settings, and an advanced inbox preview. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Check your work with previews and test sends](prepare-marketing-emails.md#check-your-work-by-using-previews-and-test-sends)

### See also

[Designer keyboard shortcuts](designer-shortcuts.md)  
[Content blocks reference](content-blocks-reference.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)  
[Work with email templates](email-templates.md)  
[Create and deploy marketing pages](create-deploy-marketing-pages.md)