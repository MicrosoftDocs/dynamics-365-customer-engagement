---
title: "msdyn_taxcode Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_taxcode entity."
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
# msdyn_taxcode Entity Reference

Store tax related information. Each tax code could contain multiple child tax codes, and in that case the tax rate will be determined by the total tax of all children.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_taxcodes<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_taxcodes<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_taxcodes|
|DisplayCollectionName|Tax Codes|
|DisplayName|Tax Code|
|EntitySetName|msdyn_taxcodes|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_taxcodes|
|LogicalName|msdyn_taxcode|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_taxcodeid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_taxcode|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActasTaxGroup](#BKMK_msdyn_ActasTaxGroup)
- [msdyn_AgreementTaxable](#BKMK_msdyn_AgreementTaxable)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ProductsTaxable](#BKMK_msdyn_ProductsTaxable)
- [msdyn_ServicesTaxable](#BKMK_msdyn_ServicesTaxable)
- [msdyn_taxcodeId](#BKMK_msdyn_taxcodeId)
- [msdyn_TaxRate](#BKMK_msdyn_TaxRate)
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
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_ActasTaxGroup"></a> msdyn_ActasTaxGroup

|Property|Value|
|--------|-----|
|Description|If set as a Tax Group the tax rate will be the total of all the Tax Code details combined|
|DisplayName|Act as Tax Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actastaxgroup|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_ActasTaxGroup Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_AgreementTaxable"></a> msdyn_AgreementTaxable

|Property|Value|
|--------|-----|
|Description|Select whether this tax code applies to service agreements.|
|DisplayName|Agreement Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementtaxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_AgreementTaxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the sales tax code name.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ProductsTaxable"></a> msdyn_ProductsTaxable

|Property|Value|
|--------|-----|
|Description|Select whether this tax code applies to products.|
|DisplayName|Products Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_productstaxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_ProductsTaxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_ServicesTaxable"></a> msdyn_ServicesTaxable

|Property|Value|
|--------|-----|
|Description|Select whether this tax code applies to services.|
|DisplayName|Services Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_servicestaxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_ServicesTaxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_taxcodeId"></a> msdyn_taxcodeId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Tax Code|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_taxcodeid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_TaxRate"></a> msdyn_TaxRate

|Property|Value|
|--------|-----|
|Description|Enter the rate of this sales tax code.|
|DisplayName|Tax Rate %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxrate|
|MaxValue|100|
|MinValue|0|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
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
|Description|Status of the Tax Code|
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
|Description|Reason for the status of the Tax Code|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who last updated the record on behalf of another user.|
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

- [msdyn_taxcode_SyncErrors](#BKMK_msdyn_taxcode_SyncErrors)
- [msdyn_taxcode_DuplicateMatchingRecord](#BKMK_msdyn_taxcode_DuplicateMatchingRecord)
- [msdyn_taxcode_DuplicateBaseRecord](#BKMK_msdyn_taxcode_DuplicateBaseRecord)
- [msdyn_taxcode_AsyncOperations](#BKMK_msdyn_taxcode_AsyncOperations)
- [msdyn_taxcode_MailboxTrackingFolders](#BKMK_msdyn_taxcode_MailboxTrackingFolders)
- [msdyn_taxcode_ProcessSession](#BKMK_msdyn_taxcode_ProcessSession)
- [msdyn_taxcode_BulkDeleteFailures](#BKMK_msdyn_taxcode_BulkDeleteFailures)
- [msdyn_taxcode_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses)
- [msdyn_taxcode_connections1](#BKMK_msdyn_taxcode_connections1)
- [msdyn_taxcode_connections2](#BKMK_msdyn_taxcode_connections2)
- [msdyn_taxcode_Annotations](#BKMK_msdyn_taxcode_Annotations)
- [msdyn_msdyn_taxcode_account_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode)
- [msdyn_msdyn_taxcode_msdyn_actual_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode)
- [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode)
- [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode)
- [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode)
- [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode)
- [msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode)
- [msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode)
- [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode)
- [msdyn_msdyn_taxcode_quotedetail_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode)


### <a name="BKMK_msdyn_taxcode_SyncErrors"></a> msdyn_taxcode_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_taxcode_SyncErrors](syncerror.md#BKMK_msdyn_taxcode_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_DuplicateMatchingRecord"></a> msdyn_taxcode_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_taxcode_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_taxcode_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_DuplicateBaseRecord"></a> msdyn_taxcode_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_taxcode_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_taxcode_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_AsyncOperations"></a> msdyn_taxcode_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_taxcode_AsyncOperations](asyncoperation.md#BKMK_msdyn_taxcode_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_MailboxTrackingFolders"></a> msdyn_taxcode_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_taxcode_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_taxcode_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_ProcessSession"></a> msdyn_taxcode_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_taxcode_ProcessSession](processsession.md#BKMK_msdyn_taxcode_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_BulkDeleteFailures"></a> msdyn_taxcode_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_taxcode_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_taxcode_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses"></a> msdyn_taxcode_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_taxcode_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_connections1"></a> msdyn_taxcode_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_taxcode_connections1](connection.md#BKMK_msdyn_taxcode_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_connections2"></a> msdyn_taxcode_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_taxcode_connections2](connection.md#BKMK_msdyn_taxcode_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_taxcode_Annotations"></a> msdyn_taxcode_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_taxcode_Annotations](annotation.md#BKMK_msdyn_taxcode_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_taxcode_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode"></a> msdyn_msdyn_taxcode_account_SalesTaxCode

Same as account entity [msdyn_msdyn_taxcode_account_SalesTaxCode](account.md#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|msdyn_salestaxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_account_SalesTaxCode|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_actual_TaxCode

Same as msdyn_actual entity [msdyn_msdyn_taxcode_msdyn_actual_TaxCode](msdyn_actual.md#BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_actual_TaxCode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode"></a> msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode

Same as msdyn_agreement entity [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](msdyn_agreement.md#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|msdyn_salestaxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode

Same as msdyn_purchaseorderbill entity [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rma_TaxCode

Same as msdyn_rma entity [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](msdyn_rma.md#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_rma_TaxCode|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Tax Code<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rtv_TaxCode

Same as msdyn_rtv entity [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](msdyn_rtv.md#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_rtv_TaxCode|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Tax Code<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode"></a> msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode

Same as msdyn_taxcodedetail entity [msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode](msdyn_taxcodedetail.md#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcodedetail|
|ReferencingAttribute|msdyn_parenttaxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: Tax Code Groups<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode

Same as msdyn_taxcodedetail entity [msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode](msdyn_taxcodedetail.md#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcodedetail|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Tax Code Items<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_workorder_TaxCode

Same as msdyn_workorder entity [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](msdyn_workorder.md#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|msdyn_taxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_msdyn_workorder_TaxCode|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode"></a> msdyn_msdyn_taxcode_quotedetail_SalesTaxCode

Same as quotedetail entity [msdyn_msdyn_taxcode_quotedetail_SalesTaxCode](quotedetail.md#BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|msdyn_salestaxcode|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_taxcode_quotedetail_SalesTaxCode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_taxcode_createdby](#BKMK_lk_msdyn_taxcode_createdby)
- [lk_msdyn_taxcode_createdonbehalfby](#BKMK_lk_msdyn_taxcode_createdonbehalfby)
- [lk_msdyn_taxcode_modifiedby](#BKMK_lk_msdyn_taxcode_modifiedby)
- [lk_msdyn_taxcode_modifiedonbehalfby](#BKMK_lk_msdyn_taxcode_modifiedonbehalfby)
- [user_msdyn_taxcode](#BKMK_user_msdyn_taxcode)
- [team_msdyn_taxcode](#BKMK_team_msdyn_taxcode)
- [business_unit_msdyn_taxcode](#BKMK_business_unit_msdyn_taxcode)


### <a name="BKMK_lk_msdyn_taxcode_createdby"></a> lk_msdyn_taxcode_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_taxcode_createdby](systemuser.md#BKMK_lk_msdyn_taxcode_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_createdonbehalfby"></a> lk_msdyn_taxcode_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_taxcode_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_taxcode_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_modifiedby"></a> lk_msdyn_taxcode_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_taxcode_modifiedby](systemuser.md#BKMK_lk_msdyn_taxcode_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_modifiedonbehalfby"></a> lk_msdyn_taxcode_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_taxcode_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_taxcode_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_taxcode"></a> user_msdyn_taxcode

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_taxcode](systemuser.md#BKMK_user_msdyn_taxcode) One-To-Many relationship.

### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

**Added by**: System Solution Solution

See team Entity [team_msdyn_taxcode](team.md#BKMK_team_msdyn_taxcode) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_taxcode"></a> business_unit_msdyn_taxcode

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_taxcode](businessunit.md#BKMK_business_unit_msdyn_taxcode) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_taxcode?text=msdyn_taxcode EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]