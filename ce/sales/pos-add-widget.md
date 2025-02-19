---
title: Add the opportunity scoring widget to a form
description: Learn how to display the predictive opportunity scoring widget on your custom forms in Dynamics 365 Sales.
ms.date: 02/19/2025
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Add the opportunity scoring widget to a form  

By default, the predictive opportunity scoring widget is available only in the out-of-the-box **Sales Insights** form. If you're using a customized form for opportunities, you can add the predictive opportunity scoring widget to it.

> [!IMPORTANT]
>
> - You can add an opportunity scoring widget to a form only in Unified Interface apps.
> - You can't use the legacy form designer to add an opportunity scoring widget to a form.

## Add the opportunity scoring widget to a custom form

1. Sign in to the [Power Apps portal](https://make.powerapps.com/).

2. Search for and select your organization's environment.

    :::image type="Select your organization" source="media/power-apps-select-org.png" alt-text="Select your organization":::

2. In the left pane, select **Tables**. On the **Tables** page, select a table to open it.

3. Open the **Data experiences**, select **Forms**.

1. Open the **Opportunity** table, select **Forms**, and then select a main form to add the widget to.

    > [!NOTE]
    > If the table to which you want to add the widget isn't listed, in the upper-right corner of the page, change the filter to **All**.

    :::image type="content" source="media/power-apps-opportunity-main-form.png" alt-text="Screenshot of selecting the Opportunity main form on the Forms tab of the Opportunity table.":::

1. In the form designer, select **Component** > **Layout** > **1-Column section** to add a placeholder for the widget.

    :::image type="content" source="media/power-apps-layout-add-column-form.png" alt-text="Screenshot of adding a column to the form as a placeholder.":::

1. With the placeholder column selected, select **Display** > **Predictive score**.

    > [!NOTE]
    > Make sure the placeholder column is selected. If it isn't, the widget will be added at a random place in the form.

    :::image type="content" source="media/power-select-predictive-score-widget.png" alt-text="Screenshot of selecting the Predictive score widget to display in the placeholder column.":::

1. In the **Edit predictive score** window, select **Done**.

    The predictive score widget is added to the form, as shown in the following image:

    :::image type="content" source="media/power-app-predictive-opportunity-score-widget-added.png" alt-text="Screenshot of the Predictive score widget added to the form.":::

1. To hide the **New section** label, select the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.

1. Save and publish the form.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
