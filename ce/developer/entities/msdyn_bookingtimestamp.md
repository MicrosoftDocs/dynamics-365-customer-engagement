---
title: "msdyn_bookingtimestamp Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bookingtimestamp entity."
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
# msdyn_bookingtimestamp Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Tracks status changes of bookings and timestamps the change of the status

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Booking Timestamp<br />
**DisplayCollectionName**: Booking Timestamps<br />
**SchemaName**: msdyn_bookingtimestamp<br />
**CollectionSchemaName**: msdyn_bookingtimestamps<br />
**LogicalName**: msdyn_bookingtimestamp<br />
**LogicalCollectionName**: msdyn_bookingtimestamps<br />
**EntitySetName**: msdyn_bookingtimestamps<br />
**PrimaryIdAttribute**: msdyn_bookingtimestampid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_bookingtimestampId](#BKMK_msdyn_bookingtimestampId)
- [msdyn_GenerateJournals](#BKMK_msdyn_GenerateJournals)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TimestampSource](#BKMK_msdyn_TimestampSource)
- [msdyn_TimestampTime](#BKMK_msdyn_TimestampTime)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Shows the sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

**Description**: Unique identifier for Resource Booking associated with Booking Timestamp.<br />
**DisplayName**: Booking<br />
**LogicalName**: msdyn_booking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: bookableresourcebooking


### <a name="BKMK_msdyn_bookingtimestampId"></a> msdyn_bookingtimestampId

**Description**: Shows the entity instances.<br />
**DisplayName**: Booking Timestamp<br />
**LogicalName**: msdyn_bookingtimestampid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_GenerateJournals"></a> msdyn_GenerateJournals

**Description**: System internal field. Indicates that journals must be generated after saving timestamp from mobile.<br />
**DisplayName**: Generate Journals<br />
**LogicalName**: msdyn_generatejournals<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: <br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Scheduled
- **Value**: 690970001 **Label**: Traveling
- **Value**: 690970002 **Label**: On Break
- **Value**: 690970003 **Label**: In Progress
- **Value**: 690970004 **Label**: Completed
- **Value**: 690970005 **Label**: Canceled



### <a name="BKMK_msdyn_TimestampSource"></a> msdyn_TimestampSource

**Description**: <br />
**DisplayName**: Timestamp Source<br />
**LogicalName**: msdyn_timestampsource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Desktop
- **Value**: 690970001 **Label**: Mobile



### <a name="BKMK_msdyn_TimestampTime"></a> msdyn_TimestampTime

**Description**: <br />
**DisplayName**: Timestamp Time<br />
**LogicalName**: msdyn_timestamptime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
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

**Description**: Status of the Booking Timestamp<br />
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

**Description**: Reason for the status of the Booking Timestamp<br />
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

**Description**: Shows the time zone code that was in use when the record was created.<br />
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
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
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

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookingname<br />
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

- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_bookingtimestamp_msdyn_approvals](#BKMK_msdyn_bookingtimestamp_msdyn_approvals)
- [msdyn_bookingtimestamp_msdyn_bookingalerts](#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts)
- [msdyn_bookingtimestamp_SyncErrors](#BKMK_msdyn_bookingtimestamp_SyncErrors)
- [msdyn_bookingtimestamp_DuplicateMatchingRecord](#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)
- [msdyn_bookingtimestamp_DuplicateBaseRecord](#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)
- [msdyn_bookingtimestamp_SharePointDocumentLocations](#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)
- [msdyn_bookingtimestamp_SharePointDocuments](#BKMK_msdyn_bookingtimestamp_SharePointDocuments)
- [msdyn_bookingtimestamp_AsyncOperations](#BKMK_msdyn_bookingtimestamp_AsyncOperations)
- [msdyn_bookingtimestamp_MailboxTrackingFolders](#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)
- [msdyn_bookingtimestamp_UserEntityInstanceDatas](#BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas)
- [msdyn_bookingtimestamp_ProcessSession](#BKMK_msdyn_bookingtimestamp_ProcessSession)
- [msdyn_bookingtimestamp_BulkDeleteFailures](#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)
- [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_bookingtimestamp_Emails](#BKMK_msdyn_bookingtimestamp_Emails)
- [msdyn_bookingtimestamp_Faxes](#BKMK_msdyn_bookingtimestamp_Faxes)
- [msdyn_bookingtimestamp_Letters](#BKMK_msdyn_bookingtimestamp_Letters)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_SocialActivities](#BKMK_msdyn_bookingtimestamp_SocialActivities)
- [msdyn_bookingtimestamp_connections1](#BKMK_msdyn_bookingtimestamp_connections1)
- [msdyn_bookingtimestamp_connections2](#BKMK_msdyn_bookingtimestamp_connections2)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_bookingtimestamp_ServiceAppointments](#BKMK_msdyn_bookingtimestamp_ServiceAppointments)


### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

Same as activitypointer entity [msdyn_bookingtimestamp_ActivityPointers](activitypointer.md#BKMK_msdyn_bookingtimestamp_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingtimestamp_msdyn_approvals"></a> msdyn_bookingtimestamp_msdyn_approvals

Same as msdyn_approval entity [msdyn_bookingtimestamp_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_bookingtimestamp_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts"></a> msdyn_bookingtimestamp_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_bookingtimestamp_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_SyncErrors"></a> msdyn_bookingtimestamp_SyncErrors

Same as syncerror entity [msdyn_bookingtimestamp_SyncErrors](syncerror.md#BKMK_msdyn_bookingtimestamp_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_SyncErrors<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord"></a> msdyn_bookingtimestamp_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_bookingtimestamp_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord"></a> msdyn_bookingtimestamp_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_bookingtimestamp_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations"></a> msdyn_bookingtimestamp_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_bookingtimestamp_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_SharePointDocumentLocations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocuments"></a> msdyn_bookingtimestamp_SharePointDocuments

Same as sharepointdocument entity [msdyn_bookingtimestamp_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_bookingtimestamp_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

Same as asyncoperation entity [msdyn_bookingtimestamp_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingtimestamp_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_AsyncOperations<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders"></a> msdyn_bookingtimestamp_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_bookingtimestamp_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas"></a> msdyn_bookingtimestamp_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_bookingtimestamp_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

Same as processsession entity [msdyn_bookingtimestamp_ProcessSession](processsession.md#BKMK_msdyn_bookingtimestamp_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_ProcessSession<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_BulkDeleteFailures"></a> msdyn_bookingtimestamp_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_bookingtimestamp_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses"></a> msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

Same as appointment entity [msdyn_bookingtimestamp_Appointments](appointment.md#BKMK_msdyn_bookingtimestamp_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Appointments<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Emails"></a> msdyn_bookingtimestamp_Emails

Same as email entity [msdyn_bookingtimestamp_Emails](email.md#BKMK_msdyn_bookingtimestamp_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Emails<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Faxes"></a> msdyn_bookingtimestamp_Faxes

Same as fax entity [msdyn_bookingtimestamp_Faxes](fax.md#BKMK_msdyn_bookingtimestamp_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Faxes<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Letters"></a> msdyn_bookingtimestamp_Letters

Same as letter entity [msdyn_bookingtimestamp_Letters](letter.md#BKMK_msdyn_bookingtimestamp_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Letters<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

Same as phonecall entity [msdyn_bookingtimestamp_PhoneCalls](phonecall.md#BKMK_msdyn_bookingtimestamp_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_PhoneCalls<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

Same as task entity [msdyn_bookingtimestamp_Tasks](task.md#BKMK_msdyn_bookingtimestamp_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Tasks<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_bookingtimestamp_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_SocialActivities"></a> msdyn_bookingtimestamp_SocialActivities

Same as socialactivity entity [msdyn_bookingtimestamp_SocialActivities](socialactivity.md#BKMK_msdyn_bookingtimestamp_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_SocialActivities<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_connections1"></a> msdyn_bookingtimestamp_connections1

Same as connection entity [msdyn_bookingtimestamp_connections1](connection.md#BKMK_msdyn_bookingtimestamp_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingtimestamp_connections2"></a> msdyn_bookingtimestamp_connections2

Same as connection entity [msdyn_bookingtimestamp_connections2](connection.md#BKMK_msdyn_bookingtimestamp_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_connections2<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

Same as annotation entity [msdyn_bookingtimestamp_Annotations](annotation.md#BKMK_msdyn_bookingtimestamp_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_Annotations<br />
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


### <a name="BKMK_msdyn_bookingtimestamp_ServiceAppointments"></a> msdyn_bookingtimestamp_ServiceAppointments

Same as serviceappointment entity [msdyn_bookingtimestamp_ServiceAppointments](serviceappointment.md#BKMK_msdyn_bookingtimestamp_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingtimestamp_ServiceAppointments<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_bookingtimestamp_createdby](#BKMK_lk_msdyn_bookingtimestamp_createdby)
- [lk_msdyn_bookingtimestamp_createdonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby)
- [lk_msdyn_bookingtimestamp_modifiedby](#BKMK_lk_msdyn_bookingtimestamp_modifiedby)
- [lk_msdyn_bookingtimestamp_modifiedonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby)
- [user_msdyn_bookingtimestamp](#BKMK_user_msdyn_bookingtimestamp)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [business_unit_msdyn_bookingtimestamp](#BKMK_business_unit_msdyn_bookingtimestamp)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)


### <a name="BKMK_lk_msdyn_bookingtimestamp_createdby"></a> lk_msdyn_bookingtimestamp_createdby

See systemuser Entity [lk_msdyn_bookingtimestamp_createdby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby"></a> lk_msdyn_bookingtimestamp_createdonbehalfby

See systemuser Entity [lk_msdyn_bookingtimestamp_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedby"></a> lk_msdyn_bookingtimestamp_modifiedby

See systemuser Entity [lk_msdyn_bookingtimestamp_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby"></a> lk_msdyn_bookingtimestamp_modifiedonbehalfby

See systemuser Entity [lk_msdyn_bookingtimestamp_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_bookingtimestamp"></a> user_msdyn_bookingtimestamp

See systemuser Entity [user_msdyn_bookingtimestamp](systemuser.md#BKMK_user_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

See team Entity [team_msdyn_bookingtimestamp](team.md#BKMK_team_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

See businessunit Entity [business_unit_msdyn_bookingtimestamp](businessunit.md#BKMK_business_unit_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bookingtimestamp?text=msdyn_bookingtimestamp EntityType" />