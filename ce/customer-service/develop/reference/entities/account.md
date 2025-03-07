---
title: "Account table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Account table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Account table/entity reference (Microsoft Dynamics 365 Customer Service)

Business that represents a customer or potential customer. The company that is billed in business transactions.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Account table extends the [Microsoft Dynamics 365 Account table](/dynamics365/developer/reference/entities/account).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [account_msdyn_bookingalerts](#BKMK_account_msdyn_bookingalerts)
- [msdyn_account_msdyn_actual_AccountCustomer](#BKMK_msdyn_account_msdyn_actual_AccountCustomer)
- [msdyn_account_msdyn_actual_AccountVendor](#BKMK_msdyn_account_msdyn_actual_AccountVendor)

### <a name="BKMK_account_msdyn_bookingalerts"></a> account_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert account_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_account_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msdyn_account_msdyn_actual_AccountCustomer"></a> msdyn_account_msdyn_actual_AccountCustomer

Many-To-One Relationship: [msdyn_actual msdyn_account_msdyn_actual_AccountCustomer](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountCustomer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_accountcustomer`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_actual_AccountCustomer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_actual_AccountVendor"></a> msdyn_account_msdyn_actual_AccountVendor

Many-To-One Relationship: [msdyn_actual msdyn_account_msdyn_actual_AccountVendor](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_accountvendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_actual_AccountVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.account?displayProperty=fullName>
