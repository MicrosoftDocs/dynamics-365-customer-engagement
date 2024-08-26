---
title: "Unit (UoM) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Unit (UoM) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Unit (UoM) table/entity reference

Unit of measure.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Unit (UoM) table extends the [Microsoft Dynamics 365 Unit (UoM) table](/dynamics365/developer/entities/uom).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_uom_msdyn_actual_Unit](#BKMK_msdyn_uom_msdyn_actual_Unit)
- [msdyn_uom_msdyn_agreementbookingproduct_Unit](#BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit)
- [msdyn_uom_msdyn_agreementbookingservice_Unit](#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit)
- [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit)
- [msdyn_uom_msdyn_geofencingsettings_DistanceUnit](#BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit)
- [msdyn_uom_msdyn_incidenttypeproduct_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)
- [msdyn_uom_msdyn_incidenttyperecommendationresult_Unit](#BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit)
- [msdyn_uom_msdyn_incidenttypeservice_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)
- [msdyn_uom_msdyn_inventoryadjustmentproduct_Unit](#BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit)
- [msdyn_uom_msdyn_inventoryjournal_Unit](#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit)
- [msdyn_uom_msdyn_orderinvoicingproduct_Unit](#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit)
- [msdyn_uom_msdyn_productinventory_Unit](#BKMK_msdyn_uom_msdyn_productinventory_Unit)
- [msdyn_uom_msdyn_purchaseorderproduct_Unit](#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit)
- [msdyn_uom_msdyn_quotebookingproduct_Unit](#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)
- [msdyn_uom_msdyn_quotebookingservice_Unit](#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit)
- [msdyn_uom_msdyn_quoteinvoicingproduct_Unit](#BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit)
- [msdyn_uom_msdyn_rmaproduct_Unit](#BKMK_msdyn_uom_msdyn_rmaproduct_Unit)
- [msdyn_uom_msdyn_rtvproduct_Unit](#BKMK_msdyn_uom_msdyn_rtvproduct_Unit)
- [msdyn_uom_msdyn_workorderproduct_Unit](#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)
- [msdyn_uom_msdyn_workorderservice_Unit](#BKMK_msdyn_uom_msdyn_workorderservice_Unit)

### <a name="BKMK_msdyn_uom_msdyn_actual_Unit"></a> msdyn_uom_msdyn_actual_Unit

Many-To-One Relationship: [msdyn_actual msdyn_uom_msdyn_actual_Unit](msdyn_actual.md#BKMK_msdyn_uom_msdyn_actual_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_actual_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit"></a> msdyn_uom_msdyn_agreementbookingproduct_Unit

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_uom_msdyn_agreementbookingproduct_Unit](msdyn_agreementbookingproduct.md#BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_agreementbookingproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit"></a> msdyn_uom_msdyn_agreementbookingservice_Unit

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_uom_msdyn_agreementbookingservice_Unit](msdyn_agreementbookingservice.md#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_agreementbookingservice_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit"></a> msdyn_uom_msdyn_agreementinvoiceproduct_Unit

Many-To-One Relationship: [msdyn_agreementinvoiceproduct msdyn_uom_msdyn_agreementinvoiceproduct_Unit](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_agreementinvoiceproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit"></a> msdyn_uom_msdyn_geofencingsettings_DistanceUnit

Many-To-One Relationship: [msdyn_geofencingsettings msdyn_uom_msdyn_geofencingsettings_DistanceUnit](msdyn_geofencingsettings.md#BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`msdyn_unitofmeasure`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_geofencingsettings_DistanceUnit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit"></a> msdyn_uom_msdyn_incidenttypeproduct_Unit

Many-To-One Relationship: [msdyn_incidenttypeproduct msdyn_uom_msdyn_incidenttypeproduct_Unit](msdyn_incidenttypeproduct.md#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_incidenttypeproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit"></a> msdyn_uom_msdyn_incidenttyperecommendationresult_Unit

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult msdyn_uom_msdyn_incidenttyperecommendationresult_Unit](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_incidenttyperecommendationresult_Unit`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit"></a> msdyn_uom_msdyn_incidenttypeservice_Unit

Many-To-One Relationship: [msdyn_incidenttypeservice msdyn_uom_msdyn_incidenttypeservice_Unit](msdyn_incidenttypeservice.md#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_incidenttypeservice_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit"></a> msdyn_uom_msdyn_inventoryadjustmentproduct_Unit

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct msdyn_uom_msdyn_inventoryadjustmentproduct_Unit](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_inventoryadjustmentproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_inventoryjournal_Unit"></a> msdyn_uom_msdyn_inventoryjournal_Unit

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_uom_msdyn_inventoryjournal_Unit](msdyn_inventoryjournal.md#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_inventoryjournal_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit"></a> msdyn_uom_msdyn_orderinvoicingproduct_Unit

Many-To-One Relationship: [msdyn_orderinvoicingproduct msdyn_uom_msdyn_orderinvoicingproduct_Unit](msdyn_orderinvoicingproduct.md#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_orderinvoicingproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_productinventory_Unit"></a> msdyn_uom_msdyn_productinventory_Unit

Many-To-One Relationship: [msdyn_productinventory msdyn_uom_msdyn_productinventory_Unit](msdyn_productinventory.md#BKMK_msdyn_uom_msdyn_productinventory_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productinventory`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_productinventory_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit"></a> msdyn_uom_msdyn_purchaseorderproduct_Unit

Many-To-One Relationship: [msdyn_purchaseorderproduct msdyn_uom_msdyn_purchaseorderproduct_Unit](msdyn_purchaseorderproduct.md#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_purchaseorderproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit"></a> msdyn_uom_msdyn_quotebookingproduct_Unit

Many-To-One Relationship: [msdyn_quotebookingproduct msdyn_uom_msdyn_quotebookingproduct_Unit](msdyn_quotebookingproduct.md#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_quotebookingproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_quotebookingservice_Unit"></a> msdyn_uom_msdyn_quotebookingservice_Unit

Many-To-One Relationship: [msdyn_quotebookingservice msdyn_uom_msdyn_quotebookingservice_Unit](msdyn_quotebookingservice.md#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_quotebookingservice_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit"></a> msdyn_uom_msdyn_quoteinvoicingproduct_Unit

Many-To-One Relationship: [msdyn_quoteinvoicingproduct msdyn_uom_msdyn_quoteinvoicingproduct_Unit](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_quoteinvoicingproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_rmaproduct_Unit"></a> msdyn_uom_msdyn_rmaproduct_Unit

Many-To-One Relationship: [msdyn_rmaproduct msdyn_uom_msdyn_rmaproduct_Unit](msdyn_rmaproduct.md#BKMK_msdyn_uom_msdyn_rmaproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_rmaproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_rtvproduct_Unit"></a> msdyn_uom_msdyn_rtvproduct_Unit

Many-To-One Relationship: [msdyn_rtvproduct msdyn_uom_msdyn_rtvproduct_Unit](msdyn_rtvproduct.md#BKMK_msdyn_uom_msdyn_rtvproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_rtvproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

Many-To-One Relationship: [msdyn_workorderproduct msdyn_uom_msdyn_workorderproduct_Unit](msdyn_workorderproduct.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_workorderproduct_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_uom_msdyn_workorderservice_Unit"></a> msdyn_uom_msdyn_workorderservice_Unit

Many-To-One Relationship: [msdyn_workorderservice msdyn_uom_msdyn_workorderservice_Unit](msdyn_workorderservice.md#BKMK_msdyn_uom_msdyn_workorderservice_Unit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencedEntityNavigationPropertyName|`msdyn_uom_msdyn_workorderservice_Unit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

