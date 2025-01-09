---
title: "Reporting capabilities in Dynamics 365 Customer Engagement (on-premises)"
description: "Reporting capabilities are designed to let users run reports on datasets that span shorter periods of time. Learn about fixed settings and best practices."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: cb1bb002-8300-43bb-ab75-99e7a9c9c35d
caps.latest.revision: 11
author: Mattp123
ms.author: matp
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Dynamics 365 Customer Engagement (on-premises) reporting considerations

Microsoft Dynamics 365 Customer Engagement (on-premises) has a number of capabilities that allow customers to surface business data that helps them drive decisions and interact with their customers more effectively. Capabilities that are available include views, charts, dashboards, and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports. Also included is [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] integration that allows users to easily build self-service reports using the Power BI features [PowerView](https://www.microsoft.com/powerBI/home/visualize.aspx), PowerPivot, and [PowerQuery](https://blogs.msdn.com/b/powerbi/archive/2013/12/19/dynamics-crm-online-in-power-query.aspx). As the volume of data held in the database continues to grow it becomes more important than ever to think about your BI strategy and determine the most effective mechanisms for reporting and visualizing large datasets.  
  
 In a Dynamics 365 Customer Engagement environment, the reporting infrastructure is shared and separate from the database. In this architecture, although customers share the resources required to run the report, each report runs against the customers’ individual database instances. Additionally, users can run as many reports as they need whenever they want to run them to meet business goals. We don't place time restrictions on reports.  
  
 The reporting capabilities built in to Customer Engagement (on-premises) are designed to let users run reports on datasets that span shorter periods of time. Considering this, we have the following fixed settings:  
  
- Reports and queries can execute for up to five minutes. When the maximum period is reached, the report times out and a message is returned to the user. Within the five-minute duration, reports and queries are allowed to span large datasets that are beyond 50,000 records, which provides significant flexibility to satisfy most operational reporting needs.  
  
- To improve query response, we recommend that detailed reports minimize the display of large numbers of records. To do this, apply suitable filtering to reduce the number of records that are returned. When you create aggregated or summarized reports, queries should push the aggregation to the query rather than fetch detailed records to perform aggregation in the report. This can be done by using Fetch XML aggregation. 
  
- For charts and grids displayed in dashboards, Power Apps environments allow users to run queries that have a dataset that has fewer than 50,000 rows. Should a user run a dashboard query that spans a dataset of 50,000 or more rows, a message is returned stating “The maximum record limit is exceeded." Reduce the number of records.”  The dataset practical setting helps to ensure optimal performance of the app.  
 
  
<a name="BKMK_ReportTips"></a>   
## Tips and solutions for reporting  
 Typically, for most organizations' reporting needs, these settings are adequate. To make sure that your users don't exceed these settings and to improve report querying performance in general, consider the following best practices.  
  
- When you create custom reports or dashboards, design them to query smaller datasets over shorter periods of time by adding a time-based filter in the report, such as the current month or quarter, to limit the results.  
  
- We recommend that you limit the number of entities that are needed to return the result. This helps reduce the time required to run the query and return the result set.  
  
- We recommend that you reduce the number of records shown in detailed reports. Suitable filtering can be used to reduce the number of records returned by the query to reduce timeouts.  
  
- For aggregated or summarized reports, queries must be used to push the aggregation to the database and not fetch detailed records and perform aggregation in the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report.  
  
- When appropriate for your business, users should run the default (out-of-the-box) reports and dashboards. These reports and dashboards are typically designed to query per user datasets, so in most cases won't exceed the dataset limit.  
  
  If app users must run reports that exceed these settings, we recommend that you review the following options for assistance with complex reporting needs. Both options effectively offload reporting workloads from Dynamics 365 Customer Engagement to another [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] datastore by using a data integration solution.  
  
- [Adapters](../analytics/reporting-considerations.md#non-microsoft-adapters-for-ssis) are used in conjunction with [!INCLUDE[pn_ms_SQL_Server_Integration_Services_short](../includes/pn-ms-sql-server-integration-services-short.md)] (SSIS) to extend the capabilities for integration with Dynamics 365 Customer Engagement data.  
  
- Extract transform load [(ETL) tools](../analytics/reporting-considerations.md#etl-tools) provide a new tool set for creating analysis of Dynamics 365 Customer Engagement data by combining multiple data sources or extracting data to the data warehouse solution if SSIS isn't in use. ETL tools provide comprehensive solutions for connecting Dynamics 365 Customer Engagement systems to move data.  
  
> [!IMPORTANT]
>  When you use these tools, we recommend you move or synchronize data during nonbusiness hours.
  
If needed, there are many Microsoft partners who can help provide a solution for your specific reporting needs, such as creating an offline copy of the data specifically used for running large reports. These partners are knowledgeable with the data integration tools available. More information: [Find the right partner](https://dynamics.microsoft.com/partners/find-a-partner/)  
  
## Non-Microsoft adapters for SSIS  
  
-   [CozyRoc SSIS+ component for Microsoft Dynamics CRM](https://www.cozyroc.com/ssis/dynamics-crm-destination)  
  
-   [KingswaySoft SSIS Integration Toolkit for Microsoft Dynamics CRM](https://www.kingswaysoft.com/products/ssis-integration-toolkit-for-microsoft-dynamics-crm/)  
  
-   [RSSBus SSIS task for Microsoft Dynamics CRM](https://www.arcesb.com/)  
  
-   [PragmaticWorks TaskFactory SSIS Source/Destination for Dynamics CRM](https://pragmaticworks.com/Products/Task-Factory/Features/DynamicsCRMSource.aspx)  
  
## ETL tools  
  
[Scribe Insight and Scribe Online with adapter for Microsoft Dynamics CRM](https://www.scribesoft.com/microsoft-dynamics-crm.asp)  
  
### See also

[Report Authoring Extension (with SQL Server Data Tools support)](https://www.microsoft.com/download/details.aspx?id=45013) <br />

[Dynamics 365 for Customer Engagement OData Feeds and Power Query: What’s the &#91;Record&#93;?](https://community.dynamics.com/crm/b/survivingcrm/archive/2014/02/16/dynamics-crm-odata-feeds-and-power-query-what-s-the-record.aspx)   <br />
[Using Power View in Excel 2013 to Analyze CRM Data](https://blogs.msdn.com/b/crm/archive/2013/04/17/using-power-view-in-excel-2013-to-analyze-crm-data.aspx)   <br />
[Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
