---
title: "msdyn_agreementbookingsetup Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreementbookingsetup entity."
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
# msdyn_agreementbookingsetup Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify the maintenance bookings for the agreement.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingsetups(*msdyn_agreementbookingsetupid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Agreement Booking Setup<br />
**DisplayCollectionName**: Agreement Booking Setups<br />
**SchemaName**: msdyn_agreementbookingsetup<br />
**CollectionSchemaName**: msdyn_agreementbookingsetups<br />
**LogicalName**: msdyn_agreementbookingsetup<br />
**LogicalCollectionName**: msdyn_agreementbookingsetups<br />
**EntitySetName**: msdyn_agreementbookingsetups<br />
**PrimaryIdAttribute**: msdyn_agreementbookingsetupid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_agreementbookingsetupId](#BKMK_msdyn_agreementbookingsetupId)
- [msdyn_AutoGenerateBooking](#BKMK_msdyn_AutoGenerateBooking)
- [msdyn_AutoGenerateWO](#BKMK_msdyn_AutoGenerateWO)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_GenerateWODaysInAdvance](#BKMK_msdyn_GenerateWODaysInAdvance)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PostBookingFlexibility](#BKMK_msdyn_PostBookingFlexibility)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_PreBookingFlexibility](#BKMK_msdyn_PreBookingFlexibility)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_PreferredStartTime](#BKMK_msdyn_PreferredStartTime)
- [msdyn_Priority](#BKMK_msdyn_Priority)
- [msdyn_RecurrenceSettings](#BKMK_msdyn_RecurrenceSettings)
- [msdyn_Revision](#BKMK_msdyn_Revision)
- [msdyn_TimeWindowEnd](#BKMK_msdyn_TimeWindowEnd)
- [msdyn_TimeWindowStart](#BKMK_msdyn_TimeWindowStart)
- [msdyn_WorkOrderSummary](#BKMK_msdyn_WorkOrderSummary)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Description**: Agreement this Booking Setup relates to<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_agreementbookingsetupId"></a> msdyn_agreementbookingsetupId

**Description**: Shows the entity instances.<br />
**DisplayName**: Agreement Booking Setup<br />
**LogicalName**: msdyn_agreementbookingsetupid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_AutoGenerateBooking"></a> msdyn_AutoGenerateBooking

**Description**: Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup<br />
**DisplayName**: Auto Generate Booking<br />
**LogicalName**: msdyn_autogeneratebooking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_AutoGenerateWO"></a> msdyn_AutoGenerateWO

**Description**: Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup<br />
**DisplayName**: Auto Generate Work Order<br />
**LogicalName**: msdyn_autogeneratewo<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Type a description of this booking setup.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

**Description**: Shows the duration of the booking.<br />
**DisplayName**: Estimated Duration<br />
**LogicalName**: msdyn_estimatedduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_GenerateWODaysInAdvance"></a> msdyn_GenerateWODaysInAdvance

**Description**: Specify how many days in advance of the Booking Date the system should automatically generate a Work Order<br />
**DisplayName**: Generate Work Order Days In Advance<br />
**LogicalName**: msdyn_generatewodaysinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


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


### <a name="BKMK_msdyn_PostBookingFlexibility"></a> msdyn_PostBookingFlexibility

**Description**: Shows the flexibility of days after the booking date.<br />
**DisplayName**: Post Booking Flexibility<br />
**LogicalName**: msdyn_postbookingflexibility<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

**Description**: <br />
**DisplayName**: Postpone Generation Until<br />
**LogicalName**: msdyn_postponegenerationuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: TimeZoneIndependent<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_PreBookingFlexibility"></a> msdyn_PreBookingFlexibility

**Description**: Shows the flexibility of days prior to the booking date.<br />
**DisplayName**: Pre Booking Flexibility<br />
**LogicalName**: msdyn_prebookingflexibility<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

**Description**: Preferred Resource to booked<br />
**DisplayName**: Preferred Resource<br />
**LogicalName**: msdyn_preferredresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_PreferredStartTime"></a> msdyn_PreferredStartTime

**Description**: Shows the preferred time to booking.<br />
**DisplayName**: Preferred Start Time<br />
**LogicalName**: msdyn_preferredstarttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

**Description**: Booking Priority<br />
**DisplayName**: Priority<br />
**LogicalName**: msdyn_priority<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_priority


### <a name="BKMK_msdyn_RecurrenceSettings"></a> msdyn_RecurrenceSettings

**Description**: Stores the booking recurrence settings.<br />
**DisplayName**: Recurrence Settings<br />
**LogicalName**: msdyn_recurrencesettings<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

**Description**: For internal use only.<br />
**DisplayName**: Revision<br />
**LogicalName**: msdyn_revision<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

**Description**: Shows the time window up until when this can be booked.<br />
**DisplayName**: Time Window End<br />
**LogicalName**: msdyn_timewindowend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

**Description**: Shows the time window from when this can be booked.<br />
**DisplayName**: Time Window Start<br />
**LogicalName**: msdyn_timewindowstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

**Description**: Shows the work order summary to be set on the work orders generated.<br />
**DisplayName**: Work Order Summary<br />
**LogicalName**: msdyn_workordersummary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

**Description**: Work Order Type to be used on generated Work Orders<br />
**DisplayName**: Work Order Type<br />
**LogicalName**: msdyn_workordertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordertype


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


### <a name="BKMK_processid"></a> processid

**Description**: Contains the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Agreement Booking Setup<br />
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

**Description**: Reason for the status of the Agreement Booking Setup<br />
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_PreferredResourceName](#BKMK_msdyn_PreferredResourceName)
- [msdyn_PriorityName](#BKMK_msdyn_PriorityName)
- [msdyn_WorkOrderTypeName](#BKMK_msdyn_WorkOrderTypeName)
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


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PreferredResourceName"></a> msdyn_PreferredResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_preferredresourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriorityName"></a> msdyn_PriorityName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_priorityname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderTypeName"></a> msdyn_WorkOrderTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordertypename<br />
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

- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementbookingsetup_msdyn_approvals](#BKMK_msdyn_agreementbookingsetup_msdyn_approvals)
- [msdyn_agreementbookingsetup_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts)
- [msdyn_agreementbookingsetup_SyncErrors](#BKMK_msdyn_agreementbookingsetup_SyncErrors)
- [msdyn_agreementbookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)
- [msdyn_agreementbookingsetup_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)
- [msdyn_agreementbookingsetup_SharePointDocumentLocations](#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)
- [msdyn_agreementbookingsetup_SharePointDocuments](#BKMK_msdyn_agreementbookingsetup_SharePointDocuments)
- [msdyn_agreementbookingsetup_AsyncOperations](#BKMK_msdyn_agreementbookingsetup_AsyncOperations)
- [msdyn_agreementbookingsetup_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)
- [msdyn_agreementbookingsetup_UserEntityInstanceDatas](#BKMK_msdyn_agreementbookingsetup_UserEntityInstanceDatas)
- [msdyn_agreementbookingsetup_ProcessSession](#BKMK_msdyn_agreementbookingsetup_ProcessSession)
- [msdyn_agreementbookingsetup_BulkDeleteFailures](#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)
- [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementbookingsetup_Emails](#BKMK_msdyn_agreementbookingsetup_Emails)
- [msdyn_agreementbookingsetup_Faxes](#BKMK_msdyn_agreementbookingsetup_Faxes)
- [msdyn_agreementbookingsetup_Letters](#BKMK_msdyn_agreementbookingsetup_Letters)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_SocialActivities](#BKMK_msdyn_agreementbookingsetup_SocialActivities)
- [msdyn_agreementbookingsetup_connections1](#BKMK_msdyn_agreementbookingsetup_connections1)
- [msdyn_agreementbookingsetup_connections2](#BKMK_msdyn_agreementbookingsetup_connections2)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementbookingsetup_ServiceAppointments](#BKMK_msdyn_agreementbookingsetup_ServiceAppointments)
- [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup)


### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

Same as activitypointer entity [msdyn_agreementbookingsetup_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_ActivityPointers<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_approvals"></a> msdyn_agreementbookingsetup_msdyn_approvals

Same as msdyn_approval entity [msdyn_agreementbookingsetup_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreementbookingsetup_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts"></a> msdyn_agreementbookingsetup_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_agreementbookingsetup_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_SyncErrors"></a> msdyn_agreementbookingsetup_SyncErrors

Same as syncerror entity [msdyn_agreementbookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_agreementbookingsetup_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_SyncErrors<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord"></a> msdyn_agreementbookingsetup_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_agreementbookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord"></a> msdyn_agreementbookingsetup_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_agreementbookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations"></a> msdyn_agreementbookingsetup_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_agreementbookingsetup_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocuments"></a> msdyn_agreementbookingsetup_SharePointDocuments

Same as sharepointdocument entity [msdyn_agreementbookingsetup_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_agreementbookingsetup_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

Same as asyncoperation entity [msdyn_agreementbookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_AsyncOperations<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders"></a> msdyn_agreementbookingsetup_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_agreementbookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_UserEntityInstanceDatas"></a> msdyn_agreementbookingsetup_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_agreementbookingsetup_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_agreementbookingsetup_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

Same as processsession entity [msdyn_agreementbookingsetup_ProcessSession](processsession.md#BKMK_msdyn_agreementbookingsetup_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_ProcessSession<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures"></a> msdyn_agreementbookingsetup_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_agreementbookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

Same as appointment entity [msdyn_agreementbookingsetup_Appointments](appointment.md#BKMK_msdyn_agreementbookingsetup_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Appointments<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Emails"></a> msdyn_agreementbookingsetup_Emails

Same as email entity [msdyn_agreementbookingsetup_Emails](email.md#BKMK_msdyn_agreementbookingsetup_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Emails<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Faxes"></a> msdyn_agreementbookingsetup_Faxes

Same as fax entity [msdyn_agreementbookingsetup_Faxes](fax.md#BKMK_msdyn_agreementbookingsetup_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Faxes<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Letters"></a> msdyn_agreementbookingsetup_Letters

Same as letter entity [msdyn_agreementbookingsetup_Letters](letter.md#BKMK_msdyn_agreementbookingsetup_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Letters<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

Same as phonecall entity [msdyn_agreementbookingsetup_PhoneCalls](phonecall.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_PhoneCalls<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

Same as task entity [msdyn_agreementbookingsetup_Tasks](task.md#BKMK_msdyn_agreementbookingsetup_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Tasks<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_agreementbookingsetup_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_SocialActivities"></a> msdyn_agreementbookingsetup_SocialActivities

Same as socialactivity entity [msdyn_agreementbookingsetup_SocialActivities](socialactivity.md#BKMK_msdyn_agreementbookingsetup_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_SocialActivities<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_connections1"></a> msdyn_agreementbookingsetup_connections1

Same as connection entity [msdyn_agreementbookingsetup_connections1](connection.md#BKMK_msdyn_agreementbookingsetup_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_connections1<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_connections2"></a> msdyn_agreementbookingsetup_connections2

Same as connection entity [msdyn_agreementbookingsetup_connections2](connection.md#BKMK_msdyn_agreementbookingsetup_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_connections2<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

Same as queueitem entity [msdyn_agreementbookingsetup_QueueItems](queueitem.md#BKMK_msdyn_agreementbookingsetup_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_QueueItems<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

Same as annotation entity [msdyn_agreementbookingsetup_Annotations](annotation.md#BKMK_msdyn_agreementbookingsetup_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_Annotations<br />
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


### <a name="BKMK_msdyn_agreementbookingsetup_ServiceAppointments"></a> msdyn_agreementbookingsetup_ServiceAppointments

Same as serviceappointment entity [msdyn_agreementbookingsetup_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementbookingsetup_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingsetup_ServiceAppointments<br />
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


### <a name="BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**ReferencingAttribute**: bpf_msdyn_agreementbookingsetupid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_agreementbookingsetup
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingdate<br />
**ReferencingAttribute**: msdyn_bookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Booking Dates
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: msdyn_agreementbookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Incidents
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_agreementbookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Products
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_agreementbookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Services
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservicetask<br />
**ReferencingAttribute**: msdyn_agreementbookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Service Tasks
- **Order**: 10000

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

- [lk_msdyn_agreementbookingsetup_createdby](#BKMK_lk_msdyn_agreementbookingsetup_createdby)
- [lk_msdyn_agreementbookingsetup_createdonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby)
- [lk_msdyn_agreementbookingsetup_modifiedby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedby)
- [lk_msdyn_agreementbookingsetup_modifiedonbehalfby](#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby)
- [user_msdyn_agreementbookingsetup](#BKMK_user_msdyn_agreementbookingsetup)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [business_unit_msdyn_agreementbookingsetup](#BKMK_business_unit_msdyn_agreementbookingsetup)
- [processstage_msdyn_agreementbookingsetup](#BKMK_processstage_msdyn_agreementbookingsetup)
- [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)
- [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)
- [msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority)
- [msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType)


### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdby"></a> lk_msdyn_agreementbookingsetup_createdby

See systemuser Entity [lk_msdyn_agreementbookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby"></a> lk_msdyn_agreementbookingsetup_createdonbehalfby

See systemuser Entity [lk_msdyn_agreementbookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedby"></a> lk_msdyn_agreementbookingsetup_modifiedby

See systemuser Entity [lk_msdyn_agreementbookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby"></a> lk_msdyn_agreementbookingsetup_modifiedonbehalfby

See systemuser Entity [lk_msdyn_agreementbookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingsetup_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreementbookingsetup"></a> user_msdyn_agreementbookingsetup

See systemuser Entity [user_msdyn_agreementbookingsetup](systemuser.md#BKMK_user_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

See team Entity [team_msdyn_agreementbookingsetup](team.md#BKMK_team_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

See businessunit Entity [business_unit_msdyn_agreementbookingsetup](businessunit.md#BKMK_business_unit_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

See processstage Entity [processstage_msdyn_agreementbookingsetup](processstage.md#BKMK_processstage_msdyn_agreementbookingsetup) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource

See bookableresource Entity [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreementbookingsetup?text=msdyn_agreementbookingsetup EntityType" />