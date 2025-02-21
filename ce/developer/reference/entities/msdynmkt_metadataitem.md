---
title: "Metadata Item (msdynmkt_metadataitem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Metadata Item (msdynmkt_metadataitem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Metadata Item (msdynmkt_metadataitem) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Metadata Item (msdynmkt_metadataitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_metadataitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_metadataitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_metadataitems(*msdynmkt_metadataitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Metadata Item (msdynmkt_metadataitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Metadata Item** |
| **DisplayCollectionName** | **Metadata Items** |
| **SchemaName** | `msdynmkt_metadataitem` |
| **CollectionSchemaName** | `msdynmkt_metadataitems` |
| **EntitySetName** | `msdynmkt_metadataitems`|
| **LogicalName** | `msdynmkt_metadataitem` |
| **LogicalCollectionName** | `msdynmkt_metadataitems` |
| **PrimaryIdAttribute** | `msdynmkt_metadataitemid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_DataType](#BKMK_msdynmkt_DataType)
- [msdynmkt_DateTimeBehavior](#BKMK_msdynmkt_DateTimeBehavior)
- [msdynmkt_DisplayName](#BKMK_msdynmkt_DisplayName)
- [msdynmkt_FullMetadataAsJSON](#BKMK_msdynmkt_FullMetadataAsJSON)
- [msdynmkt_IconPath](#BKMK_msdynmkt_IconPath)
- [msdynmkt_IsRequired](#BKMK_msdynmkt_IsRequired)
- [msdynmkt_IsSecured](#BKMK_msdynmkt_IsSecured)
- [msdynmkt_LanguageCode](#BKMK_msdynmkt_LanguageCode)
- [msdynmkt_LogicalName](#BKMK_msdynmkt_LogicalName)
- [msdynmkt_metadataitemId](#BKMK_msdynmkt_metadataitemId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_NativeId](#BKMK_msdynmkt_NativeId)
- [msdynmkt_NavigationPathsAsJSON](#BKMK_msdynmkt_NavigationPathsAsJSON)
- [msdynmkt_ReferencedSourcesAsJSON](#BKMK_msdynmkt_ReferencedSourcesAsJSON)
- [msdynmkt_SourceDisplayName](#BKMK_msdynmkt_SourceDisplayName)
- [msdynmkt_SourceIsVirtual](#BKMK_msdynmkt_SourceIsVirtual)
- [msdynmkt_SourceLogicalName](#BKMK_msdynmkt_SourceLogicalName)
- [msdynmkt_SourcePrimaryId](#BKMK_msdynmkt_SourcePrimaryId)
- [msdynmkt_SourceSetName](#BKMK_msdynmkt_SourceSetName)
- [msdynmkt_SourceType](#BKMK_msdynmkt_SourceType)
- [msdynmkt_SourceVirtualTableType](#BKMK_msdynmkt_SourceVirtualTableType)
- [msdynmkt_StringFormatType](#BKMK_msdynmkt_StringFormatType)
- [msdynmkt_TargetAudience](#BKMK_msdynmkt_TargetAudience)
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

### <a name="BKMK_msdynmkt_DataType"></a> msdynmkt_DataType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Data Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_datatype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_datatype`|

#### msdynmkt_DataType Choices/Options

|Value|Label|
|---|---|
|534120000|**BigInt**|
|534120001|**Money**|
|534120002|**DateTime**|
|534120003|**Decimal**|
|534120004|**Integer**|
|534120005|**String**|
|534120006|**File**|
|534120007|**Double**|
|534120008|**Image**|
|534120009|**Lookup**|
|534120010|**MultiSelectPicklist**|
|534120011|**Memo**|
|534120012|**Picklist**|
|534120013|**Status**|
|534120014|**State**|
|534120015|**Boolean**|
|534120016|**Uniqueidentifier**|
|534120017|**OneToManyRelationship**|
|534120018|**ManyToManyRelationship**|
|534120019|**EntityValue**|
|534120020|**EntityCollection**|
|534120021|**Other**|
|534120022|**ManyToOneRelationship**|

### <a name="BKMK_msdynmkt_DateTimeBehavior"></a> msdynmkt_DateTimeBehavior

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Time Behavior**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_datetimebehavior`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_datetimebehavior`|

#### msdynmkt_DateTimeBehavior Choices/Options

|Value|Label|
|---|---|
|534120000|**TimeZoneIndependent**|
|534120001|**DateOnly**|
|534120002|**UserLocal**|

### <a name="BKMK_msdynmkt_DisplayName"></a> msdynmkt_DisplayName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_displayname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

### <a name="BKMK_msdynmkt_FullMetadataAsJSON"></a> msdynmkt_FullMetadataAsJSON

|Property|Value|
|---|---|
|Description||
|DisplayName|**Full Metadata As JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fullmetadataasjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_IconPath"></a> msdynmkt_IconPath

|Property|Value|
|---|---|
|Description||
|DisplayName|**Icon Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_iconpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

### <a name="BKMK_msdynmkt_IsRequired"></a> msdynmkt_IsRequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_isrequired`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_isrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_IsSecured"></a> msdynmkt_IsSecured

|Property|Value|
|---|---|
|Description||
|DisplayName|**IsSecured**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_issecured`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_issecured`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_LanguageCode"></a> msdynmkt_LanguageCode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Language Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_languagecode`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_LogicalName"></a> msdynmkt_LogicalName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_logicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_metadataitemId"></a> msdynmkt_metadataitemId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Metadata Item**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_metadataitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdynmkt_NativeId"></a> msdynmkt_NativeId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Native Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_nativeid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_NavigationPathsAsJSON"></a> msdynmkt_NavigationPathsAsJSON

|Property|Value|
|---|---|
|Description||
|DisplayName|**Navigation Paths As JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_navigationpathsasjson`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_ReferencedSourcesAsJSON"></a> msdynmkt_ReferencedSourcesAsJSON

|Property|Value|
|---|---|
|Description||
|DisplayName|**Referenced Sources As JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_referencedsourcesasjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_SourceDisplayName"></a> msdynmkt_SourceDisplayName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcedisplayname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

### <a name="BKMK_msdynmkt_SourceIsVirtual"></a> msdynmkt_SourceIsVirtual

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Is Virtual**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceisvirtual`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_sourceisvirtual`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_SourceLogicalName"></a> msdynmkt_SourceLogicalName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcelogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_SourcePrimaryId"></a> msdynmkt_SourcePrimaryId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Primary Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceprimaryid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_SourceSetName"></a> msdynmkt_SourceSetName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Set Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcesetname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_SourceType"></a> msdynmkt_SourceType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_sourcetype`|

#### msdynmkt_SourceType Choices/Options

|Value|Label|
|---|---|
|534120000|**Dataverse Table**|
|534120001|**CJO Interaction Event**|
|534120002|**CJO Business Event**|
|534120003|**CJO Custom Event**|
|534120004|**Legal**|
|534120005|**External**|

### <a name="BKMK_msdynmkt_SourceVirtualTableType"></a> msdynmkt_SourceVirtualTableType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Virtual Table Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcevirtualtabletype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_sourcevirtualtabletype`|

#### msdynmkt_SourceVirtualTableType Choices/Options

|Value|Label|
|---|---|
|534120000|**None**|
|534120001|**Elastic**|
|534120002|**Other**|

### <a name="BKMK_msdynmkt_StringFormatType"></a> msdynmkt_StringFormatType

|Property|Value|
|---|---|
|Description||
|DisplayName|**String Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_stringformattype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataitem_msdynmkt_stringformattype`|

#### msdynmkt_StringFormatType Choices/Options

|Value|Label|
|---|---|
|534120000|**Email**|
|534120001|**Text**|
|534120002|**TextArea**|
|534120003|**Url**|
|534120004|**TickerSymbol**|
|534120005|**PhoneticGuide**|
|534120006|**VersionNumber**|
|534120007|**Phone**|
|534120008|**Json**|
|534120009|**RichText**|

### <a name="BKMK_msdynmkt_TargetAudience"></a> msdynmkt_TargetAudience

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target Audience As JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetaudienceasjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|Description|**Status of the Metadata Item**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_metadataitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Metadata Item**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_metadataitem_statuscode`|

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

- [business_unit_msdynmkt_metadataitem](#BKMK_business_unit_msdynmkt_metadataitem)
- [lk_msdynmkt_metadataitem_createdby](#BKMK_lk_msdynmkt_metadataitem_createdby)
- [lk_msdynmkt_metadataitem_createdonbehalfby](#BKMK_lk_msdynmkt_metadataitem_createdonbehalfby)
- [lk_msdynmkt_metadataitem_modifiedby](#BKMK_lk_msdynmkt_metadataitem_modifiedby)
- [lk_msdynmkt_metadataitem_modifiedonbehalfby](#BKMK_lk_msdynmkt_metadataitem_modifiedonbehalfby)
- [owner_msdynmkt_metadataitem](#BKMK_owner_msdynmkt_metadataitem)
- [team_msdynmkt_metadataitem](#BKMK_team_msdynmkt_metadataitem)
- [user_msdynmkt_metadataitem](#BKMK_user_msdynmkt_metadataitem)

### <a name="BKMK_business_unit_msdynmkt_metadataitem"></a> business_unit_msdynmkt_metadataitem

One-To-Many Relationship: [businessunit business_unit_msdynmkt_metadataitem](businessunit.md#BKMK_business_unit_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataitem_createdby"></a> lk_msdynmkt_metadataitem_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataitem_createdby](systemuser.md#BKMK_lk_msdynmkt_metadataitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataitem_createdonbehalfby"></a> lk_msdynmkt_metadataitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataitem_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_metadataitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataitem_modifiedby"></a> lk_msdynmkt_metadataitem_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataitem_modifiedby](systemuser.md#BKMK_lk_msdynmkt_metadataitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataitem_modifiedonbehalfby"></a> lk_msdynmkt_metadataitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_metadataitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_metadataitem"></a> owner_msdynmkt_metadataitem

One-To-Many Relationship: [owner owner_msdynmkt_metadataitem](owner.md#BKMK_owner_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_metadataitem"></a> team_msdynmkt_metadataitem

One-To-Many Relationship: [team team_msdynmkt_metadataitem](team.md#BKMK_team_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_metadataitem"></a> user_msdynmkt_metadataitem

One-To-Many Relationship: [systemuser user_msdynmkt_metadataitem](systemuser.md#BKMK_user_msdynmkt_metadataitem)

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

- [msdynmkt_metadataitem_AsyncOperations](#BKMK_msdynmkt_metadataitem_AsyncOperations)
- [msdynmkt_metadataitem_BulkDeleteFailures](#BKMK_msdynmkt_metadataitem_BulkDeleteFailures)
- [msdynmkt_metadataitem_DuplicateBaseRecord](#BKMK_msdynmkt_metadataitem_DuplicateBaseRecord)
- [msdynmkt_metadataitem_DuplicateMatchingRecord](#BKMK_msdynmkt_metadataitem_DuplicateMatchingRecord)
- [msdynmkt_metadataitem_MailboxTrackingFolders](#BKMK_msdynmkt_metadataitem_MailboxTrackingFolders)
- [msdynmkt_metadataitem_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_metadataitem_PrincipalObjectAttributeAccesses)
- [msdynmkt_metadataitem_ProcessSession](#BKMK_msdynmkt_metadataitem_ProcessSession)
- [msdynmkt_metadataitem_SyncErrors](#BKMK_msdynmkt_metadataitem_SyncErrors)

### <a name="BKMK_msdynmkt_metadataitem_AsyncOperations"></a> msdynmkt_metadataitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_metadataitem_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_metadataitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_BulkDeleteFailures"></a> msdynmkt_metadataitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_metadataitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_metadataitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_DuplicateBaseRecord"></a> msdynmkt_metadataitem_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_metadataitem_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_metadataitem_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_DuplicateMatchingRecord"></a> msdynmkt_metadataitem_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_metadataitem_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_metadataitem_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_MailboxTrackingFolders"></a> msdynmkt_metadataitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_metadataitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_metadataitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_PrincipalObjectAttributeAccesses"></a> msdynmkt_metadataitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_metadataitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_metadataitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_ProcessSession"></a> msdynmkt_metadataitem_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_metadataitem_ProcessSession](processsession.md#BKMK_msdynmkt_metadataitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataitem_SyncErrors"></a> msdynmkt_metadataitem_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_metadataitem_SyncErrors](syncerror.md#BKMK_msdynmkt_metadataitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

