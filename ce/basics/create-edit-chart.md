---
title: "Create or edit a chart (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: c4d027ca-ba55-4e61-8167-165181dae634
caps.latest.revision: 31
ms.author: "mkaur"
manager: "brycho"
---
# Create or edit a chart

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Present large quantities of data in your organization in a more insightful and graphical way by creating useful charts in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
> [!NOTE]
> [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] includes system charts (built-in charts that come with [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)]) and user charts (created by users). <!--In earlier versions of the product admins and customizers could delete or deactivate system charts. Starting with [!INCLUDE[pn_crm_2015_shortest](../includes/pn-crm-2015-shortest.md)] SP1, system charts can't be deleted or deactivated, however.-->  
  
## Create a chart  
  
1. [!INCLUDE[proc_work_area](../includes/proc-work-area.md)]  
  
2.  Open the chart designer:  
  
     #### If using the Dynamics 365 web application   

    1.  On the right side, choose the **Charts** pane.  
  
    2.  In the **Charts** area, choose **New Chart** **+**.  
  
 <!-- **If using Dynamics 365 for Outlook:**  
  
    -   On the **Charts** tab, in the **Charts** group, choose **New Chart**.  
  -->
3.  Define the properties of the chart.  
  
4.  To specify a different name for the chart, choose the chart name to edit it.  
  
5.  To save the chart, in the chart designer, choose **Save**.  
  
 The chart obtains the data from the view that is selected for a record type. A chart is automatically updated every time that you change the view in the list of records. However, if the chart has been idle for some time, we recommend that you choose **Refresh Chart** on the **Charts** tab, so that the chart and the list of records show the synchronized data.  
  
## Specify what you want to display on the chart  

1.  In the first drop-down box under **Legend Entries (Series)**, select a field to display on the series axis.  

2.  In the **Aggregate** drop-down box, choose the option by which you want to group the field you selected in **Legend Entries (Series)**.  

        For non-numeric fields, you can select only **Count: All** or **Count: Non-empty**. For numeric fields, you can select one of the following aggregation options: **Count: All**, **Count: Non-empty**, **Avg**, **Max**, **Min**, or **Sum**.  

        NULL values are not considered for computing minimum, maximum, and average of data. However, zeros (0) are considered. For example, if you have the following data:  

    |Records|Potential Customer|Established Value|  
    |-------------|------------------------|-----------------------|  
    |Opportunity 1|Account 1|Null|  
    |Opportunity 2|Account 1|250|  
    |Opportunity 3|Account 2|0|  
    |Opportunity 4|Account 2|250|  

        The average for Account 1 is 250 because the NULL value wasn’t used. The average for Account 2 is 125 because the zero was used.  

3.  To create a chart with multiple series, choose the **Add a series** icon ![add&#95;series](../basics/media/add-series.png "add_series"), select another field to display on the series axis, and then select an aggregate option for that series.  

4.  To change the chart type for a series, select the series, choose the **Current chart type** icon for that series, and then select a chart type.  

5.  To stack items in a chart, choose the chart type, and then choose **Stacked** or **100% Stacked**. You can stack items only in a bar, column, or an area chart.  

6.  To display only top items on the chart, choose the **Top/Bottom Rules** icon > **Top X Rule** icon, > **Top 3** or **Top 5**, or **Custom** to specify a different number. For example, to display only the top three opportunities grouped by potential customers, choose the **Top/Bottom Rules** icon > **Top X Rule** icon > **3**.  

    -OR-  

    To display only the bottom items on the chart, choose the **Top/Bottom Rules** icon > **Bottom X Rule** icon > choose **Bottom 3** or **Bottom 5**, or **Custom** to specify a different number.  

7.  From the list under **Horizontal (Category)**, select the field to display on the category axis.  

8.  To create a comparison chart with multiple categories, choose the **Add a category** icon ![add&#95;series](../basics/media/add-series.png "add_series"), and then select another field to display on the category axis.  

        You can add only two category items and one series item to a comparison chart.  

9. For fields that are of the datetime type, choose the option by which you want to group the field you selected as the category.  

    The chart is named based on the fields you chose for the series and category axes.  

## Edit a chart  
  
1. [!INCLUDE[proc_work_area](../includes/proc-work-area.md)]  
  
2.  Open the chart designer:  
  
 **If using the Dynamics 365 web application:**  
  
1.  On the right side, choose the **Charts** pane.  

2.  In the chart area, choose the chart list, choose the chart you want to edit, and then choose the **Edit Chart** button.  
  
 <!--**If using Dynamics 365 for Outlook:**  
  
    1.  On the **Charts** tab, in the **Layout** group, choose **Chart Pane** > **Right** or **Top**.  
  
    2.  In the chart area, choose the chart list, choose the chart you want to edit, and then in the **Charts** group, choose **Edit Chart**.  
-->  
3.  Modify the properties of the chart. For details, see Step 3 in the **Create a chart** section.  
  
### See also  
 [Create or customize dashboards](../customize/create-edit-dashboards.md)   
 
 [Drill down in a chart](../basics/drill-down-chart.md)
 
 [Track your progress with charts](../basics/track-your-progress-with-charts.md)
 
 
