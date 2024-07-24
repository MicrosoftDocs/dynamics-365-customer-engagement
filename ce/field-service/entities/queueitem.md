---
title: "Queue Item (QueueItem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Queue Item (QueueItem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Queue Item (QueueItem) table/entity reference

A specific item in a queue, such as a case record or an activity record.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Queue Item (QueueItem) table extends the [Microsoft Dataverse Queue Item (QueueItem) table](/power-apps/developer/data-platform/reference/entities/queueitem).



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

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [ObjectId](#BKMK_ObjectId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|adx_alertsubscription|


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
|10166|**Teams chat**|
|10182|**Knowledge Article Template**|
|10287|**Invite Redemption**|
|10288|**Portal Comment**|
|10370|**IoT Alert**|
|10568|**Customer Voice alert**|
|10578|**Customer Voice survey invite**|
|10580|**Customer Voice survey response**|
|10616|**Copilot Transcript**|
|10640|**Overflow Action Config**|
|10664|**Ongoing conversation (Deprecated)**|
|10676|**Conversation**|
|10693|**Session**|
|10972|**Booking Alert**|
|10989|**Fulfillment Preference**|
|10990|**Time Group Detail**|
|11021|**Agreement Booking Date**|
|11026|**Agreement Booking Setup**|
|11027|**Agreement Invoice Date**|
|11029|**Agreement Invoice Setup**|
|11049|**Inventory Adjustment**|
|11052|**Inventory Transfer**|
|11083|**Work Order**|
|11086|**Work Order Incident**|
|11089|**Work Order Service**|
|11090|**Work Order Service Task**|
|11141|**Alert Subscription**|
|11301|**Outbound message**|
|11308|**Voicemail**|
|11377|**Appointment activity marketing template**|
|11414|**Marketing activity**|
|11415|**Phone-call activity marketing template**|
|11421|**Task activity marketing template**|
|11603|**inMail**|
|11604|**Message**|
|11605|**Smart Links Content Viewed**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_alertsubscription_QueueItems](#BKMK_adx_alertsubscription_QueueItems)
- [BulkOperation_QueueItem](#BKMK_BulkOperation_QueueItem)
- [CampaignActivity_QueueItem](#BKMK_CampaignActivity_QueueItem)
- [CampaignResponse_QueueItem](#BKMK_CampaignResponse_QueueItem)
- [Incident_QueueItem](#BKMK_Incident_QueueItem)
- [li_inmail_QueueItems](#BKMK_li_inmail_QueueItems)
- [li_message_QueueItems](#BKMK_li_message_QueueItems)
- [li_pointdrivepresentationviewed_QueueItems](#BKMK_li_pointdrivepresentationviewed_QueueItems)
- [msdyn_agreementbookingdate_QueueItems](#BKMK_msdyn_agreementbookingdate_QueueItems)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementinvoicedate_QueueItems](#BKMK_msdyn_agreementinvoicedate_QueueItems)
- [msdyn_agreementinvoicesetup_QueueItems](#BKMK_msdyn_agreementinvoicesetup_QueueItems)
- [msdyn_bookingalert_QueueItems](#BKMK_msdyn_bookingalert_QueueItems)
- [msdyn_copilottranscript_QueueItems](#BKMK_msdyn_copilottranscript_QueueItems)
- [msdyn_inventoryadjustment_QueueItems](#BKMK_msdyn_inventoryadjustment_QueueItems)
- [msdyn_inventorytransfer_QueueItems](#BKMK_msdyn_inventorytransfer_QueueItems)
- [msdyn_iotalert_QueueItems](#BKMK_msdyn_iotalert_QueueItems)
- [msdyn_liveconversation_QueueItems](#BKMK_msdyn_liveconversation_QueueItems)
- [msdyn_liveworkstream_queueitem_liveworkstreamid](#BKMK_msdyn_liveworkstream_queueitem_liveworkstreamid)
- [msdyn_ocliveworkitem_QueueItems](#BKMK_msdyn_ocliveworkitem_QueueItems)
- [msdyn_ocoutboundmessage_QueueItems](#BKMK_msdyn_ocoutboundmessage_QueueItems)
- [msdyn_ocsession_QueueItems](#BKMK_msdyn_ocsession_QueueItems)
- [msdyn_ocvoicemail_QueueItems](#BKMK_msdyn_ocvoicemail_QueueItems)
- [msdyn_overflowactionconfig_QueueItems](#BKMK_msdyn_overflowactionconfig_QueueItems)
- [msdyn_timegroup_QueueItems](#BKMK_msdyn_timegroup_QueueItems)
- [msdyn_timegroupdetail_QueueItems](#BKMK_msdyn_timegroupdetail_QueueItems)
- [msdyn_workorder_QueueItems](#BKMK_msdyn_workorder_QueueItems)
- [msdyn_workorderincident_QueueItems](#BKMK_msdyn_workorderincident_QueueItems)
- [msdyn_workorderservice_QueueItems](#BKMK_msdyn_workorderservice_QueueItems)
- [msdyn_workorderservicetask_QueueItems](#BKMK_msdyn_workorderservicetask_QueueItems)
- [msdyncrm_appointmentactivitymarketingtemplate_QueueItems](#BKMK_msdyncrm_appointmentactivitymarketingtemplate_QueueItems)
- [msdyncrm_mktactivity_QueueItems](#BKMK_msdyncrm_mktactivity_QueueItems)
- [msdyncrm_phonecallactivitymarketingtemplate_QueueItems](#BKMK_msdyncrm_phonecallactivitymarketingtemplate_QueueItems)
- [msdyncrm_taskactivitymarketingtemplate_QueueItems](#BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems)
- [msfp_alert_QueueItems](#BKMK_msfp_alert_QueueItems)
- [msfp_surveyinvite_QueueItems](#BKMK_msfp_surveyinvite_QueueItems)
- [msfp_surveyresponse_QueueItems](#BKMK_msfp_surveyresponse_QueueItems)
- [ServiceAppointment_QueueItem](#BKMK_ServiceAppointment_QueueItem)

### <a name="BKMK_adx_alertsubscription_QueueItems"></a> adx_alertsubscription_QueueItems

One-To-Many Relationship: [adx_alertsubscription adx_alertsubscription_QueueItems](adx_alertsubscription.md#BKMK_adx_alertsubscription_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_alertsubscription`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_alertsubscription`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

### <a name="BKMK_li_inmail_QueueItems"></a> li_inmail_QueueItems

One-To-Many Relationship: [li_inmail li_inmail_QueueItems](li_inmail.md#BKMK_li_inmail_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`li_inmail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_inmail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_message_QueueItems"></a> li_message_QueueItems

One-To-Many Relationship: [li_message li_message_QueueItems](li_message.md#BKMK_li_message_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`li_message`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_message`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_QueueItems"></a> li_pointdrivepresentationviewed_QueueItems

One-To-Many Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_QueueItems](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`li_pointdrivepresentationviewed`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_QueueItems"></a> msdyn_agreementbookingdate_QueueItems

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_QueueItems](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_QueueItems](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_QueueItems"></a> msdyn_agreementinvoicedate_QueueItems

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_QueueItems](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_QueueItems"></a> msdyn_agreementinvoicesetup_QueueItems

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_QueueItems](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_QueueItems"></a> msdyn_bookingalert_QueueItems

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_QueueItems](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
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

### <a name="BKMK_msdyn_inventoryadjustment_QueueItems"></a> msdyn_inventoryadjustment_QueueItems

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_QueueItems](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_QueueItems"></a> msdyn_inventorytransfer_QueueItems

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_QueueItems](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventorytransfer`|
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

### <a name="BKMK_msdyn_liveconversation_QueueItems"></a> msdyn_liveconversation_QueueItems

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_QueueItems](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_liveconversation`|
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

### <a name="BKMK_msdyn_ocoutboundmessage_QueueItems"></a> msdyn_ocoutboundmessage_QueueItems

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_QueueItems](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocoutboundmessage`|
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

### <a name="BKMK_msdyn_ocvoicemail_QueueItems"></a> msdyn_ocvoicemail_QueueItems

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_QueueItems](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoicemail`|
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

### <a name="BKMK_msdyn_timegroup_QueueItems"></a> msdyn_timegroup_QueueItems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_QueueItems](msdyn_timegroup.md#BKMK_msdyn_timegroup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_QueueItems"></a> msdyn_timegroupdetail_QueueItems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_QueueItems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_QueueItems"></a> msdyn_workorder_QueueItems

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_QueueItems](msdyn_workorder.md#BKMK_msdyn_workorder_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_QueueItems"></a> msdyn_workorderincident_QueueItems

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_QueueItems](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_QueueItems"></a> msdyn_workorderservice_QueueItems

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_QueueItems](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_QueueItems"></a> msdyn_workorderservicetask_QueueItems

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_QueueItems](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_appointmentactivitymarketingtemplate_QueueItems"></a> msdyncrm_appointmentactivitymarketingtemplate_QueueItems

One-To-Many Relationship: [msdyncrm_appointmentactivitymarketingtemplate msdyncrm_appointmentactivitymarketingtemplate_QueueItems](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_msdyncrm_appointmentactivitymarketingtemplate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_appointmentactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_appointmentactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_mktactivity_QueueItems"></a> msdyncrm_mktactivity_QueueItems

One-To-Many Relationship: [msdyncrm_mktactivity msdyncrm_mktactivity_QueueItems](msdyncrm_mktactivity.md#BKMK_msdyncrm_mktactivity_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_mktactivity`|
|ReferencedAttribute|`msdyncrm_mktactivityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_mktactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_phonecallactivitymarketingtemplate_QueueItems"></a> msdyncrm_phonecallactivitymarketingtemplate_QueueItems

One-To-Many Relationship: [msdyncrm_phonecallactivitymarketingtemplate msdyncrm_phonecallactivitymarketingtemplate_QueueItems](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_msdyncrm_phonecallactivitymarketingtemplate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_phonecallactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_phonecallactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems"></a> msdyncrm_taskactivitymarketingtemplate_QueueItems

One-To-Many Relationship: [msdyncrm_taskactivitymarketingtemplate msdyncrm_taskactivitymarketingtemplate_QueueItems](msdyncrm_taskactivitymarketingtemplate.md#BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_taskactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_taskactivitymarketingtemplate`|
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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queueitem?displayProperty=fullName>
