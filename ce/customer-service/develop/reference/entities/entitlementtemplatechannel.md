---
title: "Entitlement Template Channel (EntitlementTemplateChannel) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Entitlement Template Channel (EntitlementTemplateChannel) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Entitlement Template Channel (EntitlementTemplateChannel) table/entity reference

Contains predefined support terms for a channel to create entitlements for customers.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Entitlement Template Channel (EntitlementTemplateChannel) table extends the [Microsoft Dynamics 365 Entitlement Template Channel (EntitlementTemplateChannel) table](/dynamics365/developer/entities/entitlementtemplatechannel).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

Changes from [ExchangeRate (Microsoft Dynamics 365)](/dynamics365/developer/entities/entitlementtemplatechannel#BKMK_ExchangeRate)

|Property|Value|
|---|---|
|MinValue|1E-12|
|Precision|12|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_entitlementtemplatechannel"></a> TransactionCurrency_entitlementtemplatechannel

One-To-Many Relationship: [transactioncurrency TransactionCurrency_entitlementtemplatechannel](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplatechannel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

