---
title: "msdyn_entitlementapplication Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_entitlementapplication entity."
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
# msdyn_entitlementapplication Entity Reference

Entitlement Application that will drive automatic application when the work was performed for Service Account, Customer Asset, Asset Category, Incident Type and Entitlement.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_entitlementapplications(*msdyn_entitlementapplicationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_entitlementapplications<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_entitlementapplications(*msdyn_entitlementapplicationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_entitlementapplications(*msdyn_entitlementapplicationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_entitlementapplications<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_entitlementapplications(*msdyn_entitlementapplicationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_entitlementapplications(*msdyn_entitlementapplicationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_entitlementapplications|
|DisplayCollectionName|Entitlement Applications|
|DisplayName|Entitlement Application|
|EntitySetName|msdyn_entitlementapplications|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_entitlementapplications|
|LogicalName|msdyn_entitlementapplication|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_entitlementapplicationid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_entitlementapplication|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_assetcategory](#BKMK_msdyn_assetcategory)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_entitlement](#BKMK_msdyn_entitlement)
- [msdyn_entitlementapplicationId](#BKMK_msdyn_entitlementapplicationId)
- [msdyn_incidenttype](#BKMK_msdyn_incidenttype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_serviceaccount](#BKMK_msdyn_serviceaccount)
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


### <a name="BKMK_msdyn_assetcategory"></a> msdyn_assetcategory

|Property|Value|
|--------|-----|
|Description|Entitlement Application record will only drive automatic application when the work was performed for this Customer Asset Category. If populated with other fields, then both must be true.|
|DisplayName|Asset Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_assetcategory|
|RequiredLevel|None|
|Targets|msdyn_customerassetcategory|
|Type|Lookup|


### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

|Property|Value|
|--------|-----|
|Description|Entitlement Application record will only drive automatic application when the work was performed for this customer asset. If populated with other fields, both must be true.|
|DisplayName|Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_entitlement"></a> msdyn_entitlement

|Property|Value|
|--------|-----|
|Description|Entitlement Application record will only drive automatic application for this related Entitlement.|
|DisplayName|Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitlement|
|RequiredLevel|ApplicationRequired|
|Targets|entitlement|
|Type|Lookup|


### <a name="BKMK_msdyn_entitlementapplicationId"></a> msdyn_entitlementapplicationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Entitlement Application|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_entitlementapplicationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_incidenttype"></a> msdyn_incidenttype

|Property|Value|
|--------|-----|
|Description|Entitlement Application record will only drive automatic application when the work was performed related to this incident type. If populated with other fields, both must be true.|
|DisplayName|Incident Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_incidenttype|
|RequiredLevel|None|
|Targets|msdyn_incidenttype|
|Type|Lookup|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of entitlement application name|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_serviceaccount"></a> msdyn_serviceaccount

|Property|Value|
|--------|-----|
|Description|Entitlement Application record will only drive automatic application when the work was performed for this service account. If populated with other fields, both must be true.|
|DisplayName|Service Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccount|
|RequiredLevel|None|
|Targets|account|
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
|Description|Status of the Entitlement Application|
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
|Description|Reason for the status of the Entitlement Application|
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
- [msdyn_assetcategoryName](#BKMK_msdyn_assetcategoryName)
- [msdyn_customerassetName](#BKMK_msdyn_customerassetName)
- [msdyn_entitlementName](#BKMK_msdyn_entitlementName)
- [msdyn_incidenttypeName](#BKMK_msdyn_incidenttypeName)
- [msdyn_serviceaccountName](#BKMK_msdyn_serviceaccountName)
- [msdyn_serviceaccountYomiName](#BKMK_msdyn_serviceaccountYomiName)
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


### <a name="BKMK_msdyn_assetcategoryName"></a> msdyn_assetcategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_assetcategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_customerassetName"></a> msdyn_customerassetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_entitlementName"></a> msdyn_entitlementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_entitlementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_incidenttypeName"></a> msdyn_incidenttypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_incidenttypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_serviceaccountName"></a> msdyn_serviceaccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_serviceaccountYomiName"></a> msdyn_serviceaccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountyominame|
|MaxLength|160|
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

- [msdyn_entitlementapplication_SyncErrors](#BKMK_msdyn_entitlementapplication_SyncErrors)
- [msdyn_entitlementapplication_DuplicateMatchingRecord](#BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord)
- [msdyn_entitlementapplication_DuplicateBaseRecord](#BKMK_msdyn_entitlementapplication_DuplicateBaseRecord)
- [msdyn_entitlementapplication_AsyncOperations](#BKMK_msdyn_entitlementapplication_AsyncOperations)
- [msdyn_entitlementapplication_MailboxTrackingFolders](#BKMK_msdyn_entitlementapplication_MailboxTrackingFolders)
- [msdyn_entitlementapplication_ProcessSession](#BKMK_msdyn_entitlementapplication_ProcessSession)
- [msdyn_entitlementapplication_BulkDeleteFailures](#BKMK_msdyn_entitlementapplication_BulkDeleteFailures)
- [msdyn_entitlementapplication_PrincipalObjectAttributeAccesses](#BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_entitlementapplication_SyncErrors"></a> msdyn_entitlementapplication_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_entitlementapplication_SyncErrors](syncerror.md#BKMK_msdyn_entitlementapplication_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord"></a> msdyn_entitlementapplication_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_entitlementapplication_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_DuplicateBaseRecord"></a> msdyn_entitlementapplication_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_entitlementapplication_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_entitlementapplication_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_AsyncOperations"></a> msdyn_entitlementapplication_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_entitlementapplication_AsyncOperations](asyncoperation.md#BKMK_msdyn_entitlementapplication_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_MailboxTrackingFolders"></a> msdyn_entitlementapplication_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_entitlementapplication_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_entitlementapplication_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_ProcessSession"></a> msdyn_entitlementapplication_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_entitlementapplication_ProcessSession](processsession.md#BKMK_msdyn_entitlementapplication_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_BulkDeleteFailures"></a> msdyn_entitlementapplication_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_entitlementapplication_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_entitlementapplication_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses"></a> msdyn_entitlementapplication_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_entitlementapplication_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_entitlementapplication_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_entitlementapplication_createdby](#BKMK_lk_msdyn_entitlementapplication_createdby)
- [lk_msdyn_entitlementapplication_createdonbehalfby](#BKMK_lk_msdyn_entitlementapplication_createdonbehalfby)
- [lk_msdyn_entitlementapplication_modifiedby](#BKMK_lk_msdyn_entitlementapplication_modifiedby)
- [lk_msdyn_entitlementapplication_modifiedonbehalfby](#BKMK_lk_msdyn_entitlementapplication_modifiedonbehalfby)
- [user_msdyn_entitlementapplication](#BKMK_user_msdyn_entitlementapplication)
- [team_msdyn_entitlementapplication](#BKMK_team_msdyn_entitlementapplication)
- [business_unit_msdyn_entitlementapplication](#BKMK_business_unit_msdyn_entitlementapplication)
- [msdyn_account_msdyn_entitlementapplication_serviceaccount](#BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount)
- [msdyn_entitlement_msdyn_entitlementapplication_entitlement](#BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement)
- [msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset)
- [msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory](#BKMK_msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory)
- [msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype](#BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype)


### <a name="BKMK_lk_msdyn_entitlementapplication_createdby"></a> lk_msdyn_entitlementapplication_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_entitlementapplication_createdby](systemuser.md#BKMK_lk_msdyn_entitlementapplication_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_entitlementapplication_createdonbehalfby"></a> lk_msdyn_entitlementapplication_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_entitlementapplication_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_entitlementapplication_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_entitlementapplication_modifiedby"></a> lk_msdyn_entitlementapplication_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_entitlementapplication_modifiedby](systemuser.md#BKMK_lk_msdyn_entitlementapplication_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_entitlementapplication_modifiedonbehalfby"></a> lk_msdyn_entitlementapplication_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_entitlementapplication_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_entitlementapplication_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_entitlementapplication"></a> user_msdyn_entitlementapplication

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_entitlementapplication](systemuser.md#BKMK_user_msdyn_entitlementapplication) One-To-Many relationship.

### <a name="BKMK_team_msdyn_entitlementapplication"></a> team_msdyn_entitlementapplication

**Added by**: System Solution Solution

See team Entity [team_msdyn_entitlementapplication](team.md#BKMK_team_msdyn_entitlementapplication) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_entitlementapplication"></a> business_unit_msdyn_entitlementapplication

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_entitlementapplication](businessunit.md#BKMK_business_unit_msdyn_entitlementapplication) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount"></a> msdyn_account_msdyn_entitlementapplication_serviceaccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_entitlementapplication_serviceaccount](account.md#BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement"></a> msdyn_entitlement_msdyn_entitlementapplication_entitlement

**Added by**: Service Solution

See entitlement Entity [msdyn_entitlement_msdyn_entitlementapplication_entitlement](entitlement.md#BKMK_msdyn_entitlement_msdyn_entitlementapplication_entitlement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset"></a> msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory"></a> msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory

See msdyn_customerassetcategory Entity [msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory](msdyn_customerassetcategory.md#BKMK_msdyn_msdyn_customerassetcategory_msdyn_entitlementapplication_assetcategory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype"></a> msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_entitlementapplication?text=msdyn_entitlementapplication EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]