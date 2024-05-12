---
title: "Contact table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Contact table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Contact table/entity reference

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Contact table extends the [Microsoft Dataverse Contact table](/power-apps/developer/data-platform/reference/entities/contact).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_sample_BankAccountId"></a> sample_BankAccountId

|Property|Value|
|---|---|
|Description|**The bank account this contact has access to.**|
|DisplayName|**Bank Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sample_bankaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sample_bankaccount|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

### <a name="BKMK_sample_BankAccountIdName"></a> sample_BankAccountIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sample_bankaccountidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_BankAccount_Contacts"></a> sample_BankAccount_Contacts

One-To-Many Relationship: [sample_bankaccount sample_BankAccount_Contacts](sample_bankaccount.md#BKMK_sample_BankAccount_Contacts)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`sample_bankaccountid`|
|ReferencingEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|DenormalizedAttributeName|null|
|EntityKey|null|
|IsCustomizable||
|IsDenormalizedLookup|null|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_sample_BankAccount_Customer_Contact"></a> sample_BankAccount_Customer_Contact

Many-To-One Relationship: [sample_bankaccount sample_BankAccount_Customer_Contact](sample_bankaccount.md#BKMK_sample_BankAccount_Customer_Contact)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`sample_customerid`|
|ReferencedEntityNavigationPropertyName|`sample_BankAccount_Customer_Contact`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_sample_sample_BankAccounts_Contacts"></a> sample_sample_BankAccounts_Contacts

See [sample_bankaccount sample_sample_BankAccounts_Contacts Many-To-Many Relationship](sample_bankaccount.md#BKMK_sample_sample_BankAccounts_Contacts)

|Property|Value|
|--------|-----|
|IntersectEntityName|`sample_sample_bankaccounts_contacts`|
|IsCustomizable|True|
|SchemaName|`sample_sample_BankAccounts_Contacts`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`sample_sample_BankAccounts_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Contacts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.contact?displayProperty=fullName>
