---
title: "Order Line (SalesOrderDetail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Order Line (SalesOrderDetail) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Order Line (SalesOrderDetail) table/entity reference

Line item in a sales order.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Order Line (SalesOrderDetail) table extends the [Microsoft Dynamics 365 Order Line (SalesOrderDetail) table](/dynamics365/developer/entities/salesorderdetail).


## Properties

The following table lists selected properties for the Order Line (SalesOrderDetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Order Line** |
| **DisplayCollectionName** | **Order Lines** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_agreement](#BKMK_msdyn_agreement)
- [msdyn_LineType](#BKMK_msdyn_LineType)

### <a name="BKMK_msdyn_agreement"></a> msdyn_agreement

|Property|Value|
|---|---|
|Description|**Select a Agreement for this order line**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

|Property|Value|
|---|---|
|Description|**The field to distinguish the order lines to be of project service or field service**|
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


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_agreement_salesorderdetail_Agreement](#BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement)
- [transactioncurrency_salesorderdetail](#BKMK_transactioncurrency_salesorderdetail)

### <a name="BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement"></a> msdyn_msdyn_agreement_salesorderdetail_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_salesorderdetail_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_salesorderdetail"></a> transactioncurrency_salesorderdetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_salesorderdetail](transactioncurrency.md#BKMK_transactioncurrency_salesorderdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

