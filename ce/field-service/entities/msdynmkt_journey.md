---
title: "Journey (msdynmkt_journey) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Journey (msdynmkt_journey) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Journey (msdynmkt_journey) table/entity reference



## Messages

The following table lists the messages for the Journey (msdynmkt_journey) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_journeys<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdynmkt_CreateDraftJourneyVersion`<br />Event: False |**msdynmkt_CreateDraftJourneyVersion action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_journeys<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_journeys(*msdynmkt_journeyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Journey (msdynmkt_journey) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Journey (msdynmkt_journey) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Journey** |
| **DisplayCollectionName** | **Journeys** |
| **SchemaName** | `msdynmkt_journey` |
| **CollectionSchemaName** | `msdynmkt_journeies` |
| **EntitySetName** | `msdynmkt_journeys`|
| **LogicalName** | `msdynmkt_journey` |
| **LogicalCollectionName** | `msdynmkt_journeies` |
| **PrimaryIdAttribute** | `msdynmkt_journeyid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_baseversionjourneyid](#BKMK_msdynmkt_baseversionjourneyid)
- [msdynmkt_DoubleOptInCompliance](#BKMK_msdynmkt_DoubleOptInCompliance)
- [msdynmkt_errorDetails](#BKMK_msdynmkt_errorDetails)
- [msdynmkt_flags](#BKMK_msdynmkt_flags)
- [msdynmkt_frequencycaptype](#BKMK_msdynmkt_frequencycaptype)
- [msdynmkt_issupersededbylaterversion](#BKMK_msdynmkt_issupersededbylaterversion)
- [msdynmkt_journeyEndTime](#BKMK_msdynmkt_journeyEndTime)
- [msdynmkt_journeyfeatureversionnumber](#BKMK_msdynmkt_journeyfeatureversionnumber)
- [msdynmkt_journeyId](#BKMK_msdynmkt_journeyId)
- [msdynmkt_journeyinstancepartitionenabled](#BKMK_msdynmkt_journeyinstancepartitionenabled)
- [msdynmkt_JourneyJSON](#BKMK_msdynmkt_JourneyJSON)
- [msdynmkt_JourneyJSONBackup](#BKMK_msdynmkt_JourneyJSONBackup)
- [msdynmkt_journeyStartTime](#BKMK_msdynmkt_journeyStartTime)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_Purpose](#BKMK_msdynmkt_Purpose)
- [msdynmkt_readyToBeTriggeredBySegmentRefresh](#BKMK_msdynmkt_readyToBeTriggeredBySegmentRefresh)
- [msdynmkt_templateid](#BKMK_msdynmkt_templateid)
- [msdynmkt_triggerType](#BKMK_msdynmkt_triggerType)
- [msdynmkt_versiondescription](#BKMK_msdynmkt_versiondescription)
- [msdynmkt_versionnumber](#BKMK_msdynmkt_versionnumber)
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

### <a name="BKMK_msdynmkt_baseversionjourneyid"></a> msdynmkt_baseversionjourneyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Base version**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_baseversionjourneyid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_DoubleOptInCompliance"></a> msdynmkt_DoubleOptInCompliance

|Property|Value|
|---|---|
|Description|**Double Opt-In Compliance lookup if the journey's purpose is DOI**|
|DisplayName|**Double Opt-In Compliance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doubleoptincompliance`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

### <a name="BKMK_msdynmkt_errorDetails"></a> msdynmkt_errorDetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_errorDetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_flags"></a> msdynmkt_flags

|Property|Value|
|---|---|
|Description|**Internal usage only.**|
|DisplayName|**Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_flags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_frequencycaptype"></a> msdynmkt_frequencycaptype

|Property|Value|
|---|---|
|Description|**Frequency cap type for the journey**|
|DisplayName|**Frequency cap type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_frequencycaptype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdynmkt_journey_msdynmkt_frequencycaptype`|

#### msdynmkt_frequencycaptype Choices/Options

|Value|Label|
|---|---|
|0|**Apply frequency cap by skipping messages**|
|1|**Ignore frequency cap**|

### <a name="BKMK_msdynmkt_issupersededbylaterversion"></a> msdynmkt_issupersededbylaterversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is superseded by later version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_issupersededbylaterversion`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_journey_issupersededbylaterversion`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_journeyEndTime"></a> msdynmkt_journeyEndTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey end time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_journeyfeatureversionnumber"></a> msdynmkt_journeyfeatureversionnumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey feature version number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyfeatureversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_journeyId"></a> msdynmkt_journeyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Journey**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_journeyinstancepartitionenabled"></a> msdynmkt_journeyinstancepartitionenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is journey instance partitioning enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyinstancepartitionenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_journey_msdynmkt_journeyinstancepartitionenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_JourneyJSON"></a> msdynmkt_JourneyJSON

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_JourneyJSONBackup"></a> msdynmkt_JourneyJSONBackup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey JSON Backup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyjsonbackup`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_journeyStartTime"></a> msdynmkt_journeyStartTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the journey.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_msdynmkt_Purpose"></a> msdynmkt_Purpose

|Property|Value|
|---|---|
|Description|**Journey's purpose - Marketing, DOI**|
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_purpose`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_msdynmkt_journey_msdynmkt_purpose`|

#### msdynmkt_Purpose Choices/Options

|Value|Label|
|---|---|
|721460000|**Marketing**|
|721460001|**Double Opt-In**|

### <a name="BKMK_msdynmkt_readyToBeTriggeredBySegmentRefresh"></a> msdynmkt_readyToBeTriggeredBySegmentRefresh

|Property|Value|
|---|---|
|Description||
|DisplayName|**Ready to be triggered by segment refresh**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_readytobetriggeredbysegmentrefresh`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_journey_msdynmkt_readytobetriggeredbysegmentrefresh`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_templateid"></a> msdynmkt_templateid

|Property|Value|
|---|---|
|Description|**ID of template that journey is created from**|
|DisplayName|**Template ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_templateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journeytemplate|

### <a name="BKMK_msdynmkt_triggerType"></a> msdynmkt_triggerType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Trigger type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_triggertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdynmkt_journey_msdynmkt_triggertype`|

#### msdynmkt_triggerType Choices/Options

|Value|Label|
|---|---|
|0|**Recurring**|
|1|**Ongoing**|
|2|**OneTime**|
|3|**Event**|

### <a name="BKMK_msdynmkt_versiondescription"></a> msdynmkt_versiondescription

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey version description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_versiondescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_versionnumber"></a> msdynmkt_versionnumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Version number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_versionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

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
|Description|**Status of the Journey**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_journey_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />DefaultStatus: 1<br />InvariantName: `Draft`|
|1|Label: **Live**<br />DefaultStatus: 2<br />InvariantName: `Live`|
|2|Label: **Stopped**<br />DefaultStatus: 3<br />InvariantName: `Stopped`|
|3|Label: **Publishing**<br />DefaultStatus: 4<br />InvariantName: `Publishing`|
|4|Label: **Deleted**<br />DefaultStatus: 6<br />InvariantName: `Deleted`|
|5|Label: **Completing**<br />DefaultStatus: 7<br />InvariantName: `Completing`|
|6|Label: **Completed**<br />DefaultStatus: 8<br />InvariantName: `Completed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Journey**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_journey_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Live**<br />State:1<br />TransitionData: None|
|3|Label: **Stopped**<br />State:2<br />TransitionData: None|
|4|Label: **Publishing**<br />State:3<br />TransitionData: None|
|5|Label: **Draining**<br />State:2<br />TransitionData: None|
|6|Label: **Deleted**<br />State:4<br />TransitionData: None|
|7|Label: **Completing**<br />State:5<br />TransitionData: None|
|8|Label: **Completed**<br />State:6<br />TransitionData: None|

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
|DisplayName|**Business Unit**|
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

- [business_unit_msdynmkt_journey](#BKMK_business_unit_msdynmkt_journey)
- [lk_msdynmkt_journey_createdby](#BKMK_lk_msdynmkt_journey_createdby)
- [lk_msdynmkt_journey_createdonbehalfby](#BKMK_lk_msdynmkt_journey_createdonbehalfby)
- [lk_msdynmkt_journey_modifiedby](#BKMK_lk_msdynmkt_journey_modifiedby)
- [lk_msdynmkt_journey_modifiedonbehalfby](#BKMK_lk_msdynmkt_journey_modifiedonbehalfby)
- [msdynmkt_journey_to_template](#BKMK_msdynmkt_journey_to_template)
- [msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms](#BKMK_msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms)
- [owner_msdynmkt_journey](#BKMK_owner_msdynmkt_journey)
- [team_msdynmkt_journey](#BKMK_team_msdynmkt_journey)
- [user_msdynmkt_journey](#BKMK_user_msdynmkt_journey)

### <a name="BKMK_business_unit_msdynmkt_journey"></a> business_unit_msdynmkt_journey

One-To-Many Relationship: [businessunit business_unit_msdynmkt_journey](businessunit.md#BKMK_business_unit_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journey_createdby"></a> lk_msdynmkt_journey_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_journey_createdby](systemuser.md#BKMK_lk_msdynmkt_journey_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journey_createdonbehalfby"></a> lk_msdynmkt_journey_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_journey_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_journey_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journey_modifiedby"></a> lk_msdynmkt_journey_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_journey_modifiedby](systemuser.md#BKMK_lk_msdynmkt_journey_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journey_modifiedonbehalfby"></a> lk_msdynmkt_journey_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_journey_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_journey_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journey_to_template"></a> msdynmkt_journey_to_template

One-To-Many Relationship: [msdynmkt_journeytemplate msdynmkt_journey_to_template](msdynmkt_journeytemplate.md#BKMK_msdynmkt_journey_to_template)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journeytemplate`|
|ReferencedAttribute|`msdynmkt_journeytemplateid`|
|ReferencingAttribute|`msdynmkt_templateid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_templateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms"></a> msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_msdynmkt_journey_DoubleOptInCompliance_ms)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_doubleoptincompliance`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_DoubleOptInCompliance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_journey"></a> owner_msdynmkt_journey

One-To-Many Relationship: [owner owner_msdynmkt_journey](owner.md#BKMK_owner_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_journey"></a> team_msdynmkt_journey

One-To-Many Relationship: [team team_msdynmkt_journey](team.md#BKMK_team_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_journey"></a> user_msdynmkt_journey

One-To-Many Relationship: [systemuser user_msdynmkt_journey](systemuser.md#BKMK_user_msdynmkt_journey)

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

- [msdynmkt_experiment_journeyId](#BKMK_msdynmkt_experiment_journeyId)
- [msdynmkt_journey_AsyncOperations](#BKMK_msdynmkt_journey_AsyncOperations)
- [msdynmkt_journey_BulkDeleteFailures](#BKMK_msdynmkt_journey_BulkDeleteFailures)
- [msdynmkt_journey_DuplicateBaseRecord](#BKMK_msdynmkt_journey_DuplicateBaseRecord)
- [msdynmkt_journey_DuplicateMatchingRecord](#BKMK_msdynmkt_journey_DuplicateMatchingRecord)
- [msdynmkt_journey_journeyevent](#BKMK_msdynmkt_journey_journeyevent)
- [msdynmkt_journey_journeyoptimizationcount](#BKMK_msdynmkt_journey_journeyoptimizationcount)
- [msdynmkt_journey_MailboxTrackingFolders](#BKMK_msdynmkt_journey_MailboxTrackingFolders)
- [msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId](#BKMK_msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId)
- [msdynmkt_journey_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_journey_PrincipalObjectAttributeAccesses)
- [msdynmkt_journey_ProcessSession](#BKMK_msdynmkt_journey_ProcessSession)
- [msdynmkt_journey_SyncErrors](#BKMK_msdynmkt_journey_SyncErrors)
- [msdynmkt_journeydependency_journey](#BKMK_msdynmkt_journeydependency_journey)
- [msdynmkt_JourneyWorkflowMapping_JourneyId](#BKMK_msdynmkt_JourneyWorkflowMapping_JourneyId)
- [msdynmkt_marketingformsubmission_customerjourneyid](#BKMK_msdynmkt_marketingformsubmission_customerjourneyid)
- [msdynmkt_msdynmkt_journey_contact_customerjourneyid](#BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid)
- [msdynmkt_msdynmkt_journey_lead_customerjourneyid](#BKMK_msdynmkt_msdynmkt_journey_lead_customerjourneyid)
- [msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney](#BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney)
- [msdynmkt_opportunity_JourneyId_msdynmkt_journey](#BKMK_msdynmkt_opportunity_JourneyId_msdynmkt_journey)
- [msdynmkt_phonecall_JourneyId_msdynmkt_journey](#BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey)
- [msdynmkt_segmentusage_JourneyId_lookup](#BKMK_msdynmkt_segmentusage_JourneyId_lookup)
- [msdynmkt_segmentusage_msdynmkt_journey_dependententityid](#BKMK_msdynmkt_segmentusage_msdynmkt_journey_dependententityid)
- [msdynmkt_task_JourneyId_msdynmkt_journey](#BKMK_msdynmkt_task_JourneyId_msdynmkt_journey)

### <a name="BKMK_msdynmkt_experiment_journeyId"></a> msdynmkt_experiment_journeyId

Many-To-One Relationship: [msdynmkt_experiment msdynmkt_experiment_journeyId](msdynmkt_experiment.md#BKMK_msdynmkt_experiment_journeyId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_experiment`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experiment_journeyId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_AsyncOperations"></a> msdynmkt_journey_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_journey_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_journey_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_BulkDeleteFailures"></a> msdynmkt_journey_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_journey_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_journey_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_DuplicateBaseRecord"></a> msdynmkt_journey_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_journey_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_journey_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_DuplicateMatchingRecord"></a> msdynmkt_journey_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_journey_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_journey_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_journeyevent"></a> msdynmkt_journey_journeyevent

Many-To-One Relationship: [msdynmkt_journeyevent msdynmkt_journey_journeyevent](msdynmkt_journeyevent.md#BKMK_msdynmkt_journey_journeyevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyevent`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_journeyevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_journeyoptimizationcount"></a> msdynmkt_journey_journeyoptimizationcount

Many-To-One Relationship: [msdynmkt_journeyoptimizationcount msdynmkt_journey_journeyoptimizationcount](msdynmkt_journeyoptimizationcount.md#BKMK_msdynmkt_journey_journeyoptimizationcount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyoptimizationcount`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_journeyoptimizationcount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_MailboxTrackingFolders"></a> msdynmkt_journey_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_journey_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_journey_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId"></a> msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId

Many-To-One Relationship: [msdynmkt_journeyrunparameter msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId](msdynmkt_journeyrunparameter.md#BKMK_msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyrunparameter`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_msdynmkt_journeyrunparameter_JourneyId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_PrincipalObjectAttributeAccesses"></a> msdynmkt_journey_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_journey_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_journey_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_ProcessSession"></a> msdynmkt_journey_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_journey_ProcessSession](processsession.md#BKMK_msdynmkt_journey_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journey_SyncErrors"></a> msdynmkt_journey_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_journey_SyncErrors](syncerror.md#BKMK_msdynmkt_journey_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journey_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_journey"></a> msdynmkt_journeydependency_journey

Many-To-One Relationship: [msdynmkt_journeydependency msdynmkt_journeydependency_journey](msdynmkt_journeydependency.md#BKMK_msdynmkt_journeydependency_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`msdynmkt_journey`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_JourneyWorkflowMapping_JourneyId"></a> msdynmkt_JourneyWorkflowMapping_JourneyId

Many-To-One Relationship: [msdynmkt_journeyworkflowmapping msdynmkt_JourneyWorkflowMapping_JourneyId](msdynmkt_journeyworkflowmapping.md#BKMK_msdynmkt_JourneyWorkflowMapping_JourneyId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyworkflowmapping`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_JourneyWorkflowMapping_JourneyId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_customerjourneyid"></a> msdynmkt_marketingformsubmission_customerjourneyid

Many-To-One Relationship: [msdynmkt_marketingformsubmission msdynmkt_marketingformsubmission_customerjourneyid](msdynmkt_marketingformsubmission.md#BKMK_msdynmkt_marketingformsubmission_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`msdynmkt_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_customerjourneyid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid"></a> msdynmkt_msdynmkt_journey_contact_customerjourneyid

Many-To-One Relationship: [contact msdynmkt_msdynmkt_journey_contact_customerjourneyid](contact.md#BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdynmkt_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_journey_contact_customerjourneyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_lead_customerjourneyid"></a> msdynmkt_msdynmkt_journey_lead_customerjourneyid

Many-To-One Relationship: [lead msdynmkt_msdynmkt_journey_lead_customerjourneyid](lead.md#BKMK_msdynmkt_msdynmkt_journey_lead_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdynmkt_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_journey_lead_customerjourneyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney"></a> msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney

Many-To-One Relationship: [msdynmkt_teamsengagement msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney](msdynmkt_teamsengagement.md#BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_teamsengagement`|
|ReferencingAttribute|`msdynmkt_engagementjourney`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_opportunity_JourneyId_msdynmkt_journey"></a> msdynmkt_opportunity_JourneyId_msdynmkt_journey

Many-To-One Relationship: [opportunity msdynmkt_opportunity_JourneyId_msdynmkt_journey](opportunity.md#BKMK_msdynmkt_opportunity_JourneyId_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_opportunity_JourneyId_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey"></a> msdynmkt_phonecall_JourneyId_msdynmkt_journey

Many-To-One Relationship: [phonecall msdynmkt_phonecall_JourneyId_msdynmkt_journey](phonecall.md#BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_phonecall_JourneyId_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segmentusage_JourneyId_lookup"></a> msdynmkt_segmentusage_JourneyId_lookup

Many-To-One Relationship: [msdynmkt_segmentusage msdynmkt_segmentusage_JourneyId_lookup](msdynmkt_segmentusage.md#BKMK_msdynmkt_segmentusage_JourneyId_lookup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segmentusage_JourneyId_lookup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segmentusage_msdynmkt_journey_dependententityid"></a> msdynmkt_segmentusage_msdynmkt_journey_dependententityid

Many-To-One Relationship: [msdynmkt_segmentusage msdynmkt_segmentusage_msdynmkt_journey_dependententityid](msdynmkt_segmentusage.md#BKMK_msdynmkt_segmentusage_msdynmkt_journey_dependententityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`msdynmkt_dependententityid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segmentusage_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_task_JourneyId_msdynmkt_journey"></a> msdynmkt_task_JourneyId_msdynmkt_journey

Many-To-One Relationship: [task msdynmkt_task_JourneyId_msdynmkt_journey](task.md#BKMK_msdynmkt_task_JourneyId_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_task_JourneyId_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

