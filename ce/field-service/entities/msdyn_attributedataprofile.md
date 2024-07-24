---
title: "AttributeDataProfile (msdyn_attributedataprofile) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the AttributeDataProfile (msdyn_attributedataprofile) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# AttributeDataProfile (msdyn_attributedataprofile) table/entity reference



## Messages

The following table lists the messages for the AttributeDataProfile (msdyn_attributedataprofile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_attributedataprofiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_attributedataprofiles(*msdyn_attributedataprofileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_attributedataprofiles(*msdyn_attributedataprofileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_attributedataprofiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_attributedataprofiles(*msdyn_attributedataprofileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_attributedataprofiles(*msdyn_attributedataprofileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|


## Events

The following table lists the events for the AttributeDataProfile (msdyn_attributedataprofile) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the AttributeDataProfile (msdyn_attributedataprofile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **AttributeDataProfile** |
| **DisplayCollectionName** | **AttributeDataProfiles** |
| **SchemaName** | `msdyn_attributedataprofile` |
| **CollectionSchemaName** | `msdyn_attributedataprofiles` |
| **EntitySetName** | `msdyn_attributedataprofiles`|
| **LogicalName** | `msdyn_attributedataprofile` |
| **LogicalCollectionName** | `msdyn_attributedataprofiles` |
| **PrimaryIdAttribute** | `msdyn_attributedataprofileid` |
| **PrimaryNameAttribute** |`msdyn_attributedataprofile_pk` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attributedataprofile_attributename](#BKMK_msdyn_attributedataprofile_attributename)
- [msdyn_attributedataprofile_checkifexactstats](#BKMK_msdyn_attributedataprofile_checkifexactstats)
- [msdyn_attributedataprofile_count](#BKMK_msdyn_attributedataprofile_count)
- [msdyn_attributedataprofile_errorcount](#BKMK_msdyn_attributedataprofile_errorcount)
- [msdyn_attributedataprofile_histogramserialized](#BKMK_msdyn_attributedataprofile_histogramserialized)
- [msdyn_attributedataprofile_max](#BKMK_msdyn_attributedataprofile_max)
- [msdyn_attributedataprofile_min](#BKMK_msdyn_attributedataprofile_min)
- [msdyn_attributedataprofile_missingcount](#BKMK_msdyn_attributedataprofile_missingcount)
- [msdyn_attributedataprofile_momentskurtosis](#BKMK_msdyn_attributedataprofile_momentskurtosis)
- [msdyn_attributedataprofile_momentsmean](#BKMK_msdyn_attributedataprofile_momentsmean)
- [msdyn_attributedataprofile_momentsskewness](#BKMK_msdyn_attributedataprofile_momentsskewness)
- [msdyn_attributedataprofile_momentsstddeviation](#BKMK_msdyn_attributedataprofile_momentsstddeviation)
- [msdyn_attributedataprofile_momentsvariance](#BKMK_msdyn_attributedataprofile_momentsvariance)
- [msdyn_attributedataprofile_pk](#BKMK_msdyn_attributedataprofile_pk)
- [msdyn_attributedataprofile_profilingdate](#BKMK_msdyn_attributedataprofile_profilingdate)
- [msdyn_attributedataprofile_qualifiedentityname](#BKMK_msdyn_attributedataprofile_qualifiedentityname)
- [msdyn_attributedataprofile_quantilesp0d1](#BKMK_msdyn_attributedataprofile_quantilesp0d1)
- [msdyn_attributedataprofile_quantilesp1](#BKMK_msdyn_attributedataprofile_quantilesp1)
- [msdyn_attributedataprofile_quantilesp25](#BKMK_msdyn_attributedataprofile_quantilesp25)
- [msdyn_attributedataprofile_quantilesp5](#BKMK_msdyn_attributedataprofile_quantilesp5)
- [msdyn_attributedataprofile_quantilesp50](#BKMK_msdyn_attributedataprofile_quantilesp50)
- [msdyn_attributedataprofile_quantilesp75](#BKMK_msdyn_attributedataprofile_quantilesp75)
- [msdyn_attributedataprofile_quantilesp95](#BKMK_msdyn_attributedataprofile_quantilesp95)
- [msdyn_attributedataprofile_quantilesp99](#BKMK_msdyn_attributedataprofile_quantilesp99)
- [msdyn_attributedataprofile_quantilesp99d9](#BKMK_msdyn_attributedataprofile_quantilesp99d9)
- [msdyn_attributedataprofile_topkserialized](#BKMK_msdyn_attributedataprofile_topkserialized)
- [msdyn_attributedataprofile_uniquevaluecount](#BKMK_msdyn_attributedataprofile_uniquevaluecount)
- [msdyn_attributedataprofileId](#BKMK_msdyn_attributedataprofileId)
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

### <a name="BKMK_msdyn_attributedataprofile_attributename"></a> msdyn_attributedataprofile_attributename

|Property|Value|
|---|---|
|Description||
|DisplayName|**AttributeName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_attributename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_attributedataprofile_checkifexactstats"></a> msdyn_attributedataprofile_checkifexactstats

|Property|Value|
|---|---|
|Description||
|DisplayName|**CheckIfExactStats**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_checkifexactstats`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_attributedataprofile_msdyn_attributedataprofile_checkifexactstats`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_attributedataprofile_count"></a> msdyn_attributedataprofile_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**Count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_count`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_attributedataprofile_errorcount"></a> msdyn_attributedataprofile_errorcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**ErrorCount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_errorcount`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_attributedataprofile_histogramserialized"></a> msdyn_attributedataprofile_histogramserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**HistogramSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_histogramserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_attributedataprofile_max"></a> msdyn_attributedataprofile_max

|Property|Value|
|---|---|
|Description||
|DisplayName|**Max**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_max`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_min"></a> msdyn_attributedataprofile_min

|Property|Value|
|---|---|
|Description||
|DisplayName|**Min**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_min`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_missingcount"></a> msdyn_attributedataprofile_missingcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**MissingCount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_missingcount`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_attributedataprofile_momentskurtosis"></a> msdyn_attributedataprofile_momentskurtosis

|Property|Value|
|---|---|
|Description||
|DisplayName|**MomentsKurtosis**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_momentskurtosis`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_momentsmean"></a> msdyn_attributedataprofile_momentsmean

|Property|Value|
|---|---|
|Description||
|DisplayName|**MomentsMean**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_momentsmean`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_momentsskewness"></a> msdyn_attributedataprofile_momentsskewness

|Property|Value|
|---|---|
|Description||
|DisplayName|**MomentsSkewness**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_momentsskewness`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_momentsstddeviation"></a> msdyn_attributedataprofile_momentsstddeviation

|Property|Value|
|---|---|
|Description||
|DisplayName|**MomentsStandardDeviation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_momentsstddeviation`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_momentsvariance"></a> msdyn_attributedataprofile_momentsvariance

|Property|Value|
|---|---|
|Description||
|DisplayName|**MomentsVariance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_momentsvariance`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_pk"></a> msdyn_attributedataprofile_pk

|Property|Value|
|---|---|
|Description||
|DisplayName|**PrimaryKey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_pk`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_attributedataprofile_profilingdate"></a> msdyn_attributedataprofile_profilingdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**ProfilingDate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_profilingdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_qualifiedentityname"></a> msdyn_attributedataprofile_qualifiedentityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**QualifiedEntityName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_qualifiedentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp0d1"></a> msdyn_attributedataprofile_quantilesp0d1

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP0D1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp0d1`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp1"></a> msdyn_attributedataprofile_quantilesp1

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp1`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp25"></a> msdyn_attributedataprofile_quantilesp25

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP25**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp25`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp5"></a> msdyn_attributedataprofile_quantilesp5

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP5**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp5`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp50"></a> msdyn_attributedataprofile_quantilesp50

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP50**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp50`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp75"></a> msdyn_attributedataprofile_quantilesp75

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP75**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp75`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp95"></a> msdyn_attributedataprofile_quantilesp95

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP95**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp95`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp99"></a> msdyn_attributedataprofile_quantilesp99

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP99**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp99`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_quantilesp99d9"></a> msdyn_attributedataprofile_quantilesp99d9

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuantilesP99D9**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_quantilesp99d9`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_attributedataprofile_topkserialized"></a> msdyn_attributedataprofile_topkserialized

|Property|Value|
|---|---|
|Description||
|DisplayName|**TopKSerialized**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_topkserialized`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_attributedataprofile_uniquevaluecount"></a> msdyn_attributedataprofile_uniquevaluecount

|Property|Value|
|---|---|
|Description||
|DisplayName|**UniqueValueCount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofile_uniquevaluecount`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyn_attributedataprofileId"></a> msdyn_attributedataprofileId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**AttributeDataProfile**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_attributedataprofileid`|
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
|Description|**Status of the AttributeDataProfile**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_attributedataprofile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the AttributeDataProfile**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_attributedataprofile_statuscode`|

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
|Targets||

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
|Targets||

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
|Targets||

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
|Targets||

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
|Targets||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

