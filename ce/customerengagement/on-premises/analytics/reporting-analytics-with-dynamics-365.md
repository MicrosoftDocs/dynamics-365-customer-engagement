---
title: "Reporting and Analytics Guide (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: This document set covers the reporting and analytics features with Dynamics 365 Customer Engagement (on-premises)
ms.custom: 
  - NaosGA
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: df6a8d7a-db0d-4860-8a65-039f2ddab50d
caps.latest.revision: 33
author: Mattp123
ms.author: matp
manager: kvivek
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Report writing guide for Dynamics 365 Customer Engagement (on-premises), version 9.x

Microsoft Dynamics 365 Customer Engagement (on-premises) includes reports, charts, and dashboards that provide useful business information and visualizations to the user.  

> [!NOTE]
> This guide is also applicable for Dataverse. You can follow the information in this guide to create and edit fetch-based reports that can run in Dataverse. The following reporting topics are available in the Dataverse documentation:
> - [Add reporting to your model-driven app](/powerapps/maker/model-driven-apps/add-reporting-to-app) 
> - [Create a report using the Report Wizard](/powerapps/user/create-report-with-wizard)
> - [Work with reports](/powerapps/user/work-with-reports)

  
 ## Paginated reports  
  
Customer Engagement (on-premises) includes a Report Wizard that can be used to easily create reports in just a few steps without using XML or [!INCLUDE[pn_SQL-based](../includes/pn-sql-based.md)] queries. For more information about the Report Wizard, see [Create, edit, or copy a report using the Report Wizard](../basics/create-edit-copy-report-wizard.md).  
  
 However, to create more complex reports, you can either create your own custom reports from scratch, or use an existing report as a template. The topics in this guide show you how to create new reports or change existing reports using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] as the report writing tool and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] as the report engine.  
  
 ## Dashboards  
  
 There are two types of dashboards in Customer Engagement (on-premises)—user dashboards and system dashboards. Any user can create a dashboard visible only to them in their work area, such as Sales, Service, or Marketing.  An administrator or customizer creates or customizes system dashboards that, when published, are visible to everyone in the organization. A user can choose to set their user dashboard as their default dashboard and override the system dashboard. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or customize dashboards](../customize/create-edit-dashboards.md)  
  
<!--  
 ## [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)]  
  
 [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] is a self-service business intelligence (BI) platform used to discover, analyze, visualize data, and share or collaborate these insights with colleagues. [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] provides information workers and everyday business users with excellent data analysis and visualization capabilities to get better business insights. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Power BI with Dynamics 365 Customer Engagement (on-premises)](../admin/use-power-bi.md)  
 

 There are several ways you can use [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps:  
  
- Load a content pack and start using the [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] service to display Dynamics 365 apps insights.  
  
- Use [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)] to modify and customize your reports and visualizations.  
  
- Embed a [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] tile in a personal dashboard.  
  
- Use [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] and [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] together.  
  
-->


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]