---
title: "Create and deploy Excel templates (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Create Excel templates that you can use to export, format, and share data from multiple records in Dynamics 365 for Marketing"
keywords: "administration; organization settings; Excel; templates; export"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2ab960e0-95ae-44bf-938c-a357a1982c4e
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom: dyn365-marketing; dyn365-admin
---

# Manage [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] provides powerful ways to analyze and present your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data. With [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates, you can easily create and share your customized analysis with others in your organization.

You can use [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates for:

- Sales forecasting
- Pipeline management
- Leads scoring
- Territory planning
- And much more…

Try out the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates included with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to get a quick view of what kind of analysis is possible. The Pipeline Management template is shown here:

![An example of an Excel template](media/excel-template.png "An example of an Excel template")

Templates display information from the view defined for a record type (entity). There are four steps for creating an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template.

![The process for creating an Excel template](media/excel-template-process-ill.png "The process for creating an Excel template")

## Step 1: Create a new template from existing data

1. Sign in to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] as a user with the System Administrator role.

1. Go to **Settings** > **Advanced Settings** > **Organization** > **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] & [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates** and choose **+ New Template**.

1. Select **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] Template**, and then select **Next**.

    ![Choose which type of template to create](media/create-template-type.png "Choose which type of template to create")

1. Select an entity to which the template applies. The template will use data from this entity. The views you can select in the next field depend on the entity you select.

1. The view defines the query used to display records and the columns or fields that are shown. Select a view, and then select **Next**.

    ![Choose an entity and view for the template](media/create-template-excel-entity.png "Choose an entity and view for the template")

1. On the **Download Template** page, select **Download**.

1. To upload the template later, select the **Upload the template later** check box, and then select **Next**.

1. To upload the template after you customize the data, go to the list of templates, and then select **Upload Template**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Step 3: Upload the template and share with others](#step-3-upload-the-template-and-share-with-others)

## Step 2: Customize the data in [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)]

Open the newly created template in [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] to customize the data.

![A newly created Excel template](media/excel-new-template.png "A newly created Excel template")

Let's walk through a simple example of customizing an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template by using [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] sample data:

1. Select **Enable Editing** to allow customization of the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook.

1. Add a new column, and name it "Expected Revenue".

    ![Adding a column to an Excel template](media/excel-new-column.png "Adding a column to an Excel template")

1. Create a formula for expected revenue. Don't refer to cells by using their addresses; define and use names instead.

    ![Create a formula based on column names](media/excel-formula.png "Create a formula based on column names")

1. Create a pivot table and chart.

1. Place user-added content above or to the right of the existing data table. This prevents the content from being overwritten if you add new data in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] later and you create a new [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices and considerations for using Excel templates](#best-practices-and-considerations-for-using-excel-templates)

    ![A customized Excel template](media/excel-graph.png "A customized Excel template")

1. Save the workbook.

You're now ready to upload the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

## Step 3: Upload the template and share with others

When you have your [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template customized the way you want, you can upload it into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

> [!NOTE]
> Users in your organization can see the templates available to them by selecting **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] Templates** on the command bar in the list of records.

To upload the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]:

1. In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to **Settings** > **Advanced Settings** > **Organization** > **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] & [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates** and choose **Upload Template**.

1. Find and upload the file.

    ![Upload Template dialog](media/excel-upload-template.png "Upload Template dialog box")

1. Select **Upload**.

1. You'll see the summary of the file you're uploading.

1. Select **Finish**.

<a name="best-practices-and-considerations-for-using-excel-templates"></a>

## Best practices and considerations for using [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates

Here are some things you need to be aware of to create and make the best use of [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]:

- **Test your [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates**  
[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] has lots of features. It's a good idea to test your customizations to see that all [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] features work as expected in your templates.
- **Data in templates and privacy concerns**  
By default, pivot chart data is not updated when a workbook is opened. This can create a security issue if certain pivot chart data should not be seen by users who have insufficient permissions. Consider the following scenario:
  - A [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] administrator creates a template where the view contains sensitive data in a pivot chart, which is uploaded into [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].
  - A salesperson who should not have access to the sensitive data in the pivot charts uses the template to create an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file to do data analysis.

  As a result, the salesperson might be able to see the pivot chart data as uploaded by the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] administrator, including access to views for which the salesperson does not have permissions.
  > [!IMPORTANT]
  > Sensitive data should not be included in pivot tables and pivot charts.

  > [!NOTE]
  > iOS does not support updating pivot data and pivot charts when using the [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] app on iOS devices.
- **Set pivot chart data to automatically refresh**  
By default, pivot chart data is not automatically refreshed when you open the workbook. Other types of charts are updated automatically. In [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)], right-click the pivot chart, and then select **PivotChart Options** &gt; **Refresh data** when opening the file.
  ![Pivot table options in Excel](media/excel-pivot-options-ill.png "Set pivot chart data to be automatically refreshed")
- **Placing new data**  
If you want to add content to the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template, place your data above or to the right side of the existing data. A second option is to place your new content on a second sheet.
- **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates with images might cause an error**  

If you attempt to view [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] data by using an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template that has an image saved in it, you might see the following message: "An error occurred while attempting to save your workbook. As a result, the workbook was not saved." Try removing the image from the template and reloading the template into [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].
- **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates and [!INCLUDE[pn-office-shortest](../includes/pn-office-shortest.md)] Mobile app in [!INCLUDE[pn-windows-8-1](../includes/pn-windows-8-1.md)]**  
[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates will not open in [!INCLUDE[pn-windows-8-1](../includes/pn-windows-8-1.md)] devices with the [!INCLUDE[pn-office-shortest](../includes/pn-office-shortest.md)] Mobile app. You'll get the following error message: "We've recovered as much of your document as we could, but you can't edit it. Try to open and repair the document on your PC to fix the problem." This is a known issue.
- **Use table column names and range names in formulas**  
When you create [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] formulas, don't use column titles or cell numbers. Instead, use the table column names, and define names for cells or cell ranges.

### See also

[Export data to Word or Excel docs](export-data-word-excel.md)  
[Business management settings](business-management-settings.md)
