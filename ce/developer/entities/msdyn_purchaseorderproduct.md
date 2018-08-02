---
title: "msdyn_purchaseorderproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderproduct entity."
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
# msdyn_purchaseorderproduct Entity Reference

Record products to be ordered on purchase order

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts(*msdyn_purchaseorderproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts(*msdyn_purchaseorderproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts(*msdyn_purchaseorderproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts(*msdyn_purchaseorderproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderproducts(*msdyn_purchaseorderproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_purchaseorderproducts|
|DisplayCollectionName|Purchase Order Products|
|DisplayName|Purchase Order Product|
|EntitySetName|msdyn_purchaseorderproducts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_purchaseorderproducts|
|LogicalName|msdyn_purchaseorderproduct|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_purchaseorderproductid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_purchaseorderproduct|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AssociateToBooking](#BKMK_msdyn_AssociateToBooking)
- [msdyn_AssociateToWarehouse](#BKMK_msdyn_AssociateToWarehouse)
- [msdyn_AssociateToWorkOrder](#BKMK_msdyn_AssociateToWorkOrder)
- [msdyn_DateExpected](#BKMK_msdyn_DateExpected)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IsOrdered](#BKMK_msdyn_IsOrdered)
- [msdyn_ItemStatus](#BKMK_msdyn_ItemStatus)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_purchaseorderproductId](#BKMK_msdyn_purchaseorderproductId)
- [msdyn_QtyBilled](#BKMK_msdyn_QtyBilled)
- [msdyn_QtyReceived](#BKMK_msdyn_QtyReceived)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_Unit](#BKMK_msdyn_Unit)
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
|Description|Link this product to Booking. If specified and warehouse is not set then product will be added to Resource Booking|
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
|Description|Warehouse to which this product should be received to|
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
|Description|Link this product to Work Order. If specified and warehouse is not set then product will be added to work order|
|DisplayName|Associate To Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_associatetoworkorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_DateExpected"></a> msdyn_DateExpected

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date you expect this product to arrive to the shipping address. This value defaults to the date set on the PO.|
|DisplayName|Date Expected|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_dateexpected|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|--------|-----|
|Description|Enter the product description to display for the vendor.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_IsOrdered"></a> msdyn_IsOrdered

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Ordered|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isordered|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsOrdered Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_ItemStatus"></a> msdyn_ItemStatus

|Property|Value|
|--------|-----|
|Description|Enter the current status of this product.|
|DisplayName|Item Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_itemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_ItemStatus Options

|Value|Label|
|-----|-----|
|690970000|Pending|
|690970001|Received|
|690970002|Canceled|



### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|--------|-----|
|Description|Shows the order of this product within the purchase order.|
|DisplayName|Line Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lineorder|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description|Product to order|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_product|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

|Property|Value|
|--------|-----|
|Description|Purchase order this line item relates to|
|DisplayName|Purchase Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_purchaseorder|
|Type|Lookup|


### <a name="BKMK_msdyn_purchaseorderproductId"></a> msdyn_purchaseorderproductId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Purchase Order Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_purchaseorderproductid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_QtyBilled"></a> msdyn_QtyBilled

|Property|Value|
|--------|-----|
|Description|Enter the quantity currently billed.|
|DisplayName|Quantity Billed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtybilled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_QtyReceived"></a> msdyn_QtyReceived

|Property|Value|
|--------|-----|
|Description|Enter the quantity currently received.|
|DisplayName|Quantity Received|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtyreceived|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|--------|-----|
|Description|Enter the quantity ordered.|
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
|Description|Shows the total cost of this product. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs|
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


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|--------|-----|
|Description|Unit for this product|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

|Property|Value|
|--------|-----|
|Description|Enter the cost of this product per unit.|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Purchase Order Product|
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
|Description|Reason for the status of the Purchase Order Product|
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
- [msdyn_AssociateToBookingName](#BKMK_msdyn_AssociateToBookingName)
- [msdyn_AssociateToWarehouseName](#BKMK_msdyn_AssociateToWarehouseName)
- [msdyn_AssociateToWorkOrderName](#BKMK_msdyn_AssociateToWorkOrderName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

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


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_productname|
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


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitname|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_purchaseorderproduct_ActivityPointers](#BKMK_msdyn_purchaseorderproduct_ActivityPointers)
- [msdyn_purchaseorderproduct_msdyn_approvals](#BKMK_msdyn_purchaseorderproduct_msdyn_approvals)
- [msdyn_purchaseorderproduct_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts)
- [msdyn_purchaseorderproduct_SyncErrors](#BKMK_msdyn_purchaseorderproduct_SyncErrors)
- [msdyn_purchaseorderproduct_SharePointDocumentLocations](#BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations)
- [msdyn_purchaseorderproduct_SharePointDocuments](#BKMK_msdyn_purchaseorderproduct_SharePointDocuments)
- [msdyn_purchaseorderproduct_AsyncOperations](#BKMK_msdyn_purchaseorderproduct_AsyncOperations)
- [msdyn_purchaseorderproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders)
- [msdyn_purchaseorderproduct_UserEntityInstanceDatas](#BKMK_msdyn_purchaseorderproduct_UserEntityInstanceDatas)
- [msdyn_purchaseorderproduct_ProcessSession](#BKMK_msdyn_purchaseorderproduct_ProcessSession)
- [msdyn_purchaseorderproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures)
- [msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderproduct_Appointments](#BKMK_msdyn_purchaseorderproduct_Appointments)
- [msdyn_purchaseorderproduct_Emails](#BKMK_msdyn_purchaseorderproduct_Emails)
- [msdyn_purchaseorderproduct_Faxes](#BKMK_msdyn_purchaseorderproduct_Faxes)
- [msdyn_purchaseorderproduct_Letters](#BKMK_msdyn_purchaseorderproduct_Letters)
- [msdyn_purchaseorderproduct_PhoneCalls](#BKMK_msdyn_purchaseorderproduct_PhoneCalls)
- [msdyn_purchaseorderproduct_Tasks](#BKMK_msdyn_purchaseorderproduct_Tasks)
- [msdyn_purchaseorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderproduct_SocialActivities](#BKMK_msdyn_purchaseorderproduct_SocialActivities)
- [msdyn_purchaseorderproduct_connections1](#BKMK_msdyn_purchaseorderproduct_connections1)
- [msdyn_purchaseorderproduct_connections2](#BKMK_msdyn_purchaseorderproduct_connections2)
- [msdyn_purchaseorderproduct_Annotations](#BKMK_msdyn_purchaseorderproduct_Annotations)
- [msdyn_purchaseorderproduct_ServiceAppointments](#BKMK_msdyn_purchaseorderproduct_ServiceAppointments)
- [msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct)
- [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct)


### <a name="BKMK_msdyn_purchaseorderproduct_ActivityPointers"></a> msdyn_purchaseorderproduct_ActivityPointers

Same as activitypointer entity [msdyn_purchaseorderproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderproduct_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_approvals"></a> msdyn_purchaseorderproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_purchaseorderproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderproduct_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts"></a> msdyn_purchaseorderproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_purchaseorderproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_SyncErrors"></a> msdyn_purchaseorderproduct_SyncErrors

Same as syncerror entity [msdyn_purchaseorderproduct_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderproduct_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations"></a> msdyn_purchaseorderproduct_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_purchaseorderproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_SharePointDocuments"></a> msdyn_purchaseorderproduct_SharePointDocuments

Same as sharepointdocument entity [msdyn_purchaseorderproduct_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_purchaseorderproduct_SharePointDocuments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocument|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_SharePointDocuments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 60|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_AsyncOperations"></a> msdyn_purchaseorderproduct_AsyncOperations

Same as asyncoperation entity [msdyn_purchaseorderproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderproduct_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_purchaseorderproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_UserEntityInstanceDatas"></a> msdyn_purchaseorderproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_purchaseorderproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_purchaseorderproduct_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_ProcessSession"></a> msdyn_purchaseorderproduct_ProcessSession

Same as processsession entity [msdyn_purchaseorderproduct_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderproduct_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures"></a> msdyn_purchaseorderproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_purchaseorderproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Appointments"></a> msdyn_purchaseorderproduct_Appointments

Same as appointment entity [msdyn_purchaseorderproduct_Appointments](appointment.md#BKMK_msdyn_purchaseorderproduct_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Emails"></a> msdyn_purchaseorderproduct_Emails

Same as email entity [msdyn_purchaseorderproduct_Emails](email.md#BKMK_msdyn_purchaseorderproduct_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Faxes"></a> msdyn_purchaseorderproduct_Faxes

Same as fax entity [msdyn_purchaseorderproduct_Faxes](fax.md#BKMK_msdyn_purchaseorderproduct_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Letters"></a> msdyn_purchaseorderproduct_Letters

Same as letter entity [msdyn_purchaseorderproduct_Letters](letter.md#BKMK_msdyn_purchaseorderproduct_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_PhoneCalls"></a> msdyn_purchaseorderproduct_PhoneCalls

Same as phonecall entity [msdyn_purchaseorderproduct_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderproduct_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Tasks"></a> msdyn_purchaseorderproduct_Tasks

Same as task entity [msdyn_purchaseorderproduct_Tasks](task.md#BKMK_msdyn_purchaseorderproduct_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_purchaseorderproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_SocialActivities"></a> msdyn_purchaseorderproduct_SocialActivities

Same as socialactivity entity [msdyn_purchaseorderproduct_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderproduct_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_connections1"></a> msdyn_purchaseorderproduct_connections1

Same as connection entity [msdyn_purchaseorderproduct_connections1](connection.md#BKMK_msdyn_purchaseorderproduct_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_connections2"></a> msdyn_purchaseorderproduct_connections2

Same as connection entity [msdyn_purchaseorderproduct_connections2](connection.md#BKMK_msdyn_purchaseorderproduct_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderproduct_Annotations"></a> msdyn_purchaseorderproduct_Annotations

Same as annotation entity [msdyn_purchaseorderproduct_Annotations](annotation.md#BKMK_msdyn_purchaseorderproduct_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderproduct_ServiceAppointments"></a> msdyn_purchaseorderproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_purchaseorderproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderproduct_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderproduct_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_purchaseorderproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct"></a> msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|msdyn_purchaseorderproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorderproduct_msdyn_purchaseorderreceiptproduct_POProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_purchaseorderproduct_createdby](#BKMK_lk_msdyn_purchaseorderproduct_createdby)
- [lk_msdyn_purchaseorderproduct_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderproduct_createdonbehalfby)
- [lk_msdyn_purchaseorderproduct_modifiedby](#BKMK_lk_msdyn_purchaseorderproduct_modifiedby)
- [lk_msdyn_purchaseorderproduct_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderproduct_modifiedonbehalfby)
- [user_msdyn_purchaseorderproduct](#BKMK_user_msdyn_purchaseorderproduct)
- [team_msdyn_purchaseorderproduct](#BKMK_team_msdyn_purchaseorderproduct)
- [business_unit_msdyn_purchaseorderproduct](#BKMK_business_unit_msdyn_purchaseorderproduct)
- [TransactionCurrency_msdyn_purchaseorderproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)
- [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse)
- [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder)
- [msdyn_product_msdyn_purchaseorderproduct_Product](#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product)
- [msdyn_uom_msdyn_purchaseorderproduct_Unit](#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit)


### <a name="BKMK_lk_msdyn_purchaseorderproduct_createdby"></a> lk_msdyn_purchaseorderproduct_createdby

See systemuser Entity [lk_msdyn_purchaseorderproduct_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderproduct_createdonbehalfby"></a> lk_msdyn_purchaseorderproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderproduct_modifiedby"></a> lk_msdyn_purchaseorderproduct_modifiedby

See systemuser Entity [lk_msdyn_purchaseorderproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderproduct_modifiedonbehalfby"></a> lk_msdyn_purchaseorderproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderproduct"></a> user_msdyn_purchaseorderproduct

See systemuser Entity [user_msdyn_purchaseorderproduct](systemuser.md#BKMK_user_msdyn_purchaseorderproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderproduct"></a> team_msdyn_purchaseorderproduct

See team Entity [team_msdyn_purchaseorderproduct](team.md#BKMK_team_msdyn_purchaseorderproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderproduct"></a> business_unit_msdyn_purchaseorderproduct

See businessunit Entity [business_unit_msdyn_purchaseorderproduct](businessunit.md#BKMK_business_unit_msdyn_purchaseorderproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderproduct"></a> TransactionCurrency_msdyn_purchaseorderproduct

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorderproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorderproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_purchaseorderproduct_Product"></a> msdyn_product_msdyn_purchaseorderproduct_Product

See product Entity [msdyn_product_msdyn_purchaseorderproduct_Product](product.md#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit"></a> msdyn_uom_msdyn_purchaseorderproduct_Unit

See uom Entity [msdyn_uom_msdyn_purchaseorderproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderproduct?text=msdyn_purchaseorderproduct EntityType" />