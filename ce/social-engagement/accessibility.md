---
title: "Accessibility for Social Engagement | Microsoft Docs"
description: "Learn about the accessibility features in general and specifically in Social Engagement."
keywords: "ease of access, acessibility, a11y, screen reader, color patterns"
ms.date: 01/08/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 0742a7c8-2fe9-483b-baa6-1907edad0300
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Accessibility for Microsoft Social Engagement
[Microsoft is committed to building software that enables people with different abilities](http://go.microsoft.com/fwlink/p/?LinkId=526256) to be productive. 

[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] enables all users to be productive by providing accessible software that can be used effortlessly, irrespective of abilities. 

## Accessibility capabilities built into Social Engagement

### Switch to the table view to improve readability of data points

All charts in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] can be switched to a table view. This means that every user can decide whether they want to explore the data represented as charts or as tables.
You can either turn on the table view on single charts by selecting the … control on the chart you want to change and then selecting the **Switch to table mode** option.    
To enable the table view for your user profile by default, go to **Settings > User Preferences** and change the value under **Chart data representation mode**.

### Change how colors on charts are displayed

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] also provides a filling pattern for charts with colored areas. You can choose to render the charts with a filling patterns or solid colors. To switch between filling pattern and solid color, go to **Settings > User Preferences** and update the **Chart filling mode**.

> [!NOTE]
> The Analytics area in Social Engagement renders the data in charts by default. Data points in charts aren’t accessible with keyboard navigation. You can either turn on the table view on single charts when working in the Analytics area, or you can enable the table view globally for your user profile in **Settings > User Preferences** under **Chart data representation mode**. 
> To change the solid colors to a filling pattern for better visual distinction, go to **Settings > User Preferences** and update the **Chart filling mode**.

### Navigate post list and post details with keyboard

Whenever Social Engagement shows posts, you are presented with a post list and a detail view for a specific post. Keyboard navigation in the list is solved by treating it as a layout grid which has a single tab stop. 

Once the focus is in the post list, you can use arrow keys and Enter to navigate:

- Each post is a row with several cells. To move within a row, use left and right arrow keys. 
- To move to the next row (the next post), use up and down arrow keys. Focus will move the same cell type in the next row.
- If a cell contains a single control, the focus will move to the control. Simply activate the control to interact with it. Example: “Open” control to open post details.
- If a cell contains content and several controls, the focus is set to the cell border. To interact with the elements inside this cell select the Enter key to move focus into the cell. In this mode, you can interact with each element in this cell including activating controls: Use the arrow keys to move focus. To leave a cell, select the Escape key to move the focus back onto the cell border again.

When navigating the Post details view, which shows the post and a parent post, you can collapse or expand the contents:

- Moving the focus with the Tab key will bring you to the heading for “parent” and “child” post which serve as collapse/expand buttons. 
- When collapsed, the post preview won’t receive focus.
- When expanded the post’s content and all possible actions can be reached by moving focus with the Tab key.
- Whenever one of those posts is expanded, the other is collapsed. 
- The Post details view can contain several threads. These can be navigated exactly like the post list.

### Accessibility in applications that can work with Social Engagement data

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] provides integrations and data export for other applications. 

- We recommend using the [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] content pack with [Power BI Desktop](https://docs.microsoft.com/power-bi/desktop-accessibility).
- Learn more about [accessibility for Dynamics 365 Customer Engagement](https://docs.microsoft.com/dynamics365/customer-engagement/basics/accessibility-people-with-disabilities) apps. 

## General accessibility capabilities 

### Work with a screen reader

Commonly used screen readers are supported, empowering the blind, visually impaired, or people with learning disabilities. 

- [Learn more about working with Microsoft Narrator](https://support.microsoft.com/en-us/help/22798)
- [Learn more about working with JAWS](http://www.freedomscientific.com/Products/Blindness/JawsDocumentation)
- [Learn more about working with NVDA](https://www.nvaccess.org/help/)

### Use the keyboard to navigate the user interface

Full keyboard accessibility for all user interface elements to empower agents with different motor skills, and to help agents save critical seconds by removing the dependency on a mouse. 
[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] supports basic keyboard navigation patterns, like switching between elements and selecting them. There are no keyboard shortcuts specific to [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)].

### Heighten color contrast of some text and images

The high contrast setting in Windows heightens the color contrast of some text and images on your computer screen, making those items more distinct and easier to identify. You’ll find this setting on the Ease of Access page in [Windows 10](http://www.microsoft.com/enable/products/windows10/default.aspx), [Windows 8](http://www.microsoft.com/enable/products/windows8/default.aspx), and [Windows 7](http://www.microsoft.com/enable/products/windows7/default.aspx).

### Enlarge the user interface with zooming in the browser

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] supports zooming on the user interface to 200% of the original screen size and works with the High Contrast settings in either your browser or operating system.
NOTE: 
When zooming the user interface to 200%, some controls on individual charts are hidden. You can chance the zoom level to access these controls. 

For accessibility information for specific browsers, visit the following websites:  
  
-   [Microsoft Edge accessibility](https://docs.microsoft.com/microsoft-edge/accessibility)  
  
-   [Firefox accessibility features](http://support.mozilla.org/kb/accessibility-features-firefox-make-firefox-and-we?redirectlocale=en-US&redirectslug=accessibility)  
  
-   [Safari accessibility features](http://www.apple.com/support/accessibility/)  
  
-   [Google Chrome accessibility features](https://sites.google.com/a/chromium.org/dev/user-experience)  
  
For more information on detailed accessibility features built into Microsoft products, refer to [Section 508 VPATs for Microsoft products](https://enterprise.microsoft.com/en-us/industries/government/section-508-vpats-for-microsoft-products/).  
  
### See Also  

[Get connected to the social conversation using Microsoft Social Engagement](get-connected-social-conversation.md)
 
