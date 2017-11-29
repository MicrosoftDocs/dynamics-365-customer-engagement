---
title: "DynamicPropertyAssociation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DynamicPropertyAssociation entity."
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
# DynamicPropertyAssociation Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Association of a property definition with another entity in the system.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/dynamicpropertyassociations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/dynamicpropertyassociations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Property Association<br />
**DisplayCollectionName**: Property Associations<br />
**SchemaName**: DynamicPropertyAssociation<br />
**CollectionSchemaName**: DynamicPropertyAssociations<br />
**LogicalName**: dynamicpropertyassociation<br />
**LogicalCollectionName**: dynamicpropertyassociations<br />
**EntitySetName**: dynamicpropertyassociations<br />
**PrimaryIdAttribute**: dynamicpropertyassociationid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AssociationStatus](#BKMK_AssociationStatus)
- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyAssociationId](#BKMK_DynamicPropertyAssociationId)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [DynamicPropertyIdName](#BKMK_DynamicPropertyIdName)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InheritanceState](#BKMK_InheritanceState)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectid](#BKMK_RegardingObjectid)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AssociationStatus"></a> AssociationStatus

**Description**: Shows the status of the property association.<br />
**DisplayName**: Association Status.<br />
**LogicalName**: associationstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Active
- **Value**: 1 **Label**: Deleted
- **Value**: 2 **Label**: Draft
- **Value**: 3 **Label**: Draft Added
- **Value**: 4 **Label**: Draft Deleted



### <a name="BKMK_DMTImportState"></a> DMTImportState

**Description**: Internal Use Only<br />
**DisplayName**: Internal Use Only<br />
**LogicalName**: dmtimportstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_DynamicPropertyAssociationId"></a> DynamicPropertyAssociationId

**Description**: Shows the unique identifier of the property association.<br />
**DisplayName**: Property Association ID<br />
**LogicalName**: dynamicpropertyassociationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

**Description**: Shows the property that uses this option set item.<br />
**DisplayName**: Property ID<br />
**LogicalName**: dynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: dynamicproperty


### <a name="BKMK_DynamicPropertyIdName"></a> DynamicPropertyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: dynamicpropertyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_InheritanceState"></a> InheritanceState

**Description**: Shows the inheritance state in relationship to the parent property.<br />
**DisplayName**: Inheritance State.<br />
**LogicalName**: inheritancestate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Inherited
- **Value**: 1 **Label**: Overridden
- **Value**: 2 **Label**: Owned



### <a name="BKMK_Name"></a> Name

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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


### <a name="BKMK_RegardingObjectid"></a> RegardingObjectid

**Description**: Shows the object that the property is associated with.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: product,productassociation


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


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Shows the currency associated with the record.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
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
**Format**: DateOnly


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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


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
**Format**: DateOnly


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
**MaxLength**: 4000


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
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

- [dynamicpropertyassociation_SyncErrors](#BKMK_dynamicpropertyassociation_SyncErrors)
- [dynamicpropertyassociation_AsyncOperations](#BKMK_dynamicpropertyassociation_AsyncOperations)
- [dynamicpropertyassociation_MailboxTrackingFolders](#BKMK_dynamicpropertyassociation_MailboxTrackingFolders)
- [dynamicpropertyassociation_UserEntityInstanceDatas](#BKMK_dynamicpropertyassociation_UserEntityInstanceDatas)
- [dynamicpropertyassociation_BulkDeleteFailures](#BKMK_dynamicpropertyassociation_BulkDeleteFailures)
- [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses)


### <a name="BKMK_dynamicpropertyassociation_SyncErrors"></a> dynamicpropertyassociation_SyncErrors

Same as syncerror entity [dynamicpropertyassociation_SyncErrors](syncerror.md#BKMK_dynamicpropertyassociation_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_SyncErrors<br />
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


### <a name="BKMK_dynamicpropertyassociation_AsyncOperations"></a> dynamicpropertyassociation_AsyncOperations

Same as asyncoperation entity [dynamicpropertyassociation_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyassociation_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_AsyncOperations<br />
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


### <a name="BKMK_dynamicpropertyassociation_MailboxTrackingFolders"></a> dynamicpropertyassociation_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [dynamicpropertyassociation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyassociation_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_MailboxTrackingFolders<br />
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


### <a name="BKMK_dynamicpropertyassociation_UserEntityInstanceDatas"></a> dynamicpropertyassociation_UserEntityInstanceDatas

Same as userentityinstancedata entity [dynamicpropertyassociation_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_dynamicpropertyassociation_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_UserEntityInstanceDatas<br />
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


### <a name="BKMK_dynamicpropertyassociation_BulkDeleteFailures"></a> dynamicpropertyassociation_BulkDeleteFailures

Same as bulkdeletefailure entity [dynamicpropertyassociation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyassociation_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_BulkDeleteFailures<br />
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


### <a name="BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses"></a> dynamicpropertyassociation_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyassociation_PrincipalObjectAttributeAccesses<br />
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

- [lk_DynamicPropertyAssociationattribute_createdby](#BKMK_lk_DynamicPropertyAssociationattribute_createdby)
- [lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy](#BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy)
- [lk_DynamicPropertyAssociationattribute_ModifiedBy](#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy)
- [lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy](#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy)
- [DynamicPropertyAssociation_organization](#BKMK_DynamicPropertyAssociation_organization)
- [Dynamicproperty_DynamicPropertyAssociation](#BKMK_Dynamicproperty_DynamicPropertyAssociation)
- [DynamicPropertyAssociation_TransactionCurrency](#BKMK_DynamicPropertyAssociation_TransactionCurrency)
- [Product_DynamicPropertyAssociation](#BKMK_Product_DynamicPropertyAssociation)
- [ProductAssociation_DynamicPropertyAssociation](#BKMK_ProductAssociation_DynamicPropertyAssociation)


### <a name="BKMK_lk_DynamicPropertyAssociationattribute_createdby"></a> lk_DynamicPropertyAssociationattribute_createdby

See systemuser Entity [lk_DynamicPropertyAssociationattribute_createdby](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_createdby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy"></a> lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy

See systemuser Entity [lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy"></a> lk_DynamicPropertyAssociationattribute_ModifiedBy

See systemuser Entity [lk_DynamicPropertyAssociationattribute_ModifiedBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy"></a> lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy

See systemuser Entity [lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy) One-To-Many relationship.

### <a name="BKMK_DynamicPropertyAssociation_organization"></a> DynamicPropertyAssociation_organization

See organization Entity [DynamicPropertyAssociation_organization](organization.md#BKMK_DynamicPropertyAssociation_organization) One-To-Many relationship.

### <a name="BKMK_Dynamicproperty_DynamicPropertyAssociation"></a> Dynamicproperty_DynamicPropertyAssociation

See dynamicproperty Entity [Dynamicproperty_DynamicPropertyAssociation](dynamicproperty.md#BKMK_Dynamicproperty_DynamicPropertyAssociation) One-To-Many relationship.

### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

See transactioncurrency Entity [DynamicPropertyAssociation_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyAssociation_TransactionCurrency) One-To-Many relationship.

### <a name="BKMK_Product_DynamicPropertyAssociation"></a> Product_DynamicPropertyAssociation

See product Entity [Product_DynamicPropertyAssociation](product.md#BKMK_Product_DynamicPropertyAssociation) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_DynamicPropertyAssociation"></a> ProductAssociation_DynamicPropertyAssociation

See productassociation Entity [ProductAssociation_DynamicPropertyAssociation](productassociation.md#BKMK_ProductAssociation_DynamicPropertyAssociation) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.dynamicpropertyassociation?text=dynamicpropertyassociation EntityType" />