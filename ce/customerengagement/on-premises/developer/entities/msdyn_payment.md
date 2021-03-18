---
title: "msdyn_payment Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_payment entity."
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
# msdyn_payment Entity Reference

Specify payment.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_payments(*msdyn_paymentid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_payments<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_payments(*msdyn_paymentid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_payments(*msdyn_paymentid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_payments<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_payments(*msdyn_paymentid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_payments(*msdyn_paymentid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_payments|
|DisplayCollectionName|Payments|
|DisplayName|Payment|
|EntitySetName|msdyn_payments|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_payments|
|LogicalName|msdyn_payment|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_paymentid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_payment|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_CheckNumber](#BKMK_msdyn_CheckNumber)
- [msdyn_Date](#BKMK_msdyn_Date)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_paymentId](#BKMK_msdyn_paymentId)
- [msdyn_PaymentMethod](#BKMK_msdyn_PaymentMethod)
- [msdyn_PaymentType](#BKMK_msdyn_PaymentType)
- [msdyn_UnappliedAmount](#BKMK_msdyn_UnappliedAmount)
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


### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|--------|-----|
|Description|Unique identifier for Account associated with Payment.|
|DisplayName|Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_account|
|RequiredLevel|ApplicationRequired|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_CheckNumber"></a> msdyn_CheckNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Check Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_checknumber|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_Date"></a> msdyn_Date

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_date|
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
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_paymentId"></a> msdyn_paymentId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Payment|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_paymentid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_PaymentMethod"></a> msdyn_PaymentMethod

|Property|Value|
|--------|-----|
|Description|Unique identifier for Payment Method associated with Payment.|
|DisplayName|Payment Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymentmethod|
|RequiredLevel|Recommended|
|Targets|msdyn_paymentmethod|
|Type|Lookup|


### <a name="BKMK_msdyn_PaymentType"></a> msdyn_PaymentType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Payment Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymenttype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_PaymentType Options

|Value|Label|
|-----|-----|
|690970000|Cash|
|690970001|Check|
|690970002|Credit Card|
|690970003|Other|



### <a name="BKMK_msdyn_UnappliedAmount"></a> msdyn_UnappliedAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unapplied Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unappliedamount|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|Recommended|
|Type|Money|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Payment.|
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
|Description|Status of the Payment|
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
|Description|Reason for the status of the Payment|
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
- [msdyn_AccountName](#BKMK_msdyn_AccountName)
- [msdyn_AccountYomiName](#BKMK_msdyn_AccountYomiName)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_PaymentMethodName](#BKMK_msdyn_PaymentMethodName)
- [msdyn_unappliedamount_Base](#BKMK_msdyn_unappliedamount_Base)
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


### <a name="BKMK_msdyn_AccountName"></a> msdyn_AccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AccountYomiName"></a> msdyn_AccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the amount in the base currency.|
|DisplayName|Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PaymentMethodName"></a> msdyn_PaymentMethodName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_paymentmethodname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_unappliedamount_Base"></a> msdyn_unappliedamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the unapplied amount in the base currency.|
|DisplayName|Unapplied Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unappliedamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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

- [msdyn_payment_ActivityPointers](#BKMK_msdyn_payment_ActivityPointers)
- [msdyn_payment_msdyn_bookingalerts](#BKMK_msdyn_payment_msdyn_bookingalerts)
- [msdyn_payment_msdyn_approvals](#BKMK_msdyn_payment_msdyn_approvals)
- [msdyn_payment_SyncErrors](#BKMK_msdyn_payment_SyncErrors)
- [msdyn_payment_DuplicateMatchingRecord](#BKMK_msdyn_payment_DuplicateMatchingRecord)
- [msdyn_payment_DuplicateBaseRecord](#BKMK_msdyn_payment_DuplicateBaseRecord)
- [msdyn_payment_AsyncOperations](#BKMK_msdyn_payment_AsyncOperations)
- [msdyn_payment_MailboxTrackingFolders](#BKMK_msdyn_payment_MailboxTrackingFolders)
- [msdyn_payment_ProcessSession](#BKMK_msdyn_payment_ProcessSession)
- [msdyn_payment_BulkDeleteFailures](#BKMK_msdyn_payment_BulkDeleteFailures)
- [msdyn_payment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses)
- [msdyn_payment_Appointments](#BKMK_msdyn_payment_Appointments)
- [msdyn_payment_Emails](#BKMK_msdyn_payment_Emails)
- [msdyn_payment_Faxes](#BKMK_msdyn_payment_Faxes)
- [msdyn_payment_Letters](#BKMK_msdyn_payment_Letters)
- [msdyn_payment_PhoneCalls](#BKMK_msdyn_payment_PhoneCalls)
- [msdyn_payment_Tasks](#BKMK_msdyn_payment_Tasks)
- [msdyn_payment_RecurringAppointmentMasters](#BKMK_msdyn_payment_RecurringAppointmentMasters)
- [msdyn_payment_SocialActivities](#BKMK_msdyn_payment_SocialActivities)
- [msdyn_payment_connections1](#BKMK_msdyn_payment_connections1)
- [msdyn_payment_connections2](#BKMK_msdyn_payment_connections2)
- [msdyn_payment_Annotations](#BKMK_msdyn_payment_Annotations)
- [msdyn_payment_ServiceAppointments](#BKMK_msdyn_payment_ServiceAppointments)
- [msdyn_msdyn_payment_msdyn_paymentdetail_Payment](#BKMK_msdyn_msdyn_payment_msdyn_paymentdetail_Payment)


### <a name="BKMK_msdyn_payment_ActivityPointers"></a> msdyn_payment_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_payment_ActivityPointers](activitypointer.md#BKMK_msdyn_payment_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_msdyn_bookingalerts"></a> msdyn_payment_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_payment_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_payment_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_msdyn_approvals"></a> msdyn_payment_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_payment_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_payment_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_SyncErrors"></a> msdyn_payment_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_payment_SyncErrors](syncerror.md#BKMK_msdyn_payment_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_DuplicateMatchingRecord"></a> msdyn_payment_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_payment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_payment_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_DuplicateBaseRecord"></a> msdyn_payment_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_payment_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_payment_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_AsyncOperations"></a> msdyn_payment_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_payment_AsyncOperations](asyncoperation.md#BKMK_msdyn_payment_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_MailboxTrackingFolders"></a> msdyn_payment_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_payment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_payment_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_ProcessSession"></a> msdyn_payment_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_payment_ProcessSession](processsession.md#BKMK_msdyn_payment_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_BulkDeleteFailures"></a> msdyn_payment_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_payment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_payment_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_PrincipalObjectAttributeAccesses"></a> msdyn_payment_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_payment_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_Appointments"></a> msdyn_payment_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_payment_Appointments](appointment.md#BKMK_msdyn_payment_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_Emails"></a> msdyn_payment_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_payment_Emails](email.md#BKMK_msdyn_payment_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_Faxes"></a> msdyn_payment_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_payment_Faxes](fax.md#BKMK_msdyn_payment_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_Letters"></a> msdyn_payment_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_payment_Letters](letter.md#BKMK_msdyn_payment_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_PhoneCalls"></a> msdyn_payment_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_payment_PhoneCalls](phonecall.md#BKMK_msdyn_payment_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_Tasks"></a> msdyn_payment_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_payment_Tasks](task.md#BKMK_msdyn_payment_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_RecurringAppointmentMasters"></a> msdyn_payment_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_payment_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_payment_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_SocialActivities"></a> msdyn_payment_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_payment_SocialActivities](socialactivity.md#BKMK_msdyn_payment_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_connections1"></a> msdyn_payment_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_payment_connections1](connection.md#BKMK_msdyn_payment_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_connections2"></a> msdyn_payment_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_payment_connections2](connection.md#BKMK_msdyn_payment_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_payment_Annotations"></a> msdyn_payment_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_payment_Annotations](annotation.md#BKMK_msdyn_payment_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_payment_ServiceAppointments"></a> msdyn_payment_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_payment_ServiceAppointments](serviceappointment.md#BKMK_msdyn_payment_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_payment_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_payment_msdyn_paymentdetail_Payment"></a> msdyn_msdyn_payment_msdyn_paymentdetail_Payment

Same as msdyn_paymentdetail entity [msdyn_msdyn_payment_msdyn_paymentdetail_Payment](msdyn_paymentdetail.md#BKMK_msdyn_msdyn_payment_msdyn_paymentdetail_Payment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentdetail|
|ReferencingAttribute|msdyn_payment|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_payment_msdyn_paymentdetail_Payment|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_payment_createdby](#BKMK_lk_msdyn_payment_createdby)
- [lk_msdyn_payment_createdonbehalfby](#BKMK_lk_msdyn_payment_createdonbehalfby)
- [lk_msdyn_payment_modifiedby](#BKMK_lk_msdyn_payment_modifiedby)
- [lk_msdyn_payment_modifiedonbehalfby](#BKMK_lk_msdyn_payment_modifiedonbehalfby)
- [user_msdyn_payment](#BKMK_user_msdyn_payment)
- [team_msdyn_payment](#BKMK_team_msdyn_payment)
- [business_unit_msdyn_payment](#BKMK_business_unit_msdyn_payment)
- [TransactionCurrency_msdyn_payment](#BKMK_TransactionCurrency_msdyn_payment)
- [msdyn_account_msdyn_payment_Account](#BKMK_msdyn_account_msdyn_payment_Account)
- [msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod](#BKMK_msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod)
- [msdyn_msdyn_workorder_msdyn_payment_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder)


### <a name="BKMK_lk_msdyn_payment_createdby"></a> lk_msdyn_payment_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_payment_createdby](systemuser.md#BKMK_lk_msdyn_payment_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_payment_createdonbehalfby"></a> lk_msdyn_payment_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_payment_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_payment_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_payment_modifiedby"></a> lk_msdyn_payment_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_payment_modifiedby](systemuser.md#BKMK_lk_msdyn_payment_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_payment_modifiedonbehalfby"></a> lk_msdyn_payment_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_payment_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_payment_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_payment"></a> user_msdyn_payment

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_payment](systemuser.md#BKMK_user_msdyn_payment) One-To-Many relationship.

### <a name="BKMK_team_msdyn_payment"></a> team_msdyn_payment

**Added by**: System Solution Solution

See team Entity [team_msdyn_payment](team.md#BKMK_team_msdyn_payment) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_payment"></a> business_unit_msdyn_payment

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_payment](businessunit.md#BKMK_business_unit_msdyn_payment) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_payment"></a> TransactionCurrency_msdyn_payment

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_payment](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_payment) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_payment_Account"></a> msdyn_account_msdyn_payment_Account

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_payment_Account](account.md#BKMK_msdyn_account_msdyn_payment_Account) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod"></a> msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod

See msdyn_paymentmethod Entity [msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod](msdyn_paymentmethod.md#BKMK_msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_payment_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_payment_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_payment_WorkOrder) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_payment?text=msdyn_payment EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]