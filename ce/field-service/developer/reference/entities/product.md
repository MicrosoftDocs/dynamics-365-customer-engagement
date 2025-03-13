---
title: "Product table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Product table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Product table/entity reference (Microsoft Dynamics 365 Field Service)

Information about products and their pricing information.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Product table extends the [Microsoft Dynamics 365 Product table](/dynamics365/developer/reference/entities/product).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ConvertToCustomerAsset](#BKMK_msdyn_ConvertToCustomerAsset)
- [msdyn_DefaultVendor](#BKMK_msdyn_DefaultVendor)
- [msdyn_FieldServiceProductType](#BKMK_msdyn_FieldServiceProductType)
- [msdyn_PurchaseName](#BKMK_msdyn_PurchaseName)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_UPCCode](#BKMK_msdyn_UPCCode)

### <a name="BKMK_msdyn_ConvertToCustomerAsset"></a> msdyn_ConvertToCustomerAsset

|Property|Value|
|---|---|
|Description|**Specify whether a product is to be converted to a customer asset. When a product is used on a work order, the system will automatically convert it into a customer asset when the work order is closed.**|
|DisplayName|**Convert to Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_converttocustomerasset`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_product_msdyn_converttocustomerasset`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DefaultVendor"></a> msdyn_DefaultVendor

|Property|Value|
|---|---|
|Description|**Default vendor that supplies this product**|
|DisplayName|**Default Vendor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultvendor`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_FieldServiceProductType"></a> msdyn_FieldServiceProductType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Product Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldserviceproducttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_fieldserviceproducttype`|

#### msdyn_FieldServiceProductType Choices/Options

|Value|Label|
|---|---|
|690970000|**Inventory**|
|690970001|**Non\-Inventory**|
|690970002|**Service**|

### <a name="BKMK_msdyn_PurchaseName"></a> msdyn_PurchaseName

|Property|Value|
|---|---|
|Description|**Type the name for the product when used on a purchase order.**|
|DisplayName|**Purchase Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchasename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**Select whether the item is taxable. If an item is set as not taxable, it won't be taxable even on a taxable work order.**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_product_msdyn_taxable`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_UPCCode"></a> msdyn_UPCCode

|Property|Value|
|---|---|
|Description|**Shows the UPC Code for product. Used for bar code scanning.**|
|DisplayName|**UPC Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_upccode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_account_product_DefaultVendor"></a> msdyn_account_product_DefaultVendor

One-To-Many Relationship: [account msdyn_account_product_DefaultVendor](account.md#BKMK_msdyn_account_product_DefaultVendor)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_defaultvendor`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultvendor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_product_msdyn_actual_Product](#BKMK_msdyn_product_msdyn_actual_Product)
- [msdyn_product_msdyn_agreementbookingproduct_Product](#BKMK_msdyn_product_msdyn_agreementbookingproduct_Product)
- [msdyn_product_msdyn_agreementbookingservice_Service](#BKMK_msdyn_product_msdyn_agreementbookingservice_Service)
- [msdyn_product_msdyn_agreementinvoiceproduct_Product](#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product)
- [msdyn_product_msdyn_fieldservicesetting](#BKMK_msdyn_product_msdyn_fieldservicesetting)
- [msdyn_product_msdyn_incidenttypeproduct_Product](#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)
- [msdyn_product_msdyn_incidenttypeservice_Service](#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)
- [msdyn_product_msdyn_inventoryadjustmentproduct_Product](#BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product)
- [msdyn_product_msdyn_inventoryjournal_Product](#BKMK_msdyn_product_msdyn_inventoryjournal_Product)
- [msdyn_product_msdyn_productinventory_Product](#BKMK_msdyn_product_msdyn_productinventory_Product)
- [msdyn_product_msdyn_purchaseorderproduct_Product](#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product)
- [msdyn_product_msdyn_rmaproduct_Product](#BKMK_msdyn_product_msdyn_rmaproduct_Product)
- [msdyn_product_msdyn_rtvproduct_Product](#BKMK_msdyn_product_msdyn_rtvproduct_Product)
- [msdyn_product_msdyn_workorderproduct_Product](#BKMK_msdyn_product_msdyn_workorderproduct_Product)
- [msdyn_product_msdyn_workorderservice_Service](#BKMK_msdyn_product_msdyn_workorderservice_Service)

### <a name="BKMK_msdyn_product_msdyn_actual_Product"></a> msdyn_product_msdyn_actual_Product

Many-To-One Relationship: [msdyn_actual msdyn_product_msdyn_actual_Product](msdyn_actual.md#BKMK_msdyn_product_msdyn_actual_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_actual_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_agreementbookingproduct_Product"></a> msdyn_product_msdyn_agreementbookingproduct_Product

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_product_msdyn_agreementbookingproduct_Product](msdyn_agreementbookingproduct.md#BKMK_msdyn_product_msdyn_agreementbookingproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_agreementbookingproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Product<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_agreementbookingservice_Service"></a> msdyn_product_msdyn_agreementbookingservice_Service

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_product_msdyn_agreementbookingservice_Service](msdyn_agreementbookingservice.md#BKMK_msdyn_product_msdyn_agreementbookingservice_Service)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_service`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_agreementbookingservice_Service`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Service<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product"></a> msdyn_product_msdyn_agreementinvoiceproduct_Product

Many-To-One Relationship: [msdyn_agreementinvoiceproduct msdyn_product_msdyn_agreementinvoiceproduct_Product](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_agreementinvoiceproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Product<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_fieldservicesetting"></a> msdyn_product_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_product_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_msdyn_product_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_travelchargeitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Travel Charge Item<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_incidenttypeproduct_Product"></a> msdyn_product_msdyn_incidenttypeproduct_Product

Many-To-One Relationship: [msdyn_incidenttypeproduct msdyn_product_msdyn_incidenttypeproduct_Product](msdyn_incidenttypeproduct.md#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_incidenttypeproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_incidenttypeservice_Service"></a> msdyn_product_msdyn_incidenttypeservice_Service

Many-To-One Relationship: [msdyn_incidenttypeservice msdyn_product_msdyn_incidenttypeservice_Service](msdyn_incidenttypeservice.md#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`msdyn_service`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_incidenttypeservice_Service`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product"></a> msdyn_product_msdyn_inventoryadjustmentproduct_Product

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct msdyn_product_msdyn_inventoryadjustmentproduct_Product](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_inventoryadjustmentproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_inventoryjournal_Product"></a> msdyn_product_msdyn_inventoryjournal_Product

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_product_msdyn_inventoryjournal_Product](msdyn_inventoryjournal.md#BKMK_msdyn_product_msdyn_inventoryjournal_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_inventoryjournal_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_productinventory_Product"></a> msdyn_product_msdyn_productinventory_Product

Many-To-One Relationship: [msdyn_productinventory msdyn_product_msdyn_productinventory_Product](msdyn_productinventory.md#BKMK_msdyn_product_msdyn_productinventory_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productinventory`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_productinventory_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_purchaseorderproduct_Product"></a> msdyn_product_msdyn_purchaseorderproduct_Product

Many-To-One Relationship: [msdyn_purchaseorderproduct msdyn_product_msdyn_purchaseorderproduct_Product](msdyn_purchaseorderproduct.md#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_purchaseorderproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Product<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_rmaproduct_Product"></a> msdyn_product_msdyn_rmaproduct_Product

Many-To-One Relationship: [msdyn_rmaproduct msdyn_product_msdyn_rmaproduct_Product](msdyn_rmaproduct.md#BKMK_msdyn_product_msdyn_rmaproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_rmaproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_rtvproduct_Product"></a> msdyn_product_msdyn_rtvproduct_Product

Many-To-One Relationship: [msdyn_rtvproduct msdyn_product_msdyn_rtvproduct_Product](msdyn_rtvproduct.md#BKMK_msdyn_product_msdyn_rtvproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_rtvproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

Many-To-One Relationship: [msdyn_workorderproduct msdyn_product_msdyn_workorderproduct_Product](msdyn_workorderproduct.md#BKMK_msdyn_product_msdyn_workorderproduct_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_workorderproduct_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_msdyn_workorderservice_Service"></a> msdyn_product_msdyn_workorderservice_Service

Many-To-One Relationship: [msdyn_workorderservice msdyn_product_msdyn_workorderservice_Service](msdyn_workorderservice.md#BKMK_msdyn_product_msdyn_workorderservice_Service)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_service`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_workorderservice_Service`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

