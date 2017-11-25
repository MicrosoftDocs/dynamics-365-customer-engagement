---
title: "Customize views in Dynamics 365 for Sales | Microsoft Docs"
description: "Modify the viewd included in Dynamics 365 for Sales to fit the needs of your organization."
keywords: "view; grid; customize"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e82c6918-fe81-4812-ad78-77d178111064
author: brycho
ms.author: brycho
manager: amyla
ms.reviewer: 
topic-status: Drafting
---

# Customize views in Dynamics 365 for Sales, Business edition

In Dynamics 365, use views to define how a list of records for a specific entity is displayed in the application. A view defines: 

 - The columns to display 
 - The width of columns displayed 
 - How the list of records are sorted by default 
 - What default filters are applied to restrict which records will appear in the list 
 
The records that are visible in individual views are displayed in a list, sometimes called a grid, which frequently provides options so that people can change the default sorting, column widths, and filters to more easily see the data that’s important to them. Views also define the data source for charts that are used in the application. 

## Types of views 
There are two types of views available, System views and Personal views. System views are views that are included with the app, or created by customizers and made available to some or all users. As a system administrator or system customizer, you can edit System views. System views are special views the application depends on, which exist for system entities or are automatically created when you create custom entities. These views have specific purposes and some additional capabilities.

Personal views are created by individual users and they are visible only to that person or anyone else they choose to share their personal views with. As a user, you can create a new personal view based on a system or public view, you cannot create a system or public view based on a personal view. 

This topic covers how to create system views as a customizer. 

## Search for a view 
You can easily find a view by searching for the view name. 

  1. Access the **Settings** page in the Sales app. 
  2. Choose **Views**. 
  3. Type all or part of the name of the view you want to search for in the **Search for records** box under **List of system views**, and then click the magnifying glass icon. 

 ART GOES HERE
 
## Create a new system view
You can create your own views specific to your organizations practices and processes. 

  1. On the **Views** page, choose **Create New**. 
  2. Select the entity to use for the view. 
     ART GOES HERE
  3. Choose **Go to View Designer**.
     ART GOES HERE
     
## Add a name for your view 
Provide a name for your view. This is the name that is displayed in the list of views. 

  1. Choose **Click to Add View Name**. 
  2. Type the name for your view. 
  
The name is set when you click outside of the text box. You can change the name later by clicking on it again, or by changing it in the **Properties** tab. 

## Add a column to your view

Views display records in a table that contains rows and columns. Each row is a record, and the fields from the records are determined by the columns you add to the view. 

  1. In the designer, click **Add**.

  2. Select either **Primary Entity** or **Related Entity** to display the list of available fields on the **Components** tab. 
  
  3. Double-click the name of the field you want to add. 
  
To add a column, you can also click and drag the field onto the form, or select the field and press Enter. If you double-click the field, it will be added as the last column in the view. You can drag the field to position it before an existing column when you add it. You can also move the columns around after they are added to your view. 

## Set column width

After adding the fields / columns you want to add, you can change only the width of the field under Properties. 

  1. Select the column in the view. The **Properties** tab automatically opens. 

  2. Set the width to the value you want. 

## Define a web resource

Specify a web resource, such as an image, text, or script file, to associate with a column in your view. 

  1. Open the view you want to customize.

  2. Select the column you want to add a web resource to. 

  3. On the **Properties** tab, click **Advanced**.

  4. Click the drop-down menu, and then select the web resource you want to use.

  5. In the **Function Name** box, add a function name. 

## Set the Primary and Secondary column sort 
When a view is opened, the records displayed will be sorted in the order you set when creating the view. You can choose to sort on a single column, or two columns with a primary and secondary sort order. When the view is opened, the records will first be sorted by the column defined as the primary sort, and then by the column defined as the secondary sort.  

> [!NOTE]

> You can only set primary and secondary sort on columns from the primary entity. 

  1. Select the column to use as the primary or secondary sort. 
  
  2. Click the drop-down menu, and then select **Primary Sort** or **Secondary Sort**. 
  
     ART GOES HERE
 
If you remove the column defined as the primary sort, the column defined as the secondary sort becomes the primary sort. 

## Set the order for the primary sort 
You can set the sort order, ascending or descending, for the column defined as the primary sort column. 

  1. Select the column set as the primary sort. 

  2. Click the arrow next to the name to change the order. 

When the arrow is pointing up, the sort order is ascending. When the arrow is pointing down, the sort order is descending. 

## Rearrange columns in a view 
You can change the order of the columns already included in your view. 

  1. Select the column you want to move.
  
  2. Click and drag the column to the position you want to move it to, and then drop it. 

     You will see a visual indicator when you hold the column over an allowed position. 

     ART GOES HERE

## Remove a column from a view 
You may want to remove a column from a default system view, or one that you added to a form but no longer want to use. 

  1. Select the column you want to remove. 

  2. Click Remove. 
  
     ART GOES HERE
     
## Define filter criteria 
You can set filter criteria to so that only a subset of the records is displayed in a view. When someone opens the view, only the records that meet the defined filter criteria will be displayed. You can select fields from both the primary and related entities to filter on. 

  1. In the designer, expand the **Filter Criteria** section.
  
     ART GOES HERE
  
  2. Click **Add Filter**. 
  
  3. Click the **Select** drop-down, and then select the field you want to filter on. 
  
  4. Click the drop-down in the second column to select the operator to use for the filter. The operators available depend on the field selected. 
  
     ART GOES HERE
     
  5. Enter a value to filter on in the field in the third column. 
  
  
  ## Group multiple filters
  
  You can add multiple filters to your view if you want to filter records using more than one field. 
  
  1. Click **Add Filter** to add an additional filter to your view. 
  
  2. Select the operator to use and type a value to filter on. 
  
  3. Click the check box next to each of the filter criteria. 
  
     ART GOES HERE
     
  4. Select **Group And** or **Group Or** to group the filters. 
  
     When you select **Group And**, only records that meet both criteria are displayed in the view. When you select **Group Or**, records that meet any of the filter criteria are displayed. For example, to show only records for contacts with an address in Seattle or Portland, select **Group Or**. 
     
## Remove filter groups 

  1. Click the check box for the group. 
  
  2. Click **Ungroup**.  
     
     ART GOES HERE
     
## Clear filters 
You can remove any filters you have created. 

  1. In the **Filter Criteria** section, click **Clear**. 
  
  2. Click OK to confirm that you want to clear all filters.     
     
## Save a view 
As you are working on your view, save it often to avoid losing any changes. 

  - In the designer, click **Save**. 
  
If you have not already provided a name for your view, a dialog is displayed where you can enter a name and description.      

ART GOES HERE

When you are finished customizing your view, you can use Save and Close, which saves your view and closes the designer. 

  - In the designer, click **Save and Close**. 
  
If you want to make a copy of your view, click Save As to save the current view with a different name. 

  - In the designer, click **Save As**. 

## Publish a system view 
When you are finished creating or updating a view, you need to publish it so people in your organization can use it. 

  1. Open the view you want to publish.  

  2. In the designer, click **Publish**. 


