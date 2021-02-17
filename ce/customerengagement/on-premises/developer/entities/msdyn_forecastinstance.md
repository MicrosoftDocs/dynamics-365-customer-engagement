---
title: "msdyn_forecastinstance Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_forecastinstance entity."
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
# msdyn_forecastinstance Entity Reference

Stores sales predictions for your team or organization. For internal use.

**Added by**: Forecasting Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_forecastinstances<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_forecastinstances<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_forecastinstances|
|DisplayCollectionName|Forecasts|
|DisplayName|Forecast|
|EntitySetName|msdyn_forecastinstances|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_forecastinstances|
|LogicalName|msdyn_forecastinstance|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_forecastinstanceid|
|PrimaryNameAttribute|msdyn_forecastname|
|SchemaName|msdyn_forecastinstance|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actualamount](#BKMK_msdyn_actualamount)
- [msdyn_bestcaseamount](#BKMK_msdyn_bestcaseamount)
- [msdyn_committedamount](#BKMK_msdyn_committedamount)
- [msdyn_forecastdefinitionid](#BKMK_msdyn_forecastdefinitionid)
- [msdyn_forecastinstanceId](#BKMK_msdyn_forecastinstanceId)
- [msdyn_forecastinstancetype](#BKMK_msdyn_forecastinstancetype)
- [msdyn_forecastname](#BKMK_msdyn_forecastname)
- [msdyn_forecastparentid](#BKMK_msdyn_forecastparentid)
- [msdyn_forecastrecurrenceid](#BKMK_msdyn_forecastrecurrenceid)
- [msdyn_ismanualbestcase](#BKMK_msdyn_ismanualbestcase)
- [msdyn_ismanualcommitted](#BKMK_msdyn_ismanualcommitted)
- [msdyn_ismanualpipeline](#BKMK_msdyn_ismanualpipeline)
- [msdyn_isquotasourcemanual](#BKMK_msdyn_isquotasourcemanual)
- [msdyn_level](#BKMK_msdyn_level)
- [msdyn_manualbestcaseamount](#BKMK_msdyn_manualbestcaseamount)
- [msdyn_manualcommittedamount](#BKMK_msdyn_manualcommittedamount)
- [msdyn_manualpipelineamount](#BKMK_msdyn_manualpipelineamount)
- [msdyn_matchinggoalid](#BKMK_msdyn_matchinggoalid)
- [msdyn_pipelineamount](#BKMK_msdyn_pipelineamount)
- [msdyn_recurrenceindex](#BKMK_msdyn_recurrenceindex)
- [msdyn_targetamount](#BKMK_msdyn_targetamount)
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


### <a name="BKMK_msdyn_actualamount"></a> msdyn_actualamount

|Property|Value|
|--------|-----|
|Description|Shows the actual value (money) achieved toward the target as of the last rollup date.|
|DisplayName|Closed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_bestcaseamount"></a> msdyn_bestcaseamount

|Property|Value|
|--------|-----|
|Description|Shows the rollup value (money) for the best case category as of the last rollup date.|
|DisplayName|Best case|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bestcaseamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_committedamount"></a> msdyn_committedamount

|Property|Value|
|--------|-----|
|Description|Shows the committed rollup value (money) as of the last rollup date.|
|DisplayName|Committed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_committedamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_forecastdefinitionid"></a> msdyn_forecastdefinitionid

|Property|Value|
|--------|-----|
|Description|Unique identifier for the forecast definition that is associated with the forecast.|
|DisplayName|Forecast definition|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastdefinitionid|
|RequiredLevel|None|
|Targets|msdyn_forecastdefinition|
|Type|Lookup|


### <a name="BKMK_msdyn_forecastinstanceId"></a> msdyn_forecastinstanceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the forecast.|
|DisplayName|Forecast|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_forecastinstanceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_forecastinstancetype"></a> msdyn_forecastinstancetype

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Forecast type|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastinstancetype|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_forecastname"></a> msdyn_forecastname

|Property|Value|
|--------|-----|
|Description|Name of the forecast.|
|DisplayName|Forecast|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_forecastparentid"></a> msdyn_forecastparentid

|Property|Value|
|--------|-----|
|Description|Unique identifier for the parent forecast that is associated with the forecast.|
|DisplayName|Forecast parent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastparentid|
|RequiredLevel|None|
|Targets|msdyn_forecastinstance|
|Type|Lookup|


### <a name="BKMK_msdyn_forecastrecurrenceid"></a> msdyn_forecastrecurrenceid

|Property|Value|
|--------|-----|
|Description|Unique identifier for the forecast recurrence associated with the forecast.|
|DisplayName|Forecast recurrence|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastrecurrenceid|
|RequiredLevel|None|
|Targets|msdyn_forecastrecurrence|
|Type|Lookup|


### <a name="BKMK_msdyn_ismanualbestcase"></a> msdyn_ismanualbestcase

|Property|Value|
|--------|-----|
|Description|Select whether the bestcase rollup has been manually updated.|
|DisplayName|Adjust manually (Best case)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ismanualbestcase|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ismanualcommitted"></a> msdyn_ismanualcommitted

|Property|Value|
|--------|-----|
|Description|Select whether the committed rollup has been manually updated.|
|DisplayName|Adjust manually (Committed)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ismanualcommitted|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ismanualpipeline"></a> msdyn_ismanualpipeline

|Property|Value|
|--------|-----|
|Description|Select whether the pipeline rollup has been manually updated.|
|DisplayName|Adjust manually (Pipeline)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ismanualpipeline|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_isquotasourcemanual"></a> msdyn_isquotasourcemanual

|Property|Value|
|--------|-----|
|Description|Is quota source manual|
|DisplayName|Is quota source manual|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_isquotasourcemanual|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isquotasourcemanual Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_level"></a> msdyn_level

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Record level|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_level|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_manualbestcaseamount"></a> msdyn_manualbestcaseamount

|Property|Value|
|--------|-----|
|Description|Shows the changed value of the best case rollup (Money type) as of the last rolled-up date.|
|DisplayName|Best case|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualbestcaseamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_manualcommittedamount"></a> msdyn_manualcommittedamount

|Property|Value|
|--------|-----|
|Description|Shows the changed value of the committed rollup (Money type) as of the last rolled-up date.|
|DisplayName|Committed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualcommittedamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_manualpipelineamount"></a> msdyn_manualpipelineamount

|Property|Value|
|--------|-----|
|Description|Shows the changed value of the pipeline rollup (Money type) as of the last rolled-up date.|
|DisplayName|Pipeline|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualpipelineamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_matchinggoalid"></a> msdyn_matchinggoalid

|Property|Value|
|--------|-----|
|Description|Unique identifier for the matching goal associated with the forecast.|
|DisplayName|Matching goal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_matchinggoalid|
|RequiredLevel|None|
|Targets|goal|
|Type|Lookup|


### <a name="BKMK_msdyn_pipelineamount"></a> msdyn_pipelineamount

|Property|Value|
|--------|-----|
|Description|Shows the pipeline rollup value (money) as of the last rollup date.|
|DisplayName|Pipeline|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pipelineamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_recurrenceindex"></a> msdyn_recurrenceindex

|Property|Value|
|--------|-----|
|Description|Shows the recurrence index of the forecast created from the forecast definition.|
|DisplayName|Recurrence index|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recurrenceindex|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_targetamount"></a> msdyn_targetamount

|Property|Value|
|--------|-----|
|Description|Select a target (Money type) to track a monetary amount, such as estimated revenue from an opportunity.|
|DisplayName|Quota|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_targetamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
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
|Description|Status of the Forecast|
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
|Description|Reason for the status of the Forecast|
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
- [msdyn_actualamount_Base](#BKMK_msdyn_actualamount_Base)
- [msdyn_bestcaseamount_Base](#BKMK_msdyn_bestcaseamount_Base)
- [msdyn_committedamount_Base](#BKMK_msdyn_committedamount_Base)
- [msdyn_forecastdefinitionidName](#BKMK_msdyn_forecastdefinitionidName)
- [msdyn_forecastparentidName](#BKMK_msdyn_forecastparentidName)
- [msdyn_forecastrecurrenceidName](#BKMK_msdyn_forecastrecurrenceidName)
- [msdyn_manualbestcaseamount_Base](#BKMK_msdyn_manualbestcaseamount_Base)
- [msdyn_manualcommittedamount_Base](#BKMK_msdyn_manualcommittedamount_Base)
- [msdyn_manualpipelineamount_Base](#BKMK_msdyn_manualpipelineamount_Base)
- [msdyn_matchinggoalidName](#BKMK_msdyn_matchinggoalidName)
- [msdyn_percentageachieved](#BKMK_msdyn_percentageachieved)
- [msdyn_pipelineamount_Base](#BKMK_msdyn_pipelineamount_Base)
- [msdyn_targetamount_Base](#BKMK_msdyn_targetamount_Base)
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


### <a name="BKMK_msdyn_actualamount_Base"></a> msdyn_actualamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual (Money) in base currency.|
|DisplayName|Actual (Money) (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_bestcaseamount_Base"></a> msdyn_bestcaseamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the BestCase in base currency.|
|DisplayName|bestcaseamount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bestcaseamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_committedamount_Base"></a> msdyn_committedamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Committed in base currency.|
|DisplayName|Committed (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_committedamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_forecastdefinitionidName"></a> msdyn_forecastdefinitionidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_forecastdefinitionidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_forecastparentidName"></a> msdyn_forecastparentidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_forecastparentidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_forecastrecurrenceidName"></a> msdyn_forecastrecurrenceidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_forecastrecurrenceidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_manualbestcaseamount_Base"></a> msdyn_manualbestcaseamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Manual BestCase in base currency.|
|DisplayName|Manual BestCase (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualbestcaseamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_manualcommittedamount_Base"></a> msdyn_manualcommittedamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Manual Committed in base currency.|
|DisplayName|Manual Committed (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualcommittedamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_manualpipelineamount_Base"></a> msdyn_manualpipelineamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Manual Pipeline in base currency.|
|DisplayName|Manual Pipeline (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manualpipelineamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_matchinggoalidName"></a> msdyn_matchinggoalidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_matchinggoalidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_percentageachieved"></a> msdyn_percentageachieved

|Property|Value|
|--------|-----|
|Description|Shows the percentage achieved against the target.|
|DisplayName|Achieved %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_percentageachieved|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_pipelineamount_Base"></a> msdyn_pipelineamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Pipeline in base currency.|
|DisplayName|Pipeline (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pipelineamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_targetamount_Base"></a> msdyn_targetamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Target (Money) in base currency.|
|DisplayName|Target (Money) (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_targetamount_base|
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

- [msdyn_forecastinstance_SyncErrors](#BKMK_msdyn_forecastinstance_SyncErrors)
- [msdyn_forecastinstance_DuplicateMatchingRecord](#BKMK_msdyn_forecastinstance_DuplicateMatchingRecord)
- [msdyn_forecastinstance_DuplicateBaseRecord](#BKMK_msdyn_forecastinstance_DuplicateBaseRecord)
- [msdyn_forecastinstance_AsyncOperations](#BKMK_msdyn_forecastinstance_AsyncOperations)
- [msdyn_forecastinstance_MailboxTrackingFolders](#BKMK_msdyn_forecastinstance_MailboxTrackingFolders)
- [msdyn_forecastinstance_ProcessSession](#BKMK_msdyn_forecastinstance_ProcessSession)
- [msdyn_forecastinstance_BulkDeleteFailures](#BKMK_msdyn_forecastinstance_BulkDeleteFailures)
- [msdyn_forecastinstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance)


### <a name="BKMK_msdyn_forecastinstance_SyncErrors"></a> msdyn_forecastinstance_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_forecastinstance_SyncErrors](syncerror.md#BKMK_msdyn_forecastinstance_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_DuplicateMatchingRecord"></a> msdyn_forecastinstance_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_forecastinstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastinstance_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_DuplicateBaseRecord"></a> msdyn_forecastinstance_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_forecastinstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastinstance_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_AsyncOperations"></a> msdyn_forecastinstance_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_forecastinstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastinstance_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_MailboxTrackingFolders"></a> msdyn_forecastinstance_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_forecastinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastinstance_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_ProcessSession"></a> msdyn_forecastinstance_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_forecastinstance_ProcessSession](processsession.md#BKMK_msdyn_forecastinstance_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_BulkDeleteFailures"></a> msdyn_forecastinstance_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_forecastinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastinstance_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses"></a> msdyn_forecastinstance_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_forecastinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastinstance_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance"></a> msdyn_msdyn_forecastinstance_msdyn_forecastinstance

Same as msdyn_forecastinstance entity [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastinstance|
|ReferencingAttribute|msdyn_forecastparentid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_forecastinstance_msdyn_forecastinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_forecastinstance_createdby](#BKMK_lk_msdyn_forecastinstance_createdby)
- [lk_msdyn_forecastinstance_createdonbehalfby](#BKMK_lk_msdyn_forecastinstance_createdonbehalfby)
- [lk_msdyn_forecastinstance_modifiedby](#BKMK_lk_msdyn_forecastinstance_modifiedby)
- [lk_msdyn_forecastinstance_modifiedonbehalfby](#BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby)
- [user_msdyn_forecastinstance](#BKMK_user_msdyn_forecastinstance)
- [team_msdyn_forecastinstance](#BKMK_team_msdyn_forecastinstance)
- [business_unit_msdyn_forecastinstance](#BKMK_business_unit_msdyn_forecastinstance)
- [TransactionCurrency_msdyn_forecastinstance](#BKMK_TransactionCurrency_msdyn_forecastinstance)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance)
- [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance)
- [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)
- [msdyn_goal_msdyn_forecastinstance](#BKMK_msdyn_goal_msdyn_forecastinstance)


### <a name="BKMK_lk_msdyn_forecastinstance_createdby"></a> lk_msdyn_forecastinstance_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastinstance_createdby](systemuser.md#BKMK_lk_msdyn_forecastinstance_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastinstance_createdonbehalfby"></a> lk_msdyn_forecastinstance_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastinstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinstance_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastinstance_modifiedby"></a> lk_msdyn_forecastinstance_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastinstance_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastinstance_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby"></a> lk_msdyn_forecastinstance_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastinstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_forecastinstance"></a> user_msdyn_forecastinstance

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_forecastinstance](systemuser.md#BKMK_user_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_team_msdyn_forecastinstance"></a> team_msdyn_forecastinstance

**Added by**: System Solution Solution

See team Entity [team_msdyn_forecastinstance](team.md#BKMK_team_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_forecastinstance"></a> business_unit_msdyn_forecastinstance

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_forecastinstance](businessunit.md#BKMK_business_unit_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_forecastinstance"></a> TransactionCurrency_msdyn_forecastinstance

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_forecastinstance](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastinstance

See msdyn_forecastdefinition Entity [msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](msdyn_forecastdefinition.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance"></a> msdyn_msdyn_forecastinstance_msdyn_forecastinstance

See msdyn_forecastinstance Entity [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance"></a> msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance

See msdyn_forecastrecurrence Entity [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](msdyn_forecastrecurrence.md#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_goal_msdyn_forecastinstance"></a> msdyn_goal_msdyn_forecastinstance

**Added by**: System Solution Solution

See goal Entity [msdyn_goal_msdyn_forecastinstance](goal.md#BKMK_msdyn_goal_msdyn_forecastinstance) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_forecastinstance?text=msdyn_forecastinstance EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]