---
title: "Use screen reader with Unified Interface apps in Dynamics 365 Customer Engagement (on-premises)"
description: "Learn about using a screen reader with Dynamics 365 Customer Engagement (on-premises) and finding your way around Unified Interface apps."
keywords: 
author: shwetamurkute
applies_to: Dynamics 365 Customer Engagement (on-premises)
ms.author: smurkute
ms.topic: article

ms.assetid: 5424660b-743b-434f-9993-fb64ae4e776a
ms.custom: 
  - dyn365-a11y
search.audienceType: 
  - enduser

---
# Use a screen reader in Unified Interface apps in Dynamics 365 Customer Engagement (on-premises)

::: moniker range=">= op-9-1"


[!INCLUDE [applies-to-unified-interface](../includes/applies-to-unified-interface.md)] [Use a screen reader](/powerapps/user/screen-reader)

Screen readers make Dynamics 365 Customer Engagement (on-premises) accessible to people who have low or no vision or may need some extra support for a temporary scenario, such as eye fatigue. Commonly used screen readers such as Narrator, JAWS, and NVDA are supported. 

- [Learn more about working with Microsoft Narrator](https://support.microsoft.com/help/22798)
- [Learn more about working with JAWS](https://www.freedomscientific.com/Products/Blindness/JawsDocumentation)
- [Learn more about working with NVDA](https://www.nvaccess.org/)

> [!NOTE]
> JAWS screen reader is supported on the latest Unified Interface. If choosing JAWS, we recommend using it with Internet Explorer. 
> 
> Narrator is a screen-reading app built into Windows 10. Apps built using [Unified Interface](../admin/about-unified-interface.md) are optimized for Narrator. This topic assumes that you are using Narrator on Microsoft Edge. 

## Basic tasks using a screen reader with Dynamics 365 Customer Engagement (on-premises)

### Open a Unified Interface-based app
Although you can use a screen reader anywhere in Dynamics 365 Customer Engagement (on-premises), we have made enhancements to Unified Interface apps that make using a screen reader more consistent. For a full list of Unified Interface apps available in Dynamics 365 Customer Engagement (on-premises), visit [About Unified Interface in Dynamics 365 Customer Engagement (on-premises)](../admin/about-unified-interface.md).


Use the [app switcher](where-find-business-apps.md) in Dynamics 365 Customer Engagement (on-premises) to open a Unified Interface app.

1.  On the navigation bar, use the **Tab** key to move to the Dynamics 365 Customer Engagement (on-premises) drop-down control and press **Enter** to open the site map.
2.  Press the **Tab** key until you hear the name of the application you want to open—for example, "Sales Hub." Press **Enter** to open the app.

### Use scan mode in Narrator
You can use scan mode to quickly navigate Dynamics 365 Customer Engagement (on-premises) using the arrow keys and common keyboard shortcuts. Quickly jump to headings, links, landmarks, form fields, controls, and tables in this mode. Turn scan mode on and off by pressing **Caps lock+Spacebar**. More information: [Using scan mode](https://support.microsoft.com/help/22809/windows-10-narrator-using-scan-mode).

### Find your way around the Unified Interface apps
We have made Dynamics 365 Customer Engagement (on-premises) that are based on Unified Interface more consistent and reliable with screen readers. This includes working with screen readers on grids, forms, charts, streams, and business process flows. 

#### Navigation bar
When you open a Unified Interface app, a vertical bar with subarea icons is displayed at the left side of the application. You can either use the **Tab** key to move through these icons until you hear the name of the subarea you want, such as "Opportunities," or you can use the site map control. For example, press the **Tab** key until you hear "Accounts" and then press **Enter** to open the Accounts view.

#### Grids
Screen readers navigate grids more reliably and consistently, and announce row and column headings, as well as the position within the grid. When you first open a grid, the default tab stop is the view selector. 

Whenever you enter a cell within the grid from outside of the grid, Narrator announces the name of the table, the row and column counts, and the position of your cursor within the table.

If your cursor is within the table header, quickly navigate between headers by using **Tab** or **Shift+Tab**. Narrator will announce the name of each header as you enter the header cell. It also announces the type of cell (for example, "column header"), the location of the column (for example, "column 1 of 6"), and whether the column is sorted or selected. If you press the **Enter** key in a table header, it will sort the table by that column. Narrator announces the sort order, and you can press **Enter** again to change the order.

When you move out of the last column in the table, the cursor moves to the second row of the grid, and from this point, you must use the Up and Down arrow keys to navigate between the non-header cells. If you instead press the **Tab** key again, your cursor will move to the next interactive element, typically the table filter list. When moving between non-header row cells, Narrator announces the column name, the location of the column, and text within the cell.

#### Forms
Multiple navigation modes are available for navigating a form using Narrator, with the most common modes being landmarks, headings, and form fields. To change the navigation mode, press **Caps lock+Up arrow**. Hold the Caps lock key down while pressing the Up arrow key to cycle through the modes until you hear the mode you want to use. Then use Caps lock + the Left/Right arrow keys to navigate through the various items. For example, if you want to go to the Last Name field in the Contact Information section of a Contact, do the following:

1.  Press and hold the **Caps lock** key and press the **Up arrow** key until you hear "Landmarks."
2.  Press and hold the **Caps lock** key and press the **Right arrow** key until you hear "Contact information."
3.  Change the mode by pressing and holding the **Caps lock** key and pressing the **Up arrow** key until you hear "Form Fields."
4.  Navigate to the Last Name field by using Caps lock + the Left/Right arrow keys until you hear "Last Name." Narrator also announces the control type, value, state, and any special instructions for the field.

You can also use the Tab key to quickly navigate to interactive elements on the form. Some form fields have an icon that will perform the default action when you press Ctrl+Enter. For example, an email form field might have an envelope icon that opens an email editor. 

#### Dashboards/charts
You can navigate through the dashboard charts using the Tab key and Caps lock + arrow keys. Press the **Tab** key to quickly go to the interactive elements and use Caps lock + an arrow key for navigation of non-interactive elements, such as headings, landmarks, and items.

> [!NOTE]
> You must have the latest [Windows 10](https://www.microsoft.com/enable/products/windows10/default.aspx) Update installed to have all of the accessibility features available for charts.

#### Interactive Dashboard Streams
You can use the **Tab** key or **Shift+Tab** keys to move between interactive dashboard streams, such as found in the Accounts dashboard, or just change the navigation mode until you hear "Headings" and then use the **Tab** key to quickly move between dashboard streams.

To navigate through each element of a dashboard stream, use the Up/Down arrow keys. Narrator will read the type of control and the title of the control.

#### Business process flows
You can navigate a business process flow, such as the one found at the top of the Lead form, by pressing the **Tab** key to move forward, and **Shift+Tab** to move backward between the entities. Use the **Enter** key on the **Move to the Left** or **Move to the Right** buttons to display additional entities in the process flow. Narrator reads the entity type, stage, status, title, element number out of total elements, and whether it is currently selected.

#### Dialog boxes

When a dialog box opens, Navigator announces the title. For dialog boxes with input fields, the **Close** button has the default focus, allowing you to close the dialog box by pressing the **Enter** key. For dialog boxess that require user action, the focus is on the primary action button, such as **Delete** or **OK**.

You can navigate through the controls by using the **Tab** key. The cursor will loop through each element in the dialog box, and you can press the **Esc** key to close it.




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]



::: moniker-end

::: moniker range="< op-9-1"


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Use a screen reader](/powerapps/user/screen-reader)

Screen readers make Dynamics 365 Customer Engagement (on-premises) accessible to people who have low or no vision or may need some extra support for a temporary scenario, such as eye fatigue. Commonly used screen readers such as Narrator, JAWS, and NVDA are supported. 

- [Learn more about working with Microsoft Narrator](https://support.microsoft.com/help/22798)
- [Learn more about working with JAWS](https://www.freedomscientific.com/Products/Blindness/JawsDocumentation)
- [Learn more about working with NVDA](https://www.nvaccess.org/get-help/)

> [!NOTE]
> JAWS screen reader is supported on the latest Unified Interface. If choosing JAWS, we recommend using it with Internet Explorer. 
> 
> Narrator is a screen-reading app built into Windows 10. Apps built using [Unified Interface](../admin/about-unified-interface.md) are optimized for Narrator. This topic assumes that you are using Narrator on Microsoft Edge. 

## Basic tasks using a screen reader with Dynamics 365 Customer Engagement (on-premises)

### Open a Unified Interface-based app
Although you can use a screen reader anywhere in Dynamics 365 Customer Engagement (on-premises), we have made enhancements to Unified Interface apps that make using a screen reader more consistent. For a full list of Unified Interface apps available in Dynamics 365 Customer Engagement (on-premises), visit [About Unified Interface in Dynamics 365 Customer Engagement (on-premises)](../admin/about-unified-interface.md).


Use the [app switcher](where-find-business-apps.md) in Dynamics 365 Customer Engagement (on-premises) to open a Unified Interface app.

1.  On the navigation bar, use the **Tab** key to move to the Dynamics 365 Customer Engagement (on-premises) drop-down control and press **Enter** to open the site map.
2.  Press the **Tab** key until you hear the name of the application you want to open—for example, "Sales Hub." Press **Enter** to open the app.

### Use scan mode in Narrator
You can use scan mode to quickly navigate Dynamics 365 Customer Engagement (on-premises) using the arrow keys and common keyboard shortcuts. Quickly jump to headings, links, landmarks, form fields, controls, and tables in this mode. Turn scan mode on and off by pressing **Caps lock+Spacebar**. More information: [Using scan mode](https://support.microsoft.com/help/22809/windows-10-narrator-using-scan-mode).

### Find your way around the Unified Interface apps
We have made Dynamics 365 Customer Engagement (on-premises) that are based on Unified Interface more consistent and reliable with screen readers. This includes working with screen readers on grids, forms, charts, streams, and business process flows. 

#### Navigation bar
When you open a Unified Interface app, a vertical bar with subarea icons is displayed at the left side of the application. You can either use the **Tab** key to move through these icons until you hear the name of the subarea you want, such as "Opportunities," or you can use the site map control. For example, press the **Tab** key until you hear "Accounts" and then press **Enter** to open the Accounts view.

#### Grids
Screen readers navigate grids more reliably and consistently, and announce row and column headings, as well as the position within the grid. When you first open a grid, the default tab stop is the view selector. 

Whenever you enter a cell within the grid from outside of the grid, Narrator announces the name of the table, the row and column counts, and the position of your cursor within the table.

If your cursor is within the table header, quickly navigate between headers by using **Tab** or **Shift+Tab**. Narrator will announce the name of each header as you enter the header cell. It also announces the type of cell (for example, "column header"), the location of the column (for example, "column 1 of 6"), and whether the column is sorted or selected. If you press the **Enter** key in a table header, it will sort the table by that column. Narrator announces the sort order, and you can press **Enter** again to change the order.

When you move out of the last column in the table, the cursor moves to the second row of the grid, and from this point, you must use the Up and Down arrow keys to navigate between the non-header cells. If you instead press the **Tab** key again, your cursor will move to the next interactive element, typically the table filter list. When moving between non-header row cells, Narrator announces the column name, the location of the column, and text within the cell.

#### Forms
Multiple navigation modes are available for navigating a form using Narrator, with the most common modes being landmarks, headings, and form fields. To change the navigation mode, press **Caps lock+Up arrow**. Hold the Caps lock key down while pressing the Up arrow key to cycle through the modes until you hear the mode you want to use. Then use Caps lock + the Left/Right arrow keys to navigate through the various items. For example, if you want to go to the Last Name field in the Contact Information section of a Contact, do the following:

1.  Press and hold the **Caps lock** key and press the **Up arrow** key until you hear "Landmarks."
2.  Press and hold the **Caps lock** key and press the **Right arrow** key until you hear "Contact information."
3.  Change the mode by pressing and holding the **Caps lock** key and pressing the **Up arrow** key until you hear "Form Fields."
4.  Navigate to the Last Name field by using Caps lock + the Left/Right arrow keys until you hear "Last Name." Narrator also announces the control type, value, state, and any special instructions for the field.

You can also use the Tab key to quickly navigate to interactive elements on the form. Some form fields have an icon that will perform the default action when you press Ctrl+Enter. For example, an email form field might have an envelope icon that opens an email editor. 

#### Dashboards/charts
You can navigate through the dashboard charts using the Tab key and Caps lock + arrow keys. Press the **Tab** key to quickly go to the interactive elements and use Caps lock + an arrow key for navigation of non-interactive elements, such as headings, landmarks, and items.

> [!NOTE]
> You must have the latest [Windows 10](https://www.microsoft.com/enable/products/windows10/default.aspx) Update installed to have all of the accessibility features available for charts.

#### Interactive Dashboard Streams
You can use the **Tab** key or **Shift+Tab** keys to move between interactive dashboard streams, such as found in the Accounts dashboard, or just change the navigation mode until you hear "Headings" and then use the **Tab** key to quickly move between dashboard streams.

To navigate through each element of a dashboard stream, use the Up/Down arrow keys. Narrator will read the type of control and the title of the control.

#### Business process flows
You can navigate a business process flow, such as the one found at the top of the Lead form, by pressing the **Tab** key to move forward, and **Shift+Tab** to move backward between the entities. Use the **Enter** key on the **Move to the Left** or **Move to the Right** buttons to display additional entities in the process flow. Narrator reads the entity type, stage, status, title, element number out of total elements, and whether it is currently selected.

#### Dialog boxes

When a dialog box opens, Navigator announces the title. For dialog boxes with input fields, the **Close** button has the default focus, allowing you to close the dialog box by pressing the **Enter** key. For dialog boxess that require user action, the focus is on the primary action button, such as **Delete** or **OK**.

You can navigate through the controls by using the **Tab** key. The cursor will loop through each element in the dialog box, and you can press the **Esc** key to close it.






[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

::: moniker-end
