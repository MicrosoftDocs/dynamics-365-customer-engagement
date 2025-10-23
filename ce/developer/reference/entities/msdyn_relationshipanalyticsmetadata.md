---
title: "Relationship Analytics Metadata (msdyn_relationshipanalyticsmetadata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Relationship Analytics Metadata (msdyn_relationshipanalyticsmetadata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Relationship Analytics Metadata (msdyn_relationshipanalyticsmetadata) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Relationship Analytics Metadata (msdyn_relationshipanalyticsmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_relationshipanalyticsmetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_relationshipanalyticsmetadatas(*msdyn_relationshipanalyticsmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_relationshipanalyticsmetadatas(*msdyn_relationshipanalyticsmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_relationshipanalyticsmetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_relationshipanalyticsmetadatas(*msdyn_relationshipanalyticsmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_relationshipanalyticsmetadatas(*msdyn_relationshipanalyticsmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_relationshipanalyticsmetadatas(*msdyn_relationshipanalyticsmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Relationship Analytics Metadata (msdyn_relationshipanalyticsmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Relationship Analytics Metadata** |
| **DisplayCollectionName** | **Relationship Analytics Metadatas** |
| **SchemaName** | `msdyn_relationshipanalyticsmetadata` |
| **CollectionSchemaName** | `msdyn_relationshipanalyticsmetadatas` |
| **EntitySetName** | `msdyn_relationshipanalyticsmetadatas`|
| **LogicalName** | `msdyn_relationshipanalyticsmetadata` |
| **LogicalCollectionName** | `msdyn_relationshipanalyticsmetadatas` |
| **PrimaryIdAttribute** | `msdyn_relationshipanalyticsmetadataid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_absoluteEmailWeight](#BKMK_msdyn_absoluteEmailWeight)
- [msdyn_absoluteMeetingWeight](#BKMK_msdyn_absoluteMeetingWeight)
- [msdyn_absolutePhonecallWeight](#BKMK_msdyn_absolutePhonecallWeight)
- [msdyn_absoluteTaskWeight](#BKMK_msdyn_absoluteTaskWeight)
- [msdyn_communicationFrequency](#BKMK_msdyn_communicationFrequency)
- [msdyn_fairHealthThreshold](#BKMK_msdyn_fairHealthThreshold)
- [msdyn_goodHealthThreshold](#BKMK_msdyn_goodHealthThreshold)
- [msdyn_healthEnabled](#BKMK_msdyn_healthEnabled)
- [msdyn_healthScoresDistribution](#BKMK_msdyn_healthScoresDistribution)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_provisioningStatus](#BKMK_msdyn_provisioningStatus)
- [msdyn_relationshipanalyticsmetadataId](#BKMK_msdyn_relationshipanalyticsmetadataId)
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

### <a name="BKMK_msdyn_absoluteEmailWeight"></a> msdyn_absoluteEmailWeight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Absolute Email Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_absoluteemailweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_absoluteMeetingWeight"></a> msdyn_absoluteMeetingWeight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Absolute Meeting Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_absolutemeetingweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_absolutePhonecallWeight"></a> msdyn_absolutePhonecallWeight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Absolute Phonecall Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_absolutephonecallweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_absoluteTaskWeight"></a> msdyn_absoluteTaskWeight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Absolute Task Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_absolutetaskweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_communicationFrequency"></a> msdyn_communicationFrequency

|Property|Value|
|---|---|
|Description||
|DisplayName|**Communication Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationfrequency`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msdyn_relationshipanalyticsmetadata_msdyn_communicationfrequency`|

#### msdyn_communicationFrequency Choices/Options

|Value|Label|
|---|---|
|100000001|**Daily**|
|100000002|**FewDays**|
|100000003|**Weekly**|
|100000004|**FewWeeks**|
|100000005|**Monthly**|

### <a name="BKMK_msdyn_fairHealthThreshold"></a> msdyn_fairHealthThreshold

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fair Health Threshold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fairhealththreshold`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_goodHealthThreshold"></a> msdyn_goodHealthThreshold

|Property|Value|
|---|---|
|Description||
|DisplayName|**Good Health Threshold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_goodhealththreshold`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_healthEnabled"></a> msdyn_healthEnabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Health Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_healthenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_relationshipanalyticsmetadata_msdyn_healthenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_healthScoresDistribution"></a> msdyn_healthScoresDistribution

|Property|Value|
|---|---|
|Description||
|DisplayName|**Health Scores Distribution**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_healthscoresdistribution`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_provisioningStatus"></a> msdyn_provisioningStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Provisioning Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisioningstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msdyn_relationshipanalyticsmetadata_msdyn_provisioningstatus`|

#### msdyn_provisioningStatus Choices/Options

|Value|Label|
|---|---|
|100000001|**None**|
|100000002|**Activation InProgress**|
|100000003|**Activation Completed**|
|100000004|**Activation Failed**|
|100000005|**Deactivation InProgress**|
|100000006|**Deactivation Completed**|
|100000007|**Deactivation Failed**|

### <a name="BKMK_msdyn_relationshipanalyticsmetadataId"></a> msdyn_relationshipanalyticsmetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Relationship Analytics Metadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshipanalyticsmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Relationship Analytics Metadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_relationshipanalyticsmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Relationship Analytics Metadata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_relationshipanalyticsmetadata_statuscode`|

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

- [lk_msdyn_relationshipanalyticsmetadata_createdby](#BKMK_lk_msdyn_relationshipanalyticsmetadata_createdby)
- [lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby](#BKMK_lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby)
- [lk_msdyn_relationshipanalyticsmetadata_modifiedby](#BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedby)
- [lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby](#BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby)
- [organization_msdyn_relationshipanalyticsmetadata](#BKMK_organization_msdyn_relationshipanalyticsmetadata)

### <a name="BKMK_lk_msdyn_relationshipanalyticsmetadata_createdby"></a> lk_msdyn_relationshipanalyticsmetadata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_relationshipanalyticsmetadata_createdby](systemuser.md#BKMK_lk_msdyn_relationshipanalyticsmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby"></a> lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_relationshipanalyticsmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedby"></a> lk_msdyn_relationshipanalyticsmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_relationshipanalyticsmetadata_modifiedby](systemuser.md#BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby"></a> lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_relationshipanalyticsmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_relationshipanalyticsmetadata"></a> organization_msdyn_relationshipanalyticsmetadata

One-To-Many Relationship: [organization organization_msdyn_relationshipanalyticsmetadata](organization.md#BKMK_organization_msdyn_relationshipanalyticsmetadata)

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

- [msdyn_relationshipanalyticsmetadata_AsyncOperations](#BKMK_msdyn_relationshipanalyticsmetadata_AsyncOperations)
- [msdyn_relationshipanalyticsmetadata_BulkDeleteFailures](#BKMK_msdyn_relationshipanalyticsmetadata_BulkDeleteFailures)
- [msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders](#BKMK_msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders)
- [msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_relationshipanalyticsmetadata_ProcessSession](#BKMK_msdyn_relationshipanalyticsmetadata_ProcessSession)
- [msdyn_relationshipanalyticsmetadata_SyncErrors](#BKMK_msdyn_relationshipanalyticsmetadata_SyncErrors)

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_AsyncOperations"></a> msdyn_relationshipanalyticsmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_relationshipanalyticsmetadata_AsyncOperations](asyncoperation.md#BKMK_msdyn_relationshipanalyticsmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_BulkDeleteFailures"></a> msdyn_relationshipanalyticsmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_relationshipanalyticsmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_relationshipanalyticsmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders"></a> msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_ProcessSession"></a> msdyn_relationshipanalyticsmetadata_ProcessSession

Many-To-One Relationship: [processsession msdyn_relationshipanalyticsmetadata_ProcessSession](processsession.md#BKMK_msdyn_relationshipanalyticsmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relationshipanalyticsmetadata_SyncErrors"></a> msdyn_relationshipanalyticsmetadata_SyncErrors

Many-To-One Relationship: [syncerror msdyn_relationshipanalyticsmetadata_SyncErrors](syncerror.md#BKMK_msdyn_relationshipanalyticsmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_relationshipanalyticsmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

