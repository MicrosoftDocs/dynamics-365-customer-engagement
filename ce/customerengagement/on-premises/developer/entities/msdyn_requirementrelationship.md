---
title: "msdyn_requirementrelationship Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_requirementrelationship entity."
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
# msdyn_requirementrelationship Entity Reference

Relationship of requirements in the group

**Added by**: Universal Resource Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_requirementrelationships(*msdyn_requirementrelationshipid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_requirementrelationships<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_requirementrelationships(*msdyn_requirementrelationshipid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_requirementrelationships(*msdyn_requirementrelationshipid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_requirementrelationships<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_requirementrelationships(*msdyn_requirementrelationshipid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_requirementrelationships(*msdyn_requirementrelationshipid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_requirementrelationships|
|DisplayCollectionName|Requirement Relationships|
|DisplayName|Requirement Relationship|
|EntitySetName|msdyn_requirementrelationships|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_requirementrelationships|
|LogicalName|msdyn_requirementrelationship|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_requirementrelationshipid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_requirementrelationship|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_minconditioncount](#BKMK_msdyn_minconditioncount)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_operator](#BKMK_msdyn_operator)
- [msdyn_parentrequirementrelationshipid](#BKMK_msdyn_parentrequirementrelationshipid)
- [msdyn_requirementgroupcontrolviewid](#BKMK_msdyn_requirementgroupcontrolviewid)
- [msdyn_requirementgroupid](#BKMK_msdyn_requirementgroupid)
- [msdyn_requirementrelationshipId](#BKMK_msdyn_requirementrelationshipId)
- [msdyn_resourceGroupings](#BKMK_msdyn_resourceGroupings)
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


### <a name="BKMK_msdyn_minconditioncount"></a> msdyn_minconditioncount

|Property|Value|
|--------|-----|
|Description|Minimal Condition Count that needs get satisfied in Or relationship|
|DisplayName|Min Condition Count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minconditioncount|
|MaxValue|1024|
|MinValue|1|
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


### <a name="BKMK_msdyn_operator"></a> msdyn_operator

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Operator|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_operator|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_operator Options

|Value|Label|
|-----|-----|
|192350000|&&|
|192350001||||



### <a name="BKMK_msdyn_parentrequirementrelationshipid"></a> msdyn_parentrequirementrelationshipid

|Property|Value|
|--------|-----|
|Description|Parent Requirement Relationship|
|DisplayName|Parent Requirement Relationship|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_parentrequirementrelationshipid|
|RequiredLevel|None|
|Targets|msdyn_requirementrelationship|
|Type|Lookup|


### <a name="BKMK_msdyn_requirementgroupcontrolviewid"></a> msdyn_requirementgroupcontrolviewid

|Property|Value|
|--------|-----|
|Description|The requirement group control view id of the requirement relationship entity. This field will has value only when the entity is inside the requirement group control.|
|DisplayName|Requirement Group Control View Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupcontrolviewid|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_requirementgroupid"></a> msdyn_requirementgroupid

|Property|Value|
|--------|-----|
|Description|Requirement Group|
|DisplayName|Requirement Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupid|
|RequiredLevel|None|
|Targets|msdyn_requirementgroup|
|Type|Lookup|


### <a name="BKMK_msdyn_requirementrelationshipId"></a> msdyn_requirementrelationshipId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Requirement Relationship|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_requirementrelationshipid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_resourceGroupings"></a> msdyn_resourceGroupings

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Part of Same|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcegroupings|
|RequiredLevel|None|
|Type|MultiSelectPicklist|

#### msdyn_resourceGroupings Options

|Value|Label|
|-----|-----|
|192350000|Organizational Unit|
|192350001|Related Resource Pools|
|192350002|Location|



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
|Description|Status of the Requirement Relationship|
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
|Description|Reason for the status of the Requirement Relationship|
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
- [msdyn_parentrequirementrelationshipidName](#BKMK_msdyn_parentrequirementrelationshipidName)
- [msdyn_requirementgroupidName](#BKMK_msdyn_requirementgroupidName)
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


### <a name="BKMK_msdyn_parentrequirementrelationshipidName"></a> msdyn_parentrequirementrelationshipidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_parentrequirementrelationshipidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_requirementgroupidName"></a> msdyn_requirementgroupidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_requirementgroupidname|
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

- [msdyn_requirementrelationship_SyncErrors](#BKMK_msdyn_requirementrelationship_SyncErrors)
- [msdyn_requirementrelationship_DuplicateMatchingRecord](#BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord)
- [msdyn_requirementrelationship_DuplicateBaseRecord](#BKMK_msdyn_requirementrelationship_DuplicateBaseRecord)
- [msdyn_requirementrelationship_AsyncOperations](#BKMK_msdyn_requirementrelationship_AsyncOperations)
- [msdyn_requirementrelationship_MailboxTrackingFolders](#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders)
- [msdyn_requirementrelationship_ProcessSession](#BKMK_msdyn_requirementrelationship_ProcessSession)
- [msdyn_requirementrelationship_BulkDeleteFailures](#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)
- [msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)
- [msdyn_requirementrelationship_parentrequirementrelationshipid](#BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid)
- [msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid](#BKMK_msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid)


### <a name="BKMK_msdyn_requirementrelationship_SyncErrors"></a> msdyn_requirementrelationship_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_requirementrelationship_SyncErrors](syncerror.md#BKMK_msdyn_requirementrelationship_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord"></a> msdyn_requirementrelationship_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_requirementrelationship_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_DuplicateBaseRecord"></a> msdyn_requirementrelationship_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_requirementrelationship_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_requirementrelationship_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_AsyncOperations"></a> msdyn_requirementrelationship_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_requirementrelationship_AsyncOperations](asyncoperation.md#BKMK_msdyn_requirementrelationship_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_MailboxTrackingFolders"></a> msdyn_requirementrelationship_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_requirementrelationship_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_ProcessSession"></a> msdyn_requirementrelationship_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_requirementrelationship_ProcessSession](processsession.md#BKMK_msdyn_requirementrelationship_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_BulkDeleteFailures"></a> msdyn_requirementrelationship_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_requirementrelationship_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_requirementrelationship_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses"></a> msdyn_requirementrelationship_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid"></a> msdyn_requirementrelationship_parentrequirementrelationshipid

Same as msdyn_requirementrelationship entity [msdyn_requirementrelationship_parentrequirementrelationshipid](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementrelationship|
|ReferencingAttribute|msdyn_parentrequirementrelationshipid|
|IsHierarchical|True|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_parentrequirementrelationshipid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid"></a> msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid

Same as msdyn_resourcerequirement entity [msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid](msdyn_resourcerequirement.md#BKMK_msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|msdyn_requirementrelationshipid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_requirementrelationship_resourcerequirement_requirementrelationshipid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_requirementrelationship_createdby](#BKMK_lk_msdyn_requirementrelationship_createdby)
- [lk_msdyn_requirementrelationship_createdonbehalfby](#BKMK_lk_msdyn_requirementrelationship_createdonbehalfby)
- [lk_msdyn_requirementrelationship_modifiedby](#BKMK_lk_msdyn_requirementrelationship_modifiedby)
- [lk_msdyn_requirementrelationship_modifiedonbehalfby](#BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby)
- [user_msdyn_requirementrelationship](#BKMK_user_msdyn_requirementrelationship)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
- [business_unit_msdyn_requirementrelationship](#BKMK_business_unit_msdyn_requirementrelationship)
- [msdyn_requirementgroup_requirementrelationship_requirementgroupid](#BKMK_msdyn_requirementgroup_requirementrelationship_requirementgroupid)
- [msdyn_requirementrelationship_parentrequirementrelationshipid](#BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid)


### <a name="BKMK_lk_msdyn_requirementrelationship_createdby"></a> lk_msdyn_requirementrelationship_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_requirementrelationship_createdby](systemuser.md#BKMK_lk_msdyn_requirementrelationship_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_requirementrelationship_createdonbehalfby"></a> lk_msdyn_requirementrelationship_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_requirementrelationship_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_requirementrelationship_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_requirementrelationship_modifiedby"></a> lk_msdyn_requirementrelationship_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_requirementrelationship_modifiedby](systemuser.md#BKMK_lk_msdyn_requirementrelationship_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby"></a> lk_msdyn_requirementrelationship_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_requirementrelationship_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_requirementrelationship"></a> user_msdyn_requirementrelationship

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_requirementrelationship](systemuser.md#BKMK_user_msdyn_requirementrelationship) One-To-Many relationship.

### <a name="BKMK_team_msdyn_requirementrelationship"></a> team_msdyn_requirementrelationship

**Added by**: System Solution Solution

See team Entity [team_msdyn_requirementrelationship](team.md#BKMK_team_msdyn_requirementrelationship) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_requirementrelationship"></a> business_unit_msdyn_requirementrelationship

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_requirementrelationship](businessunit.md#BKMK_business_unit_msdyn_requirementrelationship) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementgroup_requirementrelationship_requirementgroupid"></a> msdyn_requirementgroup_requirementrelationship_requirementgroupid

See msdyn_requirementgroup Entity [msdyn_requirementgroup_requirementrelationship_requirementgroupid](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_requirementrelationship_requirementgroupid) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid"></a> msdyn_requirementrelationship_parentrequirementrelationshipid

See msdyn_requirementrelationship Entity [msdyn_requirementrelationship_parentrequirementrelationshipid](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_parentrequirementrelationshipid) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_requirementrelationship?text=msdyn_requirementrelationship EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]