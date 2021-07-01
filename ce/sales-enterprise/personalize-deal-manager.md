---
title: "Personalize deal manager workspace - Sales Enterprise | MicrosoftDocs"
description: "As a seller, personalize the grid and apply filters to suit your needs. You can then save your changes as a new view that you can switch to quickly."
ms.date: 06/30/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Personalize deal manager (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

As a seller, you can personalize the deal manager workspace to suit your needs. You can,

- Personalize the grid.
- Apply filters to view records that are important to you.
- Change the layout of the workspace to either list (grid only) or combo (grid and chart).  
- Change the metrics displayed at the top of the workspace.
- Save all your personalization changes as a view so that you don't have to modify every time.  
- Create multiple views and switch between them easily. 

## Personalize metrics 

The deal manager workspace lists important metrics related to the sales pipeline at the top of the workspace. You can personalize this space to view metrics that you want to track.  

> [!NOTE]
> After you personalize the metrics, save the changes as a view. Otherwise, the metrics will be lost if you switch to a different page or refresh the browser.

**To personalize metrics:**

1. In the Sales Hub sitemap, select **Deal manager (preview)**.
1. Select **Combo** > **Edit Metrics**.
   In the **Edit metrics** side panel, you can create, update, remove, or delete a metric.
1. To create a metric,
    1. Select **Create a Metric**.
    1. Select the field and the aggregate function that you want to use for calculating the metric.
       The **Field** list displays all the numerical fields in the opportunity entity. 
    1. (Optional) Add filters to calculate metrics from specific records. For example, if you want to view the estimated revenue of all opportunities created in this year and are in the **Develop** stage, create a metric with the following values:
    - **Field:** Est. Revenue
    - **Aggregate function:** Sum
    - **Filters**
        - **Created On**: This year
        - **Sales Stage**: Develop 
2. To edit a metric, hover over the metric and select the **Edit** icon.
3. To remove a metric temporarily, clear the checkbox against the metric.
1. Save the changes to a view so that the personalized metrics are available even after you navigate away from the page.

## Personalize the grid

Personalize the grid to include columns that you want to see and update quickly. You can,
- Add or remove columns from the grid.
- Show or hide columns.
- Drag-and-drop columns to rearrange them in the grid.
- Resize, sort, and group records by columns.  

**To personalize the grid**

1. In the deal manager workspace, scroll down to the grid.
1. Select **Edit columns** to add, remove, hide, show, and rearrange columns. Alternatively, you can select the column drop-down and select **Insert basic column** to add a column to left or right of the selected column.
    1. To add a basic or a smart column, select **Add column** in the **Edit columns** panel.
        - **Basic column**    
          Lets you select a column from the opportunity or related entities such as account, contact, price list, and so on.
        - **Smart column**
          Lets you select a column that performs certain computations on the records to display smart and actionable information. For more information, see (What are Smart columns?)[#smart-columns] 
          <!--Need to add a screenshot-->
    2. To show or hide columns, select or clear the checkboxes. You cannot delete the default columns from the grid. However, you can hide them.
    1. To rearrange columns, drag-and-drop the columns in the **Edit columns** panel or in the grid.
1. To sort 
### What are Smart columns

A smart column performs certain computations on the existing columns to display smart and actionable information. For example, the **Revenue** column displays the actual revenue if the opportunity is closed, else it displays the estimated revenue. These columns save you the trouble of manual computation and makes it easy for you to look at opportunities that need your attention. For example, the **Next activity** column displays the upcoming and overdue activities so that you can stay on top of your deals.  

The following smart columns are available:


|Name  |Computation  |Action  |
|---------|---------|---------|
|Close date     | Displays the actual close date if the opportunity is closed, else it displays the estimated close date.         |None         |
|Revenue     |Displays the actual revenue if the opportunity is closed, else it displays the estimated revenue.         |None         |
|Last activity     |Displays the days elapsed since the last interaction on the opportunity.         |Add activity from the column         |
|Next activity     |Displays the next activity and its date if all the activities in the past are closed. If any of the activities in the past are still open, this column displays the list of open activities, along with a Overdue warning.          |  View activity, add activity, or change activity status       |



## Create views

### See also
- [Access deal manager workspace](deal-manager-overview.md)



