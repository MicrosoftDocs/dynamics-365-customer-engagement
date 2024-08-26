---
title: "AIPluginOperation table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AIPluginOperation table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AIPluginOperation table/entity reference

AIPluginOperations component

> [!NOTE]
> The Microsoft Dynamics 365 AIPluginOperation table extends the [Microsoft Dataverse AIPluginOperation table](/power-apps/developer/data-platform/reference/entities/aipluginoperation).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [connector](#BKMK_connector)
- [SharedConnector](#BKMK_SharedConnector)

### <a name="BKMK_connector"></a> connector

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connector**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`connector`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|connector|

### <a name="BKMK_SharedConnector"></a> SharedConnector

|Property|Value|
|---|---|
|Description|**SharedConnector Description**|
|DisplayName|**SharedConnector**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sharedconnector`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_AIPluginOperation_connector_connector"></a> AIPluginOperation_connector_connector

One-To-Many Relationship: [connector AIPluginOperation_connector_connector](connector.md#BKMK_AIPluginOperation_connector_connector)

|Property|Value|
|---|---|
|ReferencedEntity|`connector`|
|ReferencedAttribute|`connectorid`|
|ReferencingAttribute|`connector`|
|ReferencingEntityNavigationPropertyName|`connector`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.aipluginoperation?displayProperty=fullName>
