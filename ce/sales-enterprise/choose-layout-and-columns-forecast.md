---
title: "Configure columns and layouts to display in a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure columns and layouts to display in a forecast in Dynamics 365 Sales."
ms.date: 02/03/2020
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

In the **Layout** step, configure the columns to show how the forecast grid appears for the users in the forecast. You can configure rollup columns from option sets that are defined for opportunities in your organization.

Perform the following steps to add columns and configure the forecast grid:

1.	[Add columns from an option set](#add-columns-from-an-option-set)

2.	[Configure columns](#configure-columns)

3.	[(Optional) Apply additional filters](#apply-additional-filters)

## Add columns from an option set

Every forecast needs an option set to define roll up columns. 

> [!IMPORTANT]
> The **Prediction** column is only available when Predictive forecasting is enabled for your organization. The predictive forecasting only works with forecasts based on an **Org chart** template. To learn more, see [About premium forecasting](/ai/sales/configure-premium-forecasting).

To start the layout configuration, select an option set and then add the rollup columns accordingly. Follow these steps:

1.	In the **Layout and column** section, select **+ Add from option set**. A list of option sets appears.

2.	Choose an option set and select **Choose selected**. The list shows only the option sets defined on the opportunity entity. Each option set value of the selected option set is added as a column for you to configure.

    > [!TIP]
    > We recommend you use the out-of-the-box **Forecast category** option set for column configuration. After choosing this option, select **Auto-configure** in the dialog box asking if you want to auto-populate the configuration parameters. This saves time by automatically populating column according to best practices.

    > [!div class="mx-imgBorder"]
    > ![Choose option set for forecast](media/forecast-layout-column-selection.png "Choose option set for forecast")

    > [!NOTE]
    > By default, a **Quota** column of type **Simple** is added to the forecast. To begin taacking against targets, an Excel file containing quota values must be manually uploaded to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

    Once the rollup columns are added to the forecast, you can rearrange or remove the columns that aren't required through **More options**.

    > [!div class="mx-imgBorder"]
    > ![Rollup columns are added to the forecast](media/forecast-layout-column-selected-columns.png "Rollup column are added to the forecast")
    
## Configure columns

You can individually configure each column according to your organizational requirements, such as changing the column types, allowing adjustments, and showing a column in the trend chart.

Follow these steps:

1.	Hover the cursor over a column name, select the **More options** icon, and then select **Configure**. For example, hover the cursor over **Best case** and then select **Configure**.

    > [!div class="mx-imgBorder"]
    > ![Select configuration option for a column](media/forecast-layout-column-configuration-selection.png "Select configuration option for a column")

    The column configuration options appear.

2.	In the column configuration page, the **Name** specifies the name of the column.

3.	Select the **Type** of column. Depending on the type of column, the options to configure appear. For example, when you select column type as **Calculated**, a text box appears allowing you to enter a formula to use. 

    The following types are supported:

    •	[Rollup type](#rollup-type)
    
    •	[Calculated type](#calculated-type)
    
    •	[Simple type](#simple-type)

    •	[Hierarchy related type](#hierarchy-related-type)

    When configuring columns, you’ll see a preview of the configuration in the **Preview** section.

4.	Save and close the configuration.

5.	Repeat **step 1** to **step 4** for the columns that you want to edit.

### Rollup type

The **Rollup** column type aggregates the values of all fields based on the selected **Selector** and **Amount field** values, using **Date field** value as filter criteria. 

Select the column **Type** as **Rollup**. The following options are available to configure:

| Parameter | Description |
|-----------|-------------|
| Selector | Select the option set value that defines how this column is grouped. For example, if **Best Case** is selected, only opportunities with forecast category set to **Best Case** will be aggregated. |
| Data type | Select the data type of the column that is to be displayed on the forecast grid. By default, the value is selected as **Currency** and can't be changed for **Rollup** type columns. |
| Amount field | Select the amount field on which the aggregation is calculated. The available fields are based on the selected **Rollup entity**, such as **Opportunity**. For example, if the **Forecast category** option set is selected, the amount field is automatically configured as **Est. Revenue**. <br> If you're using custom field to track the estimated revenue for your organization, select that custom field. |
| Date field | Select the date field that defines the record’s forecast period. The available fields are based on the selected **Rollup entity**, such as **Opportunity**. For example, if the **Forecast category** option set is selected, the date field is configured as **Est. Close Date**. <br>If you're using custom field to track the estimated close date for your organization, select that custom field.|
| Description | Enter a description for the column. This description appears as a tool tip on the column header of the forecast grid helping your users get more information. |
| Allow adjustments | Enable this setting to provide users the ability to manually edit a system calculated value directly in the forecast grid. When enabled, you’ll see a pencil icon next to the forecasted value in that column. To learn more, see [Adjust values in a forecast](adjust-values-in-forecast.md). |
| Show progress compared to quota | Enable this option to compare the column’s value against the quota column. When enabled, a progress bar indicating the attainment percentage is shown below the column's value.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about Trend Chart, see [Understand forecast projection through trend chart](/ai/sales/understand-forecast-projection-through-trend-chart.md). |
| Unique name | The unique name is used to identify the column when writing a formula for a **Calculated** column. |	

### Calculated type

When you select column **Type** as **Calculated**, the values for the column are calculated and displayed based on a formula that you define. The following options are available to configure:

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that is to be displayed on the forecast grid based on the formula. You can select the value **Currency** or **Decimal** depending on your requirements. |
| Calculation | Enter a formula to calculate values for the column. When you start typing a formula, auto suggestions are displayed for your convenience. The names shown are the column's unique name and value. For example, if you want to see the best case forecast in this column, enter the formula as **Closed + Commit + Best Case**. <br> If you enter an invalid formula, an appropriate error message appears below the **Calculation** field. |
| Amount field | Select the amount field on which the aggregation is calculated. The available fields are based on the selected Rollup entity, such as Opportunity. For example, if the Forecast category option set is selected, the amount field is automatically configured as Est. Revenue. <br> If you're using custom field to track the estimated revenue for your organization, select that custom field. |
| Date field | Select the date field that defines the record’s forecast period. The available fields are based on the selected Rollup entity (Opportunity). For example, if the Forecast category option set is selected, the date field is configured as Est. Close Date. <br>If you're using custom field to track the estimated close date for your organization, select that custom field.|
| Description | Enter a description for the column. This description appears as a tool tip on the column header of the forecast grid helping your users get more information. |
| Show progress compared to quota | Enable this option to compare the column’s value against the quota column. When enabled, a progress bar indicating the attainment percentage is shown below the forecast value in that column.|
| Show in Trend Chart | Enable this option to show the value in the **Trend Chart**. This option is available only when predictive forecasting is enabled for your organization. To learn more about Trend Chart, see [Understand forecast projection through trend chart](/ai/sales/understand-forecast-projection-through-trend-chart.md). |
| Unique name | The unique name is used to identify the column when writing a formula for a **Calculated** column. |	

### Simple type

The **Simple** column type allows you to manually upload external data to a forecast. An Excel file is available for you to download after you activate the forecast. You must edit the Excel file with the necessary values, and then upload it to the forecast. To learn more, see [Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md).

For example, **Quota** is a simple column type where you can manually upload data using an excel file. 

The following options are available to configure:

| Parameter | Description |
|-----------|-------------|
| Data type	| Select a data type for the column that is to be displayed on the forecast grid. You can select the value as **Single Line of Text**, **Currency**, or **Decimal** depending on the type of value that you’ll be uploading through an Excel file. |
| Description | Enter a description for the column. This description appears as a tool tip on the column header of the forecast grid helping your users get more information. |
| Unique name | The unique name is used to identify the column when writing a formula for a **Calculated** column. |

### Hierarchy related type

When you select column **Type** as **Hierarchy related**, the column helps you pull additional attributes from the hierarchy entity. The following options are available to configure:

| Parameter | Description |
|-----------|-------------|
| Data type	| Data type of the column that is to be displayed on the forecast grid. By default, the value is selected as **Decimal** and can't be changed. |
| Attribute field | Select an attribute to display in the column. For example, select **Email** which will be unique to each user in your organization and helps you to identify to whom the record belongs. |
| Description | Enter a description for the column. This description appears as a tool tip on the column header of the forecast grid helping your users get more information. |
| Unique name | The unique name is used to identify the column when writing a formula for a **Calculated** column. |

## Apply additional filters

Using the additional filters, you can filter the opportunities that participate in calculating the forecast values. To filter the opportunities, you create filters based on conditions using the attributes that belong to the opportunity entity including related entity attribute. 

For example, you know that opportunities related to **Adatum Corporation** and revenue more than or equal to **$10,000** can't be closed for the current quarter. You want to filter such opportunities in the forecast. Let’s create a query for this condition to filter opportunities:

1.	In the **Additional filters** section, select **+ Add filters**.
 
2.	Select **+ Add** > **Add row**. 

    > [!div class="mx-imgBorder"]
    > ![Select add row](media/forecast-add-filter-add-row.png "Select add row")
 
3.	Select the selection box and select attribute as **Potential Customer**, conditions as **Does Not Equals**, and company to be considered as **Adatum Corporation**.
 
    > [!div class="mx-imgBorder"]
    > ![Enter a condition to ignore a company](media/forecast-add-filter-configure-condition-1.png "Enter a condition to ignore a company")

    With this condition, the opportunities related to **Adatum Corporation** will be removed from the forecast. Add the next condition to filter revenue that is more than or equal to **$10,000**.

4.	Select **+ Add** > **Add row**.

5.	Select the selection box and select attribute as **Est. Revenue**, conditions as **Is greater than**, and revenue to be considered as **10000**.

    > [!div class="mx-imgBorder"]
    > ![Enter the second condition](media/forecast-add-filter-configure-condition-2.png "Enter the second condition")
 
    Now, the conditions are created for the query and when the forecast is activated, the query executes to filter the forecast for the added conditions.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Provide permissions](provide-permissions-forecast.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)
</td></tr>
</table>

### See also

[Configure a forecast in your organization](configure-forecast.md)
