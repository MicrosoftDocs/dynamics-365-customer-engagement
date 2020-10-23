---
title: "What is a hybrid forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "What is a hybrid forecast"
ms.date: 10/26/2020
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Forecast with multiple data type columns

You can have multiple columns with different data types such as currency and quantity in a single forecast. An example use case is, for a product-based forecast, you can have a view with both product volume numbers (quantity) and product revenue (currency) for the same forecast category column (Best case quantity and Best case revenue). 

>[!NOTE]
>To configure columns, see [Choose layout and columns](choose-layout-and-columns-forecast.md).

In general, kanban view, deal flows, and trend charts support single data type forecast only. However, with multiple data types, you must choose a data type to display in the view before activating the forecast.

Similarly, kanban view, deal flows, and trend charts can't show two columns with same selector. For example, Best case selector is used for multiple revenue columns. Showing two columns of the same category in kanban and deal flow is not appropriate. So, you must choose a revenue column to display in these views before activating the forecast. 

>[!NOTE]
>For deal flows and trend charts, you must enable premium forecasting.

let's look at few examples on how you can configure and activate these forecasts.

- [Example 1: With a forecast category, create two different currency columns and a quantity column](#same-fc-different-data-type-currency-qty)
- [Example 2: With a forecast category, create a currency column and a quantity column](#same-fc-different-data-type)
- [Example 3: With two different forecast categories, create a currency column and a quantity column](#different-fc-different-data-type)

<a name=same-fc-different-data-type-currency-qty></a>
**Example 1: With a forecast category, create two different currency columns and a quantity column**

You're configuring a forecast in which you want to see **Best case** forecast category's total amount, discount amount, and number of products sold to get this amount. You configure three **Best case** columns as following:

| Column name | Selector | Data type | Amount field |
|-------------|----------|-----------|--------------|
| *Best case* | Best case| Currency | Actual amount |
| *Best case discount* | Best case| Currency | Discount Amount |
| *Best case teams* | Best case| Integer | Number of products sold |

After you've completed the other configuration steps as required and while activating, an error message is displayed on the top of the **Activate forecast** configuration page. More information: [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

> [!div class="mx-imgBorder"]
> ![Multiple data type error](media/forecast-publish-multiple-data-type-error.png "Multiple data type error")

Select **Fix Issue** and the following **Layout warning** pane is displayed to select a primary data type to display values for the selected data type. 

> [!div class="mx-imgBorder"]
> ![Layout warnings pane](media/forecast-publish-layout-warnings-pane.png "Layout warnings pane") 

- If you select the primary data type as **Quantity**, the forecast chooses the **Best case teams** column to display in the kanban view, deal flows, and trend charts as the **Best case teams** column is the only column that has a quantity (integer) data type. You can proceed with activating the forecast as there is no conflict between the columns display. 
    
    > [!div class="mx-imgBorder"]
    > ![Select primary data type as quantity](media/forecast-data-type-select-quantity.png "Select primary data type as quantity") 

- If you select the primary data type as **Currency**, the forecast has to choose between **Best case** and **Best case discount** columns to display in the kanban view, deal flows, and trend charts, as both these columns have **Currency** as data type and are of the same selector (Best case). Choose the column appropriately and save. 

    > [!div class="mx-imgBorder"]
    > ![Select primary data type as currency and choose column](media/forecast-data-type-select-currency-choose-column.png "Select primary data type as currency and choose column") 

<a name=same-fc-different-data-type></a>
**Example 2: With a forecast category, create a currency column and a quantity column**

You're configuring a forecast in which you want to see **Best case** forecast category's total amount and number of products sold to get this amount. You configure two **Best case** columns as following:

| Column name | Selector | Data type | Amount field |
|-------------|----------|-----------|--------------|
| *Best case* | Best case| Currency | Actual amount |
| *Best case teams* | Best case| Integer | Number of products sold |

After you've completed the other configuration steps as required and while activating, an error message is displayed on the top of the **Activate forecast** configuration page. More information: [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

> [!div class="mx-imgBorder"]
> ![Multiple data type error](media/forecast-publish-multiple-data-type-error.png "Multiple data type error")

Select **Fix Issue** and the following **Layout warning** pane is displayed to select a primary data type to display values for the selected data type. 

> [!div class="mx-imgBorder"]
> ![Layout warnings pane](media/forecast-publish-layout-warnings-pane.png "Layout warnings pane") 

Select the primary data type as required. The selector is same for **Best case** (currency) and **Best case teams** (quantity) columns and the difference is with the data type. Choose  a data type to display the column in the kanban view, deal flows, and trend charts.

<a name=different-fc-different-data-type></a>
**Example 3: With two different forecast categories, create a currency column and a quantity column**

You're configuring a forecast in which you want to see the total revenue of **Won** forecast category and see the teams that you have worked with under the **Best case** forecast category. You configure the **Won** and **Best case** columns as following:

| Column name | Selector | Data type | Amount field |
|-------------|----------|-----------|--------------|
| *Won* | Won | Currency | Actual amount |
| *Best case teams* | Best case| Integer | Number of products sold |

After you've completed the other configuration steps as required and while activating, an error message is displayed on the top of the **Activate forecast** configuration page. More information: [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

> [!div class="mx-imgBorder"]
> ![Multiple data type error](media/forecast-publish-multiple-data-type-error.png "Multiple data type error")

Select **Fix Issue** and the following **Layout warning** pane is displayed to select a primary data type to display values for the selected data type. 

> [!div class="mx-imgBorder"]
> ![Layout warnings pane](media/forecast-publish-layout-warnings-pane.png "Layout warnings pane") 

Select the primary data type as required. Since the **Won** (currency) and **Best case** (quantity) columns has different selectors and data types, you must choose a primary data type to display in the kanban view, deal flows, and trend charts.

### See also

[Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

[Choose layout and columns](choose-layout-and-columns-forecast.md)
