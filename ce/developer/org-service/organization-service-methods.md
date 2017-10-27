---
title: "Organization service methods (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read about the set of methods that IOrganizationService web service provides that can be used to perform common operations like Create, Retrieve, RetrieveMultiple, Update and Delete on system and custom entities and on the metadata for your organization"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 34f69739-16d5-492c-bfd3-eee6772cd5eb
caps.latest.revision: 28
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Organization service methods
The <xref:Microsoft.Xrm.Sdk.IOrganizationService> interface provides a set of methods used to perform the most common operations on system and custom entities and on the metadata for your organization. These operations can also be performed by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method and the corresponding message.  
  
## Create  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method to create an instance (record) of any entity that supports the **Create** message, including custom entities.  
  
## Retrieve  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*> method to retrieve an instance (record) of an entity.  
  
## RetrieveMultiple  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method to retrieve a collection records. The query can be specified using a query expression or Fetch XML query.  
  
## Update  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method to update an existing record.  
  
## Delete  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method to delete an existing record.  
  
## Associate  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> method to create a link between two records that participate in a relationship.  
  
## Disassociate  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*> method to delete the link between two records.  
  
## Execute  
 Use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method to execute a message. This includes common processing like create and delete of data records and metadata, or it can be specialized processing such as import or detect duplicates.  
  
## Example  
 The following code shows how to use the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>, <xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>, and <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> methods using the strong types.  
  
 [!code-csharp[StrongTypes#CompoundCreateUpdate1](../../snippets/csharp/CRMV8/strongtypes/cs/compoundcreateupdate1.cs#compoundcreateupdate1)]  
  
### See also  
<xref:Microsoft.Xrm.Sdk.IOrganizationService><br />
 [Use the IOrganizationService web service to read and write data or metadata](use-organization-service-read-write-data-metadata.md)<br />
 [Use messages (request and response classes) with the Execute method](use-messages-request-response-classes-execute-method.md)<br />
 [Use ExecuteMultiple to improve performance for bulk data load](use-executemultiple-improve-performance-bulk-data-load.md)<br />
 [Microsoft.Xrm.Sdk Messages](xrm-messages-organization-service.md)<br />
 [Microsoft.Crm.Sdk Messages](organization-service-messages.md)<br />
 [Connecting to the Dynamics 365 Services - Authentication](authenticate-users.md)<br />
 [Sample: Create, Retrieve, Update and Delete (CRUD) Using Strong Types](sample-create-retrieve-update-delete-records-early-bound.md)<br />
 [Sample: Create, Retrieve, Update and Delete (CRUD) Using Property Bag (Loosely-typed)](sample-create-retrieve-update-delete-late-bound.md)
