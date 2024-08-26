---
title: "Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Conversation (msdyn_ocliveworkitem) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Conversation (msdyn_ocliveworkitem) table/entity reference

Tracks the interaction between the agents and customer

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Conversation (msdyn_ocliveworkitem) table extends the [Microsoft Dynamics 365 Conversation (msdyn_ocliveworkitem) table](/dynamics365/developer/entities/msdyn_ocliveworkitem).


## Messages

The following table lists the messages for the Conversation (msdyn_ocliveworkitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CCaaS_AcceptConversation`<br />Event: False |**CCaaS_AcceptConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_AgentEndConversation`<br />Event: False |**CCaaS_AgentEndConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_AssignConversation`<br />Event: False |**CCaaS_AssignConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_CloseConsult`<br />Event: False |**CCaaS_CloseConsult action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ConversationTimeout`<br />Event: False |**CCaaS_ConversationTimeout action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndSecondaryChannel`<br />Event: False |**CCaaS_EndSecondaryChannel action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndSession`<br />Event: False |**CCaaS_EndSession action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ForceCloseConversation`<br />Event: False |**CCaaS_ForceCloseConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_GetAgentsForConsultAndTransfer`<br />Event: False |**CCaaS_GetAgentsForConsultAndTransfer function** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_GetClientLWIContext`<br />Event: False |**CCaaS_GetClientLWIContext function** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateAgentConsult`<br />Event: False |**CCaaS_InitiateAgentConsult action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateAgentConsultExternal`<br />Event: False |**CCaaS_InitiateAgentConsultExternal action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateAgentTransfer`<br />Event: False |**CCaaS_InitiateAgentTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateAgentTransferBySupervisor`<br />Event: False |**CCaaS_InitiateAgentTransferBySupervisor action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateAgentTransferExternal`<br />Event: False |**CCaaS_InitiateAgentTransferExternal action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateQueueAssignment`<br />Event: False |**CCaaS_InitiateQueueAssignment action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateQueueTransfer`<br />Event: False |**CCaaS_InitiateQueueTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_JoinConversation`<br />Event: False |**CCaaS_JoinConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_LeavePublicConsult`<br />Event: False |**CCaaS_LeavePublicConsult action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_MonitorConversation`<br />Event: False |**CCaaS_MonitorConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_PickConversation`<br />Event: False |**CCaaS_PickConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_RaiseSecondaryChannelEvent`<br />Event: False |**CCaaS_RaiseSecondaryChannelEvent action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_RejectConversation`<br />Event: False |**CCaaS_RejectConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_RejoinConversation`<br />Event: False |**CCaaS_RejoinConversation action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StartSecondaryChannel`<br />Event: False |**CCaaS_StartSecondaryChannel action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/entities/msdyn_ocliveworkitem#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msdyn_ocliveworkitems](#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)
- [msdyn_bookingrule_msdyn_ocliveworkitems](#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)
- [msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)
- [msdyn_resourceterritory_msdyn_ocliveworkitems](#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)
- [msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)
- [msdyn_timegroup_msdyn_ocliveworkitems](#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)
- [msdyn_timegroupdetail_msdyn_ocliveworkitems](#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems"></a> msdyn_bookingalertstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocliveworkitems](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocliveworkitems"></a> msdyn_bookingrule_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocliveworkitems](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid"></a> msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems"></a> msdyn_resourceterritory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocliveworkitems](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems"></a> msdyn_systemuserschedulersetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocliveworkitems"></a> msdyn_timegroup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocliveworkitems](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems"></a> msdyn_timegroupdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocliveworkitems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

