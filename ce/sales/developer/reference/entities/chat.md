---
title: "Teams chat (chat) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Teams chat (chat) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Teams chat (chat) table/entity reference

For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat

> [!NOTE]
> The Microsoft Dynamics 365 Sales Teams chat (chat) table extends the [Microsoft Dataverse Teams chat (chat) table](/power-apps/developer/data-platform/reference/entities/chat).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_chats"></a> sample_bankaccount_chats

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_chats](sample_bankaccount.md#BKMK_sample_bankaccount_chats)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|
|DenormalizedAttributeName|null|
|EntityKey|null|
|IsCustomizable||
|IsDenormalizedLookup|null|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.chat?displayProperty=fullName>
