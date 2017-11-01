---
title: "msdyn_contractlineinvoiceschedule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_contractlineinvoiceschedule entity."
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
# msdyn_contractlineinvoiceschedule Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

List of dates that shows when invoicing for this customer should be run. This list is used by the invoice creation job.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Project Contract Line Invoice Schedule<br />
**DisplayCollectionName**: Project Contract Line Invoice Schedules<br />
**SchemaName**: msdyn_contractlineinvoiceschedule<br />
**CollectionSchemaName**: msdyn_contractlineinvoiceschedules<br />
**LogicalName**: msdyn_contractlineinvoiceschedule<br />
**LogicalCollectionName**: msdyn_contractlineinvoiceschedules<br />
**EntitySetName**: msdyn_contractlineinvoiceschedules<br />
**PrimaryIdAttribute**: msdyn_contractlineinvoicescheduleid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ContractLine](#BKMK_msdyn_ContractLine)
- [msdyn_contractlineinvoicescheduleId](#BKMK_msdyn_contractlineinvoicescheduleId)
- [msdyn_ContractLineScheduleOfValue](#BKMK_msdyn_ContractLineScheduleOfValue)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_InvoiceRunDate](#BKMK_msdyn_InvoiceRunDate)
- [msdyn_InvoiceRunStatus](#BKMK_msdyn_InvoiceRunStatus)
- [msdyn_name](#BKMK_msdyn_name)
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


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

**Description**: Shows the associated project contract line for this invoice schedule.<br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_contractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_contractlineinvoicescheduleId"></a> msdyn_contractlineinvoicescheduleId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Project Contract Line Invoice Schedule<br />
**LogicalName**: msdyn_contractlineinvoicescheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ContractLineScheduleOfValue"></a> msdyn_ContractLineScheduleOfValue

**Description**: Select the billing milestone for a project contract line.<br />
**DisplayName**: Project Contract Line Milestone<br />
**LogicalName**: msdyn_contractlinescheduleofvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_contractlinescheduleofvalue


### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

**Description**: Select the Invoice associated with Project contract line invoice schedule.<br />
**DisplayName**: Invoice<br />
**LogicalName**: msdyn_invoice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: invoice


### <a name="BKMK_msdyn_InvoiceRunDate"></a> msdyn_InvoiceRunDate

**Description**: Enter the date on which invoice should get created<br />
**DisplayName**: Invoice Run Date<br />
**LogicalName**: msdyn_invoicerundate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_InvoiceRunStatus"></a> msdyn_InvoiceRunStatus

**Description**: Select the milestone status, for example, Not Ready to Invoice, Ready to Invoice, On an invoice, or Invoiced.<br />
**DisplayName**: Milestone status<br />
**LogicalName**: msdyn_invoicerunstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Not Run
- **Value**: 192350001 **Label**: Run Successful
- **Value**: 192350002 **Label**: Run Failed



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


### <a name="BKMK_msdyn_transactioncutoffdate"></a> msdyn_transactioncutoffdate

**Description**: Enter the date before or on which the transaction will be picked for invoicing by the invoice creation job.<br />
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

**Description**: Status of the project contract line invoice schedule<br />
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

**Description**: Reason for the status of the project contract line invoice schedule<br />
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
- [msdyn_ContractLineScheduleOfValueName](#BKMK_msdyn_ContractLineScheduleOfValueName)
- [msdyn_InvoiceName](#BKMK_msdyn_InvoiceName)
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


### <a name="BKMK_msdyn_ContractLineScheduleOfValueName"></a> msdyn_ContractLineScheduleOfValueName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contractlinescheduleofvaluename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_InvoiceName"></a> msdyn_InvoiceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_invoicename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


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

- [msdyn_contractlineinvoiceschedule_SyncErrors](#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors)
- [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord)
- [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord)
- [msdyn_contractlineinvoiceschedule_AsyncOperations](#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations)
- [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders)
- [msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas](#BKMK_msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas)
- [msdyn_contractlineinvoiceschedule_ProcessSession](#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession)
- [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures)
- [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_contractlineinvoiceschedule_SyncErrors"></a> msdyn_contractlineinvoiceschedule_SyncErrors

Same as syncerror entity [msdyn_contractlineinvoiceschedule_SyncErrors](syncerror.md#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_SyncErrors<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations"></a> msdyn_contractlineinvoiceschedule_AsyncOperations

Same as asyncoperation entity [msdyn_contractlineinvoiceschedule_AsyncOperations](asyncoperation.md#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_AsyncOperations<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders"></a> msdyn_contractlineinvoiceschedule_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas"></a> msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_ProcessSession"></a> msdyn_contractlineinvoiceschedule_ProcessSession

Same as processsession entity [msdyn_contractlineinvoiceschedule_ProcessSession](processsession.md#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_ProcessSession<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures"></a> msdyn_contractlineinvoiceschedule_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses"></a> msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_contractlineinvoiceschedule_createdby](#BKMK_lk_msdyn_contractlineinvoiceschedule_createdby)
- [lk_msdyn_contractlineinvoiceschedule_createdonbehalfby](#BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby)
- [lk_msdyn_contractlineinvoiceschedule_modifiedby](#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby)
- [lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby](#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby)
- [organization_msdyn_contractlineinvoiceschedule](#BKMK_organization_msdyn_contractlineinvoiceschedule)
- [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule)
- [msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice](#BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice)


### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_createdby"></a> lk_msdyn_contractlineinvoiceschedule_createdby

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_createdby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby"></a> lk_msdyn_contractlineinvoiceschedule_createdonbehalfby

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby"></a> lk_msdyn_contractlineinvoiceschedule_modifiedby

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_modifiedby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby"></a> lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_contractlineinvoiceschedule"></a> organization_msdyn_contractlineinvoiceschedule

See organization Entity [organization_msdyn_contractlineinvoiceschedule](organization.md#BKMK_organization_msdyn_contractlineinvoiceschedule) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule"></a> msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule) One-To-Many relationship.

### <a name="BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice"></a> msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice

See invoice Entity [msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_contractlineinvoiceschedule?text=msdyn_contractlineinvoiceschedule EntityType" />