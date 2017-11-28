---
title: "BulkOperationLog Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BulkOperationLog entity."
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
# BulkOperationLog Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Log used to track bulk operation execution, successes, and failures.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/bulkoperationlogs<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bulkoperationlogs(*bulkoperationlogid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bulkoperationlogs<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: Bulk Operation Log<br />
**DisplayCollectionName**: Bulk Operation Logs<br />
**SchemaName**: BulkOperationLog<br />
**CollectionSchemaName**: BulkOperationLogs<br />
**LogicalName**: bulkoperationlog<br />
**LogicalCollectionName**: bulkoperationlogs<br />
**EntitySetName**: bulkoperationlogs<br />
**PrimaryIdAttribute**: bulkoperationlogid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdditionalInfo](#BKMK_AdditionalInfo)
- [BulkOperationId](#BKMK_BulkOperationId)
- [BulkOperationIdType](#BKMK_BulkOperationIdType)
- [BulkOperationLogId](#BKMK_BulkOperationLogId)
- [CreatedObjectId](#BKMK_CreatedObjectId)
- [CreatedObjectIdTypeCode](#BKMK_CreatedObjectIdTypeCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdTypeCode](#BKMK_RegardingObjectIdTypeCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AdditionalInfo"></a> AdditionalInfo

**Description**: Shows the data value at which an error occurred during the quick campaign.<br />
**DisplayName**: Failed on Line<br />
**LogicalName**: additionalinfo<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_BulkOperationId"></a> BulkOperationId

**Description**: Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.<br />
**DisplayName**: Bulk Operation Number<br />
**LogicalName**: bulkoperationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: bulkoperation


### <a name="BKMK_BulkOperationIdType"></a> BulkOperationIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bulkoperationidtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_BulkOperationLogId"></a> BulkOperationLogId

**Description**: Unique identifier of the bulk operation log.<br />
**DisplayName**: Bulk Operation Log Number<br />
**LogicalName**: bulkoperationlogid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CreatedObjectId"></a> CreatedObjectId

**Description**: Choose the activity or other item created by the bulk operation.<br />
**DisplayName**: Created Object<br />
**LogicalName**: createdobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: account,activitypointer,contact,lead,opportunity


### <a name="BKMK_CreatedObjectIdTypeCode"></a> CreatedObjectIdTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdobjectidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


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

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the account, contact, lead, or list that the bulk operation log item applies to.<br />
**DisplayName**: Customers Excluded<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: account,contact,lead


### <a name="BKMK_RegardingObjectIdTypeCode"></a> RegardingObjectIdTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


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

- [BulkOperationIdName](#BKMK_BulkOperationIdName)
- [BulkOperationIdYomiName](#BKMK_BulkOperationIdYomiName)
- [CreatedObjectIdName](#BKMK_CreatedObjectIdName)
- [CreatedObjectIdYomiName](#BKMK_CreatedObjectIdYomiName)
- [ErrorNumber](#BKMK_ErrorNumber)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BulkOperationIdName"></a> BulkOperationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bulkoperationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BulkOperationIdYomiName"></a> BulkOperationIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bulkoperationidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_CreatedObjectIdName"></a> CreatedObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedObjectIdYomiName"></a> CreatedObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_ErrorNumber"></a> ErrorNumber

**Description**: Shows the error code that is used to troubleshoot issues in the bulk operation.<br />
**DisplayName**: Reason Id<br />
**LogicalName**: errornumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


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


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


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
**Targets**: 


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
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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

- [bulkoperationlog_SyncErrors](#BKMK_bulkoperationlog_SyncErrors)
- [BulkOperationLog_AsyncOperations](#BKMK_BulkOperationLog_AsyncOperations)
- [bulkoperationlog_MailboxTrackingFolders](#BKMK_bulkoperationlog_MailboxTrackingFolders)
- [userentityinstancedata_bulkoperationlog](#BKMK_userentityinstancedata_bulkoperationlog)
- [BulkOperationLog_BulkDeleteFailures](#BKMK_BulkOperationLog_BulkDeleteFailures)
- [bulkoperationlog_PrincipalObjectAttributeAccesses](#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses)


### <a name="BKMK_bulkoperationlog_SyncErrors"></a> bulkoperationlog_SyncErrors

Same as syncerror entity [bulkoperationlog_SyncErrors](syncerror.md#BKMK_bulkoperationlog_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperationlog_SyncErrors<br />
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


### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

Same as asyncoperation entity [BulkOperationLog_AsyncOperations](asyncoperation.md#BKMK_BulkOperationLog_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperationLog_AsyncOperations<br />
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


### <a name="BKMK_bulkoperationlog_MailboxTrackingFolders"></a> bulkoperationlog_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bulkoperationlog_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bulkoperationlog_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperationlog_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_bulkoperationlog"></a> userentityinstancedata_bulkoperationlog

Same as userentityinstancedata entity [userentityinstancedata_bulkoperationlog](userentityinstancedata.md#BKMK_userentityinstancedata_bulkoperationlog) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_bulkoperationlog<br />
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


### <a name="BKMK_BulkOperationLog_BulkDeleteFailures"></a> BulkOperationLog_BulkDeleteFailures

Same as bulkdeletefailure entity [BulkOperationLog_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BulkOperationLog_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperationLog_BulkDeleteFailures<br />
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


### <a name="BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses"></a> bulkoperationlog_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [bulkoperationlog_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperationlog_PrincipalObjectAttributeAccesses<br />
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

- [user_bulkoperationlog](#BKMK_user_bulkoperationlog)
- [team_bulkoperationlog](#BKMK_team_bulkoperationlog)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [BulkOperation_logs](#BKMK_BulkOperation_logs)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)
- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)


### <a name="BKMK_user_bulkoperationlog"></a> user_bulkoperationlog

See systemuser Entity [user_bulkoperationlog](systemuser.md#BKMK_user_bulkoperationlog) One-To-Many relationship.

### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

See team Entity [team_bulkoperationlog](team.md#BKMK_team_bulkoperationlog) One-To-Many relationship.

### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

See account Entity [CreatedAccount_BulkOperationLogs2](account.md#BKMK_CreatedAccount_BulkOperationLogs2) One-To-Many relationship.

### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

See account Entity [SourceAccount_BulkOperationLogs](account.md#BKMK_SourceAccount_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

See activitypointer Entity [activity_pointer_BulkOperation_logs](activitypointer.md#BKMK_activity_pointer_BulkOperation_logs) One-To-Many relationship.

### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

See activitypointer Entity [CreatedActivity_BulkOperationLogs](activitypointer.md#BKMK_CreatedActivity_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_BulkOperation_logs"></a> BulkOperation_logs

See bulkoperation Entity [BulkOperation_logs](bulkoperation.md#BKMK_BulkOperation_logs) One-To-Many relationship.

### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

See contact Entity [CreatedContact_BulkOperationLogs](contact.md#BKMK_CreatedContact_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

See contact Entity [SourceContact_BulkOperationLogs](contact.md#BKMK_SourceContact_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

See lead Entity [CreatedLead_BulkOperationLogs](lead.md#BKMK_CreatedLead_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

See lead Entity [SourceLead_BulkOperationLogs](lead.md#BKMK_SourceLead_BulkOperationLogs) One-To-Many relationship.

### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

See opportunity Entity [CreatedOpportunity_BulkOperationLogs](opportunity.md#BKMK_CreatedOpportunity_BulkOperationLogs) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bulkoperationlog?text=bulkoperationlog EntityType" />