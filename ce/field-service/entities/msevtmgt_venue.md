---
title: "Venue (msevtmgt_Venue) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Venue (msevtmgt_Venue) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Venue (msevtmgt_Venue) table/entity reference

The venue describes the location at which all event sessions and activities take place. A single event venue can be comprised of zero or more buildings, each of which can have zero or more rooms where sessions take place.

## Messages

The following table lists the messages for the Venue (msevtmgt_Venue) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_venues(*msevtmgt_venueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_venues<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_venues(*msevtmgt_venueid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_venues(*msevtmgt_venueid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_venues<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_venues(*msevtmgt_venueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_venues(*msevtmgt_venueid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_venues(*msevtmgt_venueid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Venue (msevtmgt_Venue) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Venue (msevtmgt_Venue) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Venue** |
| **DisplayCollectionName** | **Venues** |
| **SchemaName** | `msevtmgt_Venue` |
| **CollectionSchemaName** | `msevtmgt_Venues` |
| **EntitySetName** | `msevtmgt_venues`|
| **LogicalName** | `msevtmgt_venue` |
| **LogicalCollectionName** | `msevtmgt_venues` |
| **PrimaryIdAttribute** | `msevtmgt_venueid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AccessibleToilets](#BKMK_msevtmgt_AccessibleToilets)
- [msevtmgt_AdditionalFacilities](#BKMK_msevtmgt_AdditionalFacilities)
- [msevtmgt_AddressLine1](#BKMK_msevtmgt_AddressLine1)
- [msevtmgt_AddressLine2](#BKMK_msevtmgt_AddressLine2)
- [msevtmgt_AddressLine3](#BKMK_msevtmgt_AddressLine3)
- [msevtmgt_BuildingId](#BKMK_msevtmgt_BuildingId)
- [msevtmgt_City](#BKMK_msevtmgt_City)
- [msevtmgt_Cost](#BKMK_msevtmgt_Cost)
- [msevtmgt_Country](#BKMK_msevtmgt_Country)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_DisabledAccess](#BKMK_msevtmgt_DisabledAccess)
- [msevtmgt_DisabledParking](#BKMK_msevtmgt_DisabledParking)
- [msevtmgt_Email](#BKMK_msevtmgt_Email)
- [msevtmgt_EstCapacity](#BKMK_msevtmgt_EstCapacity)
- [msevtmgt_layoutId](#BKMK_msevtmgt_layoutId)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_ParentVenueId](#BKMK_msevtmgt_ParentVenueId)
- [msevtmgt_PostalCode](#BKMK_msevtmgt_PostalCode)
- [msevtmgt_PrimaryContact](#BKMK_msevtmgt_PrimaryContact)
- [msevtmgt_PublicTelephoneAvailable](#BKMK_msevtmgt_PublicTelephoneAvailable)
- [msevtmgt_RoomId](#BKMK_msevtmgt_RoomId)
- [msevtmgt_StateProvince](#BKMK_msevtmgt_StateProvince)
- [msevtmgt_Telephone1](#BKMK_msevtmgt_Telephone1)
- [msevtmgt_Telephone2](#BKMK_msevtmgt_Telephone2)
- [msevtmgt_Telephone3](#BKMK_msevtmgt_Telephone3)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
- [msevtmgt_VenueId](#BKMK_msevtmgt_VenueId)
- [msevtmgt_Website](#BKMK_msevtmgt_Website)
- [msevtmgt_WifiAvailable](#BKMK_msevtmgt_WifiAvailable)
- [msevtmgt_WifiPassword](#BKMK_msevtmgt_WifiPassword)
- [msevtmgt_WifiSSID](#BKMK_msevtmgt_WifiSSID)
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

### <a name="BKMK_msevtmgt_AccessibleToilets"></a> msevtmgt_AccessibleToilets

|Property|Value|
|---|---|
|Description|**Indicates whether accessbile toilets are available for disabled people at this location**|
|DisplayName|**Accessible toilets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_accessibletoilets`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_AccessibleToilets Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_AdditionalFacilities"></a> msevtmgt_AdditionalFacilities

|Property|Value|
|---|---|
|Description|**Additional facilities that aren't covered by the available options**|
|DisplayName|**Additional facilities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_additionalfacilities`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_AddressLine1"></a> msevtmgt_AddressLine1

|Property|Value|
|---|---|
|Description|**Address (not including city, country/region, state or province, or postal code)**|
|DisplayName|**Address line 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msevtmgt_AddressLine2"></a> msevtmgt_AddressLine2

|Property|Value|
|---|---|
|Description|**Additional address details**|
|DisplayName|**Address line 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msevtmgt_AddressLine3"></a> msevtmgt_AddressLine3

|Property|Value|
|---|---|
|Description|**Additional address details**|
|DisplayName|**Address line 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msevtmgt_BuildingId"></a> msevtmgt_BuildingId

|Property|Value|
|---|---|
|Description|**Unique identifier for the building associated with the venue**|
|DisplayName|**Building**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_buildingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_building|

### <a name="BKMK_msevtmgt_City"></a> msevtmgt_City

|Property|Value|
|---|---|
|Description|**The city of the address**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Cost"></a> msevtmgt_Cost

|Property|Value|
|---|---|
|Description|**Cost of the venue**|
|DisplayName|**Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_cost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_Country"></a> msevtmgt_Country

|Property|Value|
|---|---|
|Description|**The country or region of the address**|
|DisplayName|**Country/region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description|**Description of the venue**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_DisabledAccess"></a> msevtmgt_DisabledAccess

|Property|Value|
|---|---|
|Description|**Indicates whether this location provides easy access for disabled people**|
|DisplayName|**Disabled access**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_disabledaccess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_DisabledAccess Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_DisabledParking"></a> msevtmgt_DisabledParking

|Property|Value|
|---|---|
|Description|**Indicates wheter special parking for disabled people is available at this location**|
|DisplayName|**Disable parking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_disabledparking`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_DisabledParking Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_Email"></a> msevtmgt_Email

|Property|Value|
|---|---|
|Description|**Email to contact the venue**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_email`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_EstCapacity"></a> msevtmgt_EstCapacity

|Property|Value|
|---|---|
|Description|**Estimated capacity of the venue**|
|DisplayName|**Est. capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_estcapacity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msevtmgt_layoutId"></a> msevtmgt_layoutId

|Property|Value|
|---|---|
|Description|**Unique identifier for the layout associated with the venue**|
|DisplayName|**Layout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_layoutid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_layout|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_ParentVenueId"></a> msevtmgt_ParentVenueId

|Property|Value|
|---|---|
|Description|**Unique identifier for the venue associated with the venue**|
|DisplayName|**Parent venue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_parentvenueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_venue|

### <a name="BKMK_msevtmgt_PostalCode"></a> msevtmgt_PostalCode

|Property|Value|
|---|---|
|Description|**The postal code of the address**|
|DisplayName|**Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_PrimaryContact"></a> msevtmgt_PrimaryContact

|Property|Value|
|---|---|
|Description|**A person who is responsible for the venue**|
|DisplayName|**Primary contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primarycontact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_PublicTelephoneAvailable"></a> msevtmgt_PublicTelephoneAvailable

|Property|Value|
|---|---|
|Description|**Indicates whether public telephones are available at this location**|
|DisplayName|**Public telephone available**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publictelephoneavailable`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_PublicTelephoneAvailable Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_RoomId"></a> msevtmgt_RoomId

|Property|Value|
|---|---|
|Description|**Unique identifier for the room associated with the venue**|
|DisplayName|**Room**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_roomid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_room|

### <a name="BKMK_msevtmgt_StateProvince"></a> msevtmgt_StateProvince

|Property|Value|
|---|---|
|Description|**The state or province of the address**|
|DisplayName|**State/province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_stateprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Telephone1"></a> msevtmgt_Telephone1

|Property|Value|
|---|---|
|Description|**A telephone number for contacting the venue**|
|DisplayName|**Telephone 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Telephone2"></a> msevtmgt_Telephone2

|Property|Value|
|---|---|
|Description|**A telephone number for contacting the venue**|
|DisplayName|**Telephone 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Telephone3"></a> msevtmgt_Telephone3

|Property|Value|
|---|---|
|Description|**A telephone number for contacting the venue**|
|DisplayName|**Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_TransactionCurrencyId"></a> msevtmgt_TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_msevtmgt_VenueId"></a> msevtmgt_VenueId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Venue**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_venueid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_Website"></a> msevtmgt_Website

|Property|Value|
|---|---|
|Description|**Website for contacting the venue**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_website`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msevtmgt_WifiAvailable"></a> msevtmgt_WifiAvailable

|Property|Value|
|---|---|
|Description|**Indicates whether WiFi is available at this location.**|
|DisplayName|**WiFi available**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_wifiavailable`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_WifiAvailable Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_WifiPassword"></a> msevtmgt_WifiPassword

|Property|Value|
|---|---|
|Description|**Only store public WiFi passwords in this field; do not save internal passwords here**|
|DisplayName|**WiFi password**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_wifipassword`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_WifiSSID"></a> msevtmgt_WifiSSID

|Property|Value|
|---|---|
|Description|**The service set identifier (network name) of the WiFi network**|
|DisplayName|**WiFi SSID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_wifissid`|
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
|Description|**Status of the venue**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_venue_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the venue**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_venue_statuscode`|

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
- [msevtmgt_AddressComposite](#BKMK_msevtmgt_AddressComposite)
- [msevtmgt_cost_Base](#BKMK_msevtmgt_cost_Base)
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

### <a name="BKMK_msevtmgt_AddressComposite"></a> msevtmgt_AddressComposite

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address composite**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addresscomposite`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_cost_Base"></a> msevtmgt_cost_Base

|Property|Value|
|---|---|
|Description|**Value of the cost (in the base currency)**|
|DisplayName|**Cost (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_cost_base`|
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

- [business_unit_msevtmgt_venue](#BKMK_business_unit_msevtmgt_venue)
- [lk_msevtmgt_venue_createdby](#BKMK_lk_msevtmgt_venue_createdby)
- [lk_msevtmgt_venue_createdonbehalfby](#BKMK_lk_msevtmgt_venue_createdonbehalfby)
- [lk_msevtmgt_venue_modifiedby](#BKMK_lk_msevtmgt_venue_modifiedby)
- [lk_msevtmgt_venue_modifiedonbehalfby](#BKMK_lk_msevtmgt_venue_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_venue_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact)
- [msevtmgt_msevtmgt_building_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue)
- [msevtmgt_msevtmgt_layout_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue)
- [msevtmgt_msevtmgt_room_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_room_msevtmgt_venue)
- [msevtmgt_msevtmgt_venue_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-many-to-one)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Venue](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue)
- [owner_msevtmgt_venue](#BKMK_owner_msevtmgt_venue)
- [team_msevtmgt_venue](#BKMK_team_msevtmgt_venue)
- [TransactionCurrency_msevtmgt_Venue](#BKMK_TransactionCurrency_msevtmgt_Venue)
- [user_msevtmgt_venue](#BKMK_user_msevtmgt_venue)

### <a name="BKMK_business_unit_msevtmgt_venue"></a> business_unit_msevtmgt_venue

One-To-Many Relationship: [businessunit business_unit_msevtmgt_venue](businessunit.md#BKMK_business_unit_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_venue_createdby"></a> lk_msevtmgt_venue_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_venue_createdby](systemuser.md#BKMK_lk_msevtmgt_venue_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_venue_createdonbehalfby"></a> lk_msevtmgt_venue_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_venue_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_venue_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_venue_modifiedby"></a> lk_msevtmgt_venue_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_venue_modifiedby](systemuser.md#BKMK_lk_msevtmgt_venue_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_venue_modifiedonbehalfby"></a> lk_msevtmgt_venue_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_venue_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_venue_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact"></a> msevtmgt_contact_msevtmgt_venue_PrimaryContact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_venue_PrimaryContact](contact.md#BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PrimaryContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue"></a> msevtmgt_msevtmgt_building_msevtmgt_venue

One-To-Many Relationship: [msevtmgt_building msevtmgt_msevtmgt_building_msevtmgt_venue](msevtmgt_building.md#BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_building`|
|ReferencedAttribute|`msevtmgt_buildingid`|
|ReferencingAttribute|`msevtmgt_buildingid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_BuildingId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue"></a> msevtmgt_msevtmgt_layout_msevtmgt_venue

One-To-Many Relationship: [msevtmgt_layout msevtmgt_msevtmgt_layout_msevtmgt_venue](msevtmgt_layout.md#BKMK_msevtmgt_msevtmgt_layout_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`msevtmgt_layoutid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_layoutId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_room_msevtmgt_venue"></a> msevtmgt_msevtmgt_room_msevtmgt_venue

One-To-Many Relationship: [msevtmgt_room msevtmgt_msevtmgt_room_msevtmgt_venue](msevtmgt_room.md#BKMK_msevtmgt_msevtmgt_room_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`msevtmgt_roomid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_RoomId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-many-to-one"></a> msevtmgt_msevtmgt_venue_msevtmgt_venue

One-To-Many Relationship: [msevtmgt_venue msevtmgt_msevtmgt_venue_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`msevtmgt_parentvenueid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_ParentVenueId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Venue

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_Venue](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_venue"></a> owner_msevtmgt_venue

One-To-Many Relationship: [owner owner_msevtmgt_venue](owner.md#BKMK_owner_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_venue"></a> team_msevtmgt_venue

One-To-Many Relationship: [team team_msevtmgt_venue](team.md#BKMK_team_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Venue"></a> TransactionCurrency_msevtmgt_Venue

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_Venue](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_Venue)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_venue"></a> user_msevtmgt_venue

One-To-Many Relationship: [systemuser user_msevtmgt_venue](systemuser.md#BKMK_user_msevtmgt_venue)

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

- [msevtmgt_msevtmgt_venue_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-one-to-many)
- [msevtmgt_venue_ActivityPointers](#BKMK_msevtmgt_venue_ActivityPointers)
- [msevtmgt_venue_adx_alertsubscriptions](#BKMK_msevtmgt_venue_adx_alertsubscriptions)
- [msevtmgt_venue_adx_inviteredemptions](#BKMK_msevtmgt_venue_adx_inviteredemptions)
- [msevtmgt_venue_adx_portalcomments](#BKMK_msevtmgt_venue_adx_portalcomments)
- [msevtmgt_venue_Annotations](#BKMK_msevtmgt_venue_Annotations)
- [msevtmgt_venue_Appointments](#BKMK_msevtmgt_venue_Appointments)
- [msevtmgt_venue_AsyncOperations](#BKMK_msevtmgt_venue_AsyncOperations)
- [msevtmgt_venue_BulkDeleteFailures](#BKMK_msevtmgt_venue_BulkDeleteFailures)
- [msevtmgt_venue_chats](#BKMK_msevtmgt_venue_chats)
- [msevtmgt_venue_Emails](#BKMK_msevtmgt_venue_Emails)
- [msevtmgt_venue_Faxes](#BKMK_msevtmgt_venue_Faxes)
- [msevtmgt_venue_Letters](#BKMK_msevtmgt_venue_Letters)
- [msevtmgt_venue_li_inmails](#BKMK_msevtmgt_venue_li_inmails)
- [msevtmgt_venue_li_messages](#BKMK_msevtmgt_venue_li_messages)
- [msevtmgt_venue_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds)
- [msevtmgt_venue_MailboxTrackingFolders](#BKMK_msevtmgt_venue_MailboxTrackingFolders)
- [msevtmgt_venue_msdyn_bookingalerts](#BKMK_msevtmgt_venue_msdyn_bookingalerts)
- [msevtmgt_venue_msdyn_copilottranscripts](#BKMK_msevtmgt_venue_msdyn_copilottranscripts)
- [msevtmgt_venue_msdyn_ocliveworkitems](#BKMK_msevtmgt_venue_msdyn_ocliveworkitems)
- [msevtmgt_venue_msdyn_ocoutboundmessages](#BKMK_msevtmgt_venue_msdyn_ocoutboundmessages)
- [msevtmgt_venue_msdyn_ocsessions](#BKMK_msevtmgt_venue_msdyn_ocsessions)
- [msevtmgt_venue_msdyn_ocvoicemails](#BKMK_msevtmgt_venue_msdyn_ocvoicemails)
- [msevtmgt_venue_msevtmgt_event_PrimaryVenue](#BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue)
- [msevtmgt_Venue_msevtmgt_Session_Venue](#BKMK_msevtmgt_Venue_msevtmgt_Session_Venue)
- [msevtmgt_venue_msfp_alerts](#BKMK_msevtmgt_venue_msfp_alerts)
- [msevtmgt_venue_msfp_surveyinvites](#BKMK_msevtmgt_venue_msfp_surveyinvites)
- [msevtmgt_venue_msfp_surveyresponses](#BKMK_msevtmgt_venue_msfp_surveyresponses)
- [msevtmgt_venue_PhoneCalls](#BKMK_msevtmgt_venue_PhoneCalls)
- [msevtmgt_venue_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_venue_PrincipalObjectAttributeAccesses)
- [msevtmgt_venue_ProcessSession](#BKMK_msevtmgt_venue_ProcessSession)
- [msevtmgt_venue_RecurringAppointmentMasters](#BKMK_msevtmgt_venue_RecurringAppointmentMasters)
- [msevtmgt_venue_ServiceAppointments](#BKMK_msevtmgt_venue_ServiceAppointments)
- [msevtmgt_venue_SocialActivities](#BKMK_msevtmgt_venue_SocialActivities)
- [msevtmgt_venue_SyncErrors](#BKMK_msevtmgt_venue_SyncErrors)
- [msevtmgt_venue_Tasks](#BKMK_msevtmgt_venue_Tasks)

### <a name="BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-one-to-many"></a> msevtmgt_msevtmgt_venue_msevtmgt_venue

Many-To-One Relationship: [msevtmgt_venue msevtmgt_msevtmgt_venue_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_venue_msevtmgt_venue-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`msevtmgt_parentvenueid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_venue_msevtmgt_venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_ActivityPointers"></a> msevtmgt_venue_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_venue_ActivityPointers](activitypointer.md#BKMK_msevtmgt_venue_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_adx_alertsubscriptions"></a> msevtmgt_venue_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_venue_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_venue_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_adx_inviteredemptions"></a> msevtmgt_venue_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_venue_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_venue_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_adx_portalcomments"></a> msevtmgt_venue_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_venue_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_venue_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Annotations"></a> msevtmgt_venue_Annotations

Many-To-One Relationship: [annotation msevtmgt_venue_Annotations](annotation.md#BKMK_msevtmgt_venue_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Appointments"></a> msevtmgt_venue_Appointments

Many-To-One Relationship: [appointment msevtmgt_venue_Appointments](appointment.md#BKMK_msevtmgt_venue_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_AsyncOperations"></a> msevtmgt_venue_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_venue_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_venue_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_BulkDeleteFailures"></a> msevtmgt_venue_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_venue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_venue_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_chats"></a> msevtmgt_venue_chats

Many-To-One Relationship: [chat msevtmgt_venue_chats](chat.md#BKMK_msevtmgt_venue_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Emails"></a> msevtmgt_venue_Emails

Many-To-One Relationship: [email msevtmgt_venue_Emails](email.md#BKMK_msevtmgt_venue_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Faxes"></a> msevtmgt_venue_Faxes

Many-To-One Relationship: [fax msevtmgt_venue_Faxes](fax.md#BKMK_msevtmgt_venue_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Letters"></a> msevtmgt_venue_Letters

Many-To-One Relationship: [letter msevtmgt_venue_Letters](letter.md#BKMK_msevtmgt_venue_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_li_inmails"></a> msevtmgt_venue_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_venue_li_inmails](li_inmail.md#BKMK_msevtmgt_venue_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_li_messages"></a> msevtmgt_venue_li_messages

Many-To-One Relationship: [li_message msevtmgt_venue_li_messages](li_message.md#BKMK_msevtmgt_venue_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds"></a> msevtmgt_venue_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_venue_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_MailboxTrackingFolders"></a> msevtmgt_venue_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_venue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_venue_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_bookingalerts"></a> msevtmgt_venue_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_venue_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_venue_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_copilottranscripts"></a> msevtmgt_venue_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_venue_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_venue_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocliveworkitems"></a> msevtmgt_venue_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_venue_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_venue_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocoutboundmessages"></a> msevtmgt_venue_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_venue_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_venue_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocsessions"></a> msevtmgt_venue_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_venue_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_venue_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msdyn_ocvoicemails"></a> msevtmgt_venue_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_venue_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_venue_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue"></a> msevtmgt_venue_msevtmgt_event_PrimaryVenue

Many-To-One Relationship: [msevtmgt_event msevtmgt_venue_msevtmgt_event_PrimaryVenue](msevtmgt_event.md#BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_primaryvenue`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msevtmgt_event_PrimaryVenue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Venue_msevtmgt_Session_Venue"></a> msevtmgt_Venue_msevtmgt_Session_Venue

Many-To-One Relationship: [msevtmgt_session msevtmgt_Venue_msevtmgt_Session_Venue](msevtmgt_session.md#BKMK_msevtmgt_Venue_msevtmgt_Session_Venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_venue`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Venue_msevtmgt_Session_Venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msfp_alerts"></a> msevtmgt_venue_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_venue_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_venue_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msfp_surveyinvites"></a> msevtmgt_venue_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_venue_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_venue_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_msfp_surveyresponses"></a> msevtmgt_venue_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_venue_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_venue_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_PhoneCalls"></a> msevtmgt_venue_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_venue_PhoneCalls](phonecall.md#BKMK_msevtmgt_venue_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_PrincipalObjectAttributeAccesses"></a> msevtmgt_venue_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_venue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_venue_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_ProcessSession"></a> msevtmgt_venue_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_venue_ProcessSession](processsession.md#BKMK_msevtmgt_venue_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_RecurringAppointmentMasters"></a> msevtmgt_venue_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_venue_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_venue_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_ServiceAppointments"></a> msevtmgt_venue_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_venue_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_venue_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_SocialActivities"></a> msevtmgt_venue_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_venue_SocialActivities](socialactivity.md#BKMK_msevtmgt_venue_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_SyncErrors"></a> msevtmgt_venue_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_venue_SyncErrors](syncerror.md#BKMK_msevtmgt_venue_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_venue_Tasks"></a> msevtmgt_venue_Tasks

Many-To-One Relationship: [task msevtmgt_venue_Tasks](task.md#BKMK_msevtmgt_venue_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_venue_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

