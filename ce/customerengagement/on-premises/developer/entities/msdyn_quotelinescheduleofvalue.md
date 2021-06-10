---
title: "msdyn_quotelinescheduleofvalue Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelinescheduleofvalue entity."
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
# msdyn_quotelinescheduleofvalue Entity Reference

List of billing milestones and invoice amounts for this quote line.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_quotelinescheduleofvalues|
|DisplayCollectionName|Quote Line Milestones|
|DisplayName|Quote Line Milestone|
|EntitySetName|msdyn_quotelinescheduleofvalues|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_quotelinescheduleofvalues|
|LogicalName|msdyn_quotelinescheduleofvalue|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_quotelinescheduleofvalueid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_quotelinescheduleofvalue|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_amount](#BKMK_msdyn_amount)
- [msdyn_invoicedate](#BKMK_msdyn_invoicedate)
- [msdyn_invoicestatus](#BKMK_msdyn_invoicestatus)
- [msdyn_isdataimport](#BKMK_msdyn_isdataimport)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_projecttask](#BKMK_msdyn_projecttask)
- [msdyn_quoteline](#BKMK_msdyn_quoteline)
- [msdyn_quotelineid](#BKMK_msdyn_quotelineid)
- [msdyn_quotelinescheduleofvalueId](#BKMK_msdyn_quotelinescheduleofvalueId)
- [msdyn_tax](#BKMK_msdyn_tax)
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


### <a name="BKMK_msdyn_amount"></a> msdyn_amount

|Property|Value|
|--------|-----|
|Description|Enter the value of the amount on the billing milestone.|
|DisplayName|Line Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_invoicedate"></a> msdyn_invoicedate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date on which the milestone is to be invoiced. This, in conjunction with the Invoice status, will be used by the invoice creation job.|
|DisplayName|Milestone Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_invoicestatus"></a> msdyn_invoicestatus

|Property|Value|
|--------|-----|
|Description|Select whether this milestone was invoiced. Valid values are Not ready for invoicing, Ready for Invoicing, On an invoice, and Invoiced.|
|DisplayName|Invoice Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicestatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_invoicestatus Options

|Value|Label|
|-----|-----|
|192350000|Not Ready for invoicing|
|192350001|Ready for invoicing|
|192350002|Customer invoice created|
|192350003|Customer invoice posted|



### <a name="BKMK_msdyn_isdataimport"></a> msdyn_isdataimport

|Property|Value|
|--------|-----|
|Description|Indicates if this record was created via import. It's purpose is to support data import.|
|DisplayName|isdataimport|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdataimport|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isdataimport Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_projecttask"></a> msdyn_projecttask

|Property|Value|
|--------|-----|
|Description|Select the project task that is tracking the work for this billing milestone.|
|DisplayName|Project Task|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projecttask|
|RequiredLevel|None|
|Targets|msdyn_projecttask|
|Type|Lookup|


### <a name="BKMK_msdyn_quoteline"></a> msdyn_quoteline

|Property|Value|
|--------|-----|
|Description|(Deprecated) Shows a reference to the quote line that this milestone schedule belongs to.|
|DisplayName|(Deprecated) Quote Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quoteline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_quotelineid"></a> msdyn_quotelineid

|Property|Value|
|--------|-----|
|Description|Shows a reference to the quote line that this milestone schedule belongs to.|
|DisplayName|Quote Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotelineid|
|RequiredLevel|None|
|Targets|quotedetail|
|Type|Lookup|


### <a name="BKMK_msdyn_quotelinescheduleofvalueId"></a> msdyn_quotelinescheduleofvalueId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Quote Line Schedule Of Value|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_quotelinescheduleofvalueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_tax"></a> msdyn_tax

|Property|Value|
|--------|-----|
|Description||
|DisplayName|tax|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tax|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Quote Line Schedule Of Value|
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
|Description|Reason for the status of the Quote Line Schedule Of Value|
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
|Description|Shows the currency associated with the entity.|
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
- [msdyn_amount_after_tax](#BKMK_msdyn_amount_after_tax)
- [msdyn_amount_after_tax_Base](#BKMK_msdyn_amount_after_tax_Base)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_projecttaskName](#BKMK_msdyn_projecttaskName)
- [msdyn_quotelineidName](#BKMK_msdyn_quotelineidName)
- [msdyn_tax_Base](#BKMK_msdyn_tax_Base)
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


### <a name="BKMK_msdyn_amount_after_tax"></a> msdyn_amount_after_tax

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Milestone Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount_after_tax|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_amount_after_tax_Base"></a> msdyn_amount_after_tax_Base

|Property|Value|
|--------|-----|
|Description|Value of the amount_after_tax in base currency.|
|DisplayName|amount_after_tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount_after_tax_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Amount in base currency.|
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


### <a name="BKMK_msdyn_projecttaskName"></a> msdyn_projecttaskName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projecttaskname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_quotelineidName"></a> msdyn_quotelineidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotelineidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_tax_Base"></a> msdyn_tax_Base

|Property|Value|
|--------|-----|
|Description|Value of the tax in base currency.|
|DisplayName|tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tax_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
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

- [msdyn_quotelinescheduleofvalue_SyncErrors](#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors)
- [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_quotelinescheduleofvalue_AsyncOperations](#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations)
- [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_quotelinescheduleofvalue_ProcessSession](#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession)
- [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures)
- [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue)


### <a name="BKMK_msdyn_quotelinescheduleofvalue_SyncErrors"></a> msdyn_quotelinescheduleofvalue_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_quotelinescheduleofvalue_SyncErrors](syncerror.md#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations"></a> msdyn_quotelinescheduleofvalue_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_quotelinescheduleofvalue_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_quotelinescheduleofvalue_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_ProcessSession"></a> msdyn_quotelinescheduleofvalue_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_quotelinescheduleofvalue_ProcessSession](processsession.md#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures"></a> msdyn_quotelinescheduleofvalue_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|msdyn_quotelinescheduleofvalue|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue

Same as msdyn_quotelineinvoiceschedule entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineinvoiceschedule|
|ReferencingAttribute|msdyn_quotelinescheduleofvalue|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotelinescheduleofvalue_createdby](#BKMK_lk_msdyn_quotelinescheduleofvalue_createdby)
- [lk_msdyn_quotelinescheduleofvalue_createdonbehalfby](#BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby)
- [lk_msdyn_quotelinescheduleofvalue_modifiedby](#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby)
- [lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby](#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby)
- [user_msdyn_quotelinescheduleofvalue](#BKMK_user_msdyn_quotelinescheduleofvalue)
- [team_msdyn_quotelinescheduleofvalue](#BKMK_team_msdyn_quotelinescheduleofvalue)
- [business_unit_msdyn_quotelinescheduleofvalue](#BKMK_business_unit_msdyn_quotelinescheduleofvalue)
- [TransactionCurrency_msdyn_quotelinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue)
- [msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask](#BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask)
- [msdyn_quotedetail_msdyn_quotelinescheduleofv](#BKMK_msdyn_quotedetail_msdyn_quotelinescheduleofv)


### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_createdby"></a> lk_msdyn_quotelinescheduleofvalue_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_createdby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby"></a> lk_msdyn_quotelinescheduleofvalue_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby"></a> lk_msdyn_quotelinescheduleofvalue_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby"></a> lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelinescheduleofvalue"></a> user_msdyn_quotelinescheduleofvalue

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_quotelinescheduleofvalue](systemuser.md#BKMK_user_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelinescheduleofvalue"></a> team_msdyn_quotelinescheduleofvalue

**Added by**: System Solution Solution

See team Entity [team_msdyn_quotelinescheduleofvalue](team.md#BKMK_team_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelinescheduleofvalue"></a> business_unit_msdyn_quotelinescheduleofvalue

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_quotelinescheduleofvalue](businessunit.md#BKMK_business_unit_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue"></a> TransactionCurrency_msdyn_quotelinescheduleofvalue

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_quotelinescheduleofvalue](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask"></a> msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask) One-To-Many relationship.

### <a name="BKMK_msdyn_quotedetail_msdyn_quotelinescheduleofv"></a> msdyn_quotedetail_msdyn_quotelinescheduleofv

**Added by**: Sales Solution

See quotedetail Entity [msdyn_quotedetail_msdyn_quotelinescheduleofv](quotedetail.md#BKMK_msdyn_quotedetail_msdyn_quotelinescheduleofv) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelinescheduleofvalue?text=msdyn_quotelinescheduleofvalue EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]