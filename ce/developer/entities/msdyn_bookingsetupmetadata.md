---
title: "msdyn_bookingsetupmetadata Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bookingsetupmetadata entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_bookingsetupmetadata Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Unified Resource Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Booking Setup Metadata<br />
**DisplayCollectionName**: Booking Setup Metadata Records<br />
**SchemaName**: msdyn_bookingsetupmetadata<br />
**CollectionSchemaName**: msdyn_bookingsetupmetadatas<br />
**LogicalName**: msdyn_bookingsetupmetadata<br />
**LogicalCollectionName**: msdyn_bookingsetupmetadatas<br />
**EntitySetName**: msdyn_bookingsetupmetadatas<br />
**PrimaryIdAttribute**: msdyn_bookingsetupmetadataid<br />
**PrimaryNameAttribute**: msdyn_entitylogicalname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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
- [msdyn_EntityLogicalName](#BKMK_msdyn_EntityLogicalName)
- [msdyn_RequirementRelationshipLogicalName](#BKMK_msdyn_RequirementRelationshipLogicalName)
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

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_BookingRelationshipLogicalName"></a> msdyn_BookingRelationshipLogicalName

**Description**: A unique identifier that links bookings to a scheduling entity.<br />
**DisplayName**: Booking Relationship Logical Name<br />
**LogicalName**: msdyn_bookingrelationshiplogicalname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_bookingsetupmetadataId"></a> msdyn_bookingsetupmetadataId

**Description**: A unique identifier for an entity instance.<br />
**DisplayName**: Booking Setup Metadata<br />
**LogicalName**: msdyn_bookingsetupmetadataid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_BookingStatusFieldLogicalName"></a> msdyn_BookingStatusFieldLogicalName

**Description**: An option set that is used to group and filter statuses.<br />
**DisplayName**: Booking Status Field Logical Name<br />
**LogicalName**: msdyn_bookingstatusfieldlogicalname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_CancelBookingsWhenMoving"></a> msdyn_CancelBookingsWhenMoving

**Description**: Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."<br />
**DisplayName**: Cancel Bookings When Moving<br />
**LogicalName**: msdyn_cancelbookingswhenmoving<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_CloneEntityQuery"></a> msdyn_CloneEntityQuery

**Description**: Query for retrieving resource requirements for cloning.<br />
**DisplayName**: Clone Entity Query<br />
**LogicalName**: msdyn_cloneentityquery<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_msdyn_DefaultBookingCanceledStatus"></a> msdyn_DefaultBookingCanceledStatus

**Description**: The default booking canceled status to use when a user can't select a status.<br />
**DisplayName**: Default Booking Canceled Status<br />
**LogicalName**: msdyn_defaultbookingcanceledstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_msdyn_DefaultBookingCommittedStatus"></a> msdyn_DefaultBookingCommittedStatus

**Description**: The default booking committed status to use when a user can't select a status.<br />
**DisplayName**: Default Booking Committed Status<br />
**LogicalName**: msdyn_defaultbookingcommittedstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

**Description**: The default booking duration to use when a duration is not provided.<br />
**DisplayName**: Default Booking Duration<br />
**LogicalName**: msdyn_defaultbookingduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_DefaultRequirementActiveStatus"></a> msdyn_DefaultRequirementActiveStatus

**Description**: The default requirement active status to use when a user can't select a status<br />
**DisplayName**: Default Requirement Active Status<br />
**LogicalName**: msdyn_defaultrequirementactivestatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_requirementstatus


### <a name="BKMK_msdyn_DefaultRequirementCanceledStatus"></a> msdyn_DefaultRequirementCanceledStatus

**Description**: The default requirement canceled status to use when a user can't select a status.<br />
**DisplayName**: Default Requirement Canceled Status<br />
**LogicalName**: msdyn_defaultrequirementcanceledstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_requirementstatus


### <a name="BKMK_msdyn_DefaultRequirementCompletedStatus"></a> msdyn_DefaultRequirementCompletedStatus

**Description**: The default requirement completed status to use when a user can't select a status.<br />
**DisplayName**: Default Requirement Completed Status<br />
**LogicalName**: msdyn_defaultrequirementcompletedstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_requirementstatus


### <a name="BKMK_msdyn_DisableRequirementAutoCreation"></a> msdyn_DisableRequirementAutoCreation

**Description**: <br />
**DisplayName**: Disable Requirement Auto Creation<br />
**LogicalName**: msdyn_disablerequirementautocreation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_EntityLogicalName"></a> msdyn_EntityLogicalName

**Description**: The name of the custom entity.<br />
**DisplayName**: Entity Logical Name<br />
**LogicalName**: msdyn_entitylogicalname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_RequirementRelationshipLogicalName"></a> msdyn_RequirementRelationshipLogicalName

**Description**: A unique identifier that links requirements to an enabled scheduling entity.<br />
**DisplayName**: Requirement Relationship Logical Name<br />
**LogicalName**: msdyn_requirementrelationshiplogicalname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_RetrieveConstraintsQuery"></a> msdyn_RetrieveConstraintsQuery

**Description**: <br />
**DisplayName**: Retrieve Constraints Query<br />
**LogicalName**: msdyn_retrieveconstraintsquery<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

**Description**: <br />
**DisplayName**: Retrieve Resources Query<br />
**LogicalName**: msdyn_retrieveresourcesquery<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Booking Setup Metadata<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Booking Setup Metadata<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_CloneEntityQueryName](#BKMK_msdyn_CloneEntityQueryName)
- [msdyn_DefaultBookingCanceledStatusName](#BKMK_msdyn_DefaultBookingCanceledStatusName)
- [msdyn_DefaultBookingCommittedStatusName](#BKMK_msdyn_DefaultBookingCommittedStatusName)
- [msdyn_DefaultRequirementActiveStatusName](#BKMK_msdyn_DefaultRequirementActiveStatusName)
- [msdyn_DefaultRequirementCanceledStatusName](#BKMK_msdyn_DefaultRequirementCanceledStatusName)
- [msdyn_DefaultRequirementCompletedStatusName](#BKMK_msdyn_DefaultRequirementCompletedStatusName)
- [msdyn_RetrieveConstraintsQueryName](#BKMK_msdyn_RetrieveConstraintsQueryName)
- [msdyn_RetrieveResourcesQueryName](#BKMK_msdyn_RetrieveResourcesQueryName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CloneEntityQueryName"></a> msdyn_CloneEntityQueryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_cloneentityqueryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultBookingCanceledStatusName"></a> msdyn_DefaultBookingCanceledStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultbookingcanceledstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultBookingCommittedStatusName"></a> msdyn_DefaultBookingCommittedStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultbookingcommittedstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultRequirementActiveStatusName"></a> msdyn_DefaultRequirementActiveStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultrequirementactivestatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultRequirementCanceledStatusName"></a> msdyn_DefaultRequirementCanceledStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultrequirementcanceledstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultRequirementCompletedStatusName"></a> msdyn_DefaultRequirementCompletedStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultrequirementcompletedstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RetrieveConstraintsQueryName"></a> msdyn_RetrieveConstraintsQueryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_retrieveconstraintsqueryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RetrieveResourcesQueryName"></a> msdyn_RetrieveResourcesQueryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_retrieveresourcesqueryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_UserEntityInstanceDatas](#BKMK_msdyn_bookingsetupmetadata_UserEntityInstanceDatas)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement)


### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

Same as syncerror entity [msdyn_bookingsetupmetadata_SyncErrors](syncerror.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

Same as asyncoperation entity [msdyn_bookingsetupmetadata_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_bookingsetupmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookingsetupmetadata_UserEntityInstanceDatas"></a> msdyn_bookingsetupmetadata_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_bookingsetupmetadata_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_bookingsetupmetadata_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

Same as processsession entity [msdyn_bookingsetupmetadata_ProcessSession](processsession.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_bookingsetupmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

Same as bookableresourcebooking entity [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: msdyn_bookingsetupmetadataid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_bookingsetupmetadata_bookableresour<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement"></a> msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement

Same as msdyn_resourcerequirement entity [msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: msdyn_bookingsetupmetadataid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_bookingsetupmetadata_msdyn_resource<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Requirements
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_bookingsetupmetadata_createdby](#BKMK_lk_msdyn_bookingsetupmetadata_createdby)
- [lk_msdyn_bookingsetupmetadata_createdonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)
- [lk_msdyn_bookingsetupmetadata_modifiedby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)
- [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)
- [user_msdyn_bookingsetupmetadata](#BKMK_user_msdyn_bookingsetupmetadata)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus)


### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdby"></a> lk_msdyn_bookingsetupmetadata_createdby

See systemuser Entity [lk_msdyn_bookingsetupmetadata_createdby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby"></a> lk_msdyn_bookingsetupmetadata_createdonbehalfby

See systemuser Entity [lk_msdyn_bookingsetupmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedby"></a> lk_msdyn_bookingsetupmetadata_modifiedby

See systemuser Entity [lk_msdyn_bookingsetupmetadata_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby"></a> lk_msdyn_bookingsetupmetadata_modifiedonbehalfby

See systemuser Entity [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_bookingsetupmetadata"></a> user_msdyn_bookingsetupmetadata

See systemuser Entity [user_msdyn_bookingsetupmetadata](systemuser.md#BKMK_user_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

See team Entity [team_msdyn_bookingsetupmetadata](team.md#BKMK_team_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

See businessunit Entity [business_unit_msdyn_bookingsetupmetadata](businessunit.md#BKMK_business_unit_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus

See bookingstatus Entity [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus

See bookingstatus Entity [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bookingsetupmetadata?text=msdyn_bookingsetupmetadata EntityType" />