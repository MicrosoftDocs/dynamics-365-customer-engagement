---
title: "Example: Display the top X values (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
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
ms.assetid: 7e5c6a40-3e50-48ce-8970-ce5435b4fd0a
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
# Example: Display the top X values

[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps includes several reports that display the top `X` items of an entity, where the user can specify the value of `X`.  
  
 To query for the top items, use dynamic SQL. Assign the SQL query string that includes the user-specified parameter to a variable. This resolves the user-specified parameter. The query string is then passed to the `SQL EXEC` function together with the user-specified parameter.  
  
## Example  
 If you’re authoring a FetchXML-based report, this is the corresponding FetchXML query.  
  
```  
<fetch count="@TopCount">   
<entity name="kbarticle" enableprefiltering="true" prefilterparametername="CRM_FilteredKbArticle" >   
<attribute name="kbarticleid"/>   
</entity>   
</fetch>  
```  
  
### See also  
 [Create Custom Reports Using SQL Server Data Tools](../analytics/create-a-new-report-using-sql-server-data-tools.md)   
 [Sample Reports](../analytics/example-reports.md)   
 [Sample: Make a Report Context-Sensitive](../analytics/example-make-report-context-sensitive.md)
