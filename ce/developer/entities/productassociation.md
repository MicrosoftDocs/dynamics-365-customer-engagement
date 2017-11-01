---
title: "ProductAssociation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProductAssociation entity."
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
# ProductAssociation Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Instance of a product added to a bundle or kit.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/productassociations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/productassociations(*productassociationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/productassociations(*productassociationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/productassociations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/productassociations(*productassociationid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/productassociations(*productassociationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Product Association<br />
**DisplayCollectionName**: Product Associations<br />
**SchemaName**: ProductAssociation<br />
**CollectionSchemaName**: ProductAssociations<br />
**LogicalName**: productassociation<br />
**LogicalCollectionName**: productassociations<br />
**EntitySetName**: productassociations<br />
**PrimaryIdAttribute**: productassociationid<br />
**PrimaryNameAttribute**: productidname<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AssociatedProduct](#BKMK_AssociatedProduct)
- [DMTImportState](#BKMK_DMTImportState)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProductAssociationId](#BKMK_ProductAssociationId)
- [ProductId](#BKMK_ProductId)
- [ProductIsRequired](#BKMK_ProductIsRequired)
- [PropertyCustomizationStatus](#BKMK_PropertyCustomizationStatus)
- [Quantity](#BKMK_Quantity)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UoMId](#BKMK_UoMId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AssociatedProduct"></a> AssociatedProduct

**Description**: Select a product to add to the bundle or kit.<br />
**DisplayName**: Associated Product<br />
**LogicalName**: associatedproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_DMTImportState"></a> DMTImportState

**Description**: Internal Use Only<br />
**DisplayName**: Internal Use Only<br />
**LogicalName**: dmtimportstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
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


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ProductAssociationId"></a> ProductAssociationId

**Description**: Shows the unique identifier of the product association.<br />
**DisplayName**: Product Association ID<br />
**LogicalName**: productassociationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Select a bundle or a kit.<br />
**DisplayName**: Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_ProductIsRequired"></a> ProductIsRequired

**Description**: Select whether the associated product is required or optional.<br />
**DisplayName**: Required<br />
**LogicalName**: productisrequired<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Optional
- **Value**: 1 **Label**: Required



### <a name="BKMK_PropertyCustomizationStatus"></a> PropertyCustomizationStatus

**Description**: Shows whether the item has properties that can be customized.<br />
**DisplayName**: Property Customization<br />
**LogicalName**: propertycustomizationstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Not Available
- **Value**: 1 **Label**: Available



### <a name="BKMK_Quantity"></a> Quantity

**Description**: Type the quantity of the products added to the bundle or kit.<br />
**DisplayName**: Quantity<br />
**LogicalName**: quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_statecode"></a> statecode

**Description**: Shows whether the associated product is active or inactive.<br />
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
- **Value**: 2 **Label**: Draft **DefaultStatus**: 0 **InvariantName**: Draft
- **Value**: 3 **Label**: Under Revision **DefaultStatus**: 3 **InvariantName**: Under Revision



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Select the associated product's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Draft **State**: 2
- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1
- **Value**: 3 **Label**: DraftActive **State**: 3



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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Shows the currency associated with the record.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UoMId"></a> UoMId

**Description**: Shows the unit of the product association.<br />
**DisplayName**: Unit<br />
**LogicalName**: uomid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
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

- [AssociatedProductIdName](#BKMK_AssociatedProductIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ProductIdName](#BKMK_ProductIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UoMIdName](#BKMK_UoMIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AssociatedProductIdName"></a> AssociatedProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: associatedproductidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
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

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
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

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ProductIdName"></a> ProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: productidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_UoMIdName"></a> UoMIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [ProductAssociation_SyncErrors](#BKMK_ProductAssociation_SyncErrors)
- [ProductAssociation_AsyncOperations](#BKMK_ProductAssociation_AsyncOperations)
- [productassociation_MailboxTrackingFolders](#BKMK_productassociation_MailboxTrackingFolders)
- [userentityinstancedata_productassociation](#BKMK_userentityinstancedata_productassociation)
- [ProductAssociation_ProcessSessions](#BKMK_ProductAssociation_ProcessSessions)
- [productassociation_BulkDeleteFailures](#BKMK_productassociation_BulkDeleteFailures)
- [ProductAssociation_PrincipalObjectAttributeAccess](#BKMK_ProductAssociation_PrincipalObjectAttributeAccess)
- [ProductAssociation_DynamicPropertyAssociation](#BKMK_ProductAssociation_DynamicPropertyAssociation)
- [ProductAssociation_DynamicProperty](#BKMK_ProductAssociation_DynamicProperty)
- [productAssociation_quote_details](#BKMK_productAssociation_quote_details)
- [productAssociation_opportunity_product](#BKMK_productAssociation_opportunity_product)
- [productAssociation_invoice_details](#BKMK_productAssociation_invoice_details)
- [productAssociation_salesorder_details](#BKMK_productAssociation_salesorder_details)


### <a name="BKMK_ProductAssociation_SyncErrors"></a> ProductAssociation_SyncErrors

Same as syncerror entity [ProductAssociation_SyncErrors](syncerror.md#BKMK_ProductAssociation_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_ProductAssociation_AsyncOperations"></a> ProductAssociation_AsyncOperations

Same as asyncoperation entity [ProductAssociation_AsyncOperations](asyncoperation.md#BKMK_ProductAssociation_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_AsyncOperations<br />
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


### <a name="BKMK_productassociation_MailboxTrackingFolders"></a> productassociation_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [productassociation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_productassociation_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productassociation_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_productassociation"></a> userentityinstancedata_productassociation

Same as userentityinstancedata entity [userentityinstancedata_productassociation](userentityinstancedata.md#BKMK_userentityinstancedata_productassociation) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_productassociation<br />
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


### <a name="BKMK_ProductAssociation_ProcessSessions"></a> ProductAssociation_ProcessSessions

Same as processsession entity [ProductAssociation_ProcessSessions](processsession.md#BKMK_ProductAssociation_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_productassociation_BulkDeleteFailures"></a> productassociation_BulkDeleteFailures

Same as bulkdeletefailure entity [productassociation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_productassociation_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productassociation_BulkDeleteFailures<br />
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


### <a name="BKMK_ProductAssociation_PrincipalObjectAttributeAccess"></a> ProductAssociation_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [ProductAssociation_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_ProductAssociation_PrincipalObjectAttributeAccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_PrincipalObjectAttributeAccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_ProductAssociation_DynamicPropertyAssociation"></a> ProductAssociation_DynamicPropertyAssociation

Same as dynamicpropertyassociation entity [ProductAssociation_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_ProductAssociation_DynamicPropertyAssociation) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyassociation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_DynamicPropertyAssociation<br />
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


### <a name="BKMK_ProductAssociation_DynamicProperty"></a> ProductAssociation_DynamicProperty

Same as dynamicproperty entity [ProductAssociation_DynamicProperty](dynamicproperty.md#BKMK_ProductAssociation_DynamicProperty) Many-To-One relationship.

**ReferencingEntity**: dynamicproperty<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProductAssociation_DynamicProperty<br />
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


### <a name="BKMK_productAssociation_quote_details"></a> productAssociation_quote_details

Same as quotedetail entity [productAssociation_quote_details](quotedetail.md#BKMK_productAssociation_quote_details) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: productassociationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productAssociation_quote_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_productAssociation_opportunity_product"></a> productAssociation_opportunity_product

Same as opportunityproduct entity [productAssociation_opportunity_product](opportunityproduct.md#BKMK_productAssociation_opportunity_product) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: productassociationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productAssociation_opportunity_product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_productAssociation_invoice_details"></a> productAssociation_invoice_details

Same as invoicedetail entity [productAssociation_invoice_details](invoicedetail.md#BKMK_productAssociation_invoice_details) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: productassociationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productAssociation_invoice_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_productAssociation_salesorder_details"></a> productAssociation_salesorder_details

Same as salesorderdetail entity [productAssociation_salesorder_details](salesorderdetail.md#BKMK_productAssociation_salesorder_details) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: productassociationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: productAssociation_salesorder_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_ProductAssociate_createdby](#BKMK_lk_ProductAssociate_createdby)
- [lk_ProductAssociation_createdonbehalfby](#BKMK_lk_ProductAssociation_createdonbehalfby)
- [lk_ProductAssociation_modifiedby](#BKMK_lk_ProductAssociation_modifiedby)
- [lk_ProductAssociation_modifiedonbehalfby](#BKMK_lk_ProductAssociation_modifiedonbehalfby)
- [organization_ProductAssociation](#BKMK_organization_ProductAssociation)
- [Product_ProductAssociation_AssocProd](#BKMK_Product_ProductAssociation_AssocProd)
- [Product_ProductAssociation_Prod](#BKMK_Product_ProductAssociation_Prod)
- [transactioncurrency_ProductAssociation](#BKMK_transactioncurrency_ProductAssociation)
- [unit_of_measurement_productassociation](#BKMK_unit_of_measurement_productassociation)


### <a name="BKMK_lk_ProductAssociate_createdby"></a> lk_ProductAssociate_createdby

See systemuser Entity [lk_ProductAssociate_createdby](systemuser.md#BKMK_lk_ProductAssociate_createdby) One-To-Many relationship.

### <a name="BKMK_lk_ProductAssociation_createdonbehalfby"></a> lk_ProductAssociation_createdonbehalfby

See systemuser Entity [lk_ProductAssociation_createdonbehalfby](systemuser.md#BKMK_lk_ProductAssociation_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_ProductAssociation_modifiedby"></a> lk_ProductAssociation_modifiedby

See systemuser Entity [lk_ProductAssociation_modifiedby](systemuser.md#BKMK_lk_ProductAssociation_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_ProductAssociation_modifiedonbehalfby"></a> lk_ProductAssociation_modifiedonbehalfby

See systemuser Entity [lk_ProductAssociation_modifiedonbehalfby](systemuser.md#BKMK_lk_ProductAssociation_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_ProductAssociation"></a> organization_ProductAssociation

See organization Entity [organization_ProductAssociation](organization.md#BKMK_organization_ProductAssociation) One-To-Many relationship.

### <a name="BKMK_Product_ProductAssociation_AssocProd"></a> Product_ProductAssociation_AssocProd

See product Entity [Product_ProductAssociation_AssocProd](product.md#BKMK_Product_ProductAssociation_AssocProd) One-To-Many relationship.

### <a name="BKMK_Product_ProductAssociation_Prod"></a> Product_ProductAssociation_Prod

See product Entity [Product_ProductAssociation_Prod](product.md#BKMK_Product_ProductAssociation_Prod) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_ProductAssociation"></a> transactioncurrency_ProductAssociation

See transactioncurrency Entity [transactioncurrency_ProductAssociation](transactioncurrency.md#BKMK_transactioncurrency_ProductAssociation) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_productassociation"></a> unit_of_measurement_productassociation

See uom Entity [unit_of_measurement_productassociation](uom.md#BKMK_unit_of_measurement_productassociation) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.productassociation?text=productassociation EntityType" />