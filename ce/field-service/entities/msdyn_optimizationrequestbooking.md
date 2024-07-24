---
title: "Optimization Request Booking (msdyn_optimizationrequestbooking) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Optimization Request Booking (msdyn_optimizationrequestbooking) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Optimization Request Booking (msdyn_optimizationrequestbooking) table/entity reference

Used to map bookings to their corresponding optimization requests

## Messages

The following table lists the messages for the Optimization Request Booking (msdyn_optimizationrequestbooking) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_optimizationrequestbookings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_optimizationrequestbookings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_optimizationrequestbookings(*msdyn_optimizationrequestbookingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Optimization Request Booking (msdyn_optimizationrequestbooking) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Optimization Request Booking (msdyn_optimizationrequestbooking) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Optimization Request Booking** |
| **DisplayCollectionName** | **Optimization Request Bookings** |
| **SchemaName** | `msdyn_optimizationrequestbooking` |
| **CollectionSchemaName** | `msdyn_optimizationrequestbookings` |
| **EntitySetName** | `msdyn_optimizationrequestbookings`|
| **LogicalName** | `msdyn_optimizationrequestbooking` |
| **LogicalCollectionName** | `msdyn_optimizationrequestbookings` |
| **PrimaryIdAttribute** | `msdyn_optimizationrequestbookingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BookableResourceBooking](#BKMK_msdyn_BookableResourceBooking)
- [msdyn_BookingInfo](#BKMK_msdyn_BookingInfo)
- [msdyn_BookingOptions](#BKMK_msdyn_BookingOptions)
- [msdyn_BookingOptionsExtended](#BKMK_msdyn_BookingOptionsExtended)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Operation](#BKMK_msdyn_Operation)
- [msdyn_OperationDetails](#BKMK_msdyn_OperationDetails)
- [msdyn_OperationReason](#BKMK_msdyn_OperationReason)
- [msdyn_OperationStatus](#BKMK_msdyn_OperationStatus)
- [msdyn_optimizationrequestbookingId](#BKMK_msdyn_optimizationrequestbookingId)
- [msdyn_RequirementGroup](#BKMK_msdyn_RequirementGroup)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_RoutingOptimization](#BKMK_msdyn_RoutingOptimization)
- [msdyn_SchedulingSnapshot](#BKMK_msdyn_SchedulingSnapshot)
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

### <a name="BKMK_msdyn_BookableResourceBooking"></a> msdyn_BookableResourceBooking

|Property|Value|
|---|---|
|Description|**Bookable resource booking that corresponds to the record.**|
|DisplayName|**Bookable Resource Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresourcebooking`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_BookingInfo"></a> msdyn_BookingInfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**BookingInfo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookinginfo`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|3000|

### <a name="BKMK_msdyn_BookingOptions"></a> msdyn_BookingOptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**BookingOptions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingoptions`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_BookingOptionsExtended"></a> msdyn_BookingOptionsExtended

|Property|Value|
|---|---|
|Description|**Lists booking options**|
|DisplayName|**BookingOptions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingoptionsextended`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of the custom entity.**|
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

### <a name="BKMK_msdyn_Operation"></a> msdyn_Operation

|Property|Value|
|---|---|
|Description|**The operation, which RSO performed on the booking.**|
|DisplayName|**Operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operation`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350003|
|GlobalChoiceName|`msdyn_optimizationrequestbooking_msdyn_operation`|

#### msdyn_Operation Choices/Options

|Value|Label|
|---|---|
|192350000|**Create**|
|192350001|**Update**|
|192350002|**Delete**|
|192350003|**Unchanged**|
|192350004|**Blocked**|
|192350005|**Optimizing**|
|192350006|**Invalid**|
|192350007|**Not Scheduled**|

### <a name="BKMK_msdyn_OperationDetails"></a> msdyn_OperationDetails

|Property|Value|
|---|---|
|Description|**The details of the operation, which RSO performed on the booking.**|
|DisplayName|**Operation Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationdetails`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyn_OperationReason"></a> msdyn_OperationReason

|Property|Value|
|---|---|
|Description|**Shows why this Optimization Request Booking isn’t scheduled by the Resource Scheduling Optimization.**|
|DisplayName|**Operation Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationreason`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_optimizationrequestbookingoperationreason`|

#### msdyn_OperationReason Choices/Options

|Value|Label|
|---|---|
|192350000|**None**|
|192350001|**Latitude or Longitude invalid**|
|192350002|**Estimated Duration less than or equal to 0**|
|192350003|**Unsupported Work Location**|
|192350004|**Optimization is not enabled**|
|192350005|**Empty Reason Not Scheduled**|
|192350006|**Booking outside Optimization Scope**|
|192350007|**Scheduling Method for this booking status is currently set to 'Do Not Move'**|
|192350008|**Booking or Requirement Inactive**|
|192350009|**Booking without Requirement**|
|192350010|**Scheduling Window outside of Optimization Range**|
|192350011|**Requirement is partially fulfilled already, can't be optimized**|
|192350012|**Estimated Travel Duration greater than Booking duration**|
|192350013|**Templates Cannot Be Scheduled**|
|192350014|**Requirements Belonging To A Requirement Group Cannot Be Scheduled**|
|192350015|**Unsupported Resource Type**|
|192350016|**Requirement Status is not Active**|
|192350017|**Lock to Pool type of Resource is currently not supported by Resource Scheduling Optimization**|
|192350018|**Booking overlaps with Optimization Range Start**|
|192350019|**Booking overlaps with Optimization Range End**|
|192350020|**Predecessor or successor out of optimization scope**|

### <a name="BKMK_msdyn_OperationStatus"></a> msdyn_OperationStatus

|Property|Value|
|---|---|
|Description|**The status of the operation, which RSO performed on the booking.**|
|DisplayName|**Operation Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_optimizationrequestbooking_msdyn_operationstatus`|

#### msdyn_OperationStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Completed**|
|192350001|**Failed**|
|192350002|**Canceled**|
|192350003|**Simulation**|
|192350004|**Conflicted**|
|192350005|**Skipped**|
|192350006|**Suggestion**|

### <a name="BKMK_msdyn_optimizationrequestbookingId"></a> msdyn_optimizationrequestbookingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Optimization Request Booking**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationrequestbookingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_RequirementGroup"></a> msdyn_RequirementGroup

|Property|Value|
|---|---|
|Description|**Requirement Group processed by RSO.**|
|DisplayName|**Requirement Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementgroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementgroup|

### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

|Property|Value|
|---|---|
|Description|**Resource Requirement processed by RSO.**|
|DisplayName|**Resource Requirement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcerequirement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcerequirement|

### <a name="BKMK_msdyn_RoutingOptimization"></a> msdyn_RoutingOptimization

|Property|Value|
|---|---|
|Description|**Scheduling optimization request ID that corresponds to the bookable resource booking.**|
|DisplayName|**Scheduling Optimization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingoptimization`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_routingoptimizationrequest|

### <a name="BKMK_msdyn_SchedulingSnapshot"></a> msdyn_SchedulingSnapshot

|Property|Value|
|---|---|
|Description||
|DisplayName|**SchedulingSnapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingsnapshot`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1700|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was migrated.**|
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
|Description|**Owner ID.**|
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
|Description|**Status of the optimization request booking.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_optimizationrequestbooking_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the optimization request booking.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_optimizationrequestbooking_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**Internal use only.**|
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
|Description|**User who created the record.**|
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
|Description|**Delegate user who created the record.**|
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
|Description|**User who last modified the record.**|
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
|Description|**Date and time when the record was last modified.**|
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
|Description|**Delegate user who modified the record.**|
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
|Description|**Business unit that owns the record.**|
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
|Description|**Team that owns the record.**|
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
|Description|**User that owns the record.**|
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

- [business_unit_msdyn_optimizationrequestbooking](#BKMK_business_unit_msdyn_optimizationrequestbooking)
- [lk_msdyn_optimizationrequestbooking_createdby](#BKMK_lk_msdyn_optimizationrequestbooking_createdby)
- [lk_msdyn_optimizationrequestbooking_createdonbehalfby](#BKMK_lk_msdyn_optimizationrequestbooking_createdonbehalfby)
- [lk_msdyn_optimizationrequestbooking_modifiedby](#BKMK_lk_msdyn_optimizationrequestbooking_modifiedby)
- [lk_msdyn_optimizationrequestbooking_modifiedonbehalfby](#BKMK_lk_msdyn_optimizationrequestbooking_modifiedonbehalfby)
- [msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking)
- [msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup](#BKMK_msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup)
- [msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement](#BKMK_msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement)
- [msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization](#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization)
- [owner_msdyn_optimizationrequestbooking](#BKMK_owner_msdyn_optimizationrequestbooking)
- [team_msdyn_optimizationrequestbooking](#BKMK_team_msdyn_optimizationrequestbooking)
- [user_msdyn_optimizationrequestbooking](#BKMK_user_msdyn_optimizationrequestbooking)

### <a name="BKMK_business_unit_msdyn_optimizationrequestbooking"></a> business_unit_msdyn_optimizationrequestbooking

One-To-Many Relationship: [businessunit business_unit_msdyn_optimizationrequestbooking](businessunit.md#BKMK_business_unit_msdyn_optimizationrequestbooking)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_optimizationrequestbooking_createdby"></a> lk_msdyn_optimizationrequestbooking_createdby

One-To-Many Relationship: [systemuser lk_msdyn_optimizationrequestbooking_createdby](systemuser.md#BKMK_lk_msdyn_optimizationrequestbooking_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_optimizationrequestbooking_createdonbehalfby"></a> lk_msdyn_optimizationrequestbooking_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_optimizationrequestbooking_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_optimizationrequestbooking_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_optimizationrequestbooking_modifiedby"></a> lk_msdyn_optimizationrequestbooking_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_optimizationrequestbooking_modifiedby](systemuser.md#BKMK_lk_msdyn_optimizationrequestbooking_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_optimizationrequestbooking_modifiedonbehalfby"></a> lk_msdyn_optimizationrequestbooking_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_optimizationrequestbooking_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_optimizationrequestbooking_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking"></a> msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_bookableresourcebooking`|
|ReferencingEntityNavigationPropertyName|`msdyn_BookableResourceBooking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup"></a> msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup

One-To-Many Relationship: [msdyn_requirementgroup msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup](msdyn_requirementgroup.md#BKMK_msdyn_msdyn_requirementgroup_msdyn_optimizationrequestbooking_RequirementGroup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`msdyn_requirementgroup`|
|ReferencingEntityNavigationPropertyName|`msdyn_RequirementGroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement"></a> msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_resourcerequirement_msdyn_optimizationrequestbooking_ResourceRequirement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`msdyn_resourcerequirement`|
|ReferencingEntityNavigationPropertyName|`msdyn_ResourceRequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization"></a> msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization

One-To-Many Relationship: [msdyn_routingoptimizationrequest msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization](msdyn_routingoptimizationrequest.md#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingoptimizationrequest`|
|ReferencedAttribute|`msdyn_routingoptimizationrequestid`|
|ReferencingAttribute|`msdyn_routingoptimization`|
|ReferencingEntityNavigationPropertyName|`msdyn_RoutingOptimization`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_optimizationrequestbooking"></a> owner_msdyn_optimizationrequestbooking

One-To-Many Relationship: [owner owner_msdyn_optimizationrequestbooking](owner.md#BKMK_owner_msdyn_optimizationrequestbooking)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_optimizationrequestbooking"></a> team_msdyn_optimizationrequestbooking

One-To-Many Relationship: [team team_msdyn_optimizationrequestbooking](team.md#BKMK_team_msdyn_optimizationrequestbooking)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_optimizationrequestbooking"></a> user_msdyn_optimizationrequestbooking

One-To-Many Relationship: [systemuser user_msdyn_optimizationrequestbooking](systemuser.md#BKMK_user_msdyn_optimizationrequestbooking)

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

- [msdyn_optimizationrequestbooking_AsyncOperations](#BKMK_msdyn_optimizationrequestbooking_AsyncOperations)
- [msdyn_optimizationrequestbooking_BulkDeleteFailures](#BKMK_msdyn_optimizationrequestbooking_BulkDeleteFailures)
- [msdyn_optimizationrequestbooking_DuplicateBaseRecord](#BKMK_msdyn_optimizationrequestbooking_DuplicateBaseRecord)
- [msdyn_optimizationrequestbooking_DuplicateMatchingRecord](#BKMK_msdyn_optimizationrequestbooking_DuplicateMatchingRecord)
- [msdyn_optimizationrequestbooking_MailboxTrackingFolders](#BKMK_msdyn_optimizationrequestbooking_MailboxTrackingFolders)
- [msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses](#BKMK_msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses)
- [msdyn_optimizationrequestbooking_ProcessSession](#BKMK_msdyn_optimizationrequestbooking_ProcessSession)
- [msdyn_optimizationrequestbooking_SyncErrors](#BKMK_msdyn_optimizationrequestbooking_SyncErrors)

### <a name="BKMK_msdyn_optimizationrequestbooking_AsyncOperations"></a> msdyn_optimizationrequestbooking_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_optimizationrequestbooking_AsyncOperations](asyncoperation.md#BKMK_msdyn_optimizationrequestbooking_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_BulkDeleteFailures"></a> msdyn_optimizationrequestbooking_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_optimizationrequestbooking_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_optimizationrequestbooking_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_DuplicateBaseRecord"></a> msdyn_optimizationrequestbooking_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_optimizationrequestbooking_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_optimizationrequestbooking_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_DuplicateMatchingRecord"></a> msdyn_optimizationrequestbooking_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_optimizationrequestbooking_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_optimizationrequestbooking_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_MailboxTrackingFolders"></a> msdyn_optimizationrequestbooking_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_optimizationrequestbooking_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_optimizationrequestbooking_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses"></a> msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_ProcessSession"></a> msdyn_optimizationrequestbooking_ProcessSession

Many-To-One Relationship: [processsession msdyn_optimizationrequestbooking_ProcessSession](processsession.md#BKMK_msdyn_optimizationrequestbooking_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_optimizationrequestbooking_SyncErrors"></a> msdyn_optimizationrequestbooking_SyncErrors

Many-To-One Relationship: [syncerror msdyn_optimizationrequestbooking_SyncErrors](syncerror.md#BKMK_msdyn_optimizationrequestbooking_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_optimizationrequestbooking_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

