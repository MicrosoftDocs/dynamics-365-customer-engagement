---
title: "Incident (case) hierarchies (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about incident (case) hierarchies that allow you to create parent and child case settings and rules for deactivating cases."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service:
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ab5d6aed-52a9-4f4f-95a3-facaf313c088
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Incident (case) hierarchies

Incident entities can be related hierarchically. An administrator can use the **Parent and Child case settings** to configure specific behaviors for these relationships.  
  
 Within the application, people can create a new child incident or associate an existing incident to a parent incident. This association uses the `incident_parent_incident` relationship. When you create a new incident to be associated using this relationship, use the <xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest> message to initialize the new incident with the default values defined in the attribute mapping for this relationship.  
  
 The **Parent and Child case settings** allow easy access to specify the attribute mappings to this relationship, but they may also be set by editing the relationship in the application or programmatically. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit entity relationships](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn531171(v=crm.8)) and [Customize Entity and Attribute Mappings](customize-entity-attribute-mappings.md).  
  
 The following behaviors are enforced for incident hierarchies:  
  
-   Only one level of hierarchy is supported. You can’t set an incident as a parent while it is a child of another incident.  
  
    -   If you try to associate a child incident for an incident that is already the child of another incident you will get error -2147224493 with the message: “You can't create child cases for child cases.”  
  
    -   If you try to associate an incident that is a parent incident as a child of another incident you will get error -2147224491 with the message: “You can't add a parent case as a child case.”  
  
-   Each incident can have up to 100 child incidents. If you try to create too many child incidents you will get error -2147224492 with the message: “A Parent Case cannot have more than 100 child cases. Contact your administrator for more details.”  
  
-   Incidents associated with different parent incidents cannot be merged. The error message is “You can’t merge cases that have different parent cases.” You can use the <xref:Microsoft.Crm.Sdk.Messages.MergeRequest> message to merge incidents.  
  
### Rules for deactivating cases  
 The **Parent and Child case settings** in the application also allow you to configure additional cascade closure preferences. Depending on how the hierarchies are configured for the organization, specific rules around deactivating incidents should be followed to align with the preferences of the organization. When an incident is deactivated, its state is set to either resolved or canceled.  
  
 When **Parent and Child case settings** are configured in the application, data is stored in the following Boolean attributes of the organization entity.  
  
|Attribute|UI Label|  
|---------------|--------------|  
|`CascadeStatusUpdate`|**Close all child cases when parent case is closed**|  
|`RestrictStatusUpdate`|**Don’t allow parent case closure until all child cases are closed**|  
  
 Based on the values of these attributes the following rules are applied by the platform.  
  
|`CascadeStatusUpdate` value|`RestrictStatusUpdate` value|Behavior|  
|---------------------------------|----------------------------------|--------------|  
|False|false|When the **Specify closure preference** option in the **Parent and Child case settings** is not selected, incidents can be deactivated regardless of the status of parent or child incidents.|  
|False|true|Parent incidents can’t be deactivated if any active child incidents exist. If you attempt to do this, you get error -2147224495 with the message: “You can't resolve the parent case because it has {0} active child cases.”|  
|True|false|When parent incidents are deactivated, any active child incidents are also deactivated.|  
|True|true|The application won’t allow both of these values to be set. You shouldn’t set both of these organization attribute values to true.|  
  
### See also  
 [Service Entities (Contract, Incident, Knowledge Base)](service-entities.md)   
 [Incident (Case) Entities](incident-case-entities.md)   
 [Incident Entity](entities/incident.md)   
 [IncidentResolution Entity](entities/incidentresolution.md)   
 [Sample: Close an Incident](sample-close-incident.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]