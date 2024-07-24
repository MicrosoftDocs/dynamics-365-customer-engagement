---
title: "Multistep Form Session (adx_webformsession) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Multistep Form Session (adx_webformsession) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Multistep Form Session (adx_webformsession) table/entity reference

Serves as a mechanism to log the occurrence of an incomplete multistep form entry for a given user so they can return and complete it later.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Multistep Form Session (adx_webformsession) table extends the [Microsoft Dataverse Multistep Form Session (adx_webformsession) table](/power-apps/developer/data-platform/reference/entities/adx_webformsession).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_currentwebformstep](#BKMK_adx_currentwebformstep)
- [adx_quoteid](#BKMK_adx_quoteid)
- [adx_webform](#BKMK_adx_webform)

### <a name="BKMK_adx_currentwebformstep"></a> adx_currentwebformstep

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Form Step associated with Web Form Session.**|
|DisplayName|**Current Form Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_currentwebformstep`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_webformstep|

### <a name="BKMK_adx_quoteid"></a> adx_quoteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Quote associated with Multistep Form Session.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_quoteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_adx_webform"></a> adx_webform

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Form associated with Web Form Session.**|
|DisplayName|**Multistep Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webform`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_webform|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [adx_contact](#BKMK_adx_contact)
- [adx_systemuser](#BKMK_adx_systemuser)

### <a name="BKMK_adx_contact"></a> adx_contact

Changes from [adx_contact (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_webformsession#BKMK_adx_contact)

|Property|Value|
|---|---|
|Description|Unique identifier for Contact associated with Web Form Session.|


### <a name="BKMK_adx_systemuser"></a> adx_systemuser

Changes from [adx_systemuser (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_webformsession#BKMK_adx_systemuser)

|Property|Value|
|---|---|
|Description|Unique identifier for User associated with Web Form Session.|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_webformsession_currentwebformstep](#BKMK_adx_webformsession_currentwebformstep)
- [adx_webformsession_quote](#BKMK_adx_webformsession_quote)
- [adx_webformsession_webform](#BKMK_adx_webformsession_webform)

### <a name="BKMK_adx_webformsession_currentwebformstep"></a> adx_webformsession_currentwebformstep

One-To-Many Relationship: [adx_webformstep adx_webformsession_currentwebformstep](adx_webformstep.md#BKMK_adx_webformsession_currentwebformstep)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_currentwebformstep`|
|ReferencingEntityNavigationPropertyName|`adx_currentwebformstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformsession_quote"></a> adx_webformsession_quote

One-To-Many Relationship: [quote adx_webformsession_quote](quote.md#BKMK_adx_webformsession_quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`adx_quoteid`|
|ReferencingEntityNavigationPropertyName|`adx_quoteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformsession_webform"></a> adx_webformsession_webform

One-To-Many Relationship: [adx_webform adx_webformsession_webform](adx_webform.md#BKMK_adx_webformsession_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webform`|
|ReferencedAttribute|`adx_webformid`|
|ReferencingAttribute|`adx_webform`|
|ReferencingEntityNavigationPropertyName|`adx_webform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_webformsession?displayProperty=fullName>
