---
title: "msdyn_invoicefrequency Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_invoicefrequency entity."
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
# msdyn_invoicefrequency Entity Reference

Setup entity for invoice schedules.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Invoice Frequency<br />
**DisplayCollectionName**: Invoice Frequencies<br />
**SchemaName**: msdyn_invoicefrequency<br />
**CollectionSchemaName**: msdyn_invoicefrequencies<br />
**LogicalName**: msdyn_invoicefrequency<br />
**LogicalCollectionName**: msdyn_invoicefrequencies<br />
**EntitySetName**: msdyn_invoicefrequencies<br />
**PrimaryIdAttribute**: msdyn_invoicefrequencyid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_daysofrun](#BKMK_msdyn_daysofrun)
- [msdyn_invoicefrequencyId](#BKMK_msdyn_invoicefrequencyId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_period](#BKMK_msdyn_period)
- [msdyn_runspermonth](#BKMK_msdyn_runspermonth)
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


### <a name="BKMK_msdyn_daysofrun"></a> msdyn_daysofrun

**Description**: Describes how the run days per period interval are setup. As weekdays (Monday, Tuesday...) or day of period (1st, 2nd…) <br />
**DisplayName**: Setup of runs<br />
**LogicalName**: msdyn_daysofrun<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Day of period
- **Value**: 192350001 **Label**: Weekday of period



### <a name="BKMK_msdyn_invoicefrequencyId"></a> msdyn_invoicefrequencyId

**Description**: Shows the entity instances.<br />
**DisplayName**: Invoice Frequency<br />
**LogicalName**: msdyn_invoicefrequencyid<br />
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
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_period"></a> msdyn_period

**Description**: Select the period used for the setup of invoice frequency: supported values are Monthly, Weekly or Bi Weekly.<br />
**DisplayName**: Period<br />
**LogicalName**: msdyn_period<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Weekly
- **Value**: 192350001 **Label**: Monthly
- **Value**: 192350002 **Label**: Biweekly



### <a name="BKMK_msdyn_runspermonth"></a> msdyn_runspermonth

**Description**: Select the number of times invoicing should run in a period.<br />
**DisplayName**: Runs per period<br />
**LogicalName**: msdyn_runspermonth<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: 1
- **Value**: 2 **Label**: 2
- **Value**: 3 **Label**: 3
- **Value**: 4 **Label**: 4



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

**Description**: Status of the Invoice Frequency<br />
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

**Description**: Reason for the status of the Invoice Frequency<br />
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

- [msdyn_invoicefrequency_SyncErrors](#BKMK_msdyn_invoicefrequency_SyncErrors)
- [msdyn_invoicefrequency_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord)
- [msdyn_invoicefrequency_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord)
- [msdyn_invoicefrequency_AsyncOperations](#BKMK_msdyn_invoicefrequency_AsyncOperations)
- [msdyn_invoicefrequency_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders)
- [msdyn_invoicefrequency_UserEntityInstanceDatas](#BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas)
- [msdyn_invoicefrequency_ProcessSession](#BKMK_msdyn_invoicefrequency_ProcessSession)
- [msdyn_invoicefrequency_BulkDeleteFailures](#BKMK_msdyn_invoicefrequency_BulkDeleteFailures)
- [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency)


### <a name="BKMK_msdyn_invoicefrequency_SyncErrors"></a> msdyn_invoicefrequency_SyncErrors

Same as syncerror entity [msdyn_invoicefrequency_SyncErrors](syncerror.md#BKMK_msdyn_invoicefrequency_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_SyncErrors<br />
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


### <a name="BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord"></a> msdyn_invoicefrequency_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_invoicefrequency_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_invoicefrequency_DuplicateBaseRecord"></a> msdyn_invoicefrequency_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_invoicefrequency_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_invoicefrequency_AsyncOperations"></a> msdyn_invoicefrequency_AsyncOperations

Same as asyncoperation entity [msdyn_invoicefrequency_AsyncOperations](asyncoperation.md#BKMK_msdyn_invoicefrequency_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_AsyncOperations<br />
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


### <a name="BKMK_msdyn_invoicefrequency_MailboxTrackingFolders"></a> msdyn_invoicefrequency_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_invoicefrequency_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas"></a> msdyn_invoicefrequency_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_invoicefrequency_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_invoicefrequency_ProcessSession"></a> msdyn_invoicefrequency_ProcessSession

Same as processsession entity [msdyn_invoicefrequency_ProcessSession](processsession.md#BKMK_msdyn_invoicefrequency_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_ProcessSession<br />
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


### <a name="BKMK_msdyn_invoicefrequency_BulkDeleteFailures"></a> msdyn_invoicefrequency_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_invoicefrequency_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_invoicefrequency_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequency_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_invoicefrequency_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency

Same as msdyn_invoicefrequencydetail entity [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](msdyn_invoicefrequencydetail.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicefrequencydetail<br />
**ReferencingAttribute**: msdyn_invoicefrequency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency

Same as msdyn_projectparameter entity [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](msdyn_projectparameter.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectparameter<br />
**ReferencingAttribute**: msdyn_invoicefrequency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency

Same as quotedetail entity [msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency](quotedetail.md#BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: msdyn_invoicefrequency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency

Same as salesorderdetail entity [msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency](salesorderdetail.md#BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: msdyn_invoicefrequency<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_invoicefrequency_createdby](#BKMK_lk_msdyn_invoicefrequency_createdby)
- [lk_msdyn_invoicefrequency_createdonbehalfby](#BKMK_lk_msdyn_invoicefrequency_createdonbehalfby)
- [lk_msdyn_invoicefrequency_modifiedby](#BKMK_lk_msdyn_invoicefrequency_modifiedby)
- [lk_msdyn_invoicefrequency_modifiedonbehalfby](#BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby)
- [organization_msdyn_invoicefrequency](#BKMK_organization_msdyn_invoicefrequency)


### <a name="BKMK_lk_msdyn_invoicefrequency_createdby"></a> lk_msdyn_invoicefrequency_createdby

See systemuser Entity [lk_msdyn_invoicefrequency_createdby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_createdonbehalfby"></a> lk_msdyn_invoicefrequency_createdonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequency_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_modifiedby"></a> lk_msdyn_invoicefrequency_modifiedby

See systemuser Entity [lk_msdyn_invoicefrequency_modifiedby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby"></a> lk_msdyn_invoicefrequency_modifiedonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequency_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_invoicefrequency"></a> organization_msdyn_invoicefrequency

See organization Entity [organization_msdyn_invoicefrequency](organization.md#BKMK_organization_msdyn_invoicefrequency) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_invoicefrequency?text=msdyn_invoicefrequency EntityType" />