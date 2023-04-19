---
title: "Entitlement entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Entitlement entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Entitlement entity reference

Defines the amount and type of support a customer should receive.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RenewEntitlement|<xref:Microsoft.Crm.Sdk.Messages.RenewEntitlementRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Entitlements|
|DisplayCollectionName|Entitlements|
|DisplayName|Entitlement|
|EntitySetName|entitlements|
|IsBPFEntity|False|
|LogicalCollectionName|entitlements|
|LogicalName|entitlement|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|entitlementid|
|PrimaryNameAttribute|name|
|SchemaName|Entitlement|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [DecreaseRemainingOn](#BKMK_DecreaseRemainingOn)
- [Description](#BKMK_Description)
- [EmailAddress](#BKMK_EmailAddress)
- [EndDate](#BKMK_EndDate)
- [EntitlementId](#BKMK_EntitlementId)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDefault](#BKMK_IsDefault)
- [KbAccessLevel](#BKMK_KbAccessLevel)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [RemainingTerms](#BKMK_RemainingTerms)
- [RestrictCaseCreation](#BKMK_RestrictCaseCreation)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StartDate](#BKMK_StartDate)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AllocationTypeCode"></a> AllocationTypeCode

|Property|Value|
|--------|-----|
|Description|Select the type of entitlement terms.|
|DisplayName|Allocation Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allocationtypecode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### AllocationTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Number of cases|Number of cases|
|1|Number of hours|Number of hours|



### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Choose a contact or account for which this entitlement has been defined.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_DecreaseRemainingOn"></a> DecreaseRemainingOn

|Property|Value|
|--------|-----|
|Description|Select whether to decrease the remaining terms when the case is created or when it is resolved.|
|DisplayName|Decrease Remaining On|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|decreaseremainingon|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### DecreaseRemainingOn Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Case Resolution||
|1|Case Creation||



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the Entitlement|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the entitlement ends.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|enddate|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_EntitlementId"></a> EntitlementId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Entitlement|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entitlementid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Entitlement Template associated with Entitlement.|
|DisplayName|Entitlement Template|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitlementtemplateid|
|RequiredLevel|None|
|Targets|entitlementtemplate|
|Type|Lookup|


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


### <a name="BKMK_IsDefault"></a> IsDefault

|Property|Value|
|--------|-----|
|Description|Shows whether this entitlement is the default one for the specified customer.|
|DisplayName|Is Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isdefault|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### IsDefault Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_KbAccessLevel"></a> KbAccessLevel

|Property|Value|
|--------|-----|
|Description|Select the access someone will have to the knowledge base on the portal.|
|DisplayName|KB Access Level|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|kbaccesslevel|
|RequiredLevel|None|
|Type|Picklist|

#### KbAccessLevel Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Standard|Standard|
|1|Premium|Premium|
|2|None|None|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a meaningful name for the entitlement.|
|DisplayName|Entitlement Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
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
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RemainingTerms"></a> RemainingTerms

|Property|Value|
|--------|-----|
|Description|Type the total number of entitlement terms that are left.|
|DisplayName|Remaining Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|remainingterms|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_RestrictCaseCreation"></a> RestrictCaseCreation

|Property|Value|
|--------|-----|
|Description|Tells whether case creation is restricted based on entitlement terms.|
|DisplayName|Restrict based on entitlement terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|restrictcasecreation|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### RestrictCaseCreation Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) associated with the entitlement.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StartDate"></a> StartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the entitlement starts.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|startdate|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|None|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Draft|0|Draft|
|1|Active|1|Active|
|2|Cancelled|2|Cancelled|
|3|Expired|3|Expired|
|4|Waiting|1200|Waiting|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the reason code that explains the status of the entitlement.|
|DisplayName|Status Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|0|Draft|0|
|1|Active|1|
|2|Cancelled|2|
|3|Expired|3|
|1200|Waiting|4|



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


### <a name="BKMK_TotalTerms"></a> TotalTerms

|Property|Value|
|--------|-----|
|Description|Type the total number of entitlement terms.|
|DisplayName|Total Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalterms|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the contact.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
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

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [EntitlementTemplateIdName](#BKMK_EntitlementTemplateIdName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SLAIdName](#BKMK_SLAIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Account associated with Entitlement.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Contact associated with Entitlement.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|RequiredLevel|None|
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
|Description|Unique identifier of the delegate user who created the entitlement.|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntitlementTemplateIdName"></a> EntitlementTemplateIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entitlementtemplateidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the contact with respect to the base currency.|
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
|RequiredLevel|None|
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
|RequiredLevel|None|
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
|RequiredLevel|None|
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


### <a name="BKMK_SLAIdName"></a> SLAIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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

- [entitlement_ActivityPointers](#BKMK_entitlement_ActivityPointers)
- [Entitlement_SyncErrors](#BKMK_Entitlement_SyncErrors)
- [entitlement_ActivityParties](#BKMK_entitlement_ActivityParties)
- [entitlement_AsyncOperations](#BKMK_entitlement_AsyncOperations)
- [Entitlement_MailboxTrackingFolder](#BKMK_Entitlement_MailboxTrackingFolder)
- [entitlement_ProcessSession](#BKMK_entitlement_ProcessSession)
- [entitlement_BulkDeleteFailures](#BKMK_entitlement_BulkDeleteFailures)
- [entitlement_PrincipalObjectAttributeAccesses](#BKMK_entitlement_PrincipalObjectAttributeAccesses)
- [entitlement_Appointments](#BKMK_entitlement_Appointments)
- [entitlement_Emails](#BKMK_entitlement_Emails)
- [entitlement_Faxes](#BKMK_entitlement_Faxes)
- [entitlement_Letters](#BKMK_entitlement_Letters)
- [entitlement_PhoneCalls](#BKMK_entitlement_PhoneCalls)
- [entitlement_Tasks](#BKMK_entitlement_Tasks)
- [entitlement_RecurringAppointmentMasters](#BKMK_entitlement_RecurringAppointmentMasters)
- [entitlement_SocialActivities](#BKMK_entitlement_SocialActivities)
- [entitlement_connections1](#BKMK_entitlement_connections1)
- [entitlement_connections2](#BKMK_entitlement_connections2)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlement_IncidentResolutions](#BKMK_entitlement_IncidentResolutions)
- [entitlement_ServiceAppointments](#BKMK_entitlement_ServiceAppointments)
- [entitlement_cases](#BKMK_entitlement_cases)
- [entitlement_entitlementchannel_EntitlementId](#BKMK_entitlement_entitlementchannel_EntitlementId)
- [entitlement_DuplicateBaseRecord](#BKMK_entitlement_DuplicateBaseRecord)
- [entitlement_DuplicateMatchingRecord](#BKMK_entitlement_DuplicateMatchingRecord)
- [entitlement_OpportunityCloses](#BKMK_entitlement_OpportunityCloses)
- [entitlement_OrderCloses](#BKMK_entitlement_OrderCloses)
- [entitlement_QuoteCloses](#BKMK_entitlement_QuoteCloses)


### <a name="BKMK_entitlement_ActivityPointers"></a> entitlement_ActivityPointers

**Added by**: System Solution Solution

Same as the [entitlement_ActivityPointers](activitypointer.md#BKMK_entitlement_ActivityPointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Entitlement_SyncErrors"></a> Entitlement_SyncErrors

**Added by**: System Solution Solution

Same as the [Entitlement_SyncErrors](syncerror.md#BKMK_Entitlement_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Entitlement_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_ActivityParties"></a> entitlement_ActivityParties

**Added by**: System Solution Solution

Same as the [entitlement_ActivityParties](activityparty.md#BKMK_entitlement_ActivityParties) many-to-one relationship for the [activityparty](activityparty.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|partyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_ActivityParties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_AsyncOperations"></a> entitlement_AsyncOperations

**Added by**: System Solution Solution

Same as the [entitlement_AsyncOperations](asyncoperation.md#BKMK_entitlement_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlement_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Entitlement_MailboxTrackingFolder"></a> Entitlement_MailboxTrackingFolder

**Added by**: System Solution Solution

Same as the [Entitlement_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Entitlement_MailboxTrackingFolder) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Entitlement_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_ProcessSession"></a> entitlement_ProcessSession

**Added by**: System Solution Solution

Same as the [entitlement_ProcessSession](processsession.md#BKMK_entitlement_ProcessSession) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_BulkDeleteFailures"></a> entitlement_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [entitlement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlement_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlement_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_PrincipalObjectAttributeAccesses"></a> entitlement_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [entitlement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlement_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlement_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_Appointments"></a> entitlement_Appointments

**Added by**: System Solution Solution

Same as the [entitlement_Appointments](appointment.md#BKMK_entitlement_Appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Appointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_Emails"></a> entitlement_Emails

**Added by**: System Solution Solution

Same as the [entitlement_Emails](email.md#BKMK_entitlement_Emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Emails|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_Faxes"></a> entitlement_Faxes

**Added by**: System Solution Solution

Same as the [entitlement_Faxes](fax.md#BKMK_entitlement_Faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Faxes|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_Letters"></a> entitlement_Letters

**Added by**: System Solution Solution

Same as the [entitlement_Letters](letter.md#BKMK_entitlement_Letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Letters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_PhoneCalls"></a> entitlement_PhoneCalls

**Added by**: System Solution Solution

Same as the [entitlement_PhoneCalls](phonecall.md#BKMK_entitlement_PhoneCalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_Tasks"></a> entitlement_Tasks

**Added by**: System Solution Solution

Same as the [entitlement_Tasks](task.md#BKMK_entitlement_Tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Tasks|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_RecurringAppointmentMasters"></a> entitlement_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as the [entitlement_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_entitlement_RecurringAppointmentMasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_SocialActivities"></a> entitlement_SocialActivities

**Added by**: System Solution Solution

Same as the [entitlement_SocialActivities](socialactivity.md#BKMK_entitlement_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_SocialActivities|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_connections1"></a> entitlement_connections1

**Added by**: System Solution Solution

Same as the [entitlement_connections1](connection.md#BKMK_entitlement_connections1) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_connections2"></a> entitlement_connections2

**Added by**: System Solution Solution

Same as the [entitlement_connections2](connection.md#BKMK_entitlement_connections2) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_connections2|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

**Added by**: System Solution Solution

Same as the [entitlement_Annotations](annotation.md#BKMK_entitlement_Annotations) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_IncidentResolutions"></a> entitlement_IncidentResolutions

Same as the [entitlement_IncidentResolutions](incidentresolution.md#BKMK_entitlement_IncidentResolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_ServiceAppointments"></a> entitlement_ServiceAppointments

Same as the [entitlement_ServiceAppointments](serviceappointment.md#BKMK_entitlement_ServiceAppointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_cases"></a> entitlement_cases

Same as the [entitlement_cases](incident.md#BKMK_entitlement_cases) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|entitlementid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_cases|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_entitlementchannel_EntitlementId"></a> entitlement_entitlementchannel_EntitlementId

Same as the [entitlement_entitlementchannel_EntitlementId](entitlementchannel.md#BKMK_entitlement_entitlementchannel_EntitlementId) many-to-one relationship for the [entitlementchannel](entitlementchannel.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementchannel|
|ReferencingAttribute|entitlementid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlement_entitlementchannel_EntitlementId|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_DuplicateBaseRecord"></a> entitlement_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [entitlement_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlement_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_DuplicateMatchingRecord"></a> entitlement_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [entitlement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlement_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlement_OpportunityCloses"></a> entitlement_OpportunityCloses

**Added by**: Sales Solution

Same as the [entitlement_OpportunityCloses](opportunityclose.md#BKMK_entitlement_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_OrderCloses"></a> entitlement_OrderCloses

**Added by**: Sales Solution

Same as the [entitlement_OrderCloses](orderclose.md#BKMK_entitlement_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlement_QuoteCloses"></a> entitlement_QuoteCloses

**Added by**: Sales Solution

Same as the [entitlement_QuoteCloses](quoteclose.md#BKMK_entitlement_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlement_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_entitlement_createdby](#BKMK_lk_entitlement_createdby)
- [lk_entitlement_createdonbehalfby](#BKMK_lk_entitlement_createdonbehalfby)
- [lk_entitlement_modifiedby](#BKMK_lk_entitlement_modifiedby)
- [lk_entitlement_modifiedonbehalfby](#BKMK_lk_entitlement_modifiedonbehalfby)
- [user_entitlement](#BKMK_user_entitlement)
- [team_entitlement](#BKMK_team_entitlement)
- [business_unit_entitlement](#BKMK_business_unit_entitlement)
- [processstage_Entitlement](#BKMK_processstage_Entitlement)
- [account_entitlement_Account](#BKMK_account_entitlement_Account)
- [account_entitlement_Customer](#BKMK_account_entitlement_Customer)
- [contact_entitlement_ContactId](#BKMK_contact_entitlement_ContactId)
- [contact_entitlement_Customer](#BKMK_contact_entitlement_Customer)
- [entitlementtemplateid_RelationShip](#BKMK_entitlementtemplateid_RelationShip)
- [sla_entitlement](#BKMK_sla_entitlement)
- [TransactionCurrency_Entitlement](#BKMK_TransactionCurrency_Entitlement)


### <a name="BKMK_lk_entitlement_createdby"></a> lk_entitlement_createdby

**Added by**: System Solution Solution

See the [lk_entitlement_createdby](systemuser.md#BKMK_lk_entitlement_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_entitlement_createdonbehalfby"></a> lk_entitlement_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_entitlement_createdonbehalfby](systemuser.md#BKMK_lk_entitlement_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_entitlement_modifiedby"></a> lk_entitlement_modifiedby

**Added by**: System Solution Solution

See the [lk_entitlement_modifiedby](systemuser.md#BKMK_lk_entitlement_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_entitlement_modifiedonbehalfby"></a> lk_entitlement_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_entitlement_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlement_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_user_entitlement"></a> user_entitlement

**Added by**: System Solution Solution

See the [user_entitlement](systemuser.md#BKMK_user_entitlement) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_entitlement"></a> team_entitlement

**Added by**: System Solution Solution

See the [team_entitlement](team.md#BKMK_team_entitlement) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_business_unit_entitlement"></a> business_unit_entitlement

**Added by**: System Solution Solution

See the [business_unit_entitlement](businessunit.md#BKMK_business_unit_entitlement) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_processstage_Entitlement"></a> processstage_Entitlement

**Added by**: System Solution Solution

See the [processstage_Entitlement](processstage.md#BKMK_processstage_Entitlement) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_account_entitlement_Account"></a> account_entitlement_Account

**Added by**: System Solution Solution

See the [account_entitlement_Account](account.md#BKMK_account_entitlement_Account) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_account_entitlement_Customer"></a> account_entitlement_Customer

**Added by**: System Solution Solution

See the [account_entitlement_Customer](account.md#BKMK_account_entitlement_Customer) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_contact_entitlement_ContactId"></a> contact_entitlement_ContactId

**Added by**: System Solution Solution

See the [contact_entitlement_ContactId](contact.md#BKMK_contact_entitlement_ContactId) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_contact_entitlement_Customer"></a> contact_entitlement_Customer

**Added by**: System Solution Solution

See the [contact_entitlement_Customer](contact.md#BKMK_contact_entitlement_Customer) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_entitlementtemplateid_RelationShip"></a> entitlementtemplateid_RelationShip

See the [entitlementtemplateid_RelationShip](entitlementtemplate.md#BKMK_entitlementtemplateid_RelationShip) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_sla_entitlement"></a> sla_entitlement

**Added by**: System Solution Solution

See the [sla_entitlement](sla.md#BKMK_sla_entitlement) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_TransactionCurrency_Entitlement"></a> TransactionCurrency_Entitlement

**Added by**: System Solution Solution

See the [TransactionCurrency_Entitlement](transactioncurrency.md#BKMK_TransactionCurrency_Entitlement) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Entitlement entity is the first entity in the relationship. Listed by **SchemaName**.

- [entitlementcontacts_association](#BKMK_entitlementcontacts_association)
- [product_entitlement_association](#BKMK_product_entitlement_association)


### <a name="BKMK_entitlementcontacts_association"></a> entitlementcontacts_association

See the [entitlementcontacts_association](contact.md#BKMK_entitlementcontacts_association) many-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_product_entitlement_association"></a> product_entitlement_association

See the [product_entitlement_association](product.md#BKMK_product_entitlement_association) many-to-many relationship for the [product](product.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
