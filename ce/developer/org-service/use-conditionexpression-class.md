---
title: "Use the ConditionExpression class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use the ConditionExpression class to compare an attribute to a value or set of values by using an operator, such as “equal to” or “greater than”"
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
  - "using the ConditionExpression class"
  - "comparing attributes to a value or set of values by using operators, ConditionExpression class"
  - "ConditionExpression class, about; properties for; and code examples"
  - "using operators to compare attributes to a value or set of values, ConditionExpression class"
  - "ConditionExpression class, comparing attributes to a value or set of values by using operators"
  - "ConditionExpression class, passing condition expressions to other classes"
ms.assetid: 68a072f6-e3d9-48f6-9e55-11df3dbd1bf5
caps.latest.revision: 27
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use the ConditionExpression class

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Query.ConditionExpression> class to compare an attribute to a value or set of values by using an operator, such as “equal to” or “greater than”. The `ConditionExpression` class lets you pass condition expressions as parameters to other classes, such as <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> and <xref:Microsoft.Xrm.Sdk.Query.FilterExpression>.  
  
 The following table lists the properties you can set to create a condition using the `ConditionExpression` class.  
  
|Property|Description|  
|--------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Query.ConditionExpression.AttributeName>|Specifies the logical name of the attribute in the condition expression.|  
|<xref:Microsoft.Xrm.Sdk.Query.ConditionExpression.Operator>|Specifies the condition operator. This is set by using the <xref:Microsoft.Xrm.Sdk.Query.ConditionOperator> enumeration.|  
|<xref:Microsoft.Xrm.Sdk.Query.ConditionExpression.Values>|Specifies the values of the attribute.|  
  
 When using the <xref:Microsoft.Xrm.Sdk.Query.FilterExpression.AddCondition(Microsoft.Xrm.Sdk.Query.ConditionExpression)> method (or the constructor for <xref:Microsoft.Xrm.Sdk.Query.ConditionExpression>), it’s important to understand whether the array is being added as multiple values or as an array.  
  
 The following code example shows two different outcomes depending on how the array is used.  
  
```csharp  
string[] values = new string[] { "Value1", "Value2" };  
ConditionExpression c = new ConditionExpression("name", ConditionOperator.In, values);  
Console.WriteLine(c.Values.Count); //This will output 2   
string[] values = new string[] { "Value1", "Value2" }object value = values;  
ConditionExpression c = new ConditionExpression("name", ConditionOperator.In, value);  
Console.WriteLine(c.Values.Count); //This will output 1  
  
```  
  
 In some cases, it is necessary to cast to either `object[]` or `object`, depending on the desired behavior.  
  
 When you create a condition that compares an attribute value to an enumeration, such as a state code, you must use the `ToString` method to convert the value to a string.  
  
## Example  
 The following code example shows how to use the `ConditionExpression` class.  
  
```csharp  
  
//  Query using ConditionExpression    
ConditionExpression condition1 = new ConditionExpression();  
condition1.AttributeName = "lastname";    
condition1.Operator = ConditionOperator.Equal;    
condition1.Values.Add("Brown");                    
FilterExpression filter1 = new FilterExpression();    
filter1.Conditions.Add(condition1);    
QueryExpression query = new QueryExpression("contact");    
query.ColumnSet.AddColumns("firstname", "lastname");    
query.Criteria.AddFilter(filter1);    
EntityCollection result1 = _serviceProxy.RetrieveMultiple(query);    
Console.WriteLine();    
Console.WriteLine("Query using Query Expression with ConditionExpression and FilterExpression");    
Console.WriteLine("---------------------------------------");    
foreach (var a in result1.Entities)    
{  
      Console.WriteLine("Name: " + a.Attributes["firstname"] + " " + a.Attributes["lastname"]);    
}    
Console.WriteLine("---------------------------------------");  
```  
  
## Example  
 The following code example shows how to use the `ConditionExpression` class to test for the inactive state.  
  
```csharp  
  
ConditionExpression condition3 = new ConditionExpression();  
condition3.AttributeName = "statecode";  
condition3.Operator = ConditionOperator.Equal;  
condition3.Values.Add(AccountState.Active);  
  
```  
  
### See also  
 [Building Queries](build-queries-with-queryexpression.md)   
 [Build Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Use the FilterExpression Class](use-filterexpression-class.md)   
 <xref:Microsoft.Xrm.Sdk.Query.ConditionExpression>