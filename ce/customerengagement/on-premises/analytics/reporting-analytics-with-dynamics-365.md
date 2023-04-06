---
title: "Reporting and analytics guide for Dynamics 365 Customer Engagement (on-premises)"
description: "Get familiar with the data and visualization features in Dynamics 365 Customer Engagement (on-premises), including reports, charts, and dashboards."
ms.custom: 
  - NaosGA
ms.date: 09/30/2017
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: df6a8d7a-db0d-4860-8a65-039f2ddab50d
caps.latest.revision: 33
author: Mattp123
ms.author: matp
tags: 
  - MigrationHO
search.audienceType: 
  - customizer
---
# Report writing guide for Dynamics 365 Customer Engagement (on-premises), version 9.x

Microsoft Dynamics 365 Customer Engagement (on-premises) includes reports, charts, and dashboards that provide useful business information and visualizations to the user.  

> [!NOTE]
> This guide is also applicable for Microsoft Dataverse. You can follow the information in this guide to create and edit fetch-based reports that can run in Dataverse. The following reporting topics are available in the Dataverse documentation:
> - [Add reporting to your model-driven app](/powerapps/maker/model-driven-apps/add-reporting-to-app) 
> - [Create a report using the Report Wizard](/powerapps/user/create-report-with-wizard)
> - [Work with reports](/powerapps/user/work-with-reports)

## Paginated reports  
  
Customer Engagement (on-premises) includes a Report Wizard that can be used to easily create SQL Server Reporting Services reports in just a few steps without using XML or [!INCLUDE[pn_SQL-based](../includes/pn-sql-based.md)] queries. For more information about the Report Wizard, see [Create, edit, or copy a report using the Report Wizard](../basics/create-edit-copy-report-wizard.md).  
  
However, to create more complex reports, you can either create your own custom SQL Server Reporting Services reports from scratch, or use an existing report as a template. The topics in this guide show you how to create new reports or change existing reports using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] as the report writing tool and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] as the report engine.  
  
## Charts and dashboards  

Charts allow app users to view the data presented in a view in a range of ways, which include bar, pie, and line charts. An entity can have multiple charts associated with it, and the charts themselves provide interactivity that enables a user to select a bar and the view will filter accordingly. Add multiple charts to create an effective dashboard.

There are two types of dashboards in Customer Engagement (on-premises)—user dashboards and system dashboards. Any user can create a dashboard visible only to them in their work area, such as Sales, Service, or Marketing.  An administrator or customizer creates or customizes system dashboards that, when published, are visible to everyone in the organization. A user can choose to set their user dashboard as their default dashboard and override the system dashboard. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or customize dashboards](../customize/create-edit-dashboards.md)  

> [!NOTE]
> Embedded Power BI tiles and dashboards are not supported with Microsoft Dynamics 365 Customer Engagement (on-premises).

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
