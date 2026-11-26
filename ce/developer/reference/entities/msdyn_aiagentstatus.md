---
title: "AI Agent Status (msdyn_aiagentstatus) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Agent Status (msdyn_aiagentstatus) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Agent Status (msdyn_aiagentstatus) table/entity reference (Microsoft Dynamics 365)

Tracks the status of the AI agent for the given record

## Messages

The following table lists the messages for the AI Agent Status (msdyn_aiagentstatus) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aiagentstatuses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aiagentstatuses(*msdyn_aiagentstatusid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aiagentstatuses(*msdyn_aiagentstatusid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aiagentstatuses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_aiagentstatuses(*msdyn_aiagentstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_aiagentstatuses(*msdyn_aiagentstatusid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_aiagentstatuses(*msdyn_aiagentstatusid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the AI Agent Status (msdyn_aiagentstatus) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **AI Agent Status** |
| **DisplayCollectionName** | **AI Agent Statuses** |
| **SchemaName** | `msdyn_aiagentstatus` |
| **CollectionSchemaName** | `msdyn_aiagentstatuses` |
| **EntitySetName** | `msdyn_aiagentstatuses`|
| **LogicalName** | `msdyn_aiagentstatus` |
| **LogicalCollectionName** | `msdyn_aiagentstatuses` |
| **PrimaryIdAttribute** | `msdyn_aiagentstatusid` |
| **PrimaryNameAttribute** |`msdyn_currentaistatus` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [msdyn_agentexternalactionstatus](#BKMK_msdyn_agentexternalactionstatus)
- [msdyn_agentmode](#BKMK_msdyn_agentmode)
- [msdyn_agentresolutiontimekpi](#BKMK_msdyn_agentresolutiontimekpi)
- [msdyn_agentrunstarttime](#BKMK_msdyn_agentrunstarttime)
- [msdyn_aiagentstatusId](#BKMK_msdyn_aiagentstatusId)
- [msdyn_currentaistatus](#BKMK_msdyn_currentaistatus)
- [msdyn_emailssent](#BKMK_msdyn_emailssent)
- [msdyn_escalatedon](#BKMK_msdyn_escalatedon)
- [msdyn_fallbackreason](#BKMK_msdyn_fallbackreason)
- [msdyn_fallbackreasondetails](#BKMK_msdyn_fallbackreasondetails)
- [msdyn_lastaction](#BKMK_msdyn_lastaction)
- [msdyn_lastemailactivity](#BKMK_msdyn_lastemailactivity)
- [msdyn_lastintent](#BKMK_msdyn_lastintent)
- [msdyn_lastintentfamily](#BKMK_msdyn_lastintentfamily)
- [msdyn_lastintentgroup](#BKMK_msdyn_lastintentgroup)
- [msdyn_lastoutboundcommunicationtype](#BKMK_msdyn_lastoutboundcommunicationtype)
- [msdyn_lastrawintent](#BKMK_msdyn_lastrawintent)
- [msdyn_sentiment](#BKMK_msdyn_sentiment)
- [msdyn_targetentity](#BKMK_msdyn_targetentity)
- [msdyn_targetentityIdType](#BKMK_msdyn_targetentityIdType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SLAId](#BKMK_SLAId)
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

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date and time stamp of the last on-hold time**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentexternalactionstatus"></a> msdyn_agentexternalactionstatus

|Property|Value|
|---|---|
|Description|**Status of external action for the AI agent.**|
|DisplayName|**Agent External Action Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentexternalactionstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_aiagentstatus_msdyn_agentexternalactionstatus`|

#### msdyn_agentexternalactionstatus Choices/Options

|Value|Label|
|---|---|
|1|**Wait**|
|2|**Not Applicable**|

### <a name="BKMK_msdyn_agentmode"></a> msdyn_agentmode

|Property|Value|
|---|---|
|Description|**Used to determine if the CMA agent is operating in fully autonomous, semi-autonomous (AI assisted), shadow, or disabled mode.**|
|DisplayName|**Agent Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_aiagentstatus_msdyn_agentmode`|

#### msdyn_agentmode Choices/Options

|Value|Label|
|---|---|
|1|**Fully autonomous**|
|2|**AI assisted**|
|3|**Shadow Mode**|
|4|**Disabled**|

### <a name="BKMK_msdyn_agentresolutiontimekpi"></a> msdyn_agentresolutiontimekpi

|Property|Value|
|---|---|
|Description|**SLA KPI Instance tracking agent resolution time**|
|DisplayName|**Agent Resolution Time KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresolutiontimekpi`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slakpiinstance|

### <a name="BKMK_msdyn_agentrunstarttime"></a> msdyn_agentrunstarttime

|Property|Value|
|---|---|
|Description|**When the current CMA run started. SLA timer starts from this timestamp.**|
|DisplayName|**Agent Run Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentrunstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_aiagentstatusId"></a> msdyn_aiagentstatusId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**AI Agent Status**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aiagentstatusid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_currentaistatus"></a> msdyn_currentaistatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Current AI Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentaistatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_emailssent"></a> msdyn_emailssent

|Property|Value|
|---|---|
|Description|**Number of autonomous emails sent by the agent**|
|DisplayName|**Emails sent by agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailssent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_escalatedon"></a> msdyn_escalatedon

|Property|Value|
|---|---|
|Description|**Date and time the record was escalated on.**|
|DisplayName|**Escalated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_escalatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_fallbackreason"></a> msdyn_fallbackreason

|Property|Value|
|---|---|
|Description|**Reason AI could not proceed.**|
|DisplayName|**Fallback Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallbackreason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aiagentstatus_msdyn_fallbackreason`|

#### msdyn_fallbackreason Choices/Options

|Value|Label|
|---|---|
|1|**Intent not found**|
|2|**Multiple intents**|
|3|**Customer not responding after multiple tries**|
|4|**Customer requests supervisor**|
|5|**Customer rejects proposed solution**|
|6|**Solution not found**|
|7|**Intent-core action failed**|
|8|**Connector exception or outage**|
|9|**Long-running action threatening SLA or backlog**|
|10|**Manual takeover by agent or supervisor**|
|11|**Stage disabled in configuration**|
|12|**Failed to update case to "active" status**|
|13|**Failed to create an email draft**|
|14|**Created an email draft with no recipients**|
|15|**Email failed to send**|
|16|**An unexpected error occurred**|
|17|**OOF email response from customer**|
|18|**Unable to proceed due to various reasons**|
|19|**Could not set language code**|
|20|**Guardrail checks failed**|
|21|**Harmful content detected**|
|22|**Intent configured for shadow mode**|
|23|**Custom agent unable to proceed**|
|24|**Undeliverable email**|
|25|**Custom agent requested review**|
|26|**Invalid custom agent response**|
|27|**Case management agent prerequisites not met**|
|28|**Case management agent capabilities disabled**|
|29|**Created an email draft with no subject**|
|30|**Per line of business email template could not be resolved**|
|31|**Manual stop by supervisor**|

### <a name="BKMK_msdyn_fallbackreasondetails"></a> msdyn_fallbackreasondetails

|Property|Value|
|---|---|
|Description|**Rationale describing why the AI agent escalated or handed off.**|
|DisplayName|**Fallback Reason Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallbackreasondetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_lastaction"></a> msdyn_lastaction

|Property|Value|
|---|---|
|Description|**This field helps identifying the last action that was taken by the CMA agent on a particular case.**|
|DisplayName|**Agent Last Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastaction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_aiagentstatus_msdyn_lastaction`|

#### msdyn_lastaction Choices/Options

|Value|Label|
|---|---|
|1|**Updated case**|
|2|**Created draft email**|
|3|**Sent email**|
|4|**Resolved case**|

### <a name="BKMK_msdyn_lastemailactivity"></a> msdyn_lastemailactivity

|Property|Value|
|---|---|
|Description|**This corresponds to the last email activity that CMA dealt with**|
|DisplayName|**Last Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastemailactivity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email|

### <a name="BKMK_msdyn_lastintent"></a> msdyn_lastintent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastintent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intent|

### <a name="BKMK_msdyn_lastintentfamily"></a> msdyn_lastintentfamily

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Intent Family**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastintentfamily`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_lastintentgroup"></a> msdyn_lastintentgroup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Intent Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastintentgroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intent|

### <a name="BKMK_msdyn_lastoutboundcommunicationtype"></a> msdyn_lastoutboundcommunicationtype

|Property|Value|
|---|---|
|Description|**The type of outbound communication the AI agent performed.**|
|DisplayName|**Last Outbound Communication Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastoutboundcommunicationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_aiagentstatus_msdyn_lastoutboundcommunicationtype`|

#### msdyn_lastoutboundcommunicationtype Choices/Options

|Value|Label|
|---|---|
|0|**Interview**|
|1|**Solution response**|

### <a name="BKMK_msdyn_lastrawintent"></a> msdyn_lastrawintent

|Property|Value|
|---|---|
|Description|**Raw intent string returned by intent-core when a LOB is matched but no configured intent matches. Mutually exclusive with Last Intent.**|
|DisplayName|**Last Raw Intent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastrawintent`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_sentiment"></a> msdyn_sentiment

|Property|Value|
|---|---|
|Description|**Stores the sentiment value for the record, mirroring the Case Sentiment option set so case sentiment can be tracked on the AI Agent Status entity without modifying the Case (Incident) entity.**|
|DisplayName|**Sentiment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sentiment`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_msdyn_aiagentstatus_msdyn_sentiment`|

#### msdyn_sentiment Choices/Options

|Value|Label|
|---|---|
|0|**N/A**|
|7|**Very negative**|
|8|**Negative**|
|9|**Slightly negative**|
|10|**Neutral**|
|11|**Slightly positive**|
|12|**Positive**|
|13|**Very positive**|

### <a name="BKMK_msdyn_targetentity"></a> msdyn_targetentity

|Property|Value|
|---|---|
|Description|**Target entity for the AI agent status.**|
|DisplayName|**Target entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident, msdyn_emailthread|

### <a name="BKMK_msdyn_targetentityIdType"></a> msdyn_targetentityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentityidtype`|
|RequiredLevel|None|
|Type|EntityName|

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

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the AI Agent Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aiagentstatus_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Status of the AI Agent**|
|DisplayName|**Processing Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aiagentstatus_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **In Progress**<br />State:0<br />TransitionData: None|
|2|Label: **Escalated**<br />State:1<br />TransitionData: None|
|3|Label: **Idle**<br />State:1<br />TransitionData: None|
|4|Label: **Paused**<br />State:1<br />TransitionData: None|

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
- [OnHoldTime](#BKMK_OnHoldTime)
- [OrganizationId](#BKMK_OrganizationId)
- [slaidname](#BKMK_slaidname)
- [SLAInvokedId](#BKMK_SLAInvokedId)
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

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows how long, in minutes, that the record was on hold**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

### <a name="BKMK_slaidname"></a> slaidname

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slaidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Last SLA Applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

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

- [lk_msdyn_aiagentstatus_createdby](#BKMK_lk_msdyn_aiagentstatus_createdby)
- [lk_msdyn_aiagentstatus_createdonbehalfby](#BKMK_lk_msdyn_aiagentstatus_createdonbehalfby)
- [lk_msdyn_aiagentstatus_modifiedby](#BKMK_lk_msdyn_aiagentstatus_modifiedby)
- [lk_msdyn_aiagentstatus_modifiedonbehalfby](#BKMK_lk_msdyn_aiagentstatus_modifiedonbehalfby)
- [manualsla_msdyn_aiagentstatus](#BKMK_manualsla_msdyn_aiagentstatus)
- [msdyn_email_msdyn_aiagentstatus](#BKMK_msdyn_email_msdyn_aiagentstatus)
- [msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity](#BKMK_msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity)
- [msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity](#BKMK_msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity)
- [msdyn_msdyn_intent_msdyn_aiagentstatus](#BKMK_msdyn_msdyn_intent_msdyn_aiagentstatus)
- [msdyn_msdyn_intentfamily_msdyn_aiagentstatus](#BKMK_msdyn_msdyn_intentfamily_msdyn_aiagentstatus)
- [msdyn_msdyn_intentgroup_msdyn_aiagentstatus](#BKMK_msdyn_msdyn_intentgroup_msdyn_aiagentstatus)
- [msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi](#BKMK_msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi)
- [organization_msdyn_aiagentstatus](#BKMK_organization_msdyn_aiagentstatus)
- [sla_msdyn_aiagentstatus](#BKMK_sla_msdyn_aiagentstatus)

### <a name="BKMK_lk_msdyn_aiagentstatus_createdby"></a> lk_msdyn_aiagentstatus_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aiagentstatus_createdby](systemuser.md#BKMK_lk_msdyn_aiagentstatus_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aiagentstatus_createdonbehalfby"></a> lk_msdyn_aiagentstatus_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aiagentstatus_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aiagentstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aiagentstatus_modifiedby"></a> lk_msdyn_aiagentstatus_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aiagentstatus_modifiedby](systemuser.md#BKMK_lk_msdyn_aiagentstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aiagentstatus_modifiedonbehalfby"></a> lk_msdyn_aiagentstatus_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aiagentstatus_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aiagentstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_msdyn_aiagentstatus"></a> manualsla_msdyn_aiagentstatus

One-To-Many Relationship: [sla manualsla_msdyn_aiagentstatus](sla.md#BKMK_manualsla_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`slaid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_email_msdyn_aiagentstatus"></a> msdyn_email_msdyn_aiagentstatus

One-To-Many Relationship: [email msdyn_email_msdyn_aiagentstatus](email.md#BKMK_msdyn_email_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_lastemailactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_lastemailactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity"></a> msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity

One-To-Many Relationship: [incident msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity](incident.md#BKMK_msdyn_msdyn_aiagentstatus_incident_msdyn_targetentity)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity"></a> msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity

One-To-Many Relationship: [msdyn_emailthread msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity](msdyn_emailthread.md#BKMK_msdyn_msdyn_aiagentstatus_msdyn_emailthread_msdyn_targetentity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_emailthread`|
|ReferencedAttribute|`msdyn_emailthreadid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_msdyn_emailthread`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intent_msdyn_aiagentstatus"></a> msdyn_msdyn_intent_msdyn_aiagentstatus

One-To-Many Relationship: [msdyn_intent msdyn_msdyn_intent_msdyn_aiagentstatus](msdyn_intent.md#BKMK_msdyn_msdyn_intent_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intent`|
|ReferencedAttribute|`msdyn_intentid`|
|ReferencingAttribute|`msdyn_lastintent`|
|ReferencingEntityNavigationPropertyName|`msdyn_lastintent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intentfamily_msdyn_aiagentstatus"></a> msdyn_msdyn_intentfamily_msdyn_aiagentstatus

One-To-Many Relationship: [msdyn_intentfamily msdyn_msdyn_intentfamily_msdyn_aiagentstatus](msdyn_intentfamily.md#BKMK_msdyn_msdyn_intentfamily_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_lastintentfamily`|
|ReferencingEntityNavigationPropertyName|`msdyn_lastintentfamily`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intentgroup_msdyn_aiagentstatus"></a> msdyn_msdyn_intentgroup_msdyn_aiagentstatus

One-To-Many Relationship: [msdyn_intent msdyn_msdyn_intentgroup_msdyn_aiagentstatus](msdyn_intent.md#BKMK_msdyn_msdyn_intentgroup_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intent`|
|ReferencedAttribute|`msdyn_intentid`|
|ReferencingAttribute|`msdyn_lastintentgroup`|
|ReferencingEntityNavigationPropertyName|`msdyn_lastintentgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi"></a> msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi

One-To-Many Relationship: [slakpiinstance msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi](slakpiinstance.md#BKMK_msdyn_slakpiinstance_msdyn_aiagentstatus_agentresolutiontimekpi)

|Property|Value|
|---|---|
|ReferencedEntity|`slakpiinstance`|
|ReferencedAttribute|`slakpiinstanceid`|
|ReferencingAttribute|`msdyn_agentresolutiontimekpi`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentresolutiontimekpi`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_aiagentstatus"></a> organization_msdyn_aiagentstatus

One-To-Many Relationship: [organization organization_msdyn_aiagentstatus](organization.md#BKMK_organization_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_msdyn_aiagentstatus"></a> sla_msdyn_aiagentstatus

One-To-Many Relationship: [sla sla_msdyn_aiagentstatus](sla.md#BKMK_sla_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_aiagentstatus_AsyncOperations](#BKMK_msdyn_aiagentstatus_AsyncOperations)
- [msdyn_aiagentstatus_BulkDeleteFailures](#BKMK_msdyn_aiagentstatus_BulkDeleteFailures)
- [msdyn_aiagentstatus_MailboxTrackingFolders](#BKMK_msdyn_aiagentstatus_MailboxTrackingFolders)
- [msdyn_aiagentstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_aiagentstatus_PrincipalObjectAttributeAccesses)
- [msdyn_aiagentstatus_ProcessSession](#BKMK_msdyn_aiagentstatus_ProcessSession)
- [msdyn_aiagentstatus_SLAKPIInstances](#BKMK_msdyn_aiagentstatus_SLAKPIInstances)
- [msdyn_aiagentstatus_SyncErrors](#BKMK_msdyn_aiagentstatus_SyncErrors)
- [msdyn_incident_msdyn_aiagentstatus](#BKMK_msdyn_incident_msdyn_aiagentstatus)

### <a name="BKMK_msdyn_aiagentstatus_AsyncOperations"></a> msdyn_aiagentstatus_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_aiagentstatus_AsyncOperations](asyncoperation.md#BKMK_msdyn_aiagentstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_BulkDeleteFailures"></a> msdyn_aiagentstatus_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_aiagentstatus_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_aiagentstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_MailboxTrackingFolders"></a> msdyn_aiagentstatus_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_aiagentstatus_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_aiagentstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_PrincipalObjectAttributeAccesses"></a> msdyn_aiagentstatus_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_aiagentstatus_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_aiagentstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_ProcessSession"></a> msdyn_aiagentstatus_ProcessSession

Many-To-One Relationship: [processsession msdyn_aiagentstatus_ProcessSession](processsession.md#BKMK_msdyn_aiagentstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_SLAKPIInstances"></a> msdyn_aiagentstatus_SLAKPIInstances

Many-To-One Relationship: [slakpiinstance msdyn_aiagentstatus_SLAKPIInstances](slakpiinstance.md#BKMK_msdyn_aiagentstatus_SLAKPIInstances)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_SLAKPIInstances`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aiagentstatus_SyncErrors"></a> msdyn_aiagentstatus_SyncErrors

Many-To-One Relationship: [syncerror msdyn_aiagentstatus_SyncErrors](syncerror.md#BKMK_msdyn_aiagentstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiagentstatus_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_aiagentstatus"></a> msdyn_incident_msdyn_aiagentstatus

Many-To-One Relationship: [incident msdyn_incident_msdyn_aiagentstatus](incident.md#BKMK_msdyn_incident_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`msdyn_aiagentstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_aiagentstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

