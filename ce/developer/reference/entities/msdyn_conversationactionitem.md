---
title: "Conversation Action Item (msdyn_ConversationActionItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Action Item (msdyn_ConversationActionItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Action Item (msdyn_ConversationActionItem) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Conversation Action Item (msdyn_ConversationActionItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_conversationactionitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_conversationactionitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_conversationactionitems(*msdyn_conversationactionitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Action Item (msdyn_ConversationActionItem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Action Item** |
| **DisplayCollectionName** | **Conversation Action Items** |
| **SchemaName** | `msdyn_ConversationActionItem` |
| **CollectionSchemaName** | `msdyn_ConversationActionItems` |
| **EntitySetName** | `msdyn_conversationactionitems`|
| **LogicalName** | `msdyn_conversationactionitem` |
| **LogicalCollectionName** | `msdyn_conversationactionitems` |
| **PrimaryIdAttribute** | `msdyn_conversationactionitemid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActionItemJSON](#BKMK_msdyn_ActionItemJSON)
- [msdyn_ConversationActionItemId](#BKMK_msdyn_ConversationActionItemId)
- [msdyn_ConversationParticipantInsights](#BKMK_msdyn_ConversationParticipantInsights)
- [msdyn_CreatedActivity](#BKMK_msdyn_CreatedActivity)
- [msdyn_CreatedActivityIdType](#BKMK_msdyn_CreatedActivityIdType)
- [msdyn_DefaultText](#BKMK_msdyn_DefaultText)
- [msdyn_DurationInMS](#BKMK_msdyn_DurationInMS)
- [msdyn_ExternalResourceUri](#BKMK_msdyn_ExternalResourceUri)
- [msdyn_FragmentEnd](#BKMK_msdyn_FragmentEnd)
- [msdyn_FragmentStart](#BKMK_msdyn_FragmentStart)
- [msdyn_Locale](#BKMK_msdyn_Locale)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_OffsetInMS](#BKMK_msdyn_OffsetInMS)
- [msdyn_State](#BKMK_msdyn_State)
- [msdyn_Type](#BKMK_msdyn_Type)
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

### <a name="BKMK_msdyn_ActionItemJSON"></a> msdyn_ActionItemJSON

|Property|Value|
|---|---|
|Description||
|DisplayName|**ActionItemJSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionitemjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ConversationActionItemId"></a> msdyn_ConversationActionItemId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Conversation Action Item**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationactionitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ConversationParticipantInsights"></a> msdyn_ConversationParticipantInsights

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConversationParticipantInsights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationparticipantinsights`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_conversationparticipantinsights|

### <a name="BKMK_msdyn_CreatedActivity"></a> msdyn_CreatedActivity

|Property|Value|
|---|---|
|Description||
|DisplayName|**CreatedActivity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdactivity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, email, phonecall, task|

### <a name="BKMK_msdyn_CreatedActivityIdType"></a> msdyn_CreatedActivityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_createdactivityidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_DefaultText"></a> msdyn_DefaultText

|Property|Value|
|---|---|
|Description||
|DisplayName|**DefaultText**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaulttext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_DurationInMS"></a> msdyn_DurationInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**DurationInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationinms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_ExternalResourceUri"></a> msdyn_ExternalResourceUri

|Property|Value|
|---|---|
|Description||
|DisplayName|**ExternalResourceUri**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externalresourceuri`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_FragmentEnd"></a> msdyn_FragmentEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**FragmentEnd**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fragmentend`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_FragmentStart"></a> msdyn_FragmentStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**FragmentStart**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fragmentstart`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Locale"></a> msdyn_Locale

|Property|Value|
|---|---|
|Description||
|DisplayName|**Locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locale`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ci_locale`|

#### msdyn_Locale Choices/Options

|Value|Label|
|---|---|
|0|**en-us**|
|10|**en-gb**|
|20|**de-de**|
|30|**fr-fr**|
|40|**it-it**|
|50|**es-es**|
|60|**es-mx**|
|70|**ja-jp**|
|80|**pt-br**|
|90|**zh-cn**|
|110|**nl-nl**|
|120|**fr-ca**|
|130|**pt-pt**|
|140|**ar-ae**|
|150|**ar-bh**|
|160|**ar-eg**|
|170|**ar-iq**|
|180|**ar-jo**|
|190|**ar-kw**|
|200|**ar-lb**|
|210|**ar-om**|
|220|**ar-qa**|
|230|**ar-sa**|
|240|**ar-sy**|
|250|**he-il**|
|260|**da-dk**|
|270|**sv-se**|
|280|**fi-fi**|
|290|**nb-no**|
|300|**el-gr**|
|310|**cs-cz**|
|320|**ko-kr**|
|330|**pl-pl**|
|340|**ru-ru**|
|350|**th-th**|
|360|**tr-tr**|

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

### <a name="BKMK_msdyn_OffsetInMS"></a> msdyn_OffsetInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**OffsetInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offsetinms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_State"></a> msdyn_State

|Property|Value|
|---|---|
|Description||
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_state`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationactionitem_msdyn_state`|

#### msdyn_State Choices/Options

|Value|Label|
|---|---|
|0|**Commited**|
|1|**Suggested**|

### <a name="BKMK_msdyn_Type"></a> msdyn_Type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationactionitem_msdyn_type`|

#### msdyn_Type Choices/Options

|Value|Label|
|---|---|
|0|**Phonecall**|
|1|**Appointment**|
|2|**Email**|
|3|**Task**|
|4|**None**|

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
|Description|**Status of the Conversation Action Item**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationactionitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Conversation Action Item**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationactionitem_statuscode`|

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

- [business_unit_msdyn_conversationactionitem](#BKMK_business_unit_msdyn_conversationactionitem)
- [lk_msdyn_conversationactionitem_createdby](#BKMK_lk_msdyn_conversationactionitem_createdby)
- [lk_msdyn_conversationactionitem_createdonbehalfby](#BKMK_lk_msdyn_conversationactionitem_createdonbehalfby)
- [lk_msdyn_conversationactionitem_modifiedby](#BKMK_lk_msdyn_conversationactionitem_modifiedby)
- [lk_msdyn_conversationactionitem_modifiedonbehalfby](#BKMK_lk_msdyn_conversationactionitem_modifiedonbehalfby)
- [msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity)
- [msdyn_msdyn_conversationactionitem_Conversation](#BKMK_msdyn_msdyn_conversationactionitem_Conversation)
- [msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity)
- [msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity)
- [msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity)
- [owner_msdyn_conversationactionitem](#BKMK_owner_msdyn_conversationactionitem)
- [team_msdyn_conversationactionitem](#BKMK_team_msdyn_conversationactionitem)
- [user_msdyn_conversationactionitem](#BKMK_user_msdyn_conversationactionitem)

### <a name="BKMK_business_unit_msdyn_conversationactionitem"></a> business_unit_msdyn_conversationactionitem

One-To-Many Relationship: [businessunit business_unit_msdyn_conversationactionitem](businessunit.md#BKMK_business_unit_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationactionitem_createdby"></a> lk_msdyn_conversationactionitem_createdby

One-To-Many Relationship: [systemuser lk_msdyn_conversationactionitem_createdby](systemuser.md#BKMK_lk_msdyn_conversationactionitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationactionitem_createdonbehalfby"></a> lk_msdyn_conversationactionitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationactionitem_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationactionitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationactionitem_modifiedby"></a> lk_msdyn_conversationactionitem_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_conversationactionitem_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationactionitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationactionitem_modifiedonbehalfby"></a> lk_msdyn_conversationactionitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationactionitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationactionitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity

One-To-Many Relationship: [appointment msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity](appointment.md#BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_createdactivity_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_Conversation"></a> msdyn_msdyn_conversationactionitem_Conversation

One-To-Many Relationship: [msdyn_conversationparticipantinsights msdyn_msdyn_conversationactionitem_Conversation](msdyn_conversationparticipantinsights.md#BKMK_msdyn_msdyn_conversationactionitem_Conversation)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationparticipantinsights`|
|ReferencedAttribute|`msdyn_conversationparticipantinsightsid`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationparticipantinsights`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity

One-To-Many Relationship: [email msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity](email.md#BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_createdactivity_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity

One-To-Many Relationship: [phonecall msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity](phonecall.md#BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_createdactivity_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity

One-To-Many Relationship: [task msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity](task.md#BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`task`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencingEntityNavigationPropertyName|`msdyn_createdactivity_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_conversationactionitem"></a> owner_msdyn_conversationactionitem

One-To-Many Relationship: [owner owner_msdyn_conversationactionitem](owner.md#BKMK_owner_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_conversationactionitem"></a> team_msdyn_conversationactionitem

One-To-Many Relationship: [team team_msdyn_conversationactionitem](team.md#BKMK_team_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_conversationactionitem"></a> user_msdyn_conversationactionitem

One-To-Many Relationship: [systemuser user_msdyn_conversationactionitem](systemuser.md#BKMK_user_msdyn_conversationactionitem)

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

- [msdyn_conversationactionitem_AsyncOperations](#BKMK_msdyn_conversationactionitem_AsyncOperations)
- [msdyn_conversationactionitem_BulkDeleteFailures](#BKMK_msdyn_conversationactionitem_BulkDeleteFailures)
- [msdyn_conversationactionitem_DuplicateBaseRecord](#BKMK_msdyn_conversationactionitem_DuplicateBaseRecord)
- [msdyn_conversationactionitem_DuplicateMatchingRecord](#BKMK_msdyn_conversationactionitem_DuplicateMatchingRecord)
- [msdyn_conversationactionitem_MailboxTrackingFolders](#BKMK_msdyn_conversationactionitem_MailboxTrackingFolders)
- [msdyn_conversationactionitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationactionitem_PrincipalObjectAttributeAccesses)
- [msdyn_conversationactionitem_ProcessSession](#BKMK_msdyn_conversationactionitem_ProcessSession)
- [msdyn_conversationactionitem_SyncErrors](#BKMK_msdyn_conversationactionitem_SyncErrors)

### <a name="BKMK_msdyn_conversationactionitem_AsyncOperations"></a> msdyn_conversationactionitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_conversationactionitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationactionitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_BulkDeleteFailures"></a> msdyn_conversationactionitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_conversationactionitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationactionitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_DuplicateBaseRecord"></a> msdyn_conversationactionitem_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationactionitem_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_conversationactionitem_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_DuplicateMatchingRecord"></a> msdyn_conversationactionitem_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationactionitem_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_conversationactionitem_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_MailboxTrackingFolders"></a> msdyn_conversationactionitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_conversationactionitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationactionitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_PrincipalObjectAttributeAccesses"></a> msdyn_conversationactionitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_conversationactionitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationactionitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_ProcessSession"></a> msdyn_conversationactionitem_ProcessSession

Many-To-One Relationship: [processsession msdyn_conversationactionitem_ProcessSession](processsession.md#BKMK_msdyn_conversationactionitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationactionitem_SyncErrors"></a> msdyn_conversationactionitem_SyncErrors

Many-To-One Relationship: [syncerror msdyn_conversationactionitem_SyncErrors](syncerror.md#BKMK_msdyn_conversationactionitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationactionitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

