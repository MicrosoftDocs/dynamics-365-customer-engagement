---
title: "Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Recurring Appointment (RecurringAppointmentMaster) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Recurring Appointment (RecurringAppointmentMaster) table/entity reference

The Master appointment of a recurring appointment series.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Recurring Appointment (RecurringAppointmentMaster) table extends the [Microsoft Dynamics 365 Recurring Appointment (RecurringAppointmentMaster) table](/dynamics365/developer/entities/recurringappointmentmaster).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_RecurringAppointmentMasters](#BKMK_msdyn_agreement_RecurringAppointmentMasters)
- [msdyn_agreementbookingdate_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters)
- [msdyn_agreementbookingincident_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters)
- [msdyn_agreementbookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters)
- [msdyn_agreementbookingservice_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)
- [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementinvoicedate_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)
- [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)
- [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)
- [msdyn_bookingalertstatus_RecurringAppointmentMasters](#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters)
- [msdyn_bookingrule_RecurringAppointmentMasters](#BKMK_msdyn_bookingrule_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_fieldservicesetting_RecurringAppointmentMasters](#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)
- [msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters)
- [msdyn_incidenttypeproduct_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)
- [msdyn_incidenttypeservice_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)
- [msdyn_inventoryadjustment_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)
- [msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters)
- [msdyn_inventoryjournal_RecurringAppointmentMasters](#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)
- [msdyn_inventorytransfer_RecurringAppointmentMasters](#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)
- [msdyn_payment_RecurringAppointmentMasters](#BKMK_msdyn_payment_RecurringAppointmentMasters)
- [msdyn_paymentdetail_RecurringAppointmentMasters](#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters)
- [msdyn_paymentmethod_RecurringAppointmentMasters](#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters)
- [msdyn_paymentterm_RecurringAppointmentMasters](#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)
- [msdyn_postalcode_RecurringAppointmentMasters](#BKMK_msdyn_postalcode_RecurringAppointmentMasters)
- [msdyn_productinventory_RecurringAppointmentMasters](#BKMK_msdyn_productinventory_RecurringAppointmentMasters)
- [msdyn_purchaseorder_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)
- [msdyn_purchaseorderbill_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)
- [msdyn_purchaseorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)
- [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)
- [msdyn_quotebookingincident_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)
- [msdyn_quotebookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)
- [msdyn_quotebookingservice_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)
- [msdyn_quotebookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)
- [msdyn_resourceterritory_RecurringAppointmentMasters](#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters)
- [msdyn_rma_RecurringAppointmentMasters](#BKMK_msdyn_rma_RecurringAppointmentMasters)
- [msdyn_rmaproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)
- [msdyn_rmareceipt_RecurringAppointmentMasters](#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmasubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters)
- [msdyn_rtv_RecurringAppointmentMasters](#BKMK_msdyn_rtv_RecurringAppointmentMasters)
- [msdyn_rtvproduct_RecurringAppointmentMasters](#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)
- [msdyn_rtvsubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)
- [msdyn_shipvia_RecurringAppointmentMasters](#BKMK_msdyn_shipvia_RecurringAppointmentMasters)
- [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)
- [msdyn_timegroup_RecurringAppointmentMasters](#BKMK_msdyn_timegroup_RecurringAppointmentMasters)
- [msdyn_timegroupdetail_RecurringAppointmentMasters](#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)
- [msdyn_timeoffrequest_RecurringAppointmentMasters](#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters)
- [msdyn_warehouse_RecurringAppointmentMasters](#BKMK_msdyn_warehouse_RecurringAppointmentMasters)
- [msdyn_workorder_RecurringAppointmentMasters](#BKMK_msdyn_workorder_RecurringAppointmentMasters)
- [msdyn_workorderincident_RecurringAppointmentMasters](#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)
- [msdyn_workorderservice_RecurringAppointmentMasters](#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)
- [msdyn_workorderservicetask_RecurringAppointmentMasters](#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)

### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_RecurringAppointmentMasters](msdyn_agreement.md#BKMK_msdyn_agreement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters"></a> msdyn_agreementbookingdate_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_RecurringAppointmentMasters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters"></a> msdyn_agreementbookingincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_RecurringAppointmentMasters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters"></a> msdyn_agreementbookingproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_RecurringAppointmentMasters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters"></a> msdyn_agreementbookingservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_RecurringAppointmentMasters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters"></a> msdyn_agreementbookingservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_RecurringAppointmentMasters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_RecurringAppointmentMasters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters"></a> msdyn_agreementinvoicedate_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_RecurringAppointmentMasters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters"></a> msdyn_agreementinvoiceproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters"></a> msdyn_agreementinvoicesetup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_RecurringAppointmentMasters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters"></a> msdyn_bookingalertstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_RecurringAppointmentMasters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_RecurringAppointmentMasters"></a> msdyn_bookingrule_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_RecurringAppointmentMasters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_RecurringAppointmentMasters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_RecurringAppointmentMasters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters"></a> msdyn_incidenttypecharacteristic_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_RecurringAppointmentMasters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_RecurringAppointmentMasters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters"></a> msdyn_inventoryadjustment_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_RecurringAppointmentMasters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters"></a> msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters"></a> msdyn_inventoryjournal_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_RecurringAppointmentMasters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters"></a> msdyn_inventorytransfer_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_RecurringAppointmentMasters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_RecurringAppointmentMasters"></a> msdyn_payment_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_payment msdyn_payment_RecurringAppointmentMasters](msdyn_payment.md#BKMK_msdyn_payment_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_RecurringAppointmentMasters"></a> msdyn_paymentdetail_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_RecurringAppointmentMasters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_RecurringAppointmentMasters"></a> msdyn_paymentmethod_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_RecurringAppointmentMasters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_RecurringAppointmentMasters"></a> msdyn_paymentterm_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_RecurringAppointmentMasters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_RecurringAppointmentMasters"></a> msdyn_postalcode_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_RecurringAppointmentMasters](msdyn_postalcode.md#BKMK_msdyn_postalcode_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_RecurringAppointmentMasters"></a> msdyn_productinventory_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_RecurringAppointmentMasters](msdyn_productinventory.md#BKMK_msdyn_productinventory_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_RecurringAppointmentMasters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_RecurringAppointmentMasters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_RecurringAppointmentMasters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_RecurringAppointmentMasters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters"></a> msdyn_purchaseordersubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_RecurringAppointmentMasters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_RecurringAppointmentMasters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_RecurringAppointmentMasters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters"></a> msdyn_quotebookingservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_RecurringAppointmentMasters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_RecurringAppointmentMasters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_RecurringAppointmentMasters"></a> msdyn_resourceterritory_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_RecurringAppointmentMasters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rma msdyn_rma_RecurringAppointmentMasters](msdyn_rma.md#BKMK_msdyn_rma_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_RecurringAppointmentMasters"></a> msdyn_rmaproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_RecurringAppointmentMasters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_RecurringAppointmentMasters"></a> msdyn_rmareceipt_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_RecurringAppointmentMasters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_RecurringAppointmentMasters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters"></a> msdyn_rmasubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_RecurringAppointmentMasters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_RecurringAppointmentMasters](msdyn_rtv.md#BKMK_msdyn_rtv_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_RecurringAppointmentMasters"></a> msdyn_rtvproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_RecurringAppointmentMasters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters"></a> msdyn_rtvsubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_RecurringAppointmentMasters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_RecurringAppointmentMasters"></a> msdyn_shipvia_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_RecurringAppointmentMasters](msdyn_shipvia.md#BKMK_msdyn_shipvia_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters"></a> msdyn_systemuserschedulersetting_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_RecurringAppointmentMasters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_RecurringAppointmentMasters"></a> msdyn_timegroup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_RecurringAppointmentMasters](msdyn_timegroup.md#BKMK_msdyn_timegroup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters"></a> msdyn_timegroupdetail_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_RecurringAppointmentMasters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters"></a> msdyn_timeoffrequest_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_RecurringAppointmentMasters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_RecurringAppointmentMasters"></a> msdyn_warehouse_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_RecurringAppointmentMasters](msdyn_warehouse.md#BKMK_msdyn_warehouse_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_RecurringAppointmentMasters](msdyn_workorder.md#BKMK_msdyn_workorder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_RecurringAppointmentMasters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_RecurringAppointmentMasters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_RecurringAppointmentMasters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_RecurringAppointmentMasters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_RecurringAppointmentMasters](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.recurringappointmentmaster?displayProperty=fullName>
