---
title: "msdyn_fieldcomputation Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldcomputation entity."
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
# msdyn_fieldcomputation Entity Reference

Product properties whose values are to be considered as factors for quantity computation on a transaction line.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldcomputations(*msdyn_fieldcomputationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldcomputations<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldcomputations(*msdyn_fieldcomputationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldcomputations(*msdyn_fieldcomputationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldcomputations<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldcomputations(*msdyn_fieldcomputationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldcomputations(*msdyn_fieldcomputationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_fieldcomputations|
|DisplayCollectionName|Field Computations|
|DisplayName|Field Computation|
|EntitySetName|msdyn_fieldcomputations|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_fieldcomputations|
|LogicalName|msdyn_fieldcomputation|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_fieldcomputationid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_fieldcomputation|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ComputedField](#BKMK_msdyn_ComputedField)
- [msdyn_fieldcomputationId](#BKMK_msdyn_fieldcomputationId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ProductId](#BKMK_msdyn_ProductId)
- [msdyn_PropertyId](#BKMK_msdyn_PropertyId)
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


### <a name="BKMK_msdyn_ComputedField"></a> msdyn_ComputedField

|Property|Value|
|--------|-----|
|Description|Stores an enum value that indicates the supported sales document line field will be the target computed field.|
|DisplayName|Computed Transaction Field|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_computedfield|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_ComputedField Options

|Value|Label|
|-----|-----|
|192350001|Quantity|



### <a name="BKMK_msdyn_fieldcomputationId"></a> msdyn_fieldcomputationId

|Property|Value|
|--------|-----|
|Description|Field computation record unique identifier.|
|DisplayName|Field Computation|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_fieldcomputationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Stores the name of the computed transaction field and product property computation mapping.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ProductId"></a> msdyn_ProductId

|Property|Value|
|--------|-----|
|Description|Transaction product identifier.|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_productid|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_PropertyId"></a> msdyn_PropertyId

|Property|Value|
|--------|-----|
|Description|Product dynamic property identifier.|
|DisplayName|Factor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_propertyid|
|RequiredLevel|ApplicationRequired|
|Targets|dynamicproperty|
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
|Description|Status of the Field Computation|
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
|Description|Reason for the status of the Field Computation|
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
- [msdyn_ProductIdName](#BKMK_msdyn_ProductIdName)
- [msdyn_PropertyIdName](#BKMK_msdyn_PropertyIdName)
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


### <a name="BKMK_msdyn_ProductIdName"></a> msdyn_ProductIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_productidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PropertyIdName"></a> msdyn_PropertyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_propertyidname|
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

- [msdyn_fieldcomputation_SyncErrors](#BKMK_msdyn_fieldcomputation_SyncErrors)
- [msdyn_fieldcomputation_DuplicateMatchingRecord](#BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord)
- [msdyn_fieldcomputation_DuplicateBaseRecord](#BKMK_msdyn_fieldcomputation_DuplicateBaseRecord)
- [msdyn_fieldcomputation_AsyncOperations](#BKMK_msdyn_fieldcomputation_AsyncOperations)
- [msdyn_fieldcomputation_MailboxTrackingFolders](#BKMK_msdyn_fieldcomputation_MailboxTrackingFolders)
- [msdyn_fieldcomputation_ProcessSession](#BKMK_msdyn_fieldcomputation_ProcessSession)
- [msdyn_fieldcomputation_BulkDeleteFailures](#BKMK_msdyn_fieldcomputation_BulkDeleteFailures)
- [msdyn_fieldcomputation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_fieldcomputation_SyncErrors"></a> msdyn_fieldcomputation_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_fieldcomputation_SyncErrors](syncerror.md#BKMK_msdyn_fieldcomputation_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord"></a> msdyn_fieldcomputation_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_fieldcomputation_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_DuplicateBaseRecord"></a> msdyn_fieldcomputation_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_fieldcomputation_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fieldcomputation_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_AsyncOperations"></a> msdyn_fieldcomputation_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_fieldcomputation_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldcomputation_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_MailboxTrackingFolders"></a> msdyn_fieldcomputation_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_fieldcomputation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldcomputation_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_ProcessSession"></a> msdyn_fieldcomputation_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_fieldcomputation_ProcessSession](processsession.md#BKMK_msdyn_fieldcomputation_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_BulkDeleteFailures"></a> msdyn_fieldcomputation_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_fieldcomputation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldcomputation_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses"></a> msdyn_fieldcomputation_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_fieldcomputation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldcomputation_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_fieldcomputation_createdby](#BKMK_lk_msdyn_fieldcomputation_createdby)
- [lk_msdyn_fieldcomputation_createdonbehalfby](#BKMK_lk_msdyn_fieldcomputation_createdonbehalfby)
- [lk_msdyn_fieldcomputation_modifiedby](#BKMK_lk_msdyn_fieldcomputation_modifiedby)
- [lk_msdyn_fieldcomputation_modifiedonbehalfby](#BKMK_lk_msdyn_fieldcomputation_modifiedonbehalfby)
- [user_msdyn_fieldcomputation](#BKMK_user_msdyn_fieldcomputation)
- [team_msdyn_fieldcomputation](#BKMK_team_msdyn_fieldcomputation)
- [business_unit_msdyn_fieldcomputation](#BKMK_business_unit_msdyn_fieldcomputation)
- [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId)
- [msdyn_product_msdyn_fieldcomputation_ProductId](#BKMK_msdyn_product_msdyn_fieldcomputation_ProductId)


### <a name="BKMK_lk_msdyn_fieldcomputation_createdby"></a> lk_msdyn_fieldcomputation_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldcomputation_createdby](systemuser.md#BKMK_lk_msdyn_fieldcomputation_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldcomputation_createdonbehalfby"></a> lk_msdyn_fieldcomputation_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldcomputation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldcomputation_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldcomputation_modifiedby"></a> lk_msdyn_fieldcomputation_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldcomputation_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldcomputation_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldcomputation_modifiedonbehalfby"></a> lk_msdyn_fieldcomputation_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldcomputation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldcomputation_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_fieldcomputation"></a> user_msdyn_fieldcomputation

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_fieldcomputation](systemuser.md#BKMK_user_msdyn_fieldcomputation) One-To-Many relationship.

### <a name="BKMK_team_msdyn_fieldcomputation"></a> team_msdyn_fieldcomputation

**Added by**: System Solution Solution

See team Entity [team_msdyn_fieldcomputation](team.md#BKMK_team_msdyn_fieldcomputation) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_fieldcomputation"></a> business_unit_msdyn_fieldcomputation

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_fieldcomputation](businessunit.md#BKMK_business_unit_msdyn_fieldcomputation) One-To-Many relationship.

### <a name="BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId"></a> msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId

**Added by**: Product Management Solution

See dynamicproperty Entity [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](dynamicproperty.md#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_fieldcomputation_ProductId"></a> msdyn_product_msdyn_fieldcomputation_ProductId

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_fieldcomputation_ProductId](product.md#BKMK_msdyn_product_msdyn_fieldcomputation_ProductId) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldcomputation?text=msdyn_fieldcomputation EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]