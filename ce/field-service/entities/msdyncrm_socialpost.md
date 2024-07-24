---
title: "Social post (msdyncrm_socialpost) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Social post (msdyncrm_socialpost) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Social post (msdyncrm_socialpost) table/entity reference

Entity which represents social post

## Messages

The following table lists the messages for the Social post (msdyncrm_socialpost) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_socialposts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_socialposts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_socialposts(*msdyncrm_socialpostid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Social post (msdyncrm_socialpost) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Social post (msdyncrm_socialpost) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Social post** |
| **DisplayCollectionName** | **Social posts** |
| **SchemaName** | `msdyncrm_socialpost` |
| **CollectionSchemaName** | `msdyncrm_socialposts` |
| **EntitySetName** | `msdyncrm_socialposts`|
| **LogicalName** | `msdyncrm_socialpost` |
| **LogicalCollectionName** | `msdyncrm_socialposts` |
| **PrimaryIdAttribute** | `msdyncrm_socialpostid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_accountlink](#BKMK_msdyncrm_accountlink)
- [msdyncrm_Attachemnts](#BKMK_msdyncrm_Attachemnts)
- [msdyncrm_attachmentname](#BKMK_msdyncrm_attachmentname)
- [msdyncrm_CalendarDisplayOptions](#BKMK_msdyncrm_CalendarDisplayOptions)
- [msdyncrm_commentcount](#BKMK_msdyncrm_commentcount)
- [msdyncrm_golivetime](#BKMK_msdyncrm_golivetime)
- [msdyncrm_impressioncount](#BKMK_msdyncrm_impressioncount)
- [msdyncrm_likecount](#BKMK_msdyncrm_likecount)
- [msdyncrm_linkedInvisibility](#BKMK_msdyncrm_linkedInvisibility)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_networkId](#BKMK_msdyncrm_networkId)
- [msdyncrm_networkpages](#BKMK_msdyncrm_networkpages)
- [msdyncrm_postas](#BKMK_msdyncrm_postas)
- [msdyncrm_postattachment](#BKMK_msdyncrm_postattachment)
- [msdyncrm_postingfrom](#BKMK_msdyncrm_postingfrom)
- [msdyncrm_PostingPeriod](#BKMK_msdyncrm_PostingPeriod)
- [msdyncrm_postinguser](#BKMK_msdyncrm_postinguser)
- [msdyncrm_postinguserid](#BKMK_msdyncrm_postinguserid)
- [msdyncrm_poststate](#BKMK_msdyncrm_poststate)
- [msdyncrm_PostText](#BKMK_msdyncrm_PostText)
- [msdyncrm_postUrl](#BKMK_msdyncrm_postUrl)
- [msdyncrm_sentiment](#BKMK_msdyncrm_sentiment)
- [msdyncrm_sentimentscore](#BKMK_msdyncrm_sentimentscore)
- [msdyncrm_socialchannel](#BKMK_msdyncrm_socialchannel)
- [msdyncrm_socialconfiguration](#BKMK_msdyncrm_socialconfiguration)
- [msdyncrm_socialpostId](#BKMK_msdyncrm_socialpostId)
- [msdyncrm_StartDate](#BKMK_msdyncrm_StartDate)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**Media attachments to the post**|
|DisplayName|**Attachment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_accountlink"></a> msdyncrm_accountlink

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_accountlink`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_Attachemnts"></a> msdyncrm_Attachemnts

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attachments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_attachemnts`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_socialpost|

### <a name="BKMK_msdyncrm_attachmentname"></a> msdyncrm_attachmentname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attachment name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_attachmentname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_CalendarDisplayOptions"></a> msdyncrm_CalendarDisplayOptions

|Property|Value|
|---|---|
|Description|**Set of properties describing how this entity will be rendered inside the CalendarControl**|
|DisplayName|**Calendar Display Options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_calendardisplayoptions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_commentcount"></a> msdyncrm_commentcount

|Property|Value|
|---|---|
|Description|**Comment count**|
|DisplayName|**Comment count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_commentcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_golivetime"></a> msdyncrm_golivetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Go live time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_golivetime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_impressioncount"></a> msdyncrm_impressioncount

|Property|Value|
|---|---|
|Description|**Impression count**|
|DisplayName|**Impression count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_impressioncount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_likecount"></a> msdyncrm_likecount

|Property|Value|
|---|---|
|Description|**Like count**|
|DisplayName|**Like count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_likecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_linkedInvisibility"></a> msdyncrm_linkedInvisibility

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn visibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinvisibility`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_linkedinvisibility`|

#### msdyncrm_linkedInvisibility Choices/Options

|Value|Label|
|---|---|
|270100000|**Connections**|
|270100001|**Public**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_networkId"></a> msdyncrm_networkId

|Property|Value|
|---|---|
|Description|**Id of the post on the social network**|
|DisplayName|**Network Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_networkId`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_networkpages"></a> msdyncrm_networkpages

|Property|Value|
|---|---|
|Description||
|DisplayName|**Network pages**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_networkpages`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_networkpage|

### <a name="BKMK_msdyncrm_postas"></a> msdyncrm_postas

|Property|Value|
|---|---|
|Description||
|DisplayName|**PostAs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postas`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_postas`|

#### msdyncrm_postas Choices/Options

|Value|Label|
|---|---|
|270100000|**User**|
|270100001|**Company**|

### <a name="BKMK_msdyncrm_postattachment"></a> msdyncrm_postattachment

|Property|Value|
|---|---|
|Description||
|DisplayName|**Post attachment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postattachment`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_postingfrom"></a> msdyncrm_postingfrom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Posting from**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postingfrom`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_postingfrom`|

#### msdyncrm_postingfrom Choices/Options

|Value|Label|
|---|---|
|270100000|**User 0**|
|270100001|**User 1**|
|270100002|**User 2**|
|270100003|**User 3**|
|270100004|**User 4**|
|270100005|**User 5**|
|270100006|**User 6**|
|270100007|**User 7**|
|270100008|**User 8**|
|270100009|**User 9**|
|270100010|**User 10**|

### <a name="BKMK_msdyncrm_PostingPeriod"></a> msdyncrm_PostingPeriod

|Property|Value|
|---|---|
|Description||
|DisplayName|**Posting period**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postingperiod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_postingperiod`|

#### msdyncrm_PostingPeriod Choices/Options

|Value|Label|
|---|---|
|270100000|**Post now**|
|270100001|**Schedule later**|
|270100002|**Schedule**|
|270100003|**On demand**|

### <a name="BKMK_msdyncrm_postinguser"></a> msdyncrm_postinguser

|Property|Value|
|---|---|
|Description||
|DisplayName|**Posting user**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postinguser`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_postinguserid"></a> msdyncrm_postinguserid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Posting user ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postinguserid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_poststate"></a> msdyncrm_poststate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Post state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_poststate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_poststate`|

#### msdyncrm_poststate Choices/Options

|Value|Label|
|---|---|
|270100000|**Draft**|
|270100001|**Scheduled**|
|270100002|**Live**|
|270100003|**New**|
|270100004|**Failed**|
|270100005|**Going live**|
|270100006|**Disconnected**|

### <a name="BKMK_msdyncrm_PostText"></a> msdyncrm_PostText

|Property|Value|
|---|---|
|Description|**Text to be shown in a social post**|
|DisplayName|**Post text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_posttext`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|63206|

### <a name="BKMK_msdyncrm_postUrl"></a> msdyncrm_postUrl

|Property|Value|
|---|---|
|Description|**Url of the post in social network**|
|DisplayName|**Network Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postUrl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_sentiment"></a> msdyncrm_sentiment

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sentiment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sentiment`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_sentimentscore"></a> msdyncrm_sentimentscore

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sentiment score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sentimentscore`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyncrm_socialchannel"></a> msdyncrm_socialchannel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Social channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_socialchannel`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpost_msdyncrm_socialchannel`|

#### msdyncrm_socialchannel Choices/Options

|Value|Label|
|---|---|
|270100000|**Twitter**|
|270100001|**Facebook**|
|270100002|**LinkedIn**|
|270100003|**Instagram**|

### <a name="BKMK_msdyncrm_socialconfiguration"></a> msdyncrm_socialconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Social media account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_socialconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_socialpostingconfiguration|

### <a name="BKMK_msdyncrm_socialpostId"></a> msdyncrm_socialpostId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**Social post**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_socialpostid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_StartDate"></a> msdyncrm_StartDate

|Property|Value|
|---|---|
|Description|**Date on which the social post will be published**|
|DisplayName|**Posted time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the social post**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_socialpost_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the social post**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_socialpost_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **New**<br />State:0<br />TransitionData: None|
|2|Label: **Draft**<br />State:0<br />TransitionData: None|
|3|Label: **Published**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|DisplayName|**UTC conversion time zone code**|
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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
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
|Description|**Indicates the person who created this.**|
|DisplayName|**Created by**|
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
|DisplayName|**Created on**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
|DisplayName|**Modified by**|
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
|DisplayName|**Modified on**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
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
|Description|**Indicates the business unit that owns this**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the person who owns this.**|
|DisplayName|**Owning user**|
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

- [business_unit_msdyncrm_socialpost](#BKMK_business_unit_msdyncrm_socialpost)
- [lk_msdyncrm_socialpost_createdby](#BKMK_lk_msdyncrm_socialpost_createdby)
- [lk_msdyncrm_socialpost_createdonbehalfby](#BKMK_lk_msdyncrm_socialpost_createdonbehalfby)
- [lk_msdyncrm_socialpost_modifiedby](#BKMK_lk_msdyncrm_socialpost_modifiedby)
- [lk_msdyncrm_socialpost_modifiedonbehalfby](#BKMK_lk_msdyncrm_socialpost_modifiedonbehalfby)
- [msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts](#BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-many-to-one)
- [msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration](#BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration)
- [msdyncrm_socialpost_msdyncrm_networkpage](#BKMK_msdyncrm_socialpost_msdyncrm_networkpage)
- [owner_msdyncrm_socialpost](#BKMK_owner_msdyncrm_socialpost)
- [team_msdyncrm_socialpost](#BKMK_team_msdyncrm_socialpost)
- [user_msdyncrm_socialpost](#BKMK_user_msdyncrm_socialpost)

### <a name="BKMK_business_unit_msdyncrm_socialpost"></a> business_unit_msdyncrm_socialpost

One-To-Many Relationship: [businessunit business_unit_msdyncrm_socialpost](businessunit.md#BKMK_business_unit_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpost_createdby"></a> lk_msdyncrm_socialpost_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpost_createdby](systemuser.md#BKMK_lk_msdyncrm_socialpost_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpost_createdonbehalfby"></a> lk_msdyncrm_socialpost_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpost_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_socialpost_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpost_modifiedby"></a> lk_msdyncrm_socialpost_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpost_modifiedby](systemuser.md#BKMK_lk_msdyncrm_socialpost_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpost_modifiedonbehalfby"></a> lk_msdyncrm_socialpost_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpost_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_socialpost_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-many-to-one"></a> msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts

One-To-Many Relationship: [msdyncrm_socialpost msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts](#BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_socialpost`|
|ReferencedAttribute|`msdyncrm_socialpostid`|
|ReferencingAttribute|`msdyncrm_attachemnts`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_Attachemnts`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration"></a> msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration

One-To-Many Relationship: [msdyncrm_socialpostingconfiguration msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration](msdyncrm_socialpostingconfiguration.md#BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_socialpostingconfiguration`|
|ReferencedAttribute|`msdyncrm_socialpostingconfigurationid`|
|ReferencingAttribute|`msdyncrm_socialconfiguration`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_socialconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_socialpost_msdyncrm_networkpage"></a> msdyncrm_socialpost_msdyncrm_networkpage

One-To-Many Relationship: [msdyncrm_networkpage msdyncrm_socialpost_msdyncrm_networkpage](msdyncrm_networkpage.md#BKMK_msdyncrm_socialpost_msdyncrm_networkpage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_networkpage`|
|ReferencedAttribute|`msdyncrm_networkpageid`|
|ReferencingAttribute|`msdyncrm_networkpages`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_networkpages`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_socialpost"></a> owner_msdyncrm_socialpost

One-To-Many Relationship: [owner owner_msdyncrm_socialpost](owner.md#BKMK_owner_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_socialpost"></a> team_msdyncrm_socialpost

One-To-Many Relationship: [team team_msdyncrm_socialpost](team.md#BKMK_team_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_socialpost"></a> user_msdyncrm_socialpost

One-To-Many Relationship: [systemuser user_msdyncrm_socialpost](systemuser.md#BKMK_user_msdyncrm_socialpost)

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

- [msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts](#BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-one-to-many)
- [msdyncrm_postingishts_msdyncrm_socialpost](#BKMK_msdyncrm_postingishts_msdyncrm_socialpost)
- [msdyncrm_socialpost_AsyncOperations](#BKMK_msdyncrm_socialpost_AsyncOperations)
- [msdyncrm_socialpost_BulkDeleteFailures](#BKMK_msdyncrm_socialpost_BulkDeleteFailures)
- [msdyncrm_socialpost_MailboxTrackingFolders](#BKMK_msdyncrm_socialpost_MailboxTrackingFolders)
- [msdyncrm_socialpost_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_socialpost_PrincipalObjectAttributeAccesses)
- [msdyncrm_socialpost_ProcessSession](#BKMK_msdyncrm_socialpost_ProcessSession)
- [msdyncrm_socialpost_SyncErrors](#BKMK_msdyncrm_socialpost_SyncErrors)

### <a name="BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-one-to-many"></a> msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts

Many-To-One Relationship: [msdyncrm_socialpost msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts](#BKMK_msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpost`|
|ReferencingAttribute|`msdyncrm_attachemnts`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_socialpost_msdyncrm_socialpost_Attachemnts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_postingishts_msdyncrm_socialpost"></a> msdyncrm_postingishts_msdyncrm_socialpost

Many-To-One Relationship: [msdyncrm_postingishts msdyncrm_postingishts_msdyncrm_socialpost](msdyncrm_postingishts.md#BKMK_msdyncrm_postingishts_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_postingishts`|
|ReferencingAttribute|`msdyncrm_post`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_postingishts_msdyncrm_socialpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_AsyncOperations"></a> msdyncrm_socialpost_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_socialpost_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_socialpost_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_BulkDeleteFailures"></a> msdyncrm_socialpost_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_socialpost_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_socialpost_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_MailboxTrackingFolders"></a> msdyncrm_socialpost_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_socialpost_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_socialpost_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_PrincipalObjectAttributeAccesses"></a> msdyncrm_socialpost_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_socialpost_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_socialpost_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_ProcessSession"></a> msdyncrm_socialpost_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_socialpost_ProcessSession](processsession.md#BKMK_msdyncrm_socialpost_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpost_SyncErrors"></a> msdyncrm_socialpost_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_socialpost_SyncErrors](syncerror.md#BKMK_msdyncrm_socialpost_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpost_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

