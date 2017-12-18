---
title: "Use the Entity class to add or update associations between related records (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use the IOrganizationService. Associate and IOrganizationService.Disassociate methods to create and remove associations between related records"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ffb2c5cb-3d16-4324-b7b8-d53eec55490d
caps.latest.revision: 21
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use the Entity class to add or update associations between related records

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>. <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> and <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*> methods to create and remove associations between related records.  
  
 To create an association, you first determine the unique ID of the target entity to be associated. You then create a collection of entities to be associated with the target entity. Next, you define a relationship between the entities in the collection and the target entity. Finally, you pass this information to the `Associate` method. The same information is passed to the `Disassociate` method when you remove an association.  
  
 The following code example shows how to create associations between related records and how to disassociate them.  
  
```csharp  
// The account ID would typically be passed in as an argument or determined by a query.  
// The contact ID would typically be passed in as an argument or determined by a query.  
// Associate the accounts to the contact record.   
//Create a collection of the entity ids that will be associated to the contact.  
EntityReferenceCollection relatedEntities = new EntityReferenceCollection();  
relatedEntities.Add(new EntityReference("account", _account1Id));  
relatedEntities.Add(new EntityReference("account", _account2Id));  
relatedEntities.Add(new EntityReference("account", _account3Id));   
// Create an object that defines the relationship between the contact and account.  
Relationship relationship = new Relationship("account_primary_contact");  
  //Associate the contact with the 3 accounts.  
_orgService.Associate("contact", _contactId, relationship, relatedEntities);   
Console.WriteLine("The entities have been associated.");   
//Disassociate the records.  
_orgService.Disassociate("contact", _contactId, relationship, relatedEntities);   
Console.WriteLine("The entities have been disassociated.");  
```  
  
### See also  
 [Use the Late Bound Entity Class in Code](use-late-bound-entity-class-code.md)   
 [Use the Entity Class for Create, Update and Delete](use-entity-class-create-update-delete.md)   
 [Entity relationship behavior](../entity-relationship-behavior.md)   
 [Sample: Create, Retrieve, Update and Delete (CRUD) Using Property Bag (Loosely-typed)](sample-create-retrieve-update-delete-late-bound.md)
