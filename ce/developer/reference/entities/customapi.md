---
title: "Custom API (CustomAPI) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Custom API (CustomAPI) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Custom API (CustomAPI) table/entity reference (Microsoft Dynamics 365)

Entity that defines a custom API

> [!NOTE]
> The Microsoft Dynamics 365 Custom API (CustomAPI) table extends the [Microsoft Dataverse Custom API (CustomAPI) table](/power-apps/developer/data-platform/reference/entities/customapi).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI](#BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI)
- [msdynmkt_customapi_eventmetadata](#BKMK_msdynmkt_customapi_eventmetadata)

### <a name="BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI"></a> msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI

Many-To-One Relationship: [msdyn_customapirulesetconfiguration msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI](msdyn_customapirulesetconfiguration.md#BKMK_msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`msdyn_customapi`|
|ReferencedEntityNavigationPropertyName|`msdyn_customapi_msdyn_customapirulesetconfiguration_CustomAPI`|
|IsCustomizable|`False`|
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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.customapi?displayProperty=fullName>
