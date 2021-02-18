---
title: "msdyn_purchaseorderbill Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderbill entity."
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
# msdyn_purchaseorderbill Entity Reference

Specify purchase order bill.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderbills(*msdyn_purchaseorderbillid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_purchaseorderbills|
|DisplayCollectionName|Purchase Order Bills|
|DisplayName|Purchase Order Bill|
|EntitySetName|msdyn_purchaseorderbills|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_purchaseorderbills|
|LogicalName|msdyn_purchaseorderbill|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_purchaseorderbillid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_purchaseorderbill|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BillDate](#BKMK_msdyn_BillDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Note](#BKMK_msdyn_Note)
- [msdyn_PaymentTerm](#BKMK_msdyn_PaymentTerm)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_purchaseorderbillId](#BKMK_msdyn_purchaseorderbillId)
- [msdyn_ShippingAmount](#BKMK_msdyn_ShippingAmount)
- [msdyn_Subtotal](#BKMK_msdyn_Subtotal)
- [msdyn_TaxAmount](#BKMK_msdyn_TaxAmount)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_VendorInvoiceNumber](#BKMK_msdyn_VendorInvoiceNumber)
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


### <a name="BKMK_msdyn_BillDate"></a> msdyn_BillDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Bill Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


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


### <a name="BKMK_msdyn_Note"></a> msdyn_Note

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Note|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_note|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_PaymentTerm"></a> msdyn_PaymentTerm

|Property|Value|
|--------|-----|
|Description|Unique identifier for Payment Term associated with Purchase Order Bill.|
|DisplayName|Payment Term|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymentterm|
|RequiredLevel|None|
|Targets|msdyn_paymentterm|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Purchase Order associated with Purchase Order Bill.|
|DisplayName|Purchase Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_purchaseorder|
|Type|Lookup|


### <a name="BKMK_msdyn_purchaseorderbillId"></a> msdyn_purchaseorderbillId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Purchase Order Bill|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_purchaseorderbillid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ShippingAmount"></a> msdyn_ShippingAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Shipping Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shippingamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Subtotal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotal|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_TaxAmount"></a> msdyn_TaxAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Tax Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

|Property|Value|
|--------|-----|
|Description|Unique identifier for Tax Code associated with Purchase Order Bill.|
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
|Description||
|DisplayName|Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_VendorInvoiceNumber"></a> msdyn_VendorInvoiceNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Vendor Invoice Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendorinvoicenumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Contains the ID of the process associated with the entity.|
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
|Description|Contains the ID of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Purchase Order Bill|
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
|Description|Reason for the status of the Purchase Order Bill|
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
|Description|Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.|
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
- [msdyn_PaymentTermName](#BKMK_msdyn_PaymentTermName)
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_shippingamount_Base](#BKMK_msdyn_shippingamount_Base)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_taxamount_Base](#BKMK_msdyn_taxamount_Base)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
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


### <a name="BKMK_msdyn_PaymentTermName"></a> msdyn_PaymentTermName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_paymenttermname|
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


### <a name="BKMK_msdyn_shippingamount_Base"></a> msdyn_shippingamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the shipping amount in the base currency.|
|DisplayName|Shipping Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shippingamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_subtotal_Base"></a> msdyn_subtotal_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the subtotal in the base currency.|
|DisplayName|Subtotal (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotal_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_taxamount_Base"></a> msdyn_taxamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the tax amount in the base currency.|
|DisplayName|Tax Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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

- [msdyn_purchaseorderbill_ActivityPointers](#BKMK_msdyn_purchaseorderbill_ActivityPointers)
- [msdyn_purchaseorderbill_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts)
- [msdyn_purchaseorderbill_msdyn_approvals](#BKMK_msdyn_purchaseorderbill_msdyn_approvals)
- [msdyn_purchaseorderbill_SyncErrors](#BKMK_msdyn_purchaseorderbill_SyncErrors)
- [msdyn_purchaseorderbill_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord)
- [msdyn_purchaseorderbill_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord)
- [msdyn_purchaseorderbill_AsyncOperations](#BKMK_msdyn_purchaseorderbill_AsyncOperations)
- [msdyn_purchaseorderbill_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders)
- [msdyn_purchaseorderbill_ProcessSession](#BKMK_msdyn_purchaseorderbill_ProcessSession)
- [msdyn_purchaseorderbill_BulkDeleteFailures](#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures)
- [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderbill_Appointments](#BKMK_msdyn_purchaseorderbill_Appointments)
- [msdyn_purchaseorderbill_Emails](#BKMK_msdyn_purchaseorderbill_Emails)
- [msdyn_purchaseorderbill_Faxes](#BKMK_msdyn_purchaseorderbill_Faxes)
- [msdyn_purchaseorderbill_Letters](#BKMK_msdyn_purchaseorderbill_Letters)
- [msdyn_purchaseorderbill_PhoneCalls](#BKMK_msdyn_purchaseorderbill_PhoneCalls)
- [msdyn_purchaseorderbill_Tasks](#BKMK_msdyn_purchaseorderbill_Tasks)
- [msdyn_purchaseorderbill_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)
- [msdyn_purchaseorderbill_SocialActivities](#BKMK_msdyn_purchaseorderbill_SocialActivities)
- [msdyn_purchaseorderbill_connections1](#BKMK_msdyn_purchaseorderbill_connections1)
- [msdyn_purchaseorderbill_connections2](#BKMK_msdyn_purchaseorderbill_connections2)
- [msdyn_purchaseorderbill_Annotations](#BKMK_msdyn_purchaseorderbill_Annotations)
- [msdyn_purchaseorderbill_ServiceAppointments](#BKMK_msdyn_purchaseorderbill_ServiceAppointments)
- [bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill)


### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_purchaseorderbill_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderbill_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts"></a> msdyn_purchaseorderbill_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_purchaseorderbill_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_msdyn_approvals"></a> msdyn_purchaseorderbill_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_purchaseorderbill_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderbill_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_SyncErrors"></a> msdyn_purchaseorderbill_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_purchaseorderbill_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderbill_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord"></a> msdyn_purchaseorderbill_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorderbill_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord"></a> msdyn_purchaseorderbill_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorderbill_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_AsyncOperations"></a> msdyn_purchaseorderbill_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_purchaseorderbill_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderbill_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders"></a> msdyn_purchaseorderbill_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_purchaseorderbill_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_ProcessSession"></a> msdyn_purchaseorderbill_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_purchaseorderbill_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderbill_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_BulkDeleteFailures"></a> msdyn_purchaseorderbill_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_purchaseorderbill_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_purchaseorderbill_Appointments](appointment.md#BKMK_msdyn_purchaseorderbill_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_Emails"></a> msdyn_purchaseorderbill_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_purchaseorderbill_Emails](email.md#BKMK_msdyn_purchaseorderbill_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_Faxes"></a> msdyn_purchaseorderbill_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_purchaseorderbill_Faxes](fax.md#BKMK_msdyn_purchaseorderbill_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_Letters"></a> msdyn_purchaseorderbill_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_purchaseorderbill_Letters](letter.md#BKMK_msdyn_purchaseorderbill_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_PhoneCalls"></a> msdyn_purchaseorderbill_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_purchaseorderbill_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderbill_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_purchaseorderbill_Tasks](task.md#BKMK_msdyn_purchaseorderbill_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_purchaseorderbill_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_SocialActivities"></a> msdyn_purchaseorderbill_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_purchaseorderbill_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderbill_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_connections1"></a> msdyn_purchaseorderbill_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorderbill_connections1](connection.md#BKMK_msdyn_purchaseorderbill_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_connections2"></a> msdyn_purchaseorderbill_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorderbill_connections2](connection.md#BKMK_msdyn_purchaseorderbill_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorderbill_Annotations"></a> msdyn_purchaseorderbill_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_purchaseorderbill_Annotations](annotation.md#BKMK_msdyn_purchaseorderbill_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorderbill_ServiceAppointments"></a> msdyn_purchaseorderbill_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_purchaseorderbill_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderbill_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorderbill_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|ReferencingAttribute|bpf_msdyn_purchaseorderbillid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_purchaseorderbill_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_purchaseorderbill<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill"></a> msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|msdyn_purchaseorderbill|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorderbill_msdyn_purchaseorderreceiptproduct_PurchaseOrderBill|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_purchaseorderbill_createdby](#BKMK_lk_msdyn_purchaseorderbill_createdby)
- [lk_msdyn_purchaseorderbill_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby)
- [lk_msdyn_purchaseorderbill_modifiedby](#BKMK_lk_msdyn_purchaseorderbill_modifiedby)
- [lk_msdyn_purchaseorderbill_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby)
- [user_msdyn_purchaseorderbill](#BKMK_user_msdyn_purchaseorderbill)
- [team_msdyn_purchaseorderbill](#BKMK_team_msdyn_purchaseorderbill)
- [business_unit_msdyn_purchaseorderbill](#BKMK_business_unit_msdyn_purchaseorderbill)
- [processstage_msdyn_purchaseorderbill](#BKMK_processstage_msdyn_purchaseorderbill)
- [TransactionCurrency_msdyn_purchaseorderbill](#BKMK_TransactionCurrency_msdyn_purchaseorderbill)
- [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder)
- [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode)


### <a name="BKMK_lk_msdyn_purchaseorderbill_createdby"></a> lk_msdyn_purchaseorderbill_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderbill_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby"></a> lk_msdyn_purchaseorderbill_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderbill_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_modifiedby"></a> lk_msdyn_purchaseorderbill_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderbill_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby"></a> lk_msdyn_purchaseorderbill_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorderbill_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderbill_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderbill"></a> user_msdyn_purchaseorderbill

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_purchaseorderbill](systemuser.md#BKMK_user_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

**Added by**: System Solution Solution

See team Entity [team_msdyn_purchaseorderbill](team.md#BKMK_team_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderbill"></a> business_unit_msdyn_purchaseorderbill

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_purchaseorderbill](businessunit.md#BKMK_business_unit_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_purchaseorderbill"></a> processstage_msdyn_purchaseorderbill

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_purchaseorderbill](processstage.md#BKMK_processstage_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorderbill](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm"></a> msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm

See msdyn_paymentterm Entity [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](msdyn_paymentterm.md#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderbill?text=msdyn_purchaseorderbill EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]