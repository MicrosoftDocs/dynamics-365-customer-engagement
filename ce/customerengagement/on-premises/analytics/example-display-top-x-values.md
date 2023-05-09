---
title: "Display top X values in Dynamics 365 Customer Engagement (on-premises)"
description: "The following example describes how to author a report that displays the top X items of an entity in Dynamics 365 Customer Engagement (on-premises)."
ms.custom: 
ms.date: 06/28/2021
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 7e5c6a40-3e50-48ce-8970-ce5435b4fd0a
caps.latest.revision: 9
author: Mattp123
ms.author: matp
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Example: Display the top X values

Microsoft Dynamics 365 Customer Engagement (on-premises) includes reports that display the top `X` items of an entity, where the user can specify the value of `X`.  
  
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


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
