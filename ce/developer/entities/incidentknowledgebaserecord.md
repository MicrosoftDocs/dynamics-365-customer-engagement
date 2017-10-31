---
title: "IncidentKnowledgeBaseRecord Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the IncidentKnowledgeBaseRecord entity."
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
# IncidentKnowledgeBaseRecord Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/incidentknowledgebaserecords<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: Incident KnowledgeBaseRecord<br />
**DisplayCollectionName**: Incident KnowledgeBaseRecords<br />
**SchemaName**: IncidentKnowledgeBaseRecord<br />
**CollectionSchemaName**: <br />
**LogicalName**: incidentknowledgebaserecord<br />
**LogicalCollectionName**: <br />
**EntitySetName**: incidentknowledgebaserecords<br />
**PrimaryIdAttribute**: incidentknowledgebaserecordid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IncidentKnowledgeBaseRecordId](#BKMK_IncidentKnowledgeBaseRecordId)
- [Name](#BKMK_Name)
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


### <a name="BKMK_IncidentKnowledgeBaseRecordId"></a> IncidentKnowledgeBaseRecordId

**Description**: Unique identifier of the knowledgebase records for the incident.<br />
**DisplayName**: <br />
**LogicalName**: incidentknowledgebaserecordid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

- [IncidentId](#BKMK_IncidentId)
- [KnowledgeBaseRecordId](#BKMK_KnowledgeBaseRecordId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_IncidentId"></a> IncidentId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: incidentid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_KnowledgeBaseRecordId"></a> KnowledgeBaseRecordId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: knowledgebaserecordid<br />
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

- [incidentknowledgebaserecord_AsyncOperations](#BKMK_incidentknowledgebaserecord_AsyncOperations)
- [incidentknowledgebaserecord_MailboxTrackingFolders](#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders)
- [incidentknowledgebaserecord_UserEntityInstanceDatas](#BKMK_incidentknowledgebaserecord_UserEntityInstanceDatas)
- [incidentknowledgebaserecord_BulkDeleteFailures](#BKMK_incidentknowledgebaserecord_BulkDeleteFailures)
- [incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses)


### <a name="BKMK_incidentknowledgebaserecord_AsyncOperations"></a> incidentknowledgebaserecord_AsyncOperations

Same as asyncoperation entity [incidentknowledgebaserecord_AsyncOperations](asyncoperation.md#BKMK_incidentknowledgebaserecord_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentknowledgebaserecord_AsyncOperations<br />
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


### <a name="BKMK_incidentknowledgebaserecord_MailboxTrackingFolders"></a> incidentknowledgebaserecord_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [incidentknowledgebaserecord_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentknowledgebaserecord_MailboxTrackingFolders<br />
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


### <a name="BKMK_incidentknowledgebaserecord_UserEntityInstanceDatas"></a> incidentknowledgebaserecord_UserEntityInstanceDatas

Same as userentityinstancedata entity [incidentknowledgebaserecord_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_incidentknowledgebaserecord_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentknowledgebaserecord_UserEntityInstanceDatas<br />
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


### <a name="BKMK_incidentknowledgebaserecord_BulkDeleteFailures"></a> incidentknowledgebaserecord_BulkDeleteFailures

Same as bulkdeletefailure entity [incidentknowledgebaserecord_BulkDeleteFailures](bulkdeletefailure.md#BKMK_incidentknowledgebaserecord_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentknowledgebaserecord_BulkDeleteFailures<br />
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


### <a name="BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses"></a> incidentknowledgebaserecord_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentknowledgebaserecord_PrincipalObjectAttributeAccesses<br />
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

Relationship details provided where the IncidentKnowledgeBaseRecord entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident

See knowledgebaserecord Entity [KnowledgeBaseRecord_Incident](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Incident) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.incidentknowledgebaserecord?text=incidentknowledgebaserecord EntityType" />