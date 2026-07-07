---
title: Forecasting management FAQs
description: Get answers to frequently asked questions about forecasting management.
ms.date: 07/07/2026
ms.topic: faq
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
ai-usage: ai-assisted
---

# Forecasting management FAQs

This article answers frequently asked questions about forecasting management in Dynamics 365 Sales.

Questions are organized by topic:
- [Access and ownership](#who-owns-the-forecast)
- [Data and calculations](#how-do-i-change-the-forecast-calculation-for-lost-opportunities)
- [Best practices](#how-should-i-mark-an-opportunity-as-won-or-lost-in-a-forecast)
- [Troubleshooting](#why-is-my-forecast-showing-0-or-unexpected-values)

## Who owns the forecast?

The forecast owner is defined in the **Permissions** step of the forecast configuration. To find the owner:

1. In the Sales Hub app, select **App Settings**.
1. Under **Performance management**, select **Forecast configuration**.
1. Select the forecast configuration, then select the **Permissions** step.
1. Check the **Owner lookup field** to see who owns the forecast.
  
:::image type="content" source="media/user-security-field.png" alt-text="Screenshot of the Owner lookup field in the Permissions step.":::
  
For more information, go to [Define the forecast owner](provide-permissions-forecast.md#define-the-forecast-owner).
  
## How do I change the forecast calculation for lost opportunities?

By default, lost opportunities use **Actual Revenue** in the forecast. To switch to **Estimated Revenue**:

1. Go to **App Settings** > **Forecast configuration**.
1. Select your forecast and go to the **Layout** step.
1. Find the **Lost** forecast category column and open its settings.
1. In the **Amount** field, select **Est. Revenue**.
1. Save your changes.

For more information, see [Choose layout and columns](choose-layout-and-columns-forecast.md).

## How should I mark an opportunity as Won or Lost in a forecast?

Always close the opportunity using the **Close Opportunity** dialog in the opportunity form. The forecast category (**Won** or **Lost**) is then updated automatically by the system.

> [!IMPORTANT]
> Don't manually set the forecast category to **Won** or **Lost** in the opportunity form. Doing so can cause the opportunity to disappear from your forecast, because forecasts are configured to recognize **Won** only when Actual Revenue and Actual Close Date are available. Manually setting the category bypasses this logic and produces inaccurate rollup values.

For more information, see [Close opportunities as won or lost](close-opportunity-won-lost-sales.md).

## Why is my forecast showing $0 or unexpected values?

There are a few common causes:

- **Opportunities aren't in the forecast hierarchy:** Check whether your opportunities are assigned to users or territories that are part of the forecast hierarchy.
- **Forecast category mismatch:** The opportunity's forecast category might not match the columns defined in your forecast layout. For example, if you use a custom option set instead of the default forecast categories, ensure the column selectors are configured to match. See [Choose layout and columns](choose-layout-and-columns-forecast.md).
- **Data hasn't been recalculated:** If you recently updated opportunities on the Opportunities page, trigger a manual recalculation. See [Recalculate forecasts manually](keep-forecast-data-up-to-date.md).
- **Access permissions:** You may not have been granted access to the forecast. Contact your administrator. See [Provide permissions to access a forecast](provide-permissions-forecast.md).

## How do I exclude an opportunity from the forecast?

Set the opportunity's **Forecast Category** to **Omitted**. The opportunity's revenue won't be included in any forecast column totals, but the record remains in the system. See [Capture forecast category for opportunity](capture-forecast-category-opportunity.md).

## Can I have multiple active forecasts at the same time?

Yes. You can activate multiple forecast configurations simultaneously. For example, you can run a revenue-based org chart forecast alongside a product-quantity forecast. Each forecast is independent. See [Configure forecasts in your organization](configure-forecast.md).

## How often does forecast data refresh automatically?

- **Changes made on the Forecasts page** (including value adjustments): Reflected immediately.
- **Changes made on the Opportunities page**: Reflected by end of day for the current period.
- **Past and future periods**: Only updated by a manual recalculation.
- **Predictions (premium forecasting)**: Recalculated every seven days automatically; can't be triggered manually.

For a full breakdown, see [Forecast recalculation methods](forecast-recalculation-methods.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]