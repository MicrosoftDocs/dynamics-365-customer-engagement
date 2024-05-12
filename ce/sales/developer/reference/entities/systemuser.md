---
title: "User (SystemUser) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the User (SystemUser) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# User (SystemUser) table/entity reference

Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.

> [!NOTE]
> The Microsoft Dynamics 365 Sales User (SystemUser) table extends the [Microsoft Dataverse User (SystemUser) table](/power-apps/developer/data-platform/reference/entities/systemuser).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_sample_bankaccount_createdby](#BKMK_lk_sample_bankaccount_createdby)
- [lk_sample_bankaccount_createdonbehalfby](#BKMK_lk_sample_bankaccount_createdonbehalfby)
- [lk_sample_bankaccount_modifiedby](#BKMK_lk_sample_bankaccount_modifiedby)
- [lk_sample_bankaccount_modifiedonbehalfby](#BKMK_lk_sample_bankaccount_modifiedonbehalfby)
- [user_sample_bankaccount](#BKMK_user_sample_bankaccount)

### <a name="BKMK_lk_sample_bankaccount_createdby"></a> lk_sample_bankaccount_createdby

Many-To-One Relationship: [sample_bankaccount lk_sample_bankaccount_createdby](sample_bankaccount.md#BKMK_lk_sample_bankaccount_createdby)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_sample_bankaccount_createdby`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_sample_bankaccount_createdonbehalfby"></a> lk_sample_bankaccount_createdonbehalfby

Many-To-One Relationship: [sample_bankaccount lk_sample_bankaccount_createdonbehalfby](sample_bankaccount.md#BKMK_lk_sample_bankaccount_createdonbehalfby)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_sample_bankaccount_createdonbehalfby`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_sample_bankaccount_modifiedby"></a> lk_sample_bankaccount_modifiedby

Many-To-One Relationship: [sample_bankaccount lk_sample_bankaccount_modifiedby](sample_bankaccount.md#BKMK_lk_sample_bankaccount_modifiedby)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_sample_bankaccount_modifiedby`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_sample_bankaccount_modifiedonbehalfby"></a> lk_sample_bankaccount_modifiedonbehalfby

Many-To-One Relationship: [sample_bankaccount lk_sample_bankaccount_modifiedonbehalfby](sample_bankaccount.md#BKMK_lk_sample_bankaccount_modifiedonbehalfby)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_sample_bankaccount_modifiedonbehalfby`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_sample_bankaccount"></a> user_sample_bankaccount

Many-To-One Relationship: [sample_bankaccount user_sample_bankaccount](sample_bankaccount.md#BKMK_user_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_sample_bankaccount`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.systemuser?displayProperty=fullName>
