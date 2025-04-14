---
title: "Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Message (msdyn_ocsystemmessage) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365)

Stores the system messages sent to the message receiver for various events.

## Messages

The following table lists the messages for the Message (msdyn_ocsystemmessage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocsystemmessages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsystemmessages(*msdyn_ocsystemmessageid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsystemmessages(*msdyn_ocsystemmessageid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsystemmessages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsystemmessages(*msdyn_ocsystemmessageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsystemmessages(*msdyn_ocsystemmessageid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsystemmessages(*msdyn_ocsystemmessageid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Message (msdyn_ocsystemmessage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Message** |
| **DisplayCollectionName** | **Messages** |
| **SchemaName** | `msdyn_ocsystemmessage` |
| **CollectionSchemaName** | `msdyn_ocsystemmessages` |
| **EntitySetName** | `msdyn_ocsystemmessages`|
| **LogicalName** | `msdyn_ocsystemmessage` |
| **LogicalCollectionName** | `msdyn_ocsystemmessages` |
| **PrimaryIdAttribute** | `msdyn_ocsystemmessageid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_defaultlanguage](#BKMK_msdyn_defaultlanguage)
- [msdyn_instanceid](#BKMK_msdyn_instanceid)
- [msdyn_messagedescription](#BKMK_msdyn_messagedescription)
- [msdyn_messagereceiver](#BKMK_msdyn_messagereceiver)
- [msdyn_messagetemplatetrigger](#BKMK_msdyn_messagetemplatetrigger)
- [msdyn_messagetext](#BKMK_msdyn_messagetext)
- [msdyn_messagetype](#BKMK_msdyn_messagetype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocsystemmessageId](#BKMK_msdyn_ocsystemmessageId)
- [msdyn_streamsource](#BKMK_msdyn_streamsource)
- [msdyn_systemmessageeventtype](#BKMK_msdyn_systemmessageeventtype)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_defaultlanguage"></a> msdyn_defaultlanguage

|Property|Value|
|---|---|
|Description|**Default language of the message template.**|
|DisplayName|**Default language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_instanceid"></a> msdyn_instanceid

|Property|Value|
|---|---|
|Description|**ID of the instance this system message is related to, represented in text form.**|
|DisplayName|**Instance ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_instanceid`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_messagedescription"></a> msdyn_messagedescription

|Property|Value|
|---|---|
|Description|**Description of the message.**|
|DisplayName|**Message description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagedescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_messagereceiver"></a> msdyn_messagereceiver

|Property|Value|
|---|---|
|Description|**Stores the list of message receivers.**|
|DisplayName|**Message recipient**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagereceiver`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocmessagereceiver`|

#### msdyn_messagereceiver Choices/Options

|Value|Label|
|---|---|
|192350000|**Agent**|
|192350001|**Customer**|

### <a name="BKMK_msdyn_messagetemplatetrigger"></a> msdyn_messagetemplatetrigger

|Property|Value|
|---|---|
|Description|**Stores the list of event types for message template**|
|DisplayName|**Message template trigger**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagetemplatetrigger`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocmessagetemplatetrigger`|

#### msdyn_messagetemplatetrigger Choices/Options

|Value|Label|
|---|---|
|1|**Outside 24-hour conversation window**|

### <a name="BKMK_msdyn_messagetext"></a> msdyn_messagetext

|Property|Value|
|---|---|
|Description|**Text sent to the message receiver.**|
|DisplayName|**Message Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagetext`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_messagetype"></a> msdyn_messagetype

|Property|Value|
|---|---|
|Description|**Stores the list of event types for system messages.**|
|DisplayName|**Message type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsystemmessagetype`|

#### msdyn_messagetype Choices/Options

|Value|Label|
|---|---|
|2|**Automated Message**|
|3|**Message Template**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocsystemmessageId"></a> msdyn_ocsystemmessageId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Message**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsystemmessageid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

|Property|Value|
|---|---|
|Description|**List of all available channels.**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_streamsource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_streamsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Entity Records**|

### <a name="BKMK_msdyn_systemmessageeventtype"></a> msdyn_systemmessageeventtype

|Property|Value|
|---|---|
|Description|**Stores the list of event types for system messages.**|
|DisplayName|**Message trigger**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemmessageeventtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsystemmessageeventtype`|

#### msdyn_systemmessageeventtype Choices/Options

|Value|Label|
|---|---|
|192350000|**Agent joined conversation**|
|192350001|**Consult accepted**|
|192350002|**Transfer to agent accepted**|
|192350003|**Consult started**|
|192350004|**Consult request failed**|
|192350005|**Transfer to agent requested**|
|192350006|**Transfer to agent failed**|
|192350007|**Consult rejected**|
|192350008|**Transfer to agent rejected**|
|192350009|**Consult request timed out**|
|192350010|**Transfer to agent timed out**|
|192350011|**Transfer to queue started**|
|192350012|**Transfer to queue failed**|
|192350013|**Agent disconnected from conversation**|
|192350014|**Agent ended conversation**|
|192350015|**Session ended**|
|192350016|**Consult session ended**|
|192350017|**Agent assigned to conversation**|
|192350018|**Agent couldn't be assigned to conversation**|
|192350019|**Customer ended conversation**|
|192350020|**Customer disconnected**|
|192350021|**Customer's position in queue**|
|192350022|**Agent's message couldn't be sent**|
|192350023|**Customer's message couldn't be sent: Outside of operation hours**|
|192350024|**Customer is next in line**|
|192350025|**Message couldn't be delivered: Unsupported message type**|
|192350026|**Voice call requested**|
|192350027|**Voice call accepted**|
|192350028|**Voice call declined**|
|192350029|**Message couldn't be sent: Outside allowed timeframe**|
|192350030|**Average wait time for customers: Minutes**|
|192350031|**Average wait time for customers: Hours**|
|192350032|**Average wait time for customers: Hours and minutes**|
|192350033|**Voice call ended**|
|192350034|**Message couldn’t be sent: A channel account can’t message another account within Omnichannel**|
|192350035|**Holiday message to customer**|
|192350036|**Out of operating hour message to customer**|
|192350037|**Couldn’t find the channel account in Omnichannel**|
|192350038|**Customer's file couldn't be attached because it's too big**|
|192350039|**Transfer to out of operating hour queue**|
|192350040|**Message couldn’t be sent: File couldn’t be attached**|
|192350041|**Leave as many messages as you’d like and we’ll get back to you as soon as possible. We’ll save your chat history, so you can leave and come back anytime.**|
|192350042|**Customer put on hold.**|
|192350043|**Customer no longer on hold.**|
|192350044|**Message or attachment failed to send. Providing error details including error code, reason for failure, message id, timestamp, and transaction id**|
|192350045|**Transcription started.**|
|192350046|**Transcription paused.**|
|192350047|**Transcription resumed.**|
|192350048|**Transcription stopped.**|
|192350049|**Recording and transcription started.**|
|192350050|**Recording and transcription paused.**|
|192350051|**Recording and transcription resumed.**|
|192350052|**Recording and transcription stopped.**|
|192350053|**Trial usage limit exceeded**|
|192350054|**Trial conversation time limit exceeded**|
|192350055|**End conversation due to overflow**|
|192350056|**Greeting Message for Async Channels and Voice**|
|192350057|**Customer has opted out from Async Conversation**|
|192350058|**Agent left consult conversation**|
|192350059|**Agent left customer conversation**|
|192350060|**Agent accepted consult conversation**|
|192350061|**Agent joined customer conversation**|
|192350062|**Agent ended consult conversation**|
|192350063|**Agent removed from consult conversation**|
|192350064|**Not enough data for average wait time**|
|192350070|**Waiting time for agent when customer is disconnected**|
|192350071|**Invalid Apple OAuth response**|
|192350072|**Supervisor force closed the conversation**|
|192350073|**Offer customer callback**|
|192350074|**Customer callback response**|
|192370001|**Customer's message couldn't be sent: Service is down.**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the System Message**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsystemmessage_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the System Message**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsystemmessage_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_msdyn_ocsystemmessage_createdby](#BKMK_lk_msdyn_ocsystemmessage_createdby)
- [lk_msdyn_ocsystemmessage_createdonbehalfby](#BKMK_lk_msdyn_ocsystemmessage_createdonbehalfby)
- [lk_msdyn_ocsystemmessage_modifiedby](#BKMK_lk_msdyn_ocsystemmessage_modifiedby)
- [lk_msdyn_ocsystemmessage_modifiedonbehalfby](#BKMK_lk_msdyn_ocsystemmessage_modifiedonbehalfby)
- [msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage)
- [organization_msdyn_ocsystemmessage](#BKMK_organization_msdyn_ocsystemmessage)

### <a name="BKMK_lk_msdyn_ocsystemmessage_createdby"></a> lk_msdyn_ocsystemmessage_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocsystemmessage_createdby](systemuser.md#BKMK_lk_msdyn_ocsystemmessage_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsystemmessage_createdonbehalfby"></a> lk_msdyn_ocsystemmessage_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsystemmessage_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsystemmessage_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsystemmessage_modifiedby"></a> lk_msdyn_ocsystemmessage_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocsystemmessage_modifiedby](systemuser.md#BKMK_lk_msdyn_ocsystemmessage_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsystemmessage_modifiedonbehalfby"></a> lk_msdyn_ocsystemmessage_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsystemmessage_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsystemmessage_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsystemmessage_defaultlanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_defaultlanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_ocsystemmessage"></a> organization_msdyn_ocsystemmessage

One-To-Many Relationship: [organization organization_msdyn_ocsystemmessage](organization.md#BKMK_organization_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_ocsystemmessage_AsyncOperations](#BKMK_msdyn_ocsystemmessage_AsyncOperations)
- [msdyn_ocsystemmessage_BulkDeleteFailures](#BKMK_msdyn_ocsystemmessage_BulkDeleteFailures)
- [msdyn_ocsystemmessage_DuplicateBaseRecord](#BKMK_msdyn_ocsystemmessage_DuplicateBaseRecord)
- [msdyn_ocsystemmessage_DuplicateMatchingRecord](#BKMK_msdyn_ocsystemmessage_DuplicateMatchingRecord)
- [msdyn_ocsystemmessage_MailboxTrackingFolders](#BKMK_msdyn_ocsystemmessage_MailboxTrackingFolders)
- [msdyn_ocsystemmessage_msdyn_oclocalizationdata](#BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata)
- [msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses)
- [msdyn_ocsystemmessage_ProcessSession](#BKMK_msdyn_ocsystemmessage_ProcessSession)
- [msdyn_ocsystemmessage_SyncErrors](#BKMK_msdyn_ocsystemmessage_SyncErrors)

### <a name="BKMK_msdyn_ocsystemmessage_AsyncOperations"></a> msdyn_ocsystemmessage_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsystemmessage_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsystemmessage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_BulkDeleteFailures"></a> msdyn_ocsystemmessage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsystemmessage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsystemmessage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_DuplicateBaseRecord"></a> msdyn_ocsystemmessage_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsystemmessage_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsystemmessage_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_DuplicateMatchingRecord"></a> msdyn_ocsystemmessage_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsystemmessage_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsystemmessage_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_MailboxTrackingFolders"></a> msdyn_ocsystemmessage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsystemmessage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsystemmessage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata"></a> msdyn_ocsystemmessage_msdyn_oclocalizationdata

Many-To-One Relationship: [msdyn_oclocalizationdata msdyn_ocsystemmessage_msdyn_oclocalizationdata](msdyn_oclocalizationdata.md#BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclocalizationdata`|
|ReferencingAttribute|`msdyn_systemmessageid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_msdyn_oclocalizationdata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses"></a> msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_ProcessSession"></a> msdyn_ocsystemmessage_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsystemmessage_ProcessSession](processsession.md#BKMK_msdyn_ocsystemmessage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsystemmessage_SyncErrors"></a> msdyn_ocsystemmessage_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsystemmessage_SyncErrors](syncerror.md#BKMK_msdyn_ocsystemmessage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsystemmessage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

