---
title: "Use document templates in Dynamics 365 Sales Professional to create standardized documents | MicrosoftDocs"
description: "Send out standardized and consistent documents to your customers by using document templates in Dynamics 365 Sales Professional."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Use document templates to create standardized documents

You can use both Microsoft Word and Excel templates in Dynamics 365 Sales Professional to create standardized documents for your customers.

## Generate a document from a Word template

To use a Word template you’ve created, do the following:

1.  Open a record that contains information you want to use to create a document. For example, open an account record.

2.  On the command bar, select **Word Templates**. Under **Word Templates**, select the template you created.

    If the template you created is not visible, there are two possibilities:

    - Only templates built for the selected record type (entity) will be
    displayed. For example, if you open an opportunity record, you will not see a template you created with the Account entity.

    - You need to refresh the page to see the template. Either refresh your
    browser or close and reopen Dynamics 365 Sales Professional.

After you select your Word template, Dynamics 365 Sales Professional creates a Word document from the record you selected.

## Export and analyze data using the Excel template

The process for using an Excel template looks like this.

![Steps to use an Excel template](media/steps-use-excel-template.png "Steps to use an Excel template")

### Step 1: Select an entity to analyze

In Dynamics 365 Sales Professional, select a record type (entity) to analyze with the Excel template you created.

For example, go to **Sales** > **Opportunities** > **My Open Opportunities**.

![List of opportunities](media/opportunity-list.png "List of opportunities")

### Step 2: Export Dynamics 365 Sales Professional data using your new Excel template

Select the Excel template you created. Select **Excel Templates** > \<template name>.

![Select the Pipeline Management Excel template on opportunity record](media/pipeline-management-template.png "Select the Pipeline Management Excel template on opportunity record")

### Step 3: Analyze your Dynamics 365 Sales Professional data in Excel

What you see in the Excel spreadsheet is based on two things:

 - **Rows**. The view you choose to export from determines the records or rows that you see in the exported Excel file. For example, if you select Closed Opportunities, you’ll see those records, even if you used the template created with My Open Opportunities.

 - **Columns**. The columns correspond to the fields in a record. The template you used determines the columns that appear in the table in the exported Excel file. For example, the Closed Opportunities view has the columns Potential Customer, Status, Actual Revenue, and Actual Close Date. But if the template you used was based on My Open Opportunities, you’ll see columns associated with that view and any column filtering that was done when you created the template.

### Step 4: Share the results with others

Save a copy either online or to your computer. Send the file to others for their review and input.

### See also

[Manage Excel templates in Dynamics 365 Sales Professional](manage-excel-templates.md)  
[Manage Word templates in Dynamics 365 Sales Professional](manage-word-templates.md)  
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]