---
title: "View and export KPI data (GDPR) (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "View KPI data for account, contact, lead, and opportunity using system views, and export the data to an Excel file."
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/18/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ada3bf5d-f083-4e2b-947e-b402e4068392
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# View and export KPI data (GDPR)

Applies to Dynamics 365 (online), version 9.0.2

View KPI data for account, contact, lead, and opportunity using system views, and export the data to an Excel file. The KPI data is stored in the following entities:

- **Account KPI Items**
- **Contact KPI Items**
- **Lead KPI Items**
- **Opportunity KPI Items**

You can use the system views for these entities or create your own views to view the data.

1.  Go to **Advanced Find**.
1.  In the **Look for** list, select the record type as one of the entities mentioned earlier.
1.  Select a system view from the **Use Saved View** list or create a new view. 
    ![](media/view-kpi-data-gdpr.png)
1.  Specify the columns to include in the view by selecting **Edit Columns**, and then selecting the columns to display.
2. Select **Results** to view the data.

For detailed information about using Advanced Find, see [Create, edit, or save an Advanced Find search](../basics/save-advanced-find-search.md)

After viewing the results, you can export data to Microsoft Excel, if required. You can do so by selecting the export to Excel option from the command bar.

![](media/export-excel-gdpr.png)

For more information about exporting data from dynamics 365 Customer Engagement to excel, see [Export data to Excel](../basics/export-data-excel.md)

## See also

[Embedded Intelligence and GDPR](embedded-intelligence-gdpr.md)