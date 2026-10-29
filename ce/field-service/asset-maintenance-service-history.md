---
title: SMU history and prediction (preview)
description: SMU history and prediction help you forecast maintenance. Discover how standard readings calculate usage rates and estimate when service is due for your assets.
ms.date: 10/28/2026
ms.topic: concept-article
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom: 
    - ai-gen-docs-bap
    - ai-seo-date: 08/27/2026
ai-usage: ai-assisted
---

# SMU history and prediction (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Asset service meter units (SMU) history shows how an asset’s meter changes over time. Asset maintenance in Field Service uses readings to calculate regular usage and estimate when usage-based maintenance is due.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Standard readings

A standard reading records the asset’s observed SMU value on a specific date. When you enter the reading:

- It appears in the asset’s SMU history.
- The latest accepted value updates the asset’s current SMU.
- The history contributes to the asset’s projected SMU-per-day usage.

To calculate usage over time, you need at least two accepted standard readings on different dates. The system uses the median of the valid daily segment rates within a 30-day window. This means that for each day in a 30-day period, the system calculates a segment rate. It then ignores days without usable data, sorts the remaining daily rates, and uses the median as the representative rate.

For example, during a 30-day period, a car shows the following daily mileage rates:

Monday: 20 miles/day
Tuesday: 25 miles/day
Wednesday: 22 miles/day
Thursday: 100 miles/day
Friday: 24 miles/day

Sort the values: 20, 22, 24, 25, and 100. The median (middle value) is 24 miles/day.

Additional readings update the calculation as the asset’s usage changes.

## Predict usage-based maintenance

For an SMU-based service, the system uses the asset’s current SMU, the next SMU target, and the projected SMU-per-day rate to estimate a date.

Example:

:::image type="content" source="media/asset-maintenance-predict-reading-example.png" alt-text="Screenshot of a predict use reading example.":::

The system uses the predicted date to decide whether the service event falls within the configured forecast window. If the asset doesn’t have a positive projected SMU-per-day rate, the system can’t forecast a date for usage-based maintenance.

> [!NOTE]
> A predicted date is an estimate based on recent usage. It changes when new standard readings change the asset’s median usage.

## Prepare SMU history for an asset

Prepare an asset with enough service meter units (SMU) history to forecast usage-based maintenance. A positive SMU-per-day rate is required to estimate when an asset reaches its next SMU target. Enter at least two accepted readings. The forecast uses the asset’s trailing 30-day average usage.

1. In Field Service, select **Assets** and open the customer asset.

1. Select the **SMU History** tab.

1. Under **Asset SMU History**, select **New Asset SMU History**.

1. Create a reading with a date and total value. Then, save and close it.

1. Add a second reading with a different reading date and a higher SMU value, so it represents added asset usage. Then, save it.

   :::image type="content" source="media/asset-maintenance-asset-meter-history.png" alt-text="Screenshot of SMU history for an asset showing two readings.":::

1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
