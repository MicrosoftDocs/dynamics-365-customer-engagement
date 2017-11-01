---
title: "Test for a null value (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to test for a null value by using the FilterExpression and QueryByAttribute classes"
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
  - "testing for null values, about and code examples"
  - "testing for equality or inequality of"
  - "testing for null values"
  - "null values, testing for"
  - "testing for null values, by using the FilterExpression and QueryByAttribute classes"
ms.assetid: f0998642-40e2-4283-a306-b61d48abec98
caps.latest.revision: 11
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Test for a null value

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The following code example shows how to test for a null value by using the <xref:Microsoft.Xrm.Sdk.Query.FilterExpression> and <xref:Microsoft.Xrm.Sdk.Query.QueryByAttribute> classes.  
  
## Example  
 Use this code to test for equality by using the <xref:Microsoft.Xrm.Sdk.Query.FilterExpression> class.  
  
```csharp  
FilterExpression null_filter = new FilterExpression(LogicalOperator.And);   
null_filter.FilterOperator = LogicalOperator.And;   
null_filter.AddCondition("leadid", ConditionOperator.Null);  
  
```  
  
## Example  
 Use this code to test for inequality by using the <xref:Microsoft.Xrm.Sdk.Query.FilterExpression> class.  
  
```csharp  
  
FilterExpression filter = new FilterExpression(LogicalOperator.And);   
filter.FilterOperator = LogicalOperator.And;   
filter.AddCondition("leadid", ConditionOperator.NotNull);  
```  
  
## Example  
 Use this code to test for equality by using the <xref:Microsoft.Xrm.Sdk.Query.QueryByAttribute> class.  
  
```csharp  
  
QueryByAttribute qba = new QueryByAttribute("account");   
qba.ColumnSet = new ColumnSet("name","address1_stateorprovince");   
qba.AddAttributeValue("donotfax", null);  
```  
  
### See also  
 [Building Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Page large result sets with QueryExpression](page-large-result-sets-with-queryexpression.md)
