---
title: "Proactive Delivery (msdyn_proactive_delivery) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Proactive Delivery (msdyn_proactive_delivery) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Proactive Delivery (msdyn_proactive_delivery) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Proactive Delivery (msdyn_proactive_delivery) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_proactive_deliveries(*msdyn_proactive_deliveryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_proactive_deliveries<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_proactive_deliveries(*msdyn_proactive_deliveryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_proactive_deliveries(*msdyn_proactive_deliveryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_proactive_deliveries<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_proactive_deliveries(*msdyn_proactive_deliveryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_proactive_deliveries(*msdyn_proactive_deliveryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Proactive Delivery (msdyn_proactive_delivery) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Proactive Delivery** |
| **DisplayCollectionName** | **Proactive Deliveries** |
| **SchemaName** | `msdyn_proactive_delivery` |
| **CollectionSchemaName** | `msdyn_proactive_deliveries` |
| **EntitySetName** | `msdyn_proactive_deliveries`|
| **LogicalName** | `msdyn_proactive_delivery` |
| **LogicalCollectionName** | `msdyn_proactive_deliveries` |
| **PrimaryIdAttribute** | `msdyn_proactive_deliveryid` |
| **PrimaryNameAttribute** |`msdyn_delivery_id` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_call_id](#BKMK_msdyn_call_id)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_channel_sent_date](#BKMK_msdyn_channel_sent_date)
- [msdyn_contact_id](#BKMK_msdyn_contact_id)
- [msdyn_conversation_id](#BKMK_msdyn_conversation_id)
- [msdyn_delivery_id](#BKMK_msdyn_delivery_id)
- [msdyn_dialmode_type](#BKMK_msdyn_dialmode_type)
- [msdyn_disposition_codes](#BKMK_msdyn_disposition_codes)
- [msdyn_end_date](#BKMK_msdyn_end_date)
- [msdyn_expiration_date](#BKMK_msdyn_expiration_date)
- [msdyn_from_address](#BKMK_msdyn_from_address)
- [msdyn_journey_id](#BKMK_msdyn_journey_id)
- [msdyn_journey_run_id](#BKMK_msdyn_journey_run_id)
- [msdyn_proactive_deliveryId](#BKMK_msdyn_proactive_deliveryId)
- [msdyn_proactive_engagement_config_id](#BKMK_msdyn_proactive_engagement_config_id)
- [msdyn_queue_id](#BKMK_msdyn_queue_id)
- [msdyn_result](#BKMK_msdyn_result)
- [msdyn_result_date](#BKMK_msdyn_result_date)
- [msdyn_start_date](#BKMK_msdyn_start_date)
- [msdyn_status](#BKMK_msdyn_status)
- [msdyn_to_address](#BKMK_msdyn_to_address)
- [msdyn_tracking_id](#BKMK_msdyn_tracking_id)
- [msdyn_window_end_date](#BKMK_msdyn_window_end_date)
- [msdyn_window_start_date](#BKMK_msdyn_window_start_date)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdyn_call_id"></a> msdyn_call_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Call Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_call_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_channel_sent_date"></a> msdyn_channel_sent_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel Sent Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel_sent_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_contact_id"></a> msdyn_contact_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contact_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_conversation_id"></a> msdyn_conversation_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversation_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_delivery_id"></a> msdyn_delivery_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Delivery Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_delivery_id`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_dialmode_type"></a> msdyn_dialmode_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dial Mode Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dialmode_type`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_disposition_codes"></a> msdyn_disposition_codes

|Property|Value|
|---|---|
|Description||
|DisplayName|**Disposition Codes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disposition_codes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_end_date"></a> msdyn_end_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_end_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_expiration_date"></a> msdyn_expiration_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expiration_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_from_address"></a> msdyn_from_address

|Property|Value|
|---|---|
|Description||
|DisplayName|**From Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_from_address`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_journey_id"></a> msdyn_journey_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_journey_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_journey_run_id"></a> msdyn_journey_run_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_journey_run_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_proactive_deliveryId"></a> msdyn_proactive_deliveryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Proactive Delivery**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_deliveryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_proactive_engagement_config_id"></a> msdyn_proactive_engagement_config_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Proactive Engagement Configuration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_engagement_config_id`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_queue_id"></a> msdyn_queue_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Queue Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queue_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_result"></a> msdyn_result

|Property|Value|
|---|---|
|Description||
|DisplayName|**Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_result`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_result_date"></a> msdyn_result_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Result Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_result_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_start_date"></a> msdyn_start_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_start_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_to_address"></a> msdyn_to_address

|Property|Value|
|---|---|
|Description||
|DisplayName|**To Address**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_to_address`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_tracking_id"></a> msdyn_tracking_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Tracking Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tracking_id`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyn_window_end_date"></a> msdyn_window_end_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Window End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_window_end_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_window_start_date"></a> msdyn_window_start_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Window Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_window_start_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_proactive_delivery](#BKMK_business_unit_msdyn_proactive_delivery)
- [lk_msdyn_proactive_delivery_createdby](#BKMK_lk_msdyn_proactive_delivery_createdby)
- [lk_msdyn_proactive_delivery_createdonbehalfby](#BKMK_lk_msdyn_proactive_delivery_createdonbehalfby)
- [lk_msdyn_proactive_delivery_modifiedby](#BKMK_lk_msdyn_proactive_delivery_modifiedby)
- [lk_msdyn_proactive_delivery_modifiedonbehalfby](#BKMK_lk_msdyn_proactive_delivery_modifiedonbehalfby)
- [owner_msdyn_proactive_delivery](#BKMK_owner_msdyn_proactive_delivery)
- [team_msdyn_proactive_delivery](#BKMK_team_msdyn_proactive_delivery)
- [user_msdyn_proactive_delivery](#BKMK_user_msdyn_proactive_delivery)

### <a name="BKMK_business_unit_msdyn_proactive_delivery"></a> business_unit_msdyn_proactive_delivery

One-To-Many Relationship: [businessunit business_unit_msdyn_proactive_delivery](businessunit.md#BKMK_business_unit_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_delivery_createdby"></a> lk_msdyn_proactive_delivery_createdby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_delivery_createdby](systemuser.md#BKMK_lk_msdyn_proactive_delivery_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_delivery_createdonbehalfby"></a> lk_msdyn_proactive_delivery_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_delivery_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_delivery_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_delivery_modifiedby"></a> lk_msdyn_proactive_delivery_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_delivery_modifiedby](systemuser.md#BKMK_lk_msdyn_proactive_delivery_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_delivery_modifiedonbehalfby"></a> lk_msdyn_proactive_delivery_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_delivery_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_delivery_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_proactive_delivery"></a> owner_msdyn_proactive_delivery

One-To-Many Relationship: [owner owner_msdyn_proactive_delivery](owner.md#BKMK_owner_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_proactive_delivery"></a> team_msdyn_proactive_delivery

One-To-Many Relationship: [team team_msdyn_proactive_delivery](team.md#BKMK_team_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_proactive_delivery"></a> user_msdyn_proactive_delivery

One-To-Many Relationship: [systemuser user_msdyn_proactive_delivery](systemuser.md#BKMK_user_msdyn_proactive_delivery)

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

### <a name="BKMK_msdyn_proactive_delivery_attribute_msdyn_proactive_delivery_msdyn_proactive_delivery"></a> msdyn_proactive_delivery_attribute_msdyn_proactive_delivery_msdyn_proactive_delivery

Many-To-One Relationship: [msdyn_proactive_delivery_attribute msdyn_proactive_delivery_attribute_msdyn_proactive_delivery_msdyn_proactive_delivery](msdyn_proactive_delivery_attribute.md#BKMK_msdyn_proactive_delivery_attribute_msdyn_proactive_delivery_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_attribute`|
|ReferencingAttribute|`msdyn_proactive_delivery`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_delivery_attribute_msdyn_proactive_delivery_msdyn_proactive_delivery`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

