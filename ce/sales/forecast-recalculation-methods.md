---
title: Forecast recalculation methods
description: Learn about different forecast recalculation methods and when and how the forecast data is updated with an example.
author: lavanyakr
ms.author: lavanyakr01
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: get-started
ms.date: 12/21/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/21/2023
---

# Forecast recalculation methods

When you update the underlying records, adjust the forecast values, or update the forecast hierarchy, the forecast data should be recalculated to reflect the changes. Forecasts are recalculated using the following methods:

**Delta recalculation**

Delta recalculation happens immediately in the following scenarios:

- After you update the underlying records in the **Forecasts** page.

- After you adjust the forecast values.

**Full recalculation**

Full recalculation happens at the end of every month for annual periods and at the end of every day for all other periods. It takes into account the following changes:

- Updates to the underlying records on the **Opportunities** page.

- Updates to the forecast hierarchy.  

**Manual recalculation**

You can [trigger a manual recalculation](keep-forecast-data-up-to-date.md) at any time. This is useful in the following scenarios:

- You want to recalculate the forecast data for past or future periods.

- You want the full recalculation to happen immediately instead of waiting for the end of the day.

Let's understand the different methods with an example. Consider a scenario where you have a forecast with 4 quarterly periods and an annual period. Assume that you're currently in Q4. The following table shows when and how the forecast data is updated for different scenarios and periods.

| Scenario | Current quarter (Q4) | Past quarters | Annual | 
|----------|----|---------------|--------|
| You updated the estimated revenue of an underlying record from 100,000 to 200,000 on the **Forecasts** page. | Updated immediately | Updated immediately | Updated immediately |
|You updated the estimated revenue of an underlying record from 100,000 to 200,000 on the **Opportunities** page. | Updated at the end of the day | Updated only after a manual recalculation | Updated at the end of the month. | 
| You updated the forecast hierarchy. | Updated at the end of the day | Updated only after a manual recalculation | Updated at the end of the month |
| You adjusted the forecast value for Q4 | Updated immediately | Updated immediately | Updated immediately |
