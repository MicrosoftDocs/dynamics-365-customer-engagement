---
title: "Attribute Influence Statistics (msdyn_attributeinfluencestatistics) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Attribute Influence Statistics (msdyn_attributeinfluencestatistics) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Attribute Influence Statistics (msdyn_attributeinfluencestatistics) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Attribute Influence Statistics (msdyn_attributeinfluencestatistics) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_attributeinfluencestatisticses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_attributeinfluencestatisticses(*msdyn_attributeinfluencestatisticsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_attributeinfluencestatisticses(*msdyn_attributeinfluencestatisticsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_attributeinfluencestatisticses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_attributeinfluencestatisticses(*msdyn_attributeinfluencestatisticsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_attributeinfluencestatisticses(*msdyn_attributeinfluencestatisticsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_attributeinfluencestatisticses(*msdyn_attributeinfluencestatisticsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Attribute Influence Statistics (msdyn_attributeinfluencestatistics) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Attribute Influence Statistics** |
| **DisplayCollectionName** | **msdyn_attributeinfluencestatistics_set** |
| **SchemaName** | `msdyn_attributeinfluencestatistics` |
| **CollectionSchemaName** | `msdyn_attributeinfluencestatisticses` |
| **EntitySetName** | `msdyn_attributeinfluencestatisticses`|
| **LogicalName** | `msdyn_attributeinfluencestatistics` |
| **LogicalCollectionName** | `msdyn_attributeinfluencestatisticses` |
| **PrimaryIdAttribute** | `msdyn_attributeinfluencestatisticsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attributeinfluencestatisticsId](#BKMK_msdyn_attributeinfluencestatisticsId)
- [msdyn_attributename](#BKMK_msdyn_attributename)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_IgnoreIfBlank](#BKMK_msdyn_IgnoreIfBlank)
- [msdyn_Importance](#BKMK_msdyn_Importance)
- [msdyn_IsCrmAttribute](#BKMK_msdyn_IsCrmAttribute)
- [msdyn_IsRecommended](#BKMK_msdyn_IsRecommended)
- [msdyn_isvalid](#BKMK_msdyn_isvalid)
- [msdyn_modelid](#BKMK_msdyn_modelid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_notselectedreason](#BKMK_msdyn_notselectedreason)
- [msdyn_predictioniD](#BKMK_msdyn_predictioniD)
- [msdyn_statistics](#BKMK_msdyn_statistics)
- [msdyn_submodelid](#BKMK_msdyn_submodelid)
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

### <a name="BKMK_msdyn_attributeinfluencestatisticsId"></a> msdyn_attributeinfluencestatisticsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Attribute Influence Statistics**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributeinfluencestatisticsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_attributename"></a> msdyn_attributename

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attribute Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_IgnoreIfBlank"></a> msdyn_IgnoreIfBlank

|Property|Value|
|---|---|
|Description|**Stores boolean value to tell if blank values of attribute needs to be ignored by ML or not.**|
|DisplayName|**Ignore If Blank**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ignoreifblank`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_msdyn_ignoreifblank`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_Importance"></a> msdyn_Importance

|Property|Value|
|---|---|
|Description|**Stores importance for the attribute calculated using ML.**|
|DisplayName|**Importance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_importance`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_IsCrmAttribute"></a> msdyn_IsCrmAttribute

|Property|Value|
|---|---|
|Description|**Stores boolean value to tell if attribute is crm attribute or some engineered attribute.**|
|DisplayName|**Is Crm Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscrmattribute`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_msdyn_iscrmattribute`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_IsRecommended"></a> msdyn_IsRecommended

|Property|Value|
|---|---|
|Description|**Stores boolean value to tell if attribute is recommended for use by ML algo or not.**|
|DisplayName|**Is Recommended**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isrecommended`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_msdyn_isrecommended`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_isvalid"></a> msdyn_isvalid

|Property|Value|
|---|---|
|Description|**Is Valid**|
|DisplayName|**msdyn_isvalid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvalid`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_msdyn_isvalid`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

### <a name="BKMK_msdyn_modelid"></a> msdyn_modelid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Model Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_notselectedreason"></a> msdyn_notselectedreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Not selected reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_notselectedreason`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_predictioniD"></a> msdyn_predictioniD

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prediction ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_statistics"></a> msdyn_statistics

|Property|Value|
|---|---|
|Description||
|DisplayName|**Statistics**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statistics`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_submodelid"></a> msdyn_submodelid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sub Model Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_submodelid`|
|RequiredLevel|None|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Attribute Influence Statistics**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Attribute Influence Statistics**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_attributeinfluencestatistics_statuscode`|

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

- [lk_msdyn_attributeinfluencestatistics_createdby](#BKMK_lk_msdyn_attributeinfluencestatistics_createdby)
- [lk_msdyn_attributeinfluencestatistics_createdonbehalfby](#BKMK_lk_msdyn_attributeinfluencestatistics_createdonbehalfby)
- [lk_msdyn_attributeinfluencestatistics_modifiedby](#BKMK_lk_msdyn_attributeinfluencestatistics_modifiedby)
- [lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby](#BKMK_lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby)
- [organization_msdyn_attributeinfluencestatistics](#BKMK_organization_msdyn_attributeinfluencestatistics)

### <a name="BKMK_lk_msdyn_attributeinfluencestatistics_createdby"></a> lk_msdyn_attributeinfluencestatistics_createdby

One-To-Many Relationship: [systemuser lk_msdyn_attributeinfluencestatistics_createdby](systemuser.md#BKMK_lk_msdyn_attributeinfluencestatistics_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_attributeinfluencestatistics_createdonbehalfby"></a> lk_msdyn_attributeinfluencestatistics_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_attributeinfluencestatistics_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_attributeinfluencestatistics_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_attributeinfluencestatistics_modifiedby"></a> lk_msdyn_attributeinfluencestatistics_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_attributeinfluencestatistics_modifiedby](systemuser.md#BKMK_lk_msdyn_attributeinfluencestatistics_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby"></a> lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_attributeinfluencestatistics_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_attributeinfluencestatistics"></a> organization_msdyn_attributeinfluencestatistics

One-To-Many Relationship: [organization organization_msdyn_attributeinfluencestatistics](organization.md#BKMK_organization_msdyn_attributeinfluencestatistics)

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

- [msdyn_attributeinfluencestatistics_AsyncOperations](#BKMK_msdyn_attributeinfluencestatistics_AsyncOperations)
- [msdyn_attributeinfluencestatistics_BulkDeleteFailures](#BKMK_msdyn_attributeinfluencestatistics_BulkDeleteFailures)
- [msdyn_attributeinfluencestatistics_DuplicateBaseRecord](#BKMK_msdyn_attributeinfluencestatistics_DuplicateBaseRecord)
- [msdyn_attributeinfluencestatistics_DuplicateMatchingRecord](#BKMK_msdyn_attributeinfluencestatistics_DuplicateMatchingRecord)
- [msdyn_attributeinfluencestatistics_MailboxTrackingFolders](#BKMK_msdyn_attributeinfluencestatistics_MailboxTrackingFolders)
- [msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses](#BKMK_msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses)
- [msdyn_attributeinfluencestatistics_ProcessSession](#BKMK_msdyn_attributeinfluencestatistics_ProcessSession)
- [msdyn_attributeinfluencestatistics_SyncErrors](#BKMK_msdyn_attributeinfluencestatistics_SyncErrors)

### <a name="BKMK_msdyn_attributeinfluencestatistics_AsyncOperations"></a> msdyn_attributeinfluencestatistics_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_attributeinfluencestatistics_AsyncOperations](asyncoperation.md#BKMK_msdyn_attributeinfluencestatistics_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_BulkDeleteFailures"></a> msdyn_attributeinfluencestatistics_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_attributeinfluencestatistics_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_attributeinfluencestatistics_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_DuplicateBaseRecord"></a> msdyn_attributeinfluencestatistics_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_attributeinfluencestatistics_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_attributeinfluencestatistics_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_DuplicateMatchingRecord"></a> msdyn_attributeinfluencestatistics_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_attributeinfluencestatistics_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_attributeinfluencestatistics_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_MailboxTrackingFolders"></a> msdyn_attributeinfluencestatistics_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_attributeinfluencestatistics_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_attributeinfluencestatistics_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses"></a> msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_ProcessSession"></a> msdyn_attributeinfluencestatistics_ProcessSession

Many-To-One Relationship: [processsession msdyn_attributeinfluencestatistics_ProcessSession](processsession.md#BKMK_msdyn_attributeinfluencestatistics_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_attributeinfluencestatistics_SyncErrors"></a> msdyn_attributeinfluencestatistics_SyncErrors

Many-To-One Relationship: [syncerror msdyn_attributeinfluencestatistics_SyncErrors](syncerror.md#BKMK_msdyn_attributeinfluencestatistics_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_attributeinfluencestatistics_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

