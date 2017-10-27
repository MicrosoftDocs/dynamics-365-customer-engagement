---
title: "Use the late bound entity class in code (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Entity class lets you use late binding so that you can work with types such as custom entities and custom attributes that weren’t available when your application was compiled"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 75c9f21a-9bb7-4324-8a50-c655fc4b589d
caps.latest.revision: 25
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Use the late bound entity class in code
In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Entity> class when you work with entities. When initialized, the <xref:Microsoft.Xrm.Sdk.Entity> class contains the logical name of an entity and a property-bag array of the entity’s attributes. This lets you use late binding so that you can work with types such as custom entities and custom attributes that weren’t available when your application was compiled.  
  
 The key difference between early and late binding involves type conversion. While early binding provides compile-time checking of all types so that no implicit casts occur, late binding checks types only when the object is created or an action is performed on the type. The <xref:Microsoft.Xrm.Sdk.Entity> class requires types to be explicitly specified to prevent implicit casts.  
  
### See also  
 [Extend Dynamics 365 Customer Engagement on the server](../extend-dynamics-365-server.md)   
 [Retrieve Data with Queries](retrieve-data-queries-sdk-assemblies.md)   
 [Use the Entity Class for Create, Update and Delete](use-entity-class-create-update-delete.md)   
 [Use the Entity Class to Add or Update Associations Between Related Records](use-entity-class-add-update-associations-records.md)   
 [Sample: Create, Retrieve, Update and Delete (Late Bound)](sample-create-retrieve-update-delete-late-bound.md)   
 [Sample: Serialize and Deserialize an Entity](sample-serialize-deserialize-entity-instance.md)
