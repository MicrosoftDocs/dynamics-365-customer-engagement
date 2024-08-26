---
title: "Fax table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Fax table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Fax table/entity reference

Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Fax table extends the [Microsoft Dynamics 365 Fax table](/dynamics365/developer/entities/fax).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_Faxes](#BKMK_msdyn_agreement_Faxes)
- [msdyn_agreementbookingdate_Faxes](#BKMK_msdyn_agreementbookingdate_Faxes)
- [msdyn_agreementbookingincident_Faxes](#BKMK_msdyn_agreementbookingincident_Faxes)
- [msdyn_agreementbookingproduct_Faxes](#BKMK_msdyn_agreementbookingproduct_Faxes)
- [msdyn_agreementbookingservice_Faxes](#BKMK_msdyn_agreementbookingservice_Faxes)
- [msdyn_agreementbookingservicetask_Faxes](#BKMK_msdyn_agreementbookingservicetask_Faxes)
- [msdyn_agreementbookingsetup_Faxes](#BKMK_msdyn_agreementbookingsetup_Faxes)
- [msdyn_agreementinvoicedate_Faxes](#BKMK_msdyn_agreementinvoicedate_Faxes)
- [msdyn_agreementinvoiceproduct_Faxes](#BKMK_msdyn_agreementinvoiceproduct_Faxes)
- [msdyn_agreementinvoicesetup_Faxes](#BKMK_msdyn_agreementinvoicesetup_Faxes)
- [msdyn_bookingalertstatus_Faxes](#BKMK_msdyn_bookingalertstatus_Faxes)
- [msdyn_bookingrule_Faxes](#BKMK_msdyn_bookingrule_Faxes)
- [msdyn_bookingtimestamp_Faxes](#BKMK_msdyn_bookingtimestamp_Faxes)
- [msdyn_fieldservicesetting_Faxes](#BKMK_msdyn_fieldservicesetting_Faxes)
- [msdyn_incidenttypecharacteristic_Faxes](#BKMK_msdyn_incidenttypecharacteristic_Faxes)
- [msdyn_incidenttypeproduct_Faxes](#BKMK_msdyn_incidenttypeproduct_Faxes)
- [msdyn_incidenttypeservice_Faxes](#BKMK_msdyn_incidenttypeservice_Faxes)
- [msdyn_inventoryadjustment_Faxes](#BKMK_msdyn_inventoryadjustment_Faxes)
- [msdyn_inventoryadjustmentproduct_Faxes](#BKMK_msdyn_inventoryadjustmentproduct_Faxes)
- [msdyn_inventoryjournal_Faxes](#BKMK_msdyn_inventoryjournal_Faxes)
- [msdyn_inventorytransfer_Faxes](#BKMK_msdyn_inventorytransfer_Faxes)
- [msdyn_payment_Faxes](#BKMK_msdyn_payment_Faxes)
- [msdyn_paymentdetail_Faxes](#BKMK_msdyn_paymentdetail_Faxes)
- [msdyn_paymentmethod_Faxes](#BKMK_msdyn_paymentmethod_Faxes)
- [msdyn_paymentterm_Faxes](#BKMK_msdyn_paymentterm_Faxes)
- [msdyn_postalcode_Faxes](#BKMK_msdyn_postalcode_Faxes)
- [msdyn_productinventory_Faxes](#BKMK_msdyn_productinventory_Faxes)
- [msdyn_purchaseorder_Faxes](#BKMK_msdyn_purchaseorder_Faxes)
- [msdyn_purchaseorderbill_Faxes](#BKMK_msdyn_purchaseorderbill_Faxes)
- [msdyn_purchaseorderproduct_Faxes](#BKMK_msdyn_purchaseorderproduct_Faxes)
- [msdyn_purchaseorderreceipt_Faxes](#BKMK_msdyn_purchaseorderreceipt_Faxes)
- [msdyn_purchaseorderreceiptproduct_Faxes](#BKMK_msdyn_purchaseorderreceiptproduct_Faxes)
- [msdyn_purchaseordersubstatus_Faxes](#BKMK_msdyn_purchaseordersubstatus_Faxes)
- [msdyn_quotebookingincident_Faxes](#BKMK_msdyn_quotebookingincident_Faxes)
- [msdyn_quotebookingproduct_Faxes](#BKMK_msdyn_quotebookingproduct_Faxes)
- [msdyn_quotebookingservice_Faxes](#BKMK_msdyn_quotebookingservice_Faxes)
- [msdyn_quotebookingservicetask_Faxes](#BKMK_msdyn_quotebookingservicetask_Faxes)
- [msdyn_resourceterritory_Faxes](#BKMK_msdyn_resourceterritory_Faxes)
- [msdyn_rma_Faxes](#BKMK_msdyn_rma_Faxes)
- [msdyn_rmaproduct_Faxes](#BKMK_msdyn_rmaproduct_Faxes)
- [msdyn_rmareceipt_Faxes](#BKMK_msdyn_rmareceipt_Faxes)
- [msdyn_rmareceiptproduct_Faxes](#BKMK_msdyn_rmareceiptproduct_Faxes)
- [msdyn_rmasubstatus_Faxes](#BKMK_msdyn_rmasubstatus_Faxes)
- [msdyn_rtv_Faxes](#BKMK_msdyn_rtv_Faxes)
- [msdyn_rtvproduct_Faxes](#BKMK_msdyn_rtvproduct_Faxes)
- [msdyn_rtvsubstatus_Faxes](#BKMK_msdyn_rtvsubstatus_Faxes)
- [msdyn_shipvia_Faxes](#BKMK_msdyn_shipvia_Faxes)
- [msdyn_systemuserschedulersetting_Faxes](#BKMK_msdyn_systemuserschedulersetting_Faxes)
- [msdyn_timegroup_Faxes](#BKMK_msdyn_timegroup_Faxes)
- [msdyn_timegroupdetail_Faxes](#BKMK_msdyn_timegroupdetail_Faxes)
- [msdyn_timeoffrequest_Faxes](#BKMK_msdyn_timeoffrequest_Faxes)
- [msdyn_warehouse_Faxes](#BKMK_msdyn_warehouse_Faxes)
- [msdyn_workorder_Faxes](#BKMK_msdyn_workorder_Faxes)
- [msdyn_workorderincident_Faxes](#BKMK_msdyn_workorderincident_Faxes)
- [msdyn_workorderproduct_Faxes](#BKMK_msdyn_workorderproduct_Faxes)
- [msdyn_workorderresourcerestriction_Faxes](#BKMK_msdyn_workorderresourcerestriction_Faxes)
- [msdyn_workorderservice_Faxes](#BKMK_msdyn_workorderservice_Faxes)
- [msdyn_workorderservicetask_Faxes](#BKMK_msdyn_workorderservicetask_Faxes)

### <a name="BKMK_msdyn_agreement_Faxes"></a> msdyn_agreement_Faxes

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Faxes](msdyn_agreement.md#BKMK_msdyn_agreement_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Faxes"></a> msdyn_agreementbookingdate_Faxes

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Faxes](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Faxes"></a> msdyn_agreementbookingincident_Faxes

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Faxes](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Faxes"></a> msdyn_agreementbookingproduct_Faxes

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Faxes](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Faxes"></a> msdyn_agreementbookingservice_Faxes

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Faxes](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Faxes"></a> msdyn_agreementbookingservicetask_Faxes

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Faxes](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Faxes"></a> msdyn_agreementbookingsetup_Faxes

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Faxes](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Faxes"></a> msdyn_agreementinvoicedate_Faxes

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Faxes](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Faxes"></a> msdyn_agreementinvoiceproduct_Faxes

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Faxes](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Faxes"></a> msdyn_agreementinvoicesetup_Faxes

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Faxes](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Faxes"></a> msdyn_bookingalertstatus_Faxes

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Faxes](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Faxes"></a> msdyn_bookingrule_Faxes

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Faxes](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Faxes"></a> msdyn_bookingtimestamp_Faxes

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Faxes](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Faxes"></a> msdyn_fieldservicesetting_Faxes

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Faxes](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Faxes"></a> msdyn_incidenttypecharacteristic_Faxes

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Faxes](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Faxes"></a> msdyn_incidenttypeproduct_Faxes

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Faxes](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Faxes"></a> msdyn_incidenttypeservice_Faxes

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Faxes](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Faxes"></a> msdyn_inventoryadjustment_Faxes

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Faxes](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Faxes"></a> msdyn_inventoryadjustmentproduct_Faxes

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Faxes](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Faxes"></a> msdyn_inventoryjournal_Faxes

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Faxes](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Faxes"></a> msdyn_inventorytransfer_Faxes

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Faxes](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Faxes"></a> msdyn_payment_Faxes

One-To-Many Relationship: [msdyn_payment msdyn_payment_Faxes](msdyn_payment.md#BKMK_msdyn_payment_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Faxes"></a> msdyn_paymentdetail_Faxes

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Faxes](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Faxes"></a> msdyn_paymentmethod_Faxes

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Faxes](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Faxes"></a> msdyn_paymentterm_Faxes

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Faxes](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Faxes"></a> msdyn_postalcode_Faxes

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Faxes](msdyn_postalcode.md#BKMK_msdyn_postalcode_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Faxes"></a> msdyn_productinventory_Faxes

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Faxes](msdyn_productinventory.md#BKMK_msdyn_productinventory_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Faxes"></a> msdyn_purchaseorder_Faxes

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Faxes](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Faxes"></a> msdyn_purchaseorderbill_Faxes

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Faxes](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Faxes"></a> msdyn_purchaseorderproduct_Faxes

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Faxes](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Faxes"></a> msdyn_purchaseorderreceipt_Faxes

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Faxes](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Faxes"></a> msdyn_purchaseorderreceiptproduct_Faxes

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Faxes](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Faxes"></a> msdyn_purchaseordersubstatus_Faxes

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Faxes](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Faxes"></a> msdyn_quotebookingincident_Faxes

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Faxes](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Faxes"></a> msdyn_quotebookingproduct_Faxes

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Faxes](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Faxes"></a> msdyn_quotebookingservice_Faxes

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Faxes](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Faxes"></a> msdyn_quotebookingservicetask_Faxes

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Faxes](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Faxes"></a> msdyn_resourceterritory_Faxes

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Faxes](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Faxes"></a> msdyn_rma_Faxes

One-To-Many Relationship: [msdyn_rma msdyn_rma_Faxes](msdyn_rma.md#BKMK_msdyn_rma_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Faxes"></a> msdyn_rmaproduct_Faxes

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Faxes](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Faxes"></a> msdyn_rmareceipt_Faxes

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Faxes](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Faxes"></a> msdyn_rmareceiptproduct_Faxes

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Faxes](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Faxes"></a> msdyn_rmasubstatus_Faxes

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Faxes](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Faxes"></a> msdyn_rtv_Faxes

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Faxes](msdyn_rtv.md#BKMK_msdyn_rtv_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Faxes"></a> msdyn_rtvproduct_Faxes

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Faxes](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Faxes"></a> msdyn_rtvsubstatus_Faxes

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Faxes](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Faxes"></a> msdyn_shipvia_Faxes

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Faxes](msdyn_shipvia.md#BKMK_msdyn_shipvia_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Faxes"></a> msdyn_systemuserschedulersetting_Faxes

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Faxes](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Faxes"></a> msdyn_timegroup_Faxes

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Faxes](msdyn_timegroup.md#BKMK_msdyn_timegroup_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Faxes"></a> msdyn_timegroupdetail_Faxes

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Faxes](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Faxes"></a> msdyn_timeoffrequest_Faxes

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Faxes](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Faxes"></a> msdyn_warehouse_Faxes

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Faxes](msdyn_warehouse.md#BKMK_msdyn_warehouse_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Faxes"></a> msdyn_workorder_Faxes

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Faxes](msdyn_workorder.md#BKMK_msdyn_workorder_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Faxes"></a> msdyn_workorderincident_Faxes

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Faxes](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Faxes"></a> msdyn_workorderproduct_Faxes

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Faxes](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Faxes"></a> msdyn_workorderresourcerestriction_Faxes

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Faxes](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Faxes"></a> msdyn_workorderservice_Faxes

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Faxes](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Faxes"></a> msdyn_workorderservicetask_Faxes

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Faxes](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fax?displayProperty=fullName>
