---
title: Lead and opportunity scoring
description: Learn how to set up lead and opportunity scoring in Dynamics 365 Sales.
ms.date: 11/30/2022
ms.topic: article
author: sbmjais
ms.author: shjais
---

# Lead and opportunity scoring

Harness the power of AI to get insights into which deals are most likely to close so your sales team can more effectively prioritize their work.

> [!NOTE]
> Lead scoring requires a minimum of 40 qualified leads and 40 disqualified leads, all of which have been created in the past two years. Opportunity scoring requires a minimum of 40 won opportunities and 40 lost opportunities, all of which have been created in the past two years.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Overview

Predictive lead scoring allows your sales teams to [prioritize leads based on scores](work-predictive-lead-scoring.md) and achieve higher lead qualification rates.

Predictive opportunity scoring allows your sales teams to [prioritize opportunities based on scores](work-predictive-opportunity-scoring.md) and achieve higher opportunity win, close, or convert rates.

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQjwl]

## Licensing options

When you set up lead and opportunity scoring with the Dynamics 365 Sales Enterprise license, you get 1,500 scored records per month. If you need to score more than 1,500 records per month, upgrade to Dynamics 365 Sales Premium.

## Set up lead and opportunity scoring

1. In the **Get started with digital sales** page, under **Lead and opportunity scoring**, select **Quick setup** to open the **Lead and opportunity scoring quick setup** panel.

    :::image type="content" source="media/ds-scoring-setup.png" alt-text="Screenshot of the Lead and opportunity score quick setup panel.":::

1. To enable predictive lead scoring, select **Create and publish** in the **Predictive lead scores** section.

1. To enable predictive opportunity scoring, select **Create and publish** in the **Predictive opportunity scores** section.

After the models are generated, they're published automatically. **Lead score** and **Opportunity score** widgets are added to the **Sales Insights** form of lead and opportunity records, respectively.

> [!NOTE]
> To explore predictive scoring without using your company data, publish sales accelerator with sample data.

## Advanced settings

You may want to modify the lead and opportunity scoring configurations. For example, you may want to ensure the model is trained on fields that are most relevant to your organization or add a separate model for a different line of business.

To do so, select **Go to advanced lead score settings** and **Go to advanced opportunity score settings** in the **Lead and opportunity scoring quick setup** panel. For information about advanced configurations, go to [Configure predictive lead scoring](configure-predictive-lead-scoring.md) and [Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md).

## Monitor usage

As an administrator, you can monitor the number of lead and opportunity records that have been scored over the past seven months. The data in the usage panel is refreshed every 24 hours.

If you have a Sales Enterprise license, you get 1,500 scored records per month. The app displays a warning symbol if your usage exceeds the monthly limit. Hover over the symbol to view the message. You must upgrade to the Sales Premium license to enjoy the full benefits of predictive scoring with no monthly limit.

On the **Get started with digital sales** page, under **Lead and opportunity scoring**, select **Monitor usage**.

:::image type="content" source="media/ds-scoring-monitor-usage.png" alt-text="Screenshot of the Lead and opportunity scoring section of the Get started with digital sales page, with Monitor usage highlighted.":::

The **Predictive scoring usage panel** displays the following information:

- **Monthly average**: The average number of records scored over the last six full months

- **Scored this month**: The total number of records scored so far in the current month. If you have a Sales Enterprise license, a warning symbol indicates if you've exceeded your monthly limit.

- **Usage over time**: The monthly usage of predictive scoring over the last six months in a graphical format. If you have a Sales Enterprise license, a warning symbol indicates if you've exceeded your monthly limit.

    The monthly limit is shown with a blue line in the graph. When the limit is exceeded in a month, the number of records in excess of 1,500 is shown in red.

    By default, the usage of both lead and opportunity scoring (if both are enabled) is displayed in the graph. To display the usage only for leads or only for opportunities, select **All** and then select the filter you want.

    :::image type="content" source="media/ds-scoring-usage-panel.png" alt-text="Screenshot of the Predictive scoring usage panel.":::

## Turn off lead and opportunity scoring

1. In the **Lead and opportunity scoring quick setup** panel, select **Go to advanced lead score settings** or **Go to advanced opportunity score settings**.

2. On the **Predictive lead scoring** page or the **Predictive opportunity scoring** page, select **Delete model**.

3. When you're asked to confirm, select **Delete**.

### Add lead and opportunity scoring widgets to a custom form

By default, the lead and opportunity scoring widgets are available only in the out-of-the-box **Sales Insights** form. If you're using a custom form for leads and opportunities, you can add the scoring widgets to it. For more information, go to [Add the lead scoring widget to a form](pls-add-widget.md) and [Add the opportunity scoring widget to a form](pos-add-widget.md).

### See also

[Sales accelerator](digital-selling-sales-accelerator.md)  
[Microsoft Teams collaboration](digital-selling-teams-collab.md)  
[Microsoft Teams calls with conversation intelligence](digital-selling-microsoft-teams-calls.md)
