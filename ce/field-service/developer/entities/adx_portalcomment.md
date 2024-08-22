---
title: "Portal Comment (adx_portalcomment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Portal Comment (adx_portalcomment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Portal Comment (adx_portalcomment) table/entity reference

An activity which is used to share information between the user and the customer on the portal.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Portal Comment (adx_portalcomment) table extends the [Microsoft Dynamics 365 Portal Comment (adx_portalcomment) table](/dynamics365/developer/entities/adx_portalcomment).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_adx_portalcomments](#BKMK_msdyn_agreement_adx_portalcomments)
- [msdyn_agreementbookingdate_adx_portalcomments](#BKMK_msdyn_agreementbookingdate_adx_portalcomments)
- [msdyn_agreementbookingincident_adx_portalcomments](#BKMK_msdyn_agreementbookingincident_adx_portalcomments)
- [msdyn_agreementbookingproduct_adx_portalcomments](#BKMK_msdyn_agreementbookingproduct_adx_portalcomments)
- [msdyn_agreementbookingservice_adx_portalcomments](#BKMK_msdyn_agreementbookingservice_adx_portalcomments)
- [msdyn_agreementbookingservicetask_adx_portalcomments](#BKMK_msdyn_agreementbookingservicetask_adx_portalcomments)
- [msdyn_agreementbookingsetup_adx_portalcomments](#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)
- [msdyn_agreementinvoicedate_adx_portalcomments](#BKMK_msdyn_agreementinvoicedate_adx_portalcomments)
- [msdyn_agreementinvoiceproduct_adx_portalcomments](#BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments)
- [msdyn_agreementinvoicesetup_adx_portalcomments](#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)
- [msdyn_bookingalertstatus_adx_portalcomments](#BKMK_msdyn_bookingalertstatus_adx_portalcomments)
- [msdyn_bookingrule_adx_portalcomments](#BKMK_msdyn_bookingrule_adx_portalcomments)
- [msdyn_bookingtimestamp_adx_portalcomments](#BKMK_msdyn_bookingtimestamp_adx_portalcomments)
- [msdyn_fieldservicesetting_adx_portalcomments](#BKMK_msdyn_fieldservicesetting_adx_portalcomments)
- [msdyn_incidenttypecharacteristic_adx_portalcomments](#BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments)
- [msdyn_incidenttypeproduct_adx_portalcomments](#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)
- [msdyn_incidenttypeservice_adx_portalcomments](#BKMK_msdyn_incidenttypeservice_adx_portalcomments)
- [msdyn_inventoryadjustment_adx_portalcomments](#BKMK_msdyn_inventoryadjustment_adx_portalcomments)
- [msdyn_inventoryadjustmentproduct_adx_portalcomments](#BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments)
- [msdyn_inventoryjournal_adx_portalcomments](#BKMK_msdyn_inventoryjournal_adx_portalcomments)
- [msdyn_inventorytransfer_adx_portalcomments](#BKMK_msdyn_inventorytransfer_adx_portalcomments)
- [msdyn_payment_adx_portalcomments](#BKMK_msdyn_payment_adx_portalcomments)
- [msdyn_paymentdetail_adx_portalcomments](#BKMK_msdyn_paymentdetail_adx_portalcomments)
- [msdyn_paymentmethod_adx_portalcomments](#BKMK_msdyn_paymentmethod_adx_portalcomments)
- [msdyn_paymentterm_adx_portalcomments](#BKMK_msdyn_paymentterm_adx_portalcomments)
- [msdyn_postalcode_adx_portalcomments](#BKMK_msdyn_postalcode_adx_portalcomments)
- [msdyn_productinventory_adx_portalcomments](#BKMK_msdyn_productinventory_adx_portalcomments)
- [msdyn_purchaseorder_adx_portalcomments](#BKMK_msdyn_purchaseorder_adx_portalcomments)
- [msdyn_purchaseorderbill_adx_portalcomments](#BKMK_msdyn_purchaseorderbill_adx_portalcomments)
- [msdyn_purchaseorderproduct_adx_portalcomments](#BKMK_msdyn_purchaseorderproduct_adx_portalcomments)
- [msdyn_purchaseorderreceipt_adx_portalcomments](#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)
- [msdyn_purchaseorderreceiptproduct_adx_portalcomments](#BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments)
- [msdyn_purchaseordersubstatus_adx_portalcomments](#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)
- [msdyn_quotebookingincident_adx_portalcomments](#BKMK_msdyn_quotebookingincident_adx_portalcomments)
- [msdyn_quotebookingproduct_adx_portalcomments](#BKMK_msdyn_quotebookingproduct_adx_portalcomments)
- [msdyn_quotebookingservice_adx_portalcomments](#BKMK_msdyn_quotebookingservice_adx_portalcomments)
- [msdyn_quotebookingservicetask_adx_portalcomments](#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)
- [msdyn_resourceterritory_adx_portalcomments](#BKMK_msdyn_resourceterritory_adx_portalcomments)
- [msdyn_rma_adx_portalcomments](#BKMK_msdyn_rma_adx_portalcomments)
- [msdyn_rmaproduct_adx_portalcomments](#BKMK_msdyn_rmaproduct_adx_portalcomments)
- [msdyn_rmareceipt_adx_portalcomments](#BKMK_msdyn_rmareceipt_adx_portalcomments)
- [msdyn_rmareceiptproduct_adx_portalcomments](#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)
- [msdyn_rmasubstatus_adx_portalcomments](#BKMK_msdyn_rmasubstatus_adx_portalcomments)
- [msdyn_rtv_adx_portalcomments](#BKMK_msdyn_rtv_adx_portalcomments)
- [msdyn_rtvproduct_adx_portalcomments](#BKMK_msdyn_rtvproduct_adx_portalcomments)
- [msdyn_rtvsubstatus_adx_portalcomments](#BKMK_msdyn_rtvsubstatus_adx_portalcomments)
- [msdyn_shipvia_adx_portalcomments](#BKMK_msdyn_shipvia_adx_portalcomments)
- [msdyn_systemuserschedulersetting_adx_portalcomments](#BKMK_msdyn_systemuserschedulersetting_adx_portalcomments)
- [msdyn_timegroup_adx_portalcomments](#BKMK_msdyn_timegroup_adx_portalcomments)
- [msdyn_timegroupdetail_adx_portalcomments](#BKMK_msdyn_timegroupdetail_adx_portalcomments)
- [msdyn_timeoffrequest_adx_portalcomments](#BKMK_msdyn_timeoffrequest_adx_portalcomments)
- [msdyn_warehouse_adx_portalcomments](#BKMK_msdyn_warehouse_adx_portalcomments)
- [msdyn_workorder_adx_portalcomments](#BKMK_msdyn_workorder_adx_portalcomments)
- [msdyn_workordercharacteristic_adx_portalcomments](#BKMK_msdyn_workordercharacteristic_adx_portalcomments)
- [msdyn_workorderincident_adx_portalcomments](#BKMK_msdyn_workorderincident_adx_portalcomments)
- [msdyn_workorderproduct_adx_portalcomments](#BKMK_msdyn_workorderproduct_adx_portalcomments)
- [msdyn_workorderresourcerestriction_adx_portalcomments](#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)
- [msdyn_workorderservice_adx_portalcomments](#BKMK_msdyn_workorderservice_adx_portalcomments)
- [msdyn_workorderservicetask_adx_portalcomments](#BKMK_msdyn_workorderservicetask_adx_portalcomments)

### <a name="BKMK_msdyn_agreement_adx_portalcomments"></a> msdyn_agreement_adx_portalcomments

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_adx_portalcomments](msdyn_agreement.md#BKMK_msdyn_agreement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_adx_portalcomments"></a> msdyn_agreementbookingdate_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_adx_portalcomments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_adx_portalcomments"></a> msdyn_agreementbookingincident_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_adx_portalcomments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_adx_portalcomments"></a> msdyn_agreementbookingproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_adx_portalcomments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_adx_portalcomments"></a> msdyn_agreementbookingservice_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_adx_portalcomments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_adx_portalcomments"></a> msdyn_agreementbookingservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_adx_portalcomments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_adx_portalcomments"></a> msdyn_agreementbookingsetup_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_adx_portalcomments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_adx_portalcomments"></a> msdyn_agreementinvoicedate_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_adx_portalcomments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments"></a> msdyn_agreementinvoiceproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_adx_portalcomments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_adx_portalcomments"></a> msdyn_agreementinvoicesetup_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_adx_portalcomments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_adx_portalcomments"></a> msdyn_bookingalertstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_adx_portalcomments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_adx_portalcomments"></a> msdyn_bookingrule_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_adx_portalcomments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_adx_portalcomments"></a> msdyn_bookingtimestamp_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_adx_portalcomments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_adx_portalcomments"></a> msdyn_fieldservicesetting_adx_portalcomments

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_adx_portalcomments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments"></a> msdyn_incidenttypecharacteristic_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_adx_portalcomments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_adx_portalcomments"></a> msdyn_incidenttypeproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_adx_portalcomments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_adx_portalcomments"></a> msdyn_incidenttypeservice_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_adx_portalcomments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_adx_portalcomments"></a> msdyn_inventoryadjustment_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_adx_portalcomments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments"></a> msdyn_inventoryadjustmentproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_adx_portalcomments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_adx_portalcomments"></a> msdyn_inventoryjournal_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_adx_portalcomments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_adx_portalcomments"></a> msdyn_inventorytransfer_adx_portalcomments

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_adx_portalcomments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_adx_portalcomments"></a> msdyn_payment_adx_portalcomments

One-To-Many Relationship: [msdyn_payment msdyn_payment_adx_portalcomments](msdyn_payment.md#BKMK_msdyn_payment_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_adx_portalcomments"></a> msdyn_paymentdetail_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_adx_portalcomments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_adx_portalcomments"></a> msdyn_paymentmethod_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_adx_portalcomments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_adx_portalcomments"></a> msdyn_paymentterm_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_adx_portalcomments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_adx_portalcomments"></a> msdyn_postalcode_adx_portalcomments

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_adx_portalcomments](msdyn_postalcode.md#BKMK_msdyn_postalcode_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_adx_portalcomments"></a> msdyn_productinventory_adx_portalcomments

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_adx_portalcomments](msdyn_productinventory.md#BKMK_msdyn_productinventory_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_adx_portalcomments"></a> msdyn_purchaseorder_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_adx_portalcomments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_adx_portalcomments"></a> msdyn_purchaseorderbill_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_adx_portalcomments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_adx_portalcomments"></a> msdyn_purchaseorderproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_adx_portalcomments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_adx_portalcomments"></a> msdyn_purchaseorderreceipt_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_adx_portalcomments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments"></a> msdyn_purchaseorderreceiptproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_adx_portalcomments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_adx_portalcomments"></a> msdyn_purchaseordersubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_adx_portalcomments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_adx_portalcomments"></a> msdyn_quotebookingincident_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_adx_portalcomments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_adx_portalcomments"></a> msdyn_quotebookingproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_adx_portalcomments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_adx_portalcomments"></a> msdyn_quotebookingservice_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_adx_portalcomments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_adx_portalcomments"></a> msdyn_quotebookingservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_adx_portalcomments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_adx_portalcomments"></a> msdyn_resourceterritory_adx_portalcomments

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_adx_portalcomments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_adx_portalcomments"></a> msdyn_rma_adx_portalcomments

One-To-Many Relationship: [msdyn_rma msdyn_rma_adx_portalcomments](msdyn_rma.md#BKMK_msdyn_rma_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_adx_portalcomments"></a> msdyn_rmaproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_adx_portalcomments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_adx_portalcomments"></a> msdyn_rmareceipt_adx_portalcomments

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_adx_portalcomments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_adx_portalcomments"></a> msdyn_rmareceiptproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_adx_portalcomments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_adx_portalcomments"></a> msdyn_rmasubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_adx_portalcomments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_adx_portalcomments"></a> msdyn_rtv_adx_portalcomments

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_adx_portalcomments](msdyn_rtv.md#BKMK_msdyn_rtv_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_adx_portalcomments"></a> msdyn_rtvproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_adx_portalcomments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_adx_portalcomments"></a> msdyn_rtvsubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_adx_portalcomments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_adx_portalcomments"></a> msdyn_shipvia_adx_portalcomments

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_adx_portalcomments](msdyn_shipvia.md#BKMK_msdyn_shipvia_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_adx_portalcomments"></a> msdyn_systemuserschedulersetting_adx_portalcomments

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_adx_portalcomments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_adx_portalcomments"></a> msdyn_timegroup_adx_portalcomments

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_adx_portalcomments](msdyn_timegroup.md#BKMK_msdyn_timegroup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_adx_portalcomments"></a> msdyn_timegroupdetail_adx_portalcomments

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_adx_portalcomments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_adx_portalcomments"></a> msdyn_timeoffrequest_adx_portalcomments

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_adx_portalcomments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_adx_portalcomments"></a> msdyn_warehouse_adx_portalcomments

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_adx_portalcomments](msdyn_warehouse.md#BKMK_msdyn_warehouse_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_adx_portalcomments"></a> msdyn_workorder_adx_portalcomments

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_adx_portalcomments](msdyn_workorder.md#BKMK_msdyn_workorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_adx_portalcomments"></a> msdyn_workordercharacteristic_adx_portalcomments

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_adx_portalcomments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_adx_portalcomments"></a> msdyn_workorderincident_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_adx_portalcomments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_adx_portalcomments"></a> msdyn_workorderproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_adx_portalcomments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_adx_portalcomments"></a> msdyn_workorderresourcerestriction_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_adx_portalcomments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_adx_portalcomments"></a> msdyn_workorderservice_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_adx_portalcomments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_adx_portalcomments"></a> msdyn_workorderservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_adx_portalcomments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_portalcomment?displayProperty=fullName>
