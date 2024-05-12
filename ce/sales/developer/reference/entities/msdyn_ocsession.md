---
title: "Session (msdyn_ocsession) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Session (msdyn_ocsession) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Session (msdyn_ocsession) table/entity reference

Session for interacting with a customer

> [!NOTE]
> The Microsoft Dynamics 365 Sales Session (msdyn_ocsession) table extends the [Microsoft Dynamics 365 Session (msdyn_ocsession) table](/dynamics365/developer/reference/dataverse/entities/msdyn_ocsession).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msdyn_ocsession#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_msdyn_ocsessions"></a> sample_bankaccount_msdyn_ocsessions

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_msdyn_ocsessions](sample_bankaccount.md#BKMK_sample_bankaccount_msdyn_ocsessions)

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

