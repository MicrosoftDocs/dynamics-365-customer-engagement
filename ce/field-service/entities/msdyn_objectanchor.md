---
title: "Object Anchor (msdyn_objectanchor) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Object Anchor (msdyn_objectanchor) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Object Anchor (msdyn_objectanchor) table/entity reference

Stores information for runtime object detection (detectable object) and visualization (preview model).

## Messages

The following table lists the messages for the Object Anchor (msdyn_objectanchor) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_objectanchors<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_objectanchors<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_objectanchors(*msdyn_objectanchorid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Object Anchor (msdyn_objectanchor) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Object Anchor (msdyn_objectanchor) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Object Anchor** |
| **DisplayCollectionName** | **Object Anchors** |
| **SchemaName** | `msdyn_objectanchor` |
| **CollectionSchemaName** | `msdyn_objectanchors` |
| **EntitySetName** | `msdyn_objectanchors`|
| **LogicalName** | `msdyn_objectanchor` |
| **LogicalCollectionName** | `msdyn_objectanchors` |
| **PrimaryIdAttribute** | `msdyn_objectanchorid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ConversionStatus](#BKMK_msdyn_ConversionStatus)
- [msdyn_Depth](#BKMK_msdyn_Depth)
- [msdyn_FileFormat](#BKMK_msdyn_FileFormat)
- [msdyn_GravityX](#BKMK_msdyn_GravityX)
- [msdyn_GravityY](#BKMK_msdyn_GravityY)
- [msdyn_GravityZ](#BKMK_msdyn_GravityZ)
- [msdyn_Height](#BKMK_msdyn_Height)
- [msdyn_LengthUnit](#BKMK_msdyn_LengthUnit)
- [msdyn_LevelOfDetail](#BKMK_msdyn_LevelOfDetail)
- [msdyn_MinimumCoverage](#BKMK_msdyn_MinimumCoverage)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objectanchorId](#BKMK_msdyn_objectanchorId)
- [msdyn_objectanchorthumbnail](#BKMK_msdyn_objectanchorthumbnail)
- [msdyn_ParentFolderId](#BKMK_msdyn_ParentFolderId)
- [msdyn_schemaversion](#BKMK_msdyn_schemaversion)
- [msdyn_uselengthunitfromfile](#BKMK_msdyn_uselengthunitfromfile)
- [msdyn_Width](#BKMK_msdyn_Width)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
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

### <a name="BKMK_msdyn_ConversionStatus"></a> msdyn_ConversionStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversion Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversionstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_conversionstatus`|

#### msdyn_ConversionStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**New**|
|192350001|**Requested**|
|192350002|**Started**|
|192350003|**Succeeded**|
|192350004|**Failed**|
|192350005|**Invalid 3D Source File Type**|
|192350006|**Asset Cannot Be Converted**|
|192350007|**Asset Dimensions Out Of Bounds**|
|192350008|**Asset Size Too Large**|
|192350009|**Invalid Asset Uri**|
|192350010|**Invalid Face Vertices**|
|192350011|**Invalid Gravity**|
|192350012|**Invalid Job Id**|
|192350013|**Invalid Scale**|
|192350014|**Too Many Rig Poses**|
|192350015|**Zero Faces**|
|192350016|**Zero Trajectories Generated**|
|192350017|**Service Error**|

### <a name="BKMK_msdyn_Depth"></a> msdyn_Depth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Depth**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_depth`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_FileFormat"></a> msdyn_FileFormat

|Property|Value|
|---|---|
|Description||
|DisplayName|**File Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fileformat`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_objectanchor_msdyn_fileformat`|

#### msdyn_FileFormat Choices/Options

|Value|Label|
|---|---|
|192350000|**OU**|

### <a name="BKMK_msdyn_GravityX"></a> msdyn_GravityX

|Property|Value|
|---|---|
|Description||
|DisplayName|**Gravity X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gravityx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|3|

### <a name="BKMK_msdyn_GravityY"></a> msdyn_GravityY

|Property|Value|
|---|---|
|Description||
|DisplayName|**Gravity Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gravityy`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|3|

### <a name="BKMK_msdyn_GravityZ"></a> msdyn_GravityZ

|Property|Value|
|---|---|
|Description||
|DisplayName|**Gravity Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gravityz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|3|

### <a name="BKMK_msdyn_Height"></a> msdyn_Height

|Property|Value|
|---|---|
|Description||
|DisplayName|**Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_height`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_LengthUnit"></a> msdyn_LengthUnit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Length Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lengthunit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_lengthunit`|

#### msdyn_LengthUnit Choices/Options

|Value|Label|
|---|---|
|192350000|**Meters**|
|192350001|**Centimeters**|
|192350002|**Decimeters**|
|192350003|**Feet**|
|192350004|**Inches**|
|192350005|**Kilometers**|
|192350006|**Millimeters**|
|192350007|**Yards**|

### <a name="BKMK_msdyn_LevelOfDetail"></a> msdyn_LevelOfDetail

|Property|Value|
|---|---|
|Description|**Size of output polygon faces (in centimeters)**|
|DisplayName|**Level Of Detail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_levelofdetail`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_levelofdetail`|

#### msdyn_LevelOfDetail Choices/Options

|Value|Label|
|---|---|
|192350000|**4 cm - fast detection for any object**|
|192350001|**2 cm - slower detection works best for smaller objects**|

### <a name="BKMK_msdyn_MinimumCoverage"></a> msdyn_MinimumCoverage

|Property|Value|
|---|---|
|Description|**Optional override to increase the accuracy of scanning required to detect this object**|
|DisplayName|**Minimum Coverage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumcoverage`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the object anchor.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_objectanchorId"></a> msdyn_objectanchorId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Object Anchor**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectanchorid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_objectanchorthumbnail"></a> msdyn_objectanchorthumbnail

|Property|Value|
|---|---|
|Description|**Thumbnail of the object anchor.**|
|DisplayName|**Object Anchor Thumbnail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectanchorthumbnail`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|30720|
|MaxWidth|144|

### <a name="BKMK_msdyn_ParentFolderId"></a> msdyn_ParentFolderId

|Property|Value|
|---|---|
|Description|**Unique identifier for Folder associated with Object Anchor.**|
|DisplayName|**Parent Folder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentfolderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_mrfolder|

### <a name="BKMK_msdyn_schemaversion"></a> msdyn_schemaversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Schema Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schemaversion`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_uselengthunitfromfile"></a> msdyn_uselengthunitfromfile

|Property|Value|
|---|---|
|Description|**Set this flag if you would like model conversion to auto detect the length unit from the 3D Source File, instead of manually choosing the length unit from the given list.**|
|DisplayName|**Use Length Unit from File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uselengthunitfromfile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_objectanchor_msdyn_uselengthunitfromfile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Width"></a> msdyn_Width

|Property|Value|
|---|---|
|Description||
|DisplayName|**Width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_width`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000|
|MinValue|0|
|Precision|3|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Object Anchor**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_objectanchor_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Object Anchor**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_objectanchor_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_detectableobject](#BKMK_msdyn_detectableobject)
- [msdyn_detectableobject_Name](#BKMK_msdyn_detectableobject_Name)
- [msdyn_objectanchorthumbnail_Timestamp](#BKMK_msdyn_objectanchorthumbnail_Timestamp)
- [msdyn_objectanchorthumbnail_URL](#BKMK_msdyn_objectanchorthumbnail_URL)
- [msdyn_objectanchorthumbnailId](#BKMK_msdyn_objectanchorthumbnailId)
- [msdyn_previewmodel](#BKMK_msdyn_previewmodel)
- [msdyn_previewmodel_Name](#BKMK_msdyn_previewmodel_Name)
- [msdyn_SourceObject](#BKMK_msdyn_SourceObject)
- [msdyn_SourceObject_Name](#BKMK_msdyn_SourceObject_Name)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_detectableobject"></a> msdyn_detectableobject

|Property|Value|
|---|---|
|Description|**This is used for runtime object detection.  Detectable objects are created by the Azure Object Anchor Ingestion Service.**|
|DisplayName|**Detectable Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_detectableobject`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_detectableobject_Name"></a> msdyn_detectableobject_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_detectableobject_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_objectanchorthumbnail_Timestamp"></a> msdyn_objectanchorthumbnail_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectanchorthumbnail_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_objectanchorthumbnail_URL"></a> msdyn_objectanchorthumbnail_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectanchorthumbnail_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_objectanchorthumbnailId"></a> msdyn_objectanchorthumbnailId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectanchorthumbnailid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_previewmodel"></a> msdyn_previewmodel

|Property|Value|
|---|---|
|Description|**3D models used for visualizing object anchors.**|
|DisplayName|**Preview Model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previewmodel`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_previewmodel_Name"></a> msdyn_previewmodel_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_previewmodel_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_SourceObject"></a> msdyn_SourceObject

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceobject`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msdyn_SourceObject_Name"></a> msdyn_SourceObject_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceobject_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_objectanchor](#BKMK_business_unit_msdyn_objectanchor)
- [FileAttachment_msdyn_objectanchor_msdyn_detectableobject](#BKMK_FileAttachment_msdyn_objectanchor_msdyn_detectableobject)
- [FileAttachment_msdyn_objectanchor_msdyn_previewmodel](#BKMK_FileAttachment_msdyn_objectanchor_msdyn_previewmodel)
- [FileAttachment_msdyn_objectanchor_msdyn_SourceObject](#BKMK_FileAttachment_msdyn_objectanchor_msdyn_SourceObject)
- [lk_msdyn_objectanchor_createdby](#BKMK_lk_msdyn_objectanchor_createdby)
- [lk_msdyn_objectanchor_createdonbehalfby](#BKMK_lk_msdyn_objectanchor_createdonbehalfby)
- [lk_msdyn_objectanchor_modifiedby](#BKMK_lk_msdyn_objectanchor_modifiedby)
- [lk_msdyn_objectanchor_modifiedonbehalfby](#BKMK_lk_msdyn_objectanchor_modifiedonbehalfby)
- [msdyn_msdyn_mrfolder_msdyn_objectanchor](#BKMK_msdyn_msdyn_mrfolder_msdyn_objectanchor)
- [owner_msdyn_objectanchor](#BKMK_owner_msdyn_objectanchor)
- [team_msdyn_objectanchor](#BKMK_team_msdyn_objectanchor)
- [user_msdyn_objectanchor](#BKMK_user_msdyn_objectanchor)

### <a name="BKMK_business_unit_msdyn_objectanchor"></a> business_unit_msdyn_objectanchor

One-To-Many Relationship: [businessunit business_unit_msdyn_objectanchor](businessunit.md#BKMK_business_unit_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_objectanchor_msdyn_detectableobject"></a> FileAttachment_msdyn_objectanchor_msdyn_detectableobject

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_objectanchor_msdyn_detectableobject](fileattachment.md#BKMK_FileAttachment_msdyn_objectanchor_msdyn_detectableobject)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_detectableobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_detectableobject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_objectanchor_msdyn_previewmodel"></a> FileAttachment_msdyn_objectanchor_msdyn_previewmodel

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_objectanchor_msdyn_previewmodel](fileattachment.md#BKMK_FileAttachment_msdyn_objectanchor_msdyn_previewmodel)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_previewmodel`|
|ReferencingEntityNavigationPropertyName|`msdyn_previewmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_objectanchor_msdyn_SourceObject"></a> FileAttachment_msdyn_objectanchor_msdyn_SourceObject

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_objectanchor_msdyn_SourceObject](fileattachment.md#BKMK_FileAttachment_msdyn_objectanchor_msdyn_SourceObject)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_sourceobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourceobject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_objectanchor_createdby"></a> lk_msdyn_objectanchor_createdby

One-To-Many Relationship: [systemuser lk_msdyn_objectanchor_createdby](systemuser.md#BKMK_lk_msdyn_objectanchor_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_objectanchor_createdonbehalfby"></a> lk_msdyn_objectanchor_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_objectanchor_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_objectanchor_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_objectanchor_modifiedby"></a> lk_msdyn_objectanchor_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_objectanchor_modifiedby](systemuser.md#BKMK_lk_msdyn_objectanchor_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_objectanchor_modifiedonbehalfby"></a> lk_msdyn_objectanchor_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_objectanchor_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_objectanchor_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_mrfolder_msdyn_objectanchor"></a> msdyn_msdyn_mrfolder_msdyn_objectanchor

One-To-Many Relationship: [msdyn_mrfolder msdyn_msdyn_mrfolder_msdyn_objectanchor](msdyn_mrfolder.md#BKMK_msdyn_msdyn_mrfolder_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mrfolder`|
|ReferencedAttribute|`msdyn_mrfolderid`|
|ReferencingAttribute|`msdyn_parentfolderid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentFolderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_objectanchor"></a> owner_msdyn_objectanchor

One-To-Many Relationship: [owner owner_msdyn_objectanchor](owner.md#BKMK_owner_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_objectanchor"></a> team_msdyn_objectanchor

One-To-Many Relationship: [team team_msdyn_objectanchor](team.md#BKMK_team_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_objectanchor"></a> user_msdyn_objectanchor

One-To-Many Relationship: [systemuser user_msdyn_objectanchor](systemuser.md#BKMK_user_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje](#BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje)
- [msdyn_objectanchor_Annotations](#BKMK_msdyn_objectanchor_Annotations)
- [msdyn_objectanchor_AsyncOperations](#BKMK_msdyn_objectanchor_AsyncOperations)
- [msdyn_objectanchor_BulkDeleteFailures](#BKMK_msdyn_objectanchor_BulkDeleteFailures)
- [msdyn_objectanchor_DuplicateBaseRecord](#BKMK_msdyn_objectanchor_DuplicateBaseRecord)
- [msdyn_objectanchor_DuplicateMatchingRecord](#BKMK_msdyn_objectanchor_DuplicateMatchingRecord)
- [msdyn_objectanchor_FileAttachments](#BKMK_msdyn_objectanchor_FileAttachments)
- [msdyn_objectanchor_MailboxTrackingFolders](#BKMK_msdyn_objectanchor_MailboxTrackingFolders)
- [msdyn_objectanchor_PrincipalObjectAttributeAccesses](#BKMK_msdyn_objectanchor_PrincipalObjectAttributeAccesses)
- [msdyn_objectanchor_ProcessSession](#BKMK_msdyn_objectanchor_ProcessSession)
- [msdyn_objectanchor_SyncErrors](#BKMK_msdyn_objectanchor_SyncErrors)

### <a name="BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje"></a> msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje

Many-To-One Relationship: [msmrw_guide msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje](msmrw_guide.md#BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`msdyn_anchorobjectanchor`|
|ReferencedEntityNavigationPropertyName|`msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_Annotations"></a> msdyn_objectanchor_Annotations

Many-To-One Relationship: [annotation msdyn_objectanchor_Annotations](annotation.md#BKMK_msdyn_objectanchor_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_AsyncOperations"></a> msdyn_objectanchor_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_objectanchor_AsyncOperations](asyncoperation.md#BKMK_msdyn_objectanchor_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_BulkDeleteFailures"></a> msdyn_objectanchor_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_objectanchor_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_objectanchor_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_DuplicateBaseRecord"></a> msdyn_objectanchor_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_objectanchor_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_objectanchor_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_DuplicateMatchingRecord"></a> msdyn_objectanchor_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_objectanchor_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_objectanchor_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_FileAttachments"></a> msdyn_objectanchor_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_objectanchor_FileAttachments](fileattachment.md#BKMK_msdyn_objectanchor_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_MailboxTrackingFolders"></a> msdyn_objectanchor_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_objectanchor_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_objectanchor_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_PrincipalObjectAttributeAccesses"></a> msdyn_objectanchor_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_objectanchor_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_objectanchor_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_ProcessSession"></a> msdyn_objectanchor_ProcessSession

Many-To-One Relationship: [processsession msdyn_objectanchor_ProcessSession](processsession.md#BKMK_msdyn_objectanchor_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_objectanchor_SyncErrors"></a> msdyn_objectanchor_SyncErrors

Many-To-One Relationship: [syncerror msdyn_objectanchor_SyncErrors](syncerror.md#BKMK_msdyn_objectanchor_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_objectanchor_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

