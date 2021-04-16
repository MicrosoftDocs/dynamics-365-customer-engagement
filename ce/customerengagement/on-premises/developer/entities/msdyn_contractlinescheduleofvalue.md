---
title: "msdyn_contractlinescheduleofvalue Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_contractlinescheduleofvalue entity."
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
# msdyn_contractlinescheduleofvalue Entity Reference

List of billing milestones and invoice amounts for this project contract line.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_contractlinescheduleofvalues|
|DisplayCollectionName|Project Contract Line Milestones|
|DisplayName|Project Contract Line Milestone|
|EntitySetName|msdyn_contractlinescheduleofvalues|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_contractlinescheduleofvalues|
|LogicalName|msdyn_contractlinescheduleofvalue|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_contractlinescheduleofvalueid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_contractlinescheduleofvalue|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_amount](#BKMK_msdyn_amount)
- [msdyn_contract](#BKMK_msdyn_contract)
- [msdyn_ContractLine](#BKMK_msdyn_ContractLine)
- [msdyn_ContractLineDescription](#BKMK_msdyn_ContractLineDescription)
- [msdyn_ContractLineId](#BKMK_msdyn_ContractLineId)
- [msdyn_contractlinescheduleofvalueId](#BKMK_msdyn_contractlinescheduleofvalueId)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_externaldescription](#BKMK_msdyn_externaldescription)
- [msdyn_Invoicedate](#BKMK_msdyn_Invoicedate)
- [msdyn_Invoicestatus](#BKMK_msdyn_Invoicestatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_price](#BKMK_msdyn_price)
- [msdyn_project](#BKMK_msdyn_project)
- [msdyn_projecttask](#BKMK_msdyn_projecttask)
- [msdyn_startdatetime](#BKMK_msdyn_startdatetime)
- [msdyn_tax](#BKMK_msdyn_tax)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
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
|Description|Enter the value of the milestone.|
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


### <a name="BKMK_msdyn_contract"></a> msdyn_contract

|Property|Value|
|--------|-----|
|Description|Select the project contract associated with this milestone.|
|DisplayName|Project Contract|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contract|
|RequiredLevel|None|
|Targets|salesorder|
|Type|Lookup|


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

|Property|Value|
|--------|-----|
|Description|(Deprecated) Shows the project contract line that has this milestone|
|DisplayName|(Deprecated) Project Contract Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContractLineDescription"></a> msdyn_ContractLineDescription

|Property|Value|
|--------|-----|
|Description|Enter a description of the project contract line that has this milestone.|
|DisplayName|Project Contract Line Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlinedescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_ContractLineId"></a> msdyn_ContractLineId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Project Contract Line associated with Project Contract Line Invoice Schedule.|
|DisplayName|Project Contract Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineid|
|RequiredLevel|None|
|Targets|salesorderdetail|
|Type|Lookup|


### <a name="BKMK_msdyn_contractlinescheduleofvalueId"></a> msdyn_contractlinescheduleofvalueId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Project Contract Line Milestone|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_contractlinescheduleofvalueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type a description of the milestone.|
|DisplayName|Milestone Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_externaldescription"></a> msdyn_externaldescription

|Property|Value|
|--------|-----|
|Description|Description of the project contract line milestone|
|DisplayName|External Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externaldescription|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Invoicedate"></a> msdyn_Invoicedate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date of which this milestone should be achieved|
|DisplayName|Milestone Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Invoicestatus"></a> msdyn_Invoicestatus

|Property|Value|
|--------|-----|
|Description|Select the status of invoicing of this milestone|
|DisplayName|Invoice Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicestatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_Invoicestatus Options

|Value|Label|
|-----|-----|
|192350000|Not Ready for invoicing|
|192350001|Ready for invoicing|
|192350002|Customer invoice created|
|192350003|Customer invoice posted|



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the milestone.|
|DisplayName|Milestone Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_price"></a> msdyn_price

|Property|Value|
|--------|-----|
|Description|Enter the price of the transaction.|
|DisplayName|Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_project"></a> msdyn_project

|Property|Value|
|--------|-----|
|Description|Select the project that is tracking the work required to achieve this milestone.|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_projecttask"></a> msdyn_projecttask

|Property|Value|
|--------|-----|
|Description|Select the project work breakdown structure (WBS) task that is tracking the work for this milestone.|
|DisplayName|Project Task|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projecttask|
|RequiredLevel|None|
|Targets|msdyn_projecttask|
|Type|Lookup|


### <a name="BKMK_msdyn_startdatetime"></a> msdyn_startdatetime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date of project contract line milestone|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdatetime|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

|Property|Value|
|--------|-----|
|Description|Transaction classification of the project contract line milestone|
|DisplayName|Transaction Class|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_TransactionClassification Options

|Value|Label|
|-----|-----|
|192350000|Time|
|192350001|Expense|
|192350002|Material|
|192350003|Milestone|
|192350004|Fee|
|690970000|Commission|
|690970001|Additional|
|690970002|Tax|



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

|Property|Value|
|--------|-----|
|Description|Transaction type of the project contract line milestone|
|DisplayName|Transaction Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactiontypecode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_TransactionTypeCode Options

|Value|Label|
|-----|-----|
|192350000|Cost|
|192350004|Project Contract|
|192350005|Unbilled Sales|
|192350006|Billed Sales|
|192350007|Resourcing Unit Cost|
|192350008|Inter-Organizational Sales|



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
|Description|Status of the project contract line milestone.|
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
|Description|Reason for the status of the project contract line milestone.|
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
- [msdyn_ContractLineIdName](#BKMK_msdyn_ContractLineIdName)
- [msdyn_contractName](#BKMK_msdyn_contractName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_projectName](#BKMK_msdyn_projectName)
- [msdyn_projecttaskName](#BKMK_msdyn_projecttaskName)
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


### <a name="BKMK_msdyn_ContractLineIdName"></a> msdyn_ContractLineIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_contractName"></a> msdyn_contractName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contractname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

|Property|Value|
|--------|-----|
|Description|Value of the Price in base currency.|
|DisplayName|Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_projectName"></a> msdyn_projectName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


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

- [msdyn_contractlinescheduleofvalue_SyncErrors](#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors)
- [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_contractlinescheduleofvalue_AsyncOperations](#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations)
- [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_contractlinescheduleofvalue_ProcessSession](#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession)
- [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures)
- [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule)


### <a name="BKMK_msdyn_contractlinescheduleofvalue_SyncErrors"></a> msdyn_contractlinescheduleofvalue_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_contractlinescheduleofvalue_SyncErrors](syncerror.md#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations"></a> msdyn_contractlinescheduleofvalue_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_contractlinescheduleofvalue_AsyncOperations](asyncoperation.md#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_contractlinescheduleofvalue_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_ProcessSession"></a> msdyn_contractlinescheduleofvalue_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_contractlinescheduleofvalue_ProcessSession](processsession.md#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures"></a> msdyn_contractlinescheduleofvalue_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule"></a> msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule

Same as msdyn_contractlineinvoiceschedule entity [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contractlineinvoiceschedule|
|ReferencingAttribute|msdyn_contractlinescheduleofvalue|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_contractlinescheduleofvalue_createdby](#BKMK_lk_msdyn_contractlinescheduleofvalue_createdby)
- [lk_msdyn_contractlinescheduleofvalue_createdonbehalfby](#BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby)
- [lk_msdyn_contractlinescheduleofvalue_modifiedby](#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby)
- [lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby](#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby)
- [user_msdyn_contractlinescheduleofvalue](#BKMK_user_msdyn_contractlinescheduleofvalue)
- [team_msdyn_contractlinescheduleofvalue](#BKMK_team_msdyn_contractlinescheduleofvalue)
- [business_unit_msdyn_contractlinescheduleofvalue](#BKMK_business_unit_msdyn_contractlinescheduleofvalue)
- [TransactionCurrency_msdyn_contractlinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue)
- [msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project](#BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project)
- [msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask](#BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask)
- [msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract](#BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract)
- [msdyn_salesorderdetail_msdyn_contractlineschedu](#BKMK_msdyn_salesorderdetail_msdyn_contractlineschedu)


### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_createdby"></a> lk_msdyn_contractlinescheduleofvalue_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_createdby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby"></a> lk_msdyn_contractlinescheduleofvalue_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby"></a> lk_msdyn_contractlinescheduleofvalue_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_modifiedby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby"></a> lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_contractlinescheduleofvalue"></a> user_msdyn_contractlinescheduleofvalue

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_contractlinescheduleofvalue](systemuser.md#BKMK_user_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_team_msdyn_contractlinescheduleofvalue"></a> team_msdyn_contractlinescheduleofvalue

**Added by**: System Solution Solution

See team Entity [team_msdyn_contractlinescheduleofvalue](team.md#BKMK_team_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_contractlinescheduleofvalue"></a> business_unit_msdyn_contractlinescheduleofvalue

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_contractlinescheduleofvalue](businessunit.md#BKMK_business_unit_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue"></a> TransactionCurrency_msdyn_contractlinescheduleofvalue

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_contractlinescheduleofvalue](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project"></a> msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask"></a> msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract"></a> msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract

**Added by**: Sales Solution

See salesorder Entity [msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract](salesorder.md#BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorderdetail_msdyn_contractlineschedu"></a> msdyn_salesorderdetail_msdyn_contractlineschedu

**Added by**: Sales Solution

See salesorderdetail Entity [msdyn_salesorderdetail_msdyn_contractlineschedu](salesorderdetail.md#BKMK_msdyn_salesorderdetail_msdyn_contractlineschedu) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_contractlinescheduleofvalue?text=msdyn_contractlinescheduleofvalue EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]