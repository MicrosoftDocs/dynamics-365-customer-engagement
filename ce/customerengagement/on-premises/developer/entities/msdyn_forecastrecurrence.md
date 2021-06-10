---
title: "msdyn_forecastrecurrence Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_forecastrecurrence entity."
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
# msdyn_forecastrecurrence Entity Reference

Stores recalculation information for each recurrence of the forecast hierarchy. For internal use.

**Added by**: Forecasting Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_forecastrecurrences|
|DisplayCollectionName|Forecast recurrences|
|DisplayName|Forecast recurrence|
|EntitySetName|msdyn_forecastrecurrences|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_forecastrecurrences|
|LogicalName|msdyn_forecastrecurrence|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_forecastrecurrenceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_forecastrecurrence|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actualparticipatingrecordsfetchxml](#BKMK_msdyn_actualparticipatingrecordsfetchxml)
- [msdyn_failureinfo](#BKMK_msdyn_failureinfo)
- [msdyn_forecastdefinitionid](#BKMK_msdyn_forecastdefinitionid)
- [msdyn_forecastrecurrenceId](#BKMK_msdyn_forecastrecurrenceId)
- [msdyn_inprogressparticipatingrecordsfetchxml](#BKMK_msdyn_inprogressparticipatingrecordsfetchxml)
- [msdyn_ishierarchylocked](#BKMK_msdyn_ishierarchylocked)
- [msdyn_lastrecalculatedon](#BKMK_msdyn_lastrecalculatedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_recalculationstarttime](#BKMK_msdyn_recalculationstarttime)
- [msdyn_recalculationstatus](#BKMK_msdyn_recalculationstatus)
- [msdyn_recalculationstatusdescription](#BKMK_msdyn_recalculationstatusdescription)
- [msdyn_recurrenceindex](#BKMK_msdyn_recurrenceindex)
- [msdyn_validfrom](#BKMK_msdyn_validfrom)
- [msdyn_validto](#BKMK_msdyn_validto)
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


### <a name="BKMK_msdyn_actualparticipatingrecordsfetchxml"></a> msdyn_actualparticipatingrecordsfetchxml

|Property|Value|
|--------|-----|
|Description|Stores the FetchXML for participating records for closed opportunities. For internal use.|
|DisplayName|Closed participating opportunities FetchXML|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_actualparticipatingrecordsfetchxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_failureinfo"></a> msdyn_failureinfo

|Property|Value|
|--------|-----|
|Description|Stores information about why the recalculation of forecast hierarchy failed.|
|DisplayName|Failure info|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_failureinfo|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_forecastdefinitionid"></a> msdyn_forecastdefinitionid

|Property|Value|
|--------|-----|
|Description|Unique identifier for the forecast definition that is associated with the forecast recurrence.|
|DisplayName|Forecast definition|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastdefinitionid|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_forecastdefinition|
|Type|Lookup|


### <a name="BKMK_msdyn_forecastrecurrenceId"></a> msdyn_forecastrecurrenceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the forecast recurrence.|
|DisplayName|Forecast recurrence|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_forecastrecurrenceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_inprogressparticipatingrecordsfetchxml"></a> msdyn_inprogressparticipatingrecordsfetchxml

|Property|Value|
|--------|-----|
|Description|Stores the FetchXML for participating records for inprogress opportunities. For internal use.|
|DisplayName|Inprogress participating opportunities FetchXML|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_inprogressparticipatingrecordsfetchxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ishierarchylocked"></a> msdyn_ishierarchylocked

|Property|Value|
|--------|-----|
|Description|For internal use only|
|DisplayName|IsHierarchyLocked|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ishierarchylocked|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_ishierarchylocked Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_lastrecalculatedon"></a> msdyn_lastrecalculatedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|The date and time when the forecast hierarchy was successfully recalculated.|
|DisplayName|Last recalculated on|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastrecalculatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Shows the name of the forecast recurrence.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_recalculationstarttime"></a> msdyn_recalculationstarttime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|The date and time when the recalculation started for the forecast hierarchy.|
|DisplayName|Recalculation start time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recalculationstarttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_recalculationstatus"></a> msdyn_recalculationstatus

|Property|Value|
|--------|-----|
|Description|Shows the recalculation status for the forecast recurrence hierarchy.|
|DisplayName|Recalculation status|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recalculationstatus|
|MaxValue|100|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_recalculationstatusdescription"></a> msdyn_recalculationstatusdescription

|Property|Value|
|--------|-----|
|Description|Stores the description for the recalculation status of forecast hierarchy.|
|DisplayName|Recalculation status description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recalculationstatusdescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_recurrenceindex"></a> msdyn_recurrenceindex

|Property|Value|
|--------|-----|
|Description|Stores the recurrence index that is associated with the forecast recurrence hierarchy.|
|DisplayName|Recurrence index|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_recurrenceindex|
|MaxValue|99|
|MinValue|1|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_validfrom"></a> msdyn_validfrom

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Shows the date from which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement (on-premises) options.|
|DisplayName|Valid from|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_validfrom|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_validto"></a> msdyn_validto

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Shows the date till which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement (on-premises) options.|
|DisplayName|Valid to|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_validto|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


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
|Description|Status of the Forecast Recurrence|
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
|Description|Reason for the status of the Forecast Recurrence|
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
- [msdyn_ForecastDefinitionIdName](#BKMK_msdyn_ForecastDefinitionIdName)
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


### <a name="BKMK_msdyn_ForecastDefinitionIdName"></a> msdyn_ForecastDefinitionIdName

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

- [msdyn_forecastrecurrence_SyncErrors](#BKMK_msdyn_forecastrecurrence_SyncErrors)
- [msdyn_forecastrecurrence_DuplicateMatchingRecord](#BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord)
- [msdyn_forecastrecurrence_DuplicateBaseRecord](#BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord)
- [msdyn_forecastrecurrence_AsyncOperations](#BKMK_msdyn_forecastrecurrence_AsyncOperations)
- [msdyn_forecastrecurrence_MailboxTrackingFolders](#BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders)
- [msdyn_forecastrecurrence_ProcessSession](#BKMK_msdyn_forecastrecurrence_ProcessSession)
- [msdyn_forecastrecurrence_BulkDeleteFailures](#BKMK_msdyn_forecastrecurrence_BulkDeleteFailures)
- [msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)


### <a name="BKMK_msdyn_forecastrecurrence_SyncErrors"></a> msdyn_forecastrecurrence_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_forecastrecurrence_SyncErrors](syncerror.md#BKMK_msdyn_forecastrecurrence_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord"></a> msdyn_forecastrecurrence_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_forecastrecurrence_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord"></a> msdyn_forecastrecurrence_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_forecastrecurrence_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_AsyncOperations"></a> msdyn_forecastrecurrence_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_forecastrecurrence_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastrecurrence_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders"></a> msdyn_forecastrecurrence_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_forecastrecurrence_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_ProcessSession"></a> msdyn_forecastrecurrence_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_forecastrecurrence_ProcessSession](processsession.md#BKMK_msdyn_forecastrecurrence_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_BulkDeleteFailures"></a> msdyn_forecastrecurrence_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_forecastrecurrence_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastrecurrence_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses"></a> msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance"></a> msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance

Same as msdyn_forecastinstance entity [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastinstance|
|ReferencingAttribute|msdyn_forecastrecurrenceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_forecastrecurrence_createdby](#BKMK_lk_msdyn_forecastrecurrence_createdby)
- [lk_msdyn_forecastrecurrence_createdonbehalfby](#BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby)
- [lk_msdyn_forecastrecurrence_modifiedby](#BKMK_lk_msdyn_forecastrecurrence_modifiedby)
- [lk_msdyn_forecastrecurrence_modifiedonbehalfby](#BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby)
- [user_msdyn_forecastrecurrence](#BKMK_user_msdyn_forecastrecurrence)
- [team_msdyn_forecastrecurrence](#BKMK_team_msdyn_forecastrecurrence)
- [business_unit_msdyn_forecastrecurrence](#BKMK_business_unit_msdyn_forecastrecurrence)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence)


### <a name="BKMK_lk_msdyn_forecastrecurrence_createdby"></a> lk_msdyn_forecastrecurrence_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastrecurrence_createdby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby"></a> lk_msdyn_forecastrecurrence_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastrecurrence_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastrecurrence_modifiedby"></a> lk_msdyn_forecastrecurrence_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastrecurrence_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby"></a> lk_msdyn_forecastrecurrence_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_forecastrecurrence_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_forecastrecurrence"></a> user_msdyn_forecastrecurrence

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_forecastrecurrence](systemuser.md#BKMK_user_msdyn_forecastrecurrence) One-To-Many relationship.

### <a name="BKMK_team_msdyn_forecastrecurrence"></a> team_msdyn_forecastrecurrence

**Added by**: System Solution Solution

See team Entity [team_msdyn_forecastrecurrence](team.md#BKMK_team_msdyn_forecastrecurrence) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_forecastrecurrence"></a> business_unit_msdyn_forecastrecurrence

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_forecastrecurrence](businessunit.md#BKMK_business_unit_msdyn_forecastrecurrence) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence

See msdyn_forecastdefinition Entity [msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](msdyn_forecastdefinition.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_forecastrecurrence?text=msdyn_forecastrecurrence EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]