---
title: "Use the early bound entity classes to associate records (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can create an association between related records using AddLink method in OrganizationServiceContext class for a one-to-many relationship and Associate method in IOrganizationService class using for a many-to-many relationship"
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
  - "adding or updating associations between related records, early bound-entity classes"
  - "using early-bound entity classes in code, adding or updating associations between related records"
  - "using early bound-entity classes to add or update associations between related records"
ms.assetid: 72e6f386-94f0-43a9-aa33-d13a6b2b9628
caps.latest.revision: 24
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use the early bound entity classes to associate records

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can create an association by using early binding in several ways. To create a one-to-many relationship, you can use the [Entity)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.addlink\(microsoft.xrm.sdk.entity,microsoft.xrm.sdk.relationship,microsoft.xrm.sdk.entity\)) method in the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class. To create a many-to-many relationship, you can use the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> method in the<xref:Microsoft.Xrm.Sdk.IOrganizationService> class to create an association. You can also create the association by updating the foreign key of the target entity to match the primary key of the new source entity.  
  
 To remove an association, you can use the [Entity)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.deletelink\(microsoft.xrm.sdk.entity,microsoft.xrm.sdk.relationship,microsoft.xrm.sdk.entity\)) method in the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class or the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*> method. You can also set the foreign key to **null**.  
  
 For a complete sample showing how to add and remove associations, see [Sample: Associate Using Strong Types](sample-associate-records-early-bound.md).  
  
## Use the AddLink method  
 You can use the [Entity)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.addlink\(microsoft.xrm.sdk.entity,microsoft.xrm.sdk.relationship,microsoft.xrm.sdk.entity\)) method to create associations. You must call the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method before the server is updated with the new link information.  
  
 The following code example shows how to create an association between a contact and an account.  
  
```csharp  
Relationship relationship = new Relationship("account_primary_contact");  
context.AddLink(contact, relationship, account);  
context.SaveChanges();  
```  
  
## Use the Associate method  
 You use the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> method to create both one-to-many and many-to-many associations. The following code example shows how to create a one-to-many association between an account and a contact.  
  
```csharp  
Relationship relationship2 = new Relationship("account_primary_contact");  
EntityReferenceCollection relatedEntities = new EntityReferenceCollection();  
relatedEntities.Add(new EntityReference(Account.EntityLogicalName, firstaccount.Id));  
_serviceProxy.Associate(Contact.EntityLogicalName, firstcontact.Id, relationship2, relatedEntities);  
```  
  
### See also  
 [Use the Early Bound Entity Classes](use-early-bound-entity-classes-code.md)   
 [Mix Early and Late Bound Entities](mix-early-late-bound-entities.md)   
 [Use the Early Bound Entity Classes for Create, Update and Delete](use-early-bound-entity-classes-create-update-delete.md)
