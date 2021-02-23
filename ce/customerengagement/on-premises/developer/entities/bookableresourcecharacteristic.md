---
title: "BookableResourceCharacteristic Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceCharacteristic entity."
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
# BookableResourceCharacteristic Entity Reference

Associates resources with their characteristics and specifies the proficiency level of a resource for that characteristic.

**Added by**: Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcecharacteristics<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcecharacteristics<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcecharacteristics(*bookableresourcecharacteristicid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BookableResourceCharacteristic|
|DisplayCollectionName|Bookable Resource Characteristics|
|DisplayName|Bookable Resource Characteristic|
|EntitySetName|bookableresourcecharacteristics|
|IsBPFEntity|False|
|LogicalCollectionName|bookableresourcecharacteristics|
|LogicalName|bookableresourcecharacteristic|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bookableresourcecharacteristicid|
|PrimaryNameAttribute|name|
|SchemaName|BookableResourceCharacteristic|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceCharacteristicId](#BKMK_BookableResourceCharacteristicId)
- [Characteristic](#BKMK_Characteristic)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_approvalstatus](#BKMK_msdyn_approvalstatus)
- [msdyn_supportingrecord](#BKMK_msdyn_supportingrecord)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [RatingValue](#BKMK_RatingValue)
- [Resource](#BKMK_Resource)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceCharacteristicId"></a> BookableResourceCharacteristicId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource characteristic.|
|DisplayName|Bookable Resource Characteristic|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bookableresourcecharacteristicid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Characteristic"></a> Characteristic

|Property|Value|
|--------|-----|
|Description|Choose the characteristic to associate with the resource.|
|DisplayName|Characteristic|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|characteristic|
|RequiredLevel|SystemRequired|
|Targets|characteristic|
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


### <a name="BKMK_msdyn_approvalstatus"></a> msdyn_approvalstatus

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Approval status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_approvalstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_approvalstatus Options

|Value|Label|
|-----|-----|
|192350000|Saved|
|192350001|Pending Approval|
|192350002|Rejected|
|192350003|Approved|
|192350004|Recalled|



### <a name="BKMK_msdyn_supportingrecord"></a> msdyn_supportingrecord

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Supporting Record|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_supportingrecord|
|RequiredLevel|None|
|Targets|bookableresourcecharacteristic|
|Type|Lookup|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type the name of the association between the resource and characteristic.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|None|
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


### <a name="BKMK_RatingValue"></a> RatingValue

|Property|Value|
|--------|-----|
|Description|Select a rating value that represents the evaluation of a characteristic for a particular resource.|
|DisplayName|Rating Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ratingvalue|
|RequiredLevel|None|
|Targets|ratingvalue|
|Type|Lookup|


### <a name="BKMK_Resource"></a> Resource

|Property|Value|
|--------|-----|
|Description|Shows the resource associated with the characteristic.|
|DisplayName|Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resource|
|RequiredLevel|SystemRequired|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the Bookable Resource Characteristic|
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
|Description|Reason for the status of the Bookable Resource Characteristic|
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
|Description|Exchange rate for the currency associated with the BookableResourceCharacteristic with respect to the base currency.|
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

- [CharacteristicName](#BKMK_CharacteristicName)
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
- [msdyn_supportingrecordName](#BKMK_msdyn_supportingrecordName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RatingValueName](#BKMK_RatingValueName)
- [ResourceName](#BKMK_ResourceName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CharacteristicName"></a> CharacteristicName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|characteristicname|
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
|Description|Exchange rate for the currency associated with the bookableresourcecharacteristic with respect to the base currency.|
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


### <a name="BKMK_msdyn_supportingrecordName"></a> msdyn_supportingrecordName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_supportingrecordname|
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


### <a name="BKMK_RatingValueName"></a> RatingValueName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ratingvaluename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ResourceName"></a> ResourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resourcename|
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

- [BookableResourceCharacteristic_SyncErrors](#BKMK_BookableResourceCharacteristic_SyncErrors)
- [bookableresourcecharacteristic_DuplicateMatchingRecord](#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord)
- [bookableresourcecharacteristic_DuplicateBaseRecord](#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord)
- [bookableresourcecharacteristic_AsyncOperations](#BKMK_bookableresourcecharacteristic_AsyncOperations)
- [bookableresourcecharacteristic_MailboxTrackingFolders](#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders)
- [bookableresourcecharacteristic_ProcessSession](#BKMK_bookableresourcecharacteristic_ProcessSession)
- [bookableresourcecharacteristic_BulkDeleteFailures](#BKMK_bookableresourcecharacteristic_BulkDeleteFailures)
- [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord)
- [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic)


### <a name="BKMK_BookableResourceCharacteristic_SyncErrors"></a> BookableResourceCharacteristic_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [BookableResourceCharacteristic_SyncErrors](syncerror.md#BKMK_BookableResourceCharacteristic_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BookableResourceCharacteristic_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord"></a> bookableresourcecharacteristic_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcecharacteristic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_DuplicateBaseRecord"></a> bookableresourcecharacteristic_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [bookableresourcecharacteristic_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_AsyncOperations"></a> bookableresourcecharacteristic_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [bookableresourcecharacteristic_AsyncOperations](asyncoperation.md#BKMK_bookableresourcecharacteristic_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_MailboxTrackingFolders"></a> bookableresourcecharacteristic_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [bookableresourcecharacteristic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_ProcessSession"></a> bookableresourcecharacteristic_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [bookableresourcecharacteristic_ProcessSession](processsession.md#BKMK_bookableresourcecharacteristic_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_BulkDeleteFailures"></a> bookableresourcecharacteristic_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [bookableresourcecharacteristic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcecharacteristic_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess"></a> bookableresourcecharacteristic_PrincipalObjectAttributeAccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

**Added by**: System Solution Solution

Same as annotation entity [bookableresourcecharacteristic_Annotations](annotation.md#BKMK_bookableresourcecharacteristic_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bookableresourcecharacteristic_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord"></a> msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord

**Added by**: Project Service Automation Solution

Same as bookableresourcecharacteristic entity [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](bookableresourcecharacteristic.md#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|msdyn_supportingrecord|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic"></a> msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic

**Added by**: Project Service Automation Solution

Same as msdyn_approval entity [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](msdyn_approval.md#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_bookableresourcecharacteristic_createdby](#BKMK_lk_bookableresourcecharacteristic_createdby)
- [lk_bookableresourcecharacteristic_createdonbehalfby](#BKMK_lk_bookableresourcecharacteristic_createdonbehalfby)
- [lk_bookableresourcecharacteristic_modifiedby](#BKMK_lk_bookableresourcecharacteristic_modifiedby)
- [lk_bookableresourcecharacteristic_modifiedonbehalfby](#BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby)
- [user_bookableresourcecharacteristic](#BKMK_user_bookableresourcecharacteristic)
- [team_bookableresourcecharacteristic](#BKMK_team_bookableresourcecharacteristic)
- [business_unit_bookableresourcecharacteristic](#BKMK_business_unit_bookableresourcecharacteristic)
- [processstage_BookableResourceCharacteristic](#BKMK_processstage_BookableResourceCharacteristic)
- [bookableresource_bookableresourcecharacteristic_Resource](#BKMK_bookableresource_bookableresourcecharacteristic_Resource)
- [characteristic_bookableresourcecharacteristic_Characteristic](#BKMK_characteristic_bookableresourcecharacteristic_Characteristic)
- [ratingvalue_bookableresourcecharacteristic_RatingValue](#BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue)
- [TransactionCurrency_bookableresourcecharacteristic](#BKMK_TransactionCurrency_bookableresourcecharacteristic)
- [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord)


### <a name="BKMK_lk_bookableresourcecharacteristic_createdby"></a> lk_bookableresourcecharacteristic_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecharacteristic_createdby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_createdonbehalfby"></a> lk_bookableresourcecharacteristic_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecharacteristic_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_modifiedby"></a> lk_bookableresourcecharacteristic_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecharacteristic_modifiedby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby"></a> lk_bookableresourcecharacteristic_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_bookableresourcecharacteristic_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcecharacteristic_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcecharacteristic"></a> user_bookableresourcecharacteristic

**Added by**: System Solution Solution

See systemuser Entity [user_bookableresourcecharacteristic](systemuser.md#BKMK_user_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcecharacteristic"></a> team_bookableresourcecharacteristic

**Added by**: System Solution Solution

See team Entity [team_bookableresourcecharacteristic](team.md#BKMK_team_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcecharacteristic"></a> business_unit_bookableresourcecharacteristic

**Added by**: System Solution Solution

See businessunit Entity [business_unit_bookableresourcecharacteristic](businessunit.md#BKMK_business_unit_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_processstage_BookableResourceCharacteristic"></a> processstage_BookableResourceCharacteristic

**Added by**: System Solution Solution

See processstage Entity [processstage_BookableResourceCharacteristic](processstage.md#BKMK_processstage_BookableResourceCharacteristic) One-To-Many relationship.

### <a name="BKMK_bookableresource_bookableresourcecharacteristic_Resource"></a> bookableresource_bookableresourcecharacteristic_Resource

See bookableresource Entity [bookableresource_bookableresourcecharacteristic_Resource](bookableresource.md#BKMK_bookableresource_bookableresourcecharacteristic_Resource) One-To-Many relationship.

### <a name="BKMK_characteristic_bookableresourcecharacteristic_Characteristic"></a> characteristic_bookableresourcecharacteristic_Characteristic

See characteristic Entity [characteristic_bookableresourcecharacteristic_Characteristic](characteristic.md#BKMK_characteristic_bookableresourcecharacteristic_Characteristic) One-To-Many relationship.

### <a name="BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue"></a> ratingvalue_bookableresourcecharacteristic_RatingValue

See ratingvalue Entity [ratingvalue_bookableresourcecharacteristic_RatingValue](ratingvalue.md#BKMK_ratingvalue_bookableresourcecharacteristic_RatingValue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_bookableresourcecharacteristic"></a> TransactionCurrency_bookableresourcecharacteristic

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_bookableresourcecharacteristic](transactioncurrency.md#BKMK_TransactionCurrency_bookableresourcecharacteristic) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord"></a> msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord

See bookableresourcecharacteristic Entity [msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord](bookableresourcecharacteristic.md#BKMK_msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcecharacteristic?text=bookableresourcecharacteristic EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]