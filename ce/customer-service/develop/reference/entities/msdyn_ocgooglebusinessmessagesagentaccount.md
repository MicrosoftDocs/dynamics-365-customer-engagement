---
title: "Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount) table/entity reference (Microsoft Dynamics 365 Customer Service)

Google's Business Messages agent account

## Messages

The following table lists the messages for the Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocgooglebusinessmessagesagentaccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagesagentaccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocgooglebusinessmessagesagentaccounts(*msdyn_ocgooglebusinessmessagesagentaccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Google's Business Messages agent account** |
| **DisplayCollectionName** | **Google's Business Messages agent accounts** |
| **SchemaName** | `msdyn_ocgooglebusinessmessagesagentaccount` |
| **CollectionSchemaName** | `msdyn_ocgooglebusinessmessagesagentaccounts` |
| **EntitySetName** | `msdyn_ocgooglebusinessmessagesagentaccounts`|
| **LogicalName** | `msdyn_ocgooglebusinessmessagesagentaccount` |
| **LogicalCollectionName** | `msdyn_ocgooglebusinessmessagesagentaccounts` |
| **PrimaryIdAttribute** | `msdyn_ocgooglebusinessmessagesagentaccountid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentaccountclienttoken](#BKMK_msdyn_agentaccountclienttoken)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_brandid](#BKMK_msdyn_brandid)
- [msdyn_enableagentoverride](#BKMK_msdyn_enableagentoverride)
- [msdyn_enablefileattachmentsforagents](#BKMK_msdyn_enablefileattachmentsforagents)
- [msdyn_enablefileattachmentsforcustomers](#BKMK_msdyn_enablefileattachmentsforcustomers)
- [msdyn_googlebusinessmessagescallbackurl](#BKMK_msdyn_googlebusinessmessagescallbackurl)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocgbmpartneraccount](#BKMK_msdyn_ocgbmpartneraccount)
- [msdyn_ocgooglebusinessmessagesagentaccountId](#BKMK_msdyn_ocgooglebusinessmessagesagentaccountId)
- [msdyn_ocwidgetlanguage](#BKMK_msdyn_ocwidgetlanguage)
- [msdyn_PostConversationSurvey](#BKMK_msdyn_PostConversationSurvey)
- [msdyn_PostConversationSurveyBotSurvey](#BKMK_msdyn_PostConversationSurveyBotSurvey)
- [msdyn_PostConversationSurveyBotSurveyMessageText](#BKMK_msdyn_PostConversationSurveyBotSurveyMessageText)
- [msdyn_PostConversationSurveyBotSurveyMode](#BKMK_msdyn_PostConversationSurveyBotSurveyMode)
- [msdyn_PostConversationSurveyEnable](#BKMK_msdyn_PostConversationSurveyEnable)
- [msdyn_PostConversationSurveyMessageText](#BKMK_msdyn_PostConversationSurveyMessageText)
- [msdyn_PostConversationSurveyMode](#BKMK_msdyn_PostConversationSurveyMode)
- [msdyn_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_PostConversationSurveySeparateBotSurvey)
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

### <a name="BKMK_msdyn_agentaccountclienttoken"></a> msdyn_agentaccountclienttoken

|Property|Value|
|---|---|
|Description|**Agent account client token of the Google's Business Messages agent account.**|
|DisplayName|**Agent account client token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentaccountclienttoken`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|---|---|
|Description|**Agent ID of the Google's Business Messages agent account.**|
|DisplayName|**Agent ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_brandid"></a> msdyn_brandid

|Property|Value|
|---|---|
|Description|**Brand ID of the Google's Business Messages agent account.**|
|DisplayName|**Brand ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_brandid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_enableagentoverride"></a> msdyn_enableagentoverride

|Property|Value|
|---|---|
|Description|**Enable agent override of the Google's Business Messages agent account.**|
|DisplayName|**Enable agent override**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableagentoverride`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_msdyn_enableagentoverride`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablefileattachmentsforagents"></a> msdyn_enablefileattachmentsforagents

|Property|Value|
|---|---|
|Description|**Enable file attachments for agent of the Google's Business Messages agent account.**|
|DisplayName|**Enable file attachments for agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforagents`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_msdyn_enablefileattachmentsforagents`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablefileattachmentsforcustomers"></a> msdyn_enablefileattachmentsforcustomers

|Property|Value|
|---|---|
|Description|**Enable file attachments for customer of the Google's Business Messages agent account.**|
|DisplayName|**Enable file attachments for customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforcustomers`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_msdyn_enablefileattachmentsforcustomers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_googlebusinessmessagescallbackurl"></a> msdyn_googlebusinessmessagescallbackurl

|Property|Value|
|---|---|
|Description|**Google's Business Messages callback URL of the Google's Business Messages agent account.**|
|DisplayName|**Google's Business Messages callback URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_googlebusinessmessagescallbackurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Live work stream ID of the Google's Business Messages agent account.**|
|DisplayName|**Live work stream ID**|
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
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocgbmpartneraccount"></a> msdyn_ocgbmpartneraccount

|Property|Value|
|---|---|
|Description|**Google's Business Messages partner account ID of the agent account**|
|DisplayName|**Google's Business Messages partner account ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgbmpartneraccount`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocgooglebusinessmessagespartneraccount|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccountId"></a> msdyn_ocgooglebusinessmessagesagentaccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Google's Business Messages agent account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocwidgetlanguage"></a> msdyn_ocwidgetlanguage

|Property|Value|
|---|---|
|Description|**Widget language of the Google's Business Messages agent account.**|
|DisplayName|**Widget language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocwidgetlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_PostConversationSurvey"></a> msdyn_PostConversationSurvey

|Property|Value|
|---|---|
|Description|**Post conversation survey of the Google's Business Messages agent account.**|
|DisplayName|**Post conversation survey**|
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
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgooglebusinessmessageagentaccount_msdyn_postconversationsurveybotsurvey`|
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
|Description|**Post conversation survey enable of the Google's Business Messages agent account.**|
|DisplayName|**Post conversation survey enable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveyenable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_msdyn_postconversationsurveyenable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PostConversationSurveyMessageText"></a> msdyn_PostConversationSurveyMessageText

|Property|Value|
|---|---|
|Description|**Post conversation survey message text of the Google's Business Messages agent account.**|
|DisplayName|**Post conversation survey message text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveymessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PostConversationSurveyMode"></a> msdyn_PostConversationSurveyMode

|Property|Value|
|---|---|
|Description|**Post conversation survey mode of the Google's Business Messages agent account.**|
|DisplayName|**Post conversation survey mode**|
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
|Description|**Status of the Google's Business Messages agent account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Google's Business Messages agent account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesagentaccount_statuscode`|

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

- [business_unit_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount)
- [lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby](#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby)
- [lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby)
- [lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby](#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby)
- [lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby)
- [msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid](#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid)
- [msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount](#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount)
- [msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage)
- [msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey)
- [msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey)
- [owner_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount)
- [team_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount)
- [user_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_user_msdyn_ocgooglebusinessmessagesagentaccount)

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount"></a> business_unit_msdyn_ocgooglebusinessmessagesagentaccount

One-To-Many Relationship: [businessunit business_unit_msdyn_ocgooglebusinessmessagesagentaccount](businessunit.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby"></a> lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby"></a> lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesagentaccount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid"></a> msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocgooglebusinessmessagesagentaccount_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount"></a> msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`msdyn_ocgbmpartneraccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocgbmpartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey"></a> msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey"></a> msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocgooglebusinessmessagesagentaccount_PostConversationSurveySeparateBotSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurveyseparatebotsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurveySeparateBotSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount"></a> owner_msdyn_ocgooglebusinessmessagesagentaccount

One-To-Many Relationship: [owner owner_msdyn_ocgooglebusinessmessagesagentaccount](owner.md#BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount"></a> team_msdyn_ocgooglebusinessmessagesagentaccount

One-To-Many Relationship: [team team_msdyn_ocgooglebusinessmessagesagentaccount](team.md#BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocgooglebusinessmessagesagentaccount"></a> user_msdyn_ocgooglebusinessmessagesagentaccount

One-To-Many Relationship: [systemuser user_msdyn_ocgooglebusinessmessagesagentaccount](systemuser.md#BKMK_user_msdyn_ocgooglebusinessmessagesagentaccount)

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

- [msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)
- [msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations)
- [msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord)
- [msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord)
- [msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders)
- [msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession)
- [msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount"></a> msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount

Many-To-One Relationship: [msdyn_ocbotchannelregistration msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](msdyn_ocbotchannelregistration.md#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`msdyn_ocgbmagentaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations"></a> msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord"></a> msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord"></a> msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders"></a> msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession"></a> msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession](processsession.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors"></a> msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors](syncerror.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesagentaccount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

