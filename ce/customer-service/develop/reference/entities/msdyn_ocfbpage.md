---
title: "Facebook Page (msdyn_ocfbpage) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Facebook Page (msdyn_ocfbpage) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Facebook Page (msdyn_ocfbpage) table/entity reference (Microsoft Dynamics 365 Customer Service)

Facebook pages configured for Omnichannel integration

## Messages

The following table lists the messages for the Facebook Page (msdyn_ocfbpage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocfbpages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocfbpages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocfbpages(*msdyn_ocfbpageid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Facebook Page (msdyn_ocfbpage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Facebook Page** |
| **DisplayCollectionName** | **Facebook Pages** |
| **SchemaName** | `msdyn_ocfbpage` |
| **CollectionSchemaName** | `msdyn_ocfbpages` |
| **EntitySetName** | `msdyn_ocfbpages`|
| **LogicalName** | `msdyn_ocfbpage` |
| **LogicalCollectionName** | `msdyn_ocfbpages` |
| **PrimaryIdAttribute** | `msdyn_ocfbpageid` |
| **PrimaryNameAttribute** |`msdyn_fbpagename` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_enablefileattachmentsforagents](#BKMK_msdyn_enablefileattachmentsforagents)
- [msdyn_enablefileattachmentsforcustomers](#BKMK_msdyn_enablefileattachmentsforcustomers)
- [msdyn_enablehumanagenttag](#BKMK_msdyn_enablehumanagenttag)
- [msdyn_fbpageaccesstoken](#BKMK_msdyn_fbpageaccesstoken)
- [msdyn_fbpageid](#BKMK_msdyn_fbpageid)
- [msdyn_fbpagename](#BKMK_msdyn_fbpagename)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocfbpageId](#BKMK_msdyn_ocfbpageId)
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

### <a name="BKMK_msdyn_enablefileattachmentsforagents"></a> msdyn_enablefileattachmentsforagents

|Property|Value|
|---|---|
|Description|**Enable file attachments for agents**|
|DisplayName|**Enable file attachments for agents**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforagents`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_ocfbpage_msdyn_enablefileattachmentsforagents`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablefileattachmentsforcustomers"></a> msdyn_enablefileattachmentsforcustomers

|Property|Value|
|---|---|
|Description|**Enable file attachments for customers**|
|DisplayName|**Enable file attachments for customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforcustomers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_ocfbpage_msdyn_enablefileattachmentsforcustomers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablehumanagenttag"></a> msdyn_enablehumanagenttag

|Property|Value|
|---|---|
|Description|**Turn on your Facebook human agent message tag**|
|DisplayName|**Turn on your Facebook human agent message tag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablehumanagenttag`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_ocfbpage_msdyn_enablehumanagenttag`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_fbpageaccesstoken"></a> msdyn_fbpageaccesstoken

|Property|Value|
|---|---|
|Description|**Access token for the Facebook page**|
|DisplayName|**Page Access Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fbpageaccesstoken`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_fbpageid"></a> msdyn_fbpageid

|Property|Value|
|---|---|
|Description|**Page id of the Facebook page**|
|DisplayName|**Page Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fbpageid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_fbpagename"></a> msdyn_fbpagename

|Property|Value|
|---|---|
|Description|**The name of the Facebook page**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fbpagename`|
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
|Description|**Unique identifier for Work Stream associated with Facebook page**|
|DisplayName|**Work Stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

|Property|Value|
|---|---|
|Description|**Related Facebook application**|
|DisplayName|**Facebook Application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbapplicationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocfbapplication|

### <a name="BKMK_msdyn_ocfbpageId"></a> msdyn_ocfbpageId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Facebook Page**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbpageid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocwidgetlanguage"></a> msdyn_ocwidgetlanguage

|Property|Value|
|---|---|
|Description|**The language setting for the Facebook page**|
|DisplayName|**Facebook page language**|
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
|GlobalChoiceName|`msdyn_fb_postconversationsurveybotsurvey`|
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
|Description|**Status of the Facebook Page**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocfbpage_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Facebook Page**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocfbpage_statuscode`|

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

- [business_unit_msdyn_ocfbpage](#BKMK_business_unit_msdyn_ocfbpage)
- [lk_msdyn_ocfbpage_createdby](#BKMK_lk_msdyn_ocfbpage_createdby)
- [lk_msdyn_ocfbpage_createdonbehalfby](#BKMK_lk_msdyn_ocfbpage_createdonbehalfby)
- [lk_msdyn_ocfbpage_modifiedby](#BKMK_lk_msdyn_ocfbpage_modifiedby)
- [lk_msdyn_ocfbpage_modifiedonbehalfby](#BKMK_lk_msdyn_ocfbpage_modifiedonbehalfby)
- [msdyn_msdyn_liveworkstream_msdyn_ocfbpage](#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocfbpage)
- [msdyn_msdyn_ocfbapplication_msdyn_ocfbpage](#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocfbpage)
- [msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage)
- [msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey)
- [msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey)
- [owner_msdyn_ocfbpage](#BKMK_owner_msdyn_ocfbpage)
- [team_msdyn_ocfbpage](#BKMK_team_msdyn_ocfbpage)
- [user_msdyn_ocfbpage](#BKMK_user_msdyn_ocfbpage)

### <a name="BKMK_business_unit_msdyn_ocfbpage"></a> business_unit_msdyn_ocfbpage

One-To-Many Relationship: [businessunit business_unit_msdyn_ocfbpage](businessunit.md#BKMK_business_unit_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocfbpage_createdby"></a> lk_msdyn_ocfbpage_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocfbpage_createdby](systemuser.md#BKMK_lk_msdyn_ocfbpage_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocfbpage_createdonbehalfby"></a> lk_msdyn_ocfbpage_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocfbpage_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocfbpage_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocfbpage_modifiedby"></a> lk_msdyn_ocfbpage_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocfbpage_modifiedby](systemuser.md#BKMK_lk_msdyn_ocfbpage_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocfbpage_modifiedonbehalfby"></a> lk_msdyn_ocfbpage_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocfbpage_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocfbpage_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_ocfbpage"></a> msdyn_msdyn_liveworkstream_msdyn_ocfbpage

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_ocfbpage](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocfbpage"></a> msdyn_msdyn_ocfbapplication_msdyn_ocfbpage

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_msdyn_ocfbapplication_msdyn_ocfbpage](msdyn_ocfbapplication.md#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`msdyn_ocfbapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbapplicationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey"></a> msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey"></a> msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocfbpage_PostConversationSurveySeparateBotSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurveyseparatebotsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurveySeparateBotSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocfbpage"></a> owner_msdyn_ocfbpage

One-To-Many Relationship: [owner owner_msdyn_ocfbpage](owner.md#BKMK_owner_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocfbpage"></a> team_msdyn_ocfbpage

One-To-Many Relationship: [team team_msdyn_ocfbpage](team.md#BKMK_team_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocfbpage"></a> user_msdyn_ocfbpage

One-To-Many Relationship: [systemuser user_msdyn_ocfbpage](systemuser.md#BKMK_user_msdyn_ocfbpage)

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

- [msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)
- [msdyn_ocfbpage_AsyncOperations](#BKMK_msdyn_ocfbpage_AsyncOperations)
- [msdyn_ocfbpage_BulkDeleteFailures](#BKMK_msdyn_ocfbpage_BulkDeleteFailures)
- [msdyn_ocfbpage_DuplicateBaseRecord](#BKMK_msdyn_ocfbpage_DuplicateBaseRecord)
- [msdyn_ocfbpage_DuplicateMatchingRecord](#BKMK_msdyn_ocfbpage_DuplicateMatchingRecord)
- [msdyn_ocfbpage_MailboxTrackingFolders](#BKMK_msdyn_ocfbpage_MailboxTrackingFolders)
- [msdyn_ocfbpage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses)
- [msdyn_ocfbpage_ProcessSession](#BKMK_msdyn_ocfbpage_ProcessSession)
- [msdyn_ocfbpage_SyncErrors](#BKMK_msdyn_ocfbpage_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate

Many-To-One Relationship: [msdyn_ocprovisioningstate msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](msdyn_ocprovisioningstate.md#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`msdyn_ocfbpageid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_AsyncOperations"></a> msdyn_ocfbpage_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocfbpage_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocfbpage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_BulkDeleteFailures"></a> msdyn_ocfbpage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocfbpage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocfbpage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_DuplicateBaseRecord"></a> msdyn_ocfbpage_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocfbpage_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocfbpage_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_DuplicateMatchingRecord"></a> msdyn_ocfbpage_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocfbpage_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocfbpage_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_MailboxTrackingFolders"></a> msdyn_ocfbpage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocfbpage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocfbpage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses"></a> msdyn_ocfbpage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocfbpage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_ProcessSession"></a> msdyn_ocfbpage_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocfbpage_ProcessSession](processsession.md#BKMK_msdyn_ocfbpage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocfbpage_SyncErrors"></a> msdyn_ocfbpage_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocfbpage_SyncErrors](syncerror.md#BKMK_msdyn_ocfbpage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocfbpage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

