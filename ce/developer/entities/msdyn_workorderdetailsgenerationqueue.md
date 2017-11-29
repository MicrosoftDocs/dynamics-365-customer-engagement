---
title: "msdyn_workorderdetailsgenerationqueue Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderdetailsgenerationqueue entity."
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
# msdyn_workorderdetailsgenerationqueue Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Pool for WO Generation

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Work Order Details Generation Queue (Deprecated)<br />
**DisplayCollectionName**: Work Order Details Generation Queue (Deprecated)<br />
**SchemaName**: msdyn_workorderdetailsgenerationqueue<br />
**CollectionSchemaName**: msdyn_workorderdetailsgenerationqueues<br />
**LogicalName**: msdyn_workorderdetailsgenerationqueue<br />
**LogicalCollectionName**: msdyn_workorderdetailsgenerationqueues<br />
**EntitySetName**: msdyn_workorderdetailsgenerationqueues<br />
**PrimaryIdAttribute**: msdyn_workorderdetailsgenerationqueueid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementBookingDate](#BKMK_msdyn_AgreementBookingDate)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_ExceptionMessage](#BKMK_msdyn_ExceptionMessage)
- [msdyn_ExceptionTrace](#BKMK_msdyn_ExceptionTrace)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Processed](#BKMK_msdyn_Processed)
- [msdyn_SchDateOwnerId](#BKMK_msdyn_SchDateOwnerId)
- [msdyn_WorkOrderDetails](#BKMK_msdyn_WorkOrderDetails)
- [msdyn_workorderdetailsgenerationqueueId](#BKMK_msdyn_workorderdetailsgenerationqueueId)
- [msdyn_WorkorderId](#BKMK_msdyn_WorkorderId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_AgreementBookingDate"></a> msdyn_AgreementBookingDate

**Description**: Unique identifier for Agreement Booking Date associated with Work Order Details Generation Queue.<br />
**DisplayName**: Agreement Booking Date<br />
**LogicalName**: msdyn_agreementbookingdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingdate


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

**Description**: <br />
**DisplayName**: Booking<br />
**LogicalName**: msdyn_booking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ExceptionMessage"></a> msdyn_ExceptionMessage

**Description**: <br />
**DisplayName**: Exception Message<br />
**LogicalName**: msdyn_exceptionmessage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_msdyn_ExceptionTrace"></a> msdyn_ExceptionTrace

**Description**: <br />
**DisplayName**: Exception Trace<br />
**LogicalName**: msdyn_exceptiontrace<br />
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


### <a name="BKMK_msdyn_Processed"></a> msdyn_Processed

**Description**: <br />
**DisplayName**: Processed<br />
**LogicalName**: msdyn_processed<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_SchDateOwnerId"></a> msdyn_SchDateOwnerId

**Description**: <br />
**DisplayName**: SchDateOwnerId<br />
**LogicalName**: msdyn_schdateownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderDetails"></a> msdyn_WorkOrderDetails

**Description**: <br />
**DisplayName**: Work Order Details<br />
**LogicalName**: msdyn_workorderdetails<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_workorderdetailsgenerationqueueId"></a> msdyn_workorderdetailsgenerationqueueId

**Description**: Shows the entity instances.<br />
**DisplayName**: Work Order Details Generation Queue<br />
**LogicalName**: msdyn_workorderdetailsgenerationqueueid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_WorkorderId"></a> msdyn_WorkorderId

**Description**: <br />
**DisplayName**: Work Order ID<br />
**LogicalName**: msdyn_workorderid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Work Order Details Generation Queue<br />
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

**Description**: Reason for the status of the Work Order Details Generation Queue<br />
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
- [msdyn_AgreementBookingDateName](#BKMK_msdyn_AgreementBookingDateName)
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


### <a name="BKMK_msdyn_AgreementBookingDateName"></a> msdyn_AgreementBookingDateName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementbookingdatename<br />
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

- [msdyn_workorderdetailsgenerationqueue_SyncErrors](#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors)
- [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord)
- [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord)
- [msdyn_workorderdetailsgenerationqueue_AsyncOperations](#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations)
- [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders)
- [msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas](#BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas)
- [msdyn_workorderdetailsgenerationqueue_ProcessSession](#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession)
- [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures)
- [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors"></a> msdyn_workorderdetailsgenerationqueue_SyncErrors

Same as syncerror entity [msdyn_workorderdetailsgenerationqueue_SyncErrors](syncerror.md#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_SyncErrors<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations"></a> msdyn_workorderdetailsgenerationqueue_AsyncOperations

Same as asyncoperation entity [msdyn_workorderdetailsgenerationqueue_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_AsyncOperations<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders"></a> msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas"></a> msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession"></a> msdyn_workorderdetailsgenerationqueue_ProcessSession

Same as processsession entity [msdyn_workorderdetailsgenerationqueue_ProcessSession](processsession.md#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_ProcessSession<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures"></a> msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses"></a> msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_workorderdetailsgenerationqueue_createdby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby)
- [lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby)
- [lk_msdyn_workorderdetailsgenerationqueue_modifiedby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby)
- [lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby)
- [organization_msdyn_workorderdetailsgenerationqueue](#BKMK_organization_msdyn_workorderdetailsgenerationqueue)
- [msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate](#BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate)


### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby"></a> lk_msdyn_workorderdetailsgenerationqueue_createdby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_createdby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby"></a> lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby"></a> lk_msdyn_workorderdetailsgenerationqueue_modifiedby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby"></a> lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_workorderdetailsgenerationqueue"></a> organization_msdyn_workorderdetailsgenerationqueue

See organization Entity [organization_msdyn_workorderdetailsgenerationqueue](organization.md#BKMK_organization_msdyn_workorderdetailsgenerationqueue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate"></a> msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate

See msdyn_agreementbookingdate Entity [msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderdetailsgenerationqueue?text=msdyn_workorderdetailsgenerationqueue EntityType" />