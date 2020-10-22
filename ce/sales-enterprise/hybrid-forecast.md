---
title: "What is a hybrid forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "What is a hybrid forecast"
ms.date: 10/22/2020
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# What is hybrid forecast

A forecast that is configured with the following characteristics is known as hybrid forecast: 

- Columns that are configured with different data types (Currency).
- Duplicate columns are configured with different data types (Quantity).

For example, you're configuring a product-based forecast in which you want to view the total revenue generated (currency) and the number of products that are sold (quantity) in the won forecast category. Here, you can't display the values in a single column. Configure two won column - one column for revenue and the other for number of products sold. You configure a won forecast category column with data type as currency to display generated revenue and the other with data type as integer to display total products. 

In the forecast, two different data types (currency and integer) are defined for won forecast category. While activating the forecast, you can't have multiple data sources to roll up the values and so, you must choose a primary data type as roll up. The forecast displays a suggestion to resolve this issue by selecting the primary data source - Currency or Quantity. After you choose the primary data source, you can continue with publishing the forecast. 

> [!NOTE]
>If you don't choose the primary data source:
>- You can't activate a forecast.
>- In predictive forecasting, deal charts and trend flows will not be displayed. 

### See also

[Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

[Choose layout and columns](choose-layout-and-columns-forecast.md)
