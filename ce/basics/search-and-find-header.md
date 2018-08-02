---
title: "Search and Find in Dynamics 365 | MicrosoftDocs"
ms.custom: ""
ms.date: 07/11/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d0634607-b17f-4f33-aa15-e26ebed441f7
caps.latest.revision: 1
ms.author: "t-mijosh"
manager: "ryjones"
---
# Search and Find in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

## Compare [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] searches  

There are four ways to find data in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]:

-   Relevance Search  
  
-   Full-text Quick Find (single-entity or multi-entity)  
  
-   Quick Find (single-entity or multi-entity)  

-   Advanced Find
  
The following table provides a brief comparison of the four available options.

|Functionality|[Relevance Search](../basics/relevance-search-results.md)|[Full-text Quick Find](../basics/search-records.md)|[Quick Find](../basics/search-records.md)|[Advanced Find](../basics/save-advanced-find-search.md)|  
|-------------------|----------------------|---------------------------|----------------|-------------------|  
|Enabled by default?|No. An administrator must manually enable it.|No. An administrator must manually enable it.|Yes|Yes|  
|Single-entity search scope|Not available in an entity grid. You can filter the search results by an entity on the results page.|Available in an entity grid.|Available in an entity grid.|Available in an entity grid.|  
|Multi-entity search scope|There is no maximum limit on the number of entities you can search. **Note:**  While there is no maximum limit on the number of entities you can search, the Record Type filter shows data for only 10 entities.|Searches up to 10 entities, grouped by an entity.|Searches up to 10 entities, grouped by an entity.|Multi-entity search not available.|  
|Search behavior|Finds matches to any word in the search term in any field in the entity.|Finds matches to all words in the search term in one field in an entity; however, the words can be matched in any order in the field.|Finds matches as in a SQL query with “Like” clauses. You have to use the wildcard characters in the search term to search within a string. All matches must be an exact match to the search term.|Query builder where you can define search criteria for the selected record type. Can also be used to prepare data for export to Office Excel so that you analyze, summarize,or aggregate data, or create PivotTables to view your data from different perspectives.|  
|Search results|Returns the search results in order of their relevance, in a single list.|For single-entity, returns the search results in an entity grid. For multi-entity, returns the search results grouped by categories, such as accounts, contacts, or leads.|For single-entity, returns the search results in an entity grid. For multi-entity, returns the search results grouped by categories, such as accounts, contacts, or leads.|Returns search results of the selected record type with the columns you have specified, in the sort order you have configured.|  
  
### See also  

[Search for records ([!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for phones and tablets)](../mobile-app/dynamics-365-phones-tablets-users-guide.md)   
[Configure Relevance Search to improve search results and performance (Administrator Guide)](../admin/configure-relevance-search-organization.md)