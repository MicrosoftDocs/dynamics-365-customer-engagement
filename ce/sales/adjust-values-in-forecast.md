---
title: Adjust values in a forecast
description: "Adjust values in a forecast to estimate the final amount that you expect the forecast's opportunities to bring in at the close of the forecast period."
ms.date: 05/29/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-Entity-forecastdefinition
  - D365-Entity-msdyn_forecastconfiguration
  - D365-Entity-msdyn_forecastdefinition
  - D365-Entity-forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
ai-usage: ai-assisted
---
# Adjust values in a forecast 

An adjustment provides sales managers or sellers the ability to estimate the final amount that they expect for a forecast's opportunities to bring in at the close of the forecast period. Sales managers have the ability to adjust their own or a direct report's forecast. For example, if the sales manager thinks that one of their direct report's best-case opportunities might have more value than the proposed value, they can increase the value in the forecast. On saving the adjustment, the changes will be rolled up to the parent record and up the hierarchy. 

## Why should you adjust values?

**When to adjust:** Your forecast automatically pulls data from your opportunities. However, you may have pipeline knowledge that isn't yet captured in the system — for example, a verbal commitment from a customer, a deal that paused and is expected to return, or a known risk on a high-value opportunity. Adjustments let you account for these factors without waiting for opportunity data to be updated.

**When NOT to adjust:** If underlying opportunities are outdated, update the opportunities directly instead of masking the issue with an adjustment. If a deal fell through, close the opportunity as Lost — don't adjust its value to zero.

## Adjust a value in a forecast

To make adjustments, a forecast column must be set as editable. While configuring a forecast, the forecast owner must identify and set the editable columns through the **Allow adjustments** option in the **Layout** section of the forecast configuration. To learn more, see [configure columns](choose-layout-and-columns-forecast.md#rollup-type). 

The following types of adjustments can be made to a forecast value:

- **Direct Adjustment**: You changed a specific cell value directly (for example, increased Pipeline from $10K to $15K). This change rolls up to your manager's totals. A direct adjustment can be reverted.

- **Indirect Adjustment**: Someone else in the hierarchy made an adjustment that propagated to your row. For example, your manager adjusted their own total, and that change is reflected in your values. Visible in the adjustment History tab.

- **Calculated value**: The system-computed value when no direct or indirect adjustments have been made.

> [!NOTE]
> You can't adjust values for users or territories above your level in the hierarchy, even if you've been given access through your security role.

**To adjust a value in a forecast**

1. In the Sales Hub site map, select **Forecasts** and then open a forecast.
1. Hover over the cell that you want to adjust.  
   A pencil icon appears — select it to open the adjustment dialog. The pencil icon appears only on columns that your admin sets as adjustable in the forecast configuration. Learn more in [configure columns in a forecast](choose-layout-and-columns-forecast.md#rollup-type).

    :::image type="content" source="media/forecast-adjust-value-enter-value.png" alt-text="Screenshot of hovering over a cell to show the pencil icon to open the adjustment dialog.":::

2.	On the **Adjustment** tab, enter the value and add a note for the adjustment. For example, the **Pipeline** column is configured as adjustable and you know that Nicolas Frizzell has a pipeline revenue of $20,000 instead of the existing value, $11,752.16. Enter the value as **20000**. You can see that the actual system-calculated value for the forecast, based on existing data, is $10,000.

3.	Select **Adjust**.  
    The new value is displayed in the **Pipeline** column for Nicolas Frizzell. The adjusted value is also rolled up to the top of the hierarchy from Nicolas's manager.

4.	You can roll back the value if you think it was inappropriately adjusted from the system-calculated value. Open the adjustment dialog box, and then select **Reset**. 

5.	In the dialog that appears, specify the reason for resetting the value and select **Reset**.  

    The note is added to the history of adjustments for reference for other users and the value is rolled back to the system-calculated value. The indirect adjustment values that are added to the top of the hierarchy are also rolled back.
 
6.	To view the history of the adjustable forecast, open the adjustment dialog box and select the **History** tab.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>
[View a forecast](view-forecasts.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
