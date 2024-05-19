---
title: "Account table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Account table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Account table/entity reference

Business that represents a customer or potential customer. The company that is billed in business transactions.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Account table extends the [Microsoft Dataverse Account table](/power-apps/developer/data-platform/reference/entities/account).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [sample_Account_BankAccounts](#BKMK_sample_Account_BankAccounts)
- [sample_BankAccount_Customer_Account](#BKMK_sample_BankAccount_Customer_Account)

### <a name="BKMK_sample_Account_BankAccounts"></a> sample_Account_BankAccounts

Many-To-One Relationship: [sample_bankaccount sample_Account_BankAccounts](sample_bankaccount.md#BKMK_sample_Account_BankAccounts)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`sample_relatedaccountid`|
|ReferencedEntityNavigationPropertyName|`sample_Account_BankAccounts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Related Bank Accounts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sample_BankAccount_Customer_Account"></a> sample_BankAccount_Customer_Account

Many-To-One Relationship: [sample_bankaccount sample_BankAccount_Customer_Account](sample_bankaccount.md#BKMK_sample_BankAccount_Customer_Account)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`sample_customerid`|
|ReferencedEntityNavigationPropertyName|`sample_BankAccount_Customer_Account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.account?displayProperty=fullName>
