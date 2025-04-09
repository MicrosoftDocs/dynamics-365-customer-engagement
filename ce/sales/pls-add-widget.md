---
title: Add the lead scoring widget to a form
description: Learn how to display the predictive lead scoring widget on your custom forms in Dynamics 365 Sales.
ms.date: 12/06/2024
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Add the lead scoring widget to a form

By default, the predictive lead scoring widget is available only in the out-of-the-box **Sales Insights** form. If you're using a customized form for leads, you can add the predictive lead scoring widget to it.

> [!IMPORTANT]

> - You can add a lead scoring widget to a form only in Unified Interface apps.
> - You can't use the legacy form designer to add a lead scoring widget to a form.

## Add the lead scoring widget to a custom form

1. Sign in to the [Power Apps portal](https://make.powerapps.com/).

1. Search for and select your organization's environment.

2. In the site map, select **Tables**, and then select the `Lead` table.

3. In the **Data experiences** section, select **Forms**.

1. Select a main form to add the widget to.

    > [!NOTE]
    > If the table to which you want to add the widget isn't listed, in the upper-right corner of the page, change the filter to **All**.

    :::image type="content" source="media/power-apps-lead-main-form.png" alt-text="Screenshot of selecting the Lead main form on the Forms tab of the Lead table.":::

1. In the form designer, select **Component** > **Layout** > **1-Column section** to add a placeholder for the widget.

    :::image type="content" source="media/power-apps-layout-add-column-form.png" alt-text="Screenshot of adding a column to the form as a placeholder.":::

1. With the placeholder column selected, select **Display** > **Predictive score**.

    > [!NOTE]
    > Make sure the placeholder column is selected. If it isn't, the widget will be added at a random place in the form.

    :::image type="content" source="media/power-select-predictive-score-widget.png" alt-text="Screenshot of selecting the Predictive score widget to display in the placeholder column.":::

1. In the **Add Predictive score** window, select **Done**.

    The predictive score widget is added to the form, as shown in the following image:

    :::image type="content" source="media/power-app-predictive-score-widget-added.png" alt-text="Screenshot of the Predictive score widget added to the form.":::

1. To hide the **New section** label, select the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.

1. Save and publish the form.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
