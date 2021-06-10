---
title: "msdyn_workorder Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorder entity."
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
# msdyn_workorder Entity Reference

Work orders store all information about the job performed for an account. Stores incident details, resource, expenses, tasks, communications, billing and more

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorders<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorders<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorders|
|DisplayCollectionName|Work Orders|
|DisplayName|Work Order|
|EntitySetName|msdyn_workorders|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorders|
|LogicalName|msdyn_workorder|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_workorderid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorder|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Address1](#BKMK_msdyn_Address1)
- [msdyn_Address2](#BKMK_msdyn_Address2)
- [msdyn_Address3](#BKMK_msdyn_Address3)
- [msdyn_AddressName](#BKMK_msdyn_AddressName)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_BookingSummary](#BKMK_msdyn_BookingSummary)
- [msdyn_ChildIndex](#BKMK_msdyn_ChildIndex)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_ClosedBy](#BKMK_msdyn_ClosedBy)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_DateWindowEnd](#BKMK_msdyn_DateWindowEnd)
- [msdyn_DateWindowStart](#BKMK_msdyn_DateWindowStart)
- [msdyn_EstimateSubtotalAmount](#BKMK_msdyn_EstimateSubtotalAmount)
- [msdyn_FollowUpNote](#BKMK_msdyn_FollowUpNote)
- [msdyn_FollowUpRequired](#BKMK_msdyn_FollowUpRequired)
- [msdyn_Instructions](#BKMK_msdyn_Instructions)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IoTAlert](#BKMK_msdyn_IoTAlert)
- [msdyn_IsFollowUp](#BKMK_msdyn_IsFollowUp)
- [msdyn_IsMobile](#BKMK_msdyn_IsMobile)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OpportunityId](#BKMK_msdyn_OpportunityId)
- [msdyn_ParentWorkOrder](#BKMK_msdyn_ParentWorkOrder)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_PrimaryIncidentDescription](#BKMK_msdyn_PrimaryIncidentDescription)
- [msdyn_PrimaryIncidentEstimatedDuration](#BKMK_msdyn_PrimaryIncidentEstimatedDuration)
- [msdyn_PrimaryIncidentType](#BKMK_msdyn_PrimaryIncidentType)
- [msdyn_Priority](#BKMK_msdyn_Priority)
- [msdyn_ReportedByContact](#BKMK_msdyn_ReportedByContact)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ServiceRequest](#BKMK_msdyn_ServiceRequest)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SubtotalAmount](#BKMK_msdyn_SubtotalAmount)
- [msdyn_SupportContact](#BKMK_msdyn_SupportContact)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TimeClosed](#BKMK_msdyn_TimeClosed)
- [msdyn_TimeFromPromised](#BKMK_msdyn_TimeFromPromised)
- [msdyn_TimeGroup](#BKMK_msdyn_TimeGroup)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TimeToPromised](#BKMK_msdyn_TimeToPromised)
- [msdyn_TimeWindowEnd](#BKMK_msdyn_TimeWindowEnd)
- [msdyn_TimeWindowStart](#BKMK_msdyn_TimeWindowStart)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_TotalSalesTax](#BKMK_msdyn_TotalSalesTax)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_workorderarrivaltimekpiid](#BKMK_msdyn_workorderarrivaltimekpiid)
- [msdyn_workorderId](#BKMK_msdyn_workorderId)
- [msdyn_workorderresolutionkpiid](#BKMK_msdyn_workorderresolutionkpiid)
- [msdyn_WorkOrderSummary](#BKMK_msdyn_WorkOrderSummary)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Address Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_addressname|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|--------|-----|
|Description|Shows the agreement linked to this work order.|
|DisplayName|Agreement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreement|
|RequiredLevel|None|
|Targets|msdyn_agreement|
|Type|Lookup|


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

|Property|Value|
|--------|-----|
|Description|Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.|
|DisplayName|Billing Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccount|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_BookingSummary"></a> msdyn_BookingSummary

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Booking Summary|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingsummary|
|MaxLength|10000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_ChildIndex"></a> msdyn_ChildIndex

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Child Index|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_childindex|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_City"></a> msdyn_City

|Property|Value|
|--------|-----|
|Description||
|DisplayName|City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ClosedBy"></a> msdyn_ClosedBy

|Property|Value|
|--------|-----|
|Description|The user that last closed this work order|
|DisplayName|Closed By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_closedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_Country"></a> msdyn_Country

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|--------|-----|
|Description|Customer Asset related to this incident reported|
|DisplayName|Primary Incident Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_DateWindowEnd"></a> msdyn_DateWindowEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Date Window End|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_datewindowend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_DateWindowStart"></a> msdyn_DateWindowStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Date Window Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_datewindowstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_EstimateSubtotalAmount"></a> msdyn_EstimateSubtotalAmount

|Property|Value|
|--------|-----|
|Description|Enter the summary of total estimated billing amount for this work order|
|DisplayName|Estimate Subtotal Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatesubtotalamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_FollowUpNote"></a> msdyn_FollowUpNote

|Property|Value|
|--------|-----|
|Description|Indicate the details of the follow up work|
|DisplayName|Follow Up Note (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_followupnote|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_FollowUpRequired"></a> msdyn_FollowUpRequired

|Property|Value|
|--------|-----|
|Description|Allows indication if follow up work is required for a work order.|
|DisplayName|Follow Up Required (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_followuprequired|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_FollowUpRequired Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_Instructions"></a> msdyn_Instructions

|Property|Value|
|--------|-----|
|Description|Shows instructions for booked resources. By default, this information is taken from the work order instructions field on the service account.|
|DisplayName|Instructions|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_instructions|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_IoTAlert"></a> msdyn_IoTAlert

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

|Property|Value|
|--------|-----|
|Description|The iot alert which initiated this work order.|
|DisplayName|IoT Alert|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_iotalert|
|RequiredLevel|None|
|Targets|msdyn_iotalert|
|Type|Lookup|


### <a name="BKMK_msdyn_IsFollowUp"></a> msdyn_IsFollowUp

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is FollowUp (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isfollowup|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsFollowUp Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsMobile"></a> msdyn_IsMobile

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Mobile|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ismobile|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsMobile Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Work Order Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_OpportunityId"></a> msdyn_OpportunityId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Opportunity associated with Work Order.|
|DisplayName|Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityid|
|RequiredLevel|None|
|Targets|opportunity|
|Type|Lookup|


### <a name="BKMK_msdyn_ParentWorkOrder"></a> msdyn_ParentWorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Work Order.|
|DisplayName|Parent Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_parentworkorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

|Property|Value|
|--------|-----|
|Description|The customer Preferred Resource to work on this job. Should be taken into consideration while scheduling resources|
|DisplayName|Preferred Resource (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preferredresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Price List that controls pricing for products / services added to this work order. By default the system will use the Price List specified on the account|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_PrimaryIncidentDescription"></a> msdyn_PrimaryIncidentDescription

|Property|Value|
|--------|-----|
|Description|Incident description|
|DisplayName|Primary Incident Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_primaryincidentdescription|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_PrimaryIncidentEstimatedDuration"></a> msdyn_PrimaryIncidentEstimatedDuration

|Property|Value|
|--------|-----|
|Description|Shows the time estimated to resolve this incident.|
|DisplayName|Primary Incident Estimated Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_primaryincidentestimatedduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_PrimaryIncidentType"></a> msdyn_PrimaryIncidentType

|Property|Value|
|--------|-----|
|Description|Primary incident type reported|
|DisplayName|Primary Incident Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_primaryincidenttype|
|RequiredLevel|None|
|Targets|msdyn_incidenttype|
|Type|Lookup|


### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

|Property|Value|
|--------|-----|
|Description|Priority of the Work Order. To be taken into consideration while scheduling resources|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priority|
|RequiredLevel|None|
|Targets|msdyn_priority|
|Type|Lookup|


### <a name="BKMK_msdyn_ReportedByContact"></a> msdyn_ReportedByContact

|Property|Value|
|--------|-----|
|Description|The contact that reported this Work Order|
|DisplayName|Reported By Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_reportedbycontact|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

|Property|Value|
|--------|-----|
|Description|Account to be serviced|
|DisplayName|Service Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccount|
|RequiredLevel|ApplicationRequired|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_ServiceRequest"></a> msdyn_ServiceRequest

|Property|Value|
|--------|-----|
|Description|Case of which this work order originates from|
|DisplayName|Case|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_servicerequest|
|RequiredLevel|None|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|--------|-----|
|Description|The service territory this work order relates to. By default this will be set to the Service Territory defined on the service account|
|DisplayName|Service Territory|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceterritory|
|RequiredLevel|None|
|Targets|territory|
|Type|Lookup|


### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

|Property|Value|
|--------|-----|
|Description||
|DisplayName|State Or Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|--------|-----|
|Description|Work Order subsstatus|
|DisplayName|Substatus|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_substatus|
|RequiredLevel|Recommended|
|Targets|msdyn_workordersubstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_SubtotalAmount"></a> msdyn_SubtotalAmount

|Property|Value|
|--------|-----|
|Description|Enter the summary of subtotal billing amount excluding tax for this work order.|
|DisplayName|Subtotal Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotalamount|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_SupportContact"></a> msdyn_SupportContact

|Property|Value|
|--------|-----|
|Description|A support contact can be specified so that the individual working on the work order has someone to contact for assistance.|
|DisplayName|Support Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_supportcontact|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|--------|-----|
|Description|Tracks the current system status.|
|DisplayName|System Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_systemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_SystemStatus Options

|Value|Label|
|-----|-----|
|690970000|Open - Unscheduled|
|690970001|Open - Scheduled|
|690970002|Open - In Progress|
|690970003|Open - Completed|
|690970004|Closed - Posted|
|690970005|Closed - Canceled|



### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|--------|-----|
|Description|Shows whether sales tax is to be charged for this work order.|
|DisplayName|Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_Taxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

|Property|Value|
|--------|-----|
|Description|Tax Code to be used to calculate tax when Work Order is taxable. By default the system will use the tax code specified on the service account|
|DisplayName|Sales Tax Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxcode|
|RequiredLevel|None|
|Targets|msdyn_taxcode|
|Type|Lookup|


### <a name="BKMK_msdyn_TimeClosed"></a> msdyn_TimeClosed

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the time this work order was last closed.|
|DisplayName|Closed On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timeclosed|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TimeFromPromised"></a> msdyn_TimeFromPromised

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the starting range of the time promised to the account that incidents will be resolved.|
|DisplayName|Time From Promised|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timefrompromised|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TimeGroup"></a> msdyn_TimeGroup

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Fulfillment Preference|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timegroup|
|RequiredLevel|None|
|Targets|msdyn_timegroup|
|Type|Lookup|


### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Time Group Detail Selected (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timegroupdetailselected|
|RequiredLevel|None|
|Targets|msdyn_timegroupdetail|
|Type|Lookup|


### <a name="BKMK_msdyn_TimeToPromised"></a> msdyn_TimeToPromised

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the ending range of the time promised to the account that incidents will be resolved.|
|DisplayName|Time To Promised|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timetopromised|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Time Window End|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Time Window Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|--------|-----|
|Description|Enter the summary of total billing amount for this work order.|
|DisplayName|Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_TotalSalesTax"></a> msdyn_TotalSalesTax

|Property|Value|
|--------|-----|
|Description|Enter the summary of total sales tax charged for this work order.|
|DisplayName|Total Sales Tax|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalsalestax|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Location|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_worklocation|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_WorkLocation Options

|Value|Label|
|-----|-----|
|690970000|Onsite|
|690970001|Facility|
|690970002|Location Agnostic|



### <a name="BKMK_msdyn_workorderarrivaltimekpiid"></a> msdyn_workorderarrivaltimekpiid

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Work Order Arrival Time KPI|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderarrivaltimekpiid|
|RequiredLevel|None|
|Targets|slakpiinstance|
|Type|Lookup|


### <a name="BKMK_msdyn_workorderId"></a> msdyn_workorderId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|WO Number|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_workorderresolutionkpiid"></a> msdyn_workorderresolutionkpiid

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Work Order Resolution KPI|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderresolutionkpiid|
|RequiredLevel|None|
|Targets|slakpiinstance|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

|Property|Value|
|--------|-----|
|Description|Type a summary description of the job.|
|DisplayName|Work Order Summary|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workordersummary|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

|Property|Value|
|--------|-----|
|Description|Work Order Type|
|DisplayName|Work Order Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workordertype|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_workordertype|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_processid"></a> processid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_stageid"></a> stageid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the ID of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Work Order|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Work Order|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the entity.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_traversedpath"></a> traversedpath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.|
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
|Description|Shows the time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_BillingAccountName](#BKMK_msdyn_BillingAccountName)
- [msdyn_BillingAccountYomiName](#BKMK_msdyn_BillingAccountYomiName)
- [msdyn_ClosedByName](#BKMK_msdyn_ClosedByName)
- [msdyn_ClosedByYomiName](#BKMK_msdyn_ClosedByYomiName)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_estimatesubtotalamount_Base](#BKMK_msdyn_estimatesubtotalamount_Base)
- [msdyn_IoTAlertName](#BKMK_msdyn_IoTAlertName)
- [msdyn_mapcontrol](#BKMK_msdyn_mapcontrol)
- [msdyn_OpportunityIdName](#BKMK_msdyn_OpportunityIdName)
- [msdyn_ParentWorkOrderName](#BKMK_msdyn_ParentWorkOrderName)
- [msdyn_PreferredResourceName](#BKMK_msdyn_PreferredResourceName)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_PrimaryIncidentTypeName](#BKMK_msdyn_PrimaryIncidentTypeName)
- [msdyn_PriorityName](#BKMK_msdyn_PriorityName)
- [msdyn_ReportedByContactName](#BKMK_msdyn_ReportedByContactName)
- [msdyn_ReportedByContactYomiName](#BKMK_msdyn_ReportedByContactYomiName)
- [msdyn_ServiceAccountName](#BKMK_msdyn_ServiceAccountName)
- [msdyn_ServiceAccountYomiName](#BKMK_msdyn_ServiceAccountYomiName)
- [msdyn_ServiceRequestName](#BKMK_msdyn_ServiceRequestName)
- [msdyn_ServiceTerritoryName](#BKMK_msdyn_ServiceTerritoryName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
- [msdyn_subtotalamount_Base](#BKMK_msdyn_subtotalamount_Base)
- [msdyn_SupportContactName](#BKMK_msdyn_SupportContactName)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_TimeGroupDetailSelectedName](#BKMK_msdyn_TimeGroupDetailSelectedName)
- [msdyn_TimeGroupName](#BKMK_msdyn_TimeGroupName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalsalestax_Base](#BKMK_msdyn_totalsalestax_Base)
- [msdyn_workorderarrivaltimekpiidName](#BKMK_msdyn_workorderarrivaltimekpiidName)
- [msdyn_workorderresolutionkpiidName](#BKMK_msdyn_workorderresolutionkpiidName)
- [msdyn_WorkOrderTypeName](#BKMK_msdyn_WorkOrderTypeName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the exchange rate for the currency associated with the entity with respect to the base currency.|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BillingAccountName"></a> msdyn_BillingAccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BillingAccountYomiName"></a> msdyn_BillingAccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ClosedByName"></a> msdyn_ClosedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_closedbyname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ClosedByYomiName"></a> msdyn_ClosedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_closedbyyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_estimatesubtotalamount_Base"></a> msdyn_estimatesubtotalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate subtotal amount in the base currency.|
|DisplayName|Estimate Subtotal Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatesubtotalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_IoTAlertName"></a> msdyn_IoTAlertName

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_iotalertname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_mapcontrol"></a> msdyn_mapcontrol

|Property|Value|
|--------|-----|
|Description||
|DisplayName|This field should only be used to load the custom map control|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_mapcontrol|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OpportunityIdName"></a> msdyn_OpportunityIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityidname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ParentWorkOrderName"></a> msdyn_ParentWorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_parentworkordername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PreferredResourceName"></a> msdyn_PreferredResourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_preferredresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricelistname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PrimaryIncidentTypeName"></a> msdyn_PrimaryIncidentTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_primaryincidenttypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PriorityName"></a> msdyn_PriorityName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_priorityname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReportedByContactName"></a> msdyn_ReportedByContactName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_reportedbycontactname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReportedByContactYomiName"></a> msdyn_ReportedByContactYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_reportedbycontactyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceRequestName"></a> msdyn_ServiceRequestName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_servicerequestname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceTerritoryName"></a> msdyn_ServiceTerritoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceterritoryname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_substatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_subtotalamount_Base"></a> msdyn_subtotalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the subtotal amount in the base currency.|
|DisplayName|Subtotal Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_SupportContactName"></a> msdyn_SupportContactName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_supportcontactname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TaxCodeName"></a> msdyn_TaxCodeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_taxcodename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TimeGroupDetailSelectedName"></a> msdyn_TimeGroupDetailSelectedName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_timegroupdetailselectedname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TimeGroupName"></a> msdyn_TimeGroupName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_timegroupname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total amount in the base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_totalsalestax_Base"></a> msdyn_totalsalestax_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total sales tax in the base currency.|
|DisplayName|Total Sales Tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalsalestax_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_workorderarrivaltimekpiidName"></a> msdyn_workorderarrivaltimekpiidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderarrivaltimekpiidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_workorderresolutionkpiidName"></a> msdyn_workorderresolutionkpiidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderresolutionkpiidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderTypeName"></a> msdyn_WorkOrderTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordertypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

- [msdyn_workorder_ActivityPointers](#BKMK_msdyn_workorder_ActivityPointers)
- [msdyn_workorder_msdyn_bookingalerts](#BKMK_msdyn_workorder_msdyn_bookingalerts)
- [msdyn_workorder_msdyn_approvals](#BKMK_msdyn_workorder_msdyn_approvals)
- [msdyn_workorder_SyncErrors](#BKMK_msdyn_workorder_SyncErrors)
- [msdyn_workorder_DuplicateMatchingRecord](#BKMK_msdyn_workorder_DuplicateMatchingRecord)
- [msdyn_workorder_DuplicateBaseRecord](#BKMK_msdyn_workorder_DuplicateBaseRecord)
- [msdyn_workorder_SharePointDocumentLocations](#BKMK_msdyn_workorder_SharePointDocumentLocations)
- [msdyn_workorder_AsyncOperations](#BKMK_msdyn_workorder_AsyncOperations)
- [msdyn_workorder_MailboxTrackingFolders](#BKMK_msdyn_workorder_MailboxTrackingFolders)
- [msdyn_workorder_ProcessSession](#BKMK_msdyn_workorder_ProcessSession)
- [msdyn_workorder_BulkDeleteFailures](#BKMK_msdyn_workorder_BulkDeleteFailures)
- [msdyn_workorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses)
- [msdyn_workorder_Appointments](#BKMK_msdyn_workorder_Appointments)
- [msdyn_workorder_Emails](#BKMK_msdyn_workorder_Emails)
- [msdyn_workorder_Faxes](#BKMK_msdyn_workorder_Faxes)
- [msdyn_workorder_Letters](#BKMK_msdyn_workorder_Letters)
- [msdyn_workorder_PhoneCalls](#BKMK_msdyn_workorder_PhoneCalls)
- [msdyn_workorder_Tasks](#BKMK_msdyn_workorder_Tasks)
- [msdyn_workorder_RecurringAppointmentMasters](#BKMK_msdyn_workorder_RecurringAppointmentMasters)
- [msdyn_workorder_SocialActivities](#BKMK_msdyn_workorder_SocialActivities)
- [msdyn_workorder_connections1](#BKMK_msdyn_workorder_connections1)
- [msdyn_workorder_connections2](#BKMK_msdyn_workorder_connections2)
- [msdyn_workorder_QueueItems](#BKMK_msdyn_workorder_QueueItems)
- [msdyn_workorder_Annotations](#BKMK_msdyn_workorder_Annotations)
- [msdyn_workorder_ServiceAppointments](#BKMK_msdyn_workorder_ServiceAppointments)
- [bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b](#BKMK_bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b)
- [bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](#BKMK_bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39)
- [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)
- [msdyn_msdyn_workorder_invoicedetail](#BKMK_msdyn_msdyn_workorder_invoicedetail)
- [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_payment_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder](#BKMK_msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder)
- [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder)
- [msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)
- [bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](#BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)
- [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)


### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_workorder_ActivityPointers](activitypointer.md#BKMK_msdyn_workorder_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_msdyn_bookingalerts"></a> msdyn_workorder_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_workorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorder_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_msdyn_approvals"></a> msdyn_workorder_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_workorder_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorder_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_SyncErrors"></a> msdyn_workorder_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_workorder_SyncErrors](syncerror.md#BKMK_msdyn_workorder_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_DuplicateMatchingRecord"></a> msdyn_workorder_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorder_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorder_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_DuplicateBaseRecord"></a> msdyn_workorder_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorder_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorder_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_SharePointDocumentLocations"></a> msdyn_workorder_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_workorder_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorder_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_AsyncOperations"></a> msdyn_workorder_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_workorder_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorder_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_MailboxTrackingFolders"></a> msdyn_workorder_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_workorder_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorder_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_ProcessSession"></a> msdyn_workorder_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_workorder_ProcessSession](processsession.md#BKMK_msdyn_workorder_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_BulkDeleteFailures"></a> msdyn_workorder_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_workorder_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorder_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses"></a> msdyn_workorder_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_workorder_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_workorder_Appointments](appointment.md#BKMK_msdyn_workorder_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_Emails"></a> msdyn_workorder_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_workorder_Emails](email.md#BKMK_msdyn_workorder_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_Faxes"></a> msdyn_workorder_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_workorder_Faxes](fax.md#BKMK_msdyn_workorder_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_Letters"></a> msdyn_workorder_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_workorder_Letters](letter.md#BKMK_msdyn_workorder_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_PhoneCalls"></a> msdyn_workorder_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_workorder_PhoneCalls](phonecall.md#BKMK_msdyn_workorder_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_workorder_Tasks](task.md#BKMK_msdyn_workorder_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_workorder_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorder_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_SocialActivities"></a> msdyn_workorder_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_workorder_SocialActivities](socialactivity.md#BKMK_msdyn_workorder_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_connections1"></a> msdyn_workorder_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorder_connections1](connection.md#BKMK_msdyn_workorder_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_connections2"></a> msdyn_workorder_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorder_connections2](connection.md#BKMK_msdyn_workorder_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_QueueItems"></a> msdyn_workorder_QueueItems

**Added by**: System Solution Solution

Same as queueitem entity [msdyn_workorder_QueueItems](queueitem.md#BKMK_msdyn_workorder_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorder_Annotations"></a> msdyn_workorder_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_workorder_Annotations](annotation.md#BKMK_msdyn_workorder_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorder_ServiceAppointments"></a> msdyn_workorder_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_workorder_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorder_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorder_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b"></a> bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_989e9b1857e24af18787d5143b67523b|
|ReferencingAttribute|bpf_msdyn_workorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_workorder<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39"></a> bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39

Same as msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 entity [bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39|
|ReferencingAttribute|bpf_msdyn_workorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_workorder<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

Same as bookableresourcebooking entity [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](bookableresourcebooking.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_invoicedetail"></a> msdyn_msdyn_workorder_invoicedetail

Same as invoicedetail entity [msdyn_msdyn_workorder_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorder_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|msdyn_workorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_invoicedetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_actual_WorkOrder

Same as msdyn_actual entity [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](msdyn_actual.md#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_actual_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingdate|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder

Same as msdyn_inventoryjournal entity [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_allocatedtoworkorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_payment_WorkOrder

Same as msdyn_payment entity [msdyn_msdyn_workorder_msdyn_payment_WorkOrder](msdyn_payment.md#BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_payment|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_payment_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder"></a> msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder

Same as msdyn_paymentdetail entity [msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder](msdyn_paymentdetail.md#BKMK_msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentdetail|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder

Same as msdyn_purchaseorder entity [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder

Same as msdyn_purchaseorderproduct entity [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|msdyn_associatetoworkorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Purchase Order Products<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|msdyn_associatetoworkorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder

Same as msdyn_requirementcharacteristic entity [msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder](msdyn_requirementcharacteristic.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementcharacteristic|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Characteristics<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder

Same as msdyn_requirementresourcepreference entity [msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder](msdyn_requirementresourcepreference.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcepreference|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Resource Preferences<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder

Same as msdyn_resourcerequirement entity [msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Requirements<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rma_WorkOrder

Same as msdyn_rma entity [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](msdyn_rma.md#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_rma_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Work Order<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtv_WorkOrder

Same as msdyn_rtv entity [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](msdyn_rtv.md#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_rtv_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: RTVs<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder

Same as msdyn_rtvproduct entity [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

Same as msdyn_workorder entity [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|msdyn_parentworkorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder

Same as msdyn_workordercharacteristic entity [msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder](msdyn_workordercharacteristic.md#BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordercharacteristic|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder

Same as msdyn_workorderincident entity [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderincident|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

Same as msdyn_workorderproduct entity [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder

Same as msdyn_workorderresourcerestriction entity [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](msdyn_workorderresourcerestriction.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderresourcerestriction|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder

Same as msdyn_workorderservice entity [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder

Same as msdyn_workorderservicetask entity [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Service Tasks<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b"></a> bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|
|ReferencingAttribute|bpf_msdyn_workorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_workorder<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder"></a> msdyn_msdyn_workorder_msdyn_iotalert_Workorder

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

Same as msdyn_iotalert entity [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](msdyn_iotalert.md#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|msdyn_workorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorder_msdyn_iotalert_Workorder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorder_createdby](#BKMK_lk_msdyn_workorder_createdby)
- [lk_msdyn_workorder_createdonbehalfby](#BKMK_lk_msdyn_workorder_createdonbehalfby)
- [lk_msdyn_workorder_modifiedby](#BKMK_lk_msdyn_workorder_modifiedby)
- [lk_msdyn_workorder_modifiedonbehalfby](#BKMK_lk_msdyn_workorder_modifiedonbehalfby)
- [user_msdyn_workorder](#BKMK_user_msdyn_workorder)
- [team_msdyn_workorder](#BKMK_team_msdyn_workorder)
- [business_unit_msdyn_workorder](#BKMK_business_unit_msdyn_workorder)
- [processstage_msdyn_workorder](#BKMK_processstage_msdyn_workorder)
- [TransactionCurrency_msdyn_workorder](#BKMK_TransactionCurrency_msdyn_workorder)
- [msdyn_account_msdyn_workorder_BillingAccount](#BKMK_msdyn_account_msdyn_workorder_BillingAccount)
- [msdyn_account_msdyn_workorder_ServiceAccount](#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)
- [msdyn_bookableresource_msdyn_workorder_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)
- [msdyn_bookableresource_msdyn_workorder_SupportContact](#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)
- [msdyn_contact_msdyn_workorder_ReportedByContact](#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)
- [msdyn_incident_msdyn_workorder_ServiceRequest](#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest)
- [msdyn_msdyn_agreement_msdyn_workorder_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)
- [msdyn_msdyn_priority_msdyn_workorder_Priority](#BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority)
- [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode)
- [msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup](#BKMK_msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup)
- [msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected)
- [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder)
- [msdyn_msdyn_workordersubstatus_msdyn_workorder_Status](#BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status)
- [msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType)
- [msdyn_opportunity_msdyn_workorder](#BKMK_msdyn_opportunity_msdyn_workorder)
- [msdyn_pricelevel_msdyn_workorder_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList)
- [msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)
- [msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)
- [msdyn_systemuser_msdyn_workorder_ClosedBy](#BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy)
- [msdyn_territory_msdyn_workorder_ServiceTerritory](#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)
- [msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert)


### <a name="BKMK_lk_msdyn_workorder_createdby"></a> lk_msdyn_workorder_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorder_createdby](systemuser.md#BKMK_lk_msdyn_workorder_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_createdonbehalfby"></a> lk_msdyn_workorder_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorder_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorder_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_modifiedby"></a> lk_msdyn_workorder_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorder_modifiedby](systemuser.md#BKMK_lk_msdyn_workorder_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_modifiedonbehalfby"></a> lk_msdyn_workorder_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorder_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorder_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorder"></a> user_msdyn_workorder

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_workorder](systemuser.md#BKMK_user_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

**Added by**: System Solution Solution

See team Entity [team_msdyn_workorder](team.md#BKMK_team_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorder"></a> business_unit_msdyn_workorder

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_workorder](businessunit.md#BKMK_business_unit_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_workorder"></a> processstage_msdyn_workorder

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_workorder](processstage.md#BKMK_processstage_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_workorder](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_workorder_BillingAccount"></a> msdyn_account_msdyn_workorder_BillingAccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_workorder_BillingAccount](account.md#BKMK_msdyn_account_msdyn_workorder_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_workorder_ServiceAccount"></a> msdyn_account_msdyn_workorder_ServiceAccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_workorder_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_workorder_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource"></a> msdyn_bookableresource_msdyn_workorder_PreferredResource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_workorder_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact"></a> msdyn_bookableresource_msdyn_workorder_SupportContact

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_workorder_SupportContact](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_workorder_ReportedByContact](contact.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact) One-To-Many relationship.

### <a name="BKMK_msdyn_incident_msdyn_workorder_ServiceRequest"></a> msdyn_incident_msdyn_workorder_ServiceRequest

**Added by**: Service Solution

See incident Entity [msdyn_incident_msdyn_workorder_ServiceRequest](incident.md#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority"></a> msdyn_msdyn_priority_msdyn_workorder_Priority

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_workorder_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_workorder_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup"></a> msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup](msdyn_timegroup.md#BKMK_msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status"></a> msdyn_msdyn_workordersubstatus_msdyn_workorder_Status

See msdyn_workordersubstatus Entity [msdyn_msdyn_workordersubstatus_msdyn_workorder_Status](msdyn_workordersubstatus.md#BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunity_msdyn_workorder"></a> msdyn_opportunity_msdyn_workorder

**Added by**: Sales Solution

See opportunity Entity [msdyn_opportunity_msdyn_workorder](opportunity.md#BKMK_msdyn_opportunity_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_workorder_PriceList"></a> msdyn_pricelevel_msdyn_workorder_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_workorder_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi"></a> msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi

**Added by**: System Solution Solution

See slakpiinstance Entity [msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](slakpiinstance.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi) One-To-Many relationship.

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid"></a> msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid

**Added by**: System Solution Solution

See slakpiinstance Entity [msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](slakpiinstance.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy"></a> msdyn_systemuser_msdyn_workorder_ClosedBy

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_workorder_ClosedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory"></a> msdyn_territory_msdyn_workorder_ServiceTerritory

**Added by**: Application Common Solution

See territory Entity [msdyn_territory_msdyn_workorder_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert"></a> msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorder?text=msdyn_workorder EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]