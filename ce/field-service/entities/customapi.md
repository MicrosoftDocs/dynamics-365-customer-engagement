---
title: "Custom API (CustomAPI) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Custom API (CustomAPI) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Custom API (CustomAPI) table/entity reference

Entity that defines a custom API

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Custom API (CustomAPI) table extends the [Microsoft Dataverse Custom API (CustomAPI) table](/power-apps/developer/data-platform/reference/entities/customapi).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI](#BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI)
- [msdyn_formmapping_customapiid](#BKMK_msdyn_formmapping_customapiid)
- [msdynmkt_customapi_eventmetadata](#BKMK_msdynmkt_customapi_eventmetadata)
- [msdynmkt_journeydependency_dependency_customapi](#BKMK_msdynmkt_journeydependency_dependency_customapi)

### <a name="BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI"></a> msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI

Many-To-One Relationship: [msdyn_customapirulesetconfiguration msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI](msdyn_customapirulesetconfiguration.md#BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`msdyn_customapi`|
|ReferencedEntityNavigationPropertyName|`msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_formmapping_customapiid"></a> msdyn_formmapping_customapiid

Many-To-One Relationship: [msdyn_formmapping msdyn_formmapping_customapiid](msdyn_formmapping.md#BKMK_msdyn_formmapping_customapiid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_formmapping`|
|ReferencingAttribute|`customapiid`|
|ReferencedEntityNavigationPropertyName|`msdyn_formmapping_customapiid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_customapi_eventmetadata"></a> msdynmkt_customapi_eventmetadata

Many-To-One Relationship: [msdynmkt_eventmetadata msdynmkt_customapi_eventmetadata](msdynmkt_eventmetadata.md#BKMK_msdynmkt_customapi_eventmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata`|
|ReferencingAttribute|`msdynmkt_customapiid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_customapi_eventmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_customapi"></a> msdynmkt_journeydependency_dependency_customapi

Many-To-One Relationship: [msdynmkt_journeydependency msdynmkt_journeydependency_dependency_customapi](msdynmkt_journeydependency.md#BKMK_msdynmkt_journeydependency_dependency_customapi)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_dependency_customapi`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.customapi?displayProperty=fullName>
