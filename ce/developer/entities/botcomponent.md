---
title: "Copilot component (botcomponent) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Copilot component (botcomponent) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Copilot component (botcomponent) table/entity reference

Holds key authoring components of a Copilot such a topics, entities, variables, etc.

> [!NOTE]
> The Microsoft Dynamics 365 Copilot component (botcomponent) table extends the [Microsoft Dataverse Copilot component (botcomponent) table](/power-apps/developer/data-platform/reference/entities/botcomponent).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ComponentType"></a> ComponentType

Changes from [ComponentType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/botcomponent#BKMK_ComponentType)

#### ComponentType Choices/Options

|Value|Label|
|---|---|
|17|**External Trigger**|

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
