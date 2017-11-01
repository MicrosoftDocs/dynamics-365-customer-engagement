---
title: "Page large result sets with LINQ (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can page the results of a large .NET Language-Integrated Query (LINQ) query by using the Take and Skip operators"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "paging the results of large LINQ queries, LINQ paging example"
  - "LINQ queries, paging the results of large LINQ queries"
  - "paging the results of large LINQ queries, by using the Take and Skip operators"
ms.assetid: f1c3d6f5-1dfa-4eb6-aaf8-9b58f9ba358d
caps.latest.revision: 18
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Page large result sets with LINQ

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement you can page the results of a large [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] query by using the `Take` and `Skip` operators. The `Take` operator retrieves a specified number of results and the `Skip` operator skips over a specified number of results.  
  
## LINQ paging example  
 The following example shows how to page the results of a LINQ query by using the `Take` and `Skip` operators:  
  
 [!code-csharp[Query#UseLinqQuery1](../../snippets/csharp/CRMV8/query/cs/uselinqquery1.cs#uselinqquery1)]  
  
### See also  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 [LINQ query examples](linq-query-examples.md)
