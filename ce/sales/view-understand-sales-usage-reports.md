---
title: View and understand sales usage reports
description: View and understand sales usage reports in Microsoft Dynamics 365 Sales to analyze operational metrics and key performance indicators (KPIs) of your contacts, accounts, leads, and opportunities.
ms.date: 03/31/2023
ms.topic: conceptual
author: udaykirang
ms.author: udag
manager: shujoshi
ms.custom: bap-template
---

# View and understand sales usage reports

The sales usage reports provides a snapshot view of the historical operational metrics and key performance indicators (KPIs) of your contacts, accounts, leads, and opportunities. 

The reports only include data that has been added or updated in the application from the day of enablement. After enabling, it may take up to three days for the sales usage reports to display data, there after, the data is refreshed every 24 hours.

Also, the actions that are performed in the application are reflected in the sales usage reports. Actions such as, bulk import, bulk update, and records updated through the API are not reflected in the sales usage reports.

> [!NOTE]
> - Sales usage reports aren't available in Government Community Cloud (GCC) tenants.
> - The updated or added data may take up to three days to show in the reports.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | Sales Manager<br>See [Predefined security roles for Sales](security-roles-for-sales.md) |

## Open sales usage reports

Sign in to your sales app. In the lower-left corner of the page, select **Change area** > **Sales** > **Sales analytics** > **Sales usage reports**.

The following sales usage reports are available:

- [Opportunity usage report](#opportunity-usage-report)  
- [Lead usage report](#lead-usage-report)
- [Account usage report](#account-usage-report)
- [Contact usage report](#contact-usage-report)

### Data filters

Use the filtering options at the top of each report to view only the information that's relevant to you. You can filter by date, user, manager, business unit, and role. By default, the reports show data for the previous 20 weeks.

## Opportunity usage report

The following table describes the KPIs that are shown in the opportunity usage report tab. For each KPI, an arrow indicates the trend. For example, a green upward arrow indicates an improvement in the trend when compared to the previous time period.

| KPI | Description |
|--------|---------|
| **Created** | The number of opportunities sellers created, and the number of sellers who created opportunities, during the specified time period |
| **Viewed** | The number of opportunities sellers viewed, and the number of sellers who viewed opportunities, during the specified time period |
| **Updated** | The number of opportunities sellers updated, and the number of sellers who updated opportunities, during the specified time period |
| **Deleted** | The number of opportunities sellers deleted, and the number of sellers who deleted opportunities, during the specified time period |
| **Opportunities converted** | The number of opportunities sellers converted into won deals, and the number of sellers who converted opportunities, during the specified time period |

The following table describes the summary charts that are displayed in the report.

| Chart name | Description |
|------------|-------------|
| **Actions performed on opportunities over time** | The trend of actions taken on opportunities in the specified time period: created, viewed, updated, and deleted |
| **Number of users contributing to actions performed on opportunities** | The number of users who performed various actions on opportunities during the specified time period |
| **Users with most opportunities created** | The top four contributors who created opportunities during the specified time period |
| **Users with most opportunities updated** | The top four contributors who updated opportunities during the specified time period |
| **Users with most opportunities converted** | The top four contributors who converted opportunities into won deals during the specified time period |
| **Status of opportunities over time** | A breakdown of opportunities by status during the specified time period |

## Lead usage report

The following table describes the KPIs that are shown in the lead usage report tab. For each KPI, an arrow indicates the trend. For example, a green upward arrow indicates an improvement in the trend when compared to the previous time period.

| KPI | Description |
|--------|---------|
| **Created** | The number of leads sellers created, and the number of sellers who created leads, during the specified time period |
| **Viewed** | The number of leads sellers viewed, and the number of sellers who viewed leads, during the specified time period |
| **Updated** | The number of leads sellers updated, and the number of sellers who updated leads, during the specified time period |
| **Deleted** | The number of leads sellers deleted, and the number of sellers who deleted leads, during the specified time period |
| **Leads qualified** | The number of leads sellers qualified into opportunities, and the number of sellers who qualified leads, during the specified time period |

The following table describes the summary charts that are displayed in the report.

| Chart name | Description |
|------------|-------------|
| **Actions performed on leads over time** | The trend of actions taken on leads in the specified time period: created, viewed, updated, and deleted |
| **Number of users contributing to actions performed on leads** | The number of users who performed various actions on leads during the specified time period |
| **Users with most leads created** | The top four contributors who created leads during the specified time period |
| **Users with most leads updated** | The top four contributors who updated leads during the specified time period |
| **Users with most leads qualified** | The top four contributors who successfully qualified leads into opportunities during the specified time period |
| **Status of leads over time** | A breakdown of leads by status during the specified time period |

## Account usage report

The following table describes the KPIs that are shown in the account usage report tab. For each KPI, an arrow indicates the trend. For example, a green upward arrow indicates an improvement in the trend when compared to the previous time period.

| KPI | Description |
|--------|---------|
| **Created** | The number of accounts sellers created, and the number of sellers who created accounts, during the specified time period |
| **Viewed** | The number of accounts sellers viewed, and the number of sellers who viewed accounts, during the specified time period |
| **Updated** | The number of accounts sellers updated, and the number of sellers who updated accounts, during the specified time period |
| **Deleted** | The number of accounts sellers deleted, and the number of sellers who deleted accounts, during the specified time period |

The following table shows the summary charts that are displayed in the report.

| Chart name | Description |
|------------|-------------|
| **Actions performed on accounts over time** | The trend of actions taken on accounts in the specified time period: created, viewed, updated, and deleted |
| **Number of users contributing to actions performed on accounts** | The number of users who performed various actions on accounts during the specified time period |
| **Users with most accounts created** | The top four contributors who created accounts during the specified time period |
| **Users with most accounts updated** | The top four contributors who updated accounts during the specified time period |

## Contact usage report

The following table describes the KPIs that are shown in the contact usage report tab. For each KPI, an arrow indicates the trend. For example, a green upward arrow indicates an improvement in the trend when compared to the previous time period.

| KPI | Description |
|--------|---------|
| **Created** | The number of contacts sellers created, and the number of sellers who created contacts, during the specified time period |
| **Viewed** | The number of contacts sellers viewed, and the number of sellers who viewed contacts, during the specified time period |
| **Updated** | The number of contacts sellers updated, and the number of sellers who updated contacts, during the specified time period |
| **Deleted** | The number of contacts sellers deleted, and the number of sellers who deleted contacts, during the specified time period |

The following table describes the summary charts that are displayed in the report.

| Chart name | Description |
|------------|-------------|
| **Actions performed on contacts over time** | The trend of actions taken on contacts in the specified time period: created, viewed, updated, and deleted |
| **Number of users contributing to actions performed on contacts** | The number of users who performed various actions on contacts during the specified time period |
| **Users with most contacts created** | The top four contributors who created contacts during the specified time period |
| **Users with most contacts updated** | The top four contributors who updated contacts during the specified time period |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable sales usage reports](enable-sales-usage-reports.md)
