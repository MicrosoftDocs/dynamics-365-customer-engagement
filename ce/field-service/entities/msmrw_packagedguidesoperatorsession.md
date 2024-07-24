---
title: "Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table/entity reference

Stores information about the duration, progress and status of a packaged guide session.

## Messages

The following table lists the messages for the Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_packagedguidesoperatorsessions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_packagedguidesoperatorsessions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_packagedguidesoperatorsessions(*msmrw_packagedguidesoperatorsessionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Packaged Guides Operator Session (msmrw_packagedguidesoperatorsession) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Packaged Guides Operator Session** |
| **DisplayCollectionName** | **Packaged Guides Operator Sessions** |
| **SchemaName** | `msmrw_packagedguidesoperatorsession` |
| **CollectionSchemaName** | `msmrw_packagedguidesoperatorsessions` |
| **EntitySetName** | `msmrw_packagedguidesoperatorsessions`|
| **LogicalName** | `msmrw_packagedguidesoperatorsession` |
| **LogicalCollectionName** | `msmrw_packagedguidesoperatorsessions` |
| **PrimaryIdAttribute** | `msmrw_packagedguidesoperatorsessionid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_ActiveSessionDurationSeconds](#BKMK_msmrw_ActiveSessionDurationSeconds)
- [msmrw_AppSessionId](#BKMK_msmrw_AppSessionId)
- [msmrw_AppVersion](#BKMK_msmrw_AppVersion)
- [msmrw_DeviceClass](#BKMK_msmrw_DeviceClass)
- [msmrw_guide_id](#BKMK_msmrw_guide_id)
- [msmrw_GuideLength](#BKMK_msmrw_GuideLength)
- [msmrw_guidename](#BKMK_msmrw_guidename)
- [msmrw_IsAllSessionDataAccountedFor](#BKMK_msmrw_IsAllSessionDataAccountedFor)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_packagedguideid](#BKMK_msmrw_packagedguideid)
- [msmrw_packagedguidesoperatorsessionId](#BKMK_msmrw_packagedguidesoperatorsessionId)
- [msmrw_PercentOfStepsVisited](#BKMK_msmrw_PercentOfStepsVisited)
- [msmrw_SessionEndTime](#BKMK_msmrw_SessionEndTime)
- [msmrw_SessionStartTime](#BKMK_msmrw_SessionStartTime)
- [msmrw_SessionState](#BKMK_msmrw_SessionState)
- [msmrw_VisitedCompletionStep](#BKMK_msmrw_VisitedCompletionStep)
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

### <a name="BKMK_msmrw_ActiveSessionDurationSeconds"></a> msmrw_ActiveSessionDurationSeconds

|Property|Value|
|---|---|
|Description|**Total duration (in seconds) for a guide session, calculated as the sum of all step visit durations from the guide session.**|
|DisplayName|**Active Session Duration Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_activesessiondurationseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msmrw_AppSessionId"></a> msmrw_AppSessionId

|Property|Value|
|---|---|
|Description|**Unique identifier for app session that starts when the app is opened and ends when the app is closed.**|
|DisplayName|**App Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_appsessionid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_AppVersion"></a> msmrw_AppVersion

|Property|Value|
|---|---|
|Description|**The app version used to create the guide session.**|
|DisplayName|**App Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_appversion`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_DeviceClass"></a> msmrw_DeviceClass

|Property|Value|
|---|---|
|Description|**Type of device used for authoring.**|
|DisplayName|**Device Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_deviceclass`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_deviceclass`|

#### msmrw_DeviceClass Choices/Options

|Value|Label|
|---|---|
|937380000|**HL1**|
|937380001|**HL2**|
|937380002|**PC**|
|937380003|**iOS**|
|937380004|**Android**|

### <a name="BKMK_msmrw_guide_id"></a> msmrw_guide_id

|Property|Value|
|---|---|
|Description|**Reference to the guide.**|
|DisplayName|**GuideId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guide_id`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_GuideLength"></a> msmrw_GuideLength

|Property|Value|
|---|---|
|Description|**Total number of steps in the guide.**|
|DisplayName|**Guide Length**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidelength`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_guidename"></a> msmrw_guidename

|Property|Value|
|---|---|
|Description|**Packaged Guide Name**|
|DisplayName|**Packaged Guide Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_IsAllSessionDataAccountedFor"></a> msmrw_IsAllSessionDataAccountedFor

|Property|Value|
|---|---|
|Description|**Defines whether all session data is accounted for, which can be useful if there is any data loss due to connectivity or other technical issues (Yes: All session data is accounted for; No: One or more step visits were not correctly recorded, no step visits occurred, or the guide session was interrupt**|
|DisplayName|**Is All Session Data Accounted For**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_isallsessiondataaccountedfor`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_msmrw_packagedguidesoperatorsession_isallsessiondataaccountedfor`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_packagedguideid"></a> msmrw_packagedguideid

|Property|Value|
|---|---|
|Description|**Reference to the Packaged Guide.**|
|DisplayName|**Packaged Guide Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_packagedguideid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_packagedguidesoperatorsessionId"></a> msmrw_packagedguidesoperatorsessionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Packaged Guides Operator Session**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_packagedguidesoperatorsessionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_PercentOfStepsVisited"></a> msmrw_PercentOfStepsVisited

|Property|Value|
|---|---|
|Description|**The number of unique visited steps divided by the total number of steps in the guide.**|
|DisplayName|**Percent Of Steps Visited**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_percentofstepsvisited`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msmrw_SessionEndTime"></a> msmrw_SessionEndTime

|Property|Value|
|---|---|
|Description|**Date and time when the session ended.**|
|DisplayName|**Session End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_sessionendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msmrw_SessionStartTime"></a> msmrw_SessionStartTime

|Property|Value|
|---|---|
|Description|**Date and time when the session started.**|
|DisplayName|**Session Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_sessionstarttime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msmrw_SessionState"></a> msmrw_SessionState

|Property|Value|
|---|---|
|Description|**Defines the state of the guide session. (Can be set to: Started, Ended, EndedOnCompletionStep).**|
|DisplayName|**Session State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_sessionstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_sessionstate`|

#### msmrw_SessionState Choices/Options

|Value|Label|
|---|---|
|937380000|**Started**|
|937380001|**Ended**|
|937380002|**EndedOnCompletionStep**|

### <a name="BKMK_msmrw_VisitedCompletionStep"></a> msmrw_VisitedCompletionStep

|Property|Value|
|---|---|
|Description|**Defines whether a completion step was visited during the guide session.**|
|DisplayName|**Visited Completion Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_visitedcompletionstep`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_msmrw_packagedguidesoperatorsession_visitedcompletionstep`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Status of the Packaged Guides Operator Session**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_packagedguidesoperatorsession_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Packaged Guides Operator Session**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_packagedguidesoperatorsession_statuscode`|

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

- [business_unit_msmrw_packagedguidesoperatorsession](#BKMK_business_unit_msmrw_packagedguidesoperatorsession)
- [lk_msmrw_packagedguidesoperatorsession_createdby](#BKMK_lk_msmrw_packagedguidesoperatorsession_createdby)
- [lk_msmrw_packagedguidesoperatorsession_createdonbehalfby](#BKMK_lk_msmrw_packagedguidesoperatorsession_createdonbehalfby)
- [lk_msmrw_packagedguidesoperatorsession_modifiedby](#BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedby)
- [lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby](#BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby)
- [owner_msmrw_packagedguidesoperatorsession](#BKMK_owner_msmrw_packagedguidesoperatorsession)
- [team_msmrw_packagedguidesoperatorsession](#BKMK_team_msmrw_packagedguidesoperatorsession)
- [user_msmrw_packagedguidesoperatorsession](#BKMK_user_msmrw_packagedguidesoperatorsession)

### <a name="BKMK_business_unit_msmrw_packagedguidesoperatorsession"></a> business_unit_msmrw_packagedguidesoperatorsession

One-To-Many Relationship: [businessunit business_unit_msmrw_packagedguidesoperatorsession](businessunit.md#BKMK_business_unit_msmrw_packagedguidesoperatorsession)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesoperatorsession_createdby"></a> lk_msmrw_packagedguidesoperatorsession_createdby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesoperatorsession_createdby](systemuser.md#BKMK_lk_msmrw_packagedguidesoperatorsession_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesoperatorsession_createdonbehalfby"></a> lk_msmrw_packagedguidesoperatorsession_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesoperatorsession_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_packagedguidesoperatorsession_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedby"></a> lk_msmrw_packagedguidesoperatorsession_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesoperatorsession_modifiedby](systemuser.md#BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby"></a> lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_packagedguidesoperatorsession_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_packagedguidesoperatorsession"></a> owner_msmrw_packagedguidesoperatorsession

One-To-Many Relationship: [owner owner_msmrw_packagedguidesoperatorsession](owner.md#BKMK_owner_msmrw_packagedguidesoperatorsession)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_packagedguidesoperatorsession"></a> team_msmrw_packagedguidesoperatorsession

One-To-Many Relationship: [team team_msmrw_packagedguidesoperatorsession](team.md#BKMK_team_msmrw_packagedguidesoperatorsession)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_packagedguidesoperatorsession"></a> user_msmrw_packagedguidesoperatorsession

One-To-Many Relationship: [systemuser user_msmrw_packagedguidesoperatorsession](systemuser.md#BKMK_user_msmrw_packagedguidesoperatorsession)

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

- [msmrw_msmrw_packagedguidesessionstepvisit_pack](#BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack)
- [msmrw_packagedguidesoperatorsession_AsyncOperations](#BKMK_msmrw_packagedguidesoperatorsession_AsyncOperations)
- [msmrw_packagedguidesoperatorsession_BulkDeleteFailures](#BKMK_msmrw_packagedguidesoperatorsession_BulkDeleteFailures)
- [msmrw_packagedguidesoperatorsession_DuplicateBaseRecord](#BKMK_msmrw_packagedguidesoperatorsession_DuplicateBaseRecord)
- [msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord](#BKMK_msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord)
- [msmrw_packagedguidesoperatorsession_MailboxTrackingFolders](#BKMK_msmrw_packagedguidesoperatorsession_MailboxTrackingFolders)
- [msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses](#BKMK_msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses)
- [msmrw_packagedguidesoperatorsession_ProcessSession](#BKMK_msmrw_packagedguidesoperatorsession_ProcessSession)
- [msmrw_packagedguidesoperatorsession_SyncErrors](#BKMK_msmrw_packagedguidesoperatorsession_SyncErrors)

### <a name="BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack"></a> msmrw_msmrw_packagedguidesessionstepvisit_pack

Many-To-One Relationship: [msmrw_packagedguidesessionstepvisit msmrw_msmrw_packagedguidesessionstepvisit_pack](msmrw_packagedguidesessionstepvisit.md#BKMK_msmrw_msmrw_packagedguidesessionstepvisit_pack)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguidesessionstepvisit`|
|ReferencingAttribute|`msmrw_packagedguidesessionid`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_packagedguidesessionstepvisit_pack`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_AsyncOperations"></a> msmrw_packagedguidesoperatorsession_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_packagedguidesoperatorsession_AsyncOperations](asyncoperation.md#BKMK_msmrw_packagedguidesoperatorsession_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_BulkDeleteFailures"></a> msmrw_packagedguidesoperatorsession_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_packagedguidesoperatorsession_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_packagedguidesoperatorsession_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_DuplicateBaseRecord"></a> msmrw_packagedguidesoperatorsession_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_packagedguidesoperatorsession_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_packagedguidesoperatorsession_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord"></a> msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_MailboxTrackingFolders"></a> msmrw_packagedguidesoperatorsession_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_packagedguidesoperatorsession_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_packagedguidesoperatorsession_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses"></a> msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_ProcessSession"></a> msmrw_packagedguidesoperatorsession_ProcessSession

Many-To-One Relationship: [processsession msmrw_packagedguidesoperatorsession_ProcessSession](processsession.md#BKMK_msmrw_packagedguidesoperatorsession_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_packagedguidesoperatorsession_SyncErrors"></a> msmrw_packagedguidesoperatorsession_SyncErrors

Many-To-One Relationship: [syncerror msmrw_packagedguidesoperatorsession_SyncErrors](syncerror.md#BKMK_msmrw_packagedguidesoperatorsession_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_packagedguidesoperatorsession_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

