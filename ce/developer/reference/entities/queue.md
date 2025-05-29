---
title: "Queue table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Queue table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Queue table/entity reference (Microsoft Dynamics 365)

A list of records that require action, such as accounts, activities, and cases.

> [!NOTE]
> The Microsoft Dynamics 365 Queue table extends the [Microsoft Dataverse Queue table](/power-apps/developer/data-platform/reference/entities/queue).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EmailSignature](#BKMK_EmailSignature)
- [msdyn_assignmentinputcontractid](#BKMK_msdyn_assignmentinputcontractid)
- [msdyn_assignmentstrategy](#BKMK_msdyn_assignmentstrategy)
- [msdyn_inqueueoverflowrulesetid](#BKMK_msdyn_inqueueoverflowrulesetid)
- [msdyn_intentfamilyid](#BKMK_msdyn_intentfamilyid)
- [msdyn_isdefaultqueue](#BKMK_msdyn_isdefaultqueue)
- [msdyn_isomnichannelqueue](#BKMK_msdyn_isomnichannelqueue)
- [msdyn_maxqueuesize](#BKMK_msdyn_maxqueuesize)
- [msdyn_operatinghourid](#BKMK_msdyn_operatinghourid)
- [msdyn_operatinghoursbasedassignment](#BKMK_msdyn_operatinghoursbasedassignment)
- [msdyn_prequeueoverflowrulesetid](#BKMK_msdyn_prequeueoverflowrulesetid)
- [msdyn_priority](#BKMK_msdyn_priority)
- [msdyn_processqueueperiodically](#BKMK_msdyn_processqueueperiodically)
- [msdyn_queuetype](#BKMK_msdyn_queuetype)
- [msdyn_uniquename](#BKMK_msdyn_uniquename)

### <a name="BKMK_EmailSignature"></a> EmailSignature

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Signature**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailsignature`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|emailsignature|

### <a name="BKMK_msdyn_assignmentinputcontractid"></a> msdyn_assignmentinputcontractid

|Property|Value|
|---|---|
|Description|**Link assignment input contract with queue.**|
|DisplayName|**Assignment Input Contract Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignmentinputcontractid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_decisioncontract|

### <a name="BKMK_msdyn_assignmentstrategy"></a> msdyn_assignmentstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assignment Strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignmentstrategy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_queueassignmentstrategy`|

#### msdyn_assignmentstrategy Choices/Options

|Value|Label|
|---|---|
|192350000|**Omnichannel Assignment**|
|192350001|**Round Robin**|
|192350002|**Custom Assignment Configuration**|
|192350003|**Longest Idle**|

### <a name="BKMK_msdyn_inqueueoverflowrulesetid"></a> msdyn_inqueueoverflowrulesetid

|Property|Value|
|---|---|
|Description|**Define overflow rules for work items after it enters queue**|
|DisplayName|**Inqueue Overflow Ruleset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inqueueoverflowrulesetid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_decisionruleset|

### <a name="BKMK_msdyn_intentfamilyid"></a> msdyn_intentfamilyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**intentfamilyid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_isdefaultqueue"></a> msdyn_isdefaultqueue

|Property|Value|
|---|---|
|Description|**Shows whether the queue is set as default or not.**|
|DisplayName|**Is Default Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefaultqueue`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`queue_msdyn_isdefaultqueue`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isomnichannelqueue"></a> msdyn_isomnichannelqueue

|Property|Value|
|---|---|
|Description|**Shows whether the queue is used as Omnichannel queue for work distribution.**|
|DisplayName|**Is Omnichannel queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isomnichannelqueue`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`queue_msdyn_isomnichannelqueue`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_maxqueuesize"></a> msdyn_maxqueuesize

|Property|Value|
|---|---|
|Description|**Maximum queue size**|
|DisplayName|**Maximum queue size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maxqueuesize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_operatinghourid"></a> msdyn_operatinghourid

|Property|Value|
|---|---|
|Description|**Unique identifier for Operating hour associated with Queue**|
|DisplayName|**Operating Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operatinghourid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_operatinghour|

### <a name="BKMK_msdyn_operatinghoursbasedassignment"></a> msdyn_operatinghoursbasedassignment

|Property|Value|
|---|---|
|Description|**Setting to enable/disable periodic processing of a queue**|
|DisplayName|**Enable Operating Hours Based Assignment for Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operatinghoursbasedassignment`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`queue_msdyn_operatinghoursbasedassignment`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_prequeueoverflowrulesetid"></a> msdyn_prequeueoverflowrulesetid

|Property|Value|
|---|---|
|Description|**Define overflow rules for work items before it enters queue**|
|DisplayName|**Prequeue Overflow Ruleset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prequeueoverflowrulesetid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_decisionruleset|

### <a name="BKMK_msdyn_priority"></a> msdyn_priority

|Property|Value|
|---|---|
|Description|**Priority of the queue to indicate conversation assignment order to the agent.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_processqueueperiodically"></a> msdyn_processqueueperiodically

|Property|Value|
|---|---|
|Description|**Setting to enable/disable periodic processing of a queue**|
|DisplayName|**Enable Periodic Processing of Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processqueueperiodically`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`queue_msdyn_processqueueperiodically`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_queuetype"></a> msdyn_queuetype

|Property|Value|
|---|---|
|Description|**Defines the type of channels handled by this queue**|
|DisplayName|**Queue type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queuetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_queuetype`|

#### msdyn_queuetype Choices/Options

|Value|Label|
|---|---|
|192350000|**Messaging**|
|192350001|**Entity**|

### <a name="BKMK_msdyn_uniquename"></a> msdyn_uniquename

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uniquename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid](#BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid)
- [msdyn_msdyn_operatinghour_queue](#BKMK_msdyn_msdyn_operatinghour_queue)
- [msdyn_queue_decisioncontractid](#BKMK_msdyn_queue_decisioncontractid)
- [msdyn_queue_decisionrulesetId](#BKMK_msdyn_queue_decisionrulesetId)
- [Queue_intentfamilyid_msdyn_intentfamily](#BKMK_Queue_intentfamilyid_msdyn_intentfamily)

### <a name="BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid"></a> msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid

One-To-Many Relationship: [msdyn_decisionruleset msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid](msdyn_decisionruleset.md#BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_decisionruleset`|
|ReferencedAttribute|`msdyn_decisionrulesetid`|
|ReferencingAttribute|`msdyn_inqueueoverflowrulesetid`|
|ReferencingEntityNavigationPropertyName|`msdyn_inqueueoverflowrulesetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_operatinghour_queue"></a> msdyn_msdyn_operatinghour_queue

One-To-Many Relationship: [msdyn_operatinghour msdyn_msdyn_operatinghour_queue](msdyn_operatinghour.md#BKMK_msdyn_msdyn_operatinghour_queue)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_operatinghour`|
|ReferencedAttribute|`msdyn_operatinghourid`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencingEntityNavigationPropertyName|`msdyn_operatinghourid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_decisioncontractid"></a> msdyn_queue_decisioncontractid

One-To-Many Relationship: [msdyn_decisioncontract msdyn_queue_decisioncontractid](msdyn_decisioncontract.md#BKMK_msdyn_queue_decisioncontractid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_decisioncontract`|
|ReferencedAttribute|`msdyn_decisioncontractid`|
|ReferencingAttribute|`msdyn_assignmentinputcontractid`|
|ReferencingEntityNavigationPropertyName|`msdyn_routingcontractid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_decisionrulesetId"></a> msdyn_queue_decisionrulesetId

One-To-Many Relationship: [msdyn_decisionruleset msdyn_queue_decisionrulesetId](msdyn_decisionruleset.md#BKMK_msdyn_queue_decisionrulesetId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_decisionruleset`|
|ReferencedAttribute|`msdyn_decisionrulesetid`|
|ReferencingAttribute|`msdyn_prequeueoverflowrulesetid`|
|ReferencingEntityNavigationPropertyName|`msdyn_decisionrulesetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Queue_intentfamilyid_msdyn_intentfamily"></a> Queue_intentfamilyid_msdyn_intentfamily

One-To-Many Relationship: [msdyn_intentfamily Queue_intentfamilyid_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_Queue_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentfamilyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_intentsolutionmap_queueid_queue](#BKMK_msdyn_intentsolutionmap_queueid_queue)
- [msdyn_liveworkstream_defaultqueue_Queue](#BKMK_msdyn_liveworkstream_defaultqueue_Queue)
- [msdyn_queue_msdyn_assignmentconfiguration_queueid](#BKMK_msdyn_queue_msdyn_assignmentconfiguration_queueid)
- [msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue](#BKMK_msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue)
- [msdyn_queue_msdyn_liveworkstream_queueid](#BKMK_msdyn_queue_msdyn_liveworkstream_queueid)
- [msdyn_queue_msdyn_ocliveworkitem_queueid](#BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid)
- [msdyn_queue_msdyn_ocsession_queueid](#BKMK_msdyn_queue_msdyn_ocsession_queueid)
- [msdyn_queue_msdyn_originatingqueue_queueid](#BKMK_msdyn_queue_msdyn_originatingqueue_queueid)
- [msdyn_queue_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned)
- [msdyn_queue_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner)
- [msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid](#BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid)
- [msdyn_queue_msdyn_unifiedroutingrun_queue](#BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue)
- [msdyn_queue_ocruleitem](#BKMK_msdyn_queue_ocruleitem)
- [queue_msdyn_entityId_msdyn_activeicdextension](#BKMK_queue_msdyn_entityId_msdyn_activeicdextension)
- [queue_msdyn_entityId_msdyn_entityWorkstreamMap](#BKMK_queue_msdyn_entityId_msdyn_entityWorkstreamMap)
- [queue_msdyn_entityId_msdyn_icdextension](#BKMK_queue_msdyn_entityId_msdyn_icdextension)

### <a name="BKMK_msdyn_intentsolutionmap_queueid_queue"></a> msdyn_intentsolutionmap_queueid_queue

Many-To-One Relationship: [msdyn_intentsolutionmap msdyn_intentsolutionmap_queueid_queue](msdyn_intentsolutionmap.md#BKMK_msdyn_intentsolutionmap_queueid_queue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentsolutionmap_queueid_queue`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveworkstream_defaultqueue_Queue"></a> msdyn_liveworkstream_defaultqueue_Queue

Many-To-One Relationship: [msdyn_liveworkstream msdyn_liveworkstream_defaultqueue_Queue](msdyn_liveworkstream.md#BKMK_msdyn_liveworkstream_defaultqueue_Queue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`msdyn_defaultqueue`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveworkstream_defaultqueue_Queue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_assignmentconfiguration_queueid"></a> msdyn_queue_msdyn_assignmentconfiguration_queueid

Many-To-One Relationship: [msdyn_assignmentconfiguration msdyn_queue_msdyn_assignmentconfiguration_queueid](msdyn_assignmentconfiguration.md#BKMK_msdyn_queue_msdyn_assignmentconfiguration_queueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfiguration`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_assignmentconfiguration_queueid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue"></a> msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue

Many-To-One Relationship: [msdyn_liveworkstream msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue](msdyn_liveworkstream.md#BKMK_msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`msdyn_bot_queue`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_liveworkstream_msdyn_bot_queue`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_liveworkstream_queueid"></a> msdyn_queue_msdyn_liveworkstream_queueid

Many-To-One Relationship: [msdyn_liveworkstream msdyn_queue_msdyn_liveworkstream_queueid](msdyn_liveworkstream.md#BKMK_msdyn_queue_msdyn_liveworkstream_queueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`msdyn_outboundqueueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_liveworkstream_queueid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid"></a> msdyn_queue_msdyn_ocliveworkitem_queueid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_queue_msdyn_ocliveworkitem_queueid](msdyn_ocliveworkitem.md#BKMK_msdyn_queue_msdyn_ocliveworkitem_queueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_ocliveworkitem_queueid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_ocsession_queueid"></a> msdyn_queue_msdyn_ocsession_queueid

Many-To-One Relationship: [msdyn_ocsession msdyn_queue_msdyn_ocsession_queueid](msdyn_ocsession.md#BKMK_msdyn_queue_msdyn_ocsession_queueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_ocsession_queueid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_originatingqueue_queueid"></a> msdyn_queue_msdyn_originatingqueue_queueid

Many-To-One Relationship: [msdyn_originatingqueue msdyn_queue_msdyn_originatingqueue_queueid](msdyn_originatingqueue.md#BKMK_msdyn_queue_msdyn_originatingqueue_queueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_originatingqueue`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_originatingqueue_queueid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned"></a> msdyn_queue_msdyn_salesroutingrun_ownerassigned

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_queue_msdyn_salesroutingrun_ownerassigned](msdyn_salesroutingrun.md#BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_ownerassigned`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_salesroutingrun_ownerassigned`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner"></a> msdyn_queue_msdyn_salesroutingrun_previousowner

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_queue_msdyn_salesroutingrun_previousowner](msdyn_salesroutingrun.md#BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_previousowner`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_salesroutingrun_previousowner`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid"></a> msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid

Many-To-One Relationship: [msdyn_sessionparticipant msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid](msdyn_sessionparticipant.md#BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipant`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue"></a> msdyn_queue_msdyn_unifiedroutingrun_queue

Many-To-One Relationship: [msdyn_unifiedroutingrun msdyn_queue_msdyn_unifiedroutingrun_queue](msdyn_unifiedroutingrun.md#BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`msdyn_queue`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_msdyn_unifiedroutingrun_queue`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_ocruleitem"></a> msdyn_queue_ocruleitem

Many-To-One Relationship: [msdyn_ocruleitem msdyn_queue_ocruleitem](msdyn_ocruleitem.md#BKMK_msdyn_queue_ocruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocruleitem`|
|ReferencingAttribute|`msdyn_cdsqueueassignid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_ocruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_queue_msdyn_entityId_msdyn_activeicdextension"></a> queue_msdyn_entityId_msdyn_activeicdextension

Many-To-One Relationship: [msdyn_activeicdextension queue_msdyn_entityId_msdyn_activeicdextension](msdyn_activeicdextension.md#BKMK_queue_msdyn_entityId_msdyn_activeicdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activeicdextension`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`queue_msdyn_entityId_msdyn_activeicdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_queue_msdyn_entityId_msdyn_entityWorkstreamMap"></a> queue_msdyn_entityId_msdyn_entityWorkstreamMap

Many-To-One Relationship: [msdyn_entityworkstreammap queue_msdyn_entityId_msdyn_entityWorkstreamMap](msdyn_entityworkstreammap.md#BKMK_queue_msdyn_entityId_msdyn_entityWorkstreamMap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityworkstreammap`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`queue_msdyn_entityId_msdyn_entityWorkstreamMap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_queue_msdyn_entityId_msdyn_icdextension"></a> queue_msdyn_entityId_msdyn_icdextension

Many-To-One Relationship: [msdyn_icdextension queue_msdyn_entityId_msdyn_icdextension](msdyn_icdextension.md#BKMK_queue_msdyn_entityId_msdyn_icdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icdextension`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`queue_msdyn_entityId_msdyn_icdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queue?displayProperty=fullName>
