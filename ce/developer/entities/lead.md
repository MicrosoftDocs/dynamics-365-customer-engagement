---
title: "Lead Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Lead entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Lead Entity Reference

Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.

**Added by**: Lead Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/leads(*leadid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|Create|POST [*org URI*]/api/data/v9.0/leads<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/leads(*leadid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|Merge|<xref href="Microsoft.Dynamics.CRM.Merge?text=Merge Action" />|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|QualifyLead|<xref href="Microsoft.Dynamics.CRM.QualifyLead?text=QualifyLead Action" />|<xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/leads(*leadid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/leads<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/leads(*leadid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/leads(*leadid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Leads|
|DisplayCollectionName|Leads|
|DisplayName|Lead|
|EntitySetName|leads|
|IsBPFEntity|False|
|LogicalCollectionName|leads|
|LogicalName|lead|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|leadid|
|PrimaryNameAttribute|fullname|
|SchemaName|Lead|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Address1_AddressId](#BKMK_Address1_AddressId)
- [Address1_AddressTypeCode](#BKMK_Address1_AddressTypeCode)
- [Address1_City](#BKMK_Address1_City)
- [Address1_Country](#BKMK_Address1_Country)
- [Address1_County](#BKMK_Address1_County)
- [Address1_Fax](#BKMK_Address1_Fax)
- [Address1_Latitude](#BKMK_Address1_Latitude)
- [Address1_Line1](#BKMK_Address1_Line1)
- [Address1_Line2](#BKMK_Address1_Line2)
- [Address1_Line3](#BKMK_Address1_Line3)
- [Address1_Longitude](#BKMK_Address1_Longitude)
- [Address1_Name](#BKMK_Address1_Name)
- [Address1_PostalCode](#BKMK_Address1_PostalCode)
- [Address1_PostOfficeBox](#BKMK_Address1_PostOfficeBox)
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
- [Address2_Latitude](#BKMK_Address2_Latitude)
- [Address2_Line1](#BKMK_Address2_Line1)
- [Address2_Line2](#BKMK_Address2_Line2)
- [Address2_Line3](#BKMK_Address2_Line3)
- [Address2_Longitude](#BKMK_Address2_Longitude)
- [Address2_Name](#BKMK_Address2_Name)
- [Address2_PostalCode](#BKMK_Address2_PostalCode)
- [Address2_PostOfficeBox](#BKMK_Address2_PostOfficeBox)
- [Address2_ShippingMethodCode](#BKMK_Address2_ShippingMethodCode)
- [Address2_StateOrProvince](#BKMK_Address2_StateOrProvince)
- [Address2_Telephone1](#BKMK_Address2_Telephone1)
- [Address2_Telephone2](#BKMK_Address2_Telephone2)
- [Address2_Telephone3](#BKMK_Address2_Telephone3)
- [Address2_UPSZone](#BKMK_Address2_UPSZone)
- [Address2_UTCOffset](#BKMK_Address2_UTCOffset)
- [BudgetAmount](#BKMK_BudgetAmount)
- [BudgetStatus](#BKMK_BudgetStatus)
- [CampaignId](#BKMK_CampaignId)
- [CompanyName](#BKMK_CompanyName)
- [ConfirmInterest](#BKMK_ConfirmInterest)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [DecisionMaker](#BKMK_DecisionMaker)
- [Description](#BKMK_Description)
- [DoNotBulkEMail](#BKMK_DoNotBulkEMail)
- [DoNotEMail](#BKMK_DoNotEMail)
- [DoNotFax](#BKMK_DoNotFax)
- [DoNotPhone](#BKMK_DoNotPhone)
- [DoNotPostalMail](#BKMK_DoNotPostalMail)
- [DoNotSendMM](#BKMK_DoNotSendMM)
- [EMailAddress1](#BKMK_EMailAddress1)
- [EMailAddress2](#BKMK_EMailAddress2)
- [EMailAddress3](#BKMK_EMailAddress3)
- [EntityImage](#BKMK_EntityImage)
- [EstimatedAmount](#BKMK_EstimatedAmount)
- [EstimatedCloseDate](#BKMK_EstimatedCloseDate)
- [EstimatedValue](#BKMK_EstimatedValue)
- [EvaluateFit](#BKMK_EvaluateFit)
- [Fax](#BKMK_Fax)
- [FirstName](#BKMK_FirstName)
- [FollowEmail](#BKMK_FollowEmail)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IndustryCode](#BKMK_IndustryCode)
- [InitialCommunication](#BKMK_InitialCommunication)
- [JobTitle](#BKMK_JobTitle)
- [LastName](#BKMK_LastName)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LastUsedInCampaign](#BKMK_LastUsedInCampaign)
- [LeadId](#BKMK_LeadId)
- [LeadQualityCode](#BKMK_LeadQualityCode)
- [LeadSourceCode](#BKMK_LeadSourceCode)
- [MiddleName](#BKMK_MiddleName)
- [MobilePhone](#BKMK_MobilePhone)
- [msdyn_ordertype](#BKMK_msdyn_ordertype)
- [Need](#BKMK_Need)
- [NumberOfEmployees](#BKMK_NumberOfEmployees)
- [OriginatingCaseId](#BKMK_OriginatingCaseId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Pager](#BKMK_Pager)
- [ParentAccountId](#BKMK_ParentAccountId)
- [ParentContactId](#BKMK_ParentContactId)
- [ParticipatesInWorkflow](#BKMK_ParticipatesInWorkflow)
- [PreferredContactMethodCode](#BKMK_PreferredContactMethodCode)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [PurchaseProcess](#BKMK_PurchaseProcess)
- [PurchaseTimeFrame](#BKMK_PurchaseTimeFrame)
- [QualificationComments](#BKMK_QualificationComments)
- [QualifyingOpportunityId](#BKMK_QualifyingOpportunityId)
- [RelatedObjectId](#BKMK_RelatedObjectId)
- [Revenue](#BKMK_Revenue)
- [SalesStage](#BKMK_SalesStage)
- [SalesStageCode](#BKMK_SalesStageCode)
- [Salutation](#BKMK_Salutation)
- [ScheduleFollowUp_Prospect](#BKMK_ScheduleFollowUp_Prospect)
- [ScheduleFollowUp_Qualify](#BKMK_ScheduleFollowUp_Qualify)
- [SIC](#BKMK_SIC)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [Telephone1](#BKMK_Telephone1)
- [Telephone2](#BKMK_Telephone2)
- [Telephone3](#BKMK_Telephone3)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WebSiteUrl](#BKMK_WebSiteUrl)
- [YomiCompanyName](#BKMK_YomiCompanyName)
- [YomiFirstName](#BKMK_YomiFirstName)
- [YomiLastName](#BKMK_YomiLastName)
- [YomiMiddleName](#BKMK_YomiMiddleName)


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

#### Address1_AddressTypeCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_Address1_City"></a> Address1_City

|Property|Value|
|--------|-----|
|Description|Type the city for the primary address.|
|DisplayName|City|
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
|DisplayName|Country/Region|
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
|DisplayName|Street 1|
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
|DisplayName|Street 2|
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
|DisplayName|Street 3|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the primary address.|
|DisplayName|ZIP/Postal Code|
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

#### Address1_ShippingMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province of the primary address.|
|DisplayName|State/Province|
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
|DisplayName|Address 1: Telephone 1|
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

#### Address2_AddressTypeCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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
|MaxLength|100|
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

#### Address2_ShippingMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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


### <a name="BKMK_BudgetAmount"></a> BudgetAmount

|Property|Value|
|--------|-----|
|Description|Information about the budget amount of the lead's company or organization.|
|DisplayName|Budget Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_BudgetStatus"></a> BudgetStatus

|Property|Value|
|--------|-----|
|Description|Information about the budget status of the lead's company or organization.|
|DisplayName|Budget|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetstatus|
|RequiredLevel|None|
|Type|Picklist|

#### BudgetStatus Options

|Value|Label|
|-----|-----|
|0|No Committed Budget|
|1|May Buy|
|2|Can Buy|
|3|Will Buy|



### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|--------|-----|
|Description|Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.|
|DisplayName|Source Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|campaignid|
|RequiredLevel|None|
|Targets|campaign|
|Type|Lookup|


### <a name="BKMK_CompanyName"></a> CompanyName

|Property|Value|
|--------|-----|
|Description|Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.|
|DisplayName|Company Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|companyname|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_ConfirmInterest"></a> ConfirmInterest

|Property|Value|
|--------|-----|
|Description|Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.|
|DisplayName|Confirm Interest|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|confirminterest|
|RequiredLevel|None|
|Type|Boolean|

#### ConfirmInterest Options

|Value|Label|
|-----|-----|
|1|No|
|0|Yes|

**DefaultValue**: False



### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|None|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_DecisionMaker"></a> DecisionMaker

|Property|Value|
|--------|-----|
|Description|Select whether your notes include information about who makes the purchase decisions at the lead's company.|
|DisplayName|Decision Maker?|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|decisionmaker|
|RequiredLevel|None|
|Type|Boolean|

#### DecisionMaker Options

|Value|Label|
|-----|-----|
|1|completed|
|0|mark complete|

**DefaultValue**: False



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the lead, such as an excerpt from the company's website.|
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
|Description|Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.|
|DisplayName|Do not allow Bulk Emails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotbulkemail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotBulkEMail Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotEMail"></a> DoNotEMail

|Property|Value|
|--------|-----|
|Description|Select whether the lead allows direct email sent from Microsoft Dynamics 365.|
|DisplayName|Do not allow Emails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotemail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotEMail Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotFax"></a> DoNotFax

|Property|Value|
|--------|-----|
|Description|Select whether the lead allows faxes.|
|DisplayName|Do not allow Faxes|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotfax|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotFax Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotPhone"></a> DoNotPhone

|Property|Value|
|--------|-----|
|Description|Select whether the lead allows phone calls.|
|DisplayName|Do not allow Phone Calls|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotphone|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPhone Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

|Property|Value|
|--------|-----|
|Description|Select whether the lead allows direct mail.|
|DisplayName|Do not allow Mails|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotpostalmail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPostalMail Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotSendMM"></a> DoNotSendMM

|Property|Value|
|--------|-----|
|Description|Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.|
|DisplayName|Marketing Material|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotsendmm|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotSendMM Options

|Value|Label|
|-----|-----|
|1|Do Not Send|
|0|Send|

**DefaultValue**: False



### <a name="BKMK_EMailAddress1"></a> EMailAddress1

|Property|Value|
|--------|-----|
|Description|Type the primary email address for the lead.|
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
|Description|Type the secondary email address for the lead.|
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
|Description|Type a third email address for the lead.|
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
|DisplayName|Entity Image|
|IsPrimaryImage|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_EstimatedAmount"></a> EstimatedAmount

|Property|Value|
|--------|-----|
|Description|Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.|
|DisplayName|Est. Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_EstimatedCloseDate"></a> EstimatedCloseDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.|
|DisplayName|Est. Close Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedclosedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EstimatedValue"></a> EstimatedValue

|Property|Value|
|--------|-----|
|Description|Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.|
|DisplayName|Est. Value (deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedvalue|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_EvaluateFit"></a> EvaluateFit

|Property|Value|
|--------|-----|
|Description|Select whether the fit between the lead's requirements and your offerings was evaluated.|
|DisplayName|Evaluate Fit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|evaluatefit|
|RequiredLevel|None|
|Type|Boolean|

#### EvaluateFit Options

|Value|Label|
|-----|-----|
|1|No|
|0|Yes|

**DefaultValue**: False



### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the primary contact for the lead.|
|DisplayName|Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FirstName"></a> FirstName

|Property|Value|
|--------|-----|
|Description|Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.|
|DisplayName|First Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstname|
|MaxLength|50|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_FollowEmail"></a> FollowEmail

|Property|Value|
|--------|-----|
|Description|Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.|
|DisplayName|Follow Email Activity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|followemail|
|RequiredLevel|None|
|Type|Boolean|

#### FollowEmail Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: True



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


### <a name="BKMK_IndustryCode"></a> IndustryCode

|Property|Value|
|--------|-----|
|Description|Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.|
|DisplayName|Industry|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|industrycode|
|RequiredLevel|None|
|Type|Picklist|

#### IndustryCode Options

|Value|Label|
|-----|-----|
|1|Accounting|
|2|Agriculture and Non-petrol Natural Resource Extraction|
|3|Broadcasting Printing and Publishing|
|4|Brokers|
|5|Building Supply Retail|
|6|Business Services|
|7|Consulting|
|8|Consumer Services|
|9|Design, Direction and Creative Management|
|10|Distributors, Dispatchers and Processors|
|11|Doctor's Offices and Clinics|
|12|Durable Manufacturing|
|13|Eating and Drinking Places|
|14|Entertainment Retail|
|15|Equipment Rental and Leasing|
|16|Financial|
|17|Food and Tobacco Processing|
|18|Inbound Capital Intensive Processing|
|19|Inbound Repair and Services|
|20|Insurance|
|21|Legal Services|
|22|Non-Durable Merchandise Retail|
|23|Outbound Consumer Service|
|24|Petrochemical Extraction and Distribution|
|25|Service Retail|
|26|SIG Affiliations|
|27|Social Services|
|28|Special Outbound Trade Contractors|
|29|Specialty Realty|
|30|Transportation|
|31|Utility Creation and Distribution|
|32|Vehicle Retail|
|33|Wholesale|



### <a name="BKMK_InitialCommunication"></a> InitialCommunication

|Property|Value|
|--------|-----|
|Description|Choose whether someone from the sales team contacted this lead earlier.|
|DisplayName|Initial Communication|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|initialcommunication|
|RequiredLevel|None|
|Type|Picklist|

#### InitialCommunication Options

|Value|Label|
|-----|-----|
|0|Contacted|
|1|Not Contacted|



### <a name="BKMK_JobTitle"></a> JobTitle

|Property|Value|
|--------|-----|
|Description|Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.|
|DisplayName|Job Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|jobtitle|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_LastName"></a> LastName

|Property|Value|
|--------|-----|
|Description|Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.|
|DisplayName|Last Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastname|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


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
|Description|Shows the date when the lead was last included in a marketing campaign or quick campaign.|
|DisplayName|Last Campaign Date|
|Format|DateOnly|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastusedincampaign|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LeadId"></a> LeadId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the lead.|
|DisplayName|Lead|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|leadid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_LeadQualityCode"></a> LeadQualityCode

|Property|Value|
|--------|-----|
|Description|Select a rating value to indicate the lead's potential to become a customer.|
|DisplayName|Rating|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|leadqualitycode|
|RequiredLevel|None|
|Type|Picklist|

#### LeadQualityCode Options

|Value|Label|
|-----|-----|
|1|Hot|
|2|Warm|
|3|Cold|



### <a name="BKMK_LeadSourceCode"></a> LeadSourceCode

|Property|Value|
|--------|-----|
|Description|Select the primary marketing source that prompted the lead to contact you.|
|DisplayName|Lead Source|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|leadsourcecode|
|RequiredLevel|None|
|Type|Picklist|

#### LeadSourceCode Options

|Value|Label|
|-----|-----|
|1|Advertisement|
|2|Employee Referral|
|3|External Referral|
|4|Partner|
|5|Public Relations|
|6|Seminar|
|7|Trade Show|
|8|Web|
|9|Word of Mouth|
|10|Other|



### <a name="BKMK_MiddleName"></a> MiddleName

|Property|Value|
|--------|-----|
|Description|Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.|
|DisplayName|Middle Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|middlename|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MobilePhone"></a> MobilePhone

|Property|Value|
|--------|-----|
|Description|Type the mobile phone number for the primary contact for the lead.|
|DisplayName|Mobile Phone|
|FormatName|Phone|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|mobilephone|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ordertype"></a> msdyn_ordertype

**Added by**: Project Service Automation Solution<br />

|Property|Value|
|--------|-----|
|Description|Whether the Opportunity created when qualifying this Lead is for an Item- based or a Work-based sale|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ordertype|
|RequiredLevel|Recommended|
|Type|Picklist|

#### msdyn_ordertype Options

|Value|Label|
|-----|-----|
|192350000|Item based|
|192350001|Work based|
|690970002|Service-Maintenance Based|



### <a name="BKMK_Need"></a> Need

|Property|Value|
|--------|-----|
|Description|Choose how high the level of need is for the lead's company.|
|DisplayName|Need|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|need|
|RequiredLevel|None|
|Type|Picklist|

#### Need Options

|Value|Label|
|-----|-----|
|0|Must have|
|1|Should have|
|2|Good to have|
|3|No need|



### <a name="BKMK_NumberOfEmployees"></a> NumberOfEmployees

|Property|Value|
|--------|-----|
|Description|Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.|
|DisplayName|No. of Employees|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|numberofemployees|
|MaxValue|1000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OriginatingCaseId"></a> OriginatingCaseId

|Property|Value|
|--------|-----|
|Description|This attribute is used for Sample Service Business Processes.|
|DisplayName|Originating Case|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|originatingcaseid|
|RequiredLevel|None|
|Targets|incident|
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
|Description|Owner Id|
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
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Pager"></a> Pager

|Property|Value|
|--------|-----|
|Description|Type the pager number for the primary contact for the lead.|
|DisplayName|Pager|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pager|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentAccountId"></a> ParentAccountId

|Property|Value|
|--------|-----|
|Description|Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.|
|DisplayName|Parent Account for lead|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentaccountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_ParentContactId"></a> ParentContactId

|Property|Value|
|--------|-----|
|Description|Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.|
|DisplayName|Parent Contact for lead|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentcontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

|Property|Value|
|--------|-----|
|Description|Shows whether the lead participates in workflow rules.|
|DisplayName|Participates in Workflow|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|participatesinworkflow|
|RequiredLevel|None|
|Type|Boolean|

#### ParticipatesInWorkflow Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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

#### PreferredContactMethodCode Options

|Value|Label|
|-----|-----|
|1|Any|
|2|Email|
|3|Phone|
|4|Fax|
|5|Mail|



### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PurchaseProcess"></a> PurchaseProcess

|Property|Value|
|--------|-----|
|Description|Choose whether an individual or a committee will be involved in the  purchase process for the lead.|
|DisplayName|Purchase Process|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|purchaseprocess|
|RequiredLevel|None|
|Type|Picklist|

#### PurchaseProcess Options

|Value|Label|
|-----|-----|
|0|Individual|
|1|Committee|
|2|Unknown|



### <a name="BKMK_PurchaseTimeFrame"></a> PurchaseTimeFrame

|Property|Value|
|--------|-----|
|Description|Choose how long the lead will likely take to make the purchase, so the sales team will be aware.|
|DisplayName|Purchase Timeframe|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|purchasetimeframe|
|RequiredLevel|None|
|Type|Picklist|

#### PurchaseTimeFrame Options

|Value|Label|
|-----|-----|
|0|Immediate|
|1|This Quarter|
|2|Next Quarter|
|3|This Year|
|4|Unknown|



### <a name="BKMK_QualificationComments"></a> QualificationComments

|Property|Value|
|--------|-----|
|Description|Type comments about the qualification or scoring of the lead.|
|DisplayName|Qualification Comments|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|qualificationcomments|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_QualifyingOpportunityId"></a> QualifyingOpportunityId

|Property|Value|
|--------|-----|
|Description|Choose the opportunity that the lead was qualified on and then converted to.|
|DisplayName|Qualifying Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|qualifyingopportunityid|
|RequiredLevel|None|
|Targets|opportunity|
|Type|Lookup|


### <a name="BKMK_RelatedObjectId"></a> RelatedObjectId

|Property|Value|
|--------|-----|
|Description|Related Campaign Response.|
|DisplayName|Related Campaign Response|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|relatedobjectid|
|RequiredLevel|None|
|Targets|campaignresponse|
|Type|Lookup|


### <a name="BKMK_Revenue"></a> Revenue

|Property|Value|
|--------|-----|
|Description|Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.|
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


### <a name="BKMK_SalesStage"></a> SalesStage

|Property|Value|
|--------|-----|
|Description|Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.|
|DisplayName|Sales Stage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesstage|
|RequiredLevel|None|
|Type|Picklist|

#### SalesStage Options

|Value|Label|
|-----|-----|
|0|Qualify|



### <a name="BKMK_SalesStageCode"></a> SalesStageCode

|Property|Value|
|--------|-----|
|Description|Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.|
|DisplayName|Sales Stage Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesstagecode|
|RequiredLevel|None|
|Type|Picklist|

#### SalesStageCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_Salutation"></a> Salutation

|Property|Value|
|--------|-----|
|Description|Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.|
|DisplayName|Salutation|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salutation|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ScheduleFollowUp_Prospect"></a> ScheduleFollowUp_Prospect

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time of the prospecting follow-up meeting with the lead.|
|DisplayName|Schedule Follow Up (Prospect)|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|schedulefollowup_prospect|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduleFollowUp_Qualify"></a> ScheduleFollowUp_Qualify

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time of the qualifying follow-up meeting with the lead.|
|DisplayName|Schedule Follow Up (Qualify)|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|schedulefollowup_qualify|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SIC"></a> SIC

|Property|Value|
|--------|-----|
|Description|Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.|
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
|Description|Choose the service level agreement (SLA) that you want to apply to the Lead record.|
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
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Open|1|Open|
|1|Qualified|3|Qualified|
|2|Disqualified|4|Disqualified|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the lead's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|New|0|
|2|Contacted|0|
|3|Qualified|1|
|4|Lost|2|
|5|Cannot Contact|2|
|6|No Longer Interested|2|
|7|Canceled|2|



### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.|
|DisplayName|Topic|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|300|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|--------|-----|
|Description|Type the work phone number for the primary contact for the lead.|
|DisplayName|Business Phone|
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
|Description|Type the home phone number for the primary contact for the lead.|
|DisplayName|Home Phone|
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
|Description|Type an alternate phone number for the primary contact for the lead.|
|DisplayName|Other Phone|
|FormatName|Phone|
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
|MinValue|-2147483648|
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
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|Traversed Path|
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
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WebSiteUrl"></a> WebSiteUrl

|Property|Value|
|--------|-----|
|Description|Type the website URL for the company associated with this lead.|
|DisplayName|Website|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|websiteurl|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiCompanyName"></a> YomiCompanyName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.|
|DisplayName|Yomi Company Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomicompanyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiFirstName"></a> YomiFirstName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.|
|DisplayName|Yomi First Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomifirstname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiLastName"></a> YomiLastName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.|
|DisplayName|Yomi Last Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomilastname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiMiddleName"></a> YomiMiddleName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.|
|DisplayName|Yomi Middle Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomimiddlename|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [Address1_Composite](#BKMK_Address1_Composite)
- [Address2_Composite](#BKMK_Address2_Composite)
- [BudgetAmount_Base](#BKMK_BudgetAmount_Base)
- [CampaignIdName](#BKMK_CampaignIdName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [EstimatedAmount_Base](#BKMK_EstimatedAmount_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FullName](#BKMK_FullName)
- [IsAutoCreate](#BKMK_IsAutoCreate)
- [IsPrivate](#BKMK_IsPrivate)
- [MasterId](#BKMK_MasterId)
- [MasterLeadIdName](#BKMK_MasterLeadIdName)
- [MasterLeadIdYomiName](#BKMK_MasterLeadIdYomiName)
- [Merged](#BKMK_Merged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OriginatingCaseIdName](#BKMK_OriginatingCaseIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentAccountIdName](#BKMK_ParentAccountIdName)
- [ParentAccountIdYomiName](#BKMK_ParentAccountIdYomiName)
- [ParentContactIdName](#BKMK_ParentContactIdName)
- [ParentContactIdYomiName](#BKMK_ParentContactIdYomiName)
- [QualifyingOpportunityIdName](#BKMK_QualifyingOpportunityIdName)
- [RelatedObjectIdName](#BKMK_RelatedObjectIdName)
- [Revenue_Base](#BKMK_Revenue_Base)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [YomiFullName](#BKMK_YomiFullName)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account with which the lead is associated.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_BudgetAmount_Base"></a> BudgetAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Budget Amount in base currency.|
|DisplayName|Budget Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CampaignIdName"></a> CampaignIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contact with which the lead is associated.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Date and time when the record was created.|
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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_EstimatedAmount_Base"></a> EstimatedAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Est. Value in base currency.|
|DisplayName|Est. Value (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_FullName"></a> FullName

|Property|Value|
|--------|-----|
|Description|Combines and shows the lead's first and last names so the full name can be displayed in views and reports.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fullname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsAutoCreate"></a> IsAutoCreate

|Property|Value|
|--------|-----|
|Description|Information about whether the contact was auto-created when promoting an email or an appointment.|
|DisplayName|Auto-created|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isautocreate|
|RequiredLevel|None|
|Type|Boolean|

#### IsAutoCreate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|--------|-----|
|Description|Indicates whether the lead is private or visible to the entire organization.|
|DisplayName|Is Private|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsPrivate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MasterId"></a> MasterId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the master lead for merge.|
|DisplayName|Master ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masterid|
|RequiredLevel|None|
|Targets|lead|
|Type|Lookup|


### <a name="BKMK_MasterLeadIdName"></a> MasterLeadIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masterleadidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MasterLeadIdYomiName"></a> MasterLeadIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masterleadidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Merged"></a> Merged

|Property|Value|
|--------|-----|
|Description|Tells whether the lead has been merged with another lead.|
|DisplayName|Merged|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|merged|
|RequiredLevel|None|
|Type|Boolean|

#### Merged Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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
|Description|Date and time when the record was modified.|
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
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_OriginatingCaseIdName"></a> OriginatingCaseIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingcaseidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
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
|Description|Yomi name of the owner|
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
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
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
|Description|Unique identifier for the user that owns the record.|
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


### <a name="BKMK_ParentContactIdName"></a> ParentContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentcontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentContactIdYomiName"></a> ParentContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentcontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_QualifyingOpportunityIdName"></a> QualifyingOpportunityIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|qualifyingopportunityidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RelatedObjectIdName"></a> RelatedObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relatedobjectidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Revenue_Base"></a> Revenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Annual Revenue in base currency.|
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


### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

|Property|Value|
|--------|-----|
|Description|Total time spent for emails (read and write) and meetings by me in relation to the lead record.|
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
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_YomiFullName"></a> YomiFullName

|Property|Value|
|--------|-----|
|Description|Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.|
|DisplayName|Yomi Full Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomifullname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [Lead_ActivityPointers](#BKMK_Lead_ActivityPointers)
- [Lead_SyncErrors](#BKMK_Lead_SyncErrors)
- [lead_activity_parties](#BKMK_lead_activity_parties)
- [Lead_DuplicateMatchingRecord](#BKMK_Lead_DuplicateMatchingRecord)
- [Lead_DuplicateBaseRecord](#BKMK_Lead_DuplicateBaseRecord)
- [Lead_SharepointDocumentLocation](#BKMK_Lead_SharepointDocumentLocation)
- [Lead_SharepointDocument](#BKMK_Lead_SharepointDocument)
- [Lead_AsyncOperations](#BKMK_Lead_AsyncOperations)
- [Lead_MailboxTrackingFolder](#BKMK_Lead_MailboxTrackingFolder)
- [userentityinstancedata_lead](#BKMK_userentityinstancedata_lead)
- [Lead_ProcessSessions](#BKMK_Lead_ProcessSessions)
- [Lead_BulkDeleteFailures](#BKMK_Lead_BulkDeleteFailures)
- [lead_principalobjectattributeaccess](#BKMK_lead_principalobjectattributeaccess)
- [Lead_Appointments](#BKMK_Lead_Appointments)
- [Lead_Emails](#BKMK_Lead_Emails)
- [Lead_Faxes](#BKMK_Lead_Faxes)
- [Lead_Letters](#BKMK_Lead_Letters)
- [Lead_Phonecalls](#BKMK_Lead_Phonecalls)
- [Lead_Tasks](#BKMK_Lead_Tasks)
- [Lead_RecurringAppointmentMasters](#BKMK_Lead_RecurringAppointmentMasters)
- [Lead_SocialActivities](#BKMK_Lead_SocialActivities)
- [lead_connections1](#BKMK_lead_connections1)
- [lead_connections2](#BKMK_lead_connections2)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [Lead_actioncard](#BKMK_Lead_actioncard)
- [Lead_Email_EmailSender](#BKMK_Lead_Email_EmailSender)
- [lead_addresses](#BKMK_lead_addresses)
- [lead_PostFollows](#BKMK_lead_PostFollows)
- [lead_master_lead](#BKMK_lead_master_lead)
- [slakpiinstance_lead](#BKMK_slakpiinstance_lead)
- [account_originating_lead](#BKMK_account_originating_lead)
- [contact_originating_lead](#BKMK_contact_originating_lead)
- [lead_BulkOperations](#BKMK_lead_BulkOperations)
- [lead_CampaignActivities](#BKMK_lead_CampaignActivities)
- [lead_CampaignResponses](#BKMK_lead_CampaignResponses)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)
- [lead_IncidentResolutions](#BKMK_lead_IncidentResolutions)
- [Lead_ServiceAppointments](#BKMK_Lead_ServiceAppointments)
- [lead_OpportunityCloses](#BKMK_lead_OpportunityCloses)
- [lead_OrderCloses](#BKMK_lead_OrderCloses)
- [lead_QuoteCloses](#BKMK_lead_QuoteCloses)
- [opportunity_originating_lead](#BKMK_opportunity_originating_lead)
- [lk_leadtoopportunitysalesprocess_leadid](#BKMK_lk_leadtoopportunitysalesprocess_leadid)
- [lead_msdyn_bookingalerts](#BKMK_lead_msdyn_bookingalerts)
- [lead_msdyn_approvals](#BKMK_lead_msdyn_approvals)


### <a name="BKMK_Lead_ActivityPointers"></a> Lead_ActivityPointers

Same as activitypointer entity [Lead_ActivityPointers](activitypointer.md#BKMK_Lead_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_SyncErrors"></a> Lead_SyncErrors

Same as syncerror entity [Lead_SyncErrors](syncerror.md#BKMK_Lead_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_activity_parties"></a> lead_activity_parties

Same as activityparty entity [lead_activity_parties](activityparty.md#BKMK_lead_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|partyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lead_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_DuplicateMatchingRecord"></a> Lead_DuplicateMatchingRecord

Same as duplicaterecord entity [Lead_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Lead_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_DuplicateBaseRecord"></a> Lead_DuplicateBaseRecord

Same as duplicaterecord entity [Lead_DuplicateBaseRecord](duplicaterecord.md#BKMK_Lead_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_SharepointDocumentLocation"></a> Lead_SharepointDocumentLocation

Same as sharepointdocumentlocation entity [Lead_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Lead_SharepointDocumentLocation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_SharepointDocumentLocation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_SharepointDocument"></a> Lead_SharepointDocument

Same as sharepointdocument entity [Lead_SharepointDocument](sharepointdocument.md#BKMK_Lead_SharepointDocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocument|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_SharepointDocument|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_AsyncOperations"></a> Lead_AsyncOperations

Same as asyncoperation entity [Lead_AsyncOperations](asyncoperation.md#BKMK_Lead_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_MailboxTrackingFolder"></a> Lead_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Lead_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Lead_MailboxTrackingFolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_userentityinstancedata_lead"></a> userentityinstancedata_lead

Same as userentityinstancedata entity [userentityinstancedata_lead](userentityinstancedata.md#BKMK_userentityinstancedata_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_ProcessSessions"></a> Lead_ProcessSessions

Same as processsession entity [Lead_ProcessSessions](processsession.md#BKMK_Lead_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_BulkDeleteFailures"></a> Lead_BulkDeleteFailures

Same as bulkdeletefailure entity [Lead_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Lead_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_principalobjectattributeaccess"></a> lead_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [lead_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_lead_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lead_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_Appointments"></a> Lead_Appointments

Same as appointment entity [Lead_Appointments](appointment.md#BKMK_Lead_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_Emails"></a> Lead_Emails

Same as email entity [Lead_Emails](email.md#BKMK_Lead_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_Faxes"></a> Lead_Faxes

Same as fax entity [Lead_Faxes](fax.md#BKMK_Lead_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_Letters"></a> Lead_Letters

Same as letter entity [Lead_Letters](letter.md#BKMK_Lead_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_Phonecalls"></a> Lead_Phonecalls

Same as phonecall entity [Lead_Phonecalls](phonecall.md#BKMK_Lead_Phonecalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_Tasks"></a> Lead_Tasks

Same as task entity [Lead_Tasks](task.md#BKMK_Lead_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_RecurringAppointmentMasters"></a> Lead_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Lead_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Lead_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_SocialActivities"></a> Lead_SocialActivities

Same as socialactivity entity [Lead_SocialActivities](socialactivity.md#BKMK_Lead_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_connections1"></a> lead_connections1

Same as connection entity [lead_connections1](connection.md#BKMK_lead_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_connections2"></a> lead_connections2

Same as connection entity [lead_connections2](connection.md#BKMK_lead_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

Same as annotation entity [Lead_Annotation](annotation.md#BKMK_Lead_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_actioncard"></a> Lead_actioncard

Same as actioncard entity [Lead_actioncard](actioncard.md#BKMK_Lead_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Lead_Email_EmailSender"></a> Lead_Email_EmailSender

Same as email entity [Lead_Email_EmailSender](email.md#BKMK_Lead_Email_EmailSender) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|emailsender|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Lead_Email_EmailSender|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_addresses"></a> lead_addresses

Same as leadaddress entity [lead_addresses](leadaddress.md#BKMK_lead_addresses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadaddress|
|ReferencingAttribute|parentid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_addresses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_PostFollows"></a> lead_PostFollows

Same as postfollow entity [lead_PostFollows](postfollow.md#BKMK_lead_PostFollows) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lead_PostFollows|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_master_lead"></a> lead_master_lead

Same as lead entity [lead_master_lead](lead.md#BKMK_lead_master_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|masterid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_master_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_lead"></a> slakpiinstance_lead

Same as slakpiinstance entity [slakpiinstance_lead](slakpiinstance.md#BKMK_slakpiinstance_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slakpiinstance_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_account_originating_lead"></a> account_originating_lead

Same as account entity [account_originating_lead](account.md#BKMK_account_originating_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|originatingleadid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|account_originating_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contact_originating_lead"></a> contact_originating_lead

Same as contact entity [contact_originating_lead](contact.md#BKMK_contact_originating_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|originatingleadid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contact_originating_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_BulkOperations"></a> lead_BulkOperations

Same as bulkoperation entity [lead_BulkOperations](bulkoperation.md#BKMK_lead_BulkOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_CampaignActivities"></a> lead_CampaignActivities

Same as campaignactivity entity [lead_CampaignActivities](campaignactivity.md#BKMK_lead_CampaignActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_CampaignActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_CampaignResponses"></a> lead_CampaignResponses

Same as campaignresponse entity [lead_CampaignResponses](campaignresponse.md#BKMK_lead_CampaignResponses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

Same as bulkoperationlog entity [CreatedLead_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedLead_BulkOperationLogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|createdobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CreatedLead_BulkOperationLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

Same as bulkoperationlog entity [SourceLead_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceLead_BulkOperationLogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|SourceLead_BulkOperationLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_IncidentResolutions"></a> lead_IncidentResolutions

Same as incidentresolution entity [lead_IncidentResolutions](incidentresolution.md#BKMK_lead_IncidentResolutions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Lead_ServiceAppointments"></a> Lead_ServiceAppointments

Same as serviceappointment entity [Lead_ServiceAppointments](serviceappointment.md#BKMK_Lead_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Lead_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_OpportunityCloses"></a> lead_OpportunityCloses

Same as opportunityclose entity [lead_OpportunityCloses](opportunityclose.md#BKMK_lead_OpportunityCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_OrderCloses"></a> lead_OrderCloses

Same as orderclose entity [lead_OrderCloses](orderclose.md#BKMK_lead_OrderCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_QuoteCloses"></a> lead_QuoteCloses

Same as quoteclose entity [lead_QuoteCloses](quoteclose.md#BKMK_lead_QuoteCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_originating_lead"></a> opportunity_originating_lead

Same as opportunity entity [opportunity_originating_lead](opportunity.md#BKMK_opportunity_originating_lead) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|originatingleadid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_originating_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_leadtoopportunitysalesprocess_leadid"></a> lk_leadtoopportunitysalesprocess_leadid

Same as leadtoopportunitysalesprocess entity [lk_leadtoopportunitysalesprocess_leadid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_leadid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadtoopportunitysalesprocess|
|ReferencingAttribute|leadid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_leadtoopportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_msdyn_bookingalerts"></a> lead_msdyn_bookingalerts

Same as msdyn_bookingalert entity [lead_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_lead_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lead_msdyn_approvals"></a> lead_msdyn_approvals

Same as msdyn_approval entity [lead_msdyn_approvals](msdyn_approval.md#BKMK_lead_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_leadbase_createdby](#BKMK_lk_leadbase_createdby)
- [lk_lead_createdonbehalfby](#BKMK_lk_lead_createdonbehalfby)
- [lk_leadbase_modifiedby](#BKMK_lk_leadbase_modifiedby)
- [lk_lead_modifiedonbehalfby](#BKMK_lk_lead_modifiedonbehalfby)
- [lead_owning_user](#BKMK_lead_owning_user)
- [lead_owning_team](#BKMK_lead_owning_team)
- [business_unit_leads](#BKMK_business_unit_leads)
- [processstage_lead](#BKMK_processstage_lead)
- [transactioncurrency_lead](#BKMK_transactioncurrency_lead)
- [lead_customer_accounts](#BKMK_lead_customer_accounts)
- [lead_customer_contacts](#BKMK_lead_customer_contacts)
- [manualsla_lead](#BKMK_manualsla_lead)
- [sla_lead](#BKMK_sla_lead)
- [lead_master_lead](#BKMK_lead_master_lead)
- [lead_parent_account](#BKMK_lead_parent_account)
- [lead_parent_contact](#BKMK_lead_parent_contact)
- [campaign_leads](#BKMK_campaign_leads)
- [CampaignResponse_Lead](#BKMK_CampaignResponse_Lead)
- [OriginatingCase_Lead](#BKMK_OriginatingCase_Lead)
- [lead_qualifying_opportunity](#BKMK_lead_qualifying_opportunity)


### <a name="BKMK_lk_leadbase_createdby"></a> lk_leadbase_createdby

See systemuser Entity [lk_leadbase_createdby](systemuser.md#BKMK_lk_leadbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_lead_createdonbehalfby"></a> lk_lead_createdonbehalfby

See systemuser Entity [lk_lead_createdonbehalfby](systemuser.md#BKMK_lk_lead_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_leadbase_modifiedby"></a> lk_leadbase_modifiedby

See systemuser Entity [lk_leadbase_modifiedby](systemuser.md#BKMK_lk_leadbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_lead_modifiedonbehalfby"></a> lk_lead_modifiedonbehalfby

See systemuser Entity [lk_lead_modifiedonbehalfby](systemuser.md#BKMK_lk_lead_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lead_owning_user"></a> lead_owning_user

See systemuser Entity [lead_owning_user](systemuser.md#BKMK_lead_owning_user) One-To-Many relationship.

### <a name="BKMK_lead_owning_team"></a> lead_owning_team

See team Entity [lead_owning_team](team.md#BKMK_lead_owning_team) One-To-Many relationship.

### <a name="BKMK_business_unit_leads"></a> business_unit_leads

See businessunit Entity [business_unit_leads](businessunit.md#BKMK_business_unit_leads) One-To-Many relationship.

### <a name="BKMK_processstage_lead"></a> processstage_lead

See processstage Entity [processstage_lead](processstage.md#BKMK_processstage_lead) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

See transactioncurrency Entity [transactioncurrency_lead](transactioncurrency.md#BKMK_transactioncurrency_lead) One-To-Many relationship.

### <a name="BKMK_lead_customer_accounts"></a> lead_customer_accounts

See account Entity [lead_customer_accounts](account.md#BKMK_lead_customer_accounts) One-To-Many relationship.

### <a name="BKMK_lead_customer_contacts"></a> lead_customer_contacts

See contact Entity [lead_customer_contacts](contact.md#BKMK_lead_customer_contacts) One-To-Many relationship.

### <a name="BKMK_manualsla_lead"></a> manualsla_lead

See sla Entity [manualsla_lead](sla.md#BKMK_manualsla_lead) One-To-Many relationship.

### <a name="BKMK_sla_lead"></a> sla_lead

See sla Entity [sla_lead](sla.md#BKMK_sla_lead) One-To-Many relationship.

### <a name="BKMK_lead_master_lead"></a> lead_master_lead

See lead Entity [lead_master_lead](lead.md#BKMK_lead_master_lead) One-To-Many relationship.

### <a name="BKMK_lead_parent_account"></a> lead_parent_account

See account Entity [lead_parent_account](account.md#BKMK_lead_parent_account) One-To-Many relationship.

### <a name="BKMK_lead_parent_contact"></a> lead_parent_contact

See contact Entity [lead_parent_contact](contact.md#BKMK_lead_parent_contact) One-To-Many relationship.

### <a name="BKMK_campaign_leads"></a> campaign_leads

See campaign Entity [campaign_leads](campaign.md#BKMK_campaign_leads) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_Lead"></a> CampaignResponse_Lead

See campaignresponse Entity [CampaignResponse_Lead](campaignresponse.md#BKMK_CampaignResponse_Lead) One-To-Many relationship.

### <a name="BKMK_OriginatingCase_Lead"></a> OriginatingCase_Lead

See incident Entity [OriginatingCase_Lead](incident.md#BKMK_OriginatingCase_Lead) One-To-Many relationship.

### <a name="BKMK_lead_qualifying_opportunity"></a> lead_qualifying_opportunity

See opportunity Entity [lead_qualifying_opportunity](opportunity.md#BKMK_lead_qualifying_opportunity) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Lead entity is the first entity in the relationship. Listed by **SchemaName**.

- [accountleads_association](#BKMK_accountleads_association)
- [contactleads_association](#BKMK_contactleads_association)
- [listlead_association](#BKMK_listlead_association)
- [leadcompetitors_association](#BKMK_leadcompetitors_association)
- [leadproduct_association](#BKMK_leadproduct_association)


### <a name="BKMK_accountleads_association"></a> accountleads_association

See account Entity [accountleads_association](account.md#BKMK_accountleads_association) Many-To-Many Relationship.

### <a name="BKMK_contactleads_association"></a> contactleads_association

See contact Entity [contactleads_association](contact.md#BKMK_contactleads_association) Many-To-Many Relationship.

### <a name="BKMK_listlead_association"></a> listlead_association

See list Entity [listlead_association](list.md#BKMK_listlead_association) Many-To-Many Relationship.

### <a name="BKMK_leadcompetitors_association"></a> leadcompetitors_association

IntersectEntityName: leadcompetitors<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|leadid|
|IsCustomizable|False|
|LogicalName|lead|
|NavigationPropertyName|leadcompetitors_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|competitor|
|IntersectAttribute|competitorid|
|NavigationPropertyName|leadcompetitors_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 40|


### <a name="BKMK_leadproduct_association"></a> leadproduct_association

IntersectEntityName: leadproduct<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|leadid|
|IsCustomizable|False|
|LogicalName|lead|
|NavigationPropertyName|leadproduct_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|product|
|IntersectAttribute|productid|
|NavigationPropertyName|leadproduct_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.lead?text=lead EntityType" />