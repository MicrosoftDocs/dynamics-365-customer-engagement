---
title: View and export KPI data
description: View KPI data for contact, lead, and opportunity using system views, and export the data to an Excel file in Sales Insights.
ms.date: 09/08/2022
ms.topic: article
author: udaykirang
ms.author: udag
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.assetid: ada3bf5d-f083-4e2b-947e-b402e4068392
topic-status: Drafting
---
# View and export KPI data

View KPI data for contact, lead, and opportunity using system views, and export the data to an Excel file. The KPI data is stored in the following entities:

- **Contact KPI Items**
- **Lead KPI Items**
- **Opportunity KPI Items**

> [!NOTE]
> This topic is applicable only for the [Relationship Analytics](relationship-analytics.md) feature.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## View KPI data

You can use the system views for these entities or create your own views to view the data.

1.  Go to **Advanced Find**.
1.  In the **Look for** list, select the record type as one of the entities mentioned earlier.
1.  Select a system view from the **Use Saved View** list or create a new view. 
    ![View KPI data](media/view-kpi-data-gdpr.png "View KPI data")
1.  Specify the columns to include in the view by selecting **Edit Columns**, and then selecting the columns to display.
2. Select **Results** to view the data.

For detailed information about using Advanced Find, see [Create, edit, or save an Advanced Find search](/dynamics365/customer-engagement/basics/save-advanced-find-search)

After viewing the results, you can export data to Microsoft Excel, if required. You can do so by selecting the export to Excel option from the command bar.

![Export data to Microsoft Excel](media/export-excel-gdpr.png "Export data to Microsoft Excel")

For more information about exporting data from Dynamics 365 Sales to excel, see [Export data to Excel](/dynamics365/customer-engagement/basics/export-data-excel)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## See also

[Privacy and personal data for Microsoft Dynamics 365](/dynamics365/get-started/gdpr)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
