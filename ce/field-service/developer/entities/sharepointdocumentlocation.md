---
title: "Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Document Location (SharePointDocumentLocation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365 Field Service)

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Document Location (SharePointDocumentLocation) table extends the [Microsoft Dynamics 365 Document Location (SharePointDocumentLocation) table](/dynamics365/developer/entities/sharepointdocumentlocation).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_SharePointDocumentLocations](#BKMK_msdyn_agreement_SharePointDocumentLocations)
- [msdyn_agreementbookingdate_SharePointDocumentLocations](#BKMK_msdyn_agreementbookingdate_SharePointDocumentLocations)
- [msdyn_agreementbookingsetup_SharePointDocumentLocations](#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)
- [msdyn_agreementinvoicedate_SharePointDocumentLocations](#BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations)
- [msdyn_agreementinvoicesetup_SharePointDocumentLocations](#BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations)
- [msdyn_bookingtimestamp_SharePointDocumentLocations](#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)
- [msdyn_incidenttypeproduct_SharePointDocumentLocations](#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations)
- [msdyn_inventoryadjustment_SharePointDocumentLocations](#BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations)
- [msdyn_inventoryadjustmentproduct_SharePointDocumentLocations](#BKMK_msdyn_inventoryadjustmentproduct_SharePointDocumentLocations)
- [msdyn_inventorytransfer_SharePointDocumentLocations](#BKMK_msdyn_inventorytransfer_SharePointDocumentLocations)
- [msdyn_purchaseorder_SharePointDocumentLocations](#BKMK_msdyn_purchaseorder_SharePointDocumentLocations)
- [msdyn_purchaseorderproduct_SharePointDocumentLocations](#BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations)
- [msdyn_purchaseorderreceipt_SharePointDocumentLocations](#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations)
- [msdyn_resourceterritory_SharePointDocumentLocations](#BKMK_msdyn_resourceterritory_SharePointDocumentLocations)
- [msdyn_rma_SharePointDocumentLocations](#BKMK_msdyn_rma_SharePointDocumentLocations)
- [msdyn_rmareceipt_SharePointDocumentLocations](#BKMK_msdyn_rmareceipt_SharePointDocumentLocations)
- [msdyn_rtv_SharePointDocumentLocations](#BKMK_msdyn_rtv_SharePointDocumentLocations)
- [msdyn_timegroup_SharePointDocumentLocations](#BKMK_msdyn_timegroup_SharePointDocumentLocations)
- [msdyn_timegroupdetail_SharePointDocumentLocations](#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)
- [msdyn_warehouse_SharePointDocumentLocations](#BKMK_msdyn_warehouse_SharePointDocumentLocations)
- [msdyn_workorder_SharePointDocumentLocations](#BKMK_msdyn_workorder_SharePointDocumentLocations)
- [msdyn_workorderincident_SharePointDocumentLocations](#BKMK_msdyn_workorderincident_SharePointDocumentLocations)
- [msdyn_workorderproduct_SharePointDocumentLocations](#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)
- [msdyn_workorderservice_SharePointDocumentLocations](#BKMK_msdyn_workorderservice_SharePointDocumentLocations)
- [msdyn_workorderservicetask_SharePointDocumentLocations](#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations)

### <a name="BKMK_msdyn_agreement_SharePointDocumentLocations"></a> msdyn_agreement_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_SharePointDocumentLocations](msdyn_agreement.md#BKMK_msdyn_agreement_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_SharePointDocumentLocations"></a> msdyn_agreementbookingdate_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_SharePointDocumentLocations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations"></a> msdyn_agreementbookingsetup_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_SharePointDocumentLocations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations"></a> msdyn_agreementinvoicedate_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_SharePointDocumentLocations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations"></a> msdyn_agreementinvoicesetup_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_SharePointDocumentLocations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations"></a> msdyn_bookingtimestamp_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_SharePointDocumentLocations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations"></a> msdyn_incidenttypeproduct_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_SharePointDocumentLocations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations"></a> msdyn_inventoryadjustment_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_SharePointDocumentLocations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_SharePointDocumentLocations"></a> msdyn_inventoryadjustmentproduct_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_SharePointDocumentLocations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_SharePointDocumentLocations"></a> msdyn_inventorytransfer_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_SharePointDocumentLocations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorder_SharePointDocumentLocations"></a> msdyn_purchaseorder_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_SharePointDocumentLocations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations"></a> msdyn_purchaseorderproduct_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_SharePointDocumentLocations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations"></a> msdyn_purchaseorderreceipt_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_SharePointDocumentLocations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_SharePointDocumentLocations"></a> msdyn_resourceterritory_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_SharePointDocumentLocations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_SharePointDocumentLocations"></a> msdyn_rma_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_rma msdyn_rma_SharePointDocumentLocations](msdyn_rma.md#BKMK_msdyn_rma_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_SharePointDocumentLocations"></a> msdyn_rmareceipt_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_SharePointDocumentLocations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_SharePointDocumentLocations"></a> msdyn_rtv_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_SharePointDocumentLocations](msdyn_rtv.md#BKMK_msdyn_rtv_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_SharePointDocumentLocations"></a> msdyn_timegroup_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_SharePointDocumentLocations](msdyn_timegroup.md#BKMK_msdyn_timegroup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_SharePointDocumentLocations"></a> msdyn_timegroupdetail_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_SharePointDocumentLocations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_SharePointDocumentLocations"></a> msdyn_warehouse_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_SharePointDocumentLocations](msdyn_warehouse.md#BKMK_msdyn_warehouse_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_SharePointDocumentLocations"></a> msdyn_workorder_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_SharePointDocumentLocations](msdyn_workorder.md#BKMK_msdyn_workorder_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_SharePointDocumentLocations"></a> msdyn_workorderincident_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_SharePointDocumentLocations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_SharePointDocumentLocations"></a> msdyn_workorderproduct_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_SharePointDocumentLocations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_SharePointDocumentLocations"></a> msdyn_workorderservice_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_SharePointDocumentLocations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_SharePointDocumentLocations"></a> msdyn_workorderservicetask_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_SharePointDocumentLocations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sharepointdocumentlocation?displayProperty=fullName>
