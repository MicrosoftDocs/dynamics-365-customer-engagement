---
title: "Report writing environment using SQL Server Data Tools (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: Learn about reporting writing in Dynamics 365
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 4c31abe1-7c07-4498-b69a-ddfed2686d08
caps.latest.revision: 23
author: Mattp123
ms.author: matp
manager: kvivek
tags: 
  - MigrationHO
search.audienceType: 
  - customizer
---
# Report writing environment using SQL Server Data Tools

This article describes what’s needed to author [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps reports.  
  
 You must have the required development tools and appropriate privileges in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps to write and publish a report. Also, you should be familiar with:  
  
- [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
- Creating [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports using [!INCLUDE[pn_sql_server_data_tools_SSDT](../includes/pn-sql-server-data-tools-ssdt.md)].  
  
- To write Fetch-based reports, the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps FetchXML language. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build queries with FetchXML](../developer/build-queries-fetchxml.md)  -->
  
## Required tools  
 The following are required to write a custom report for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps:  
  
- **[!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]**. For specific versions, see [Report Authoring Extension requirements](../deploy/microsoft-dynamics-365-reporting-requirements.md#report-authoring-extension-requirements).  
  
- **[!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)]**. This is a report authoring environment that is available as a plug-in with [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].
  
- **Dynamics 365 Report Authoring Extension**. This is required if you are writing custom Fetch-based reports. Notice that Dynamics 365 customer engagement apps, such as Dynamics 365 Sales and Dynamics 365 Customer Service, only support Fetch-based reports. Dynamics 365 Report Authoring Extension must be installed on the computer where [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] and [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] are installed. [Download: Dynamics 365 Report Authoring Extension](https://www.microsoft.com/download/details.aspx?id=56973). For installation instructions, see [Install Dynamics 365 Report Authoring Extension](install-dynamics-365-report-authoring-extension.md).  

- **Microsoft Reporting Services Projects extension**. Used to create report server projects. The extension is included with Visual Studio 2015. For later versions, see [Report Services Projects extension](https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftReportProjectsforVisualStudio).

> [!NOTE]
> - You can’t use SQL Server Reporting Services Report Builder to author FetchXML reports. The Dynamics 365 Report Authoring Extension for SQL Server Data Tools is used to author FetchXML reports.
> - Dynamics 365 Report Authoring Extension is available only in a 32-bit version.  
  
## Required privileges  
 To deploy custom reports to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, you must have a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps account and a security role assigned to you that includes the **PublishReport** privilege. By default, the System Customizer and System Administrator security roles include these privileges.  
  
## Report development process  
 The following lists the steps for developing custom [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps reports. You may have to repeat some steps while you develop a report:  
  
1. Develop a report concept or specification based on what business information is to be displayed.  
  
2. Create a custom report or use an existing report to modify using [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
   - Create a new (custom) report. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create custom reports using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)  
  
   - Download an existing [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps report definition language (.rdl) file. To do this, open a customer engagement app, select the **Reporting** tab, select the report you want, and then select **Edit** on the command bar. On the report properties page, select **Download Report** from the **Actions** toolbar.
  
3. Create basic report parameters. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Parameters in Reports](../analytics/use-parameters-in-reports.md)  
  
4. Specify datasets and filtering criteria for retrieving data:  
  
   - Enable pre-filtering on the primary entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Filters in Reports](../analytics/improve-report-performance-by-using-filters.md)  
  
5. Define the basic layout of the report, including headers and footers.  
  
6. Add report items as required based on the report specification. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add Report Navigation](../analytics/add-report-navigation.md)  
  
7. Preview the report in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)], and resolve any errors. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Test and Troubleshoot Reports](../analytics/test-and-troubleshoot-reports.md)  
  
8. Deploy the report to the reporting server by using [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish Reports](../analytics/publish-reports.md)  
  
9. Run the deployed report to verify.  
  
### See also

 [Build queries with FetchXML](../developer/org-service/build-queries-fetchxml.md) <br/>
 [Create Custom Reports Using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)   
 

 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]