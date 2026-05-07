---
title: Enable premium forecasting
description: Premium forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data.
ms.date: 05/06/2026
ms.custom: 
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---
# Enable premium forecasting

Premium forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data. To achieve this, premium forecasting uses AI-driven models that look at historical data and the sales pipeline to predict future revenue outcomes.

>[!IMPORTANT]
>**Premium forecasting requires a specific Dynamics 365 Sales license and is not available in all regions.**
>- Check whether your license includes premium forecasting: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544)
>- **Not available in:** Government Community Cloud (GCC), France, and India
>- Not sure if you have the right license? Contact your Microsoft representative or check your subscription in the Microsoft 365 admin center.

## Prerequisites for premium forecasting

Before you begin, ensure that you have the following prerequisites in place:

- Forecasting is enabled. More information: [Configure forecasts in your organization](configure-forecast.md).
 
- **More than 10 closed opportunities** with **Actual Value**, **Actual Close Date**, **Estimated Value**, and **Estimated Close Date** filled in. *(Fewer opportunities means less training data, which results in lower prediction accuracy.)*

- **Open opportunities** with **Estimated Value** and **Estimated Close Date** filled in. *(These are the records used to forecast future revenue.)*

- **Real data** that reflects actual usage — for example, opportunity created date should be before the close date. *(Test or dummy data skews the prediction model.)*

- A larger volume of closed opportunities with complete field values results in more accurate predictions. The AI selects the best model based on the available data.

- Additional filters applied to the forecast don't negatively affect the prediction model.

- For best results, consider enabling predictive opportunity scoring, which improves the underlying model quality. See [Predictive opportunity scoring](configure-predictive-opportunity-scoring.md).


## How to enable premium forecasting 

Once your data meets the prerequisites above, you can enable premium forecasting:

1. Go to **Sales Hub** > **Change area** > **App Settings**.

1. Under **Performance management**, select **Forecast configuration**.
1. Select your forecast and go to the **Layout** step.
1. Add a **Prediction** column to the layout. This column is only available when premium forecasting is licensed.
   >[!NOTE]
   >- **Prediction** column is now available for all hierarchies with rollup entity as **Opportunity**.
   >-  All underlying opportunities must have system users as owners for predictive forecasting to consider while generating the values. 
1. Save and activate the forecast.
   After activation, the **Prediction** column displays data within approximately two hours.
1. Turn on **Prediction factors** in the **Advanced** step to see the top factors influencing the prediction for each forecast row. This helps sellers understand why a certain revenue is being predicted and take action to improve it. Learn more in [View prediction factors](forecast-configure-advanced-settings.md#view-prediction-factors).




[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-premium-sales-insights-features)<br>
[Blog: Predictive sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/02/26/predictive-sales-forecasting-in-dynamics-365-sales/)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
