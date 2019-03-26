---
title: "Use document templates in Dynamics 365 for Sales Professional to create standardized documents | MicrosoftDocs"
description: ""
keywords: ""
author: shubhadaj
ms.author: shujoshi
manager: annbe
applies_to: 
	- Dynamics 365 for Customer Engagement
	- Dynamics 365 for Customer Engagement apps version 9.x
ms.date: 03/26/2019
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: d131432d-36d1-4f65-b1fa-29ed85376200
ms.custom: dyn365-sales
---
Use document templates in Dynamics 365 for Sales Professional to create standardized documents
==============================================================================================

You can use both Word and Excel templates in Dynamics 365 for Sales Professional
to create standardized documents for your customers.

Generate a document from the Word template
------------------------------------------

To use the Word template you’ve created, do the following:

1.  Open a record with information you want to create a document. For example,
    open an account record.

2.  On the command bar, select **Word Templates**, and then under **Word
    Templates** select the template you created.

If the template you created is not visible, there are two possibilities:

1.  Only templates built for the selected record type (entity) will be
    displayed. For example, if you open an opportunity record, you will not see
    a template you created with the Account entity.

2.  You need to refresh the page to see the template. Either refresh your
    browser or close and reopen Dynamics 365 for Sales Professional.

After you select your Word template, Dynamics 365 for Sales Professional creates
a Word document from the record you selected.

### Try out the sample Word templates

There are five ready-to-use Word templates included with Dynamics 365 for Sales
Professional.

Document template list showing all Word and Excel templates

Document template list showing all Word and Excel templates

The sample Word templates were created with a specific record type (entity).
You’ll only be able to apply the template to records of the same record type.

| **Name**            | **Entity**  |
|---------------------|-------------|
| Account Summary     | Account     |
| Invoice             | Invoice     |
| Invoice Summary     | Invoice     |
| Opportunity Summary | Opportunity |
| Quote Summary       | Quote       |

To apply a sample Word template

1.  Open a record with information with the entity type that matches the sample
    template. For example, open a customer account record in Sales to apply the
    Account Summary template.

2.  Select **More** (**…**) **\> Word Templates**, and then under **Word
    Templates** select the sample template and then open the newly-created
    template.

>   [!Note]

>   Templates that are included in Dynamics 365 for Sales Professional are
>   read-only and cannot be changed.

Export and analyze data using the Excel template
------------------------------------------------

The process for using an Excel template looks like this.

![Steps to use an Excel template](media/92a6131460f74d59999717af697a34ae.png)

Steps to use an Excel template

### Step 1: Select an entity to analyze

In Dynamics 365 for Sales Professional, select a record type (entity) to analyze
with the Excel template you created.

For example, go to **Sales** \> **Opportunities** \> **My Open Opportunities**.

![Open list of opportunities](media/1c631f55e656ebe299de2954d24b9766.png)

Open list of opportunities

### Step 2: Export Dynamics 365 for Sales Professional data using your new Excel template

Select the Excel template you created. Select **Excel Templates** \> \<template
name\>.

![Select the Pipeline Management Excel template on opportunity record](media/831cc0ec7d6381546835419349bad7d9.png)

Select the Pipeline Management Excel template on opportunity record

### Step 3: Analyze your Dynamics 365 for Sales Professional data in Excel

What you see in the Excel spreadsheet is based on two things:

-   **Rows**. The view you choose to export from determines what records or rows
    you see in the exported Excel file. For example, if you selected Closed
    Opportunities, you’ll see those records even if you used the template
    created with My Open Opportunities.

-   **Columns**. The columns correspond to the fields in a record. The template
    you used determines what columns appear in the table in the exported Excel
    file. For example, the Closed Opportunities view has these columns:
    Potential Customer, Status, Actual Revenue, and Actual Close Date. But if
    the template you used was based on My Open Opportunities, you’d see columns
    associated with that view and any column filtering done when you created the
    template.

### Step 4: Share the results with others

Save a copy either online or to your computer. Send the file to others for their
review and input.

### Try out the sample Excel template

There’s a ready-to-use Excel template included with Dynamics 365 for Sales
Professional.

Document template list showing all Word and Excel templates

Document template list showing all Word and Excel templates

The sample Excel template is created specifically for the opportunity records.
You’ll only be able to apply the template to opportunity records.

To apply a sample Excel template

1.  Go to list of opportunities.

2.  On the command bar, select **Excel Templates**, and then under **Excel
    Templates**, select the sample template.

3.  Download the template or open it in place in Excel.

>   [!Tip]

>   You can export the templates that are included in Dynamics 365 for Sales
>   Professional, modify them, and then reimport them as new templates. This can
>   give you a running start on creating your own custom Excel templates.

### See Also

Manage Excel templates in Dynamics 365 for Sales Professional  
Manage Word templates in Dynamics 365 for Sales Professional Overview of
Dynamics 365 for Sales Professional
