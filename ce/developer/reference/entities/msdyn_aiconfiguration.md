---
title: "AI Configuration (msdyn_AIConfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Configuration (msdyn_AIConfiguration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Configuration (msdyn_AIConfiguration) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 AI Configuration (msdyn_AIConfiguration) table extends the [Microsoft Dataverse AI Configuration (msdyn_AIConfiguration) table](/power-apps/developer/data-platform/reference/entities/msdyn_aiconfiguration).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_iermltraining_publishaiconfiguration](#BKMK_msdyn_iermltraining_publishaiconfiguration)
- [msdyn_iermltraining_trainaiconfiguration](#BKMK_msdyn_iermltraining_trainaiconfiguration)
- [msdyn_ocsimltraining_publishaiconfigurati](#BKMK_msdyn_ocsimltraining_publishaiconfigurati)
- [msdyn_ocsimltraining_trainaiconfiguration](#BKMK_msdyn_ocsimltraining_trainaiconfiguration)

### <a name="BKMK_msdyn_iermltraining_publishaiconfiguration"></a> msdyn_iermltraining_publishaiconfiguration

Many-To-One Relationship: [msdyn_iermltraining msdyn_iermltraining_publishaiconfiguration](msdyn_iermltraining.md#BKMK_msdyn_iermltraining_publishaiconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermltraining`|
|ReferencingAttribute|`msdyn_publishaiconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyn_iermltraining_publishaiconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iermltraining_trainaiconfiguration"></a> msdyn_iermltraining_trainaiconfiguration

Many-To-One Relationship: [msdyn_iermltraining msdyn_iermltraining_trainaiconfiguration](msdyn_iermltraining.md#BKMK_msdyn_iermltraining_trainaiconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermltraining`|
|ReferencingAttribute|`msdyn_trainaiconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyn_iermltraining_trainaiconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsimltraining_publishaiconfigurati"></a> msdyn_ocsimltraining_publishaiconfigurati

Many-To-One Relationship: [msdyn_ocsimltraining msdyn_ocsimltraining_publishaiconfigurati](msdyn_ocsimltraining.md#BKMK_msdyn_ocsimltraining_publishaiconfigurati)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsimltraining`|
|ReferencingAttribute|`msdyn_publishaiconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsimltraining_publishaiconfigurati`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsimltraining_trainaiconfiguration"></a> msdyn_ocsimltraining_trainaiconfiguration

Many-To-One Relationship: [msdyn_ocsimltraining msdyn_ocsimltraining_trainaiconfiguration](msdyn_ocsimltraining.md#BKMK_msdyn_ocsimltraining_trainaiconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsimltraining`|
|ReferencingAttribute|`msdyn_trainaiconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsimltraining_trainaiconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_aiconfiguration?displayProperty=fullName>
