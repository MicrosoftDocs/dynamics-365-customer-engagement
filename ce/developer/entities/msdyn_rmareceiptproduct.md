---
title: "msdyn_rmareceiptproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rmareceiptproduct entity."
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
# msdyn_rmareceiptproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify RMA receipt product.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: RMA Receipt Product<br />
**DisplayCollectionName**: RMA Receipt Products<br />
**SchemaName**: msdyn_rmareceiptproduct<br />
**CollectionSchemaName**: msdyn_rmareceiptproducts<br />
**LogicalName**: msdyn_rmareceiptproduct<br />
**LogicalCollectionName**: msdyn_rmareceiptproducts<br />
**EntitySetName**: msdyn_rmareceiptproducts<br />
**PrimaryIdAttribute**: msdyn_rmareceiptproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_RMA](#BKMK_msdyn_RMA)
- [msdyn_RMAProduct](#BKMK_msdyn_RMAProduct)
- [msdyn_RMAReceipt](#BKMK_msdyn_RMAReceipt)
- [msdyn_rmareceiptproductId](#BKMK_msdyn_rmareceiptproductId)
- [msdyn_RTV](#BKMK_msdyn_RTV)
- [msdyn_RTVProduct](#BKMK_msdyn_RTVProduct)
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


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Enter the quantity received.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_RMA"></a> msdyn_RMA

**Description**: RMA this product relates to<br />
**DisplayName**: RMA<br />
**LogicalName**: msdyn_rma<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_rma


### <a name="BKMK_msdyn_RMAProduct"></a> msdyn_RMAProduct

**Description**: RMA Product this product relates to<br />
**DisplayName**: RMA Product<br />
**LogicalName**: msdyn_rmaproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_rmaproduct


### <a name="BKMK_msdyn_RMAReceipt"></a> msdyn_RMAReceipt

**Description**: RMA Receipt this product relates to<br />
**DisplayName**: RMA Receipt<br />
**LogicalName**: msdyn_rmareceipt<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_rmareceipt


### <a name="BKMK_msdyn_rmareceiptproductId"></a> msdyn_rmareceiptproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: RMA Receipt Product<br />
**LogicalName**: msdyn_rmareceiptproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_RTV"></a> msdyn_RTV

**Description**: RTV this product relates to (if Product Action is RTV)<br />
**DisplayName**: RTV<br />
**LogicalName**: msdyn_rtv<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rtv


### <a name="BKMK_msdyn_RTVProduct"></a> msdyn_RTVProduct

**Description**: RTV Product this product relates to (if Product Action is RTV)<br />
**DisplayName**: RTV Product<br />
**LogicalName**: msdyn_rtvproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rtvproduct


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

**Description**: Status of the RMA Receipt Product<br />
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

**Description**: Reason for the status of the RMA Receipt Product<br />
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
- [msdyn_RMAName](#BKMK_msdyn_RMAName)
- [msdyn_RMAProductName](#BKMK_msdyn_RMAProductName)
- [msdyn_RMAReceiptName](#BKMK_msdyn_RMAReceiptName)
- [msdyn_RTVName](#BKMK_msdyn_RTVName)
- [msdyn_RTVProductName](#BKMK_msdyn_RTVProductName)
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


### <a name="BKMK_msdyn_RMAName"></a> msdyn_RMAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAProductName"></a> msdyn_RMAProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmaproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAReceiptName"></a> msdyn_RMAReceiptName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rmareceiptname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RTVName"></a> msdyn_RTVName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rtvname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RTVProductName"></a> msdyn_RTVProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_rtvproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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

- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmareceiptproduct_msdyn_approvals](#BKMK_msdyn_rmareceiptproduct_msdyn_approvals)
- [msdyn_rmareceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts)
- [msdyn_rmareceiptproduct_SyncErrors](#BKMK_msdyn_rmareceiptproduct_SyncErrors)
- [msdyn_rmareceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)
- [msdyn_rmareceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)
- [msdyn_rmareceiptproduct_AsyncOperations](#BKMK_msdyn_rmareceiptproduct_AsyncOperations)
- [msdyn_rmareceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)
- [msdyn_rmareceiptproduct_UserEntityInstanceDatas](#BKMK_msdyn_rmareceiptproduct_UserEntityInstanceDatas)
- [msdyn_rmareceiptproduct_ProcessSession](#BKMK_msdyn_rmareceiptproduct_ProcessSession)
- [msdyn_rmareceiptproduct_BulkDeleteFailures](#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)
- [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmareceiptproduct_Emails](#BKMK_msdyn_rmareceiptproduct_Emails)
- [msdyn_rmareceiptproduct_Faxes](#BKMK_msdyn_rmareceiptproduct_Faxes)
- [msdyn_rmareceiptproduct_Letters](#BKMK_msdyn_rmareceiptproduct_Letters)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_SocialActivities](#BKMK_msdyn_rmareceiptproduct_SocialActivities)
- [msdyn_rmareceiptproduct_connections1](#BKMK_msdyn_rmareceiptproduct_connections1)
- [msdyn_rmareceiptproduct_connections2](#BKMK_msdyn_rmareceiptproduct_connections2)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmareceiptproduct_ServiceAppointments](#BKMK_msdyn_rmareceiptproduct_ServiceAppointments)
- [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)


### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

Same as activitypointer entity [msdyn_rmareceiptproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_approvals"></a> msdyn_rmareceiptproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_rmareceiptproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rmareceiptproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts"></a> msdyn_rmareceiptproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_rmareceiptproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_SyncErrors"></a> msdyn_rmareceiptproduct_SyncErrors

Same as syncerror entity [msdyn_rmareceiptproduct_SyncErrors](syncerror.md#BKMK_msdyn_rmareceiptproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord"></a> msdyn_rmareceiptproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_rmareceiptproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord"></a> msdyn_rmareceiptproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_rmareceiptproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

Same as asyncoperation entity [msdyn_rmareceiptproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders"></a> msdyn_rmareceiptproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_rmareceiptproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_UserEntityInstanceDatas"></a> msdyn_rmareceiptproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_rmareceiptproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_rmareceiptproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

Same as processsession entity [msdyn_rmareceiptproduct_ProcessSession](processsession.md#BKMK_msdyn_rmareceiptproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures"></a> msdyn_rmareceiptproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_rmareceiptproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

Same as appointment entity [msdyn_rmareceiptproduct_Appointments](appointment.md#BKMK_msdyn_rmareceiptproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Appointments<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Emails"></a> msdyn_rmareceiptproduct_Emails

Same as email entity [msdyn_rmareceiptproduct_Emails](email.md#BKMK_msdyn_rmareceiptproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Emails<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Faxes"></a> msdyn_rmareceiptproduct_Faxes

Same as fax entity [msdyn_rmareceiptproduct_Faxes](fax.md#BKMK_msdyn_rmareceiptproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Faxes<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Letters"></a> msdyn_rmareceiptproduct_Letters

Same as letter entity [msdyn_rmareceiptproduct_Letters](letter.md#BKMK_msdyn_rmareceiptproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Letters<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

Same as phonecall entity [msdyn_rmareceiptproduct_PhoneCalls](phonecall.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

Same as task entity [msdyn_rmareceiptproduct_Tasks](task.md#BKMK_msdyn_rmareceiptproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Tasks<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_rmareceiptproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_SocialActivities"></a> msdyn_rmareceiptproduct_SocialActivities

Same as socialactivity entity [msdyn_rmareceiptproduct_SocialActivities](socialactivity.md#BKMK_msdyn_rmareceiptproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_connections1"></a> msdyn_rmareceiptproduct_connections1

Same as connection entity [msdyn_rmareceiptproduct_connections1](connection.md#BKMK_msdyn_rmareceiptproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_connections1<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_connections2"></a> msdyn_rmareceiptproduct_connections2

Same as connection entity [msdyn_rmareceiptproduct_connections2](connection.md#BKMK_msdyn_rmareceiptproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_connections2<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

Same as annotation entity [msdyn_rmareceiptproduct_Annotations](annotation.md#BKMK_msdyn_rmareceiptproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_Annotations<br />
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


### <a name="BKMK_msdyn_rmareceiptproduct_ServiceAppointments"></a> msdyn_rmareceiptproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_rmareceiptproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rmareceiptproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rmareceiptproduct_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct"></a> msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_rmareceiptproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct<br />
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

- [lk_msdyn_rmareceiptproduct_createdby](#BKMK_lk_msdyn_rmareceiptproduct_createdby)
- [lk_msdyn_rmareceiptproduct_createdonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby)
- [lk_msdyn_rmareceiptproduct_modifiedby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedby)
- [lk_msdyn_rmareceiptproduct_modifiedonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby)
- [user_msdyn_rmareceiptproduct](#BKMK_user_msdyn_rmareceiptproduct)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [business_unit_msdyn_rmareceiptproduct](#BKMK_business_unit_msdyn_rmareceiptproduct)
- [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)
- [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct)
- [msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt)
- [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)
- [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct)


### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdby"></a> lk_msdyn_rmareceiptproduct_createdby

See systemuser Entity [lk_msdyn_rmareceiptproduct_createdby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby"></a> lk_msdyn_rmareceiptproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_rmareceiptproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedby"></a> lk_msdyn_rmareceiptproduct_modifiedby

See systemuser Entity [lk_msdyn_rmareceiptproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby"></a> lk_msdyn_rmareceiptproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_rmareceiptproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rmareceiptproduct"></a> user_msdyn_rmareceiptproduct

See systemuser Entity [user_msdyn_rmareceiptproduct](systemuser.md#BKMK_user_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

See team Entity [team_msdyn_rmareceiptproduct](team.md#BKMK_team_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

See businessunit Entity [business_unit_msdyn_rmareceiptproduct](businessunit.md#BKMK_business_unit_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct

See msdyn_rmaproduct Entity [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt"></a> msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt

See msdyn_rmareceipt Entity [msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](msdyn_rmareceipt.md#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV

See msdyn_rtv Entity [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](msdyn_rtv.md#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct"></a> msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct

See msdyn_rtvproduct Entity [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rmareceiptproduct?text=msdyn_rmareceiptproduct EntityType" />