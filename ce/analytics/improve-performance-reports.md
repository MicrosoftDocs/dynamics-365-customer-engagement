---
title: "Improve performance of reports (Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: dece910e-0712-4801-824f-d2aa1bed88d2
caps.latest.revision: 9
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer
search.app: 
  - D365CE
---
# Improve performance of reports

[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

Here are some guidelines that can help you improve the performance of the report.  
  
## General  
 These guidelines are applicable for both Fetch-based reports.  
  
- Limit a report to display information from a specified time period, instead of displaying all records in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps database.  
  
- Pre-filter a report so that the dataset is limited.  
  
- Calculate aggregate totals by using aggregations in a FetchXML query, instead of passing raw data to Reporting Services and grouping.  
  
- Limit the number of datasets used, if possible.  
  
- When you compare dates, use the UTC date fields for comparisons. For example, compare the `createdonutc` fields and not the `createdon` fields in the FetchXML query or a filtered view.  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Improve report performance by using filters](../analytics/improve-report-performance-by-using-filters.md)
