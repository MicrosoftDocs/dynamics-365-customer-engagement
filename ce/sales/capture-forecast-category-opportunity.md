---
title: Capture forecast category for opportunity
description: Capture the forecast category to indicate the confidence level of an opportunity getting converted into a sale.
ms.date: 05/06/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
ai-usage: ai-assisted
---
# Capture forecast category for opportunity 

Forecast categories tell your team how confident you are in closing each deal. They determine which forecast column each opportunity contributes to. For example, **Committed** (high confidence) or **Pipeline** (early-stage). Keeping forecast categories accurate ensures your forecast reflects the real state of your pipeline.

## Set the forecast confidence level for an opportunity

When you create or edit an opportunity, set its **Forecast Category** to reflect your current confidence in closing it. This value determines which column the opportunity appears in on the forecast grid.

> [!IMPORTANT]
> **Don't manually select Won or Lost.** Instead, close the opportunity using the Close Opportunity dialog; the forecast category updates automatically. Manually setting Won or Lost can cause the opportunity to disappear from the forecast or produce inaccurate rollup values. See [Close opportunities as won or lost](close-opportunity-won-lost-sales.md).

1. In the site map, select **Opportunities**.

1. Open the opportunity you want to update.
1. Switch to the **Opportunity** form if you're not already on it. By default, the **Forecast Category** field is only available on the Opportunity form.

1. In the **Forecast Category** drop-down list, select the category that best reflects your confidence, then select **Save**:

    - **Pipeline** (default): Early-stage or stalled deal, low confidence. *When to use: You just discovered this opportunity or early conversations are underway.*

    - **Best case**: Deal is progressing&mdash;you shared quotes or had substantive conversations&mdash;but no commitment yet. Medium confidence. *When to use: Customer is actively evaluating; deal could go either way.*

    - **Committed**: Customer has made a verbal or contractual commitment. High confidence. *When to use: You're mainly waiting on paperwork or final approvals.*

    - **Omitted**: Exclude this opportunity from all forecast totals. *When to use: The deal is on hold, irrelevant to this period, or you want to remove it temporarily.*

    - **Won**: Set automatically when you close an opportunity as Won. Don't select manually.

    - **Lost**: Set automatically when you close an opportunity as Lost. Don't select manually.

       :::image type="Capture forecast category on an opportunity" source="media/capture-forecast-category-opportunity-form.png" alt-text="Capture forecast category on an opportunity":::

## What happens after you set the category

After you save the opportunity with a forecast category:

- The opportunity's revenue appears in the corresponding column on the forecast grid (Pipeline, Best Case, Committed, and so on).
- When you close the opportunity as Won or Lost, the forecast category is automatically updated to match.
- Your manager and higher levels in the hierarchy see the aggregated totals including this opportunity.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[Create or edit an opportunity](create-edit-opportunity-sales.md)  

[Configure a forecast in your organization](configure-forecast.md)

[View forecasts](view-forecasts.md)

[Close opportunities as won or lost](close-opportunity-won-lost-sales.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
