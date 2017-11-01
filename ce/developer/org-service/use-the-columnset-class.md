---
title: "Use the ColumnSet class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use the ColumnSet class to specify what attributes to return from a query expression"
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
  - "reducing query results by defining the attributes to return, ColumnSet class"
  - "ColumnSet class, about and code example"
  - "ColumnSet class, specifying what attributes to return from a query expression"
  - "ColumnSet class, reducing query results by defining the attributes to return"
  - "using the ColumnSet class"
  - "specifying what attributes to return from a query expression, ColumnSet class"
ms.assetid: b74367ff-cd14-4305-9601-7c00acb80a0d
caps.latest.revision: 21
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use the ColumnSet class

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> class to specify what attributes to return from a query expression. The query returns only non-null values.  
  
 You can also use the <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> class to reduce the size of a query result by defining only those attributes to be returned.  To improve server performance, it is recommended that you don’t execute a query that returns all columns.  
  
 The following code example shows how to use the `ColumnSet` class to specify what attributes to return from a query expression.  
  
```csharp  
QueryExpression contactquery = new QueryExpression   
{  
   EntityName="contact",  
   ColumnSet = new ColumnSet("firstname", "lastname", "contactid")   
};  
```  
  
### See also  
 [Using the QueryExpression Class](use-queryexpression-class.md)   
 [Building Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Use the ConditionExpression Class](use-conditionexpression-class.md)   
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>   
 <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>