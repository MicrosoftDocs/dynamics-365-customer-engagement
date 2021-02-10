---
title: "Understand the configuration of premium forecasting in Dynamics 365 Sales Insights | MicrosoftDocs"
description: "Understand the configuration of premium forecasting in Dynamics 365 Sales Insights."
ms.date: 06/01/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# About premium forecasting

Premium forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data. To achieve this, premium forecasting uses AI-driven models that look at historical data and the sales pipeline to predict future revenue outcomes. 

>[!IMPORTANT]
>Premium forecasting is not available on Government Community Cloud (GCC), France, and India. 

## Prerequisites 

Review the following requirements before you use the predictive forecast feature: 

- Purchase a Sales Insights, a Sales Premium license, or start a trial to use advanced Sales Insights features. 

- Enable forecasting. To learn more, see [Configure forecasts in your organization](https://docs.microsoft.com/dynamics365/sales-enterprise/configure-forecast). 

## Features available in premium forecasting

The following premium forecasting features are available with Sales Insights.

### Forecast predictions

Provides an AI-powered forecast that helps sellers and managers understand how much revenue their sales team can achieve. These predictions are calculated based on historical data and the current sales pipeline, and are available at each level of the hierarchy. A detailed breakdown is also provided. 

To verify that the predictive forecasting feature is enabled in your organization, go to **Change area** > **App settings** > **Forecast configuration**. The **Prediction** column appears in a forecast grid when you select it as a column. To learn more, see [Choose layout and columns](https://docs.microsoft.com/dynamics365/sales-enterprise/choose-layout-and-columns-forecast).

>[!NOTE]
> **Predictive** column is now available for all hierarchies with rollup entity as **Opportunity**.

After you activate the forecast for the first time, predictive forecasting will take about two hours to display data in the column.

To learn more, see [Configure forecasts in your organization](https://docs.microsoft.com/dynamics365/sales-enterprise/configure-forecast).

Consider the following before you start using predictive forecasting, you must have:

-	More than 10 closed opportunities with values filled for the fields–**Actual Value**, **Actual Close Date**, **Estimated Value**, and **Estimated Close Date**. 

-	Open opportunities with values filled for the fields–**Estimated Value** and **Estimated Close Date**. 

-	Data should be real as in the usage scenarios for both closed and open opportunities. For example, opportunity created date should be before close date.

- Predictive forecasting service selects forecast model according to the available data, so, larger volume of closed opportunities with more complete values will result in getting more accurate forecasts.

- Additional filters created for the forecast don't negatively affect the outcome of the predictive forecasting model.

- To optimize the accuracy of the predictive forecast model, consider activating and publishing predictive opportunity scoring. To learn more, see [Predictive opportunity scoring](configure-predictive-opportunity-scoring.md).

### Snapshots

Sales organizations can use snapshots to "freeze" forecast data at a moment in time. To learn more about how to use snapshots and how deals flow between two snapshots, see [Take snapshots automatically](manage-snapshots-forecast.md) and [Analyze deals flow between snapshots](analyze-deals-flow-between-snapshots.md).

### Trend chart

The **Trend** chart provides a visualization of how each forecast amount is trending over time, comparing it against the period end prediction and quota. A separate predicted realization line is automatically created to project the future revenues over time.

The option **Show in Trend Chart** is available to add forecast columns to the trend chart while configuring the column in the forecast configuration. Only **Roll up** and **Calculated** column types can be displayed in the trend chart. To learn more, see [Configure columns](https://docs.microsoft.com/dynamics365/sales-enterprise/choose-layout-and-columns-forecast#configure-columns).

To understand how to use trend charts, see [Understand forecast projection through trend charts](understand-forecast-projection-through-trend-chart.md).

### Flow chart

The flow chart provides a visual representation of how the forecast changes between two moments in time. To learn more, see [Analyze deals flow between snapshots](analyze-deals-flow-between-snapshots.md).

### See also

[Take snapshots automatically](manage-snapshots-forecast.md)<br>
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)<br>
[Blog: Predictive sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/02/26/predictive-sales-forecasting-in-dynamics-365-sales/)
