---
title: "msdyn_timeentry Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_timeentry entity."
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
# msdyn_timeentry Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Entity used  for time entry.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_timeentries<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_timeentries<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Time Entry<br />
**DisplayCollectionName**: Time Entries<br />
**SchemaName**: msdyn_timeentry<br />
**CollectionSchemaName**: msdyn_timeentries<br />
**LogicalName**: msdyn_timeentry<br />
**LogicalCollectionName**: msdyn_timeentries<br />
**EntitySetName**: msdyn_timeentries<br />
**PrimaryIdAttribute**: msdyn_timeentryid<br />
**PrimaryNameAttribute**: msdyn_description<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_date](#BKMK_msdyn_date)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_duration](#BKMK_msdyn_duration)
- [msdyn_entryStatus](#BKMK_msdyn_entryStatus)
- [msdyn_externalDescription](#BKMK_msdyn_externalDescription)
- [msdyn_manager](#BKMK_msdyn_manager)
- [msdyn_project](#BKMK_msdyn_project)
- [msdyn_projectTask](#BKMK_msdyn_projectTask)
- [msdyn_relatedItemId](#BKMK_msdyn_relatedItemId)
- [msdyn_relatedItemType](#BKMK_msdyn_relatedItemType)
- [msdyn_resourceCategory](#BKMK_msdyn_resourceCategory)
- [msdyn_ResourceOrganizationalUnitId](#BKMK_msdyn_ResourceOrganizationalUnitId)
- [msdyn_targetEntryStatus](#BKMK_msdyn_targetEntryStatus)
- [msdyn_timeentryId](#BKMK_msdyn_timeentryId)
- [msdyn_type](#BKMK_msdyn_type)
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


### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

**Description**: Shows the bookable resource.<br />
**DisplayName**: Bookable Resource<br />
**LogicalName**: msdyn_bookableresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_date"></a> msdyn_date

**Description**: Enter the time entry date.<br />
**DisplayName**: Date<br />
**LogicalName**: msdyn_date<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type the description of the time entry.<br />
**DisplayName**: Internal Comments<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_duration"></a> msdyn_duration

**Description**: Shows the time spent.<br />
**DisplayName**: Duration<br />
**LogicalName**: msdyn_duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_entryStatus"></a> msdyn_entryStatus

**Description**: Select the entry status.<br />
**DisplayName**: Entry Status<br />
**LogicalName**: msdyn_entrystatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Draft
- **Value**: 192350001 **Label**: Returned
- **Value**: 192350002 **Label**: Approved
- **Value**: 192350003 **Label**: Submitted



### <a name="BKMK_msdyn_externalDescription"></a> msdyn_externalDescription

**Description**: Type the external description of the time entry.<br />
**DisplayName**: External Comments<br />
**LogicalName**: msdyn_externaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_manager"></a> msdyn_manager

**Description**: Select the manager of the time entry user. This field is used for approval.<br />
**DisplayName**: Manager<br />
**LogicalName**: msdyn_manager<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_project"></a> msdyn_project

**Description**: Select the project that the time entry is related to.<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_projectTask"></a> msdyn_projectTask

**Description**: Select the project task that the time entry is related to.<br />
**DisplayName**: Project Task<br />
**LogicalName**: msdyn_projecttask<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_relatedItemId"></a> msdyn_relatedItemId

**Description**: The identifier of the related item.<br />
**DisplayName**: Related item identifier<br />
**LogicalName**: msdyn_relateditemid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_relatedItemType"></a> msdyn_relatedItemType

**Description**: The related item type<br />
**DisplayName**: Related item type<br />
**LogicalName**: msdyn_relateditemtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: None
- **Value**: 192350001 **Label**: Resource Booking
- **Value**: 192350002 **Label**: Resource Assignment
- **Value**: 192350100 **Label**: Exchange Appointments



### <a name="BKMK_msdyn_resourceCategory"></a> msdyn_resourceCategory

**Description**: Select the role that the user has in the project that the time entry is for.<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_resourcecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


### <a name="BKMK_msdyn_ResourceOrganizationalUnitId"></a> msdyn_ResourceOrganizationalUnitId

**Description**: Select the organizational unit at the time the entry was registered of the resource who performed the work.<br />
**DisplayName**: Resourcing Unit<br />
**LogicalName**: msdyn_resourceorganizationalunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_organizationalunit


### <a name="BKMK_msdyn_targetEntryStatus"></a> msdyn_targetEntryStatus

**Description**: <br />
**DisplayName**: Target Entry Status<br />
**LogicalName**: msdyn_targetentrystatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Draft
- **Value**: 192350001 **Label**: Returned
- **Value**: 192350002 **Label**: Approved
- **Value**: 192350003 **Label**: Submitted



### <a name="BKMK_msdyn_timeentryId"></a> msdyn_timeentryId

**Description**: The unique identifier for a time entry.<br />
**DisplayName**: Time Entry<br />
**LogicalName**: msdyn_timeentryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_type"></a> msdyn_type

**Description**: Select the time entry type.<br />
**DisplayName**: Type<br />
**LogicalName**: msdyn_type<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Work
- **Value**: 192350001 **Label**: Absence
- **Value**: 192350002 **Label**: Vacation



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

**Description**: Status of the Time Entry<br />
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

**Description**: Reason for the status of the Time Entry<br />
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
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_managerName](#BKMK_msdyn_managerName)
- [msdyn_managerYomiName](#BKMK_msdyn_managerYomiName)
- [msdyn_projectName](#BKMK_msdyn_projectName)
- [msdyn_projectTaskName](#BKMK_msdyn_projectTaskName)
- [msdyn_resourceCategoryName](#BKMK_msdyn_resourceCategoryName)
- [msdyn_ResourceOrganizationalUnitIdName](#BKMK_msdyn_ResourceOrganizationalUnitIdName)
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


### <a name="BKMK_msdyn_bookableresourceName"></a> msdyn_bookableresourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookableresourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_managerName"></a> msdyn_managerName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_managername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_managerYomiName"></a> msdyn_managerYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_manageryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_projectName"></a> msdyn_projectName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projectname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_projectTaskName"></a> msdyn_projectTaskName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projecttaskname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_resourceCategoryName"></a> msdyn_resourceCategoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcecategoryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceOrganizationalUnitIdName"></a> msdyn_ResourceOrganizationalUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourceorganizationalunitidname<br />
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

- [msdyn_timeentry_SyncErrors](#BKMK_msdyn_timeentry_SyncErrors)
- [msdyn_timeentry_AsyncOperations](#BKMK_msdyn_timeentry_AsyncOperations)
- [msdyn_timeentry_MailboxTrackingFolders](#BKMK_msdyn_timeentry_MailboxTrackingFolders)
- [msdyn_timeentry_UserEntityInstanceDatas](#BKMK_msdyn_timeentry_UserEntityInstanceDatas)
- [msdyn_timeentry_ProcessSession](#BKMK_msdyn_timeentry_ProcessSession)
- [msdyn_timeentry_BulkDeleteFailures](#BKMK_msdyn_timeentry_BulkDeleteFailures)
- [msdyn_timeentry_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses)
- [msdyn_timeentry_Annotations](#BKMK_msdyn_timeentry_Annotations)
- [msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry](#BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry)
- [msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry](#BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry)


### <a name="BKMK_msdyn_timeentry_SyncErrors"></a> msdyn_timeentry_SyncErrors

Same as syncerror entity [msdyn_timeentry_SyncErrors](syncerror.md#BKMK_msdyn_timeentry_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_SyncErrors<br />
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


### <a name="BKMK_msdyn_timeentry_AsyncOperations"></a> msdyn_timeentry_AsyncOperations

Same as asyncoperation entity [msdyn_timeentry_AsyncOperations](asyncoperation.md#BKMK_msdyn_timeentry_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_AsyncOperations<br />
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


### <a name="BKMK_msdyn_timeentry_MailboxTrackingFolders"></a> msdyn_timeentry_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_timeentry_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_timeentry_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_timeentry_UserEntityInstanceDatas"></a> msdyn_timeentry_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_timeentry_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_timeentry_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_timeentry_ProcessSession"></a> msdyn_timeentry_ProcessSession

Same as processsession entity [msdyn_timeentry_ProcessSession](processsession.md#BKMK_msdyn_timeentry_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_ProcessSession<br />
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


### <a name="BKMK_msdyn_timeentry_BulkDeleteFailures"></a> msdyn_timeentry_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_timeentry_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_timeentry_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses"></a> msdyn_timeentry_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_timeentry_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_timeentry_Annotations"></a> msdyn_timeentry_Annotations

Same as annotation entity [msdyn_timeentry_Annotations](annotation.md#BKMK_msdyn_timeentry_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_timeentry_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry"></a> msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry

Same as msdyn_projectapproval entity [msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry](msdyn_projectapproval.md#BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: msdyn_timeentry<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry<br />
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


### <a name="BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry"></a> msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry

Same as msdyn_timeoffcalendar entity [msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry](msdyn_timeoffcalendar.md#BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeoffcalendar<br />
**ReferencingAttribute**: msdyn_timeentry<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_timeentry_createdby](#BKMK_lk_msdyn_timeentry_createdby)
- [lk_msdyn_timeentry_createdonbehalfby](#BKMK_lk_msdyn_timeentry_createdonbehalfby)
- [lk_msdyn_timeentry_modifiedby](#BKMK_lk_msdyn_timeentry_modifiedby)
- [lk_msdyn_timeentry_modifiedonbehalfby](#BKMK_lk_msdyn_timeentry_modifiedonbehalfby)
- [user_msdyn_timeentry](#BKMK_user_msdyn_timeentry)
- [team_msdyn_timeentry](#BKMK_team_msdyn_timeentry)
- [business_unit_msdyn_timeentry](#BKMK_business_unit_msdyn_timeentry)
- [msdyn_bookableresource_msdyn_timeentry_bookableresource](#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory)
- [msdyn_msdyn_project_msdyn_timeentry_project](#BKMK_msdyn_msdyn_project_msdyn_timeentry_project)
- [msdyn_msdyn_projecttask_msdyn_timeentry_projectTask](#BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask)
- [msdyn_organizationalunit_timeentry](#BKMK_msdyn_organizationalunit_timeentry)
- [msdyn_systemuser_msdyn_timeentry_manager](#BKMK_msdyn_systemuser_msdyn_timeentry_manager)


### <a name="BKMK_lk_msdyn_timeentry_createdby"></a> lk_msdyn_timeentry_createdby

See systemuser Entity [lk_msdyn_timeentry_createdby](systemuser.md#BKMK_lk_msdyn_timeentry_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_createdonbehalfby"></a> lk_msdyn_timeentry_createdonbehalfby

See systemuser Entity [lk_msdyn_timeentry_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_timeentry_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_modifiedby"></a> lk_msdyn_timeentry_modifiedby

See systemuser Entity [lk_msdyn_timeentry_modifiedby](systemuser.md#BKMK_lk_msdyn_timeentry_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_modifiedonbehalfby"></a> lk_msdyn_timeentry_modifiedonbehalfby

See systemuser Entity [lk_msdyn_timeentry_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_timeentry_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_timeentry"></a> user_msdyn_timeentry

See systemuser Entity [user_msdyn_timeentry](systemuser.md#BKMK_user_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

See team Entity [team_msdyn_timeentry](team.md#BKMK_team_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_timeentry"></a> business_unit_msdyn_timeentry

See businessunit Entity [business_unit_msdyn_timeentry](businessunit.md#BKMK_business_unit_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource"></a> msdyn_bookableresource_msdyn_timeentry_bookableresource

See bookableresource Entity [msdyn_bookableresource_msdyn_timeentry_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory"></a> msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_timeentry_project"></a> msdyn_msdyn_project_msdyn_timeentry_project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_timeentry_project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_timeentry_project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask"></a> msdyn_msdyn_projecttask_msdyn_timeentry_projectTask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_timeentry_projectTask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_timeentry"></a> msdyn_organizationalunit_timeentry

See msdyn_organizationalunit Entity [msdyn_organizationalunit_timeentry](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_timeentry) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_timeentry_manager"></a> msdyn_systemuser_msdyn_timeentry_manager

See systemuser Entity [msdyn_systemuser_msdyn_timeentry_manager](systemuser.md#BKMK_msdyn_systemuser_msdyn_timeentry_manager) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_timeentry?text=msdyn_timeentry EntityType" />