---
title: "Queue Item (QueueItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Queue Item (QueueItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Queue Item (QueueItem) table/entity reference (Microsoft Dynamics 365)

A specific item in a queue, such as a case record or an activity record.

> [!NOTE]
> The Microsoft Dynamics 365 Queue Item (QueueItem) table extends the [Microsoft Dataverse Queue Item (QueueItem) table](/power-apps/developer/data-platform/reference/entities/queueitem).


## Messages

The following table lists the messages for the Queue Item (QueueItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_TriggerARCWithRule`<br />Event: False |**msdyn_TriggerARCWithRule action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_skipursync](#BKMK_msdyn_skipursync)

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Liveworkstream this queue item belongs to**|
|DisplayName|**Live workstream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_skipursync"></a> msdyn_skipursync

|Property|Value|
|---|---|
|Description|**This attribute is used by Unified Routing system to decide whether to Skip Sync Call to Omnichannel Service or not.**|
|DisplayName|**msdyn_skipursync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skipursync`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`queueitem_msdyn_skipursync`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [ObjectId](#BKMK_ObjectId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|bulkoperation, campaignactivity, campaignresponse, incident, msdyn_copilottranscript, msdyn_iotalert, msdyn_liveconversation, msdyn_ocliveworkitem, msdyn_ocsession, msdyn_overflowactionconfig, msfp_alert, msfp_surveyinvite, msfp_surveyresponse, serviceappointment|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|112|**Case**|
|4214|**Service Activity**|
|4401|**Campaign Response**|
|4402|**Campaign Activity**|
|4406|**Quick Campaign**|
|10428|**IoT Alert**|
|10628|**Customer Voice alert**|
|10638|**Customer Voice survey invite**|
|10640|**Customer Voice survey response**|
|10690|**Overflow Action Config**|
|10714|**Ongoing conversation (Deprecated)**|
|10726|**Conversation**|
|10743|**Session**|
|10931|**Copilot Transcript**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [BulkOperation_QueueItem](#BKMK_BulkOperation_QueueItem)
- [CampaignActivity_QueueItem](#BKMK_CampaignActivity_QueueItem)
- [CampaignResponse_QueueItem](#BKMK_CampaignResponse_QueueItem)
- [Incident_QueueItem](#BKMK_Incident_QueueItem)
- [msdyn_copilottranscript_QueueItems](#BKMK_msdyn_copilottranscript_QueueItems)
- [msdyn_iotalert_QueueItems](#BKMK_msdyn_iotalert_QueueItems)
- [msdyn_liveworkstream_queueitem_liveworkstreamid](#BKMK_msdyn_liveworkstream_queueitem_liveworkstreamid)
- [msdyn_ocliveworkitem_QueueItems](#BKMK_msdyn_ocliveworkitem_QueueItems)
- [msdyn_ocsession_QueueItems](#BKMK_msdyn_ocsession_QueueItems)
- [msdyn_overflowactionconfig_QueueItems](#BKMK_msdyn_overflowactionconfig_QueueItems)
- [msfp_alert_QueueItems](#BKMK_msfp_alert_QueueItems)
- [msfp_surveyinvite_QueueItems](#BKMK_msfp_surveyinvite_QueueItems)
- [msfp_surveyresponse_QueueItems](#BKMK_msfp_surveyresponse_QueueItems)
- [ServiceAppointment_QueueItem](#BKMK_ServiceAppointment_QueueItem)

### <a name="BKMK_BulkOperation_QueueItem"></a> BulkOperation_QueueItem

One-To-Many Relationship: [bulkoperation BulkOperation_QueueItem](bulkoperation.md#BKMK_BulkOperation_QueueItem)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bulkoperation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignActivity_QueueItem"></a> CampaignActivity_QueueItem

One-To-Many Relationship: [campaignactivity CampaignActivity_QueueItem](campaignactivity.md#BKMK_CampaignActivity_QueueItem)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_QueueItem"></a> CampaignResponse_QueueItem

One-To-Many Relationship: [campaignresponse CampaignResponse_QueueItem](campaignresponse.md#BKMK_CampaignResponse_QueueItem)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Incident_QueueItem"></a> Incident_QueueItem

One-To-Many Relationship: [incident Incident_QueueItem](incident.md#BKMK_Incident_QueueItem)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_QueueItems"></a> msdyn_copilottranscript_QueueItems

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_QueueItems](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_QueueItems"></a> msdyn_iotalert_QueueItems

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_QueueItems](msdyn_iotalert.md#BKMK_msdyn_iotalert_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveworkstream_queueitem_liveworkstreamid"></a> msdyn_liveworkstream_queueitem_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_liveworkstream_queueitem_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_liveworkstream_queueitem_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_QueueItems"></a> msdyn_ocliveworkitem_QueueItems

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_QueueItems](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_QueueItems"></a> msdyn_ocsession_QueueItems

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_QueueItems](msdyn_ocsession.md#BKMK_msdyn_ocsession_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_overflowactionconfig_QueueItems"></a> msdyn_overflowactionconfig_QueueItems

One-To-Many Relationship: [msdyn_overflowactionconfig msdyn_overflowactionconfig_QueueItems](msdyn_overflowactionconfig.md#BKMK_msdyn_overflowactionconfig_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_overflowactionconfig`|
|ReferencedAttribute|`msdyn_overflowactionconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_overflowactionconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_QueueItems"></a> msfp_alert_QueueItems

One-To-Many Relationship: [msfp_alert msfp_alert_QueueItems](msfp_alert.md#BKMK_msfp_alert_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_QueueItems"></a> msfp_surveyinvite_QueueItems

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_QueueItems](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_QueueItems"></a> msfp_surveyresponse_QueueItems

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_QueueItems](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_ServiceAppointment_QueueItem"></a> ServiceAppointment_QueueItem

One-To-Many Relationship: [serviceappointment ServiceAppointment_QueueItem](serviceappointment.md#BKMK_ServiceAppointment_QueueItem)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_queueitem_msdyn_ocliveworkitem_queueitemid](#BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid)
- [msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject](#BKMK_msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject)
- [msdyn_unifiedroutingrun_queueitem_targetobject](#BKMK_msdyn_unifiedroutingrun_queueitem_targetobject)

### <a name="BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid"></a> msdyn_queueitem_msdyn_ocliveworkitem_queueitemid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_queueitem_msdyn_ocliveworkitem_queueitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_queueitem_msdyn_ocliveworkitem_queueitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_queueitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueitem_msdyn_ocliveworkitem_queueitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject"></a> msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject](msdyn_unifiedroutingdiagnostic.md#BKMK_msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_queueitem_msdyn_unifiedroutingdiagnostic_targetobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_queueitem_targetobject"></a> msdyn_unifiedroutingrun_queueitem_targetobject

Many-To-One Relationship: [msdyn_unifiedroutingrun msdyn_unifiedroutingrun_queueitem_targetobject](msdyn_unifiedroutingrun.md#BKMK_msdyn_unifiedroutingrun_queueitem_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_queueitem_targetobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queueitem?displayProperty=fullName>
