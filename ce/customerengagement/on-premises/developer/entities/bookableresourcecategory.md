---
title: "BookableResourceCategory Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceCategory entity."
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
# BookableResourceCategory Entity Reference

Resource category master used to categorize people and equipment.

**Added by**: Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcecategories<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcecategories<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcecategories(*bookableresourcecategoryid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BookableResourceCategory|
|DisplayCollectionName|Bookable Resource Categories|
|DisplayName|Bookable Resource Category|
|EntitySetName|bookableresourcecategories|
|IsBPFEntity|False|
|LogicalCollectionName|bookableresourcecategories|
|LogicalName|bookableresourcecategory|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bookableresourcecategoryid|
|PrimaryNameAttribute|name|
|SchemaName|BookableResourceCategory|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceCategoryId](#BKMK_BookableResourceCategoryId)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_billingtype](#BKMK_msdyn_billingtype)
- [msdyn_targetutilization](#BKMK_msdyn_targetutilization)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceCategoryId"></a> BookableResourceCategoryId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource category.|
|DisplayName|Resource Category|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bookableresourcecategoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type a detailed description of what the categorization is about.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_msdyn_billingtype"></a> msdyn_billingtype

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Select the billing type for this resource role.|
|DisplayName|Billing Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_billingtype Options

|Value|Label|
|-----|-----|
|192350000|Non Chargeable|
|192350001|Chargeable|
|192350002|Complimentary|
|192350003|Not Available|



### <a name="BKMK_msdyn_targetutilization"></a> msdyn_targetutilization

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Enter the target usage rate for this resource role.|
|DisplayName|Target Utilization|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_targetutilization|
|MaxValue|100|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Enter the default transaction category for this resource role.|
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type the name of the resource category.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the Resource Category|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Resource Category|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

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
|Description|Exchange rate for the currency associated with the BookableResourceCategory with respect to the base currency.|
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
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
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
|Description|Date and time when the record was created.|
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
|Description|Unique identifier of the delegate user who created the record.|
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
|Description|Exchange rate for the currency associated with the bookableresourcecategory with respect to the base currency.|
|DisplayName|ExchangeRate|
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
|Description|Date and time when the record was modified.|
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
|Description|Unique identifier of the delegate user who modified the record.|
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


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategoryname|
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

- [BookableResourceCategory_SyncErrors](#BKMK_BookableResourceCategory_SyncErrors)
- [bookableresourcecategory_DuplicateMatchingRecord](#BKMK_bookableresourcecategory_DuplicateMatchingRecord)
- [bookableresourcecategory_DuplicateBaseRecord](#BKMK_bookableresourcecategory_DuplicateBaseRecord)
- [bookableresourcecategory_AsyncOperations](#BKMK_bookableresourcecategory_AsyncOperations)
- [bookableresourcecategory_MailboxTrackingFolders](#BKMK_bookableresourcecategory_MailboxTrackingFolders)
- [bookableresourcecategory_ProcessSession](#BKMK_bookableresourcecategory_ProcessSession)
- [bookableresourcecategory_BulkDeleteFailures](#BKMK_bookableresourcecategory_BulkDeleteFailures)
- [bookableresourcecategory_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess)
- [bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory](#BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory)
- [msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid)
- [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid)
- [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole)
- [msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory)
- [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid)
- [msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory](#BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory)
- [msdyn_bookableresourcecategory_msdyn_roleutilization_role](#BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role)
- [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory)
- [msdyn_bookableresourcecategory_resourcerequirement](#BKMK_msdyn_bookableresourcecategory_resourcerequirement)


### <a name="BKMK_BookableResourceCategory_SyncErrors"></a> BookableResourceCategory_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [BookableResourceCategory_SyncErrors](syncerror.md#BKMK_BookableResourceCategory_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BookableResourceCategory_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcecategory_DuplicateMatchingRecord"></a> bookableresourcecategory_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcecategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcecategory_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_DuplicateBaseRecord"></a> bookableresourcecategory_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcecategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcecategory_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_AsyncOperations"></a> bookableresourcecategory_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [bookableresourcecategory_AsyncOperations](asyncoperation.md#BKMK_bookableresourcecategory_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_MailboxTrackingFolders"></a> bookableresourcecategory_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [bookableresourcecategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcecategory_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_ProcessSession"></a> bookableresourcecategory_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [bookableresourcecategory_ProcessSession](processsession.md#BKMK_bookableresourcecategory_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_BulkDeleteFailures"></a> bookableresourcecategory_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [bookableresourcecategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcecategory_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess"></a> bookableresourcecategory_PrincipalObjectAttributeAccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [bookableresourcecategory_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory"></a> bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory

Same as bookableresourcecategoryassn entity [bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory](bookableresourcecategoryassn.md#BKMK_bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategoryassn|
|ReferencingAttribute|resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_requirementresourcecategory entity [msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory](msdyn_requirementresourcecategory.md#BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcecategory|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid

**Added by**: Project Service Automation Solution

Same as bookableresourcebooking entity [msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid](bookableresourcebooking.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|msdyn_resourcecategoryid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid"></a> msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid

**Added by**: Project Service Automation Solution

Same as bookableresourcebookingheader entity [msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid](bookableresourcebookingheader.md#BKMK_msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebookingheader|
|ReferencingAttribute|msdyn_resourcecategoryid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_actual entity [msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory](msdyn_actual.md#BKMK_msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_estimateline entity [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](msdyn_estimateline.md#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_fact entity [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](msdyn_fact.md#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory](msdyn_invoicelinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory](msdyn_journalline.md#BKMK_msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylineresourcecategory|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylinetransaction entity [msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory](msdyn_opportunitylinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_orderlineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory](msdyn_orderlineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlineresourcecategory|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_orderlinetransaction entity [msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory](msdyn_orderlinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_projectapproval entity [msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory](msdyn_projectapproval.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole

**Added by**: Project Service Automation Solution

Same as msdyn_projectparameter entity [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](msdyn_projectparameter.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameter|
|ReferencingAttribute|msdyn_projectmanagerrole|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole

**Added by**: Project Service Automation Solution

Same as msdyn_projectparameter entity [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](msdyn_projectparameter.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameter|
|ReferencingAttribute|msdyn_teammemberrole|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory

**Added by**: Project Service Automation Solution

Same as msdyn_projecttask entity [msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory](msdyn_projecttask.md#BKMK_msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory

**Added by**: Project Service Automation Solution

Same as msdyn_projectteam entity [msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory](msdyn_projectteam.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectteam|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_quotelineresourcecategory entity [msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory](msdyn_quotelineresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineresourcecategory|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_quotelinetransaction entity [msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory](msdyn_quotelinetransaction.md#BKMK_msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorymarkuppricelevel entity [msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorymarkuppricelevel|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_resourcecategorymarkuppricelevel_resourcecategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorypricelevel entity [msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid"></a> msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid

**Added by**: Project Service Automation Solution

Same as msdyn_resourcerequest entity [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](msdyn_resourcerequest.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequest|
|ReferencingAttribute|msdyn_roleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory"></a> msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory

**Added by**: Project Service Automation Solution

Same as msdyn_rolecompetencyrequirement entity [msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rolecompetencyrequirement|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role"></a> msdyn_bookableresourcecategory_msdyn_roleutilization_role

**Added by**: Project Service Automation Solution

Same as msdyn_roleutilization entity [msdyn_bookableresourcecategory_msdyn_roleutilization_role](msdyn_roleutilization.md#BKMK_msdyn_bookableresourcecategory_msdyn_roleutilization_role) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_roleutilization|
|ReferencingAttribute|msdyn_role|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_roleutilization_role|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory"></a> msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory

**Added by**: Project Service Automation Solution

Same as msdyn_timeentry entity [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](msdyn_timeentry.md#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|msdyn_resourcecategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecategory_resourcerequirement"></a> msdyn_bookableresourcecategory_resourcerequirement

**Added by**: Project Service Automation Solution

Same as msdyn_resourcerequirement entity [msdyn_bookableresourcecategory_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_bookableresourcecategory_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|msdyn_roleid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecategory_resourcerequirement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_bookableresourcecategory_createdby](#BKMK_lk_bookableresourcecategory_createdby)
- [lk_bookableresourcecategory_createdonbehalfby](#BKMK_lk_bookableresourcecategory_createdonbehalfby)
- [lk_bookableresourcecategory_modifiedby](#BKMK_lk_bookableresourcecategory_modifiedby)
- [lk_bookableresourcecategory_modifiedonbehalfby](#BKMK_lk_bookableresourcecategory_modifiedonbehalfby)
- [user_bookableresourcecategory](#BKMK_user_bookableresourcecategory)
- [team_bookableresourcecategory](#BKMK_team_bookableresourcecategory)
- [business_unit_bookableresourcecategory](#BKMK_business_unit_bookableresourcecategory)
- [TransactionCurrency_bookableresourcecategory](#BKMK_TransactionCurrency_bookableresourcecategory)
- [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory)


### <a name="BKMK_lk_bookableresourcecategory_createdby"></a> lk_bookableresourcecategory_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecategory_createdby](systemuser.md#BKMK_lk_bookableresourcecategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_createdonbehalfby"></a> lk_bookableresourcecategory_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecategory_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcecategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_modifiedby"></a> lk_bookableresourcecategory_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecategory_modifiedby](systemuser.md#BKMK_lk_bookableresourcecategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecategory_modifiedonbehalfby"></a> lk_bookableresourcecategory_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecategory_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcecategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcecategory"></a> user_bookableresourcecategory

**Added by**: System Solution Solution

See systemuser Entity [user_bookableresourcecategory](systemuser.md#BKMK_user_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcecategory"></a> team_bookableresourcecategory

**Added by**: System Solution Solution

See team Entity [team_bookableresourcecategory](team.md#BKMK_team_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcecategory"></a> business_unit_bookableresourcecategory

**Added by**: System Solution Solution

See businessunit Entity [business_unit_bookableresourcecategory](businessunit.md#BKMK_business_unit_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcecategory"></a> TransactionCurrency_bookableresourcecategory

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_bookableresourcecategory](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcecategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory

**Added by**: Project Service Automation Solution

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcecategory?text=bookableresourcecategory EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]