---
title: "System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the System Job (AsyncOperation) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# System Job (AsyncOperation) table/entity reference

Process whose execution can proceed independently or in the background.

> [!NOTE]
> The Microsoft Dynamics 365 Sales System Job (AsyncOperation) table extends the [Microsoft Dataverse System Job (AsyncOperation) table](/power-apps/developer/data-platform/reference/entities/asyncoperation).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/asyncoperation#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_AsyncOperations"></a> sample_bankaccount_AsyncOperations

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_AsyncOperations](sample_bankaccount.md#BKMK_sample_bankaccount_AsyncOperations)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.asyncoperation?displayProperty=fullName>
