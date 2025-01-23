---
title: Predict future revenue outcomes using premium forecasting
description: Premium forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data.
ms.date: 01/02/2025
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Predict future revenue outcomes using premium forecasting

Premium forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data. To achieve this, premium forecasting uses AI-driven models that look at historical data and the sales pipeline to predict future revenue outcomes.

>[!IMPORTANT]
>Premium forecasting is not available on Government Community Cloud (GCC), France, and India.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Features available in premium forecasting

The following premium forecasting features are available with the Sales Premium license. Before you begin, ensure that forecasting is enabled. More information: [Configure forecasts in your organization](configure-forecast.md).

### Forecast predictions

Provides an AI-powered forecast that helps sellers and managers understand how much revenue their sales team can achieve. These predictions are calculated based on historical data and the current sales pipeline, and are available at each level of the hierarchy. A detailed breakdown is also provided. 

To verify that the predictive forecasting feature is enabled in your organization, go to **Change area** > **App settings** > **Forecast configuration**. The **Prediction** column appears in a forecast grid when you select it as a column. To learn more, see [Choose layout and columns](/dynamics365/sales-enterprise/choose-layout-and-columns-forecast).

>[!NOTE]
> - **Prediction** column is now available for all hierarchies with rollup entity as **Opportunity**.
> -  All underlying opportunities must have system users as owners for predictive forecasting to consider while generating the values. 

After you activate the forecast for the first time, predictive forecasting will take about two hours to display data in the column.

To learn more, see [Configure forecasts in your organization](/dynamics365/sales-enterprise/configure-forecast).

Consider the following before you start using predictive forecasting, you must have:

-	More than 10 closed opportunities with values filled for the fields–**Actual Value**, **Actual Close Date**, **Estimated Value**, and **Estimated Close Date**. 

-	Open opportunities with values filled for the fields–**Estimated Value** and **Estimated Close Date**. 

-	Data should be real as in the usage scenarios for both closed and open opportunities. For example, opportunity created date should be before close date.

- Predictive forecasting service selects forecast model according to the available data, so, larger volume of closed opportunities with more complete values will result in getting more accurate forecasts.

- Additional filters created for the forecast don't negatively affect the outcome of the predictive forecasting model.

- To optimize the accuracy of the predictive forecast model, consider activating and publishing predictive opportunity scoring. To learn more, see [Predictive opportunity scoring](configure-predictive-opportunity-scoring.md).



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-premium-sales-insights-features)<br>
[Blog: Predictive sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/02/26/predictive-sales-forecasting-in-dynamics-365-sales/)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
