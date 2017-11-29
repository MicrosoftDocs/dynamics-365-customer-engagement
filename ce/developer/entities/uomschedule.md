---
title: "UoMSchedule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the UoMSchedule entity."
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
# UoMSchedule Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Grouping of units.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/uomschedules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/uomschedules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Unit Group<br />
**DisplayCollectionName**: Unit Groups<br />
**SchemaName**: UoMSchedule<br />
**CollectionSchemaName**: UoMSchedules<br />
**LogicalName**: uomschedule<br />
**LogicalCollectionName**: uomschedules<br />
**EntitySetName**: uomschedules<br />
**PrimaryIdAttribute**: uomscheduleid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseUoMName](#BKMK_BaseUoMName)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UoMScheduleId](#BKMK_UoMScheduleId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseUoMName"></a> BaseUoMName

**Description**: Name of the base unit.<br />
**DisplayName**: Base Unit name<br />
**LogicalName**: baseuomname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Description"></a> Description

**Description**: Description of the unit group.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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


### <a name="BKMK_Name"></a> Name

**Description**: Name of the unit group.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the Unit Group.<br />
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



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the Unit Group.<br />
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


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

**Description**: Unique identifier for the unit group.<br />
**DisplayName**: Unit Group<br />
**LogicalName**: uomscheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
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

**Description**: Unique identifier of the user who created the unit group.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

**Description**: Shows the external party who created the record.<br />
**DisplayName**: Created By (External Party)<br />
**LogicalName**: createdbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the unit group was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the uomschedule.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the unit group.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

**Description**: Shows the external party who modified the record.<br />
**DisplayName**: Modified By (External Party)<br />
**LogicalName**: modifiedbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the unit group was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the uomschedule.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: SystemRequired<br />
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

- [UoMSchedule_SyncErrors](#BKMK_UoMSchedule_SyncErrors)
- [UoMSchedule_AsyncOperations](#BKMK_UoMSchedule_AsyncOperations)
- [uomschedule_MailboxTrackingFolders](#BKMK_uomschedule_MailboxTrackingFolders)
- [userentityinstancedata_uomschedule](#BKMK_userentityinstancedata_uomschedule)
- [UoMSchedule_BulkDeleteFailures](#BKMK_UoMSchedule_BulkDeleteFailures)
- [uomschedule_PrincipalObjectAttributeAccesses](#BKMK_uomschedule_PrincipalObjectAttributeAccesses)
- [unit_of_measurement_schedule_products](#BKMK_unit_of_measurement_schedule_products)
- [unit_of_measure_schedule_conversions](#BKMK_unit_of_measure_schedule_conversions)
- [unit_of_measure_schedule_product_price_level](#BKMK_unit_of_measure_schedule_product_price_level)
- [contract_detail_unit_of_measure_schedule](#BKMK_contract_detail_unit_of_measure_schedule)
- [msdyn_uomschedule_msdyn_actual_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule)
- [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule)
- [msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_journalline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule)
- [msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule)
- [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup)
- [msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule)
- [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup)


### <a name="BKMK_UoMSchedule_SyncErrors"></a> UoMSchedule_SyncErrors

Same as syncerror entity [UoMSchedule_SyncErrors](syncerror.md#BKMK_UoMSchedule_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: UoMSchedule_SyncErrors<br />
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


### <a name="BKMK_UoMSchedule_AsyncOperations"></a> UoMSchedule_AsyncOperations

Same as asyncoperation entity [UoMSchedule_AsyncOperations](asyncoperation.md#BKMK_UoMSchedule_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: UoMSchedule_AsyncOperations<br />
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


### <a name="BKMK_uomschedule_MailboxTrackingFolders"></a> uomschedule_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [uomschedule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_uomschedule_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: uomschedule_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_uomschedule"></a> userentityinstancedata_uomschedule

Same as userentityinstancedata entity [userentityinstancedata_uomschedule](userentityinstancedata.md#BKMK_userentityinstancedata_uomschedule) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_uomschedule<br />
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


### <a name="BKMK_UoMSchedule_BulkDeleteFailures"></a> UoMSchedule_BulkDeleteFailures

Same as bulkdeletefailure entity [UoMSchedule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_UoMSchedule_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: UoMSchedule_BulkDeleteFailures<br />
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


### <a name="BKMK_uomschedule_PrincipalObjectAttributeAccesses"></a> uomschedule_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [uomschedule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_uomschedule_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: uomschedule_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_unit_of_measurement_schedule_products"></a> unit_of_measurement_schedule_products

Same as product entity [unit_of_measurement_schedule_products](product.md#BKMK_unit_of_measurement_schedule_products) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: defaultuomscheduleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_schedule_products<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measure_schedule_conversions"></a> unit_of_measure_schedule_conversions

Same as uom entity [unit_of_measure_schedule_conversions](uom.md#BKMK_unit_of_measure_schedule_conversions) Many-To-One relationship.

**ReferencingEntity**: uom<br />
**ReferencingAttribute**: uomscheduleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measure_schedule_conversions<br />
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


### <a name="BKMK_unit_of_measure_schedule_product_price_level"></a> unit_of_measure_schedule_product_price_level

Same as productpricelevel entity [unit_of_measure_schedule_product_price_level](productpricelevel.md#BKMK_unit_of_measure_schedule_product_price_level) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: uomscheduleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measure_schedule_product_price_level<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_contract_detail_unit_of_measure_schedule"></a> contract_detail_unit_of_measure_schedule

Same as contractdetail entity [contract_detail_unit_of_measure_schedule](contractdetail.md#BKMK_contract_detail_unit_of_measure_schedule) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: uomscheduleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contract_detail_unit_of_measure_schedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule"></a> msdyn_uomschedule_msdyn_actual_UnitSchedule

Same as msdyn_actual entity [msdyn_uomschedule_msdyn_actual_UnitSchedule](msdyn_actual.md#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_actual_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule"></a> msdyn_uomschedule_msdyn_estimateline_UnitSchedule

Same as msdyn_estimateline entity [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](msdyn_estimateline.md#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_estimateline_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule

Same as msdyn_invoicelinetransaction entity [msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule](msdyn_invoicelinetransaction.md#BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule"></a> msdyn_uomschedule_msdyn_journalline_UnitSchedule

Same as msdyn_journalline entity [msdyn_uomschedule_msdyn_journalline_UnitSchedule](msdyn_journalline.md#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_journalline_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule

Same as msdyn_opportunitylinetransaction entity [msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule](msdyn_opportunitylinetransaction.md#BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule

Same as msdyn_orderlinetransaction entity [msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule](msdyn_orderlinetransaction.md#BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule

Same as msdyn_quotelinetransaction entity [msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule](msdyn_quotelinetransaction.md#BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule

Same as msdyn_resourcecategorypricelevel entity [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule<br />
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


### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup"></a> msdyn_uomschedule_msdyn_transactioncategory_UnitGroup

Same as msdyn_transactioncategory entity [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](msdyn_transactioncategory.md#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategory<br />
**ReferencingAttribute**: msdyn_unitgroup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_transactioncategory_UnitGroup<br />
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


### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule

Same as msdyn_transactioncategorypricelevel entity [msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategorypricelevel<br />
**ReferencingAttribute**: msdyn_unitschedule<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule<br />
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


### <a name="BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup"></a> msdyn_uomschedule_msdyn_transactiontype_UnitGroup

Same as msdyn_transactiontype entity [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](msdyn_transactiontype.md#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactiontype<br />
**ReferencingAttribute**: msdyn_unitgroup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uomschedule_msdyn_transactiontype_UnitGroup<br />
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

- [lk_uomschedulebase_createdby](#BKMK_lk_uomschedulebase_createdby)
- [lk_uomschedule_createdonbehalfby](#BKMK_lk_uomschedule_createdonbehalfby)
- [lk_uomschedulebase_modifiedby](#BKMK_lk_uomschedulebase_modifiedby)
- [lk_uomschedule_modifiedonbehalfby](#BKMK_lk_uomschedule_modifiedonbehalfby)
- [organization_uof_schedules](#BKMK_organization_uof_schedules)
- [lk_externalparty_uomschedule_createdby](#BKMK_lk_externalparty_uomschedule_createdby)
- [lk_externalparty_uomschedule_modifiedby](#BKMK_lk_externalparty_uomschedule_modifiedby)


### <a name="BKMK_lk_uomschedulebase_createdby"></a> lk_uomschedulebase_createdby

See systemuser Entity [lk_uomschedulebase_createdby](systemuser.md#BKMK_lk_uomschedulebase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedule_createdonbehalfby"></a> lk_uomschedule_createdonbehalfby

See systemuser Entity [lk_uomschedule_createdonbehalfby](systemuser.md#BKMK_lk_uomschedule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedulebase_modifiedby"></a> lk_uomschedulebase_modifiedby

See systemuser Entity [lk_uomschedulebase_modifiedby](systemuser.md#BKMK_lk_uomschedulebase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedule_modifiedonbehalfby"></a> lk_uomschedule_modifiedonbehalfby

See systemuser Entity [lk_uomschedule_modifiedonbehalfby](systemuser.md#BKMK_lk_uomschedule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_uof_schedules"></a> organization_uof_schedules

See organization Entity [organization_uof_schedules](organization.md#BKMK_organization_uof_schedules) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_uomschedule_createdby"></a> lk_externalparty_uomschedule_createdby

See externalparty Entity [lk_externalparty_uomschedule_createdby](externalparty.md#BKMK_lk_externalparty_uomschedule_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_uomschedule_modifiedby"></a> lk_externalparty_uomschedule_modifiedby

See externalparty Entity [lk_externalparty_uomschedule_modifiedby](externalparty.md#BKMK_lk_externalparty_uomschedule_modifiedby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.uomschedule?text=uomschedule EntityType" />