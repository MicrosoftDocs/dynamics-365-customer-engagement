---
title: "Scheduling Parameter (msdyn_schedulingparameter) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Scheduling Parameter (msdyn_schedulingparameter) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Scheduling Parameter (msdyn_schedulingparameter) table/entity reference (Microsoft Dynamics 365 Customer Service)

Scheduling Parameters

## Messages

The following table lists the messages for the Scheduling Parameter (msdyn_schedulingparameter) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_schedulingparameters<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_schedulingparameters(*msdyn_schedulingparameterid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_schedulingparameters(*msdyn_schedulingparameterid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_schedulingparameters<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_schedulingparameters(*msdyn_schedulingparameterid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_schedulingparameters(*msdyn_schedulingparameterid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_schedulingparameters(*msdyn_schedulingparameterid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Scheduling Parameter (msdyn_schedulingparameter) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Scheduling Parameter** |
| **DisplayCollectionName** | **Scheduling Parameters** |
| **SchemaName** | `msdyn_schedulingparameter` |
| **CollectionSchemaName** | `msdyn_schedulingparameters` |
| **EntitySetName** | `msdyn_schedulingparameters`|
| **LogicalName** | `msdyn_schedulingparameter` |
| **LogicalCollectionName** | `msdyn_schedulingparameters` |
| **PrimaryIdAttribute** | `msdyn_schedulingparameterid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdvancedSettings](#BKMK_msdyn_AdvancedSettings)
- [msdyn_AutoUpdateBookingTravel](#BKMK_msdyn_AutoUpdateBookingTravel)
- [msdyn_BackgroundJobsConfiguration](#BKMK_msdyn_BackgroundJobsConfiguration)
- [msdyn_ConnectToMaps](#BKMK_msdyn_ConnectToMaps)
- [msdyn_CustomGeoLatitudeField](#BKMK_msdyn_CustomGeoLatitudeField)
- [msdyn_CustomGeoLocationEntity](#BKMK_msdyn_CustomGeoLocationEntity)
- [msdyn_CustomGeoLongitudeField](#BKMK_msdyn_CustomGeoLongitudeField)
- [msdyn_CustomGeoResourceField](#BKMK_msdyn_CustomGeoResourceField)
- [msdyn_CustomGeoTimestampField](#BKMK_msdyn_CustomGeoTimestampField)
- [msdyn_DefaultRadiusUnit](#BKMK_msdyn_DefaultRadiusUnit)
- [msdyn_DefaultRadiusValue](#BKMK_msdyn_DefaultRadiusValue)
- [msdyn_DisableSanitizingHTMLTemplates](#BKMK_msdyn_DisableSanitizingHTMLTemplates)
- [msdyn_EnableAppointments](#BKMK_msdyn_EnableAppointments)
- [msdyn_EnableCustomGeoLocation](#BKMK_msdyn_EnableCustomGeoLocation)
- [msdyn_enableOptimizer](#BKMK_msdyn_enableOptimizer)
- [msdyn_EnableOutlookSchedules](#BKMK_msdyn_EnableOutlookSchedules)
- [msdyn_EnableSuggestSchedule](#BKMK_msdyn_EnableSuggestSchedule)
- [msdyn_GeoLocationExpiresAfterXMinutes](#BKMK_msdyn_GeoLocationExpiresAfterXMinutes)
- [msdyn_GeoLocationRefreshIntervalSeconds](#BKMK_msdyn_GeoLocationRefreshIntervalSeconds)
- [msdyn_internalflag](#BKMK_msdyn_internalflag)
- [msdyn_MapApiKey](#BKMK_msdyn_MapApiKey)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_SAAutoFilterServiceTerritory](#BKMK_msdyn_SAAutoFilterServiceTerritory)
- [msdyn_ScheduleBoardRefreshIntervalSeconds](#BKMK_msdyn_ScheduleBoardRefreshIntervalSeconds)
- [msdyn_schedulingparameterId](#BKMK_msdyn_schedulingparameterId)
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

### <a name="BKMK_msdyn_AdvancedSettings"></a> msdyn_AdvancedSettings

|Property|Value|
|---|---|
|Description|**For internal use**|
|DisplayName|**Advanced Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_advancedsettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_AutoUpdateBookingTravel"></a> msdyn_AutoUpdateBookingTravel

|Property|Value|
|---|---|
|Description|**When changing bookings on hourly Schedule Board, automatically update travel time and distance for affected bookings.**|
|DisplayName|**Auto Update Booking Travel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autoupdatebookingtravel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_autoupdatebookingtraveltype`|

#### msdyn_AutoUpdateBookingTravel Choices/Options

|Value|Label|
|---|---|
|192350000|**Disabled**|
|192350001|**Enabled**|

### <a name="BKMK_msdyn_BackgroundJobsConfiguration"></a> msdyn_BackgroundJobsConfiguration

|Property|Value|
|---|---|
|Description|**Configuration that defines operations, which will be executed in background periodically (internal use only)**|
|DisplayName|**Background Jobs Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_backgroundjobsconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|3000|

### <a name="BKMK_msdyn_ConnectToMaps"></a> msdyn_ConnectToMaps

|Property|Value|
|---|---|
|Description|**Determines if the mapping provider will be used for map location and distance calculations.**|
|DisplayName|**Connect to Maps**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connecttomaps`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingparameter_msdyn_connecttomaps`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CustomGeoLatitudeField"></a> msdyn_CustomGeoLatitudeField

|Property|Value|
|---|---|
|Description|**Shows the logical name of the latitude field to be used by geolocations.**|
|DisplayName|**Custom Geo Latitude Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgeolatitudefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGeoLocationEntity"></a> msdyn_CustomGeoLocationEntity

|Property|Value|
|---|---|
|Description|**Shows the logical name of custom entity to be used for geolocations.**|
|DisplayName|**Custom Geo Location Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgeolocationentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGeoLongitudeField"></a> msdyn_CustomGeoLongitudeField

|Property|Value|
|---|---|
|Description|**Shows the logical name of the longitude field to be used for geolocations.**|
|DisplayName|**Custom Geo Longitude Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgeolongitudefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGeoResourceField"></a> msdyn_CustomGeoResourceField

|Property|Value|
|---|---|
|Description|**Shows the logical name of the resource field to be used for geolocations.**|
|DisplayName|**Custom Geo Resource Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgeoresourcefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGeoTimestampField"></a> msdyn_CustomGeoTimestampField

|Property|Value|
|---|---|
|Description|**Shows the logical name of the timestamp field to be used for geolocations.**|
|DisplayName|**Custom Geo Timestamp Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgeotimestampfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DefaultRadiusUnit"></a> msdyn_DefaultRadiusUnit

|Property|Value|
|---|---|
|Description|**Choose the unit to display the distance on the Schedule Assistant experience**|
|DisplayName|**Default Radius Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultradiusunit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_distanceunit`|

#### msdyn_DefaultRadiusUnit Choices/Options

|Value|Label|
|---|---|
|192350000|**Miles**|
|192350001|**KM**|

### <a name="BKMK_msdyn_DefaultRadiusValue"></a> msdyn_DefaultRadiusValue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Radius Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultradiusvalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_DisableSanitizingHTMLTemplates"></a> msdyn_DisableSanitizingHTMLTemplates

|Property|Value|
|---|---|
|Description|**Disable Sanitizing HTML Templates on the Schedule Board**|
|DisplayName|**Disable Sanitizing HTML Templates**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disablesanitizinghtmltemplates`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingparameter_msdyn_disablesanitizinghtmltemplates`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableAppointments"></a> msdyn_EnableAppointments

|Property|Value|
|---|---|
|Description|**Enable appointments to display on the new schedule board and be considered in availability search for resources.**|
|DisplayName|**Include Appointments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableappointments`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_enableappointmentsoption`|

#### msdyn_EnableAppointments Choices/Options

|Value|Label|
|---|---|
|192350000|**No**|
|192350001|**Yes**|

### <a name="BKMK_msdyn_EnableCustomGeoLocation"></a> msdyn_EnableCustomGeoLocation

|Property|Value|
|---|---|
|Description|**Determines if a custom entity will be used as a source of geo locations for resources to be displayed in the map view.**|
|DisplayName|**Enable Custom Geo Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablecustomgeolocation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingparameter_msdyn_enablecustomgeolocation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enableOptimizer"></a> msdyn_enableOptimizer

|Property|Value|
|---|---|
|Description|**Determines if scheduling optimization is enabled.**|
|DisplayName|**Enable Optimizer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableoptimizer`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingparameter_msdyn_enableoptimizer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableOutlookSchedules"></a> msdyn_EnableOutlookSchedules

|Property|Value|
|---|---|
|Description|**This only applies when directly calling the API. It does not apply when the Book button is clicked on the Schedule Board or on any schedulable entity.**|
|DisplayName|**Include Outlook Free/Busy in Search Resource Availability API**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableoutlookschedules`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_enableappointmentsoption`|

#### msdyn_EnableOutlookSchedules Choices/Options

|Value|Label|
|---|---|
|192350000|**No**|
|192350001|**Yes**|

### <a name="BKMK_msdyn_EnableSuggestSchedule"></a> msdyn_EnableSuggestSchedule

|Property|Value|
|---|---|
|Description|**Enable Suggest Schedule**|
|DisplayName|**Enable Suggest Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablesuggestschedule`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_GeoLocationExpiresAfterXMinutes"></a> msdyn_GeoLocationExpiresAfterXMinutes

|Property|Value|
|---|---|
|Description||
|DisplayName|**Geo Location Expires After X Minutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_geolocationexpiresafterxminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_GeoLocationRefreshIntervalSeconds"></a> msdyn_GeoLocationRefreshIntervalSeconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**Geo Location Refresh Interval Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_geolocationrefreshintervalseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_internalflag"></a> msdyn_internalflag

|Property|Value|
|---|---|
|Description|**For internal use**|
|DisplayName|**For internal use**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflag`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_MapApiKey"></a> msdyn_MapApiKey

|Property|Value|
|---|---|
|Description|**Api key for map**|
|DisplayName|**Map Api Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mapapikey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_SAAutoFilterServiceTerritory"></a> msdyn_SAAutoFilterServiceTerritory

|Property|Value|
|---|---|
|Description|**Determines if the schedule assistant should automatically filter results based on the requirement territory.**|
|DisplayName|**Auto Filter Service Territory (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saautofilterserviceterritory`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingparameter_msdyn_saautofilterserviceterritory`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ScheduleBoardRefreshIntervalSeconds"></a> msdyn_ScheduleBoardRefreshIntervalSeconds

|Property|Value|
|---|---|
|Description||
|DisplayName|**The refresh rate of the schedule board.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scheduleboardrefreshintervalseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_schedulingparameterId"></a> msdyn_schedulingparameterId

|Property|Value|
|---|---|
|Description|**A unique identifier for an entity instance.**|
|DisplayName|**Scheduling Parameter**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingparameterid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Scheduling Parameter**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingparameter_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Scheduling Parameter**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingparameter_statuscode`|

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

- [lk_msdyn_schedulingparameter_createdby](#BKMK_lk_msdyn_schedulingparameter_createdby)
- [lk_msdyn_schedulingparameter_createdonbehalfby](#BKMK_lk_msdyn_schedulingparameter_createdonbehalfby)
- [lk_msdyn_schedulingparameter_modifiedby](#BKMK_lk_msdyn_schedulingparameter_modifiedby)
- [lk_msdyn_schedulingparameter_modifiedonbehalfby](#BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby)
- [organization_msdyn_schedulingparameter](#BKMK_organization_msdyn_schedulingparameter)

### <a name="BKMK_lk_msdyn_schedulingparameter_createdby"></a> lk_msdyn_schedulingparameter_createdby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingparameter_createdby](systemuser.md#BKMK_lk_msdyn_schedulingparameter_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingparameter_createdonbehalfby"></a> lk_msdyn_schedulingparameter_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingparameter_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_schedulingparameter_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingparameter_modifiedby"></a> lk_msdyn_schedulingparameter_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingparameter_modifiedby](systemuser.md#BKMK_lk_msdyn_schedulingparameter_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby"></a> lk_msdyn_schedulingparameter_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingparameter_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_schedulingparameter"></a> organization_msdyn_schedulingparameter

One-To-Many Relationship: [organization organization_msdyn_schedulingparameter](organization.md#BKMK_organization_msdyn_schedulingparameter)

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

- [msdyn_schedulingparameter_AsyncOperations](#BKMK_msdyn_schedulingparameter_AsyncOperations)
- [msdyn_schedulingparameter_BulkDeleteFailures](#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)
- [msdyn_schedulingparameter_MailboxTrackingFolders](#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)
- [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingparameter_ProcessSession](#BKMK_msdyn_schedulingparameter_ProcessSession)
- [msdyn_schedulingparameter_SyncErrors](#BKMK_msdyn_schedulingparameter_SyncErrors)

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_schedulingparameter_AsyncOperations](asyncoperation.md#BKMK_msdyn_schedulingparameter_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingparameter_BulkDeleteFailures"></a> msdyn_schedulingparameter_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_schedulingparameter_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingparameter_MailboxTrackingFolders"></a> msdyn_schedulingparameter_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_schedulingparameter_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingparameter_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingparameter_ProcessSession"></a> msdyn_schedulingparameter_ProcessSession

Many-To-One Relationship: [processsession msdyn_schedulingparameter_ProcessSession](processsession.md#BKMK_msdyn_schedulingparameter_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingparameter_SyncErrors"></a> msdyn_schedulingparameter_SyncErrors

Many-To-One Relationship: [syncerror msdyn_schedulingparameter_SyncErrors](syncerror.md#BKMK_msdyn_schedulingparameter_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingparameter_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

