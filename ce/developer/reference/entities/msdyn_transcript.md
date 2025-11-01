---
title: "Transcript (msdyn_transcript) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Transcript (msdyn_transcript) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Transcript (msdyn_transcript) table/entity reference (Microsoft Dynamics 365)

Stores the transcript of the communication  between the user and the customer

## Messages

The following table lists the messages for the Transcript (msdyn_transcript) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_transcripts(*msdyn_transcriptid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_transcripts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_transcripts(*msdyn_transcriptid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_transcripts(*msdyn_transcriptid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_transcripts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_transcripts(*msdyn_transcriptid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_transcripts(*msdyn_transcriptid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_transcripts(*msdyn_transcriptid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Transcript (msdyn_transcript) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Transcript** |
| **DisplayCollectionName** | **Transcripts** |
| **SchemaName** | `msdyn_transcript` |
| **CollectionSchemaName** | `msdyn_transcripts` |
| **EntitySetName** | `msdyn_transcripts`|
| **LogicalName** | `msdyn_transcript` |
| **LogicalCollectionName** | `msdyn_transcripts` |
| **PrimaryIdAttribute** | `msdyn_transcriptid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_applicationid](#BKMK_msdyn_applicationid)
- [msdyn_channelinstanceid](#BKMK_msdyn_channelinstanceid)
- [msdyn_LiveWorkItemIdId](#BKMK_msdyn_LiveWorkItemIdId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_transcriptId](#BKMK_msdyn_transcriptId)
- [msdyn_transcripttarget](#BKMK_msdyn_transcripttarget)
- [msdyn_transcripttargetIdType](#BKMK_msdyn_transcripttargetIdType)
- [msdyn_transcripturi](#BKMK_msdyn_transcripturi)
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

### <a name="BKMK_msdyn_applicationid"></a> msdyn_applicationid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Application Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_applicationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_channelinstanceid"></a> msdyn_channelinstanceid

|Property|Value|
|---|---|
|Description|**Unique identifier to identify the app to which this conversation belogs to.**|
|DisplayName|**Channel Instance ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_channelinstance|

### <a name="BKMK_msdyn_LiveWorkItemIdId"></a> msdyn_LiveWorkItemIdId

|Property|Value|
|---|---|
|Description|**LiveWorkItem this Transcript belongs to**|
|DisplayName|**LiveWorkItemId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitemidid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_transcriptId"></a> msdyn_transcriptId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Transcript**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_transcripttarget"></a> msdyn_transcripttarget

|Property|Value|
|---|---|
|Description|**Unique identifier for the target object associated with the Transcript**|
|DisplayName|**Transcript target entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcripttarget`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, phonecall|

### <a name="BKMK_msdyn_transcripttargetIdType"></a> msdyn_transcripttargetIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_transcripttargetidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_transcripturi"></a> msdyn_transcripturi

|Property|Value|
|---|---|
|Description|**Transcript URI associated to the transcript**|
|DisplayName|**Transcript URI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcripturi`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the Transcript**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_transcript_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Transcript**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_transcript_statuscode`|

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
- [msdyn_englishtranslatedtranscriptformatted](#BKMK_msdyn_englishtranslatedtranscriptformatted)
- [msdyn_englishtranslatedtranscriptformatted_Name](#BKMK_msdyn_englishtranslatedtranscriptformatted_Name)
- [msdyn_rawvoicetranscript](#BKMK_msdyn_rawvoicetranscript)
- [msdyn_rawvoicetranscript_Name](#BKMK_msdyn_rawvoicetranscript_Name)
- [msdyn_voicetranscript](#BKMK_msdyn_voicetranscript)
- [msdyn_voicetranscript_formatted](#BKMK_msdyn_voicetranscript_formatted)
- [msdyn_voicetranscript_formatted_Name](#BKMK_msdyn_voicetranscript_formatted_Name)
- [msdyn_voicetranscript_Name](#BKMK_msdyn_voicetranscript_Name)
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

### <a name="BKMK_msdyn_englishtranslatedtranscriptformatted"></a> msdyn_englishtranslatedtranscriptformatted

|Property|Value|
|---|---|
|Description|**Use this field to store English translated transcript files to the system**|
|DisplayName|**Transcript file translated to English**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_englishtranslatedtranscriptformatted`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_englishtranslatedtranscriptformatted_Name"></a> msdyn_englishtranslatedtranscriptformatted_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_englishtranslatedtranscriptformatted_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_rawvoicetranscript"></a> msdyn_rawvoicetranscript

|Property|Value|
|---|---|
|Description|**Use this field to store raw voice transcript files to the system**|
|DisplayName|**Raw voice Transcript file**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawvoicetranscript`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_rawvoicetranscript_Name"></a> msdyn_rawvoicetranscript_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rawvoicetranscript_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_voicetranscript"></a> msdyn_voicetranscript

|Property|Value|
|---|---|
|Description|**Use this field to store voice transcript files to the system**|
|DisplayName|**Voice Transcript file**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voicetranscript`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_voicetranscript_formatted"></a> msdyn_voicetranscript_formatted

|Property|Value|
|---|---|
|Description|**Use this field to store formatted voice transcript files to the system**|
|DisplayName|**Formatted Voice Transcript file**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voicetranscript_formatted`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_voicetranscript_formatted_Name"></a> msdyn_voicetranscript_formatted_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_voicetranscript_formatted_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_voicetranscript_Name"></a> msdyn_voicetranscript_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_voicetranscript_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

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

- [business_unit_msdyn_transcript](#BKMK_business_unit_msdyn_transcript)
- [FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted](#BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted)
- [FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript](#BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript)
- [FileAttachment_msdyn_transcript_msdyn_voicetranscript](#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript)
- [FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted](#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted)
- [lk_msdyn_transcript_createdby](#BKMK_lk_msdyn_transcript_createdby)
- [lk_msdyn_transcript_createdonbehalfby](#BKMK_lk_msdyn_transcript_createdonbehalfby)
- [lk_msdyn_transcript_modifiedby](#BKMK_lk_msdyn_transcript_modifiedby)
- [lk_msdyn_transcript_modifiedonbehalfby](#BKMK_lk_msdyn_transcript_modifiedonbehalfby)
- [msdyn_appointment_msdyn_transcript_transcripttarget](#BKMK_msdyn_appointment_msdyn_transcript_transcripttarget)
- [msdyn_msdyn_ocliveworkitem_msdyn_transcript](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript)
- [msdyn_msdyn_transcript_msdyn_channelinstance](#BKMK_msdyn_msdyn_transcript_msdyn_channelinstance)
- [msdyn_phonecall_msdyn_transcript_transcripttarget](#BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget)
- [owner_msdyn_transcript](#BKMK_owner_msdyn_transcript)
- [team_msdyn_transcript](#BKMK_team_msdyn_transcript)
- [user_msdyn_transcript](#BKMK_user_msdyn_transcript)

### <a name="BKMK_business_unit_msdyn_transcript"></a> business_unit_msdyn_transcript

One-To-Many Relationship: [businessunit business_unit_msdyn_transcript](businessunit.md#BKMK_business_unit_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted"></a> FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted](fileattachment.md#BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_englishtranslatedtranscriptformatted`|
|ReferencingEntityNavigationPropertyName|`msdyn_englishtranslatedtranscriptformatted`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript"></a> FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript](fileattachment.md#BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_rawvoicetranscript`|
|ReferencingEntityNavigationPropertyName|`msdyn_rawvoicetranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript"></a> FileAttachment_msdyn_transcript_msdyn_voicetranscript

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_transcript_msdyn_voicetranscript](fileattachment.md#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_voicetranscript`|
|ReferencingEntityNavigationPropertyName|`msdyn_voicetranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted"></a> FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted](fileattachment.md#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_voicetranscript_formatted`|
|ReferencingEntityNavigationPropertyName|`msdyn_voicetranscript_formatted`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_transcript_createdby"></a> lk_msdyn_transcript_createdby

One-To-Many Relationship: [systemuser lk_msdyn_transcript_createdby](systemuser.md#BKMK_lk_msdyn_transcript_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_transcript_createdonbehalfby"></a> lk_msdyn_transcript_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_transcript_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_transcript_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_transcript_modifiedby"></a> lk_msdyn_transcript_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_transcript_modifiedby](systemuser.md#BKMK_lk_msdyn_transcript_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_transcript_modifiedonbehalfby"></a> lk_msdyn_transcript_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_transcript_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_transcript_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_appointment_msdyn_transcript_transcripttarget"></a> msdyn_appointment_msdyn_transcript_transcripttarget

One-To-Many Relationship: [appointment msdyn_appointment_msdyn_transcript_transcripttarget](appointment.md#BKMK_msdyn_appointment_msdyn_transcript_transcripttarget)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_transcripttarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_transcripttarget_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript"></a> msdyn_msdyn_ocliveworkitem_msdyn_transcript

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_transcript](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitemidid`|
|ReferencingEntityNavigationPropertyName|`msdyn_LiveWorkItemIdId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_transcript_msdyn_channelinstance"></a> msdyn_msdyn_transcript_msdyn_channelinstance

One-To-Many Relationship: [msdyn_channelinstance msdyn_msdyn_transcript_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_msdyn_msdyn_transcript_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstance`|
|ReferencedAttribute|`msdyn_channelinstanceid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget"></a> msdyn_phonecall_msdyn_transcript_transcripttarget

One-To-Many Relationship: [phonecall msdyn_phonecall_msdyn_transcript_transcripttarget](phonecall.md#BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_transcripttarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_transcripttarget_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_transcript"></a> owner_msdyn_transcript

One-To-Many Relationship: [owner owner_msdyn_transcript](owner.md#BKMK_owner_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_transcript"></a> team_msdyn_transcript

One-To-Many Relationship: [team team_msdyn_transcript](team.md#BKMK_team_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_transcript"></a> user_msdyn_transcript

One-To-Many Relationship: [systemuser user_msdyn_transcript](systemuser.md#BKMK_user_msdyn_transcript)

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

- [msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr](#BKMK_msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr)
- [msdyn_msdyn_sciconversation_Transcript_msdyn_tr](#BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr)
- [msdyn_transcript_Annotations](#BKMK_msdyn_transcript_Annotations)
- [msdyn_transcript_AsyncOperations](#BKMK_msdyn_transcript_AsyncOperations)
- [msdyn_transcript_BulkDeleteFailures](#BKMK_msdyn_transcript_BulkDeleteFailures)
- [msdyn_transcript_FileAttachments](#BKMK_msdyn_transcript_FileAttachments)
- [msdyn_transcript_MailboxTrackingFolders](#BKMK_msdyn_transcript_MailboxTrackingFolders)
- [msdyn_transcript_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transcript_PrincipalObjectAttributeAccesses)
- [msdyn_transcript_ProcessSession](#BKMK_msdyn_transcript_ProcessSession)
- [msdyn_transcript_SyncErrors](#BKMK_msdyn_transcript_SyncErrors)

### <a name="BKMK_msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr"></a> msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr

Many-To-One Relationship: [msdyn_conversationcomment msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr](msdyn_conversationcomment.md#BKMK_msdyn_msdyn_conversationcomment_Transcript_msdyn_transcr)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationcomment`|
|ReferencingAttribute|`msdyn_transcript`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationcomment_transcript_msdyn_transcr`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr"></a> msdyn_msdyn_sciconversation_Transcript_msdyn_tr

Many-To-One Relationship: [msdyn_sciconversation msdyn_msdyn_sciconversation_Transcript_msdyn_tr](msdyn_sciconversation.md#BKMK_msdyn_msdyn_sciconversation_Transcript_msdyn_tr)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`msdyn_transcript`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sciconversation_transcript_msdyn_tr`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_Annotations"></a> msdyn_transcript_Annotations

Many-To-One Relationship: [annotation msdyn_transcript_Annotations](annotation.md#BKMK_msdyn_transcript_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_AsyncOperations"></a> msdyn_transcript_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_transcript_AsyncOperations](asyncoperation.md#BKMK_msdyn_transcript_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_BulkDeleteFailures"></a> msdyn_transcript_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_transcript_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_transcript_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_FileAttachments"></a> msdyn_transcript_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_transcript_FileAttachments](fileattachment.md#BKMK_msdyn_transcript_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_MailboxTrackingFolders"></a> msdyn_transcript_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_transcript_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_transcript_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_PrincipalObjectAttributeAccesses"></a> msdyn_transcript_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_transcript_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_transcript_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_ProcessSession"></a> msdyn_transcript_ProcessSession

Many-To-One Relationship: [processsession msdyn_transcript_ProcessSession](processsession.md#BKMK_msdyn_transcript_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transcript_SyncErrors"></a> msdyn_transcript_SyncErrors

Many-To-One Relationship: [syncerror msdyn_transcript_SyncErrors](syncerror.md#BKMK_msdyn_transcript_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_transcript_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

