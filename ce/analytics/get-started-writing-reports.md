---
title: "Get started writing reports with Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 07/12/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 7e593f9d-5003-4115-ab6f-a1f4ce188fab
caps.latest.revision: 14
author: Mattp123
ms.author: matp
manager: kvivek
tags: 
  - MigrationHO
search.audienceType: 
  - customizer
search.app: 
  - D365CE
---
# Overview of reports
[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps includes reports that provide useful business information to the user. These reports are based on [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], and provide the same set of features that are available for the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports. 

<a name="ownership"></a>   
## Report ownership  
 System reports are available to all users. Individuals who own reports can share them with specific colleagues or teams, or can make the reports available to the organization, so that all users can use them.  
  
<a name="types"></a>   
## Report types  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps supports two types of reports:  
  
- **[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports.** These reports use SQL queries and filtered views to retrieve report data. Filtered views restrict the data to what is available to the security role of the person running the report. All the default reports included with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps are SQL-based reports.  
  
     You cannot access filtered views in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps because access to the SQL database is not supported. If you have a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps subscription, use Fetch-based reports for custom reporting.  
  
- **Fetch-based Reporting Services reports.** These reports use FetchXML queries that are proprietary to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps instead of filtered views to retrieve data for reports. Reports that you create by using the Report Wizard in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps are Fetch-based reports.  
  
The other reports can be:  
  
- Links to webpages  
  
- Static files  
  
- Dynamic [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] files that read data from the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps database  
 
 
 For each report, you can edit the following properties:  
  
-   File name or URL  
  
-   Display name  
  
-   Description  
  
-   Information about where the report displays in the user interface  
  
<a name="security"></a>   
## Security of data in reports  
 All reports read [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps data from filtered views that filter the data based on the user's security role. Reports only display data that the person running the report has permission to view.  
  
<a name="solutions"></a>   
## Reports in solutions  
 In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, reports are solution aware. Adding a report as a component to a solution makes it become a single unit of software that extends [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps functionality and the user interface. Only reports that are organization owned or visible to the organization can be added to solutions.  
  
> [!NOTE]
>  To find if a report is viewable to the organization: In the list of reports, select a report, and then click or tap **Edit**. On the **Administration** tab, see if **Viewable By** is set to **Organization**.  
  
 You can add, import, or export snapshots of reports as part of a solution. In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, reports, sub reports, report category, report display area, and report-related record type are considered as components of a report set. When you import a solution update in non-overwrite mode, any updates by the solution to a report will be ignored if any component of the report set has been customized.  

## Get started writing reports

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps uses [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report definition language (RDL) reports to query Dynamics 365 for Customer Engagement apps data and return refined results back to the report user. For more information about RDL, see [Report Definition Language (SSRS)](https://technet.microsoft.com/library/ms155062.aspx).  
  
 To create or modify existing RDL reports that can be used with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, use FetchXML, which is then converted to RDL by using report authoring tools. 
  
 If you want, you can use a third-party tool, SQL2FetchXML, to convert your SQL scripts to FetchXML, and then use the FetchXML query in your Fetch-based reports. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SQL2FetchXML Help](http://www.sql2fetchxml.com/help.aspx)  

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
  
- Edit a default report. For example, if you customize [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, you might need to modify labels or add or remove fields in default reports. More information: [Report writing environment using SQL Server Data Tools](../analytics/report-writing-environment-using-sql-server-data-tools.md)  
  
- Edit the default filter for a default report, a report created with the Report Wizard, or other Reporting Services reports.  
  
- Create a one-time snapshot for a Reporting Services report or schedule a Reporting Services report to run at set intervals. Note that the Report Scheduling feature is currently only available with on-premises versions of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
- Share a personal report with other users, or make it available to everyone in your organization.  
  
- Publish a report so that it is available for use with external applications, such as [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] or custom programs.  

> [!NOTE]
> You can’t use SQL Server Reporting Services Report Builder to author FetchXML reports. The Dynamics 365 Report Authoring Extension for SQL Server Data Tools is used to author FetchXML reports.
 
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md) 
  
 [Publish reports](../analytics/publish-reports.md)
