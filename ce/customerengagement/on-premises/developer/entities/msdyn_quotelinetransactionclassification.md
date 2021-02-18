---
title: "msdyn_quotelinetransactionclassification Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelinetransactionclassification entity."
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
# msdyn_quotelinetransactionclassification Entity Reference

List of transaction classification heads, the four broad cost classifications of time, expense, material, and fee, that will be considered as costs when computing the profit of a quote line.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications(*msdyn_quotelinetransactionclassificationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications(*msdyn_quotelinetransactionclassificationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications(*msdyn_quotelinetransactionclassificationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications(*msdyn_quotelinetransactionclassificationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinetransactionclassifications(*msdyn_quotelinetransactionclassificationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_quotelinetransactionclassifications|
|DisplayCollectionName|Quote Line Transaction Classifications|
|DisplayName|Quote Line Transaction Classification|
|EntitySetName|msdyn_quotelinetransactionclassifications|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_quotelinetransactionclassifications|
|LogicalName|msdyn_quotelinetransactionclassification|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_quotelinetransactionclassificationid|
|PrimaryNameAttribute|msdyn_description|
|SchemaName|msdyn_quotelinetransactionclassification|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_Include](#BKMK_msdyn_Include)
- [msdyn_QuoteLine](#BKMK_msdyn_QuoteLine)
- [msdyn_QuoteLineId](#BKMK_msdyn_QuoteLineId)
- [msdyn_quotelinetransactionclassificationId](#BKMK_msdyn_quotelinetransactionclassificationId)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
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


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

|Property|Value|
|--------|-----|
|Description|Select whether the transaction classification identified on the quote line will be charged to the customer or not. Valid values are Chargeable, Non-chargeable and Complimentary.  |
|DisplayName|Billing Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_BillingType Options

|Value|Label|
|-----|-----|
|192350000|Non Chargeable|
|192350001|Chargeable|
|192350002|Complimentary|
|192350003|Not Available|



### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Include"></a> msdyn_Include

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Include|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_include|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Include Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_QuoteLine"></a> msdyn_QuoteLine

|Property|Value|
|--------|-----|
|Description|(Deprecated) Type the reference to the Quote line to which this transaction classification is being associated to.|
|DisplayName|(Deprecated) Quote Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quoteline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_QuoteLineId"></a> msdyn_QuoteLineId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Quote Line associated with Quote Line Transaction Classification.|
|DisplayName|Quote Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotelineid|
|RequiredLevel|None|
|Targets|quotedetail|
|Type|Lookup|


### <a name="BKMK_msdyn_quotelinetransactionclassificationId"></a> msdyn_quotelinetransactionclassificationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Quote Line Transaction Classification|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_quotelinetransactionclassificationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

|Property|Value|
|--------|-----|
|Description|Select the transaction classification on the quote line. 4 classifications are supported: Select the time, Expense, Material and Fee.|
|DisplayName|Transaction Classification|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|None|
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
|Description|Status of the Quote Line Transaction Classification|
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
|Description|Reason for the status of the Quote Line Transaction Classification|
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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_QuoteLineIdName](#BKMK_msdyn_QuoteLineIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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


### <a name="BKMK_msdyn_QuoteLineIdName"></a> msdyn_QuoteLineIdName

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

- [msdyn_quotelinetransactionclassification_SyncErrors](#BKMK_msdyn_quotelinetransactionclassification_SyncErrors)
- [msdyn_quotelinetransactionclassification_DuplicateMatchingRecord](#BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord)
- [msdyn_quotelinetransactionclassification_DuplicateBaseRecord](#BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord)
- [msdyn_quotelinetransactionclassification_AsyncOperations](#BKMK_msdyn_quotelinetransactionclassification_AsyncOperations)
- [msdyn_quotelinetransactionclassification_MailboxTrackingFolders](#BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders)
- [msdyn_quotelinetransactionclassification_ProcessSession](#BKMK_msdyn_quotelinetransactionclassification_ProcessSession)
- [msdyn_quotelinetransactionclassification_BulkDeleteFailures](#BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures)
- [msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses)
- [msdyn_quotelinetransactionclassification_Annotations](#BKMK_msdyn_quotelinetransactionclassification_Annotations)
- [msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass](#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass)
- [msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla](#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla)


### <a name="BKMK_msdyn_quotelinetransactionclassification_SyncErrors"></a> msdyn_quotelinetransactionclassification_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_quotelinetransactionclassification_SyncErrors](syncerror.md#BKMK_msdyn_quotelinetransactionclassification_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord"></a> msdyn_quotelinetransactionclassification_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotelinetransactionclassification_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord"></a> msdyn_quotelinetransactionclassification_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_quotelinetransactionclassification_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_AsyncOperations"></a> msdyn_quotelinetransactionclassification_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_quotelinetransactionclassification_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelinetransactionclassification_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders"></a> msdyn_quotelinetransactionclassification_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_quotelinetransactionclassification_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_ProcessSession"></a> msdyn_quotelinetransactionclassification_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_quotelinetransactionclassification_ProcessSession](processsession.md#BKMK_msdyn_quotelinetransactionclassification_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures"></a> msdyn_quotelinetransactionclassification_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_quotelinetransactionclassification_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_Annotations"></a> msdyn_quotelinetransactionclassification_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_quotelinetransactionclassification_Annotations](annotation.md#BKMK_msdyn_quotelinetransactionclassification_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass"></a> msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass

Same as msdyn_quotelineresourcecategory entity [msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineresourcecategory|
|ReferencingAttribute|msdyn_quotelinetransactionclassification|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_msdyn_quotelineresourcecategory_QuoteLineTransactionClass|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla"></a> msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla

Same as msdyn_quotelinetransactioncategory entity [msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactioncategory|
|ReferencingAttribute|msdyn_quotelinetransactionclassification|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_quotelinetransactionclassification_msdyn_quotelinetransactioncategory_QuoteLineTransactionCla|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotelinetransactionclassification_createdby](#BKMK_lk_msdyn_quotelinetransactionclassification_createdby)
- [lk_msdyn_quotelinetransactionclassification_createdonbehalfby](#BKMK_lk_msdyn_quotelinetransactionclassification_createdonbehalfby)
- [lk_msdyn_quotelinetransactionclassification_modifiedby](#BKMK_lk_msdyn_quotelinetransactionclassification_modifiedby)
- [lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby](#BKMK_lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby)
- [user_msdyn_quotelinetransactionclassification](#BKMK_user_msdyn_quotelinetransactionclassification)
- [team_msdyn_quotelinetransactionclassification](#BKMK_team_msdyn_quotelinetransactionclassification)
- [business_unit_msdyn_quotelinetransactionclassification](#BKMK_business_unit_msdyn_quotelinetransactionclassification)
- [msdyn_quotedetail_msdyn_quotelinetransactioncla](#BKMK_msdyn_quotedetail_msdyn_quotelinetransactioncla)


### <a name="BKMK_lk_msdyn_quotelinetransactionclassification_createdby"></a> lk_msdyn_quotelinetransactionclassification_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinetransactionclassification_createdby](systemuser.md#BKMK_lk_msdyn_quotelinetransactionclassification_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinetransactionclassification_createdonbehalfby"></a> lk_msdyn_quotelinetransactionclassification_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinetransactionclassification_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinetransactionclassification_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinetransactionclassification_modifiedby"></a> lk_msdyn_quotelinetransactionclassification_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinetransactionclassification_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelinetransactionclassification_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby"></a> lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinetransactionclassification_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelinetransactionclassification"></a> user_msdyn_quotelinetransactionclassification

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_quotelinetransactionclassification](systemuser.md#BKMK_user_msdyn_quotelinetransactionclassification) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelinetransactionclassification"></a> team_msdyn_quotelinetransactionclassification

**Added by**: System Solution Solution

See team Entity [team_msdyn_quotelinetransactionclassification](team.md#BKMK_team_msdyn_quotelinetransactionclassification) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelinetransactionclassification"></a> business_unit_msdyn_quotelinetransactionclassification

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_quotelinetransactionclassification](businessunit.md#BKMK_business_unit_msdyn_quotelinetransactionclassification) One-To-Many relationship.

### <a name="BKMK_msdyn_quotedetail_msdyn_quotelinetransactioncla"></a> msdyn_quotedetail_msdyn_quotelinetransactioncla

**Added by**: Sales Solution

See quotedetail Entity [msdyn_quotedetail_msdyn_quotelinetransactioncla](quotedetail.md#BKMK_msdyn_quotedetail_msdyn_quotelinetransactioncla) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelinetransactionclassification?text=msdyn_quotelinetransactionclassification EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]