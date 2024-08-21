---
title: "Appointment table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Appointment table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Appointment table/entity reference

Commitment representing a time interval with start/end times and duration.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Appointment table extends the [Microsoft Dataverse Appointment table](/power-apps/developer/data-platform/reference/entities/appointment).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_Appointments](#BKMK_msdyn_agreement_Appointments)
- [msdyn_agreementbookingdate_Appointments](#BKMK_msdyn_agreementbookingdate_Appointments)
- [msdyn_agreementbookingincident_Appointments](#BKMK_msdyn_agreementbookingincident_Appointments)
- [msdyn_agreementbookingproduct_Appointments](#BKMK_msdyn_agreementbookingproduct_Appointments)
- [msdyn_agreementbookingservice_Appointments](#BKMK_msdyn_agreementbookingservice_Appointments)
- [msdyn_agreementbookingservicetask_Appointments](#BKMK_msdyn_agreementbookingservicetask_Appointments)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementinvoicedate_Appointments](#BKMK_msdyn_agreementinvoicedate_Appointments)
- [msdyn_agreementinvoiceproduct_Appointments](#BKMK_msdyn_agreementinvoiceproduct_Appointments)
- [msdyn_agreementinvoicesetup_Appointments](#BKMK_msdyn_agreementinvoicesetup_Appointments)
- [msdyn_bookingalertstatus_Appointments](#BKMK_msdyn_bookingalertstatus_Appointments)
- [msdyn_bookingrule_Appointments](#BKMK_msdyn_bookingrule_Appointments)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_fieldservicesetting_Appointments](#BKMK_msdyn_fieldservicesetting_Appointments)
- [msdyn_incidenttypecharacteristic_Appointments](#BKMK_msdyn_incidenttypecharacteristic_Appointments)
- [msdyn_incidenttypeproduct_Appointments](#BKMK_msdyn_incidenttypeproduct_Appointments)
- [msdyn_incidenttypeservice_Appointments](#BKMK_msdyn_incidenttypeservice_Appointments)
- [msdyn_inventoryadjustment_Appointments](#BKMK_msdyn_inventoryadjustment_Appointments)
- [msdyn_inventoryadjustmentproduct_Appointments](#BKMK_msdyn_inventoryadjustmentproduct_Appointments)
- [msdyn_inventoryjournal_Appointments](#BKMK_msdyn_inventoryjournal_Appointments)
- [msdyn_inventorytransfer_Appointments](#BKMK_msdyn_inventorytransfer_Appointments)
- [msdyn_payment_Appointments](#BKMK_msdyn_payment_Appointments)
- [msdyn_paymentdetail_Appointments](#BKMK_msdyn_paymentdetail_Appointments)
- [msdyn_paymentmethod_Appointments](#BKMK_msdyn_paymentmethod_Appointments)
- [msdyn_paymentterm_Appointments](#BKMK_msdyn_paymentterm_Appointments)
- [msdyn_postalcode_Appointments](#BKMK_msdyn_postalcode_Appointments)
- [msdyn_productinventory_Appointments](#BKMK_msdyn_productinventory_Appointments)
- [msdyn_purchaseorder_Appointments](#BKMK_msdyn_purchaseorder_Appointments)
- [msdyn_purchaseorderbill_Appointments](#BKMK_msdyn_purchaseorderbill_Appointments)
- [msdyn_purchaseorderproduct_Appointments](#BKMK_msdyn_purchaseorderproduct_Appointments)
- [msdyn_purchaseorderreceipt_Appointments](#BKMK_msdyn_purchaseorderreceipt_Appointments)
- [msdyn_purchaseorderreceiptproduct_Appointments](#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)
- [msdyn_purchaseordersubstatus_Appointments](#BKMK_msdyn_purchaseordersubstatus_Appointments)
- [msdyn_quotebookingincident_Appointments](#BKMK_msdyn_quotebookingincident_Appointments)
- [msdyn_quotebookingproduct_Appointments](#BKMK_msdyn_quotebookingproduct_Appointments)
- [msdyn_quotebookingservice_Appointments](#BKMK_msdyn_quotebookingservice_Appointments)
- [msdyn_quotebookingservicetask_Appointments](#BKMK_msdyn_quotebookingservicetask_Appointments)
- [msdyn_resourceterritory_Appointments](#BKMK_msdyn_resourceterritory_Appointments)
- [msdyn_rma_Appointments](#BKMK_msdyn_rma_Appointments)
- [msdyn_rmaproduct_Appointments](#BKMK_msdyn_rmaproduct_Appointments)
- [msdyn_rmareceipt_Appointments](#BKMK_msdyn_rmareceipt_Appointments)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmasubstatus_Appointments](#BKMK_msdyn_rmasubstatus_Appointments)
- [msdyn_rtv_Appointments](#BKMK_msdyn_rtv_Appointments)
- [msdyn_rtvproduct_Appointments](#BKMK_msdyn_rtvproduct_Appointments)
- [msdyn_rtvsubstatus_Appointments](#BKMK_msdyn_rtvsubstatus_Appointments)
- [msdyn_shipvia_Appointments](#BKMK_msdyn_shipvia_Appointments)
- [msdyn_systemuserschedulersetting_Appointments](#BKMK_msdyn_systemuserschedulersetting_Appointments)
- [msdyn_timegroup_Appointments](#BKMK_msdyn_timegroup_Appointments)
- [msdyn_timegroupdetail_Appointments](#BKMK_msdyn_timegroupdetail_Appointments)
- [msdyn_timeoffrequest_Appointments](#BKMK_msdyn_timeoffrequest_Appointments)
- [msdyn_warehouse_Appointments](#BKMK_msdyn_warehouse_Appointments)
- [msdyn_workorder_Appointments](#BKMK_msdyn_workorder_Appointments)
- [msdyn_workordercharacteristic_Appointments](#BKMK_msdyn_workordercharacteristic_Appointments)
- [msdyn_workorderincident_Appointments](#BKMK_msdyn_workorderincident_Appointments)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderresourcerestriction_Appointments](#BKMK_msdyn_workorderresourcerestriction_Appointments)
- [msdyn_workorderservice_Appointments](#BKMK_msdyn_workorderservice_Appointments)
- [msdyn_workorderservicetask_Appointments](#BKMK_msdyn_workorderservicetask_Appointments)

### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Appointments](msdyn_agreement.md#BKMK_msdyn_agreement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Appointments"></a> msdyn_agreementbookingdate_Appointments

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Appointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Appointments"></a> msdyn_agreementbookingincident_Appointments

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Appointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Appointments"></a> msdyn_agreementbookingproduct_Appointments

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Appointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Appointments"></a> msdyn_agreementbookingservice_Appointments

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Appointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Appointments"></a> msdyn_agreementbookingservicetask_Appointments

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Appointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Appointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Appointments"></a> msdyn_agreementinvoicedate_Appointments

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Appointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Appointments"></a> msdyn_agreementinvoiceproduct_Appointments

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Appointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Appointments"></a> msdyn_agreementinvoicesetup_Appointments

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Appointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Appointments"></a> msdyn_bookingalertstatus_Appointments

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Appointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Appointments"></a> msdyn_bookingrule_Appointments

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Appointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Appointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Appointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Appointments"></a> msdyn_incidenttypecharacteristic_Appointments

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Appointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Appointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Appointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Appointments"></a> msdyn_inventoryadjustment_Appointments

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Appointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Appointments"></a> msdyn_inventoryadjustmentproduct_Appointments

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Appointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Appointments"></a> msdyn_inventoryjournal_Appointments

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Appointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Appointments"></a> msdyn_inventorytransfer_Appointments

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Appointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Appointments"></a> msdyn_payment_Appointments

One-To-Many Relationship: [msdyn_payment msdyn_payment_Appointments](msdyn_payment.md#BKMK_msdyn_payment_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Appointments"></a> msdyn_paymentdetail_Appointments

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Appointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Appointments"></a> msdyn_paymentmethod_Appointments

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Appointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Appointments"></a> msdyn_paymentterm_Appointments

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Appointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Appointments"></a> msdyn_postalcode_Appointments

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Appointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Appointments"></a> msdyn_productinventory_Appointments

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Appointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Appointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Appointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Appointments"></a> msdyn_purchaseorderproduct_Appointments

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Appointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Appointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Appointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Appointments"></a> msdyn_purchaseordersubstatus_Appointments

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Appointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Appointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Appointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Appointments"></a> msdyn_quotebookingservice_Appointments

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Appointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Appointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Appointments"></a> msdyn_resourceterritory_Appointments

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Appointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

One-To-Many Relationship: [msdyn_rma msdyn_rma_Appointments](msdyn_rma.md#BKMK_msdyn_rma_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Appointments"></a> msdyn_rmaproduct_Appointments

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Appointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Appointments"></a> msdyn_rmareceipt_Appointments

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Appointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Appointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Appointments"></a> msdyn_rmasubstatus_Appointments

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Appointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Appointments](msdyn_rtv.md#BKMK_msdyn_rtv_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Appointments"></a> msdyn_rtvproduct_Appointments

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Appointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Appointments"></a> msdyn_rtvsubstatus_Appointments

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Appointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Appointments"></a> msdyn_shipvia_Appointments

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Appointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Appointments"></a> msdyn_systemuserschedulersetting_Appointments

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Appointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Appointments"></a> msdyn_timegroup_Appointments

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Appointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Appointments"></a> msdyn_timegroupdetail_Appointments

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Appointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Appointments"></a> msdyn_timeoffrequest_Appointments

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Appointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Appointments"></a> msdyn_warehouse_Appointments

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Appointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Appointments](msdyn_workorder.md#BKMK_msdyn_workorder_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_Appointments"></a> msdyn_workordercharacteristic_Appointments

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_Appointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Appointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Appointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Appointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Appointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Appointments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
- [msdyn_appointment_msdyn_resourcerequirement](#BKMK_msdyn_appointment_msdyn_resourcerequirement)

### <a name="BKMK_msdyn_appointment_bookableresourcebooking"></a> msdyn_appointment_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking msdyn_appointment_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_appointment_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_appointmentbookingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_resourcerequirement"></a> msdyn_appointment_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_appointment_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_appointment_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_appointmentrequirementid`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.appointment?displayProperty=fullName>
