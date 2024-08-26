---
title: "Geolocation Settings (msdyn_geolocationsettings) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Geolocation Settings (msdyn_geolocationsettings) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Geolocation Settings (msdyn_geolocationsettings) table/entity reference (Microsoft Dynamics 365 Field Service)

Defines a list of geolocation settings.

## Messages

The following table lists the messages for the Geolocation Settings (msdyn_geolocationsettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_geolocationsettingscollection<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_geolocationsettingscollection(*msdyn_geolocationsettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_geolocationsettingscollection(*msdyn_geolocationsettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_geolocationsettingscollection<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_geolocationsettingscollection(*msdyn_geolocationsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_geolocationsettingscollection(*msdyn_geolocationsettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_geolocationsettingscollection(*msdyn_geolocationsettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Geolocation Settings (msdyn_geolocationsettings) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Geolocation Settings (msdyn_geolocationsettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Geolocation Settings** |
| **DisplayCollectionName** | **Geolocation Settings** |
| **SchemaName** | `msdyn_geolocationsettings` |
| **CollectionSchemaName** | `msdyn_geolocationsettingses` |
| **EntitySetName** | `msdyn_geolocationsettingscollection`|
| **LogicalName** | `msdyn_geolocationsettings` |
| **LogicalCollectionName** | `msdyn_geolocationsettingses` |
| **PrimaryIdAttribute** | `msdyn_geolocationsettingsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BeaconConfiguration](#BKMK_msdyn_BeaconConfiguration)
- [msdyn_EnableLocationTracking](#BKMK_msdyn_EnableLocationTracking)
- [msdyn_fridayendtime](#BKMK_msdyn_fridayendtime)
- [msdyn_fridaystarttime](#BKMK_msdyn_fridaystarttime)
- [msdyn_geolocationsettingsId](#BKMK_msdyn_geolocationsettingsId)
- [msdyn_mondayendtime](#BKMK_msdyn_mondayendtime)
- [msdyn_mondaystarttime](#BKMK_msdyn_mondaystarttime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_refreshIntervalSeconds](#BKMK_msdyn_refreshIntervalSeconds)
- [msdyn_saturdayendtime](#BKMK_msdyn_saturdayendtime)
- [msdyn_saturdaystarttime](#BKMK_msdyn_saturdaystarttime)
- [msdyn_sundayendtime](#BKMK_msdyn_sundayendtime)
- [msdyn_sundaystarttime](#BKMK_msdyn_sundaystarttime)
- [msdyn_thursdayendtime](#BKMK_msdyn_thursdayendtime)
- [msdyn_thursdaystarttime](#BKMK_msdyn_thursdaystarttime)
- [msdyn_tuesdayendtime](#BKMK_msdyn_tuesdayendtime)
- [msdyn_tuesdaystarttime](#BKMK_msdyn_tuesdaystarttime)
- [msdyn_wednesdayendtime](#BKMK_msdyn_wednesdayendtime)
- [msdyn_wednesdaystarttime](#BKMK_msdyn_wednesdaystarttime)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_BeaconConfiguration"></a> msdyn_BeaconConfiguration

|Property|Value|
|---|---|
|Description|**The Beacon configuration**|
|DisplayName|**Beacon Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_beaconconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdyn_EnableLocationTracking"></a> msdyn_EnableLocationTracking

|Property|Value|
|---|---|
|Description|**Checks if location tracking is enabled.**|
|DisplayName|**Enable Location Tracking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablelocationtracking`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_geolocationsettings_msdyn_enablelocationtracking`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_fridayendtime"></a> msdyn_fridayendtime

|Property|Value|
|---|---|
|Description|**The Friday tracking end time**|
|DisplayName|**Friday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fridayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_fridaystarttime"></a> msdyn_fridaystarttime

|Property|Value|
|---|---|
|Description|**The Friday tracking start time**|
|DisplayName|**Friday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fridaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_geolocationsettingsId"></a> msdyn_geolocationsettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**GeolocationSettings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_geolocationsettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_mondayendtime"></a> msdyn_mondayendtime

|Property|Value|
|---|---|
|Description|**The Monday tracking end time**|
|DisplayName|**Monday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mondayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_mondaystarttime"></a> msdyn_mondaystarttime

|Property|Value|
|---|---|
|Description|**The Monday tracking start time**|
|DisplayName|**Monday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mondaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the geolocation settings**|
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

### <a name="BKMK_msdyn_refreshIntervalSeconds"></a> msdyn_refreshIntervalSeconds

|Property|Value|
|---|---|
|Description|**The frequency in seconds at which location data should be uploaded from mobile clients to the server**|
|DisplayName|**Refresh interval**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_refreshintervalseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|60|

### <a name="BKMK_msdyn_saturdayendtime"></a> msdyn_saturdayendtime

|Property|Value|
|---|---|
|Description|**The Saturday tracking end time**|
|DisplayName|**Saturday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saturdayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_saturdaystarttime"></a> msdyn_saturdaystarttime

|Property|Value|
|---|---|
|Description|**The Saturday tracking start time**|
|DisplayName|**Saturday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saturdaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sundayendtime"></a> msdyn_sundayendtime

|Property|Value|
|---|---|
|Description|**The Sunday tracking end time**|
|DisplayName|**Sunday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sundayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sundaystarttime"></a> msdyn_sundaystarttime

|Property|Value|
|---|---|
|Description|**The Sunday tracking start time**|
|DisplayName|**Sunday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sundaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_thursdayendtime"></a> msdyn_thursdayendtime

|Property|Value|
|---|---|
|Description|**The Thursday tracking end time**|
|DisplayName|**Thursday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_thursdayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_thursdaystarttime"></a> msdyn_thursdaystarttime

|Property|Value|
|---|---|
|Description|**The Thursday tracking start time**|
|DisplayName|**Thursday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_thursdaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_tuesdayendtime"></a> msdyn_tuesdayendtime

|Property|Value|
|---|---|
|Description|**The Tuesday tracking end time**|
|DisplayName|**Tuesday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tuesdayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_tuesdaystarttime"></a> msdyn_tuesdaystarttime

|Property|Value|
|---|---|
|Description|**The Tuesday tracking start time**|
|DisplayName|**Tuesday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tuesdaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_wednesdayendtime"></a> msdyn_wednesdayendtime

|Property|Value|
|---|---|
|Description|**The Wednesday tracking end time**|
|DisplayName|**Wednesday End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wednesdayendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_wednesdaystarttime"></a> msdyn_wednesdaystarttime

|Property|Value|
|---|---|
|Description|**The Wednesday tracking start time**|
|DisplayName|**Wednesday Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wednesdaystarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the GeolocationSettings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_geolocationsettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the GeolocationSettings**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_geolocationsettings_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_geolocationsettings_createdby](#BKMK_lk_msdyn_geolocationsettings_createdby)
- [lk_msdyn_geolocationsettings_createdonbehalfby](#BKMK_lk_msdyn_geolocationsettings_createdonbehalfby)
- [lk_msdyn_geolocationsettings_modifiedby](#BKMK_lk_msdyn_geolocationsettings_modifiedby)
- [lk_msdyn_geolocationsettings_modifiedonbehalfby](#BKMK_lk_msdyn_geolocationsettings_modifiedonbehalfby)
- [organization_msdyn_geolocationsettings](#BKMK_organization_msdyn_geolocationsettings)

### <a name="BKMK_lk_msdyn_geolocationsettings_createdby"></a> lk_msdyn_geolocationsettings_createdby

One-To-Many Relationship: [systemuser lk_msdyn_geolocationsettings_createdby](systemuser.md#BKMK_lk_msdyn_geolocationsettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_geolocationsettings_createdonbehalfby"></a> lk_msdyn_geolocationsettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_geolocationsettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_geolocationsettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_geolocationsettings_modifiedby"></a> lk_msdyn_geolocationsettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_geolocationsettings_modifiedby](systemuser.md#BKMK_lk_msdyn_geolocationsettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_geolocationsettings_modifiedonbehalfby"></a> lk_msdyn_geolocationsettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_geolocationsettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_geolocationsettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_geolocationsettings"></a> organization_msdyn_geolocationsettings

One-To-Many Relationship: [organization organization_msdyn_geolocationsettings](organization.md#BKMK_organization_msdyn_geolocationsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_geolocationsettings_AsyncOperations](#BKMK_msdyn_geolocationsettings_AsyncOperations)
- [msdyn_geolocationsettings_BulkDeleteFailures](#BKMK_msdyn_geolocationsettings_BulkDeleteFailures)
- [msdyn_geolocationsettings_DuplicateBaseRecord](#BKMK_msdyn_geolocationsettings_DuplicateBaseRecord)
- [msdyn_geolocationsettings_DuplicateMatchingRecord](#BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord)
- [msdyn_geolocationsettings_MailboxTrackingFolders](#BKMK_msdyn_geolocationsettings_MailboxTrackingFolders)
- [msdyn_geolocationsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses)
- [msdyn_geolocationsettings_ProcessSession](#BKMK_msdyn_geolocationsettings_ProcessSession)
- [msdyn_geolocationsettings_SyncErrors](#BKMK_msdyn_geolocationsettings_SyncErrors)

### <a name="BKMK_msdyn_geolocationsettings_AsyncOperations"></a> msdyn_geolocationsettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_geolocationsettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_geolocationsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_BulkDeleteFailures"></a> msdyn_geolocationsettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_geolocationsettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_geolocationsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_DuplicateBaseRecord"></a> msdyn_geolocationsettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_geolocationsettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_geolocationsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord"></a> msdyn_geolocationsettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_geolocationsettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_MailboxTrackingFolders"></a> msdyn_geolocationsettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_geolocationsettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_geolocationsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses"></a> msdyn_geolocationsettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_geolocationsettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_ProcessSession"></a> msdyn_geolocationsettings_ProcessSession

Many-To-One Relationship: [processsession msdyn_geolocationsettings_ProcessSession](processsession.md#BKMK_msdyn_geolocationsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geolocationsettings_SyncErrors"></a> msdyn_geolocationsettings_SyncErrors

Many-To-One Relationship: [syncerror msdyn_geolocationsettings_SyncErrors](syncerror.md#BKMK_msdyn_geolocationsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_geolocationsettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

