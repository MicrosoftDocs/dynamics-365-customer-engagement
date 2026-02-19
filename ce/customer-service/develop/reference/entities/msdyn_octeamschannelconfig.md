---
title: "Microsoft Teams account (msdyn_octeamschannelconfig) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Microsoft Teams account (msdyn_octeamschannelconfig) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Microsoft Teams account (msdyn_octeamschannelconfig) table/entity reference (Microsoft Dynamics 365 Customer Service)

Microsoft Teams accounts for Omnichannel integration

## Messages

The following table lists the messages for the Microsoft Teams account (msdyn_octeamschannelconfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_octeamschannelconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_octeamschannelconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_octeamschannelconfigs(*msdyn_octeamschannelconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Microsoft Teams account (msdyn_octeamschannelconfig) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Microsoft Teams account** |
| **DisplayCollectionName** | **Microsoft Teams accounts** |
| **SchemaName** | `msdyn_octeamschannelconfig` |
| **CollectionSchemaName** | `msdyn_octeamschannelconfigs` |
| **EntitySetName** | `msdyn_octeamschannelconfigs`|
| **LogicalName** | `msdyn_octeamschannelconfig` |
| **LogicalCollectionName** | `msdyn_octeamschannelconfigs` |
| **PrimaryIdAttribute** | `msdyn_octeamschannelconfigid` |
| **PrimaryNameAttribute** |`msdyn_teamsappname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_botid](#BKMK_msdyn_botid)
- [msdyn_callingoptions](#BKMK_msdyn_callingoptions)
- [msdyn_enablefileattachmentsforagents](#BKMK_msdyn_enablefileattachmentsforagents)
- [msdyn_enablefileattachmentsforcustomers](#BKMK_msdyn_enablefileattachmentsforcustomers)
- [msdyn_enablerealtimelanguagetranslation](#BKMK_msdyn_enablerealtimelanguagetranslation)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_octeamschannelconfigId](#BKMK_msdyn_octeamschannelconfigId)
- [msdyn_ocwidgetlanguage](#BKMK_msdyn_ocwidgetlanguage)
- [msdyn_PostConversationSurvey](#BKMK_msdyn_PostConversationSurvey)
- [msdyn_PostConversationSurveyBotSurvey](#BKMK_msdyn_PostConversationSurveyBotSurvey)
- [msdyn_PostConversationSurveyBotSurveyMessageText](#BKMK_msdyn_PostConversationSurveyBotSurveyMessageText)
- [msdyn_PostConversationSurveyBotSurveyMode](#BKMK_msdyn_PostConversationSurveyBotSurveyMode)
- [msdyn_PostConversationSurveyEnable](#BKMK_msdyn_PostConversationSurveyEnable)
- [msdyn_PostConversationSurveyMessageText](#BKMK_msdyn_PostConversationSurveyMessageText)
- [msdyn_PostConversationSurveyMode](#BKMK_msdyn_PostConversationSurveyMode)
- [msdyn_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_PostConversationSurveySeparateBotSurvey)
- [msdyn_teamsappname](#BKMK_msdyn_teamsappname)
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
|Description|**Bot ID is of Teams Channel**|
|DisplayName|**Bot ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_callingoptions"></a> msdyn_callingoptions

|Property|Value|
|---|---|
|Description|**List of calling options available for the Teams channel**|
|DisplayName|**Calling options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callingoptions`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_occallingoptions`|

#### msdyn_callingoptions Choices/Options

|Value|Label|
|---|---|
|192350000|**No calling**|
|192350001|**Video and voice calling**|
|192350002|**Voice only**|

### <a name="BKMK_msdyn_enablefileattachmentsforagents"></a> msdyn_enablefileattachmentsforagents

|Property|Value|
|---|---|
|Description|**Option set to enable or disable attachments for agents**|
|DisplayName|**Enable file attachments for agents**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforagents`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_octeamschannelconfig_msdyn_enablefileattachmentsforagents`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablefileattachmentsforcustomers"></a> msdyn_enablefileattachmentsforcustomers

|Property|Value|
|---|---|
|Description|**Option set to enable or disable attachments for customers**|
|DisplayName|**Enable file attachments for customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforcustomers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_octeamschannelconfig_msdyn_enablefileattachmentsforcustomers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablerealtimelanguagetranslation"></a> msdyn_enablerealtimelanguagetranslation

|Property|Value|
|---|---|
|Description|**Enable Real Time Language Translation**|
|DisplayName|**msdyn\_enablerealtimelanguagetranslation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablerealtimelanguagetranslation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_octeamschannelconfig_msdyn_enablerealtimelanguagetranslation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Work Stream**|
|DisplayName|**Work Stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

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

### <a name="BKMK_msdyn_octeamschannelconfigId"></a> msdyn_octeamschannelconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Teams Channel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_octeamschannelconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocwidgetlanguage"></a> msdyn_ocwidgetlanguage

|Property|Value|
|---|---|
|Description|**The language setting for the Teams account**|
|DisplayName|**Teams account language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocwidgetlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_PostConversationSurvey"></a> msdyn_PostConversationSurvey

|Property|Value|
|---|---|
|Description|**Lookup to Dynamics 365 Customer Voice survey field**|
|DisplayName|**Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurvey`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msfp_survey|

### <a name="BKMK_msdyn_PostConversationSurveyBotSurvey"></a> msdyn_PostConversationSurveyBotSurvey

|Property|Value|
|---|---|
|Description|**Enable or disable bot survey**|
|DisplayName|**Bot Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurvey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_teams_postconversationsurveybotsurvey`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PostConversationSurveyBotSurveyMessageText"></a> msdyn_PostConversationSurveyBotSurveyMessageText

|Property|Value|
|---|---|
|Description|**Prefix text for survey link message that will be sent to the user.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurveymessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_PostConversationSurveyBotSurveyMode"></a> msdyn_PostConversationSurveyBotSurveyMode

|Property|Value|
|---|---|
|Description|**Mode of the survey to be sent**|
|DisplayName|**Survey Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurveymode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_postconversationsurveymode`|

#### msdyn_PostConversationSurveyBotSurveyMode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_PostConversationSurveyEnable"></a> msdyn_PostConversationSurveyEnable

|Property|Value|
|---|---|
|Description|**To enable or disable post conversation survey**|
|DisplayName|**Enable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveyenable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_postconversationsurveyenable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PostConversationSurveyMessageText"></a> msdyn_PostConversationSurveyMessageText

|Property|Value|
|---|---|
|Description|**Prefix text for survey link message that will be sent to the user.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveymessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_PostConversationSurveyMode"></a> msdyn_PostConversationSurveyMode

|Property|Value|
|---|---|
|Description|**Mode of the survey to be sent**|
|DisplayName|**Survey Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveymode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_postconversationsurveymode`|

#### msdyn_PostConversationSurveyMode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_PostConversationSurveySeparateBotSurvey"></a> msdyn_PostConversationSurveySeparateBotSurvey

|Property|Value|
|---|---|
|Description|**Lookup to Dynamics 365 Customer Voice survey field**|
|DisplayName|**Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveyseparatebotsurvey`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msfp_survey|

### <a name="BKMK_msdyn_teamsappname"></a> msdyn_teamsappname

|Property|Value|
|---|---|
|Description|**Teams App Name or Teams Channel**|
|DisplayName|**Teams App Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsappname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Teams Channel**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_octeamschannelconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Teams Channel**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_octeamschannelconfig_statuscode`|

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

- [business_unit_msdyn_octeamschannelconfig](#BKMK_business_unit_msdyn_octeamschannelconfig)
- [lk_msdyn_octeamschannelconfig_createdby](#BKMK_lk_msdyn_octeamschannelconfig_createdby)
- [lk_msdyn_octeamschannelconfig_createdonbehalfby](#BKMK_lk_msdyn_octeamschannelconfig_createdonbehalfby)
- [lk_msdyn_octeamschannelconfig_modifiedby](#BKMK_lk_msdyn_octeamschannelconfig_modifiedby)
- [lk_msdyn_octeamschannelconfig_modifiedonbehalfby](#BKMK_lk_msdyn_octeamschannelconfig_modifiedonbehalfby)
- [msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid](#BKMK_msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid)
- [msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage)
- [msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey](#BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey)
- [msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey)
- [owner_msdyn_octeamschannelconfig](#BKMK_owner_msdyn_octeamschannelconfig)
- [team_msdyn_octeamschannelconfig](#BKMK_team_msdyn_octeamschannelconfig)
- [user_msdyn_octeamschannelconfig](#BKMK_user_msdyn_octeamschannelconfig)

### <a name="BKMK_business_unit_msdyn_octeamschannelconfig"></a> business_unit_msdyn_octeamschannelconfig

One-To-Many Relationship: [businessunit business_unit_msdyn_octeamschannelconfig](businessunit.md#BKMK_business_unit_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_octeamschannelconfig_createdby"></a> lk_msdyn_octeamschannelconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_octeamschannelconfig_createdby](systemuser.md#BKMK_lk_msdyn_octeamschannelconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_octeamschannelconfig_createdonbehalfby"></a> lk_msdyn_octeamschannelconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_octeamschannelconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_octeamschannelconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_octeamschannelconfig_modifiedby"></a> lk_msdyn_octeamschannelconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_octeamschannelconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_octeamschannelconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_octeamschannelconfig_modifiedonbehalfby"></a> lk_msdyn_octeamschannelconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_octeamschannelconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_octeamschannelconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid"></a> msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_octeamschannelconfig_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage"></a> msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey"></a> msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey"></a> msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_octeamschannelconfig_PostConversationSurveySeparateBotSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurveyseparatebotsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurveySeparateBotSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_octeamschannelconfig"></a> owner_msdyn_octeamschannelconfig

One-To-Many Relationship: [owner owner_msdyn_octeamschannelconfig](owner.md#BKMK_owner_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_octeamschannelconfig"></a> team_msdyn_octeamschannelconfig

One-To-Many Relationship: [team team_msdyn_octeamschannelconfig](team.md#BKMK_team_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_octeamschannelconfig"></a> user_msdyn_octeamschannelconfig

One-To-Many Relationship: [systemuser user_msdyn_octeamschannelconfig](systemuser.md#BKMK_user_msdyn_octeamschannelconfig)

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

- [msdyn_octeamschannelconfig_AsyncOperations](#BKMK_msdyn_octeamschannelconfig_AsyncOperations)
- [msdyn_octeamschannelconfig_BulkDeleteFailures](#BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures)
- [msdyn_octeamschannelconfig_DuplicateBaseRecord](#BKMK_msdyn_octeamschannelconfig_DuplicateBaseRecord)
- [msdyn_octeamschannelconfig_DuplicateMatchingRecord](#BKMK_msdyn_octeamschannelconfig_DuplicateMatchingRecord)
- [msdyn_octeamschannelconfig_MailboxTrackingFolders](#BKMK_msdyn_octeamschannelconfig_MailboxTrackingFolders)
- [msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)
- [msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses)
- [msdyn_octeamschannelconfig_ProcessSession](#BKMK_msdyn_octeamschannelconfig_ProcessSession)
- [msdyn_octeamschannelconfig_SyncErrors](#BKMK_msdyn_octeamschannelconfig_SyncErrors)

### <a name="BKMK_msdyn_octeamschannelconfig_AsyncOperations"></a> msdyn_octeamschannelconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_octeamschannelconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_octeamschannelconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures"></a> msdyn_octeamschannelconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_octeamschannelconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_DuplicateBaseRecord"></a> msdyn_octeamschannelconfig_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_octeamschannelconfig_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_octeamschannelconfig_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_DuplicateMatchingRecord"></a> msdyn_octeamschannelconfig_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_octeamschannelconfig_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_octeamschannelconfig_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_MailboxTrackingFolders"></a> msdyn_octeamschannelconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_octeamschannelconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_octeamschannelconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid

Many-To-One Relationship: [msdyn_ocbotchannelregistration msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](msdyn_ocbotchannelregistration.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid

Many-To-One Relationship: [msdyn_ocprovisioningstate msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](msdyn_ocprovisioningstate.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses"></a> msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_ProcessSession"></a> msdyn_octeamschannelconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_octeamschannelconfig_ProcessSession](processsession.md#BKMK_msdyn_octeamschannelconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_octeamschannelconfig_SyncErrors"></a> msdyn_octeamschannelconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_octeamschannelconfig_SyncErrors](syncerror.md#BKMK_msdyn_octeamschannelconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_octeamschannelconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

