---
title: "msdyn_rtv Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rtv entity."
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
# msdyn_rtv Entity Reference

Records RTVs for products to be retuned to vendors

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rtvs<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rtvs<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_rtvs|
|DisplayCollectionName|RTVs|
|DisplayName|RTV|
|EntitySetName|msdyn_rtvs|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_rtvs|
|LogicalName|msdyn_rtv|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_rtvid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_rtv|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Address1](#BKMK_msdyn_Address1)
- [msdyn_Address2](#BKMK_msdyn_Address2)
- [msdyn_Address3](#BKMK_msdyn_Address3)
- [msdyn_ApprovedDeclinedBy](#BKMK_msdyn_ApprovedDeclinedBy)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OriginalPurchaseOrder](#BKMK_msdyn_OriginalPurchaseOrder)
- [msdyn_OriginatingRMA](#BKMK_msdyn_OriginatingRMA)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_ReferenceNo](#BKMK_msdyn_ReferenceNo)
- [msdyn_RequestDate](#BKMK_msdyn_RequestDate)
- [msdyn_ReturnDate](#BKMK_msdyn_ReturnDate)
- [msdyn_ReturnedBy](#BKMK_msdyn_ReturnedBy)
- [msdyn_rtvId](#BKMK_msdyn_rtvId)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_Vendor](#BKMK_msdyn_Vendor)
- [msdyn_VendorContact](#BKMK_msdyn_VendorContact)
- [msdyn_VendorRMA](#BKMK_msdyn_VendorRMA)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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
|MaxLength|100|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ApprovedDeclinedBy"></a> msdyn_ApprovedDeclinedBy

|Property|Value|
|--------|-----|
|Description|The user who approved or rejected this return|
|DisplayName|Approved/Declined By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_approveddeclinedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource Booking associated with RTV.|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Shows the unique number for identifying this RTV record.|
|DisplayName|RTV Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_OriginalPurchaseOrder"></a> msdyn_OriginalPurchaseOrder

|Property|Value|
|--------|-----|
|Description|Purchase Order from where items are originating|
|DisplayName|Original Purchase Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_originalpurchaseorder|
|RequiredLevel|None|
|Targets|msdyn_purchaseorder|
|Type|Lookup|


### <a name="BKMK_msdyn_OriginatingRMA"></a> msdyn_OriginatingRMA

|Property|Value|
|--------|-----|
|Description|Originating RMA if items were returned from customer|
|DisplayName|Originating RMA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_originatingrma|
|RequiredLevel|None|
|Targets|msdyn_rma|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReferenceNo"></a> msdyn_ReferenceNo

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Reference No|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_referenceno|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RequestDate"></a> msdyn_RequestDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when return was requested.|
|DisplayName|Request Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requestdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ReturnDate"></a> msdyn_ReturnDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date items were returned to vendor.|
|DisplayName|Return Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_returndate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ReturnedBy"></a> msdyn_ReturnedBy

|Property|Value|
|--------|-----|
|Description|User processing this return|
|DisplayName|Returned By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_returnedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_rtvId"></a> msdyn_rtvId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|RTV|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_rtvid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

|Property|Value|
|--------|-----|
|Description|Method of Shipment to Vendor|
|DisplayName|Ship Via|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shipvia|
|RequiredLevel|None|
|Targets|msdyn_shipvia|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|--------|-----|
|Description|RTV Substatus|
|DisplayName|Substatus|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_substatus|
|RequiredLevel|None|
|Targets|msdyn_rtvsubstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|--------|-----|
|Description|Enter the current status of the RTV.|
|DisplayName|System Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_systemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_SystemStatus Options

|Value|Label|
|-----|-----|
|690970000|Draft|
|690970001|Approved|
|690970002|Shipped|
|690970003|Received|
|690970004|Canceled|



### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

|Property|Value|
|--------|-----|
|Description|Tax code vendor charges you|
|DisplayName|Tax Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxcode|
|RequiredLevel|None|
|Targets|msdyn_taxcode|
|Type|Lookup|


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|--------|-----|
|Description|Shows the total Amount to be credited on this RTV.|
|DisplayName|Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|0|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Vendor"></a> msdyn_Vendor

|Property|Value|
|--------|-----|
|Description|Vendor where items will be returned|
|DisplayName|Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendor|
|RequiredLevel|ApplicationRequired|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_VendorContact"></a> msdyn_VendorContact

|Property|Value|
|--------|-----|
|Description|Contact person at Vendor|
|DisplayName|Vendor Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendorcontact|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_msdyn_VendorRMA"></a> msdyn_VendorRMA

|Property|Value|
|--------|-----|
|Description|RMA from Vendor|
|DisplayName|Vendor RMA|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendorrma|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with RTV.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the RTV|
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
|Description|Reason for the status of the RTV|
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
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


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
- [msdyn_ApprovedDeclinedByName](#BKMK_msdyn_ApprovedDeclinedByName)
- [msdyn_ApprovedDeclinedByYomiName](#BKMK_msdyn_ApprovedDeclinedByYomiName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_OriginalPurchaseOrderName](#BKMK_msdyn_OriginalPurchaseOrderName)
- [msdyn_OriginatingRMAName](#BKMK_msdyn_OriginatingRMAName)
- [msdyn_ReturnedByName](#BKMK_msdyn_ReturnedByName)
- [msdyn_ReturnedByYomiName](#BKMK_msdyn_ReturnedByYomiName)
- [msdyn_ShipViaName](#BKMK_msdyn_ShipViaName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_VendorContactName](#BKMK_msdyn_VendorContactName)
- [msdyn_VendorContactYomiName](#BKMK_msdyn_VendorContactYomiName)
- [msdyn_VendorName](#BKMK_msdyn_VendorName)
- [msdyn_VendorYomiName](#BKMK_msdyn_VendorYomiName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
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


### <a name="BKMK_msdyn_ApprovedDeclinedByName"></a> msdyn_ApprovedDeclinedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_approveddeclinedbyname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ApprovedDeclinedByYomiName"></a> msdyn_ApprovedDeclinedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_approveddeclinedbyyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OriginalPurchaseOrderName"></a> msdyn_OriginalPurchaseOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_originalpurchaseordername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OriginatingRMAName"></a> msdyn_OriginatingRMAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_originatingrmaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReturnedByName"></a> msdyn_ReturnedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_returnedbyname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReturnedByYomiName"></a> msdyn_ReturnedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_returnedbyyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ShipViaName"></a> msdyn_ShipViaName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shipvianame|
|MaxLength|100|
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
|PrecisionSource|0|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_VendorContactName"></a> msdyn_VendorContactName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendorcontactname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_VendorContactYomiName"></a> msdyn_VendorContactYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendorcontactyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_VendorName"></a> msdyn_VendorName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendorname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_VendorYomiName"></a> msdyn_VendorYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendoryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordername|
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

- [msdyn_rtv_ActivityPointers](#BKMK_msdyn_rtv_ActivityPointers)
- [msdyn_rtv_msdyn_bookingalerts](#BKMK_msdyn_rtv_msdyn_bookingalerts)
- [msdyn_rtv_msdyn_approvals](#BKMK_msdyn_rtv_msdyn_approvals)
- [msdyn_rtv_SyncErrors](#BKMK_msdyn_rtv_SyncErrors)
- [msdyn_rtv_DuplicateMatchingRecord](#BKMK_msdyn_rtv_DuplicateMatchingRecord)
- [msdyn_rtv_DuplicateBaseRecord](#BKMK_msdyn_rtv_DuplicateBaseRecord)
- [msdyn_rtv_SharePointDocumentLocations](#BKMK_msdyn_rtv_SharePointDocumentLocations)
- [msdyn_rtv_AsyncOperations](#BKMK_msdyn_rtv_AsyncOperations)
- [msdyn_rtv_MailboxTrackingFolders](#BKMK_msdyn_rtv_MailboxTrackingFolders)
- [msdyn_rtv_ProcessSession](#BKMK_msdyn_rtv_ProcessSession)
- [msdyn_rtv_BulkDeleteFailures](#BKMK_msdyn_rtv_BulkDeleteFailures)
- [msdyn_rtv_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses)
- [msdyn_rtv_Appointments](#BKMK_msdyn_rtv_Appointments)
- [msdyn_rtv_Emails](#BKMK_msdyn_rtv_Emails)
- [msdyn_rtv_Faxes](#BKMK_msdyn_rtv_Faxes)
- [msdyn_rtv_Letters](#BKMK_msdyn_rtv_Letters)
- [msdyn_rtv_PhoneCalls](#BKMK_msdyn_rtv_PhoneCalls)
- [msdyn_rtv_Tasks](#BKMK_msdyn_rtv_Tasks)
- [msdyn_rtv_RecurringAppointmentMasters](#BKMK_msdyn_rtv_RecurringAppointmentMasters)
- [msdyn_rtv_SocialActivities](#BKMK_msdyn_rtv_SocialActivities)
- [msdyn_rtv_connections1](#BKMK_msdyn_rtv_connections1)
- [msdyn_rtv_connections2](#BKMK_msdyn_rtv_connections2)
- [msdyn_rtv_Annotations](#BKMK_msdyn_rtv_Annotations)
- [msdyn_rtv_ServiceAppointments](#BKMK_msdyn_rtv_ServiceAppointments)
- [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)
- [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV)


### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_rtv_ActivityPointers](activitypointer.md#BKMK_msdyn_rtv_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_msdyn_bookingalerts"></a> msdyn_rtv_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_rtv_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rtv_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_msdyn_approvals"></a> msdyn_rtv_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_rtv_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rtv_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_SyncErrors"></a> msdyn_rtv_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_rtv_SyncErrors](syncerror.md#BKMK_msdyn_rtv_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_DuplicateMatchingRecord"></a> msdyn_rtv_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_rtv_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rtv_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_DuplicateBaseRecord"></a> msdyn_rtv_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_rtv_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rtv_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_SharePointDocumentLocations"></a> msdyn_rtv_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_rtv_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_rtv_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_AsyncOperations"></a> msdyn_rtv_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_rtv_AsyncOperations](asyncoperation.md#BKMK_msdyn_rtv_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_MailboxTrackingFolders"></a> msdyn_rtv_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_rtv_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rtv_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_ProcessSession"></a> msdyn_rtv_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_rtv_ProcessSession](processsession.md#BKMK_msdyn_rtv_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_BulkDeleteFailures"></a> msdyn_rtv_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_rtv_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rtv_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses"></a> msdyn_rtv_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_rtv_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_rtv_Appointments](appointment.md#BKMK_msdyn_rtv_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_Emails"></a> msdyn_rtv_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_rtv_Emails](email.md#BKMK_msdyn_rtv_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_Faxes"></a> msdyn_rtv_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_rtv_Faxes](fax.md#BKMK_msdyn_rtv_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_Letters"></a> msdyn_rtv_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_rtv_Letters](letter.md#BKMK_msdyn_rtv_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_PhoneCalls"></a> msdyn_rtv_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_rtv_PhoneCalls](phonecall.md#BKMK_msdyn_rtv_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_rtv_Tasks](task.md#BKMK_msdyn_rtv_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_rtv_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rtv_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_SocialActivities"></a> msdyn_rtv_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_rtv_SocialActivities](socialactivity.md#BKMK_msdyn_rtv_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_connections1"></a> msdyn_rtv_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_rtv_connections1](connection.md#BKMK_msdyn_rtv_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_connections2"></a> msdyn_rtv_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_rtv_connections2](connection.md#BKMK_msdyn_rtv_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rtv_Annotations"></a> msdyn_rtv_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_rtv_Annotations](annotation.md#BKMK_msdyn_rtv_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rtv_ServiceAppointments"></a> msdyn_rtv_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_rtv_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rtv_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rtv_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV

Same as msdyn_rmareceiptproduct entity [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmareceiptproduct|
|ReferencingAttribute|msdyn_rtv|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rtvproduct_RTV

Same as msdyn_rtvproduct entity [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|msdyn_rtv|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_rtv_msdyn_rtvproduct_RTV|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_rtv_createdby](#BKMK_lk_msdyn_rtv_createdby)
- [lk_msdyn_rtv_createdonbehalfby](#BKMK_lk_msdyn_rtv_createdonbehalfby)
- [lk_msdyn_rtv_modifiedby](#BKMK_lk_msdyn_rtv_modifiedby)
- [lk_msdyn_rtv_modifiedonbehalfby](#BKMK_lk_msdyn_rtv_modifiedonbehalfby)
- [user_msdyn_rtv](#BKMK_user_msdyn_rtv)
- [team_msdyn_rtv](#BKMK_team_msdyn_rtv)
- [business_unit_msdyn_rtv](#BKMK_business_unit_msdyn_rtv)
- [TransactionCurrency_msdyn_rtv](#BKMK_TransactionCurrency_msdyn_rtv)
- [msdyn_account_msdyn_rtv_Vendor](#BKMK_msdyn_account_msdyn_rtv_Vendor)
- [msdyn_bookableresourcebooking_msdyn_rtv_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)
- [msdyn_contact_msdyn_rtv_VendorContact](#BKMK_msdyn_contact_msdyn_rtv_VendorContact)
- [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO)
- [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA)
- [msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus)
- [msdyn_msdyn_shipvia_msdyn_rtv_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia)
- [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode)
- [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder)
- [msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy](#BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy)
- [msdyn_systemuser_msdyn_rtv_ReturnedBy](#BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy)


### <a name="BKMK_lk_msdyn_rtv_createdby"></a> lk_msdyn_rtv_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rtv_createdby](systemuser.md#BKMK_lk_msdyn_rtv_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_createdonbehalfby"></a> lk_msdyn_rtv_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rtv_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rtv_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_modifiedby"></a> lk_msdyn_rtv_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rtv_modifiedby](systemuser.md#BKMK_lk_msdyn_rtv_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_modifiedonbehalfby"></a> lk_msdyn_rtv_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rtv_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rtv_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rtv"></a> user_msdyn_rtv

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_rtv](systemuser.md#BKMK_user_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

**Added by**: System Solution Solution

See team Entity [team_msdyn_rtv](team.md#BKMK_team_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rtv"></a> business_unit_msdyn_rtv

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_rtv](businessunit.md#BKMK_business_unit_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_rtv](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rtv_Vendor"></a> msdyn_account_msdyn_rtv_Vendor

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_rtv_Vendor](account.md#BKMK_msdyn_account_msdyn_rtv_Vendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking"></a> msdyn_bookableresourcebooking_msdyn_rtv_Booking

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_rtv_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_rtv_VendorContact"></a> msdyn_contact_msdyn_rtv_VendorContact

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_rtv_VendorContact](contact.md#BKMK_msdyn_contact_msdyn_rtv_VendorContact) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO"></a> msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA"></a> msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus"></a> msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus

See msdyn_rtvsubstatus Entity [msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](msdyn_rtvsubstatus.md#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_rtv_ShipVia

See msdyn_shipvia Entity [msdyn_msdyn_shipvia_msdyn_rtv_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rtv_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtv_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy"></a> msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy"></a> msdyn_systemuser_msdyn_rtv_ReturnedBy

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_rtv_ReturnedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rtv?text=msdyn_rtv EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]