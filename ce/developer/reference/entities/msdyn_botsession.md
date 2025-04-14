---
title: "Bot Session (msdyn_botsession) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Bot Session (msdyn_botsession) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Bot Session (msdyn_botsession) table/entity reference (Microsoft Dynamics 365)

Bot specific sessions

## Messages

The following table lists the messages for the Bot Session (msdyn_botsession) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_botsessions(*msdyn_botsessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_botsessions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_botsessions(*msdyn_botsessionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_botsessions(*msdyn_botsessionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_botsessions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_botsessions(*msdyn_botsessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_botsessions(*msdyn_botsessionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_botsessions(*msdyn_botsessionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Bot Session (msdyn_botsession) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Bot Session** |
| **DisplayCollectionName** | **Bot Sessions** |
| **SchemaName** | `msdyn_botsession` |
| **CollectionSchemaName** | `msdyn_botsessions` |
| **EntitySetName** | `msdyn_botsessions`|
| **LogicalName** | `msdyn_botsession` |
| **LogicalCollectionName** | `msdyn_botsessions` |
| **PrimaryIdAttribute** | `msdyn_botsessionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_botid](#BKMK_msdyn_botid)
- [msdyn_botsessionId](#BKMK_msdyn_botsessionId)
- [msdyn_csatscore](#BKMK_msdyn_csatscore)
- [msdyn_endedon](#BKMK_msdyn_endedon)
- [msdyn_isengaged](#BKMK_msdyn_isengaged)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_outcome](#BKMK_msdyn_outcome)
- [msdyn_outcomereason](#BKMK_msdyn_outcomereason)
- [msdyn_sessionid](#BKMK_msdyn_sessionid)
- [msdyn_sourcesessionid](#BKMK_msdyn_sourcesessionid)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_topicid](#BKMK_msdyn_topicid)
- [msdyn_topicname](#BKMK_msdyn_topicname)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_botid"></a> msdyn_botid

|Property|Value|
|---|---|
|Description|**botId of Chatbot entity for lookup**|
|DisplayName|**Bot Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|bot|

### <a name="BKMK_msdyn_botsessionId"></a> msdyn_botsessionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Bot Session Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_botsessionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_csatscore"></a> msdyn_csatscore

|Property|Value|
|---|---|
|Description|**Customer satisfaction (CSAT) scores for sessions in which customers respond to an end-of-session request to take the survey. (1-5)**|
|DisplayName|**Bot Session CSAT Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_csatscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|5|
|MinValue|1|

### <a name="BKMK_msdyn_endedon"></a> msdyn_endedon

|Property|Value|
|---|---|
|Description|**UTC Date and time when session ended**|
|DisplayName|**Bot Session Ended On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_isengaged"></a> msdyn_isengaged

|Property|Value|
|---|---|
|Description|**Boolean which mentions if the PVA session is Engaged**|
|DisplayName|**Bot Session IsEngaged**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isengaged`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_botsession_msdyn_isengaged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msdyn_outcome"></a> msdyn_outcome

|Property|Value|
|---|---|
|Description|**Bot Session Outcome:  None, Resolved or Escalated or Abandoned from option, sessionoutcome**|
|DisplayName|**Bot Session Outcome**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outcome`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|419550000|
|GlobalChoiceName|`msdyn_sessionoutcome`|

#### msdyn_outcome Choices/Options

|Value|Label|
|---|---|
|419550000|**none**|
|419550001|**resolved**|
|419550002|**escalated**|
|419550003|**abandoned**|

### <a name="BKMK_msdyn_outcomereason"></a> msdyn_outcomereason

|Property|Value|
|---|---|
|Description|**Bot Session Outcome Reason:  NoError, UserError, SystemError, UserExit, AgentTransferWithoutError, AgentTransferRequestedByUser, Resolved, AgentTransferConfiguredByAuthor, or AgentTransferFromQuestionMaxAttempts from option, sessionoutcomereason**|
|DisplayName|**Bot Session Outcome Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outcomereason`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|419560000|
|GlobalChoiceName|`msdyn_sessionoutcomereason`|

#### msdyn_outcomereason Choices/Options

|Value|Label|
|---|---|
|419560000|**noError**|
|419560001|**userError**|
|419560002|**systemError**|
|419560003|**userExit**|
|419560004|**agentTransferWithoutError**|
|419560005|**agentTransferRequestedByUser**|
|419560006|**resolved**|
|419560007|**agentTransferConfiguredByAuthor**|
|419560008|**agentTransferFromQuestionMaxAttempts**|

### <a name="BKMK_msdyn_sessionid"></a> msdyn_sessionid

|Property|Value|
|---|---|
|Description|**Omnichannel Session Id**|
|DisplayName|**Omnichannel Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_sourcesessionid"></a> msdyn_sourcesessionid

|Property|Value|
|---|---|
|Description|**A unique identifier for the session per source system.**|
|DisplayName|**Source Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourcesessionid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|---|---|
|Description|**UTC Date and time when session started**|
|DisplayName|**Bot Session Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startedon`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_topicid"></a> msdyn_topicid

|Property|Value|
|---|---|
|Description|**A unique identifier of the topic that triggered the session**|
|DisplayName|**Bot Session Topic Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topicid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_topicname"></a> msdyn_topicname

|Property|Value|
|---|---|
|Description|**The display name of the name of the topic that triggered the session**|
|DisplayName|**Bot Session Topic Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topicname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**System user id for the bot (Application user id)**|
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
|Description|**Status of the botsession**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_botsession_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the botsession**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_botsession_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|Description|**Unique identifier for the team that owns the record.**|
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
|Description|**Unique identifier for the user that owns the record.**|
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

- [business_unit_msdyn_botsession](#BKMK_business_unit_msdyn_botsession)
- [lk_msdyn_botsession_createdby](#BKMK_lk_msdyn_botsession_createdby)
- [lk_msdyn_botsession_createdonbehalfby](#BKMK_lk_msdyn_botsession_createdonbehalfby)
- [lk_msdyn_botsession_modifiedby](#BKMK_lk_msdyn_botsession_modifiedby)
- [lk_msdyn_botsession_modifiedonbehalfby](#BKMK_lk_msdyn_botsession_modifiedonbehalfby)
- [msdyn_msdyn_botsession_botid_bot](#BKMK_msdyn_msdyn_botsession_botid_bot)
- [msdyn_msdyn_botsession_sessionid_msdyn_oc](#BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc)
- [owner_msdyn_botsession](#BKMK_owner_msdyn_botsession)
- [team_msdyn_botsession](#BKMK_team_msdyn_botsession)
- [user_msdyn_botsession](#BKMK_user_msdyn_botsession)

### <a name="BKMK_business_unit_msdyn_botsession"></a> business_unit_msdyn_botsession

One-To-Many Relationship: [businessunit business_unit_msdyn_botsession](businessunit.md#BKMK_business_unit_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_botsession_createdby"></a> lk_msdyn_botsession_createdby

One-To-Many Relationship: [systemuser lk_msdyn_botsession_createdby](systemuser.md#BKMK_lk_msdyn_botsession_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_botsession_createdonbehalfby"></a> lk_msdyn_botsession_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_botsession_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_botsession_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_botsession_modifiedby"></a> lk_msdyn_botsession_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_botsession_modifiedby](systemuser.md#BKMK_lk_msdyn_botsession_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_botsession_modifiedonbehalfby"></a> lk_msdyn_botsession_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_botsession_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_botsession_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_botsession_botid_bot"></a> msdyn_msdyn_botsession_botid_bot

One-To-Many Relationship: [bot msdyn_msdyn_botsession_botid_bot](bot.md#BKMK_msdyn_msdyn_botsession_botid_bot)

|Property|Value|
|---|---|
|ReferencedEntity|`bot`|
|ReferencedAttribute|`botid`|
|ReferencingAttribute|`msdyn_botid`|
|ReferencingEntityNavigationPropertyName|`msdyn_botid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc"></a> msdyn_msdyn_botsession_sessionid_msdyn_oc

One-To-Many Relationship: [msdyn_ocsession msdyn_msdyn_botsession_sessionid_msdyn_oc](msdyn_ocsession.md#BKMK_msdyn_msdyn_botsession_sessionid_msdyn_oc)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_sessionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_sessionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_botsession"></a> owner_msdyn_botsession

One-To-Many Relationship: [owner owner_msdyn_botsession](owner.md#BKMK_owner_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_botsession"></a> team_msdyn_botsession

One-To-Many Relationship: [team team_msdyn_botsession](team.md#BKMK_team_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_botsession"></a> user_msdyn_botsession

One-To-Many Relationship: [systemuser user_msdyn_botsession](systemuser.md#BKMK_user_msdyn_botsession)

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

- [msdyn_botsession_AsyncOperations](#BKMK_msdyn_botsession_AsyncOperations)
- [msdyn_botsession_BulkDeleteFailures](#BKMK_msdyn_botsession_BulkDeleteFailures)
- [msdyn_botsession_DuplicateBaseRecord](#BKMK_msdyn_botsession_DuplicateBaseRecord)
- [msdyn_botsession_DuplicateMatchingRecord](#BKMK_msdyn_botsession_DuplicateMatchingRecord)
- [msdyn_botsession_MailboxTrackingFolders](#BKMK_msdyn_botsession_MailboxTrackingFolders)
- [msdyn_botsession_PrincipalObjectAttributeAccesses](#BKMK_msdyn_botsession_PrincipalObjectAttributeAccesses)
- [msdyn_botsession_ProcessSession](#BKMK_msdyn_botsession_ProcessSession)
- [msdyn_botsession_SyncErrors](#BKMK_msdyn_botsession_SyncErrors)

### <a name="BKMK_msdyn_botsession_AsyncOperations"></a> msdyn_botsession_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_botsession_AsyncOperations](asyncoperation.md#BKMK_msdyn_botsession_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_BulkDeleteFailures"></a> msdyn_botsession_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_botsession_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_botsession_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_DuplicateBaseRecord"></a> msdyn_botsession_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_botsession_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_botsession_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_DuplicateMatchingRecord"></a> msdyn_botsession_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_botsession_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_botsession_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_MailboxTrackingFolders"></a> msdyn_botsession_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_botsession_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_botsession_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_PrincipalObjectAttributeAccesses"></a> msdyn_botsession_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_botsession_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_botsession_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_ProcessSession"></a> msdyn_botsession_ProcessSession

Many-To-One Relationship: [processsession msdyn_botsession_ProcessSession](processsession.md#BKMK_msdyn_botsession_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_botsession_SyncErrors"></a> msdyn_botsession_SyncErrors

Many-To-One Relationship: [syncerror msdyn_botsession_SyncErrors](syncerror.md#BKMK_msdyn_botsession_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_botsession_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

