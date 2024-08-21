---
title: "Task table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Task table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Task table/entity reference

Generic activity representing work needed to be done.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Task table extends the [Microsoft Dataverse Task table](/power-apps/developer/data-platform/reference/entities/task).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/task#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_Tasks](#BKMK_msdyn_agreement_Tasks)
- [msdyn_agreementbookingdate_Tasks](#BKMK_msdyn_agreementbookingdate_Tasks)
- [msdyn_agreementbookingincident_Tasks](#BKMK_msdyn_agreementbookingincident_Tasks)
- [msdyn_agreementbookingproduct_Tasks](#BKMK_msdyn_agreementbookingproduct_Tasks)
- [msdyn_agreementbookingservice_Tasks](#BKMK_msdyn_agreementbookingservice_Tasks)
- [msdyn_agreementbookingservicetask_Tasks](#BKMK_msdyn_agreementbookingservicetask_Tasks)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_agreementinvoicedate_Tasks](#BKMK_msdyn_agreementinvoicedate_Tasks)
- [msdyn_agreementinvoiceproduct_Tasks](#BKMK_msdyn_agreementinvoiceproduct_Tasks)
- [msdyn_agreementinvoicesetup_Tasks](#BKMK_msdyn_agreementinvoicesetup_Tasks)
- [msdyn_bookingalertstatus_Tasks](#BKMK_msdyn_bookingalertstatus_Tasks)
- [msdyn_bookingrule_Tasks](#BKMK_msdyn_bookingrule_Tasks)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)
- [msdyn_fieldservicesetting_Tasks](#BKMK_msdyn_fieldservicesetting_Tasks)
- [msdyn_incidenttypecharacteristic_Tasks](#BKMK_msdyn_incidenttypecharacteristic_Tasks)
- [msdyn_incidenttypeproduct_Tasks](#BKMK_msdyn_incidenttypeproduct_Tasks)
- [msdyn_incidenttypeservice_Tasks](#BKMK_msdyn_incidenttypeservice_Tasks)
- [msdyn_inventoryadjustment_Tasks](#BKMK_msdyn_inventoryadjustment_Tasks)
- [msdyn_inventoryadjustmentproduct_Tasks](#BKMK_msdyn_inventoryadjustmentproduct_Tasks)
- [msdyn_inventoryjournal_Tasks](#BKMK_msdyn_inventoryjournal_Tasks)
- [msdyn_inventorytransfer_Tasks](#BKMK_msdyn_inventorytransfer_Tasks)
- [msdyn_payment_Tasks](#BKMK_msdyn_payment_Tasks)
- [msdyn_paymentdetail_Tasks](#BKMK_msdyn_paymentdetail_Tasks)
- [msdyn_paymentmethod_Tasks](#BKMK_msdyn_paymentmethod_Tasks)
- [msdyn_paymentterm_Tasks](#BKMK_msdyn_paymentterm_Tasks)
- [msdyn_postalcode_Tasks](#BKMK_msdyn_postalcode_Tasks)
- [msdyn_productinventory_Tasks](#BKMK_msdyn_productinventory_Tasks)
- [msdyn_purchaseorder_Tasks](#BKMK_msdyn_purchaseorder_Tasks)
- [msdyn_purchaseorderbill_Tasks](#BKMK_msdyn_purchaseorderbill_Tasks)
- [msdyn_purchaseorderproduct_Tasks](#BKMK_msdyn_purchaseorderproduct_Tasks)
- [msdyn_purchaseorderreceipt_Tasks](#BKMK_msdyn_purchaseorderreceipt_Tasks)
- [msdyn_purchaseorderreceiptproduct_Tasks](#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)
- [msdyn_purchaseordersubstatus_Tasks](#BKMK_msdyn_purchaseordersubstatus_Tasks)
- [msdyn_quotebookingincident_Tasks](#BKMK_msdyn_quotebookingincident_Tasks)
- [msdyn_quotebookingproduct_Tasks](#BKMK_msdyn_quotebookingproduct_Tasks)
- [msdyn_quotebookingservice_Tasks](#BKMK_msdyn_quotebookingservice_Tasks)
- [msdyn_quotebookingservicetask_Tasks](#BKMK_msdyn_quotebookingservicetask_Tasks)
- [msdyn_resourceterritory_Tasks](#BKMK_msdyn_resourceterritory_Tasks)
- [msdyn_rma_Tasks](#BKMK_msdyn_rma_Tasks)
- [msdyn_rmaproduct_Tasks](#BKMK_msdyn_rmaproduct_Tasks)
- [msdyn_rmareceipt_Tasks](#BKMK_msdyn_rmareceipt_Tasks)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)
- [msdyn_rmasubstatus_Tasks](#BKMK_msdyn_rmasubstatus_Tasks)
- [msdyn_rtv_Tasks](#BKMK_msdyn_rtv_Tasks)
- [msdyn_rtvproduct_Tasks](#BKMK_msdyn_rtvproduct_Tasks)
- [msdyn_rtvsubstatus_Tasks](#BKMK_msdyn_rtvsubstatus_Tasks)
- [msdyn_shipvia_Tasks](#BKMK_msdyn_shipvia_Tasks)
- [msdyn_systemuserschedulersetting_Tasks](#BKMK_msdyn_systemuserschedulersetting_Tasks)
- [msdyn_timegroup_Tasks](#BKMK_msdyn_timegroup_Tasks)
- [msdyn_timegroupdetail_Tasks](#BKMK_msdyn_timegroupdetail_Tasks)
- [msdyn_timeoffrequest_Tasks](#BKMK_msdyn_timeoffrequest_Tasks)
- [msdyn_warehouse_Tasks](#BKMK_msdyn_warehouse_Tasks)
- [msdyn_workorder_Tasks](#BKMK_msdyn_workorder_Tasks)
- [msdyn_workordercharacteristic_Tasks](#BKMK_msdyn_workordercharacteristic_Tasks)
- [msdyn_workorderincident_Tasks](#BKMK_msdyn_workorderincident_Tasks)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)
- [msdyn_workorderresourcerestriction_Tasks](#BKMK_msdyn_workorderresourcerestriction_Tasks)
- [msdyn_workorderservice_Tasks](#BKMK_msdyn_workorderservice_Tasks)
- [msdyn_workorderservicetask_Tasks](#BKMK_msdyn_workorderservicetask_Tasks)

### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Tasks](msdyn_agreement.md#BKMK_msdyn_agreement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Tasks"></a> msdyn_agreementbookingdate_Tasks

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Tasks](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Tasks"></a> msdyn_agreementbookingincident_Tasks

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Tasks](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Tasks"></a> msdyn_agreementbookingproduct_Tasks

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Tasks](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Tasks"></a> msdyn_agreementbookingservice_Tasks

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Tasks](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Tasks"></a> msdyn_agreementbookingservicetask_Tasks

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Tasks](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Tasks](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Tasks"></a> msdyn_agreementinvoicedate_Tasks

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Tasks](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Tasks"></a> msdyn_agreementinvoiceproduct_Tasks

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Tasks](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Tasks"></a> msdyn_agreementinvoicesetup_Tasks

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Tasks](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Tasks"></a> msdyn_bookingalertstatus_Tasks

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Tasks](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Tasks"></a> msdyn_bookingrule_Tasks

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Tasks](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Tasks](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Tasks](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Tasks"></a> msdyn_incidenttypecharacteristic_Tasks

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Tasks](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Tasks](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Tasks](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Tasks"></a> msdyn_inventoryadjustment_Tasks

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Tasks](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Tasks"></a> msdyn_inventoryadjustmentproduct_Tasks

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Tasks](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Tasks"></a> msdyn_inventoryjournal_Tasks

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Tasks](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Tasks"></a> msdyn_inventorytransfer_Tasks

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Tasks](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Tasks"></a> msdyn_payment_Tasks

One-To-Many Relationship: [msdyn_payment msdyn_payment_Tasks](msdyn_payment.md#BKMK_msdyn_payment_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Tasks"></a> msdyn_paymentdetail_Tasks

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Tasks](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Tasks"></a> msdyn_paymentmethod_Tasks

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Tasks](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Tasks"></a> msdyn_paymentterm_Tasks

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Tasks](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Tasks"></a> msdyn_postalcode_Tasks

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Tasks](msdyn_postalcode.md#BKMK_msdyn_postalcode_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Tasks"></a> msdyn_productinventory_Tasks

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Tasks](msdyn_productinventory.md#BKMK_msdyn_productinventory_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Tasks](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Tasks](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Tasks"></a> msdyn_purchaseorderproduct_Tasks

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Tasks](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Tasks](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Tasks](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Tasks"></a> msdyn_purchaseordersubstatus_Tasks

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Tasks](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Tasks](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Tasks](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Tasks"></a> msdyn_quotebookingservice_Tasks

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Tasks](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Tasks](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Tasks"></a> msdyn_resourceterritory_Tasks

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Tasks](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

One-To-Many Relationship: [msdyn_rma msdyn_rma_Tasks](msdyn_rma.md#BKMK_msdyn_rma_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Tasks"></a> msdyn_rmaproduct_Tasks

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Tasks](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Tasks"></a> msdyn_rmareceipt_Tasks

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Tasks](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Tasks](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Tasks"></a> msdyn_rmasubstatus_Tasks

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Tasks](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Tasks](msdyn_rtv.md#BKMK_msdyn_rtv_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Tasks"></a> msdyn_rtvproduct_Tasks

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Tasks](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Tasks"></a> msdyn_rtvsubstatus_Tasks

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Tasks](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Tasks"></a> msdyn_shipvia_Tasks

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Tasks](msdyn_shipvia.md#BKMK_msdyn_shipvia_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Tasks](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Tasks"></a> msdyn_timegroup_Tasks

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Tasks](msdyn_timegroup.md#BKMK_msdyn_timegroup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Tasks](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Tasks"></a> msdyn_timeoffrequest_Tasks

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Tasks](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Tasks"></a> msdyn_warehouse_Tasks

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Tasks](msdyn_warehouse.md#BKMK_msdyn_warehouse_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Tasks](msdyn_workorder.md#BKMK_msdyn_workorder_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_Tasks"></a> msdyn_workordercharacteristic_Tasks

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_Tasks](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Tasks](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Tasks](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Tasks](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Tasks](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Tasks](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.task?displayProperty=fullName>
