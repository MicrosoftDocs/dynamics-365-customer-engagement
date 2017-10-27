---
title: "Page large result sets with FetchXML (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can page the results of a FetchXML query by using the paging cookie"
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
  - "paging the results of FetchXML queries, code examples"
  - "paging the results of FetchXML queries, by using the paging cookie"
  - "paging the results of FetchXML queries, effect of nonconsecutive pages on using the paging cookie"
  - "building queries with FetchXML, paging the results of FetchXML queries"
  - "FetchXML queries, paging the results of FetchXML queries"
ms.assetid: cd32c68c-fb8a-4018-90a3-49c6a80ca7b4
caps.latest.revision: 17
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Page large result sets with FetchXML
You can page the results of a FetchXML query by using the paging cookie. The paging cookie is a performance feature that makes paging in the application faster for very large datasets. When you query for a set of records, the result will contain a value for the paging cookie. For better performance, you can pass that value when you retrieve the next set of records.  
  
 FetchXML and <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> use different formats for their paging cookies. If you convert from one query format to the other by using the <xref:Microsoft.Crm.Sdk.Messages.FetchXmlToQueryExpressionRequest> message or the <xref:Microsoft.Crm.Sdk.Messages.QueryExpressionToFetchXmlRequest> message, the paging cookie value is ignored. In addition, if you request nonconsecutive pages, the paging cookie value is ignored.  
  
 When you use the paging cookie with FetchXML, make sure that you use the correct encoding. The following example shows the correct encoding when using the paging cookie with FetchXML:  
  
```csharp  
strQueryXML = @"  
<fetch mapping='logical' paging-cookie='&lt;cookie page=&quot;1&quot;&gt;&lt;accountid last=&quot;{E062B974-7F8D-DC11-9048-0003FF27AC3B}&quot; first=&quot;{60B934EF-798D-DC11-9048-0003FF27AC3B}&quot;/&gt;&lt;/cookie&gt;' page='2' count='2'>  
 <entity name='account'>  
  <all-attributes/>  
 </entity>  
</fetch>";  
```  
  
## FetchXML and the Paging Cookie Example  
 The following example shows how to use the paging cookie with a FetchXML query. For the complete sample code, see [Sample: Use FetchXML with a Paging Cookie](sample-use-fetchxml-paging-cookie.md).  
  
 [!code-csharp[Query#FetchPagingWithCookie1](../../snippets/csharp/CRMV8/query/cs/fetchpagingwithcookie1.cs#fetchpagingwithcookie1)]  
  
### See also  
 [Sample: Use FetchXML with a Paging Cookie](sample-use-fetchxml-paging-cookie.md)   
 [Building Queries with FetchXML](build-queries-fetchxml.md)   
 [Fiscal date query operators in FetchXML](fiscal-date-older-datetime-query-operators-fetchxml.md)   
 [Using FetchXML](use-fetchxml-construct-query.md)   
 [Page large result sets with QueryExpression](page-large-result-sets-with-queryexpression.md)
