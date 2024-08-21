---
title: "Phone Call (PhoneCall) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Phone Call (PhoneCall) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Phone Call (PhoneCall) table/entity reference

Activity to track a telephone call.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Phone Call (PhoneCall) table extends the [Microsoft Dataverse Phone Call (PhoneCall) table](/power-apps/developer/data-platform/reference/entities/phonecall).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_PhoneCalls](#BKMK_msdyn_agreement_PhoneCalls)
- [msdyn_agreementbookingdate_PhoneCalls](#BKMK_msdyn_agreementbookingdate_PhoneCalls)
- [msdyn_agreementbookingincident_PhoneCalls](#BKMK_msdyn_agreementbookingincident_PhoneCalls)
- [msdyn_agreementbookingproduct_PhoneCalls](#BKMK_msdyn_agreementbookingproduct_PhoneCalls)
- [msdyn_agreementbookingservice_PhoneCalls](#BKMK_msdyn_agreementbookingservice_PhoneCalls)
- [msdyn_agreementbookingservicetask_PhoneCalls](#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementinvoicedate_PhoneCalls](#BKMK_msdyn_agreementinvoicedate_PhoneCalls)
- [msdyn_agreementinvoiceproduct_PhoneCalls](#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)
- [msdyn_agreementinvoicesetup_PhoneCalls](#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)
- [msdyn_bookingalertstatus_PhoneCalls](#BKMK_msdyn_bookingalertstatus_PhoneCalls)
- [msdyn_bookingrule_PhoneCalls](#BKMK_msdyn_bookingrule_PhoneCalls)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_fieldservicesetting_PhoneCalls](#BKMK_msdyn_fieldservicesetting_PhoneCalls)
- [msdyn_incidenttypecharacteristic_PhoneCalls](#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls)
- [msdyn_incidenttypeproduct_PhoneCalls](#BKMK_msdyn_incidenttypeproduct_PhoneCalls)
- [msdyn_incidenttypeservice_PhoneCalls](#BKMK_msdyn_incidenttypeservice_PhoneCalls)
- [msdyn_inventoryadjustment_PhoneCalls](#BKMK_msdyn_inventoryadjustment_PhoneCalls)
- [msdyn_inventoryadjustmentproduct_PhoneCalls](#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls)
- [msdyn_inventoryjournal_PhoneCalls](#BKMK_msdyn_inventoryjournal_PhoneCalls)
- [msdyn_inventorytransfer_PhoneCalls](#BKMK_msdyn_inventorytransfer_PhoneCalls)
- [msdyn_payment_PhoneCalls](#BKMK_msdyn_payment_PhoneCalls)
- [msdyn_paymentdetail_PhoneCalls](#BKMK_msdyn_paymentdetail_PhoneCalls)
- [msdyn_paymentmethod_PhoneCalls](#BKMK_msdyn_paymentmethod_PhoneCalls)
- [msdyn_paymentterm_PhoneCalls](#BKMK_msdyn_paymentterm_PhoneCalls)
- [msdyn_postalcode_PhoneCalls](#BKMK_msdyn_postalcode_PhoneCalls)
- [msdyn_productinventory_PhoneCalls](#BKMK_msdyn_productinventory_PhoneCalls)
- [msdyn_purchaseorder_PhoneCalls](#BKMK_msdyn_purchaseorder_PhoneCalls)
- [msdyn_purchaseorderbill_PhoneCalls](#BKMK_msdyn_purchaseorderbill_PhoneCalls)
- [msdyn_purchaseorderproduct_PhoneCalls](#BKMK_msdyn_purchaseorderproduct_PhoneCalls)
- [msdyn_purchaseorderreceipt_PhoneCalls](#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)
- [msdyn_purchaseorderreceiptproduct_PhoneCalls](#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)
- [msdyn_purchaseordersubstatus_PhoneCalls](#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)
- [msdyn_quotebookingincident_PhoneCalls](#BKMK_msdyn_quotebookingincident_PhoneCalls)
- [msdyn_quotebookingproduct_PhoneCalls](#BKMK_msdyn_quotebookingproduct_PhoneCalls)
- [msdyn_quotebookingservice_PhoneCalls](#BKMK_msdyn_quotebookingservice_PhoneCalls)
- [msdyn_quotebookingservicetask_PhoneCalls](#BKMK_msdyn_quotebookingservicetask_PhoneCalls)
- [msdyn_resourceterritory_PhoneCalls](#BKMK_msdyn_resourceterritory_PhoneCalls)
- [msdyn_rma_PhoneCalls](#BKMK_msdyn_rma_PhoneCalls)
- [msdyn_rmaproduct_PhoneCalls](#BKMK_msdyn_rmaproduct_PhoneCalls)
- [msdyn_rmareceipt_PhoneCalls](#BKMK_msdyn_rmareceipt_PhoneCalls)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmasubstatus_PhoneCalls](#BKMK_msdyn_rmasubstatus_PhoneCalls)
- [msdyn_rtv_PhoneCalls](#BKMK_msdyn_rtv_PhoneCalls)
- [msdyn_rtvproduct_PhoneCalls](#BKMK_msdyn_rtvproduct_PhoneCalls)
- [msdyn_rtvsubstatus_PhoneCalls](#BKMK_msdyn_rtvsubstatus_PhoneCalls)
- [msdyn_shipvia_PhoneCalls](#BKMK_msdyn_shipvia_PhoneCalls)
- [msdyn_systemuserschedulersetting_PhoneCalls](#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)
- [msdyn_timegroup_PhoneCalls](#BKMK_msdyn_timegroup_PhoneCalls)
- [msdyn_timegroupdetail_PhoneCalls](#BKMK_msdyn_timegroupdetail_PhoneCalls)
- [msdyn_timeoffrequest_PhoneCalls](#BKMK_msdyn_timeoffrequest_PhoneCalls)
- [msdyn_warehouse_PhoneCalls](#BKMK_msdyn_warehouse_PhoneCalls)
- [msdyn_workorder_PhoneCalls](#BKMK_msdyn_workorder_PhoneCalls)
- [msdyn_workordercharacteristic_PhoneCalls](#BKMK_msdyn_workordercharacteristic_PhoneCalls)
- [msdyn_workorderincident_PhoneCalls](#BKMK_msdyn_workorderincident_PhoneCalls)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderresourcerestriction_PhoneCalls](#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)
- [msdyn_workorderservice_PhoneCalls](#BKMK_msdyn_workorderservice_PhoneCalls)
- [msdyn_workorderservicetask_PhoneCalls](#BKMK_msdyn_workorderservicetask_PhoneCalls)

### <a name="BKMK_msdyn_agreement_PhoneCalls"></a> msdyn_agreement_PhoneCalls

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_PhoneCalls](msdyn_agreement.md#BKMK_msdyn_agreement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_PhoneCalls"></a> msdyn_agreementbookingdate_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_PhoneCalls](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_PhoneCalls"></a> msdyn_agreementbookingincident_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_PhoneCalls](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_PhoneCalls"></a> msdyn_agreementbookingproduct_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_PhoneCalls](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_PhoneCalls"></a> msdyn_agreementbookingservice_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_PhoneCalls](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_PhoneCalls"></a> msdyn_agreementbookingservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_PhoneCalls](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_PhoneCalls](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_PhoneCalls"></a> msdyn_agreementinvoicedate_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_PhoneCalls](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_PhoneCalls"></a> msdyn_agreementinvoiceproduct_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_PhoneCalls](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_PhoneCalls"></a> msdyn_agreementinvoicesetup_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_PhoneCalls](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_PhoneCalls"></a> msdyn_bookingalertstatus_PhoneCalls

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_PhoneCalls](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_PhoneCalls"></a> msdyn_bookingrule_PhoneCalls

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_PhoneCalls](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_PhoneCalls](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_PhoneCalls"></a> msdyn_fieldservicesetting_PhoneCalls

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_PhoneCalls](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_PhoneCalls"></a> msdyn_incidenttypecharacteristic_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_PhoneCalls](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_PhoneCalls"></a> msdyn_incidenttypeproduct_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_PhoneCalls](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_PhoneCalls"></a> msdyn_incidenttypeservice_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_PhoneCalls](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_PhoneCalls"></a> msdyn_inventoryadjustment_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_PhoneCalls](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls"></a> msdyn_inventoryadjustmentproduct_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_PhoneCalls](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_PhoneCalls"></a> msdyn_inventoryjournal_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_PhoneCalls](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_PhoneCalls"></a> msdyn_inventorytransfer_PhoneCalls

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_PhoneCalls](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_PhoneCalls"></a> msdyn_payment_PhoneCalls

One-To-Many Relationship: [msdyn_payment msdyn_payment_PhoneCalls](msdyn_payment.md#BKMK_msdyn_payment_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_PhoneCalls"></a> msdyn_paymentdetail_PhoneCalls

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_PhoneCalls](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_PhoneCalls"></a> msdyn_paymentmethod_PhoneCalls

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_PhoneCalls](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_PhoneCalls"></a> msdyn_paymentterm_PhoneCalls

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_PhoneCalls](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_PhoneCalls"></a> msdyn_postalcode_PhoneCalls

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_PhoneCalls](msdyn_postalcode.md#BKMK_msdyn_postalcode_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_PhoneCalls"></a> msdyn_productinventory_PhoneCalls

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_PhoneCalls](msdyn_productinventory.md#BKMK_msdyn_productinventory_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_PhoneCalls"></a> msdyn_purchaseorder_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_PhoneCalls](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_PhoneCalls"></a> msdyn_purchaseorderbill_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_PhoneCalls](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_PhoneCalls"></a> msdyn_purchaseorderproduct_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_PhoneCalls](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_PhoneCalls"></a> msdyn_purchaseorderreceipt_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_PhoneCalls](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls"></a> msdyn_purchaseorderreceiptproduct_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_PhoneCalls](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_PhoneCalls"></a> msdyn_purchaseordersubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_PhoneCalls](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_PhoneCalls"></a> msdyn_quotebookingincident_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_PhoneCalls](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_PhoneCalls"></a> msdyn_quotebookingproduct_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_PhoneCalls](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_PhoneCalls"></a> msdyn_quotebookingservice_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_PhoneCalls](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_PhoneCalls"></a> msdyn_quotebookingservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_PhoneCalls](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_PhoneCalls"></a> msdyn_resourceterritory_PhoneCalls

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_PhoneCalls](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_PhoneCalls"></a> msdyn_rma_PhoneCalls

One-To-Many Relationship: [msdyn_rma msdyn_rma_PhoneCalls](msdyn_rma.md#BKMK_msdyn_rma_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_PhoneCalls"></a> msdyn_rmaproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_PhoneCalls](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_PhoneCalls"></a> msdyn_rmareceipt_PhoneCalls

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_PhoneCalls](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_PhoneCalls](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_PhoneCalls"></a> msdyn_rmasubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_PhoneCalls](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_PhoneCalls"></a> msdyn_rtv_PhoneCalls

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_PhoneCalls](msdyn_rtv.md#BKMK_msdyn_rtv_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_PhoneCalls"></a> msdyn_rtvproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_PhoneCalls](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_PhoneCalls"></a> msdyn_rtvsubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_PhoneCalls](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_PhoneCalls"></a> msdyn_shipvia_PhoneCalls

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_PhoneCalls](msdyn_shipvia.md#BKMK_msdyn_shipvia_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_PhoneCalls"></a> msdyn_systemuserschedulersetting_PhoneCalls

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_PhoneCalls](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_PhoneCalls"></a> msdyn_timegroup_PhoneCalls

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_PhoneCalls](msdyn_timegroup.md#BKMK_msdyn_timegroup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_PhoneCalls"></a> msdyn_timegroupdetail_PhoneCalls

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_PhoneCalls](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_PhoneCalls"></a> msdyn_timeoffrequest_PhoneCalls

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_PhoneCalls](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_PhoneCalls"></a> msdyn_warehouse_PhoneCalls

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_PhoneCalls](msdyn_warehouse.md#BKMK_msdyn_warehouse_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_PhoneCalls"></a> msdyn_workorder_PhoneCalls

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_PhoneCalls](msdyn_workorder.md#BKMK_msdyn_workorder_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_PhoneCalls"></a> msdyn_workordercharacteristic_PhoneCalls

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_PhoneCalls](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_PhoneCalls"></a> msdyn_workorderincident_PhoneCalls

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_PhoneCalls](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_PhoneCalls](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_PhoneCalls"></a> msdyn_workorderresourcerestriction_PhoneCalls

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_PhoneCalls](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_PhoneCalls"></a> msdyn_workorderservice_PhoneCalls

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_PhoneCalls](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_PhoneCalls"></a> msdyn_workorderservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_PhoneCalls](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.phonecall?displayProperty=fullName>
