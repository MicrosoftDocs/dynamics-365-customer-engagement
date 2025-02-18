---
title: "Teams chat (chat) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Teams chat (chat) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Teams chat (chat) table/entity reference (Microsoft Dynamics 365 Customer Service)

For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Teams chat (chat) table extends the [Microsoft Dynamics 365 Teams chat (chat) table](/dynamics365/developer/reference/entities/chat).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_chats](#BKMK_msdyn_bookingalertstatus_chats)
- [msdyn_bookingrule_chats](#BKMK_msdyn_bookingrule_chats)
- [msdyn_resourceterritory_chats](#BKMK_msdyn_resourceterritory_chats)
- [msdyn_systemuserschedulersetting_chats](#BKMK_msdyn_systemuserschedulersetting_chats)
- [msdyn_timegroup_chats](#BKMK_msdyn_timegroup_chats)
- [msdyn_timegroupdetail_chats](#BKMK_msdyn_timegroupdetail_chats)

### <a name="BKMK_msdyn_bookingalertstatus_chats"></a> msdyn_bookingalertstatus_chats

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_chats](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_chats"></a> msdyn_bookingrule_chats

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_chats](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_chats"></a> msdyn_resourceterritory_chats

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_chats](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_chats"></a> msdyn_systemuserschedulersetting_chats

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_chats](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_chats"></a> msdyn_timegroup_chats

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_chats](msdyn_timegroup.md#BKMK_msdyn_timegroup_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_chats"></a> msdyn_timegroupdetail_chats

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_chats](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.chat?displayProperty=fullName>
