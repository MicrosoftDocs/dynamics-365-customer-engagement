---
title: "Reduce potential data loss using optimistic concurrency (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how to reduce potential data loss when two or more update or delete operations on the same piece of data happen at the same time using optimistic concurrency"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0eb0167c-e312-4c6f-8a3c-760a2e73c0ff
caps.latest.revision: 17
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Reduce potential data loss using optimistic concurrency
On a multi-threaded and multi-user system like [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement, operations and data changes often happen in parallel. A problem arises when two or more update or delete operations on the same piece of data happen at the same time. This situation could potentially result in data loss. Provided in this SDK release is the ability for your applications to detect whether an entity record has changed on the server in the time between when your application retrieved the record and when it tries to update or delete that record.  
  
 Optimistic concurrency is supported on all out-of-box entities enabled for offline sync and all custom entities. You can determine if an entity supports optimistic concurrency by retrieving the entity’s metadata through an SDK call, or by viewing the metadata using the Metadata Browser, and check if the attribute **IsOptimisticConcurrencyEnabled** is set to `true`. For custom entities, this property is set to `true` by default. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
<a name="bkmk_enable"></a>   
## Enable optimistic concurrency  
 You can enable optimistic concurrency checking behavior when executing an <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> by setting the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest.ConcurrencyBehavior> property of the request to <xref:Microsoft.Xrm.Sdk.ConcurrencyBehavior.IfRowVersionMatches>. Similarly, for a <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest>, you would set the <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest.ConcurrencyBehavior> property.  
  
 When using the organization service context to make data changes, set <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.ConcurrencyBehavior> on the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> object. This value will be passed through to all of the **UpdateRequest** and **DeleteRequest** messages used by the **OrganizationServiceContext** when <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> is called.  
  
 Optimistic concurrency behavior can only be set through an SDK call. There is presently no setting for it in a form of the Web application.  
  
<a name="bkmk_update"></a>   
## Update or delete a record  
 After retrieving an entity record, access the <xref:Microsoft.Xrm.Sdk.Entity.RowVersion> attribute to obtain the current version of that record. In the entity object you use as the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest.Target> in the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest>, set the <xref:Microsoft.Xrm.Sdk.Entity.RowVersion> property to the same value from the retrieved record and execute the request. Similarly, in the entity reference object you use as the <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest.Target> in the <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest>, set the <xref:Microsoft.Xrm.Sdk.EntityReference.RowVersion> property to the same row version value from the retrieved record and execute the request.  
  
 If the entity passed to the **UpdateRequest** contains related entities, the same behavior is applied to all update operations using the row versions supplied with each individual entity.  
  
 When the request is received by the platform, a comparison of the current entity record row version and the row version in the request is performed. If the row versions match and <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest.ConcurrencyBehavior> is set to <xref:Microsoft.Xrm.Sdk.ConcurrencyBehavior.IfRowVersionMatches>, the operation succeeds. Otherwise, a fault exception is returned.  
  
<a name="bkmk_handle"></a>   
## Handle exceptions  
 There are several error conditions that can be returned in a [FaultException](https://msdn.microsoft.com/library/ms576199\(v=vs.110\).aspx)\<<xref:Microsoft.Xrm.Sdk.OrganizationServiceFault>> from the Web service call when using optimistic concurrency.  
  
- **ConcurrencyVersionMismatch** (code=-2147088254)  
  
     When a row version is provided and the **IfVersionMatches** behavior is indicated, if the existing record’s version does not match the row version provided in the request, a fault is returned.  
  
- **ConcurrencyVersionNotProvided** (code= -2147088253  
  
     When the **IfVersionMatches** behavior is indicated, and no value for row version is provided, a fault is returned.  
  
- **OptimisticConcurrencyNotEnabled** (code=-2147088243)  
  
     When the **IfVersionMatches** behavior is indicated on an update to an entity, and where optimistic concurrency isn’t enabled, a fault is returned.  
  
 You can check the [Code](https://msdn.microsoft.com/library/system.servicemodel.faultexception.code\(v=vs.110\).aspx) property of the returned fault to determine if the fault is related to optimistic concurrency. The codes for the error conditions that were shown previously were obtained from the ErrorCodes.cs helper code.  
  
### See also  
 [Extend Dynamics 365 Customer Engagement on the server](../extend-dynamics-365-server.md)   
 [Sample: Use optimistic concurrency with update and delete operations](sample-use-optimistic-concurrency-update-delete-operations.md)
