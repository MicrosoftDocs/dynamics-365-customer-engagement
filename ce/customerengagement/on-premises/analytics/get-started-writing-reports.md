---
title: "Get started writing reports with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: Start here to learn about report writing
ms.custom: 
ms.date: 07/12/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 7e593f9d-5003-4115-ab6f-a1f4ce188fab
caps.latest.revision: 14
author: Mattp123
ms.author: matp
manager: kvivek
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Overview of reports

Microsoft Dynamics 365 Customer Engagement (on-premises) include reports that provide useful business information to the user. These reports are based on [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], and provide the same set of features that are available for the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports. 

<a name="ownership"></a>   
## Report ownership  
 System reports are available to all users. Individuals who own reports can share them with specific colleagues or teams, or can make the reports available to the organization, so that all users can use them.  
  
<a name="types"></a>   
## Report types  
Customer Engagement (on-premises) support two types of reports:  
  
- **[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports.** These reports use SQL queries and filtered views to retrieve report data. Filtered views restrict the data to what is available to the security role of the person running the report. All the default reports included with Customer Engagement (on-premises) are SQL-based reports.  
  
     You cannot access filtered views in Dynamics 365 Customer Engagement because access to the SQL database is not supported. If you have a Dynamics 365 (online) or Power Apps subscription, use Fetch-based reports for custom reporting.  
  
- **Fetch-based Reporting Services reports.** These reports use FetchXML queries that are proprietary to Customer Engagement (on-premises) instead of filtered views to retrieve data for reports. Reports that you create by using the Report Wizard in are Fetch-based reports.  
  
The other reports can be:  
  
- Links to webpages  
  
- Static files  
  
- Dynamic [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] files that read data from the Customer Engagement (on-premises) database  
 
 
 For each report, you can edit the following properties:  
  
-   File name or URL  
  
-   Display name  
  
-   Description  
  
-   Information about where the report displays in the user interface  
  
<a name="security"></a>   
## Security of data in reports  
 All reports read data from filtered views that filter the data based on the user's security role. Reports only display data that the person running the report has permission to view.  
  
<a name="solutions"></a>   
## Reports in solutions  
 Reports are solution aware. Adding a report as a component to a solution makes it become a single unit of software that extends your apps functionality and the user interface. Only reports that are organization owned or visible to the organization can be added to solutions.  
  
> [!NOTE]
>  To find if a report is viewable to the organization: In the list of reports, select a report, and then click or tap **Edit**. On the **Administration** tab, see if **Viewable By** is set to **Organization**.  
  
 You can add, import, or export snapshots of reports as part of a solution. Reports, sub reports, report category, report display area, and report-related record type are considered as components of a report set. When you import a solution update in non-overwrite mode, any updates by the solution to a report will be ignored if any component of the report set has been customized.  

## Get started writing reports

Customer Engagement (on-premises) uses [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report definition language (RDL) reports to query data and return refined results back to the report user. For more information about RDL, see [Report Definition Language (SSRS)](/sql/reporting-services/reports/report-definition-language-ssrs).  
  
 To create or modify existing RDL reports that can be used with your apps, use FetchXML, which is then converted to RDL by using report authoring tools. 
  
 If you want, you can use a third-party tool, SQL2FetchXML, to convert your SQL scripts to FetchXML, and then use the FetchXML query in your Fetch-based reports. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SQL2FetchXML Help](https://www.sql2fetchxml.com/help.aspx)  

<a name="creating"></a>   
### Options for creating new reports  
 To create a new report, users with appropriate permissions can:  
  
- Add a file or a link to a webpage as a report.  
  
- Run the Report Wizard to create a new Reporting Services report. The Report Wizard can create table and chart reports, including drill-through reports and top N reports.  
  
- Write a new Fetch-based Reporting Services report. To write custom fetch-based reports, you must install the Report Authoring Extension. More information: [Create a new report using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)  
  
<a name="modifying"></a>   
### Options for modifying existing reports  
 For existing reports, users with appropriate permissions can:  
  
- Organize reports into categories to control which views in the reports area display for each report.  
  
- Determine where a report is visible in the user interface, and edit other report properties.  
  
- Edit a report created with the Report Wizard.  
  
- Edit a default report. For example, if you customize an app you might need to modify labels or add or remove fields in default reports. More information: [Report writing environment using SQL Server Data Tools](../analytics/report-writing-environment-using-sql-server-data-tools.md)  
  
- Edit the default filter for a default report, a report created with the Report Wizard, or other Reporting Services reports.  
  
- Create a one-time snapshot for a Reporting Services report or schedule a Reporting Services report to run at set intervals. Note that the Report Scheduling feature is currently only available with Dynamics 365 Customer Engagement on-premises versions.  
  
- Share a personal report with other users, or make it available to everyone in your organization.  
  
- Publish a report so that it is available for use with external applications, such as [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] or custom programs.  

> [!NOTE]
> You can’t use SQL Server Reporting Services Report Builder to author FetchXML reports. The Dynamics 365 Report Authoring Extension for SQL Server Data Tools is used to author FetchXML reports.
 
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md) 
  
 [Publish reports](../analytics/publish-reports.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]