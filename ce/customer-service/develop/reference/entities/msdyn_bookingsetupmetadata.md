---
title: "Booking Setup Metadata (msdyn_bookingsetupmetadata) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Booking Setup Metadata (msdyn_bookingsetupmetadata) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Booking Setup Metadata (msdyn_bookingsetupmetadata) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Booking Setup Metadata (msdyn_bookingsetupmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_bookingsetupmetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_bookingsetupmetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Booking Setup Metadata (msdyn_bookingsetupmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Booking Setup Metadata** |
| **DisplayCollectionName** | **Booking Setup Metadata Records** |
| **SchemaName** | `msdyn_bookingsetupmetadata` |
| **CollectionSchemaName** | `msdyn_bookingsetupmetadatas` |
| **EntitySetName** | `msdyn_bookingsetupmetadatas`|
| **LogicalName** | `msdyn_bookingsetupmetadata` |
| **LogicalCollectionName** | `msdyn_bookingsetupmetadatas` |
| **PrimaryIdAttribute** | `msdyn_bookingsetupmetadataid` |
| **PrimaryNameAttribute** |`msdyn_entitylogicalname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AvailableDurationMinimumPercentage](#BKMK_msdyn_AvailableDurationMinimumPercentage)
- [msdyn_BookingRelationshipLogicalName](#BKMK_msdyn_BookingRelationshipLogicalName)
- [msdyn_bookingsetupmetadataId](#BKMK_msdyn_bookingsetupmetadataId)
- [msdyn_BookingStatusFieldLogicalName](#BKMK_msdyn_BookingStatusFieldLogicalName)
- [msdyn_CancelBookingsWhenMoving](#BKMK_msdyn_CancelBookingsWhenMoving)
- [msdyn_CloneEntityQuery](#BKMK_msdyn_CloneEntityQuery)
- [msdyn_DefaultBookingCanceledStatus](#BKMK_msdyn_DefaultBookingCanceledStatus)
- [msdyn_DefaultBookingCommittedStatus](#BKMK_msdyn_DefaultBookingCommittedStatus)
- [msdyn_DefaultBookingDuration](#BKMK_msdyn_DefaultBookingDuration)
- [msdyn_DefaultRequirementActiveStatus](#BKMK_msdyn_DefaultRequirementActiveStatus)
- [msdyn_DefaultRequirementCanceledStatus](#BKMK_msdyn_DefaultRequirementCanceledStatus)
- [msdyn_DefaultRequirementCompletedStatus](#BKMK_msdyn_DefaultRequirementCompletedStatus)
- [msdyn_DisableRequirementAutoCreation](#BKMK_msdyn_DisableRequirementAutoCreation)
- [msdyn_enablequickbook](#BKMK_msdyn_enablequickbook)
- [msdyn_EntityLogicalName](#BKMK_msdyn_EntityLogicalName)
- [msdyn_RequirementRelationshipLogicalName](#BKMK_msdyn_RequirementRelationshipLogicalName)
- [msdyn_ResourceAvailabilityRetrievalLimit](#BKMK_msdyn_ResourceAvailabilityRetrievalLimit)
- [msdyn_RetrieveConstraintsQuery](#BKMK_msdyn_RetrieveConstraintsQuery)
- [msdyn_RetrieveResourcesQuery](#BKMK_msdyn_RetrieveResourcesQuery)
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

### <a name="BKMK_msdyn_AvailableDurationMinimumPercentage"></a> msdyn_AvailableDurationMinimumPercentage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Available Duration Minimum(%)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_availabledurationminimumpercentage`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_BookingRelationshipLogicalName"></a> msdyn_BookingRelationshipLogicalName

|Property|Value|
|---|---|
|Description|**A unique identifier that links bookings to a scheduling entity.**|
|DisplayName|**Booking Relationship Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingrelationshiplogicalname`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_msdyn_bookingsetupmetadataId"></a> msdyn_bookingsetupmetadataId

|Property|Value|
|---|---|
|Description|**A unique identifier for an entity instance.**|
|DisplayName|**Booking Setup Metadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingsetupmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_BookingStatusFieldLogicalName"></a> msdyn_BookingStatusFieldLogicalName

|Property|Value|
|---|---|
|Description|**An option set that is used to group and filter statuses.**|
|DisplayName|**Booking Status Field Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingstatusfieldlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_msdyn_CancelBookingsWhenMoving"></a> msdyn_CancelBookingsWhenMoving

|Property|Value|
|---|---|
|Description|**Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Canceled". This feature only applies when using the 'Move Bookings' option.**|
|DisplayName|**Cancel Bookings When Moving**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cancelbookingswhenmoving`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookingsetupmetadata_msdyn_cancelbookingswhenmoving`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CloneEntityQuery"></a> msdyn_CloneEntityQuery

|Property|Value|
|---|---|
|Description|**Query for retrieving resource requirements for cloning.**|
|DisplayName|**Clone Entity Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cloneentityquery`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

### <a name="BKMK_msdyn_DefaultBookingCanceledStatus"></a> msdyn_DefaultBookingCanceledStatus

|Property|Value|
|---|---|
|Description|**The default booking canceled status to use when a user can't select a status.**|
|DisplayName|**Default Booking Canceled Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultbookingcanceledstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_DefaultBookingCommittedStatus"></a> msdyn_DefaultBookingCommittedStatus

|Property|Value|
|---|---|
|Description|**The default booking committed status to use when a user can't select a status.**|
|DisplayName|**Default Booking Committed Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultbookingcommittedstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

|Property|Value|
|---|---|
|Description|**The default booking duration to use when a duration is not provided.**|
|DisplayName|**Default Booking Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultbookingduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_DefaultRequirementActiveStatus"></a> msdyn_DefaultRequirementActiveStatus

|Property|Value|
|---|---|
|Description|**The default requirement active status to use when a user can't select a status**|
|DisplayName|**Default Requirement Active Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultrequirementactivestatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementstatus|

### <a name="BKMK_msdyn_DefaultRequirementCanceledStatus"></a> msdyn_DefaultRequirementCanceledStatus

|Property|Value|
|---|---|
|Description|**The default requirement canceled status to use when a user can't select a status.**|
|DisplayName|**Default Requirement Canceled Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultrequirementcanceledstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementstatus|

### <a name="BKMK_msdyn_DefaultRequirementCompletedStatus"></a> msdyn_DefaultRequirementCompletedStatus

|Property|Value|
|---|---|
|Description|**The default requirement completed status to use when a user can't select a status.**|
|DisplayName|**Default Requirement Completed Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultrequirementcompletedstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementstatus|

### <a name="BKMK_msdyn_DisableRequirementAutoCreation"></a> msdyn_DisableRequirementAutoCreation

|Property|Value|
|---|---|
|Description|**Determines if a requirement should be created automatically when a booking is generated and there's no requirement for a scheduling entity.**|
|DisplayName|**Disable Requirement Auto Creation for Bookings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disablerequirementautocreation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookingsetupmetadata_msdyn_disablerequirementautocreation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablequickbook"></a> msdyn_enablequickbook

|Property|Value|
|---|---|
|Description|**If yes, the book button on schedulable entities will launch the quick book experience. Otherwise, the book button will launch the pop-out scheduler.**|
|DisplayName|**Enable Quick Book**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablequickbook`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookingsetupmetadata_msdyn_enablequickbook`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EntityLogicalName"></a> msdyn_EntityLogicalName

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_msdyn_RequirementRelationshipLogicalName"></a> msdyn_RequirementRelationshipLogicalName

|Property|Value|
|---|---|
|Description|**A unique identifier that links requirements to an enabled scheduling entity.**|
|DisplayName|**Requirement Relationship Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementrelationshiplogicalname`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_msdyn_ResourceAvailabilityRetrievalLimit"></a> msdyn_ResourceAvailabilityRetrievalLimit

|Property|Value|
|---|---|
|Description|**The maximum number of resources to retrieve and show in schedule assistant.**|
|DisplayName|**Resource Availability Retrieval Limit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourceavailabilityretrievallimit`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000|
|MinValue|0|

### <a name="BKMK_msdyn_RetrieveConstraintsQuery"></a> msdyn_RetrieveConstraintsQuery

|Property|Value|
|---|---|
|Description||
|DisplayName|**Retrieve Constraints Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrieveconstraintsquery`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

|Property|Value|
|---|---|
|Description||
|DisplayName|**Retrieve Resources Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrieveresourcesquery`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

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
|Description|**Status of the Booking Setup Metadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookingsetupmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Booking Setup Metadata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookingsetupmetadata_statuscode`|

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

- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [lk_msdyn_bookingsetupmetadata_createdby](#BKMK_lk_msdyn_bookingsetupmetadata_createdby)
- [lk_msdyn_bookingsetupmetadata_createdonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)
- [lk_msdyn_bookingsetupmetadata_modifiedby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)
- [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus)
- [owner_msdyn_bookingsetupmetadata](#BKMK_owner_msdyn_bookingsetupmetadata)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [user_msdyn_bookingsetupmetadata](#BKMK_user_msdyn_bookingsetupmetadata)

### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

One-To-Many Relationship: [businessunit business_unit_msdyn_bookingsetupmetadata](businessunit.md#BKMK_business_unit_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdby"></a> lk_msdyn_bookingsetupmetadata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_bookingsetupmetadata_createdby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby"></a> lk_msdyn_bookingsetupmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookingsetupmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedby"></a> lk_msdyn_bookingsetupmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_bookingsetupmetadata_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby"></a> lk_msdyn_bookingsetupmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_defaultbookingcanceledstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultBookingCanceledStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_defaultbookingcommittedstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultBookingCommittedStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery

One-To-Many Relationship: [msdyn_configuration msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`msdyn_cloneentityquery`|
|ReferencingEntityNavigationPropertyName|`msdyn_CloneEntityQuery`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery

One-To-Many Relationship: [msdyn_configuration msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`msdyn_retrieveconstraintsquery`|
|ReferencingEntityNavigationPropertyName|`msdyn_RetrieveConstraintsQuery`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery

One-To-Many Relationship: [msdyn_configuration msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`msdyn_retrieveresourcesquery`|
|ReferencingEntityNavigationPropertyName|`msdyn_RetrieveResourcesQuery`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus

One-To-Many Relationship: [msdyn_requirementstatus msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`msdyn_defaultrequirementactivestatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultRequirementActiveStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus

One-To-Many Relationship: [msdyn_requirementstatus msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`msdyn_defaultrequirementcanceledstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultRequirementCanceledStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus

One-To-Many Relationship: [msdyn_requirementstatus msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`msdyn_defaultrequirementcompletedstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultRequirementCompletedStatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_bookingsetupmetadata"></a> owner_msdyn_bookingsetupmetadata

One-To-Many Relationship: [owner owner_msdyn_bookingsetupmetadata](owner.md#BKMK_owner_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

One-To-Many Relationship: [team team_msdyn_bookingsetupmetadata](team.md#BKMK_team_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_bookingsetupmetadata"></a> user_msdyn_bookingsetupmetadata

One-To-Many Relationship: [systemuser user_msdyn_bookingsetupmetadata](systemuser.md#BKMK_user_msdyn_bookingsetupmetadata)

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

- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement)

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_bookingsetupmetadata_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_bookingsetupmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_bookingsetupmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

Many-To-One Relationship: [processsession msdyn_bookingsetupmetadata_ProcessSession](processsession.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

Many-To-One Relationship: [syncerror msdyn_bookingsetupmetadata_SyncErrors](syncerror.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingsetupmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_bookingsetupmetadata_bookableresour`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement"></a> msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_bookingsetupmetadata_msdyn_resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Requirements<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

