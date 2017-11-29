---
title: "OpportunityCompetitors Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OpportunityCompetitors entity."
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
# OpportunityCompetitors Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/opportunitycompetitorscollection<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: OpportunityCompetitors<br />
**DisplayCollectionName**: OpportunityCompetitors<br />
**SchemaName**: OpportunityCompetitors<br />
**CollectionSchemaName**: <br />
**LogicalName**: opportunitycompetitors<br />
**LogicalCollectionName**: <br />
**EntitySetName**: opportunitycompetitorscollection<br />
**PrimaryIdAttribute**: opportunitycompetitorid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OpportunityCompetitorId](#BKMK_OpportunityCompetitorId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_OpportunityCompetitorId"></a> OpportunityCompetitorId

**Description**: Unique identifier of the opportunity competitor.<br />
**DisplayName**: <br />
**LogicalName**: opportunitycompetitorid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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
- [OpportunityId](#BKMK_OpportunityId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CompetitorId"></a> CompetitorId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: competitorid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OpportunityId"></a> OpportunityId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: opportunityid<br />
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

- [opportunitycompetitors_AsyncOperations](#BKMK_opportunitycompetitors_AsyncOperations)
- [opportunitycompetitors_MailboxTrackingFolders](#BKMK_opportunitycompetitors_MailboxTrackingFolders)
- [opportunitycompetitors_UserEntityInstanceDatas](#BKMK_opportunitycompetitors_UserEntityInstanceDatas)
- [opportunitycompetitors_BulkDeleteFailures](#BKMK_opportunitycompetitors_BulkDeleteFailures)
- [opportunitycompetitors_PrincipalObjectAttributeAccesses](#BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses)


### <a name="BKMK_opportunitycompetitors_AsyncOperations"></a> opportunitycompetitors_AsyncOperations

Same as asyncoperation entity [opportunitycompetitors_AsyncOperations](asyncoperation.md#BKMK_opportunitycompetitors_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunitycompetitors_AsyncOperations<br />
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


### <a name="BKMK_opportunitycompetitors_MailboxTrackingFolders"></a> opportunitycompetitors_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [opportunitycompetitors_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_opportunitycompetitors_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunitycompetitors_MailboxTrackingFolders<br />
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


### <a name="BKMK_opportunitycompetitors_UserEntityInstanceDatas"></a> opportunitycompetitors_UserEntityInstanceDatas

Same as userentityinstancedata entity [opportunitycompetitors_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_opportunitycompetitors_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunitycompetitors_UserEntityInstanceDatas<br />
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


### <a name="BKMK_opportunitycompetitors_BulkDeleteFailures"></a> opportunitycompetitors_BulkDeleteFailures

Same as bulkdeletefailure entity [opportunitycompetitors_BulkDeleteFailures](bulkdeletefailure.md#BKMK_opportunitycompetitors_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunitycompetitors_BulkDeleteFailures<br />
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


### <a name="BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses"></a> opportunitycompetitors_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [opportunitycompetitors_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunitycompetitors_PrincipalObjectAttributeAccesses<br />
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

Relationship details provided where the OpportunityCompetitors entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_opportunitycompetitors_association"></a> opportunitycompetitors_association

See opportunity Entity [opportunitycompetitors_association](opportunity.md#BKMK_opportunitycompetitors_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.opportunitycompetitors?text=opportunitycompetitors EntityType" />