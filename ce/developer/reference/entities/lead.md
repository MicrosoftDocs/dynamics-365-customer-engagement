---
title: "Lead table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Lead table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Lead table/entity reference (Microsoft Dynamics 365)

Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.

## Messages

The following table lists the messages for the Lead table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /leads(*leadid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /leads<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /leads(*leadid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `Merge`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Merge?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `QualifyLead`<br />Event: True |**QualifyLead action** |<xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /leads(*leadid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /leads<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /leads(*leadid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /leads(*leadid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /leads(*leadid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Lead table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead** |
| **DisplayCollectionName** | **Leads** |
| **SchemaName** | `Lead` |
| **CollectionSchemaName** | `Leads` |
| **EntitySetName** | `leads`|
| **LogicalName** | `lead` |
| **LogicalCollectionName** | `leads` |
| **PrimaryIdAttribute** | `leadid` |
| **PrimaryNameAttribute** |`fullname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [BusinessCard](#BKMK_BusinessCard)
- [BusinessCardAttributes](#BKMK_BusinessCardAttributes)
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
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_LeadGrade](#BKMK_msdyn_LeadGrade)
- [msdyn_leadkpiid](#BKMK_msdyn_leadkpiid)
- [msdyn_LeadScore](#BKMK_msdyn_LeadScore)
- [msdyn_LeadScoreTrend](#BKMK_msdyn_LeadScoreTrend)
- [msdyn_PredictiveScoreId](#BKMK_msdyn_PredictiveScoreId)
- [msdyn_salesassignmentresult](#BKMK_msdyn_salesassignmentresult)
- [msdyn_ScoreHistory](#BKMK_msdyn_ScoreHistory)
- [msdyn_ScoreReasons](#BKMK_msdyn_ScoreReasons)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
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
- [TeamsFollowed](#BKMK_TeamsFollowed)
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
|---|---|
|Description|**Unique identifier for address 1.**|
|DisplayName|**Address 1: ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`address1_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

|Property|Value|
|---|---|
|Description|**Select the primary address type.**|
|DisplayName|**Address 1: Address Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_address1_addresstypecode`|

#### Address1_AddressTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address1_City"></a> Address1_City

|Property|Value|
|---|---|
|Description|**Type the city for the primary address.**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address1_Country"></a> Address1_Country

|Property|Value|
|---|---|
|Description|**Type the country or region for the primary address.**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address1_County"></a> Address1_County

|Property|Value|
|---|---|
|Description|**Type the county for the primary address.**|
|DisplayName|**Address 1: County**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Fax"></a> Address1_Fax

|Property|Value|
|---|---|
|Description|**Type the fax number associated with the primary address.**|
|DisplayName|**Address 1: Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

|Property|Value|
|---|---|
|Description|**Type the latitude value for the primary address for use in mapping and other applications.**|
|DisplayName|**Address 1: Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_Address1_Line1"></a> Address1_Line1

|Property|Value|
|---|---|
|Description|**Type the first line of the primary address.**|
|DisplayName|**Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Line2"></a> Address1_Line2

|Property|Value|
|---|---|
|Description|**Type the second line of the primary address.**|
|DisplayName|**Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Line3"></a> Address1_Line3

|Property|Value|
|---|---|
|Description|**Type the third line of the primary address.**|
|DisplayName|**Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

|Property|Value|
|---|---|
|Description|**Type the longitude value for the primary address for use in mapping and other applications.**|
|DisplayName|**Address 1: Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Address1_Name"></a> Address1_Name

|Property|Value|
|---|---|
|Description|**Type a descriptive name for the primary address, such as Corporate Headquarters.**|
|DisplayName|**Address 1: Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

|Property|Value|
|---|---|
|Description|**Type the ZIP Code or postal code for the primary address.**|
|DisplayName|**ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

|Property|Value|
|---|---|
|Description|**Type the post office box number of the primary address.**|
|DisplayName|**Address 1: Post Office Box**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Select a shipping method for deliveries sent to this address.**|
|DisplayName|**Address 1: Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_address1_shippingmethodcode`|

#### Address1_ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

|Property|Value|
|---|---|
|Description|**Type the state or province of the primary address.**|
|DisplayName|**State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

|Property|Value|
|---|---|
|Description|**Type the main phone number associated with the primary address.**|
|DisplayName|**Address 1: Telephone 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

|Property|Value|
|---|---|
|Description|**Type a second phone number associated with the primary address.**|
|DisplayName|**Address 1: Telephone 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

|Property|Value|
|---|---|
|Description|**Type a third phone number associated with the primary address.**|
|DisplayName|**Address 1: Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

|Property|Value|
|---|---|
|Description|**Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.**|
|DisplayName|**Address 1: UPS Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

|Property|Value|
|---|---|
|Description|**Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.**|
|DisplayName|**Address 1: UTC Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

|Property|Value|
|---|---|
|Description|**Unique identifier for address 2.**|
|DisplayName|**Address 2: ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`address2_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

|Property|Value|
|---|---|
|Description|**Select the secondary address type.**|
|DisplayName|**Address 2: Address Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_address2_addresstypecode`|

#### Address2_AddressTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address2_City"></a> Address2_City

|Property|Value|
|---|---|
|Description|**Type the city for the secondary address.**|
|DisplayName|**Address 2: City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address2_Country"></a> Address2_Country

|Property|Value|
|---|---|
|Description|**Type the country or region for the secondary address.**|
|DisplayName|**Address 2: Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address2_County"></a> Address2_County

|Property|Value|
|---|---|
|Description|**Type the county for the secondary address.**|
|DisplayName|**Address 2: County**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Fax"></a> Address2_Fax

|Property|Value|
|---|---|
|Description|**Type the fax number associated with the secondary address.**|
|DisplayName|**Address 2: Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

|Property|Value|
|---|---|
|Description|**Type the latitude value for the secondary address for use in mapping and other applications.**|
|DisplayName|**Address 2: Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_Address2_Line1"></a> Address2_Line1

|Property|Value|
|---|---|
|Description|**Type the first line of the secondary address.**|
|DisplayName|**Address 2: Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Line2"></a> Address2_Line2

|Property|Value|
|---|---|
|Description|**Type the second line of the secondary address.**|
|DisplayName|**Address 2: Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Line3"></a> Address2_Line3

|Property|Value|
|---|---|
|Description|**Type the third line of the secondary address.**|
|DisplayName|**Address 2: Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

|Property|Value|
|---|---|
|Description|**Type the longitude value for the secondary address for use in mapping and other applications.**|
|DisplayName|**Address 2: Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Address2_Name"></a> Address2_Name

|Property|Value|
|---|---|
|Description|**Type a descriptive name for the secondary address, such as Corporate Headquarters.**|
|DisplayName|**Address 2: Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

|Property|Value|
|---|---|
|Description|**Type the ZIP Code or postal code for the secondary address.**|
|DisplayName|**Address 2: ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

|Property|Value|
|---|---|
|Description|**Type the post office box number of the secondary address.**|
|DisplayName|**Address 2: Post Office Box**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Select a shipping method for deliveries sent to this address.**|
|DisplayName|**Address 2: Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_address2_shippingmethodcode`|

#### Address2_ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

|Property|Value|
|---|---|
|Description|**Type the state or province of the secondary address.**|
|DisplayName|**Address 2: State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

|Property|Value|
|---|---|
|Description|**Type the main phone number associated with the secondary address.**|
|DisplayName|**Address 2: Telephone 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

|Property|Value|
|---|---|
|Description|**Type a second phone number associated with the secondary address.**|
|DisplayName|**Address 2: Telephone 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

|Property|Value|
|---|---|
|Description|**Type a third phone number associated with the secondary address.**|
|DisplayName|**Address 2: Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

|Property|Value|
|---|---|
|Description|**Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.**|
|DisplayName|**Address 2: UPS Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

|Property|Value|
|---|---|
|Description|**Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.**|
|DisplayName|**Address 2: UTC Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_BudgetAmount"></a> BudgetAmount

|Property|Value|
|---|---|
|Description|**Information about the budget amount of the lead's company or organization.**|
|DisplayName|**Budget Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_BudgetStatus"></a> BudgetStatus

|Property|Value|
|---|---|
|Description|**Information about the budget status of the lead's company or organization.**|
|DisplayName|**Budget**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`budgetstatus`|

#### BudgetStatus Choices/Options

|Value|Label|
|---|---|
|0|**No Committed Budget**|
|1|**May Buy**|
|2|**Can Buy**|
|3|**Will Buy**|

### <a name="BKMK_BusinessCard"></a> BusinessCard

|Property|Value|
|---|---|
|Description|**Stores Image of the Business Card**|
|DisplayName|**Business Card**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businesscard`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_BusinessCardAttributes"></a> BusinessCardAttributes

|Property|Value|
|---|---|
|Description|**Stores Business Card Control Properties.**|
|DisplayName|**BusinessCardAttributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businesscardattributes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|---|---|
|Description|**Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.**|
|DisplayName|**Source Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`campaignid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|campaign|

### <a name="BKMK_CompanyName"></a> CompanyName

|Property|Value|
|---|---|
|Description|**Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.**|
|DisplayName|**Company Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`companyname`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ConfirmInterest"></a> ConfirmInterest

|Property|Value|
|---|---|
|Description|**Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.**|
|DisplayName|**Confirm Interest**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`confirminterest`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`confirminterest`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|None|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_DecisionMaker"></a> DecisionMaker

|Property|Value|
|---|---|
|Description|**Select whether your notes include information about who makes the purchase decisions at the lead's company.**|
|DisplayName|**Decision Maker?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`decisionmaker`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`decisionmaker`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the lead, such as an excerpt from the company's website.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DoNotBulkEMail"></a> DoNotBulkEMail

|Property|Value|
|---|---|
|Description|**Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.**|
|DisplayName|**Do not allow Bulk Emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotbulkemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotbulkemail`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_DoNotEMail"></a> DoNotEMail

|Property|Value|
|---|---|
|Description|**Select whether the lead allows direct email sent from Microsoft Dynamics 365.**|
|DisplayName|**Do not allow Emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotemail`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_DoNotFax"></a> DoNotFax

|Property|Value|
|---|---|
|Description|**Select whether the lead allows faxes.**|
|DisplayName|**Do not allow Faxes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotfax`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotfax`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_DoNotPhone"></a> DoNotPhone

|Property|Value|
|---|---|
|Description|**Select whether the lead allows phone calls.**|
|DisplayName|**Do not allow Phone Calls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotphone`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotphone`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

|Property|Value|
|---|---|
|Description|**Select whether the lead allows direct mail.**|
|DisplayName|**Do not allow Mails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotpostalmail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotpostalmail`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_DoNotSendMM"></a> DoNotSendMM

|Property|Value|
|---|---|
|Description|**Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.**|
|DisplayName|**Marketing Material**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotsendmm`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_donotsendmm`|
|DefaultValue|False|
|True Label|Do Not Send|
|False Label|Send|

### <a name="BKMK_EMailAddress1"></a> EMailAddress1

|Property|Value|
|---|---|
|Description|**Type the primary email address for the lead.**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress1`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EMailAddress2"></a> EMailAddress2

|Property|Value|
|---|---|
|Description|**Type the secondary email address for the lead.**|
|DisplayName|**Email Address 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress2`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EMailAddress3"></a> EMailAddress3

|Property|Value|
|---|---|
|Description|**Type a third email address for the lead.**|
|DisplayName|**Email Address 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress3`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**Shows the default image for the record.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_EstimatedAmount"></a> EstimatedAmount

|Property|Value|
|---|---|
|Description|**Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.**|
|DisplayName|**Est. Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_EstimatedCloseDate"></a> EstimatedCloseDate

|Property|Value|
|---|---|
|Description|**Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.**|
|DisplayName|**Est. Close Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedclosedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_EstimatedValue"></a> EstimatedValue

|Property|Value|
|---|---|
|Description|**Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.**|
|DisplayName|**Est. Value (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedvalue`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_EvaluateFit"></a> EvaluateFit

|Property|Value|
|---|---|
|Description|**Select whether the fit between the lead's requirements and your offerings was evaluated.**|
|DisplayName|**Evaluate Fit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`evaluatefit`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`evaluatefit`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|---|---|
|Description|**Type the fax number for the primary contact for the lead.**|
|DisplayName|**Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_FirstName"></a> FirstName

|Property|Value|
|---|---|
|Description|**Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.**|
|DisplayName|**First Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`firstname`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_FollowEmail"></a> FollowEmail

|Property|Value|
|---|---|
|Description|**Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.**|
|DisplayName|**Follow Email Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`followemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_followemail`|
|DefaultValue|True|
|True Label|Allow|
|False Label|Do Not Allow|

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

### <a name="BKMK_IndustryCode"></a> IndustryCode

|Property|Value|
|---|---|
|Description|**Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.**|
|DisplayName|**Industry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`industrycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`lead_industrycode`|

#### IndustryCode Choices/Options

|Value|Label|
|---|---|
|1|**Accounting**|
|2|**Agriculture and Non-petrol Natural Resource Extraction**|
|3|**Broadcasting Printing and Publishing**|
|4|**Brokers**|
|5|**Building Supply Retail**|
|6|**Business Services**|
|7|**Consulting**|
|8|**Consumer Services**|
|9|**Design, Direction and Creative Management**|
|10|**Distributors, Dispatchers and Processors**|
|11|**Doctor's Offices and Clinics**|
|12|**Durable Manufacturing**|
|13|**Eating and Drinking Places**|
|14|**Entertainment Retail**|
|15|**Equipment Rental and Leasing**|
|16|**Financial**|
|17|**Food and Tobacco Processing**|
|18|**Inbound Capital Intensive Processing**|
|19|**Inbound Repair and Services**|
|20|**Insurance**|
|21|**Legal Services**|
|22|**Non-Durable Merchandise Retail**|
|23|**Outbound Consumer Service**|
|24|**Petrochemical Extraction and Distribution**|
|25|**Service Retail**|
|26|**SIG Affiliations**|
|27|**Social Services**|
|28|**Special Outbound Trade Contractors**|
|29|**Specialty Realty**|
|30|**Transportation**|
|31|**Utility Creation and Distribution**|
|32|**Vehicle Retail**|
|33|**Wholesale**|

### <a name="BKMK_InitialCommunication"></a> InitialCommunication

|Property|Value|
|---|---|
|Description|**Choose whether someone from the sales team contacted this lead earlier.**|
|DisplayName|**Initial Communication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`initialcommunication`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`initialcommunication`|

#### InitialCommunication Choices/Options

|Value|Label|
|---|---|
|0|**Contacted**|
|1|**Not Contacted**|

### <a name="BKMK_JobTitle"></a> JobTitle

|Property|Value|
|---|---|
|Description|**Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.**|
|DisplayName|**Job Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`jobtitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_LastName"></a> LastName

|Property|Value|
|---|---|
|Description|**Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.**|
|DisplayName|**Last Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date and time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LastUsedInCampaign"></a> LastUsedInCampaign

|Property|Value|
|---|---|
|Description|**Shows the date when the lead was last included in a marketing campaign or quick campaign.**|
|DisplayName|**Last Campaign Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastusedincampaign`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LeadId"></a> LeadId

|Property|Value|
|---|---|
|Description|**Unique identifier of the lead.**|
|DisplayName|**Lead**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`leadid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_LeadQualityCode"></a> LeadQualityCode

|Property|Value|
|---|---|
|Description|**Select a rating value to indicate the lead's potential to become a customer.**|
|DisplayName|**Rating**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`leadqualitycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`lead_leadqualitycode`|

#### LeadQualityCode Choices/Options

|Value|Label|
|---|---|
|1|**Hot**|
|2|**Warm**|
|3|**Cold**|

### <a name="BKMK_LeadSourceCode"></a> LeadSourceCode

|Property|Value|
|---|---|
|Description|**Select the primary marketing source that prompted the lead to contact you.**|
|DisplayName|**Lead Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`leadsourcecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`lead_leadsourcecode`|

#### LeadSourceCode Choices/Options

|Value|Label|
|---|---|
|1|**Advertisement**|
|2|**Employee Referral**|
|3|**External Referral**|
|4|**Partner**|
|5|**Public Relations**|
|6|**Seminar**|
|7|**Trade Show**|
|8|**Web**|
|9|**Word of Mouth**|
|10|**Other**|

### <a name="BKMK_MiddleName"></a> MiddleName

|Property|Value|
|---|---|
|Description|**Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.**|
|DisplayName|**Middle Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`middlename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_MobilePhone"></a> MobilePhone

|Property|Value|
|---|---|
|Description|**Type the mobile phone number for the primary contact for the lead.**|
|DisplayName|**Mobile Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`mobilephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether lead is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_lead_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LeadGrade"></a> msdyn_LeadGrade

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Lead Grade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadgrade`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_leadgradeoptset`|

#### msdyn_LeadGrade Choices/Options

|Value|Label|
|---|---|
|0|**Grade A**|
|1|**Grade B**|
|2|**Grade C**|
|3|**Grade D**|

### <a name="BKMK_msdyn_leadkpiid"></a> msdyn_leadkpiid

|Property|Value|
|---|---|
|Description|**LeadKPIId**|
|DisplayName|**KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadkpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_leadkpiitem|

### <a name="BKMK_msdyn_LeadScore"></a> msdyn_LeadScore

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Lead Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_LeadScoreTrend"></a> msdyn_LeadScoreTrend

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Lead Score Trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadscoretrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_leadscoretrendoptset`|

#### msdyn_LeadScoreTrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|

### <a name="BKMK_msdyn_PredictiveScoreId"></a> msdyn_PredictiveScoreId

|Property|Value|
|---|---|
|Description|**Predictive score**|
|DisplayName|**Predictive Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictivescoreid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_predictivescore|

### <a name="BKMK_msdyn_salesassignmentresult"></a> msdyn_salesassignmentresult

|Property|Value|
|---|---|
|Description|**Result of the assignment rule process**|
|DisplayName|**Assignment Rule Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesassignmentresult`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_lead_msdyn_salesassignmentresult`|

#### msdyn_salesassignmentresult Choices/Options

|Value|Label|
|---|---|
|0|**Succeeded**|
|1|**Failed**|

### <a name="BKMK_msdyn_ScoreHistory"></a> msdyn_ScoreHistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Score History**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ScoreReasons"></a> msdyn_ScoreReasons

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Score Reasons**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorereasons`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with Lead.**|
|DisplayName|**Segment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_Need"></a> Need

|Property|Value|
|---|---|
|Description|**Choose how high the level of need is for the lead's company.**|
|DisplayName|**Need**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`need`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`need`|

#### Need Choices/Options

|Value|Label|
|---|---|
|0|**Must have**|
|1|**Should have**|
|2|**Good to have**|
|3|**No need**|

### <a name="BKMK_NumberOfEmployees"></a> NumberOfEmployees

|Property|Value|
|---|---|
|Description|**Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.**|
|DisplayName|**No. of Employees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`numberofemployees`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000|
|MinValue|0|

### <a name="BKMK_OriginatingCaseId"></a> OriginatingCaseId

|Property|Value|
|---|---|
|Description|**This attribute is used for Sample Service Business Processes.**|
|DisplayName|**Originating Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingcaseid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

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

### <a name="BKMK_Pager"></a> Pager

|Property|Value|
|---|---|
|Description|**Type the pager number for the primary contact for the lead.**|
|DisplayName|**Pager**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pager`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_ParentAccountId"></a> ParentAccountId

|Property|Value|
|---|---|
|Description|**Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.**|
|DisplayName|**Parent Account for lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_ParentContactId"></a> ParentContactId

|Property|Value|
|---|---|
|Description|**Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.**|
|DisplayName|**Parent Contact for lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentcontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

|Property|Value|
|---|---|
|Description|**Shows whether the lead participates in workflow rules.**|
|DisplayName|**Participates in Workflow**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`participatesinworkflow`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_participatesinworkflow`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_PreferredContactMethodCode"></a> PreferredContactMethodCode

|Property|Value|
|---|---|
|Description|**Select the preferred method of contact.**|
|DisplayName|**Preferred Method of Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`preferredcontactmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_preferredcontactmethodcode`|

#### PreferredContactMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Any**|
|2|**Email**|
|3|**Phone**|
|4|**Fax**|
|5|**Mail**|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_PurchaseProcess"></a> PurchaseProcess

|Property|Value|
|---|---|
|Description|**Choose whether an individual or a committee will be involved in the  purchase process for the lead.**|
|DisplayName|**Purchase Process**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`purchaseprocess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`purchaseprocess`|

#### PurchaseProcess Choices/Options

|Value|Label|
|---|---|
|0|**Individual**|
|1|**Committee**|
|2|**Unknown**|

### <a name="BKMK_PurchaseTimeFrame"></a> PurchaseTimeFrame

|Property|Value|
|---|---|
|Description|**Choose how long the lead will likely take to make the purchase, so the sales team will be aware.**|
|DisplayName|**Purchase Timeframe**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`purchasetimeframe`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`purchasetimeframe`|

#### PurchaseTimeFrame Choices/Options

|Value|Label|
|---|---|
|0|**Immediate**|
|1|**This Quarter**|
|2|**Next Quarter**|
|3|**This Year**|
|4|**Unknown**|

### <a name="BKMK_QualificationComments"></a> QualificationComments

|Property|Value|
|---|---|
|Description|**Type comments about the qualification or scoring of the lead.**|
|DisplayName|**Qualification Comments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`qualificationcomments`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_QualifyingOpportunityId"></a> QualifyingOpportunityId

|Property|Value|
|---|---|
|Description|**Choose the opportunity that the lead was qualified on and then converted to.**|
|DisplayName|**Qualifying Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`qualifyingopportunityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_RelatedObjectId"></a> RelatedObjectId

|Property|Value|
|---|---|
|Description|**Related Campaign Response.**|
|DisplayName|**Related Campaign Response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`relatedobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|campaignresponse|

### <a name="BKMK_Revenue"></a> Revenue

|Property|Value|
|---|---|
|Description|**Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.**|
|DisplayName|**Annual Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`revenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_SalesStage"></a> SalesStage

|Property|Value|
|---|---|
|Description|**Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.**|
|DisplayName|**Sales Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesstage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`lead_salesstage`|

#### SalesStage Choices/Options

|Value|Label|
|---|---|
|0|**Qualify**|

### <a name="BKMK_SalesStageCode"></a> SalesStageCode

|Property|Value|
|---|---|
|Description|**Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.**|
|DisplayName|**Sales Stage Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesstagecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`lead_salesstagecode`|

#### SalesStageCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Salutation"></a> Salutation

|Property|Value|
|---|---|
|Description|**Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.**|
|DisplayName|**Salutation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salutation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ScheduleFollowUp_Prospect"></a> ScheduleFollowUp_Prospect

|Property|Value|
|---|---|
|Description|**Enter the date and time of the prospecting follow-up meeting with the lead.**|
|DisplayName|**Schedule Follow Up (Prospect)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`schedulefollowup_prospect`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduleFollowUp_Qualify"></a> ScheduleFollowUp_Qualify

|Property|Value|
|---|---|
|Description|**Enter the date and time of the qualifying follow-up meeting with the lead.**|
|DisplayName|**Schedule Follow Up (Qualify)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`schedulefollowup_qualify`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SIC"></a> SIC

|Property|Value|
|---|---|
|Description|**Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.**|
|DisplayName|**SIC Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sic`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the Lead record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`lead_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Qualified**<br />DefaultStatus: 3<br />InvariantName: `Qualified`|
|2|Label: **Disqualified**<br />DefaultStatus: 4<br />InvariantName: `Disqualified`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the lead's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`lead_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **New**<br />State:0<br />TransitionData: None|
|2|Label: **Contacted**<br />State:0<br />TransitionData: None|
|3|Label: **Qualified**<br />State:1<br />TransitionData: None|
|4|Label: **Lost**<br />State:2<br />TransitionData: None|
|5|Label: **Cannot Contact**<br />State:2<br />TransitionData: None|
|6|Label: **No Longer Interested**<br />State:2<br />TransitionData: None|
|7|Label: **Canceled**<br />State:2<br />TransitionData: None|

### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|---|---|
|Description|**Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.**|
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

|Property|Value|
|---|---|
|Description|**Number of users or conversations followed the record**|
|DisplayName|**TeamsFollowed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`teamsfollowed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|---|---|
|Description|**Type the work phone number for the primary contact for the lead.**|
|DisplayName|**Business Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone2"></a> Telephone2

|Property|Value|
|---|---|
|Description|**Type the home phone number for the primary contact for the lead.**|
|DisplayName|**Home Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone3"></a> Telephone3

|Property|Value|
|---|---|
|Description|**Type an alternate phone number for the primary contact for the lead.**|
|DisplayName|**Other Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Inactive|
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
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

### <a name="BKMK_WebSiteUrl"></a> WebSiteUrl

|Property|Value|
|---|---|
|Description|**Type the website URL for the company associated with this lead.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`websiteurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_YomiCompanyName"></a> YomiCompanyName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.**|
|DisplayName|**Yomi Company Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomicompanyname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_YomiFirstName"></a> YomiFirstName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.**|
|DisplayName|**Yomi First Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomifirstname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_YomiLastName"></a> YomiLastName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.**|
|DisplayName|**Yomi Last Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomilastname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_YomiMiddleName"></a> YomiMiddleName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.**|
|DisplayName|**Yomi Middle Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomimiddlename`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|150|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [Address1_Composite](#BKMK_Address1_Composite)
- [Address2_Composite](#BKMK_Address2_Composite)
- [BudgetAmount_Base](#BKMK_BudgetAmount_Base)
- [ContactId](#BKMK_ContactId)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
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
- [Merged](#BKMK_Merged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [Revenue_Base](#BKMK_Revenue_Base)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [VersionNumber](#BKMK_VersionNumber)
- [YomiFullName](#BKMK_YomiFullName)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the account with which the lead is associated.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_Address1_Composite"></a> Address1_Composite

|Property|Value|
|---|---|
|Description|**Shows the complete primary address.**|
|DisplayName|**Address 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_Address2_Composite"></a> Address2_Composite

|Property|Value|
|---|---|
|Description|**Shows the complete secondary address.**|
|DisplayName|**Address 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_BudgetAmount_Base"></a> BudgetAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Budget Amount in base currency.**|
|DisplayName|**Budget Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contact with which the lead is associated.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
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
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridyominame`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_EstimatedAmount_Base"></a> EstimatedAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Est. Value in base currency.**|
|DisplayName|**Est. Value (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
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

### <a name="BKMK_FullName"></a> FullName

|Property|Value|
|---|---|
|Description|**Combines and shows the lead's first and last names so the full name can be displayed in views and reports.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`fullname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_IsAutoCreate"></a> IsAutoCreate

|Property|Value|
|---|---|
|Description|**Information about whether the contact was auto-created when promoting an email or an appointment.**|
|DisplayName|**Auto-created**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`isautocreate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_isautocreate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|---|---|
|Description|**Indicates whether the lead is private or visible to the entire organization.**|
|DisplayName|**Is Private**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`isprivate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_isprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_MasterId"></a> MasterId

|Property|Value|
|---|---|
|Description|**Unique identifier of the master lead for merge.**|
|DisplayName|**Master ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`masterid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_Merged"></a> Merged

|Property|Value|
|---|---|
|Description|**Tells whether the lead has been merged with another lead.**|
|DisplayName|**Merged**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`merged`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`lead_merged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows how long, in minutes, that the record was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
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
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
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

### <a name="BKMK_Revenue_Base"></a> Revenue_Base

|Property|Value|
|---|---|
|Description|**Value of the Annual Revenue in base currency.**|
|DisplayName|**Annual Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`revenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this case. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

|Property|Value|
|---|---|
|Description|**Total time spent for emails (read and write) and meetings by me in relation to the lead record.**|
|DisplayName|**Time Spent by me**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timespentbymeonemailandmeetings`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

### <a name="BKMK_YomiFullName"></a> YomiFullName

|Property|Value|
|---|---|
|Description|**Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.**|
|DisplayName|**Yomi Full Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomifullname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|450|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_leads](#BKMK_business_unit_leads)
- [campaign_leads](#BKMK_campaign_leads)
- [CampaignResponse_Lead](#BKMK_CampaignResponse_Lead)
- [lead_customer_accounts](#BKMK_lead_customer_accounts)
- [lead_customer_contacts](#BKMK_lead_customer_contacts)
- [lead_master_lead](#BKMK_lead_master_lead-many-to-one)
- [lead_owning_team](#BKMK_lead_owning_team)
- [lead_owning_user](#BKMK_lead_owning_user)
- [lead_parent_account](#BKMK_lead_parent_account)
- [lead_parent_contact](#BKMK_lead_parent_contact)
- [lead_qualifying_opportunity](#BKMK_lead_qualifying_opportunity)
- [lk_lead_createdonbehalfby](#BKMK_lk_lead_createdonbehalfby)
- [lk_lead_modifiedonbehalfby](#BKMK_lk_lead_modifiedonbehalfby)
- [lk_leadbase_createdby](#BKMK_lk_leadbase_createdby)
- [lk_leadbase_modifiedby](#BKMK_lk_leadbase_modifiedby)
- [manualsla_lead](#BKMK_manualsla_lead)
- [msdyn_msdyn_leadkpiitem_lead_leadkpiid](#BKMK_msdyn_msdyn_leadkpiitem_lead_leadkpiid)
- [msdyn_msdyn_predictivescore_lead](#BKMK_msdyn_msdyn_predictivescore_lead)
- [msdyn_msdyn_segment_lead](#BKMK_msdyn_msdyn_segment_lead)
- [OriginatingCase_Lead](#BKMK_OriginatingCase_Lead)
- [owner_leads](#BKMK_owner_leads)
- [processstage_lead](#BKMK_processstage_lead)
- [sla_lead](#BKMK_sla_lead)
- [transactioncurrency_lead](#BKMK_transactioncurrency_lead)

### <a name="BKMK_business_unit_leads"></a> business_unit_leads

One-To-Many Relationship: [businessunit business_unit_leads](businessunit.md#BKMK_business_unit_leads)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_leads"></a> campaign_leads

One-To-Many Relationship: [campaign campaign_leads](campaign.md#BKMK_campaign_leads)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`campaignid`|
|ReferencingEntityNavigationPropertyName|`campaignid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_Lead"></a> CampaignResponse_Lead

One-To-Many Relationship: [campaignresponse CampaignResponse_Lead](campaignresponse.md#BKMK_CampaignResponse_Lead)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`relatedobjectid`|
|ReferencingEntityNavigationPropertyName|`relatedobjectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_customer_accounts"></a> lead_customer_accounts

One-To-Many Relationship: [account lead_customer_accounts](account.md#BKMK_lead_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lead_customer_contacts"></a> lead_customer_contacts

One-To-Many Relationship: [contact lead_customer_contacts](contact.md#BKMK_lead_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lead_master_lead-many-to-one"></a> lead_master_lead

One-To-Many Relationship: [lead lead_master_lead](#BKMK_lead_master_lead-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`masterid`|
|ReferencingEntityNavigationPropertyName|`masterid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_owning_team"></a> lead_owning_team

One-To-Many Relationship: [team lead_owning_team](team.md#BKMK_lead_owning_team)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_owning_user"></a> lead_owning_user

One-To-Many Relationship: [systemuser lead_owning_user](systemuser.md#BKMK_lead_owning_user)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_parent_account"></a> lead_parent_account

One-To-Many Relationship: [account lead_parent_account](account.md#BKMK_lead_parent_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`parentaccountid`|
|ReferencingEntityNavigationPropertyName|`parentaccountid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_parent_contact"></a> lead_parent_contact

One-To-Many Relationship: [contact lead_parent_contact](contact.md#BKMK_lead_parent_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`parentcontactid`|
|ReferencingEntityNavigationPropertyName|`parentcontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_qualifying_opportunity"></a> lead_qualifying_opportunity

One-To-Many Relationship: [opportunity lead_qualifying_opportunity](opportunity.md#BKMK_lead_qualifying_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`qualifyingopportunityid`|
|ReferencingEntityNavigationPropertyName|`qualifyingopportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_lead_createdonbehalfby"></a> lk_lead_createdonbehalfby

One-To-Many Relationship: [systemuser lk_lead_createdonbehalfby](systemuser.md#BKMK_lk_lead_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_lead_modifiedonbehalfby"></a> lk_lead_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_lead_modifiedonbehalfby](systemuser.md#BKMK_lk_lead_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadbase_createdby"></a> lk_leadbase_createdby

One-To-Many Relationship: [systemuser lk_leadbase_createdby](systemuser.md#BKMK_lk_leadbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadbase_modifiedby"></a> lk_leadbase_modifiedby

One-To-Many Relationship: [systemuser lk_leadbase_modifiedby](systemuser.md#BKMK_lk_leadbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_lead"></a> manualsla_lead

One-To-Many Relationship: [sla manualsla_lead](sla.md#BKMK_manualsla_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_lead_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_leadkpiitem_lead_leadkpiid"></a> msdyn_msdyn_leadkpiitem_lead_leadkpiid

One-To-Many Relationship: [msdyn_leadkpiitem msdyn_msdyn_leadkpiitem_lead_leadkpiid](msdyn_leadkpiitem.md#BKMK_msdyn_msdyn_leadkpiitem_lead_leadkpiid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_leadkpiitem`|
|ReferencedAttribute|`msdyn_leadkpiitemid`|
|ReferencingAttribute|`msdyn_leadkpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_leadkpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_predictivescore_lead"></a> msdyn_msdyn_predictivescore_lead

One-To-Many Relationship: [msdyn_predictivescore msdyn_msdyn_predictivescore_lead](msdyn_predictivescore.md#BKMK_msdyn_msdyn_predictivescore_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictivescore`|
|ReferencedAttribute|`msdyn_predictivescoreid`|
|ReferencingAttribute|`msdyn_predictivescoreid`|
|ReferencingEntityNavigationPropertyName|`msdyn_PredictiveScoreId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_lead"></a> msdyn_msdyn_segment_lead

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_lead](msdyn_segment.md#BKMK_msdyn_msdyn_segment_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_segmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_OriginatingCase_Lead"></a> OriginatingCase_Lead

One-To-Many Relationship: [incident OriginatingCase_Lead](incident.md#BKMK_OriginatingCase_Lead)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`originatingcaseid`|
|ReferencingEntityNavigationPropertyName|`originatingcaseid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_leads"></a> owner_leads

One-To-Many Relationship: [owner owner_leads](owner.md#BKMK_owner_leads)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_lead"></a> processstage_lead

One-To-Many Relationship: [processstage processstage_lead](processstage.md#BKMK_processstage_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_lead"></a> sla_lead

One-To-Many Relationship: [sla sla_lead](sla.md#BKMK_sla_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_lead_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

One-To-Many Relationship: [transactioncurrency transactioncurrency_lead](transactioncurrency.md#BKMK_transactioncurrency_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [account_originating_lead](#BKMK_account_originating_lead)
- [contact_originating_lead](#BKMK_contact_originating_lead)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [Lead_actioncard](#BKMK_Lead_actioncard)
- [lead_activity_parties](#BKMK_lead_activity_parties)
- [Lead_ActivityPointers](#BKMK_Lead_ActivityPointers)
- [lead_addresses](#BKMK_lead_addresses)
- [lead_adx_inviteredemptions](#BKMK_lead_adx_inviteredemptions)
- [lead_adx_portalcomments](#BKMK_lead_adx_portalcomments)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [Lead_Appointments](#BKMK_Lead_Appointments)
- [Lead_AsyncOperations](#BKMK_Lead_AsyncOperations)
- [Lead_BulkDeleteFailures](#BKMK_Lead_BulkDeleteFailures)
- [lead_BulkOperations](#BKMK_lead_BulkOperations)
- [lead_CampaignResponses](#BKMK_lead_CampaignResponses)
- [lead_chats](#BKMK_lead_chats)
- [lead_connections1](#BKMK_lead_connections1)
- [lead_connections2](#BKMK_lead_connections2)
- [Lead_DuplicateBaseRecord](#BKMK_Lead_DuplicateBaseRecord)
- [Lead_DuplicateMatchingRecord](#BKMK_Lead_DuplicateMatchingRecord)
- [Lead_Email_EmailSender](#BKMK_Lead_Email_EmailSender)
- [Lead_Emails](#BKMK_Lead_Emails)
- [Lead_Faxes](#BKMK_Lead_Faxes)
- [lead_IncidentResolutions](#BKMK_lead_IncidentResolutions)
- [Lead_Letters](#BKMK_Lead_Letters)
- [Lead_MailboxTrackingFolder](#BKMK_Lead_MailboxTrackingFolder)
- [lead_master_lead](#BKMK_lead_master_lead-one-to-many)
- [lead_msdyn_copilottranscripts](#BKMK_lead_msdyn_copilottranscripts)
- [lead_msdyn_ocliveworkitems](#BKMK_lead_msdyn_ocliveworkitems)
- [lead_msdyn_ocsessions](#BKMK_lead_msdyn_ocsessions)
- [lead_msfp_alerts](#BKMK_lead_msfp_alerts)
- [lead_msfp_surveyinvites](#BKMK_lead_msfp_surveyinvites)
- [lead_msfp_surveyresponses](#BKMK_lead_msfp_surveyresponses)
- [lead_OpportunityCloses](#BKMK_lead_OpportunityCloses)
- [lead_OrderCloses](#BKMK_lead_OrderCloses)
- [Lead_Phonecalls](#BKMK_Lead_Phonecalls)
- [lead_PostFollows](#BKMK_lead_PostFollows)
- [lead_PostRegardings](#BKMK_lead_PostRegardings)
- [lead_Posts](#BKMK_lead_Posts)
- [lead_principalobjectattributeaccess](#BKMK_lead_principalobjectattributeaccess)
- [Lead_ProcessSessions](#BKMK_Lead_ProcessSessions)
- [lead_QuoteCloses](#BKMK_lead_QuoteCloses)
- [Lead_RecurringAppointmentMasters](#BKMK_Lead_RecurringAppointmentMasters)
- [Lead_ServiceAppointments](#BKMK_Lead_ServiceAppointments)
- [Lead_SharepointDocumentLocation](#BKMK_Lead_SharepointDocumentLocation)
- [Lead_SocialActivities](#BKMK_Lead_SocialActivities)
- [Lead_SyncErrors](#BKMK_Lead_SyncErrors)
- [Lead_Tasks](#BKMK_Lead_Tasks)
- [lk_leadtoopportunitysalesprocess_leadid](#BKMK_lk_leadtoopportunitysalesprocess_leadid)
- [msdyn_lead_dailyleadkpiitem_entityid](#BKMK_msdyn_lead_dailyleadkpiitem_entityid)
- [msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid](#BKMK_msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid)
- [msdyn_lead_msdyn_duplicateleadmapping](#BKMK_msdyn_lead_msdyn_duplicateleadmapping)
- [msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord](#BKMK_msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord)
- [msdyn_lead_msdyn_leadkpiitem_leadid](#BKMK_msdyn_lead_msdyn_leadkpiitem_leadid)
- [msdyn_lead_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId)
- [msdyn_lead_msdyn_mostcontactedby_regardingObjectId](#BKMK_msdyn_lead_msdyn_mostcontactedby_regardingObjectId)
- [msdyn_lead_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject)
- [msdyn_lead_msdyn_timespent_leadlookup](#BKMK_msdyn_lead_msdyn_timespent_leadlookup)
- [msdyn_linkeditemvalidity_polymorphic_leadid](#BKMK_msdyn_linkeditemvalidity_polymorphic_leadid)
- [msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid)
- [msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid](#BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid)
- [msdyn_sabackupdiagnostic_lead_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target)
- [msdyn_salesroutingdiagnostic_lead_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target)
- [msdyn_sequencetarget_lead_msdyn_target](#BKMK_msdyn_sequencetarget_lead_msdyn_target)
- [opportunity_originating_lead](#BKMK_opportunity_originating_lead)
- [slakpiinstance_lead](#BKMK_slakpiinstance_lead)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)

### <a name="BKMK_account_originating_lead"></a> account_originating_lead

Many-To-One Relationship: [account account_originating_lead](account.md#BKMK_account_originating_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`originatingleadid`|
|ReferencedEntityNavigationPropertyName|`account_originating_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_originating_lead"></a> contact_originating_lead

Many-To-One Relationship: [contact contact_originating_lead](contact.md#BKMK_contact_originating_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`originatingleadid`|
|ReferencedEntityNavigationPropertyName|`contact_originating_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog CreatedLead_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedLead_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`createdobjectid`|
|ReferencedEntityNavigationPropertyName|`CreatedLead_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_actioncard"></a> Lead_actioncard

Many-To-One Relationship: [actioncard Lead_actioncard](actioncard.md#BKMK_Lead_actioncard)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_actioncard`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_activity_parties"></a> lead_activity_parties

Many-To-One Relationship: [activityparty lead_activity_parties](activityparty.md#BKMK_lead_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`lead_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_ActivityPointers"></a> Lead_ActivityPointers

Many-To-One Relationship: [activitypointer Lead_ActivityPointers](activitypointer.md#BKMK_Lead_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_addresses"></a> lead_addresses

Many-To-One Relationship: [leadaddress lead_addresses](leadaddress.md#BKMK_lead_addresses)

|Property|Value|
|---|---|
|ReferencingEntity|`leadaddress`|
|ReferencingAttribute|`parentid`|
|ReferencedEntityNavigationPropertyName|`lead_addresses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_adx_inviteredemptions"></a> lead_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption lead_adx_inviteredemptions](adx_inviteredemption.md#BKMK_lead_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_adx_portalcomments"></a> lead_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment lead_adx_portalcomments](adx_portalcomment.md#BKMK_lead_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

Many-To-One Relationship: [annotation Lead_Annotation](annotation.md#BKMK_Lead_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Appointments"></a> Lead_Appointments

Many-To-One Relationship: [appointment Lead_Appointments](appointment.md#BKMK_Lead_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_AsyncOperations"></a> Lead_AsyncOperations

Many-To-One Relationship: [asyncoperation Lead_AsyncOperations](asyncoperation.md#BKMK_Lead_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_BulkDeleteFailures"></a> Lead_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Lead_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Lead_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_BulkOperations"></a> lead_BulkOperations

Many-To-One Relationship: [bulkoperation lead_BulkOperations](bulkoperation.md#BKMK_lead_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_CampaignResponses"></a> lead_CampaignResponses

Many-To-One Relationship: [campaignresponse lead_CampaignResponses](campaignresponse.md#BKMK_lead_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_chats"></a> lead_chats

Many-To-One Relationship: [chat lead_chats](chat.md#BKMK_lead_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_connections1"></a> lead_connections1

Many-To-One Relationship: [connection lead_connections1](connection.md#BKMK_lead_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`lead_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_connections2"></a> lead_connections2

Many-To-One Relationship: [connection lead_connections2](connection.md#BKMK_lead_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`lead_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_DuplicateBaseRecord"></a> Lead_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Lead_DuplicateBaseRecord](duplicaterecord.md#BKMK_Lead_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Lead_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_DuplicateMatchingRecord"></a> Lead_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Lead_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Lead_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Lead_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Email_EmailSender"></a> Lead_Email_EmailSender

Many-To-One Relationship: [email Lead_Email_EmailSender](email.md#BKMK_Lead_Email_EmailSender)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`emailsender`|
|ReferencedEntityNavigationPropertyName|`Lead_Email_EmailSender`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Emails"></a> Lead_Emails

Many-To-One Relationship: [email Lead_Emails](email.md#BKMK_Lead_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Faxes"></a> Lead_Faxes

Many-To-One Relationship: [fax Lead_Faxes](fax.md#BKMK_Lead_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_IncidentResolutions"></a> lead_IncidentResolutions

Many-To-One Relationship: [incidentresolution lead_IncidentResolutions](incidentresolution.md#BKMK_lead_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Lead_Letters"></a> Lead_Letters

Many-To-One Relationship: [letter Lead_Letters](letter.md#BKMK_Lead_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_MailboxTrackingFolder"></a> Lead_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Lead_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Lead_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_master_lead-one-to-many"></a> lead_master_lead

Many-To-One Relationship: [lead lead_master_lead](#BKMK_lead_master_lead-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`masterid`|
|ReferencedEntityNavigationPropertyName|`lead_master_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_msdyn_copilottranscripts"></a> lead_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript lead_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_lead_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_msdyn_ocliveworkitems"></a> lead_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem lead_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_lead_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_msdyn_ocsessions"></a> lead_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession lead_msdyn_ocsessions](msdyn_ocsession.md#BKMK_lead_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_msfp_alerts"></a> lead_msfp_alerts

Many-To-One Relationship: [msfp_alert lead_msfp_alerts](msfp_alert.md#BKMK_lead_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_msfp_surveyinvites"></a> lead_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite lead_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_lead_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_msfp_surveyresponses"></a> lead_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse lead_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_lead_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_OpportunityCloses"></a> lead_OpportunityCloses

Many-To-One Relationship: [opportunityclose lead_OpportunityCloses](opportunityclose.md#BKMK_lead_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_lead_OrderCloses"></a> lead_OrderCloses

Many-To-One Relationship: [orderclose lead_OrderCloses](orderclose.md#BKMK_lead_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Lead_Phonecalls"></a> Lead_Phonecalls

Many-To-One Relationship: [phonecall Lead_Phonecalls](phonecall.md#BKMK_Lead_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_PostFollows"></a> lead_PostFollows

Many-To-One Relationship: [postfollow lead_PostFollows](postfollow.md#BKMK_lead_PostFollows)

|Property|Value|
|---|---|
|ReferencingEntity|`postfollow`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_PostFollows`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_PostRegardings"></a> lead_PostRegardings

Many-To-One Relationship: [postregarding lead_PostRegardings](postregarding.md#BKMK_lead_PostRegardings)

|Property|Value|
|---|---|
|ReferencingEntity|`postregarding`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_PostRegardings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_Posts"></a> lead_Posts

Many-To-One Relationship: [post lead_Posts](post.md#BKMK_lead_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_principalobjectattributeaccess"></a> lead_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess lead_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_lead_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`lead_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_ProcessSessions"></a> Lead_ProcessSessions

Many-To-One Relationship: [processsession Lead_ProcessSessions](processsession.md#BKMK_Lead_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_QuoteCloses"></a> lead_QuoteCloses

Many-To-One Relationship: [quoteclose lead_QuoteCloses](quoteclose.md#BKMK_lead_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Lead_RecurringAppointmentMasters"></a> Lead_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Lead_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Lead_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_ServiceAppointments"></a> Lead_ServiceAppointments

Many-To-One Relationship: [serviceappointment Lead_ServiceAppointments](serviceappointment.md#BKMK_Lead_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Lead_SharepointDocumentLocation"></a> Lead_SharepointDocumentLocation

Many-To-One Relationship: [sharepointdocumentlocation Lead_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Lead_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_SharepointDocumentLocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_SocialActivities"></a> Lead_SocialActivities

Many-To-One Relationship: [socialactivity Lead_SocialActivities](socialactivity.md#BKMK_Lead_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_SyncErrors"></a> Lead_SyncErrors

Many-To-One Relationship: [syncerror Lead_SyncErrors](syncerror.md#BKMK_Lead_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Lead_Tasks"></a> Lead_Tasks

Many-To-One Relationship: [task Lead_Tasks](task.md#BKMK_Lead_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Lead_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_leadid"></a> lk_leadtoopportunitysalesprocess_leadid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_leadid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_leadid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`leadid`|
|ReferencedEntityNavigationPropertyName|`lead_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_dailyleadkpiitem_entityid"></a> msdyn_lead_dailyleadkpiitem_entityid

Many-To-One Relationship: [msdyn_dailyleadkpiitem msdyn_lead_dailyleadkpiitem_entityid](msdyn_dailyleadkpiitem.md#BKMK_msdyn_lead_dailyleadkpiitem_entityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyleadkpiitem`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_dailyleadkpiitem_entityid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid"></a> msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid

Many-To-One Relationship: [msdyn_duplicatedetectionpluginrun msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid](msdyn_duplicatedetectionpluginrun.md#BKMK_msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicatedetectionpluginrun`|
|ReferencingAttribute|`msdyn_baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_duplicatedetectionpluginrun_baserecordid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_duplicateleadmapping"></a> msdyn_lead_msdyn_duplicateleadmapping

Many-To-One Relationship: [msdyn_duplicateleadmapping msdyn_lead_msdyn_duplicateleadmapping](msdyn_duplicateleadmapping.md#BKMK_msdyn_lead_msdyn_duplicateleadmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicateleadmapping`|
|ReferencingAttribute|`msdyn_duplicateleadrecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_duplicateleadmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord"></a> msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord

Many-To-One Relationship: [msdyn_duplicateleadmapping msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord](msdyn_duplicateleadmapping.md#BKMK_msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicateleadmapping`|
|ReferencingAttribute|`msdyn_baseleadrecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_duplicateleadmapping_BaseLeadRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_leadkpiitem_leadid"></a> msdyn_lead_msdyn_leadkpiitem_leadid

Many-To-One Relationship: [msdyn_leadkpiitem msdyn_lead_msdyn_leadkpiitem_leadid](msdyn_leadkpiitem.md#BKMK_msdyn_lead_msdyn_leadkpiitem_leadid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadkpiitem`|
|ReferencingAttribute|`msdyn_leadid`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_leadkpiitem_leadid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId"></a> msdyn_lead_msdyn_mostcontacted_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontacted msdyn_lead_msdyn_mostcontacted_regardingObjectId](msdyn_mostcontacted.md#BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontacted`|
|ReferencingAttribute|`msdyn_lead_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_mostcontacted_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_mostcontactedby_regardingObjectId"></a> msdyn_lead_msdyn_mostcontactedby_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontactedby msdyn_lead_msdyn_mostcontactedby_regardingObjectId](msdyn_mostcontactedby.md#BKMK_msdyn_lead_msdyn_mostcontactedby_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontactedby`|
|ReferencingAttribute|`msdyn_lead_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_mostcontactedby_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject"></a> msdyn_lead_msdyn_salesroutingrun_targetobject

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_lead_msdyn_salesroutingrun_targetobject](msdyn_salesroutingrun.md#BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_salesroutingrun_targetobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_lead_msdyn_timespent_leadlookup"></a> msdyn_lead_msdyn_timespent_leadlookup

Many-To-One Relationship: [msdyn_timespent msdyn_lead_msdyn_timespent_leadlookup](msdyn_timespent.md#BKMK_msdyn_lead_msdyn_timespent_leadlookup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`msdyn_leadlookup`|
|ReferencedEntityNavigationPropertyName|`msdyn_lead_msdyn_timespent_leadlookup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkeditemvalidity_polymorphic_leadid"></a> msdyn_linkeditemvalidity_polymorphic_leadid

Many-To-One Relationship: [msdyn_linkedentityattributevalidity msdyn_linkeditemvalidity_polymorphic_leadid](msdyn_linkedentityattributevalidity.md#BKMK_msdyn_linkeditemvalidity_polymorphic_leadid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_linkedentityattributevalidity`|
|ReferencingAttribute|`msdyn_linkeditemlookup`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkeditemvalidity_polymorphic_leadid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid"></a> msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid

Many-To-One Relationship: [msdyn_taggedrecord msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid](msdyn_taggedrecord.md#BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`msdyn_dynamicsrecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target"></a> msdyn_sabackupdiagnostic_lead_msdyn_target

Many-To-One Relationship: [msdyn_sabackupdiagnostic msdyn_sabackupdiagnostic_lead_msdyn_target](msdyn_sabackupdiagnostic.md#BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabackupdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_lead_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target"></a> msdyn_salesroutingdiagnostic_lead_msdyn_target

Many-To-One Relationship: [msdyn_salesroutingdiagnostic msdyn_salesroutingdiagnostic_lead_msdyn_target](msdyn_salesroutingdiagnostic.md#BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_lead_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_lead_msdyn_target"></a> msdyn_sequencetarget_lead_msdyn_target

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequencetarget_lead_msdyn_target](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_lead_msdyn_target`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_originating_lead"></a> opportunity_originating_lead

Many-To-One Relationship: [opportunity opportunity_originating_lead](opportunity.md#BKMK_opportunity_originating_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`originatingleadid`|
|ReferencedEntityNavigationPropertyName|`opportunity_originating_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_lead"></a> slakpiinstance_lead

Many-To-One Relationship: [slakpiinstance slakpiinstance_lead](slakpiinstance.md#BKMK_slakpiinstance_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_lead`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog SourceLead_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceLead_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SourceLead_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [accountleads_association](#BKMK_accountleads_association)
- [BulkOperation_Leads](#BKMK_BulkOperation_Leads)
- [CampaignActivity_Leads](#BKMK_CampaignActivity_Leads)
- [contactleads_association](#BKMK_contactleads_association)
- [leadcompetitors_association](#BKMK_leadcompetitors_association)
- [leadproduct_association](#BKMK_leadproduct_association)
- [listlead_association](#BKMK_listlead_association)

### <a name="BKMK_accountleads_association"></a> accountleads_association

See [account accountleads_association Many-To-Many Relationship](account.md#BKMK_accountleads_association)

|Property|Value|
|---|---|
|IntersectEntityName|`accountleads`|
|IsCustomizable|False|
|SchemaName|`accountleads_association`|
|IntersectAttribute|`accountid`|
|NavigationPropertyName|`accountleads_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BulkOperation_Leads"></a> BulkOperation_Leads

See [bulkoperation BulkOperation_Leads Many-To-Many Relationship](bulkoperation.md#BKMK_BulkOperation_Leads)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Leads`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`BulkOperation_Logs_Leads`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 13<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Leads"></a> CampaignActivity_Leads

See [campaignactivity CampaignActivity_Leads Many-To-Many Relationship](campaignactivity.md#BKMK_CampaignActivity_Leads)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Leads`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`CampaignActivity_Logs_Leads`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 13<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contactleads_association"></a> contactleads_association

See [contact contactleads_association Many-To-Many Relationship](contact.md#BKMK_contactleads_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactleads`|
|IsCustomizable|False|
|SchemaName|`contactleads_association`|
|IntersectAttribute|`leadid`|
|NavigationPropertyName|`contactleads_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadcompetitors_association"></a> leadcompetitors_association

See [competitor leadcompetitors_association Many-To-Many Relationship](competitor.md#BKMK_leadcompetitors_association)

|Property|Value|
|---|---|
|IntersectEntityName|`leadcompetitors`|
|IsCustomizable|False|
|SchemaName|`leadcompetitors_association`|
|IntersectAttribute|`leadid`|
|NavigationPropertyName|`leadcompetitors_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 40<br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_leadproduct_association"></a> leadproduct_association

See [product leadproduct_association Many-To-Many Relationship](product.md#BKMK_leadproduct_association)

|Property|Value|
|---|---|
|IntersectEntityName|`leadproduct`|
|IsCustomizable|False|
|SchemaName|`leadproduct_association`|
|IntersectAttribute|`leadid`|
|NavigationPropertyName|`leadproduct_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_listlead_association"></a> listlead_association

See [list listlead_association Many-To-Many Relationship](list.md#BKMK_listlead_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listlead_association`|
|IntersectAttribute|`entityid`|
|NavigationPropertyName|`listlead_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

