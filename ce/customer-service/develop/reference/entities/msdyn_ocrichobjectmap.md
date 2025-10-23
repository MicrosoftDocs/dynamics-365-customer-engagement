---
title: "Rich object map (msdyn_ocrichobjectmap) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Rich object map (msdyn_ocrichobjectmap) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Rich object map (msdyn_ocrichobjectmap) table/entity reference (Microsoft Dynamics 365 Customer Service)

Rich objects map for Omnichannel integration

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Rich object map (msdyn_ocrichobjectmap) table extends the [Microsoft Dynamics 365 Rich object map (msdyn_ocrichobjectmap) table](/dynamics365/developer/reference/entities/msdyn_ocrichobjectmap).


## Properties

The following table lists selected properties for the Rich object map (msdyn_ocrichobjectmap) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Rich object map** |
| **DisplayCollectionName** | **Rich objects map** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_ocapplepayid"></a> msdyn_ocapplepayid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Apple Pay Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocapplepayid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocapplepay|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid"></a> msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid

One-To-Many Relationship: [msdyn_ocapplepay msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid](msdyn_ocapplepay.md#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`msdyn_ocapplepayid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocapplepayid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

