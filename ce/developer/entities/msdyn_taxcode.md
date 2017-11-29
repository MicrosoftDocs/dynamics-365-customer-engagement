---
title: "msdyn_taxcode Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_taxcode entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_taxcode Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Store tax related information. Each tax code could contain multiple child tax codes, and in that case the tax rate will be determined by the total tax of all children.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_taxcodes<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_taxcodes<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_taxcodes(*msdyn_taxcodeid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Tax Code<br />
**DisplayCollectionName**: Tax Codes<br />
**SchemaName**: msdyn_taxcode<br />
**CollectionSchemaName**: msdyn_taxcodes<br />
**LogicalName**: msdyn_taxcode<br />
**LogicalCollectionName**: msdyn_taxcodes<br />
**EntitySetName**: msdyn_taxcodes<br />
**PrimaryIdAttribute**: msdyn_taxcodeid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Shows the sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_ActasTaxGroup"></a> msdyn_ActasTaxGroup

**Description**: If set as a Tax Group the tax rate will be the total of all the Tax Code details combined<br />
**DisplayName**: Act as Tax Group<br />
**LogicalName**: msdyn_actastaxgroup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_AgreementTaxable"></a> msdyn_AgreementTaxable

**Description**: Select whether this tax code applies to service agreements.<br />
**DisplayName**: Agreement Taxable<br />
**LogicalName**: msdyn_agreementtaxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the sales tax code name.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProductsTaxable"></a> msdyn_ProductsTaxable

**Description**: Select whether this tax code applies to products.<br />
**DisplayName**: Products Taxable<br />
**LogicalName**: msdyn_productstaxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_ServicesTaxable"></a> msdyn_ServicesTaxable

**Description**: Select whether this tax code applies to services.<br />
**DisplayName**: Services Taxable<br />
**LogicalName**: msdyn_servicestaxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_taxcodeId"></a> msdyn_taxcodeId

**Description**: Shows the entity instances.<br />
**DisplayName**: Tax Code<br />
**LogicalName**: msdyn_taxcodeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_TaxRate"></a> msdyn_TaxRate

**Description**: Enter the rate of this sales tax code.<br />
**DisplayName**: Tax Rate %<br />
**LogicalName**: msdyn_taxrate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Tax Code<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Tax Code<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

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

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_taxcode_SyncErrors](#BKMK_msdyn_taxcode_SyncErrors)
- [msdyn_taxcode_DuplicateMatchingRecord](#BKMK_msdyn_taxcode_DuplicateMatchingRecord)
- [msdyn_taxcode_DuplicateBaseRecord](#BKMK_msdyn_taxcode_DuplicateBaseRecord)
- [msdyn_taxcode_AsyncOperations](#BKMK_msdyn_taxcode_AsyncOperations)
- [msdyn_taxcode_MailboxTrackingFolders](#BKMK_msdyn_taxcode_MailboxTrackingFolders)
- [msdyn_taxcode_UserEntityInstanceDatas](#BKMK_msdyn_taxcode_UserEntityInstanceDatas)
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

Same as syncerror entity [msdyn_taxcode_SyncErrors](syncerror.md#BKMK_msdyn_taxcode_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_taxcode_DuplicateMatchingRecord"></a> msdyn_taxcode_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_taxcode_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_taxcode_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_DuplicateBaseRecord"></a> msdyn_taxcode_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_taxcode_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_taxcode_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_AsyncOperations"></a> msdyn_taxcode_AsyncOperations

Same as asyncoperation entity [msdyn_taxcode_AsyncOperations](asyncoperation.md#BKMK_msdyn_taxcode_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_MailboxTrackingFolders"></a> msdyn_taxcode_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_taxcode_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_taxcode_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_taxcode_UserEntityInstanceDatas"></a> msdyn_taxcode_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_taxcode_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_taxcode_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_ProcessSession"></a> msdyn_taxcode_ProcessSession

Same as processsession entity [msdyn_taxcode_ProcessSession](processsession.md#BKMK_msdyn_taxcode_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_BulkDeleteFailures"></a> msdyn_taxcode_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_taxcode_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_taxcode_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses"></a> msdyn_taxcode_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_taxcode_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_connections1"></a> msdyn_taxcode_connections1

Same as connection entity [msdyn_taxcode_connections1](connection.md#BKMK_msdyn_taxcode_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_connections2"></a> msdyn_taxcode_connections2

Same as connection entity [msdyn_taxcode_connections2](connection.md#BKMK_msdyn_taxcode_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_taxcode_Annotations"></a> msdyn_taxcode_Annotations

Same as annotation entity [msdyn_taxcode_Annotations](annotation.md#BKMK_msdyn_taxcode_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_taxcode_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode"></a> msdyn_msdyn_taxcode_account_SalesTaxCode

Same as account entity [msdyn_msdyn_taxcode_account_SalesTaxCode](account.md#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: msdyn_salestaxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_account_SalesTaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_actual_TaxCode

Same as msdyn_actual entity [msdyn_msdyn_taxcode_msdyn_actual_TaxCode](msdyn_actual.md#BKMK_msdyn_msdyn_taxcode_msdyn_actual_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_actual_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode"></a> msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode

Same as msdyn_agreement entity [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](msdyn_agreement.md#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: msdyn_salestaxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode

Same as msdyn_purchaseorderbill entity [msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rma_TaxCode

Same as msdyn_rma entity [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](msdyn_rma.md#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_rma_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Tax Code
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rtv_TaxCode

Same as msdyn_rtv entity [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](msdyn_rtv.md#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_rtv_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Tax Code
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode"></a> msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode

Same as msdyn_taxcodedetail entity [msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode](msdyn_taxcodedetail.md#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcodedetail<br />
**ReferencingAttribute**: msdyn_parenttaxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Tax Code Groups
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode

Same as msdyn_taxcodedetail entity [msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode](msdyn_taxcodedetail.md#BKMK_msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcodedetail<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Tax Code Items
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_workorder_TaxCode

Same as msdyn_workorder entity [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](msdyn_workorder.md#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_taxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_msdyn_workorder_TaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode"></a> msdyn_msdyn_taxcode_quotedetail_SalesTaxCode

Same as quotedetail entity [msdyn_msdyn_taxcode_quotedetail_SalesTaxCode](quotedetail.md#BKMK_msdyn_msdyn_taxcode_quotedetail_SalesTaxCode) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: msdyn_salestaxcode<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_taxcode_quotedetail_SalesTaxCode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

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

See systemuser Entity [lk_msdyn_taxcode_createdby](systemuser.md#BKMK_lk_msdyn_taxcode_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_createdonbehalfby"></a> lk_msdyn_taxcode_createdonbehalfby

See systemuser Entity [lk_msdyn_taxcode_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_taxcode_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_modifiedby"></a> lk_msdyn_taxcode_modifiedby

See systemuser Entity [lk_msdyn_taxcode_modifiedby](systemuser.md#BKMK_lk_msdyn_taxcode_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_taxcode_modifiedonbehalfby"></a> lk_msdyn_taxcode_modifiedonbehalfby

See systemuser Entity [lk_msdyn_taxcode_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_taxcode_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_taxcode"></a> user_msdyn_taxcode

See systemuser Entity [user_msdyn_taxcode](systemuser.md#BKMK_user_msdyn_taxcode) One-To-Many relationship.

### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

See team Entity [team_msdyn_taxcode](team.md#BKMK_team_msdyn_taxcode) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_taxcode"></a> business_unit_msdyn_taxcode

See businessunit Entity [business_unit_msdyn_taxcode](businessunit.md#BKMK_business_unit_msdyn_taxcode) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_taxcode?text=msdyn_taxcode EntityType" />