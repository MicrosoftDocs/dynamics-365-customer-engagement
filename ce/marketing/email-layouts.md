---
title: "Use section elements to lay out your email design (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Learn how to use section elements to create single and multi-column layouts for marketing email messages in Dynamics 365 for Marketing"
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: f167b4f8-cb53-44a0-9404-c01473fa762e
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Design multi-column layouts for email messages

[!INCLUDE [cc-marketing-early-access-2019w2](../includes/cc-marketing-early-access-2019w2.md)]

Use section elements to establish the basic layout of your email messages. Each section element creates a row of columns into which you can drag various other design elements, like text boxes, images, buttons, dividers, and more. There are five different section elements, each of which creates a row with one of five different layout options (one column, two columns (1:1), two columns (1:2), two columns (2:1), or three columns). You can stack several section elements as needed to create complex designs with various column layouts in each row.

All section elements are designed to work well with nearly all email clients. Multi-column layouts will both render correctly as tables in Microsoft Outlook, and can provide responsive-design layouts for clients that support them.

## Add section elements to layout your email design

When you're designing an email message starting with the blank template (or a custom template based on the blank template), all design elements (other than section elements) must be placed into a _section element_. Section elements are provided in the **Toolbox** panel under the **Layout** heading.

The blank template provides a one-column section by default, but you can edit its column layout and/or add more section elements as needed.

To add a section element, open the **Toolbox** panel, choose the section element that provides the column layout you'd like to start with and drag it into position above or below any existing section element in your design.

![Add a section element to your design](media/email-layout-add.png "Add a section element to your design")

> [!NOTE]
> If you choose one of the out-of-the-box templates (which implement layouts using custom HTML instead of section elements), then section elements aren't available. Instead, you'll be able to drag design elements into any container defined by the template. This may also apply to other custom templates that use custom HTML to create layouts.

## Edit and configure a section element

When you add a new section element, you'll choose one of five initial column layouts. But once your element is placed, you can change the column layout and/or spacing options.

To edit and configure a section element:

1. Select the section element on the canvas. It now displays a blue border and tabs showing the element type and buttons for deleting or moving the element.
1. The **Properties** panel opens to show the settings for your selected section.

    ![Add a section element to your design](media/email-layout-edit.png "Add a section element to your design")

1. Make settings in the following sections as needed:

    - **Section layout**: Select a button here to change the column layout to the one indicated by the graphic on each button. If you remove a column, all of its content will be moved into one of the remaining columns. If you add a column, the new column will initially be empty.
    - **Section padding**: Specify how much padding (in pixels) you'd like to place between the columns and the outside border of the section element. You can enter separate values for top, bottom, left, and right.
    - **Section margin**: Specify how much margin (in pixels) you'd like to place between the columns and the outside border of the section element. You can enter separate values for top, bottom, left, and right.

## Add, configure, and edit design elements to create content for your layout

Section elements create a structure onto which you can drag other types of design elements to create your content. If you are using section elements, then all of your design elements must be placed into a section-element column.

- To add a design element, drag the required element from the **Toolbox** onto the appropriate section-element column. When you drop most types of elements, the **Properties** panel will open or, for text  elements, the formatting toolbar will open and you'll be able to start entering text.
- To configure an existing element's properties, or start entering text into a text element, first select the containing section-element to activate it, then select the target element to begin editing it. For non-text elements, this will open the **Properties** panel for the selected element. For text elements, this will open the floating text-formatting toolbar.
- To remove a design element, select it and then select the delete button ![Delete button](media/email-element-delete-button.png "Delete button") provided at the upper-right corner of the element.
- To move a design element, select it, then click on the move button ![Move button](media/email-element-move-button.png "Move button")  provided at the upper-right corner of the element and drag the element to its new location.

### See also

[Design your digital content](design-digital-content.md)  
[Create a new email and design its content](email-design.md)  
[Design elements reference](content-blocks-reference.md)