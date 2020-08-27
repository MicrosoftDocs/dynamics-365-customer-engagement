---
title: "Configure columns and layouts to display in a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure columns and layouts to display in a forecast in Dynamics 365 Sales."
ms.date: 08/01/2020
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Choose layout and columns

>[!NOTE]
> If you have opted in for early access, follow the process as specified in  [Choose layout and columns in early access](#choose-layout-and-columns-in-early-access).

In the **Layout** step of the forecast configuration, you can configure columns to define the forecast grid that appears for users. You can configure rollup columns from option sets that are defined for opportunities in your organization.

Perform the following steps to add columns and configure the forecast grid:

1.	[Add columns from an option set](#add-columns-from-an-option-set).

2.	[Configure columns](#configure-columns).

## Add columns from an option set

Every forecast needs an option set to define rollup columns. 

> [!IMPORTANT]
> - The **Prediction** column is available only when predictive forecasting is enabled for your organization. To learn more, see [About premium forecasting](https://docs.microsoft.com/dynamics365/ai/sales/configure-premium-forecasting).
> - To view the status of the prediction, select the icon displayed corresponding to the **Prediction** column. To learn more, see [View prediction model status](https://review.docs.microsoft.com/dynamics365/ai/sales/view-prediction-model-status). 

To define the layout, select an option set and then add the rollup columns accordingly, as described in the following steps.

1.	In the **Layout and column** section, select **Add from option set**. A list of option sets appears.

2.	Choose an option set, and then select **Choose selected**. The list shows only the option sets defined on the opportunity entity. Each option set value you select is added as a column for you to configure.

    > [!TIP]
    > We recommend you use the out-of-the-box **Forecast category** option set for column configuration. After choosing this option, select **Auto-configure** in the dialog box that asks if you want to auto-populate the configuration parameters. This saves time by automatically populating columns according to best practices.

    > [!div class="mx-imgBorder"]
    > ![Choose option set for forecast](media/forecast-layout-column-selection.png "Choose an option set for the forecast")

    > [!NOTE]
    > By default, a **Quota** column of type **Simple** is added to the forecast. To begin tracking against targets, you must manually upload an Excel workbook that contains quota values to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

    After the rollup columns are added to the forecast, you can use **More options** to rearrange or remove the columns that you don't need.

    > [!div class="mx-imgBorder"]
    > ![Rollup columns are added to the forecast](media/forecast-layout-column-selected-columns.png "Rollup columns are added to the forecast")

## Configure columns

You can configure each column individually&mdash;such as changing the column type, allowing adjustments, and showing a column in the trend chart&mdash;according to your organizational requirements.

1.	Hover over a column name, select the **More options** icon, and then select **Configure**. For example, you can hover over **Best case**, and then select **Configure**.

    > [!div class="mx-imgBorder"]
    > ![Select configuration option for a column](media/forecast-layout-column-configuration-selection.png "Select a configuration option for a column")

    On the column configuration page, the **Name** specifies the name of the column.

3.	Select the **Type** of column. The options that appear depend on the type of column you select. For example, when you select a column of type **Calculated**, a text box appears for you to enter a formula to use for calculating the value of the column. 

    The following column types are supported:

    •	[Rollup type](#rollup-type)
    
    •	[Calculated type](#calculated-type)
    
    •	[Simple type](#simple-type)

    •	[Hierarchy related type](#hierarchy-related-type)

    When configuring columns, you'll see a preview of the configuration in the **Preview** section.

4.	Save and close the configuration.

5.	Repeat steps 1 through 4 for each column that you want to edit.

### Rollup type

The **Rollup** column type aggregates the values of all fields based on the selected **Selector** and **Amount field** values, by using the **Date field** value as the filter criteria. 

Select the column **Type** as **Rollup**. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Selector | Select the option set value that defines how this column is grouped. For example, if **Best Case** is selected, only opportunities with the forecast category set to **Best Case** will be aggregated. |
| Data type | Select the data type of the column that you want to display on the forecast grid. By default, the value is selected as **Currency** and can't be changed for **Rollup** type columns. |
| Amount field | Select the amount field on which the aggregation is calculated. The available fields are based on the selected **Rollup entity**, such as **Opportunity**. For example, if the **Forecast category** option set is selected, the amount field is automatically configured as **Est. Revenue**. <br> If you're using a custom field to track the estimated revenue for your organization, select that custom field. |
| Date field | Select the date field that defines the record's forecast period. The available fields are based on the selected **Rollup entity**, such as **Opportunity**. For example, if the **Forecast category** option set is selected, the date field is configured as **Est. Close Date**. <br>If you're using a custom field to track the estimated close date for your organization, select that custom field.|
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Allow adjustments | Enable this setting to let users manually edit a system-calculated value directly in the forecast grid. When this setting is enabled, you'll see a pencil icon next to the forecasted value in that column. To learn more, see [Adjust values in a forecast](adjust-values-in-forecast.md). |
| Show progress compared to quota | Enable this option to compare the column's value against the quota column. When this is enabled, a progress bar indicating the attainment percentage is shown below the column's value.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about trend charts, see [Understand forecast projection through trend charts](https://docs.microsoft.com/dynamics365/ai/sales/understand-forecast-projection-through-trend-chart.md). |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |

### Calculated type

When you select column **Type** as **Calculated**, the values for the column are calculated and displayed based on a formula that you define. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that you want to display on the forecast grid, based on the formula. You can select the value **Currency** or **Decimal**, depending on your requirements. |
| Calculation | Enter a formula to calculate values for the column. When you start typing a formula, suggestions are displayed for your convenience. The names shown are the column's unique name and value. For example, if you want to see the best case forecast in this column, enter the formula as **Closed + Commit + Best Case**. <br> If you enter an invalid formula, an appropriate error message appears below the **Calculation** field. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Show progress compared to quota | Enable this option to compare the column's value against the quota column. When enabled, a progress bar indicating the attainment percentage is shown below the forecast value in that column.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about trend charts, see [Understand forecast projection through trend chart](https://docs.microsoft.com/dynamics365/ai/sales/understand-forecast-projection-through-trend-chart). |
| Unique name | The unique name is used to identify the column when you're writing a formula for a **Calculated** column. |	

### Simple type

Use the **Simple** column type to manually upload external data to a forecast. An Excel workbook is available for you to download after you activate the forecast. You must edit the Excel workbook with the necessary values and then upload it to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

For example, **Quota** is a simple column type where you can manually upload data by using an Excel workbook. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that you want to display on the forecast grid. You can select **Single Line of Text**, **Currency**, or **Decimal**, depending on the type of value that you'll be uploading through an Excel workbook. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |

### Hierarchy related type

When you select column **Type** as **Hierarchy related**, the column helps you pull additional attributes from the hierarchy entity. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Data type of the column that you want to display on the forecast grid. By default, the value is selected as **Decimal** and can't be changed. |
| Attribute field | Select an attribute to display in the column. For example, you can select **Email**, which will be unique to each user in your organization and can help you identify to whom the record belongs. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |

## Choose layout and columns in early access

[!INCLUDE [cc-early-access](../includes/cc-early-access.md)]

In the **Layout** step of the forecast configuration, you can configure columns to define the forecast grid that appears for users. You can configure rollup columns from option sets that are defined for opportunities in your organization.

Perform the following steps to add columns and configure the forecast grid:

1.	[Add columns from an option set](#add-columns).

2.	[Configure columns](#configure-columns).

<a name="add-columns"> </a>
### Add columns from an option set

Every forecast needs an option set to define rollup columns. 

> [!IMPORTANT]
> The **Prediction** column is available only when predictive forecasting is enabled for your organization. To learn more, see [About premium forecasting](https://docs.microsoft.com/dynamics365/ai/sales/configure-premium-forecasting).

To define the layout, select an option set and then add the rollup columns accordingly, as described in the following steps.

1.	In the **Layout and column** section, select **Add from option set**. A list of option sets appears. 

2.	Choose an option set entity from the rollup entity or from its related entities. The selected entity consists of option sets that are necessary to add columns to the forecast. In this example, the **Opportunity (Opportunity)** option set entity is selected from **Related Entities**. The list shows only the option sets defined on the opportunity entity.

    > [!div class="mx-imgBorder"]
    > ![Select opportiunity entity from related entities](media/forecast-ce-select-opportunity-entity.png "Select opportiunity entity from related entities")

3.	Choose an option set and then select **Choose selected**. In this example, **Forecast category** option set is selected. The option set values are added as columns for you to configure.

    > [!TIP]
    > We recommend you use the out-of-the-box **Forecast category** option set for column configuration. After choosing this option, select **Auto-configure** in the dialog box that asks if you want to auto-populate the configuration parameters. This saves time by automatically populating columns according to best practices. The option to auto-configure columns are available only for **Opportunity** and **Opportunity product** rollup entities.

    > [!div class="mx-imgBorder"]
    > ![Choose option set for forecast](media/forecast-layout-column-choose-option-set.png "Choose an option set for the forecast")

    By default, a **Quota** column of type **Simple** is added to the forecast. To begin tracking against targets, you must manually upload an Excel workbook that contains quota values to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

    After the rollup columns are added to the forecast, you can use **More options** to rearrange or remove the columns that you don't need.

    > [!div class="mx-imgBorder"]
    > ![Rollup columns are added to the forecast](media/forecast-layout-column-selected-columns-added.png "rollup columns are added to the forecast")

<a name="configure-columns"> </a>      
### Configure columns

You can configure each column individually&mdash;such as changing the column type, allowing adjustments, and showing a column in the trend chart&mdash;according to your organizational requirements.

>[!NOTE]
>- Auto configuration of coulmns are available only for **Opportunity** and **Opportunity product** rollup entities. For other rollup entities, you must manually configure each column.
>- An alert icon ![Alert icon](media/alert-icon.png "Alert icon") corresponding to a column, indicates that the column is not configured.

1.	To configure each column, select the gear icon ![Gear icon](media/gear-icon.png "Gear icon") and the column configuration section opens. In this example, the **Pipeline** column is selected.

    > [!div class="mx-imgBorder"]
    > ![Select configuration option for a column](media/forecast-layout-column-configuration-selection-opens.png "Select a configuration option for a column")

    On the column configuration page, the **Name** specifies the name of the column.

3.	Select the **Type** of column. The options that appear depend on the type of column you select. For example, when you select a column of type **Calculated**, a text box appears for you to enter a formula to use for calculating the value of the column. 

    The following column types are supported:

    •	[Rollup type](#configure-rollup-type)
    
    •	[Calculated type](#configure-calculated-type)
    
    •	[Simple type](#configure-simple-type)

    •	[Hierarchy related type](#configure-hierarchy-related-type)

    When configuring columns, you'll see a preview of the configuration in the **Preview** section.

4.	Save and close the configuration.

5.	Repeat steps 1 through 4 for each column that you want to edit.

<a name="configure-rollup-type"> </a>  
#### Rollup type

The **Rollup** column type aggregates the values of all fields based on the selected **Selector** and **Amount field** values, by using the **Date field** value as the filter criteria.

While configuring these columns, some attributes that are necessary for the forecast estimated revenue and estimated close date. Typically, these attributes are available in the selected rollup entity. For complex data models, such as opportunity splits and opportunity product, these attributes are distributed between rollup and related entities. To address this complexity, the forecasting supports the selection of related attributes for estimated revenue and estimated close date.

Select the column **Type** as **Rollup**. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Selector | Select the option set value that defines how this column is grouped. For example, if **Best Case** is selected, only opportunities with the forecast category set to **Best Case** will be aggregated. |
| Data type | Select the data type of the column that you want to display on the forecast grid. By default, the value is selected as **Currency** and can't be changed for **Rollup** type columns. |
| Amount field | Select the amount field on which the aggregation is calculated. The available fields are based on the selected **Rollup entity**, such as **Opportunity**. For example, if the **Forecast category** option set is selected, the amount field is automatically configured as **Est.Revenue**. <br> If you're using a custom field to track the estimated revenue for your organization, select that custom field. |
| Date entity | Select the entity from which you want to choose the date field. <br>If the required date field is not available in the rollup entity, you can choose from the related entities. For example, in a product based forecast, the rollup entity is **Opportunity Product** and the required estimated close date attribute will not be available in this entity. Therefore, select the **Opportunity** entity from **Related entities** that has the estimated close date attribute. |
| Date field | Select the date field that defines the record's forecast period. The available fields are based on the selected **Date entity**, such as **Opportunity**. For example, if the **Opportunity** entity is selected, the date field is configured as **Est.Close Date**. <br>If you're using a custom field to track the estimated close date for your organization, select that custom field.|
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Allow adjustments | Enable this setting to let users manually edit a system-calculated value directly in the forecast grid. When this setting is enabled, you'll see a pencil icon next to the forecasted value in that column. To learn more, see [Adjust values in a forecast](adjust-values-in-forecast.md). |
| Show progress compared to quota | Enable this option to compare the column's value against the quota column. When this is enabled, a progress bar indicating the attainment percentage is shown below the column's value.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about trend charts, see [Understand forecast projection through trend charts](https://docs.microsoft.com/dynamics365/ai/sales/understand-forecast-projection-through-trend-chart.md). |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |

<a name="configure-calculated-type"> </a>
#### Calculated type

When you select column **Type** as **Calculated**, the values for the column are calculated and displayed based on a formula that you define. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that you want to display on the forecast grid, based on the formula. You can select the value **Currency** or **Decimal**, depending on your requirements. |
| Calculation | Enter a formula to calculate values for the column. When you start typing a formula, suggestions are displayed for your convenience. The names shown are the column's unique name and value. For example, if you want to see the best case forecast in this column, enter the formula as **Closed + Commit + Best Case**. <br> If you enter an invalid formula, an appropriate error message appears below the **Calculation** field. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Show progress compared to quota | Enable this option to compare the column's value against the quota column. When enabled, a progress bar indicating the attainment percentage is shown below the forecast value in that column.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about trend charts, see [Understand forecast projection through trend chart](https://docs.microsoft.com/dynamics365/ai/sales/understand-forecast-projection-through-trend-chart). |
| Unique name | The unique name is used to identify the column when you're writing a formula for a **Calculated** column. |	

<a name="configure-simple-type"> </a>
#### Simple type

Use the **Simple** column type to manually upload external data to a forecast. An Excel workbook is available for you to download after you activate the forecast. You must edit the Excel workbook with the necessary values and then upload it to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

For example, **Quota** is a simple column type where you can manually upload data by using an Excel workbook. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that you want to display on the forecast grid. You can select **Single Line of Text**, **Currency**, or **Decimal**, depending on the type of value that you'll be uploading through an Excel workbook. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |

<a name="configure-hierarchy-related-type"> </a>
#### Hierarchy related type

When you select column **Type** as **Hierarchy related**, the column helps you pull additional attributes from the hierarchy entity. The following options are available to configure.

| Parameter | Description |
|-----------|-------------|
| Data type	| Data type of the column that you want to display on the forecast grid. By default, the value is selected as **Decimal** and can't be changed. |
| Attribute field | Select an attribute to display in the column. For example, you can select **Email**, which will be unique to each user in your organization and can help you identify to whom the record belongs. |
| Description | Enter a description for the column. This description appears as a tooltip on the column header of the forecast grid, to help your users understand what the column contains. |
| Unique name | The unique name is used to identify the column to use when you're writing a formula for a **Calculated** column. |


<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Provide viewing permissions](provide-permissions-forecast.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Apply additional filter](add-additional-filters.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)<br>
[View a forecast](view-forecasts.md)<br>
[About premium forecasting](https://docs.microsoft.com/dynamics365/ai/sales/configure-premium-forecasting)<br>
[Configure forecast using custom rollup entity](configure-forecast-using-custom-rollup-entity.md)
