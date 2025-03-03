---
title: "Incident KnowledgeBaseRecord (IncidentKnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Incident KnowledgeBaseRecord (IncidentKnowledgeBaseRecord) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Incident KnowledgeBaseRecord (IncidentKnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Incident KnowledgeBaseRecord (IncidentKnowledgeBaseRecord) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `RetrieveMultiple`<br />Event: True |`GET` /incidentknowledgebaserecords<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the Incident KnowledgeBaseRecord (IncidentKnowledgeBaseRecord) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Incident KnowledgeBaseRecord** |
| **DisplayCollectionName** | **Incident KnowledgeBaseRecords** |
| **SchemaName** | `IncidentKnowledgeBaseRecord` |
| **EntitySetName** | `incidentknowledgebaserecords`|
| **LogicalName** | `incidentknowledgebaserecord` |
| **PrimaryIdAttribute** | `incidentknowledgebaserecordid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IncidentKnowledgeBaseRecordId](#BKMK_IncidentKnowledgeBaseRecordId)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IncidentKnowledgeBaseRecordId"></a> IncidentKnowledgeBaseRecordId

|Property|Value|
|---|---|
|Description|**Unique identifier of the knowledgebase records for the incident.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`incidentknowledgebaserecordid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [IncidentId](#BKMK_IncidentId)
- [KnowledgeBaseRecordId](#BKMK_KnowledgeBaseRecordId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_IncidentId"></a> IncidentId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`incidentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_KnowledgeBaseRecordId"></a> KnowledgeBaseRecordId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`knowledgebaserecordid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [incidentknowledgebaserecord_AsyncOperations](#BKMK_incidentknowledgebaserecord_AsyncOperations)
- [incidentknowledgebaserecord_BulkDeleteFailures](#BKMK_incidentknowledgebaserecord_BulkDeleteFailures)
- [incidentknowledgebaserecord_MailboxTrackingFolders](#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders)
- [incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses)

### <a name="BKMK_incidentknowledgebaserecord_AsyncOperations"></a> incidentknowledgebaserecord_AsyncOperations

Many-To-One Relationship: [asyncoperation incidentknowledgebaserecord_AsyncOperations](asyncoperation.md#BKMK_incidentknowledgebaserecord_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incidentknowledgebaserecord_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentknowledgebaserecord_BulkDeleteFailures"></a> incidentknowledgebaserecord_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure incidentknowledgebaserecord_BulkDeleteFailures](bulkdeletefailure.md#BKMK_incidentknowledgebaserecord_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incidentknowledgebaserecord_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentknowledgebaserecord_MailboxTrackingFolders"></a> incidentknowledgebaserecord_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder incidentknowledgebaserecord_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incidentknowledgebaserecord_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses"></a> incidentknowledgebaserecord_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`incidentknowledgebaserecord_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident


|Property|Value|
|---|---|
|IntersectEntityName|`incidentknowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`KnowledgeBaseRecord_Incident`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

