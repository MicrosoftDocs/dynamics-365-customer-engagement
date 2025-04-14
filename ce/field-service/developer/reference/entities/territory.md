---
title: "Territory table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Territory table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Territory table/entity reference (Microsoft Dynamics 365 Field Service)

Territory represents sales regions.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Territory table extends the [Microsoft Dynamics 365 Territory table](/dynamics365/developer/reference/entities/territory).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_territory_account_ServiceTerritory](#BKMK_msdyn_territory_account_ServiceTerritory)
- [msdyn_territory_msdyn_actual_ServiceTerritory](#BKMK_msdyn_territory_msdyn_actual_ServiceTerritory)
- [msdyn_territory_msdyn_agreement_ServiceTerritory](#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory)
- [msdyn_territory_msdyn_postalcode_ServiceTerritory](#BKMK_msdyn_territory_msdyn_postalcode_ServiceTerritory)
- [msdyn_territory_msdyn_resourcerequirement_Territory](#BKMK_msdyn_territory_msdyn_resourcerequirement_Territory)
- [msdyn_territory_msdyn_resourceterritory_Territory](#BKMK_msdyn_territory_msdyn_resourceterritory_Territory)
- [msdyn_territory_msdyn_workorder_ServiceTerritory](#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)

### <a name="BKMK_msdyn_territory_account_ServiceTerritory"></a> msdyn_territory_account_ServiceTerritory

Many-To-One Relationship: [account msdyn_territory_account_ServiceTerritory](account.md#BKMK_msdyn_territory_account_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_account_ServiceTerritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_actual_ServiceTerritory"></a> msdyn_territory_msdyn_actual_ServiceTerritory

Many-To-One Relationship: [msdyn_actual msdyn_territory_msdyn_actual_ServiceTerritory](msdyn_actual.md#BKMK_msdyn_territory_msdyn_actual_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_actual_ServiceTerritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory"></a> msdyn_territory_msdyn_agreement_ServiceTerritory

Many-To-One Relationship: [msdyn_agreement msdyn_territory_msdyn_agreement_ServiceTerritory](msdyn_agreement.md#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_agreement_ServiceTerritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_postalcode_ServiceTerritory"></a> msdyn_territory_msdyn_postalcode_ServiceTerritory

Many-To-One Relationship: [msdyn_postalcode msdyn_territory_msdyn_postalcode_ServiceTerritory](msdyn_postalcode.md#BKMK_msdyn_territory_msdyn_postalcode_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_postalcode_ServiceTerritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_resourcerequirement_Territory"></a> msdyn_territory_msdyn_resourcerequirement_Territory

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_territory_msdyn_resourcerequirement_Territory](msdyn_resourcerequirement.md#BKMK_msdyn_territory_msdyn_resourcerequirement_Territory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_territory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_resourcerequirement_Territory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_resourceterritory_Territory"></a> msdyn_territory_msdyn_resourceterritory_Territory

Many-To-One Relationship: [msdyn_resourceterritory msdyn_territory_msdyn_resourceterritory_Territory](msdyn_resourceterritory.md#BKMK_msdyn_territory_msdyn_resourceterritory_Territory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`msdyn_territory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_resourceterritory_Territory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory"></a> msdyn_territory_msdyn_workorder_ServiceTerritory

Many-To-One Relationship: [msdyn_workorder msdyn_territory_msdyn_workorder_ServiceTerritory](msdyn_workorder.md#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_workorder_ServiceTerritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.territory?displayProperty=fullName>
