---
title: "Product Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Product entity."
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
# Product Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Information about products and their pricing information.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Associate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|CloneProduct|<xref href="Microsoft.Dynamics.CRM.CloneProduct?text=CloneProduct Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneProductRequest>|
|Create|POST [*org URI*]/api/data/v9.0/products<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|PublishProductHierarchy|<xref href="Microsoft.Dynamics.CRM.PublishProductHierarchy?text=PublishProductHierarchy Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/products<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RevertProduct|<xref href="Microsoft.Dynamics.CRM.RevertProduct?text=RevertProduct Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevertProductRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/products(*productid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Product<br />
**DisplayCollectionName**: Products<br />
**SchemaName**: Product<br />
**CollectionSchemaName**: Products<br />
**LogicalName**: product<br />
**LogicalCollectionName**: products<br />
**EntitySetName**: products<br />
**PrimaryIdAttribute**: productid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CurrentCost](#BKMK_CurrentCost)
- [DefaultUoMId](#BKMK_DefaultUoMId)
- [DefaultUoMScheduleId](#BKMK_DefaultUoMScheduleId)
- [Description](#BKMK_Description)
- [DMTImportState](#BKMK_DMTImportState)
- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsKit](#BKMK_IsKit)
- [IsStockItem](#BKMK_IsStockItem)
- [msdyn_ConvertToCustomerAsset](#BKMK_msdyn_ConvertToCustomerAsset)
- [msdyn_DefaultVendor](#BKMK_msdyn_DefaultVendor)
- [msdyn_FieldServiceProductType](#BKMK_msdyn_FieldServiceProductType)
- [msdyn_PurchaseName](#BKMK_msdyn_PurchaseName)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_UPCCode](#BKMK_msdyn_UPCCode)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentProductId](#BKMK_ParentProductId)
- [Price](#BKMK_Price)
- [PriceLevelId](#BKMK_PriceLevelId)
- [ProcessId](#BKMK_ProcessId)
- [ProductId](#BKMK_ProductId)
- [ProductNumber](#BKMK_ProductNumber)
- [ProductStructure](#BKMK_ProductStructure)
- [ProductTypeCode](#BKMK_ProductTypeCode)
- [ProductUrl](#BKMK_ProductUrl)
- [QuantityDecimal](#BKMK_QuantityDecimal)
- [QuantityOnHand](#BKMK_QuantityOnHand)
- [Size](#BKMK_Size)
- [StageId](#BKMK_StageId)
- [StandardCost](#BKMK_StandardCost)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [StockVolume](#BKMK_StockVolume)
- [StockWeight](#BKMK_StockWeight)
- [SubjectId](#BKMK_SubjectId)
- [SupplierName](#BKMK_SupplierName)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [ValidFromDate](#BKMK_ValidFromDate)
- [ValidToDate](#BKMK_ValidToDate)
- [VendorID](#BKMK_VendorID)
- [VendorName](#BKMK_VendorName)
- [VendorPartNumber](#BKMK_VendorPartNumber)


### <a name="BKMK_CurrentCost"></a> CurrentCost

**Description**: Current cost for the product item. Used in price calculations.<br />
**DisplayName**: Current Cost<br />
**LogicalName**: currentcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_DefaultUoMId"></a> DefaultUoMId

**Description**: Default unit for the product.<br />
**DisplayName**: Default Unit<br />
**LogicalName**: defaultuomid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_DefaultUoMScheduleId"></a> DefaultUoMScheduleId

**Description**: Default unit group for the product.<br />
**DisplayName**: Unit Group<br />
**LogicalName**: defaultuomscheduleid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uomschedule


### <a name="BKMK_Description"></a> Description

**Description**: Description of the product.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: Shows the default image for the record.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: True<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


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


### <a name="BKMK_IsKit"></a> IsKit

**Description**: Information that specifies whether the product is a kit.<br />
**DisplayName**: Is Kit<br />
**LogicalName**: iskit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsStockItem"></a> IsStockItem

**Description**: Information about whether the product is a stock item.<br />
**DisplayName**: Stock Item<br />
**LogicalName**: isstockitem<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_ConvertToCustomerAsset"></a> msdyn_ConvertToCustomerAsset

**Added by**: Field Service Solution<br />
**Description**: Specify whether a product is to be converted to a customer asset. When a product is used on a work order, the system will automatically convert it into a customer asset when the work order is closed.<br />
**DisplayName**: Convert to Customer Asset<br />
**LogicalName**: msdyn_converttocustomerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_DefaultVendor"></a> msdyn_DefaultVendor

**Added by**: Field Service Solution<br />
**Description**: Default vendor that supplies this product<br />
**DisplayName**: Default Vendor<br />
**LogicalName**: msdyn_defaultvendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_FieldServiceProductType"></a> msdyn_FieldServiceProductType

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Field Service Product Type<br />
**LogicalName**: msdyn_fieldserviceproducttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Inventory
- **Value**: 690970001 **Label**: Non-Inventory
- **Value**: 690970002 **Label**: Service



### <a name="BKMK_msdyn_PurchaseName"></a> msdyn_PurchaseName

**Added by**: Field Service Solution<br />
**Description**: Type the name for the product when used on a purchase order.<br />
**DisplayName**: Purchase Name<br />
**LogicalName**: msdyn_purchasename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Added by**: Field Service Solution<br />
**Description**: Select whether the item is taxable. If an item is set as not taxable, it won't be taxable even on a taxable work order.<br />
**DisplayName**: Taxable<br />
**LogicalName**: msdyn_taxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Added by**: Project Service Automation Solution<br />
**Description**: Select the transaction category for this product.<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_transactioncategory


### <a name="BKMK_msdyn_UPCCode"></a> msdyn_UPCCode

**Added by**: Field Service Solution<br />
**Description**: Shows the UPC Code for product. Used for bar code scanning.<br />
**DisplayName**: UPC Code<br />
**LogicalName**: msdyn_upccode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Name"></a> Name

**Description**: Name of the product.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: True<br />
**MaxLength**: 100


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


### <a name="BKMK_ParentProductId"></a> ParentProductId

**Description**: Specifies the parent product family hierarchy.<br />
**DisplayName**: Parent<br />
**LogicalName**: parentproductid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_Price"></a> Price

**Description**: List price of the product.<br />
**DisplayName**: List Price<br />
**LogicalName**: price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_PriceLevelId"></a> PriceLevelId

**Description**: Select the default price list for the product.<br />
**DisplayName**: Default Price List<br />
**LogicalName**: pricelevelid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**IsValidForCreate**: False<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Unique identifier of the product.<br />
**DisplayName**: Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductNumber"></a> ProductNumber

**Description**: User-defined product ID.<br />
**DisplayName**: Product ID<br />
**LogicalName**: productnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ProductStructure"></a> ProductStructure

**Description**: Product Structure.<br />
**DisplayName**: Product Structure<br />
**LogicalName**: productstructure<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Product
- **Value**: 2 **Label**: Product Family
- **Value**: 3 **Label**: Product Bundle



### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

**Description**: Type of product.<br />
**DisplayName**: Product Type<br />
**LogicalName**: producttypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Sales Inventory
- **Value**: 2 **Label**: Miscellaneous Charges
- **Value**: 3 **Label**: Services
- **Value**: 4 **Label**: Flat Fees



### <a name="BKMK_ProductUrl"></a> ProductUrl

**Description**: URL for the Website associated with the product.<br />
**DisplayName**: URL<br />
**LogicalName**: producturl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 255


### <a name="BKMK_QuantityDecimal"></a> QuantityDecimal

**Description**: Number of decimal places that can be used in monetary amounts for the product.<br />
**DisplayName**: Decimals Supported<br />
**LogicalName**: quantitydecimal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 5<br />
**MinValue**: 0


### <a name="BKMK_QuantityOnHand"></a> QuantityOnHand

**Description**: Quantity of the product in stock.<br />
**DisplayName**: Quantity On Hand<br />
**LogicalName**: quantityonhand<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_Size"></a> Size

**Description**: Product size.<br />
**DisplayName**: Size<br />
**LogicalName**: size<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StandardCost"></a> StandardCost

**Description**: Standard cost of the product.<br />
**DisplayName**: Standard Cost<br />
**LogicalName**: standardcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the product.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Retired **DefaultStatus**: 2 **InvariantName**: Inactive
- **Value**: 2 **Label**: Draft **DefaultStatus**: 0 **InvariantName**: Draft
- **Value**: 3 **Label**: Under Revision **DefaultStatus**: 3 **InvariantName**: Under Revision



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the product.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Draft **State**: 2
- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Retired **State**: 1
- **Value**: 3 **Label**: Under Revision **State**: 3



### <a name="BKMK_StockVolume"></a> StockVolume

**Description**: Stock volume of the product.<br />
**DisplayName**: Stock Volume<br />
**LogicalName**: stockvolume<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_StockWeight"></a> StockWeight

**Description**: Stock weight of the product.<br />
**DisplayName**: Stock Weight<br />
**LogicalName**: stockweight<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_SubjectId"></a> SubjectId

**Description**: Select a category for the product.<br />
**DisplayName**: Subject<br />
**LogicalName**: subjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: subject


### <a name="BKMK_SupplierName"></a> SupplierName

**Description**: Name of the product's supplier.<br />
**DisplayName**: Supplier Name<br />
**LogicalName**: suppliername<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**MinValue**: -2147483648


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the product.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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
**MinValue**: -2147483648


### <a name="BKMK_ValidFromDate"></a> ValidFromDate

**Description**: Date from which this product is valid.<br />
**DisplayName**: Valid From<br />
**LogicalName**: validfromdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: DateOnly<br />
**Format**: DateOnly


### <a name="BKMK_ValidToDate"></a> ValidToDate

**Description**: Date to which this product is valid.<br />
**DisplayName**: Valid To<br />
**LogicalName**: validtodate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: DateOnly<br />
**Format**: DateOnly


### <a name="BKMK_VendorID"></a> VendorID

**Description**: Unique identifier of vendor supplying the product.<br />
**DisplayName**: Vendor ID<br />
**LogicalName**: vendorid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VendorName"></a> VendorName

**Description**: Name of the product vendor.<br />
**DisplayName**: Vendor<br />
**LogicalName**: vendorname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VendorPartNumber"></a> VendorPartNumber

**Description**: Unique part identifier in vendor catalog of this product.<br />
**DisplayName**: Vendor Name<br />
**LogicalName**: vendorpartnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CurrentCost_Base](#BKMK_CurrentCost_Base)
- [DefaultUoMIdName](#BKMK_DefaultUoMIdName)
- [DefaultUoMScheduleIdName](#BKMK_DefaultUoMScheduleIdName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [HierarchyPath](#BKMK_HierarchyPath)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_DefaultVendorName](#BKMK_msdyn_DefaultVendorName)
- [msdyn_DefaultVendorYomiName](#BKMK_msdyn_DefaultVendorYomiName)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ParentProductIdName](#BKMK_ParentProductIdName)
- [Price_Base](#BKMK_Price_Base)
- [PriceLevelIdName](#BKMK_PriceLevelIdName)
- [StandardCost_Base](#BKMK_StandardCost_Base)
- [SubjectIdName](#BKMK_SubjectIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the product.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

**Description**: Shows the external party who created the record.<br />
**DisplayName**: Created By (External Party)<br />
**LogicalName**: createdbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**RequiredLevel**: None<br />
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
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the product.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CurrentCost_Base"></a> CurrentCost_Base

**Description**: Value of the Current Cost in base currency.<br />
**DisplayName**: Current Cost (Base)<br />
**LogicalName**: currentcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


### <a name="BKMK_DefaultUoMIdName"></a> DefaultUoMIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: defaultuomidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DefaultUoMScheduleIdName"></a> DefaultUoMScheduleIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: defaultuomscheduleidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the product with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_HierarchyPath"></a> HierarchyPath

**Description**: Hierarchy path of the product.<br />
**DisplayName**: Hierarchy Path<br />
**LogicalName**: hierarchypath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the product.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

**Description**: Shows the external party who modified the record.<br />
**DisplayName**: Modified By (External Party)<br />
**LogicalName**: modifiedbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**RequiredLevel**: None<br />
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
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the product.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultVendorName"></a> msdyn_DefaultVendorName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultvendorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_DefaultVendorYomiName"></a> msdyn_DefaultVendorYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultvendoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_transactioncategoryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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


### <a name="BKMK_ParentProductIdName"></a> ParentProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentproductidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Price_Base"></a> Price_Base

**Description**: Value of the List Price in base currency.<br />
**DisplayName**: List Price (Base)<br />
**LogicalName**: price_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: pricelevelidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_StandardCost_Base"></a> StandardCost_Base

**Description**: Value of the Standard Cost in base currency.<br />
**DisplayName**: Standard Cost (Base)<br />
**LogicalName**: standardcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 1


### <a name="BKMK_SubjectIdName"></a> SubjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: subjectidname<br />
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

- [Product_SyncErrors](#BKMK_Product_SyncErrors)
- [Product_SharepointDocumentLocation](#BKMK_Product_SharepointDocumentLocation)
- [Product_SharepointDocument](#BKMK_Product_SharepointDocument)
- [Product_AsyncOperations](#BKMK_Product_AsyncOperations)
- [product_MailboxTrackingFolders](#BKMK_product_MailboxTrackingFolders)
- [userentityinstancedata_product](#BKMK_userentityinstancedata_product)
- [Product_ProcessSessions](#BKMK_Product_ProcessSessions)
- [Product_BulkDeleteFailures](#BKMK_Product_BulkDeleteFailures)
- [product_principalobjectattributeaccess](#BKMK_product_principalobjectattributeaccess)
- [product_connections1](#BKMK_product_connections1)
- [product_connections2](#BKMK_product_connections2)
- [Product_Annotation](#BKMK_Product_Annotation)
- [Product_DynamicProperty](#BKMK_Product_DynamicProperty)
- [Product_DynamicPropertyAssociation](#BKMK_Product_DynamicPropertyAssociation)
- [product_parent_product](#BKMK_product_parent_product)
- [Product_ProductAssociation_AssocProd](#BKMK_Product_ProductAssociation_AssocProd)
- [Product_ProductAssociation_Prod](#BKMK_Product_ProductAssociation_Prod)
- [product_ProductSubstitute_substitutedproductid](#BKMK_product_ProductSubstitute_substitutedproductid)
- [product_ProductSubstitute_productid](#BKMK_product_ProductSubstitute_productid)
- [product_price_levels](#BKMK_product_price_levels)
- [product_contract_line_items](#BKMK_product_contract_line_items)
- [product_incidents](#BKMK_product_incidents)
- [opportunity_products](#BKMK_opportunity_products)
- [product_invoice_details](#BKMK_product_invoice_details)
- [product_order_details](#BKMK_product_order_details)
- [product_quote_details](#BKMK_product_quote_details)
- [msdyn_product_msdyn_actual_Product](#BKMK_msdyn_product_msdyn_actual_Product)
- [msdyn_product_msdyn_estimateline_Product](#BKMK_msdyn_product_msdyn_estimateline_Product)
- [msdyn_product_msdyn_fact_Product](#BKMK_msdyn_product_msdyn_fact_Product)
- [msdyn_product_msdyn_fieldcomputation_ProductId](#BKMK_msdyn_product_msdyn_fieldcomputation_ProductId)
- [msdyn_product_msdyn_invoicelinetransaction_Product](#BKMK_msdyn_product_msdyn_invoicelinetransaction_Product)
- [msdyn_product_msdyn_journalline_Product](#BKMK_msdyn_product_msdyn_journalline_Product)
- [msdyn_product_msdyn_opportunitylinetransaction_Product](#BKMK_msdyn_product_msdyn_opportunitylinetransaction_Product)
- [msdyn_product_msdyn_orderlinetransaction_Product](#BKMK_msdyn_product_msdyn_orderlinetransaction_Product)
- [msdyn_product_msdyn_quotelinetransaction_Product](#BKMK_msdyn_product_msdyn_quotelinetransaction_Product)
- [msdyn_product_msdyn_agreementbookingproduct_Product](#BKMK_msdyn_product_msdyn_agreementbookingproduct_Product)
- [msdyn_product_msdyn_agreementbookingservice_Service](#BKMK_msdyn_product_msdyn_agreementbookingservice_Service)
- [msdyn_product_msdyn_agreementinvoiceproduct_Product](#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product)
- [msdyn_product_msdyn_customerasset_Product](#BKMK_msdyn_product_msdyn_customerasset_Product)
- [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService)
- [msdyn_product_msdyn_fieldservicesetting](#BKMK_msdyn_product_msdyn_fieldservicesetting)
- [msdyn_product_msdyn_incidenttypeproduct_Product](#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)
- [msdyn_product_msdyn_incidenttypeservice_Service](#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)
- [msdyn_product_msdyn_inventoryadjustmentproduct_Product](#BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product)
- [msdyn_product_msdyn_inventoryjournal_Product](#BKMK_msdyn_product_msdyn_inventoryjournal_Product)
- [msdyn_product_msdyn_orderinvoicingproduct_Product](#BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product)
- [msdyn_product_msdyn_productinventory_Product](#BKMK_msdyn_product_msdyn_productinventory_Product)
- [msdyn_product_msdyn_purchaseorderproduct_Product](#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product)
- [msdyn_product_msdyn_quotebookingproduct_Product](#BKMK_msdyn_product_msdyn_quotebookingproduct_Product)
- [msdyn_product_msdyn_quotebookingservice_Service](#BKMK_msdyn_product_msdyn_quotebookingservice_Service)
- [msdyn_product_msdyn_quoteinvoicingproduct_Product](#BKMK_msdyn_product_msdyn_quoteinvoicingproduct_Product)
- [msdyn_product_msdyn_rmaproduct_Product](#BKMK_msdyn_product_msdyn_rmaproduct_Product)
- [msdyn_product_msdyn_rtvproduct_Product](#BKMK_msdyn_product_msdyn_rtvproduct_Product)
- [msdyn_product_msdyn_workorderproduct_Product](#BKMK_msdyn_product_msdyn_workorderproduct_Product)
- [msdyn_product_msdyn_workorderservice_Service](#BKMK_msdyn_product_msdyn_workorderservice_Service)


### <a name="BKMK_Product_SyncErrors"></a> Product_SyncErrors

Same as syncerror entity [Product_SyncErrors](syncerror.md#BKMK_Product_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_SyncErrors<br />
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


### <a name="BKMK_Product_SharepointDocumentLocation"></a> Product_SharepointDocumentLocation

Same as sharepointdocumentlocation entity [Product_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Product_SharepointDocumentLocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_SharepointDocumentLocation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Product_SharepointDocument"></a> Product_SharepointDocument

Same as sharepointdocument entity [Product_SharepointDocument](sharepointdocument.md#BKMK_Product_SharepointDocument) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_SharepointDocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

Same as asyncoperation entity [Product_AsyncOperations](asyncoperation.md#BKMK_Product_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Product_AsyncOperations<br />
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


### <a name="BKMK_product_MailboxTrackingFolders"></a> product_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [product_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_product_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_product"></a> userentityinstancedata_product

Same as userentityinstancedata entity [userentityinstancedata_product](userentityinstancedata.md#BKMK_userentityinstancedata_product) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_product<br />
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


### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

Same as processsession entity [Product_ProcessSessions](processsession.md#BKMK_Product_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Product_ProcessSessions<br />
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


### <a name="BKMK_Product_BulkDeleteFailures"></a> Product_BulkDeleteFailures

Same as bulkdeletefailure entity [Product_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Product_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Product_BulkDeleteFailures<br />
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


### <a name="BKMK_product_principalobjectattributeaccess"></a> product_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [product_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_product_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: product_principalobjectattributeaccess<br />
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


### <a name="BKMK_product_connections1"></a> product_connections1

Same as connection entity [product_connections1](connection.md#BKMK_product_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_connections1<br />
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


### <a name="BKMK_product_connections2"></a> product_connections2

Same as connection entity [product_connections2](connection.md#BKMK_product_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_Product_Annotation"></a> Product_Annotation

Same as annotation entity [Product_Annotation](annotation.md#BKMK_Product_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Product_Annotation<br />
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


### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

Same as dynamicproperty entity [Product_DynamicProperty](dynamicproperty.md#BKMK_Product_DynamicProperty) Many-To-One relationship.

**ReferencingEntity**: dynamicproperty<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_DynamicProperty<br />
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


### <a name="BKMK_Product_DynamicPropertyAssociation"></a> Product_DynamicPropertyAssociation

Same as dynamicpropertyassociation entity [Product_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Product_DynamicPropertyAssociation) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyassociation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_DynamicPropertyAssociation<br />
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


### <a name="BKMK_product_parent_product"></a> product_parent_product

Same as product entity [product_parent_product](product.md#BKMK_product_parent_product) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: parentproductid<br />
**IsHierarchical**: True<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_parent_product<br />
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


### <a name="BKMK_Product_ProductAssociation_AssocProd"></a> Product_ProductAssociation_AssocProd

Same as productassociation entity [Product_ProductAssociation_AssocProd](productassociation.md#BKMK_Product_ProductAssociation_AssocProd) Many-To-One relationship.

**ReferencingEntity**: productassociation<br />
**ReferencingAttribute**: associatedproduct<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_ProductAssociation_AssocProd<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_Product_ProductAssociation_Prod"></a> Product_ProductAssociation_Prod

Same as productassociation entity [Product_ProductAssociation_Prod](productassociation.md#BKMK_Product_ProductAssociation_Prod) Many-To-One relationship.

**ReferencingEntity**: productassociation<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Product_ProductAssociation_Prod<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_product_ProductSubstitute_substitutedproductid"></a> product_ProductSubstitute_substitutedproductid

Same as productsubstitute entity [product_ProductSubstitute_substitutedproductid](productsubstitute.md#BKMK_product_ProductSubstitute_substitutedproductid) Many-To-One relationship.

**ReferencingEntity**: productsubstitute<br />
**ReferencingAttribute**: substitutedproductid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_ProductSubstitute_substitutedproductid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_product_ProductSubstitute_productid"></a> product_ProductSubstitute_productid

Same as productsubstitute entity [product_ProductSubstitute_productid](productsubstitute.md#BKMK_product_ProductSubstitute_productid) Many-To-One relationship.

**ReferencingEntity**: productsubstitute<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_ProductSubstitute_productid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_product_price_levels"></a> product_price_levels

Same as productpricelevel entity [product_price_levels](productpricelevel.md#BKMK_product_price_levels) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: product_price_levels<br />
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


### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

Same as contractdetail entity [product_contract_line_items](contractdetail.md#BKMK_product_contract_line_items) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_contract_line_items<br />
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


### <a name="BKMK_product_incidents"></a> product_incidents

Same as incident entity [product_incidents](incident.md#BKMK_product_incidents) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_incidents<br />
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


### <a name="BKMK_opportunity_products"></a> opportunity_products

Same as opportunityproduct entity [opportunity_products](opportunityproduct.md#BKMK_opportunity_products) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunity_products<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_product_invoice_details"></a> product_invoice_details

Same as invoicedetail entity [product_invoice_details](invoicedetail.md#BKMK_product_invoice_details) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_invoice_details<br />
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


### <a name="BKMK_product_order_details"></a> product_order_details

Same as salesorderdetail entity [product_order_details](salesorderdetail.md#BKMK_product_order_details) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_order_details<br />
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


### <a name="BKMK_product_quote_details"></a> product_quote_details

Same as quotedetail entity [product_quote_details](quotedetail.md#BKMK_product_quote_details) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: product_quote_details<br />
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


### <a name="BKMK_msdyn_product_msdyn_actual_Product"></a> msdyn_product_msdyn_actual_Product

Same as msdyn_actual entity [msdyn_product_msdyn_actual_Product](msdyn_actual.md#BKMK_msdyn_product_msdyn_actual_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_actual_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_estimateline_Product"></a> msdyn_product_msdyn_estimateline_Product

Same as msdyn_estimateline entity [msdyn_product_msdyn_estimateline_Product](msdyn_estimateline.md#BKMK_msdyn_product_msdyn_estimateline_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_estimateline_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_fact_Product"></a> msdyn_product_msdyn_fact_Product

Same as msdyn_fact entity [msdyn_product_msdyn_fact_Product](msdyn_fact.md#BKMK_msdyn_product_msdyn_fact_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_fact_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_fieldcomputation_ProductId"></a> msdyn_product_msdyn_fieldcomputation_ProductId

Same as msdyn_fieldcomputation entity [msdyn_product_msdyn_fieldcomputation_ProductId](msdyn_fieldcomputation.md#BKMK_msdyn_product_msdyn_fieldcomputation_ProductId) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldcomputation<br />
**ReferencingAttribute**: msdyn_productid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_fieldcomputation_ProductId<br />
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


### <a name="BKMK_msdyn_product_msdyn_invoicelinetransaction_Product"></a> msdyn_product_msdyn_invoicelinetransaction_Product

Same as msdyn_invoicelinetransaction entity [msdyn_product_msdyn_invoicelinetransaction_Product](msdyn_invoicelinetransaction.md#BKMK_msdyn_product_msdyn_invoicelinetransaction_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_invoicelinetransaction_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_journalline_Product"></a> msdyn_product_msdyn_journalline_Product

Same as msdyn_journalline entity [msdyn_product_msdyn_journalline_Product](msdyn_journalline.md#BKMK_msdyn_product_msdyn_journalline_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_journalline_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_opportunitylinetransaction_Product"></a> msdyn_product_msdyn_opportunitylinetransaction_Product

Same as msdyn_opportunitylinetransaction entity [msdyn_product_msdyn_opportunitylinetransaction_Product](msdyn_opportunitylinetransaction.md#BKMK_msdyn_product_msdyn_opportunitylinetransaction_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_opportunitylinetransaction_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_orderlinetransaction_Product"></a> msdyn_product_msdyn_orderlinetransaction_Product

Same as msdyn_orderlinetransaction entity [msdyn_product_msdyn_orderlinetransaction_Product](msdyn_orderlinetransaction.md#BKMK_msdyn_product_msdyn_orderlinetransaction_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_orderlinetransaction_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_quotelinetransaction_Product"></a> msdyn_product_msdyn_quotelinetransaction_Product

Same as msdyn_quotelinetransaction entity [msdyn_product_msdyn_quotelinetransaction_Product](msdyn_quotelinetransaction.md#BKMK_msdyn_product_msdyn_quotelinetransaction_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_quotelinetransaction_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_product_msdyn_agreementbookingproduct_Product"></a> msdyn_product_msdyn_agreementbookingproduct_Product

Same as msdyn_agreementbookingproduct entity [msdyn_product_msdyn_agreementbookingproduct_Product](msdyn_agreementbookingproduct.md#BKMK_msdyn_product_msdyn_agreementbookingproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_agreementbookingproduct_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Product
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_product_msdyn_agreementbookingservice_Service"></a> msdyn_product_msdyn_agreementbookingservice_Service

Same as msdyn_agreementbookingservice entity [msdyn_product_msdyn_agreementbookingservice_Service](msdyn_agreementbookingservice.md#BKMK_msdyn_product_msdyn_agreementbookingservice_Service) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_service<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_agreementbookingservice_Service<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Service
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product"></a> msdyn_product_msdyn_agreementinvoiceproduct_Product

Same as msdyn_agreementinvoiceproduct entity [msdyn_product_msdyn_agreementinvoiceproduct_Product](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_agreementinvoiceproduct_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Product
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

Same as msdyn_customerasset entity [msdyn_product_msdyn_customerasset_Product](msdyn_customerasset.md#BKMK_msdyn_product_msdyn_customerasset_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_customerasset_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService"></a> msdyn_product_msdyn_fieldservicepricelistitem_ProductService

Same as msdyn_fieldservicepricelistitem entity [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicepricelistitem<br />
**ReferencingAttribute**: msdyn_productservice<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_fieldservicepricelistitem_ProductService<br />
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


### <a name="BKMK_msdyn_product_msdyn_fieldservicesetting"></a> msdyn_product_msdyn_fieldservicesetting

Same as msdyn_fieldservicesetting entity [msdyn_product_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_msdyn_product_msdyn_fieldservicesetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicesetting<br />
**ReferencingAttribute**: msdyn_travelchargeitemid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_fieldservicesetting<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Travel Charge Item
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_product_msdyn_incidenttypeproduct_Product"></a> msdyn_product_msdyn_incidenttypeproduct_Product

Same as msdyn_incidenttypeproduct entity [msdyn_product_msdyn_incidenttypeproduct_Product](msdyn_incidenttypeproduct.md#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_incidenttypeproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_incidenttypeservice_Service"></a> msdyn_product_msdyn_incidenttypeservice_Service

Same as msdyn_incidenttypeservice entity [msdyn_product_msdyn_incidenttypeservice_Service](msdyn_incidenttypeservice.md#BKMK_msdyn_product_msdyn_incidenttypeservice_Service) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservice<br />
**ReferencingAttribute**: msdyn_service<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_incidenttypeservice_Service<br />
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


### <a name="BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product"></a> msdyn_product_msdyn_inventoryadjustmentproduct_Product

Same as msdyn_inventoryadjustmentproduct entity [msdyn_product_msdyn_inventoryadjustmentproduct_Product](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustmentproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_inventoryadjustmentproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_inventoryjournal_Product"></a> msdyn_product_msdyn_inventoryjournal_Product

Same as msdyn_inventoryjournal entity [msdyn_product_msdyn_inventoryjournal_Product](msdyn_inventoryjournal.md#BKMK_msdyn_product_msdyn_inventoryjournal_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_inventoryjournal_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product"></a> msdyn_product_msdyn_orderinvoicingproduct_Product

Same as msdyn_orderinvoicingproduct entity [msdyn_product_msdyn_orderinvoicingproduct_Product](msdyn_orderinvoicingproduct.md#BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_orderinvoicingproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_productinventory_Product"></a> msdyn_product_msdyn_productinventory_Product

Same as msdyn_productinventory entity [msdyn_product_msdyn_productinventory_Product](msdyn_productinventory.md#BKMK_msdyn_product_msdyn_productinventory_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_productinventory<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_productinventory_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_product_msdyn_purchaseorderproduct_Product"></a> msdyn_product_msdyn_purchaseorderproduct_Product

Same as msdyn_purchaseorderproduct entity [msdyn_product_msdyn_purchaseorderproduct_Product](msdyn_purchaseorderproduct.md#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_purchaseorderproduct_Product<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Product
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_product_msdyn_quotebookingproduct_Product"></a> msdyn_product_msdyn_quotebookingproduct_Product

Same as msdyn_quotebookingproduct entity [msdyn_product_msdyn_quotebookingproduct_Product](msdyn_quotebookingproduct.md#BKMK_msdyn_product_msdyn_quotebookingproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_quotebookingproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_quotebookingservice_Service"></a> msdyn_product_msdyn_quotebookingservice_Service

Same as msdyn_quotebookingservice entity [msdyn_product_msdyn_quotebookingservice_Service](msdyn_quotebookingservice.md#BKMK_msdyn_product_msdyn_quotebookingservice_Service) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_service<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_quotebookingservice_Service<br />
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


### <a name="BKMK_msdyn_product_msdyn_quoteinvoicingproduct_Product"></a> msdyn_product_msdyn_quoteinvoicingproduct_Product

Same as msdyn_quoteinvoicingproduct entity [msdyn_product_msdyn_quoteinvoicingproduct_Product](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_product_msdyn_quoteinvoicingproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_quoteinvoicingproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_rmaproduct_Product"></a> msdyn_product_msdyn_rmaproduct_Product

Same as msdyn_rmaproduct entity [msdyn_product_msdyn_rmaproduct_Product](msdyn_rmaproduct.md#BKMK_msdyn_product_msdyn_rmaproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_rmaproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_rtvproduct_Product"></a> msdyn_product_msdyn_rtvproduct_Product

Same as msdyn_rtvproduct entity [msdyn_product_msdyn_rtvproduct_Product](msdyn_rtvproduct.md#BKMK_msdyn_product_msdyn_rtvproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_rtvproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

Same as msdyn_workorderproduct entity [msdyn_product_msdyn_workorderproduct_Product](msdyn_workorderproduct.md#BKMK_msdyn_product_msdyn_workorderproduct_Product) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_product<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_workorderproduct_Product<br />
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


### <a name="BKMK_msdyn_product_msdyn_workorderservice_Service"></a> msdyn_product_msdyn_workorderservice_Service

Same as msdyn_workorderservice entity [msdyn_product_msdyn_workorderservice_Service](msdyn_workorderservice.md#BKMK_msdyn_product_msdyn_workorderservice_Service) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_service<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_product_msdyn_workorderservice_Service<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_productbase_createdby](#BKMK_lk_productbase_createdby)
- [lk_product_createdonbehalfby](#BKMK_lk_product_createdonbehalfby)
- [lk_productbase_modifiedby](#BKMK_lk_productbase_modifiedby)
- [lk_product_modifiedonbehalfby](#BKMK_lk_product_modifiedonbehalfby)
- [organization_products](#BKMK_organization_products)
- [processstage_products](#BKMK_processstage_products)
- [transactioncurrency_product](#BKMK_transactioncurrency_product)
- [lk_externalparty_product_createdby](#BKMK_lk_externalparty_product_createdby)
- [lk_externalparty_product_modifiedby](#BKMK_lk_externalparty_product_modifiedby)
- [price_level_products](#BKMK_price_level_products)
- [product_parent_product](#BKMK_product_parent_product)
- [subject_products](#BKMK_subject_products)
- [unit_of_measurement_products](#BKMK_unit_of_measurement_products)
- [unit_of_measurement_schedule_products](#BKMK_unit_of_measurement_schedule_products)
- [msdyn_msdyn_transactioncategory_product_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory)
- [msdyn_account_product_DefaultVendor](#BKMK_msdyn_account_product_DefaultVendor)


### <a name="BKMK_lk_productbase_createdby"></a> lk_productbase_createdby

See systemuser Entity [lk_productbase_createdby](systemuser.md#BKMK_lk_productbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_product_createdonbehalfby"></a> lk_product_createdonbehalfby

See systemuser Entity [lk_product_createdonbehalfby](systemuser.md#BKMK_lk_product_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_productbase_modifiedby"></a> lk_productbase_modifiedby

See systemuser Entity [lk_productbase_modifiedby](systemuser.md#BKMK_lk_productbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_product_modifiedonbehalfby"></a> lk_product_modifiedonbehalfby

See systemuser Entity [lk_product_modifiedonbehalfby](systemuser.md#BKMK_lk_product_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_products"></a> organization_products

See organization Entity [organization_products](organization.md#BKMK_organization_products) One-To-Many relationship.

### <a name="BKMK_processstage_products"></a> processstage_products

See processstage Entity [processstage_products](processstage.md#BKMK_processstage_products) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

See transactioncurrency Entity [transactioncurrency_product](transactioncurrency.md#BKMK_transactioncurrency_product) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_product_createdby"></a> lk_externalparty_product_createdby

See externalparty Entity [lk_externalparty_product_createdby](externalparty.md#BKMK_lk_externalparty_product_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_product_modifiedby"></a> lk_externalparty_product_modifiedby

See externalparty Entity [lk_externalparty_product_modifiedby](externalparty.md#BKMK_lk_externalparty_product_modifiedby) One-To-Many relationship.

### <a name="BKMK_price_level_products"></a> price_level_products

See pricelevel Entity [price_level_products](pricelevel.md#BKMK_price_level_products) One-To-Many relationship.

### <a name="BKMK_product_parent_product"></a> product_parent_product

See product Entity [product_parent_product](product.md#BKMK_product_parent_product) One-To-Many relationship.

### <a name="BKMK_subject_products"></a> subject_products

See subject Entity [subject_products](subject.md#BKMK_subject_products) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

See uom Entity [unit_of_measurement_products](uom.md#BKMK_unit_of_measurement_products) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_schedule_products"></a> unit_of_measurement_schedule_products

See uomschedule Entity [unit_of_measurement_schedule_products](uomschedule.md#BKMK_unit_of_measurement_schedule_products) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory"></a> msdyn_msdyn_transactioncategory_product_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_product_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_account_product_DefaultVendor"></a> msdyn_account_product_DefaultVendor

See account Entity [msdyn_account_product_DefaultVendor](account.md#BKMK_msdyn_account_product_DefaultVendor) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Product entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaignproduct_association](#BKMK_campaignproduct_association)
- [product_entitlement_association](#BKMK_product_entitlement_association)
- [product_entitlementtemplate_association](#BKMK_product_entitlementtemplate_association)
- [leadproduct_association](#BKMK_leadproduct_association)
- [productsalesliterature_association](#BKMK_productsalesliterature_association)
- [competitorproduct_association](#BKMK_competitorproduct_association)


### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

See campaign Entity [campaignproduct_association](campaign.md#BKMK_campaignproduct_association) Many-To-Many Relationship.

### <a name="BKMK_product_entitlement_association"></a> product_entitlement_association

**IntersectEntityName**: entitlementproducts<br />
**Entity1LogicalName**: product<br />

- **Entity1IntersectAttribute**: productid
- **Entity1NavigationPropertyName**: product_entitlement_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [entitlement](entitlement.md)<br />

- **Entity2IntersectAttribute**: entitlementid
- **Entity2NavigationPropertyName**: product_entitlement_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

**IntersectEntityName**: entitlementtemplateproducts<br />
**Entity1LogicalName**: product<br />

- **Entity1IntersectAttribute**: productid
- **Entity1NavigationPropertyName**: product_entitlementtemplate_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [entitlementtemplate](entitlementtemplate.md)<br />

- **Entity2IntersectAttribute**: entitlementtemplateid
- **Entity2NavigationPropertyName**: product_entitlementtemplate_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_leadproduct_association"></a> leadproduct_association

See lead Entity [leadproduct_association](lead.md#BKMK_leadproduct_association) Many-To-Many Relationship.

### <a name="BKMK_productsalesliterature_association"></a> productsalesliterature_association

**IntersectEntityName**: productsalesliterature<br />
**Entity1LogicalName**: product<br />

- **Entity1IntersectAttribute**: productid
- **Entity1NavigationPropertyName**: productsalesliterature_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [salesliterature](salesliterature.md)<br />

- **Entity2IntersectAttribute**: salesliteratureid
- **Entity2NavigationPropertyName**: productsalesliterature_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_competitorproduct_association"></a> competitorproduct_association

See competitor Entity [competitorproduct_association](competitor.md#BKMK_competitorproduct_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.product?text=product EntityType" />