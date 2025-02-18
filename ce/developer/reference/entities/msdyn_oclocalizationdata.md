---
title: "Localization (msdyn_oclocalizationdata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Localization (msdyn_oclocalizationdata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Localization (msdyn_oclocalizationdata) table/entity reference (Microsoft Dynamics 365)

Entity used for data localization on CRM org.

## Messages

The following table lists the messages for the Localization (msdyn_oclocalizationdata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_oclocalizationdatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_oclocalizationdatas(*msdyn_oclocalizationdataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_oclocalizationdatas(*msdyn_oclocalizationdataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_oclocalizationdatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_oclocalizationdatas(*msdyn_oclocalizationdataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_oclocalizationdatas(*msdyn_oclocalizationdataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_oclocalizationdatas(*msdyn_oclocalizationdataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Localization (msdyn_oclocalizationdata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Localization** |
| **DisplayCollectionName** | **Localizations** |
| **SchemaName** | `msdyn_oclocalizationdata` |
| **CollectionSchemaName** | `msdyn_oclocalizationdatas` |
| **EntitySetName** | `msdyn_oclocalizationdatas`|
| **LogicalName** | `msdyn_oclocalizationdata` |
| **LogicalCollectionName** | `msdyn_oclocalizationdatas` |
| **PrimaryIdAttribute** | `msdyn_oclocalizationdataid` |
| **PrimaryNameAttribute** |`msdyn_localizedtext` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerlanguageid](#BKMK_msdyn_customerlanguageid)
- [msdyn_DefaultLocalizedText](#BKMK_msdyn_DefaultLocalizedText)
- [msdyn_EntityColumnName](#BKMK_msdyn_EntityColumnName)
- [msdyn_EntityName](#BKMK_msdyn_EntityName)
- [msdyn_EntityRecordId](#BKMK_msdyn_EntityRecordId)
- [msdyn_Isdefault](#BKMK_msdyn_Isdefault)
- [msdyn_LanguageCode](#BKMK_msdyn_LanguageCode)
- [msdyn_localizedtext](#BKMK_msdyn_localizedtext)
- [msdyn_oclocalizationdataId](#BKMK_msdyn_oclocalizationdataId)
- [msdyn_systemmessageid](#BKMK_msdyn_systemmessageid)
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

### <a name="BKMK_msdyn_customerlanguageid"></a> msdyn_customerlanguageid

|Property|Value|
|---|---|
|Description|**Unique identifier for Channel Language associated with Localization Data.**|
|DisplayName|**Language code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerlanguageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_DefaultLocalizedText"></a> msdyn_DefaultLocalizedText

|Property|Value|
|---|---|
|Description|**Default Localized Text**|
|DisplayName|**Default Localized Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultlocalizedtext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_EntityColumnName"></a> msdyn_EntityColumnName

|Property|Value|
|---|---|
|Description|**The column name of the original entity to be localized.**|
|DisplayName|**Entity Column Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitycolumnname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EntityName"></a> msdyn_EntityName

|Property|Value|
|---|---|
|Description|**The name of the original entity to be localized.**|
|DisplayName|**Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EntityRecordId"></a> msdyn_EntityRecordId

|Property|Value|
|---|---|
|Description|**The record id of the original entity.**|
|DisplayName|**Entity Record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Isdefault"></a> msdyn_Isdefault

|Property|Value|
|---|---|
|Description|**Indicates if the localization data record is the default record for message template.**|
|DisplayName|**Is default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_oclocalizationdata_msdyn_isdefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LanguageCode"></a> msdyn_LanguageCode

|Property|Value|
|---|---|
|Description|**The target language code for the record to be localized in.**|
|DisplayName|**Language Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_languagecode`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|100000|
|MinValue|0|

### <a name="BKMK_msdyn_localizedtext"></a> msdyn_localizedtext

|Property|Value|
|---|---|
|Description|**Localized text of the original record.**|
|DisplayName|**Localized text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_localizedtext`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_oclocalizationdataId"></a> msdyn_oclocalizationdataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Localization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_oclocalizationdataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_systemmessageid"></a> msdyn_systemmessageid

|Property|Value|
|---|---|
|Description|**Unique identifier for System Message associated with Localization Data.**|
|DisplayName|**Automated message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemmessageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsystemmessage|

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
|Description|**Status of the Localization Data**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_oclocalizationdata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Localization Data**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_oclocalizationdata_statuscode`|

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

- [lk_msdyn_oclocalizationdata_createdby](#BKMK_lk_msdyn_oclocalizationdata_createdby)
- [lk_msdyn_oclocalizationdata_createdonbehalfby](#BKMK_lk_msdyn_oclocalizationdata_createdonbehalfby)
- [lk_msdyn_oclocalizationdata_modifiedby](#BKMK_lk_msdyn_oclocalizationdata_modifiedby)
- [lk_msdyn_oclocalizationdata_modifiedonbehalfby](#BKMK_lk_msdyn_oclocalizationdata_modifiedonbehalfby)
- [msdyn_oclanguage_msdyn_oclocalizationdata](#BKMK_msdyn_oclanguage_msdyn_oclocalizationdata)
- [msdyn_ocsystemmessage_msdyn_oclocalizationdata](#BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata)
- [organization_msdyn_oclocalizationdata](#BKMK_organization_msdyn_oclocalizationdata)

### <a name="BKMK_lk_msdyn_oclocalizationdata_createdby"></a> lk_msdyn_oclocalizationdata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_oclocalizationdata_createdby](systemuser.md#BKMK_lk_msdyn_oclocalizationdata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_oclocalizationdata_createdonbehalfby"></a> lk_msdyn_oclocalizationdata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_oclocalizationdata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_oclocalizationdata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_oclocalizationdata_modifiedby"></a> lk_msdyn_oclocalizationdata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_oclocalizationdata_modifiedby](systemuser.md#BKMK_lk_msdyn_oclocalizationdata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_oclocalizationdata_modifiedonbehalfby"></a> lk_msdyn_oclocalizationdata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_oclocalizationdata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_oclocalizationdata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclanguage_msdyn_oclocalizationdata"></a> msdyn_oclanguage_msdyn_oclocalizationdata

One-To-Many Relationship: [msdyn_oclanguage msdyn_oclanguage_msdyn_oclocalizationdata](msdyn_oclanguage.md#BKMK_msdyn_oclanguage_msdyn_oclocalizationdata)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_customerlanguageid`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerlanguageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata"></a> msdyn_ocsystemmessage_msdyn_oclocalizationdata

One-To-Many Relationship: [msdyn_ocsystemmessage msdyn_ocsystemmessage_msdyn_oclocalizationdata](msdyn_ocsystemmessage.md#BKMK_msdyn_ocsystemmessage_msdyn_oclocalizationdata)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsystemmessage`|
|ReferencedAttribute|`msdyn_ocsystemmessageid`|
|ReferencingAttribute|`msdyn_systemmessageid`|
|ReferencingEntityNavigationPropertyName|`msdyn_systemmessageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_oclocalizationdata"></a> organization_msdyn_oclocalizationdata

One-To-Many Relationship: [organization organization_msdyn_oclocalizationdata](organization.md#BKMK_organization_msdyn_oclocalizationdata)

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

- [msdyn_oclocalizationdata_AsyncOperations](#BKMK_msdyn_oclocalizationdata_AsyncOperations)
- [msdyn_oclocalizationdata_BulkDeleteFailures](#BKMK_msdyn_oclocalizationdata_BulkDeleteFailures)
- [msdyn_oclocalizationdata_DuplicateBaseRecord](#BKMK_msdyn_oclocalizationdata_DuplicateBaseRecord)
- [msdyn_oclocalizationdata_DuplicateMatchingRecord](#BKMK_msdyn_oclocalizationdata_DuplicateMatchingRecord)
- [msdyn_oclocalizationdata_MailboxTrackingFolders](#BKMK_msdyn_oclocalizationdata_MailboxTrackingFolders)
- [msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses)
- [msdyn_oclocalizationdata_ProcessSession](#BKMK_msdyn_oclocalizationdata_ProcessSession)
- [msdyn_oclocalizationdata_SyncErrors](#BKMK_msdyn_oclocalizationdata_SyncErrors)

### <a name="BKMK_msdyn_oclocalizationdata_AsyncOperations"></a> msdyn_oclocalizationdata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_oclocalizationdata_AsyncOperations](asyncoperation.md#BKMK_msdyn_oclocalizationdata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_BulkDeleteFailures"></a> msdyn_oclocalizationdata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_oclocalizationdata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_oclocalizationdata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_DuplicateBaseRecord"></a> msdyn_oclocalizationdata_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_oclocalizationdata_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_oclocalizationdata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_DuplicateMatchingRecord"></a> msdyn_oclocalizationdata_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_oclocalizationdata_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_oclocalizationdata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_MailboxTrackingFolders"></a> msdyn_oclocalizationdata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_oclocalizationdata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_oclocalizationdata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses"></a> msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_ProcessSession"></a> msdyn_oclocalizationdata_ProcessSession

Many-To-One Relationship: [processsession msdyn_oclocalizationdata_ProcessSession](processsession.md#BKMK_msdyn_oclocalizationdata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclocalizationdata_SyncErrors"></a> msdyn_oclocalizationdata_SyncErrors

Many-To-One Relationship: [syncerror msdyn_oclocalizationdata_SyncErrors](syncerror.md#BKMK_msdyn_oclocalizationdata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclocalizationdata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

