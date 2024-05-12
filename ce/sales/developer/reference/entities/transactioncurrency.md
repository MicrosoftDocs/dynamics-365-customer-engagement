---
title: "Currency (TransactionCurrency) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Currency (TransactionCurrency) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Currency (TransactionCurrency) table/entity reference

Currency in which a financial transaction is carried out.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Currency (TransactionCurrency) table extends the [Microsoft Dataverse Currency (TransactionCurrency) table](/power-apps/developer/data-platform/reference/entities/transactioncurrency).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_sample_BankAccount"></a> TransactionCurrency_sample_BankAccount

Many-To-One Relationship: [sample_bankaccount TransactionCurrency_sample_BankAccount](sample_bankaccount.md#BKMK_TransactionCurrency_sample_BankAccount)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_sample_BankAccount`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.transactioncurrency?displayProperty=fullName>
