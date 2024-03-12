---
title: Forecast management FAQs
description: Get answers to frequently asked questions about Forecast management.
ms.date: 03/29/2023
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Forecast management FAQs

This article answers frequently asked questions about Forecast management in Dynamics 365 Sales, Sales premium, and Sales professional.

## Who owns the forecast?
  
To view the forecast owner:

1. In the Sales Hub app, select **App Settings**.
1. Under **Performance management**, select **Forecast configuration**.
1. Select the forecast configuration that's related to the forecast, and then select the **Permissions** step.
1. Check the **Owner lookup field** field to determine who owns the forecast.
  
:::image type="content" source="media/user-security-field.png" alt-text="Screenshot of the Owner lookup field in the Permissions step.":::
  
For more information, go to [Define the forecast owner](provide-permissions-forecast.md#define-the-forecast-owner).
  
## How do I change the forecast calculation for lost opportunities?

By default, the forecast calculation for lost opportunities is based on the actual revenue. To change it to estimated revenue, go to the **Layout** step of the forecast configuration, select the **Lost** forecast category, and then  select **Est. Revenue** in the **Amount** field. For more information, go to [Choose layout and columns](choose-layout-and-columns-forecast.md).

## Can I manually set the forecast category of an opportunity as Won or Lost?

Technically, you can. The **Opportunity** form and editable grids, other than the grid in the forecast, allow the selection of **Won** or **Lost** as forecast categories.

However, manually setting the forecast category interferes with your forecast and rollup values, and isn't an ideal practice. For example, if you manually set the value of an opportunity to **Won** without closing the opportunity, the opportunity might not even show up in the forecast. By default, forecasts are configured to show an opportunity as **Won** only when the actual revenue and actual close date are available.

The best practice is to close the opportunity as **Won** or **Lost** and have the forecast category automatically updated. For more information, go to [Close opportunities as won or lost](close-opportunity-won-lost-sales.md).


