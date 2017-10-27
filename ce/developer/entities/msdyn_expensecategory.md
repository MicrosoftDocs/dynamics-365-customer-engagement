---
title: "msdyn_expensecategory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_expensecategory entity."
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
# msdyn_expensecategory Entity Reference

Main container that holds expense category information.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_expensecategories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_expensecategories(*msdyn_expensecategoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_expensecategories(*msdyn_expensecategoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_expensecategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_expensecategories(*msdyn_expensecategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_expensecategories(*msdyn_expensecategoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Expense Category<br />
**DisplayCollectionName**: Expense Categories<br />
**SchemaName**: msdyn_expensecategory<br />
**CollectionSchemaName**: msdyn_expensecategories<br />
**LogicalName**: msdyn_expensecategory<br />
**LogicalCollectionName**: msdyn_expensecategories<br />
**EntitySetName**: msdyn_expensecategories<br />
**PrimaryIdAttribute**: msdyn_expensecategoryid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_expensecategoryId](#BKMK_msdyn_expensecategoryId)
- [msdyn_ExpenseCategoryuId](#BKMK_msdyn_ExpenseCategoryuId)
- [msdyn_ExpenseType](#BKMK_msdyn_ExpenseType)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ReceiptRequired](#BKMK_msdyn_ReceiptRequired)
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


### <a name="BKMK_msdyn_expensecategoryId"></a> msdyn_expensecategoryId

**Description**: Shows the entity instances.<br />
**DisplayName**: Expense Category<br />
**LogicalName**: msdyn_expensecategoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ExpenseCategoryuId"></a> msdyn_ExpenseCategoryuId

**Description**: Select the Transaction Category associated with Expense Category.<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_expensecategoryuid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_ExpenseType"></a> msdyn_ExpenseType

**Description**: Enter the type of expense<br />
**DisplayName**: Expense Type<br />
**LogicalName**: msdyn_expensetype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Hotel
- **Value**: 192350001 **Label**: Car Rental
- **Value**: 192350002 **Label**: Meal
- **Value**: 192350003 **Label**: Airline
- **Value**: 192350004 **Label**: Entertainment
- **Value**: 192350005 **Label**: Gift
- **Value**: 192350006 **Label**: Conference
- **Value**: 192350007 **Label**: Miscellaneous
- **Value**: 192350008 **Label**: Mileage
- **Value**: 192350009 **Label**: Per diem



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


### <a name="BKMK_msdyn_ReceiptRequired"></a> msdyn_ReceiptRequired

**Description**: Shows whether the expense entry requires a receipt.<br />
**DisplayName**: Receipt Required<br />
**LogicalName**: msdyn_receiptrequired<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Optional
- **Value**: 192350001 **Label**: Mandatory



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

**Description**: Status of the Expense Category<br />
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

**Description**: Reason for the status of the Expense Category<br />
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
- [msdyn_ExpenseCategoryuIdName](#BKMK_msdyn_ExpenseCategoryuIdName)
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


### <a name="BKMK_msdyn_ExpenseCategoryuIdName"></a> msdyn_ExpenseCategoryuIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_expensecategoryuidname<br />
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

- [msdyn_expensecategory_SyncErrors](#BKMK_msdyn_expensecategory_SyncErrors)
- [msdyn_expensecategory_DuplicateMatchingRecord](#BKMK_msdyn_expensecategory_DuplicateMatchingRecord)
- [msdyn_expensecategory_DuplicateBaseRecord](#BKMK_msdyn_expensecategory_DuplicateBaseRecord)
- [msdyn_expensecategory_AsyncOperations](#BKMK_msdyn_expensecategory_AsyncOperations)
- [msdyn_expensecategory_MailboxTrackingFolders](#BKMK_msdyn_expensecategory_MailboxTrackingFolders)
- [msdyn_expensecategory_UserEntityInstanceDatas](#BKMK_msdyn_expensecategory_UserEntityInstanceDatas)
- [msdyn_expensecategory_ProcessSession](#BKMK_msdyn_expensecategory_ProcessSession)
- [msdyn_expensecategory_BulkDeleteFailures](#BKMK_msdyn_expensecategory_BulkDeleteFailures)
- [msdyn_expensecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses)
- [msdyn_expensecategory_Annotations](#BKMK_msdyn_expensecategory_Annotations)
- [msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory](#BKMK_msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory)
- [msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory](#BKMK_msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory)


### <a name="BKMK_msdyn_expensecategory_SyncErrors"></a> msdyn_expensecategory_SyncErrors

Same as syncerror entity [msdyn_expensecategory_SyncErrors](syncerror.md#BKMK_msdyn_expensecategory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_SyncErrors<br />
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


### <a name="BKMK_msdyn_expensecategory_DuplicateMatchingRecord"></a> msdyn_expensecategory_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_expensecategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_expensecategory_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_expensecategory_DuplicateBaseRecord"></a> msdyn_expensecategory_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_expensecategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_expensecategory_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_expensecategory_AsyncOperations"></a> msdyn_expensecategory_AsyncOperations

Same as asyncoperation entity [msdyn_expensecategory_AsyncOperations](asyncoperation.md#BKMK_msdyn_expensecategory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_AsyncOperations<br />
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


### <a name="BKMK_msdyn_expensecategory_MailboxTrackingFolders"></a> msdyn_expensecategory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_expensecategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_expensecategory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_expensecategory_UserEntityInstanceDatas"></a> msdyn_expensecategory_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_expensecategory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_expensecategory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_expensecategory_ProcessSession"></a> msdyn_expensecategory_ProcessSession

Same as processsession entity [msdyn_expensecategory_ProcessSession](processsession.md#BKMK_msdyn_expensecategory_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_ProcessSession<br />
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


### <a name="BKMK_msdyn_expensecategory_BulkDeleteFailures"></a> msdyn_expensecategory_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_expensecategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_expensecategory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses"></a> msdyn_expensecategory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_expensecategory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_expensecategory_Annotations"></a> msdyn_expensecategory_Annotations

Same as annotation entity [msdyn_expensecategory_Annotations](annotation.md#BKMK_msdyn_expensecategory_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_expensecategory_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory"></a> msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory

Same as msdyn_expense entity [msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory](msdyn_expense.md#BKMK_msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_expense<br />
**ReferencingAttribute**: msdyn_expensecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory<br />
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


### <a name="BKMK_msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory"></a> msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory

Same as msdyn_projectapproval entity [msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory](msdyn_projectapproval.md#BKMK_msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: msdyn_expensecategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory<br />
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

- [lk_msdyn_expensecategory_createdby](#BKMK_lk_msdyn_expensecategory_createdby)
- [lk_msdyn_expensecategory_createdonbehalfby](#BKMK_lk_msdyn_expensecategory_createdonbehalfby)
- [lk_msdyn_expensecategory_modifiedby](#BKMK_lk_msdyn_expensecategory_modifiedby)
- [lk_msdyn_expensecategory_modifiedonbehalfby](#BKMK_lk_msdyn_expensecategory_modifiedonbehalfby)
- [organization_msdyn_expensecategory](#BKMK_organization_msdyn_expensecategory)
- [msdyn_msdyn_transactioncategory_msdyn_expensecatego](#BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego)


### <a name="BKMK_lk_msdyn_expensecategory_createdby"></a> lk_msdyn_expensecategory_createdby

See systemuser Entity [lk_msdyn_expensecategory_createdby](systemuser.md#BKMK_lk_msdyn_expensecategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_expensecategory_createdonbehalfby"></a> lk_msdyn_expensecategory_createdonbehalfby

See systemuser Entity [lk_msdyn_expensecategory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_expensecategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_expensecategory_modifiedby"></a> lk_msdyn_expensecategory_modifiedby

See systemuser Entity [lk_msdyn_expensecategory_modifiedby](systemuser.md#BKMK_lk_msdyn_expensecategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_expensecategory_modifiedonbehalfby"></a> lk_msdyn_expensecategory_modifiedonbehalfby

See systemuser Entity [lk_msdyn_expensecategory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_expensecategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_expensecategory"></a> organization_msdyn_expensecategory

See organization Entity [organization_msdyn_expensecategory](organization.md#BKMK_organization_msdyn_expensecategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego"></a> msdyn_msdyn_transactioncategory_msdyn_expensecatego

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_expensecatego](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_expensecategory?text=msdyn_expensecategory EntityType" />