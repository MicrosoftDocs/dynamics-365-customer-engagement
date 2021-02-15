---
title: "msdyn_quotebookingservice Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingservice entity."
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
# msdyn_quotebookingservice Entity Reference

Stores details about the services associated with Quote Booking Setup 

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservices(*msdyn_quotebookingserviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingservices<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingservices(*msdyn_quotebookingserviceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingservices(*msdyn_quotebookingserviceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingservices<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservices(*msdyn_quotebookingserviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservices(*msdyn_quotebookingserviceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_quotebookingservices|
|DisplayCollectionName|Quote Booking Services|
|DisplayName|Quote Booking Service|
|EntitySetName|msdyn_quotebookingservices|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_quotebookingservices|
|LogicalName|msdyn_quotebookingservice|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_quotebookingserviceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_quotebookingservice|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_currency](#BKMK_msdyn_currency)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_duration](#BKMK_msdyn_duration)
- [msdyn_durationtobill](#BKMK_msdyn_durationtobill)
- [msdyn_EstimatedCostAmount](#BKMK_msdyn_EstimatedCostAmount)
- [msdyn_EstimatedSalesAmount](#BKMK_msdyn_EstimatedSalesAmount)
- [msdyn_Internalflags](#BKMK_msdyn_Internalflags)
- [msdyn_iscopied](#BKMK_msdyn_iscopied)
- [msdyn_lineorder](#BKMK_msdyn_lineorder)
- [msdyn_minimumchargeamount](#BKMK_msdyn_minimumchargeamount)
- [msdyn_minimumchargeduration](#BKMK_msdyn_minimumchargeduration)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_pricelist](#BKMK_msdyn_pricelist)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingincident](#BKMK_msdyn_quotebookingincident)
- [msdyn_quotebookingserviceId](#BKMK_msdyn_quotebookingserviceId)
- [msdyn_quotebookingsetup](#BKMK_msdyn_quotebookingsetup)
- [msdyn_Service](#BKMK_msdyn_Service)
- [msdyn_unit](#BKMK_msdyn_unit)
- [msdyn_unitamount](#BKMK_msdyn_unitamount)
- [msdyn_unitcostamount](#BKMK_msdyn_unitcostamount)
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


### <a name="BKMK_msdyn_currency"></a> msdyn_currency

|Property|Value|
|--------|-----|
|Description|The currency that will be used to charge this service|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_currency|
|MaxValue|1000000000|
|MinValue|0|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

|Property|Value|
|--------|-----|
|Description|Customer Asset related to this Service|
|DisplayName|Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_duration"></a> msdyn_duration

|Property|Value|
|--------|-----|
|Description|Shows the actual duration of service.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_durationtobill"></a> msdyn_durationtobill

|Property|Value|
|--------|-----|
|Description|Enter the duration you want to bill the customer for. By default, this will default to the same value as the "Duration" field.|
|DisplayName|Duration To Bill|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_durationtobill|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_EstimatedCostAmount"></a> msdyn_EstimatedCostAmount

|Property|Value|
|--------|-----|
|Description|Shows the total cost amount of the service. It is calculated as (Unit Cost) * Duration|
|DisplayName|Estimated Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedcostamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimatedSalesAmount"></a> msdyn_EstimatedSalesAmount

|Property|Value|
|--------|-----|
|Description|Shows the total sales amount of the service.|
|DisplayName|Estimated Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedsalesamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_msdyn_iscopied"></a> msdyn_iscopied

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Copied|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_iscopied|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_iscopied Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_lineorder"></a> msdyn_lineorder

|Property|Value|
|--------|-----|
|Description|Shows the order of this service within the agreement services.|
|DisplayName|Line Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lineorder|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_minimumchargeamount"></a> msdyn_minimumchargeamount

|Property|Value|
|--------|-----|
|Description|Enter the amount charged as a minimum charge.|
|DisplayName|Minimum Charge Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_minimumchargeduration"></a> msdyn_minimumchargeduration

|Property|Value|
|--------|-----|
|Description|Enter the duration of up to how long the minimum charge applies.|
|DisplayName|Minimum Charge Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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


### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

|Property|Value|
|--------|-----|
|Description|Optionally set Price List that will determine the pricing for this service on the Work Order|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_quote"></a> msdyn_quote

|Property|Value|
|--------|-----|
|Description|Unique identifier for Quote associated with Quote Booking Service.|
|DisplayName|Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quote|
|RequiredLevel|ApplicationRequired|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_msdyn_quotebookingincident"></a> msdyn_quotebookingincident

|Property|Value|
|--------|-----|
|Description|The Quote Booking Incident related to this service|
|DisplayName|Quote  Booking Incident|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotebookingincident|
|RequiredLevel|None|
|Targets|msdyn_quotebookingincident|
|Type|Lookup|


### <a name="BKMK_msdyn_quotebookingserviceId"></a> msdyn_quotebookingserviceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Quote Booking Service|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_quotebookingserviceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_quotebookingsetup"></a> msdyn_quotebookingsetup

|Property|Value|
|--------|-----|
|Description|Unique identifier for Quote Booking Setup associated with Quote Booking Service.|
|DisplayName|Quote Booking Setup|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotebookingsetup|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_quotebookingsetup|
|Type|Lookup|


### <a name="BKMK_msdyn_Service"></a> msdyn_Service

|Property|Value|
|--------|-----|
|Description|Unique identifier for Product/Service associated with Quote Booking Service.|
|DisplayName|Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_service|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_unit"></a> msdyn_unit

|Property|Value|
|--------|-----|
|Description|The unit that determines the pricing for this service when Price List is set|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_unitamount"></a> msdyn_unitamount

|Property|Value|
|--------|-----|
|Description|Enter the amount you wish to charge the customer per unit. This field is optional.|
|DisplayName|Unit Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitcostamount"></a> msdyn_unitcostamount

|Property|Value|
|--------|-----|
|Description|Shows the estimated cost amount per unit.|
|DisplayName|Unit Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcostamount|
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
|Description|Status of the Quote Booking Service|
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
|Description|Reason for the status of the Quote Booking Service|
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
- [msdyn_currency_Base](#BKMK_msdyn_currency_Base)
- [msdyn_customerassetName](#BKMK_msdyn_customerassetName)
- [msdyn_estimatedcostamount_Base](#BKMK_msdyn_estimatedcostamount_Base)
- [msdyn_estimatedsalesamount_Base](#BKMK_msdyn_estimatedsalesamount_Base)
- [msdyn_minimumchargeamount_Base](#BKMK_msdyn_minimumchargeamount_Base)
- [msdyn_pricelistName](#BKMK_msdyn_pricelistName)
- [msdyn_quotebookingincidentName](#BKMK_msdyn_quotebookingincidentName)
- [msdyn_quotebookingsetupName](#BKMK_msdyn_quotebookingsetupName)
- [msdyn_quoteName](#BKMK_msdyn_quoteName)
- [msdyn_ServiceName](#BKMK_msdyn_ServiceName)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcostamount_Base](#BKMK_msdyn_unitcostamount_Base)
- [msdyn_unitName](#BKMK_msdyn_unitName)
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


### <a name="BKMK_msdyn_currency_Base"></a> msdyn_currency_Base

|Property|Value|
|--------|-----|
|Description|Value of the Currency in base currency.|
|DisplayName|Currency (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_currency_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_customerassetName"></a> msdyn_customerassetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_estimatedcostamount_Base"></a> msdyn_estimatedcostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimate Cost Amount in base currency.|
|DisplayName|Estimate Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedcostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatedsalesamount_Base"></a> msdyn_estimatedsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimate Sales Amount in base currency.|
|DisplayName|Estimate Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_minimumchargeamount_Base"></a> msdyn_minimumchargeamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Minimum Charge Amount in base currency.|
|DisplayName|Minimum Charge Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_pricelistName"></a> msdyn_pricelistName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricelistname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_quotebookingincidentName"></a> msdyn_quotebookingincidentName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotebookingincidentname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_quotebookingsetupName"></a> msdyn_quotebookingsetupName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_quotebookingsetupname|
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


### <a name="BKMK_msdyn_ServiceName"></a> msdyn_ServiceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_servicename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Unit Amount in base currency.|
|DisplayName|Unit Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitcostamount_Base"></a> msdyn_unitcostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Unit Cost in base currency.|
|DisplayName|Unit Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitName"></a> msdyn_unitName

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

- [msdyn_quotebookingservice_ActivityPointers](#BKMK_msdyn_quotebookingservice_ActivityPointers)
- [msdyn_quotebookingservice_msdyn_bookingalerts](#BKMK_msdyn_quotebookingservice_msdyn_bookingalerts)
- [msdyn_quotebookingservice_msdyn_approvals](#BKMK_msdyn_quotebookingservice_msdyn_approvals)
- [msdyn_quotebookingservice_SyncErrors](#BKMK_msdyn_quotebookingservice_SyncErrors)
- [msdyn_quotebookingservice_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord)
- [msdyn_quotebookingservice_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord)
- [msdyn_quotebookingservice_AsyncOperations](#BKMK_msdyn_quotebookingservice_AsyncOperations)
- [msdyn_quotebookingservice_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders)
- [msdyn_quotebookingservice_ProcessSession](#BKMK_msdyn_quotebookingservice_ProcessSession)
- [msdyn_quotebookingservice_BulkDeleteFailures](#BKMK_msdyn_quotebookingservice_BulkDeleteFailures)
- [msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservice_Appointments](#BKMK_msdyn_quotebookingservice_Appointments)
- [msdyn_quotebookingservice_Emails](#BKMK_msdyn_quotebookingservice_Emails)
- [msdyn_quotebookingservice_Faxes](#BKMK_msdyn_quotebookingservice_Faxes)
- [msdyn_quotebookingservice_Letters](#BKMK_msdyn_quotebookingservice_Letters)
- [msdyn_quotebookingservice_PhoneCalls](#BKMK_msdyn_quotebookingservice_PhoneCalls)
- [msdyn_quotebookingservice_Tasks](#BKMK_msdyn_quotebookingservice_Tasks)
- [msdyn_quotebookingservice_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)
- [msdyn_quotebookingservice_SocialActivities](#BKMK_msdyn_quotebookingservice_SocialActivities)
- [msdyn_quotebookingservice_connections1](#BKMK_msdyn_quotebookingservice_connections1)
- [msdyn_quotebookingservice_connections2](#BKMK_msdyn_quotebookingservice_connections2)
- [msdyn_quotebookingservice_Annotations](#BKMK_msdyn_quotebookingservice_Annotations)
- [msdyn_quotebookingservice_ServiceAppointments](#BKMK_msdyn_quotebookingservice_ServiceAppointments)


### <a name="BKMK_msdyn_quotebookingservice_ActivityPointers"></a> msdyn_quotebookingservice_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_quotebookingservice_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingservice_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_msdyn_bookingalerts"></a> msdyn_quotebookingservice_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_quotebookingservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingservice_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_msdyn_approvals"></a> msdyn_quotebookingservice_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_quotebookingservice_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_quotebookingservice_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_SyncErrors"></a> msdyn_quotebookingservice_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_quotebookingservice_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingservice_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord"></a> msdyn_quotebookingservice_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotebookingservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_DuplicateBaseRecord"></a> msdyn_quotebookingservice_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotebookingservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_AsyncOperations"></a> msdyn_quotebookingservice_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_quotebookingservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingservice_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_MailboxTrackingFolders"></a> msdyn_quotebookingservice_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_quotebookingservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_ProcessSession"></a> msdyn_quotebookingservice_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_quotebookingservice_ProcessSession](processsession.md#BKMK_msdyn_quotebookingservice_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_BulkDeleteFailures"></a> msdyn_quotebookingservice_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_quotebookingservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingservice_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservice_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_Appointments"></a> msdyn_quotebookingservice_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_quotebookingservice_Appointments](appointment.md#BKMK_msdyn_quotebookingservice_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_Emails"></a> msdyn_quotebookingservice_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_quotebookingservice_Emails](email.md#BKMK_msdyn_quotebookingservice_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_Faxes"></a> msdyn_quotebookingservice_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_quotebookingservice_Faxes](fax.md#BKMK_msdyn_quotebookingservice_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_Letters"></a> msdyn_quotebookingservice_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_quotebookingservice_Letters](letter.md#BKMK_msdyn_quotebookingservice_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_PhoneCalls"></a> msdyn_quotebookingservice_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_quotebookingservice_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingservice_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_Tasks"></a> msdyn_quotebookingservice_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_quotebookingservice_Tasks](task.md#BKMK_msdyn_quotebookingservice_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters"></a> msdyn_quotebookingservice_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_quotebookingservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_SocialActivities"></a> msdyn_quotebookingservice_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_quotebookingservice_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingservice_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_connections1"></a> msdyn_quotebookingservice_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_quotebookingservice_connections1](connection.md#BKMK_msdyn_quotebookingservice_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_connections2"></a> msdyn_quotebookingservice_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_quotebookingservice_connections2](connection.md#BKMK_msdyn_quotebookingservice_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotebookingservice_Annotations"></a> msdyn_quotebookingservice_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_quotebookingservice_Annotations](annotation.md#BKMK_msdyn_quotebookingservice_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotebookingservice_ServiceAppointments"></a> msdyn_quotebookingservice_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_quotebookingservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingservice_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotebookingservice_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotebookingservice_createdby](#BKMK_lk_msdyn_quotebookingservice_createdby)
- [lk_msdyn_quotebookingservice_createdonbehalfby](#BKMK_lk_msdyn_quotebookingservice_createdonbehalfby)
- [lk_msdyn_quotebookingservice_modifiedby](#BKMK_lk_msdyn_quotebookingservice_modifiedby)
- [lk_msdyn_quotebookingservice_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingservice_modifiedonbehalfby)
- [user_msdyn_quotebookingservice](#BKMK_user_msdyn_quotebookingservice)
- [team_msdyn_quotebookingservice](#BKMK_team_msdyn_quotebookingservice)
- [business_unit_msdyn_quotebookingservice](#BKMK_business_unit_msdyn_quotebookingservice)
- [TransactionCurrency_msdyn_quotebookingservice](#BKMK_TransactionCurrency_msdyn_quotebookingservice)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup)
- [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList)
- [msdyn_product_msdyn_quotebookingservice_Service](#BKMK_msdyn_product_msdyn_quotebookingservice_Service)
- [msdyn_quote_msdyn_quotebookingservice_Quote](#BKMK_msdyn_quote_msdyn_quotebookingservice_Quote)
- [msdyn_uom_msdyn_quotebookingservice_Unit](#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit)


### <a name="BKMK_lk_msdyn_quotebookingservice_createdby"></a> lk_msdyn_quotebookingservice_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingservice_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingservice_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservice_createdonbehalfby"></a> lk_msdyn_quotebookingservice_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservice_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservice_modifiedby"></a> lk_msdyn_quotebookingservice_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingservice_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingservice_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservice_modifiedonbehalfby"></a> lk_msdyn_quotebookingservice_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotebookingservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservice_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingservice"></a> user_msdyn_quotebookingservice

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_quotebookingservice](systemuser.md#BKMK_user_msdyn_quotebookingservice) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingservice"></a> team_msdyn_quotebookingservice

**Added by**: System Solution Solution

See team Entity [team_msdyn_quotebookingservice](team.md#BKMK_team_msdyn_quotebookingservice) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingservice"></a> business_unit_msdyn_quotebookingservice

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_quotebookingservice](businessunit.md#BKMK_business_unit_msdyn_quotebookingservice) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingservice"></a> TransactionCurrency_msdyn_quotebookingservice

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_quotebookingservice](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingservice) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident

See msdyn_quotebookingincident Entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup

See msdyn_quotebookingsetup Entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList"></a> msdyn_pricelevel_msdyn_quotebookingservice_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_quotebookingservice_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_quotebookingservice_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_quotebookingservice_Service"></a> msdyn_product_msdyn_quotebookingservice_Service

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_quotebookingservice_Service](product.md#BKMK_msdyn_product_msdyn_quotebookingservice_Service) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingservice_Quote"></a> msdyn_quote_msdyn_quotebookingservice_Quote

**Added by**: Sales Solution

See quote Entity [msdyn_quote_msdyn_quotebookingservice_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingservice_Quote) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_quotebookingservice_Unit"></a> msdyn_uom_msdyn_quotebookingservice_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_quotebookingservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingservice?text=msdyn_quotebookingservice EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]