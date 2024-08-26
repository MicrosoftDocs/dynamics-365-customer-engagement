---
title: "Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Facility/Equipment (Equipment) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365 Customer Service)

Resource that can be scheduled.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Facility/Equipment (Equipment) table extends the [Microsoft Dynamics 365 Facility/Equipment (Equipment) table](/dynamics365/developer/entities/equipment).



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


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

Changes from [ExchangeRate (Microsoft Dynamics 365)](/dynamics365/developer/entities/equipment#BKMK_ExchangeRate)

|Property|Value|
|---|---|
|MinValue|1E-12|
|Precision|12|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_organizationalunit_equipment](#BKMK_msdyn_organizationalunit_equipment)
- [TransactionCurrency_Equipment](#BKMK_TransactionCurrency_Equipment)

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

### <a name="BKMK_TransactionCurrency_Equipment"></a> TransactionCurrency_Equipment

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Equipment](transactioncurrency.md#BKMK_TransactionCurrency_Equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

