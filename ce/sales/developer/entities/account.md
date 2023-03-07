---
title: "Account table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Account table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# Account table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Business that represents a customer or potential customer. The company that is billed in business transactions.


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|Merge|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Accounts|
|DisplayCollectionName|Accounts|
|DisplayName|Account|
|EntitySetName|accounts|
|IsBPFEntity|False|
|LogicalCollectionName|accounts|
|LogicalName|account|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|accountid|
|PrimaryNameAttribute|name|
|SchemaName|Account|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AccountCategoryCode](#BKMK_AccountCategoryCode)
- [AccountClassificationCode](#BKMK_AccountClassificationCode)
- [AccountId](#BKMK_AccountId)
- [AccountNumber](#BKMK_AccountNumber)
- [AccountRatingCode](#BKMK_AccountRatingCode)
- [Address1_AddressId](#BKMK_Address1_AddressId)
- [Address1_AddressTypeCode](#BKMK_Address1_AddressTypeCode)
- [Address1_City](#BKMK_Address1_City)
- [Address1_Country](#BKMK_Address1_Country)
- [Address1_County](#BKMK_Address1_County)
- [Address1_Fax](#BKMK_Address1_Fax)
- [Address1_FreightTermsCode](#BKMK_Address1_FreightTermsCode)
- [Address1_Latitude](#BKMK_Address1_Latitude)
- [Address1_Line1](#BKMK_Address1_Line1)
- [Address1_Line2](#BKMK_Address1_Line2)
- [Address1_Line3](#BKMK_Address1_Line3)
- [Address1_Longitude](#BKMK_Address1_Longitude)
- [Address1_Name](#BKMK_Address1_Name)
- [Address1_PostalCode](#BKMK_Address1_PostalCode)
- [Address1_PostOfficeBox](#BKMK_Address1_PostOfficeBox)
- [Address1_PrimaryContactName](#BKMK_Address1_PrimaryContactName)
- [Address1_ShippingMethodCode](#BKMK_Address1_ShippingMethodCode)
- [Address1_StateOrProvince](#BKMK_Address1_StateOrProvince)
- [Address1_Telephone1](#BKMK_Address1_Telephone1)
- [Address1_Telephone2](#BKMK_Address1_Telephone2)
- [Address1_Telephone3](#BKMK_Address1_Telephone3)
- [Address1_UPSZone](#BKMK_Address1_UPSZone)
- [Address1_UTCOffset](#BKMK_Address1_UTCOffset)
- [Address2_AddressId](#BKMK_Address2_AddressId)
- [Address2_AddressTypeCode](#BKMK_Address2_AddressTypeCode)
- [Address2_City](#BKMK_Address2_City)
- [Address2_Country](#BKMK_Address2_Country)
- [Address2_County](#BKMK_Address2_County)
- [Address2_Fax](#BKMK_Address2_Fax)
- [Address2_FreightTermsCode](#BKMK_Address2_FreightTermsCode)
- [Address2_Latitude](#BKMK_Address2_Latitude)
- [Address2_Line1](#BKMK_Address2_Line1)
- [Address2_Line2](#BKMK_Address2_Line2)
- [Address2_Line3](#BKMK_Address2_Line3)
- [Address2_Longitude](#BKMK_Address2_Longitude)
- [Address2_Name](#BKMK_Address2_Name)
- [Address2_PostalCode](#BKMK_Address2_PostalCode)
- [Address2_PostOfficeBox](#BKMK_Address2_PostOfficeBox)
- [Address2_PrimaryContactName](#BKMK_Address2_PrimaryContactName)
- [Address2_ShippingMethodCode](#BKMK_Address2_ShippingMethodCode)
- [Address2_StateOrProvince](#BKMK_Address2_StateOrProvince)
- [Address2_Telephone1](#BKMK_Address2_Telephone1)
- [Address2_Telephone2](#BKMK_Address2_Telephone2)
- [Address2_Telephone3](#BKMK_Address2_Telephone3)
- [Address2_UPSZone](#BKMK_Address2_UPSZone)
- [Address2_UTCOffset](#BKMK_Address2_UTCOffset)
- [BusinessTypeCode](#BKMK_BusinessTypeCode)
- [CreditLimit](#BKMK_CreditLimit)
- [CreditOnHold](#BKMK_CreditOnHold)
- [CustomerSizeCode](#BKMK_CustomerSizeCode)
- [CustomerTypeCode](#BKMK_CustomerTypeCode)
- [DefaultPriceLevelId](#BKMK_DefaultPriceLevelId)
- [Description](#BKMK_Description)
- [DoNotBulkEMail](#BKMK_DoNotBulkEMail)
- [DoNotBulkPostalMail](#BKMK_DoNotBulkPostalMail)
- [DoNotEMail](#BKMK_DoNotEMail)
- [DoNotFax](#BKMK_DoNotFax)
- [DoNotPhone](#BKMK_DoNotPhone)
- [DoNotPostalMail](#BKMK_DoNotPostalMail)
- [DoNotSendMM](#BKMK_DoNotSendMM)
- [EMailAddress1](#BKMK_EMailAddress1)
- [EMailAddress2](#BKMK_EMailAddress2)
- [EMailAddress3](#BKMK_EMailAddress3)
- [EntityImage](#BKMK_EntityImage)
- [Fax](#BKMK_Fax)
- [FollowEmail](#BKMK_FollowEmail)
- [FtpSiteURL](#BKMK_FtpSiteURL)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IndustryCode](#BKMK_IndustryCode)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LastUsedInCampaign](#BKMK_LastUsedInCampaign)
- [MarketCap](#BKMK_MarketCap)
- [MarketingOnly](#BKMK_MarketingOnly)
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_salesaccelerationinsightid](#BKMK_msdyn_salesaccelerationinsightid)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [Name](#BKMK_Name)
- [NumberOfEmployees](#BKMK_NumberOfEmployees)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnershipCode](#BKMK_OwnershipCode)
- [ParentAccountId](#BKMK_ParentAccountId)
- [ParticipatesInWorkflow](#BKMK_ParticipatesInWorkflow)
- [PaymentTermsCode](#BKMK_PaymentTermsCode)
- [PreferredAppointmentDayCode](#BKMK_PreferredAppointmentDayCode)
- [PreferredAppointmentTimeCode](#BKMK_PreferredAppointmentTimeCode)
- [PreferredContactMethodCode](#BKMK_PreferredContactMethodCode)
- [PreferredEquipmentId](#BKMK_PreferredEquipmentId)
- [PreferredServiceId](#BKMK_PreferredServiceId)
- [PreferredSystemUserId](#BKMK_PreferredSystemUserId)
- [PrimaryContactId](#BKMK_PrimaryContactId)
- [PrimarySatoriId](#BKMK_PrimarySatoriId)
- [PrimaryTwitterId](#BKMK_PrimaryTwitterId)
- [ProcessId](#BKMK_ProcessId)
- [Revenue](#BKMK_Revenue)
- [SharesOutstanding](#BKMK_SharesOutstanding)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [SIC](#BKMK_SIC)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [StockExchange](#BKMK_StockExchange)
- [TeamsFollowed](#BKMK_TeamsFollowed)
- [Telephone1](#BKMK_Telephone1)
- [Telephone2](#BKMK_Telephone2)
- [Telephone3](#BKMK_Telephone3)
- [TerritoryCode](#BKMK_TerritoryCode)
- [TerritoryId](#BKMK_TerritoryId)
- [TickerSymbol](#BKMK_TickerSymbol)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WebSiteURL](#BKMK_WebSiteURL)
- [YomiName](#BKMK_YomiName)


### <a name="BKMK_AccountCategoryCode"></a> AccountCategoryCode

|Property|Value|
|--------|-----|
|Description|Select a category to indicate whether the customer account is standard or preferred.|
|DisplayName|Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|accountcategorycode|
|RequiredLevel|None|
|Type|Picklist|

#### AccountCategoryCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Preferred Customer||
|2|Standard||



### <a name="BKMK_AccountClassificationCode"></a> AccountClassificationCode

|Property|Value|
|--------|-----|
|Description|Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.|
|DisplayName|Classification|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|accountclassificationcode|
|RequiredLevel|None|
|Type|Picklist|

#### AccountClassificationCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|accountid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_AccountNumber"></a> AccountNumber

|Property|Value|
|--------|-----|
|Description|Type an ID number or code for the account to quickly search and identify the account in system views.|
|DisplayName|Account Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|accountnumber|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountRatingCode"></a> AccountRatingCode

|Property|Value|
|--------|-----|
|Description|Select a rating to indicate the value of the customer account.|
|DisplayName|Account Rating|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|accountratingcode|
|RequiredLevel|None|
|Type|Picklist|

#### AccountRatingCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address1_AddressId"></a> Address1_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier for address 1.|
|DisplayName|Address 1: ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|address1_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

|Property|Value|
|--------|-----|
|Description|Select the primary address type.|
|DisplayName|Address 1: Address Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_addresstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Address1_AddressTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Bill To||
|2|Ship To||
|3|Primary||
|4|Other||



### <a name="BKMK_Address1_City"></a> Address1_City

|Property|Value|
|--------|-----|
|Description|Type the city for the primary address.|
|DisplayName|Address 1: City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Country"></a> Address1_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the primary address.|
|DisplayName|Address 1: Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_County"></a> Address1_County

|Property|Value|
|--------|-----|
|Description|Type the county for the primary address.|
|DisplayName|Address 1: County|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_county|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Fax"></a> Address1_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number associated with the primary address.|
|DisplayName|Address 1: Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_FreightTermsCode"></a> Address1_FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms for the primary address to make sure shipping orders are processed correctly.|
|DisplayName|Address 1: Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### Address1_FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|FOB||
|2|No Charge||



### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

|Property|Value|
|--------|-----|
|Description|Type the latitude value for the primary address for use in mapping and other applications.|
|DisplayName|Address 1: Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address1_Line1"></a> Address1_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the primary address.|
|DisplayName|Address 1: Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Line2"></a> Address1_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the primary address.|
|DisplayName|Address 1: Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Line3"></a> Address1_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the primary address.|
|DisplayName|Address 1: Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

|Property|Value|
|--------|-----|
|Description|Type the longitude value for the primary address for use in mapping and other applications.|
|DisplayName|Address 1: Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address1_Name"></a> Address1_Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the primary address, such as Corporate Headquarters.|
|DisplayName|Address 1: Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the primary address.|
|DisplayName|Address 1: ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

|Property|Value|
|--------|-----|
|Description|Type the post office box number of the primary address.|
|DisplayName|Address 1: Post Office Box|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_postofficebox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PrimaryContactName"></a> Address1_PrimaryContactName

|Property|Value|
|--------|-----|
|Description|Type the name of the main contact at the account's primary address.|
|DisplayName|Address 1: Primary Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_primarycontactname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Select a shipping method for deliveries sent to this address.|
|DisplayName|Address 1: Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### Address1_ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Airborne||
|2|DHL||
|3|FedEx||
|4|UPS||
|5|Postal Mail||
|6|Full Load||
|7|Will Call||



### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province of the primary address.|
|DisplayName|Address 1: State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

|Property|Value|
|--------|-----|
|Description|Type the main phone number associated with the primary address.|
|DisplayName|Address Phone|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone1|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

|Property|Value|
|--------|-----|
|Description|Type a second phone number associated with the primary address.|
|DisplayName|Address 1: Telephone 2|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone2|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

|Property|Value|
|--------|-----|
|Description|Type a third phone number associated with the primary address.|
|DisplayName|Address 1: Telephone 3|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

|Property|Value|
|--------|-----|
|Description|Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.|
|DisplayName|Address 1: UPS Zone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_upszone|
|MaxLength|4|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

|Property|Value|
|--------|-----|
|Description|Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.|
|DisplayName|Address 1: UTC Offset|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_utcoffset|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier for address 2.|
|DisplayName|Address 2: ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|address2_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

|Property|Value|
|--------|-----|
|Description|Select the secondary address type.|
|DisplayName|Address 2: Address Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_addresstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Address2_AddressTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address2_City"></a> Address2_City

|Property|Value|
|--------|-----|
|Description|Type the city for the secondary address.|
|DisplayName|Address 2: City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Country"></a> Address2_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the secondary address.|
|DisplayName|Address 2: Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_County"></a> Address2_County

|Property|Value|
|--------|-----|
|Description|Type the county for the secondary address.|
|DisplayName|Address 2: County|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_county|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Fax"></a> Address2_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number associated with the secondary address.|
|DisplayName|Address 2: Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_FreightTermsCode"></a> Address2_FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms for the secondary address to make sure shipping orders are processed correctly.|
|DisplayName|Address 2: Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### Address2_FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

|Property|Value|
|--------|-----|
|Description|Type the latitude value for the secondary address for use in mapping and other applications.|
|DisplayName|Address 2: Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address2_Line1"></a> Address2_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the secondary address.|
|DisplayName|Address 2: Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Line2"></a> Address2_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the secondary address.|
|DisplayName|Address 2: Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Line3"></a> Address2_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the secondary address.|
|DisplayName|Address 2: Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

|Property|Value|
|--------|-----|
|Description|Type the longitude value for the secondary address for use in mapping and other applications.|
|DisplayName|Address 2: Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address2_Name"></a> Address2_Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the secondary address, such as Corporate Headquarters.|
|DisplayName|Address 2: Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the secondary address.|
|DisplayName|Address 2: ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

|Property|Value|
|--------|-----|
|Description|Type the post office box number of the secondary address.|
|DisplayName|Address 2: Post Office Box|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_postofficebox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_PrimaryContactName"></a> Address2_PrimaryContactName

|Property|Value|
|--------|-----|
|Description|Type the name of the main contact at the account's secondary address.|
|DisplayName|Address 2: Primary Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_primarycontactname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Select a shipping method for deliveries sent to this address.|
|DisplayName|Address 2: Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### Address2_ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province of the secondary address.|
|DisplayName|Address 2: State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

|Property|Value|
|--------|-----|
|Description|Type the main phone number associated with the secondary address.|
|DisplayName|Address 2: Telephone 1|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone1|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

|Property|Value|
|--------|-----|
|Description|Type a second phone number associated with the secondary address.|
|DisplayName|Address 2: Telephone 2|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone2|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

|Property|Value|
|--------|-----|
|Description|Type a third phone number associated with the secondary address.|
|DisplayName|Address 2: Telephone 3|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

|Property|Value|
|--------|-----|
|Description|Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.|
|DisplayName|Address 2: UPS Zone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_upszone|
|MaxLength|4|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

|Property|Value|
|--------|-----|
|Description|Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.|
|DisplayName|Address 2: UTC Offset|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_utcoffset|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_BusinessTypeCode"></a> BusinessTypeCode

|Property|Value|
|--------|-----|
|Description|Select the legal designation or other business type of the account for contracts or reporting purposes.|
|DisplayName|Business Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|businesstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### BusinessTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_CreditLimit"></a> CreditLimit

|Property|Value|
|--------|-----|
|Description|Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.|
|DisplayName|Credit Limit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|creditlimit|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreditOnHold"></a> CreditOnHold

|Property|Value|
|--------|-----|
|Description|Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.|
|DisplayName|Credit Hold|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|creditonhold|
|RequiredLevel|None|
|Type|Boolean|

#### CreditOnHold Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_CustomerSizeCode"></a> CustomerSizeCode

|Property|Value|
|--------|-----|
|Description|Select the size category or range of the account for segmentation and reporting purposes.|
|DisplayName|Customer Size|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customersizecode|
|RequiredLevel|None|
|Type|Picklist|

#### CustomerSizeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_CustomerTypeCode"></a> CustomerTypeCode

|Property|Value|
|--------|-----|
|Description|Select the category that best describes the relationship between the account and your organization.|
|DisplayName|Relationship Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customertypecode|
|RequiredLevel|None|
|Type|Picklist|

#### CustomerTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Competitor||
|2|Consultant||
|3|Customer||
|4|Investor||
|5|Partner||
|6|Influencer||
|7|Press||
|8|Prospect||
|9|Reseller||
|10|Supplier||
|11|Vendor||
|12|Other||



### <a name="BKMK_DefaultPriceLevelId"></a> DefaultPriceLevelId

**Added by**: Product Management Solution

|Property|Value|
|--------|-----|
|Description|Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultpricelevelid|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the account, such as an excerpt from the company's website.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DoNotBulkEMail"></a> DoNotBulkEMail

|Property|Value|
|--------|-----|
|Description|Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.|
|DisplayName|Do not allow Bulk Emails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotbulkemail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotBulkEMail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Allow||
|0|Allow||

**DefaultValue**: 0



### <a name="BKMK_DoNotBulkPostalMail"></a> DoNotBulkPostalMail

|Property|Value|
|--------|-----|
|Description|Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.|
|DisplayName|Do not allow Bulk Mails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotbulkpostalmail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotBulkPostalMail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_DoNotEMail"></a> DoNotEMail

|Property|Value|
|--------|-----|
|Description|Select whether the account allows direct email sent from Microsoft Dynamics 365.|
|DisplayName|Do not allow Emails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotemail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotEMail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Allow||
|0|Allow||

**DefaultValue**: 0



### <a name="BKMK_DoNotFax"></a> DoNotFax

|Property|Value|
|--------|-----|
|Description|Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.|
|DisplayName|Do not allow Faxes|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotfax|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotFax Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Allow||
|0|Allow||

**DefaultValue**: 0



### <a name="BKMK_DoNotPhone"></a> DoNotPhone

|Property|Value|
|--------|-----|
|Description|Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.|
|DisplayName|Do not allow Phone Calls|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotphone|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPhone Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Allow||
|0|Allow||

**DefaultValue**: 0



### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

|Property|Value|
|--------|-----|
|Description|Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.|
|DisplayName|Do not allow Mails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotpostalmail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPostalMail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Allow||
|0|Allow||

**DefaultValue**: 0



### <a name="BKMK_DoNotSendMM"></a> DoNotSendMM

|Property|Value|
|--------|-----|
|Description|Select whether the account accepts marketing materials, such as brochures or catalogs.|
|DisplayName|Send Marketing Materials|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotsendmm|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotSendMM Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Do Not Send||
|0|Send||

**DefaultValue**: 0



### <a name="BKMK_EMailAddress1"></a> EMailAddress1

|Property|Value|
|--------|-----|
|Description|Type the primary email address for the account.|
|DisplayName|Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress1|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EMailAddress2"></a> EMailAddress2

|Property|Value|
|--------|-----|
|Description|Type the secondary email address for the account.|
|DisplayName|Email Address 2|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress2|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EMailAddress3"></a> EMailAddress3

|Property|Value|
|--------|-----|
|Description|Type an alternate email address for the account.|
|DisplayName|Email Address 3|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress3|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|--------|-----|
|Description|Shows the default image for the record.|
|DisplayName|Default Image|
|IsPrimaryImage|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the account.|
|DisplayName|Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FollowEmail"></a> FollowEmail

|Property|Value|
|--------|-----|
|Description|Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.|
|DisplayName|Follow Email Activity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|followemail|
|RequiredLevel|None|
|Type|Boolean|

#### FollowEmail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Allow||
|0|Do Not Allow||

**DefaultValue**: 1



### <a name="BKMK_FtpSiteURL"></a> FtpSiteURL

|Property|Value|
|--------|-----|
|Description|Type the URL for the account's FTP site to enable users to access data and share documents.|
|DisplayName|FTP Site|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ftpsiteurl|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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


### <a name="BKMK_IndustryCode"></a> IndustryCode

|Property|Value|
|--------|-----|
|Description|Select the account's primary industry for use in marketing segmentation and demographic analysis.|
|DisplayName|Industry|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|industrycode|
|RequiredLevel|None|
|Type|Picklist|

#### IndustryCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Accounting||
|2|Agriculture and Non-petrol Natural Resource Extraction||
|3|Broadcasting Printing and Publishing||
|4|Brokers||
|5|Building Supply Retail||
|6|Business Services||
|7|Consulting||
|8|Consumer Services||
|9|Design, Direction and Creative Management||
|10|Distributors, Dispatchers and Processors||
|11|Doctor's Offices and Clinics||
|12|Durable Manufacturing||
|13|Eating and Drinking Places||
|14|Entertainment Retail||
|15|Equipment Rental and Leasing||
|16|Financial||
|17|Food and Tobacco Processing||
|18|Inbound Capital Intensive Processing||
|19|Inbound Repair and Services||
|20|Insurance||
|21|Legal Services||
|22|Non-Durable Merchandise Retail||
|23|Outbound Consumer Service||
|24|Petrochemical Extraction and Distribution||
|25|Service Retail||
|26|SIG Affiliations||
|27|Social Services||
|28|Special Outbound Trade Contractors||
|29|Specialty Realty||
|30|Transportation||
|31|Utility Creation and Distribution||
|32|Vehicle Retail||
|33|Wholesale||



### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date and time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LastUsedInCampaign"></a> LastUsedInCampaign

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date when the account was last included in a marketing campaign or quick campaign.|
|DisplayName|Last Date Included in Campaign|
|Format|DateOnly|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastusedincampaign|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MarketCap"></a> MarketCap

|Property|Value|
|--------|-----|
|Description|Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.|
|DisplayName|Market Capitalization|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|marketcap|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_MarketingOnly"></a> MarketingOnly

|Property|Value|
|--------|-----|
|Description|Whether is only for marketing|
|DisplayName|Marketing Only|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|marketingonly|
|RequiredLevel|None|
|Type|Boolean|

#### MarketingOnly Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description|Describes whether account is opted out or not|
|DisplayName|GDPR Optout|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_gdproptout|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_gdproptout Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_salesaccelerationinsightid"></a> msdyn_salesaccelerationinsightid

**Added by**: Sales Acceleration Solution

|Property|Value|
|--------|-----|
|Description|Sales Acceleration Insights ID|
|DisplayName|Sales Acceleration Insights ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesaccelerationinsightid|
|RequiredLevel|None|
|Targets|msdyn_salesaccelerationinsight|
|Type|Lookup|


### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Segment associated with account.|
|DisplayName|Segment Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_segmentid|
|RequiredLevel|None|
|Targets|msdyn_segment|
|Type|Lookup|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type the company or business name.|
|DisplayName|Account Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_NumberOfEmployees"></a> NumberOfEmployees

|Property|Value|
|--------|-----|
|Description|Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.|
|DisplayName|Number of Employees|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|numberofemployees|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

**Added by**: Lead Management Solution

|Property|Value|
|--------|-----|
|Description|Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.|
|DisplayName|Originating Lead|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|originatingleadid|
|RequiredLevel|None|
|Targets|lead|
|Type|Lookup|


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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwnershipCode"></a> OwnershipCode

|Property|Value|
|--------|-----|
|Description|Select the account's ownership structure, such as public or private.|
|DisplayName|Ownership|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownershipcode|
|RequiredLevel|None|
|Type|Picklist|

#### OwnershipCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Public||
|2|Private||
|3|Subsidiary||
|4|Other||



### <a name="BKMK_ParentAccountId"></a> ParentAccountId

|Property|Value|
|--------|-----|
|Description|Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.|
|DisplayName|Parent Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentaccountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

|Property|Value|
|--------|-----|
|Description|For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.|
|DisplayName|Participates in Workflow|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|participatesinworkflow|
|RequiredLevel|None|
|Type|Boolean|

#### ParticipatesInWorkflow Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_PaymentTermsCode"></a> PaymentTermsCode

|Property|Value|
|--------|-----|
|Description|Select the payment terms to indicate when the customer needs to pay the total amount.|
|DisplayName|Payment Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|paymenttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### PaymentTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Net 30||
|2|2% 10, Net 30||
|3|Net 45||
|4|Net 60||



### <a name="BKMK_PreferredAppointmentDayCode"></a> PreferredAppointmentDayCode

|Property|Value|
|--------|-----|
|Description|Select the preferred day of the week for service appointments.|
|DisplayName|Preferred Day|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredappointmentdaycode|
|RequiredLevel|None|
|Type|Picklist|

#### PreferredAppointmentDayCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Sunday||
|1|Monday||
|2|Tuesday||
|3|Wednesday||
|4|Thursday||
|5|Friday||
|6|Saturday||



### <a name="BKMK_PreferredAppointmentTimeCode"></a> PreferredAppointmentTimeCode

|Property|Value|
|--------|-----|
|Description|Select the preferred time of day for service appointments.|
|DisplayName|Preferred Time|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredappointmenttimecode|
|RequiredLevel|None|
|Type|Picklist|

#### PreferredAppointmentTimeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Morning||
|2|Afternoon||
|3|Evening||



### <a name="BKMK_PreferredContactMethodCode"></a> PreferredContactMethodCode

|Property|Value|
|--------|-----|
|Description|Select the preferred method of contact.|
|DisplayName|Preferred Method of Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredcontactmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### PreferredContactMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Any||
|2|Email||
|3|Phone||
|4|Fax||
|5|Mail||



### <a name="BKMK_PreferredEquipmentId"></a> PreferredEquipmentId

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description|Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.|
|DisplayName|Preferred Facility/Equipment|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredequipmentid|
|RequiredLevel|None|
|Targets|equipment|
|Type|Lookup|


### <a name="BKMK_PreferredServiceId"></a> PreferredServiceId

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description|Choose the account's preferred service for reference when you schedule service activities.|
|DisplayName|Preferred Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredserviceid|
|RequiredLevel|None|
|Targets|service|
|Type|Lookup|


### <a name="BKMK_PreferredSystemUserId"></a> PreferredSystemUserId

|Property|Value|
|--------|-----|
|Description|Choose the preferred service representative for reference when you schedule service activities for the account.|
|DisplayName|Preferred User|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|preferredsystemuserid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PrimaryContactId"></a> PrimaryContactId

|Property|Value|
|--------|-----|
|Description|Choose the primary contact for the account to provide quick access to contact details.|
|DisplayName|Primary Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|primarycontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_PrimarySatoriId"></a> PrimarySatoriId

|Property|Value|
|--------|-----|
|Description|Primary Satori ID for Account|
|DisplayName|Primary Satori ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|primarysatoriid|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryTwitterId"></a> PrimaryTwitterId

|Property|Value|
|--------|-----|
|Description|Primary Twitter ID for Account|
|DisplayName|Primary Twitter ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|primarytwitterid|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Revenue"></a> Revenue

|Property|Value|
|--------|-----|
|Description|Type the annual revenue for the account, used as an indicator in financial performance analysis.|
|DisplayName|Annual Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|revenue|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_SharesOutstanding"></a> SharesOutstanding

|Property|Value|
|--------|-----|
|Description|Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.|
|DisplayName|Shares Outstanding|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sharesoutstanding|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.|
|DisplayName|Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_SIC"></a> SIC

|Property|Value|
|--------|-----|
|Description|Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.|
|DisplayName|SIC Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sic|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the Account record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the account's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_StockExchange"></a> StockExchange

|Property|Value|
|--------|-----|
|Description|Type the stock exchange at which the account is listed to track their stock and financial performance of the company.|
|DisplayName|Stock Exchange|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stockexchange|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Number of users or conversations followed the record|
|DisplayName|TeamsFollowed|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|teamsfollowed|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|--------|-----|
|Description|Type the main phone number for this account.|
|DisplayName|Main Phone|
|FormatName|Phone|
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
|Description|Type a second phone number for this account.|
|DisplayName|Other Phone|
|FormatName|Phone|
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
|Description|Type a third phone number for this account.|
|DisplayName|Telephone 3|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TerritoryCode"></a> TerritoryCode

|Property|Value|
|--------|-----|
|Description|Select a region or territory for the account for use in segmentation and analysis.|
|DisplayName|Territory Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|territorycode|
|RequiredLevel|None|
|Type|Picklist|

#### TerritoryCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_TerritoryId"></a> TerritoryId

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.|
|DisplayName|Territory|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|territoryid|
|RequiredLevel|None|
|Targets|territory|
|Type|Lookup|


### <a name="BKMK_TickerSymbol"></a> TickerSymbol

|Property|Value|
|--------|-----|
|Description|Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.|
|DisplayName|Ticker Symbol|
|FormatName|TickerSymbol|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tickersymbol|
|MaxLength|10|
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
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
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


### <a name="BKMK_WebSiteURL"></a> WebSiteURL

|Property|Value|
|--------|-----|
|Description|Type the account's website URL to get quick details about the company profile.|
|DisplayName|Website|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|websiteurl|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiName"></a> YomiName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.|
|DisplayName|Yomi Account Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [Address1_Composite](#BKMK_Address1_Composite)
- [Address2_Composite](#BKMK_Address2_Composite)
- [Aging30](#BKMK_Aging30)
- [Aging30_Base](#BKMK_Aging30_Base)
- [Aging60](#BKMK_Aging60)
- [Aging60_Base](#BKMK_Aging60_Base)
- [Aging90](#BKMK_Aging90)
- [Aging90_Base](#BKMK_Aging90_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CreditLimit_Base](#BKMK_CreditLimit_Base)
- [DefaultPriceLevelIdName](#BKMK_DefaultPriceLevelIdName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsPrivate](#BKMK_IsPrivate)
- [MarketCap_Base](#BKMK_MarketCap_Base)
- [MasterAccountIdName](#BKMK_MasterAccountIdName)
- [MasterAccountIdYomiName](#BKMK_MasterAccountIdYomiName)
- [MasterId](#BKMK_MasterId)
- [Merged](#BKMK_Merged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_salesaccelerationinsightidName](#BKMK_msdyn_salesaccelerationinsightidName)
- [msdyn_segmentidName](#BKMK_msdyn_segmentidName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OpenDeals](#BKMK_OpenDeals)
- [OpenDeals_Date](#BKMK_OpenDeals_Date)
- [OpenDeals_State](#BKMK_OpenDeals_State)
- [OpenRevenue](#BKMK_OpenRevenue)
- [OpenRevenue_Base](#BKMK_OpenRevenue_Base)
- [OpenRevenue_Date](#BKMK_OpenRevenue_Date)
- [OpenRevenue_State](#BKMK_OpenRevenue_State)
- [OriginatingLeadIdName](#BKMK_OriginatingLeadIdName)
- [OriginatingLeadIdYomiName](#BKMK_OriginatingLeadIdYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentAccountIdName](#BKMK_ParentAccountIdName)
- [ParentAccountIdYomiName](#BKMK_ParentAccountIdYomiName)
- [PreferredEquipmentIdName](#BKMK_PreferredEquipmentIdName)
- [PreferredServiceIdName](#BKMK_PreferredServiceIdName)
- [PreferredSystemUserIdName](#BKMK_PreferredSystemUserIdName)
- [PreferredSystemUserIdYomiName](#BKMK_PreferredSystemUserIdYomiName)
- [PrimaryContactIdName](#BKMK_PrimaryContactIdName)
- [PrimaryContactIdYomiName](#BKMK_PrimaryContactIdYomiName)
- [Revenue_Base](#BKMK_Revenue_Base)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TerritoryIdName](#BKMK_TerritoryIdName)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_Address1_Composite"></a> Address1_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete primary address.|
|DisplayName|Address 1|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Address2_Composite"></a> Address2_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete secondary address.|
|DisplayName|Address 2|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Aging30"></a> Aging30

|Property|Value|
|--------|-----|
|Description|For system use only.|
|DisplayName|Aging 30|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging30|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Aging30_Base"></a> Aging30_Base

|Property|Value|
|--------|-----|
|Description|The base currency equivalent of the aging 30 field.|
|DisplayName|Aging 30 (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging30_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Aging60"></a> Aging60

|Property|Value|
|--------|-----|
|Description|For system use only.|
|DisplayName|Aging 60|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging60|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Aging60_Base"></a> Aging60_Base

|Property|Value|
|--------|-----|
|Description|The base currency equivalent of the aging 60 field.|
|DisplayName|Aging 60 (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging60_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Aging90"></a> Aging90

|Property|Value|
|--------|-----|
|Description|For system use only.|
|DisplayName|Aging 90|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging90|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Aging90_Base"></a> Aging90_Base

|Property|Value|
|--------|-----|
|Description|The base currency equivalent of the aging 90 field.|
|DisplayName|Aging 90 (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|aging90_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who created the record.|
|DisplayName|Created By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_CreditLimit_Base"></a> CreditLimit_Base

|Property|Value|
|--------|-----|
|Description|Shows the credit limit converted to the system's default base currency for reporting purposes.|
|DisplayName|Credit Limit (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|creditlimit_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DefaultPriceLevelIdName"></a> DefaultPriceLevelIdName

**Added by**: Product Management Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultpricelevelidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Entity Image Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.000000000001|
|Precision|12|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_MarketCap_Base"></a> MarketCap_Base

|Property|Value|
|--------|-----|
|Description|Shows the market capitalization converted to the system's default base currency.|
|DisplayName|Market Capitalization (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|marketcap_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_MasterAccountIdName"></a> MasterAccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masteraccountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MasterAccountIdYomiName"></a> MasterAccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masteraccountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MasterId"></a> MasterId

|Property|Value|
|--------|-----|
|Description|Shows the master account that the account was merged with.|
|DisplayName|Master ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masterid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_Merged"></a> Merged

|Property|Value|
|--------|-----|
|Description|Shows whether the account has been merged with another account.|
|DisplayName|Merged|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|merged|
|RequiredLevel|None|
|Type|Boolean|

#### Merged Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who modified the record.|
|DisplayName|Modified By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_msdyn_salesaccelerationinsightidName"></a> msdyn_salesaccelerationinsightidName

**Added by**: Sales Acceleration Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salesaccelerationinsightidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_segmentidName"></a> msdyn_segmentidName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_segmentidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows how long, in minutes, that the record was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OpenDeals"></a> OpenDeals

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Number of open opportunities against an account and its child accounts.|
|DisplayName|Open Deals|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opendeals|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OpenDeals_Date"></a> OpenDeals_Date

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Last Updated time of rollup field Open Deals.|
|DisplayName|Open Deals (Last Updated On)|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opendeals_date|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OpenDeals_State"></a> OpenDeals_State

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|State of rollup field Open Deals.|
|DisplayName|Open Deals (State)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opendeals_state|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OpenRevenue"></a> OpenRevenue

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Sum of open revenue against an account and its child accounts.|
|DisplayName|Open Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|openrevenue|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_OpenRevenue_Base"></a> OpenRevenue_Base

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Value of the Open Revenue in base currency.|
|DisplayName|Open Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|openrevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_OpenRevenue_Date"></a> OpenRevenue_Date

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Last Updated time of rollup field Open Revenue.|
|DisplayName|Open Revenue (Last Updated On)|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|openrevenue_date|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OpenRevenue_State"></a> OpenRevenue_State

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|State of rollup field Open Revenue.|
|DisplayName|Open Revenue (State)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|openrevenue_state|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OriginatingLeadIdName"></a> OriginatingLeadIdName

**Added by**: Lead Management Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingleadidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OriginatingLeadIdYomiName"></a> OriginatingLeadIdYomiName

**Added by**: Lead Management Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingleadidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Shows the business unit that the record owner belongs to.|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns the account.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the account.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ParentAccountIdName"></a> ParentAccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentaccountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentAccountIdYomiName"></a> ParentAccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentaccountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PreferredEquipmentIdName"></a> PreferredEquipmentIdName

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|preferredequipmentidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PreferredServiceIdName"></a> PreferredServiceIdName

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|preferredserviceidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PreferredSystemUserIdName"></a> PreferredSystemUserIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|preferredsystemuseridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PreferredSystemUserIdYomiName"></a> PreferredSystemUserIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|preferredsystemuseridyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryContactIdName"></a> PrimaryContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primarycontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryContactIdYomiName"></a> PrimaryContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primarycontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Revenue_Base"></a> Revenue_Base

|Property|Value|
|--------|-----|
|Description|Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.|
|DisplayName|Annual Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|revenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this case. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TerritoryIdName"></a> TerritoryIdName

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|territoryidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

|Property|Value|
|--------|-----|
|Description|Total time spent for emails (read and write) and meetings by me in relation to account record.|
|DisplayName|Time Spent by me|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timespentbymeonemailandmeetings|
|MaxLength|1250|
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
|Description|Version number of the account.|
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

- [account_parent_account](#BKMK_account_parent_account)
- [contact_customer_accounts](#BKMK_contact_customer_accounts)
- [account_master_account](#BKMK_account_master_account)
- [lead_customer_accounts](#BKMK_lead_customer_accounts)
- [lead_parent_account](#BKMK_lead_parent_account)
- [account_BulkOperations](#BKMK_account_BulkOperations)
- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [account_OpportunityCloses](#BKMK_account_OpportunityCloses)
- [account_OrderCloses](#BKMK_account_OrderCloses)
- [account_QuoteCloses](#BKMK_account_QuoteCloses)
- [invoice_customer_accounts](#BKMK_invoice_customer_accounts)
- [opportunity_customer_accounts](#BKMK_opportunity_customer_accounts)
- [order_customer_accounts](#BKMK_order_customer_accounts)
- [quote_customer_accounts](#BKMK_quote_customer_accounts)
- [opportunity_parent_account](#BKMK_opportunity_parent_account)
- [msdyn_playbookinstance_account](#BKMK_msdyn_playbookinstance_account)


### <a name="BKMK_account_parent_account"></a> account_parent_account

Same as the [account_parent_account](account.md#BKMK_account_parent_account) many-to-one relationship for the [account](account.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|parentaccountid|
|IsHierarchical|True|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_parent_account|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 40|
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contact_customer_accounts"></a> contact_customer_accounts

Same as the [contact_customer_accounts](contact.md#BKMK_contact_customer_accounts) many-to-one relationship for the [contact](contact.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|parentcustomerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contact_customer_accounts|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 50|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_account_master_account"></a> account_master_account

Same as the [account_master_account](account.md#BKMK_account_master_account) many-to-one relationship for the [account](account.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|masterid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_master_account|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_customer_accounts"></a> lead_customer_accounts

**Added by**: Lead Management Solution

Same as the [lead_customer_accounts](lead.md#BKMK_lead_customer_accounts) many-to-one relationship for the [lead](lead.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|customerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_customer_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_parent_account"></a> lead_parent_account

**Added by**: Lead Management Solution

Same as the [lead_parent_account](lead.md#BKMK_lead_parent_account) many-to-one relationship for the [lead](lead.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|parentaccountid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_parent_account|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_account_BulkOperations"></a> account_BulkOperations

**Added by**: Marketing Solution

Same as the [account_BulkOperations](bulkoperation.md#BKMK_account_BulkOperations) many-to-one relationship for the [bulkoperation](bulkoperation.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

**Added by**: Marketing Solution

Same as the [account_CampaignResponses](campaignresponse.md#BKMK_account_CampaignResponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

**Added by**: Marketing Solution

Same as the [CreatedAccount_BulkOperationLogs2](bulkoperationlog.md#BKMK_CreatedAccount_BulkOperationLogs2) many-to-one relationship for the [bulkoperationlog](bulkoperationlog.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|createdobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CreatedAccount_BulkOperationLogs2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

**Added by**: Marketing Solution

Same as the [SourceAccount_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceAccount_BulkOperationLogs) many-to-one relationship for the [bulkoperationlog](bulkoperationlog.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|SourceAccount_BulkOperationLogs|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_account_OpportunityCloses"></a> account_OpportunityCloses

**Added by**: Sales Solution

Same as the [account_OpportunityCloses](opportunityclose.md#BKMK_account_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_account_OrderCloses"></a> account_OrderCloses

**Added by**: Sales Solution

Same as the [account_OrderCloses](orderclose.md#BKMK_account_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_account_QuoteCloses"></a> account_QuoteCloses

**Added by**: Sales Solution

Same as the [account_QuoteCloses](quoteclose.md#BKMK_account_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_invoice_customer_accounts"></a> invoice_customer_accounts

**Added by**: Sales Solution

Same as the [invoice_customer_accounts](invoice.md#BKMK_invoice_customer_accounts) many-to-one relationship for the [invoice](invoice.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|customerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|invoice_customer_accounts|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 40|
|CascadeConfiguration|Assign: Cascade<br />Delete: Restrict<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_customer_accounts"></a> opportunity_customer_accounts

**Added by**: Sales Solution

Same as the [opportunity_customer_accounts](opportunity.md#BKMK_opportunity_customer_accounts) many-to-one relationship for the [opportunity](opportunity.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|customerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_customer_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Sales<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_order_customer_accounts"></a> order_customer_accounts

**Added by**: Sales Solution

Same as the [order_customer_accounts](salesorder.md#BKMK_order_customer_accounts) many-to-one relationship for the [salesorder](salesorder.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|customerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|order_customer_accounts|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 30|
|CascadeConfiguration|Assign: Cascade<br />Delete: Restrict<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_quote_customer_accounts"></a> quote_customer_accounts

**Added by**: Sales Solution

Same as the [quote_customer_accounts](quote.md#BKMK_quote_customer_accounts) many-to-one relationship for the [quote](quote.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|customerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quote_customer_accounts|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 20|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_parent_account"></a> opportunity_parent_account

**Added by**: Sales Solution

Same as the [opportunity_parent_account](opportunity.md#BKMK_opportunity_parent_account) many-to-one relationship for the [opportunity](opportunity.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|parentaccountid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_parent_account|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 1|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_account"></a> msdyn_playbookinstance_account

**Added by**: Playbook Solution

Same as the [msdyn_playbookinstance_account](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_account) many-to-one relationship for the [msdyn_playbookinstance](msdyn_playbookinstance.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_account|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [account_primary_contact](#BKMK_account_primary_contact)
- [account_master_account](#BKMK_account_master_account)
- [account_parent_account](#BKMK_account_parent_account)
- [account_originating_lead](#BKMK_account_originating_lead)
- [price_level_accounts](#BKMK_price_level_accounts)


### <a name="BKMK_account_primary_contact"></a> account_primary_contact

See the [account_primary_contact](contact.md#BKMK_account_primary_contact) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_account_master_account"></a> account_master_account

See the [account_master_account](account.md#BKMK_account_master_account) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_account_parent_account"></a> account_parent_account

See the [account_parent_account](account.md#BKMK_account_parent_account) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_account_originating_lead"></a> account_originating_lead

**Added by**: Lead Management Solution

See the [account_originating_lead](lead.md#BKMK_account_originating_lead) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_price_level_accounts"></a> price_level_accounts

**Added by**: Product Management Solution

See the [price_level_accounts](pricelevel.md#BKMK_price_level_accounts) one-to-many relationship for the [pricelevel](pricelevel.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Account table is the first table in the relationship. Listed by **SchemaName**.

- [accountleads_association](#BKMK_accountleads_association)
- [listaccount_association](#BKMK_listaccount_association)
- [BulkOperation_Accounts](#BKMK_BulkOperation_Accounts)
- [CampaignActivity_Accounts](#BKMK_CampaignActivity_Accounts)


### <a name="BKMK_accountleads_association"></a> accountleads_association

IntersectEntityName: accountleads<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|leadid|
|IsCustomizable|False|
|LogicalName|account|
|NavigationPropertyName|accountleads_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|lead|
|IntersectAttribute|accountid|
|NavigationPropertyName|accountleads_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_listaccount_association"></a> listaccount_association

See the [listaccount_association](list.md#BKMK_listaccount_association) many-to-many relationship for the [list](list.md) table/entity.

### <a name="BKMK_BulkOperation_Accounts"></a> BulkOperation_Accounts

See the [BulkOperation_Accounts](bulkoperation.md#BKMK_BulkOperation_Accounts) many-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_CampaignActivity_Accounts"></a> CampaignActivity_Accounts

See the [CampaignActivity_Accounts](campaignactivity.md#BKMK_CampaignActivity_Accounts) many-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />