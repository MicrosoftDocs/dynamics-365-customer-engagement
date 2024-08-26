---
title: "Entitlement Template (EntitlementTemplate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Entitlement Template (EntitlementTemplate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Entitlement Template (EntitlementTemplate) table/entity reference

Contains predefined customer support terms that can be used to created entitlements for customers.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Entitlement Template (EntitlementTemplate) table extends the [Microsoft Dynamics 365 Entitlement Template (EntitlementTemplate) table](/dynamics365/developer/entities/entitlementtemplate).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [entitytype](#BKMK_entitytype)
- [ExchangeRate](#BKMK_ExchangeRate)

### <a name="BKMK_entitytype"></a> entitytype

Changes from [entitytype (Microsoft Dynamics 365)](/dynamics365/developer/entities/entitlementtemplate#BKMK_entitytype)

#### entitytype Choices/Options

|Value|Label|
|---|---|
|192350000|**Work Order**|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

Changes from [ExchangeRate (Microsoft Dynamics 365)](/dynamics365/developer/entities/entitlementtemplate#BKMK_ExchangeRate)

|Property|Value|
|---|---|
|MinValue|1E-12|
|Precision|12|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

One-To-Many Relationship: [transactioncurrency TransactionCurrency_entitlementtemplate](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplate)

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

### <a name="BKMK_entitlementtemplate_msdyn_bookingalerts"></a> entitlementtemplate_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert entitlementtemplate_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlementtemplate_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

