---
title: "Owner table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Owner table/entity reference

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Owner table extends the [Microsoft Dataverse Owner table](/power-apps/developer/data-platform/reference/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_owner_sample_bankaccount"></a> owner_sample_bankaccount

Many-To-One Relationship: [sample_bankaccount owner_sample_bankaccount](sample_bankaccount.md#BKMK_owner_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_sample_bankaccount`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

