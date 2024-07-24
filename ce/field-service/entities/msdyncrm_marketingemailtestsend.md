---
title: "Marketing email test send (msdyncrm_marketingemailtestsend) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing email test send (msdyncrm_marketingemailtestsend) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing email test send (msdyncrm_marketingemailtestsend) table/entity reference



## Messages

The following table lists the messages for the Marketing email test send (msdyncrm_marketingemailtestsend) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingemailtestsends<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingemailtestsends<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingemailtestsends(*msdyncrm_marketingemailtestsendid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing email test send (msdyncrm_marketingemailtestsend) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing email test send (msdyncrm_marketingemailtestsend) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing email test send** |
| **DisplayCollectionName** | **Marketing emails test-send** |
| **SchemaName** | `msdyncrm_marketingemailtestsend` |
| **CollectionSchemaName** | `msdyncrm_marketingemailtestsends` |
| **EntitySetName** | `msdyncrm_marketingemailtestsends`|
| **LogicalName** | `msdyncrm_marketingemailtestsend` |
| **LogicalCollectionName** | `msdyncrm_marketingemailtestsends` |
| **PrimaryIdAttribute** | `msdyncrm_marketingemailtestsendid` |
| **PrimaryNameAttribute** |`msdyncrm_subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_abtestid](#BKMK_msdyncrm_abtestid)
- [msdyncrm_abtestvariantid](#BKMK_msdyncrm_abtestvariantid)
- [msdyncrm_email_contenttype](#BKMK_msdyncrm_email_contenttype)
- [msdyncrm_emailbody](#BKMK_msdyncrm_emailbody)
- [msdyncrm_emailid](#BKMK_msdyncrm_emailid)
- [msdyncrm_entityname](#BKMK_msdyncrm_entityname)
- [msdyncrm_from](#BKMK_msdyncrm_from)
- [msdyncrm_fromexpression](#BKMK_msdyncrm_fromexpression)
- [msdyncrm_htmlpart](#BKMK_msdyncrm_htmlpart)
- [msdyncrm_keywords](#BKMK_msdyncrm_keywords)
- [msdyncrm_marketingemailtestsendId](#BKMK_msdyncrm_marketingemailtestsendId)
- [msdyncrm_marketinglistid](#BKMK_msdyncrm_marketinglistid)
- [msdyncrm_messagedesignation](#BKMK_msdyncrm_messagedesignation)
- [msdyncrm_messagetype](#BKMK_msdyncrm_messagetype)
- [msdyncrm_replytoexpression](#BKMK_msdyncrm_replytoexpression)
- [msdyncrm_subject](#BKMK_msdyncrm_subject)
- [msdyncrm_testcontactid](#BKMK_msdyncrm_testcontactid)
- [msdyncrm_testcontentsettingsid](#BKMK_msdyncrm_testcontentsettingsid)
- [msdyncrm_testsendemailaddress](#BKMK_msdyncrm_testsendemailaddress)
- [msdyncrm_textpart](#BKMK_msdyncrm_textpart)
- [msdyncrm_toexpression](#BKMK_msdyncrm_toexpression)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_abtestid"></a> msdyncrm_abtestid

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_abtestvariantid"></a> msdyncrm_abtestvariantid

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test variant ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestvariantid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_email_contenttype"></a> msdyncrm_email_contenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_contenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_email_contenttype`|

#### msdyncrm_email_contenttype Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**Confirmation request**|

### <a name="BKMK_msdyncrm_emailbody"></a> msdyncrm_emailbody

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email body**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailbody`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdyncrm_emailid"></a> msdyncrm_emailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_entityname"></a> msdyncrm_entityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**entityname**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_entityname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_from"></a> msdyncrm_from

|Property|Value|
|---|---|
|Description||
|DisplayName|**From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_from`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_fromexpression"></a> msdyncrm_fromexpression

|Property|Value|
|---|---|
|Description||
|DisplayName|**From expression**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fromexpression`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_htmlpart"></a> msdyncrm_htmlpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**HTML part**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_htmlpart`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_keywords"></a> msdyncrm_keywords

|Property|Value|
|---|---|
|Description||
|DisplayName|**Keywords**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_keywords`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_marketingemailtestsendId"></a> msdyncrm_marketingemailtestsendId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing email test send**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailtestsendid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketinglistid"></a> msdyncrm_marketinglistid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing list ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketinglistid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_messagedesignation"></a> msdyncrm_messagedesignation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Legal designation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_messagedesignation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_messagedesignation`|

#### msdyncrm_messagedesignation Choices/Options

|Value|Label|
|---|---|
|0|**Commercial**|
|1|**Transactional**|

### <a name="BKMK_msdyncrm_messagetype"></a> msdyncrm_messagetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Message type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_messagetype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1|
|MinValue|1|

### <a name="BKMK_msdyncrm_replytoexpression"></a> msdyncrm_replytoexpression

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reply-to expression**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_replytoexpression`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_subject"></a> msdyncrm_subject

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subject`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyncrm_testcontactid"></a> msdyncrm_testcontactid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_testcontactid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_testcontentsettingsid"></a> msdyncrm_testcontentsettingsid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test content settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_testcontentsettingsid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_contentsettings|

### <a name="BKMK_msdyncrm_testsendemailaddress"></a> msdyncrm_testsendemailaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test-send email address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_testsendemailaddress`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyncrm_textpart"></a> msdyncrm_textpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plain text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textpart`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdyncrm_toexpression"></a> msdyncrm_toexpression

|Property|Value|
|---|---|
|Description||
|DisplayName|**To expression**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_toexpression`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the marketing email test send**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailtestsend_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing email test-send status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailtestsend_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
|Description|**Indicates the business unit that owns this.**|
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
|Description|**Indicates the team that owns this.**|
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

- [business_unit_msdyncrm_marketingemailtestsend](#BKMK_business_unit_msdyncrm_marketingemailtestsend)
- [lk_msdyncrm_marketingemailtestsend_createdby](#BKMK_lk_msdyncrm_marketingemailtestsend_createdby)
- [lk_msdyncrm_marketingemailtestsend_createdonbehalfby](#BKMK_lk_msdyncrm_marketingemailtestsend_createdonbehalfby)
- [lk_msdyncrm_marketingemailtestsend_modifiedby](#BKMK_lk_msdyncrm_marketingemailtestsend_modifiedby)
- [lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby)
- [msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid](#BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid)
- [owner_msdyncrm_marketingemailtestsend](#BKMK_owner_msdyncrm_marketingemailtestsend)
- [team_msdyncrm_marketingemailtestsend](#BKMK_team_msdyncrm_marketingemailtestsend)
- [user_msdyncrm_marketingemailtestsend](#BKMK_user_msdyncrm_marketingemailtestsend)

### <a name="BKMK_business_unit_msdyncrm_marketingemailtestsend"></a> business_unit_msdyncrm_marketingemailtestsend

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingemailtestsend](businessunit.md#BKMK_business_unit_msdyncrm_marketingemailtestsend)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtestsend_createdby"></a> lk_msdyncrm_marketingemailtestsend_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtestsend_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtestsend_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtestsend_createdonbehalfby"></a> lk_msdyncrm_marketingemailtestsend_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtestsend_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtestsend_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtestsend_modifiedby"></a> lk_msdyncrm_marketingemailtestsend_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtestsend_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtestsend_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby"></a> lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid"></a> msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid

One-To-Many Relationship: [contact msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid](contact.md#BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_testcontactid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_testcontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid](msdyncrm_contentsettings.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`msdyncrm_testcontentsettingsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_testcontentsettingsid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingemailtestsend"></a> owner_msdyncrm_marketingemailtestsend

One-To-Many Relationship: [owner owner_msdyncrm_marketingemailtestsend](owner.md#BKMK_owner_msdyncrm_marketingemailtestsend)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingemailtestsend"></a> team_msdyncrm_marketingemailtestsend

One-To-Many Relationship: [team team_msdyncrm_marketingemailtestsend](team.md#BKMK_team_msdyncrm_marketingemailtestsend)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingemailtestsend"></a> user_msdyncrm_marketingemailtestsend

One-To-Many Relationship: [systemuser user_msdyncrm_marketingemailtestsend](systemuser.md#BKMK_user_msdyncrm_marketingemailtestsend)

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

- [msdyncrm_marketingemailtestsend_ActivityPointers](#BKMK_msdyncrm_marketingemailtestsend_ActivityPointers)
- [msdyncrm_marketingemailtestsend_adx_alertsubscriptions](#BKMK_msdyncrm_marketingemailtestsend_adx_alertsubscriptions)
- [msdyncrm_marketingemailtestsend_adx_inviteredemptions](#BKMK_msdyncrm_marketingemailtestsend_adx_inviteredemptions)
- [msdyncrm_marketingemailtestsend_adx_portalcomments](#BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments)
- [msdyncrm_marketingemailtestsend_Annotations](#BKMK_msdyncrm_marketingemailtestsend_Annotations)
- [msdyncrm_marketingemailtestsend_Appointments](#BKMK_msdyncrm_marketingemailtestsend_Appointments)
- [msdyncrm_marketingemailtestsend_AsyncOperations](#BKMK_msdyncrm_marketingemailtestsend_AsyncOperations)
- [msdyncrm_marketingemailtestsend_BulkDeleteFailures](#BKMK_msdyncrm_marketingemailtestsend_BulkDeleteFailures)
- [msdyncrm_marketingemailtestsend_chats](#BKMK_msdyncrm_marketingemailtestsend_chats)
- [msdyncrm_marketingemailtestsend_connections1](#BKMK_msdyncrm_marketingemailtestsend_connections1)
- [msdyncrm_marketingemailtestsend_connections2](#BKMK_msdyncrm_marketingemailtestsend_connections2)
- [msdyncrm_marketingemailtestsend_DuplicateBaseRecord](#BKMK_msdyncrm_marketingemailtestsend_DuplicateBaseRecord)
- [msdyncrm_marketingemailtestsend_DuplicateMatchingRecord](#BKMK_msdyncrm_marketingemailtestsend_DuplicateMatchingRecord)
- [msdyncrm_marketingemailtestsend_Emails](#BKMK_msdyncrm_marketingemailtestsend_Emails)
- [msdyncrm_marketingemailtestsend_Faxes](#BKMK_msdyncrm_marketingemailtestsend_Faxes)
- [msdyncrm_marketingemailtestsend_Feedback](#BKMK_msdyncrm_marketingemailtestsend_Feedback)
- [msdyncrm_marketingemailtestsend_Letters](#BKMK_msdyncrm_marketingemailtestsend_Letters)
- [msdyncrm_marketingemailtestsend_li_inmails](#BKMK_msdyncrm_marketingemailtestsend_li_inmails)
- [msdyncrm_marketingemailtestsend_li_messages](#BKMK_msdyncrm_marketingemailtestsend_li_messages)
- [msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds)
- [msdyncrm_marketingemailtestsend_MailboxTrackingFolders](#BKMK_msdyncrm_marketingemailtestsend_MailboxTrackingFolders)
- [msdyncrm_marketingemailtestsend_msdyn_bookingalerts](#BKMK_msdyncrm_marketingemailtestsend_msdyn_bookingalerts)
- [msdyncrm_marketingemailtestsend_msdyn_copilottranscripts](#BKMK_msdyncrm_marketingemailtestsend_msdyn_copilottranscripts)
- [msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems)
- [msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages)
- [msdyncrm_marketingemailtestsend_msdyn_ocsessions](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions)
- [msdyncrm_marketingemailtestsend_msdyn_ocvoicemails](#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocvoicemails)
- [msdyncrm_marketingemailtestsend_msfp_alerts](#BKMK_msdyncrm_marketingemailtestsend_msfp_alerts)
- [msdyncrm_marketingemailtestsend_msfp_surveyinvites](#BKMK_msdyncrm_marketingemailtestsend_msfp_surveyinvites)
- [msdyncrm_marketingemailtestsend_msfp_surveyresponses](#BKMK_msdyncrm_marketingemailtestsend_msfp_surveyresponses)
- [msdyncrm_marketingemailtestsend_PhoneCalls](#BKMK_msdyncrm_marketingemailtestsend_PhoneCalls)
- [msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingemailtestsend_ProcessSession](#BKMK_msdyncrm_marketingemailtestsend_ProcessSession)
- [msdyncrm_marketingemailtestsend_RecurringAppointmentMasters](#BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters)
- [msdyncrm_marketingemailtestsend_ServiceAppointments](#BKMK_msdyncrm_marketingemailtestsend_ServiceAppointments)
- [msdyncrm_marketingemailtestsend_SocialActivities](#BKMK_msdyncrm_marketingemailtestsend_SocialActivities)
- [msdyncrm_marketingemailtestsend_SyncErrors](#BKMK_msdyncrm_marketingemailtestsend_SyncErrors)
- [msdyncrm_marketingemailtestsend_Tasks](#BKMK_msdyncrm_marketingemailtestsend_Tasks)

### <a name="BKMK_msdyncrm_marketingemailtestsend_ActivityPointers"></a> msdyncrm_marketingemailtestsend_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_marketingemailtestsend_ActivityPointers](activitypointer.md#BKMK_msdyncrm_marketingemailtestsend_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_adx_alertsubscriptions"></a> msdyncrm_marketingemailtestsend_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_marketingemailtestsend_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_marketingemailtestsend_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_adx_inviteredemptions"></a> msdyncrm_marketingemailtestsend_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_marketingemailtestsend_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_marketingemailtestsend_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments"></a> msdyncrm_marketingemailtestsend_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_marketingemailtestsend_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Annotations"></a> msdyncrm_marketingemailtestsend_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingemailtestsend_Annotations](annotation.md#BKMK_msdyncrm_marketingemailtestsend_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Appointments"></a> msdyncrm_marketingemailtestsend_Appointments

Many-To-One Relationship: [appointment msdyncrm_marketingemailtestsend_Appointments](appointment.md#BKMK_msdyncrm_marketingemailtestsend_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_AsyncOperations"></a> msdyncrm_marketingemailtestsend_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingemailtestsend_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingemailtestsend_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_BulkDeleteFailures"></a> msdyncrm_marketingemailtestsend_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingemailtestsend_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingemailtestsend_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_chats"></a> msdyncrm_marketingemailtestsend_chats

Many-To-One Relationship: [chat msdyncrm_marketingemailtestsend_chats](chat.md#BKMK_msdyncrm_marketingemailtestsend_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_connections1"></a> msdyncrm_marketingemailtestsend_connections1

Many-To-One Relationship: [connection msdyncrm_marketingemailtestsend_connections1](connection.md#BKMK_msdyncrm_marketingemailtestsend_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_connections2"></a> msdyncrm_marketingemailtestsend_connections2

Many-To-One Relationship: [connection msdyncrm_marketingemailtestsend_connections2](connection.md#BKMK_msdyncrm_marketingemailtestsend_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_DuplicateBaseRecord"></a> msdyncrm_marketingemailtestsend_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingemailtestsend_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_marketingemailtestsend_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_DuplicateMatchingRecord"></a> msdyncrm_marketingemailtestsend_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingemailtestsend_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_marketingemailtestsend_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Emails"></a> msdyncrm_marketingemailtestsend_Emails

Many-To-One Relationship: [email msdyncrm_marketingemailtestsend_Emails](email.md#BKMK_msdyncrm_marketingemailtestsend_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Faxes"></a> msdyncrm_marketingemailtestsend_Faxes

Many-To-One Relationship: [fax msdyncrm_marketingemailtestsend_Faxes](fax.md#BKMK_msdyncrm_marketingemailtestsend_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Feedback"></a> msdyncrm_marketingemailtestsend_Feedback

Many-To-One Relationship: [feedback msdyncrm_marketingemailtestsend_Feedback](feedback.md#BKMK_msdyncrm_marketingemailtestsend_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Letters"></a> msdyncrm_marketingemailtestsend_Letters

Many-To-One Relationship: [letter msdyncrm_marketingemailtestsend_Letters](letter.md#BKMK_msdyncrm_marketingemailtestsend_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_li_inmails"></a> msdyncrm_marketingemailtestsend_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_marketingemailtestsend_li_inmails](li_inmail.md#BKMK_msdyncrm_marketingemailtestsend_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_li_messages"></a> msdyncrm_marketingemailtestsend_li_messages

Many-To-One Relationship: [li_message msdyncrm_marketingemailtestsend_li_messages](li_message.md#BKMK_msdyncrm_marketingemailtestsend_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds"></a> msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_MailboxTrackingFolders"></a> msdyncrm_marketingemailtestsend_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingemailtestsend_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingemailtestsend_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_bookingalerts"></a> msdyncrm_marketingemailtestsend_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_marketingemailtestsend_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_copilottranscripts"></a> msdyncrm_marketingemailtestsend_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_marketingemailtestsend_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems"></a> msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages"></a> msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions"></a> msdyncrm_marketingemailtestsend_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_marketingemailtestsend_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msdyn_ocvoicemails"></a> msdyncrm_marketingemailtestsend_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_marketingemailtestsend_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_marketingemailtestsend_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msfp_alerts"></a> msdyncrm_marketingemailtestsend_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_marketingemailtestsend_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_marketingemailtestsend_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msfp_surveyinvites"></a> msdyncrm_marketingemailtestsend_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_marketingemailtestsend_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_marketingemailtestsend_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_msfp_surveyresponses"></a> msdyncrm_marketingemailtestsend_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_marketingemailtestsend_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_marketingemailtestsend_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_PhoneCalls"></a> msdyncrm_marketingemailtestsend_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_marketingemailtestsend_PhoneCalls](phonecall.md#BKMK_msdyncrm_marketingemailtestsend_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_ProcessSession"></a> msdyncrm_marketingemailtestsend_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingemailtestsend_ProcessSession](processsession.md#BKMK_msdyncrm_marketingemailtestsend_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters"></a> msdyncrm_marketingemailtestsend_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_marketingemailtestsend_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_ServiceAppointments"></a> msdyncrm_marketingemailtestsend_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_marketingemailtestsend_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_marketingemailtestsend_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_SocialActivities"></a> msdyncrm_marketingemailtestsend_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_marketingemailtestsend_SocialActivities](socialactivity.md#BKMK_msdyncrm_marketingemailtestsend_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_SyncErrors"></a> msdyncrm_marketingemailtestsend_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingemailtestsend_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingemailtestsend_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Tasks"></a> msdyncrm_marketingemailtestsend_Tasks

Many-To-One Relationship: [task msdyncrm_marketingemailtestsend_Tasks](task.md#BKMK_msdyncrm_marketingemailtestsend_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtestsend_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

