---
title: "Overflow Action Config (msdyn_overflowactionconfig) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Overflow Action Config (msdyn_overflowactionconfig) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Overflow Action Config (msdyn_overflowactionconfig) table/entity reference (Microsoft Dynamics 365 Field Service)

Overflow action configurations.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Overflow Action Config (msdyn_overflowactionconfig) table extends the [Microsoft Dynamics 365 Overflow Action Config (msdyn_overflowactionconfig) table](/dynamics365/developer/reference/entities/msdyn_overflowactionconfig).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_directcallbackoutboundprofile](#BKMK_msdyn_directcallbackoutboundprofile)
- [msdyn_proactive_callback_profileId](#BKMK_msdyn_proactive_callback_profileId)

### <a name="BKMK_msdyn_directcallbackoutboundprofile"></a> msdyn_directcallbackoutboundprofile

|Property|Value|
|---|---|
|Description|**Direct Callback Outbound Profile**|
|DisplayName|**Direct Callback Outbound Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_directcallbackoutboundprofile`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocvoicechannelsetting|

### <a name="BKMK_msdyn_proactive_callback_profileId"></a> msdyn_proactive_callback_profileId

|Property|Value|
|---|---|
|Description|**Lookup to the Callback Profile associated with overflow action config**|
|DisplayName|**Proactive Callback Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_callback_profileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_proactive_callback_profile|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile)
- [msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile](#BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile)

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_overflowactionconfig_directcallbackoutboundprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`msdyn_directcallbackoutboundprofile`|
|ReferencingEntityNavigationPropertyName|`msdyn_directcallbackoutboundprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile"></a> msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile

One-To-Many Relationship: [msdyn_proactive_callback_profile msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile](msdyn_proactive_callback_profile.md#BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_callback_profile`|
|ReferencedAttribute|`msdyn_proactive_callback_profileid`|
|ReferencingAttribute|`msdyn_proactive_callback_profileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_proactive_callback_profileId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

