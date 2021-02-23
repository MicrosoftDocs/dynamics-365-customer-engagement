---
title: "LeadAddress Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the LeadAddress entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# LeadAddress Entity Reference

Address information for a lead.

**Added by**: Lead Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/leadaddresses(*leadaddressid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/leadaddresses<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|LeadAddresses|
|DisplayCollectionName|Lead Addresses|
|DisplayName|Lead Address|
|EntitySetName|leadaddresses|
|IsBPFEntity|False|
|LogicalCollectionName|leadaddresses|
|LogicalName|leadaddress|
|OwnershipType|None|
|PrimaryIdAttribute|leadaddressid|
|PrimaryNameAttribute|name|
|SchemaName|LeadAddress|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Information about the address for the lead.|
|DisplayName|Address Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|addressnumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_AddressTypeCode"></a> AddressTypeCode

|Property|Value|
|--------|-----|
|Description|Type of address for the lead address.|
|DisplayName|Address Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|addresstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### AddressTypeCode Options

|Value|Label|
|-----|-----|




### <a name="BKMK_City"></a> City

|Property|Value|
|--------|-----|
|Description|City name in the address for the lead.|
|DisplayName|City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Country"></a> Country

|Property|Value|
|--------|-----|
|Description|Country/region name in the address for the lead.|
|DisplayName|Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_County"></a> County

|Property|Value|
|--------|-----|
|Description|County name in the address for the lead.|
|DisplayName|County|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|county|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|--------|-----|
|Description|Fax number for the address for the lead.|
|DisplayName|Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Latitude"></a> Latitude

|Property|Value|
|--------|-----|
|Description|Latitude for the address for the lead.|
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_LeadAddressId"></a> LeadAddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the lead address.|
|DisplayName|Address|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|leadaddressid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Line1"></a> Line1

|Property|Value|
|--------|-----|
|Description|First line for entering address information.|
|DisplayName|Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Line2"></a> Line2

|Property|Value|
|--------|-----|
|Description|Second line for entering address information.|
|DisplayName|Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Line3"></a> Line3

|Property|Value|
|--------|-----|
|Description|Third line for entering address information.|
|DisplayName|Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Longitude"></a> Longitude

|Property|Value|
|--------|-----|
|Description|Longitude for the address for the lead.|
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name used to identify the lead address.|
|DisplayName|Address Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ParentId"></a> ParentId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the parent object with which the lead address is associated.|
|DisplayName|Parent|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentid|
|RequiredLevel|SystemRequired|
|Targets|lead|
|Type|Lookup|


### <a name="BKMK_PostalCode"></a> PostalCode

|Property|Value|
|--------|-----|
|Description|ZIP Code or postal code in the address for the lead.|
|DisplayName|ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PostOfficeBox"></a> PostOfficeBox

|Property|Value|
|--------|-----|
|Description|Post office box number in the address for the lead.|
|DisplayName|Post Office Box|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|postofficebox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Method of shipment for the lead.|
|DisplayName|Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Options

|Value|Label|
|-----|-----|




### <a name="BKMK_StateOrProvince"></a> StateOrProvince

|Property|Value|
|--------|-----|
|Description|State or province in the address for the lead.|
|DisplayName|State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|--------|-----|
|Description|First telephone number for the lead address.|
|DisplayName|Main Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|telephone1|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Telephone2"></a> Telephone2

|Property|Value|
|--------|-----|
|Description|Second telephone number for the lead address.|
|DisplayName|Phone 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|telephone2|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Telephone3"></a> Telephone3

|Property|Value|
|--------|-----|
|Description|Third telephone number for the lead address.|
|DisplayName|Telephone 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the leadaddress.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UPSZone"></a> UPSZone

|Property|Value|
|--------|-----|
|Description|United Parcel Service (UPS) zone for the address of the lead.|
|DisplayName|UPS Zone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|upszone|
|MaxLength|4|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCOffset"></a> UTCOffset

|Property|Value|
|--------|-----|
|Description|UTC offset for the lead address. This is the difference between local time and standard Coordinated Universal Time.|
|DisplayName|UTC Offset|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|utcoffset|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [Composite](#BKMK_Composite)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerId](#BKMK_OwnerId)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [ParentIdName](#BKMK_ParentIdName)
- [ParentIdYomiName](#BKMK_ParentIdYomiName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_Composite"></a> Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete address.|
|DisplayName|Address|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the lead address.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the lead address was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the leadaddress.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the leadaddress with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the lead address.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the lead address was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the leadaddress.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ParentIdName"></a> ParentIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentIdYomiName"></a> ParentIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [LeadAddress_SyncErrors](#BKMK_LeadAddress_SyncErrors)
- [leadaddress_AsyncOperations](#BKMK_leadaddress_AsyncOperations)
- [leadaddress_MailboxTrackingFolders](#BKMK_leadaddress_MailboxTrackingFolders)
- [leadaddress_BulkDeleteFailures](#BKMK_leadaddress_BulkDeleteFailures)
- [leadaddress_PrincipalObjectAttributeAccesses](#BKMK_leadaddress_PrincipalObjectAttributeAccesses)


### <a name="BKMK_LeadAddress_SyncErrors"></a> LeadAddress_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [LeadAddress_SyncErrors](syncerror.md#BKMK_LeadAddress_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|LeadAddress_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_leadaddress_AsyncOperations"></a> leadaddress_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [leadaddress_AsyncOperations](asyncoperation.md#BKMK_leadaddress_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|leadaddress_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_leadaddress_MailboxTrackingFolders"></a> leadaddress_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [leadaddress_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_leadaddress_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|leadaddress_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_leadaddress_BulkDeleteFailures"></a> leadaddress_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [leadaddress_BulkDeleteFailures](bulkdeletefailure.md#BKMK_leadaddress_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|leadaddress_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_leadaddress_PrincipalObjectAttributeAccesses"></a> leadaddress_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [leadaddress_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_leadaddress_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|leadaddress_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_leadaddressbase_createdby](#BKMK_lk_leadaddressbase_createdby)
- [lk_leadaddress_createdonbehalfby](#BKMK_lk_leadaddress_createdonbehalfby)
- [lk_leadaddressbase_modifiedby](#BKMK_lk_leadaddressbase_modifiedby)
- [lk_leadaddress_modifiedonbehalfby](#BKMK_lk_leadaddress_modifiedonbehalfby)
- [lead_addresses](#BKMK_lead_addresses)
- [TransactionCurrency_LeadAddress](#BKMK_TransactionCurrency_LeadAddress)


### <a name="BKMK_lk_leadaddressbase_createdby"></a> lk_leadaddressbase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_leadaddressbase_createdby](systemuser.md#BKMK_lk_leadaddressbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_leadaddress_createdonbehalfby"></a> lk_leadaddress_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_leadaddress_createdonbehalfby](systemuser.md#BKMK_lk_leadaddress_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_leadaddressbase_modifiedby"></a> lk_leadaddressbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_leadaddressbase_modifiedby](systemuser.md#BKMK_lk_leadaddressbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_leadaddress_modifiedonbehalfby"></a> lk_leadaddress_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_leadaddress_modifiedonbehalfby](systemuser.md#BKMK_lk_leadaddress_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lead_addresses"></a> lead_addresses

See lead Entity [lead_addresses](lead.md#BKMK_lead_addresses) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_LeadAddress](transactioncurrency.md#BKMK_TransactionCurrency_LeadAddress) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.leadaddress?text=leadaddress EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]