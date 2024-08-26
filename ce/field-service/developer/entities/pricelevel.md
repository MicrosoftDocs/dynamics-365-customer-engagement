---
title: "Price List (PriceLevel) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Price List (PriceLevel) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Price List (PriceLevel) table/entity reference

Entity that defines pricing levels.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Price List (PriceLevel) table extends the [Microsoft Dynamics 365 Price List (PriceLevel) table](/dynamics365/developer/entities/pricelevel).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_BreakHoursBillable"></a> msdyn_BreakHoursBillable

|Property|Value|
|---|---|
|Description||
|DisplayName|**Break Hours Billable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakhoursbillable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_pricelevel_msdyn_breakhoursbillable`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

One-To-Many Relationship: [transactioncurrency transactioncurrency_pricelevel](transactioncurrency.md#BKMK_transactioncurrency_pricelevel)

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

- [msdyn_pricelevel_entitlement_PriceListToApply](#BKMK_msdyn_pricelevel_entitlement_PriceListToApply)
- [msdyn_pricelevel_msdyn_actual_PriceList](#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)
- [msdyn_pricelevel_msdyn_agreement_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)
- [msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList)
- [msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)
- [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList)
- [msdyn_pricelevel_msdyn_rma_PriceList](#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)
- [msdyn_pricelevel_msdyn_rmaproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorder_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList)
- [msdyn_pricelevel_msdyn_workorderproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)
- [msdyn_pricelevel_msdyn_workorderservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)
- [msdyn_pricelevel_msdyn_workordertype_PriceList](#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList)
- [msdyn_pricelevel_opportunityproduct_PriceList](#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)
- [msdyn_pricelevel_quotedetail_PriceList](#BKMK_msdyn_pricelevel_quotedetail_PriceList)

### <a name="BKMK_msdyn_pricelevel_entitlement_PriceListToApply"></a> msdyn_pricelevel_entitlement_PriceListToApply

Many-To-One Relationship: [entitlement msdyn_pricelevel_entitlement_PriceListToApply](entitlement.md#BKMK_msdyn_pricelevel_entitlement_PriceListToApply)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`msdyn_pricelisttoapply`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_entitlement_PriceListToApply`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_actual_PriceList"></a> msdyn_pricelevel_msdyn_actual_PriceList

Many-To-One Relationship: [msdyn_actual msdyn_pricelevel_msdyn_actual_PriceList](msdyn_actual.md#BKMK_msdyn_pricelevel_msdyn_actual_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_actual_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_agreement_PriceList"></a> msdyn_pricelevel_msdyn_agreement_PriceList

Many-To-One Relationship: [msdyn_agreement msdyn_pricelevel_msdyn_agreement_PriceList](msdyn_agreement.md#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_agreement_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList](msdyn_agreementbookingproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Price List<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingservice_PriceList

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](msdyn_agreementbookingservice.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_agreementbookingservice_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Price List<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList"></a> msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList

Many-To-One Relationship: [msdyn_agreementinvoiceproduct msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList"></a> msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList

Many-To-One Relationship: [msdyn_fieldservicepricelistitem msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicepricelistitem`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingproduct_PriceList

Many-To-One Relationship: [msdyn_quotebookingproduct msdyn_pricelevel_msdyn_quotebookingproduct_PriceList](msdyn_quotebookingproduct.md#BKMK_msdyn_pricelevel_msdyn_quotebookingproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_quotebookingproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingservice_PriceList

Many-To-One Relationship: [msdyn_quotebookingservice msdyn_pricelevel_msdyn_quotebookingservice_PriceList](msdyn_quotebookingservice.md#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_quotebookingservice_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_rma_PriceList"></a> msdyn_pricelevel_msdyn_rma_PriceList

Many-To-One Relationship: [msdyn_rma msdyn_pricelevel_msdyn_rma_PriceList](msdyn_rma.md#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_rma_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList"></a> msdyn_pricelevel_msdyn_rmaproduct_PriceList

Many-To-One Relationship: [msdyn_rmaproduct msdyn_pricelevel_msdyn_rmaproduct_PriceList](msdyn_rmaproduct.md#BKMK_msdyn_pricelevel_msdyn_rmaproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_rmaproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workorder_PriceList"></a> msdyn_pricelevel_msdyn_workorder_PriceList

Many-To-One Relationship: [msdyn_workorder msdyn_pricelevel_msdyn_workorder_PriceList](msdyn_workorder.md#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_workorder_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

Many-To-One Relationship: [msdyn_workorderproduct msdyn_pricelevel_msdyn_workorderproduct_PriceList](msdyn_workorderproduct.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_workorderproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList"></a> msdyn_pricelevel_msdyn_workorderservice_PriceList

Many-To-One Relationship: [msdyn_workorderservice msdyn_pricelevel_msdyn_workorderservice_PriceList](msdyn_workorderservice.md#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_workorderservice_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList"></a> msdyn_pricelevel_msdyn_workordertype_PriceList

Many-To-One Relationship: [msdyn_workordertype msdyn_pricelevel_msdyn_workordertype_PriceList](msdyn_workordertype.md#BKMK_msdyn_pricelevel_msdyn_workordertype_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_msdyn_workordertype_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_opportunityproduct_PriceList"></a> msdyn_pricelevel_opportunityproduct_PriceList

Many-To-One Relationship: [opportunityproduct msdyn_pricelevel_opportunityproduct_PriceList](opportunityproduct.md#BKMK_msdyn_pricelevel_opportunityproduct_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_opportunityproduct_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_pricelevel_quotedetail_PriceList"></a> msdyn_pricelevel_quotedetail_PriceList

Many-To-One Relationship: [quotedetail msdyn_pricelevel_quotedetail_PriceList](quotedetail.md#BKMK_msdyn_pricelevel_quotedetail_PriceList)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencedEntityNavigationPropertyName|`msdyn_pricelevel_quotedetail_PriceList`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

