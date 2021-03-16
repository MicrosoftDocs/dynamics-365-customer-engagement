---
title: "Characteristic Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Characteristic entity."
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
# Characteristic Entity Reference

Skills, education and certifications of resources.

**Added by**: Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/characteristics(*characteristicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/characteristics<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/characteristics(*characteristicid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/characteristics(*characteristicid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/characteristics<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/characteristics(*characteristicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/characteristics(*characteristicid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Characteristic|
|DisplayCollectionName|Characteristics|
|DisplayName|Characteristic|
|EntitySetName|characteristics|
|IsBPFEntity|False|
|LogicalCollectionName|characteristics|
|LogicalName|characteristic|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|characteristicid|
|PrimaryNameAttribute|name|
|SchemaName|Characteristic|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CharacteristicId](#BKMK_CharacteristicId)
- [CharacteristicType](#BKMK_CharacteristicType)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_requireapproval](#BKMK_msdyn_requireapproval)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_CharacteristicId"></a> CharacteristicId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the characteristic.|
|DisplayName|Characteristic|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|characteristicid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CharacteristicType"></a> CharacteristicType

|Property|Value|
|--------|-----|
|Description|Select the type of characteristic.|
|DisplayName|Characteristic Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|characteristictype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CharacteristicType Options

|Value|Label|
|-----|-----|
|1|Skill|
|2|Certification|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type a detailed description of the characteristic.|
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


### <a name="BKMK_msdyn_requireapproval"></a> msdyn_requireapproval

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Require approval|
|DisplayName|Require Approval|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requireapproval|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_requireapproval Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a name for the characteristic.|
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
|Description|Status of the Characteristic|
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
|Description|Reason for the status of the Characteristic|
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
|Description|Exchange rate for the currency associated with the Characteristic with respect to the base currency.|
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
|Description|Exchange rate for the currency associated with the characteristic with respect to the base currency.|
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

- [Characteristic_SyncErrors](#BKMK_Characteristic_SyncErrors)
- [characteristic_DuplicateMatchingRecord](#BKMK_characteristic_DuplicateMatchingRecord)
- [characteristic_DuplicateBaseRecord](#BKMK_characteristic_DuplicateBaseRecord)
- [characteristic_AsyncOperations](#BKMK_characteristic_AsyncOperations)
- [characteristic_MailboxTrackingFolders](#BKMK_characteristic_MailboxTrackingFolders)
- [characteristic_ProcessSession](#BKMK_characteristic_ProcessSession)
- [characteristic_BulkDeleteFailures](#BKMK_characteristic_BulkDeleteFailures)
- [characteristic_PrincipalObjectAttributeAccess](#BKMK_characteristic_PrincipalObjectAttributeAccess)
- [characteristic_bookableresourcecharacteristic_Characteristic](#BKMK_characteristic_bookableresourcecharacteristic_Characteristic)
- [msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic)
- [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic)
- [msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic](#BKMK_msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic)
- [msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic](#BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic)
- [msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic)


### <a name="BKMK_Characteristic_SyncErrors"></a> Characteristic_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [Characteristic_SyncErrors](syncerror.md#BKMK_Characteristic_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Characteristic_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_characteristic_DuplicateMatchingRecord"></a> characteristic_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [characteristic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_characteristic_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_DuplicateBaseRecord"></a> characteristic_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [characteristic_DuplicateBaseRecord](duplicaterecord.md#BKMK_characteristic_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_AsyncOperations"></a> characteristic_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [characteristic_AsyncOperations](asyncoperation.md#BKMK_characteristic_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_MailboxTrackingFolders"></a> characteristic_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [characteristic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_characteristic_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_ProcessSession"></a> characteristic_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [characteristic_ProcessSession](processsession.md#BKMK_characteristic_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_BulkDeleteFailures"></a> characteristic_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [characteristic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_characteristic_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_PrincipalObjectAttributeAccess"></a> characteristic_PrincipalObjectAttributeAccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [characteristic_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_characteristic_PrincipalObjectAttributeAccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_characteristic_bookableresourcecharacteristic_Characteristic"></a> characteristic_bookableresourcecharacteristic_Characteristic

Same as bookableresourcecharacteristic entity [characteristic_bookableresourcecharacteristic_Characteristic](bookableresourcecharacteristic.md#BKMK_characteristic_bookableresourcecharacteristic_Characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|characteristic_bookableresourcecharacteristic_Characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic"></a> msdyn_characteristic_msdyn_requirementcharacteristic_characteristic

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_requirementcharacteristic entity [msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](msdyn_requirementcharacteristic.md#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementcharacteristic|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristic_msdyn_requirementcharacteristic_characteristic|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Characteristics<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic"></a> msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic

**Added by**: Project Service Automation Solution

Same as msdyn_characteristicreqforteammember entity [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_characteristicreqforteammember|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic"></a> msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic

**Added by**: Project Service Automation Solution

Same as msdyn_rolecompetencyrequirement entity [msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rolecompetencyrequirement|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristic_msdyn_rolecompetencyrequirement_characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic"></a> msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic

**Added by**: Field Service Solution

Same as msdyn_incidenttypecharacteristic entity [msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypecharacteristic|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic"></a> msdyn_characteristic_msdyn_workordercharacteristic_Characteristic

**Added by**: Field Service Solution

Same as msdyn_workordercharacteristic entity [msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](msdyn_workordercharacteristic.md#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordercharacteristic|
|ReferencingAttribute|msdyn_characteristic|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristic_msdyn_workordercharacteristic_Characteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_characteristic_createdby](#BKMK_lk_characteristic_createdby)
- [lk_characteristic_createdonbehalfby](#BKMK_lk_characteristic_createdonbehalfby)
- [lk_characteristic_modifiedby](#BKMK_lk_characteristic_modifiedby)
- [lk_characteristic_modifiedonbehalfby](#BKMK_lk_characteristic_modifiedonbehalfby)
- [user_characteristic](#BKMK_user_characteristic)
- [team_characteristic](#BKMK_team_characteristic)
- [business_unit_characteristic](#BKMK_business_unit_characteristic)
- [TransactionCurrency_characteristic](#BKMK_TransactionCurrency_characteristic)


### <a name="BKMK_lk_characteristic_createdby"></a> lk_characteristic_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_characteristic_createdby](systemuser.md#BKMK_lk_characteristic_createdby) One-To-Many relationship.

### <a name="BKMK_lk_characteristic_createdonbehalfby"></a> lk_characteristic_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_characteristic_createdonbehalfby](systemuser.md#BKMK_lk_characteristic_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_characteristic_modifiedby"></a> lk_characteristic_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_characteristic_modifiedby](systemuser.md#BKMK_lk_characteristic_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_characteristic_modifiedonbehalfby"></a> lk_characteristic_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_characteristic_modifiedonbehalfby](systemuser.md#BKMK_lk_characteristic_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_characteristic"></a> user_characteristic

**Added by**: System Solution Solution

See systemuser Entity [user_characteristic](systemuser.md#BKMK_user_characteristic) One-To-Many relationship.

### <a name="BKMK_team_characteristic"></a> team_characteristic

**Added by**: System Solution Solution

See team Entity [team_characteristic](team.md#BKMK_team_characteristic) One-To-Many relationship.

### <a name="BKMK_business_unit_characteristic"></a> business_unit_characteristic

**Added by**: System Solution Solution

See businessunit Entity [business_unit_characteristic](businessunit.md#BKMK_business_unit_characteristic) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_characteristic"></a> TransactionCurrency_characteristic

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_characteristic](transactioncurrency.md#BKMK_TransactionCurrency_characteristic) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.characteristic?text=characteristic EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]