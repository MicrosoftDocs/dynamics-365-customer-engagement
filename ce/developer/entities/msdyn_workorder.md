---
title: "msdyn_workorder Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorder entity."
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
# msdyn_workorder Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Work orders store all information about the job performed for an account. Stores incident details, resource, expenses, tasks, communications, billing and more

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorders<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorders<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorders(*msdyn_workorderid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Work Order<br />
**DisplayCollectionName**: Work Orders<br />
**SchemaName**: msdyn_workorder<br />
**CollectionSchemaName**: msdyn_workorders<br />
**LogicalName**: msdyn_workorder<br />
**LogicalCollectionName**: msdyn_workorders<br />
**EntitySetName**: msdyn_workorders<br />
**PrimaryIdAttribute**: msdyn_workorderid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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
- [msdyn_workorderId](#BKMK_msdyn_workorderId)
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

**Description**: Shows the sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

**Description**: <br />
**DisplayName**: Address 1<br />
**LogicalName**: msdyn_address1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

**Description**: <br />
**DisplayName**: Address 2<br />
**LogicalName**: msdyn_address2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

**Description**: <br />
**DisplayName**: Address 3<br />
**LogicalName**: msdyn_address3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

**Description**: <br />
**DisplayName**: Address Name<br />
**LogicalName**: msdyn_addressname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Description**: Shows the agreement linked to this work order.<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

**Description**: Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.<br />
**DisplayName**: Billing Account<br />
**LogicalName**: msdyn_billingaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_BookingSummary"></a> msdyn_BookingSummary

**Description**: Shows a synopsis of the bookings on the work order. This field is automatically updated by the system whenever a resource booking on the work order is changed.<br />
**DisplayName**: Booking Summary<br />
**LogicalName**: msdyn_bookingsummary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10000


### <a name="BKMK_msdyn_ChildIndex"></a> msdyn_ChildIndex

**Description**: <br />
**DisplayName**: Child Index<br />
**LogicalName**: msdyn_childindex<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_City"></a> msdyn_City

**Description**: <br />
**DisplayName**: City<br />
**LogicalName**: msdyn_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_msdyn_ClosedBy"></a> msdyn_ClosedBy

**Description**: The user that last closed this work order<br />
**DisplayName**: Closed By<br />
**LogicalName**: msdyn_closedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_Country"></a> msdyn_Country

**Description**: <br />
**DisplayName**: Country/Region<br />
**LogicalName**: msdyn_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Description**: Customer Asset related to this incident reported<br />
**DisplayName**: Primary Incident Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_DateWindowEnd"></a> msdyn_DateWindowEnd

**Description**: <br />
**DisplayName**: Date Window End<br />
**LogicalName**: msdyn_datewindowend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_DateWindowStart"></a> msdyn_DateWindowStart

**Description**: <br />
**DisplayName**: Date Window Start<br />
**LogicalName**: msdyn_datewindowstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_EstimateSubtotalAmount"></a> msdyn_EstimateSubtotalAmount

**Description**: Enter the summary of total estimated billing amount for this work order<br />
**DisplayName**: Estimate Subtotal Amount<br />
**LogicalName**: msdyn_estimatesubtotalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_FollowUpNote"></a> msdyn_FollowUpNote

**Description**: Indicate the details of the follow up work<br />
**DisplayName**: Follow Up Note (Deprecated)<br />
**LogicalName**: msdyn_followupnote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_FollowUpRequired"></a> msdyn_FollowUpRequired

**Description**: Allows indication if follow up work is required for a work order.<br />
**DisplayName**: Follow Up Required (Deprecated)<br />
**LogicalName**: msdyn_followuprequired<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Instructions"></a> msdyn_Instructions

**Description**: Shows instructions for booked resources. By default, this information is taken from the work order instructions field on the service account.<br />
**DisplayName**: Instructions<br />
**LogicalName**: msdyn_instructions<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_IoTAlert"></a> msdyn_IoTAlert

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: The iot alert which initiated this work order.<br />
**DisplayName**: IoT Alert<br />
**LogicalName**: msdyn_iotalert<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_iotalert


### <a name="BKMK_msdyn_IsFollowUp"></a> msdyn_IsFollowUp

**Description**: <br />
**DisplayName**: Is FollowUp (Deprecated)<br />
**LogicalName**: msdyn_isfollowup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsMobile"></a> msdyn_IsMobile

**Description**: <br />
**DisplayName**: Is Mobile<br />
**LogicalName**: msdyn_ismobile<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

**Description**: <br />
**DisplayName**: Latitude<br />
**LogicalName**: msdyn_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

**Description**: <br />
**DisplayName**: Longitude<br />
**LogicalName**: msdyn_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Work Order Number<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OpportunityId"></a> msdyn_OpportunityId

**Description**: Unique identifier for Opportunity associated with Work Order.<br />
**DisplayName**: Opportunity<br />
**LogicalName**: msdyn_opportunityid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: opportunity


### <a name="BKMK_msdyn_ParentWorkOrder"></a> msdyn_ParentWorkOrder

**Description**: Unique identifier for Work Order associated with Work Order.<br />
**DisplayName**: Parent Work Order<br />
**LogicalName**: msdyn_parentworkorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

**Description**: <br />
**DisplayName**: Postal Code<br />
**LogicalName**: msdyn_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

**Description**: The customer Preferred Resource to work on this job. Should be taken into consideration while scheduling resources<br />
**DisplayName**: Preferred Resource (Deprecated)<br />
**LogicalName**: msdyn_preferredresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Price List that controls pricing for products / services added to this work order. By default the system will use the Price List specified on the account<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_PrimaryIncidentDescription"></a> msdyn_PrimaryIncidentDescription

**Description**: Incident description<br />
**DisplayName**: Primary Incident Description<br />
**LogicalName**: msdyn_primaryincidentdescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_PrimaryIncidentEstimatedDuration"></a> msdyn_PrimaryIncidentEstimatedDuration

**Description**: Shows the time estimated to resolve this incident.<br />
**DisplayName**: Primary Incident Estimated Duration<br />
**LogicalName**: msdyn_primaryincidentestimatedduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_PrimaryIncidentType"></a> msdyn_PrimaryIncidentType

**Description**: Primary incident type reported<br />
**DisplayName**: Primary Incident Type<br />
**LogicalName**: msdyn_primaryincidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

**Description**: Priority of the Work Order. To be taken into consideration while scheduling resources<br />
**DisplayName**: Priority<br />
**LogicalName**: msdyn_priority<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_priority


### <a name="BKMK_msdyn_ReportedByContact"></a> msdyn_ReportedByContact

**Description**: The contact that reported this Work Order<br />
**DisplayName**: Reported By Contact<br />
**LogicalName**: msdyn_reportedbycontact<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

**Description**: Account to be serviced<br />
**DisplayName**: Service Account<br />
**LogicalName**: msdyn_serviceaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ServiceRequest"></a> msdyn_ServiceRequest

**Description**: Case of which this work order originates from<br />
**DisplayName**: Case<br />
**LogicalName**: msdyn_servicerequest<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: incident


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

**Description**: The service territory this work order relates to. By default this will be set to the Service Territory defined on the service account<br />
**DisplayName**: Service Territory<br />
**LogicalName**: msdyn_serviceterritory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: territory


### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

**Description**: <br />
**DisplayName**: State Or Province<br />
**LogicalName**: msdyn_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

**Description**: Work Order sub-status<br />
**DisplayName**: Sub-Status<br />
**LogicalName**: msdyn_substatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordersubstatus


### <a name="BKMK_msdyn_SubtotalAmount"></a> msdyn_SubtotalAmount

**Description**: Enter the summary of subtotal billing amount excluding tax for this work order.<br />
**DisplayName**: Subtotal Amount<br />
**LogicalName**: msdyn_subtotalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 900000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: Tracks the current system status.<br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Open - Unscheduled
- **Value**: 690970001 **Label**: Open - Scheduled
- **Value**: 690970002 **Label**: Open - In Progress
- **Value**: 690970003 **Label**: Open - Completed
- **Value**: 690970004 **Label**: Closed - Posted
- **Value**: 690970005 **Label**: Closed - Canceled



### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Description**: Shows whether sales tax is to be charged for this work order.<br />
**DisplayName**: Taxable<br />
**LogicalName**: msdyn_taxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

**Description**: Tax Code to be used to calculate tax when Work Order is taxable. By default the system will use the tax code specified on the service account<br />
**DisplayName**: Sales Tax Code<br />
**LogicalName**: msdyn_taxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_TimeClosed"></a> msdyn_TimeClosed

**Description**: Enter the time this work order was last closed.<br />
**DisplayName**: Closed On<br />
**LogicalName**: msdyn_timeclosed<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TimeFromPromised"></a> msdyn_TimeFromPromised

**Description**: Enter the starting range of the time promised to the account that incidents will be resolved.<br />
**DisplayName**: Time From Promised<br />
**LogicalName**: msdyn_timefrompromised<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TimeGroup"></a> msdyn_TimeGroup

**Description**: <br />
**DisplayName**: Time Group<br />
**LogicalName**: msdyn_timegroup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_timegroup


### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

**Description**: <br />
**DisplayName**: Time Group Detail Selected (Deprecated)<br />
**LogicalName**: msdyn_timegroupdetailselected<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_timegroupdetail


### <a name="BKMK_msdyn_TimeToPromised"></a> msdyn_TimeToPromised

**Description**: Enter the ending range of the time promised to the account that incidents will be resolved.<br />
**DisplayName**: Time To Promised<br />
**LogicalName**: msdyn_timetopromised<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

**Description**: <br />
**DisplayName**: Time Window End<br />
**LogicalName**: msdyn_timewindowend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

**Description**: <br />
**DisplayName**: Time Window Start<br />
**LogicalName**: msdyn_timewindowstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: Enter the summary of total billing amount for this work order.<br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 900000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TotalSalesTax"></a> msdyn_TotalSalesTax

**Description**: Enter the summary of total sales tax charged for this work order.<br />
**DisplayName**: Total Sales Tax<br />
**LogicalName**: msdyn_totalsalestax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

**Description**: <br />
**DisplayName**: Work Location<br />
**LogicalName**: msdyn_worklocation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Onsite
- **Value**: 690970001 **Label**: Depot
- **Value**: 690970002 **Label**: Location Agnostic



### <a name="BKMK_msdyn_workorderId"></a> msdyn_workorderId

**Description**: Shows the entity instances.<br />
**DisplayName**: WO Number<br />
**LogicalName**: msdyn_workorderid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

**Description**: Type a summary description of the job.<br />
**DisplayName**: Work Order Summary<br />
**LogicalName**: msdyn_workordersummary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

**Description**: Work Order Type<br />
**DisplayName**: Work Order Type<br />
**LogicalName**: msdyn_workordertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordertype


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
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

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_processid"></a> processid

**Description**: Shows the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Shows the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Work Order<br />
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



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Work Order<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



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

**Description**: Unique identifier of the currency associated with the entity.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
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

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

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
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_TimeGroupDetailSelectedName](#BKMK_msdyn_TimeGroupDetailSelectedName)
- [msdyn_TimeGroupName](#BKMK_msdyn_TimeGroupName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalsalestax_Base](#BKMK_msdyn_totalsalestax_Base)
- [msdyn_WorkOrderTypeName](#BKMK_msdyn_WorkOrderTypeName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**RequiredLevel**: SystemRequired<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**RequiredLevel**: SystemRequired<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementname<br />
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


### <a name="BKMK_msdyn_ClosedByName"></a> msdyn_ClosedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_closedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ClosedByYomiName"></a> msdyn_ClosedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_closedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_customerassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_estimatesubtotalamount_Base"></a> msdyn_estimatesubtotalamount_Base

**Description**: Shows the value of the estimate subtotal amount in the base currency.<br />
**DisplayName**: Estimate Subtotal Amount (Base)<br />
**LogicalName**: msdyn_estimatesubtotalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_IoTAlertName"></a> msdyn_IoTAlertName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_iotalertname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OpportunityIdName"></a> msdyn_OpportunityIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_opportunityidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_ParentWorkOrderName"></a> msdyn_ParentWorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_parentworkordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_pricelistname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PrimaryIncidentTypeName"></a> msdyn_PrimaryIncidentTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_primaryincidenttypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriorityName"></a> msdyn_PriorityName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_priorityname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ReportedByContactName"></a> msdyn_ReportedByContactName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_reportedbycontactname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ReportedByContactYomiName"></a> msdyn_ReportedByContactYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_reportedbycontactyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceRequestName"></a> msdyn_ServiceRequestName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_servicerequestname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_substatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_subtotalamount_Base"></a> msdyn_subtotalamount_Base

**Description**: Shows the value of the subtotal amount in the base currency.<br />
**DisplayName**: Subtotal Amount (Base)<br />
**LogicalName**: msdyn_subtotalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_TaxCodeName"></a> msdyn_TaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_taxcodename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TimeGroupDetailSelectedName"></a> msdyn_TimeGroupDetailSelectedName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_timegroupdetailselectedname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TimeGroupName"></a> msdyn_TimeGroupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_timegroupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

**Description**: Shows the value of the total amount in the base currency.<br />
**DisplayName**: Total Amount (Base)<br />
**LogicalName**: msdyn_totalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_totalsalestax_Base"></a> msdyn_totalsalestax_Base

**Description**: Shows the value of the total sales tax in the base currency.<br />
**DisplayName**: Total Sales Tax (Base)<br />
**LogicalName**: msdyn_totalsalestax_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_WorkOrderTypeName"></a> msdyn_WorkOrderTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordertypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
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

**Description**: Yomi name of the owner<br />
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

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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

**Description**: Version Number<br />
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

- [bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](#BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)
- [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)
- [msdyn_workorder_ActivityPointers](#BKMK_msdyn_workorder_ActivityPointers)
- [msdyn_workorder_msdyn_approvals](#BKMK_msdyn_workorder_msdyn_approvals)
- [msdyn_workorder_msdyn_bookingalerts](#BKMK_msdyn_workorder_msdyn_bookingalerts)
- [msdyn_workorder_SyncErrors](#BKMK_msdyn_workorder_SyncErrors)
- [msdyn_workorder_DuplicateMatchingRecord](#BKMK_msdyn_workorder_DuplicateMatchingRecord)
- [msdyn_workorder_DuplicateBaseRecord](#BKMK_msdyn_workorder_DuplicateBaseRecord)
- [msdyn_workorder_SharePointDocumentLocations](#BKMK_msdyn_workorder_SharePointDocumentLocations)
- [msdyn_workorder_SharePointDocuments](#BKMK_msdyn_workorder_SharePointDocuments)
- [msdyn_workorder_AsyncOperations](#BKMK_msdyn_workorder_AsyncOperations)
- [msdyn_workorder_MailboxTrackingFolders](#BKMK_msdyn_workorder_MailboxTrackingFolders)
- [msdyn_workorder_UserEntityInstanceDatas](#BKMK_msdyn_workorder_UserEntityInstanceDatas)
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


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b"></a> bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />
**ReferencingAttribute**: bpf_msdyn_workorderid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_workorder
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder"></a> msdyn_msdyn_workorder_msdyn_iotalert_Workorder

Same as msdyn_iotalert entity [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](msdyn_iotalert.md#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_iotalert_Workorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

Same as activitypointer entity [msdyn_workorder_ActivityPointers](activitypointer.md#BKMK_msdyn_workorder_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_ActivityPointers<br />
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


### <a name="BKMK_msdyn_workorder_msdyn_approvals"></a> msdyn_workorder_msdyn_approvals

Same as msdyn_approval entity [msdyn_workorder_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorder_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_msdyn_bookingalerts"></a> msdyn_workorder_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_workorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorder_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_SyncErrors"></a> msdyn_workorder_SyncErrors

Same as syncerror entity [msdyn_workorder_SyncErrors](syncerror.md#BKMK_msdyn_workorder_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_DuplicateMatchingRecord"></a> msdyn_workorder_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorder_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorder_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_workorder_DuplicateBaseRecord"></a> msdyn_workorder_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorder_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorder_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_workorder_SharePointDocumentLocations"></a> msdyn_workorder_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_workorder_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorder_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_workorder_SharePointDocuments"></a> msdyn_workorder_SharePointDocuments

Same as sharepointdocument entity [msdyn_workorder_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_workorder_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_AsyncOperations"></a> msdyn_workorder_AsyncOperations

Same as asyncoperation entity [msdyn_workorder_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorder_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_AsyncOperations<br />
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


### <a name="BKMK_msdyn_workorder_MailboxTrackingFolders"></a> msdyn_workorder_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorder_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorder_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_UserEntityInstanceDatas"></a> msdyn_workorder_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorder_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorder_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_workorder_ProcessSession"></a> msdyn_workorder_ProcessSession

Same as processsession entity [msdyn_workorder_ProcessSession](processsession.md#BKMK_msdyn_workorder_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_ProcessSession<br />
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


### <a name="BKMK_msdyn_workorder_BulkDeleteFailures"></a> msdyn_workorder_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorder_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorder_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses"></a> msdyn_workorder_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorder_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

Same as appointment entity [msdyn_workorder_Appointments](appointment.md#BKMK_msdyn_workorder_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_Emails"></a> msdyn_workorder_Emails

Same as email entity [msdyn_workorder_Emails](email.md#BKMK_msdyn_workorder_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_Faxes"></a> msdyn_workorder_Faxes

Same as fax entity [msdyn_workorder_Faxes](fax.md#BKMK_msdyn_workorder_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_Letters"></a> msdyn_workorder_Letters

Same as letter entity [msdyn_workorder_Letters](letter.md#BKMK_msdyn_workorder_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_PhoneCalls"></a> msdyn_workorder_PhoneCalls

Same as phonecall entity [msdyn_workorder_PhoneCalls](phonecall.md#BKMK_msdyn_workorder_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

Same as task entity [msdyn_workorder_Tasks](task.md#BKMK_msdyn_workorder_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_workorder_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorder_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_SocialActivities"></a> msdyn_workorder_SocialActivities

Same as socialactivity entity [msdyn_workorder_SocialActivities](socialactivity.md#BKMK_msdyn_workorder_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_connections1"></a> msdyn_workorder_connections1

Same as connection entity [msdyn_workorder_connections1](connection.md#BKMK_msdyn_workorder_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_workorder_connections2"></a> msdyn_workorder_connections2

Same as connection entity [msdyn_workorder_connections2](connection.md#BKMK_msdyn_workorder_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_connections2<br />
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


### <a name="BKMK_msdyn_workorder_QueueItems"></a> msdyn_workorder_QueueItems

Same as queueitem entity [msdyn_workorder_QueueItems](queueitem.md#BKMK_msdyn_workorder_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_QueueItems<br />
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


### <a name="BKMK_msdyn_workorder_Annotations"></a> msdyn_workorder_Annotations

Same as annotation entity [msdyn_workorder_Annotations](annotation.md#BKMK_msdyn_workorder_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorder_ServiceAppointments"></a> msdyn_workorder_ServiceAppointments

Same as serviceappointment entity [msdyn_workorder_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorder_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorder_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b"></a> bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />
**ReferencingAttribute**: bpf_msdyn_workorderid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_workorder
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39"></a> bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39

Same as msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 entity [bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />
**ReferencingAttribute**: bpf_msdyn_workorderid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_workorder_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_workorder
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

Same as bookableresourcebooking entity [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](bookableresourcebooking.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_invoicedetail"></a> msdyn_msdyn_workorder_invoicedetail

Same as invoicedetail entity [msdyn_msdyn_workorder_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorder_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_workorderid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_invoicedetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Sales
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_actual_WorkOrder

Same as msdyn_actual entity [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](msdyn_actual.md#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_actual_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingdate<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder

Same as msdyn_inventoryjournal entity [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_allocatedtoworkorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_payment_WorkOrder

Same as msdyn_payment entity [msdyn_msdyn_workorder_msdyn_payment_WorkOrder](msdyn_payment.md#BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_payment<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_payment_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder"></a> msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder

Same as msdyn_paymentdetail entity [msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder](msdyn_paymentdetail.md#BKMK_msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentdetail<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder

Same as msdyn_purchaseorder entity [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder

Same as msdyn_purchaseorderproduct entity [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_associatetoworkorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Purchase Order Products
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_associatetoworkorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder

Same as msdyn_requirementcharacteristic entity [msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder](msdyn_requirementcharacteristic.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementcharacteristic<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Characteristics
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder

Same as msdyn_requirementresourcepreference entity [msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder](msdyn_requirementresourcepreference.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcepreference<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Resource Preferences
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder

Same as msdyn_resourcerequirement entity [msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Requirements
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rma_WorkOrder

Same as msdyn_rma entity [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](msdyn_rma.md#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_rma_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Work Order
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtv_WorkOrder

Same as msdyn_rtv entity [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](msdyn_rtv.md#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_rtv_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: RTVs
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder

Same as msdyn_rtvproduct entity [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

Same as msdyn_workorder entity [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_parentworkorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder

Same as msdyn_workordercharacteristic entity [msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder](msdyn_workordercharacteristic.md#BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordercharacteristic<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder

Same as msdyn_workorderincident entity [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderincident<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

Same as msdyn_workorderproduct entity [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder

Same as msdyn_workorderresourcerestriction entity [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](msdyn_workorderresourcerestriction.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderresourcerestriction<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder

Same as msdyn_workorderservice entity [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder

Same as msdyn_workorderservicetask entity [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: msdyn_workorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Service Tasks
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert)
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
- [msdyn_systemuser_msdyn_workorder_ClosedBy](#BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy)
- [msdyn_territory_msdyn_workorder_ServiceTerritory](#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)


### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert"></a> msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert

See msdyn_iotalert Entity [msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_createdby"></a> lk_msdyn_workorder_createdby

See systemuser Entity [lk_msdyn_workorder_createdby](systemuser.md#BKMK_lk_msdyn_workorder_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_createdonbehalfby"></a> lk_msdyn_workorder_createdonbehalfby

See systemuser Entity [lk_msdyn_workorder_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorder_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_modifiedby"></a> lk_msdyn_workorder_modifiedby

See systemuser Entity [lk_msdyn_workorder_modifiedby](systemuser.md#BKMK_lk_msdyn_workorder_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorder_modifiedonbehalfby"></a> lk_msdyn_workorder_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorder_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorder_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorder"></a> user_msdyn_workorder

See systemuser Entity [user_msdyn_workorder](systemuser.md#BKMK_user_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

See team Entity [team_msdyn_workorder](team.md#BKMK_team_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorder"></a> business_unit_msdyn_workorder

See businessunit Entity [business_unit_msdyn_workorder](businessunit.md#BKMK_business_unit_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_workorder"></a> processstage_msdyn_workorder

See processstage Entity [processstage_msdyn_workorder](processstage.md#BKMK_processstage_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

See transactioncurrency Entity [TransactionCurrency_msdyn_workorder](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_workorder_BillingAccount"></a> msdyn_account_msdyn_workorder_BillingAccount

See account Entity [msdyn_account_msdyn_workorder_BillingAccount](account.md#BKMK_msdyn_account_msdyn_workorder_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_workorder_ServiceAccount"></a> msdyn_account_msdyn_workorder_ServiceAccount

See account Entity [msdyn_account_msdyn_workorder_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_workorder_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource"></a> msdyn_bookableresource_msdyn_workorder_PreferredResource

See bookableresource Entity [msdyn_bookableresource_msdyn_workorder_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

See contact Entity [msdyn_contact_msdyn_workorder_ReportedByContact](contact.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact) One-To-Many relationship.

### <a name="BKMK_msdyn_incident_msdyn_workorder_ServiceRequest"></a> msdyn_incident_msdyn_workorder_ServiceRequest

See incident Entity [msdyn_incident_msdyn_workorder_ServiceRequest](incident.md#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority"></a> msdyn_msdyn_priority_msdyn_workorder_Priority

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_workorder_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_workorder_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup"></a> msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup

See msdyn_timegroup Entity [msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup](msdyn_timegroup.md#BKMK_msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected

See msdyn_timegroupdetail Entity [msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status"></a> msdyn_msdyn_workordersubstatus_msdyn_workorder_Status

See msdyn_workordersubstatus Entity [msdyn_msdyn_workordersubstatus_msdyn_workorder_Status](msdyn_workordersubstatus.md#BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunity_msdyn_workorder"></a> msdyn_opportunity_msdyn_workorder

See opportunity Entity [msdyn_opportunity_msdyn_workorder](opportunity.md#BKMK_msdyn_opportunity_msdyn_workorder) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_workorder_PriceList"></a> msdyn_pricelevel_msdyn_workorder_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_workorder_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorder_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy"></a> msdyn_systemuser_msdyn_workorder_ClosedBy

See systemuser Entity [msdyn_systemuser_msdyn_workorder_ClosedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_workorder_ClosedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory"></a> msdyn_territory_msdyn_workorder_ServiceTerritory

See territory Entity [msdyn_territory_msdyn_workorder_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorder?text=msdyn_workorder EntityType" />