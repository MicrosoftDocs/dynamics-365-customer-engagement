---
title: "Entity table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entity table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entity table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Entity table extends the [Microsoft Dataverse Entity table](/power-apps/developer/data-platform/reference/entities/entity).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_entity_msdyn_contactsuggestionruleset_entitytype](#BKMK_msdyn_entity_msdyn_contactsuggestionruleset_entitytype)
- [msdyn_entity_msdyn_inboxentityconfig_entitytypeid](#BKMK_msdyn_entity_msdyn_inboxentityconfig_entitytypeid)
- [msdyn_entity_msdyn_swarmtemplate_entitytypeid](#BKMK_msdyn_entity_msdyn_swarmtemplate_entitytypeid)

### <a name="BKMK_msdyn_entity_msdyn_contactsuggestionruleset_entitytype"></a> msdyn_entity_msdyn_contactsuggestionruleset_entitytype

Many-To-One Relationship: [msdyn_contactsuggestionruleset msdyn_entity_msdyn_contactsuggestionruleset_entitytype](msdyn_contactsuggestionruleset.md#BKMK_msdyn_entity_msdyn_contactsuggestionruleset_entitytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionruleset`|
|ReferencingAttribute|`msdyn_entitytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_entity_msdyn_contactsuggestionruleset_entitytype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entity_msdyn_inboxentityconfig_entitytypeid"></a> msdyn_entity_msdyn_inboxentityconfig_entitytypeid

Many-To-One Relationship: [msdyn_inboxentityconfig msdyn_entity_msdyn_inboxentityconfig_entitytypeid](msdyn_inboxentityconfig.md#BKMK_msdyn_entity_msdyn_inboxentityconfig_entitytypeid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inboxentityconfig`|
|ReferencingAttribute|`msdyn_entitytypeid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entity_msdyn_inboxentityconfig_entitytypeid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entity_msdyn_swarmtemplate_entitytypeid"></a> msdyn_entity_msdyn_swarmtemplate_entitytypeid

Many-To-One Relationship: [msdyn_swarmtemplate msdyn_entity_msdyn_swarmtemplate_entitytypeid](msdyn_swarmtemplate.md#BKMK_msdyn_entity_msdyn_swarmtemplate_entitytypeid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmtemplate`|
|ReferencingAttribute|`msdyn_entitytypeid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entity_msdyn_swarmtemplate_entitytypeid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.entity?displayProperty=fullName>
