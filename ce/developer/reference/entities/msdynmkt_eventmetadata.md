---
title: "Trigger (msdynmkt_eventmetadata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Trigger (msdynmkt_eventmetadata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Trigger (msdynmkt_eventmetadata) table/entity reference (Microsoft Dynamics 365)

Metadata for Cxp Events

## Messages

The following table lists the messages for the Trigger (msdynmkt_eventmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_eventmetadataset<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_eventmetadataset<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_eventmetadataset(*msdynmkt_eventmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Trigger (msdynmkt_eventmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Trigger** |
| **DisplayCollectionName** | **Triggers** |
| **SchemaName** | `msdynmkt_eventmetadata` |
| **CollectionSchemaName** | `msdynmkt_eventmetadatas` |
| **EntitySetName** | `msdynmkt_eventmetadataset`|
| **LogicalName** | `msdynmkt_eventmetadata` |
| **LogicalCollectionName** | `msdynmkt_eventmetadatas` |
| **PrimaryIdAttribute** | `msdynmkt_eventmetadataid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_cdpaexportlocation](#BKMK_msdynmkt_cdpaexportlocation)
- [msdynmkt_customapiid](#BKMK_msdynmkt_customapiid)
- [msdynmkt_cxpversioningjson](#BKMK_msdynmkt_cxpversioningjson)
- [msdynmkt_eventjson](#BKMK_msdynmkt_eventjson)
- [msdynmkt_eventmetadataId](#BKMK_msdynmkt_eventmetadataId)
- [msdynmkt_eventmetadatastatus](#BKMK_msdynmkt_eventmetadatastatus)
- [msdynmkt_integrationstatus](#BKMK_msdynmkt_integrationstatus)
- [msdynmkt_integrationstatuscomputedon](#BKMK_msdynmkt_integrationstatuscomputedon)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_sourceentity](#BKMK_msdynmkt_sourceentity)
- [msdynmkt_state](#BKMK_msdynmkt_state)
- [msdynmkt_supportedtargetentities](#BKMK_msdynmkt_supportedtargetentities)
- [msdynmkt_uniquename](#BKMK_msdynmkt_uniquename)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdynmkt_cdpaexportlocation"></a> msdynmkt_cdpaexportlocation

|Property|Value|
|---|---|
|Description|**Location of the CDPA export registered for this event.**|
|DisplayName|**Cdpa Export Location**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cdpaexportlocation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_customapiid"></a> msdynmkt_customapiid

|Property|Value|
|---|---|
|Description|**Unique identifier for Custom API associated with EventMetadata.**|
|DisplayName|**Custom Api Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customapiid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|customapi|

### <a name="BKMK_msdynmkt_cxpversioningjson"></a> msdynmkt_cxpversioningjson

|Property|Value|
|---|---|
|Description|**Tracks code versions used by CXP to handle event metadata lifecycle.**|
|DisplayName|**CXP Versioning JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cxpversioningjson`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_eventjson"></a> msdynmkt_eventjson

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventjson`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_eventmetadataId"></a> msdynmkt_eventmetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**EventMetadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_eventmetadatastatus"></a> msdynmkt_eventmetadatastatus

|Property|Value|
|---|---|
|Description|**Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventmetadatastatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_eventmetadatastatus`|

#### msdynmkt_eventmetadatastatus Choices/Options

|Value|Label|
|---|---|
|534120000|**Draft**|
|534120001|**Published**|
|534120002|**Stopped**|

### <a name="BKMK_msdynmkt_integrationstatus"></a> msdynmkt_integrationstatus

|Property|Value|
|---|---|
|Description|**Integration Status**|
|DisplayName|**Integration Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_integrationstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_eventmetadataintegrationstatus`|

#### msdynmkt_integrationstatus Choices/Options

|Value|Label|
|---|---|
|534120000|**Unknown**|
|534120001|**Integrated**|
|534120002|**NotIntegrated**|

### <a name="BKMK_msdynmkt_integrationstatuscomputedon"></a> msdynmkt_integrationstatuscomputedon

|Property|Value|
|---|---|
|Description|**Date and time when the integration status was last computed.**|
|DisplayName|**Integration Status Computed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastintegrationstatuscomputedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourceentity"></a> msdynmkt_sourceentity

|Property|Value|
|---|---|
|Description|**Source entity logical name**|
|DisplayName|**Source Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdynmkt_state"></a> msdynmkt_state

|Property|Value|
|---|---|
|Description|**State**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_state`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_eventmetadatastate`|

#### msdynmkt_state Choices/Options

|Value|Label|
|---|---|
|534120000|**Draft**|
|534120001|**Getting ready**|
|534120002|**Ready to use**|
|534120003|**Stopping**|
|534120004|**Stopped**|
|534120005|**Deleting**|
|534120006|**Deleted**|
|534120007|**Restarting**|
|534120008|**Resetting**|

### <a name="BKMK_msdynmkt_supportedtargetentities"></a> msdynmkt_supportedtargetentities

|Property|Value|
|---|---|
|Description|**Supported list of the entities that can be associated with the Target Id.**|
|DisplayName|**Supported Target Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_supportedtargetentities`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_uniquename"></a> msdynmkt_uniquename

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uniquename`|
|RequiredLevel|SystemRequired|
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
|Description|**Status of the EventMetadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_eventmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the EventMetadata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_eventmetadata_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdynmkt_cataloguniquename](#BKMK_msdynmkt_cataloguniquename)
- [msdynmkt_iconpath](#BKMK_msdynmkt_iconpath)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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
|DisplayName|**Created on**|
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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_msdynmkt_cataloguniquename"></a> msdynmkt_cataloguniquename

|Property|Value|
|---|---|
|Description|**Unique name of the catalog for this event.**|
|DisplayName|**Catalog Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cataloguniquename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdynmkt_iconpath"></a> msdynmkt_iconpath

|Property|Value|
|---|---|
|Description|**Name of the icon to display for the event.**|
|DisplayName|**IconPath**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_iconpath`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|DisplayName|**Business Unit**|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
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

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdynmkt_eventmetadata](#BKMK_business_unit_msdynmkt_eventmetadata)
- [lk_msdynmkt_eventmetadata_createdby](#BKMK_lk_msdynmkt_eventmetadata_createdby)
- [lk_msdynmkt_eventmetadata_createdonbehalfby](#BKMK_lk_msdynmkt_eventmetadata_createdonbehalfby)
- [lk_msdynmkt_eventmetadata_modifiedby](#BKMK_lk_msdynmkt_eventmetadata_modifiedby)
- [lk_msdynmkt_eventmetadata_modifiedonbehalfby](#BKMK_lk_msdynmkt_eventmetadata_modifiedonbehalfby)
- [msdynmkt_customapi_eventmetadata](#BKMK_msdynmkt_customapi_eventmetadata)
- [owner_msdynmkt_eventmetadata](#BKMK_owner_msdynmkt_eventmetadata)
- [team_msdynmkt_eventmetadata](#BKMK_team_msdynmkt_eventmetadata)
- [user_msdynmkt_eventmetadata](#BKMK_user_msdynmkt_eventmetadata)

### <a name="BKMK_business_unit_msdynmkt_eventmetadata"></a> business_unit_msdynmkt_eventmetadata

One-To-Many Relationship: [businessunit business_unit_msdynmkt_eventmetadata](businessunit.md#BKMK_business_unit_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_createdby"></a> lk_msdynmkt_eventmetadata_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_createdby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_createdonbehalfby"></a> lk_msdynmkt_eventmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_modifiedby"></a> lk_msdynmkt_eventmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_modifiedby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_eventmetadata_modifiedonbehalfby"></a> lk_msdynmkt_eventmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_eventmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_eventmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_customapi_eventmetadata"></a> msdynmkt_customapi_eventmetadata

One-To-Many Relationship: [customapi msdynmkt_customapi_eventmetadata](customapi.md#BKMK_msdynmkt_customapi_eventmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`customapi`|
|ReferencedAttribute|`customapiid`|
|ReferencingAttribute|`msdynmkt_customapiid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_customapiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_eventmetadata"></a> owner_msdynmkt_eventmetadata

One-To-Many Relationship: [owner owner_msdynmkt_eventmetadata](owner.md#BKMK_owner_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_eventmetadata"></a> team_msdynmkt_eventmetadata

One-To-Many Relationship: [team team_msdynmkt_eventmetadata](team.md#BKMK_team_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_eventmetadata"></a> user_msdynmkt_eventmetadata

One-To-Many Relationship: [systemuser user_msdynmkt_eventmetadata](systemuser.md#BKMK_user_msdynmkt_eventmetadata)

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

- [msdynmkt_eventmetadata_AsyncOperations](#BKMK_msdynmkt_eventmetadata_AsyncOperations)
- [msdynmkt_eventmetadata_BulkDeleteFailures](#BKMK_msdynmkt_eventmetadata_BulkDeleteFailures)
- [msdynmkt_eventmetadata_DuplicateBaseRecord](#BKMK_msdynmkt_eventmetadata_DuplicateBaseRecord)
- [msdynmkt_eventmetadata_DuplicateMatchingRecord](#BKMK_msdynmkt_eventmetadata_DuplicateMatchingRecord)
- [msdynmkt_eventmetadata_eventmetadata_sdkmessagepro](#BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro)
- [msdynmkt_eventmetadata_MailboxTrackingFolders](#BKMK_msdynmkt_eventmetadata_MailboxTrackingFolders)
- [msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses)
- [msdynmkt_eventmetadata_ProcessSession](#BKMK_msdynmkt_eventmetadata_ProcessSession)
- [msdynmkt_eventmetadata_SyncErrors](#BKMK_msdynmkt_eventmetadata_SyncErrors)

### <a name="BKMK_msdynmkt_eventmetadata_AsyncOperations"></a> msdynmkt_eventmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_eventmetadata_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_eventmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_BulkDeleteFailures"></a> msdynmkt_eventmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_eventmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_eventmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_DuplicateBaseRecord"></a> msdynmkt_eventmetadata_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_eventmetadata_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_eventmetadata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_DuplicateMatchingRecord"></a> msdynmkt_eventmetadata_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_eventmetadata_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_eventmetadata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro"></a> msdynmkt_eventmetadata_eventmetadata_sdkmessagepro

Many-To-One Relationship: [msdynmkt_eventmetadata_sdkmessageprocessingstep msdynmkt_eventmetadata_eventmetadata_sdkmessagepro](msdynmkt_eventmetadata_sdkmessageprocessingstep.md#BKMK_msdynmkt_eventmetadata_eventmetadata_sdkmessagepro)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata_sdkmessageprocessingstep`|
|ReferencingAttribute|`msdynmkt_eventmetadataid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_eventmetadata_sdkmessagepro`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_MailboxTrackingFolders"></a> msdynmkt_eventmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_eventmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_eventmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses"></a> msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_ProcessSession"></a> msdynmkt_eventmetadata_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_eventmetadata_ProcessSession](processsession.md#BKMK_msdynmkt_eventmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_eventmetadata_SyncErrors"></a> msdynmkt_eventmetadata_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_eventmetadata_SyncErrors](syncerror.md#BKMK_msdynmkt_eventmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_eventmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

