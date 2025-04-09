---
title: "Opportunity Line (OpportunityProduct) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Opportunity Line (OpportunityProduct) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Opportunity Line (OpportunityProduct) table/entity reference (Microsoft Dynamics 365 Field Service)

Association between an opportunity and a product.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Opportunity Line (OpportunityProduct) table extends the [Microsoft Dynamics 365 Opportunity Line (OpportunityProduct) table](/dynamics365/developer/reference/entities/opportunityproduct).


## Properties

The following table lists selected properties for the Opportunity Line (OpportunityProduct) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity Line** |
| **DisplayCollectionName** | **Opportunity Lines** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_enddate](#BKMK_msdyn_enddate)
- [msdyn_LineType](#BKMK_msdyn_LineType)
- [msdyn_pricelist](#BKMK_msdyn_pricelist)
- [msdyn_serviceaccount](#BKMK_msdyn_serviceaccount)
- [msdyn_startdate](#BKMK_msdyn_startdate)

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Enter the duration of the agreement**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_enddate"></a> msdyn_enddate

|Property|Value|
|---|---|
|Description|**Enter the end date of the agreement**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_LineType"></a> msdyn_LineType

|Property|Value|
|---|---|
|Description|**The field to distinguish the order lines to be of project service or field service**|
|DisplayName|**Line Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linetype`|

#### msdyn_LineType Choices/Options

|Value|Label|
|---|---|
|690970000|**Project Service Line**|
|690970001|**Field Service Line**|

### <a name="BKMK_msdyn_pricelist"></a> msdyn_pricelist

|Property|Value|
|---|---|
|Description|**Select a price list for the opportunity line**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_serviceaccount"></a> msdyn_serviceaccount

|Property|Value|
|---|---|
|Description|**Select the service account for the opportunity line**|
|DisplayName|**Service Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_startdate"></a> msdyn_startdate

|Property|Value|
|---|---|
|Description|**Start date of the Agreement**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_account_opportunityproduct_ServiceAccount"></a> msdyn_account_opportunityproduct_ServiceAccount

One-To-Many Relationship: [account msdyn_account_opportunityproduct_ServiceAccount](account.md#BKMK_msdyn_account_opportunityproduct_ServiceAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

