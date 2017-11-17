---
title: "Use FetchXML to construct a query (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This article discusses how to create and execute a FetchXML query "
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
  - "using FetchXML to construct queries, building the XML query strings"
  - "FetchXML queries, how privileges of logged-on users affect the returned records"
  - "using FetchXML to construct queries, code examples"
  - "creating queries with FetchXML, using FetchXML to construct queries"
  - "using FetchXML to construct queries, executing by using the IOrganizationService.RetrieveMultiple method"
  - "using FetchXML to construct queries, conforming with schema definitions of the FetchXML language"
  - "using FetchXML to construct queries, privileges of logged-on users affect the returned records"
  - "FetchXML queries, using FetchXML to construct queries"
  - "building queries with FetchXML, using FetchXML to construct queries"
ms.assetid: 273dd192-cc12-4ab0-84ec-1ea1b8f367c3
caps.latest.revision: 37
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use FetchXML to construct a query

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

To execute a FetchXML query in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you must first build the XML query string. After you create the query string, use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method to execute the query string. The privileges of the logged on user affects the set of records returned. Only records for which the logged on user has read access will be returned.  
  
 The FetchXML query string must conform to the schema definition for the FetchXML language. For more information, see [Fetch XML Schema](fetchxml-schema.md).  
  
 You can save a query by creating a `SavedQuery` record, as demonstrated in [Sample: Validate and Execute a Saved Query](sample-validate-execute-saved-query.md). Set `visible` on the `link-entity` node to `false` to hide the linked entity in the **Advanced Find** user interface. It will still participate in the execution of the query and will return the appropriate results.  
  
> [!WARNING]
>  Don’t retrieve all attributes in a query because of the negative effect on performance. This is particularly true if the query is used as a parameter to an update request. In an update, if all attributes are included this sets all field values, even if they are unchanged, and often triggers cascaded updates to child records.  
  
## Create the Query String  
 In the following example, the **FetchXML** statement retrieves all accounts:  
  
```xml  
  
<fetch mapping='logical'>   
   <entity name='account'>  
      <attribute name='accountid'/>   
      <attribute name='name'/>   
</entity>  
</fetch>  
  
```  
  
 In the following example, the **FetchXML** statement retrieves all accounts where the last name of the owning user is not equal to Cannon:  
  
```xml  
  
<fetch mapping='logical'>  
   <entity name='account'>   
      <attribute name='accountid'/>   
      <attribute name='name'/>   
      <link-entity name='systemuser' to='owninguser'>   
         <filter type='and'>   
            <condition attribute='lastname' operator='ne' value='Cannon' />   
          </filter>   
      </link-entity>   
   </entity>   
</fetch>  
  
```  
  
 In the following example, the **FetchXML** statement uses count to set the maximum number of records returned from the query. In this case first 3 accounts are returned from the query,  
  
```  
<fetch mapping='logical' count='3'>  
  <entity name='account'>  
   <attribute name='name' alias='name'/>  
  </entity></fetch>  
```  
  
 This example shows an inner join between EntityMap and AttributeMap where the EntityMapID matches.  
  
```  
<fetch version='1.0' mapping='logical' distinct='false'>  
   <entity name='entitymap'>  
      <attribute name='sourceentityname'/>  
      <attribute name='targetentityname'/>  
      <link-entity name='attributemap' alias='attributemap' to='entitymapid' from='entitymapid' link-type='inner'>  
         <attribute name='sourceattributename'/>  
         <attribute name='targetattributename'/>  
      </link-entity>  
   </entity>  
 </fetch>  
```  
  
## Execute the Query  
 The following code shows how to execute a **FetchXML** query:  
  
```csharp  
  
// Retrieve all accounts owned by the user with read access rights to the accounts and   
// where the last name of the user is not Cannon.   
string fetch2 = @"  
   <fetch mapping='logical'>  
     <entity name='account'>   
        <attribute name='accountid'/>   
        <attribute name='name'/>   
        <link-entity name='systemuser' to='owninguser'>   
           <filter type='and'>   
              <condition attribute='lastname' operator='ne' value='Cannon' />   
           </filter>   
        </link-entity>   
     </entity>   
   </fetch> ";   
  
EntityCollection result = _serviceProxy.RetrieveMultiple(new FetchExpression(fetch2));foreach (var c in result.Entities)   {   System.Console.WriteLine(c.Attributes["name"]);   }  
```  
  
## Query Results  
 When you execute a FetchXML query by using the <!--[QueryBase)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationserviceproxy.retrievemultiple\(microsoft.xrm.sdk.query.querybase\))--> <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.RetrieveMultiple(Microsoft.Xrm.Sdk.Query.QueryBase)> <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.RetrieveMultiple(Microsoft.Xrm.Sdk.Query.QueryBase)> method authenticates the user. 
 method, the return value is an <xref:Microsoft.Xrm.Sdk.EntityCollection> that contains the results of the query. You can then iterate through the entity collection. The previous example uses the `foreach` loop to iterate through the result collection of the FetchXML query.  
  
### See also  
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Use FetchXML Aggregation](use-fetchxml-aggregation.md)   
 [Fetch XML Schema](fetchxml-schema.md)
