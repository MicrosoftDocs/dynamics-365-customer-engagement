---
title: "Organize and lay out your report data (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: b4a11cd3-87aa-46b3-9073-6d2ae9d28717
caps.latest.revision: 23
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Organize and lay out your report data

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

When you create a report, you have to decide which columns to include, the order in which they are displayed, and whether to group data into subcategories. By grouping and summarizing the data, you make it easier to see the patterns.  
  
 For example, your report could use one level of grouping to group opportunities by salesperson, or add a second level of grouping to show each quarter's opportunities, or add a third level to show the percentage won and lost in each quarter.  
  
 To use a chart in your report, if your report has no grouping, you must select at least one numeric column. If your report uses grouping, you must select at least one numeric column with a summary type defined.  
  
##  Define how to organize the report  

To group items so that they are organized together in the report by date or other common properties.  

1. For each grouping level you need, click or tap **Click here to add a grouping**.  

2. Define the grouping:  

   - **Record type**. You can select records from the primary record type you selected, and from any related record types. If you selected a secondary record type, you can also select records from the secondary record type and its related records types.  

   - **Column**. The name of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] field that contains the data to define the grouping.  

   - **Time interval**.  For datetime fields, group the data by Month, Day, Week, or Year.  

   - **Sort order**. Sort order for displaying the groups.  

   - **Column width**. Width of the column heading in pixels.  

   - **Summary type**. You can group records by a count of matching records.  

3. To reorder the grouping levels, use the up and down arrows in the **Common Tasks** section.  

4. Click or tap **OK**.  

### To define the sort order within each group

1. Click or tap **Configure Sorting**

2. Select a column and sort order

3. Click or tap **OK**.  

### To limit reports to groups with the highest or lowest values

1. Click or tap **Set Top or Bottom Number**:  

2. Select **Top** or **Bottom**.  

3.  Select the number of groups to display.  

4.  Click or tap **OK**.  

##  Define which columns to display in the report

You can display columns that show data from a record, or columns that show summary information.  

1. For each column you want to include, click or tap **Click here to add a column**:  

   - **Record type**.  You can select records from the primary record type you selected, and from any related record types.  If you selected a secondary record type, you can also select records from the secondary record type and its related records types.  

   - **Column**. The name of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] field that contains the data to display or summarize.  

   - **Data type**. The data type of the column, one of: primarykey,  nvarchar,  picklist,  bit,  decimal, int,  float,  money,  ntext, datetime,  owner, lookup.  

   - **Name**. The name used in the database.  

   - **Column width**. The width in pixels of the column.  

   - **Summary type**.  The specific type of summaries available depends on the data type of the column.  

   - **None**:  lookup,  datetime,  owner,  picklist, bit,  ntext  

   - **Average**, **Maximum**, **Minimum**, **Percent of Total**, **Sum**: all numeric record types (decimal, int, float, money)  

   - **Include unformatted value column**. Typically, in a report, the underlying data is formatted as plain text. When you export the report to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)], you can’t change the format of the cell that contains the exported data (plain text) to a different format. This causes problems with calculations. To avoid this, you can select the **Include unformatted value column** check box for fields of type Date Only, Date and Time, Whole Number, Decimal, Currency, or Floating Point Number. This adds a column, which contains the unformatted value of the fields, to the report.  

2. Use the left and right arrows to reorganize the columns.  

3. Click or tap **OK**.  

4. Click or tap **Next**.  
  
### See also  
 [Create, edit, or copy a report using the Report Wizard](../basics/create-edit-copy-report-wizard.md)
 [Get started writing reports](../analytics/get-started-writing-reports.md)
