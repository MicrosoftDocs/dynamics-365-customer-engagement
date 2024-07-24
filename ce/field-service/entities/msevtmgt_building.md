---
title: "Building (msevtmgt_Building) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Building (msevtmgt_Building) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Building (msevtmgt_Building) table/entity reference

A single venue can be comprised of zero or more buildings where event activities are held. Each building in turn is comprised of zero or more rooms where event activities are held.

## Messages

The following table lists the messages for the Building (msevtmgt_Building) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_buildings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_buildings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_buildings(*msevtmgt_buildingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Building (msevtmgt_Building) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Building (msevtmgt_Building) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Building** |
| **DisplayCollectionName** | **Buildings** |
| **SchemaName** | `msevtmgt_Building` |
| **CollectionSchemaName** | `msevtmgt_Buildings` |
| **EntitySetName** | `msevtmgt_buildings`|
| **LogicalName** | `msevtmgt_building` |
| **LogicalCollectionName** | `msevtmgt_buildings` |
| **PrimaryIdAttribute** | `msevtmgt_buildingid` |
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
- [msevtmgt_EstimatedCapacity](#BKMK_msevtmgt_EstimatedCapacity)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_PostalCode](#BKMK_msevtmgt_PostalCode)
- [msevtmgt_PrimaryContact](#BKMK_msevtmgt_PrimaryContact)
- [msevtmgt_PublicTelephoneAvailable](#BKMK_msevtmgt_PublicTelephoneAvailable)
- [msevtmgt_StateProvince](#BKMK_msevtmgt_StateProvince)
- [msevtmgt_Telephone1](#BKMK_msevtmgt_Telephone1)
- [msevtmgt_Telephone2](#BKMK_msevtmgt_Telephone2)
- [msevtmgt_Telephone3](#BKMK_msevtmgt_Telephone3)
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
|Description|**Unique identifier for entity instances**|
|DisplayName|**Building**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_buildingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Cost (of using the building)**|
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
|Description|**Description of the building**|
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
|DisplayName|**Disabled parking**|
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
|Description|**Email to contact the building**|
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

### <a name="BKMK_msevtmgt_EstimatedCapacity"></a> msevtmgt_EstimatedCapacity

|Property|Value|
|---|---|
|Description|**Estimated capacity of building**|
|DisplayName|**Estimated capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_estimatedcapacity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**A person who is responsible for the building**|
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
|Description|**A telephone number for contacting the building**|
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
|Description|**A telephone number for contacting the building**|
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
|Description|**A telephone number for contacting the building**|
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

### <a name="BKMK_msevtmgt_Website"></a> msevtmgt_Website

|Property|Value|
|---|---|
|Description|**Website for contacting the building**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_website`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the building**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_building_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the building**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_building_statuscode`|

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
- [msevtmgt_addresscomposite](#BKMK_msevtmgt_addresscomposite)
- [msevtmgt_cost_Base](#BKMK_msevtmgt_cost_Base)
- [msevtmgt_NumberOfRooms](#BKMK_msevtmgt_NumberOfRooms)
- [msevtmgt_NumberOfRooms_Date](#BKMK_msevtmgt_NumberOfRooms_Date)
- [msevtmgt_NumberOfRooms_State](#BKMK_msevtmgt_NumberOfRooms_State)
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

### <a name="BKMK_msevtmgt_addresscomposite"></a> msevtmgt_addresscomposite

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

### <a name="BKMK_msevtmgt_NumberOfRooms"></a> msevtmgt_NumberOfRooms

|Property|Value|
|---|---|
|Description|**Number of available rooms**|
|DisplayName|**Number of rooms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofrooms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_NumberOfRooms_Date"></a> msevtmgt_NumberOfRooms_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Number of rooms.**|
|DisplayName|**Number of rooms (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofrooms_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_NumberOfRooms_State"></a> msevtmgt_NumberOfRooms_State

|Property|Value|
|---|---|
|Description|**State of rollup field Number of rooms.**|
|DisplayName|**Number of rooms (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofrooms_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

- [business_unit_msevtmgt_building](#BKMK_business_unit_msevtmgt_building)
- [lk_msevtmgt_building_createdby](#BKMK_lk_msevtmgt_building_createdby)
- [lk_msevtmgt_building_createdonbehalfby](#BKMK_lk_msevtmgt_building_createdonbehalfby)
- [lk_msevtmgt_building_modifiedby](#BKMK_lk_msevtmgt_building_modifiedby)
- [lk_msevtmgt_building_modifiedonbehalfby](#BKMK_lk_msevtmgt_building_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_building_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact)
- [owner_msevtmgt_building](#BKMK_owner_msevtmgt_building)
- [team_msevtmgt_building](#BKMK_team_msevtmgt_building)
- [TransactionCurrency_msevtmgt_Building](#BKMK_TransactionCurrency_msevtmgt_Building)
- [user_msevtmgt_building](#BKMK_user_msevtmgt_building)

### <a name="BKMK_business_unit_msevtmgt_building"></a> business_unit_msevtmgt_building

One-To-Many Relationship: [businessunit business_unit_msevtmgt_building](businessunit.md#BKMK_business_unit_msevtmgt_building)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_building_createdby"></a> lk_msevtmgt_building_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_building_createdby](systemuser.md#BKMK_lk_msevtmgt_building_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_building_createdonbehalfby"></a> lk_msevtmgt_building_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_building_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_building_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_building_modifiedby"></a> lk_msevtmgt_building_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_building_modifiedby](systemuser.md#BKMK_lk_msevtmgt_building_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_building_modifiedonbehalfby"></a> lk_msevtmgt_building_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_building_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_building_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact"></a> msevtmgt_contact_msevtmgt_building_PrimaryContact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_building_PrimaryContact](contact.md#BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PrimaryContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_building"></a> owner_msevtmgt_building

One-To-Many Relationship: [owner owner_msevtmgt_building](owner.md#BKMK_owner_msevtmgt_building)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_building"></a> team_msevtmgt_building

One-To-Many Relationship: [team team_msevtmgt_building](team.md#BKMK_team_msevtmgt_building)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Building"></a> TransactionCurrency_msevtmgt_Building

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_Building](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_Building)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_building"></a> user_msevtmgt_building

One-To-Many Relationship: [systemuser user_msevtmgt_building](systemuser.md#BKMK_user_msevtmgt_building)

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

- [msevtmgt_building_AsyncOperations](#BKMK_msevtmgt_building_AsyncOperations)
- [msevtmgt_building_BulkDeleteFailures](#BKMK_msevtmgt_building_BulkDeleteFailures)
- [msevtmgt_building_MailboxTrackingFolders](#BKMK_msevtmgt_building_MailboxTrackingFolders)
- [msevtmgt_building_msevtmgt_room_Building](#BKMK_msevtmgt_building_msevtmgt_room_Building)
- [msevtmgt_building_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_building_PrincipalObjectAttributeAccesses)
- [msevtmgt_building_ProcessSession](#BKMK_msevtmgt_building_ProcessSession)
- [msevtmgt_building_SyncErrors](#BKMK_msevtmgt_building_SyncErrors)
- [msevtmgt_event_building](#BKMK_msevtmgt_event_building)
- [msevtmgt_msevtmgt_building_msevtmgt_venue](#BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue)
- [msevtmgt_session_building](#BKMK_msevtmgt_session_building)

### <a name="BKMK_msevtmgt_building_AsyncOperations"></a> msevtmgt_building_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_building_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_building_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_BulkDeleteFailures"></a> msevtmgt_building_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_building_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_building_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_MailboxTrackingFolders"></a> msevtmgt_building_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_building_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_building_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_msevtmgt_room_Building"></a> msevtmgt_building_msevtmgt_room_Building

Many-To-One Relationship: [msevtmgt_room msevtmgt_building_msevtmgt_room_Building](msevtmgt_room.md#BKMK_msevtmgt_building_msevtmgt_room_Building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_room`|
|ReferencingAttribute|`msevtmgt_building`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_msevtmgt_room_Building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_PrincipalObjectAttributeAccesses"></a> msevtmgt_building_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_building_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_building_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_ProcessSession"></a> msevtmgt_building_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_building_ProcessSession](processsession.md#BKMK_msevtmgt_building_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_building_SyncErrors"></a> msevtmgt_building_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_building_SyncErrors](syncerror.md#BKMK_msevtmgt_building_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_building_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_building"></a> msevtmgt_event_building

Many-To-One Relationship: [msevtmgt_event msevtmgt_event_building](msevtmgt_event.md#BKMK_msevtmgt_event_building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_building`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue"></a> msevtmgt_msevtmgt_building_msevtmgt_venue

Many-To-One Relationship: [msevtmgt_venue msevtmgt_msevtmgt_building_msevtmgt_venue](msevtmgt_venue.md#BKMK_msevtmgt_msevtmgt_building_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`msevtmgt_buildingid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_building_msevtmgt_venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_session_building"></a> msevtmgt_session_building

Many-To-One Relationship: [msevtmgt_session msevtmgt_session_building](msevtmgt_session.md#BKMK_msevtmgt_session_building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_building`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_session_building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

