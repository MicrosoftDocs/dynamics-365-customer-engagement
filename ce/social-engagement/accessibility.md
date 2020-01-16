---
title: "Accessibility for Social Engagement | Microsoft Docs"
description: "Learn about accessibility features in general and specifically in Social Engagement."
keywords: ease of access, accessibility, a11y, screen reader, color patterns
ms.date: 06/11/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - Social Engagement
ms.assetid: 0742a7c8-2fe9-483b-baa6-1907edad0300
author: m-hartmann
ms.author: mhart
manager: shellyha
ms.custom:
  - dyn365-a11y
  - dyn365-socialengagement
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365SE
---

# Accessibility for [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)]

[!INCLUDE [mse-service-discontinuation](../includes/mse-service-discontinuation.md)]

[Microsoft is committed to building software that enables people with different abilities](https://go.microsoft.com/fwlink/p/?LinkId=526256) to be productive.
[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] enables all users to be productive by providing accessible software that can be used effortlessly, regardless of abilities.

## Accessibility capabilities built into [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)]

### Switch to the table view to improve readability of data points

Widgets in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] can show in a chart view or a table view. You can decide whether you want to work with the data represented as charts or as tables.
You can turn on the table view for a widget in chart view by selecting the ![More options control](media/more-options-icon.png "More options control") control on the chart you want to change and then selecting the **Switch to table view** option. To switch back, open the same control and select **Switch to chart view**.
To enable the table view for all widgets by default, go to **Settings > User Preferences** and change the value under **Chart data representation mode** from **Chart** to **Table**.

### Change how colors on charts are displayed

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] also provides a fill pattern for charts with colored areas. You can choose to render the charts with a fill pattern or a solid color. To switch between a fill pattern and solid color, go to **Settings > User Preferences** and update the **Chart filling mode**.

When selecting the fill pattern, data on maps will be represented in different shapes and will not rely exclusively on color.

> [!NOTE]
> The Analytics area in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] renders the data in charts by default. Data points in charts aren’t accessible with keyboard navigation. You can either turn on the table view on single charts when working in the Analytics area, or you can enable the table view globally for your user profile in **Settings > User Preferences** under **Chart data representation mode**.
> To change the solid colors to a fill pattern for better visual distinction, go to **Settings > User Preferences** and update the **Chart filling mode**.

### Navigate post list and post details with your keyboard

Whenever [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] shows posts, you are presented with a post list and a detail view for a specific post. Keyboard navigation in the list is solved by treating it as a layout grid that has a single tab stop.

Once the focus is in the post list, you can use arrow keys and Enter to navigate:

- Each post is a row with several cells. To move within a row, use left and right arrow keys.
- To move to the next row (the next post), use up and down arrow keys. Focus will move the same cell type in the next row.
- If a cell contains a single control, the focus will move to the control. Simply activate the control to interact with it. Example: “Open” control to open post details.
- If a cell contains content and several controls, the focus is set to the cell border. To interact with the elements inside this cell select the Enter or F2 key to move focus into the cell. In this mode, you can interact with each element in the cell, including activating controls: Use the arrow keys to move focus. To leave a cell, select the Escape or F2 key to move the focus back onto the cell border again.

When navigating the Post details view, which shows the post and a parent post, you can collapse or expand the contents:

- Move the focus using the Tab key to go to the heading for “parent” and “child” posts, which serve as collapse/expand buttons.
- When collapsed, the post preview won’t receive focus.
- When expanded, the post’s content and all possible actions can be reached by moving focus with the Tab key.
- Whenever one of those posts is expanded, the other is collapsed.
- The post details view can contain several threads. These can be navigated exactly like the post list.

### Navigate maps with keyboard

#### Analytics

You can navigate the maps in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] with a keyboard by selecting Tab to reach the first data point on a map. The order of navigation is based on sorting the data points by latitude, from north to south. The first tab stop starts on the northernmost data point.

- To move to the next data point, select the right or down arrow.
- To move to the previous data point, select the left or up arrow.

#### Activity maps

Activity maps let you read the data either by analyzing the data on the visual map or from the table view, which can be turned on using the **Switch to table view** control.
To navigate the data on the visual activity map, select Tab until you reach a data point on the map. Then you can use the arrow keys to browse through all data points on the map. The arrow keys indicate the direction where the next data point will be:
- Left arrow: the closest data point in the west
- Up arrow: the closest data point in the north
- Right arrow: the closest data point in the east
- Down arrow: the closest data point in the south

To navigate the data in the cells of the table view, select the arrow keys.

To use the area filter with a keyboard, select Tab until you reach the **Area filter** and provide coordinates for two corner points of the rectangular area filter. Provide the latitude and longitude for Point A and for Point B. Tab to the **Save** control and select Enter to activate the area filter. Only data that matches your area filter is now shown in your map/table.


## Accessibility in applications that can work with [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] data

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] provides integrations and data export for other applications.

- We recommend using the [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] content pack with [Power BI Desktop](https://docs.microsoft.com/power-bi/desktop-accessibility) due to accessibility support of [Power BI Desktop](https://powerbi.microsoft.com/desktop/).
- Learn more about [accessibility for Dynamics 365 for Customer Engagement](https://docs.microsoft.com/dynamics365/customer-engagement/basics/accessibility-people-with-disabilities) apps.

## General accessibility capabilities

### Work with a screen reader

Commonly used screen readers are supported, empowering the blind, visually impaired, or people with learning disabilities.

- [Learn more about working with Microsoft Narrator](https://support.microsoft.com/help/22798)
- [Learn more about working with JAWS](https://www.freedomscientific.com/Products/Blindness/JawsDocumentation)
- [Learn more about working with NVDA](https://www.nvaccess.org/get-help/)

### Use the keyboard to navigate the user interface

Full keyboard accessibility for all user interface elements to empower agents with different motor skills, and to help agents save critical seconds by removing the dependency on a mouse.
[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] supports basic keyboard navigation patterns, like switching between elements and selecting them. There are no keyboard shortcuts specific to [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)].

All tables in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] follow the same keyboard access pattern:

- A table has only one tab stop.
- Each table row can have several cells. To move within a row, use the left and right arrow keys.
- To move to the next row, use the up and down arrow keys. Focus will move the same cell type in the next row.
- If a cell contains a single control, the focus will move to the control. Simply activate the control to interact with it. Example: “Remove” control to remove the item of that row.
- If a cell contains content and/or several controls, the focus is set to the cell border. To interact with the elements inside this cell select the Enter or F2 key to move focus into the cell. In this mode, you can interact with each element in this cell including activating controls by using the arrow keys to move focus. To leave a cell, select the Escape or F2 key to move the focus back onto the cell border.

### Heighten color contrast of some text and images

The high contrast setting in Windows heightens the color contrast of some text and images on your computer screen, making those items more distinct and easier to identify. You’ll find this setting on the Ease of Access page in [Windows 10](https://www.microsoft.com/enable/products/windows10/default.aspx), [Windows 8](https://www.microsoft.com/enable/products/windows8/default.aspx), and [Windows 7](https://www.microsoft.com/enable/products/windows7/default.aspx).

### Enlarge the user interface with zooming in the browser

[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] supports zooming on the user interface to 200 percent of the original screen size and works with the high contrast settings in either your browser or operating system.

> [!NOTE]
> When zooming the user interface to 200 percent, some fields or controls are hidden to keep it readable. We aim only to hide information and controls that aren't required to complete a task. You can change the zoom level to access these controls.

For accessibility information for specific browsers, visit the following websites:

-   [Microsoft Edge accessibility](https://docs.microsoft.com/microsoft-edge/accessibility)

-   [Firefox accessibility features](https://support.mozilla.org/kb/accessibility-features-firefox-make-firefox-and-we?redirectlocale=en-US&redirectslug=accessibility)

-   [Safari accessibility features](https://www.apple.com/support/accessibility/)

-   [Google Chrome accessibility features](https://sites.google.com/a/chromium.org/dev/user-experience)

For more information on detailed accessibility features built into Microsoft products, refer to [Section 508 VPATs for Microsoft products](https://enterprise.microsoft.com/industries/government/section-508-vpats-for-microsoft-products/).

### See Also

[Social Engagement overview](overview.md)
[Manage user preferences](user-preferences.md)
