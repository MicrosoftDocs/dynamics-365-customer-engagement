---
title: "Use layout elements to lay out your email design (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Learn how to use layout elements to create single and multi-column layouts for marketing email messages in Dynamics 365 for Marketing"
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
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

Use layout elements to establish the basic layout of your email messages. Each layout element creates a row of columns into which you can drag various other design elements, like text boxes, images, buttons, dividers, and more. There are five different layout elements, each of which creates a row with one of five different layout options (one column, two columns (1:1), two columns (1:2), two columns (2:1), or three columns). You can stack several layouts as needed to create complex designs with various column layouts in each row.

All layout elements are designed to work well with nearly all email clients. Multi-column layouts will both render correctly as tables in Microsoft Outlook, and can provide responsive-design layouts for clients that support them.

## Add layout elements to layout your email design

When you're designing an email message starting with the blank template (or a custom template based on the blank template), all of your design elements must be placed into a _layout element_. Layout elements are provided in the **Toolbox** panel together with the other types of design elements.

The blank template provides a one-column layout by default, but you can add more layouts and/or replace default one as needed. To use a layout, drag it from the **Toolbox** panel to a position above or below the existing layouts.

![Add a layout element to your design](media/email-layout-add.png "Add a layout element to your design")


> [!NOTE]
> If you choose one of the out-of-the-box templates (which implement layouts using custom HTML instead of layout elements), then layout elements aren't available. Instead, you'll be able to drag design elements into any container defined by the template. This may also apply to other custom templates that use custom HTML to create layouts.

## Add, configure, and edit design elements to create content for your layout

Layout elements create a structure onto which you can drag other types of design elements to create your content. If you are using layouts, then all of your design elements must be placed into a layout column.

- To add a design element, drag the required element from the Toolbox onto the appropriate layout column.
- To configure an element's properties, or start entering text into a text element, double-click on that element in the layout. For non-text elements, this will open the Properties panel for the selected element. For text elements, this will open the floating text-formatting toolbar.
- To remove a design element, double-click on it and then select the delete button ![Delete button](media/email-element-delete-button.png "Delete button") provided at the upper-right corner of the element.
- To move a design element, double-click to activate it, then click on the move button ![Move button](media/email-element-move-button.png "Move button")  provided at the upper-right corner of the element and drag the element to its new location.

### See also

[Design your digital content](design-digital-content.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)  
[Design elements reference](content-blocks-reference.md)


