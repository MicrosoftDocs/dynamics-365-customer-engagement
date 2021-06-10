---
title: "Customize and organize reports Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: Learn how to create, edit, and manage reports
ms.custom: 
ms.date: 04/30/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: ea98ae5e-5dbc-4c23-b4c6-513774997226
caps.latest.revision: 47
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Customize and organize reports

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Add reporting features to your model-driven app](/powerapps/maker/model-driven-apps/add-reporting-to-app)

Analyze data in Dynamics 365 Customer Engagement (on-premises) by using reports. Dynamics 365 Customer Engagement (on-premises) includes default reports for many common business needs. However, most organizations customize the default reports and add custom reports for specific needs.  
  
<a name="ownership"></a>   
## Report ownership  
 System reports are available to all users. Individuals who own reports can share them with specific colleagues or teams, or can make the reports available to the organization, so that all users can use them.  
  
<a name="types"></a>   
## Report types  
 Dynamics 365 Customer Engagement (on-premises) supports two types of reports:  
  
- **[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports.** These reports use SQL queries and filtered views to retrieve report data. Filtered views restrict the data to what is available to the security role of the person running the report. All the default reports included with Dynamics 365 Customer Engagement (on-premises) are SQL-based reports.  
  
     You cannot access filtered views in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps because access to the SQL database is not supported. If you have a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps subscription, use Fetch-based reports for custom reporting.  
  
- **Fetch-based Reporting Services reports.** These reports use FetchXML queries that are proprietary to Dynamics 365 Customer Engagement (on-premises) instead of filtered views to retrieve data for reports. Reports that you create by using the Report Wizard in Dynamics 365 Customer Engagement (on-premises) are Fetch-based reports.  
  
The other reports can be:  
  
- Links to webpages  
  
- Static files  
  
- Dynamic [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] files that read data from the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] database  
 
 
 For each report, you can edit the following properties:  
  
-   File name or URL  
  
-   Display name  
  
-   Description  
  
-   Information about where the report displays in the user interface  
  
<a name="security"></a>   
## Security of data in reports  
 All reports read Dynamics 365 Customer Engagement (on-premises) data from filtered views that filter the data based on the user's security role. Reports only display data that the person running the report has permission to view.  
  
<a name="creating"></a>   
## Options for creating new reports  
 To create a new report, users with appropriate permissions can:  
  
- Add a file or a link to a webpage as a report.  
  
- Run the Report Wizard to create a new Reporting Services report. The Report Wizard can create table and chart reports, including drill-through reports and top N reports.  
  
- Write a new Fetch-based Reporting Services report. To write custom fetch-based reports, you must install the Report Authoring Extension. More information: [Create a new report using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)  
  
<a name="modifying"></a>   
## Options for modifying existing reports  
 For existing reports, users with appropriate permissions can:  
  
- Organize reports into categories to control which views in the reports area display for each report.  
  
- Determine where a report is visible in the user interface, and edit other report properties.  
  
- Edit a report created with the Report Wizard.  
  
- Edit a default report. For example, if you customize Dynamics 365 Customer Engagement (on-premises), you might need to modify labels or add or remove fields in default reports. More information: [Report writing environment using SQL Server Data Tools](../analytics/report-writing-environment-using-sql-server-data-tools.md)  
  
- Edit the default filter for a default report, a report created with the Report Wizard, or other Reporting Services reports.  
  
- Create a one-time snapshot for a Reporting Services report or schedule a Reporting Services report to run at set intervals. Note that the Report Scheduling feature is currently only available with on-premises versions of Dynamics 365 Customer Engagement (on-premises).  
  
- Share a personal report with other users, or make it available to everyone in your organization.  
  
- Publish a report so that it is available for use with external applications, such as [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] or custom programs.  
  
<a name="solutions"></a>   
## Reports in solutions  
 In Dynamics 365 Customer Engagement (on-premises), reports are solution aware. Adding a report as a component to a solution makes it become a single unit of software that extends Dynamics 365 Customer Engagement (on-premises) functionality and the user interface. Only reports that are organization owned or visible to the organization can be added to solutions.  
  
> [!NOTE]
>  To find if a report is viewable to the organization: In the list of reports, select a report, and then click or tap **Edit**. On the **Administration** tab, see if **Viewable By** is set to **Organization**.  
  
 You can add, import, or export snapshots of reports as part of a solution. In Dynamics 365 Customer Engagement (on-premises), reports, sub reports, report category, report display area, and report-related record type are considered as components of a report set. When you import a solution update in non-overwrite mode, any updates by the solution to a report will be ignored if any component of the report set has been customized.  
  
### See also  
 [Create or edit a report using the Report Wizard](../basics/create-edit-copy-report-wizard.md)   
 [Introduction to reporting and analytics with Dynamics 365 Customer Engagement (on-premises)](../analytics/reporting-analytics-with-dynamics-365.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]