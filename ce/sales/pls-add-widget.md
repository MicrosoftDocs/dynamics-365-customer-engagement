---
title: Add the lead scoring widget to a form
description: Learn how to display the predictive lead scoring widget on your custom forms in Dynamics 365 Sales.
ms.date: 11/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Add the lead scoring widget to a form

By default, the predictive lead scoring widget is available only in the out-of-the-box **Sales Insights** form. If you're using a customized form for leads, you can add the predictive lead scoring widget to it.

> [!IMPORTANT]

> - You can add a lead scoring widget to a form only in Unified Interface apps.
> - You can't use the legacy form designer to add a lead scoring widget to a form.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Add the lead scoring widget to a custom form

1. Sign in to the [Power Apps portal](https://make.powerapps.com/) and select an environment.

1. Select **Data** > **Tables**.

1. Open the **Lead** table, select the **Forms** tab, and then select a main form to add the widget to.

    > [!NOTE]
    > If the table to which you want to add the widget isn't listed, in the upper-right corner of the page, change the filter to **All**.

    :::image type="content" source="media/power-apps-lead-main-form.png" alt-text="Screenshot of selecting the Lead main form on the Forms tab of the Lead table.":::

1. In the form designer, select **Component** > **Layout** > **1-Column section** to add a placeholder for the widget.

    :::image type="content" source="media/power-apps-layout-add-column-form.png" alt-text="Screenshot of adding a column to the form as a placeholder.":::

1. With the placeholder column selected, select **Display** > **Predictive score**.

    > [!NOTE]
    > Make sure the placeholder column is selected. If it isn't, the widget will be added at a random place in the form.

    :::image type="content" source="media/power-select-predictive-score-widget.png" alt-text="Screenshot of selecting the Predictive score widget to display in the placeholder column.":::

1. In the **Edit predictive score** window, select **Done**.

    The predictive score widget is added to the form, as shown in the following image:

    :::image type="content" source="media/power-app-predictive-score-widget-added.png" alt-text="Screenshot of the Predictive score widget added to the form.":::

1. To hide the **New section** label, select the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.

1. Save and publish the form.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
