---
title: "CompetitorSalesLiterature Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CompetitorSalesLiterature entity."
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
# CompetitorSalesLiterature Entity Reference



**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/competitorsalesliteratures<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: CompetitorSalesLiterature<br />
**DisplayCollectionName**: CompetitorSalesLiterature<br />
**SchemaName**: CompetitorSalesLiterature<br />
**CollectionSchemaName**: <br />
**LogicalName**: competitorsalesliterature<br />
**LogicalCollectionName**: <br />
**EntitySetName**: competitorsalesliteratures<br />
**PrimaryIdAttribute**: competitorsalesliteratureid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CompetitorSalesLiteratureId](#BKMK_CompetitorSalesLiteratureId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_CompetitorSalesLiteratureId"></a> CompetitorSalesLiteratureId

**Description**: Unique identifier of the sales literature for the competitor product.<br />
**DisplayName**: <br />
**LogicalName**: competitorsalesliteratureid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

- [CompetitorId](#BKMK_CompetitorId)
- [SalesLiteratureId](#BKMK_SalesLiteratureId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CompetitorId"></a> CompetitorId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: competitorid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SalesLiteratureId"></a> SalesLiteratureId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: salesliteratureid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


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

- [competitorsalesliterature_AsyncOperations](#BKMK_competitorsalesliterature_AsyncOperations)
- [competitorsalesliterature_MailboxTrackingFolders](#BKMK_competitorsalesliterature_MailboxTrackingFolders)
- [competitorsalesliterature_UserEntityInstanceDatas](#BKMK_competitorsalesliterature_UserEntityInstanceDatas)
- [competitorsalesliterature_BulkDeleteFailures](#BKMK_competitorsalesliterature_BulkDeleteFailures)
- [competitorsalesliterature_PrincipalObjectAttributeAccesses](#BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses)
- [userentityinstancedata_competitorsalesliterature](#BKMK_userentityinstancedata_competitorsalesliterature)


### <a name="BKMK_competitorsalesliterature_AsyncOperations"></a> competitorsalesliterature_AsyncOperations

Same as asyncoperation entity [competitorsalesliterature_AsyncOperations](asyncoperation.md#BKMK_competitorsalesliterature_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: competitorsalesliterature_AsyncOperations<br />
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


### <a name="BKMK_competitorsalesliterature_MailboxTrackingFolders"></a> competitorsalesliterature_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [competitorsalesliterature_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_competitorsalesliterature_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: competitorsalesliterature_MailboxTrackingFolders<br />
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


### <a name="BKMK_competitorsalesliterature_UserEntityInstanceDatas"></a> competitorsalesliterature_UserEntityInstanceDatas

Same as userentityinstancedata entity [competitorsalesliterature_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_competitorsalesliterature_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: competitorsalesliterature_UserEntityInstanceDatas<br />
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


### <a name="BKMK_competitorsalesliterature_BulkDeleteFailures"></a> competitorsalesliterature_BulkDeleteFailures

Same as bulkdeletefailure entity [competitorsalesliterature_BulkDeleteFailures](bulkdeletefailure.md#BKMK_competitorsalesliterature_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: competitorsalesliterature_BulkDeleteFailures<br />
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


### <a name="BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses"></a> competitorsalesliterature_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [competitorsalesliterature_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: competitorsalesliterature_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_userentityinstancedata_competitorsalesliterature"></a> userentityinstancedata_competitorsalesliterature

Same as userentityinstancedata entity [userentityinstancedata_competitorsalesliterature](userentityinstancedata.md#BKMK_userentityinstancedata_competitorsalesliterature) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_competitorsalesliterature<br />
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

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the CompetitorSalesLiterature entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_competitorsalesliterature_association"></a> competitorsalesliterature_association

See salesliterature Entity [competitorsalesliterature_association](salesliterature.md#BKMK_competitorsalesliterature_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.competitorsalesliterature?text=competitorsalesliterature EntityType" />