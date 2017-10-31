---
title: "Sample: Retrieve with one-to-many relationship (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The following sample shows how to use the QueryBase) method to return the 1:N related entities of an entity along with the primary entity"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 48e437ea-6733-44cb-acf1-2e8b20fd6506
caps.latest.revision: 15
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Retrieve with one-to-many relationship

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]

## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Example  
 The following sample shows how to use the <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method to return the 1:N related entities of an entity along with the primary entity. In this example, we retrieve an account and its related tasks.  
  
```csharp  
Console.WriteLine("One-to-many Query using RetrieveMultiple");  
    Console.WriteLine();  
//Create an account and three related tasks  
    Account account = new Account();  
    account.Name = "SDK Test Account";  
    Guid acctId = _serviceProxy.Create(account);  
    Console.WriteLine("New account created.");  
    Console.WriteLine();  
  
    Task task1 = new Task();  
    task1.Subject = "Test Task1";  
    task1.RegardingObjectId = new EntityReference("account", acctId);  
    Guid task1Id = _serviceProxy.Create(task1);  
  
    Task task2 = new Task();  
    task2.Subject = "Test Task2";  
    task2.RegardingObjectId = new EntityReference("account", acctId);  
    Guid task2Id = _serviceProxy.Create(task2);  
  
    Task task3 = new Task();  
    task3.Subject = "Test Task3";  
    task3.RegardingObjectId = new EntityReference("account", acctId);  
    Guid task3Id = _serviceProxy.Create(task2);  
  
    Console.WriteLine("Three tasks created.");  
    Console.WriteLine();  
  
// Construct query  
    // Condition where task attribute equals account id.   
    ConditionExpression condition = new ConditionExpression();  
    condition.AttributeName = "regardingobjectid";  
    condition.Operator = ConditionOperator.Equal;  
    condition.Values.Add(acctId.ToString());  
  
    //Create a column set.  
    ColumnSet columns = new ColumnSet("subject");  
  
    // Create query expression.  
    QueryExpression query1 = new QueryExpression();  
    query1.ColumnSet = columns;  
    query1.EntityName = "task";  
    query1.Criteria.AddCondition(condition);  
  
    EntityCollection result1 = _serviceProxy.RetrieveMultiple(query1);  
  
    foreach (var r in result1.Entities)  
    {  
        Console.WriteLine(r.Attributes["subject"]);  
    };  
    Console.WriteLine("-------------------------------");  
    Console.WriteLine();  
  
```  
  
### See also  
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [Build Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Sample: Retrieve multiple with the QueryByAttribute class](sample-retrieve-multiple-querybyattribute-class.md)   
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>