---
title: "Configure advanced settings for a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure advanced settings for a forecast in Dynamics 365 Sales."
ms.date: 10/23/2020
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure advanced settings

Using the **Advanced** step, you can configure the following for a forecast:

- [Automatically hide parent row](#automatically-hide-parent-row)
- [Enable multi-currency selection](#enable-multi-currency-selection)
- [Customize underlying records](#customize-underlying-records)

## Automatically hide parent row

When you open a forecast, each parent node has a dedicated contributor row under the tree where individual simple columns, such as quota, and revenue contribution are shown. For certain organizations, these dedicated contributor rows might have null value simple columns with no revenue contributions. With **Advanced** settings, you can hide these dedicated contributor rows of parent node.

For example, you have configured a forecast based on **User** hierarchy. When the manager **Kenny Smith**, opens the forecast, he can see a row dedicated for himself with null values along with other users, though he doesn’t have any associated opportunities including simple columns. 

> [!div class="mx-imgBorder"]
> ![Forecast grid view](media/forecast-hide-row-view-manger-row.png "Forecast grid view") 

In such cases, you can hide the dedicated contributor rows of the parent node. The parent row with the rolled-up values will remain displayed. 

As an administrator or forecast manager, you can select the option **Auto-hide parent row** under **Advanced** step of the forecast configuration to hide the parent’s dedicated contributor rows. Select the toggle to enable the autohide parent row.

> [!NOTE]
> By default, the option is enabled.

> [!div class="mx-imgBorder"]
> ![Enable autohide parent row](media/forecast-hide-row-enable-auto-hide-row.png "Enable autohide parent row")

> [!IMPORTANT]
> Though you may select the option to hide the parent row, the row will not be hidden if the parent row has underlying records or values defined for simple columns in the forecast.

## Enable multi-currency selection

When your sales teams are distributed across different countries and viewing the forecast with default currency might cause confusion for users in other countries to analyze and understand forecast. By enabling the multi-currency selection option, sales teams have an option to choose and convert the forecast data in real time to their convenient currencies defined in their organization which help in better planning, organizing, and understanding the current forecast state.

For example, you have sales teams in the US and Europe. The default currency for your organization is defined as US Doller and also, Euro is defined as currency. When you create forecast with multi currency enabled, sales teams in Europe can see the forecast data in Euro and the conversion of currency happens in real time. When the data is adjusted based on Euro, the updated data will be converted into Doller in real time. 

> [!div class="mx-imgBorder"]
> ![Select currency drop-down](media/forecast-multi-currency-select.png "Select currency drop-down")

As an administrator or forecast manager, select the **Multi-currency selection** toggle under **Advanced** step of the forecast configuration to allow users to view the forecast data in any currency that are defined for your organization. 

## Customize underlying records

You can customize the underlying records by adding a JavaScript library. The customizations include disable fields based on a logic, prevent autosave of fields, and set error notification for the fields. Before you upload, the JavaScript library must be created as per the schemas defined in [events and context object](../sales-enterprise/developer/reference/custom-actions/events-context.md). 

To create and upload a JavaScript library, follow these steps:

1.	Write your custom JavaScript code. For example, Let's create a JavaScript to disable all fields except few for **Opportunity** entity only. 

    ```JavaScript
    function OnRowLoad(executionContext) {

    // Get the logical name of the loaded entity as part of forecasting editable grid.
    var entityName = executionContext.getFormContext().data.entity.getEntityName();

        if (entityName === "opportunity") {

            // Defining the attributes list from opportunity that must be enabled if loaded as part of view.
            var OPTY_ENABLE_ATTRS_LIST = ["name", "msdyn_forecastcategory", "actualvalue", "actualclosedate", "estimatedvalue", "estimatedclosedate"];

            executionContext.getFormContext().data.entity.attributes.forEach(
                attribute => {
                    // Disabling all attributes other than OPTY_ENABLE_ATTRS_LIST
                    if (!OPTY_ENABLE_ATTRS_LIST.includes(attribute.getName())) {
                        attribute.controls.get(0).setDisabled(true);
                    }
                }
            )        
        }
    }
    ```
    
    > [!NOTE]
    > -	The function names in JavaScript file should match the event names and must accept context object parameter. 
    > -	Forecasting context object that is referred in the example is different from the execution context of platform. Forecasting context object is specific to forecasting and supports the advanced configurations of underlying records grid. More information: [Events and context object](../sales-enterprise/developer/reference/custom-actions/events-context.md).  

2.	Add your JavaScript code in a Script web resource.

    1.	Navigate to your model-driven apps instance in browser and go to **Settings** > **Customizations**.
    2.	In the Customization area, choose **Customize the System**.
    3.	In the solutions explorer, under **Components**, choose **Web Resources**.
    4.	Choose **New** to create a web resource.
    5.	In the new web resource dialog, specify the **Name** and **Display Name** for your web resource. For example: *mySampleScript.js* and *Sample: Walkthrough* script.
    6.	From the **Type** drop-down list, select **Script (JScript)**. You can either upload a file containing your JavaScript code by selecting **Choose File**, or select **Text Editor** and then paste your JavaScript code in the editor. 
    7.	Choose **Save** to create the web resource containing your JavaScript code.
    8.	Choose **Publish** to publish your web resource.

3.	Upload the JavaScript library to forecast configuration.
    
    >[!NOTE]
    >You can have only one JavaScript file at a time for a forecast. To upload a new file, you must first remove the existing file. You can upload a file to a forecast at any time.
    
    1.	In the forecast configuration page, go to the **Advanced** step and under **Customize underlying records** section, select **Add a javascript library**.

        > [!div class="mx-imgBorder"]
        > ![Select the add a JavaScript library option](media/forecast-javascript-select-option-upload.png "Select the add a JavaScript library option") 
         
    2.	On the **Add a JavaScript library** dialog, search for the JavaScript file that you want to upload and then select **Add**.

        > [!div class="mx-imgBorder"]
        > ![Choose a JavaScript library](media/forecast-javascript-choose-file.png "Choose a JavaScript library")
        
        The file is added to the forecast.

        > [!div class="mx-imgBorder"]
        > ![JavaScript library added to the forecast](media/forecast-javascript-file-added.png "JavaScript library added to the forecast")
 
 
<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Configure and manage drill-down entities](configure-manage-drill-downs.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)

[Events and context objects for underlying records grid](../sales-enterprise/developer/reference/custom-actions/events-context.md)
