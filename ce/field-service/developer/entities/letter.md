---
title: "Letter table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Letter table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Letter table/entity reference

Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Letter table extends the [Microsoft Dynamics 365 Letter table](/dynamics365/developer/entities/letter).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/letter#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_Letters](#BKMK_msdyn_agreement_Letters)
- [msdyn_agreementbookingdate_Letters](#BKMK_msdyn_agreementbookingdate_Letters)
- [msdyn_agreementbookingincident_Letters](#BKMK_msdyn_agreementbookingincident_Letters)
- [msdyn_agreementbookingproduct_Letters](#BKMK_msdyn_agreementbookingproduct_Letters)
- [msdyn_agreementbookingservice_Letters](#BKMK_msdyn_agreementbookingservice_Letters)
- [msdyn_agreementbookingservicetask_Letters](#BKMK_msdyn_agreementbookingservicetask_Letters)
- [msdyn_agreementbookingsetup_Letters](#BKMK_msdyn_agreementbookingsetup_Letters)
- [msdyn_agreementinvoicedate_Letters](#BKMK_msdyn_agreementinvoicedate_Letters)
- [msdyn_agreementinvoiceproduct_Letters](#BKMK_msdyn_agreementinvoiceproduct_Letters)
- [msdyn_agreementinvoicesetup_Letters](#BKMK_msdyn_agreementinvoicesetup_Letters)
- [msdyn_bookingalertstatus_Letters](#BKMK_msdyn_bookingalertstatus_Letters)
- [msdyn_bookingrule_Letters](#BKMK_msdyn_bookingrule_Letters)
- [msdyn_bookingtimestamp_Letters](#BKMK_msdyn_bookingtimestamp_Letters)
- [msdyn_fieldservicesetting_Letters](#BKMK_msdyn_fieldservicesetting_Letters)
- [msdyn_incidenttypecharacteristic_Letters](#BKMK_msdyn_incidenttypecharacteristic_Letters)
- [msdyn_incidenttypeproduct_Letters](#BKMK_msdyn_incidenttypeproduct_Letters)
- [msdyn_incidenttypeservice_Letters](#BKMK_msdyn_incidenttypeservice_Letters)
- [msdyn_inventoryadjustment_Letters](#BKMK_msdyn_inventoryadjustment_Letters)
- [msdyn_inventoryadjustmentproduct_Letters](#BKMK_msdyn_inventoryadjustmentproduct_Letters)
- [msdyn_inventoryjournal_Letters](#BKMK_msdyn_inventoryjournal_Letters)
- [msdyn_inventorytransfer_Letters](#BKMK_msdyn_inventorytransfer_Letters)
- [msdyn_payment_Letters](#BKMK_msdyn_payment_Letters)
- [msdyn_paymentdetail_Letters](#BKMK_msdyn_paymentdetail_Letters)
- [msdyn_paymentmethod_Letters](#BKMK_msdyn_paymentmethod_Letters)
- [msdyn_paymentterm_Letters](#BKMK_msdyn_paymentterm_Letters)
- [msdyn_postalcode_Letters](#BKMK_msdyn_postalcode_Letters)
- [msdyn_productinventory_Letters](#BKMK_msdyn_productinventory_Letters)
- [msdyn_purchaseorder_Letters](#BKMK_msdyn_purchaseorder_Letters)
- [msdyn_purchaseorderbill_Letters](#BKMK_msdyn_purchaseorderbill_Letters)
- [msdyn_purchaseorderproduct_Letters](#BKMK_msdyn_purchaseorderproduct_Letters)
- [msdyn_purchaseorderreceipt_Letters](#BKMK_msdyn_purchaseorderreceipt_Letters)
- [msdyn_purchaseorderreceiptproduct_Letters](#BKMK_msdyn_purchaseorderreceiptproduct_Letters)
- [msdyn_purchaseordersubstatus_Letters](#BKMK_msdyn_purchaseordersubstatus_Letters)
- [msdyn_quotebookingincident_Letters](#BKMK_msdyn_quotebookingincident_Letters)
- [msdyn_quotebookingproduct_Letters](#BKMK_msdyn_quotebookingproduct_Letters)
- [msdyn_quotebookingservice_Letters](#BKMK_msdyn_quotebookingservice_Letters)
- [msdyn_quotebookingservicetask_Letters](#BKMK_msdyn_quotebookingservicetask_Letters)
- [msdyn_resourceterritory_Letters](#BKMK_msdyn_resourceterritory_Letters)
- [msdyn_rma_Letters](#BKMK_msdyn_rma_Letters)
- [msdyn_rmaproduct_Letters](#BKMK_msdyn_rmaproduct_Letters)
- [msdyn_rmareceipt_Letters](#BKMK_msdyn_rmareceipt_Letters)
- [msdyn_rmareceiptproduct_Letters](#BKMK_msdyn_rmareceiptproduct_Letters)
- [msdyn_rmasubstatus_Letters](#BKMK_msdyn_rmasubstatus_Letters)
- [msdyn_rtv_Letters](#BKMK_msdyn_rtv_Letters)
- [msdyn_rtvproduct_Letters](#BKMK_msdyn_rtvproduct_Letters)
- [msdyn_rtvsubstatus_Letters](#BKMK_msdyn_rtvsubstatus_Letters)
- [msdyn_shipvia_Letters](#BKMK_msdyn_shipvia_Letters)
- [msdyn_systemuserschedulersetting_Letters](#BKMK_msdyn_systemuserschedulersetting_Letters)
- [msdyn_timegroup_Letters](#BKMK_msdyn_timegroup_Letters)
- [msdyn_timegroupdetail_Letters](#BKMK_msdyn_timegroupdetail_Letters)
- [msdyn_timeoffrequest_Letters](#BKMK_msdyn_timeoffrequest_Letters)
- [msdyn_warehouse_Letters](#BKMK_msdyn_warehouse_Letters)
- [msdyn_workorder_Letters](#BKMK_msdyn_workorder_Letters)
- [msdyn_workorderincident_Letters](#BKMK_msdyn_workorderincident_Letters)
- [msdyn_workorderproduct_Letters](#BKMK_msdyn_workorderproduct_Letters)
- [msdyn_workorderresourcerestriction_Letters](#BKMK_msdyn_workorderresourcerestriction_Letters)
- [msdyn_workorderservice_Letters](#BKMK_msdyn_workorderservice_Letters)
- [msdyn_workorderservicetask_Letters](#BKMK_msdyn_workorderservicetask_Letters)

### <a name="BKMK_msdyn_agreement_Letters"></a> msdyn_agreement_Letters

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Letters](msdyn_agreement.md#BKMK_msdyn_agreement_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Letters"></a> msdyn_agreementbookingdate_Letters

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Letters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Letters"></a> msdyn_agreementbookingincident_Letters

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Letters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Letters"></a> msdyn_agreementbookingproduct_Letters

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Letters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Letters"></a> msdyn_agreementbookingservice_Letters

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Letters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Letters"></a> msdyn_agreementbookingservicetask_Letters

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Letters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Letters"></a> msdyn_agreementbookingsetup_Letters

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Letters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Letters"></a> msdyn_agreementinvoicedate_Letters

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Letters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Letters"></a> msdyn_agreementinvoiceproduct_Letters

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Letters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Letters"></a> msdyn_agreementinvoicesetup_Letters

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Letters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Letters"></a> msdyn_bookingalertstatus_Letters

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Letters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Letters"></a> msdyn_bookingrule_Letters

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Letters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Letters"></a> msdyn_bookingtimestamp_Letters

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Letters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Letters"></a> msdyn_fieldservicesetting_Letters

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Letters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Letters"></a> msdyn_incidenttypecharacteristic_Letters

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Letters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Letters"></a> msdyn_incidenttypeproduct_Letters

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Letters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Letters"></a> msdyn_incidenttypeservice_Letters

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Letters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Letters"></a> msdyn_inventoryadjustment_Letters

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Letters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Letters"></a> msdyn_inventoryadjustmentproduct_Letters

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Letters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Letters"></a> msdyn_inventoryjournal_Letters

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Letters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Letters"></a> msdyn_inventorytransfer_Letters

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Letters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Letters"></a> msdyn_payment_Letters

One-To-Many Relationship: [msdyn_payment msdyn_payment_Letters](msdyn_payment.md#BKMK_msdyn_payment_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Letters"></a> msdyn_paymentdetail_Letters

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Letters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Letters"></a> msdyn_paymentmethod_Letters

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Letters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Letters"></a> msdyn_paymentterm_Letters

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Letters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Letters"></a> msdyn_postalcode_Letters

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Letters](msdyn_postalcode.md#BKMK_msdyn_postalcode_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Letters"></a> msdyn_productinventory_Letters

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Letters](msdyn_productinventory.md#BKMK_msdyn_productinventory_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Letters"></a> msdyn_purchaseorder_Letters

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Letters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Letters"></a> msdyn_purchaseorderbill_Letters

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Letters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Letters"></a> msdyn_purchaseorderproduct_Letters

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Letters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Letters"></a> msdyn_purchaseorderreceipt_Letters

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Letters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Letters"></a> msdyn_purchaseorderreceiptproduct_Letters

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Letters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Letters"></a> msdyn_purchaseordersubstatus_Letters

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Letters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Letters"></a> msdyn_quotebookingincident_Letters

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Letters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Letters"></a> msdyn_quotebookingproduct_Letters

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Letters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Letters"></a> msdyn_quotebookingservice_Letters

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Letters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Letters"></a> msdyn_quotebookingservicetask_Letters

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Letters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Letters"></a> msdyn_resourceterritory_Letters

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Letters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Letters"></a> msdyn_rma_Letters

One-To-Many Relationship: [msdyn_rma msdyn_rma_Letters](msdyn_rma.md#BKMK_msdyn_rma_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Letters"></a> msdyn_rmaproduct_Letters

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Letters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Letters"></a> msdyn_rmareceipt_Letters

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Letters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Letters"></a> msdyn_rmareceiptproduct_Letters

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Letters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Letters"></a> msdyn_rmasubstatus_Letters

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Letters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Letters"></a> msdyn_rtv_Letters

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Letters](msdyn_rtv.md#BKMK_msdyn_rtv_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Letters"></a> msdyn_rtvproduct_Letters

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Letters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Letters"></a> msdyn_rtvsubstatus_Letters

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Letters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Letters"></a> msdyn_shipvia_Letters

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Letters](msdyn_shipvia.md#BKMK_msdyn_shipvia_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Letters"></a> msdyn_systemuserschedulersetting_Letters

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Letters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Letters"></a> msdyn_timegroup_Letters

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Letters](msdyn_timegroup.md#BKMK_msdyn_timegroup_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Letters"></a> msdyn_timegroupdetail_Letters

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Letters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Letters"></a> msdyn_timeoffrequest_Letters

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Letters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Letters"></a> msdyn_warehouse_Letters

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Letters](msdyn_warehouse.md#BKMK_msdyn_warehouse_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Letters"></a> msdyn_workorder_Letters

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Letters](msdyn_workorder.md#BKMK_msdyn_workorder_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Letters"></a> msdyn_workorderincident_Letters

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Letters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Letters"></a> msdyn_workorderproduct_Letters

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Letters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Letters"></a> msdyn_workorderresourcerestriction_Letters

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Letters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Letters"></a> msdyn_workorderservice_Letters

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Letters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Letters"></a> msdyn_workorderservicetask_Letters

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Letters](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Letters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.letter?displayProperty=fullName>
