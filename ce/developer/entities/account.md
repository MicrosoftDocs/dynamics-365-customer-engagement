---
title: "Account Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Account entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Account Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Business that represents a customer or potential customer. The company that is billed in business transactions.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/accounts(*accountid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|Create|POST [*org URI*]/api/data/v9.0/accounts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/accounts(*accountid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|Merge|<xref href="Microsoft.Dynamics.CRM.Merge?text=Merge Action" />|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/accounts(*accountid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/accounts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/accounts(*accountid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/accounts(*accountid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Account<br />
**DisplayCollectionName**: Accounts<br />
**SchemaName**: Account<br />
**CollectionSchemaName**: Accounts<br />
**LogicalName**: account<br />
**LogicalCollectionName**: accounts<br />
**EntitySetName**: accounts<br />
**PrimaryIdAttribute**: accountid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_externalaccountid](#BKMK_msdyn_externalaccountid)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_SalesTaxCode](#BKMK_msdyn_SalesTaxCode)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_TaxExempt](#BKMK_msdyn_TaxExempt)
- [msdyn_TaxExemptNumber](#BKMK_msdyn_TaxExemptNumber)
- [msdyn_TravelCharge](#BKMK_msdyn_TravelCharge)
- [msdyn_TravelChargeType](#BKMK_msdyn_TravelChargeType)
- [msdyn_WorkOrderInstructions](#BKMK_msdyn_WorkOrderInstructions)
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

**Description**: Select a category to indicate whether the customer account is standard or preferred.<br />
**DisplayName**: Category<br />
**LogicalName**: accountcategorycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Preferred Customer
- **Value**: 2 **Label**: Standard



### <a name="BKMK_AccountClassificationCode"></a> AccountClassificationCode

**Description**: Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.<br />
**DisplayName**: Classification<br />
**LogicalName**: accountclassificationcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_AccountId"></a> AccountId

**Description**: Unique identifier of the account.<br />
**DisplayName**: Account<br />
**LogicalName**: accountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_AccountNumber"></a> AccountNumber

**Description**: Type an ID number or code for the account to quickly search and identify the account in system views.<br />
**DisplayName**: Account Number<br />
**LogicalName**: accountnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_AccountRatingCode"></a> AccountRatingCode

**Description**: Select a rating to indicate the value of the customer account.<br />
**DisplayName**: Account Rating<br />
**LogicalName**: accountratingcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address1_AddressId"></a> Address1_AddressId

**Description**: Unique identifier for address 1.<br />
**DisplayName**: Address 1: ID<br />
**LogicalName**: address1_addressid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

**Description**: Select the primary address type.<br />
**DisplayName**: Address 1: Address Type<br />
**LogicalName**: address1_addresstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Bill To
- **Value**: 2 **Label**: Ship To
- **Value**: 3 **Label**: Primary
- **Value**: 4 **Label**: Other



### <a name="BKMK_Address1_City"></a> Address1_City

**Description**: Type the city for the primary address.<br />
**DisplayName**: Address 1: City<br />
**LogicalName**: address1_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address1_Country"></a> Address1_Country

**Description**: Type the country or region for the primary address.<br />
**DisplayName**: Address 1: Country/Region<br />
**LogicalName**: address1_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address1_County"></a> Address1_County

**Description**: Type the county for the primary address.<br />
**DisplayName**: Address 1: County<br />
**LogicalName**: address1_county<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Fax"></a> Address1_Fax

**Description**: Type the fax number associated with the primary address.<br />
**DisplayName**: Address 1: Fax<br />
**LogicalName**: address1_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_FreightTermsCode"></a> Address1_FreightTermsCode

**Description**: Select the freight terms for the primary address to make sure shipping orders are processed correctly.<br />
**DisplayName**: Address 1: Freight Terms<br />
**LogicalName**: address1_freighttermscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: FOB
- **Value**: 2 **Label**: No Charge



### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

**Description**: Type the latitude value for the primary address for use in mapping and other applications.<br />
**DisplayName**: Address 1: Latitude<br />
**LogicalName**: address1_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_Address1_Line1"></a> Address1_Line1

**Description**: Type the first line of the primary address.<br />
**DisplayName**: Address 1: Street 1<br />
**LogicalName**: address1_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Line2"></a> Address1_Line2

**Description**: Type the second line of the primary address.<br />
**DisplayName**: Address 1: Street 2<br />
**LogicalName**: address1_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Line3"></a> Address1_Line3

**Description**: Type the third line of the primary address.<br />
**DisplayName**: Address 1: Street 3<br />
**LogicalName**: address1_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

**Description**: Type the longitude value for the primary address for use in mapping and other applications.<br />
**DisplayName**: Address 1: Longitude<br />
**LogicalName**: address1_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_Address1_Name"></a> Address1_Name

**Description**: Type a descriptive name for the primary address, such as Corporate Headquarters.<br />
**DisplayName**: Address 1: Name<br />
**LogicalName**: address1_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

**Description**: Type the ZIP Code or postal code for the primary address.<br />
**DisplayName**: Address 1: ZIP/Postal Code<br />
**LogicalName**: address1_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

**Description**: Type the post office box number of the primary address.<br />
**DisplayName**: Address 1: Post Office Box<br />
**LogicalName**: address1_postofficebox<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address1_PrimaryContactName"></a> Address1_PrimaryContactName

**Description**: Type the name of the main contact at the account's primary address.<br />
**DisplayName**: Address 1: Primary Contact Name<br />
**LogicalName**: address1_primarycontactname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

**Description**: Select a shipping method for deliveries sent to this address.<br />
**DisplayName**: Address 1: Shipping Method<br />
**LogicalName**: address1_shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Airborne
- **Value**: 2 **Label**: DHL
- **Value**: 3 **Label**: FedEx
- **Value**: 4 **Label**: UPS
- **Value**: 5 **Label**: Postal Mail
- **Value**: 6 **Label**: Full Load
- **Value**: 7 **Label**: Will Call



### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

**Description**: Type the state or province of the primary address.<br />
**DisplayName**: Address 1: State/Province<br />
**LogicalName**: address1_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

**Description**: Type the main phone number associated with the primary address.<br />
**DisplayName**: Address Phone<br />
**LogicalName**: address1_telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

**Description**: Type a second phone number associated with the primary address.<br />
**DisplayName**: Address 1: Telephone 2<br />
**LogicalName**: address1_telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

**Description**: Type a third phone number associated with the primary address.<br />
**DisplayName**: Address 1: Telephone 3<br />
**LogicalName**: address1_telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

**Description**: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />
**DisplayName**: Address 1: UPS Zone<br />
**LogicalName**: address1_upszone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4


### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />
**DisplayName**: Address 1: UTC Offset<br />
**LogicalName**: address1_utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

**Description**: Unique identifier for address 2.<br />
**DisplayName**: Address 2: ID<br />
**LogicalName**: address2_addressid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

**Description**: Select the secondary address type.<br />
**DisplayName**: Address 2: Address Type<br />
**LogicalName**: address2_addresstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address2_City"></a> Address2_City

**Description**: Type the city for the secondary address.<br />
**DisplayName**: Address 2: City<br />
**LogicalName**: address2_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address2_Country"></a> Address2_Country

**Description**: Type the country or region for the secondary address.<br />
**DisplayName**: Address 2: Country/Region<br />
**LogicalName**: address2_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address2_County"></a> Address2_County

**Description**: Type the county for the secondary address.<br />
**DisplayName**: Address 2: County<br />
**LogicalName**: address2_county<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Fax"></a> Address2_Fax

**Description**: Type the fax number associated with the secondary address.<br />
**DisplayName**: Address 2: Fax<br />
**LogicalName**: address2_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_FreightTermsCode"></a> Address2_FreightTermsCode

**Description**: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.<br />
**DisplayName**: Address 2: Freight Terms<br />
**LogicalName**: address2_freighttermscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

**Description**: Type the latitude value for the secondary address for use in mapping and other applications.<br />
**DisplayName**: Address 2: Latitude<br />
**LogicalName**: address2_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_Address2_Line1"></a> Address2_Line1

**Description**: Type the first line of the secondary address.<br />
**DisplayName**: Address 2: Street 1<br />
**LogicalName**: address2_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Line2"></a> Address2_Line2

**Description**: Type the second line of the secondary address.<br />
**DisplayName**: Address 2: Street 2<br />
**LogicalName**: address2_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Line3"></a> Address2_Line3

**Description**: Type the third line of the secondary address.<br />
**DisplayName**: Address 2: Street 3<br />
**LogicalName**: address2_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

**Description**: Type the longitude value for the secondary address for use in mapping and other applications.<br />
**DisplayName**: Address 2: Longitude<br />
**LogicalName**: address2_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_Address2_Name"></a> Address2_Name

**Description**: Type a descriptive name for the secondary address, such as Corporate Headquarters.<br />
**DisplayName**: Address 2: Name<br />
**LogicalName**: address2_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

**Description**: Type the ZIP Code or postal code for the secondary address.<br />
**DisplayName**: Address 2: ZIP/Postal Code<br />
**LogicalName**: address2_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

**Description**: Type the post office box number of the secondary address.<br />
**DisplayName**: Address 2: Post Office Box<br />
**LogicalName**: address2_postofficebox<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address2_PrimaryContactName"></a> Address2_PrimaryContactName

**Description**: Type the name of the main contact at the account's secondary address.<br />
**DisplayName**: Address 2: Primary Contact Name<br />
**LogicalName**: address2_primarycontactname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

**Description**: Select a shipping method for deliveries sent to this address.<br />
**DisplayName**: Address 2: Shipping Method<br />
**LogicalName**: address2_shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

**Description**: Type the state or province of the secondary address.<br />
**DisplayName**: Address 2: State/Province<br />
**LogicalName**: address2_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

**Description**: Type the main phone number associated with the secondary address.<br />
**DisplayName**: Address 2: Telephone 1<br />
**LogicalName**: address2_telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

**Description**: Type a second phone number associated with the secondary address.<br />
**DisplayName**: Address 2: Telephone 2<br />
**LogicalName**: address2_telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

**Description**: Type a third phone number associated with the secondary address.<br />
**DisplayName**: Address 2: Telephone 3<br />
**LogicalName**: address2_telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

**Description**: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />
**DisplayName**: Address 2: UPS Zone<br />
**LogicalName**: address2_upszone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4


### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />
**DisplayName**: Address 2: UTC Offset<br />
**LogicalName**: address2_utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_BusinessTypeCode"></a> BusinessTypeCode

**Description**: Select the legal designation or other business type of the account for contracts or reporting purposes.<br />
**DisplayName**: Business Type<br />
**LogicalName**: businesstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_CreditLimit"></a> CreditLimit

**Description**: Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.<br />
**DisplayName**: Credit Limit<br />
**LogicalName**: creditlimit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_CreditOnHold"></a> CreditOnHold

**Description**: Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.<br />
**DisplayName**: Credit Hold<br />
**LogicalName**: creditonhold<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_CustomerSizeCode"></a> CustomerSizeCode

**Description**: Select the size category or range of the account for segmentation and reporting purposes.<br />
**DisplayName**: Customer Size<br />
**LogicalName**: customersizecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_CustomerTypeCode"></a> CustomerTypeCode

**Description**: Select the category that best describes the relationship between the account and your organization.<br />
**DisplayName**: Relationship Type<br />
**LogicalName**: customertypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Competitor
- **Value**: 2 **Label**: Consultant
- **Value**: 3 **Label**: Customer
- **Value**: 4 **Label**: Investor
- **Value**: 5 **Label**: Partner
- **Value**: 6 **Label**: Influencer
- **Value**: 7 **Label**: Press
- **Value**: 8 **Label**: Prospect
- **Value**: 9 **Label**: Reseller
- **Value**: 10 **Label**: Supplier
- **Value**: 11 **Label**: Vendor
- **Value**: 12 **Label**: Other



### <a name="BKMK_DefaultPriceLevelId"></a> DefaultPriceLevelId

**Added by**: Project Service Automation Solution<br />
**Description**: Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.<br />
**DisplayName**: Product Price List<br />
**LogicalName**: defaultpricelevelid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the account, such as an excerpt from the company's website.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DoNotBulkEMail"></a> DoNotBulkEMail

**Description**: Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.<br />
**DisplayName**: Do not allow Bulk Emails<br />
**LogicalName**: donotbulkemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotBulkPostalMail"></a> DoNotBulkPostalMail

**Description**: Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.<br />
**DisplayName**: Do not allow Bulk Mails<br />
**LogicalName**: donotbulkpostalmail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_DoNotEMail"></a> DoNotEMail

**Description**: Select whether the account allows direct email sent from Microsoft Dynamics 365.<br />
**DisplayName**: Do not allow Emails<br />
**LogicalName**: donotemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotFax"></a> DoNotFax

**Description**: Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.<br />
**DisplayName**: Do not allow Faxes<br />
**LogicalName**: donotfax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotPhone"></a> DoNotPhone

**Description**: Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.<br />
**DisplayName**: Do not allow Phone Calls<br />
**LogicalName**: donotphone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

**Description**: Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.<br />
**DisplayName**: Do not allow Mails<br />
**LogicalName**: donotpostalmail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotSendMM"></a> DoNotSendMM

**Description**: Select whether the account accepts marketing materials, such as brochures or catalogs.<br />
**DisplayName**: Send Marketing Materials<br />
**LogicalName**: donotsendmm<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Send
- **FalseOption Value**: 0 **Label**: Send

**DefaultValue**: False


### <a name="BKMK_EMailAddress1"></a> EMailAddress1

**Description**: Type the primary email address for the account.<br />
**DisplayName**: Email<br />
**LogicalName**: emailaddress1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EMailAddress2"></a> EMailAddress2

**Description**: Type the secondary email address for the account.<br />
**DisplayName**: Email Address 2<br />
**LogicalName**: emailaddress2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EMailAddress3"></a> EMailAddress3

**Description**: Type an alternate email address for the account.<br />
**DisplayName**: Email Address 3<br />
**LogicalName**: emailaddress3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: Shows the default image for the record.<br />
**DisplayName**: Default Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: True<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_Fax"></a> Fax

**Description**: Type the fax number for the account.<br />
**DisplayName**: Fax<br />
**LogicalName**: fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_FollowEmail"></a> FollowEmail

**Description**: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.<br />
**DisplayName**: Follow Email Activity<br />
**LogicalName**: followemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Allow
- **FalseOption Value**: 0 **Label**: Do Not Allow

**DefaultValue**: True


### <a name="BKMK_FtpSiteURL"></a> FtpSiteURL

**Description**: Type the URL for the account's FTP site to enable users to access data and share documents.<br />
**DisplayName**: FTP Site<br />
**LogicalName**: ftpsiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IndustryCode"></a> IndustryCode

**Description**: Select the account's primary industry for use in marketing segmentation and demographic analysis.<br />
**DisplayName**: Industry<br />
**LogicalName**: industrycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Accounting
- **Value**: 2 **Label**: Agriculture and Non-petrol Natural Resource Extraction
- **Value**: 3 **Label**: Broadcasting Printing and Publishing
- **Value**: 4 **Label**: Brokers
- **Value**: 5 **Label**: Building Supply Retail
- **Value**: 6 **Label**: Business Services
- **Value**: 7 **Label**: Consulting
- **Value**: 8 **Label**: Consumer Services
- **Value**: 9 **Label**: Design, Direction and Creative Management
- **Value**: 10 **Label**: Distributors, Dispatchers and Processors
- **Value**: 11 **Label**: Doctor's Offices and Clinics
- **Value**: 12 **Label**: Durable Manufacturing
- **Value**: 13 **Label**: Eating and Drinking Places
- **Value**: 14 **Label**: Entertainment Retail
- **Value**: 15 **Label**: Equipment Rental and Leasing
- **Value**: 16 **Label**: Financial
- **Value**: 17 **Label**: Food and Tobacco Processing
- **Value**: 18 **Label**: Inbound Capital Intensive Processing
- **Value**: 19 **Label**: Inbound Repair and Services
- **Value**: 20 **Label**: Insurance
- **Value**: 21 **Label**: Legal Services
- **Value**: 22 **Label**: Non-Durable Merchandise Retail
- **Value**: 23 **Label**: Outbound Consumer Service
- **Value**: 24 **Label**: Petrochemical Extraction and Distribution
- **Value**: 25 **Label**: Service Retail
- **Value**: 26 **Label**: SIG Affiliations
- **Value**: 27 **Label**: Social Services
- **Value**: 28 **Label**: Special Outbound Trade Contractors
- **Value**: 29 **Label**: Specialty Realty
- **Value**: 30 **Label**: Transportation
- **Value**: 31 **Label**: Utility Creation and Distribution
- **Value**: 32 **Label**: Vehicle Retail
- **Value**: 33 **Label**: Wholesale



### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

**Description**: Contains the date and time stamp of the last on hold time.<br />
**DisplayName**: Last On Hold Time<br />
**LogicalName**: lastonholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_LastUsedInCampaign"></a> LastUsedInCampaign

**Description**: Shows the date when the account was last included in a marketing campaign or quick campaign.<br />
**DisplayName**: Last Date Included in Campaign<br />
**LogicalName**: lastusedincampaign<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_MarketCap"></a> MarketCap

**Description**: Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.<br />
**DisplayName**: Market Capitalization<br />
**LogicalName**: marketcap<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_MarketingOnly"></a> MarketingOnly

**Description**: Whether is only for marketing<br />
**DisplayName**: Marketing Only<br />
**LogicalName**: marketingonly<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

**Added by**: Field Service Solution<br />
**Description**: Reference to an other account to be used for billing (only to be used if billing account differs)<br />
**DisplayName**: Billing Account<br />
**LogicalName**: msdyn_billingaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_externalaccountid"></a> msdyn_externalaccountid

**Added by**: Project Service Automation Solution<br />
**Description**: External Account ID from other systems.<br />
**DisplayName**: External ID<br />
**LogicalName**: msdyn_externalaccountid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Preferred Resource (Deprecated)<br />
**LogicalName**: msdyn_preferredresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

**Added by**: Field Service Solution<br />
**Description**: Default Sales Tax Code<br />
**DisplayName**: Sales Tax Code<br />
**LogicalName**: msdyn_salestaxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

**Added by**: Field Service Solution<br />
**Description**: The Service Territory this account belongs to. This is used to optimize scheduling and routing<br />
**DisplayName**: Service Territory<br />
**LogicalName**: msdyn_serviceterritory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: territory


### <a name="BKMK_msdyn_TaxExempt"></a> msdyn_TaxExempt

**Added by**: Field Service Solution<br />
**Description**: Select whether the account is tax exempt.<br />
**DisplayName**: Tax Exempt<br />
**LogicalName**: msdyn_taxexempt<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_TaxExemptNumber"></a> msdyn_TaxExemptNumber

**Added by**: Field Service Solution<br />
**Description**: Shows the government tax exempt number.<br />
**DisplayName**: Tax Exempt Number<br />
**LogicalName**: msdyn_taxexemptnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_msdyn_TravelCharge"></a> msdyn_TravelCharge

**Added by**: Field Service Solution<br />
**Description**: Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.<br />
**DisplayName**: Travel Charge<br />
**LogicalName**: msdyn_travelcharge<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TravelChargeType"></a> msdyn_TravelChargeType

**Added by**: Field Service Solution<br />
**Description**: Specify how travel is charged for this account.<br />
**DisplayName**: Travel Charge Type<br />
**LogicalName**: msdyn_travelchargetype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Hourly
- **Value**: 690970001 **Label**: Mileage
- **Value**: 690970002 **Label**: Fixed
- **Value**: 690970003 **Label**: None



### <a name="BKMK_msdyn_WorkOrderInstructions"></a> msdyn_WorkOrderInstructions

**Added by**: Field Service Solution<br />
**Description**: Shows the default instructions to show on new work orders.<br />
**DisplayName**: Work Order Instructions<br />
**LogicalName**: msdyn_workorderinstructions<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_Name"></a> Name

**Description**: Type the company or business name.<br />
**DisplayName**: Account Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_NumberOfEmployees"></a> NumberOfEmployees

**Description**: Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.<br />
**DisplayName**: Number of Employees<br />
**LogicalName**: numberofemployees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

**Description**: Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.<br />
**DisplayName**: Originating Lead<br />
**LogicalName**: originatingleadid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: lead


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwnershipCode"></a> OwnershipCode

**Description**: Select the account's ownership structure, such as public or private.<br />
**DisplayName**: Ownership<br />
**LogicalName**: ownershipcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Public
- **Value**: 2 **Label**: Private
- **Value**: 3 **Label**: Subsidiary
- **Value**: 4 **Label**: Other



### <a name="BKMK_ParentAccountId"></a> ParentAccountId

**Description**: Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.<br />
**DisplayName**: Parent Account<br />
**LogicalName**: parentaccountid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

**Description**: For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.<br />
**DisplayName**: Participates in Workflow<br />
**LogicalName**: participatesinworkflow<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_PaymentTermsCode"></a> PaymentTermsCode

**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />
**DisplayName**: Payment Terms<br />
**LogicalName**: paymenttermscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Net 30
- **Value**: 2 **Label**: 2% 10, Net 30
- **Value**: 3 **Label**: Net 45
- **Value**: 4 **Label**: Net 60



### <a name="BKMK_PreferredAppointmentDayCode"></a> PreferredAppointmentDayCode

**Description**: Select the preferred day of the week for service appointments.<br />
**DisplayName**: Preferred Day<br />
**LogicalName**: preferredappointmentdaycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Sunday
- **Value**: 1 **Label**: Monday
- **Value**: 2 **Label**: Tuesday
- **Value**: 3 **Label**: Wednesday
- **Value**: 4 **Label**: Thursday
- **Value**: 5 **Label**: Friday
- **Value**: 6 **Label**: Saturday



### <a name="BKMK_PreferredAppointmentTimeCode"></a> PreferredAppointmentTimeCode

**Description**: Select the preferred time of day for service appointments.<br />
**DisplayName**: Preferred Time<br />
**LogicalName**: preferredappointmenttimecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Morning
- **Value**: 2 **Label**: Afternoon
- **Value**: 3 **Label**: Evening



### <a name="BKMK_PreferredContactMethodCode"></a> PreferredContactMethodCode

**Description**: Select the preferred method of contact.<br />
**DisplayName**: Preferred Method of Contact<br />
**LogicalName**: preferredcontactmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Any
- **Value**: 2 **Label**: Email
- **Value**: 3 **Label**: Phone
- **Value**: 4 **Label**: Fax
- **Value**: 5 **Label**: Mail



### <a name="BKMK_PreferredEquipmentId"></a> PreferredEquipmentId

**Description**: Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.<br />
**DisplayName**: Preferred Facility/Equipment<br />
**LogicalName**: preferredequipmentid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: equipment


### <a name="BKMK_PreferredServiceId"></a> PreferredServiceId

**Description**: Choose the account's preferred service for reference when you schedule service activities.<br />
**DisplayName**: Preferred Service<br />
**LogicalName**: preferredserviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_PreferredSystemUserId"></a> PreferredSystemUserId

**Description**: Choose the preferred service representative for reference when you schedule service activities for the account.<br />
**DisplayName**: Preferred User<br />
**LogicalName**: preferredsystemuserid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PrimaryContactId"></a> PrimaryContactId

**Description**: Choose the primary contact for the account to provide quick access to contact details.<br />
**DisplayName**: Primary Contact<br />
**LogicalName**: primarycontactid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_PrimarySatoriId"></a> PrimarySatoriId

**Description**: Primary Satori ID for Account<br />
**DisplayName**: Primary Satori ID<br />
**LogicalName**: primarysatoriid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_PrimaryTwitterId"></a> PrimaryTwitterId

**Description**: Primary Twitter ID for Account<br />
**DisplayName**: Primary Twitter ID<br />
**LogicalName**: primarytwitterid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 128


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Revenue"></a> Revenue

**Description**: Type the annual revenue for the account, used as an indicator in financial performance analysis.<br />
**DisplayName**: Annual Revenue<br />
**LogicalName**: revenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_SharesOutstanding"></a> SharesOutstanding

**Description**: Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.<br />
**DisplayName**: Shares Outstanding<br />
**LogicalName**: sharesoutstanding<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

**Description**: Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.<br />
**DisplayName**: Shipping Method<br />
**LogicalName**: shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_SIC"></a> SIC

**Description**: Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.<br />
**DisplayName**: SIC Code<br />
**LogicalName**: sic<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the Account record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_StageId"></a> StageId

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the account's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_StockExchange"></a> StockExchange

**Description**: Type the stock exchange at which the account is listed to track their stock and financial performance of the company.<br />
**DisplayName**: Stock Exchange<br />
**LogicalName**: stockexchange<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Telephone1"></a> Telephone1

**Description**: Type the main phone number for this account.<br />
**DisplayName**: Main Phone<br />
**LogicalName**: telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Telephone2"></a> Telephone2

**Description**: Type a second phone number for this account.<br />
**DisplayName**: Other Phone<br />
**LogicalName**: telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Telephone3"></a> Telephone3

**Description**: Type a third phone number for this account.<br />
**DisplayName**: Telephone 3<br />
**LogicalName**: telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_TerritoryCode"></a> TerritoryCode

**Description**: Select a region or territory for the account for use in segmentation and analysis.<br />
**DisplayName**: Territory Code<br />
**LogicalName**: territorycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_TerritoryId"></a> TerritoryId

**Description**: Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.<br />
**DisplayName**: Territory<br />
**LogicalName**: territoryid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: territory


### <a name="BKMK_TickerSymbol"></a> TickerSymbol

**Description**: Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.<br />
**DisplayName**: Ticker Symbol<br />
**LogicalName**: tickersymbol<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TickerSymbol<br />
**IsLocalizable**: False<br />
**MaxLength**: 10


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: For internal use only.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_WebSiteURL"></a> WebSiteURL

**Description**: Type the account's website URL to get quick details about the company profile.<br />
**DisplayName**: Website<br />
**LogicalName**: websiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_YomiName"></a> YomiName

**Description**: Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />
**DisplayName**: Yomi Account Name<br />
**LogicalName**: yominame<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 160

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [msdyn_BillingAccountName](#BKMK_msdyn_BillingAccountName)
- [msdyn_BillingAccountYomiName](#BKMK_msdyn_BillingAccountYomiName)
- [msdyn_PreferredResourceName](#BKMK_msdyn_PreferredResourceName)
- [msdyn_SalesTaxCodeName](#BKMK_msdyn_SalesTaxCodeName)
- [msdyn_ServiceTerritoryName](#BKMK_msdyn_ServiceTerritoryName)
- [msdyn_travelcharge_Base](#BKMK_msdyn_travelcharge_Base)
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

**Description**: Shows the complete primary address.<br />
**DisplayName**: Address 1<br />
**LogicalName**: address1_composite<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1000


### <a name="BKMK_Address2_Composite"></a> Address2_Composite

**Description**: Shows the complete secondary address.<br />
**DisplayName**: Address 2<br />
**LogicalName**: address2_composite<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1000


### <a name="BKMK_Aging30"></a> Aging30

**Description**: For system use only.<br />
**DisplayName**: Aging 30<br />
**LogicalName**: aging30<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Aging30_Base"></a> Aging30_Base

**Description**: The base currency equivalent of the aging 30 field.<br />
**DisplayName**: Aging 30 (Base)<br />
**LogicalName**: aging30_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_Aging60"></a> Aging60

**Description**: For system use only.<br />
**DisplayName**: Aging 60<br />
**LogicalName**: aging60<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Aging60_Base"></a> Aging60_Base

**Description**: The base currency equivalent of the aging 60 field.<br />
**DisplayName**: Aging 60 (Base)<br />
**LogicalName**: aging60_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_Aging90"></a> Aging90

**Description**: For system use only.<br />
**DisplayName**: Aging 90<br />
**LogicalName**: aging90<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Aging90_Base"></a> Aging90_Base

**Description**: The base currency equivalent of the aging 90 field.<br />
**DisplayName**: Aging 90 (Base)<br />
**LogicalName**: aging90_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

**Description**: Shows the external party who created the record.<br />
**DisplayName**: Created By (External Party)<br />
**LogicalName**: createdbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreditLimit_Base"></a> CreditLimit_Base

**Description**: Shows the credit limit converted to the system's default base currency for reporting purposes.<br />
**DisplayName**: Credit Limit (Base)<br />
**LogicalName**: creditlimit_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_DefaultPriceLevelIdName"></a> DefaultPriceLevelIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: defaultpricelevelidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: For internal use only.<br />
**DisplayName**: Entity Image Id<br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_IsPrivate"></a> IsPrivate

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: isprivate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_MarketCap_Base"></a> MarketCap_Base

**Description**: Shows the market capitalization converted to the system's default base currency.<br />
**DisplayName**: Market Capitalization (Base)<br />
**LogicalName**: marketcap_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_MasterAccountIdName"></a> MasterAccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: masteraccountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_MasterAccountIdYomiName"></a> MasterAccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: masteraccountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_MasterId"></a> MasterId

**Description**: Shows the master account that the account was merged with.<br />
**DisplayName**: Master ID<br />
**LogicalName**: masterid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_Merged"></a> Merged

**Description**: Shows whether the account has been merged with another account.<br />
**DisplayName**: Merged<br />
**LogicalName**: merged<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

**Description**: Shows the external party who modified the record.<br />
**DisplayName**: Modified By (External Party)<br />
**LogicalName**: modifiedbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_BillingAccountName"></a> msdyn_BillingAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_BillingAccountYomiName"></a> msdyn_BillingAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_PreferredResourceName"></a> msdyn_PreferredResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_preferredresourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SalesTaxCodeName"></a> msdyn_SalesTaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_salestaxcodename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ServiceTerritoryName"></a> msdyn_ServiceTerritoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceterritoryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_travelcharge_Base"></a> msdyn_travelcharge_Base

**Added by**: Field Service Solution<br />
**Description**: Value of the Travel Charge in base currency.<br />
**DisplayName**: Travel Charge (Base)<br />
**LogicalName**: msdyn_travelcharge_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

**Description**: Shows how long, in minutes, that the record was on hold.<br />
**DisplayName**: On Hold Time (Minutes)<br />
**LogicalName**: onholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OpenDeals"></a> OpenDeals

**Description**: Number of open opportunities against an account and its child accounts.<br />
**DisplayName**: Open Deals<br />
**LogicalName**: opendeals<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OpenDeals_Date"></a> OpenDeals_Date

**Description**: Last Updated time of rollup field Open Deals.<br />
**DisplayName**: Open Deals (Last Updated On)<br />
**LogicalName**: opendeals_date<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_OpenDeals_State"></a> OpenDeals_State

**Description**: State of rollup field Open Deals.<br />
**DisplayName**: Open Deals (State)<br />
**LogicalName**: opendeals_state<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OpenRevenue"></a> OpenRevenue

**Description**: Sum of open revenue against an account and its child accounts.<br />
**DisplayName**: Open Revenue<br />
**LogicalName**: openrevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_OpenRevenue_Base"></a> OpenRevenue_Base

**Description**: Value of the Open Revenue in base currency.<br />
**DisplayName**: Open Revenue (Base)<br />
**LogicalName**: openrevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_OpenRevenue_Date"></a> OpenRevenue_Date

**Description**: Last Updated time of rollup field Open Revenue.<br />
**DisplayName**: Open Revenue (Last Updated On)<br />
**LogicalName**: openrevenue_date<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_OpenRevenue_State"></a> OpenRevenue_State

**Description**: State of rollup field Open Revenue.<br />
**DisplayName**: Open Revenue (State)<br />
**LogicalName**: openrevenue_state<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OriginatingLeadIdName"></a> OriginatingLeadIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingleadidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OriginatingLeadIdYomiName"></a> OriginatingLeadIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingleadidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Shows the business unit that the record owner belongs to.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the account.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the account.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ParentAccountIdName"></a> ParentAccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentaccountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ParentAccountIdYomiName"></a> ParentAccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentaccountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PreferredEquipmentIdName"></a> PreferredEquipmentIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: preferredequipmentidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PreferredServiceIdName"></a> PreferredServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: preferredserviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PreferredSystemUserIdName"></a> PreferredSystemUserIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: preferredsystemuseridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PreferredSystemUserIdYomiName"></a> PreferredSystemUserIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: preferredsystemuseridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PrimaryContactIdName"></a> PrimaryContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: primarycontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PrimaryContactIdYomiName"></a> PrimaryContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: primarycontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Revenue_Base"></a> Revenue_Base

**Description**: Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />
**DisplayName**: Annual Revenue (Base)<br />
**LogicalName**: revenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this case. This field is for internal use only.<br />
**DisplayName**: Last SLA applied<br />
**LogicalName**: slainvokedid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slainvokedidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAName"></a> SLAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TerritoryIdName"></a> TerritoryIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: territoryidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

**Description**: Total time spent for emails (read and write) and meetings by me in relation to account record.<br />
**DisplayName**: Time Spent by me<br />
**LogicalName**: timespentbymeonemailandmeetings<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the account.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_account_msdyn_iotdevice_Account](#BKMK_msdyn_account_msdyn_iotdevice_Account)
- [lead_customer_accounts](#BKMK_lead_customer_accounts)
- [lead_parent_account](#BKMK_lead_parent_account)
- [account_bookableresource_AccountId](#BKMK_account_bookableresource_AccountId)
- [account_BulkOperations](#BKMK_account_BulkOperations)
- [account_CampaignActivities](#BKMK_account_CampaignActivities)
- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [account_IncidentResolutions](#BKMK_account_IncidentResolutions)
- [Account_ServiceAppointments](#BKMK_Account_ServiceAppointments)
- [contractlineitem_customer_accounts](#BKMK_contractlineitem_customer_accounts)
- [contract_billingcustomer_accounts](#BKMK_contract_billingcustomer_accounts)
- [contract_customer_accounts](#BKMK_contract_customer_accounts)
- [incident_customer_accounts](#BKMK_incident_customer_accounts)
- [account_entitlement_Account](#BKMK_account_entitlement_Account)
- [account_entitlement_Customer](#BKMK_account_entitlement_Customer)
- [account_OpportunityCloses](#BKMK_account_OpportunityCloses)
- [account_OrderCloses](#BKMK_account_OrderCloses)
- [account_QuoteCloses](#BKMK_account_QuoteCloses)
- [account_customer_opportunity_roles](#BKMK_account_customer_opportunity_roles)
- [invoice_customer_accounts](#BKMK_invoice_customer_accounts)
- [opportunity_customer_accounts](#BKMK_opportunity_customer_accounts)
- [order_customer_accounts](#BKMK_order_customer_accounts)
- [quote_customer_accounts](#BKMK_quote_customer_accounts)
- [opportunity_parent_account](#BKMK_opportunity_parent_account)
- [account_msdyn_bookingalerts](#BKMK_account_msdyn_bookingalerts)
- [msdyn_account_msdyn_actual_AccountCustomer](#BKMK_msdyn_account_msdyn_actual_AccountCustomer)
- [msdyn_account_msdyn_actual_AccountVendor](#BKMK_msdyn_account_msdyn_actual_AccountVendor)
- [account_msdyn_approvals](#BKMK_account_msdyn_approvals)
- [msdyn_account_msdyn_accountpricelist_Account](#BKMK_msdyn_account_msdyn_accountpricelist_Account)
- [msdyn_account_msdyn_estimateline_AccountCustomer](#BKMK_msdyn_account_msdyn_estimateline_AccountCustomer)
- [msdyn_account_msdyn_estimateline_AccountVendor](#BKMK_msdyn_account_msdyn_estimateline_AccountVendor)
- [msdyn_account_msdyn_fact_AccountCustomer](#BKMK_msdyn_account_msdyn_fact_AccountCustomer)
- [msdyn_account_msdyn_fact_AccountVendor](#BKMK_msdyn_account_msdyn_fact_AccountVendor)
- [msdyn_account_msdyn_invoicelinetransaction_AccountCustomer](#BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountCustomer)
- [msdyn_account_msdyn_invoicelinetransaction_AccountVendor](#BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountVendor)
- [msdyn_account_msdyn_journalline_AccountCustomer](#BKMK_msdyn_account_msdyn_journalline_AccountCustomer)
- [msdyn_account_msdyn_journalline_AccountVendor](#BKMK_msdyn_account_msdyn_journalline_AccountVendor)
- [msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer](#BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer)
- [msdyn_account_msdyn_opportunitylinetransaction_AccountVendor](#BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountVendor)
- [msdyn_account_msdyn_orderlinetransaction_AccountCustomer](#BKMK_msdyn_account_msdyn_orderlinetransaction_AccountCustomer)
- [msdyn_account_msdyn_orderlinetransaction_AccountVendor](#BKMK_msdyn_account_msdyn_orderlinetransaction_AccountVendor)
- [msdyn_account_msdyn_project_Customer](#BKMK_msdyn_account_msdyn_project_Customer)
- [msdyn_account_msdyn_quotelinetransaction_AccountCustomer](#BKMK_msdyn_account_msdyn_quotelinetransaction_AccountCustomer)
- [msdyn_account_msdyn_quotelinetransaction_AccountVendor](#BKMK_msdyn_account_msdyn_quotelinetransaction_AccountVendor)
- [msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount)
- [msdyn_account_msdyn_actual_ServiceAccount](#BKMK_msdyn_account_msdyn_actual_ServiceAccount)
- [msdyn_account_msdyn_agreement_BillingAccount](#BKMK_msdyn_account_msdyn_agreement_BillingAccount)
- [msdyn_account_msdyn_agreement_ServiceAccount](#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)
- [msdyn_account_msdyn_customerasset_Account](#BKMK_msdyn_account_msdyn_customerasset_Account)
- [msdyn_account_msdyn_payment_Account](#BKMK_msdyn_account_msdyn_payment_Account)
- [msdyn_account_msdyn_purchaseorder_Vendor](#BKMK_msdyn_account_msdyn_purchaseorder_Vendor)
- [msdyn_account_msdyn_requirementresourcepreference_Account](#BKMK_msdyn_account_msdyn_requirementresourcepreference_Account)
- [msdyn_account_msdyn_rma_BillingAccount](#BKMK_msdyn_account_msdyn_rma_BillingAccount)
- [msdyn_account_msdyn_rma_ServiceAccount](#BKMK_msdyn_account_msdyn_rma_ServiceAccount)
- [msdyn_account_msdyn_rmaproduct_Changeownership](#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership)
- [msdyn_account_msdyn_rmaproduct_ReturntoVendor](#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor)
- [msdyn_account_msdyn_rtv_Vendor](#BKMK_msdyn_account_msdyn_rtv_Vendor)
- [msdyn_account_msdyn_workorder_BillingAccount](#BKMK_msdyn_account_msdyn_workorder_BillingAccount)
- [msdyn_account_msdyn_workorder_ServiceAccount](#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)
- [msdyn_account_msdyn_workorderresourcerestriction_Account](#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account)
- [msdyn_account_opportunityproduct_ServiceAccount](#BKMK_msdyn_account_opportunityproduct_ServiceAccount)
- [msdyn_account_product_DefaultVendor](#BKMK_msdyn_account_product_DefaultVendor)
- [msdyn_account_quote_Account](#BKMK_msdyn_account_quote_Account)
- [msdyn_account_quotedetail_ServiceAccount](#BKMK_msdyn_account_quotedetail_ServiceAccount)
- [msdyn_account_salesorder_Account](#BKMK_msdyn_account_salesorder_Account)
- [account_principalobjectattributeaccess](#BKMK_account_principalobjectattributeaccess)
- [Account_Faxes](#BKMK_Account_Faxes)
- [slakpiinstance_account](#BKMK_slakpiinstance_account)
- [account_PostFollows](#BKMK_account_PostFollows)
- [Account_Tasks](#BKMK_Account_Tasks)
- [account_connections1](#BKMK_account_connections1)
- [account_customer_relationship_customer](#BKMK_account_customer_relationship_customer)
- [userentityinstancedata_account](#BKMK_userentityinstancedata_account)
- [SocialActivity_PostAuthorAccount_accounts](#BKMK_SocialActivity_PostAuthorAccount_accounts)
- [Account_DuplicateBaseRecord](#BKMK_Account_DuplicateBaseRecord)
- [SocialActivity_PostAuthor_accounts](#BKMK_SocialActivity_PostAuthor_accounts)
- [Account_SyncErrors](#BKMK_Account_SyncErrors)
- [Account_MailboxTrackingFolder](#BKMK_Account_MailboxTrackingFolder)
- [Account_BulkDeleteFailures](#BKMK_Account_BulkDeleteFailures)
- [Account_ActivityPointers](#BKMK_Account_ActivityPointers)
- [Account_Email_SendersAccount](#BKMK_Account_Email_SendersAccount)
- [Account_Appointments](#BKMK_Account_Appointments)
- [Socialprofile_customer_accounts](#BKMK_Socialprofile_customer_accounts)
- [Account_Emails](#BKMK_Account_Emails)
- [account_activity_parties](#BKMK_account_activity_parties)
- [Account_Phonecalls](#BKMK_Account_Phonecalls)
- [account_customer_relationship_partner](#BKMK_account_customer_relationship_partner)
- [Account_SocialActivities](#BKMK_Account_SocialActivities)
- [Account_DuplicateMatchingRecord](#BKMK_Account_DuplicateMatchingRecord)
- [Account_SharepointDocument](#BKMK_Account_SharepointDocument)
- [account_actioncard](#BKMK_account_actioncard)
- [Account_AsyncOperations](#BKMK_Account_AsyncOperations)
- [Account_CustomerAddress](#BKMK_Account_CustomerAddress)
- [Account_Annotation](#BKMK_Account_Annotation)
- [Account_Letters](#BKMK_Account_Letters)
- [Account_RecurringAppointmentMasters](#BKMK_Account_RecurringAppointmentMasters)
- [Account_Email_EmailSender](#BKMK_Account_Email_EmailSender)
- [Account_ProcessSessions](#BKMK_Account_ProcessSessions)
- [account_parent_account](#BKMK_account_parent_account)
- [contact_customer_accounts](#BKMK_contact_customer_accounts)
- [account_master_account](#BKMK_account_master_account)
- [Account_SharepointDocumentLocation](#BKMK_Account_SharepointDocumentLocation)
- [account_connections2](#BKMK_account_connections2)


### <a name="BKMK_msdyn_account_msdyn_iotdevice_Account"></a> msdyn_account_msdyn_iotdevice_Account

Same as msdyn_iotdevice entity [msdyn_account_msdyn_iotdevice_Account](msdyn_iotdevice.md#BKMK_msdyn_account_msdyn_iotdevice_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevice<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_iotdevice_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_lead_customer_accounts"></a> lead_customer_accounts

Same as lead entity [lead_customer_accounts](lead.md#BKMK_lead_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lead_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_lead_parent_account"></a> lead_parent_account

Same as lead entity [lead_parent_account](lead.md#BKMK_lead_parent_account) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: parentaccountid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lead_parent_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_bookableresource_AccountId"></a> account_bookableresource_AccountId

Same as bookableresource entity [account_bookableresource_AccountId](bookableresource.md#BKMK_account_bookableresource_AccountId) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: accountid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_bookableresource_AccountId<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_BulkOperations"></a> account_BulkOperations

Same as bulkoperation entity [account_BulkOperations](bulkoperation.md#BKMK_account_BulkOperations) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_BulkOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_CampaignActivities"></a> account_CampaignActivities

Same as campaignactivity entity [account_CampaignActivities](campaignactivity.md#BKMK_account_CampaignActivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_CampaignActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

Same as campaignresponse entity [account_CampaignResponses](campaignresponse.md#BKMK_account_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_CampaignResponses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

Same as bulkoperationlog entity [CreatedAccount_BulkOperationLogs2](bulkoperationlog.md#BKMK_CreatedAccount_BulkOperationLogs2) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: createdobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CreatedAccount_BulkOperationLogs2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

Same as bulkoperationlog entity [SourceAccount_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceAccount_BulkOperationLogs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SourceAccount_BulkOperationLogs<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_IncidentResolutions"></a> account_IncidentResolutions

Same as incidentresolution entity [account_IncidentResolutions](incidentresolution.md#BKMK_account_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_IncidentResolutions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_ServiceAppointments"></a> Account_ServiceAppointments

Same as serviceappointment entity [Account_ServiceAppointments](serviceappointment.md#BKMK_Account_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_contractlineitem_customer_accounts"></a> contractlineitem_customer_accounts

Same as contractdetail entity [contractlineitem_customer_accounts](contractdetail.md#BKMK_contractlineitem_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contractlineitem_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_contract_billingcustomer_accounts"></a> contract_billingcustomer_accounts

Same as contract entity [contract_billingcustomer_accounts](contract.md#BKMK_contract_billingcustomer_accounts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: billingcustomerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_billingcustomer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_contract_customer_accounts"></a> contract_customer_accounts

Same as contract entity [contract_customer_accounts](contract.md#BKMK_contract_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Service
- **Label**: 
- **Order**: 20

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_customer_accounts"></a> incident_customer_accounts

Same as incident entity [incident_customer_accounts](incident.md#BKMK_incident_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Service
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_entitlement_Account"></a> account_entitlement_Account

Same as entitlement entity [account_entitlement_Account](entitlement.md#BKMK_account_entitlement_Account) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: accountid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_entitlement_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_entitlement_Customer"></a> account_entitlement_Customer

Same as entitlement entity [account_entitlement_Customer](entitlement.md#BKMK_account_entitlement_Customer) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_entitlement_Customer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_OpportunityCloses"></a> account_OpportunityCloses

Same as opportunityclose entity [account_OpportunityCloses](opportunityclose.md#BKMK_account_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_OpportunityCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_OrderCloses"></a> account_OrderCloses

Same as orderclose entity [account_OrderCloses](orderclose.md#BKMK_account_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_OrderCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_QuoteCloses"></a> account_QuoteCloses

Same as quoteclose entity [account_QuoteCloses](quoteclose.md#BKMK_account_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_QuoteCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_customer_opportunity_roles"></a> account_customer_opportunity_roles

Same as customeropportunityrole entity [account_customer_opportunity_roles](customeropportunityrole.md#BKMK_account_customer_opportunity_roles) Many-To-One relationship.

**ReferencingEntity**: customeropportunityrole<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_customer_opportunity_roles<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_invoice_customer_accounts"></a> invoice_customer_accounts

Same as invoice entity [invoice_customer_accounts](invoice.md#BKMK_invoice_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: invoice_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 40

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_opportunity_customer_accounts"></a> opportunity_customer_accounts

Same as opportunity entity [opportunity_customer_accounts](opportunity.md#BKMK_opportunity_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunity_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_order_customer_accounts"></a> order_customer_accounts

Same as salesorder entity [order_customer_accounts](salesorder.md#BKMK_order_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: order_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 30

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_quote_customer_accounts"></a> quote_customer_accounts

Same as quote entity [quote_customer_accounts](quote.md#BKMK_quote_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: quote_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 20

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_opportunity_parent_account"></a> opportunity_parent_account

Same as opportunity entity [opportunity_parent_account](opportunity.md#BKMK_opportunity_parent_account) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: parentaccountid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunity_parent_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_msdyn_bookingalerts"></a> account_msdyn_bookingalerts

Same as msdyn_bookingalert entity [account_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_account_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_account_msdyn_actual_AccountCustomer"></a> msdyn_account_msdyn_actual_AccountCustomer

Same as msdyn_actual entity [msdyn_account_msdyn_actual_AccountCustomer](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_actual_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_actual_AccountVendor"></a> msdyn_account_msdyn_actual_AccountVendor

Same as msdyn_actual entity [msdyn_account_msdyn_actual_AccountVendor](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_actual_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_msdyn_approvals"></a> account_msdyn_approvals

Same as msdyn_approval entity [account_msdyn_approvals](msdyn_approval.md#BKMK_account_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_account_msdyn_accountpricelist_Account"></a> msdyn_account_msdyn_accountpricelist_Account

Same as msdyn_accountpricelist entity [msdyn_account_msdyn_accountpricelist_Account](msdyn_accountpricelist.md#BKMK_msdyn_account_msdyn_accountpricelist_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_accountpricelist<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_accountpricelist_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_account_msdyn_estimateline_AccountCustomer"></a> msdyn_account_msdyn_estimateline_AccountCustomer

Same as msdyn_estimateline entity [msdyn_account_msdyn_estimateline_AccountCustomer](msdyn_estimateline.md#BKMK_msdyn_account_msdyn_estimateline_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_estimateline_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_estimateline_AccountVendor"></a> msdyn_account_msdyn_estimateline_AccountVendor

Same as msdyn_estimateline entity [msdyn_account_msdyn_estimateline_AccountVendor](msdyn_estimateline.md#BKMK_msdyn_account_msdyn_estimateline_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_estimateline_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_fact_AccountCustomer"></a> msdyn_account_msdyn_fact_AccountCustomer

Same as msdyn_fact entity [msdyn_account_msdyn_fact_AccountCustomer](msdyn_fact.md#BKMK_msdyn_account_msdyn_fact_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_fact_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_fact_AccountVendor"></a> msdyn_account_msdyn_fact_AccountVendor

Same as msdyn_fact entity [msdyn_account_msdyn_fact_AccountVendor](msdyn_fact.md#BKMK_msdyn_account_msdyn_fact_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_fact_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountCustomer"></a> msdyn_account_msdyn_invoicelinetransaction_AccountCustomer

Same as msdyn_invoicelinetransaction entity [msdyn_account_msdyn_invoicelinetransaction_AccountCustomer](msdyn_invoicelinetransaction.md#BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_invoicelinetransaction_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountVendor"></a> msdyn_account_msdyn_invoicelinetransaction_AccountVendor

Same as msdyn_invoicelinetransaction entity [msdyn_account_msdyn_invoicelinetransaction_AccountVendor](msdyn_invoicelinetransaction.md#BKMK_msdyn_account_msdyn_invoicelinetransaction_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_invoicelinetransaction_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_journalline_AccountCustomer"></a> msdyn_account_msdyn_journalline_AccountCustomer

Same as msdyn_journalline entity [msdyn_account_msdyn_journalline_AccountCustomer](msdyn_journalline.md#BKMK_msdyn_account_msdyn_journalline_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_journalline_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_journalline_AccountVendor"></a> msdyn_account_msdyn_journalline_AccountVendor

Same as msdyn_journalline entity [msdyn_account_msdyn_journalline_AccountVendor](msdyn_journalline.md#BKMK_msdyn_account_msdyn_journalline_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_journalline_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer"></a> msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer

Same as msdyn_opportunitylinetransaction entity [msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer](msdyn_opportunitylinetransaction.md#BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountVendor"></a> msdyn_account_msdyn_opportunitylinetransaction_AccountVendor

Same as msdyn_opportunitylinetransaction entity [msdyn_account_msdyn_opportunitylinetransaction_AccountVendor](msdyn_opportunitylinetransaction.md#BKMK_msdyn_account_msdyn_opportunitylinetransaction_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_opportunitylinetransaction_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_orderlinetransaction_AccountCustomer"></a> msdyn_account_msdyn_orderlinetransaction_AccountCustomer

Same as msdyn_orderlinetransaction entity [msdyn_account_msdyn_orderlinetransaction_AccountCustomer](msdyn_orderlinetransaction.md#BKMK_msdyn_account_msdyn_orderlinetransaction_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_orderlinetransaction_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_orderlinetransaction_AccountVendor"></a> msdyn_account_msdyn_orderlinetransaction_AccountVendor

Same as msdyn_orderlinetransaction entity [msdyn_account_msdyn_orderlinetransaction_AccountVendor](msdyn_orderlinetransaction.md#BKMK_msdyn_account_msdyn_orderlinetransaction_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_orderlinetransaction_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_project_Customer"></a> msdyn_account_msdyn_project_Customer

Same as msdyn_project entity [msdyn_account_msdyn_project_Customer](msdyn_project.md#BKMK_msdyn_account_msdyn_project_Customer) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: msdyn_customer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_project_Customer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_quotelinetransaction_AccountCustomer"></a> msdyn_account_msdyn_quotelinetransaction_AccountCustomer

Same as msdyn_quotelinetransaction entity [msdyn_account_msdyn_quotelinetransaction_AccountCustomer](msdyn_quotelinetransaction.md#BKMK_msdyn_account_msdyn_quotelinetransaction_AccountCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_accountcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_quotelinetransaction_AccountCustomer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_quotelinetransaction_AccountVendor"></a> msdyn_account_msdyn_quotelinetransaction_AccountVendor

Same as msdyn_quotelinetransaction entity [msdyn_account_msdyn_quotelinetransaction_AccountVendor](msdyn_quotelinetransaction.md#BKMK_msdyn_account_msdyn_quotelinetransaction_AccountVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_accountvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_quotelinetransaction_AccountVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_account_BillingAccount"></a> msdyn_account_account_BillingAccount

Same as account entity [msdyn_account_account_BillingAccount](account.md#BKMK_msdyn_account_account_BillingAccount) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: msdyn_billingaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_account_BillingAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Billed Accounts
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_actual_ServiceAccount"></a> msdyn_account_msdyn_actual_ServiceAccount

Same as msdyn_actual entity [msdyn_account_msdyn_actual_ServiceAccount](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_actual_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_agreement_BillingAccount"></a> msdyn_account_msdyn_agreement_BillingAccount

Same as msdyn_agreement entity [msdyn_account_msdyn_agreement_BillingAccount](msdyn_agreement.md#BKMK_msdyn_account_msdyn_agreement_BillingAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: msdyn_billingaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_agreement_BillingAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Billed Agreements
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_agreement_ServiceAccount"></a> msdyn_account_msdyn_agreement_ServiceAccount

Same as msdyn_agreement entity [msdyn_account_msdyn_agreement_ServiceAccount](msdyn_agreement.md#BKMK_msdyn_account_msdyn_agreement_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_agreement_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_customerasset_Account"></a> msdyn_account_msdyn_customerasset_Account

Same as msdyn_customerasset entity [msdyn_account_msdyn_customerasset_Account](msdyn_customerasset.md#BKMK_msdyn_account_msdyn_customerasset_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_customerasset_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_payment_Account"></a> msdyn_account_msdyn_payment_Account

Same as msdyn_payment entity [msdyn_account_msdyn_payment_Account](msdyn_payment.md#BKMK_msdyn_account_msdyn_payment_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_payment<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_payment_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_purchaseorder_Vendor"></a> msdyn_account_msdyn_purchaseorder_Vendor

Same as msdyn_purchaseorder entity [msdyn_account_msdyn_purchaseorder_Vendor](msdyn_purchaseorder.md#BKMK_msdyn_account_msdyn_purchaseorder_Vendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: msdyn_vendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_purchaseorder_Vendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_requirementresourcepreference_Account"></a> msdyn_account_msdyn_requirementresourcepreference_Account

Same as msdyn_requirementresourcepreference entity [msdyn_account_msdyn_requirementresourcepreference_Account](msdyn_requirementresourcepreference.md#BKMK_msdyn_account_msdyn_requirementresourcepreference_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcepreference<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_requirementresourcepreference_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Resource Preferences
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_rma_BillingAccount"></a> msdyn_account_msdyn_rma_BillingAccount

Same as msdyn_rma entity [msdyn_account_msdyn_rma_BillingAccount](msdyn_rma.md#BKMK_msdyn_account_msdyn_rma_BillingAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_billingaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_rma_BillingAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Billing RMAs
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_rma_ServiceAccount"></a> msdyn_account_msdyn_rma_ServiceAccount

Same as msdyn_rma entity [msdyn_account_msdyn_rma_ServiceAccount](msdyn_rma.md#BKMK_msdyn_account_msdyn_rma_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_rma_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: RMAs
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_rmaproduct_Changeownership"></a> msdyn_account_msdyn_rmaproduct_Changeownership

Same as msdyn_rmaproduct entity [msdyn_account_msdyn_rmaproduct_Changeownership](msdyn_rmaproduct.md#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_changeownership<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_rmaproduct_Changeownership<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Change ownership
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor"></a> msdyn_account_msdyn_rmaproduct_ReturntoVendor

Same as msdyn_rmaproduct entity [msdyn_account_msdyn_rmaproduct_ReturntoVendor](msdyn_rmaproduct.md#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_returntovendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_rmaproduct_ReturntoVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Return to Vendor
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_rtv_Vendor"></a> msdyn_account_msdyn_rtv_Vendor

Same as msdyn_rtv entity [msdyn_account_msdyn_rtv_Vendor](msdyn_rtv.md#BKMK_msdyn_account_msdyn_rtv_Vendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_vendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_rtv_Vendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: RTVs
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_workorder_BillingAccount"></a> msdyn_account_msdyn_workorder_BillingAccount

Same as msdyn_workorder entity [msdyn_account_msdyn_workorder_BillingAccount](msdyn_workorder.md#BKMK_msdyn_account_msdyn_workorder_BillingAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_billingaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_workorder_BillingAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Billed Work Orders
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_workorder_ServiceAccount"></a> msdyn_account_msdyn_workorder_ServiceAccount

Same as msdyn_workorder entity [msdyn_account_msdyn_workorder_ServiceAccount](msdyn_workorder.md#BKMK_msdyn_account_msdyn_workorder_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_workorder_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account"></a> msdyn_account_msdyn_workorderresourcerestriction_Account

Same as msdyn_workorderresourcerestriction entity [msdyn_account_msdyn_workorderresourcerestriction_Account](msdyn_workorderresourcerestriction.md#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderresourcerestriction<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_msdyn_workorderresourcerestriction_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_opportunityproduct_ServiceAccount"></a> msdyn_account_opportunityproduct_ServiceAccount

Same as opportunityproduct entity [msdyn_account_opportunityproduct_ServiceAccount](opportunityproduct.md#BKMK_msdyn_account_opportunityproduct_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_opportunityproduct_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_product_DefaultVendor"></a> msdyn_account_product_DefaultVendor

Same as product entity [msdyn_account_product_DefaultVendor](product.md#BKMK_msdyn_account_product_DefaultVendor) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: msdyn_defaultvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_product_DefaultVendor<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Default Vendor
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_quote_Account"></a> msdyn_account_quote_Account

Same as quote entity [msdyn_account_quote_Account](quote.md#BKMK_msdyn_account_quote_Account) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_quote_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_quotedetail_ServiceAccount"></a> msdyn_account_quotedetail_ServiceAccount

Same as quotedetail entity [msdyn_account_quotedetail_ServiceAccount](quotedetail.md#BKMK_msdyn_account_quotedetail_ServiceAccount) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: msdyn_serviceaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_quotedetail_ServiceAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_account_salesorder_Account"></a> msdyn_account_salesorder_Account

Same as salesorder entity [msdyn_account_salesorder_Account](salesorder.md#BKMK_msdyn_account_salesorder_Account) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: msdyn_account<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_account_salesorder_Account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_principalobjectattributeaccess"></a> account_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [account_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_account_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Faxes"></a> Account_Faxes

Same as fax entity [Account_Faxes](fax.md#BKMK_Account_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_slakpiinstance_account"></a> slakpiinstance_account

Same as slakpiinstance entity [slakpiinstance_account](slakpiinstance.md#BKMK_slakpiinstance_account) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_PostFollows"></a> account_PostFollows

Same as postfollow entity [account_PostFollows](postfollow.md#BKMK_account_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_PostFollows<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Tasks"></a> Account_Tasks

Same as task entity [Account_Tasks](task.md#BKMK_Account_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_connections1"></a> account_connections1

Same as connection entity [account_connections1](connection.md#BKMK_account_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_customer_relationship_customer"></a> account_customer_relationship_customer

Same as customerrelationship entity [account_customer_relationship_customer](customerrelationship.md#BKMK_account_customer_relationship_customer) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_customer_relationship_customer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_account"></a> userentityinstancedata_account

Same as userentityinstancedata entity [userentityinstancedata_account](userentityinstancedata.md#BKMK_userentityinstancedata_account) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SocialActivity_PostAuthorAccount_accounts"></a> SocialActivity_PostAuthorAccount_accounts

Same as socialactivity entity [SocialActivity_PostAuthorAccount_accounts](socialactivity.md#BKMK_SocialActivity_PostAuthorAccount_accounts) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: postauthoraccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_PostAuthorAccount_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_DuplicateBaseRecord"></a> Account_DuplicateBaseRecord

Same as duplicaterecord entity [Account_DuplicateBaseRecord](duplicaterecord.md#BKMK_Account_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SocialActivity_PostAuthor_accounts"></a> SocialActivity_PostAuthor_accounts

Same as socialactivity entity [SocialActivity_PostAuthor_accounts](socialactivity.md#BKMK_SocialActivity_PostAuthor_accounts) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: postauthor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_PostAuthor_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_SyncErrors"></a> Account_SyncErrors

Same as syncerror entity [Account_SyncErrors](syncerror.md#BKMK_Account_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_MailboxTrackingFolder"></a> Account_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Account_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Account_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_MailboxTrackingFolder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_BulkDeleteFailures"></a> Account_BulkDeleteFailures

Same as bulkdeletefailure entity [Account_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Account_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_ActivityPointers"></a> Account_ActivityPointers

Same as activitypointer entity [Account_ActivityPointers](activitypointer.md#BKMK_Account_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 20

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Email_SendersAccount"></a> Account_Email_SendersAccount

Same as email entity [Account_Email_SendersAccount](email.md#BKMK_Account_Email_SendersAccount) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: sendersaccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_Email_SendersAccount<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Appointments"></a> Account_Appointments

Same as appointment entity [Account_Appointments](appointment.md#BKMK_Account_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Socialprofile_customer_accounts"></a> Socialprofile_customer_accounts

Same as socialprofile entity [Socialprofile_customer_accounts](socialprofile.md#BKMK_Socialprofile_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: socialprofile<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Socialprofile_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 50

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_Emails"></a> Account_Emails

Same as email entity [Account_Emails](email.md#BKMK_Account_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_activity_parties"></a> account_activity_parties

Same as activityparty entity [account_activity_parties](activityparty.md#BKMK_account_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_activity_parties<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Phonecalls"></a> Account_Phonecalls

Same as phonecall entity [Account_Phonecalls](phonecall.md#BKMK_Account_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Phonecalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_customer_relationship_partner"></a> account_customer_relationship_partner

Same as customerrelationship entity [account_customer_relationship_partner](customerrelationship.md#BKMK_account_customer_relationship_partner) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: partnerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: account_customer_relationship_partner<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_SocialActivities"></a> Account_SocialActivities

Same as socialactivity entity [Account_SocialActivities](socialactivity.md#BKMK_Account_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_DuplicateMatchingRecord"></a> Account_DuplicateMatchingRecord

Same as duplicaterecord entity [Account_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Account_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_SharepointDocument"></a> Account_SharepointDocument

Same as sharepointdocument entity [Account_SharepointDocument](sharepointdocument.md#BKMK_Account_SharepointDocument) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_SharepointDocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_actioncard"></a> account_actioncard

Same as actioncard entity [account_actioncard](actioncard.md#BKMK_account_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_actioncard<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_AsyncOperations"></a> Account_AsyncOperations

Same as asyncoperation entity [Account_AsyncOperations](asyncoperation.md#BKMK_Account_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_CustomerAddress"></a> Account_CustomerAddress

Same as customeraddress entity [Account_CustomerAddress](customeraddress.md#BKMK_Account_CustomerAddress) Many-To-One relationship.

**ReferencingEntity**: customeraddress<br />
**ReferencingAttribute**: parentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_CustomerAddress<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_Annotation"></a> Account_Annotation

Same as annotation entity [Account_Annotation](annotation.md#BKMK_Account_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_Letters"></a> Account_Letters

Same as letter entity [Account_Letters](letter.md#BKMK_Account_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_RecurringAppointmentMasters"></a> Account_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Account_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Account_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Account_Email_EmailSender"></a> Account_Email_EmailSender

Same as email entity [Account_Email_EmailSender](email.md#BKMK_Account_Email_EmailSender) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: emailsender<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_Email_EmailSender<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_ProcessSessions"></a> Account_ProcessSessions

Same as processsession entity [Account_ProcessSessions](processsession.md#BKMK_Account_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Account_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_parent_account"></a> account_parent_account

Same as account entity [account_parent_account](account.md#BKMK_account_parent_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: parentaccountid<br />
**IsHierarchical**: True<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_parent_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 40

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_contact_customer_accounts"></a> contact_customer_accounts

Same as contact entity [contact_customer_accounts](contact.md#BKMK_contact_customer_accounts) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: parentcustomerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_customer_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 50

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_account_master_account"></a> account_master_account

Same as account entity [account_master_account](account.md#BKMK_account_master_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: masterid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_master_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Account_SharepointDocumentLocation"></a> Account_SharepointDocumentLocation

Same as sharepointdocumentlocation entity [Account_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Account_SharepointDocumentLocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Account_SharepointDocumentLocation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_account_connections2"></a> account_connections2

Same as connection entity [account_connections2](connection.md#BKMK_account_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [account_originating_lead](#BKMK_account_originating_lead)
- [price_level_accounts](#BKMK_price_level_accounts)
- [equipment_accounts](#BKMK_equipment_accounts)
- [service_accounts](#BKMK_service_accounts)
- [territory_accounts](#BKMK_territory_accounts)
- [msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount)
- [msdyn_bookableresource_account_PreferredResource](#BKMK_msdyn_bookableresource_account_PreferredResource)
- [msdyn_msdyn_taxcode_account_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode)
- [msdyn_territory_account_ServiceTerritory](#BKMK_msdyn_territory_account_ServiceTerritory)
- [account_primary_contact](#BKMK_account_primary_contact)
- [account_master_account](#BKMK_account_master_account)
- [system_user_accounts](#BKMK_system_user_accounts)
- [lk_externalparty_account_createdby](#BKMK_lk_externalparty_account_createdby)
- [lk_accountbase_modifiedby](#BKMK_lk_accountbase_modifiedby)
- [account_parent_account](#BKMK_account_parent_account)
- [business_unit_accounts](#BKMK_business_unit_accounts)
- [transactioncurrency_account](#BKMK_transactioncurrency_account)
- [user_accounts](#BKMK_user_accounts)
- [lk_accountbase_createdonbehalfby](#BKMK_lk_accountbase_createdonbehalfby)
- [processstage_account](#BKMK_processstage_account)
- [manualsla_account](#BKMK_manualsla_account)
- [lk_accountbase_createdby](#BKMK_lk_accountbase_createdby)
- [lk_externalparty_account_modifiedby](#BKMK_lk_externalparty_account_modifiedby)
- [sla_account](#BKMK_sla_account)
- [lk_accountbase_modifiedonbehalfby](#BKMK_lk_accountbase_modifiedonbehalfby)
- [team_accounts](#BKMK_team_accounts)


### <a name="BKMK_account_originating_lead"></a> account_originating_lead

See lead Entity [account_originating_lead](lead.md#BKMK_account_originating_lead) One-To-Many relationship.

### <a name="BKMK_price_level_accounts"></a> price_level_accounts

See pricelevel Entity [price_level_accounts](pricelevel.md#BKMK_price_level_accounts) One-To-Many relationship.

### <a name="BKMK_equipment_accounts"></a> equipment_accounts

See equipment Entity [equipment_accounts](equipment.md#BKMK_equipment_accounts) One-To-Many relationship.

### <a name="BKMK_service_accounts"></a> service_accounts

See service Entity [service_accounts](service.md#BKMK_service_accounts) One-To-Many relationship.

### <a name="BKMK_territory_accounts"></a> territory_accounts

See territory Entity [territory_accounts](territory.md#BKMK_territory_accounts) One-To-Many relationship.

### <a name="BKMK_msdyn_account_account_BillingAccount"></a> msdyn_account_account_BillingAccount

See account Entity [msdyn_account_account_BillingAccount](account.md#BKMK_msdyn_account_account_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_account_PreferredResource"></a> msdyn_bookableresource_account_PreferredResource

See bookableresource Entity [msdyn_bookableresource_account_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_account_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode"></a> msdyn_msdyn_taxcode_account_SalesTaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_account_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_account_ServiceTerritory"></a> msdyn_territory_account_ServiceTerritory

See territory Entity [msdyn_territory_account_ServiceTerritory](territory.md#BKMK_msdyn_territory_account_ServiceTerritory) One-To-Many relationship.

### <a name="BKMK_account_primary_contact"></a> account_primary_contact

See contact Entity [account_primary_contact](contact.md#BKMK_account_primary_contact) One-To-Many relationship.

### <a name="BKMK_account_master_account"></a> account_master_account

See account Entity [account_master_account](account.md#BKMK_account_master_account) One-To-Many relationship.

### <a name="BKMK_system_user_accounts"></a> system_user_accounts

See systemuser Entity [system_user_accounts](systemuser.md#BKMK_system_user_accounts) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_account_createdby"></a> lk_externalparty_account_createdby

See externalparty Entity [lk_externalparty_account_createdby](externalparty.md#BKMK_lk_externalparty_account_createdby) One-To-Many relationship.

### <a name="BKMK_lk_accountbase_modifiedby"></a> lk_accountbase_modifiedby

See systemuser Entity [lk_accountbase_modifiedby](systemuser.md#BKMK_lk_accountbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_account_parent_account"></a> account_parent_account

See account Entity [account_parent_account](account.md#BKMK_account_parent_account) One-To-Many relationship.

### <a name="BKMK_business_unit_accounts"></a> business_unit_accounts

See businessunit Entity [business_unit_accounts](businessunit.md#BKMK_business_unit_accounts) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_account"></a> transactioncurrency_account

See transactioncurrency Entity [transactioncurrency_account](transactioncurrency.md#BKMK_transactioncurrency_account) One-To-Many relationship.

### <a name="BKMK_user_accounts"></a> user_accounts

See systemuser Entity [user_accounts](systemuser.md#BKMK_user_accounts) One-To-Many relationship.

### <a name="BKMK_lk_accountbase_createdonbehalfby"></a> lk_accountbase_createdonbehalfby

See systemuser Entity [lk_accountbase_createdonbehalfby](systemuser.md#BKMK_lk_accountbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_processstage_account"></a> processstage_account

See processstage Entity [processstage_account](processstage.md#BKMK_processstage_account) One-To-Many relationship.

### <a name="BKMK_manualsla_account"></a> manualsla_account

See sla Entity [manualsla_account](sla.md#BKMK_manualsla_account) One-To-Many relationship.

### <a name="BKMK_lk_accountbase_createdby"></a> lk_accountbase_createdby

See systemuser Entity [lk_accountbase_createdby](systemuser.md#BKMK_lk_accountbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_account_modifiedby"></a> lk_externalparty_account_modifiedby

See externalparty Entity [lk_externalparty_account_modifiedby](externalparty.md#BKMK_lk_externalparty_account_modifiedby) One-To-Many relationship.

### <a name="BKMK_sla_account"></a> sla_account

See sla Entity [sla_account](sla.md#BKMK_sla_account) One-To-Many relationship.

### <a name="BKMK_lk_accountbase_modifiedonbehalfby"></a> lk_accountbase_modifiedonbehalfby

See systemuser Entity [lk_accountbase_modifiedonbehalfby](systemuser.md#BKMK_lk_accountbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_team_accounts"></a> team_accounts

See team Entity [team_accounts](team.md#BKMK_team_accounts) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Account entity is the first entity in the relationship. Listed by **SchemaName**.

- [accountleads_association](#BKMK_accountleads_association)
- [listaccount_association](#BKMK_listaccount_association)


### <a name="BKMK_accountleads_association"></a> accountleads_association

**IntersectEntityName**: accountleads<br />
**Entity1LogicalName**: account<br />

- **Entity1IntersectAttribute**: leadid
- **Entity1NavigationPropertyName**: accountleads_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [lead](lead.md)<br />

- **Entity2IntersectAttribute**: accountid
- **Entity2NavigationPropertyName**: accountleads_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_listaccount_association"></a> listaccount_association

See list Entity [listaccount_association](list.md#BKMK_listaccount_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.account?text=account EntityType" />