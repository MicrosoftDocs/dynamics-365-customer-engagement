---
title: "Use late-bound entity class with a LINQ query (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use late binding with .NET Language-Integrated Query (LINQ) queries"
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
  - "LINQ queries"
  - "LINQ queries, using late binding in join or left join clauses"
  - "LINQ queries, using late-bound entity classes with LINQ queries"
  - "LINQ queries"
  - "LINQ queries, using late binding with the not equals operator"
  - "using late-bound entity classes with LINQ queries"
  - "LINQ queries, using late binding with the Contains or GetAttributeValue method"
ms.assetid: 675f8ad0-e5f7-4fcb-a702-40962117f4cc
caps.latest.revision: 32
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use late-bound entity class with a LINQ query

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use late binding with [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] queries. Late binding uses the attribute logical name, and is resolved at runtime.  
  
<a name="usinglatebindingjoin"></a>   
## Using late binding in a join clause  
 The following examples show how to use late binding in the `join` clause of a LINQ query.  
  
 Retrieve the full name of the contact that represents the primary contact for an account and the account name.  
  
 [!code-csharp[Query#LINQExamples6](../../snippets/csharp/CRMV8/query/cs/linqexamples6.cs#linqexamples6)]  

 Retrieve Contact, Account and Lead data where the Lead was the originating Lead and the Contact’s last name is not “Parker”  
  
 [!code-csharp[Query#linqexamples40](../../snippets/csharp/CRMV8/query/cs/linqexamples40.cs#linqexamples40)]  

<a name="Usinglatebindingleft"></a>   
## Using late binding in a left join  
 The following example shows how to retrieve a list of Contact and Account information using a left join. A left join is designed to return parents with and without children from two sources. There is a correlation between parent and child, but no child may actually exist.  
  
 [!code-csharp[Query#linqexamples13](../../snippets/csharp/CRMV8/query/cs/linqexamples13.cs#linqexamples13)]  
  
<a name="contains"></a>   
## Using late binding and the Contains method  
 The following example shows how to use late binding with the `Contains` method in a LINQ query.  
  
 [!code-csharp[Query#linqexamples25](../../snippets/csharp/CRMV8/query/cs/linqexamples25.cs#linqexamples25)]  
  
<a name="notequals"></a>   
## Using late binding and not equals operator  
 The following example shows use of the not equals operator.  
  
 [!code-csharp[Query#linqexamples19](../../snippets/csharp/CRMV8/query/cs/linqexamples19.cs#linqexamples19)]  
  
<a name="getattribute"></a>   
## Using the GetAttributeValue method  
 The following example shows how to retrieve Contact information using the `GetAttributeValue` method.  
  
 [!code-csharp[Query#linqexamples34](../../snippets/csharp/CRMV8/query/cs/linqexamples34.cs#linqexamples34)]  
  
### See also  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 [Order Results Using Entity Attributes with LINQ](order-results-entity-attributes-linq.md)   
 [CreateQuery\`\`1](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.createquery``1)