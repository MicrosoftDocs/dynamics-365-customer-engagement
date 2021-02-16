---
title: "msdyn_timeentry Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_timeentry entity."
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
# msdyn_timeentry Entity Reference

Entity used  for time entry.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_timeentries<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_timeentries<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_timeentries(*msdyn_timeentryid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_timeentries|
|DisplayCollectionName|Time Entries|
|DisplayName|Time Entry|
|EntitySetName|msdyn_timeentries|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_timeentries|
|LogicalName|msdyn_timeentry|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_timeentryid|
|PrimaryNameAttribute|msdyn_description|
|SchemaName|msdyn_timeentry|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_date](#BKMK_msdyn_date)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_duration](#BKMK_msdyn_duration)
- [msdyn_entryStatus](#BKMK_msdyn_entryStatus)
- [msdyn_externalDescription](#BKMK_msdyn_externalDescription)
- [msdyn_manager](#BKMK_msdyn_manager)
- [msdyn_project](#BKMK_msdyn_project)
- [msdyn_projectTask](#BKMK_msdyn_projectTask)
- [msdyn_relatedItemId](#BKMK_msdyn_relatedItemId)
- [msdyn_relatedItemType](#BKMK_msdyn_relatedItemType)
- [msdyn_resourceCategory](#BKMK_msdyn_resourceCategory)
- [msdyn_ResourceOrganizationalUnitId](#BKMK_msdyn_ResourceOrganizationalUnitId)
- [msdyn_targetEntryStatus](#BKMK_msdyn_targetEntryStatus)
- [msdyn_timeentryId](#BKMK_msdyn_timeentryId)
- [msdyn_transactioncategory](#BKMK_msdyn_transactioncategory)
- [msdyn_type](#BKMK_msdyn_type)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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


### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

|Property|Value|
|--------|-----|
|Description|Shows the bookable resource.|
|DisplayName|Bookable Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_date"></a> msdyn_date

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the time entry date.|
|DisplayName|Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_date|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type the description of the time entry.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_duration"></a> msdyn_duration

|Property|Value|
|--------|-----|
|Description|Shows the time spent.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_entryStatus"></a> msdyn_entryStatus

|Property|Value|
|--------|-----|
|Description|Select the entry status.|
|DisplayName|Entry Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entrystatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_entryStatus Options

|Value|Label|
|-----|-----|
|192350000|Draft|
|192350001|Returned|
|192350002|Approved|
|192350003|Submitted|
|192350004|Recall Requested|



### <a name="BKMK_msdyn_externalDescription"></a> msdyn_externalDescription

|Property|Value|
|--------|-----|
|Description|Type the external description of the time entry.|
|DisplayName|External Comments|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externaldescription|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_manager"></a> msdyn_manager

|Property|Value|
|--------|-----|
|Description|Select the manager of the time entry user. This field is used for approval.|
|DisplayName|Manager|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_manager|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_project"></a> msdyn_project

|Property|Value|
|--------|-----|
|Description|Select the project that the time entry is related to.|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_projectTask"></a> msdyn_projectTask

|Property|Value|
|--------|-----|
|Description|Select the project task that the time entry is related to.|
|DisplayName|Project Task|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projecttask|
|RequiredLevel|None|
|Targets|msdyn_projecttask|
|Type|Lookup|


### <a name="BKMK_msdyn_relatedItemId"></a> msdyn_relatedItemId

|Property|Value|
|--------|-----|
|Description|The identifier of the related item.|
|DisplayName|Related item identifier|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_relateditemid|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_relatedItemType"></a> msdyn_relatedItemType

|Property|Value|
|--------|-----|
|Description|The related item type|
|DisplayName|Related item type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_relateditemtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_relatedItemType Options

|Value|Label|
|-----|-----|
|192350000|None|
|192350001|Resource Booking|
|192350002|Resource Assignment|
|192350100|Exchange Appointments|



### <a name="BKMK_msdyn_resourceCategory"></a> msdyn_resourceCategory

|Property|Value|
|--------|-----|
|Description|Select the role that the user has in the project that the time entry is for.|
|DisplayName|Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategory|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceOrganizationalUnitId"></a> msdyn_ResourceOrganizationalUnitId

|Property|Value|
|--------|-----|
|Description|Select the organizational unit at the time the entry was registered of the resource who performed the work.|
|DisplayName|Resourcing Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourceorganizationalunitid|
|RequiredLevel|Recommended|
|Targets|msdyn_organizationalunit|
|Type|Lookup|


### <a name="BKMK_msdyn_targetEntryStatus"></a> msdyn_targetEntryStatus

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Target Entry Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_targetentrystatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_targetEntryStatus Options

|Value|Label|
|-----|-----|
|192350000|Draft|
|192350001|Returned|
|192350002|Approved|
|192350003|Submitted|
|192350004|Recall Requested|



### <a name="BKMK_msdyn_timeentryId"></a> msdyn_timeentryId

|Property|Value|
|--------|-----|
|Description|The unique identifier for a time entry.|
|DisplayName|Time Entry|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_timeentryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_transactioncategory"></a> msdyn_transactioncategory

|Property|Value|
|--------|-----|
|Description|Shows the transaction category.|
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|--------|-----|
|Description|Select the time entry type.|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_type|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_type Options

|Value|Label|
|-----|-----|
|192350000|Work|
|192350001|Absence|
|192350002|Vacation|



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


### <a name="BKMK_processid"></a> processid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
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
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Time Entry|
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
|Description|Reason for the status of the Time Entry|
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
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
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_managerName](#BKMK_msdyn_managerName)
- [msdyn_managerYomiName](#BKMK_msdyn_managerYomiName)
- [msdyn_projectName](#BKMK_msdyn_projectName)
- [msdyn_projectTaskName](#BKMK_msdyn_projectTaskName)
- [msdyn_resourceCategoryName](#BKMK_msdyn_resourceCategoryName)
- [msdyn_ResourceOrganizationalUnitIdName](#BKMK_msdyn_ResourceOrganizationalUnitIdName)
- [msdyn_transactioncategoryName](#BKMK_msdyn_transactioncategoryName)
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


### <a name="BKMK_msdyn_bookableresourceName"></a> msdyn_bookableresourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_managerName"></a> msdyn_managerName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_managername|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_managerYomiName"></a> msdyn_managerYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_manageryominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_msdyn_projectTaskName"></a> msdyn_projectTaskName

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


### <a name="BKMK_msdyn_resourceCategoryName"></a> msdyn_resourceCategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceOrganizationalUnitIdName"></a> msdyn_ResourceOrganizationalUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourceorganizationalunitidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_transactioncategoryName"></a> msdyn_transactioncategoryName

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

- [msdyn_timeentry_SyncErrors](#BKMK_msdyn_timeentry_SyncErrors)
- [msdyn_timeentry_AsyncOperations](#BKMK_msdyn_timeentry_AsyncOperations)
- [msdyn_timeentry_MailboxTrackingFolders](#BKMK_msdyn_timeentry_MailboxTrackingFolders)
- [msdyn_timeentry_ProcessSession](#BKMK_msdyn_timeentry_ProcessSession)
- [msdyn_timeentry_BulkDeleteFailures](#BKMK_msdyn_timeentry_BulkDeleteFailures)
- [msdyn_timeentry_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses)
- [msdyn_timeentry_Annotations](#BKMK_msdyn_timeentry_Annotations)
- [msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry](#BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry)
- [msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry](#BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry)


### <a name="BKMK_msdyn_timeentry_SyncErrors"></a> msdyn_timeentry_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_timeentry_SyncErrors](syncerror.md#BKMK_msdyn_timeentry_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_AsyncOperations"></a> msdyn_timeentry_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_timeentry_AsyncOperations](asyncoperation.md#BKMK_msdyn_timeentry_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_MailboxTrackingFolders"></a> msdyn_timeentry_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_timeentry_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_timeentry_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_ProcessSession"></a> msdyn_timeentry_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_timeentry_ProcessSession](processsession.md#BKMK_msdyn_timeentry_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_BulkDeleteFailures"></a> msdyn_timeentry_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_timeentry_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_timeentry_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses"></a> msdyn_timeentry_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_timeentry_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_timeentry_Annotations"></a> msdyn_timeentry_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_timeentry_Annotations](annotation.md#BKMK_msdyn_timeentry_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_timeentry_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry"></a> msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry

Same as msdyn_projectapproval entity [msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry](msdyn_projectapproval.md#BKMK_msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|msdyn_timeentry|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry"></a> msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry

Same as msdyn_timeoffcalendar entity [msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry](msdyn_timeoffcalendar.md#BKMK_msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeoffcalendar|
|ReferencingAttribute|msdyn_timeentry|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_timeentry_createdby](#BKMK_lk_msdyn_timeentry_createdby)
- [lk_msdyn_timeentry_createdonbehalfby](#BKMK_lk_msdyn_timeentry_createdonbehalfby)
- [lk_msdyn_timeentry_modifiedby](#BKMK_lk_msdyn_timeentry_modifiedby)
- [lk_msdyn_timeentry_modifiedonbehalfby](#BKMK_lk_msdyn_timeentry_modifiedonbehalfby)
- [user_msdyn_timeentry](#BKMK_user_msdyn_timeentry)
- [team_msdyn_timeentry](#BKMK_team_msdyn_timeentry)
- [business_unit_msdyn_timeentry](#BKMK_business_unit_msdyn_timeentry)
- [processstage_msdyn_timeentry](#BKMK_processstage_msdyn_timeentry)
- [msdyn_bookableresource_msdyn_timeentry_bookableresource](#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory)
- [msdyn_msdyn_project_msdyn_timeentry_project](#BKMK_msdyn_msdyn_project_msdyn_timeentry_project)
- [msdyn_msdyn_projecttask_msdyn_timeentry_projectTask](#BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask)
- [msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory)
- [msdyn_organizationalunit_timeentry](#BKMK_msdyn_organizationalunit_timeentry)
- [msdyn_systemuser_msdyn_timeentry_manager](#BKMK_msdyn_systemuser_msdyn_timeentry_manager)


### <a name="BKMK_lk_msdyn_timeentry_createdby"></a> lk_msdyn_timeentry_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_timeentry_createdby](systemuser.md#BKMK_lk_msdyn_timeentry_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_createdonbehalfby"></a> lk_msdyn_timeentry_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_timeentry_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_timeentry_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_modifiedby"></a> lk_msdyn_timeentry_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_timeentry_modifiedby](systemuser.md#BKMK_lk_msdyn_timeentry_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_timeentry_modifiedonbehalfby"></a> lk_msdyn_timeentry_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_timeentry_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_timeentry_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_timeentry"></a> user_msdyn_timeentry

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_timeentry](systemuser.md#BKMK_user_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

**Added by**: System Solution Solution

See team Entity [team_msdyn_timeentry](team.md#BKMK_team_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_timeentry"></a> business_unit_msdyn_timeentry

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_timeentry](businessunit.md#BKMK_business_unit_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_timeentry"></a> processstage_msdyn_timeentry

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_timeentry](processstage.md#BKMK_processstage_msdyn_timeentry) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource"></a> msdyn_bookableresource_msdyn_timeentry_bookableresource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_timeentry_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory"></a> msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_timeentry_project"></a> msdyn_msdyn_project_msdyn_timeentry_project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_timeentry_project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_timeentry_project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask"></a> msdyn_msdyn_projecttask_msdyn_timeentry_projectTask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_timeentry_projectTask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_timeentry_projectTask) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_timeentry"></a> msdyn_organizationalunit_timeentry

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_organizationalunit_timeentry](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_timeentry) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_timeentry_manager"></a> msdyn_systemuser_msdyn_timeentry_manager

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_timeentry_manager](systemuser.md#BKMK_msdyn_systemuser_msdyn_timeentry_manager) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_timeentry?text=msdyn_timeentry EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]