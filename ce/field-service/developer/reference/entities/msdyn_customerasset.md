---
title: "Customer Asset (msdyn_customerasset) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer Asset (msdyn_customerasset) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer Asset (msdyn_customerasset) table/entity reference (Microsoft Dynamics 365 Field Service)

Specify Customer Asset.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Customer Asset (msdyn_customerasset) table extends the [Microsoft Dynamics 365 Customer Asset (msdyn_customerasset) table](/dynamics365/developer/reference/entities/msdyn_customerasset).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

|Property|Value|
|---|---|
|Description|**Indicates a link to the Work Order Product from where this Asset was auto created by the system.**|
|DisplayName|**Work Order Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderproduct|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_MasterAsset](#BKMK_msdyn_MasterAsset)
- [msdyn_ParentAsset](#BKMK_msdyn_ParentAsset)

### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

Changes from [msdyn_DeviceId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_customerasset#BKMK_msdyn_DeviceId)

|Property|Value|
|---|---|
|Description|Device ID used to register with the IoT provider. This will not be used if there are two or more connected devices for this asset. This value will be updated based on the connected devices.|


### <a name="BKMK_msdyn_MasterAsset"></a> msdyn_MasterAsset

Changes from [msdyn_MasterAsset (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_customerasset#BKMK_msdyn_MasterAsset)

|Property|Value|
|---|---|
|DisplayName|**Top-Level Asset**|
|Description|Top-Level Asset, (if this asset is a sub asset)|


### <a name="BKMK_msdyn_ParentAsset"></a> msdyn_ParentAsset

Changes from [msdyn_ParentAsset (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_customerasset#BKMK_msdyn_ParentAsset)

|Property|Value|
|---|---|
|DisplayName|**Parent Asset**|
|Description|Parent Asset|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

One-To-Many Relationship: [msdyn_workorderproduct msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customerasset_msdyn_bookingalerts](#BKMK_msdyn_customerasset_msdyn_bookingalerts)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset)
- [msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid](#BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid)
- [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)

### <a name="BKMK_msdyn_customerasset_msdyn_bookingalerts"></a> msdyn_customerasset_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_customerasset_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_customerasset_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Customer Asset<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingservicetask msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset"></a> msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset

Many-To-One Relationship: [msdyn_entitlementapplication msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](msdyn_entitlementapplication.md#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid"></a> msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid

Many-To-One Relationship: [msdyn_inspectioninstance msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid](msdyn_inspectioninstance.md#BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`msdyn_customerassetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset

Many-To-One Relationship: [msdyn_rmaproduct msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_workorder.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

Many-To-One Relationship: [msdyn_workorderincident msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_workorderincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

Many-To-One Relationship: [msdyn_workorderproduct msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset

Many-To-One Relationship: [msdyn_workorderresolution msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset](msdyn_workorderresolution.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

Many-To-One Relationship: [msdyn_workorderservice msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_workorderservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

Many-To-One Relationship: [msdyn_workorderservicetask msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Customized relationships

### Customized One-to-Many relationships

#### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

Changes from [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_customerasset#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset)

|Property|Value|
|---|---|
|AssociatedMenuConfiguration|Label: `Items of Master Asset`|


### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

