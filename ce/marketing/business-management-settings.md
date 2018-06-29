---
title: "Business management settings (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Learn how to import data and control how duplicate records are identified in Dynamics 365 for Marketing"
keywords: "administration; import; export; duplicate detection"
ms.date: 04/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 9c480d38-9c4a-4875-a115-d064a9b327f4
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Business management settings

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

This topic describes what you can do when working in the **Advanced Settings** > **Business Management** section of the **Settings** work area.

<a name="import"></a>

## Import data and manage imports

Bring your customer and sales data quickly into your app by importing it. You can import data into most record types.

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] processes imports in the background. After an import is completed, you can review which records were successfully imported, failed to be imported, or were partially imported. To fix the records that failed to be imported, export them into a separate file, fix them, and then try to import them again (if necessary, you can start over by deleting all records associated with the previous import).

Data can be imported from:

- Most list views
- The **Settings** > **Advanced settings** > **Business management** > **Import data** settings page

When you import data while working in the **Settings** work area, you must select the entity you want to import to (such as a lead or contact).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Import data](import-data.md)

<a name="export"></a>

## Export data or templates

Present information to people who don't have access to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] by exporting the data to an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] workbook. You can export just the data from a list, or you can export a template.

When you export a template, a ready-made workbook with column headings matching the fields of the record is created for you. Templates are already formatted as expected by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], so they are easy to edit and reimport later.

Data and templates can be exported from:

- Most list views
- The **Settings** > **Advanced settings** > **Business management** > **Export data** page

When you export data or templates while working in the **Settings** work area, you must select the entity you want to export (such as a lead or contact). You can also choose the view that will be used for exporting. If you don't choose a view, the default view is selected, and the data or template for all the columns in that view are exported.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Export data](export-data-word-excel.md)

<a name="duplicate-detection"></a>

## Keep your data clean by using duplicate detection

To maintain the integrity of your data, it's a good idea to set up duplicate detection to find duplicate records in the system. By default, duplicate detection is already enabled for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

### Duplicate detection rules

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] includes duplicate detection rules for accounts and contacts. The rules are automatically published when duplicate detection is enabled.

- Accounts with the same account name are found
- Contacts with the same first name and last name are found
- Contacts with the same email address are found

If any of these rules are deleted, duplicate detection won't work as expected.

### Enable duplicate detection

If duplicate detection is disabled, duplicates won't be detected. To enable duplicate detection:

1. Go to **Settings** > **Advanced Settings** > **Business Management** > **Duplicate Detection**.
1. Select **Enable**.

### When does duplicate detection happen?

If duplicate detection is enabled, duplicates are detected when:

- **A record is created or updated**: The system checks for duplicates when a user enters or updates records.
- **During data import**: When you use the Import Data wizard to bring in contacts or accounts, the wizard detects any duplicate records.

> [!IMPORTANT]
> Duplicates aren't detected when a user merges two records, activates or deactivates a record, or saves a completed activity.

### Disable duplicate detection

If your system contains a large number of records, checking for duplicates can affect performance. You might want to disable duplicate detection at such times.

1. To disable duplicate detection, go to **Settings** > **Advanced Settings** > **Business Management** > **Duplicate Detection**.
1. Select **Disable**.

All the duplicate detection rules will be unpublished in the back end.

### See also

[Import data](import-data.md)  
[Manage Excel templates](manage-excel-templates.md)  
[Manage Word templates](manage-word-templates.md)  
[Export data](export-data-Word-Excel.md)
