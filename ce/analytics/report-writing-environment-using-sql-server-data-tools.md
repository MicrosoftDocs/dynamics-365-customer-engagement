---
title: "Report writing environment using SQL Server Data Tools (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4c31abe1-7c07-4498-b69a-ddfed2686d08
caps.latest.revision: 23
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
tags: 
 - "MigrationHO"
---
# Report writing environment using SQL Server Data Tools

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This topic describes what’s needed to author [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] reports.  
  
 You must have the required development tools and appropriate privileges in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to write and publish a report. Also, you should be familiar with:  
  
- [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
- Creating [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports using [!INCLUDE[pn_sql_server_data_tools_SSDT](../includes/pn-sql-server-data-tools-ssdt.md)].  
  
- To write Fetch-based reports, the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]FetchXML language. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build queries with FetchXML](../developer/build-queries-fetchxml.md)  -->
  
## Required tools  
 The following are required to write a custom report for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]:  
  
- **[!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]** . For specific versions, see [Microsoft Dynamics CRM Reporting Authoring Extension requirements](https://technet.microsoft.com/library/hh699754.aspx#report_auth_gen_req).  
  
- **[!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)]** . This is a report authoring environment that is used as a plug-in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
  - For and [!INCLUDE[pn_microsoft_visual_studio_2013](../includes/pn-microsoft-visual-studio-2013.md)]: You must download and install [Download: Microsoft SQL Server Data Tools - Business Intelligence for Visual Studio 2013](https://www.microsoft.com/en-us/download/details.aspx?id=42313)  
  
  - For [!INCLUDE[pn_microsoft_visual_studio_2012](../includes/pn-microsoft-visual-studio-2012.md)]: You must download and install [Download: Microsoft SQL Server Data Tools - Business Intelligence for Visual Studio 2012](http://www.microsoft.com/download/details.aspx?id=36843).  
  
  - For [!INCLUDE[pn_MS_Visual_Studio_2010](../includes/pn-ms-visual-studio-2010.md)]: You must select and install the [!INCLUDE[pn_sql_server_data_tools_SSDT](../includes/pn-sql-server-data-tools-ssdt.md)] feature that is included with [!INCLUDE[pn_MS_SQL_Server_2012](../includes/pn-ms-sql-server-2012.md)] or [!INCLUDE[pn_ms_sql_2012_express](../includes/pn-ms-sql-2012-express.md)] on the computer that is running [!INCLUDE[pn_MS_Visual_Studio_2010](../includes/pn-ms-visual-studio-2010.md)]. [Download: Microsoft SQL Server 2012 Express](http://www.microsoft.com/download/details.aspx?id=29062)  
  
- **[!INCLUDE[pn_crm_fetch_extension](../includes/pn-crm-fetch-extension.md)]** . This is required if you are writing custom Fetch-based reports. Notice that [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] only supports Fetch-based reports. [!INCLUDE[pn_crm_fetch_extension](../includes/pn-crm-fetch-extension.md)] must be installed on the computer where [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] and [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] are installed. [Download: CRM 2016 Report Authoring Extension](http://go.microsoft.com/fwlink/?LinkID=624672). For installation instructions, see [Install Microsoft Dynamics CRM Report Authoring Extension](https://technet.microsoft.com/library/hh699675.aspx).  
  

> [!NOTE]
> - You can’t use SQL Server Reporting Services Report Builder to author FetchXML reports. The Dynamics 365 Report Authoring Extension for SQL Server Data Tools is used to author FetchXML reports.
> - [!INCLUDE[pn_crm_fetch_extension](../includes/pn-crm-fetch-extension.md)] is available only in a 32-bit version.  
  
## Required privileges  
 To deploy custom reports to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you must have a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] account and a security role assigned to you that includes the **PublishReport** privilege. By default, the System Customizer and System Administrator security roles include these privileges.  
  
## Report development process  
 The following lists the steps for developing custom [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] reports. You may have to repeat some steps while you develop a report:  
  
1. Develop a report concept or specification based on what business information is to be displayed.  
  
2. Create a custom report or use an existing report to modify using [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
   - Create a new (custom) report. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create Custom Reports Using Business Intelligence Development Studio](../analytics/create-a-new-report-using-sql-server-data-tools.md)  
  
   - Download an existing [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] report definition language (.rdl) file. You can do this in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application. More information: [Modify a report (RDL) file](https://technet.microsoft.com/library/dn531075.aspx#bkmk_ModifyRDL)  
  
3. Create basic report parameters. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Parameters in Reports](../analytics/use-parameters-in-reports.md)  
  
4. Specify datasets and filtering criteria for retrieving data:  
  
   - Enable pre-filtering on the primary entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Filters in Reports](../analytics/improve-report-performance-by-using-filters.md)  
  
5. Define the basic layout of the report, including headers and footers.  
  
6. Add report items as required based on the report specification. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add Report Navigation](../analytics/add-report-navigation.md)  
  
7. Preview the report in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)], and resolve any errors. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Test and Troubleshoot Reports](../analytics/test-and-troubleshoot-reports.md)  
  
8. Deploy the report to the reporting server by using [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish Reports](../analytics/publish-reports.md)  
  
9. Run the deployed report to verify.  
  
### See also  
<!-- TODO: Fix reference to TechNet. Where is this topic now?-->
 [TechNet: Use SQL and Filtered Views to Retrieve Data for Reports](https://technet.microsoft.com/library/dn531161.aspx)  
 [Create Custom Reports Using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)   
 

 
