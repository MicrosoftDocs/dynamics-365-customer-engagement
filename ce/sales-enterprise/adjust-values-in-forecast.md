---
title: "Adjust forecast values in sales forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "Adjust values in a forecast in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Adjust values in a forecast

An adjustment provides sales managers or sellers the ability to estimate the final amount that they expect for a forecast’s opportunities to bring in at the close of the forecast period. Sales managers have the ability to adjust their own or a direct report’s forecast. For example, if the sales manager thinks that one of their direct report's best case opportunities might have more value than the proposed value, they can increase the value in the forecast. Upon saving the adjustment, the changes are rolled up to the parent record and up the hierarchy. 

To make adjustments, a forecast column must be set as editable. While configuring a forecast, the forecast owner must identify and set the editable columns through the **Allow adjustments** option. To learn more, see [configure columns](choose-layout-and-columns-forecast.md#configure-columns). 

You can also view the history of the adjustments that are made on a forecast and you can get more information on the following type of adjustment:

-	**Direct Adjustment**: Specifies that a user directly modified the value in the current cell. A direct adjustment can be reverted.

-	**Indirect Adjustment**: Specifies that a user made an adjustment to another value somewhere in the grid, and that adjustment was propagated through the forecast.

-	**Calculated value**: Shows the system calculated value if no direct or indirect adjustments are made.

> [!NOTE]
> You cannot adjust values for users or territories above your level in the hierarchy even if given access through security role.

To adjust a value, follow these steps:

1.	Hover the cursor over the field and a pencil icon is displayed. Select the pencil icon.

    > [!div class="mx-imgBorder"]
    > ![Select adjust value](media/forecast-adjust-value-pencil.png "Select adjust value")

    A dialog box opens to adjust the value.

    > [!div class="mx-imgBorder"]
    > ![Adjust value dialog box](media/forecast-adjust-value-dialog.png "Adjust value dialog box")

2.	Under the **Adjustment** tab, enter the value and add a note for the adjustment. In this example, the **Pipeline** column is configured as editable and you know that Nicolas Frizzell has a pipeline revenue of $20,000 instead of existing $11,752.16. Enter the value as 20000. Also, you can see the actual system calculated value for the forecast based on the existing data is $10,000.

    > [!div class="mx-imgBorder"]
    > ![Enter values to adjust](media/forecast-adjust-value-enter-value.png "Enter values to adjust")

3.	Select **Adjust**. The old value is strike off and a new value is added to the Pipeline column of Nicolas Frizzell. Also, you can see the indirect adjustment of values is added to the top of the hierarchy from Nicolas’s manager, Alyce Durham. 
 
    > [!div class="mx-imgBorder"]
    > ![Values adjusted](media/forecast-adjust-value-adjusted-value.png "Values adjusted")

4.	You can roll back the value if you think the adjusted value is inappropriate from the system calculated value. Open the adjustment dialog box and select **Reset**.

    > [!div class="mx-imgBorder"]
    > ![Select reset value](media/forecast-adjust-value-reset.png "Select reset value")

    A dialog opens to enter a note for the roll back reason. 
 
    > [!div class="mx-imgBorder"]
    > ![Reset adjusted value](media/forecast-adjust-reset-confirmation.png "Reset adjusted value")

5.	Enter a note and select **Reset**. 

    The note is added to the history of adjustments for reference for other users and the value is rolled back to the system calculated value. The indirect adjustment values that are added to the top of the hierarchy are also rolled back.
 
6.	To view the history of the adjustable forecast, open the adjustment dialog box and select the History tab. In this example, you can see the history of changes that are made for Nicolas Frizzell’s Pipeline forecast.

    > [!div class="mx-imgBorder"]
    > ![Adjusted value history](media/forecast-adjust-value-history.png "Adjusted value history")
    
 
### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)

[View a forecast](view-forecasts.md)