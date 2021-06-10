---
title: "msdyn_organizationalunit Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_organizationalunit entity."
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
# msdyn_organizationalunit Entity Reference

Division of the company or organization that has a specific cost price list associated to it.

**Added by**: Universal Resource Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_organizationalunits<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_organizationalunits(*msdyn_organizationalunitid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_organizationalunits(*msdyn_organizationalunitid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_organizationalunits<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_organizationalunits(*msdyn_organizationalunitid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_organizationalunits(*msdyn_organizationalunitid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_organizationalunits|
|DisplayCollectionName|Organizational Units|
|DisplayName|Organizational Unit|
|EntitySetName|msdyn_organizationalunits|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_organizationalunits|
|LogicalName|msdyn_organizationalunit|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_organizationalunitid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_organizationalunit|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_currency](#BKMK_msdyn_currency)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_organizationalunitId](#BKMK_msdyn_organizationalunitId)
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


### <a name="BKMK_msdyn_currency"></a> msdyn_currency

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Select the currency that the organization uses to track its costs.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_currency|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Enter a description of the organizational unit.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|--------|-----|
|Description|The latitude to use for the location of organizational unit.|
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|--------|-----|
|Description|The longitude to use for the location of organizational unit.|
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


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


### <a name="BKMK_msdyn_organizationalunitId"></a> msdyn_organizationalunitId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Organizational Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_organizationalunitid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Status of the Organizational Unit|
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
|Description|Reason for the status of the Organizational Unit|
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
- [msdyn_currencyName](#BKMK_msdyn_currencyName)
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


### <a name="BKMK_msdyn_currencyName"></a> msdyn_currencyName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_currencyname|
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

- [msdyn_organizationalunit_SyncErrors](#BKMK_msdyn_organizationalunit_SyncErrors)
- [msdyn_organizationalunit_DuplicateMatchingRecord](#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord)
- [msdyn_organizationalunit_DuplicateBaseRecord](#BKMK_msdyn_organizationalunit_DuplicateBaseRecord)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_organizationalunit_MailboxTrackingFolders](#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)
- [msdyn_organizationalunit_ProcessSession](#BKMK_msdyn_organizationalunit_ProcessSession)
- [msdyn_organizationalunit_BulkDeleteFailures](#BKMK_msdyn_organizationalunit_BulkDeleteFailures)
- [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)
- [msdyn_organizationalunit_Annotations](#BKMK_msdyn_organizationalunit_Annotations)
- [msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit)
- [msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit](#BKMK_msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit)
- [msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId](#BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId)
- [msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId](#BKMK_msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId)
- [msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId](#BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId)
- [msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit)
- [msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit)
- [msdyn_organizationalunit_actual](#BKMK_msdyn_organizationalunit_actual)
- [msdyn_organizationalunit_estimateline](#BKMK_msdyn_organizationalunit_estimateline)
- [msdyn_organizationalunit_expense](#BKMK_msdyn_organizationalunit_expense)
- [msdyn_organizationalunit_invoicelinetransaction](#BKMK_msdyn_organizationalunit_invoicelinetransaction)
- [msdyn_organizationalunit_journalline](#BKMK_msdyn_organizationalunit_journalline)
- [msdyn_organizationalunit_opportunity](#BKMK_msdyn_organizationalunit_opportunity)
- [msdyn_organizationalunit_opportunitylinedetail](#BKMK_msdyn_organizationalunit_opportunitylinedetail)
- [msdyn_organizationalunit_orderlinetransaction](#BKMK_msdyn_organizationalunit_orderlinetransaction)
- [msdyn_organizationalunit_project](#BKMK_msdyn_organizationalunit_project)
- [msdyn_organizationalunit_projecttask](#BKMK_msdyn_organizationalunit_projecttask)
- [msdyn_organizationalunit_quote](#BKMK_msdyn_organizationalunit_quote)
- [msdyn_organizationalunit_quotelinetransaction](#BKMK_msdyn_organizationalunit_quotelinetransaction)
- [msdyn_organizationalunit_salesorder](#BKMK_msdyn_organizationalunit_salesorder)
- [msdyn_organizationalunit_timeentry](#BKMK_msdyn_organizationalunit_timeentry)
- [msdyn_projectparameter_defaultorganizationalunit](#BKMK_msdyn_projectparameter_defaultorganizationalunit)
- [msdyn_resourcecategorypricelevel_organizationalunit](#BKMK_msdyn_resourcecategorypricelevel_organizationalunit)


### <a name="BKMK_msdyn_organizationalunit_SyncErrors"></a> msdyn_organizationalunit_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_organizationalunit_SyncErrors](syncerror.md#BKMK_msdyn_organizationalunit_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_DuplicateMatchingRecord"></a> msdyn_organizationalunit_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_organizationalunit_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_DuplicateBaseRecord"></a> msdyn_organizationalunit_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_organizationalunit_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_organizationalunit_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_organizationalunit_AsyncOperations](asyncoperation.md#BKMK_msdyn_organizationalunit_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_MailboxTrackingFolders"></a> msdyn_organizationalunit_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_organizationalunit_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_organizationalunit_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_ProcessSession"></a> msdyn_organizationalunit_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_organizationalunit_ProcessSession](processsession.md#BKMK_msdyn_organizationalunit_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_BulkDeleteFailures"></a> msdyn_organizationalunit_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_organizationalunit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_organizationalunit_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses"></a> msdyn_organizationalunit_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_Annotations"></a> msdyn_organizationalunit_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_organizationalunit_Annotations](annotation.md#BKMK_msdyn_organizationalunit_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit"></a> msdyn_msdyn_organizationalunit_bookableresource_organizationalunit

Same as bookableresource entity [msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](bookableresource.md#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresource|
|ReferencingAttribute|msdyn_organizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_bookableresource_organizationalunit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit"></a> msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit

Same as msdyn_requirementorganizationunit entity [msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit](msdyn_requirementorganizationunit.md#BKMK_msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementorganizationunit|
|ReferencingAttribute|msdyn_organizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Organizational Units<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId"></a> msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId

**Added by**: Project Service Automation Solution

Same as msdyn_actual entity [msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId](msdyn_actual.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Contracting Unit Actuals<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId"></a> msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId](msdyn_invoicelinetransaction.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Contracting Unit Invoice Line Details<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId"></a> msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId](msdyn_journalline.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Contracting Unit Journal Lines<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit"></a> msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit

**Added by**: Project Service Automation Solution

Same as msdyn_projectteam entity [msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit](msdyn_projectteam.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectteam|
|ReferencingAttribute|msdyn_organizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_msdyn_projectteam_organizationalunit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit"></a> msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorymarkuppricelevel entity [msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorymarkuppricelevel|
|ReferencingAttribute|msdyn_organizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_organizationalunit_msdyn_resourcecategorymarkuppricelevel_organizationalunit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_actual"></a> msdyn_organizationalunit_actual

**Added by**: Project Service Automation Solution

Same as msdyn_actual entity [msdyn_organizationalunit_actual](msdyn_actual.md#BKMK_msdyn_organizationalunit_actual) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_actual|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Resourcing Unit Actuals<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_estimateline"></a> msdyn_organizationalunit_estimateline

**Added by**: Project Service Automation Solution

Same as msdyn_estimateline entity [msdyn_organizationalunit_estimateline](msdyn_estimateline.md#BKMK_msdyn_organizationalunit_estimateline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_estimateline|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_expense"></a> msdyn_organizationalunit_expense

**Added by**: Project Service Automation Solution

Same as msdyn_expense entity [msdyn_organizationalunit_expense](msdyn_expense.md#BKMK_msdyn_organizationalunit_expense) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_expense|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_invoicelinetransaction"></a> msdyn_organizationalunit_invoicelinetransaction

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_organizationalunit_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_msdyn_organizationalunit_invoicelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_invoicelinetransaction|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Resourcing Unit Invoice Line Details<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_journalline"></a> msdyn_organizationalunit_journalline

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_organizationalunit_journalline](msdyn_journalline.md#BKMK_msdyn_organizationalunit_journalline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_journalline|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Resourcing Unit Journal Lines<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_opportunity"></a> msdyn_organizationalunit_opportunity

**Added by**: Project Service Automation Solution

Same as opportunity entity [msdyn_organizationalunit_opportunity](opportunity.md#BKMK_msdyn_organizationalunit_opportunity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_opportunity|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_opportunitylinedetail"></a> msdyn_organizationalunit_opportunitylinedetail

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylinetransaction entity [msdyn_organizationalunit_opportunitylinedetail](msdyn_opportunitylinetransaction.md#BKMK_msdyn_organizationalunit_opportunitylinedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_opportunitylinedetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_orderlinetransaction"></a> msdyn_organizationalunit_orderlinetransaction

**Added by**: Project Service Automation Solution

Same as msdyn_orderlinetransaction entity [msdyn_organizationalunit_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_msdyn_organizationalunit_orderlinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_orderlinetransaction|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_project"></a> msdyn_organizationalunit_project

**Added by**: Project Service Automation Solution

Same as msdyn_project entity [msdyn_organizationalunit_project](msdyn_project.md#BKMK_msdyn_organizationalunit_project) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_project|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_projecttask"></a> msdyn_organizationalunit_projecttask

**Added by**: Project Service Automation Solution

Same as msdyn_projecttask entity [msdyn_organizationalunit_projecttask](msdyn_projecttask.md#BKMK_msdyn_organizationalunit_projecttask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_projecttask|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_quote"></a> msdyn_organizationalunit_quote

**Added by**: Project Service Automation Solution

Same as quote entity [msdyn_organizationalunit_quote](quote.md#BKMK_msdyn_organizationalunit_quote) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_quote|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_quotelinetransaction"></a> msdyn_organizationalunit_quotelinetransaction

**Added by**: Project Service Automation Solution

Same as msdyn_quotelinetransaction entity [msdyn_organizationalunit_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_msdyn_organizationalunit_quotelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_quotelinetransaction|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_salesorder"></a> msdyn_organizationalunit_salesorder

**Added by**: Project Service Automation Solution

Same as salesorder entity [msdyn_organizationalunit_salesorder](salesorder.md#BKMK_msdyn_organizationalunit_salesorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|msdyn_contractorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_salesorder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_organizationalunit_timeentry"></a> msdyn_organizationalunit_timeentry

**Added by**: Project Service Automation Solution

Same as msdyn_timeentry entity [msdyn_organizationalunit_timeentry](msdyn_timeentry.md#BKMK_msdyn_organizationalunit_timeentry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|msdyn_resourceorganizationalunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_organizationalunit_timeentry|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_projectparameter_defaultorganizationalunit"></a> msdyn_projectparameter_defaultorganizationalunit

**Added by**: Project Service Automation Solution

Same as msdyn_projectparameter entity [msdyn_projectparameter_defaultorganizationalunit](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_defaultorganizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameter|
|ReferencingAttribute|msdyn_defaultorganizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_projectparameter_defaultorganizationalunit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcecategorypricelevel_organizationalunit"></a> msdyn_resourcecategorypricelevel_organizationalunit

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorypricelevel entity [msdyn_resourcecategorypricelevel_organizationalunit](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_organizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_organizationalunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcecategorypricelevel_organizationalunit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_organizationalunit_createdby](#BKMK_lk_msdyn_organizationalunit_createdby)
- [lk_msdyn_organizationalunit_createdonbehalfby](#BKMK_lk_msdyn_organizationalunit_createdonbehalfby)
- [lk_msdyn_organizationalunit_modifiedby](#BKMK_lk_msdyn_organizationalunit_modifiedby)
- [lk_msdyn_organizationalunit_modifiedonbehalfby](#BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby)
- [organization_msdyn_organizationalunit](#BKMK_organization_msdyn_organizationalunit)
- [msdyn_organizationalunit_currency](#BKMK_msdyn_organizationalunit_currency)


### <a name="BKMK_lk_msdyn_organizationalunit_createdby"></a> lk_msdyn_organizationalunit_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_organizationalunit_createdby](systemuser.md#BKMK_lk_msdyn_organizationalunit_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_organizationalunit_createdonbehalfby"></a> lk_msdyn_organizationalunit_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_organizationalunit_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_organizationalunit_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_organizationalunit_modifiedby"></a> lk_msdyn_organizationalunit_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_organizationalunit_modifiedby](systemuser.md#BKMK_lk_msdyn_organizationalunit_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby"></a> lk_msdyn_organizationalunit_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_organizationalunit_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_organizationalunit"></a> organization_msdyn_organizationalunit

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_organizationalunit](organization.md#BKMK_organization_msdyn_organizationalunit) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_currency"></a> msdyn_organizationalunit_currency

**Added by**: System Solution Solution

See transactioncurrency Entity [msdyn_organizationalunit_currency](transactioncurrency.md#BKMK_msdyn_organizationalunit_currency) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_organizationalunit entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_organizationalunit_pricelevel"></a> msdyn_organizationalunit_pricelevel

IntersectEntityName: msdyn_organizationalunit_pricelevel<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|msdyn_organizationalunitid|
|IsCustomizable|True|
|LogicalName|msdyn_organizationalunit|
|NavigationPropertyName|msdyn_organizationalunit_pricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|pricelevel|
|IntersectAttribute|pricelevelid|
|NavigationPropertyName|msdyn_organizationalunit_pricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_organizationalunit?text=msdyn_organizationalunit EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]