---
title: "msdyn_quotebookingsetup Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingsetup entity."
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
# msdyn_quotebookingsetup Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify the maintenance bookings for the agreement.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Quote Booking Setup<br />
**DisplayCollectionName**: Quote Booking Setups<br />
**SchemaName**: msdyn_quotebookingsetup<br />
**CollectionSchemaName**: msdyn_quotebookingsetups<br />
**LogicalName**: msdyn_quotebookingsetup<br />
**LogicalCollectionName**: msdyn_quotebookingsetups<br />
**EntitySetName**: msdyn_quotebookingsetups<br />
**PrimaryIdAttribute**: msdyn_quotebookingsetupid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_autogeneratebooking](#BKMK_msdyn_autogeneratebooking)
- [msdyn_autogenerateworkorder](#BKMK_msdyn_autogenerateworkorder)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_EstimatedCost](#BKMK_msdyn_EstimatedCost)
- [msdyn_estimatedduration](#BKMK_msdyn_estimatedduration)
- [msdyn_EstimatedMargin](#BKMK_msdyn_EstimatedMargin)
- [msdyn_EstimatedMarginPerWO](#BKMK_msdyn_EstimatedMarginPerWO)
- [msdyn_EstimatedProductCost](#BKMK_msdyn_EstimatedProductCost)
- [msdyn_EstimatedProductRevenue](#BKMK_msdyn_EstimatedProductRevenue)
- [msdyn_EstimatedRevenue](#BKMK_msdyn_EstimatedRevenue)
- [msdyn_EstimatedRevenuePerWO](#BKMK_msdyn_EstimatedRevenuePerWO)
- [msdyn_EstimatedServiceCost](#BKMK_msdyn_EstimatedServiceCost)
- [msdyn_EstimatedServiceRevenue](#BKMK_msdyn_EstimatedServiceRevenue)
- [msdyn_generateworkorderdaysinadvance](#BKMK_msdyn_generateworkorderdaysinadvance)
- [msdyn_Internalflags](#BKMK_msdyn_Internalflags)
- [msdyn_Margin](#BKMK_msdyn_Margin)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NumberOfWO](#BKMK_msdyn_NumberOfWO)
- [msdyn_postbookingflexibility](#BKMK_msdyn_postbookingflexibility)
- [msdyn_postponegenerationuntil](#BKMK_msdyn_postponegenerationuntil)
- [msdyn_prebookingflexibility](#BKMK_msdyn_prebookingflexibility)
- [msdyn_preferredresource](#BKMK_msdyn_preferredresource)
- [msdyn_preferredstarttime](#BKMK_msdyn_preferredstarttime)
- [msdyn_priority](#BKMK_msdyn_priority)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingsetupId](#BKMK_msdyn_quotebookingsetupId)
- [msdyn_QuoteDetailId](#BKMK_msdyn_QuoteDetailId)
- [msdyn_recurrencesettings](#BKMK_msdyn_recurrencesettings)
- [msdyn_revision](#BKMK_msdyn_revision)
- [msdyn_timewindowend](#BKMK_msdyn_timewindowend)
- [msdyn_timewindowstart](#BKMK_msdyn_timewindowstart)
- [msdyn_workordersummary](#BKMK_msdyn_workordersummary)
- [msdyn_workordertype](#BKMK_msdyn_workordertype)
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

**Description**: Sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_autogeneratebooking"></a> msdyn_autogeneratebooking

**Description**: Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup<br />
**DisplayName**: Auto Generate Booking<br />
**LogicalName**: msdyn_autogeneratebooking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_autogenerateworkorder"></a> msdyn_autogenerateworkorder

**Description**: Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup<br />
**DisplayName**: Auto Generate Work Order<br />
**LogicalName**: msdyn_autogenerateworkorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type a description of this booking setup.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

**Description**: <br />
**DisplayName**: Estimated Cost<br />
**LogicalName**: msdyn_estimatedcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

**Description**: Shows the duration of the booking.<br />
**DisplayName**: Estimated Duration<br />
**LogicalName**: msdyn_estimatedduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_EstimatedMargin"></a> msdyn_EstimatedMargin

**Description**: The estimated margin for this Quote Booking Setup<br />
**DisplayName**: EstimatedMargin<br />
**LogicalName**: msdyn_estimatedmargin<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstimatedMarginPerWO"></a> msdyn_EstimatedMarginPerWO

**Description**: <br />
**DisplayName**: EstimatedMarginPerWO<br />
**LogicalName**: msdyn_estimatedmarginperwo<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_EstimatedProductCost"></a> msdyn_EstimatedProductCost

**Description**: Estimated Costs of all Products that are associated to this Quote Booking Setup<br />
**DisplayName**: EstimatedProductCost<br />
**LogicalName**: msdyn_estimatedproductcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedProductRevenue"></a> msdyn_EstimatedProductRevenue

**Description**: The sum of estimated revenue of all products that are associated to this quote booking setup<br />
**DisplayName**: EstimatedProductRevenue<br />
**LogicalName**: msdyn_estimatedproductrevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedRevenue"></a> msdyn_EstimatedRevenue

**Description**: <br />
**DisplayName**: Estimated Revenue<br />
**LogicalName**: msdyn_estimatedrevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedRevenuePerWO"></a> msdyn_EstimatedRevenuePerWO

**Description**: The Estimated Revenue per Work Order<br />
**DisplayName**: EstimatedRevenuePerWO<br />
**LogicalName**: msdyn_estimatedrevenueperwo<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedServiceCost"></a> msdyn_EstimatedServiceCost

**Description**: The sum of the estimated costs of all quote booking services that are associated to this quote booking setup<br />
**DisplayName**: EstimatedServiceCost<br />
**LogicalName**: msdyn_estimatedservicecost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_EstimatedServiceRevenue"></a> msdyn_EstimatedServiceRevenue

**Description**: The sum of estimated revenue of all services that are associated to this quote booking setup<br />
**DisplayName**: EstimatedServiceRevenue<br />
**LogicalName**: msdyn_estimatedservicerevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_generateworkorderdaysinadvance"></a> msdyn_generateworkorderdaysinadvance

**Description**: Specify how many days in advance of the Booking Date the system should automatically generate a Work Order<br />
**DisplayName**: Generate Work Order Days In Advance<br />
**LogicalName**: msdyn_generateworkorderdaysinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_Internalflags"></a> msdyn_Internalflags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_Internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_Margin"></a> msdyn_Margin

**Description**: <br />
**DisplayName**: Margin<br />
**LogicalName**: msdyn_margin<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: The name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_NumberOfWO"></a> msdyn_NumberOfWO

**Description**: <br />
**DisplayName**: NumberOfWO<br />
**LogicalName**: msdyn_numberofwo<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_postbookingflexibility"></a> msdyn_postbookingflexibility

**Description**: Shows the flexibility of days after the booking date.<br />
**DisplayName**: Post Booking Flexibility<br />
**LogicalName**: msdyn_postbookingflexibility<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_postponegenerationuntil"></a> msdyn_postponegenerationuntil

**Description**: Shows the date until which Work Order generation can be postponed<br />
**DisplayName**: Postpone Generation Until<br />
**LogicalName**: msdyn_postponegenerationuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: TimeZoneIndependent<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_prebookingflexibility"></a> msdyn_prebookingflexibility

**Description**: Shows the flexibility of days prior to the booking date.<br />
**DisplayName**: Pre Booking Flexibility<br />
**LogicalName**: msdyn_prebookingflexibility<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_preferredresource"></a> msdyn_preferredresource

**Description**: Preferred Resource to booked<br />
**DisplayName**: Preferred Resource<br />
**LogicalName**: msdyn_preferredresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_preferredstarttime"></a> msdyn_preferredstarttime

**Description**: Shows the preferred time to booking.<br />
**DisplayName**: Preferred Start Time<br />
**LogicalName**: msdyn_preferredstarttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_priority"></a> msdyn_priority

**Description**: Booking Priority<br />
**DisplayName**: Priority<br />
**LogicalName**: msdyn_priority<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_priority


### <a name="BKMK_msdyn_quote"></a> msdyn_quote

**Description**: Quote this Booking Setup relates to<br />
**DisplayName**: Quote<br />
**LogicalName**: msdyn_quote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: quote


### <a name="BKMK_msdyn_quotebookingsetupId"></a> msdyn_quotebookingsetupId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Booking Setup<br />
**LogicalName**: msdyn_quotebookingsetupid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_QuoteDetailId"></a> msdyn_QuoteDetailId

**Description**: <br />
**DisplayName**: QuoteDetailId<br />
**LogicalName**: msdyn_quotedetailid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_recurrencesettings"></a> msdyn_recurrencesettings

**Description**: Stores the booking recurrence settings.<br />
**DisplayName**: Recurrence Settings<br />
**LogicalName**: msdyn_recurrencesettings<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_revision"></a> msdyn_revision

**Description**: For internal use only.<br />
**DisplayName**: Revision<br />
**LogicalName**: msdyn_revision<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_timewindowend"></a> msdyn_timewindowend

**Description**: Shows the time window up until when this can be booked.<br />
**DisplayName**: Time Window End<br />
**LogicalName**: msdyn_timewindowend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_timewindowstart"></a> msdyn_timewindowstart

**Description**: Shows the time window from when this can be booked.<br />
**DisplayName**: Time Window Start<br />
**LogicalName**: msdyn_timewindowstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_workordersummary"></a> msdyn_workordersummary

**Description**: Shows the work order summary to be set on the work orders generated.<br />
**DisplayName**: Work Order Summary<br />
**LogicalName**: msdyn_workordersummary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_workordertype"></a> msdyn_workordertype

**Description**: Work Order Type to be used on generated Work Orders<br />
**DisplayName**: Work Order Type<br />
**LogicalName**: msdyn_workordertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordertype


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

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Quote Booking Setup<br />
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

**Description**: Reason for the status of the Quote Booking Setup<br />
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

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
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
- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedproductcost_Base](#BKMK_msdyn_estimatedproductcost_Base)
- [msdyn_estimatedproductrevenue_Base](#BKMK_msdyn_estimatedproductrevenue_Base)
- [msdyn_estimatedrevenue_Base](#BKMK_msdyn_estimatedrevenue_Base)
- [msdyn_estimatedrevenueperwo_Base](#BKMK_msdyn_estimatedrevenueperwo_Base)
- [msdyn_estimatedservicecost_Base](#BKMK_msdyn_estimatedservicecost_Base)
- [msdyn_estimatedservicerevenue_Base](#BKMK_msdyn_estimatedservicerevenue_Base)
- [msdyn_preferredresourceName](#BKMK_msdyn_preferredresourceName)
- [msdyn_priorityName](#BKMK_msdyn_priorityName)
- [msdyn_quoteName](#BKMK_msdyn_quoteName)
- [msdyn_workordertypeName](#BKMK_msdyn_workordertypeName)
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

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
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

**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />
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

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
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


### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

**Description**: Value of the Estimated Cost in base currency.<br />
**DisplayName**: Estimated Cost (Base)<br />
**LogicalName**: msdyn_estimatedcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedproductcost_Base"></a> msdyn_estimatedproductcost_Base

**Description**: Value of the EstimatedProductCost in base currency.<br />
**DisplayName**: EstimatedProductCost (Base)<br />
**LogicalName**: msdyn_estimatedproductcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedproductrevenue_Base"></a> msdyn_estimatedproductrevenue_Base

**Description**: Value of the EstimatedProductRevenue in base currency.<br />
**DisplayName**: EstimatedProductRevenue (Base)<br />
**LogicalName**: msdyn_estimatedproductrevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedrevenue_Base"></a> msdyn_estimatedrevenue_Base

**Description**: Value of the Estimated Revenue in base currency.<br />
**DisplayName**: Estimated Revenue (Base)<br />
**LogicalName**: msdyn_estimatedrevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedrevenueperwo_Base"></a> msdyn_estimatedrevenueperwo_Base

**Description**: Value of the EstimatedRevenuePerWO in base currency.<br />
**DisplayName**: EstimatedRevenuePerWO (Base)<br />
**LogicalName**: msdyn_estimatedrevenueperwo_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedservicecost_Base"></a> msdyn_estimatedservicecost_Base

**Description**: Value of the EstimatedServiceCost in base currency.<br />
**DisplayName**: EstimatedServiceCost (Base)<br />
**LogicalName**: msdyn_estimatedservicecost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_estimatedservicerevenue_Base"></a> msdyn_estimatedservicerevenue_Base

**Description**: Value of the EstimatedServiceRevenue in base currency.<br />
**DisplayName**: EstimatedServiceRevenue (Base)<br />
**LogicalName**: msdyn_estimatedservicerevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_preferredresourceName"></a> msdyn_preferredresourceName

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


### <a name="BKMK_msdyn_priorityName"></a> msdyn_priorityName

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


### <a name="BKMK_msdyn_quoteName"></a> msdyn_quoteName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_workordertypeName"></a> msdyn_workordertypeName

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

- [msdyn_quotebookingsetup_SyncErrors](#BKMK_msdyn_quotebookingsetup_SyncErrors)
- [msdyn_quotebookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)
- [msdyn_quotebookingsetup_DuplicateBaseRecord](#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)
- [msdyn_quotebookingsetup_AsyncOperations](#BKMK_msdyn_quotebookingsetup_AsyncOperations)
- [msdyn_quotebookingsetup_MailboxTrackingFolders](#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)
- [msdyn_quotebookingsetup_UserEntityInstanceDatas](#BKMK_msdyn_quotebookingsetup_UserEntityInstanceDatas)
- [msdyn_quotebookingsetup_ProcessSession](#BKMK_msdyn_quotebookingsetup_ProcessSession)
- [msdyn_quotebookingsetup_BulkDeleteFailures](#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)
- [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)


### <a name="BKMK_msdyn_quotebookingsetup_SyncErrors"></a> msdyn_quotebookingsetup_SyncErrors

Same as syncerror entity [msdyn_quotebookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingsetup_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord"></a> msdyn_quotebookingsetup_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotebookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord"></a> msdyn_quotebookingsetup_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotebookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

Same as asyncoperation entity [msdyn_quotebookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingsetup_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders"></a> msdyn_quotebookingsetup_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotebookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_UserEntityInstanceDatas"></a> msdyn_quotebookingsetup_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotebookingsetup_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotebookingsetup_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

Same as processsession entity [msdyn_quotebookingsetup_ProcessSession](processsession.md#BKMK_msdyn_quotebookingsetup_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_BulkDeleteFailures"></a> msdyn_quotebookingsetup_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotebookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup

Same as msdyn_quotebookingincident entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingincident<br />
**ReferencingAttribute**: msdyn_quotebookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup

Same as msdyn_quotebookingproduct entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_quotebookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup

Same as msdyn_quotebookingservice entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_quotebookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup

Same as msdyn_quotebookingservicetask entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservicetask<br />
**ReferencingAttribute**: msdyn_quotebookingsetup<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotebookingsetup_createdby](#BKMK_lk_msdyn_quotebookingsetup_createdby)
- [lk_msdyn_quotebookingsetup_createdonbehalfby](#BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby)
- [lk_msdyn_quotebookingsetup_modifiedby](#BKMK_lk_msdyn_quotebookingsetup_modifiedby)
- [lk_msdyn_quotebookingsetup_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby)
- [user_msdyn_quotebookingsetup](#BKMK_user_msdyn_quotebookingsetup)
- [team_msdyn_quotebookingsetup](#BKMK_team_msdyn_quotebookingsetup)
- [business_unit_msdyn_quotebookingsetup](#BKMK_business_unit_msdyn_quotebookingsetup)
- [processstage_msdyn_quotebookingsetup](#BKMK_processstage_msdyn_quotebookingsetup)
- [TransactionCurrency_msdyn_quotebookingsetup](#BKMK_TransactionCurrency_msdyn_quotebookingsetup)
- [msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource)
- [msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority](#BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority)
- [msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType)
- [msdyn_quote_msdyn_quotebookingsetup_Quote](#BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote)


### <a name="BKMK_lk_msdyn_quotebookingsetup_createdby"></a> lk_msdyn_quotebookingsetup_createdby

See systemuser Entity [lk_msdyn_quotebookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby"></a> lk_msdyn_quotebookingsetup_createdonbehalfby

See systemuser Entity [lk_msdyn_quotebookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedby"></a> lk_msdyn_quotebookingsetup_modifiedby

See systemuser Entity [lk_msdyn_quotebookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby"></a> lk_msdyn_quotebookingsetup_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotebookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingsetup"></a> user_msdyn_quotebookingsetup

See systemuser Entity [user_msdyn_quotebookingsetup](systemuser.md#BKMK_user_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

See team Entity [team_msdyn_quotebookingsetup](team.md#BKMK_team_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

See businessunit Entity [business_unit_msdyn_quotebookingsetup](businessunit.md#BKMK_business_unit_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

See processstage Entity [processstage_msdyn_quotebookingsetup](processstage.md#BKMK_processstage_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

See transactioncurrency Entity [TransactionCurrency_msdyn_quotebookingsetup](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource

See bookableresource Entity [msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote"></a> msdyn_quote_msdyn_quotebookingsetup_Quote

See quote Entity [msdyn_quote_msdyn_quotebookingsetup_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingsetup?text=msdyn_quotebookingsetup EntityType" />