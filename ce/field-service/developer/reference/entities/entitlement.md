---
title: "Entitlement table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Entitlement table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Entitlement table/entity reference (Microsoft Dynamics 365 Field Service)

Defines the amount and type of support a customer should receive.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Entitlement table extends the [Microsoft Dynamics 365 Entitlement table](/dynamics365/developer/reference/entities/entitlement).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_AppliesTo](#BKMK_msdyn_AppliesTo)
- [msdyn_EntitlementPrioritization](#BKMK_msdyn_EntitlementPrioritization)
- [msdyn_PercentDiscount](#BKMK_msdyn_PercentDiscount)
- [msdyn_PriceListToApply](#BKMK_msdyn_PriceListToApply)

### <a name="BKMK_msdyn_AppliesTo"></a> msdyn_AppliesTo

|Property|Value|
|---|---|
|Description|**The work order entities to which the entitlement is applicable.**|
|DisplayName|**Applies To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appliesto`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_entitlementappliesto`|

#### msdyn_AppliesTo Choices/Options

|Value|Label|
|---|---|
|690970000|**Work Order Products**|
|690970001|**Work Order Services**|
|690970002|**Both Work Order Products & Services**|

### <a name="BKMK_msdyn_EntitlementPrioritization"></a> msdyn_EntitlementPrioritization

|Property|Value|
|---|---|
|Description|**The priority level when considering which eligible entitlement to apply, where the lower the number the higher the priority.**|
|DisplayName|**Entitlement Prioritization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitlementprioritization`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_PercentDiscount"></a> msdyn_PercentDiscount

|Property|Value|
|---|---|
|Description|**The percent discount the entitlement applies to the work order.**|
|DisplayName|**% Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_percentdiscount`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_PriceListToApply"></a> msdyn_PriceListToApply

|Property|Value|
|---|---|
|Description|**The price list that the entitlement applies to the work order.**|
|DisplayName|**Price List To Apply**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelisttoapply`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [entitytype](#BKMK_entitytype)

### <a name="BKMK_AllocationTypeCode"></a> AllocationTypeCode

Changes from [AllocationTypeCode (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/entitlement#BKMK_AllocationTypeCode)

#### AllocationTypeCode Choices/Options

|Value|Label|
|---|---|
|192350000|**Discount % and Price List**|

### <a name="BKMK_entitytype"></a> entitytype

Changes from [entitytype (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/entitlement#BKMK_entitytype)

#### entitytype Choices/Options

|Value|Label|
|---|---|
|192350000|**Work Order**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [entitlement_msdyn_bookingalerts](#BKMK_entitlement_msdyn_bookingalerts)
- [msdyn_entitlement_msdyn_entitlementapplication_entitlement](#BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement)
- [msdyn_entitlement_msdyn_workorderproduct_Entitlement](#BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement)
- [msdyn_entitlement_msdyn_workorderservice_entitlement](#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement)

### <a name="BKMK_entitlement_msdyn_bookingalerts"></a> entitlement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert entitlement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement"></a> msdyn_entitlement_msdyn_entitlementapplication_entitlement

Many-To-One Relationship: [msdyn_entitlementapplication msdyn_entitlement_msdyn_entitlementapplication_entitlement](msdyn_entitlementapplication.md#BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`msdyn_entitlement`|
|ReferencedEntityNavigationPropertyName|`msdyn_entitlement_msdyn_entitlementapplication_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement"></a> msdyn_entitlement_msdyn_workorderproduct_Entitlement

Many-To-One Relationship: [msdyn_workorderproduct msdyn_entitlement_msdyn_workorderproduct_Entitlement](msdyn_workorderproduct.md#BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_entitlement`|
|ReferencedEntityNavigationPropertyName|`msdyn_entitlement_msdyn_workorderproduct_Entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement"></a> msdyn_entitlement_msdyn_workorderservice_entitlement

Many-To-One Relationship: [msdyn_workorderservice msdyn_entitlement_msdyn_workorderservice_entitlement](msdyn_workorderservice.md#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_entitlement`|
|ReferencedEntityNavigationPropertyName|`msdyn_entitlement_msdyn_workorderservice_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

