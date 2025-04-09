---
title: "Currency (TransactionCurrency) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Currency (TransactionCurrency) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Currency (TransactionCurrency) table/entity reference (Microsoft Dynamics 365 Customer Service)

Currency in which a financial transaction is carried out.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Currency (TransactionCurrency) table extends the [Microsoft Dynamics 365 Currency (TransactionCurrency) table](/dynamics365/developer/reference/entities/transactioncurrency).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)
- [TransactionCurrency_msdyn_actual](#BKMK_TransactionCurrency_msdyn_actual)

### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_transactioncurrency_transactioncurrencyid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

Many-To-One Relationship: [msdyn_actual TransactionCurrency_msdyn_actual](msdyn_actual.md#BKMK_TransactionCurrency_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.transactioncurrency?displayProperty=fullName>
