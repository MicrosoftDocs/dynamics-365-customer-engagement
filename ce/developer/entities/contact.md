---
title: "Contact Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Contact entity."
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
# Contact Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/contacts(*contactid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|Create|POST [*org URI*]/api/data/v9.0/contacts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/contacts(*contactid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|Merge|<xref href="Microsoft.Dynamics.CRM.Merge?text=Merge Action" />|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/contacts(*contactid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/contacts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/contacts(*contactid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/contacts(*contactid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Contact<br />
**DisplayCollectionName**: Contacts<br />
**SchemaName**: Contact<br />
**CollectionSchemaName**: Contacts<br />
**LogicalName**: contact<br />
**LogicalCollectionName**: contacts<br />
**EntitySetName**: contacts<br />
**PrimaryIdAttribute**: contactid<br />
**PrimaryNameAttribute**: fullname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AccountRoleCode](#BKMK_AccountRoleCode)
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
- [Address3_AddressId](#BKMK_Address3_AddressId)
- [Address3_AddressTypeCode](#BKMK_Address3_AddressTypeCode)
- [Address3_City](#BKMK_Address3_City)
- [Address3_Country](#BKMK_Address3_Country)
- [Address3_County](#BKMK_Address3_County)
- [Address3_Fax](#BKMK_Address3_Fax)
- [Address3_FreightTermsCode](#BKMK_Address3_FreightTermsCode)
- [Address3_Latitude](#BKMK_Address3_Latitude)
- [Address3_Line1](#BKMK_Address3_Line1)
- [Address3_Line2](#BKMK_Address3_Line2)
- [Address3_Line3](#BKMK_Address3_Line3)
- [Address3_Longitude](#BKMK_Address3_Longitude)
- [Address3_Name](#BKMK_Address3_Name)
- [Address3_PostalCode](#BKMK_Address3_PostalCode)
- [Address3_PostOfficeBox](#BKMK_Address3_PostOfficeBox)
- [Address3_PrimaryContactName](#BKMK_Address3_PrimaryContactName)
- [Address3_ShippingMethodCode](#BKMK_Address3_ShippingMethodCode)
- [Address3_StateOrProvince](#BKMK_Address3_StateOrProvince)
- [Address3_Telephone1](#BKMK_Address3_Telephone1)
- [Address3_Telephone2](#BKMK_Address3_Telephone2)
- [Address3_Telephone3](#BKMK_Address3_Telephone3)
- [Address3_UPSZone](#BKMK_Address3_UPSZone)
- [Address3_UTCOffset](#BKMK_Address3_UTCOffset)
- [Anniversary](#BKMK_Anniversary)
- [AnnualIncome](#BKMK_AnnualIncome)
- [AssistantName](#BKMK_AssistantName)
- [AssistantPhone](#BKMK_AssistantPhone)
- [BirthDate](#BKMK_BirthDate)
- [Business2](#BKMK_Business2)
- [Callback](#BKMK_Callback)
- [ChildrensNames](#BKMK_ChildrensNames)
- [Company](#BKMK_Company)
- [ContactId](#BKMK_ContactId)
- [CreditLimit](#BKMK_CreditLimit)
- [CreditOnHold](#BKMK_CreditOnHold)
- [CustomerSizeCode](#BKMK_CustomerSizeCode)
- [CustomerTypeCode](#BKMK_CustomerTypeCode)
- [DefaultPriceLevelId](#BKMK_DefaultPriceLevelId)
- [Department](#BKMK_Department)
- [Description](#BKMK_Description)
- [DoNotBulkEMail](#BKMK_DoNotBulkEMail)
- [DoNotBulkPostalMail](#BKMK_DoNotBulkPostalMail)
- [DoNotEMail](#BKMK_DoNotEMail)
- [DoNotFax](#BKMK_DoNotFax)
- [DoNotPhone](#BKMK_DoNotPhone)
- [DoNotPostalMail](#BKMK_DoNotPostalMail)
- [DoNotSendMM](#BKMK_DoNotSendMM)
- [EducationCode](#BKMK_EducationCode)
- [EMailAddress1](#BKMK_EMailAddress1)
- [EMailAddress2](#BKMK_EMailAddress2)
- [EMailAddress3](#BKMK_EMailAddress3)
- [EmployeeId](#BKMK_EmployeeId)
- [EntityImage](#BKMK_EntityImage)
- [ExternalUserIdentifier](#BKMK_ExternalUserIdentifier)
- [FamilyStatusCode](#BKMK_FamilyStatusCode)
- [Fax](#BKMK_Fax)
- [FirstName](#BKMK_FirstName)
- [FollowEmail](#BKMK_FollowEmail)
- [FtpSiteUrl](#BKMK_FtpSiteUrl)
- [GenderCode](#BKMK_GenderCode)
- [GovernmentId](#BKMK_GovernmentId)
- [HasChildrenCode](#BKMK_HasChildrenCode)
- [Home2](#BKMK_Home2)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBackofficeCustomer](#BKMK_IsBackofficeCustomer)
- [JobTitle](#BKMK_JobTitle)
- [LastName](#BKMK_LastName)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LastUsedInCampaign](#BKMK_LastUsedInCampaign)
- [LeadSourceCode](#BKMK_LeadSourceCode)
- [ManagerName](#BKMK_ManagerName)
- [ManagerPhone](#BKMK_ManagerPhone)
- [MarketingOnly](#BKMK_MarketingOnly)
- [MiddleName](#BKMK_MiddleName)
- [MobilePhone](#BKMK_MobilePhone)
- [NickName](#BKMK_NickName)
- [NumberOfChildren](#BKMK_NumberOfChildren)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Pager](#BKMK_Pager)
- [ParentCustomerId](#BKMK_ParentCustomerId)
- [ParentCustomerIdType](#BKMK_ParentCustomerIdType)
- [ParticipatesInWorkflow](#BKMK_ParticipatesInWorkflow)
- [PaymentTermsCode](#BKMK_PaymentTermsCode)
- [PreferredAppointmentDayCode](#BKMK_PreferredAppointmentDayCode)
- [PreferredAppointmentTimeCode](#BKMK_PreferredAppointmentTimeCode)
- [PreferredContactMethodCode](#BKMK_PreferredContactMethodCode)
- [PreferredEquipmentId](#BKMK_PreferredEquipmentId)
- [PreferredServiceId](#BKMK_PreferredServiceId)
- [PreferredSystemUserId](#BKMK_PreferredSystemUserId)
- [ProcessId](#BKMK_ProcessId)
- [Salutation](#BKMK_Salutation)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [SLAId](#BKMK_SLAId)
- [SpousesName](#BKMK_SpousesName)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [SubscriptionId](#BKMK_SubscriptionId)
- [Suffix](#BKMK_Suffix)
- [Telephone1](#BKMK_Telephone1)
- [Telephone2](#BKMK_Telephone2)
- [Telephone3](#BKMK_Telephone3)
- [TerritoryCode](#BKMK_TerritoryCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WebSiteUrl](#BKMK_WebSiteUrl)
- [YomiFirstName](#BKMK_YomiFirstName)
- [YomiLastName](#BKMK_YomiLastName)
- [YomiMiddleName](#BKMK_YomiMiddleName)


### <a name="BKMK_AccountRoleCode"></a> AccountRoleCode

**Description**: Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.<br />
**DisplayName**: Role<br />
**LogicalName**: accountrolecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Decision Maker
- **Value**: 2 **Label**: Employee
- **Value**: 3 **Label**: Influencer



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
**DisplayName**: Address 1: Phone<br />
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
**MaxLength**: 100


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


### <a name="BKMK_Address3_AddressId"></a> Address3_AddressId

**Description**: Unique identifier for address 3.<br />
**DisplayName**: Address 3: ID<br />
**LogicalName**: address3_addressid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Address3_AddressTypeCode"></a> Address3_AddressTypeCode

**Description**: Select the third address type.<br />
**DisplayName**: Address 3: Address Type<br />
**LogicalName**: address3_addresstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address3_City"></a> Address3_City

**Description**: Type the city for the 3rd address.<br />
**DisplayName**: Address 3: City<br />
**LogicalName**: address3_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address3_Country"></a> Address3_Country

**Description**: the country or region for the 3rd address.<br />
**DisplayName**: Address3: Country/Region<br />
**LogicalName**: address3_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address3_County"></a> Address3_County

**Description**: Type the county for the third address.<br />
**DisplayName**: Address 3: County<br />
**LogicalName**: address3_county<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_Fax"></a> Address3_Fax

**Description**: Type the fax number associated with the third address.<br />
**DisplayName**: Address 3: Fax<br />
**LogicalName**: address3_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_FreightTermsCode"></a> Address3_FreightTermsCode

**Description**: Select the freight terms for the third address to make sure shipping orders are processed correctly.<br />
**DisplayName**: Address 3: Freight Terms<br />
**LogicalName**: address3_freighttermscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address3_Latitude"></a> Address3_Latitude

**Description**: Type the latitude value for the third address for use in mapping and other applications.<br />
**DisplayName**: Address 3: Latitude<br />
**LogicalName**: address3_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_Address3_Line1"></a> Address3_Line1

**Description**: the first line of the 3rd address.<br />
**DisplayName**: Address3: Street 1<br />
**LogicalName**: address3_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address3_Line2"></a> Address3_Line2

**Description**: the second line of the 3rd address.<br />
**DisplayName**: Address3: Street 2<br />
**LogicalName**: address3_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address3_Line3"></a> Address3_Line3

**Description**: the third line of the 3rd address.<br />
**DisplayName**: Address3: Street 3<br />
**LogicalName**: address3_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address3_Longitude"></a> Address3_Longitude

**Description**: Type the longitude value for the third address for use in mapping and other applications.<br />
**DisplayName**: Address 3: Longitude<br />
**LogicalName**: address3_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_Address3_Name"></a> Address3_Name

**Description**: Type a descriptive name for the third address, such as Corporate Headquarters.<br />
**DisplayName**: Address 3: Name<br />
**LogicalName**: address3_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_Address3_PostalCode"></a> Address3_PostalCode

**Description**: the ZIP Code or postal code for the 3rd address.<br />
**DisplayName**: Address3: ZIP/Postal Code<br />
**LogicalName**: address3_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address3_PostOfficeBox"></a> Address3_PostOfficeBox

**Description**: the post office box number of the 3rd address.<br />
**DisplayName**: Address 3: Post Office Box<br />
**LogicalName**: address3_postofficebox<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address3_PrimaryContactName"></a> Address3_PrimaryContactName

**Description**: Type the name of the main contact at the account's third address.<br />
**DisplayName**: Address 3: Primary Contact Name<br />
**LogicalName**: address3_primarycontactname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Address3_ShippingMethodCode"></a> Address3_ShippingMethodCode

**Description**: Select a shipping method for deliveries sent to this address.<br />
**DisplayName**: Address 3: Shipping Method<br />
**LogicalName**: address3_shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address3_StateOrProvince"></a> Address3_StateOrProvince

**Description**: the state or province of the third address.<br />
**DisplayName**: Address3: State/Province<br />
**LogicalName**: address3_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_Telephone1"></a> Address3_Telephone1

**Description**: Type the main phone number associated with the third address.<br />
**DisplayName**: Address 3: Telephone1<br />
**LogicalName**: address3_telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_Telephone2"></a> Address3_Telephone2

**Description**: Type a second phone number associated with the third address.<br />
**DisplayName**: Address 3: Telephone2<br />
**LogicalName**: address3_telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_Telephone3"></a> Address3_Telephone3

**Description**: Type a third phone number associated with the primary address.<br />
**DisplayName**: Address 3: Telephone3<br />
**LogicalName**: address3_telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address3_UPSZone"></a> Address3_UPSZone

**Description**: Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />
**DisplayName**: Address 3: UPS Zone<br />
**LogicalName**: address3_upszone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4


### <a name="BKMK_Address3_UTCOffset"></a> Address3_UTCOffset

**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />
**DisplayName**: Address 3: UTC Offset<br />
**LogicalName**: address3_utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_Anniversary"></a> Anniversary

**Description**: Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.<br />
**DisplayName**: Anniversary<br />
**LogicalName**: anniversary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: DateOnly<br />
**Format**: DateOnly


### <a name="BKMK_AnnualIncome"></a> AnnualIncome

**Description**: Type the contact's annual income for use in profiling and financial analysis.<br />
**DisplayName**: Annual Income<br />
**LogicalName**: annualincome<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_AssistantName"></a> AssistantName

**Description**: Type the name of the contact's assistant.<br />
**DisplayName**: Assistant<br />
**LogicalName**: assistantname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AssistantPhone"></a> AssistantPhone

**Description**: Type the phone number for the contact's assistant.<br />
**DisplayName**: Assistant Phone<br />
**LogicalName**: assistantphone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_BirthDate"></a> BirthDate

**Description**: Enter the contact's birthday for use in customer gift programs or other communications.<br />
**DisplayName**: Birthday<br />
**LogicalName**: birthdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: DateOnly<br />
**Format**: DateOnly


### <a name="BKMK_Business2"></a> Business2

**Description**: Type a second business phone number for this contact.<br />
**DisplayName**: Business Phone 2<br />
**LogicalName**: business2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Callback"></a> Callback

**Description**: Type a callback phone number for this contact.<br />
**DisplayName**: Callback Number<br />
**LogicalName**: callback<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_ChildrensNames"></a> ChildrensNames

**Description**: Type the names of the contact's children for reference in communications and client programs.<br />
**DisplayName**: Children's Names<br />
**LogicalName**: childrensnames<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 255


### <a name="BKMK_Company"></a> Company

**Description**: Type the company phone of the contact.<br />
**DisplayName**: Company Phone<br />
**LogicalName**: company<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_ContactId"></a> ContactId

**Description**: Unique identifier of the contact.<br />
**DisplayName**: Contact<br />
**LogicalName**: contactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CreditLimit"></a> CreditLimit

**Description**: Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.<br />
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

**Description**: Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.<br />
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

**Description**: Select the size of the contact's company for segmentation and reporting purposes.<br />
**DisplayName**: Customer Size<br />
**LogicalName**: customersizecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_CustomerTypeCode"></a> CustomerTypeCode

**Description**: Select the category that best describes the relationship between the contact and your organization.<br />
**DisplayName**: Relationship Type<br />
**LogicalName**: customertypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_DefaultPriceLevelId"></a> DefaultPriceLevelId

**Description**: Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.<br />
**DisplayName**: Price List<br />
**LogicalName**: defaultpricelevelid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_Department"></a> Department

**Description**: Type the department or business unit where the contact works in the parent company or business.<br />
**DisplayName**: Department<br />
**LogicalName**: department<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the contact, such as an excerpt from the company's website.<br />
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

**Description**: Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.<br />
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

**Description**: Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.<br />
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

**Description**: Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.<br />
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

**Description**: Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.<br />
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

**Description**: Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.<br />
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

**Description**: Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.<br />
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

**Description**: Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.<br />
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


### <a name="BKMK_EducationCode"></a> EducationCode

**Description**: Select the contact's highest level of education for use in segmentation and analysis.<br />
**DisplayName**: Education<br />
**LogicalName**: educationcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_EMailAddress1"></a> EMailAddress1

**Description**: Type the primary email address for the contact.<br />
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

**Description**: Type the secondary email address for the contact.<br />
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

**Description**: Type an alternate email address for the contact.<br />
**DisplayName**: Email Address 3<br />
**LogicalName**: emailaddress3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EmployeeId"></a> EmployeeId

**Description**: Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.<br />
**DisplayName**: Employee<br />
**LogicalName**: employeeid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: Shows the default image for the record.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: True<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_ExternalUserIdentifier"></a> ExternalUserIdentifier

**Description**: Identifier for an external user.<br />
**DisplayName**: External User Identifier<br />
**LogicalName**: externaluseridentifier<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_FamilyStatusCode"></a> FamilyStatusCode

**Description**: Select the marital status of the contact for reference in follow-up phone calls and other communications.<br />
**DisplayName**: Marital Status<br />
**LogicalName**: familystatuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Single
- **Value**: 2 **Label**: Married
- **Value**: 3 **Label**: Divorced
- **Value**: 4 **Label**: Widowed



### <a name="BKMK_Fax"></a> Fax

**Description**: Type the fax number for the contact.<br />
**DisplayName**: Fax<br />
**LogicalName**: fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_FirstName"></a> FirstName

**Description**: Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />
**DisplayName**: First Name<br />
**LogicalName**: firstname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_FollowEmail"></a> FollowEmail

**Description**: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.<br />
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


### <a name="BKMK_FtpSiteUrl"></a> FtpSiteUrl

**Description**: Type the URL for the contact's FTP site to enable users to access data and share documents.<br />
**DisplayName**: FTP Site<br />
**LogicalName**: ftpsiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_GenderCode"></a> GenderCode

**Description**: Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />
**DisplayName**: Gender<br />
**LogicalName**: gendercode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Male
- **Value**: 2 **Label**: Female



### <a name="BKMK_GovernmentId"></a> GovernmentId

**Description**: Type the passport number or other government ID for the contact for use in documents or reports.<br />
**DisplayName**: Government<br />
**LogicalName**: governmentid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_HasChildrenCode"></a> HasChildrenCode

**Description**: Select whether the contact has any children for reference in follow-up phone calls and other communications.<br />
**DisplayName**: Has Children<br />
**LogicalName**: haschildrencode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Home2"></a> Home2

**Description**: Type a second home phone number for this contact.<br />
**DisplayName**: Home Phone 2<br />
**LogicalName**: home2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


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


### <a name="BKMK_IsBackofficeCustomer"></a> IsBackofficeCustomer

**Description**: Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.<br />
**DisplayName**: Back Office Customer<br />
**LogicalName**: isbackofficecustomer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_JobTitle"></a> JobTitle

**Description**: Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />
**DisplayName**: Job Title<br />
**LogicalName**: jobtitle<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_LastName"></a> LastName

**Description**: Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />
**DisplayName**: Last Name<br />
**LogicalName**: lastname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


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

**Description**: Shows the date when the contact was last included in a marketing campaign or quick campaign.<br />
**DisplayName**: Last Date Included in Campaign<br />
**LogicalName**: lastusedincampaign<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_LeadSourceCode"></a> LeadSourceCode

**Description**: Select the primary marketing source that directed the contact to your organization.<br />
**DisplayName**: Lead Source<br />
**LogicalName**: leadsourcecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_ManagerName"></a> ManagerName

**Description**: Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.<br />
**DisplayName**: Manager<br />
**LogicalName**: managername<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ManagerPhone"></a> ManagerPhone

**Description**: Type the phone number for the contact's manager.<br />
**DisplayName**: Manager Phone<br />
**LogicalName**: managerphone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


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


### <a name="BKMK_MiddleName"></a> MiddleName

**Description**: Type the contact's middle name or initial to make sure the contact is addressed correctly.<br />
**DisplayName**: Middle Name<br />
**LogicalName**: middlename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_MobilePhone"></a> MobilePhone

**Description**: Type the mobile phone number for the contact.<br />
**DisplayName**: Mobile Phone<br />
**LogicalName**: mobilephone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_NickName"></a> NickName

**Description**: Type the contact's nickname.<br />
**DisplayName**: Nickname<br />
**LogicalName**: nickname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_NumberOfChildren"></a> NumberOfChildren

**Description**: Type the number of children the contact has for reference in follow-up phone calls and other communications.<br />
**DisplayName**: No. of Children<br />
**LogicalName**: numberofchildren<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

**Description**: Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.<br />
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


### <a name="BKMK_Pager"></a> Pager

**Description**: Type the pager number for the contact.<br />
**DisplayName**: Pager<br />
**LogicalName**: pager<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_ParentCustomerId"></a> ParentCustomerId

**Description**: Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.<br />
**DisplayName**: Company Name<br />
**LogicalName**: parentcustomerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_ParentCustomerIdType"></a> ParentCustomerIdType

**Description**: <br />
**DisplayName**: Parent Customer Type<br />
**LogicalName**: parentcustomeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

**Description**: Shows whether the contact participates in workflow rules.<br />
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

**Description**: Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.<br />
**DisplayName**: Preferred Facility/Equipment<br />
**LogicalName**: preferredequipmentid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: equipment


### <a name="BKMK_PreferredServiceId"></a> PreferredServiceId

**Description**: Choose the contact's preferred service to make sure services are scheduled correctly for the customer.<br />
**DisplayName**: Preferred Service<br />
**LogicalName**: preferredserviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_PreferredSystemUserId"></a> PreferredSystemUserId

**Description**: Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.<br />
**DisplayName**: Preferred User<br />
**LogicalName**: preferredsystemuserid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Salutation"></a> Salutation

**Description**: Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.<br />
**DisplayName**: Salutation<br />
**LogicalName**: salutation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

**Description**: Select a shipping method for deliveries sent to this address.<br />
**DisplayName**: Shipping Method<br />
**LogicalName**: shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the Contact record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SpousesName"></a> SpousesName

**Description**: Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.<br />
**DisplayName**: Spouse/Partner Name<br />
**LogicalName**: spousesname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_StageId"></a> StageId

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.<br />
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

**Description**: Select the contact's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_SubscriptionId"></a> SubscriptionId

**Description**: For internal use only.<br />
**DisplayName**: Subscription<br />
**LogicalName**: subscriptionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Suffix"></a> Suffix

**Description**: Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />
**DisplayName**: Suffix<br />
**LogicalName**: suffix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10


### <a name="BKMK_Telephone1"></a> Telephone1

**Description**: Type the main phone number for this contact.<br />
**DisplayName**: Business Phone<br />
**LogicalName**: telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Telephone2"></a> Telephone2

**Description**: Type a second phone number for this contact.<br />
**DisplayName**: Home Phone<br />
**LogicalName**: telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Telephone3"></a> Telephone3

**Description**: Type a third phone number for this contact.<br />
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

**Description**: Select a region or territory for the contact for use in segmentation and analysis.<br />
**DisplayName**: Territory<br />
**LogicalName**: territorycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



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


### <a name="BKMK_WebSiteUrl"></a> WebSiteUrl

**Description**: Type the contact's professional or personal website or blog URL.<br />
**DisplayName**: Website<br />
**LogicalName**: websiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_YomiFirstName"></a> YomiFirstName

**Description**: Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />
**DisplayName**: Yomi First Name<br />
**LogicalName**: yomifirstname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 150


### <a name="BKMK_YomiLastName"></a> YomiLastName

**Description**: Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />
**DisplayName**: Yomi Last Name<br />
**LogicalName**: yomilastname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 150


### <a name="BKMK_YomiMiddleName"></a> YomiMiddleName

**Description**: Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />
**DisplayName**: Yomi Middle Name<br />
**LogicalName**: yomimiddlename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 150

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [Address1_Composite](#BKMK_Address1_Composite)
- [Address2_Composite](#BKMK_Address2_Composite)
- [Address3_Composite](#BKMK_Address3_Composite)
- [Aging30](#BKMK_Aging30)
- [Aging30_Base](#BKMK_Aging30_Base)
- [Aging60](#BKMK_Aging60)
- [Aging60_Base](#BKMK_Aging60_Base)
- [Aging90](#BKMK_Aging90)
- [Aging90_Base](#BKMK_Aging90_Base)
- [AnnualIncome_Base](#BKMK_AnnualIncome_Base)
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
- [FullName](#BKMK_FullName)
- [IsAutoCreate](#BKMK_IsAutoCreate)
- [IsPrivate](#BKMK_IsPrivate)
- [MasterContactIdName](#BKMK_MasterContactIdName)
- [MasterContactIdYomiName](#BKMK_MasterContactIdYomiName)
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
- [OnHoldTime](#BKMK_OnHoldTime)
- [OriginatingLeadIdName](#BKMK_OriginatingLeadIdName)
- [OriginatingLeadIdYomiName](#BKMK_OriginatingLeadIdYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentContactId](#BKMK_ParentContactId)
- [ParentContactIdName](#BKMK_ParentContactIdName)
- [ParentContactIdYomiName](#BKMK_ParentContactIdYomiName)
- [ParentCustomerIdName](#BKMK_ParentCustomerIdName)
- [ParentCustomerIdYomiName](#BKMK_ParentCustomerIdYomiName)
- [PreferredEquipmentIdName](#BKMK_PreferredEquipmentIdName)
- [PreferredServiceIdName](#BKMK_PreferredServiceIdName)
- [PreferredSystemUserIdName](#BKMK_PreferredSystemUserIdName)
- [PreferredSystemUserIdYomiName](#BKMK_PreferredSystemUserIdYomiName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [YomiFullName](#BKMK_YomiFullName)


### <a name="BKMK_AccountId"></a> AccountId

**Description**: Unique identifier of the account with which the contact is associated.<br />
**DisplayName**: Account<br />
**LogicalName**: accountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_AccountIdName"></a> AccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_Address3_Composite"></a> Address3_Composite

**Description**: Shows the complete third address.<br />
**DisplayName**: Address 3<br />
**LogicalName**: address3_composite<br />
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

**Description**: Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />
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

**Description**: Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />
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

**Description**: Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />
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


### <a name="BKMK_AnnualIncome_Base"></a> AnnualIncome_Base

**Description**: Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />
**DisplayName**: Annual Income (Base)<br />
**LogicalName**: annualincome_base<br />
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

**Description**: Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.<br />
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


### <a name="BKMK_FullName"></a> FullName

**Description**: Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.<br />
**DisplayName**: Full Name<br />
**LogicalName**: fullname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_IsAutoCreate"></a> IsAutoCreate

**Description**: Information about whether the contact was auto-created when promoting an email or an appointment.<br />
**DisplayName**: Auto-created<br />
**LogicalName**: isautocreate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


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


### <a name="BKMK_MasterContactIdName"></a> MasterContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: mastercontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_MasterContactIdYomiName"></a> MasterContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: mastercontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_MasterId"></a> MasterId

**Description**: Unique identifier of the master contact for merge.<br />
**DisplayName**: Master ID<br />
**LogicalName**: masterid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_Merged"></a> Merged

**Description**: Shows whether the account has been merged with a master contact.<br />
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

**Description**: Shows who last updated the record on behalf of another user.<br />
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

**Description**: Unique identifier of the business unit that owns the contact.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the contact.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the contact.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ParentContactId"></a> ParentContactId

**Description**: Unique identifier of the parent contact.<br />
**DisplayName**: Parent Contact<br />
**LogicalName**: parentcontactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_ParentContactIdName"></a> ParentContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentcontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ParentContactIdYomiName"></a> ParentContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentcontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ParentCustomerIdName"></a> ParentCustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentcustomeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ParentCustomerIdYomiName"></a> ParentCustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentcustomeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


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


### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

**Description**: Total time spent for emails (read and write) and meetings by me in relation to the contact record.<br />
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

**Description**: Version number of the contact.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_YomiFullName"></a> YomiFullName

**Description**: Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.<br />
**DisplayName**: Yomi Full Name<br />
**LogicalName**: yomifullname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 450

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [lead_customer_contacts](#BKMK_lead_customer_contacts)
- [lead_parent_contact](#BKMK_lead_parent_contact)
- [contact_bookableresource_ContactId](#BKMK_contact_bookableresource_ContactId)
- [contact_BulkOperations](#BKMK_contact_BulkOperations)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)
- [Contact_ServiceAppointments](#BKMK_Contact_ServiceAppointments)
- [contact_as_responsible_contact](#BKMK_contact_as_responsible_contact)
- [contractlineitem_customer_contacts](#BKMK_contractlineitem_customer_contacts)
- [contract_billingcustomer_contacts](#BKMK_contract_billingcustomer_contacts)
- [contract_customer_contacts](#BKMK_contract_customer_contacts)
- [incident_customer_contacts](#BKMK_incident_customer_contacts)
- [contact_as_primary_contact](#BKMK_contact_as_primary_contact)
- [contact_entitlement_ContactId](#BKMK_contact_entitlement_ContactId)
- [contact_entitlement_Customer](#BKMK_contact_entitlement_Customer)
- [contact_customer_opportunity_roles](#BKMK_contact_customer_opportunity_roles)
- [invoice_customer_contacts](#BKMK_invoice_customer_contacts)
- [opportunity_customer_contacts](#BKMK_opportunity_customer_contacts)
- [order_customer_contacts](#BKMK_order_customer_contacts)
- [quote_customer_contacts](#BKMK_quote_customer_contacts)
- [opportunity_parent_contact](#BKMK_opportunity_parent_contact)
- [contact_msdyn_bookingalerts](#BKMK_contact_msdyn_bookingalerts)
- [msdyn_contact_msdyn_actual_ContactCustomer](#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)
- [msdyn_contact_msdyn_actual_ContactVendor](#BKMK_msdyn_contact_msdyn_actual_ContactVendor)
- [contact_msdyn_approvals](#BKMK_contact_msdyn_approvals)
- [msdyn_contact_msdyn_contactpricelist_Contact](#BKMK_msdyn_contact_msdyn_contactpricelist_Contact)
- [msdyn_contact_msdyn_estimateline_ContactCustomer](#BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer)
- [msdyn_contact_msdyn_estimateline_ContactVendor](#BKMK_msdyn_contact_msdyn_estimateline_ContactVendor)
- [msdyn_contact_msdyn_fact_ContactCustomer](#BKMK_msdyn_contact_msdyn_fact_ContactCustomer)
- [msdyn_contact_msdyn_fact_ContactVendor](#BKMK_msdyn_contact_msdyn_fact_ContactVendor)
- [msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer](#BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer)
- [msdyn_contact_msdyn_invoicelinetransaction_ContactVendor](#BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactVendor)
- [msdyn_contact_msdyn_journalline_ContactCustomer](#BKMK_msdyn_contact_msdyn_journalline_ContactCustomer)
- [msdyn_contact_msdyn_journalline_ContactVendor](#BKMK_msdyn_contact_msdyn_journalline_ContactVendor)
- [msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer](#BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer)
- [msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor](#BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor)
- [msdyn_contact_msdyn_orderlinetransaction_ContactCustomer](#BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactCustomer)
- [msdyn_contact_msdyn_orderlinetransaction_ContactVendor](#BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactVendor)
- [msdyn_contact_msdyn_quotelinetransaction_ContactCustomer](#BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactCustomer)
- [msdyn_contact_msdyn_quotelinetransaction_ContactVendor](#BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactVendor)
- [msdyn_contact_msdyn_rma_RequestedByContact](#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)
- [msdyn_contact_msdyn_rtv_VendorContact](#BKMK_msdyn_contact_msdyn_rtv_VendorContact)
- [msdyn_contact_msdyn_workorder_ReportedByContact](#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)
- [contact_principalobjectattributeaccess](#BKMK_contact_principalobjectattributeaccess)
- [slakpiinstance_contact](#BKMK_slakpiinstance_contact)
- [socialactivity_postauthoraccount_contacts](#BKMK_socialactivity_postauthoraccount_contacts)
- [Contact_Email_EmailSender](#BKMK_Contact_Email_EmailSender)
- [Contact_Tasks](#BKMK_Contact_Tasks)
- [contact_PostFollows](#BKMK_contact_PostFollows)
- [Contact_RecurringAppointmentMasters](#BKMK_Contact_RecurringAppointmentMasters)
- [contact_master_contact](#BKMK_contact_master_contact)
- [contact_customer_relationship_partner](#BKMK_contact_customer_relationship_partner)
- [lk_contact_feedback_createdby](#BKMK_lk_contact_feedback_createdby)
- [contact_actioncard](#BKMK_contact_actioncard)
- [contact_connections2](#BKMK_contact_connections2)
- [Contact_BulkDeleteFailures](#BKMK_Contact_BulkDeleteFailures)
- [contact_activity_parties](#BKMK_contact_activity_parties)
- [Contact_DuplicateBaseRecord](#BKMK_Contact_DuplicateBaseRecord)
- [Contact_Annotation](#BKMK_Contact_Annotation)
- [Contact_SocialActivities](#BKMK_Contact_SocialActivities)
- [Contact_ActivityPointers](#BKMK_Contact_ActivityPointers)
- [Contact_MailboxTrackingFolder](#BKMK_Contact_MailboxTrackingFolder)
- [account_primary_contact](#BKMK_account_primary_contact)
- [Socialprofile_customer_contacts](#BKMK_Socialprofile_customer_contacts)
- [Contact_ExternalPartyItems](#BKMK_Contact_ExternalPartyItems)
- [socialactivity_postauthor_contacts](#BKMK_socialactivity_postauthor_contacts)
- [lk_contact_feedback_createdonbehalfby](#BKMK_lk_contact_feedback_createdonbehalfby)
- [Contact_Emails](#BKMK_Contact_Emails)
- [Contact_Appointments](#BKMK_Contact_Appointments)
- [Contact_Feedback](#BKMK_Contact_Feedback)
- [Contact_ProcessSessions](#BKMK_Contact_ProcessSessions)
- [Contact_AsyncOperations](#BKMK_Contact_AsyncOperations)
- [contact_connections1](#BKMK_contact_connections1)
- [Contact_CustomerAddress](#BKMK_Contact_CustomerAddress)
- [Contact_Phonecalls](#BKMK_Contact_Phonecalls)
- [contact_customer_contacts](#BKMK_contact_customer_contacts)
- [userentityinstancedata_contact](#BKMK_userentityinstancedata_contact)
- [Contact_SyncErrors](#BKMK_Contact_SyncErrors)
- [Contact_DuplicateMatchingRecord](#BKMK_Contact_DuplicateMatchingRecord)
- [contact_customer_relationship_customer](#BKMK_contact_customer_relationship_customer)
- [Contact_Faxes](#BKMK_Contact_Faxes)
- [Contact_Letters](#BKMK_Contact_Letters)


### <a name="BKMK_lead_customer_contacts"></a> lead_customer_contacts

Same as lead entity [lead_customer_contacts](lead.md#BKMK_lead_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lead_customer_contacts<br />
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


### <a name="BKMK_lead_parent_contact"></a> lead_parent_contact

Same as lead entity [lead_parent_contact](lead.md#BKMK_lead_parent_contact) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: parentcontactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lead_parent_contact<br />
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


### <a name="BKMK_contact_bookableresource_ContactId"></a> contact_bookableresource_ContactId

Same as bookableresource entity [contact_bookableresource_ContactId](bookableresource.md#BKMK_contact_bookableresource_ContactId) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: contactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_bookableresource_ContactId<br />
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


### <a name="BKMK_contact_BulkOperations"></a> contact_BulkOperations

Same as bulkoperation entity [contact_BulkOperations](bulkoperation.md#BKMK_contact_BulkOperations) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_BulkOperations<br />
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


### <a name="BKMK_contact_CampaignResponses"></a> contact_CampaignResponses

Same as campaignresponse entity [contact_CampaignResponses](campaignresponse.md#BKMK_contact_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_CampaignResponses<br />
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


### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

Same as bulkoperationlog entity [CreatedContact_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedContact_BulkOperationLogs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: createdobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CreatedContact_BulkOperationLogs<br />
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


### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

Same as bulkoperationlog entity [SourceContact_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceContact_BulkOperationLogs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SourceContact_BulkOperationLogs<br />
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


### <a name="BKMK_Contact_ServiceAppointments"></a> Contact_ServiceAppointments

Same as serviceappointment entity [Contact_ServiceAppointments](serviceappointment.md#BKMK_Contact_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_ServiceAppointments<br />
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


### <a name="BKMK_contact_as_responsible_contact"></a> contact_as_responsible_contact

Same as incident entity [contact_as_responsible_contact](incident.md#BKMK_contact_as_responsible_contact) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: responsiblecontactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_as_responsible_contact<br />
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


### <a name="BKMK_contractlineitem_customer_contacts"></a> contractlineitem_customer_contacts

Same as contractdetail entity [contractlineitem_customer_contacts](contractdetail.md#BKMK_contractlineitem_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contractlineitem_customer_contacts<br />
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


### <a name="BKMK_contract_billingcustomer_contacts"></a> contract_billingcustomer_contacts

Same as contract entity [contract_billingcustomer_contacts](contract.md#BKMK_contract_billingcustomer_contacts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: billingcustomerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_billingcustomer_contacts<br />
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


### <a name="BKMK_contract_customer_contacts"></a> contract_customer_contacts

Same as contract entity [contract_customer_contacts](contract.md#BKMK_contract_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_customer_contacts<br />
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


### <a name="BKMK_incident_customer_contacts"></a> incident_customer_contacts

Same as incident entity [incident_customer_contacts](incident.md#BKMK_incident_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_customer_contacts<br />
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


### <a name="BKMK_contact_as_primary_contact"></a> contact_as_primary_contact

Same as incident entity [contact_as_primary_contact](incident.md#BKMK_contact_as_primary_contact) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: primarycontactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_as_primary_contact<br />
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


### <a name="BKMK_contact_entitlement_ContactId"></a> contact_entitlement_ContactId

Same as entitlement entity [contact_entitlement_ContactId](entitlement.md#BKMK_contact_entitlement_ContactId) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: contactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_entitlement_ContactId<br />
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


### <a name="BKMK_contact_entitlement_Customer"></a> contact_entitlement_Customer

Same as entitlement entity [contact_entitlement_Customer](entitlement.md#BKMK_contact_entitlement_Customer) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_entitlement_Customer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 20

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_contact_customer_opportunity_roles"></a> contact_customer_opportunity_roles

Same as customeropportunityrole entity [contact_customer_opportunity_roles](customeropportunityrole.md#BKMK_contact_customer_opportunity_roles) Many-To-One relationship.

**ReferencingEntity**: customeropportunityrole<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_customer_opportunity_roles<br />
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


### <a name="BKMK_invoice_customer_contacts"></a> invoice_customer_contacts

Same as invoice entity [invoice_customer_contacts](invoice.md#BKMK_invoice_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: invoice_customer_contacts<br />
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


### <a name="BKMK_opportunity_customer_contacts"></a> opportunity_customer_contacts

Same as opportunity entity [opportunity_customer_contacts](opportunity.md#BKMK_opportunity_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunity_customer_contacts<br />
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


### <a name="BKMK_order_customer_contacts"></a> order_customer_contacts

Same as salesorder entity [order_customer_contacts](salesorder.md#BKMK_order_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: order_customer_contacts<br />
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


### <a name="BKMK_quote_customer_contacts"></a> quote_customer_contacts

Same as quote entity [quote_customer_contacts](quote.md#BKMK_quote_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: quote_customer_contacts<br />
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


### <a name="BKMK_opportunity_parent_contact"></a> opportunity_parent_contact

Same as opportunity entity [opportunity_parent_contact](opportunity.md#BKMK_opportunity_parent_contact) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: parentcontactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunity_parent_contact<br />
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


### <a name="BKMK_contact_msdyn_bookingalerts"></a> contact_msdyn_bookingalerts

Same as msdyn_bookingalert entity [contact_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_contact_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_contact_msdyn_actual_ContactCustomer"></a> msdyn_contact_msdyn_actual_ContactCustomer

Same as msdyn_actual entity [msdyn_contact_msdyn_actual_ContactCustomer](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_actual_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_actual_ContactVendor"></a> msdyn_contact_msdyn_actual_ContactVendor

Same as msdyn_actual entity [msdyn_contact_msdyn_actual_ContactVendor](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_actual_ContactVendor<br />
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


### <a name="BKMK_contact_msdyn_approvals"></a> contact_msdyn_approvals

Same as msdyn_approval entity [contact_msdyn_approvals](msdyn_approval.md#BKMK_contact_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_contact_msdyn_contactpricelist_Contact"></a> msdyn_contact_msdyn_contactpricelist_Contact

Same as msdyn_contactpricelist entity [msdyn_contact_msdyn_contactpricelist_Contact](msdyn_contactpricelist.md#BKMK_msdyn_contact_msdyn_contactpricelist_Contact) Many-To-One relationship.

**ReferencingEntity**: msdyn_contactpricelist<br />
**ReferencingAttribute**: msdyn_contact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_contactpricelist_Contact<br />
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


### <a name="BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer"></a> msdyn_contact_msdyn_estimateline_ContactCustomer

Same as msdyn_estimateline entity [msdyn_contact_msdyn_estimateline_ContactCustomer](msdyn_estimateline.md#BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_estimateline_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_estimateline_ContactVendor"></a> msdyn_contact_msdyn_estimateline_ContactVendor

Same as msdyn_estimateline entity [msdyn_contact_msdyn_estimateline_ContactVendor](msdyn_estimateline.md#BKMK_msdyn_contact_msdyn_estimateline_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_estimateline_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_fact_ContactCustomer"></a> msdyn_contact_msdyn_fact_ContactCustomer

Same as msdyn_fact entity [msdyn_contact_msdyn_fact_ContactCustomer](msdyn_fact.md#BKMK_msdyn_contact_msdyn_fact_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_fact_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_fact_ContactVendor"></a> msdyn_contact_msdyn_fact_ContactVendor

Same as msdyn_fact entity [msdyn_contact_msdyn_fact_ContactVendor](msdyn_fact.md#BKMK_msdyn_contact_msdyn_fact_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_fact_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer"></a> msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer

Same as msdyn_invoicelinetransaction entity [msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer](msdyn_invoicelinetransaction.md#BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactVendor"></a> msdyn_contact_msdyn_invoicelinetransaction_ContactVendor

Same as msdyn_invoicelinetransaction entity [msdyn_contact_msdyn_invoicelinetransaction_ContactVendor](msdyn_invoicelinetransaction.md#BKMK_msdyn_contact_msdyn_invoicelinetransaction_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_invoicelinetransaction_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_journalline_ContactCustomer"></a> msdyn_contact_msdyn_journalline_ContactCustomer

Same as msdyn_journalline entity [msdyn_contact_msdyn_journalline_ContactCustomer](msdyn_journalline.md#BKMK_msdyn_contact_msdyn_journalline_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_journalline_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_journalline_ContactVendor"></a> msdyn_contact_msdyn_journalline_ContactVendor

Same as msdyn_journalline entity [msdyn_contact_msdyn_journalline_ContactVendor](msdyn_journalline.md#BKMK_msdyn_contact_msdyn_journalline_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_journalline_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer"></a> msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer

Same as msdyn_opportunitylinetransaction entity [msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer](msdyn_opportunitylinetransaction.md#BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor"></a> msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor

Same as msdyn_opportunitylinetransaction entity [msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor](msdyn_opportunitylinetransaction.md#BKMK_msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactCustomer"></a> msdyn_contact_msdyn_orderlinetransaction_ContactCustomer

Same as msdyn_orderlinetransaction entity [msdyn_contact_msdyn_orderlinetransaction_ContactCustomer](msdyn_orderlinetransaction.md#BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_orderlinetransaction_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactVendor"></a> msdyn_contact_msdyn_orderlinetransaction_ContactVendor

Same as msdyn_orderlinetransaction entity [msdyn_contact_msdyn_orderlinetransaction_ContactVendor](msdyn_orderlinetransaction.md#BKMK_msdyn_contact_msdyn_orderlinetransaction_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_orderlinetransaction_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactCustomer"></a> msdyn_contact_msdyn_quotelinetransaction_ContactCustomer

Same as msdyn_quotelinetransaction entity [msdyn_contact_msdyn_quotelinetransaction_ContactCustomer](msdyn_quotelinetransaction.md#BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactCustomer) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_contactcustomer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_quotelinetransaction_ContactCustomer<br />
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


### <a name="BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactVendor"></a> msdyn_contact_msdyn_quotelinetransaction_ContactVendor

Same as msdyn_quotelinetransaction entity [msdyn_contact_msdyn_quotelinetransaction_ContactVendor](msdyn_quotelinetransaction.md#BKMK_msdyn_contact_msdyn_quotelinetransaction_ContactVendor) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_contactvendor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_quotelinetransaction_ContactVendor<br />
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


### <a name="BKMK_msdyn_contact_msdyn_rma_RequestedByContact"></a> msdyn_contact_msdyn_rma_RequestedByContact

Same as msdyn_rma entity [msdyn_contact_msdyn_rma_RequestedByContact](msdyn_rma.md#BKMK_msdyn_contact_msdyn_rma_RequestedByContact) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_requestedbycontact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_rma_RequestedByContact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Billing Account
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contact_msdyn_rtv_VendorContact"></a> msdyn_contact_msdyn_rtv_VendorContact

Same as msdyn_rtv entity [msdyn_contact_msdyn_rtv_VendorContact](msdyn_rtv.md#BKMK_msdyn_contact_msdyn_rtv_VendorContact) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_vendorcontact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_rtv_VendorContact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Vendor Contact
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

Same as msdyn_workorder entity [msdyn_contact_msdyn_workorder_ReportedByContact](msdyn_workorder.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_reportedbycontact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contact_msdyn_workorder_ReportedByContact<br />
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


### <a name="BKMK_contact_principalobjectattributeaccess"></a> contact_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [contact_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contact_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_principalobjectattributeaccess<br />
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


### <a name="BKMK_slakpiinstance_contact"></a> slakpiinstance_contact

Same as slakpiinstance entity [slakpiinstance_contact](slakpiinstance.md#BKMK_slakpiinstance_contact) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_contact<br />
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


### <a name="BKMK_socialactivity_postauthoraccount_contacts"></a> socialactivity_postauthoraccount_contacts

Same as socialactivity entity [socialactivity_postauthoraccount_contacts](socialactivity.md#BKMK_socialactivity_postauthoraccount_contacts) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: postauthoraccount<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_postauthoraccount_contacts<br />
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


### <a name="BKMK_Contact_Email_EmailSender"></a> Contact_Email_EmailSender

Same as email entity [Contact_Email_EmailSender](email.md#BKMK_Contact_Email_EmailSender) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: emailsender<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_Email_EmailSender<br />
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


### <a name="BKMK_Contact_Tasks"></a> Contact_Tasks

Same as task entity [Contact_Tasks](task.md#BKMK_Contact_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Tasks<br />
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


### <a name="BKMK_contact_PostFollows"></a> contact_PostFollows

Same as postfollow entity [contact_PostFollows](postfollow.md#BKMK_contact_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_PostFollows<br />
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


### <a name="BKMK_Contact_RecurringAppointmentMasters"></a> Contact_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Contact_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Contact_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_RecurringAppointmentMasters<br />
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


### <a name="BKMK_contact_master_contact"></a> contact_master_contact

Same as contact entity [contact_master_contact](contact.md#BKMK_contact_master_contact) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: masterid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_master_contact<br />
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


### <a name="BKMK_contact_customer_relationship_partner"></a> contact_customer_relationship_partner

Same as customerrelationship entity [contact_customer_relationship_partner](customerrelationship.md#BKMK_contact_customer_relationship_partner) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: partnerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_customer_relationship_partner<br />
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


### <a name="BKMK_lk_contact_feedback_createdby"></a> lk_contact_feedback_createdby

Same as feedback entity [lk_contact_feedback_createdby](feedback.md#BKMK_lk_contact_feedback_createdby) Many-To-One relationship.

**ReferencingEntity**: feedback<br />
**ReferencingAttribute**: createdbycontact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_contact_feedback_createdby<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_contact_actioncard"></a> contact_actioncard

Same as actioncard entity [contact_actioncard](actioncard.md#BKMK_contact_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_actioncard<br />
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


### <a name="BKMK_contact_connections2"></a> contact_connections2

Same as connection entity [contact_connections2](connection.md#BKMK_contact_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_connections2<br />
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


### <a name="BKMK_Contact_BulkDeleteFailures"></a> Contact_BulkDeleteFailures

Same as bulkdeletefailure entity [Contact_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Contact_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_BulkDeleteFailures<br />
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


### <a name="BKMK_contact_activity_parties"></a> contact_activity_parties

Same as activityparty entity [contact_activity_parties](activityparty.md#BKMK_contact_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_activity_parties<br />
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


### <a name="BKMK_Contact_DuplicateBaseRecord"></a> Contact_DuplicateBaseRecord

Same as duplicaterecord entity [Contact_DuplicateBaseRecord](duplicaterecord.md#BKMK_Contact_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_DuplicateBaseRecord<br />
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


### <a name="BKMK_Contact_Annotation"></a> Contact_Annotation

Same as annotation entity [Contact_Annotation](annotation.md#BKMK_Contact_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Annotation<br />
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


### <a name="BKMK_Contact_SocialActivities"></a> Contact_SocialActivities

Same as socialactivity entity [Contact_SocialActivities](socialactivity.md#BKMK_Contact_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_SocialActivities<br />
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


### <a name="BKMK_Contact_ActivityPointers"></a> Contact_ActivityPointers

Same as activitypointer entity [Contact_ActivityPointers](activitypointer.md#BKMK_Contact_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_ActivityPointers<br />
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


### <a name="BKMK_Contact_MailboxTrackingFolder"></a> Contact_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Contact_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Contact_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_MailboxTrackingFolder<br />
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


### <a name="BKMK_account_primary_contact"></a> account_primary_contact

Same as account entity [account_primary_contact](account.md#BKMK_account_primary_contact) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: primarycontactid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: account_primary_contact<br />
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


### <a name="BKMK_Socialprofile_customer_contacts"></a> Socialprofile_customer_contacts

Same as socialprofile entity [Socialprofile_customer_contacts](socialprofile.md#BKMK_Socialprofile_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: socialprofile<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Socialprofile_customer_contacts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 40

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Contact_ExternalPartyItems"></a> Contact_ExternalPartyItems

Same as externalpartyitem entity [Contact_ExternalPartyItems](externalpartyitem.md#BKMK_Contact_ExternalPartyItems) Many-To-One relationship.

**ReferencingEntity**: externalpartyitem<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_ExternalPartyItems<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_socialactivity_postauthor_contacts"></a> socialactivity_postauthor_contacts

Same as socialactivity entity [socialactivity_postauthor_contacts](socialactivity.md#BKMK_socialactivity_postauthor_contacts) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: postauthor<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_postauthor_contacts<br />
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


### <a name="BKMK_lk_contact_feedback_createdonbehalfby"></a> lk_contact_feedback_createdonbehalfby

Same as feedback entity [lk_contact_feedback_createdonbehalfby](feedback.md#BKMK_lk_contact_feedback_createdonbehalfby) Many-To-One relationship.

**ReferencingEntity**: feedback<br />
**ReferencingAttribute**: createdonbehalfbycontact<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_contact_feedback_createdonbehalfby<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Contact_Emails"></a> Contact_Emails

Same as email entity [Contact_Emails](email.md#BKMK_Contact_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Emails<br />
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


### <a name="BKMK_Contact_Appointments"></a> Contact_Appointments

Same as appointment entity [Contact_Appointments](appointment.md#BKMK_Contact_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Appointments<br />
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


### <a name="BKMK_Contact_Feedback"></a> Contact_Feedback

Same as feedback entity [Contact_Feedback](feedback.md#BKMK_Contact_Feedback) Many-To-One relationship.

**ReferencingEntity**: feedback<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Feedback<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 150

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Contact_ProcessSessions"></a> Contact_ProcessSessions

Same as processsession entity [Contact_ProcessSessions](processsession.md#BKMK_Contact_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_ProcessSessions<br />
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


### <a name="BKMK_Contact_AsyncOperations"></a> Contact_AsyncOperations

Same as asyncoperation entity [Contact_AsyncOperations](asyncoperation.md#BKMK_Contact_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_AsyncOperations<br />
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


### <a name="BKMK_contact_connections1"></a> contact_connections1

Same as connection entity [contact_connections1](connection.md#BKMK_contact_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_connections1<br />
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


### <a name="BKMK_Contact_CustomerAddress"></a> Contact_CustomerAddress

Same as customeraddress entity [Contact_CustomerAddress](customeraddress.md#BKMK_Contact_CustomerAddress) Many-To-One relationship.

**ReferencingEntity**: customeraddress<br />
**ReferencingAttribute**: parentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_CustomerAddress<br />
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


### <a name="BKMK_Contact_Phonecalls"></a> Contact_Phonecalls

Same as phonecall entity [Contact_Phonecalls](phonecall.md#BKMK_Contact_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Phonecalls<br />
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


### <a name="BKMK_contact_customer_contacts"></a> contact_customer_contacts

Same as contact entity [contact_customer_contacts](contact.md#BKMK_contact_customer_contacts) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: parentcustomerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contact_customer_contacts<br />
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


### <a name="BKMK_userentityinstancedata_contact"></a> userentityinstancedata_contact

Same as userentityinstancedata entity [userentityinstancedata_contact](userentityinstancedata.md#BKMK_userentityinstancedata_contact) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_contact<br />
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


### <a name="BKMK_Contact_SyncErrors"></a> Contact_SyncErrors

Same as syncerror entity [Contact_SyncErrors](syncerror.md#BKMK_Contact_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_SyncErrors<br />
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


### <a name="BKMK_Contact_DuplicateMatchingRecord"></a> Contact_DuplicateMatchingRecord

Same as duplicaterecord entity [Contact_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Contact_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Contact_DuplicateMatchingRecord<br />
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


### <a name="BKMK_contact_customer_relationship_customer"></a> contact_customer_relationship_customer

Same as customerrelationship entity [contact_customer_relationship_customer](customerrelationship.md#BKMK_contact_customer_relationship_customer) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: customerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contact_customer_relationship_customer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 50

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Contact_Faxes"></a> Contact_Faxes

Same as fax entity [Contact_Faxes](fax.md#BKMK_Contact_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Faxes<br />
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


### <a name="BKMK_Contact_Letters"></a> Contact_Letters

Same as letter entity [Contact_Letters](letter.md#BKMK_Contact_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Contact_Letters<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [contact_originating_lead](#BKMK_contact_originating_lead)
- [price_level_contacts](#BKMK_price_level_contacts)
- [equipment_contacts](#BKMK_equipment_contacts)
- [service_contacts](#BKMK_service_contacts)
- [transactioncurrency_contact](#BKMK_transactioncurrency_contact)
- [contact_master_contact](#BKMK_contact_master_contact)
- [lk_contactbase_createdby](#BKMK_lk_contactbase_createdby)
- [lk_contact_createdonbehalfby](#BKMK_lk_contact_createdonbehalfby)
- [team_contacts](#BKMK_team_contacts)
- [manualsla_contact](#BKMK_manualsla_contact)
- [system_user_contacts](#BKMK_system_user_contacts)
- [lk_contactbase_modifiedby](#BKMK_lk_contactbase_modifiedby)
- [sla_contact](#BKMK_sla_contact)
- [contact_customer_accounts](#BKMK_contact_customer_accounts)
- [lk_contact_modifiedonbehalfby](#BKMK_lk_contact_modifiedonbehalfby)
- [processstage_contact](#BKMK_processstage_contact)
- [contact_owning_user](#BKMK_contact_owning_user)
- [lk_externalparty_contact_createdby](#BKMK_lk_externalparty_contact_createdby)
- [contact_customer_contacts](#BKMK_contact_customer_contacts)
- [business_unit_contacts](#BKMK_business_unit_contacts)
- [lk_externalparty_contact_modifiedby](#BKMK_lk_externalparty_contact_modifiedby)


### <a name="BKMK_contact_originating_lead"></a> contact_originating_lead

See lead Entity [contact_originating_lead](lead.md#BKMK_contact_originating_lead) One-To-Many relationship.

### <a name="BKMK_price_level_contacts"></a> price_level_contacts

See pricelevel Entity [price_level_contacts](pricelevel.md#BKMK_price_level_contacts) One-To-Many relationship.

### <a name="BKMK_equipment_contacts"></a> equipment_contacts

See equipment Entity [equipment_contacts](equipment.md#BKMK_equipment_contacts) One-To-Many relationship.

### <a name="BKMK_service_contacts"></a> service_contacts

See service Entity [service_contacts](service.md#BKMK_service_contacts) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_contact"></a> transactioncurrency_contact

See transactioncurrency Entity [transactioncurrency_contact](transactioncurrency.md#BKMK_transactioncurrency_contact) One-To-Many relationship.

### <a name="BKMK_contact_master_contact"></a> contact_master_contact

See contact Entity [contact_master_contact](contact.md#BKMK_contact_master_contact) One-To-Many relationship.

### <a name="BKMK_lk_contactbase_createdby"></a> lk_contactbase_createdby

See systemuser Entity [lk_contactbase_createdby](systemuser.md#BKMK_lk_contactbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_contact_createdonbehalfby"></a> lk_contact_createdonbehalfby

See systemuser Entity [lk_contact_createdonbehalfby](systemuser.md#BKMK_lk_contact_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_team_contacts"></a> team_contacts

See team Entity [team_contacts](team.md#BKMK_team_contacts) One-To-Many relationship.

### <a name="BKMK_manualsla_contact"></a> manualsla_contact

See sla Entity [manualsla_contact](sla.md#BKMK_manualsla_contact) One-To-Many relationship.

### <a name="BKMK_system_user_contacts"></a> system_user_contacts

See systemuser Entity [system_user_contacts](systemuser.md#BKMK_system_user_contacts) One-To-Many relationship.

### <a name="BKMK_lk_contactbase_modifiedby"></a> lk_contactbase_modifiedby

See systemuser Entity [lk_contactbase_modifiedby](systemuser.md#BKMK_lk_contactbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_sla_contact"></a> sla_contact

See sla Entity [sla_contact](sla.md#BKMK_sla_contact) One-To-Many relationship.

### <a name="BKMK_contact_customer_accounts"></a> contact_customer_accounts

See account Entity [contact_customer_accounts](account.md#BKMK_contact_customer_accounts) One-To-Many relationship.

### <a name="BKMK_lk_contact_modifiedonbehalfby"></a> lk_contact_modifiedonbehalfby

See systemuser Entity [lk_contact_modifiedonbehalfby](systemuser.md#BKMK_lk_contact_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_processstage_contact"></a> processstage_contact

See processstage Entity [processstage_contact](processstage.md#BKMK_processstage_contact) One-To-Many relationship.

### <a name="BKMK_contact_owning_user"></a> contact_owning_user

See systemuser Entity [contact_owning_user](systemuser.md#BKMK_contact_owning_user) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_contact_createdby"></a> lk_externalparty_contact_createdby

See externalparty Entity [lk_externalparty_contact_createdby](externalparty.md#BKMK_lk_externalparty_contact_createdby) One-To-Many relationship.

### <a name="BKMK_contact_customer_contacts"></a> contact_customer_contacts

See contact Entity [contact_customer_contacts](contact.md#BKMK_contact_customer_contacts) One-To-Many relationship.

### <a name="BKMK_business_unit_contacts"></a> business_unit_contacts

See businessunit Entity [business_unit_contacts](businessunit.md#BKMK_business_unit_contacts) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_contact_modifiedby"></a> lk_externalparty_contact_modifiedby

See externalparty Entity [lk_externalparty_contact_modifiedby](externalparty.md#BKMK_lk_externalparty_contact_modifiedby) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Contact entity is the first entity in the relationship. Listed by **SchemaName**.

- [contactleads_association](#BKMK_contactleads_association)
- [listcontact_association](#BKMK_listcontact_association)
- [entitlementcontacts_association](#BKMK_entitlementcontacts_association)
- [servicecontractcontacts_association](#BKMK_servicecontractcontacts_association)
- [contactinvoices_association](#BKMK_contactinvoices_association)
- [contactorders_association](#BKMK_contactorders_association)
- [contactquotes_association](#BKMK_contactquotes_association)


### <a name="BKMK_contactleads_association"></a> contactleads_association

**IntersectEntityName**: contactleads<br />
**Entity1LogicalName**: contact<br />

- **Entity1IntersectAttribute**: contactid
- **Entity1NavigationPropertyName**: contactleads_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [lead](lead.md)<br />

- **Entity2IntersectAttribute**: leadid
- **Entity2NavigationPropertyName**: contactleads_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_listcontact_association"></a> listcontact_association

See list Entity [listcontact_association](list.md#BKMK_listcontact_association) Many-To-Many Relationship.

### <a name="BKMK_entitlementcontacts_association"></a> entitlementcontacts_association

**IntersectEntityName**: entitlementcontacts<br />
**Entity1LogicalName**: contact<br />

- **Entity1IntersectAttribute**: contactid
- **Entity1NavigationPropertyName**: entitlementcontacts_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [entitlement](entitlement.md)<br />

- **Entity2IntersectAttribute**: entitlementid
- **Entity2NavigationPropertyName**: entitlementcontacts_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_servicecontractcontacts_association"></a> servicecontractcontacts_association

**IntersectEntityName**: servicecontractcontacts<br />
**Entity1LogicalName**: contact<br />

- **Entity1IntersectAttribute**: contactid
- **Entity1NavigationPropertyName**: servicecontractcontacts_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [contract](contract.md)<br />

- **Entity2IntersectAttribute**: contractid
- **Entity2NavigationPropertyName**: servicecontractcontacts_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_contactinvoices_association"></a> contactinvoices_association

See invoice Entity [contactinvoices_association](invoice.md#BKMK_contactinvoices_association) Many-To-Many Relationship.

### <a name="BKMK_contactorders_association"></a> contactorders_association

See salesorder Entity [contactorders_association](salesorder.md#BKMK_contactorders_association) Many-To-Many Relationship.

### <a name="BKMK_contactquotes_association"></a> contactquotes_association

See quote Entity [contactquotes_association](quote.md#BKMK_contactquotes_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.contact?text=contact EntityType" />