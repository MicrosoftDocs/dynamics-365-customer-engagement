---
title: "Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table/entity reference

This entity records the number of rooms that have been allocated from a single hotel for guests of a single event.

## Messages

The following table lists the messages for the Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_hotelroomallocations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_hotelroomallocations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_hotelroomallocations(*msevtmgt_hotelroomallocationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Hotel Room Allocation (msevtmgt_HotelRoomAllocation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Hotel Room Allocation** |
| **DisplayCollectionName** | **Hotel Room Allocations** |
| **SchemaName** | `msevtmgt_HotelRoomAllocation` |
| **CollectionSchemaName** | `msevtmgt_HotelRoomAllocations` |
| **EntitySetName** | `msevtmgt_hotelroomallocations`|
| **LogicalName** | `msevtmgt_hotelroomallocation` |
| **LogicalCollectionName** | `msevtmgt_hotelroomallocations` |
| **PrimaryIdAttribute** | `msevtmgt_hotelroomallocationid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AdditionalDetails](#BKMK_msevtmgt_AdditionalDetails)
- [msevtmgt_Event](#BKMK_msevtmgt_Event)
- [msevtmgt_HotelProperty](#BKMK_msevtmgt_HotelProperty)
- [msevtmgt_HotelRoomAllocationId](#BKMK_msevtmgt_HotelRoomAllocationId)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_NumberOfRoomsAllocated](#BKMK_msevtmgt_NumberOfRoomsAllocated)
- [msevtmgt_PricePerRoom](#BKMK_msevtmgt_PricePerRoom)
- [msevtmgt_PrimaryContact](#BKMK_msevtmgt_PrimaryContact)
- [msevtmgt_RoomType](#BKMK_msevtmgt_RoomType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_AdditionalDetails"></a> msevtmgt_AdditionalDetails

|Property|Value|
|---|---|
|Description|**Room allocation additional details**|
|DisplayName|**Additional details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_additionaldetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Event"></a> msevtmgt_Event

|Property|Value|
|---|---|
|Description|**Related event**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_HotelProperty"></a> msevtmgt_HotelProperty

|Property|Value|
|---|---|
|Description|**Related hotel property**|
|DisplayName|**Hotel/property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_hotelproperty`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_hotel|

### <a name="BKMK_msevtmgt_HotelRoomAllocationId"></a> msevtmgt_HotelRoomAllocationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Hotel room allocation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_hotelroomallocationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_NumberOfRoomsAllocated"></a> msevtmgt_NumberOfRoomsAllocated

|Property|Value|
|---|---|
|Description|**Number of allocated rooms**|
|DisplayName|**Number of rooms allocated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofroomsallocated`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_PricePerRoom"></a> msevtmgt_PricePerRoom

|Property|Value|
|---|---|
|Description|**Price per room**|
|DisplayName|**Price per room**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_priceperroom`|
|RequiredLevel|Recommended|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_PrimaryContact"></a> msevtmgt_PrimaryContact

|Property|Value|
|---|---|
|Description|**Primary contact**|
|DisplayName|**Primary contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primarycontact`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_RoomType"></a> msevtmgt_RoomType

|Property|Value|
|---|---|
|Description|**Room type**|
|DisplayName|**Room type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_roomtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_roomtype`|

#### msevtmgt_RoomType Choices/Options

|Value|Label|
|---|---|
|100000000|**Single room**|
|100000001|**Double room**|
|100000002|**Junior suite**|
|100000003|**Executive suite**|
|100000004|**Luxury suite**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the hotel room allocation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_hotelroomallocation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the hotel room allocation**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_hotelroomallocation_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msevtmgt_NumberOfRoomsLeft](#BKMK_msevtmgt_NumberOfRoomsLeft)
- [msevtmgt_NumberofRoomsReserved](#BKMK_msevtmgt_NumberofRoomsReserved)
- [msevtmgt_NumberofRoomsReserved_Date](#BKMK_msevtmgt_NumberofRoomsReserved_Date)
- [msevtmgt_NumberofRoomsReserved_State](#BKMK_msevtmgt_NumberofRoomsReserved_State)
- [msevtmgt_priceperroom_Base](#BKMK_msevtmgt_priceperroom_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate between the base currency and the currency associated with the entity**|
|DisplayName|**Exchange rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msevtmgt_NumberOfRoomsLeft"></a> msevtmgt_NumberOfRoomsLeft

|Property|Value|
|---|---|
|Description|**Number of rooms left**|
|DisplayName|**Number of rooms left**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofroomsleft`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_NumberofRoomsReserved"></a> msevtmgt_NumberofRoomsReserved

|Property|Value|
|---|---|
|Description|**Number of reserved rooms**|
|DisplayName|**Number of rooms reserved**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofroomsreserved`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_NumberofRoomsReserved_Date"></a> msevtmgt_NumberofRoomsReserved_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Number of rooms reserved.**|
|DisplayName|**Number of rooms reserved (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofroomsreserved_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_NumberofRoomsReserved_State"></a> msevtmgt_NumberofRoomsReserved_State

|Property|Value|
|---|---|
|Description|**State of rollup field Number of rooms reserved.**|
|DisplayName|**Number of rooms reserved (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofroomsreserved_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_priceperroom_Base"></a> msevtmgt_priceperroom_Base

|Property|Value|
|---|---|
|Description|**Value of the price per room (in the base currency)**|
|DisplayName|**Price per room (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_priceperroom_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
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

- [business_unit_msevtmgt_hotelroomallocation](#BKMK_business_unit_msevtmgt_hotelroomallocation)
- [lk_msevtmgt_hotelroomallocation_createdby](#BKMK_lk_msevtmgt_hotelroomallocation_createdby)
- [lk_msevtmgt_hotelroomallocation_createdonbehalfby](#BKMK_lk_msevtmgt_hotelroomallocation_createdonbehalfby)
- [lk_msevtmgt_hotelroomallocation_modifiedby](#BKMK_lk_msevtmgt_hotelroomallocation_modifiedby)
- [lk_msevtmgt_hotelroomallocation_modifiedonbehalfby](#BKMK_lk_msevtmgt_hotelroomallocation_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact)
- [msevtmgt_msevtmgt_event_hotelroomallocation_Event](#BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event)
- [msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty](#BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty)
- [owner_msevtmgt_hotelroomallocation](#BKMK_owner_msevtmgt_hotelroomallocation)
- [team_msevtmgt_hotelroomallocation](#BKMK_team_msevtmgt_hotelroomallocation)
- [TransactionCurrency_msevtmgt_HotelRoomAllocation](#BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation)
- [user_msevtmgt_hotelroomallocation](#BKMK_user_msevtmgt_hotelroomallocation)

### <a name="BKMK_business_unit_msevtmgt_hotelroomallocation"></a> business_unit_msevtmgt_hotelroomallocation

One-To-Many Relationship: [businessunit business_unit_msevtmgt_hotelroomallocation](businessunit.md#BKMK_business_unit_msevtmgt_hotelroomallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotelroomallocation_createdby"></a> lk_msevtmgt_hotelroomallocation_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotelroomallocation_createdby](systemuser.md#BKMK_lk_msevtmgt_hotelroomallocation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotelroomallocation_createdonbehalfby"></a> lk_msevtmgt_hotelroomallocation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotelroomallocation_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_hotelroomallocation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotelroomallocation_modifiedby"></a> lk_msevtmgt_hotelroomallocation_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotelroomallocation_modifiedby](systemuser.md#BKMK_lk_msevtmgt_hotelroomallocation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotelroomallocation_modifiedonbehalfby"></a> lk_msevtmgt_hotelroomallocation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotelroomallocation_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_hotelroomallocation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact"></a> msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact](contact.md#BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PrimaryContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event"></a> msevtmgt_msevtmgt_event_hotelroomallocation_Event

One-To-Many Relationship: [msevtmgt_event msevtmgt_msevtmgt_event_hotelroomallocation_Event](msevtmgt_event.md#BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty"></a> msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty](msevtmgt_hotel.md#BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`msevtmgt_hotelproperty`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_HotelProperty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_hotelroomallocation"></a> owner_msevtmgt_hotelroomallocation

One-To-Many Relationship: [owner owner_msevtmgt_hotelroomallocation](owner.md#BKMK_owner_msevtmgt_hotelroomallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_hotelroomallocation"></a> team_msevtmgt_hotelroomallocation

One-To-Many Relationship: [team team_msevtmgt_hotelroomallocation](team.md#BKMK_team_msevtmgt_hotelroomallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation"></a> TransactionCurrency_msevtmgt_HotelRoomAllocation

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_HotelRoomAllocation](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_hotelroomallocation"></a> user_msevtmgt_hotelroomallocation

One-To-Many Relationship: [systemuser user_msevtmgt_hotelroomallocation](systemuser.md#BKMK_user_msevtmgt_hotelroomallocation)

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

- [msevtmgt_hotelroomallocation_ActivityPointers](#BKMK_msevtmgt_hotelroomallocation_ActivityPointers)
- [msevtmgt_hotelroomallocation_adx_alertsubscriptions](#BKMK_msevtmgt_hotelroomallocation_adx_alertsubscriptions)
- [msevtmgt_hotelroomallocation_adx_inviteredemptions](#BKMK_msevtmgt_hotelroomallocation_adx_inviteredemptions)
- [msevtmgt_hotelroomallocation_adx_portalcomments](#BKMK_msevtmgt_hotelroomallocation_adx_portalcomments)
- [msevtmgt_hotelroomallocation_Annotations](#BKMK_msevtmgt_hotelroomallocation_Annotations)
- [msevtmgt_hotelroomallocation_Appointments](#BKMK_msevtmgt_hotelroomallocation_Appointments)
- [msevtmgt_hotelroomallocation_AsyncOperations](#BKMK_msevtmgt_hotelroomallocation_AsyncOperations)
- [msevtmgt_hotelroomallocation_BulkDeleteFailures](#BKMK_msevtmgt_hotelroomallocation_BulkDeleteFailures)
- [msevtmgt_hotelroomallocation_chats](#BKMK_msevtmgt_hotelroomallocation_chats)
- [msevtmgt_hotelroomallocation_Emails](#BKMK_msevtmgt_hotelroomallocation_Emails)
- [msevtmgt_hotelroomallocation_Faxes](#BKMK_msevtmgt_hotelroomallocation_Faxes)
- [msevtmgt_hotelroomallocation_Letters](#BKMK_msevtmgt_hotelroomallocation_Letters)
- [msevtmgt_hotelroomallocation_li_inmails](#BKMK_msevtmgt_hotelroomallocation_li_inmails)
- [msevtmgt_hotelroomallocation_li_messages](#BKMK_msevtmgt_hotelroomallocation_li_messages)
- [msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds)
- [msevtmgt_hotelroomallocation_MailboxTrackingFolders](#BKMK_msevtmgt_hotelroomallocation_MailboxTrackingFolders)
- [msevtmgt_hotelroomallocation_msdyn_bookingalerts](#BKMK_msevtmgt_hotelroomallocation_msdyn_bookingalerts)
- [msevtmgt_hotelroomallocation_msdyn_copilottranscripts](#BKMK_msevtmgt_hotelroomallocation_msdyn_copilottranscripts)
- [msevtmgt_hotelroomallocation_msdyn_ocliveworkitems](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems)
- [msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages)
- [msevtmgt_hotelroomallocation_msdyn_ocsessions](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions)
- [msevtmgt_hotelroomallocation_msdyn_ocvoicemails](#BKMK_msevtmgt_hotelroomallocation_msdyn_ocvoicemails)
- [msevtmgt_hotelroomallocation_msfp_alerts](#BKMK_msevtmgt_hotelroomallocation_msfp_alerts)
- [msevtmgt_hotelroomallocation_msfp_surveyinvites](#BKMK_msevtmgt_hotelroomallocation_msfp_surveyinvites)
- [msevtmgt_hotelroomallocation_msfp_surveyresponses](#BKMK_msevtmgt_hotelroomallocation_msfp_surveyresponses)
- [msevtmgt_hotelroomallocation_PhoneCalls](#BKMK_msevtmgt_hotelroomallocation_PhoneCalls)
- [msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses)
- [msevtmgt_hotelroomallocation_ProcessSession](#BKMK_msevtmgt_hotelroomallocation_ProcessSession)
- [msevtmgt_hotelroomallocation_RecurringAppointmentMasters](#BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters)
- [msevtmgt_hotelroomallocation_ServiceAppointments](#BKMK_msevtmgt_hotelroomallocation_ServiceAppointments)
- [msevtmgt_hotelroomallocation_SocialActivities](#BKMK_msevtmgt_hotelroomallocation_SocialActivities)
- [msevtmgt_hotelroomallocation_SyncErrors](#BKMK_msevtmgt_hotelroomallocation_SyncErrors)
- [msevtmgt_hotelroomallocation_Tasks](#BKMK_msevtmgt_hotelroomallocation_Tasks)
- [msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation](#BKMK_msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation)

### <a name="BKMK_msevtmgt_hotelroomallocation_ActivityPointers"></a> msevtmgt_hotelroomallocation_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_hotelroomallocation_ActivityPointers](activitypointer.md#BKMK_msevtmgt_hotelroomallocation_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_adx_alertsubscriptions"></a> msevtmgt_hotelroomallocation_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_hotelroomallocation_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_hotelroomallocation_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_adx_inviteredemptions"></a> msevtmgt_hotelroomallocation_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_hotelroomallocation_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_hotelroomallocation_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_adx_portalcomments"></a> msevtmgt_hotelroomallocation_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_hotelroomallocation_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_hotelroomallocation_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Annotations"></a> msevtmgt_hotelroomallocation_Annotations

Many-To-One Relationship: [annotation msevtmgt_hotelroomallocation_Annotations](annotation.md#BKMK_msevtmgt_hotelroomallocation_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Appointments"></a> msevtmgt_hotelroomallocation_Appointments

Many-To-One Relationship: [appointment msevtmgt_hotelroomallocation_Appointments](appointment.md#BKMK_msevtmgt_hotelroomallocation_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_AsyncOperations"></a> msevtmgt_hotelroomallocation_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_hotelroomallocation_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_hotelroomallocation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_BulkDeleteFailures"></a> msevtmgt_hotelroomallocation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_hotelroomallocation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_hotelroomallocation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_chats"></a> msevtmgt_hotelroomallocation_chats

Many-To-One Relationship: [chat msevtmgt_hotelroomallocation_chats](chat.md#BKMK_msevtmgt_hotelroomallocation_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Emails"></a> msevtmgt_hotelroomallocation_Emails

Many-To-One Relationship: [email msevtmgt_hotelroomallocation_Emails](email.md#BKMK_msevtmgt_hotelroomallocation_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Faxes"></a> msevtmgt_hotelroomallocation_Faxes

Many-To-One Relationship: [fax msevtmgt_hotelroomallocation_Faxes](fax.md#BKMK_msevtmgt_hotelroomallocation_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Letters"></a> msevtmgt_hotelroomallocation_Letters

Many-To-One Relationship: [letter msevtmgt_hotelroomallocation_Letters](letter.md#BKMK_msevtmgt_hotelroomallocation_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_li_inmails"></a> msevtmgt_hotelroomallocation_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_hotelroomallocation_li_inmails](li_inmail.md#BKMK_msevtmgt_hotelroomallocation_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_li_messages"></a> msevtmgt_hotelroomallocation_li_messages

Many-To-One Relationship: [li_message msevtmgt_hotelroomallocation_li_messages](li_message.md#BKMK_msevtmgt_hotelroomallocation_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds"></a> msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_MailboxTrackingFolders"></a> msevtmgt_hotelroomallocation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_hotelroomallocation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_hotelroomallocation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_bookingalerts"></a> msevtmgt_hotelroomallocation_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_hotelroomallocation_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_hotelroomallocation_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_copilottranscripts"></a> msevtmgt_hotelroomallocation_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_hotelroomallocation_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_hotelroomallocation_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems"></a> msevtmgt_hotelroomallocation_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_hotelroomallocation_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages"></a> msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions"></a> msevtmgt_hotelroomallocation_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_hotelroomallocation_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msdyn_ocvoicemails"></a> msevtmgt_hotelroomallocation_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_hotelroomallocation_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_hotelroomallocation_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msfp_alerts"></a> msevtmgt_hotelroomallocation_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_hotelroomallocation_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_hotelroomallocation_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msfp_surveyinvites"></a> msevtmgt_hotelroomallocation_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_hotelroomallocation_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_hotelroomallocation_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_msfp_surveyresponses"></a> msevtmgt_hotelroomallocation_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_hotelroomallocation_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_hotelroomallocation_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_PhoneCalls"></a> msevtmgt_hotelroomallocation_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_hotelroomallocation_PhoneCalls](phonecall.md#BKMK_msevtmgt_hotelroomallocation_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses"></a> msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_ProcessSession"></a> msevtmgt_hotelroomallocation_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_hotelroomallocation_ProcessSession](processsession.md#BKMK_msevtmgt_hotelroomallocation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters"></a> msevtmgt_hotelroomallocation_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_hotelroomallocation_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_ServiceAppointments"></a> msevtmgt_hotelroomallocation_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_hotelroomallocation_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_hotelroomallocation_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_SocialActivities"></a> msevtmgt_hotelroomallocation_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_hotelroomallocation_SocialActivities](socialactivity.md#BKMK_msevtmgt_hotelroomallocation_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_SyncErrors"></a> msevtmgt_hotelroomallocation_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_hotelroomallocation_SyncErrors](syncerror.md#BKMK_msevtmgt_hotelroomallocation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Tasks"></a> msevtmgt_hotelroomallocation_Tasks

Many-To-One Relationship: [task msevtmgt_hotelroomallocation_Tasks](task.md#BKMK_msevtmgt_hotelroomallocation_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotelroomallocation_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation"></a> msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation

Many-To-One Relationship: [msevtmgt_hotelroomreservation msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`msevtmgt_hotelroomallocation`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

