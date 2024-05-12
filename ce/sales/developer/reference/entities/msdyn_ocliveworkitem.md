---
title: "Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Conversation (msdyn_ocliveworkitem) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation (msdyn_ocliveworkitem) table/entity reference

Tracks the interaction between the agents and customer

> [!NOTE]
> The Microsoft Dynamics 365 Sales Conversation (msdyn_ocliveworkitem) table extends the [Microsoft Dynamics 365 Conversation (msdyn_ocliveworkitem) table](/dynamics365/developer/reference/dataverse/entities/msdyn_ocliveworkitem).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_averageresponsetimeinmsadjforoh](#BKMK_msdyn_averageresponsetimeinmsadjforoh)
- [msdyn_firstresponsetimeinmsadjforoh](#BKMK_msdyn_firstresponsetimeinmsadjforoh)

### <a name="BKMK_msdyn_averageresponsetimeinmsadjforoh"></a> msdyn_averageresponsetimeinmsadjforoh

|Property|Value|
|---|---|
|Description|**Average time it took to respond to customer, excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Conversation average response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averageresponsetimeinmsadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_firstresponsetimeinmsadjforoh"></a> msdyn_firstresponsetimeinmsadjforoh

|Property|Value|
|---|---|
|Description|**Time it took to respond to customer, excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Conversation first response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstresponsetimeinmsadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|


## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msdyn_ocliveworkitem#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_msdyn_ocliveworkitems"></a> sample_bankaccount_msdyn_ocliveworkitems

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_msdyn_ocliveworkitems](sample_bankaccount.md#BKMK_sample_bankaccount_msdyn_ocliveworkitems)

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

