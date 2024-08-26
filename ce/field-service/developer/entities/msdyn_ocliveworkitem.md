---
title: "Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Conversation (msdyn_ocliveworkitem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Conversation (msdyn_ocliveworkitem) table/entity reference

Tracks the interaction between the agents and customer

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Conversation (msdyn_ocliveworkitem) table extends the [Microsoft Dynamics 365 Conversation (msdyn_ocliveworkitem) table](/dynamics365/developer/entities/msdyn_ocliveworkitem).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/entities/msdyn_ocliveworkitem#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_msdyn_ocliveworkitems](#BKMK_msdyn_agreement_msdyn_ocliveworkitems)
- [msdyn_agreementbookingdate_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems)
- [msdyn_agreementbookingincident_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems)
- [msdyn_agreementbookingproduct_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems)
- [msdyn_agreementbookingservice_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)
- [msdyn_agreementbookingservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems)
- [msdyn_agreementbookingsetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)
- [msdyn_agreementinvoicedate_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems)
- [msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems)
- [msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)
- [msdyn_bookingalertstatus_msdyn_ocliveworkitems](#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)
- [msdyn_bookingrule_msdyn_ocliveworkitems](#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)
- [msdyn_bookingtimestamp_msdyn_ocliveworkitems](#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)
- [msdyn_fieldservicesetting_msdyn_ocliveworkitems](#BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems)
- [msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems)
- [msdyn_incidenttypeproduct_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)
- [msdyn_incidenttypeservice_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)
- [msdyn_inventoryadjustment_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)
- [msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems)
- [msdyn_inventoryjournal_msdyn_ocliveworkitems](#BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems)
- [msdyn_inventorytransfer_msdyn_ocliveworkitems](#BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems)
- [msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)
- [msdyn_payment_msdyn_ocliveworkitems](#BKMK_msdyn_payment_msdyn_ocliveworkitems)
- [msdyn_paymentdetail_msdyn_ocliveworkitems](#BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems)
- [msdyn_paymentmethod_msdyn_ocliveworkitems](#BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems)
- [msdyn_paymentterm_msdyn_ocliveworkitems](#BKMK_msdyn_paymentterm_msdyn_ocliveworkitems)
- [msdyn_postalcode_msdyn_ocliveworkitems](#BKMK_msdyn_postalcode_msdyn_ocliveworkitems)
- [msdyn_productinventory_msdyn_ocliveworkitems](#BKMK_msdyn_productinventory_msdyn_ocliveworkitems)
- [msdyn_purchaseorder_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems)
- [msdyn_purchaseorderbill_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems)
- [msdyn_purchaseorderproduct_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems)
- [msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)
- [msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems)
- [msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)
- [msdyn_quotebookingincident_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)
- [msdyn_quotebookingproduct_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)
- [msdyn_quotebookingservice_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems)
- [msdyn_quotebookingservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)
- [msdyn_resourceterritory_msdyn_ocliveworkitems](#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)
- [msdyn_rma_msdyn_ocliveworkitems](#BKMK_msdyn_rma_msdyn_ocliveworkitems)
- [msdyn_rmaproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems)
- [msdyn_rmareceipt_msdyn_ocliveworkitems](#BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems)
- [msdyn_rmareceiptproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)
- [msdyn_rmasubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems)
- [msdyn_rtv_msdyn_ocliveworkitems](#BKMK_msdyn_rtv_msdyn_ocliveworkitems)
- [msdyn_rtvproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems)
- [msdyn_rtvsubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)
- [msdyn_shipvia_msdyn_ocliveworkitems](#BKMK_msdyn_shipvia_msdyn_ocliveworkitems)
- [msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)
- [msdyn_timegroup_msdyn_ocliveworkitems](#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)
- [msdyn_timegroupdetail_msdyn_ocliveworkitems](#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)
- [msdyn_timeoffrequest_msdyn_ocliveworkitems](#BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems)
- [msdyn_warehouse_msdyn_ocliveworkitems](#BKMK_msdyn_warehouse_msdyn_ocliveworkitems)
- [msdyn_workorder_msdyn_ocliveworkitems](#BKMK_msdyn_workorder_msdyn_ocliveworkitems)
- [msdyn_workorderincident_msdyn_ocliveworkitems](#BKMK_msdyn_workorderincident_msdyn_ocliveworkitems)
- [msdyn_workorderproduct_msdyn_ocliveworkitems](#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)
- [msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)
- [msdyn_workorderservice_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)
- [msdyn_workorderservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)

### <a name="BKMK_msdyn_agreement_msdyn_ocliveworkitems"></a> msdyn_agreement_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msdyn_ocliveworkitems](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems"></a> msdyn_agreementbookingdate_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msdyn_ocliveworkitems](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems"></a> msdyn_agreementbookingincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msdyn_ocliveworkitems](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems"></a> msdyn_agreementbookingproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msdyn_ocliveworkitems](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems"></a> msdyn_agreementbookingservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msdyn_ocliveworkitems](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems"></a> msdyn_agreementbookingservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msdyn_ocliveworkitems](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems"></a> msdyn_agreementbookingsetup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msdyn_ocliveworkitems](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems"></a> msdyn_agreementinvoicedate_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msdyn_ocliveworkitems](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems"></a> msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems"></a> msdyn_agreementinvoicesetup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems"></a> msdyn_bookingalertstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocliveworkitems](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocliveworkitems"></a> msdyn_bookingrule_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocliveworkitems](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems"></a> msdyn_bookingtimestamp_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msdyn_ocliveworkitems](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems"></a> msdyn_fieldservicesetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msdyn_ocliveworkitems](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems"></a> msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems"></a> msdyn_incidenttypeproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msdyn_ocliveworkitems](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems"></a> msdyn_incidenttypeservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msdyn_ocliveworkitems](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems"></a> msdyn_inventoryadjustment_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msdyn_ocliveworkitems](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems"></a> msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems"></a> msdyn_inventoryjournal_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msdyn_ocliveworkitems](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems"></a> msdyn_inventorytransfer_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msdyn_ocliveworkitems](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid"></a> msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_msdyn_ocliveworkitems"></a> msdyn_payment_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_payment msdyn_payment_msdyn_ocliveworkitems](msdyn_payment.md#BKMK_msdyn_payment_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems"></a> msdyn_paymentdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msdyn_ocliveworkitems](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems"></a> msdyn_paymentmethod_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msdyn_ocliveworkitems](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msdyn_ocliveworkitems"></a> msdyn_paymentterm_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msdyn_ocliveworkitems](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msdyn_ocliveworkitems"></a> msdyn_postalcode_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msdyn_ocliveworkitems](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msdyn_ocliveworkitems"></a> msdyn_productinventory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msdyn_ocliveworkitems](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems"></a> msdyn_purchaseorder_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msdyn_ocliveworkitems](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems"></a> msdyn_purchaseorderbill_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msdyn_ocliveworkitems](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems"></a> msdyn_purchaseorderproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msdyn_ocliveworkitems](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems"></a> msdyn_purchaseorderreceipt_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems"></a> msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems"></a> msdyn_purchaseordersubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems"></a> msdyn_quotebookingincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msdyn_ocliveworkitems](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems"></a> msdyn_quotebookingproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msdyn_ocliveworkitems](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems"></a> msdyn_quotebookingservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msdyn_ocliveworkitems](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems"></a> msdyn_quotebookingservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msdyn_ocliveworkitems](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems"></a> msdyn_resourceterritory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocliveworkitems](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msdyn_ocliveworkitems"></a> msdyn_rma_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rma msdyn_rma_msdyn_ocliveworkitems](msdyn_rma.md#BKMK_msdyn_rma_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems"></a> msdyn_rmaproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msdyn_ocliveworkitems](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems"></a> msdyn_rmareceipt_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msdyn_ocliveworkitems](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems"></a> msdyn_rmareceiptproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msdyn_ocliveworkitems](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems"></a> msdyn_rmasubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msdyn_ocliveworkitems](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msdyn_ocliveworkitems"></a> msdyn_rtv_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msdyn_ocliveworkitems](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems"></a> msdyn_rtvproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msdyn_ocliveworkitems](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems"></a> msdyn_rtvsubstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msdyn_ocliveworkitems](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msdyn_ocliveworkitems"></a> msdyn_shipvia_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msdyn_ocliveworkitems](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems"></a> msdyn_systemuserschedulersetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocliveworkitems"></a> msdyn_timegroup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocliveworkitems](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems"></a> msdyn_timegroupdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocliveworkitems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems"></a> msdyn_timeoffrequest_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msdyn_ocliveworkitems](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msdyn_ocliveworkitems"></a> msdyn_warehouse_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msdyn_ocliveworkitems](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msdyn_ocliveworkitems"></a> msdyn_workorder_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msdyn_ocliveworkitems](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msdyn_ocliveworkitems"></a> msdyn_workorderincident_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msdyn_ocliveworkitems](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems"></a> msdyn_workorderproduct_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msdyn_ocliveworkitems](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems"></a> msdyn_workorderresourcerestriction_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocliveworkitems"></a> msdyn_workorderservice_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msdyn_ocliveworkitems](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems"></a> msdyn_workorderservicetask_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msdyn_ocliveworkitems](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

