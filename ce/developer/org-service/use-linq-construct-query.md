---
title: "Use LINQ to construct a query (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Discusses how to use .NET Language-Integrated Query(LINQ) query provider in Dynamics 365 to construct a query"
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
  - "LINQ operators and their limitations, select clause"
  - "LINQ operators and their limitations, orderby operator"
  - "LINQ operators and their limitations, from clause"
  - "LINQ operators and their limitations"
  - "LINQ operators and their limitations, join clause"
  - "LINQ operators and their limitations, where clause"
  - "LINQ queries, using LINQ to construct queries"
  - "using LINQ to construct queries, LINQ operators and their limitations"
ms.assetid: 8fda7c51-ce40-4263-aeac-804dc79ea212
caps.latest.revision: 41
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Use LINQ to construct a query
The [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] query provider in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement uses standard LINQ syntax. The first step in creating a LINQ query is to identify the relevant entity types and the relationships between them. You can then specify the data source and the other query parameters.  
  
 The `from` clause is used to return a single “root” entity. The query provider can only return entities of a single entity type. The `orderby` and `select` clauses must reference this root entity. You can use `join` clauses to add entities with a relationship to the “root” entity.  
  
<a name="bkmk_operators"></a>   
## LINQ operators  
 All LINQ query expressions have a similar format. The following table shows the most common clauses in a LINQ query expression when using the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] LINQ query provider.  
  
### from  
 When using the generated service context and early binding, use the `IQueryable` entity set, such as `AccountSet`, in the generated context.  
  
 When not using the generated context, the `CreateQuery` method on the organization service context object gives you access to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] entities.  
  
 Example:  
  
 Using the generated service context:  
  
```csharp  
var query1 = from c in context.ContactSet  
select c;  
```  
  
 Using the `CreateQuery` method:  
  
```csharp  
var query1 = from c in context.CreateQuery<Contact>()  
select c;  
```  
  
### join  
 The `join` clause represents an inner join. You use the clause to work with two or more entities that can be joined with a common attribute value.  
  
 Example:  
  
```csharp  
from c in context.ContactSet  
join a in context.AccountSet on c.ContactId equals a.PrimaryContactId.Id  
```  
  
### where  
 The `where` clause applies a filter to the results, often using a Boolean expression. The filter specifies which elements to exclude from the source sequence. Each `where` clause can only contain conditions against a single entity type. A composite condition involving multiple entities is not valid. Instead, each entity should be filtered in separate `where` clauses.  
  
 Example:  
  
```csharp  
from a in context.AccountSet  
where (a.Name.StartsWith("Contoso") && a.Address1_StateOrProvince == "WA")  
```  
  
### orderby  
 The `orderby` operator puts the returned query attributes in a specified order.  
  
 Example:  
  
```csharp  
var query1 = from c in context.CreateQuery<Contact>()     
    orderby c.FullName ascending     
    select c;  
foreach ( var q in query1)     
{  
    Console.WriteLine(q.FirstName + " " + q.LastName);     
}  
```  
  
### select  
 The `select` clause defines the form of the data returned. The clause creates a column set based on the query expression results. You can also define an instance of a new object to work with. The newly created object using the `select` clause is not created on the server, but is a local instance.  
  
 Example:  
  
```csharp  
select new Contact     
{  
    ContactId = c.ContactId,  
    FirstName = c.FirstName,  
    LastName = c.LastName,  
    Address1_Telephone1 = c.Address1_Telephone1     
};  
```  
  
<a name="limitations"></a>   
## LINQ limitations  
 The LINQ query provider supports a subset of the LINQ operators. Not all conditions that can be expressed in LINQ are supported. The following table shows some of the limitations of the basic LINQ operators.  
  
|LINQ Operator|Limitations|  
|-------------------|-----------------|  
|`join`|Represents an inner or outer join. Only left outer joins are supported.|  
|`from`|Supports one `from` clause per query.|  
|`where`|The left side of the clause must be an attribute name and the right side of the clause must be a value. You cannot set the left side to a constant. Both the sides of the clause cannot be constants.<br /><br /> Supports the `String` functions `Contains`, `StartsWith`, `EndsWith`, and `Equals`.|  
|`groupBy`|Not supported. FetchXML supports grouping options that are not available with the LINQ query provider. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use FetchXML Aggregation](use-fetchxml-aggregation.md)|  
|`orderBy`|Supports ordering by entity attributes, such as `Contact.FullName`.|  
|`select`|Supports anonymous types, constructors, and initializers.|  
|`last`|The `last` operator is not supported.|  
|`skip` and `take`|Supports `skip` and `take` using server-side paging. The `skip` value must be greater than or equal to the `take` value.|  
|`aggregate`|Not supported. FetchXML supports aggregation options that are not available with the LINQ query provider. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use FetchXML Aggregation](use-fetchxml-aggregation.md)|  
  
<a name="filter"></a>   
## Filter multiple entities  
 You can create complex [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] queries in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)]. You use multiple `Join` clauses with filter clauses to create a result that is filtered on attributes from several entities.  
  
 The following sample shows how to create a LINQ query that works with two entities and filters the result based on values from each of the entities.  
  
 [!code-csharp[query#linqexamples3](../../snippets/csharp/CRMV8/query/cs/linqexamples3.cs#linqexamples3)]  
  
 [!code-vb[queryvb#linqexamples3](../../snippets/visualbasic/CRMV8/queryvb/vb/linqexamples3.vb#linqexamples3)]  
  
### See also  
 [Sample: Create a LINQ Query](sample-create-linq-query.md)   
 [Sample: LINQ Query Examples](sample-complex-linq-queries.md)   
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 [Use Late-Bound Entity Class with a LINQ Query](use-late-bound-entity-class-linq-query.md)   
 [Blog: LINQPad 4 Driver for Dynamics CRM REST/Web API are available on CodePlex](http://blogs.msdn.com/b/crminthefield/archive/2015/06/11/linqpad-4-driver-for-dynamics-crm-rest-webapi-are-available-on-codeplex.aspx)