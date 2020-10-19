---
title: "Configure advanced settings for a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure advanced settings for a forecast in Dynamics 365 Sales."
ms.date: 10/23/2020
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure advanced settings

Using the **Advanced** step, you can configure the following for a forecast:

- [Automatically hide parent row](#automatically-hide-parent-row)
- [Enable multi-currency selection](#enable-multi-currency-selection)
- [Customize underlying records](#customize-underlying-records)

## Automatically hide parent row

When you open a forecast, each parent node has a dedicated contributor row under the tree where individual simple columns such as quota and revenue contribution are shown. For certain organizations, these dedicated contributor rows might have null value simple columns with no revenue contributions. With **Advanced** settings, you can hide these dedicated contributor rows of parent node.

For example, you have configured a forecast based on **User** hierarchy. When the manager **Kenny Smith**, opens the forecast, he can see a row dedicated for himself with null values along with other users, though he doesn’t have any associated opportunities including simple columns. 

> [!div class="mx-imgBorder"]
> ![Forecast grid view](media/forecast-hide-row-view-manger-row.png "Forecast grid view") 

In such cases, you can hide the dedicated contributor rows of the parent node. The parent row with the rolled-up values will remain displayed. 

As an administrator or forecast manager, you can select the option **Auto-hide parent row** under **Advanced** step of the forecast configuration to hide the parent’s dedicated contributor rows. Select the toggle to enable the auto-hide parent row.

> [!NOTE]
> By default, the option is enabled.

> [!div class="mx-imgBorder"]
> ![Enable auto-hide parent row](media/forecast-hide-row-enable-auto-hide-row.png "Enable auto-hide parent row")

> [!IMPORTANT]
> Though you may select the option to hide the parent row, the row will not be hidden if the parent row has underlying records or values defined for simple columns in the forecast.

## Enable multi-currency selection


## Customize underlying records












