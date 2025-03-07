---
title: "Conversation Characteristic (msdyn_ocliveworkitemcharacteristic) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Characteristic (msdyn_ocliveworkitemcharacteristic) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Characteristic (msdyn_ocliveworkitemcharacteristic) table/entity reference (Microsoft Dynamics 365)

Characteristic associated to Omnichannel conversation

## Messages

The following table lists the messages for the Conversation Characteristic (msdyn_ocliveworkitemcharacteristic) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocliveworkitemcharacteristics<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocliveworkitemcharacteristics<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocliveworkitemcharacteristics(*msdyn_ocliveworkitemcharacteristicid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Characteristic (msdyn_ocliveworkitemcharacteristic) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Characteristic** |
| **DisplayCollectionName** | **Conversation Characteristics** |
| **SchemaName** | `msdyn_ocliveworkitemcharacteristic` |
| **CollectionSchemaName** | `msdyn_ocliveworkitemcharacteristics` |
| **EntitySetName** | `msdyn_ocliveworkitemcharacteristics`|
| **LogicalName** | `msdyn_ocliveworkitemcharacteristic` |
| **LogicalCollectionName** | `msdyn_ocliveworkitemcharacteristics` |
| **PrimaryIdAttribute** | `msdyn_ocliveworkitemcharacteristicid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_characteristic](#BKMK_msdyn_characteristic)
- [msdyn_characteristicsource](#BKMK_msdyn_characteristicsource)
- [msdyn_confidence](#BKMK_msdyn_confidence)
- [msdyn_createdon](#BKMK_msdyn_createdon)
- [msdyn_mlmodelid](#BKMK_msdyn_mlmodelid)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocliveworkitemcharacteristicId](#BKMK_msdyn_ocliveworkitemcharacteristicId)
- [msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitemid)
- [msdyn_ratingvalue](#BKMK_msdyn_ratingvalue)
- [msdyn_skilladdedby](#BKMK_msdyn_skilladdedby)
- [msdyn_status](#BKMK_msdyn_status)
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

### <a name="BKMK_msdyn_characteristic"></a> msdyn_characteristic

|Property|Value|
|---|---|
|Description|**Characteristic linked to the conversation**|
|DisplayName|**Characteristic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_characteristic`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|characteristic|

### <a name="BKMK_msdyn_characteristicsource"></a> msdyn_characteristicsource

|Property|Value|
|---|---|
|Description|**Option Set with different type of Source for the characteristic**|
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_characteristicsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationcharacteristicsource`|

#### msdyn_characteristicsource Choices/Options

|Value|Label|
|---|---|
|321240000|**Rule Based**|
|321240001|**ML Based**|
|321240002|**Manual**|

### <a name="BKMK_msdyn_confidence"></a> msdyn_confidence

|Property|Value|
|---|---|
|Description|**Confidence of the characteristic linked to the conversation**|
|DisplayName|**Confidence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidence`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|5|

### <a name="BKMK_msdyn_createdon"></a> msdyn_createdon

|Property|Value|
|---|---|
|Description|**Created On**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_mlmodelid"></a> msdyn_mlmodelid

|Property|Value|
|---|---|
|Description|**ML Model Id which is used to attach this characteristic**|
|DisplayName|**Ml Model Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mlmodelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_aimodel|

### <a name="BKMK_msdyn_modifiedon"></a> msdyn_modifiedon

|Property|Value|
|---|---|
|Description|**Last Modified On**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_ocliveworkitemcharacteristicId"></a> msdyn_ocliveworkitemcharacteristicId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Conversation Characteristic**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkitemcharacteristicid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitemid

|Property|Value|
|---|---|
|Description|**Related Conversation**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocliveworkitemid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_ratingvalue"></a> msdyn_ratingvalue

|Property|Value|
|---|---|
|Description|**Required rating value for the characteristic**|
|DisplayName|**Rating Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ratingvalue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|ratingvalue|

### <a name="BKMK_msdyn_skilladdedby"></a> msdyn_skilladdedby

|Property|Value|
|---|---|
|Description|**Look up to User who added this characteristic**|
|DisplayName|**Skill Added By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skilladdedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Status of the characteristic associated to the conversation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_conversationcharacteristicstatus`|

#### msdyn_status Choices/Options

|Value|Label|
|---|---|
|192350000|**Active**|
|192350001|**Deleted**|

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
|Description|**Status of the Conversation Characteristic**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocliveworkitemcharacteristic_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Conversation Characteristic**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocliveworkitemcharacteristic_statuscode`|

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

- [business_unit_msdyn_ocliveworkitemcharacteristic](#BKMK_business_unit_msdyn_ocliveworkitemcharacteristic)
- [lk_msdyn_ocliveworkitemcharacteristic_createdby](#BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdby)
- [lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby](#BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby)
- [lk_msdyn_ocliveworkitemcharacteristic_modifiedby](#BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedby)
- [lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby](#BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby)
- [msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic](#BKMK_msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid)
- [msdyn_ocliveworkitemcharacteristic_mlmodelid](#BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid)
- [msdyn_ocliveworkitemcharacteristic_skilladdedby](#BKMK_msdyn_ocliveworkitemcharacteristic_skilladdedby)
- [msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue](#BKMK_msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue)
- [owner_msdyn_ocliveworkitemcharacteristic](#BKMK_owner_msdyn_ocliveworkitemcharacteristic)
- [team_msdyn_ocliveworkitemcharacteristic](#BKMK_team_msdyn_ocliveworkitemcharacteristic)
- [user_msdyn_ocliveworkitemcharacteristic](#BKMK_user_msdyn_ocliveworkitemcharacteristic)

### <a name="BKMK_business_unit_msdyn_ocliveworkitemcharacteristic"></a> business_unit_msdyn_ocliveworkitemcharacteristic

One-To-Many Relationship: [businessunit business_unit_msdyn_ocliveworkitemcharacteristic](businessunit.md#BKMK_business_unit_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdby"></a> lk_msdyn_ocliveworkitemcharacteristic_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocliveworkitemcharacteristic_createdby](systemuser.md#BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby"></a> lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocliveworkitemcharacteristic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedby"></a> lk_msdyn_ocliveworkitemcharacteristic_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocliveworkitemcharacteristic_modifiedby](systemuser.md#BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby"></a> lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocliveworkitemcharacteristic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic"></a> msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic

One-To-Many Relationship: [characteristic msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic](characteristic.md#BKMK_msdyn_characteristic_msdyn_ocliveworkitemcharacteristic_characteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`characteristic`|
|ReferencedAttribute|`characteristicid`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencingEntityNavigationPropertyName|`msdyn_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocliveworkitemcharacteristic_ocliveworkitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocliveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid"></a> msdyn_ocliveworkitemcharacteristic_mlmodelid

One-To-Many Relationship: [msdyn_aimodel msdyn_ocliveworkitemcharacteristic_mlmodelid](msdyn_aimodel.md#BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aimodel`|
|ReferencedAttribute|`msdyn_aimodelid`|
|ReferencingAttribute|`msdyn_mlmodelid`|
|ReferencingEntityNavigationPropertyName|`msdyn_mlmodelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_skilladdedby"></a> msdyn_ocliveworkitemcharacteristic_skilladdedby

One-To-Many Relationship: [systemuser msdyn_ocliveworkitemcharacteristic_skilladdedby](systemuser.md#BKMK_msdyn_ocliveworkitemcharacteristic_skilladdedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_skilladdedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_skilladdedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue"></a> msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue

One-To-Many Relationship: [ratingvalue msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue](ratingvalue.md#BKMK_msdyn_ratingvalue_msdyn_ocliveworkitemcharacteristic_ratingvalue)

|Property|Value|
|---|---|
|ReferencedEntity|`ratingvalue`|
|ReferencedAttribute|`ratingvalueid`|
|ReferencingAttribute|`msdyn_ratingvalue`|
|ReferencingEntityNavigationPropertyName|`msdyn_ratingvalue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocliveworkitemcharacteristic"></a> owner_msdyn_ocliveworkitemcharacteristic

One-To-Many Relationship: [owner owner_msdyn_ocliveworkitemcharacteristic](owner.md#BKMK_owner_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocliveworkitemcharacteristic"></a> team_msdyn_ocliveworkitemcharacteristic

One-To-Many Relationship: [team team_msdyn_ocliveworkitemcharacteristic](team.md#BKMK_team_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocliveworkitemcharacteristic"></a> user_msdyn_ocliveworkitemcharacteristic

One-To-Many Relationship: [systemuser user_msdyn_ocliveworkitemcharacteristic](systemuser.md#BKMK_user_msdyn_ocliveworkitemcharacteristic)

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

- [msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic](#BKMK_msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic)
- [msdyn_ocliveworkitemcharacteristic_AsyncOperations](#BKMK_msdyn_ocliveworkitemcharacteristic_AsyncOperations)
- [msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures](#BKMK_msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures)
- [msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord](#BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord)
- [msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord)
- [msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders](#BKMK_msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders)
- [msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_ocliveworkitemcharacteristic_ProcessSession](#BKMK_msdyn_ocliveworkitemcharacteristic_ProcessSession)
- [msdyn_ocliveworkitemcharacteristic_SyncErrors](#BKMK_msdyn_ocliveworkitemcharacteristic_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic"></a> msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic

Many-To-One Relationship: [msdyn_ocsessioncharacteristic msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic](msdyn_ocsessioncharacteristic.md#BKMK_msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessioncharacteristic`|
|ReferencingAttribute|`msdyn_ocliveworkitemcharacteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitemcharacteristic_msdyn_ocsessioncharacteristic_ocliveworkitemcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_AsyncOperations"></a> msdyn_ocliveworkitemcharacteristic_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocliveworkitemcharacteristic_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocliveworkitemcharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures"></a> msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord"></a> msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord"></a> msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders"></a> msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_ProcessSession"></a> msdyn_ocliveworkitemcharacteristic_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocliveworkitemcharacteristic_ProcessSession](processsession.md#BKMK_msdyn_ocliveworkitemcharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_SyncErrors"></a> msdyn_ocliveworkitemcharacteristic_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocliveworkitemcharacteristic_SyncErrors](syncerror.md#BKMK_msdyn_ocliveworkitemcharacteristic_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

