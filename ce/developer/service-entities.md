---
title: "Service entities in Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about service entites that are targeted at the customer service department of an organization."
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
  - "service entities (contract; incident; knowledge base), introduction"
  - "customer service department, entities for"
ms.assetid: 4a81b285-0ebc-446e-920e-ac7d82d4b027
caps.latest.revision: 25
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Service entities in Dynamics 365 Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The entities described in this section are targeted at the customer service department of an organization.  
  
> [!NOTE]
>  In addition to the entities linked to later in this topic, there are several entities that will appear to support a set of messages or could be used with the<xref:Microsoft.Xrm.Sdk.IOrganizationService> methods. However, the following entities are for internal use only:  
> 
> - `ConvertRule` (Automatic Record Creation and Update Rule): Defines the rules for automatic record creation and updates.  
>   -   `ConvertRuleItem` (Case Creation Rule Item): Defines the individual conditions required for creating and updating record automatically.  
>   -   `RoutingRule` (Routing Rule Set): Defines a set of rules to route cases automatically to queues, users, or teams.  
>   -   `RoutingRuleItem` (Rule Item): Defines the individual conditions required for routing the cases.  
>   -   `SLA`: Contains information about the service level agreements for cases that belong to different customers.  
>   -   `SLAItem` (SLA Item): Contains information about a tracked service level agreement (SLA) key performance indicator and the condition when it is applicable for case records.  
> 
>   While these entities appear to support common messages and methods, they also have a dependency on the web application so that certain messages will not work as expected when called directly from the web services. You should not use these entities in your code.  
> 
>   However, with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], you can use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message on the `ConvertRule`, `RoutingRule`, and `SLA` entities to programmatically activate or deactivate these entity records. For information about changing the state of an entity record using the `Update` message, see [Perform specialized operations using Update](org-service/perform-specialized-operations-using-update.md)  
  
## In This Section  
 [Contract Entities](contract-entities.md)  
  
 [Incident (Case) Entities](incident-case-entities.md)  
  
 [Knowledge Base Entities](knowledge-management-entities.md)  
  
 [Entitlement Entities](entitlement-entities.md)  
  
 [Apply SLAs to entities](apply-slas-entities.md)  
  
 [SlaKpiInstance Entity](entities/slakpiinstance.md)  
  
## Related Sections  
 [Model Your Business Data With Dynamics 365](model-business-data.md)  
  
 [Activity Entities](activity-entities.md)  
  
 [Server-side Synchronization Entities](server-side-synchronization-entities.md)  
  
 [Goal Management Entities](goal-management-entities.md)  
  
 [Product Catalog Entities](product-catalog-entities.md)  
  
 [Sales Literature Entities](sales-literature-entities.md)
