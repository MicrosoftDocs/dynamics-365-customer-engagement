---
title: "Product Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Product entity."
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
# Product Entity Reference

Information about products and their pricing information.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Associate|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|CloneProduct|<xref href="Microsoft.Dynamics.CRM.CloneProduct?text=CloneProduct Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneProductRequest>|
|Create|POST [*org URI*]/api/data/v9.0/products<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|PublishProductHierarchy|<xref href="Microsoft.Dynamics.CRM.PublishProductHierarchy?text=PublishProductHierarchy Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/products<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RevertProduct|<xref href="Microsoft.Dynamics.CRM.RevertProduct?text=RevertProduct Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevertProductRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/products(*productid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/products(*productid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Products|
|DisplayCollectionName|Products|
|DisplayName|Product|
|EntitySetName|products|
|IsBPFEntity|False|
|LogicalCollectionName|products|
|LogicalName|product|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|productid|
|PrimaryNameAttribute|name|
|SchemaName|Product|

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
- [IsReparented](#BKMK_IsReparented)
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

|Property|Value|
|--------|-----|
|Description|Current cost for the product item. Used in price calculations.|
|DisplayName|Current Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currentcost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DefaultUoMId"></a> DefaultUoMId

|Property|Value|
|--------|-----|
|Description|Default unit for the product.|
|DisplayName|Default Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultuomid|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_DefaultUoMScheduleId"></a> DefaultUoMScheduleId

|Property|Value|
|--------|-----|
|Description|Default unit group for the product.|
|DisplayName|Unit Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultuomscheduleid|
|RequiredLevel|ApplicationRequired|
|Targets|uomschedule|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the product.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DMTImportState"></a> DMTImportState

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Internal Use Only|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|dmtimportstate|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_EntityImage"></a> EntityImage

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the default image for the record.|
|DisplayName|Entity Image|
|IsPrimaryImage|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


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


### <a name="BKMK_IsKit"></a> IsKit

|Property|Value|
|--------|-----|
|Description|Information that specifies whether the product is a kit.|
|DisplayName|Is Kit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|iskit|
|RequiredLevel|None|
|Type|Boolean|

#### IsKit Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsReparented"></a> IsReparented

**Added by**: Product Management Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Reparented|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isreparented|
|RequiredLevel|None|
|Type|Boolean|

#### IsReparented Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsStockItem"></a> IsStockItem

|Property|Value|
|--------|-----|
|Description|Information about whether the product is a stock item.|
|DisplayName|Stock Item|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isstockitem|
|RequiredLevel|None|
|Type|Boolean|

#### IsStockItem Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_ConvertToCustomerAsset"></a> msdyn_ConvertToCustomerAsset

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Specify whether a product is to be converted to a customer asset. When a product is used on a work order, the system will automatically convert it into a customer asset when the work order is closed.|
|DisplayName|Convert to Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_converttocustomerasset|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_ConvertToCustomerAsset Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_DefaultVendor"></a> msdyn_DefaultVendor

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Default vendor that supplies this product|
|DisplayName|Default Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultvendor|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_FieldServiceProductType"></a> msdyn_FieldServiceProductType

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Field Service Product Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_fieldserviceproducttype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_FieldServiceProductType Options

|Value|Label|
|-----|-----|
|690970000|Inventory|
|690970001|Non-Inventory|
|690970002|Service|



### <a name="BKMK_msdyn_PurchaseName"></a> msdyn_PurchaseName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Type the name for the product when used on a purchase order.|
|DisplayName|Purchase Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchasename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Select whether the item is taxable. If an item is set as not taxable, it won't be taxable even on a taxable work order.|
|DisplayName|Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_Taxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description|Select the transaction category for this product.|
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_UPCCode"></a> msdyn_UPCCode

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Shows the UPC Code for product. Used for bar code scanning.|
|DisplayName|UPC Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_upccode|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the product.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


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


### <a name="BKMK_ParentProductId"></a> ParentProductId

|Property|Value|
|--------|-----|
|Description|Specifies the parent product family hierarchy.|
|DisplayName|Parent|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|parentproductid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_Price"></a> Price

|Property|Value|
|--------|-----|
|Description|List price of the product.|
|DisplayName|List Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|price|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Select the default price list for the product.|
|DisplayName|Default Price List|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pricelevelid|
|RequiredLevel|Recommended|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the product.|
|DisplayName|Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|productid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ProductNumber"></a> ProductNumber

|Property|Value|
|--------|-----|
|Description|User-defined product ID.|
|DisplayName|Product ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productnumber|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ProductStructure"></a> ProductStructure

|Property|Value|
|--------|-----|
|Description|Product Structure.|
|DisplayName|Product Structure|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|productstructure|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ProductStructure Options

|Value|Label|
|-----|-----|
|1|Product|
|2|Product Family|
|3|Product Bundle|



### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

|Property|Value|
|--------|-----|
|Description|Type of product.|
|DisplayName|Product Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|producttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### ProductTypeCode Options

|Value|Label|
|-----|-----|
|1|Sales Inventory|
|2|Miscellaneous Charges|
|3|Services|
|4|Flat Fees|



### <a name="BKMK_ProductUrl"></a> ProductUrl

|Property|Value|
|--------|-----|
|Description|URL for the Website associated with the product.|
|DisplayName|URL|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|producturl|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_QuantityDecimal"></a> QuantityDecimal

|Property|Value|
|--------|-----|
|Description|Number of decimal places that can be used in monetary amounts for the product.|
|DisplayName|Decimals Supported|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantitydecimal|
|MaxValue|5|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_QuantityOnHand"></a> QuantityOnHand

|Property|Value|
|--------|-----|
|Description|Quantity of the product in stock.|
|DisplayName|Quantity On Hand|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quantityonhand|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_Size"></a> Size

|Property|Value|
|--------|-----|
|Description|Product size.|
|DisplayName|Size|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|size|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StandardCost"></a> StandardCost

|Property|Value|
|--------|-----|
|Description|Standard cost of the product.|
|DisplayName|Standard Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|standardcost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the product.|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Retired|2|Inactive|
|2|Draft|0|Draft|
|3|Under Revision|3|Under Revision|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the product.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|0|Draft|2|
|1|Active|0|
|2|Retired|1|
|3|Under Revision|3|



### <a name="BKMK_StockVolume"></a> StockVolume

|Property|Value|
|--------|-----|
|Description|Stock volume of the product.|
|DisplayName|Stock Volume|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stockvolume|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_StockWeight"></a> StockWeight

|Property|Value|
|--------|-----|
|Description|Stock weight of the product.|
|DisplayName|Stock Weight|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stockweight|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_SubjectId"></a> SubjectId

|Property|Value|
|--------|-----|
|Description|Select a category for the product.|
|DisplayName|Subject|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subjectid|
|RequiredLevel|None|
|Targets|subject|
|Type|Lookup|


### <a name="BKMK_SupplierName"></a> SupplierName

|Property|Value|
|--------|-----|
|Description|Name of the product's supplier.|
|DisplayName|Supplier Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|suppliername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the product.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_ValidFromDate"></a> ValidFromDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Date from which this product is valid.|
|DisplayName|Valid From|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|validfromdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ValidToDate"></a> ValidToDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Date to which this product is valid.|
|DisplayName|Valid To|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|validtodate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_VendorID"></a> VendorID

|Property|Value|
|--------|-----|
|Description|Unique identifier of vendor supplying the product.|
|DisplayName|Vendor ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|vendorid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VendorName"></a> VendorName

|Property|Value|
|--------|-----|
|Description|Name of the product vendor.|
|DisplayName|Vendor|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|vendorname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VendorPartNumber"></a> VendorPartNumber

|Property|Value|
|--------|-----|
|Description|Unique part identifier in vendor catalog of this product.|
|DisplayName|Vendor Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|vendorpartnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the product.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who created the record.|
|DisplayName|Created By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByName"></a> CreatedByName

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
|RequiredLevel|None|
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the product.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CurrentCost_Base"></a> CurrentCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Current Cost in base currency.|
|DisplayName|Current Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currentcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DefaultUoMIdName"></a> DefaultUoMIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultuomidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_DefaultUoMScheduleIdName"></a> DefaultUoMScheduleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultuomscheduleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the product with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_HierarchyPath"></a> HierarchyPath

|Property|Value|
|--------|-----|
|Description|Hierarchy path of the product.|
|DisplayName|Hierarchy Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hierarchypath|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the product.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who modified the record.|
|DisplayName|Modified By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

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
|RequiredLevel|None|
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the product.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultVendorName"></a> msdyn_DefaultVendorName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultvendorname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultVendorYomiName"></a> msdyn_DefaultVendorYomiName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultvendoryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

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


### <a name="BKMK_ParentProductIdName"></a> ParentProductIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentproductidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Price_Base"></a> Price_Base

|Property|Value|
|--------|-----|
|Description|Value of the List Price in base currency.|
|DisplayName|List Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|price_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelevelidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_StandardCost_Base"></a> StandardCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Standard Cost in base currency.|
|DisplayName|Standard Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|standardcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_SubjectIdName"></a> SubjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|subjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

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

- [Product_SyncErrors](#BKMK_Product_SyncErrors)
- [Product_SharepointDocumentLocation](#BKMK_Product_SharepointDocumentLocation)
- [Product_AsyncOperations](#BKMK_Product_AsyncOperations)
- [product_MailboxTrackingFolders](#BKMK_product_MailboxTrackingFolders)
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

**Added by**: System Solution Solution

Same as syncerror entity [Product_SyncErrors](syncerror.md#BKMK_Product_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Product_SharepointDocumentLocation"></a> Product_SharepointDocumentLocation

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [Product_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Product_SharepointDocumentLocation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_SharepointDocumentLocation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [Product_AsyncOperations](asyncoperation.md#BKMK_Product_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Product_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_MailboxTrackingFolders"></a> product_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [product_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_product_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [Product_ProcessSessions](processsession.md#BKMK_Product_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Product_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_BulkDeleteFailures"></a> Product_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [Product_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Product_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Product_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_principalobjectattributeaccess"></a> product_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [product_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_product_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|product_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_connections1"></a> product_connections1

**Added by**: System Solution Solution

Same as connection entity [product_connections1](connection.md#BKMK_product_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_connections2"></a> product_connections2

**Added by**: System Solution Solution

Same as connection entity [product_connections2](connection.md#BKMK_product_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_Annotation"></a> Product_Annotation

**Added by**: System Solution Solution

Same as annotation entity [Product_Annotation](annotation.md#BKMK_Product_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Product_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

Same as dynamicproperty entity [Product_DynamicProperty](dynamicproperty.md#BKMK_Product_DynamicProperty) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicproperty|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_DynamicProperty|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_DynamicPropertyAssociation"></a> Product_DynamicPropertyAssociation

Same as dynamicpropertyassociation entity [Product_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Product_DynamicPropertyAssociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyassociation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_DynamicPropertyAssociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_parent_product"></a> product_parent_product

Same as product entity [product_parent_product](product.md#BKMK_product_parent_product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|parentproductid|
|IsHierarchical|True|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_parent_product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_ProductAssociation_AssocProd"></a> Product_ProductAssociation_AssocProd

Same as productassociation entity [Product_ProductAssociation_AssocProd](productassociation.md#BKMK_Product_ProductAssociation_AssocProd) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productassociation|
|ReferencingAttribute|associatedproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_ProductAssociation_AssocProd|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Product_ProductAssociation_Prod"></a> Product_ProductAssociation_Prod

Same as productassociation entity [Product_ProductAssociation_Prod](productassociation.md#BKMK_Product_ProductAssociation_Prod) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productassociation|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Product_ProductAssociation_Prod|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_ProductSubstitute_substitutedproductid"></a> product_ProductSubstitute_substitutedproductid

Same as productsubstitute entity [product_ProductSubstitute_substitutedproductid](productsubstitute.md#BKMK_product_ProductSubstitute_substitutedproductid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productsubstitute|
|ReferencingAttribute|substitutedproductid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_ProductSubstitute_substitutedproductid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_ProductSubstitute_productid"></a> product_ProductSubstitute_productid

Same as productsubstitute entity [product_ProductSubstitute_productid](productsubstitute.md#BKMK_product_ProductSubstitute_productid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productsubstitute|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_ProductSubstitute_productid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_price_levels"></a> product_price_levels

Same as productpricelevel entity [product_price_levels](productpricelevel.md#BKMK_product_price_levels) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|product_price_levels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

**Added by**: Service Solution

Same as contractdetail entity [product_contract_line_items](contractdetail.md#BKMK_product_contract_line_items) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_contract_line_items|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_incidents"></a> product_incidents

**Added by**: Service Solution

Same as incident entity [product_incidents](incident.md#BKMK_product_incidents) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_incidents|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunity_products"></a> opportunity_products

**Added by**: Sales Solution

Same as opportunityproduct entity [opportunity_products](opportunityproduct.md#BKMK_opportunity_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_invoice_details"></a> product_invoice_details

**Added by**: Sales Solution

Same as invoicedetail entity [product_invoice_details](invoicedetail.md#BKMK_product_invoice_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_invoice_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_order_details"></a> product_order_details

**Added by**: Sales Solution

Same as salesorderdetail entity [product_order_details](salesorderdetail.md#BKMK_product_order_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_order_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_quote_details"></a> product_quote_details

**Added by**: Sales Solution

Same as quotedetail entity [product_quote_details](quotedetail.md#BKMK_product_quote_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_quote_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_actual_Product"></a> msdyn_product_msdyn_actual_Product

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_actual entity [msdyn_product_msdyn_actual_Product](msdyn_actual.md#BKMK_msdyn_product_msdyn_actual_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_actual_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_estimateline_Product"></a> msdyn_product_msdyn_estimateline_Product

**Added by**: Project Service Automation Solution

Same as msdyn_estimateline entity [msdyn_product_msdyn_estimateline_Product](msdyn_estimateline.md#BKMK_msdyn_product_msdyn_estimateline_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_estimateline_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_fact_Product"></a> msdyn_product_msdyn_fact_Product

**Added by**: Project Service Automation Solution

Same as msdyn_fact entity [msdyn_product_msdyn_fact_Product](msdyn_fact.md#BKMK_msdyn_product_msdyn_fact_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_fact_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_fieldcomputation_ProductId"></a> msdyn_product_msdyn_fieldcomputation_ProductId

**Added by**: Project Service Automation Solution

Same as msdyn_fieldcomputation entity [msdyn_product_msdyn_fieldcomputation_ProductId](msdyn_fieldcomputation.md#BKMK_msdyn_product_msdyn_fieldcomputation_ProductId) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldcomputation|
|ReferencingAttribute|msdyn_productid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_fieldcomputation_ProductId|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_invoicelinetransaction_Product"></a> msdyn_product_msdyn_invoicelinetransaction_Product

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_product_msdyn_invoicelinetransaction_Product](msdyn_invoicelinetransaction.md#BKMK_msdyn_product_msdyn_invoicelinetransaction_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_invoicelinetransaction_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_journalline_Product"></a> msdyn_product_msdyn_journalline_Product

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_product_msdyn_journalline_Product](msdyn_journalline.md#BKMK_msdyn_product_msdyn_journalline_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_journalline_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_opportunitylinetransaction_Product"></a> msdyn_product_msdyn_opportunitylinetransaction_Product

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylinetransaction entity [msdyn_product_msdyn_opportunitylinetransaction_Product](msdyn_opportunitylinetransaction.md#BKMK_msdyn_product_msdyn_opportunitylinetransaction_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_opportunitylinetransaction_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_orderlinetransaction_Product"></a> msdyn_product_msdyn_orderlinetransaction_Product

**Added by**: Project Service Automation Solution

Same as msdyn_orderlinetransaction entity [msdyn_product_msdyn_orderlinetransaction_Product](msdyn_orderlinetransaction.md#BKMK_msdyn_product_msdyn_orderlinetransaction_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_orderlinetransaction_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_quotelinetransaction_Product"></a> msdyn_product_msdyn_quotelinetransaction_Product

**Added by**: Project Service Automation Solution

Same as msdyn_quotelinetransaction entity [msdyn_product_msdyn_quotelinetransaction_Product](msdyn_quotelinetransaction.md#BKMK_msdyn_product_msdyn_quotelinetransaction_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_quotelinetransaction_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_agreementbookingproduct_Product"></a> msdyn_product_msdyn_agreementbookingproduct_Product

**Added by**: Field Service Solution

Same as msdyn_agreementbookingproduct entity [msdyn_product_msdyn_agreementbookingproduct_Product](msdyn_agreementbookingproduct.md#BKMK_msdyn_product_msdyn_agreementbookingproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_agreementbookingproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Product<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_agreementbookingservice_Service"></a> msdyn_product_msdyn_agreementbookingservice_Service

**Added by**: Field Service Solution

Same as msdyn_agreementbookingservice entity [msdyn_product_msdyn_agreementbookingservice_Service](msdyn_agreementbookingservice.md#BKMK_msdyn_product_msdyn_agreementbookingservice_Service) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_service|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_agreementbookingservice_Service|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Service<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product"></a> msdyn_product_msdyn_agreementinvoiceproduct_Product

**Added by**: Field Service Solution

Same as msdyn_agreementinvoiceproduct entity [msdyn_product_msdyn_agreementinvoiceproduct_Product](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_product_msdyn_agreementinvoiceproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_agreementinvoiceproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Product<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

**Added by**: Field Service Solution

Same as msdyn_customerasset entity [msdyn_product_msdyn_customerasset_Product](msdyn_customerasset.md#BKMK_msdyn_product_msdyn_customerasset_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_customerasset_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService"></a> msdyn_product_msdyn_fieldservicepricelistitem_ProductService

**Added by**: Field Service Solution

Same as msdyn_fieldservicepricelistitem entity [msdyn_product_msdyn_fieldservicepricelistitem_ProductService](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_product_msdyn_fieldservicepricelistitem_ProductService) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicepricelistitem|
|ReferencingAttribute|msdyn_productservice|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_fieldservicepricelistitem_ProductService|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_fieldservicesetting"></a> msdyn_product_msdyn_fieldservicesetting

**Added by**: Field Service Solution

Same as msdyn_fieldservicesetting entity [msdyn_product_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_msdyn_product_msdyn_fieldservicesetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_travelchargeitemid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_fieldservicesetting|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Travel Charge Item<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_incidenttypeproduct_Product"></a> msdyn_product_msdyn_incidenttypeproduct_Product

**Added by**: Field Service Solution

Same as msdyn_incidenttypeproduct entity [msdyn_product_msdyn_incidenttypeproduct_Product](msdyn_incidenttypeproduct.md#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_incidenttypeproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_incidenttypeservice_Service"></a> msdyn_product_msdyn_incidenttypeservice_Service

**Added by**: Field Service Solution

Same as msdyn_incidenttypeservice entity [msdyn_product_msdyn_incidenttypeservice_Service](msdyn_incidenttypeservice.md#BKMK_msdyn_product_msdyn_incidenttypeservice_Service) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservice|
|ReferencingAttribute|msdyn_service|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_incidenttypeservice_Service|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product"></a> msdyn_product_msdyn_inventoryadjustmentproduct_Product

**Added by**: Field Service Solution

Same as msdyn_inventoryadjustmentproduct entity [msdyn_product_msdyn_inventoryadjustmentproduct_Product](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_product_msdyn_inventoryadjustmentproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustmentproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_inventoryadjustmentproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_inventoryjournal_Product"></a> msdyn_product_msdyn_inventoryjournal_Product

**Added by**: Field Service Solution

Same as msdyn_inventoryjournal entity [msdyn_product_msdyn_inventoryjournal_Product](msdyn_inventoryjournal.md#BKMK_msdyn_product_msdyn_inventoryjournal_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_inventoryjournal_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product"></a> msdyn_product_msdyn_orderinvoicingproduct_Product

**Added by**: Field Service Solution

Same as msdyn_orderinvoicingproduct entity [msdyn_product_msdyn_orderinvoicingproduct_Product](msdyn_orderinvoicingproduct.md#BKMK_msdyn_product_msdyn_orderinvoicingproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_orderinvoicingproduct_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_productinventory_Product"></a> msdyn_product_msdyn_productinventory_Product

**Added by**: Field Service Solution

Same as msdyn_productinventory entity [msdyn_product_msdyn_productinventory_Product](msdyn_productinventory.md#BKMK_msdyn_product_msdyn_productinventory_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_productinventory|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_productinventory_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_product_msdyn_purchaseorderproduct_Product"></a> msdyn_product_msdyn_purchaseorderproduct_Product

**Added by**: Field Service Solution

Same as msdyn_purchaseorderproduct entity [msdyn_product_msdyn_purchaseorderproduct_Product](msdyn_purchaseorderproduct.md#BKMK_msdyn_product_msdyn_purchaseorderproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_purchaseorderproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Product<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_quotebookingproduct_Product"></a> msdyn_product_msdyn_quotebookingproduct_Product

**Added by**: Field Service Solution

Same as msdyn_quotebookingproduct entity [msdyn_product_msdyn_quotebookingproduct_Product](msdyn_quotebookingproduct.md#BKMK_msdyn_product_msdyn_quotebookingproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_quotebookingproduct_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_quotebookingservice_Service"></a> msdyn_product_msdyn_quotebookingservice_Service

**Added by**: Field Service Solution

Same as msdyn_quotebookingservice entity [msdyn_product_msdyn_quotebookingservice_Service](msdyn_quotebookingservice.md#BKMK_msdyn_product_msdyn_quotebookingservice_Service) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|msdyn_service|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_quotebookingservice_Service|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_quoteinvoicingproduct_Product"></a> msdyn_product_msdyn_quoteinvoicingproduct_Product

**Added by**: Field Service Solution

Same as msdyn_quoteinvoicingproduct entity [msdyn_product_msdyn_quoteinvoicingproduct_Product](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_product_msdyn_quoteinvoicingproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_quoteinvoicingproduct_Product|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_rmaproduct_Product"></a> msdyn_product_msdyn_rmaproduct_Product

**Added by**: Field Service Solution

Same as msdyn_rmaproduct entity [msdyn_product_msdyn_rmaproduct_Product](msdyn_rmaproduct.md#BKMK_msdyn_product_msdyn_rmaproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_rmaproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_rtvproduct_Product"></a> msdyn_product_msdyn_rtvproduct_Product

**Added by**: Field Service Solution

Same as msdyn_rtvproduct entity [msdyn_product_msdyn_rtvproduct_Product](msdyn_rtvproduct.md#BKMK_msdyn_product_msdyn_rtvproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_rtvproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

**Added by**: Field Service Solution

Same as msdyn_workorderproduct entity [msdyn_product_msdyn_workorderproduct_Product](msdyn_workorderproduct.md#BKMK_msdyn_product_msdyn_workorderproduct_Product) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_product|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_workorderproduct_Product|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_product_msdyn_workorderservice_Service"></a> msdyn_product_msdyn_workorderservice_Service

**Added by**: Field Service Solution

Same as msdyn_workorderservice entity [msdyn_product_msdyn_workorderservice_Service](msdyn_workorderservice.md#BKMK_msdyn_product_msdyn_workorderservice_Service) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_service|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_product_msdyn_workorderservice_Service|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [price_level_products](#BKMK_price_level_products)
- [product_parent_product](#BKMK_product_parent_product)
- [subject_products](#BKMK_subject_products)
- [unit_of_measurement_products](#BKMK_unit_of_measurement_products)
- [unit_of_measurement_schedule_products](#BKMK_unit_of_measurement_schedule_products)
- [msdyn_msdyn_transactioncategory_product_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory)
- [msdyn_account_product_DefaultVendor](#BKMK_msdyn_account_product_DefaultVendor)


### <a name="BKMK_lk_productbase_createdby"></a> lk_productbase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_productbase_createdby](systemuser.md#BKMK_lk_productbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_product_createdonbehalfby"></a> lk_product_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_product_createdonbehalfby](systemuser.md#BKMK_lk_product_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_productbase_modifiedby"></a> lk_productbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_productbase_modifiedby](systemuser.md#BKMK_lk_productbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_product_modifiedonbehalfby"></a> lk_product_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_product_modifiedonbehalfby](systemuser.md#BKMK_lk_product_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_products"></a> organization_products

**Added by**: System Solution Solution

See organization Entity [organization_products](organization.md#BKMK_organization_products) One-To-Many relationship.

### <a name="BKMK_processstage_products"></a> processstage_products

**Added by**: System Solution Solution

See processstage Entity [processstage_products](processstage.md#BKMK_processstage_products) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_product](transactioncurrency.md#BKMK_transactioncurrency_product) One-To-Many relationship.

### <a name="BKMK_price_level_products"></a> price_level_products

See pricelevel Entity [price_level_products](pricelevel.md#BKMK_price_level_products) One-To-Many relationship.

### <a name="BKMK_product_parent_product"></a> product_parent_product

See product Entity [product_parent_product](product.md#BKMK_product_parent_product) One-To-Many relationship.

### <a name="BKMK_subject_products"></a> subject_products

**Added by**: System Solution Solution

See subject Entity [subject_products](subject.md#BKMK_subject_products) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

See uom Entity [unit_of_measurement_products](uom.md#BKMK_unit_of_measurement_products) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_schedule_products"></a> unit_of_measurement_schedule_products

See uomschedule Entity [unit_of_measurement_schedule_products](uomschedule.md#BKMK_unit_of_measurement_schedule_products) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory"></a> msdyn_msdyn_transactioncategory_product_TransactionCategory

**Added by**: Project Service Automation Solution

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_product_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_account_product_DefaultVendor"></a> msdyn_account_product_DefaultVendor

**Added by**: System Solution Solution

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

IntersectEntityName: entitlementproducts<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|productid|
|IsCustomizable|False|
|LogicalName|product|
|NavigationPropertyName|product_entitlement_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|entitlement|
|IntersectAttribute|entitlementid|
|NavigationPropertyName|product_entitlement_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

IntersectEntityName: entitlementtemplateproducts<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|productid|
|IsCustomizable|False|
|LogicalName|product|
|NavigationPropertyName|product_entitlementtemplate_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|entitlementtemplate|
|IntersectAttribute|entitlementtemplateid|
|NavigationPropertyName|product_entitlementtemplate_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_leadproduct_association"></a> leadproduct_association

See lead Entity [leadproduct_association](lead.md#BKMK_leadproduct_association) Many-To-Many Relationship.

### <a name="BKMK_productsalesliterature_association"></a> productsalesliterature_association

IntersectEntityName: productsalesliterature<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|productid|
|IsCustomizable|False|
|LogicalName|product|
|NavigationPropertyName|productsalesliterature_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|salesliterature|
|IntersectAttribute|salesliteratureid|
|NavigationPropertyName|productsalesliterature_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_competitorproduct_association"></a> competitorproduct_association

See competitor Entity [competitorproduct_association](competitor.md#BKMK_competitorproduct_association) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.product?text=product EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]