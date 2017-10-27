---
title: "msdyn_invoicefrequencydetail Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_invoicefrequencydetail entity."
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
# msdyn_invoicefrequencydetail Entity Reference

List of days expressed as dates or day of week for a specific invoice schedule template.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Invoice Frequency Detail<br />
**DisplayCollectionName**: Invoice Frequency Details<br />
**SchemaName**: msdyn_invoicefrequencydetail<br />
**CollectionSchemaName**: msdyn_invoicefrequencydetails<br />
**LogicalName**: msdyn_invoicefrequencydetail<br />
**LogicalCollectionName**: msdyn_invoicefrequencydetails<br />
**EntitySetName**: msdyn_invoicefrequencydetails<br />
**PrimaryIdAttribute**: msdyn_invoicefrequencydetailid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_dayofmonth](#BKMK_msdyn_dayofmonth)
- [msdyn_invoicefrequency](#BKMK_msdyn_invoicefrequency)
- [msdyn_invoicefrequencydetailId](#BKMK_msdyn_invoicefrequencydetailId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_occurrenceofweekday](#BKMK_msdyn_occurrenceofweekday)
- [msdyn_weekday](#BKMK_msdyn_weekday)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_dayofmonth"></a> msdyn_dayofmonth

**Description**: Specify the day(s) of the month on which invoicing should run<br />
**DisplayName**: Day of month<br />
**LogicalName**: msdyn_dayofmonth<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350001 **Label**: 1
- **Value**: 192350002 **Label**: 2
- **Value**: 192350003 **Label**: 3
- **Value**: 192350004 **Label**: 4
- **Value**: 192350005 **Label**: 5
- **Value**: 192350006 **Label**: 6
- **Value**: 192350007 **Label**: 7
- **Value**: 192350008 **Label**: 8
- **Value**: 192350009 **Label**: 9
- **Value**: 192350010 **Label**: 10
- **Value**: 192350011 **Label**: 11
- **Value**: 192350012 **Label**: 12
- **Value**: 192350013 **Label**: 13
- **Value**: 192350014 **Label**: 14
- **Value**: 192350015 **Label**: 15
- **Value**: 192350016 **Label**: 16
- **Value**: 192350017 **Label**: 17
- **Value**: 192350018 **Label**: 18
- **Value**: 192350019 **Label**: 19
- **Value**: 192350020 **Label**: 20
- **Value**: 192350021 **Label**: 21
- **Value**: 192350022 **Label**: 22
- **Value**: 192350023 **Label**: 23
- **Value**: 192350024 **Label**: 24
- **Value**: 192350025 **Label**: 25
- **Value**: 192350026 **Label**: 26
- **Value**: 192350027 **Label**: 27
- **Value**: 192350028 **Label**: 28
- **Value**: 192350029 **Label**: 29
- **Value**: 192350030 **Label**: 30
- **Value**: 192350031 **Label**: 31



### <a name="BKMK_msdyn_invoicefrequency"></a> msdyn_invoicefrequency

**Description**: Select the invoice frequency.<br />
**DisplayName**: Invoice Frequency<br />
**LogicalName**: msdyn_invoicefrequency<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_invoicefrequency


### <a name="BKMK_msdyn_invoicefrequencydetailId"></a> msdyn_invoicefrequencydetailId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Invoice Frequency Detail<br />
**LogicalName**: msdyn_invoicefrequencydetailid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_occurrenceofweekday"></a> msdyn_occurrenceofweekday

**Description**: Specifies which occurrence of a weekday the invoicing job should run if there are multiple occurrences of a weekday in the selected period<br />
**DisplayName**: Occurrence of weekday<br />
**LogicalName**: msdyn_occurrenceofweekday<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: First
- **Value**: 192350001 **Label**: Second
- **Value**: 192350002 **Label**: Third
- **Value**: 192350003 **Label**: Fourth
- **Value**: 192350004 **Label**: Last



### <a name="BKMK_msdyn_weekday"></a> msdyn_weekday

**Description**: Select the weekday of the invoicing job run.<br />
**DisplayName**: Weekday<br />
**LogicalName**: msdyn_weekday<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Sunday
- **Value**: 192350001 **Label**: Monday
- **Value**: 192350002 **Label**: Tuesday
- **Value**: 192350003 **Label**: Wednesday
- **Value**: 192350004 **Label**: Thursday
- **Value**: 192350005 **Label**: Friday
- **Value**: 192350006 **Label**: Saturday



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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Invoice Frequency Detail<br />
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

**Description**: Reason for the status of the Invoice Frequency Detail<br />
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
- [msdyn_invoicefrequencyName](#BKMK_msdyn_invoicefrequencyName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
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


### <a name="BKMK_msdyn_invoicefrequencyName"></a> msdyn_invoicefrequencyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_invoicefrequencyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_invoicefrequencydetail_SyncErrors](#BKMK_msdyn_invoicefrequencydetail_SyncErrors)
- [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord)
- [msdyn_invoicefrequencydetail_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord)
- [msdyn_invoicefrequencydetail_AsyncOperations](#BKMK_msdyn_invoicefrequencydetail_AsyncOperations)
- [msdyn_invoicefrequencydetail_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders)
- [msdyn_invoicefrequencydetail_UserEntityInstanceDatas](#BKMK_msdyn_invoicefrequencydetail_UserEntityInstanceDatas)
- [msdyn_invoicefrequencydetail_ProcessSession](#BKMK_msdyn_invoicefrequencydetail_ProcessSession)
- [msdyn_invoicefrequencydetail_BulkDeleteFailures](#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures)
- [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_invoicefrequencydetail_SyncErrors"></a> msdyn_invoicefrequencydetail_SyncErrors

Same as syncerror entity [msdyn_invoicefrequencydetail_SyncErrors](syncerror.md#BKMK_msdyn_invoicefrequencydetail_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_SyncErrors<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord"></a> msdyn_invoicefrequencydetail_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord"></a> msdyn_invoicefrequencydetail_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_invoicefrequencydetail_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_AsyncOperations"></a> msdyn_invoicefrequencydetail_AsyncOperations

Same as asyncoperation entity [msdyn_invoicefrequencydetail_AsyncOperations](asyncoperation.md#BKMK_msdyn_invoicefrequencydetail_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_AsyncOperations<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders"></a> msdyn_invoicefrequencydetail_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_invoicefrequencydetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_UserEntityInstanceDatas"></a> msdyn_invoicefrequencydetail_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_invoicefrequencydetail_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_invoicefrequencydetail_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_ProcessSession"></a> msdyn_invoicefrequencydetail_ProcessSession

Same as processsession entity [msdyn_invoicefrequencydetail_ProcessSession](processsession.md#BKMK_msdyn_invoicefrequencydetail_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_ProcessSession<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures"></a> msdyn_invoicefrequencydetail_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_invoicefrequencydetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_invoicefrequencydetail_createdby](#BKMK_lk_msdyn_invoicefrequencydetail_createdby)
- [lk_msdyn_invoicefrequencydetail_createdonbehalfby](#BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby)
- [lk_msdyn_invoicefrequencydetail_modifiedby](#BKMK_lk_msdyn_invoicefrequencydetail_modifiedby)
- [lk_msdyn_invoicefrequencydetail_modifiedonbehalfby](#BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby)
- [organization_msdyn_invoicefrequencydetail](#BKMK_organization_msdyn_invoicefrequencydetail)
- [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency)


### <a name="BKMK_lk_msdyn_invoicefrequencydetail_createdby"></a> lk_msdyn_invoicefrequencydetail_createdby

See systemuser Entity [lk_msdyn_invoicefrequencydetail_createdby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby"></a> lk_msdyn_invoicefrequencydetail_createdonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequencydetail_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_modifiedby"></a> lk_msdyn_invoicefrequencydetail_modifiedby

See systemuser Entity [lk_msdyn_invoicefrequencydetail_modifiedby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby"></a> lk_msdyn_invoicefrequencydetail_modifiedonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequencydetail_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_invoicefrequencydetail"></a> organization_msdyn_invoicefrequencydetail

See organization Entity [organization_msdyn_invoicefrequencydetail](organization.md#BKMK_organization_msdyn_invoicefrequencydetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency

See msdyn_invoicefrequency Entity [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](msdyn_invoicefrequency.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_invoicefrequencydetail?text=msdyn_invoicefrequencydetail EntityType" />