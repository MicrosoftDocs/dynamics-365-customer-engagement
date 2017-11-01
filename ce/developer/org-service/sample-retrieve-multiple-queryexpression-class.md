---
title: "Sample: Retrieve multiple with the QueryExpression class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to retrieve multiple entities using the QueryBase) method with QueryExpression along with their related entity columns. The code returns columns from the primary account record as well as the firstname and lastname of the primary contacts associated with the account"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2bdd259c-1003-4b37-a7db-61bf2278c7e4
caps.latest.revision: 20
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Retrieve multiple with the QueryExpression class

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Example  
 This sample shows how to retrieve multiple entities using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple(Microsoft.Xrm.Sdk.Query.QueryBase)> method with <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> along with their related entity columns. The code returns columns from the primary account record as well as the firstname and lastname of the primary contacts associated with the account.  
 
To access aliased values, use the <xref:Microsoft.Xrm.Sdk.Entity>.<xref:Microsoft.Xrm.Sdk.Entity.GetAttributeValue``1(System.String)> to get the <xref:Microsoft.Xrm.Sdk.AliasedValue>.<xref:Microsoft.Xrm.Sdk.AliasedValue.Value>.
  
```csharp  
static void RetrieveMultipleWithRelatedEntityColumns(IOrganizationService service)
{
    Console.WriteLine("Entering:RetrieveMultipleWithRelatedEntityColumns");
    //Create multiple accounts with primary contacts  
    Entity contact = new Entity("contact");
    contact.Attributes["firstname"] = "ContactFirstName";
    contact.Attributes["lastname"] = "ContactLastName";
    Guid contactId = service.Create(contact);

    Entity account = new Entity("account");
    account["name"] = "Test Account1";
    EntityReference primaryContactId = new EntityReference("contact", contactId);
    account["primarycontactid"] = primaryContactId;

    Guid accountId1 = service.Create(account);
    account["name"] = "Test Account2";
    Guid accountId2 = service.Create(account);
    account["name"] = "Test Account3";
    Guid accountId3 = service.Create(account);

    //Create a query expression specifying the link entity alias and the columns of the link entity that you want to return  
    QueryExpression qe = new QueryExpression();
    qe.EntityName = "account";
    qe.ColumnSet = new ColumnSet();
    qe.ColumnSet.Columns.Add("name");

    qe.LinkEntities.Add(new LinkEntity("account", "contact", "primarycontactid", "contactid", JoinOperator.Inner));
    qe.LinkEntities[0].Columns.AddColumns("firstname", "lastname");
    qe.LinkEntities[0].EntityAlias = "primarycontact";

    EntityCollection ec = service.RetrieveMultiple(qe);

    Console.WriteLine("Retrieved {0} entities", ec.Entities.Count);
    foreach (Entity act in ec.Entities)
    {
        Console.WriteLine("account name: {0}", act["name"]);
        Console.WriteLine("primary contact first name: {0}", act.GetAttributeValue<AliasedValue>("primarycontact.firstname").Value);
        Console.WriteLine("primary contact first name: {0}", act.GetAttributeValue<AliasedValue>("primarycontact.lastname").Value);
    }
} 
```  
The code will output the following:
```ms-dos
Entering:RetrieveMultipleWithRelatedEntityColumns
Retrieved 3 entities
account name: Test Account1
primary contact first name: ContactFirstName
primary contact first name: ContactLastName
account name: Test Account2
primary contact first name: ContactFirstName
primary contact first name: ContactLastName
account name: Test Account3
primary contact first name: ContactFirstName
primary contact first name: ContactLastName
```
  
### See also  
 [Use the QueryExpression Class](use-queryexpression-class.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [QueryBase](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrievemultiple\(microsoft.xrm.sdk.query.querybase\))   
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>   
 [Build Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Sample: Convert queries between Fetch and QueryExpression](sample-convert-queries-fetch-queryexpression.md)   
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>
