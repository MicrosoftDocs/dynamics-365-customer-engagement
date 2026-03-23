---
title: "Connection table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Connection table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Connection table/entity reference (Microsoft Dynamics 365 Customer Service)

Relationship between two entities.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Connection table extends the [Microsoft Dynamics 365 Connection table](/dynamics365/developer/reference/entities/connection).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Record1Id](#BKMK_Record1Id)
- [Record1ObjectTypeCode](#BKMK_Record1ObjectTypeCode)
- [Record2Id](#BKMK_Record2Id)
- [Record2ObjectTypeCode](#BKMK_Record2ObjectTypeCode)

### <a name="BKMK_Record1Id"></a> Record1Id

Changes from [Record1Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1Id)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_ocoutboundmessage, msdyn_ocvoicemail, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


### <a name="BKMK_Record1ObjectTypeCode"></a> Record1ObjectTypeCode

Changes from [Record1ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1ObjectTypeCode)

#### Record1ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10410|**Invitation**|
|10411|**Invite Redemption**|
|10430|**Publishing State Transition Rule**|
|10432|**Shortcut**|
|10444|**Website**|
|10489|**Customer Asset**|
|10511|**IoT Alert**|
|10512|**IoT Device**|
|10513|**IoT Device Category**|
|10514|**IoT Device Command**|
|10518|**IoT Device Registration History**|
|10719|**Profile Album**|
|10724|**Customer Voice alert**|
|10739|**Customer Voice survey invite**|
|10742|**Customer Voice survey response**|
|10828|**Ongoing conversation (Deprecated)**|
|10840|**Conversation**|
|10857|**Session**|
|11011|**Sequence**|
|11013|**Sequence Target**|
|11025|**Assignment Rule**|
|11028|**Assignment Map**|
|11035|**Insight**|
|11044|**Suggestion Principal Object Access**|
|11125|**Copilot Transcript**|
|11365|**Booking Alert**|
|11366|**Booking Alert Status**|
|11368|**Booking Rule**|
|11379|**Resource Territory**|
|11382|**System User Scheduler Setting**|
|11383|**Fulfillment Preference**|
|11384|**Time Group Detail**|
|11452|**Voicemail**|
|11466|**Outbound message**|

### <a name="BKMK_Record2Id"></a> Record2Id

Changes from [Record2Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2Id)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_ocoutboundmessage, msdyn_ocvoicemail, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


### <a name="BKMK_Record2ObjectTypeCode"></a> Record2ObjectTypeCode

Changes from [Record2ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2ObjectTypeCode)

#### Record2ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10410|**Invitation**|
|10411|**Invite Redemption**|
|10430|**Publishing State Transition Rule**|
|10432|**Shortcut**|
|10444|**Website**|
|10489|**Customer Asset**|
|10511|**IoT Alert**|
|10512|**IoT Device**|
|10513|**IoT Device Category**|
|10514|**IoT Device Command**|
|10518|**IoT Device Registration History**|
|10719|**Profile Album**|
|10724|**Customer Voice alert**|
|10739|**Customer Voice survey invite**|
|10742|**Customer Voice survey response**|
|10828|**Ongoing conversation (Deprecated)**|
|10840|**Conversation**|
|10857|**Session**|
|11011|**Sequence**|
|11013|**Sequence Target**|
|11025|**Assignment Rule**|
|11028|**Assignment Map**|
|11035|**Insight**|
|11044|**Suggestion Principal Object Access**|
|11125|**Copilot Transcript**|
|11365|**Booking Alert**|
|11366|**Booking Alert Status**|
|11368|**Booking Rule**|
|11379|**Resource Territory**|
|11382|**System User Scheduler Setting**|
|11383|**Fulfillment Preference**|
|11384|**Time Group Detail**|
|11452|**Voicemail**|
|11466|**Outbound message**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalert_connections1](#BKMK_msdyn_bookingalert_connections1)
- [msdyn_bookingalert_connections2](#BKMK_msdyn_bookingalert_connections2)
- [msdyn_bookingalertstatus_connections1](#BKMK_msdyn_bookingalertstatus_connections1)
- [msdyn_bookingalertstatus_connections2](#BKMK_msdyn_bookingalertstatus_connections2)
- [msdyn_bookingrule_connections1](#BKMK_msdyn_bookingrule_connections1)
- [msdyn_bookingrule_connections2](#BKMK_msdyn_bookingrule_connections2)
- [msdyn_ocoutboundmessage_connections1](#BKMK_msdyn_ocoutboundmessage_connections1)
- [msdyn_ocoutboundmessage_connections2](#BKMK_msdyn_ocoutboundmessage_connections2)
- [msdyn_ocvoicemail_connections1](#BKMK_msdyn_ocvoicemail_connections1)
- [msdyn_ocvoicemail_connections2](#BKMK_msdyn_ocvoicemail_connections2)
- [msdyn_resourceterritory_connections1](#BKMK_msdyn_resourceterritory_connections1)
- [msdyn_resourceterritory_connections2](#BKMK_msdyn_resourceterritory_connections2)
- [msdyn_systemuserschedulersetting_connections1](#BKMK_msdyn_systemuserschedulersetting_connections1)
- [msdyn_systemuserschedulersetting_connections2](#BKMK_msdyn_systemuserschedulersetting_connections2)
- [msdyn_timegroup_connections1](#BKMK_msdyn_timegroup_connections1)
- [msdyn_timegroup_connections2](#BKMK_msdyn_timegroup_connections2)
- [msdyn_timegroupdetail_connections1](#BKMK_msdyn_timegroupdetail_connections1)
- [msdyn_timegroupdetail_connections2](#BKMK_msdyn_timegroupdetail_connections2)

### <a name="BKMK_msdyn_bookingalert_connections1"></a> msdyn_bookingalert_connections1

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_connections1](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_connections2"></a> msdyn_bookingalert_connections2

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_connections2](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_connections1"></a> msdyn_bookingalertstatus_connections1

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_connections1](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_connections2"></a> msdyn_bookingalertstatus_connections2

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_connections2](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_connections1"></a> msdyn_bookingrule_connections1

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_connections1](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_connections2"></a> msdyn_bookingrule_connections2

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_connections2](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections1"></a> msdyn_ocoutboundmessage_connections1

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_connections1](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections2"></a> msdyn_ocoutboundmessage_connections2

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_connections2](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_connections1"></a> msdyn_ocvoicemail_connections1

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_connections1](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_connections2"></a> msdyn_ocvoicemail_connections2

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_connections2](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_connections1"></a> msdyn_resourceterritory_connections1

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_connections1](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_connections2"></a> msdyn_resourceterritory_connections2

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_connections2](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_connections1"></a> msdyn_systemuserschedulersetting_connections1

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_connections1](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_connections2"></a> msdyn_systemuserschedulersetting_connections2

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_connections2](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_connections1"></a> msdyn_timegroup_connections1

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_connections1](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_connections2"></a> msdyn_timegroup_connections2

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_connections2](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_connections1"></a> msdyn_timegroupdetail_connections1

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_connections1](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_connections2"></a> msdyn_timegroupdetail_connections2

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_connections2](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connection?displayProperty=fullName>
