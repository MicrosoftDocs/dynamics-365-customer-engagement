---
title: "ODOSFeatureMetadata (msdyn_odosfeaturemetadata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the ODOSFeatureMetadata (msdyn_odosfeaturemetadata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# ODOSFeatureMetadata (msdyn_odosfeaturemetadata) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the ODOSFeatureMetadata (msdyn_odosfeaturemetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_odosfeaturemetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_odosfeaturemetadatas(*msdyn_odosfeaturemetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_odosfeaturemetadatas(*msdyn_odosfeaturemetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_odosfeaturemetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_odosfeaturemetadatas(*msdyn_odosfeaturemetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_odosfeaturemetadatas(*msdyn_odosfeaturemetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_odosfeaturemetadatas(*msdyn_odosfeaturemetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the ODOSFeatureMetadata (msdyn_odosfeaturemetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **ODOSFeatureMetadata** |
| **DisplayCollectionName** | **ODOSFeatureMetadata** |
| **SchemaName** | `msdyn_odosfeaturemetadata` |
| **CollectionSchemaName** | `msdyn_odosfeaturemetadatas` |
| **EntitySetName** | `msdyn_odosfeaturemetadatas`|
| **LogicalName** | `msdyn_odosfeaturemetadata` |
| **LogicalCollectionName** | `msdyn_odosfeaturemetadatas` |
| **PrimaryIdAttribute** | `msdyn_odosfeaturemetadataid` |
| **PrimaryNameAttribute** |`msdyn_featurename` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_clientid](#BKMK_msdyn_clientid)
- [msdyn_consentrevokedtime](#BKMK_msdyn_consentrevokedtime)
- [msdyn_entities](#BKMK_msdyn_entities)
- [msdyn_featurename](#BKMK_msdyn_featurename)
- [msdyn_isconsentrevoked](#BKMK_msdyn_isconsentrevoked)
- [msdyn_isfeatureenabled](#BKMK_msdyn_isfeatureenabled)
- [msdyn_lastbackfillrunexecutionId](#BKMK_msdyn_lastbackfillrunexecutionId)
- [msdyn_lastrunexecutionid](#BKMK_msdyn_lastrunexecutionid)
- [msdyn_odosfeaturemetadataId](#BKMK_msdyn_odosfeaturemetadataId)
- [msdyn_primitives](#BKMK_msdyn_primitives)
- [msdyn_propertybag](#BKMK_msdyn_propertybag)
- [msdyn_provisioningexception](#BKMK_msdyn_provisioningexception)
- [msdyn_provisioningstage](#BKMK_msdyn_provisioningstage)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_clientid"></a> msdyn_clientid

|Property|Value|
|---|---|
|Description||
|DisplayName|**ODOS Client Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clientid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_consentrevokedtime"></a> msdyn_consentrevokedtime

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConsentRevokedTime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consentrevokedtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_entities"></a> msdyn_entities

|Property|Value|
|---|---|
|Description||
|DisplayName|**entities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entities`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_featurename"></a> msdyn_featurename

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**FeatureName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_featurename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_isconsentrevoked"></a> msdyn_isconsentrevoked

|Property|Value|
|---|---|
|Description||
|DisplayName|**IsConsentRevoked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isconsentrevoked`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_odosfeaturemetadata_msdyn_isconsentrevoked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isfeatureenabled"></a> msdyn_isfeatureenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Feature provisioned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfeatureenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_odosfeaturemetadata_msdyn_isfeatureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lastbackfillrunexecutionId"></a> msdyn_lastbackfillrunexecutionId

|Property|Value|
|---|---|
|Description||
|DisplayName|**lastBackFillRunExecutionId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastbackfillrunexecutionId`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastrunexecutionid"></a> msdyn_lastrunexecutionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**LastRunExecutionId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastrunexecutionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_odosfeaturemetadataId"></a> msdyn_odosfeaturemetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ODOSFeatureMetadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_odosfeaturemetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_primitives"></a> msdyn_primitives

|Property|Value|
|---|---|
|Description||
|DisplayName|**primitives**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primitives`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_propertybag"></a> msdyn_propertybag

|Property|Value|
|---|---|
|Description||
|DisplayName|**propertyBag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_propertybag`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_provisioningexception"></a> msdyn_provisioningexception

|Property|Value|
|---|---|
|Description||
|DisplayName|**provisioningException**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisioningexception`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_provisioningstage"></a> msdyn_provisioningstage

|Property|Value|
|---|---|
|Description||
|DisplayName|**ProvisioningStage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisioningstage`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|-1|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the ODOSFeatureMetadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_odosfeaturemetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ODOSFeatureMetadata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_odosfeaturemetadata_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_odosfeaturemetadata_createdby](#BKMK_lk_msdyn_odosfeaturemetadata_createdby)
- [lk_msdyn_odosfeaturemetadata_createdonbehalfby](#BKMK_lk_msdyn_odosfeaturemetadata_createdonbehalfby)
- [lk_msdyn_odosfeaturemetadata_modifiedby](#BKMK_lk_msdyn_odosfeaturemetadata_modifiedby)
- [lk_msdyn_odosfeaturemetadata_modifiedonbehalfby](#BKMK_lk_msdyn_odosfeaturemetadata_modifiedonbehalfby)
- [organization_msdyn_odosfeaturemetadata](#BKMK_organization_msdyn_odosfeaturemetadata)

### <a name="BKMK_lk_msdyn_odosfeaturemetadata_createdby"></a> lk_msdyn_odosfeaturemetadata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_odosfeaturemetadata_createdby](systemuser.md#BKMK_lk_msdyn_odosfeaturemetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_odosfeaturemetadata_createdonbehalfby"></a> lk_msdyn_odosfeaturemetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_odosfeaturemetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_odosfeaturemetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_odosfeaturemetadata_modifiedby"></a> lk_msdyn_odosfeaturemetadata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_odosfeaturemetadata_modifiedby](systemuser.md#BKMK_lk_msdyn_odosfeaturemetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_odosfeaturemetadata_modifiedonbehalfby"></a> lk_msdyn_odosfeaturemetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_odosfeaturemetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_odosfeaturemetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_odosfeaturemetadata"></a> organization_msdyn_odosfeaturemetadata

One-To-Many Relationship: [organization organization_msdyn_odosfeaturemetadata](organization.md#BKMK_organization_msdyn_odosfeaturemetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_odosfeaturemetadata_AsyncOperations](#BKMK_msdyn_odosfeaturemetadata_AsyncOperations)
- [msdyn_odosfeaturemetadata_BulkDeleteFailures](#BKMK_msdyn_odosfeaturemetadata_BulkDeleteFailures)
- [msdyn_odosfeaturemetadata_MailboxTrackingFolders](#BKMK_msdyn_odosfeaturemetadata_MailboxTrackingFolders)
- [msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses)
- [msdyn_odosfeaturemetadata_ProcessSession](#BKMK_msdyn_odosfeaturemetadata_ProcessSession)
- [msdyn_odosfeaturemetadata_SyncErrors](#BKMK_msdyn_odosfeaturemetadata_SyncErrors)

### <a name="BKMK_msdyn_odosfeaturemetadata_AsyncOperations"></a> msdyn_odosfeaturemetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_odosfeaturemetadata_AsyncOperations](asyncoperation.md#BKMK_msdyn_odosfeaturemetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_odosfeaturemetadata_BulkDeleteFailures"></a> msdyn_odosfeaturemetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_odosfeaturemetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_odosfeaturemetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_odosfeaturemetadata_MailboxTrackingFolders"></a> msdyn_odosfeaturemetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_odosfeaturemetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_odosfeaturemetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses"></a> msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_odosfeaturemetadata_ProcessSession"></a> msdyn_odosfeaturemetadata_ProcessSession

Many-To-One Relationship: [processsession msdyn_odosfeaturemetadata_ProcessSession](processsession.md#BKMK_msdyn_odosfeaturemetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_odosfeaturemetadata_SyncErrors"></a> msdyn_odosfeaturemetadata_SyncErrors

Many-To-One Relationship: [syncerror msdyn_odosfeaturemetadata_SyncErrors](syncerror.md#BKMK_msdyn_odosfeaturemetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_odosfeaturemetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

