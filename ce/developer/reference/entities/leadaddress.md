---
title: "Lead Address (LeadAddress) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Lead Address (LeadAddress) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Lead Address (LeadAddress) table/entity reference (Microsoft Dynamics 365)

Address information for a lead.

## Messages

The following table lists the messages for the Lead Address (LeadAddress) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /leadaddresses(*leadaddressid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /leadaddresses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the Lead Address (LeadAddress) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead Address** |
| **DisplayCollectionName** | **Lead Addresses** |
| **SchemaName** | `LeadAddress` |
| **CollectionSchemaName** | `LeadAddresses` |
| **EntitySetName** | `leadaddresses`|
| **LogicalName** | `leadaddress` |
| **LogicalCollectionName** | `leadaddresses` |
| **PrimaryIdAttribute** | `leadaddressid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AddressNumber](#BKMK_AddressNumber)
- [AddressTypeCode](#BKMK_AddressTypeCode)
- [City](#BKMK_City)
- [Country](#BKMK_Country)
- [County](#BKMK_County)
- [Fax](#BKMK_Fax)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Latitude](#BKMK_Latitude)
- [LeadAddressId](#BKMK_LeadAddressId)
- [Line1](#BKMK_Line1)
- [Line2](#BKMK_Line2)
- [Line3](#BKMK_Line3)
- [Longitude](#BKMK_Longitude)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentId](#BKMK_ParentId)
- [PostalCode](#BKMK_PostalCode)
- [PostOfficeBox](#BKMK_PostOfficeBox)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [StateOrProvince](#BKMK_StateOrProvince)
- [Telephone1](#BKMK_Telephone1)
- [Telephone2](#BKMK_Telephone2)
- [Telephone3](#BKMK_Telephone3)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UPSZone](#BKMK_UPSZone)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [UTCOffset](#BKMK_UTCOffset)

### <a name="BKMK_AddressNumber"></a> AddressNumber

|Property|Value|
|---|---|
|Description|**Information about the address for the lead.**|
|DisplayName|**Address Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`addressnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_AddressTypeCode"></a> AddressTypeCode

|Property|Value|
|---|---|
|Description|**Type of address for the lead address.**|
|DisplayName|**Address Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`leadaddress_addresstypecode`|

#### AddressTypeCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_City"></a> City

|Property|Value|
|---|---|
|Description|**City name in the address for the lead.**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Country"></a> Country

|Property|Value|
|---|---|
|Description|**Country/region name in the address for the lead.**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_County"></a> County

|Property|Value|
|---|---|
|Description|**County name in the address for the lead.**|
|DisplayName|**County**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|---|---|
|Description|**Fax number for the address for the lead.**|
|DisplayName|**Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

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

### <a name="BKMK_Latitude"></a> Latitude

|Property|Value|
|---|---|
|Description|**Latitude for the address for the lead.**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_LeadAddressId"></a> LeadAddressId

|Property|Value|
|---|---|
|Description|**Unique identifier of the lead address.**|
|DisplayName|**Address**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`leadaddressid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Line1"></a> Line1

|Property|Value|
|---|---|
|Description|**First line for entering address information.**|
|DisplayName|**Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Line2"></a> Line2

|Property|Value|
|---|---|
|Description|**Second line for entering address information.**|
|DisplayName|**Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Line3"></a> Line3

|Property|Value|
|---|---|
|Description|**Third line for entering address information.**|
|DisplayName|**Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Longitude"></a> Longitude

|Property|Value|
|---|---|
|Description|**Longitude for the address for the lead.**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name used to identify the lead address.**|
|DisplayName|**Address Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_ParentId"></a> ParentId

|Property|Value|
|---|---|
|Description|**Unique identifier of the parent object with which the lead address is associated.**|
|DisplayName|**Parent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`parentid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_PostalCode"></a> PostalCode

|Property|Value|
|---|---|
|Description|**ZIP Code or postal code in the address for the lead.**|
|DisplayName|**ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_PostOfficeBox"></a> PostOfficeBox

|Property|Value|
|---|---|
|Description|**Post office box number in the address for the lead.**|
|DisplayName|**Post Office Box**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Method of shipment for the lead.**|
|DisplayName|**Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`leadaddress_shippingmethodcode`|

#### ShippingMethodCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_StateOrProvince"></a> StateOrProvince

|Property|Value|
|---|---|
|Description|**State or province in the address for the lead.**|
|DisplayName|**State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|---|---|
|Description|**First telephone number for the lead address.**|
|DisplayName|**Main Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone2"></a> Telephone2

|Property|Value|
|---|---|
|Description|**Second telephone number for the lead address.**|
|DisplayName|**Phone 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone3"></a> Telephone3

|Property|Value|
|---|---|
|Description|**Third telephone number for the lead address.**|
|DisplayName|**Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the leadaddress.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UPSZone"></a> UPSZone

|Property|Value|
|---|---|
|Description|**United Parcel Service (UPS) zone for the address of the lead.**|
|DisplayName|**UPS Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

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

### <a name="BKMK_UTCOffset"></a> UTCOffset

|Property|Value|
|---|---|
|Description|**UTC offset for the lead address. This is the difference between local time and standard Coordinated Universal Time.**|
|DisplayName|**UTC Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [Composite](#BKMK_Composite)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerId](#BKMK_OwnerId)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_Composite"></a> Composite

|Property|Value|
|---|---|
|Description|**Shows the complete address.**|
|DisplayName|**Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the lead address.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the lead address was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the leadaddress.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the leadaddress with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the lead address.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the lead address was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the leadaddress.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [lead_addresses](#BKMK_lead_addresses)
- [lk_leadaddress_createdonbehalfby](#BKMK_lk_leadaddress_createdonbehalfby)
- [lk_leadaddress_modifiedonbehalfby](#BKMK_lk_leadaddress_modifiedonbehalfby)
- [lk_leadaddressbase_createdby](#BKMK_lk_leadaddressbase_createdby)
- [lk_leadaddressbase_modifiedby](#BKMK_lk_leadaddressbase_modifiedby)
- [TransactionCurrency_LeadAddress](#BKMK_TransactionCurrency_LeadAddress)

### <a name="BKMK_lead_addresses"></a> lead_addresses

One-To-Many Relationship: [lead lead_addresses](lead.md#BKMK_lead_addresses)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`parentid`|
|ReferencingEntityNavigationPropertyName|`parentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadaddress_createdonbehalfby"></a> lk_leadaddress_createdonbehalfby

One-To-Many Relationship: [systemuser lk_leadaddress_createdonbehalfby](systemuser.md#BKMK_lk_leadaddress_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadaddress_modifiedonbehalfby"></a> lk_leadaddress_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_leadaddress_modifiedonbehalfby](systemuser.md#BKMK_lk_leadaddress_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadaddressbase_createdby"></a> lk_leadaddressbase_createdby

One-To-Many Relationship: [systemuser lk_leadaddressbase_createdby](systemuser.md#BKMK_lk_leadaddressbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadaddressbase_modifiedby"></a> lk_leadaddressbase_modifiedby

One-To-Many Relationship: [systemuser lk_leadaddressbase_modifiedby](systemuser.md#BKMK_lk_leadaddressbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

One-To-Many Relationship: [transactioncurrency TransactionCurrency_LeadAddress](transactioncurrency.md#BKMK_TransactionCurrency_LeadAddress)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [leadaddress_AsyncOperations](#BKMK_leadaddress_AsyncOperations)
- [leadaddress_BulkDeleteFailures](#BKMK_leadaddress_BulkDeleteFailures)
- [leadaddress_MailboxTrackingFolders](#BKMK_leadaddress_MailboxTrackingFolders)
- [leadaddress_PrincipalObjectAttributeAccesses](#BKMK_leadaddress_PrincipalObjectAttributeAccesses)
- [LeadAddress_SyncErrors](#BKMK_LeadAddress_SyncErrors)

### <a name="BKMK_leadaddress_AsyncOperations"></a> leadaddress_AsyncOperations

Many-To-One Relationship: [asyncoperation leadaddress_AsyncOperations](asyncoperation.md#BKMK_leadaddress_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadaddress_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadaddress_BulkDeleteFailures"></a> leadaddress_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure leadaddress_BulkDeleteFailures](bulkdeletefailure.md#BKMK_leadaddress_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadaddress_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadaddress_MailboxTrackingFolders"></a> leadaddress_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder leadaddress_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_leadaddress_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadaddress_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadaddress_PrincipalObjectAttributeAccesses"></a> leadaddress_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess leadaddress_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_leadaddress_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`leadaddress_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_LeadAddress_SyncErrors"></a> LeadAddress_SyncErrors

Many-To-One Relationship: [syncerror LeadAddress_SyncErrors](syncerror.md#BKMK_LeadAddress_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`LeadAddress_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

