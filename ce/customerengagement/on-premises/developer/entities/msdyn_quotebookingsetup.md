---
title: "msdyn_quotebookingsetup Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingsetup entity."
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
# msdyn_quotebookingsetup Entity Reference

Specify the maintenance bookings for the agreement.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_quotebookingsetups|
|DisplayCollectionName|Quote Booking Setups|
|DisplayName|Quote Booking Setup|
|EntitySetName|msdyn_quotebookingsetups|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_quotebookingsetups|
|LogicalName|msdyn_quotebookingsetup|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_quotebookingsetupid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_quotebookingsetup|

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
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
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
- [msdyn_quotedetail](#BKMK_msdyn_quotedetail)
- [msdyn_QuoteDetailId](#BKMK_msdyn_QuoteDetailId)
- [msdyn_recurrencesettings](#BKMK_msdyn_recurrencesettings)
- [msdyn_revision](#BKMK_msdyn_revision)
- [msdyn_timewindowend](#BKMK_msdyn_timewindowend)
- [msdyn_timewindowstart](#BKMK_msdyn_timewindowstart)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
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


### <a name="BKMK_msdyn_autogeneratebooking"></a> msdyn_autogeneratebooking

|Property|Value|
|--------|-----|
|Description|Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup|
|DisplayName|Auto Generate Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogeneratebooking|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_autogeneratebooking Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_autogenerateworkorder"></a> msdyn_autogenerateworkorder

|Property|Value|
|--------|-----|
|Description|Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup|
|DisplayName|Auto Generate Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogenerateworkorder|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_autogenerateworkorder Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type a description of this booking setup.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedcost|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

|Property|Value|
|--------|-----|
|Description|Shows the duration of the booking.|
|DisplayName|Estimated Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_EstimatedMargin"></a> msdyn_EstimatedMargin

|Property|Value|
|--------|-----|
|Description|The estimated margin for this Quote Booking Setup|
|DisplayName|EstimatedMargin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedmargin|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstimatedMarginPerWO"></a> msdyn_EstimatedMarginPerWO

|Property|Value|
|--------|-----|
|Description||
|DisplayName|EstimatedMarginPerWO|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedmarginperwo|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstimatedProductCost"></a> msdyn_EstimatedProductCost

|Property|Value|
|--------|-----|
|Description|Estimated Costs of all Products that are associated to this Quote Booking Setup|
|DisplayName|EstimatedProductCost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedproductcost|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedProductRevenue"></a> msdyn_EstimatedProductRevenue

|Property|Value|
|--------|-----|
|Description|The sum of estimated revenue of all products that are associated to this quote booking setup|
|DisplayName|EstimatedProductRevenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedproductrevenue|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedRevenue"></a> msdyn_EstimatedRevenue

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedrevenue|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedRevenuePerWO"></a> msdyn_EstimatedRevenuePerWO

|Property|Value|
|--------|-----|
|Description|The Estimated Revenue per Work Order|
|DisplayName|EstimatedRevenuePerWO|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedrevenueperwo|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedServiceCost"></a> msdyn_EstimatedServiceCost

|Property|Value|
|--------|-----|
|Description|The sum of the estimated costs of all quote booking services that are associated to this quote booking setup|
|DisplayName|EstimatedServiceCost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedservicecost|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedServiceRevenue"></a> msdyn_EstimatedServiceRevenue

|Property|Value|
|--------|-----|
|Description|The sum of estimated revenue of all services that are associated to this quote booking setup|
|DisplayName|EstimatedServiceRevenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedservicerevenue|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_generateworkorderdaysinadvance"></a> msdyn_generateworkorderdaysinadvance

|Property|Value|
|--------|-----|
|Description|Specify how many days in advance of the Booking Date the system should automatically generate a Work Order|
|DisplayName|Generate Work Order Days In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generateworkorderdaysinadvance|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Internalflags"></a> msdyn_Internalflags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_Internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|--------|-----|
|Description|Only used when Work Location is a Facility. Latitude is used when trying to locate nearby facilities.|
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
|Description|Only used when Work Location is a Facility. Longitude is used when trying to locate nearby facilities.|
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Margin"></a> msdyn_Margin

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Margin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_margin|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_NumberOfWO"></a> msdyn_NumberOfWO

|Property|Value|
|--------|-----|
|Description||
|DisplayName|NumberOfWO|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_numberofwo|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_postbookingflexibility"></a> msdyn_postbookingflexibility

|Property|Value|
|--------|-----|
|Description|Shows the flexibility of days after the booking date.|
|DisplayName|Post Booking Flexibility|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postbookingflexibility|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_postponegenerationuntil"></a> msdyn_postponegenerationuntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description|Shows the date until which Work Order generation can be postponed|
|DisplayName|Postpone Generation Until|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postponegenerationuntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_prebookingflexibility"></a> msdyn_prebookingflexibility

|Property|Value|
|--------|-----|
|Description|Shows the flexibility of days prior to the booking date.|
|DisplayName|Pre Booking Flexibility|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_prebookingflexibility|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_preferredresource"></a> msdyn_preferredresource

|Property|Value|
|--------|-----|
|Description|Preferred Resource to booked|
|DisplayName|Preferred Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preferredresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_preferredstarttime"></a> msdyn_preferredstarttime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the preferred time to booking.|
|DisplayName|Preferred Start Time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_preferredstarttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_priority"></a> msdyn_priority

|Property|Value|
|--------|-----|
|Description|Booking Priority|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priority|
|RequiredLevel|None|
|Targets|msdyn_priority|
|Type|Lookup|


### <a name="BKMK_msdyn_quote"></a> msdyn_quote

|Property|Value|
|--------|-----|
|Description|Quote this Booking Setup relates to|
|DisplayName|Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quote|
|RequiredLevel|ApplicationRequired|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_msdyn_quotebookingsetupId"></a> msdyn_quotebookingsetupId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Quote Booking Setup|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_quotebookingsetupid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_quotedetail"></a> msdyn_quotedetail

|Property|Value|
|--------|-----|
|Description|Relationship between Quote Detail and Quote Booking Setup|
|DisplayName|Relationship between Quote Detail and Quote Booking Setup|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotedetail_msdyn_quotebookingset|
|RequiredLevel|ApplicationRequired|
|Targets|quotedetail|
|Type|Lookup|


### <a name="BKMK_msdyn_QuoteDetailId"></a> msdyn_QuoteDetailId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|QuoteDetailId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotedetailid|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_recurrencesettings"></a> msdyn_recurrencesettings

|Property|Value|
|--------|-----|
|Description|Stores the booking recurrence settings.|
|DisplayName|Recurrence Settings|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recurrencesettings|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_revision"></a> msdyn_revision

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Revision|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_revision|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_timewindowend"></a> msdyn_timewindowend

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time window up until when this can be booked.|
|DisplayName|Time Window End|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_timewindowstart"></a> msdyn_timewindowstart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time window from when this can be booked.|
|DisplayName|Time Window Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timewindowstart|
|RequiredLevel|None|
|Type|DateTime|


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



### <a name="BKMK_msdyn_workordersummary"></a> msdyn_workordersummary

|Property|Value|
|--------|-----|
|Description|Shows the work order summary to be set on the work orders generated.|
|DisplayName|Work Order Summary|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workordersummary|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_workordertype"></a> msdyn_workordertype

|Property|Value|
|--------|-----|
|Description|Work Order Type to be used on generated Work Orders|
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
|Description|Contains the id of the process associated with the entity.|
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
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Quote Booking Setup|
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
|Description|Reason for the status of the Quote Booking Setup|
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
- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedproductcost_Base](#BKMK_msdyn_estimatedproductcost_Base)
- [msdyn_estimatedproductrevenue_Base](#BKMK_msdyn_estimatedproductrevenue_Base)
- [msdyn_estimatedrevenue_Base](#BKMK_msdyn_estimatedrevenue_Base)
- [msdyn_estimatedrevenueperwo_Base](#BKMK_msdyn_estimatedrevenueperwo_Base)
- [msdyn_estimatedservicecost_Base](#BKMK_msdyn_estimatedservicecost_Base)
- [msdyn_estimatedservicerevenue_Base](#BKMK_msdyn_estimatedservicerevenue_Base)
- [msdyn_preferredresourceName](#BKMK_msdyn_preferredresourceName)
- [msdyn_priorityName](#BKMK_msdyn_priorityName)
- [msdyn_quotedetail_msdyn_quotebookingsetName](#BKMK_msdyn_quotedetail_msdyn_quotebookingsetName)
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
|Description|Date and time when the record was created.|
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
|Description|Unique identifier of the delegate user who created the record.|
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
|Description|Exchange rate for the currency associated with the entity with respect to the base currency.|
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
|Description|Date and time when the record was modified.|
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
|Description|Unique identifier of the delegate user who modified the record.|
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


### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Cost in base currency.|
|DisplayName|Estimated Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedproductcost_Base"></a> msdyn_estimatedproductcost_Base

|Property|Value|
|--------|-----|
|Description|Value of the EstimatedProductCost in base currency.|
|DisplayName|EstimatedProductCost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedproductcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedproductrevenue_Base"></a> msdyn_estimatedproductrevenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the EstimatedProductRevenue in base currency.|
|DisplayName|EstimatedProductRevenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedproductrevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedrevenue_Base"></a> msdyn_estimatedrevenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Revenue in base currency.|
|DisplayName|Estimated Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedrevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedrevenueperwo_Base"></a> msdyn_estimatedrevenueperwo_Base

|Property|Value|
|--------|-----|
|Description|Value of the EstimatedRevenuePerWO in base currency.|
|DisplayName|EstimatedRevenuePerWO (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedrevenueperwo_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedservicecost_Base"></a> msdyn_estimatedservicecost_Base

|Property|Value|
|--------|-----|
|Description|Value of the EstimatedServiceCost in base currency.|
|DisplayName|EstimatedServiceCost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedservicecost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedservicerevenue_Base"></a> msdyn_estimatedservicerevenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the EstimatedServiceRevenue in base currency.|
|DisplayName|EstimatedServiceRevenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedservicerevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_preferredresourceName"></a> msdyn_preferredresourceName

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


### <a name="BKMK_msdyn_priorityName"></a> msdyn_priorityName

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


### <a name="BKMK_msdyn_quotedetail_msdyn_quotebookingsetName"></a> msdyn_quotedetail_msdyn_quotebookingsetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotedetail_msdyn_quotebookingsetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_quoteName"></a> msdyn_quoteName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotename|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_workordertypeName"></a> msdyn_workordertypeName

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

- [msdyn_quotebookingsetup_SyncErrors](#BKMK_msdyn_quotebookingsetup_SyncErrors)
- [msdyn_quotebookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)
- [msdyn_quotebookingsetup_DuplicateBaseRecord](#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)
- [msdyn_quotebookingsetup_AsyncOperations](#BKMK_msdyn_quotebookingsetup_AsyncOperations)
- [msdyn_quotebookingsetup_MailboxTrackingFolders](#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)
- [msdyn_quotebookingsetup_ProcessSession](#BKMK_msdyn_quotebookingsetup_ProcessSession)
- [msdyn_quotebookingsetup_BulkDeleteFailures](#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)
- [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)


### <a name="BKMK_msdyn_quotebookingsetup_SyncErrors"></a> msdyn_quotebookingsetup_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_quotebookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingsetup_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord"></a> msdyn_quotebookingsetup_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotebookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord"></a> msdyn_quotebookingsetup_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotebookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_quotebookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingsetup_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders"></a> msdyn_quotebookingsetup_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_quotebookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_quotebookingsetup_ProcessSession](processsession.md#BKMK_msdyn_quotebookingsetup_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_BulkDeleteFailures"></a> msdyn_quotebookingsetup_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_quotebookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup

Same as msdyn_quotebookingincident entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingincident|
|ReferencingAttribute|msdyn_quotebookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup

Same as msdyn_quotebookingproduct entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|msdyn_quotebookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup

Same as msdyn_quotebookingservice entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|msdyn_quotebookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup

Same as msdyn_quotebookingservicetask entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservicetask|
|ReferencingAttribute|msdyn_quotebookingsetup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

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
- [msdyn_quotedetail_msdyn_quotebookingsetup](#BKMK_msdyn_quotedetail_msdyn_quotebookingsetup)


### <a name="BKMK_lk_msdyn_quotebookingsetup_createdby"></a> lk_msdyn_quotebookingsetup_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby"></a> lk_msdyn_quotebookingsetup_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedby"></a> lk_msdyn_quotebookingsetup_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby"></a> lk_msdyn_quotebookingsetup_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingsetup"></a> user_msdyn_quotebookingsetup

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_quotebookingsetup](systemuser.md#BKMK_user_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

**Added by**: System Solution Solution

See team Entity [team_msdyn_quotebookingsetup](team.md#BKMK_team_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_quotebookingsetup](businessunit.md#BKMK_business_unit_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_quotebookingsetup](processstage.md#BKMK_processstage_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_quotebookingsetup](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote"></a> msdyn_quote_msdyn_quotebookingsetup_Quote

**Added by**: Sales Solution

See quote Entity [msdyn_quote_msdyn_quotebookingsetup_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote) One-To-Many relationship.

### <a name="BKMK_msdyn_quotedetail_msdyn_quotebookingsetup"></a> msdyn_quotedetail_msdyn_quotebookingsetup

**Added by**: Sales Solution

See quotedetail Entity [msdyn_quotedetail_msdyn_quotebookingsetup](quotedetail.md#BKMK_msdyn_quotedetail_msdyn_quotebookingsetup) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingsetup?text=msdyn_quotebookingsetup EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]