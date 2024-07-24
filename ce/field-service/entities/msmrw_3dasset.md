---
title: "3D Object (msmrw_3dasset) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the 3D Object (msmrw_3dasset) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# 3D Object (msmrw_3dasset) table/entity reference

Stores a 3D object file and information associated with that 3D object file.

## Messages

The following table lists the messages for the 3D Object (msmrw_3dasset) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_3dassets(*msmrw_3dassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_3dassets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_3dassets(*msmrw_3dassetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msmrw_BatchConvert3DObjectSchema`<br />Event: False |**msmrw_BatchConvert3DObjectSchema action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msmrw_Upgrade3dobjectschema`<br />Event: False |**msmrw_Upgrade3dobjectschema action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_3dassets(*msmrw_3dassetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_3dassets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_3dassets(*msmrw_3dassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_3dassets(*msmrw_3dassetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_3dassets(*msmrw_3dassetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the 3D Object (msmrw_3dasset) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the 3D Object (msmrw_3dasset) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **3D Object** |
| **DisplayCollectionName** | **3D Objects** |
| **SchemaName** | `msmrw_3dasset` |
| **CollectionSchemaName** | `msmrw_3dassets` |
| **EntitySetName** | `msmrw_3dassets`|
| **LogicalName** | `msmrw_3dasset` |
| **LogicalCollectionName** | `msmrw_3dassets` |
| **PrimaryIdAttribute** | `msmrw_3dassetid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ParentFolderId](#BKMK_msdyn_ParentFolderId)
- [msmrw_3dassetId](#BKMK_msmrw_3dassetId)
- [msmrw_assetcollectionid](#BKMK_msmrw_assetcollectionid)
- [msmrw_fileformat](#BKMK_msmrw_fileformat)
- [msmrw_indexcount](#BKMK_msmrw_indexcount)
- [msmrw_IsBillboard](#BKMK_msmrw_IsBillboard)
- [msmrw_materialcount](#BKMK_msmrw_materialcount)
- [msmrw_meshcount](#BKMK_msmrw_meshcount)
- [msmrw_meshinstancecount](#BKMK_msmrw_meshinstancecount)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_nodecount](#BKMK_msmrw_nodecount)
- [msmrw_SchemaVersion](#BKMK_msmrw_SchemaVersion)
- [msmrw_texturecount](#BKMK_msmrw_texturecount)
- [msmrw_texturedatasize](#BKMK_msmrw_texturedatasize)
- [msmrw_vertexcount](#BKMK_msmrw_vertexcount)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Thumbnail**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

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

### <a name="BKMK_msdyn_ParentFolderId"></a> msdyn_ParentFolderId

|Property|Value|
|---|---|
|Description|**Reference to the parent folder for this 3D asset.**|
|DisplayName|**Parent Folder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentfolderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_mrfolder|

### <a name="BKMK_msmrw_3dassetId"></a> msmrw_3dassetId

|Property|Value|
|---|---|
|Description|**Unique identifier for a 3D object.**|
|DisplayName|**3D Object**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_3dassetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_assetcollectionid"></a> msmrw_assetcollectionid

|Property|Value|
|---|---|
|Description|**Reference to the 3D object collection that the 3D object belongs to.**|
|DisplayName|**Collection ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_assetcollectionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_assetcollection|

### <a name="BKMK_msmrw_fileformat"></a> msmrw_fileformat

|Property|Value|
|---|---|
|Description|**Specifies the file format of the 3D object. (Can be set to: .glb, .gltf)**|
|DisplayName|**File Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_fileformat`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|5|
|GlobalChoiceName|`msmrw_3dasset_msmrw_fileformat`|

#### msmrw_fileformat Choices/Options

|Value|Label|
|---|---|
|0|**gltf**|
|5|**glb**|

### <a name="BKMK_msmrw_indexcount"></a> msmrw_indexcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Index Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_indexcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_IsBillboard"></a> msmrw_IsBillboard

|Property|Value|
|---|---|
|Description|**Defines whether the 3D object will always face the user and pivot with them as they move.**|
|DisplayName|**Is Billboard**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_isbillboard`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_3dasset_msmrw_isbillboard`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_materialcount"></a> msmrw_materialcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Material Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_materialcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_meshcount"></a> msmrw_meshcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Mesh Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_meshcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_meshinstancecount"></a> msmrw_meshinstancecount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Mesh Instance Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_meshinstancecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_nodecount"></a> msmrw_nodecount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Node Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_nodecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_SchemaVersion"></a> msmrw_SchemaVersion

|Property|Value|
|---|---|
|Description|**The schema version for this record.**|
|DisplayName|**Schema Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_schemaversion`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msmrw_texturecount"></a> msmrw_texturecount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Texture Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_texturecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msmrw_texturedatasize"></a> msmrw_texturedatasize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Texture Data Size**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_texturedatasize`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msmrw_vertexcount"></a> msmrw_vertexcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Vertex Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_vertexcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Status of the 3D Object**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_3dasset_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the 3D Object**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_3dasset_statuscode`|

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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msmrw_File](#BKMK_msmrw_File)
- [msmrw_File_Name](#BKMK_msmrw_File_Name)
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

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msmrw_File"></a> msmrw_File

|Property|Value|
|---|---|
|Description|**The 3d object file.**|
|DisplayName|**File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_file`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_msmrw_File_Name"></a> msmrw_File_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_file_name`|
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

- [business_unit_msmrw_3dasset](#BKMK_business_unit_msmrw_3dasset)
- [FileAttachment_msmrw_3dasset_msmrw_File](#BKMK_FileAttachment_msmrw_3dasset_msmrw_File)
- [lk_msmrw_3dasset_createdby](#BKMK_lk_msmrw_3dasset_createdby)
- [lk_msmrw_3dasset_createdonbehalfby](#BKMK_lk_msmrw_3dasset_createdonbehalfby)
- [lk_msmrw_3dasset_modifiedby](#BKMK_lk_msmrw_3dasset_modifiedby)
- [lk_msmrw_3dasset_modifiedonbehalfby](#BKMK_lk_msmrw_3dasset_modifiedonbehalfby)
- [msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold](#BKMK_msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold)
- [msmrw_assetcollection_msmrw_3dasset](#BKMK_msmrw_assetcollection_msmrw_3dasset)
- [owner_msmrw_3dasset](#BKMK_owner_msmrw_3dasset)
- [team_msmrw_3dasset](#BKMK_team_msmrw_3dasset)
- [user_msmrw_3dasset](#BKMK_user_msmrw_3dasset)

### <a name="BKMK_business_unit_msmrw_3dasset"></a> business_unit_msmrw_3dasset

One-To-Many Relationship: [businessunit business_unit_msmrw_3dasset](businessunit.md#BKMK_business_unit_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msmrw_3dasset_msmrw_File"></a> FileAttachment_msmrw_3dasset_msmrw_File

One-To-Many Relationship: [fileattachment FileAttachment_msmrw_3dasset_msmrw_File](fileattachment.md#BKMK_FileAttachment_msmrw_3dasset_msmrw_File)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msmrw_file`|
|ReferencingEntityNavigationPropertyName|`msmrw_file`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_3dasset_createdby"></a> lk_msmrw_3dasset_createdby

One-To-Many Relationship: [systemuser lk_msmrw_3dasset_createdby](systemuser.md#BKMK_lk_msmrw_3dasset_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_3dasset_createdonbehalfby"></a> lk_msmrw_3dasset_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_3dasset_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_3dasset_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_3dasset_modifiedby"></a> lk_msmrw_3dasset_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_3dasset_modifiedby](systemuser.md#BKMK_lk_msmrw_3dasset_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_3dasset_modifiedonbehalfby"></a> lk_msmrw_3dasset_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_3dasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_3dasset_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold"></a> msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold

One-To-Many Relationship: [msdyn_mrfolder msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold](msdyn_mrfolder.md#BKMK_msdyn_msmrw_3dasset_parentfolderid_msdyn_mrfold)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mrfolder`|
|ReferencedAttribute|`msdyn_mrfolderid`|
|ReferencingAttribute|`msdyn_parentfolderid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentFolderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_assetcollection_msmrw_3dasset"></a> msmrw_assetcollection_msmrw_3dasset

One-To-Many Relationship: [msmrw_assetcollection msmrw_assetcollection_msmrw_3dasset](msmrw_assetcollection.md#BKMK_msmrw_assetcollection_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_assetcollection`|
|ReferencedAttribute|`msmrw_assetcollectionid`|
|ReferencingAttribute|`msmrw_assetcollectionid`|
|ReferencingEntityNavigationPropertyName|`msmrw_assetcollectionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_3dasset"></a> owner_msmrw_3dasset

One-To-Many Relationship: [owner owner_msmrw_3dasset](owner.md#BKMK_owner_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_3dasset"></a> team_msmrw_3dasset

One-To-Many Relationship: [team team_msmrw_3dasset](team.md#BKMK_team_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_3dasset"></a> user_msmrw_3dasset

One-To-Many Relationship: [systemuser user_msmrw_3dasset](systemuser.md#BKMK_user_msmrw_3dasset)

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

- [msmrw_3dasset_Annotations](#BKMK_msmrw_3dasset_Annotations)
- [msmrw_3dasset_AsyncOperations](#BKMK_msmrw_3dasset_AsyncOperations)
- [msmrw_3dasset_BulkDeleteFailures](#BKMK_msmrw_3dasset_BulkDeleteFailures)
- [msmrw_3dasset_DuplicateBaseRecord](#BKMK_msmrw_3dasset_DuplicateBaseRecord)
- [msmrw_3dasset_DuplicateMatchingRecord](#BKMK_msmrw_3dasset_DuplicateMatchingRecord)
- [msmrw_3dasset_FileAttachments](#BKMK_msmrw_3dasset_FileAttachments)
- [msmrw_3dasset_MailboxTrackingFolders](#BKMK_msmrw_3dasset_MailboxTrackingFolders)
- [msmrw_3dasset_msmrw_3dasset_localized](#BKMK_msmrw_3dasset_msmrw_3dasset_localized)
- [msmrw_3dasset_PrincipalObjectAttributeAccesses](#BKMK_msmrw_3dasset_PrincipalObjectAttributeAccesses)
- [msmrw_3dasset_ProcessSession](#BKMK_msmrw_3dasset_ProcessSession)
- [msmrw_3dasset_SyncErrors](#BKMK_msmrw_3dasset_SyncErrors)
- [msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle](#BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle)
- [msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject)
- [msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject)
- [msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject)
- [msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject)

### <a name="BKMK_msmrw_3dasset_Annotations"></a> msmrw_3dasset_Annotations

Many-To-One Relationship: [annotation msmrw_3dasset_Annotations](annotation.md#BKMK_msmrw_3dasset_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_AsyncOperations"></a> msmrw_3dasset_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_3dasset_AsyncOperations](asyncoperation.md#BKMK_msmrw_3dasset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_BulkDeleteFailures"></a> msmrw_3dasset_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_3dasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_3dasset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_DuplicateBaseRecord"></a> msmrw_3dasset_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_3dasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_3dasset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_DuplicateMatchingRecord"></a> msmrw_3dasset_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_3dasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_3dasset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_FileAttachments"></a> msmrw_3dasset_FileAttachments

Many-To-One Relationship: [fileattachment msmrw_3dasset_FileAttachments](fileattachment.md#BKMK_msmrw_3dasset_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_MailboxTrackingFolders"></a> msmrw_3dasset_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_3dasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_3dasset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_msmrw_3dasset_localized"></a> msmrw_3dasset_msmrw_3dasset_localized

Many-To-One Relationship: [msmrw_3dasset_localized msmrw_3dasset_msmrw_3dasset_localized](msmrw_3dasset_localized.md#BKMK_msmrw_3dasset_msmrw_3dasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_3dasset_localized`|
|ReferencingAttribute|`msmrw_parent_3d_assetid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_msmrw_3dasset_localized`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_PrincipalObjectAttributeAccesses"></a> msmrw_3dasset_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_3dasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_3dasset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_ProcessSession"></a> msmrw_3dasset_ProcessSession

Many-To-One Relationship: [processsession msmrw_3dasset_ProcessSession](processsession.md#BKMK_msmrw_3dasset_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_3dasset_SyncErrors"></a> msmrw_3dasset_SyncErrors

Many-To-One Relationship: [syncerror msmrw_3dasset_SyncErrors](syncerror.md#BKMK_msmrw_3dasset_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_3dasset_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle"></a> msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle

Many-To-One Relationship: [msmrw_guide msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle](msmrw_guide.md#BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`msmrw_anchor3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject

Many-To-One Relationship: [msmrw_guidecompletionstepobject msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject](msmrw_guidecompletionstepobject.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobject`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_3dasset_msmrw_guidecompletionstepobject_3DObject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject

Many-To-One Relationship: [msmrw_guidecompletionstepobjectplacement msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject](msmrw_guidecompletionstepobjectplacement.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject

Many-To-One Relationship: [msmrw_guidestepobject msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject](msmrw_guidestepobject.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject

Many-To-One Relationship: [msmrw_guidestepobjectplacement msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject](msmrw_guidestepobjectplacement.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_3dasset_msmrw_guidestepobjectplacement_3DObject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

