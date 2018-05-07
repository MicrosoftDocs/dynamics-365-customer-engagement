---
title: "Export data (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to export data to a Microsoft Word or Excel document from Dynamics 365 for Marketing"
keywords: "Word; Excel; export; template"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: aac5aed4-0dd6-418f-bcbe-f2380e2ecf03
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom: dyn365-marketing
---

# Export [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data to [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] or [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] docs

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

You can export [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data to a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] or [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template to create standardized documents that you can share with people who don't use [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

> [!TIP]
> You can export the templates that are included in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], modify them, and then reimport them as new templates. This can give you a running start on creating your own custom [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] templates.

## Generate a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] document with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data

You can export information from a single record by using a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, which formats the information into a readable and sharable document.

To export [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data by using a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, do the following:

1. Open a record, such as a single contact, with information you want to use in your document.

1. On the command bar, select **[!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates**, and then under **[!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates**, choose the template want to use. If you don't see the template you are looking for, consider the following:
    - Only templates built for the selected record type (entity) will be displayed. For example, you won't see a template created for accounts when you are working with a contact.
    - If you are looking for a brand-new template, you might need to refresh the page to see it. Either refresh your browser or close and reopen [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

After you select your [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] creates a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] document from the record you selected.

Several sample [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] templates, for a variety of entities, are included out of the box. Your administrator can add more as needed, either by customizing the standard ones or creating new ones from scratch. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage Word templates](manage-word-templates.md)

## Generate an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]

You can export information from a multiple-record list by using an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template, which formats the information and generates graphs to create a readable and sharable workbook.

The process for using an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template looks like this:

![The process for using an Excel template](media/excel-process-ill.png "The process for using an Excel template")

### Step 1: Select an entity to analyze

In [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], select a record type (entity) to export to an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook.

For example, go to **Marketing** &gt; **Lead Management** &gt; **Leads**.

### Step 2: Export [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data by using an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] template

On the command bar, select **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] Templates** to open a list of available templates, and then choose the one you want to use for the export.

![Choose an Excel template to export to](media/export-choose-excel-template.png "Choose an Excel template to export to")

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] generates your [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook and downloads it to your computer.

### Step 3: Analyze your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data in [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)]

What you see in the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook is based on two things:

- **Rows**: Your [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook includes a row for each record that was visible in the view you exported from.
- **Columns**: The columns correspond to the fields in a record. The template you used determines which columns appear in the table in the exported [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file.

### Step 4: Share the results with others

Save a copy either online or to your computer, and then share the workbook or link with others for their review and input.

### See also

[Manage Excel templates](manage-excel-templates.md)  
[Manage Word templates](manage-word-templates.md)  
[Business management settings](business-management-settings.md)
