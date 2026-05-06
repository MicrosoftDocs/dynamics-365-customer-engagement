---
title: "Analyze revenue outcome using predictive forecasting"
description: "Use predictive forecasting to analyze the revenue outcome by providing forecast projections based on your data."
ms.date: 08/22/2025
ms.custom: 
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Analyze revenue outcome by using predictive forecasting

Predictive forecasting uses AI to estimate how much revenue you'll actually close, based on your historical performance and current pipeline. Unlike your manual forecast (Committed, Best Case), predictive forecasting accounts for historical close rates and pipeline trajectory — helping you spot risks like deals slipping to the next period, or opportunities from new deals flowing in that you might miss otherwise.

## Prerequisites

> [!IMPORTANT]
> To use predictive forecasting, you need the following:
>
> - **Predictive opportunity scoring** must be enabled with at least one model configured. [Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md)
> - **Premium forecasting** must be enabled (requires a specific Dynamics 365 Sales license). [Learn more about premium forecasting](configure-premium-forecasting.md)

## Understand the prediction column and details in a forecast

Predictive forecasting helps sellers and managers improve their forecast accuracy by providing forecast projections based on data. To achieve this, predictive forecasting uses AI-driven models that look at historical data and the open sales pipeline to predict future revenue outcome.

The **Prediction** column shows the predicted revenue for each seller and manager. Predictions are based on the **Status** field of an opportunity. To optimize the accuracy of the predictions, ensure the **Forecast Category** values are kept in sync with the **Status** field. For the out-of-the-box forecast category, a workflow ensures that when an opportunity is closed as **Won** or **Lost**, the forecast category is updated with the proper value.

> [!NOTE]
> If sufficient data isn't available for predictive forecasting, an error message is displayed and the **Prediction** column is left empty.


### Prediction column

The **Prediction** column shows the predicted revenue for each seller or manager — separate from the manual forecast columns (Committed, Best Case). Predictions are based on historical close rates and the current pipeline trajectory, and are recalculated automatically every seven days.

Open a forecast and view the **Prediction** column. To learn more, see [View a forecast](/dynamics365/sales-enterprise/view-forecasts).

The following screen shows an example of a **Prediction** column.

:::image type="content" source="media/predictive-forecasting-prediction-column.png" alt-text="Screenshot of the Prediction column in the forecast grid.":::

When you hover over the information icon on the **Prediction** column header, the last recalculation date of the prediction is shown. Predictions are recalculated after every seven days; you can't trigger a manual recalculation.

### Prediction details

Select a value in the **Prediction** column to display the **Prediction details** pane.

:::image type="content" source="media/predictive-forecasting-prediction-details.png" alt-text="Screenshot of the Prediction details pane.":::

The graph in the **Prediction details** pane consists of the following values:  

- **Closed won**: Total actual revenue of opportunities that have been closed as won during the current forecast period.

- **Predicted from open**: Total estimated revenue from open opportunities that are predicted to close during the current forecasting period and are contributing to the prediction.  

- **Predicted from new**: Total estimated revenue from new opportunities that are predicted to close during the current forecasting period and are contributing to the prediction.

- **Total prediction**: Total predicted amount for the current forecasting period.

The top factors that influence the prediction are displayed below the graph. These factors help you to understand the key points of the graph. As many as five of these factors will appear.

>[!NOTE]
>In order for **Prediction details** to be displayed, an administrator or forecast manager must [enable prediction factors](/dynamics365/sales-enterprise/forecast-configure-advanced-settings#enable-prediction-factors).  

The top prediction factors are categorized into three types:  
-	A green icon with an upward-trending arrow (![Green icon](media/predictive-forecasting-factor-green-icon.png)) represents a positive influencing factor.  
-	A red icon with a downward-trending arrow (![Red icon](media/predictive-forecasting-factor-red-icon.png)) represents a negative influencing factor.  
-	A gray icon with a horizontal arrow (![Gray icon](media/predictive-forecasting-factor-gray-icon.png)) represents a neutral influencing factor.  

The following image shows an example of a **Top factors that influence prediction** section. 

:::image type="content" source="media/predictive-forecasting-top-factors.png" alt-text="Screenshot of the Top factors that influence prediction section.":::

| Icon | Influencing factor | What to do |
| - | - | - |
| ![Green icon](media/predictive-forecasting-factor-green-icon.png) | The top positive influencing factor is that $247.22K will flow from new deals in the remaining 59 days of the period, and $124.91K (51%) of it will flow in the last 17 days. | Protect these deals. Assign resources to ensure they close on time. |
| ![Red icon](media/predictive-forecasting-factor-red-icon.png) | The negative influencing factor is that 22% of opportunities are predicted to slip to the next period. | Prioritize these deals. Consider adding executive support or accelerating the close plan. |
| ![Gray icon](media/predictive-forecasting-factor-gray-icon.png) | The neutral influencing factor is that 3,614 opportunities in the pipeline are expected to close within this forecast period. | Use as baseline context. No immediate action needed. |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[About premium forecasting](configure-premium-forecasting.md)  
[Enable prediction factors](/dynamics365/sales-enterprise/forecast-configure-advanced-settings#enable-prediction-factors)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
