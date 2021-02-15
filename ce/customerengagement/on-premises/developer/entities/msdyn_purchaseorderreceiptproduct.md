---
title: "msdyn_purchaseorderreceiptproduct Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderreceiptproduct entity."
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
# msdyn_purchaseorderreceiptproduct Entity Reference

Specify product for purchase order receipt.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceiptproducts(*msdyn_purchaseorderreceiptproductid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_purchaseorderreceiptproducts|
|DisplayCollectionName|Purchase Order Receipt Products|
|DisplayName|Purchase Order Receipt Product|
|EntitySetName|msdyn_purchaseorderreceiptproducts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_purchaseorderreceiptproducts|
|LogicalName|msdyn_purchaseorderreceiptproduct|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_purchaseorderreceiptproductid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_purchaseorderreceiptproduct|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AssociateToBooking](#BKMK_msdyn_AssociateToBooking)
- [msdyn_AssociateToWarehouse](#BKMK_msdyn_AssociateToWarehouse)
- [msdyn_AssociateToWorkOrder](#BKMK_msdyn_AssociateToWorkOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_PurchaseOrderBill](#BKMK_msdyn_PurchaseOrderBill)
- [msdyn_PurchaseOrderProduct](#BKMK_msdyn_PurchaseOrderProduct)
- [msdyn_PurchaseOrderReceipt](#BKMK_msdyn_PurchaseOrderReceipt)
- [msdyn_purchaseorderreceiptproductId](#BKMK_msdyn_purchaseorderreceiptproductId)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_UnitCost](#BKMK_msdyn_UnitCost)
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


### <a name="BKMK_msdyn_AssociateToBooking"></a> msdyn_AssociateToBooking

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource Booking associated with Purchase Order Receipt Product.|
|DisplayName|Associate To Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_associatetobooking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_AssociateToWarehouse"></a> msdyn_AssociateToWarehouse

|Property|Value|
|--------|-----|
|Description|Unique identifier for Warehouse associated with Purchase Order Receipt Product.|
|DisplayName|Associate To Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_associatetowarehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_AssociateToWorkOrder"></a> msdyn_AssociateToWorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Purchase Order Receipt Product.|
|DisplayName|Associate To Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_associatetoworkorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Purchase Order associated with Purchase Order Receipt Product.|
|DisplayName|Purchase Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_purchaseorder|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrderBill"></a> msdyn_PurchaseOrderBill

|Property|Value|
|--------|-----|
|Description|Unique identifier for Purchase Order Bill associated with Purchase Order Receipt Product.|
|DisplayName|Purchase Order Bill|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderbill|
|RequiredLevel|None|
|Targets|msdyn_purchaseorderbill|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrderProduct"></a> msdyn_PurchaseOrderProduct

|Property|Value|
|--------|-----|
|Description|Unique identifier for Purchase Order Product associated with Purchase Order Receipt Product.|
|DisplayName|Purchase Order Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderproduct|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_purchaseorderproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrderReceipt"></a> msdyn_PurchaseOrderReceipt

|Property|Value|
|--------|-----|
|Description|Unique identifier for Purchase Order Receipt associated with Purchase Order Receipt Product.|
|DisplayName|Purchase Order Receipt|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderreceipt|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_purchaseorderreceipt|
|Type|Lookup|


### <a name="BKMK_msdyn_purchaseorderreceiptproductId"></a> msdyn_purchaseorderreceiptproductId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Purchase Order Receipt Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_purchaseorderreceiptproductid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quantity|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unit Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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
|Description|Status of the Purchase Order Receipt Product|
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
|Description|Reason for the status of the Purchase Order Receipt Product|
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
- [msdyn_AssociateToBookingName](#BKMK_msdyn_AssociateToBookingName)
- [msdyn_AssociateToWarehouseName](#BKMK_msdyn_AssociateToWarehouseName)
- [msdyn_AssociateToWorkOrderName](#BKMK_msdyn_AssociateToWorkOrderName)
- [msdyn_PurchaseOrderBillName](#BKMK_msdyn_PurchaseOrderBillName)
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_PurchaseOrderProductName](#BKMK_msdyn_PurchaseOrderProductName)
- [msdyn_PurchaseOrderReceiptName](#BKMK_msdyn_PurchaseOrderReceiptName)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
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


### <a name="BKMK_msdyn_AssociateToBookingName"></a> msdyn_AssociateToBookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_associatetobookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AssociateToWarehouseName"></a> msdyn_AssociateToWarehouseName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_associatetowarehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AssociateToWorkOrderName"></a> msdyn_AssociateToWorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_associatetoworkordername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderBillName"></a> msdyn_PurchaseOrderBillName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderbillname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderName"></a> msdyn_PurchaseOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseordername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderProductName"></a> msdyn_PurchaseOrderProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderproductname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderReceiptName"></a> msdyn_PurchaseOrderReceiptName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderreceiptname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total cost in the base currency.|
|DisplayName|Total Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitcost_Base"></a> msdyn_unitcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the unit cost in the base currency.|
|DisplayName|Unit Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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

- [msdyn_purchaseorderreceiptproduct_ActivityPointers](#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)
- [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts)
- [msdyn_purchaseorderreceiptproduct_msdyn_approvals](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals)
- [msdyn_purchaseorderreceiptproduct_SyncErrors](#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors)
- [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord)
- [msdyn_purchaseorderreceiptproduct_AsyncOperations](#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations)
- [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders)
- [msdyn_purchaseorderreceiptproduct_ProcessSession](#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession)
- [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures)
- [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceiptproduct_Appointments](#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)
- [msdyn_purchaseorderreceiptproduct_Emails](#BKMK_msdyn_purchaseorderreceiptproduct_Emails)
- [msdyn_purchaseorderreceiptproduct_Faxes](#BKMK_msdyn_purchaseorderreceiptproduct_Faxes)
- [msdyn_purchaseorderreceiptproduct_Letters](#BKMK_msdyn_purchaseorderreceiptproduct_Letters)
- [msdyn_purchaseorderreceiptproduct_PhoneCalls](#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)
- [msdyn_purchaseorderreceiptproduct_Tasks](#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)
- [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceiptproduct_SocialActivities](#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities)
- [msdyn_purchaseorderreceiptproduct_connections1](#BKMK_msdyn_purchaseorderreceiptproduct_connections1)
- [msdyn_purchaseorderreceiptproduct_connections2](#BKMK_msdyn_purchaseorderreceiptproduct_connections2)
- [msdyn_purchaseorderreceiptproduct_Annotations](#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)
- [msdyn_purchaseorderreceiptproduct_ServiceAppointments](#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct)


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_purchaseorderreceiptproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts"></a> msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals"></a> msdyn_purchaseorderreceiptproduct_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_purchaseorderreceiptproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors"></a> msdyn_purchaseorderreceiptproduct_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_purchaseorderreceiptproduct_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations"></a> msdyn_purchaseorderreceiptproduct_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_purchaseorderreceiptproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession"></a> msdyn_purchaseorderreceiptproduct_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_purchaseorderreceiptproduct_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures"></a> msdyn_purchaseorderreceiptproduct_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_purchaseorderreceiptproduct_Appointments](appointment.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Emails"></a> msdyn_purchaseorderreceiptproduct_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_purchaseorderreceiptproduct_Emails](email.md#BKMK_msdyn_purchaseorderreceiptproduct_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Faxes"></a> msdyn_purchaseorderreceiptproduct_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_purchaseorderreceiptproduct_Faxes](fax.md#BKMK_msdyn_purchaseorderreceiptproduct_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Letters"></a> msdyn_purchaseorderreceiptproduct_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_purchaseorderreceiptproduct_Letters](letter.md#BKMK_msdyn_purchaseorderreceiptproduct_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls"></a> msdyn_purchaseorderreceiptproduct_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_purchaseorderreceiptproduct_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_purchaseorderreceiptproduct_Tasks](task.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities"></a> msdyn_purchaseorderreceiptproduct_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_purchaseorderreceiptproduct_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections1"></a> msdyn_purchaseorderreceiptproduct_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorderreceiptproduct_connections1](connection.md#BKMK_msdyn_purchaseorderreceiptproduct_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections2"></a> msdyn_purchaseorderreceiptproduct_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorderreceiptproduct_connections2](connection.md#BKMK_msdyn_purchaseorderreceiptproduct_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Annotations"></a> msdyn_purchaseorderreceiptproduct_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_purchaseorderreceiptproduct_Annotations](annotation.md#BKMK_msdyn_purchaseorderreceiptproduct_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments"></a> msdyn_purchaseorderreceiptproduct_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_purchaseorderreceiptproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderreceiptproduct_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_purchaseorderreceiptproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct

Same as msdyn_workorderproduct entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_purchaseorderreceiptproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_purchaseorderreceiptproduct_createdby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby)
- [lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby)
- [lk_msdyn_purchaseorderreceiptproduct_modifiedby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby)
- [lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby)
- [user_msdyn_purchaseorderreceiptproduct](#BKMK_user_msdyn_purchaseorderreceiptproduct)
- [team_msdyn_purchaseorderreceiptproduct](#BKMK_team_msdyn_purchaseorderreceiptproduct)
- [business_unit_msdyn_purchaseorderreceiptproduct](#BKMK_business_unit_msdyn_purchaseorderreceiptproduct)
- [TransactionCurrency_msdyn_purchaseorderreceiptproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder)
- [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill)
- [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct)
- [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse)
- [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder)


### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby"></a> lk_msdyn_purchaseorderreceiptproduct_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby"></a> lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby"></a> lk_msdyn_purchaseorderreceiptproduct_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby"></a> lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceiptproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderreceiptproduct"></a> user_msdyn_purchaseorderreceiptproduct

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_purchaseorderreceiptproduct](systemuser.md#BKMK_user_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

**Added by**: System Solution Solution

See team Entity [team_msdyn_purchaseorderreceiptproduct](team.md#BKMK_team_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderreceiptproduct"></a> business_unit_msdyn_purchaseorderreceiptproduct

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_purchaseorderreceiptproduct](businessunit.md#BKMK_business_unit_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorderreceiptproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill"></a> msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill

See msdyn_purchaseorderbill Entity [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct

See msdyn_purchaseorderproduct Entity [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt"></a> msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt

See msdyn_purchaseorderreceipt Entity [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](msdyn_purchaseorderreceipt.md#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderreceiptproduct?text=msdyn_purchaseorderreceiptproduct EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]