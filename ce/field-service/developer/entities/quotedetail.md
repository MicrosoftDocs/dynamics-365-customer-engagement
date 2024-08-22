---
title: "Quote Line (QuoteDetail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Quote Line (QuoteDetail) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Quote Line (QuoteDetail) table/entity reference

Product line item in a quote. The details include such information as product ID, description, quantity, and cost.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Quote Line (QuoteDetail) table extends the [Microsoft Dynamics 365 Quote Line (QuoteDetail) table](/dynamics365/developer/entities/quotedetail).


## Properties

The following table lists selected properties for the Quote Line (QuoteDetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Line** |
| **DisplayCollectionName** | **Quote Lines** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_EndDate](#BKMK_msdyn_EndDate)
- [msdyn_EstimatedCost](#BKMK_msdyn_EstimatedCost)
- [msdyn_EstimatedMargin](#BKMK_msdyn_EstimatedMargin)
- [msdyn_EstimatedRevenue](#BKMK_msdyn_EstimatedRevenue)
- [msdyn_ImportDetailsFromAgreement](#BKMK_msdyn_ImportDetailsFromAgreement)
- [msdyn_LineType](#BKMK_msdyn_LineType)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_SalesTaxCode](#BKMK_msdyn_SalesTaxCode)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_StartDate](#BKMK_msdyn_StartDate)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**The agreement that will be connected to this quote**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Duration of the service associated with the quote line**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

|Property|Value|
|---|---|
|Description|**End date of the service associated with the quote line**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

|Property|Value|
|---|---|
|Description|**The estimated cost of this quote line**|
|DisplayName|**EstimatedCost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedMargin"></a> msdyn_EstimatedMargin

|Property|Value|
|---|---|
|Description|**The estimated margin of this quote line**|
|DisplayName|**Estimated Margin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedmargin`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedRevenue"></a> msdyn_EstimatedRevenue

|Property|Value|
|---|---|
|Description|**The estimated revenue of this quote line**|
|DisplayName|**EstimatedRevenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_ImportDetailsFromAgreement"></a> msdyn_ImportDetailsFromAgreement

|Property|Value|
|---|---|
|Description||
|DisplayName|**ImportDetailsFromAgreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_importdetailsfromagreement`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotedetail_msdyn_importdetailsfromagreement`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

|Property|Value|
|---|---|
|Description|**The field to distinguish the quote lines to be of project service or field service**|
|DisplayName|**Line Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linetype`|

#### msdyn_LineType Choices/Options

|Value|Label|
|---|---|
|690970000|**Project Service Line**|
|690970001|**Field Service Line**|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**The price list associated for the service account on this quote line**|
|DisplayName|**Services Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

|Property|Value|
|---|---|
|Description|**The sales tax code**|
|DisplayName|**Sales Tax Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salestaxcode`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_taxcode|

### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

|Property|Value|
|---|---|
|Description|**The service account for this quote line**|
|DisplayName|**Service Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|---|---|
|Description|**Service territory of this service**|
|DisplayName|**Service Territory**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceterritory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|territory|

### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

|Property|Value|
|---|---|
|Description|**Start Date of the service associated with the quote Line**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**States whether this is taxable**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotedetail_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedrevenue_Base](#BKMK_msdyn_estimatedrevenue_Base)

### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedCost in base currency.**|
|DisplayName|**EstimatedCost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedrevenue_Base"></a> msdyn_estimatedrevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedRevenue in base currency.**|
|DisplayName|**EstimatedRevenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_account_quotedetail_ServiceAccount](#BKMK_msdyn_account_quotedetail_ServiceAccount)
- [msdyn_msdyn_agreement_quotedetail_Agreement](#BKMK_msdyn_msdyn_agreement_quotedetail_Agreement)
- [msdyn_msdyn_taxcode_quotedetail_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode)
- [msdyn_pricelevel_quotedetail_PriceList](#BKMK_msdyn_pricelevel_quotedetail_PriceList)
- [msdyn_territory_quotedetail_ServiceTerritory](#BKMK_msdyn_territory_quotedetail_ServiceTerritory)
- [transactioncurrency_quotedetail](#BKMK_transactioncurrency_quotedetail)

### <a name="BKMK_msdyn_account_quotedetail_ServiceAccount"></a> msdyn_account_quotedetail_ServiceAccount

One-To-Many Relationship: [account msdyn_account_quotedetail_ServiceAccount](account.md#BKMK_msdyn_account_quotedetail_ServiceAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ServiceAccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_quotedetail_Agreement"></a> msdyn_msdyn_agreement_quotedetail_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_quotedetail_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_quotedetail_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_Agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode"></a> msdyn_msdyn_taxcode_quotedetail_SalesTaxCode

One-To-Many Relationship: [msdyn_taxcode msdyn_msdyn_taxcode_quotedetail_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`msdyn_salestaxcode`|
|ReferencingEntityNavigationPropertyName|`msdyn_SalesTaxCode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_quotedetail_PriceList"></a> msdyn_pricelevel_quotedetail_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_quotedetail_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_quotedetail_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_PriceList`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_territory_quotedetail_ServiceTerritory"></a> msdyn_territory_quotedetail_ServiceTerritory

One-To-Many Relationship: [territory msdyn_territory_quotedetail_ServiceTerritory](territory.md#BKMK_msdyn_territory_quotedetail_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencedEntity|`territory`|
|ReferencedAttribute|`territoryid`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencingEntityNavigationPropertyName|`msdyn_ServiceTerritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_quotedetail](transactioncurrency.md#BKMK_transactioncurrency_quotedetail)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_quotedetail_msdyn_quotebookingsetup"></a> msdyn_quotedetail_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup msdyn_quotedetail_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_msdyn_quotedetail_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`msdyn_quotedetail_msdyn_quotebookingset`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotedetail_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

