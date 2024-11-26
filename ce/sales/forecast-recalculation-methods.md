---
title: Forecast recalculation methods
description: Learn about different forecast recalculation methods and when and how the forecast data is updated with an example.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual
ms.collection: get-started
ms.date: 09/17/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/21/2023
---

# Forecast recalculation methods

When you update the underlying records, adjust the forecast values, or update the forecast hierarchy, the forecast data should be recalculated to reflect the changes. Forecasts are recalculated using the methods described in this article.

## Automatic delta recalculation

Delta recalculation happens immediately in the following scenarios:

- After you update the underlying records in the **Forecasts** page.

- After you adjust the forecast values.

## Automatic full recalculation

Full recalculation happens at the end of every month for annual periods and at the end of every day for the current period. The forecast must be in active state. This method takes into account the following changes:

- Updates to the underlying records outside of the **Forecasts** page. For example, updates to the underlying records on the **Opportunities** page.

- Updates to the forecast hierarchy.  

## Manual full recalculation

You can [trigger a manual recalculation](keep-forecast-data-up-to-date.md) at any time. This is useful in the following scenarios:

- You want to recalculate the forecast data for past or future periods.

- You want the full recalculation to happen immediately instead of waiting for the end of the day.

## Example of forecast recalculation methods

Let's understand the different methods with an example. Consider a scenario where you have a forecast with 4 quarterly periods and an annual period. Assume that you're currently in Q4. The following table shows when and how the forecast data is updated for different scenarios and periods.

| Scenario | Current quarter (Q4) | Past quarters | Annual | 
|----------|----|---------------|--------|
| You updated the estimated revenue of an underlying opportunity from 100,000 to 200,000 on the **Forecasts** page. | Updated immediately | Updated immediately | Updated immediately |
|You updated the estimated revenue of an underlying opportunity from 100,000 to 200,000 on the **Opportunities** page. | Updated at the end of the day | Updated only after a manual recalculation | Updated at the end of the month. | 
| You updated the forecast hierarchy. | Updated at the end of the day | Updated only after a manual recalculation | Updated at the end of the month |
| You adjusted the forecast value for Q4 | Updated immediately | Updated immediately | Updated immediately |

## What happens during recalculation?

When recalculation happens, the following updates are made to the forecast data:

-	The aggregation and roll-ups for the underlying data are recalculated.

-	Any other changes affecting the forecast values are refreshed.

- Changes to the forecast hierarchy are applied only after a full recalculation.

> [!NOTE]
> - Only the current forecast period is recalculated when the daily job runs.
> - No changes are made to the forecast values that were manually adjusted.
> - No changes are made to the **Prediction** column. Predictions are only recalculated after every seven days. Hover over the information icon on the column header to view the last recalculation date.
