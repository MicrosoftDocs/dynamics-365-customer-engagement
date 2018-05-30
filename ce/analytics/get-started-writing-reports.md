---
title: "Get started writing reports with Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 7e593f9d-5003-4115-ab6f-a1f4ce188fab
caps.latest.revision: 14
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
tags: 
 - "MigrationHO"
---
# Get started writing reports

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] uses [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report definition language (RDL) reports to query Dynamics 365 data and return refined results back to the report user. For more information about RDL, see [Report Definition Language (SSRS)](https://technet.microsoft.com/library/ms155062.aspx).  
  
 To create or modify existing RDL reports that can be used with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], use FetchXML, which is then converted to RDL by using report authoring tools. 
  
 If you want, you can use a third-party tool, SQL2FetchXML, to convert your SQL scripts to FetchXML, and then use the FetchXML query in your Fetch-based reports. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SQL2FetchXML Help](http://www.sql2fetchxml.com/help.aspx)  

> [!NOTE]
> You can’t use SQL Server Reporting Services Report Builder to author FetchXML reports. The Dynamics 365 Report Authoring Extension for SQL Server Data Tools is used to author FetchXML reports.
 
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md) 
  
 [Publish reports](../analytics/publish-reports.md)
