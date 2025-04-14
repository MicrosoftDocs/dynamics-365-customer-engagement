---
title: "Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Facility/Equipment (Equipment) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365 Customer Service)

Resource that can be scheduled.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Facility/Equipment (Equipment) table extends the [Microsoft Dynamics 365 Facility/Equipment (Equipment) table](/dynamics365/developer/reference/entities/equipment).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_OrganizationalUnitId"></a> msdyn_OrganizationalUnitId

|Property|Value|
|---|---|
|Description|**Unique identifier for OrganizationalUnit associated with Equipment**|
|DisplayName|**Organizational Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationalunitid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_organizationalunit|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_organizationalunit_equipment"></a> msdyn_organizationalunit_equipment

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_equipment](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`msdyn_organizationalunitid`|
|ReferencingEntityNavigationPropertyName|`msdyn_organizationalunitid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId"></a> msdyn_equipment_bookableresource_FacilityEquipmentId

Many-To-One Relationship: [bookableresource msdyn_equipment_bookableresource_FacilityEquipmentId](bookableresource.md#BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`msdyn_facilityequipmentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_equipment_bookableresource_FacilityEquipmentId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

