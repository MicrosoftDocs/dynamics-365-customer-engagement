---
title: "Customize views in Dynamics 365 for Sales | Microsoft Docs"
description: "Modify the viewd included in Dynamics 365 for Sales to fit the needs of your organization."
keywords: "view; grid; customize"
ms.date: 12/15/2017
ms.service: dynamics-365-sales
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e82c6918-fe81-4812-ad78-743578111064
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
topic-status: Drafting
ms.custom:
  - dyn365-sales
---

# Customize views (Sales, Preview)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc-applies-to-update-9-0-0.md)]

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

In [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview, use views to define how a list of records for a specific entity is displayed. A view defines: 

 - The columns to be displayed 
 - The width of columns displayed 
 - How the list of records are sorted by default 
 - What default filters are applied to restrict which records will appear in the list 
 
The records that are visible in individual views are displayed in a list, sometimes called a grid, which frequently provides options so that people can change the default sorting, column widths, and filters to more easily see the data that’s important to them. Views also define the data source for charts that are used in the application. 

## Types of views 
There are two types of views in [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview: System views and Personal views. System views are views that are included with the app, or created by customizers and made available to some or all users. As a system administrator or system customizer, you can edit System views. System views are special views the application depends on, which exist for system entities or are automatically created when you create custom entities. These views have specific purposes and some additional capabilities.

Personal views are created by individual users and they are visible only to that person or anyone else they choose to share their personal views with. As a user, you can create a new personal view based on a system or public view. You can't create a system or public view based on a personal view. 

This topic covers how to create system views as a customizer. 

## Open a system view

  1. In the left navigation bar, under **Tools**, select **Settings** to go to the **Advanced Settings** page. 
  
     ![Settings in navigation bar](media/views-cust-nav-bar-settings.png "Settings in navigation bar")
  
  2. In **Advanced Settings**, under **Customization**, choose **Views**. 
  
     ![Settings in navigation bar](media/views-cust-advanced-settings.png "Settings in navigation bar")
  
  3. In the **Name** column, select the view to open it, or if you want to search for a view, under **List of system views** in the upper left, in the **Search for records** box, type all or part of the name of the view you want to search for, and then choose the magnifying glass icon. 

     ![Customize views in Advanced settings](media/views-cust-1.png "Customize views in Advanced settings")
 
## Create a new system view
You can create your own views specific to your organization's practices and processes. 

  1. On the **Views** page, choose **Create New** in the upper-right corner. 
  
  2. Select the entity to use for the view. 
  
     ![Select entity](media/views-cust-2.png "Select entity")
     
  3. Choose **Go to View Designer** at the bottom of the pane.
  
     ![Go to View Designer](media/views-cust-3.png "Go to View Designer")
     
  4. To add a name, which is the name displayed in the list of views:
  
     a. Choose **Click to Add View Name** in the upper-left corner of the screen. 
     
     b. Type the name for your view. 
  
        The name is set when you click or tab outside the text box. You can change the name later by clicking it again, or by changing it in the **Properties** tab. 

## Add a column to your view

Views display records in a table that contains rows and columns. Each row is a record, and the fields from the records are determined by the columns you add to the view. 

  1. In the designer, choose **Add** in the upper-left corner.

  2. Select **Primary Entity** or **Related Entity** to display the list of available fields on the **Components** tab. 
  
  3. Do one of the following:
  
     - Double-click the name of the field you want to add. It will be added as the last column in the view. 
     
     - Drag the field onto the grid. You can drag the field to position it before an existing column when you add it. 
     
     - Select the field and press Enter. 
     
     You can also move the columns around after they are added to your view. 

## Set column width

After adding the columns, you can change the width of the column. 

  1. Select the column in the view. 

  2. In the **Properties** tab, set the width to the value you want by choosing the up and down arrows to increase or decrease the column width.

## Set the primary and secondary column sort order
When a view is opened, the records displayed will be sorted in the order you set when creating the view. You can choose to sort on a single column, or two columns with a primary and secondary sort order. When the view is opened, the records will first be sorted by the column defined as the primary sort, and then by the column defined as the secondary sort.  

> [!NOTE]

> You can only set primary and secondary sort on columns from the primary entity. 

  1. Select the column to use as the primary or secondary sort. 
  
  2. In the drop-down menu, select **Primary Sort** or **Secondary Sort**. 
  
     ![Set sort order](media/views-cust-4.png "Set sort order")
 
> [!NOTE]

> If you remove the column defined as the primary sort, the column defined as the secondary sort becomes the primary sort. 

## Set the order for the primary sort 
You can set the sort order to ascending or descending for the column defined as the primary sort column. 

  1. Select the column set as the primary sort. 

  2. Choose the arrow next to the name to change the order. 
  
     ![Set ascending or descending](media/views-cust-sort-order.png "Set ascending or descending")

When the arrow is pointing up, the sort order is ascending. When the arrow is pointing down, the sort order is descending. 

## Rearrange columns in a view 
You can change the order of the columns already included in your view. 

  1. Select the column you want to move.
  
  2. Drag the column to the position you want to move it to. 

     You will see a visual indicator when you hold the column over an allowed position. 

     ![Rearrange columns](media/views-cust-5.png "Rearrange columns")
     
> [!NOTE]

> You can also rearange columns by using the Ctrl+X and Ctrl+V shortcut keys.

## Remove a column from a view 
You may want to remove a column from a default system view, or one that you added to a form but no longer want to use. 

  1. Select the column you want to remove. 

  2. Choose **Remove**. 
  
     ![Remove column](media/views-cust-6.png "Remove column")
     
## Define filter criteria 
You can set filter criteria so that only a subset of the records is displayed in a view. When someone opens the view, only the records that meet the defined filter criteria will be displayed. You can select fields from both the primary and related entities to filter on. 

  1. In the designer, expand the **Filter Criteria** section.
  
     ![Expand filter criteria](media/views-cust-7.png "Expand filter criteria")
  
  2. Choose **Add Filter**. 
  
  3. In the **Select** drop-down, select the field you want to filter on. 
  
  4. In the drop-down in the second column, select the operator to use for the filter. The available operators depend on the selected field. 
  
     ![Select operator](media/views-cust-8.png "Select operator")
     
  5. Enter a value to filter on in the field in the third column. 
  
  
  ## Group multiple filters
  
  You can add multiple filters to your view if you want to filter records using more than one field, and then group on fields, as desired. 
  
  1. Choose **Add Filter** to add an additional filter to your view. 
  
  2. Select the operator to use and type a value to filter on. 
  
  3. Select the check box next to each row of  filter criteria. 
  
     ![Group filters](media/views-cust-9.png "Group filters")
     
  4. Choose **Group And** or **Group Or** to group the filters. 
  
     When you select **Group And**, records that meet both criteria are displayed in the view. When you select **Group Or**, records that meet any of the filter criteria are displayed. For example, in the above example, to show  records for contacts with an address in Seattle or Portland, select **Group Or**. 
     
## Remove a filter group 

  1. Select the check box for the group. 
  
  2. Choose **Ungroup**.  
     
     ![Ungroup filters](media/views-cust-10.png "Ungroup filters")
     
## Clear filters 
You can remove any filters you have created. 

  1. In the **Filter Criteria** section, choose **Clear**. 
  
  2. Choose **OK**.     
     
## Save a view 
As you are working on your view, save it often to avoid losing any changes. 

  - In the designer, choose one of the following in the upper-right corner:
  
     - To save without closing the designer, choose **Save**
  
     - If you're finished customizing your view, choose **Save and Close**. 
 
> [!NOTE]

> To make a copy of your view, choose **Save As** to save the current view with a different name. 
 

## Publish a system view 
When you're finished creating or updating a view, you need to publish it so people in your organization can use it. 

  1. Open the view you want to publish.  

  2. In the designer, choose **Publish**. 

### See also

[Customize forms](customize-forms.md)</br>
[Customize business process flows](customize-business-process-flows.md)
