---
title: "msdyn_iotpropertydefinition Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_iotpropertydefinition entity."
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
# msdyn_iotpropertydefinition Entity Reference

Defines a device property or a parameter that can be used for one or more command definitions.

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_iotpropertydefinitions|
|DisplayCollectionName|IoT Property Definitions|
|DisplayName|IoT Property Definition|
|EntitySetName|msdyn_iotpropertydefinitions|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_iotpropertydefinitions|
|LogicalName|msdyn_iotpropertydefinition|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_iotpropertydefinitionid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_iotpropertydefinition|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalProperties](#BKMK_msdyn_AdditionalProperties)
- [msdyn_Editable](#BKMK_msdyn_Editable)
- [msdyn_iotpropertydefinitionId](#BKMK_msdyn_iotpropertydefinitionId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentProperty](#BKMK_msdyn_ParentProperty)
- [msdyn_Type](#BKMK_msdyn_Type)
- [msdyn_Visible](#BKMK_msdyn_Visible)
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


### <a name="BKMK_msdyn_AdditionalProperties"></a> msdyn_AdditionalProperties

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Additional Properties|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_additionalproperties|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Editable"></a> msdyn_Editable

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Editable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_editable|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Editable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_iotpropertydefinitionId"></a> msdyn_iotpropertydefinitionId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|IoT Property Definition|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_iotpropertydefinitionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_msdyn_ParentProperty"></a> msdyn_ParentProperty

|Property|Value|
|--------|-----|
|Description|Refers to the parent property when building a nested property.|
|DisplayName|Parent Property|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_parentproperty|
|RequiredLevel|None|
|Targets|msdyn_iotpropertydefinition|
|Type|Lookup|


### <a name="BKMK_msdyn_Type"></a> msdyn_Type

|Property|Value|
|--------|-----|
|Description|The data type of the parameter.|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_type|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_Type Options

|Value|Label|
|-----|-----|
|192350000|String|
|192350001|Object|
|192350002|Date and Time|
|192350003|Boolean|
|192350004|Whole Number|
|192350005|Decimal Number|



### <a name="BKMK_msdyn_Visible"></a> msdyn_Visible

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Visible|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_visible|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Visible Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



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
|Description|Status of the IoT Property Definition|
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
|Description|Reason for the status of the IoT Property Definition|
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
- [msdyn_ParentPropertyName](#BKMK_msdyn_ParentPropertyName)
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


### <a name="BKMK_msdyn_ParentPropertyName"></a> msdyn_ParentPropertyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_parentpropertyname|
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

- [msdyn_iotpropertydefinition_SyncErrors](#BKMK_msdyn_iotpropertydefinition_SyncErrors)
- [msdyn_iotpropertydefinition_DuplicateMatchingRecord](#BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord)
- [msdyn_iotpropertydefinition_DuplicateBaseRecord](#BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord)
- [msdyn_iotpropertydefinition_AsyncOperations](#BKMK_msdyn_iotpropertydefinition_AsyncOperations)
- [msdyn_iotpropertydefinition_MailboxTrackingFolders](#BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders)
- [msdyn_iotpropertydefinition_ProcessSession](#BKMK_msdyn_iotpropertydefinition_ProcessSession)
- [msdyn_iotpropertydefinition_BulkDeleteFailures](#BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures)
- [msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter)


### <a name="BKMK_msdyn_iotpropertydefinition_SyncErrors"></a> msdyn_iotpropertydefinition_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_iotpropertydefinition_SyncErrors](syncerror.md#BKMK_msdyn_iotpropertydefinition_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord"></a> msdyn_iotpropertydefinition_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotpropertydefinition_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord"></a> msdyn_iotpropertydefinition_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotpropertydefinition_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_AsyncOperations"></a> msdyn_iotpropertydefinition_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_iotpropertydefinition_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotpropertydefinition_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders"></a> msdyn_iotpropertydefinition_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_iotpropertydefinition_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_ProcessSession"></a> msdyn_iotpropertydefinition_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_iotpropertydefinition_ProcessSession](processsession.md#BKMK_msdyn_iotpropertydefinition_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures"></a> msdyn_iotpropertydefinition_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_iotpropertydefinition_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses"></a> msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property

Same as msdyn_iotdeviceproperty entity [msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property](msdyn_iotdeviceproperty.md#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceproperty|
|ReferencingAttribute|msdyn_property|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter

Same as msdyn_iotpropertydefinition entity [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](msdyn_iotpropertydefinition.md#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotpropertydefinition|
|ReferencingAttribute|msdyn_parentproperty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_iotpropertydefinition_createdby](#BKMK_lk_msdyn_iotpropertydefinition_createdby)
- [lk_msdyn_iotpropertydefinition_createdonbehalfby](#BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby)
- [lk_msdyn_iotpropertydefinition_modifiedby](#BKMK_lk_msdyn_iotpropertydefinition_modifiedby)
- [lk_msdyn_iotpropertydefinition_modifiedonbehalfby](#BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby)
- [user_msdyn_iotpropertydefinition](#BKMK_user_msdyn_iotpropertydefinition)
- [team_msdyn_iotpropertydefinition](#BKMK_team_msdyn_iotpropertydefinition)
- [business_unit_msdyn_iotpropertydefinition](#BKMK_business_unit_msdyn_iotpropertydefinition)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter)


### <a name="BKMK_lk_msdyn_iotpropertydefinition_createdby"></a> lk_msdyn_iotpropertydefinition_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotpropertydefinition_createdby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby"></a> lk_msdyn_iotpropertydefinition_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotpropertydefinition_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotpropertydefinition_modifiedby"></a> lk_msdyn_iotpropertydefinition_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotpropertydefinition_modifiedby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby"></a> lk_msdyn_iotpropertydefinition_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotpropertydefinition_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_iotpropertydefinition"></a> user_msdyn_iotpropertydefinition

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_iotpropertydefinition](systemuser.md#BKMK_user_msdyn_iotpropertydefinition) One-To-Many relationship.

### <a name="BKMK_team_msdyn_iotpropertydefinition"></a> team_msdyn_iotpropertydefinition

**Added by**: System Solution Solution

See team Entity [team_msdyn_iotpropertydefinition](team.md#BKMK_team_msdyn_iotpropertydefinition) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_iotpropertydefinition"></a> business_unit_msdyn_iotpropertydefinition

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_iotpropertydefinition](businessunit.md#BKMK_business_unit_msdyn_iotpropertydefinition) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter

See msdyn_iotpropertydefinition Entity [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](msdyn_iotpropertydefinition.md#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_iotpropertydefinition entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_iotdevicecommandparameters"></a> msdyn_iotdevicecommandparameters

See msdyn_iotdevicecommanddefinition Entity [msdyn_iotdevicecommandparameters](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_iotdevicecommandparameters) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_iotpropertydefinition?text=msdyn_iotpropertydefinition EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]