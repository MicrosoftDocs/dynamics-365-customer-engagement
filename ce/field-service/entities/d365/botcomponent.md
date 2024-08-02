---
title: "Chatbot subcomponent (botcomponent) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Chatbot subcomponent (botcomponent) table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Chatbot subcomponent (botcomponent) table/entity reference

Holds key authoring components of a Chatbot such a topics, entities, variables, etc.

> [!NOTE]
> The Microsoft Dynamics 365 Chatbot subcomponent (botcomponent) table extends the [Microsoft Dataverse Chatbot subcomponent (botcomponent) table](/power-apps/developer/data-platform/reference/entities/botcomponent).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid"></a> msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid

Many-To-One Relationship: [msdyn_servicecopilotplugin msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid](msdyn_servicecopilotplugin.md#BKMK_msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotplugin`|
|ReferencingAttribute|`msdyn_botcomponentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.botcomponent?displayProperty=fullName>
