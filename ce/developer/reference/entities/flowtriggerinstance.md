---
title: "Flow Trigger Instance (flowtriggerinstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Flow Trigger Instance (flowtriggerinstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Flow Trigger Instance (flowtriggerinstance) table/entity reference (Microsoft Dynamics 365)

This table contains records of flow trigger instances

> [!NOTE]
> The Microsoft Dynamics 365 Flow Trigger Instance (flowtriggerinstance) table extends the [Microsoft Dataverse Flow Trigger Instance (flowtriggerinstance) table](/power-apps/developer/data-platform/reference/entities/flowtriggerinstance).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_connectionreferenceid"></a> connectionreferenceid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connection Reference Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`connectionreferenceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|connectionreference|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_flowtriggerinstance_connectionreferenceid_connectionreference"></a> flowtriggerinstance_connectionreferenceid_connectionreference

One-To-Many Relationship: [connectionreference flowtriggerinstance_connectionreferenceid_connectionreference](connectionreference.md#BKMK_flowtriggerinstance_connectionreferenceid_connectionreference)

|Property|Value|
|---|---|
|ReferencedEntity|`connectionreference`|
|ReferencedAttribute|`connectionreferenceid`|
|ReferencingAttribute|`connectionreferenceid`|
|ReferencingEntityNavigationPropertyName|`connectionreferenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.flowtriggerinstance?displayProperty=fullName>
