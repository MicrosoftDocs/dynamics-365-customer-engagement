---
title: "Conversation Message Block (msdyn_conversationmessageblock) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Message Block (msdyn_conversationmessageblock) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Message Block (msdyn_conversationmessageblock) table/entity reference (Microsoft Dynamics 365)

A Message Block would constitute a block of messages up till an agent responds (including the messages sent by the agent). A follow up message, after an agent responds, will create another message block, this block again ends with the messages from the agent

## Messages

The following table lists the messages for the Conversation Message Block (msdyn_conversationmessageblock) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_conversationmessageblocks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_conversationmessageblocks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Message Block (msdyn_conversationmessageblock) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Message Block** |
| **DisplayCollectionName** | **msdyn_conversationmessageblock** |
| **SchemaName** | `msdyn_conversationmessageblock` |
| **CollectionSchemaName** | `msdyn_conversationmessageblocks` |
| **EntitySetName** | `msdyn_conversationmessageblocks`|
| **LogicalName** | `msdyn_conversationmessageblock` |
| **LogicalCollectionName** | `msdyn_conversationmessageblocks` |
| **PrimaryIdAttribute** | `msdyn_conversationmessageblockid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_agentmessagetime](#BKMK_msdyn_agentmessagetime)
- [msdyn_agentresponsesessionid](#BKMK_msdyn_agentresponsesessionid)
- [msdyn_agentresponsetimeadjforoh](#BKMK_msdyn_agentresponsetimeadjforoh)
- [msdyn_agentresponsetimenotadjforoh](#BKMK_msdyn_agentresponsetimenotadjforoh)
- [msdyn_conversationmessageblockId](#BKMK_msdyn_conversationmessageblockId)
- [msdyn_customermessagesessionid](#BKMK_msdyn_customermessagesessionid)
- [msdyn_customermessagetimestamp](#BKMK_msdyn_customermessagetimestamp)
- [msdyn_inboundmessagecountoutsideoh](#BKMK_msdyn_inboundmessagecountoutsideoh)
- [msdyn_inboundmessagecountwithinoh](#BKMK_msdyn_inboundmessagecountwithinoh)
- [msdyn_isfirstresponsetime](#BKMK_msdyn_isfirstresponsetime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitemid)
- [msdyn_outboundmessagecountoutsideoh](#BKMK_msdyn_outboundmessagecountoutsideoh)
- [msdyn_outboundmessagecountwithinoh](#BKMK_msdyn_outboundmessagecountwithinoh)
- [msdyn_responsetimeadjforoh](#BKMK_msdyn_responsetimeadjforoh)
- [msdyn_responsetimenotadjforoh](#BKMK_msdyn_responsetimenotadjforoh)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|---|---|
|Description|**Id of Agent who first responded to customer in this message block**|
|DisplayName|**Agent Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_agentmessagetime"></a> msdyn_agentmessagetime

|Property|Value|
|---|---|
|Description|**Timestamp of first message sent by agent within a message block. Each message block record is a summary of consecutive messages sent by customer and agent’s response to the same**|
|DisplayName|**Agent message time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentmessagetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentresponsesessionid"></a> msdyn_agentresponsesessionid

|Property|Value|
|---|---|
|Description|**Agent response session identifier. The session in which agent responded to the customer’s message within this message block**|
|DisplayName|**Agent response session identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresponsesessionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_agentresponsetimeadjforoh"></a> msdyn_agentresponsetimeadjforoh

|Property|Value|
|---|---|
|Description|**Time it took for the agent to respond to the customer from the time agent accepted the session., excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Agent response time adjusted for operating hours.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresponsetimeadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentresponsetimenotadjforoh"></a> msdyn_agentresponsetimenotadjforoh

|Property|Value|
|---|---|
|Description|**Time it took for the agent to respond to the customer from the time agent accepted the session, including agent's out of operating hours (OOOH)**|
|DisplayName|**Agent response time not adjusted for OH**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentresponsetimenotadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_conversationmessageblockId"></a> msdyn_conversationmessageblockId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Conversation Message Blocks**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationmessageblockid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_customermessagesessionid"></a> msdyn_customermessagesessionid

|Property|Value|
|---|---|
|Description|**Customer message session identifier. The session in which customer sent the message within this message block**|
|DisplayName|**Customer message session identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customermessagesessionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_customermessagetimestamp"></a> msdyn_customermessagetimestamp

|Property|Value|
|---|---|
|Description|**Customer Message Session timestamp. Timestamp of first customer message within this message block**|
|DisplayName|**Customer message time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customermessagetimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_inboundmessagecountoutsideoh"></a> msdyn_inboundmessagecountoutsideoh

|Property|Value|
|---|---|
|Description|**Number of messages from customer to agent outside the agent's operating hours**|
|DisplayName|**In message outside OH**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inboundmessagecountoutsideoh`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_inboundmessagecountwithinoh"></a> msdyn_inboundmessagecountwithinoh

|Property|Value|
|---|---|
|Description|**Number of messages from customer to agent within the agent's operating hours**|
|DisplayName|**In message within OH**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inboundmessagecountwithinoh`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_isfirstresponsetime"></a> msdyn_isfirstresponsetime

|Property|Value|
|---|---|
|Description|**Indicates if this message block contains the first response time for the conversation**|
|DisplayName|**Is first response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfirstresponsetime`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_conversationmessageblock_msdyn_isfirstresponsetime`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitemid

|Property|Value|
|---|---|
|Description|**Conversation Id**|
|DisplayName|**Conversation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_outboundmessagecountoutsideoh"></a> msdyn_outboundmessagecountoutsideoh

|Property|Value|
|---|---|
|Description|**Number of messages from agent to customer outside the agent's operating hours**|
|DisplayName|**Outbound message outside operating hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outboundmessagecountoutsideoh`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_outboundmessagecountwithinoh"></a> msdyn_outboundmessagecountwithinoh

|Property|Value|
|---|---|
|Description|**Number of messages from agent to customer within the agent's operating hours**|
|DisplayName|**Outboud message within operating hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outboundmessagecountwithinoh`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_responsetimeadjforoh"></a> msdyn_responsetimeadjforoh

|Property|Value|
|---|---|
|Description|**Time it took to respond to customer, excluding agent's out of operating hours (OOOH)**|
|DisplayName|**Response time adjusted for OH**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responsetimeadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_responsetimenotadjforoh"></a> msdyn_responsetimenotadjforoh

|Property|Value|
|---|---|
|Description|**Time it took to respond to customer, including agent's out of operating hours**|
|DisplayName|**Response time not adjusted for OH**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responsetimenotadjforoh`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Conversation Message Blocks**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationmessageblock_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Conversation Message Blocks**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationmessageblock_statuscode`|

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
|Description|**Time zone code that was in use when the record was created**|
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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Unique identifier of the delegate user who created the record**|
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
|Description|**Unique identifier of the user who modified the record**|
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
|Description|**Date and time when the record was modified**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_conversationmessageblock](#BKMK_business_unit_msdyn_conversationmessageblock)
- [lk_msdyn_conversationmessageblock_createdby](#BKMK_lk_msdyn_conversationmessageblock_createdby)
- [lk_msdyn_conversationmessageblock_createdonbehalfby](#BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby)
- [lk_msdyn_conversationmessageblock_modifiedby](#BKMK_lk_msdyn_conversationmessageblock_modifiedby)
- [lk_msdyn_conversationmessageblock_modifiedonbehalfby](#BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby)
- [msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid)
- [msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid](#BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid)
- [owner_msdyn_conversationmessageblock](#BKMK_owner_msdyn_conversationmessageblock)
- [team_msdyn_conversationmessageblock](#BKMK_team_msdyn_conversationmessageblock)
- [user_msdyn_conversationmessageblock](#BKMK_user_msdyn_conversationmessageblock)

### <a name="BKMK_business_unit_msdyn_conversationmessageblock"></a> business_unit_msdyn_conversationmessageblock

One-To-Many Relationship: [businessunit business_unit_msdyn_conversationmessageblock](businessunit.md#BKMK_business_unit_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationmessageblock_createdby"></a> lk_msdyn_conversationmessageblock_createdby

One-To-Many Relationship: [systemuser lk_msdyn_conversationmessageblock_createdby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby"></a> lk_msdyn_conversationmessageblock_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationmessageblock_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationmessageblock_modifiedby"></a> lk_msdyn_conversationmessageblock_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_conversationmessageblock_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby"></a> lk_msdyn_conversationmessageblock_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationmessageblock_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocliveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_agentresponsesessionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentresponsesessionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_customermessagesessionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_customermessagesessionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid"></a> msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid](systemuser.md#BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_agentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_conversationmessageblock"></a> owner_msdyn_conversationmessageblock

One-To-Many Relationship: [owner owner_msdyn_conversationmessageblock](owner.md#BKMK_owner_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_conversationmessageblock"></a> team_msdyn_conversationmessageblock

One-To-Many Relationship: [team team_msdyn_conversationmessageblock](team.md#BKMK_team_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_conversationmessageblock"></a> user_msdyn_conversationmessageblock

One-To-Many Relationship: [systemuser user_msdyn_conversationmessageblock](systemuser.md#BKMK_user_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_conversationmessageblock_AsyncOperations](#BKMK_msdyn_conversationmessageblock_AsyncOperations)
- [msdyn_conversationmessageblock_BulkDeleteFailures](#BKMK_msdyn_conversationmessageblock_BulkDeleteFailures)
- [msdyn_conversationmessageblock_DuplicateBaseRecord](#BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord)
- [msdyn_conversationmessageblock_DuplicateMatchingRecord](#BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord)
- [msdyn_conversationmessageblock_MailboxTrackingFolders](#BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders)
- [msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses)
- [msdyn_conversationmessageblock_ProcessSession](#BKMK_msdyn_conversationmessageblock_ProcessSession)
- [msdyn_conversationmessageblock_SyncErrors](#BKMK_msdyn_conversationmessageblock_SyncErrors)

### <a name="BKMK_msdyn_conversationmessageblock_AsyncOperations"></a> msdyn_conversationmessageblock_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_conversationmessageblock_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationmessageblock_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_BulkDeleteFailures"></a> msdyn_conversationmessageblock_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_conversationmessageblock_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationmessageblock_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord"></a> msdyn_conversationmessageblock_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationmessageblock_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord"></a> msdyn_conversationmessageblock_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationmessageblock_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders"></a> msdyn_conversationmessageblock_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_conversationmessageblock_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses"></a> msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_ProcessSession"></a> msdyn_conversationmessageblock_ProcessSession

Many-To-One Relationship: [processsession msdyn_conversationmessageblock_ProcessSession](processsession.md#BKMK_msdyn_conversationmessageblock_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationmessageblock_SyncErrors"></a> msdyn_conversationmessageblock_SyncErrors

Many-To-One Relationship: [syncerror msdyn_conversationmessageblock_SyncErrors](syncerror.md#BKMK_msdyn_conversationmessageblock_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationmessageblock_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

