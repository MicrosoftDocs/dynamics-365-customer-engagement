---
title: "msdyn_quotelineinvoiceschedule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelineinvoiceschedule entity."
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
# msdyn_quotelineinvoiceschedule Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

List of dates on which invoicing for this customer should be run. This list is used by an invoice creation job.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules(*msdyn_quotelineinvoicescheduleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules(*msdyn_quotelineinvoicescheduleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules(*msdyn_quotelineinvoicescheduleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelineinvoiceschedules(*msdyn_quotelineinvoicescheduleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Quote Line Invoice Schedule<br />
**DisplayCollectionName**: Quote Line Invoice Schedule<br />
**SchemaName**: msdyn_quotelineinvoiceschedule<br />
**CollectionSchemaName**: msdyn_quotelineinvoiceschedules<br />
**LogicalName**: msdyn_quotelineinvoiceschedule<br />
**LogicalCollectionName**: msdyn_quotelineinvoiceschedules<br />
**EntitySetName**: msdyn_quotelineinvoiceschedules<br />
**PrimaryIdAttribute**: msdyn_quotelineinvoicescheduleid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_InvoiceRunDate](#BKMK_msdyn_InvoiceRunDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_QuoteLine](#BKMK_msdyn_QuoteLine)
- [msdyn_quotelineinvoicescheduleId](#BKMK_msdyn_quotelineinvoicescheduleId)
- [msdyn_QuoteLineScheduleOfValue](#BKMK_msdyn_QuoteLineScheduleOfValue)
- [msdyn_transactioncutoffdate](#BKMK_msdyn_transactioncutoffdate)
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


### <a name="BKMK_msdyn_InvoiceRunDate"></a> msdyn_InvoiceRunDate

**Description**: Enter the date for the invoice creation job to use as invoice date on the invoice generated<br />
**DisplayName**: Invoice Run Date<br />
**LogicalName**: msdyn_invoicerundate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_msdyn_QuoteLine"></a> msdyn_QuoteLine

**Description**: Type the reference to the quote line that this invoice schedule is for.<br />
**DisplayName**: Quote Line<br />
**LogicalName**: msdyn_quoteline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_quotelineinvoicescheduleId"></a> msdyn_quotelineinvoicescheduleId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Line Invoice Schedule<br />
**LogicalName**: msdyn_quotelineinvoicescheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_QuoteLineScheduleOfValue"></a> msdyn_QuoteLineScheduleOfValue

**Description**: Billing milestone for the quote line<br />
**DisplayName**: Quote Line Schedule Of Value<br />
**LogicalName**: msdyn_quotelinescheduleofvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotelinescheduleofvalue


### <a name="BKMK_msdyn_transactioncutoffdate"></a> msdyn_transactioncutoffdate

**Description**: Enter the date used by the invoice creation job to filter transactions that happened on or before this date for invoice creation<br />
**DisplayName**: Transaction Cut Off Date<br />
**LogicalName**: msdyn_transactioncutoffdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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

**Description**: Status of the Quote Line Invoice Schedule<br />
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

**Description**: Reason for the status of the Quote Line Invoice Schedule<br />
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
- [msdyn_QuoteLineScheduleOfValueName](#BKMK_msdyn_QuoteLineScheduleOfValueName)
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


### <a name="BKMK_msdyn_QuoteLineScheduleOfValueName"></a> msdyn_QuoteLineScheduleOfValueName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotelinescheduleofvaluename<br />
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

- [msdyn_quotelineinvoiceschedule_SyncErrors](#BKMK_msdyn_quotelineinvoiceschedule_SyncErrors)
- [msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord](#BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord)
- [msdyn_quotelineinvoiceschedule_DuplicateBaseRecord](#BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord)
- [msdyn_quotelineinvoiceschedule_AsyncOperations](#BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations)
- [msdyn_quotelineinvoiceschedule_MailboxTrackingFolders](#BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders)
- [msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas](#BKMK_msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas)
- [msdyn_quotelineinvoiceschedule_ProcessSession](#BKMK_msdyn_quotelineinvoiceschedule_ProcessSession)
- [msdyn_quotelineinvoiceschedule_BulkDeleteFailures](#BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures)
- [msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_quotelineinvoiceschedule_SyncErrors"></a> msdyn_quotelineinvoiceschedule_SyncErrors

Same as syncerror entity [msdyn_quotelineinvoiceschedule_SyncErrors](syncerror.md#BKMK_msdyn_quotelineinvoiceschedule_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord"></a> msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord"></a> msdyn_quotelineinvoiceschedule_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotelineinvoiceschedule_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations"></a> msdyn_quotelineinvoiceschedule_AsyncOperations

Same as asyncoperation entity [msdyn_quotelineinvoiceschedule_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders"></a> msdyn_quotelineinvoiceschedule_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotelineinvoiceschedule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas"></a> msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_ProcessSession"></a> msdyn_quotelineinvoiceschedule_ProcessSession

Same as processsession entity [msdyn_quotelineinvoiceschedule_ProcessSession](processsession.md#BKMK_msdyn_quotelineinvoiceschedule_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures"></a> msdyn_quotelineinvoiceschedule_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotelineinvoiceschedule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_quotelineinvoiceschedule_createdby](#BKMK_lk_msdyn_quotelineinvoiceschedule_createdby)
- [lk_msdyn_quotelineinvoiceschedule_createdonbehalfby](#BKMK_lk_msdyn_quotelineinvoiceschedule_createdonbehalfby)
- [lk_msdyn_quotelineinvoiceschedule_modifiedby](#BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedby)
- [lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby](#BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby)
- [organization_msdyn_quotelineinvoiceschedule](#BKMK_organization_msdyn_quotelineinvoiceschedule)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue)


### <a name="BKMK_lk_msdyn_quotelineinvoiceschedule_createdby"></a> lk_msdyn_quotelineinvoiceschedule_createdby

See systemuser Entity [lk_msdyn_quotelineinvoiceschedule_createdby](systemuser.md#BKMK_lk_msdyn_quotelineinvoiceschedule_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineinvoiceschedule_createdonbehalfby"></a> lk_msdyn_quotelineinvoiceschedule_createdonbehalfby

See systemuser Entity [lk_msdyn_quotelineinvoiceschedule_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineinvoiceschedule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedby"></a> lk_msdyn_quotelineinvoiceschedule_modifiedby

See systemuser Entity [lk_msdyn_quotelineinvoiceschedule_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby"></a> lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelineinvoiceschedule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_quotelineinvoiceschedule"></a> organization_msdyn_quotelineinvoiceschedule

See organization Entity [organization_msdyn_quotelineinvoiceschedule](organization.md#BKMK_organization_msdyn_quotelineinvoiceschedule) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue

See msdyn_quotelinescheduleofvalue Entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelineinvoiceschedule?text=msdyn_quotelineinvoiceschedule EntityType" />