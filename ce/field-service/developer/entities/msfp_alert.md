---
title: "Customer Voice alert (msfp_alert) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer Voice alert (msfp_alert) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer Voice alert (msfp_alert) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Customer Voice alert (msfp_alert) table extends the [Microsoft Dynamics 365 Customer Voice alert (msfp_alert) table](/dynamics365/developer/entities//msfp_alert).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/entities//msfp_alert#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_msfp_alerts](#BKMK_msdyn_agreement_msfp_alerts)
- [msdyn_agreementbookingdate_msfp_alerts](#BKMK_msdyn_agreementbookingdate_msfp_alerts)
- [msdyn_agreementbookingincident_msfp_alerts](#BKMK_msdyn_agreementbookingincident_msfp_alerts)
- [msdyn_agreementbookingproduct_msfp_alerts](#BKMK_msdyn_agreementbookingproduct_msfp_alerts)
- [msdyn_agreementbookingservice_msfp_alerts](#BKMK_msdyn_agreementbookingservice_msfp_alerts)
- [msdyn_agreementbookingservicetask_msfp_alerts](#BKMK_msdyn_agreementbookingservicetask_msfp_alerts)
- [msdyn_agreementbookingsetup_msfp_alerts](#BKMK_msdyn_agreementbookingsetup_msfp_alerts)
- [msdyn_agreementinvoicedate_msfp_alerts](#BKMK_msdyn_agreementinvoicedate_msfp_alerts)
- [msdyn_agreementinvoiceproduct_msfp_alerts](#BKMK_msdyn_agreementinvoiceproduct_msfp_alerts)
- [msdyn_agreementinvoicesetup_msfp_alerts](#BKMK_msdyn_agreementinvoicesetup_msfp_alerts)
- [msdyn_bookingalertstatus_msfp_alerts](#BKMK_msdyn_bookingalertstatus_msfp_alerts)
- [msdyn_bookingrule_msfp_alerts](#BKMK_msdyn_bookingrule_msfp_alerts)
- [msdyn_bookingtimestamp_msfp_alerts](#BKMK_msdyn_bookingtimestamp_msfp_alerts)
- [msdyn_fieldservicesetting_msfp_alerts](#BKMK_msdyn_fieldservicesetting_msfp_alerts)
- [msdyn_incidenttypecharacteristic_msfp_alerts](#BKMK_msdyn_incidenttypecharacteristic_msfp_alerts)
- [msdyn_incidenttypeproduct_msfp_alerts](#BKMK_msdyn_incidenttypeproduct_msfp_alerts)
- [msdyn_incidenttypeservice_msfp_alerts](#BKMK_msdyn_incidenttypeservice_msfp_alerts)
- [msdyn_inventoryadjustment_msfp_alerts](#BKMK_msdyn_inventoryadjustment_msfp_alerts)
- [msdyn_inventoryadjustmentproduct_msfp_alerts](#BKMK_msdyn_inventoryadjustmentproduct_msfp_alerts)
- [msdyn_inventoryjournal_msfp_alerts](#BKMK_msdyn_inventoryjournal_msfp_alerts)
- [msdyn_inventorytransfer_msfp_alerts](#BKMK_msdyn_inventorytransfer_msfp_alerts)
- [msdyn_payment_msfp_alerts](#BKMK_msdyn_payment_msfp_alerts)
- [msdyn_paymentdetail_msfp_alerts](#BKMK_msdyn_paymentdetail_msfp_alerts)
- [msdyn_paymentmethod_msfp_alerts](#BKMK_msdyn_paymentmethod_msfp_alerts)
- [msdyn_paymentterm_msfp_alerts](#BKMK_msdyn_paymentterm_msfp_alerts)
- [msdyn_postalcode_msfp_alerts](#BKMK_msdyn_postalcode_msfp_alerts)
- [msdyn_productinventory_msfp_alerts](#BKMK_msdyn_productinventory_msfp_alerts)
- [msdyn_purchaseorder_msfp_alerts](#BKMK_msdyn_purchaseorder_msfp_alerts)
- [msdyn_purchaseorderbill_msfp_alerts](#BKMK_msdyn_purchaseorderbill_msfp_alerts)
- [msdyn_purchaseorderproduct_msfp_alerts](#BKMK_msdyn_purchaseorderproduct_msfp_alerts)
- [msdyn_purchaseorderreceipt_msfp_alerts](#BKMK_msdyn_purchaseorderreceipt_msfp_alerts)
- [msdyn_purchaseorderreceiptproduct_msfp_alerts](#BKMK_msdyn_purchaseorderreceiptproduct_msfp_alerts)
- [msdyn_purchaseordersubstatus_msfp_alerts](#BKMK_msdyn_purchaseordersubstatus_msfp_alerts)
- [msdyn_quotebookingincident_msfp_alerts](#BKMK_msdyn_quotebookingincident_msfp_alerts)
- [msdyn_quotebookingproduct_msfp_alerts](#BKMK_msdyn_quotebookingproduct_msfp_alerts)
- [msdyn_quotebookingservice_msfp_alerts](#BKMK_msdyn_quotebookingservice_msfp_alerts)
- [msdyn_quotebookingservicetask_msfp_alerts](#BKMK_msdyn_quotebookingservicetask_msfp_alerts)
- [msdyn_resourceterritory_msfp_alerts](#BKMK_msdyn_resourceterritory_msfp_alerts)
- [msdyn_rma_msfp_alerts](#BKMK_msdyn_rma_msfp_alerts)
- [msdyn_rmaproduct_msfp_alerts](#BKMK_msdyn_rmaproduct_msfp_alerts)
- [msdyn_rmareceipt_msfp_alerts](#BKMK_msdyn_rmareceipt_msfp_alerts)
- [msdyn_rmareceiptproduct_msfp_alerts](#BKMK_msdyn_rmareceiptproduct_msfp_alerts)
- [msdyn_rmasubstatus_msfp_alerts](#BKMK_msdyn_rmasubstatus_msfp_alerts)
- [msdyn_rtv_msfp_alerts](#BKMK_msdyn_rtv_msfp_alerts)
- [msdyn_rtvproduct_msfp_alerts](#BKMK_msdyn_rtvproduct_msfp_alerts)
- [msdyn_rtvsubstatus_msfp_alerts](#BKMK_msdyn_rtvsubstatus_msfp_alerts)
- [msdyn_shipvia_msfp_alerts](#BKMK_msdyn_shipvia_msfp_alerts)
- [msdyn_systemuserschedulersetting_msfp_alerts](#BKMK_msdyn_systemuserschedulersetting_msfp_alerts)
- [msdyn_timegroup_msfp_alerts](#BKMK_msdyn_timegroup_msfp_alerts)
- [msdyn_timegroupdetail_msfp_alerts](#BKMK_msdyn_timegroupdetail_msfp_alerts)
- [msdyn_timeoffrequest_msfp_alerts](#BKMK_msdyn_timeoffrequest_msfp_alerts)
- [msdyn_warehouse_msfp_alerts](#BKMK_msdyn_warehouse_msfp_alerts)
- [msdyn_workorder_msfp_alerts](#BKMK_msdyn_workorder_msfp_alerts)
- [msdyn_workordercharacteristic_msfp_alerts](#BKMK_msdyn_workordercharacteristic_msfp_alerts)
- [msdyn_workorderincident_msfp_alerts](#BKMK_msdyn_workorderincident_msfp_alerts)
- [msdyn_workorderproduct_msfp_alerts](#BKMK_msdyn_workorderproduct_msfp_alerts)
- [msdyn_workorderresourcerestriction_msfp_alerts](#BKMK_msdyn_workorderresourcerestriction_msfp_alerts)
- [msdyn_workorderservice_msfp_alerts](#BKMK_msdyn_workorderservice_msfp_alerts)
- [msdyn_workorderservicetask_msfp_alerts](#BKMK_msdyn_workorderservicetask_msfp_alerts)

### <a name="BKMK_msdyn_agreement_msfp_alerts"></a> msdyn_agreement_msfp_alerts

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msfp_alerts](msdyn_agreement.md#BKMK_msdyn_agreement_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msfp_alerts"></a> msdyn_agreementbookingdate_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msfp_alerts](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msfp_alerts"></a> msdyn_agreementbookingincident_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msfp_alerts](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msfp_alerts"></a> msdyn_agreementbookingproduct_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msfp_alerts](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msfp_alerts"></a> msdyn_agreementbookingservice_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msfp_alerts](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msfp_alerts"></a> msdyn_agreementbookingservicetask_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msfp_alerts](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msfp_alerts"></a> msdyn_agreementbookingsetup_msfp_alerts

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msfp_alerts](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msfp_alerts"></a> msdyn_agreementinvoicedate_msfp_alerts

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msfp_alerts](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msfp_alerts"></a> msdyn_agreementinvoiceproduct_msfp_alerts

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msfp_alerts](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msfp_alerts"></a> msdyn_agreementinvoicesetup_msfp_alerts

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msfp_alerts](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msfp_alerts"></a> msdyn_bookingalertstatus_msfp_alerts

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msfp_alerts](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msfp_alerts"></a> msdyn_bookingrule_msfp_alerts

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msfp_alerts](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msfp_alerts"></a> msdyn_bookingtimestamp_msfp_alerts

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msfp_alerts](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msfp_alerts"></a> msdyn_fieldservicesetting_msfp_alerts

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msfp_alerts](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msfp_alerts"></a> msdyn_incidenttypecharacteristic_msfp_alerts

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msfp_alerts](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msfp_alerts"></a> msdyn_incidenttypeproduct_msfp_alerts

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msfp_alerts](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msfp_alerts"></a> msdyn_incidenttypeservice_msfp_alerts

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msfp_alerts](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msfp_alerts"></a> msdyn_inventoryadjustment_msfp_alerts

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msfp_alerts](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msfp_alerts"></a> msdyn_inventoryadjustmentproduct_msfp_alerts

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msfp_alerts](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msfp_alerts"></a> msdyn_inventoryjournal_msfp_alerts

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msfp_alerts](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msfp_alerts"></a> msdyn_inventorytransfer_msfp_alerts

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msfp_alerts](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_msfp_alerts"></a> msdyn_payment_msfp_alerts

One-To-Many Relationship: [msdyn_payment msdyn_payment_msfp_alerts](msdyn_payment.md#BKMK_msdyn_payment_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msfp_alerts"></a> msdyn_paymentdetail_msfp_alerts

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msfp_alerts](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msfp_alerts"></a> msdyn_paymentmethod_msfp_alerts

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msfp_alerts](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msfp_alerts"></a> msdyn_paymentterm_msfp_alerts

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msfp_alerts](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msfp_alerts"></a> msdyn_postalcode_msfp_alerts

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msfp_alerts](msdyn_postalcode.md#BKMK_msdyn_postalcode_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msfp_alerts"></a> msdyn_productinventory_msfp_alerts

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msfp_alerts](msdyn_productinventory.md#BKMK_msdyn_productinventory_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msfp_alerts"></a> msdyn_purchaseorder_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msfp_alerts](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msfp_alerts"></a> msdyn_purchaseorderbill_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msfp_alerts](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msfp_alerts"></a> msdyn_purchaseorderproduct_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msfp_alerts](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msfp_alerts"></a> msdyn_purchaseorderreceipt_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msfp_alerts](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msfp_alerts"></a> msdyn_purchaseorderreceiptproduct_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msfp_alerts](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msfp_alerts"></a> msdyn_purchaseordersubstatus_msfp_alerts

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msfp_alerts](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_msfp_alerts"></a> msdyn_quotebookingincident_msfp_alerts

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msfp_alerts](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msfp_alerts"></a> msdyn_quotebookingproduct_msfp_alerts

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msfp_alerts](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msfp_alerts"></a> msdyn_quotebookingservice_msfp_alerts

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msfp_alerts](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msfp_alerts"></a> msdyn_quotebookingservicetask_msfp_alerts

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msfp_alerts](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msfp_alerts"></a> msdyn_resourceterritory_msfp_alerts

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msfp_alerts](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msfp_alerts"></a> msdyn_rma_msfp_alerts

One-To-Many Relationship: [msdyn_rma msdyn_rma_msfp_alerts](msdyn_rma.md#BKMK_msdyn_rma_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msfp_alerts"></a> msdyn_rmaproduct_msfp_alerts

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msfp_alerts](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msfp_alerts"></a> msdyn_rmareceipt_msfp_alerts

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msfp_alerts](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msfp_alerts"></a> msdyn_rmareceiptproduct_msfp_alerts

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msfp_alerts](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msfp_alerts"></a> msdyn_rmasubstatus_msfp_alerts

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msfp_alerts](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msfp_alerts"></a> msdyn_rtv_msfp_alerts

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msfp_alerts](msdyn_rtv.md#BKMK_msdyn_rtv_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msfp_alerts"></a> msdyn_rtvproduct_msfp_alerts

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msfp_alerts](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msfp_alerts"></a> msdyn_rtvsubstatus_msfp_alerts

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msfp_alerts](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msfp_alerts"></a> msdyn_shipvia_msfp_alerts

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msfp_alerts](msdyn_shipvia.md#BKMK_msdyn_shipvia_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msfp_alerts"></a> msdyn_systemuserschedulersetting_msfp_alerts

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msfp_alerts](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msfp_alerts"></a> msdyn_timegroup_msfp_alerts

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msfp_alerts](msdyn_timegroup.md#BKMK_msdyn_timegroup_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_alerts"></a> msdyn_timegroupdetail_msfp_alerts

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msfp_alerts](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msfp_alerts"></a> msdyn_timeoffrequest_msfp_alerts

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msfp_alerts](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msfp_alerts"></a> msdyn_warehouse_msfp_alerts

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msfp_alerts](msdyn_warehouse.md#BKMK_msdyn_warehouse_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msfp_alerts"></a> msdyn_workorder_msfp_alerts

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msfp_alerts](msdyn_workorder.md#BKMK_msdyn_workorder_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_msfp_alerts"></a> msdyn_workordercharacteristic_msfp_alerts

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_msfp_alerts](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msfp_alerts"></a> msdyn_workorderincident_msfp_alerts

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msfp_alerts](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msfp_alerts"></a> msdyn_workorderproduct_msfp_alerts

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msfp_alerts](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msfp_alerts"></a> msdyn_workorderresourcerestriction_msfp_alerts

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msfp_alerts](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msfp_alerts"></a> msdyn_workorderservice_msfp_alerts

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msfp_alerts](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msfp_alerts"></a> msdyn_workorderservicetask_msfp_alerts

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msfp_alerts](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

