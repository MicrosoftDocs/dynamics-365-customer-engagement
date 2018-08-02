---
title: "msdyn_characteristicreqforteammember Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_characteristicreqforteammember entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_characteristicreqforteammember Entity Reference

Characteristic requirement for team member

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_characteristicreqforteammembers|
|DisplayCollectionName|Competency Requirements|
|DisplayName|Competency Requirement (Deprecated)|
|EntitySetName|msdyn_characteristicreqforteammembers|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_characteristicreqforteammembers|
|LogicalName|msdyn_characteristicreqforteammember|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_characteristicreqforteammemberid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_characteristicreqforteammember|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Characteristic](#BKMK_msdyn_Characteristic)
- [msdyn_characteristicreqforteammemberId](#BKMK_msdyn_characteristicreqforteammemberId)
- [msdyn_characteristictype](#BKMK_msdyn_characteristictype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ratingvalue](#BKMK_msdyn_ratingvalue)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
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


### <a name="BKMK_msdyn_Characteristic"></a> msdyn_Characteristic

|Property|Value|
|--------|-----|
|Description|Select the characteristic required.|
|DisplayName|Characteristic|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_characteristic|
|RequiredLevel|ApplicationRequired|
|Targets|characteristic|
|Type|Lookup|


### <a name="BKMK_msdyn_characteristicreqforteammemberId"></a> msdyn_characteristicreqforteammemberId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Characteristic requirement for team member|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_characteristicreqforteammemberid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_characteristictype"></a> msdyn_characteristictype

|Property|Value|
|--------|-----|
|Description|Shows the skill type of this team member.|
|DisplayName|Bookable Characteristic Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_characteristictype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_characteristictype Options

|Value|Label|
|-----|-----|
|1|Skill|
|2|Certification|



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ratingvalue"></a> msdyn_ratingvalue

|Property|Value|
|--------|-----|
|Description|Shows the proficiency in this skill for this team member.|
|DisplayName|Rating Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ratingvalue|
|RequiredLevel|ApplicationRequired|
|Targets|ratingvalue|
|Type|Lookup|


### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource Requirement associated with Competency Requirement.|
|DisplayName|Resource Requirement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirementid|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_resourcerequirement|
|Type|Lookup|


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
|Description|Status of the Characteristic requirement for team member|
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
|Description|Reason for the status of the Characteristic requirement for team member|
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
- [msdyn_CharacteristicName](#BKMK_msdyn_CharacteristicName)
- [msdyn_ratingvalueName](#BKMK_msdyn_ratingvalueName)
- [msdyn_resourcerequirementidName](#BKMK_msdyn_resourcerequirementidName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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


### <a name="BKMK_msdyn_CharacteristicName"></a> msdyn_CharacteristicName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_characteristicname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ratingvalueName"></a> msdyn_ratingvalueName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ratingvaluename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_resourcerequirementidName"></a> msdyn_resourcerequirementidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirementidname|
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

- [msdyn_characteristicreqforteammember_SyncErrors](#BKMK_msdyn_characteristicreqforteammember_SyncErrors)
- [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord)
- [msdyn_characteristicreqforteammember_DuplicateBaseRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord)
- [msdyn_characteristicreqforteammember_AsyncOperations](#BKMK_msdyn_characteristicreqforteammember_AsyncOperations)
- [msdyn_characteristicreqforteammember_MailboxTrackingFolders](#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders)
- [msdyn_characteristicreqforteammember_UserEntityInstanceDatas](#BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas)
- [msdyn_characteristicreqforteammember_ProcessSession](#BKMK_msdyn_characteristicreqforteammember_ProcessSession)
- [msdyn_characteristicreqforteammember_BulkDeleteFailures](#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures)
- [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses)
- [msdyn_characteristicreqforteammember_Annotations](#BKMK_msdyn_characteristicreqforteammember_Annotations)


### <a name="BKMK_msdyn_characteristicreqforteammember_SyncErrors"></a> msdyn_characteristicreqforteammember_SyncErrors

Same as syncerror entity [msdyn_characteristicreqforteammember_SyncErrors](syncerror.md#BKMK_msdyn_characteristicreqforteammember_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord"></a> msdyn_characteristicreqforteammember_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord"></a> msdyn_characteristicreqforteammember_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_characteristicreqforteammember_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_AsyncOperations"></a> msdyn_characteristicreqforteammember_AsyncOperations

Same as asyncoperation entity [msdyn_characteristicreqforteammember_AsyncOperations](asyncoperation.md#BKMK_msdyn_characteristicreqforteammember_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders"></a> msdyn_characteristicreqforteammember_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_characteristicreqforteammember_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas"></a> msdyn_characteristicreqforteammember_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_characteristicreqforteammember_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_ProcessSession"></a> msdyn_characteristicreqforteammember_ProcessSession

Same as processsession entity [msdyn_characteristicreqforteammember_ProcessSession](processsession.md#BKMK_msdyn_characteristicreqforteammember_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures"></a> msdyn_characteristicreqforteammember_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_characteristicreqforteammember_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses"></a> msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_characteristicreqforteammember_Annotations"></a> msdyn_characteristicreqforteammember_Annotations

Same as annotation entity [msdyn_characteristicreqforteammember_Annotations](annotation.md#BKMK_msdyn_characteristicreqforteammember_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_characteristicreqforteammember_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_characteristicreqforteammember_createdby](#BKMK_lk_msdyn_characteristicreqforteammember_createdby)
- [lk_msdyn_characteristicreqforteammember_createdonbehalfby](#BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby)
- [lk_msdyn_characteristicreqforteammember_modifiedby](#BKMK_lk_msdyn_characteristicreqforteammember_modifiedby)
- [lk_msdyn_characteristicreqforteammember_modifiedonbehalfby](#BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby)
- [user_msdyn_characteristicreqforteammember](#BKMK_user_msdyn_characteristicreqforteammember)
- [team_msdyn_characteristicreqforteammember](#BKMK_team_msdyn_characteristicreqforteammember)
- [business_unit_msdyn_characteristicreqforteammember](#BKMK_business_unit_msdyn_characteristicreqforteammember)
- [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic)
- [msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue](#BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue)
- [msdyn_resourcerequirement_characteristicreq](#BKMK_msdyn_resourcerequirement_characteristicreq)


### <a name="BKMK_lk_msdyn_characteristicreqforteammember_createdby"></a> lk_msdyn_characteristicreqforteammember_createdby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_createdby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby"></a> lk_msdyn_characteristicreqforteammember_createdonbehalfby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_modifiedby"></a> lk_msdyn_characteristicreqforteammember_modifiedby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_modifiedby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby"></a> lk_msdyn_characteristicreqforteammember_modifiedonbehalfby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_characteristicreqforteammember"></a> user_msdyn_characteristicreqforteammember

See systemuser Entity [user_msdyn_characteristicreqforteammember](systemuser.md#BKMK_user_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_team_msdyn_characteristicreqforteammember"></a> team_msdyn_characteristicreqforteammember

See team Entity [team_msdyn_characteristicreqforteammember](team.md#BKMK_team_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_characteristicreqforteammember"></a> business_unit_msdyn_characteristicreqforteammember

See businessunit Entity [business_unit_msdyn_characteristicreqforteammember](businessunit.md#BKMK_business_unit_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic"></a> msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic

See characteristic Entity [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](characteristic.md#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic) One-To-Many relationship.

### <a name="BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue"></a> msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue

See ratingvalue Entity [msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue](ratingvalue.md#BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_characteristicreq"></a> msdyn_resourcerequirement_characteristicreq

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_characteristicreq](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_characteristicreq) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_characteristicreqforteammember?text=msdyn_characteristicreqforteammember EntityType" />