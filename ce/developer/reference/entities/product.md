---
title: "Product table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Product table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Product table/entity reference (Microsoft Dynamics 365)

Information about products and their pricing information.

## Messages

The following table lists the messages for the Product table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `AddProductToKit`<br />Event: True | |<xref:Microsoft.Crm.Sdk.Messages.AddProductToKitRequest>|
| `AddSubstituteProduct`<br />Event: False | |<xref:Microsoft.Crm.Sdk.Messages.AddSubstituteProductRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CloneProduct`<br />Event: True |**CloneProduct action** |<xref:Microsoft.Crm.Sdk.Messages.CloneProductRequest>|
| `ConvertKitToProduct`<br />Event: False | |<xref:Microsoft.Crm.Sdk.Messages.ConvertKitToProductRequest>|
| `ConvertProductToKit`<br />Event: False | |<xref:Microsoft.Crm.Sdk.Messages.ConvertProductToKitRequest>|
| `Create`<br />Event: True |`POST` /products<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /products(*productid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PublishProductHierarchy`<br />Event: False |**PublishProductHierarchy action** |<xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest>|
| `RemoveSubstituteProduct`<br />Event: False | |<xref:Microsoft.Crm.Sdk.Messages.RemoveSubstituteProductRequest>|
| `Retrieve`<br />Event: True |`GET` /products(*productid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /products<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RevertProduct`<br />Event: False |**RevertProduct action** |<xref:Microsoft.Crm.Sdk.Messages.RevertProductRequest>|
| `SetState`<br />Event: True |`PATCH` /products(*productid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /products(*productid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /products(*productid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Product table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Product** |
| **DisplayCollectionName** | **Products** |
| **SchemaName** | `Product` |
| **CollectionSchemaName** | `Products` |
| **EntitySetName** | `products`|
| **LogicalName** | `product` |
| **LogicalCollectionName** | `products` |
| **PrimaryIdAttribute** | `productid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
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
|---|---|
|Description|**Current cost for the product item. Used in price calculations.**|
|DisplayName|**Current Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`currentcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_DefaultUoMId"></a> DefaultUoMId

|Property|Value|
|---|---|
|Description|**Default unit for the product.**|
|DisplayName|**Default Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultuomid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_DefaultUoMScheduleId"></a> DefaultUoMScheduleId

|Property|Value|
|---|---|
|Description|**Default unit group for the product.**|
|DisplayName|**Unit Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultuomscheduleid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uomschedule|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of the product.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DMTImportState"></a> DMTImportState

|Property|Value|
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Internal Use Only**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`dmtimportstate`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**Shows the default image for the record.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsKit"></a> IsKit

|Property|Value|
|---|---|
|Description|**Information that specifies whether the product is a kit.**|
|DisplayName|**Is Kit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`iskit`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`product_iskit`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsReparented"></a> IsReparented

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Reparented**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isreparented`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`isreparented`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsStockItem"></a> IsStockItem

|Property|Value|
|---|---|
|Description|**Information about whether the product is a stock item.**|
|DisplayName|**Stock Item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isstockitem`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`product_isstockitem`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether product is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_product_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name of the product.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ParentProductId"></a> ParentProductId

|Property|Value|
|---|---|
|Description|**Specifies the parent product family hierarchy.**|
|DisplayName|**Parent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentproductid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_Price"></a> Price

|Property|Value|
|---|---|
|Description|**List price for the product item. Used in price calculations.**|
|DisplayName|**List Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`price`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|---|---|
|Description|**Select the default price list for the product.**|
|DisplayName|**Default Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pricelevelid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|---|---|
|Description|**Unique identifier of the product.**|
|DisplayName|**Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`productid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductNumber"></a> ProductNumber

|Property|Value|
|---|---|
|Description|**User-defined product ID.**|
|DisplayName|**Product ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productnumber`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ProductStructure"></a> ProductStructure

|Property|Value|
|---|---|
|Description|**Product Structure.**|
|DisplayName|**Product Structure**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productstructure`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`product_productstructure`|

#### ProductStructure Choices/Options

|Value|Label|
|---|---|
|1|**Product**|
|2|**Product Family**|
|3|**Product Bundle**|

### <a name="BKMK_ProductTypeCode"></a> ProductTypeCode

|Property|Value|
|---|---|
|Description|**Type of product.**|
|DisplayName|**Product Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`producttypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`product_producttypecode`|

#### ProductTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Sales Inventory**|
|2|**Miscellaneous Charges**|
|3|**Services**|
|4|**Flat Fees**|

### <a name="BKMK_ProductUrl"></a> ProductUrl

|Property|Value|
|---|---|
|Description|**URL for the Website associated with the product.**|
|DisplayName|**URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`producturl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_QuantityDecimal"></a> QuantityDecimal

|Property|Value|
|---|---|
|Description|**Number of decimal places that can be used in monetary amounts for the product.**|
|DisplayName|**Decimals Supported**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quantitydecimal`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|5|
|MinValue|0|

### <a name="BKMK_QuantityOnHand"></a> QuantityOnHand

|Property|Value|
|---|---|
|Description|**Quantity of the product in stock.**|
|DisplayName|**Quantity On Hand**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quantityonhand`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_Size"></a> Size

|Property|Value|
|---|---|
|Description|**Product size.**|
|DisplayName|**Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`size`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StandardCost"></a> StandardCost

|Property|Value|
|---|---|
|Description|**Standard cost for the product item. Used in price calculations.**|
|DisplayName|**Standard Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`standardcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the product.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|2|
|GlobalChoiceName|`product_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Retired**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|
|2|Label: **Draft**<br />DefaultStatus: 0<br />InvariantName: `Draft`|
|3|Label: **Under Revision**<br />DefaultStatus: 3<br />InvariantName: `Under Revision`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the product.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`product_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />State:2<br />TransitionData: None|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Retired**<br />State:1<br />TransitionData: None|
|3|Label: **Under Revision**<br />State:3<br />TransitionData: None|

### <a name="BKMK_StockVolume"></a> StockVolume

|Property|Value|
|---|---|
|Description|**Stock volume of the product.**|
|DisplayName|**Stock Volume**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`stockvolume`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_StockWeight"></a> StockWeight

|Property|Value|
|---|---|
|Description|**Stock weight of the product.**|
|DisplayName|**Stock Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`stockweight`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_SubjectId"></a> SubjectId

|Property|Value|
|---|---|
|Description|**Select a category for the product.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|subject|

### <a name="BKMK_SupplierName"></a> SupplierName

|Property|Value|
|---|---|
|Description|**Name of the product's supplier.**|
|DisplayName|**Supplier Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`suppliername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the product.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_ValidFromDate"></a> ValidFromDate

|Property|Value|
|---|---|
|Description|**Date from which this product is valid.**|
|DisplayName|**Valid From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`validfromdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ValidToDate"></a> ValidToDate

|Property|Value|
|---|---|
|Description|**Date to which this product is valid.**|
|DisplayName|**Valid To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`validtodate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_VendorID"></a> VendorID

|Property|Value|
|---|---|
|Description|**Unique identifier of vendor supplying the product.**|
|DisplayName|**Vendor ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`vendorid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_VendorName"></a> VendorName

|Property|Value|
|---|---|
|Description|**Name of the product vendor.**|
|DisplayName|**Vendor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`vendorname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_VendorPartNumber"></a> VendorPartNumber

|Property|Value|
|---|---|
|Description|**Unique part identifier in vendor catalog of this product.**|
|DisplayName|**Vendor Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`vendorpartnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CurrentCost_Base](#BKMK_CurrentCost_Base)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [HierarchyPath](#BKMK_HierarchyPath)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [Price_Base](#BKMK_Price_Base)
- [StandardCost_Base](#BKMK_StandardCost_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the product.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who created the record.**|
|DisplayName|**Created By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the product.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CurrentCost_Base"></a> CurrentCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Current Cost in base currency.**|
|DisplayName|**Current Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`currentcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the product with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_HierarchyPath"></a> HierarchyPath

|Property|Value|
|---|---|
|Description|**Hierarchy path of the product.**|
|DisplayName|**Hierarchy Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`hierarchypath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the product.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who modified the record.**|
|DisplayName|**Modified By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who last modified the product.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_Price_Base"></a> Price_Base

|Property|Value|
|---|---|
|Description|**Value of the List Price in base currency.**|
|DisplayName|**List Price (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`price_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_StandardCost_Base"></a> StandardCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Standard Cost in base currency.**|
|DisplayName|**Standard Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`standardcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_product_createdonbehalfby](#BKMK_lk_product_createdonbehalfby)
- [lk_product_modifiedonbehalfby](#BKMK_lk_product_modifiedonbehalfby)
- [lk_productbase_createdby](#BKMK_lk_productbase_createdby)
- [lk_productbase_modifiedby](#BKMK_lk_productbase_modifiedby)
- [organization_products](#BKMK_organization_products)
- [price_level_products](#BKMK_price_level_products)
- [processstage_products](#BKMK_processstage_products)
- [product_parent_product](#BKMK_product_parent_product-many-to-one)
- [subject_products](#BKMK_subject_products)
- [transactioncurrency_product](#BKMK_transactioncurrency_product)
- [unit_of_measurement_products](#BKMK_unit_of_measurement_products)
- [unit_of_measurement_schedule_products](#BKMK_unit_of_measurement_schedule_products)

### <a name="BKMK_lk_product_createdonbehalfby"></a> lk_product_createdonbehalfby

One-To-Many Relationship: [systemuser lk_product_createdonbehalfby](systemuser.md#BKMK_lk_product_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_product_modifiedonbehalfby"></a> lk_product_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_product_modifiedonbehalfby](systemuser.md#BKMK_lk_product_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productbase_createdby"></a> lk_productbase_createdby

One-To-Many Relationship: [systemuser lk_productbase_createdby](systemuser.md#BKMK_lk_productbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_productbase_modifiedby"></a> lk_productbase_modifiedby

One-To-Many Relationship: [systemuser lk_productbase_modifiedby](systemuser.md#BKMK_lk_productbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_products"></a> organization_products

One-To-Many Relationship: [organization organization_products](organization.md#BKMK_organization_products)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_products"></a> price_level_products

One-To-Many Relationship: [pricelevel price_level_products](pricelevel.md#BKMK_price_level_products)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelevelid`|
|ReferencingEntityNavigationPropertyName|`pricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_products"></a> processstage_products

One-To-Many Relationship: [processstage processstage_products](processstage.md#BKMK_processstage_products)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_parent_product-many-to-one"></a> product_parent_product

One-To-Many Relationship: [product product_parent_product](#BKMK_product_parent_product-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`parentproductid`|
|ReferencingEntityNavigationPropertyName|`parentproductid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_subject_products"></a> subject_products

One-To-Many Relationship: [subject subject_products](subject.md#BKMK_subject_products)

|Property|Value|
|---|---|
|ReferencedEntity|`subject`|
|ReferencedAttribute|`subjectid`|
|ReferencingAttribute|`subjectid`|
|ReferencingEntityNavigationPropertyName|`subjectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

One-To-Many Relationship: [transactioncurrency transactioncurrency_product](transactioncurrency.md#BKMK_transactioncurrency_product)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

One-To-Many Relationship: [uom unit_of_measurement_products](uom.md#BKMK_unit_of_measurement_products)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`defaultuomid`|
|ReferencingEntityNavigationPropertyName|`defaultuomid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_schedule_products"></a> unit_of_measurement_schedule_products

One-To-Many Relationship: [uomschedule unit_of_measurement_schedule_products](uomschedule.md#BKMK_unit_of_measurement_schedule_products)

|Property|Value|
|---|---|
|ReferencedEntity|`uomschedule`|
|ReferencedAttribute|`uomscheduleid`|
|ReferencingAttribute|`defaultuomscheduleid`|
|ReferencingEntityNavigationPropertyName|`defaultuomscheduleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_product_msdyn_customerasset_Product](#BKMK_msdyn_product_msdyn_customerasset_Product)
- [opportunity_products](#BKMK_opportunity_products)
- [Product_Annotation](#BKMK_Product_Annotation)
- [Product_AsyncOperations](#BKMK_Product_AsyncOperations)
- [Product_BulkDeleteFailures](#BKMK_Product_BulkDeleteFailures)
- [product_connections1](#BKMK_product_connections1)
- [product_connections2](#BKMK_product_connections2)
- [product_contract_line_items](#BKMK_product_contract_line_items)
- [Product_DynamicProperty](#BKMK_Product_DynamicProperty)
- [Product_DynamicPropertyAssociation](#BKMK_Product_DynamicPropertyAssociation)
- [product_incidents](#BKMK_product_incidents)
- [product_invoice_details](#BKMK_product_invoice_details)
- [product_MailboxTrackingFolders](#BKMK_product_MailboxTrackingFolders)
- [product_order_details](#BKMK_product_order_details)
- [product_parent_product](#BKMK_product_parent_product-one-to-many)
- [product_price_levels](#BKMK_product_price_levels)
- [product_principalobjectattributeaccess](#BKMK_product_principalobjectattributeaccess)
- [Product_ProcessSessions](#BKMK_Product_ProcessSessions)
- [Product_ProductAssociation_AssocProd](#BKMK_Product_ProductAssociation_AssocProd)
- [Product_ProductAssociation_Prod](#BKMK_Product_ProductAssociation_Prod)
- [product_ProductSubstitute_productid](#BKMK_product_ProductSubstitute_productid)
- [product_ProductSubstitute_substitutedproductid](#BKMK_product_ProductSubstitute_substitutedproductid)
- [product_quote_details](#BKMK_product_quote_details)
- [Product_SharepointDocumentLocation](#BKMK_Product_SharepointDocumentLocation)
- [Product_SyncErrors](#BKMK_Product_SyncErrors)

### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

Many-To-One Relationship: [msdyn_customerasset msdyn_product_msdyn_customerasset_Product](msdyn_customerasset.md#BKMK_msdyn_product_msdyn_customerasset_Product)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_product`|
|ReferencedEntityNavigationPropertyName|`msdyn_product_msdyn_customerasset_Product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_products"></a> opportunity_products

Many-To-One Relationship: [opportunityproduct opportunity_products](opportunityproduct.md#BKMK_opportunity_products)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`opportunity_products`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_Annotation"></a> Product_Annotation

Many-To-One Relationship: [annotation Product_Annotation](annotation.md#BKMK_Product_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Product_Annotation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

Many-To-One Relationship: [asyncoperation Product_AsyncOperations](asyncoperation.md#BKMK_Product_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_BulkDeleteFailures"></a> Product_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Product_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Product_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_connections1"></a> product_connections1

Many-To-One Relationship: [connection product_connections1](connection.md#BKMK_product_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`product_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_connections2"></a> product_connections2

Many-To-One Relationship: [connection product_connections2](connection.md#BKMK_product_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`product_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

Many-To-One Relationship: [contractdetail product_contract_line_items](contractdetail.md#BKMK_product_contract_line_items)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_contract_line_items`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

Many-To-One Relationship: [dynamicproperty Product_DynamicProperty](dynamicproperty.md#BKMK_Product_DynamicProperty)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicproperty`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_DynamicProperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_DynamicPropertyAssociation"></a> Product_DynamicPropertyAssociation

Many-To-One Relationship: [dynamicpropertyassociation Product_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Product_DynamicPropertyAssociation)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyassociation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_DynamicPropertyAssociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_incidents"></a> product_incidents

Many-To-One Relationship: [incident product_incidents](incident.md#BKMK_product_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_incidents`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_invoice_details"></a> product_invoice_details

Many-To-One Relationship: [invoicedetail product_invoice_details](invoicedetail.md#BKMK_product_invoice_details)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_invoice_details`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_MailboxTrackingFolders"></a> product_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder product_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_product_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`product_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_order_details"></a> product_order_details

Many-To-One Relationship: [salesorderdetail product_order_details](salesorderdetail.md#BKMK_product_order_details)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_order_details`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_parent_product-one-to-many"></a> product_parent_product

Many-To-One Relationship: [product product_parent_product](#BKMK_product_parent_product-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`parentproductid`|
|ReferencedEntityNavigationPropertyName|`product_parent_product`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_price_levels"></a> product_price_levels

Many-To-One Relationship: [productpricelevel product_price_levels](productpricelevel.md#BKMK_product_price_levels)

|Property|Value|
|---|---|
|ReferencingEntity|`productpricelevel`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_price_levels`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMProductPriceLevel.RetrieveByObject`<br />ViewId: `f4d79a29-8f34-40e3-8802-bb631ee8eace`|

### <a name="BKMK_product_principalobjectattributeaccess"></a> product_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess product_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_product_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`product_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

Many-To-One Relationship: [processsession Product_ProcessSessions](processsession.md#BKMK_Product_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_ProductAssociation_AssocProd"></a> Product_ProductAssociation_AssocProd

Many-To-One Relationship: [productassociation Product_ProductAssociation_AssocProd](productassociation.md#BKMK_Product_ProductAssociation_AssocProd)

|Property|Value|
|---|---|
|ReferencingEntity|`productassociation`|
|ReferencingAttribute|`associatedproduct`|
|ReferencedEntityNavigationPropertyName|`Product_ProductAssociation_AssocProd`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: `CRMProduct.RetrieveByObject`<br />ViewId: `ff3ab78d-fbfa-45ef-bf83-d672eb5bb553`|

### <a name="BKMK_Product_ProductAssociation_Prod"></a> Product_ProductAssociation_Prod

Many-To-One Relationship: [productassociation Product_ProductAssociation_Prod](productassociation.md#BKMK_Product_ProductAssociation_Prod)

|Property|Value|
|---|---|
|ReferencingEntity|`productassociation`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`Product_ProductAssociation_Prod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_ProductSubstitute_productid"></a> product_ProductSubstitute_productid

Many-To-One Relationship: [productsubstitute product_ProductSubstitute_productid](productsubstitute.md#BKMK_product_ProductSubstitute_productid)

|Property|Value|
|---|---|
|ReferencingEntity|`productsubstitute`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_ProductSubstitute_productid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: `CRMProduct.RetrieveSubstitutes`<br />ViewId: `21bfc518-b51e-4c08-baef-682aefc09e76`|

### <a name="BKMK_product_ProductSubstitute_substitutedproductid"></a> product_ProductSubstitute_substitutedproductid

Many-To-One Relationship: [productsubstitute product_ProductSubstitute_substitutedproductid](productsubstitute.md#BKMK_product_ProductSubstitute_substitutedproductid)

|Property|Value|
|---|---|
|ReferencingEntity|`productsubstitute`|
|ReferencingAttribute|`substitutedproductid`|
|ReferencedEntityNavigationPropertyName|`product_ProductSubstitute_substitutedproductid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_quote_details"></a> product_quote_details

Many-To-One Relationship: [quotedetail product_quote_details](quotedetail.md#BKMK_product_quote_details)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`productid`|
|ReferencedEntityNavigationPropertyName|`product_quote_details`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_SharepointDocumentLocation"></a> Product_SharepointDocumentLocation

Many-To-One Relationship: [sharepointdocumentlocation Product_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Product_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_SharepointDocumentLocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Product_SyncErrors"></a> Product_SyncErrors

Many-To-One Relationship: [syncerror Product_SyncErrors](syncerror.md#BKMK_Product_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Product_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [campaignproduct_association](#BKMK_campaignproduct_association)
- [competitorproduct_association](#BKMK_competitorproduct_association)
- [leadproduct_association](#BKMK_leadproduct_association)
- [msdyn_product_knowledgearticle](#BKMK_msdyn_product_knowledgearticle)
- [product_entitlement_association](#BKMK_product_entitlement_association)
- [product_entitlementtemplate_association](#BKMK_product_entitlementtemplate_association)
- [product_knowledgebaserecord](#BKMK_product_knowledgebaserecord)
- [productsalesliterature_association](#BKMK_productsalesliterature_association)

### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

See [campaign campaignproduct_association Many-To-Many Relationship](campaign.md#BKMK_campaignproduct_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignproduct_association`|
|IntersectAttribute|`entityid`|
|NavigationPropertyName|`campaignproduct_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_competitorproduct_association"></a> competitorproduct_association

See [competitor competitorproduct_association Many-To-Many Relationship](competitor.md#BKMK_competitorproduct_association)

|Property|Value|
|---|---|
|IntersectEntityName|`competitorproduct`|
|IsCustomizable|False|
|SchemaName|`competitorproduct_association`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|`competitorproduct_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMProduct.RetrieveByObject`<br />ViewId: `f8de15f4-4c76-4a21-94c9-a38fcafdb73d`|

### <a name="BKMK_leadproduct_association"></a> leadproduct_association

See [lead leadproduct_association Many-To-Many Relationship](lead.md#BKMK_leadproduct_association)

|Property|Value|
|---|---|
|IntersectEntityName|`leadproduct`|
|IsCustomizable|False|
|SchemaName|`leadproduct_association`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|`leadproduct_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_product_knowledgearticle"></a> msdyn_product_knowledgearticle

See [knowledgearticle msdyn_product_knowledgearticle Many-To-Many Relationship](knowledgearticle.md#BKMK_msdyn_product_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_product_knowledgearticle`|
|IsCustomizable|True|
|SchemaName|`msdyn_product_knowledgearticle`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_entitlement_association"></a> product_entitlement_association

See [entitlement product_entitlement_association Many-To-Many Relationship](entitlement.md#BKMK_product_entitlement_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementproducts`|
|IsCustomizable|False|
|SchemaName|`product_entitlement_association`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|`product_entitlement_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

See [entitlementtemplate product_entitlementtemplate_association Many-To-Many Relationship](entitlementtemplate.md#BKMK_product_entitlementtemplate_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementtemplateproducts`|
|IsCustomizable|False|
|SchemaName|`product_entitlementtemplate_association`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|`product_entitlementtemplate_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_knowledgebaserecord"></a> product_knowledgebaserecord

See [knowledgebaserecord product_knowledgebaserecord Many-To-Many Relationship](knowledgebaserecord.md#BKMK_product_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_product_knowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`product_knowledgebaserecord`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_productsalesliterature_association"></a> productsalesliterature_association

See [salesliterature productsalesliterature_association Many-To-Many Relationship](salesliterature.md#BKMK_productsalesliterature_association)

|Property|Value|
|---|---|
|IntersectEntityName|`productsalesliterature`|
|IsCustomizable|False|
|SchemaName|`productsalesliterature_association`|
|IntersectAttribute|`productid`|
|NavigationPropertyName|`productsalesliterature_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMProduct.RetrieveByObject`<br />ViewId: `f8de15f4-4c76-4a21-94c9-a38fcafdb73d`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

