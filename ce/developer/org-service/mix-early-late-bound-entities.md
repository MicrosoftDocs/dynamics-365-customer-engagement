---
title: "Mix early and late bound entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how to mix early and late binding methods to work with both strong types and the Entity class"
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
  - "mixing early- and late-bound entities, assigning early-bound instances to late-bound instances"
  - "using early-bound entity classes in code, mixing early- and late-bound entities"
  - "assigning early-bound instances to late-bound instances, mixing early- and late-bound entities"
  - "mixing early- and late-bound entities, with both strong types and the entity class"
  - "early-bound class samples, assigning early-bound instances to late-bound instances"
  - "samples for early-bound classes, assigning early-bound instances to late-bound instances"
ms.assetid: bbfe8b49-518a-4692-b0b3-a64f97b5dc66
caps.latest.revision: 20
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Mix early and late bound entities

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement, you can mix early binding and late binding methods to work with both strong types and the <xref:Microsoft.Xrm.Sdk.Entity> class. This approach uses both static metadata from a code-generated file of strong types with the flexibility of the <xref:Microsoft.Xrm.Sdk.Entity> class and its helper methods.  
  
 The following example shows one way to mix early and late binding methods.  
  
```csharp  
// Create an organization service context object  
AWCServiceContext context = new AWCServiceContext(_serviceProxy);  
  
// Instantiate an account object using the Entity class.  
Entity testaccount = new Entity("account");  
  
// Set several attributes. For account, only the name is required.   
testaccount["name"] = "Fourth Coffee";  
testaccount["emailaddress1"] = "marshd@contoso.com";  
  
// Save the entity using the organization service context object.  
context.AddToAccountSet(testaccount);  
context.SaveChanges();  
  
```  
  
## Assign an early bound instance to a late bound instance  
 The following sample shows how to assign an early bound instance to a late bound instance.  
  
```csharp
Entity incident = ((Entity)context.InputParameters[ParameterName.Target]).ToEntity<Incident>();  
Task relatedEntity = new Task() { Id = this.TaskId };  
  
incident.RelatedEntities[new Relationship("Incident_Tasks")] =   
new EntityCollection(new Entity[] { relatedEntity.ToEntity<Entity>() });  
```  
  
### See also  
 [Use the Early Bound Entity Classes](use-early-bound-entity-classes-code.md)   
 [Use the Late Bound Entity Class](use-late-bound-entity-class-code.md)   
 [Sample: Use the organization service context](sample-use-organization-service-context.md)
