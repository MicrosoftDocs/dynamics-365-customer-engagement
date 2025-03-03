---
title: "Account table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Account table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Account table/entity reference (Microsoft Dynamics 365 Field Service)

Business that represents a customer or potential customer. The company that is billed in business transactions.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Account table extends the [Microsoft Dynamics 365 Account table](/dynamics365/developer/reference/entities/account).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_SalesTaxCode](#BKMK_msdyn_SalesTaxCode)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_TaxExempt](#BKMK_msdyn_TaxExempt)
- [msdyn_TaxExemptNumber](#BKMK_msdyn_TaxExemptNumber)
- [msdyn_TravelCharge](#BKMK_msdyn_TravelCharge)
- [msdyn_TravelChargeType](#BKMK_msdyn_TravelChargeType)
- [msdyn_workhourtemplate](#BKMK_msdyn_workhourtemplate)
- [msdyn_WorkOrderInstructions](#BKMK_msdyn_WorkOrderInstructions)

### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

|Property|Value|
|---|---|
|Description|**Reference to an other account to be used for billing (only to be used if billing account differs)**|
|DisplayName|**Billing Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_billingaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Preferred Resource (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

|Property|Value|
|---|---|
|Description|**Default Sales Tax Code**|
|DisplayName|**Sales Tax Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salestaxcode`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_taxcode|

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with account.**|
|DisplayName|**Segment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|---|---|
|Description|**The Service Territory this account belongs to. This is used to optimize scheduling and routing**|
|DisplayName|**Service Territory**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceterritory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|territory|

### <a name="BKMK_msdyn_TaxExempt"></a> msdyn_TaxExempt

|Property|Value|
|---|---|
|Description|**Select whether the account is tax exempt.**|
|DisplayName|**Tax Exempt**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxexempt`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_account_msdyn_taxexempt`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TaxExemptNumber"></a> msdyn_TaxExemptNumber

|Property|Value|
|---|---|
|Description|**Shows the government tax exempt number.**|
|DisplayName|**Tax Exempt Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxexemptnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_msdyn_TravelCharge"></a> msdyn_TravelCharge

|Property|Value|
|---|---|
|Description|**Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.**|
|DisplayName|**Travel Charge**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_travelcharge`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_TravelChargeType"></a> msdyn_TravelChargeType

|Property|Value|
|---|---|
|Description|**Specify how travel is charged for this account.**|
|DisplayName|**Travel Charge Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_travelchargetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970003|
|GlobalChoiceName|`msdyn_travelchargetype`|

#### msdyn_TravelChargeType Choices/Options

|Value|Label|
|---|---|
|690970000|**Hourly**|
|690970001|**Mileage**|
|690970002|**Fixed**|
|690970003|**None**|

### <a name="BKMK_msdyn_workhourtemplate"></a> msdyn_workhourtemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Hour Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workhourtemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workhourtemplate|

### <a name="BKMK_msdyn_WorkOrderInstructions"></a> msdyn_WorkOrderInstructions

|Property|Value|
|---|---|
|Description|**Shows the default instructions to show on new work orders.**|
|DisplayName|**Work Order Instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderinstructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

### <a name="BKMK_msdyn_travelcharge_Base"></a> msdyn_travelcharge_Base

|Property|Value|
|---|---|
|Description|**Value of the Travel Charge in base currency.**|
|DisplayName|**Travel Charge (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_travelcharge_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_CustomerTypeCode"></a> CustomerTypeCode

Changes from [CustomerTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/account#BKMK_CustomerTypeCode)

#### CustomerTypeCode Choices/Options

|Value|Label|
|---|---|
|13|**Insurance carrier**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount-many-to-one)
- [msdyn_bookableresource_account_PreferredResource](#BKMK_msdyn_bookableresource_account_PreferredResource)
- [msdyn_msdyn_taxcode_account_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode)
- [msdyn_msdyn_workhourtemplate_account_workhourtemplate](#BKMK_msdyn_msdyn_workhourtemplate_account_workhourtemplate)
- [msdyn_territory_account_ServiceTerritory](#BKMK_msdyn_territory_account_ServiceTerritory)

### <a name="BKMK_msdyn_account_account_BillingAccount-many-to-one"></a> msdyn_account_account_BillingAccount

One-To-Many Relationship: [account msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_billingaccount_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_account_PreferredResource"></a> msdyn_bookableresource_account_PreferredResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_account_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_account_PreferredResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_PreferredResource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode"></a> msdyn_msdyn_taxcode_account_SalesTaxCode

One-To-Many Relationship: [msdyn_taxcode msdyn_msdyn_taxcode_account_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_account_SalesTaxCode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`msdyn_salestaxcode`|
|ReferencingEntityNavigationPropertyName|`msdyn_salestaxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workhourtemplate_account_workhourtemplate"></a> msdyn_msdyn_workhourtemplate_account_workhourtemplate

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_msdyn_workhourtemplate_account_workhourtemplate](msdyn_workhourtemplate.md#BKMK_msdyn_msdyn_workhourtemplate_account_workhourtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`msdyn_workhourtemplate`|
|ReferencingEntityNavigationPropertyName|`msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_territory_account_ServiceTerritory"></a> msdyn_territory_account_ServiceTerritory

One-To-Many Relationship: [territory msdyn_territory_account_ServiceTerritory](territory.md#BKMK_msdyn_territory_account_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencedEntity|`territory`|
|ReferencedAttribute|`territoryid`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [account_msdyn_bookingalerts](#BKMK_account_msdyn_bookingalerts)
- [msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount-one-to-many)
- [msdyn_account_msdyn_actual_AccountCustomer](#BKMK_msdyn_account_msdyn_actual_AccountCustomer)
- [msdyn_account_msdyn_actual_AccountVendor](#BKMK_msdyn_account_msdyn_actual_AccountVendor)
- [msdyn_account_msdyn_actual_ServiceAccount](#BKMK_msdyn_account_msdyn_actual_ServiceAccount)
- [msdyn_account_msdyn_agreement_BillingAccount](#BKMK_msdyn_account_msdyn_agreement_BillingAccount)
- [msdyn_account_msdyn_agreement_ServiceAccount](#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)
- [msdyn_account_msdyn_entitlementapplication_serviceaccount](#BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount)
- [msdyn_account_msdyn_nottoexceed_account](#BKMK_msdyn_account_msdyn_nottoexceed_account)
- [msdyn_account_msdyn_purchaseorder_Vendor](#BKMK_msdyn_account_msdyn_purchaseorder_Vendor)
- [msdyn_account_msdyn_requirementresourcepreference_Account](#BKMK_msdyn_account_msdyn_requirementresourcepreference_Account)
- [msdyn_account_msdyn_rma_BillingAccount](#BKMK_msdyn_account_msdyn_rma_BillingAccount)
- [msdyn_account_msdyn_rma_ServiceAccount](#BKMK_msdyn_account_msdyn_rma_ServiceAccount)
- [msdyn_account_msdyn_rmaproduct_Changeownership](#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership)
- [msdyn_account_msdyn_rmaproduct_ReturntoVendor](#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor)
- [msdyn_account_msdyn_rtv_Vendor](#BKMK_msdyn_account_msdyn_rtv_Vendor)
- [msdyn_account_msdyn_tradecoverage_Account](#BKMK_msdyn_account_msdyn_tradecoverage_Account)
- [msdyn_account_msdyn_workorder_BillingAccount](#BKMK_msdyn_account_msdyn_workorder_BillingAccount)
- [msdyn_account_msdyn_workorder_ServiceAccount](#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)
- [msdyn_account_opportunityproduct_ServiceAccount](#BKMK_msdyn_account_opportunityproduct_ServiceAccount)
- [msdyn_account_product_DefaultVendor](#BKMK_msdyn_account_product_DefaultVendor)
- [msdyn_account_quote_Account](#BKMK_msdyn_account_quote_Account)
- [msdyn_geofence_account](#BKMK_msdyn_geofence_account)

### <a name="BKMK_account_msdyn_bookingalerts"></a> account_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert account_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_account_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msdyn_account_account_BillingAccount-one-to-many"></a> msdyn_account_account_BillingAccount

Many-To-One Relationship: [account msdyn_account_account_BillingAccount](#BKMK_msdyn_account_account_BillingAccount-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_account_BillingAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billed Accounts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_actual_AccountCustomer"></a> msdyn_account_msdyn_actual_AccountCustomer

Many-To-One Relationship: [msdyn_actual msdyn_account_msdyn_actual_AccountCustomer](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountCustomer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_accountcustomer`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_actual_AccountCustomer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_actual_AccountVendor"></a> msdyn_account_msdyn_actual_AccountVendor

Many-To-One Relationship: [msdyn_actual msdyn_account_msdyn_actual_AccountVendor](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_AccountVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_accountvendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_actual_AccountVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_actual_ServiceAccount"></a> msdyn_account_msdyn_actual_ServiceAccount

Many-To-One Relationship: [msdyn_actual msdyn_account_msdyn_actual_ServiceAccount](msdyn_actual.md#BKMK_msdyn_account_msdyn_actual_ServiceAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_actual_ServiceAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_agreement_BillingAccount"></a> msdyn_account_msdyn_agreement_BillingAccount

Many-To-One Relationship: [msdyn_agreement msdyn_account_msdyn_agreement_BillingAccount](msdyn_agreement.md#BKMK_msdyn_account_msdyn_agreement_BillingAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_agreement_BillingAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billed Agreements<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_agreement_ServiceAccount"></a> msdyn_account_msdyn_agreement_ServiceAccount

Many-To-One Relationship: [msdyn_agreement msdyn_account_msdyn_agreement_ServiceAccount](msdyn_agreement.md#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_agreement_ServiceAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount"></a> msdyn_account_msdyn_entitlementapplication_serviceaccount

Many-To-One Relationship: [msdyn_entitlementapplication msdyn_account_msdyn_entitlementapplication_serviceaccount](msdyn_entitlementapplication.md#BKMK_msdyn_account_msdyn_entitlementapplication_serviceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_entitlementapplication_serviceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_nottoexceed_account"></a> msdyn_account_msdyn_nottoexceed_account

Many-To-One Relationship: [msdyn_nottoexceed msdyn_account_msdyn_nottoexceed_account](msdyn_nottoexceed.md#BKMK_msdyn_account_msdyn_nottoexceed_account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_nottoexceed_account`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_purchaseorder_Vendor"></a> msdyn_account_msdyn_purchaseorder_Vendor

Many-To-One Relationship: [msdyn_purchaseorder msdyn_account_msdyn_purchaseorder_Vendor](msdyn_purchaseorder.md#BKMK_msdyn_account_msdyn_purchaseorder_Vendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_vendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_purchaseorder_Vendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_requirementresourcepreference_Account"></a> msdyn_account_msdyn_requirementresourcepreference_Account

Many-To-One Relationship: [msdyn_requirementresourcepreference msdyn_account_msdyn_requirementresourcepreference_Account](msdyn_requirementresourcepreference.md#BKMK_msdyn_account_msdyn_requirementresourcepreference_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_requirementresourcepreference_Account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Resource Preferences<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_rma_BillingAccount"></a> msdyn_account_msdyn_rma_BillingAccount

Many-To-One Relationship: [msdyn_rma msdyn_account_msdyn_rma_BillingAccount](msdyn_rma.md#BKMK_msdyn_account_msdyn_rma_BillingAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_rma_BillingAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billing RMAs<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_rma_ServiceAccount"></a> msdyn_account_msdyn_rma_ServiceAccount

Many-To-One Relationship: [msdyn_rma msdyn_account_msdyn_rma_ServiceAccount](msdyn_rma.md#BKMK_msdyn_account_msdyn_rma_ServiceAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_rma_ServiceAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: RMAs<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_rmaproduct_Changeownership"></a> msdyn_account_msdyn_rmaproduct_Changeownership

Many-To-One Relationship: [msdyn_rmaproduct msdyn_account_msdyn_rmaproduct_Changeownership](msdyn_rmaproduct.md#BKMK_msdyn_account_msdyn_rmaproduct_Changeownership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_changeownership`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_rmaproduct_Changeownership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Change ownership<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor"></a> msdyn_account_msdyn_rmaproduct_ReturntoVendor

Many-To-One Relationship: [msdyn_rmaproduct msdyn_account_msdyn_rmaproduct_ReturntoVendor](msdyn_rmaproduct.md#BKMK_msdyn_account_msdyn_rmaproduct_ReturntoVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_returntovendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_rmaproduct_ReturntoVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Return to Vendor<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_rtv_Vendor"></a> msdyn_account_msdyn_rtv_Vendor

Many-To-One Relationship: [msdyn_rtv msdyn_account_msdyn_rtv_Vendor](msdyn_rtv.md#BKMK_msdyn_account_msdyn_rtv_Vendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_vendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_rtv_Vendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: RTVs<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_tradecoverage_Account"></a> msdyn_account_msdyn_tradecoverage_Account

Many-To-One Relationship: [msdyn_tradecoverage msdyn_account_msdyn_tradecoverage_Account](msdyn_tradecoverage.md#BKMK_msdyn_account_msdyn_tradecoverage_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_tradecoverage_Account`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_workorder_BillingAccount"></a> msdyn_account_msdyn_workorder_BillingAccount

Many-To-One Relationship: [msdyn_workorder msdyn_account_msdyn_workorder_BillingAccount](msdyn_workorder.md#BKMK_msdyn_account_msdyn_workorder_BillingAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_workorder_BillingAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billed Work Orders<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_workorder_ServiceAccount"></a> msdyn_account_msdyn_workorder_ServiceAccount

Many-To-One Relationship: [msdyn_workorder msdyn_account_msdyn_workorder_ServiceAccount](msdyn_workorder.md#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_workorder_ServiceAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_opportunityproduct_ServiceAccount"></a> msdyn_account_opportunityproduct_ServiceAccount

Many-To-One Relationship: [opportunityproduct msdyn_account_opportunityproduct_ServiceAccount](opportunityproduct.md#BKMK_msdyn_account_opportunityproduct_ServiceAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_opportunityproduct_ServiceAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_product_DefaultVendor"></a> msdyn_account_product_DefaultVendor

Many-To-One Relationship: [product msdyn_account_product_DefaultVendor](product.md#BKMK_msdyn_account_product_DefaultVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`msdyn_defaultvendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_product_DefaultVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Default Vendor<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_quote_Account"></a> msdyn_account_quote_Account

Many-To-One Relationship: [quote msdyn_account_quote_Account](quote.md#BKMK_msdyn_account_quote_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_quote_Account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geofence_account"></a> msdyn_geofence_account

Many-To-One Relationship: [msdyn_geofence msdyn_geofence_account](msdyn_geofence.md#BKMK_msdyn_geofence_account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_geofence_account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Account<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.account?displayProperty=fullName>
