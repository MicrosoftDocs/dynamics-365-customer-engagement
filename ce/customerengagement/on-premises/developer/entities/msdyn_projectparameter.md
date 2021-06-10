---
title: "msdyn_projectparameter Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_projectparameter entity."
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
# msdyn_projectparameter Entity Reference

List of settings that determine the behavior of the project-based service solution.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_projectparameters<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_projectparameters(*msdyn_projectparameterid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_projectparameters(*msdyn_projectparameterid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_projectparameters<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_projectparameters(*msdyn_projectparameterid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_projectparameters(*msdyn_projectparameterid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_projectparameters|
|DisplayCollectionName|Project Parameters|
|DisplayName|Project Parameter|
|EntitySetName|msdyn_projectparameters|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_projectparameters|
|LogicalName|msdyn_projectparameter|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_projectparameterid|
|PrimaryNameAttribute|msdyn_description|
|SchemaName|msdyn_projectparameter|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Allowskillupdatebyresource](#BKMK_msdyn_Allowskillupdatebyresource)
- [msdyn_defaultorganizationalunit](#BKMK_msdyn_defaultorganizationalunit)
- [msdyn_defaultWorkTemplate](#BKMK_msdyn_defaultWorkTemplate)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_invoicefrequency](#BKMK_msdyn_invoicefrequency)
- [msdyn_projectmanagerrole](#BKMK_msdyn_projectmanagerrole)
- [msdyn_projectparameterId](#BKMK_msdyn_projectparameterId)
- [msdyn_Projectresourcerequirementsvisibletore](#BKMK_msdyn_Projectresourcerequirementsvisibletore)
- [msdyn_resourceallocationmode](#BKMK_msdyn_resourceallocationmode)
- [msdyn_teammemberrole](#BKMK_msdyn_teammemberrole)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_Allowskillupdatebyresource"></a> msdyn_Allowskillupdatebyresource

|Property|Value|
|--------|-----|
|Description|Allow resources to update their skills via the Project Finder Mobile app.|
|DisplayName|Allow skill update by resource (Deprecated in v3.0)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_allowskillupdatebyresource|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Allowskillupdatebyresource Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_defaultorganizationalunit"></a> msdyn_defaultorganizationalunit

|Property|Value|
|--------|-----|
|Description|Select the default organizational unit that will be used for new resources.|
|DisplayName|Default Organizational Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultorganizationalunit|
|RequiredLevel|None|
|Targets|msdyn_organizationalunit|
|Type|Lookup|


### <a name="BKMK_msdyn_defaultWorkTemplate"></a> msdyn_defaultWorkTemplate

|Property|Value|
|--------|-----|
|Description|Select the default work template for new projects.|
|DisplayName|defaultWorkTemplate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultworktemplate|
|RequiredLevel|None|
|Targets|msdyn_workhourtemplate|
|Type|Lookup|


### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type the name of the project parameters.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_invoicefrequency"></a> msdyn_invoicefrequency

|Property|Value|
|--------|-----|
|Description|Select the default frequency for generating invoices.|
|DisplayName|Invoice Frequency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicefrequency|
|RequiredLevel|None|
|Targets|msdyn_invoicefrequency|
|Type|Lookup|


### <a name="BKMK_msdyn_projectmanagerrole"></a> msdyn_projectmanagerrole

|Property|Value|
|--------|-----|
|Description|Shows the default role to be used when a project manager is added to the project team.|
|DisplayName|Project Manager Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projectmanagerrole|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_projectparameterId"></a> msdyn_projectparameterId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Project Parameter|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_projectparameterid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_Projectresourcerequirementsvisibletore"></a> msdyn_Projectresourcerequirementsvisibletore

|Property|Value|
|--------|-----|
|Description|Select whether project resource requirements are visible to resources.|
|DisplayName|Resource requirements visible to resources (Deprecated in v3.0)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_projectresourcerequirementsvisibletore|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Projectresourcerequirementsvisibletore Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_resourceallocationmode"></a> msdyn_resourceallocationmode

|Property|Value|
|--------|-----|
|Description|Select the default method for allocating resources to projects.|
|DisplayName|Resource allocation mode|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourceallocationmode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_resourceallocationmode Options

|Value|Label|
|-----|-----|
|1|Centralized|
|2|Hybrid|



### <a name="BKMK_msdyn_teammemberrole"></a> msdyn_teammemberrole

|Property|Value|
|--------|-----|
|Description|Shows the default role to be used when a team member is added to the project team.|
|DisplayName|Team Member Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_teammemberrole|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Project Parameter|
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
|Description|Reason for the status of the Project Parameter|
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
- [msdyn_defaultorganizationalunitName](#BKMK_msdyn_defaultorganizationalunitName)
- [msdyn_defaultWorkTemplateName](#BKMK_msdyn_defaultWorkTemplateName)
- [msdyn_invoicefrequencyName](#BKMK_msdyn_invoicefrequencyName)
- [msdyn_projectmanagerroleName](#BKMK_msdyn_projectmanagerroleName)
- [msdyn_teammemberroleName](#BKMK_msdyn_teammemberroleName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
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


### <a name="BKMK_msdyn_defaultorganizationalunitName"></a> msdyn_defaultorganizationalunitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultorganizationalunitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_defaultWorkTemplateName"></a> msdyn_defaultWorkTemplateName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultworktemplatename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_invoicefrequencyName"></a> msdyn_invoicefrequencyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicefrequencyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_projectmanagerroleName"></a> msdyn_projectmanagerroleName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectmanagerrolename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_teammemberroleName"></a> msdyn_teammemberroleName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_teammemberrolename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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

- [msdyn_projectparameter_SyncErrors](#BKMK_msdyn_projectparameter_SyncErrors)
- [msdyn_projectparameter_DuplicateMatchingRecord](#BKMK_msdyn_projectparameter_DuplicateMatchingRecord)
- [msdyn_projectparameter_DuplicateBaseRecord](#BKMK_msdyn_projectparameter_DuplicateBaseRecord)
- [msdyn_projectparameter_AsyncOperations](#BKMK_msdyn_projectparameter_AsyncOperations)
- [msdyn_projectparameter_MailboxTrackingFolders](#BKMK_msdyn_projectparameter_MailboxTrackingFolders)
- [msdyn_projectparameter_ProcessSession](#BKMK_msdyn_projectparameter_ProcessSession)
- [msdyn_projectparameter_BulkDeleteFailures](#BKMK_msdyn_projectparameter_BulkDeleteFailures)
- [msdyn_projectparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses)
- [msdyn_projectparameter_Annotations](#BKMK_msdyn_projectparameter_Annotations)
- [msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter](#BKMK_msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter)


### <a name="BKMK_msdyn_projectparameter_SyncErrors"></a> msdyn_projectparameter_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_projectparameter_SyncErrors](syncerror.md#BKMK_msdyn_projectparameter_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_DuplicateMatchingRecord"></a> msdyn_projectparameter_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_projectparameter_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_projectparameter_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_DuplicateBaseRecord"></a> msdyn_projectparameter_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_projectparameter_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_projectparameter_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_AsyncOperations"></a> msdyn_projectparameter_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_projectparameter_AsyncOperations](asyncoperation.md#BKMK_msdyn_projectparameter_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_MailboxTrackingFolders"></a> msdyn_projectparameter_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_projectparameter_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_projectparameter_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_ProcessSession"></a> msdyn_projectparameter_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_projectparameter_ProcessSession](processsession.md#BKMK_msdyn_projectparameter_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_BulkDeleteFailures"></a> msdyn_projectparameter_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_projectparameter_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_projectparameter_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses"></a> msdyn_projectparameter_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_projectparameter_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_Annotations"></a> msdyn_projectparameter_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_projectparameter_Annotations](annotation.md#BKMK_msdyn_projectparameter_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter"></a> msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter

Same as msdyn_projectparameterpricelist entity [msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter](msdyn_projectparameterpricelist.md#BKMK_msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameterpricelist|
|ReferencingAttribute|msdyn_projectparameter|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_projectparameter_createdby](#BKMK_lk_msdyn_projectparameter_createdby)
- [lk_msdyn_projectparameter_createdonbehalfby](#BKMK_lk_msdyn_projectparameter_createdonbehalfby)
- [lk_msdyn_projectparameter_modifiedby](#BKMK_lk_msdyn_projectparameter_modifiedby)
- [lk_msdyn_projectparameter_modifiedonbehalfby](#BKMK_lk_msdyn_projectparameter_modifiedonbehalfby)
- [organization_msdyn_projectparameter](#BKMK_organization_msdyn_projectparameter)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole)
- [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole)
- [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency)
- [msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate](#BKMK_msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate)
- [msdyn_projectparameter_defaultorganizationalunit](#BKMK_msdyn_projectparameter_defaultorganizationalunit)


### <a name="BKMK_lk_msdyn_projectparameter_createdby"></a> lk_msdyn_projectparameter_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_projectparameter_createdby](systemuser.md#BKMK_lk_msdyn_projectparameter_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_projectparameter_createdonbehalfby"></a> lk_msdyn_projectparameter_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_projectparameter_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_projectparameter_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_projectparameter_modifiedby"></a> lk_msdyn_projectparameter_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_projectparameter_modifiedby](systemuser.md#BKMK_lk_msdyn_projectparameter_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_projectparameter_modifiedonbehalfby"></a> lk_msdyn_projectparameter_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_projectparameter_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_projectparameter_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_projectparameter"></a> organization_msdyn_projectparameter

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_projectparameter](organization.md#BKMK_organization_msdyn_projectparameter) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole"></a> msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency

See msdyn_invoicefrequency Entity [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](msdyn_invoicefrequency.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate"></a> msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate

**Added by**: Universal Resource Scheduling Solution

See msdyn_workhourtemplate Entity [msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate](msdyn_workhourtemplate.md#BKMK_msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_defaultorganizationalunit"></a> msdyn_projectparameter_defaultorganizationalunit

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_projectparameter_defaultorganizationalunit](msdyn_organizationalunit.md#BKMK_msdyn_projectparameter_defaultorganizationalunit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_projectparameter?text=msdyn_projectparameter EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]