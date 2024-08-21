---
title: "Activity (ActivityPointer) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Activity (ActivityPointer) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Activity (ActivityPointer) table/entity reference

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Activity (ActivityPointer) table extends the [Microsoft Dataverse Activity (ActivityPointer) table](/power-apps/developer/data-platform/reference/entities/activitypointer).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_ActivityPointers](#BKMK_msdyn_agreement_ActivityPointers)
- [msdyn_agreementbookingdate_ActivityPointers](#BKMK_msdyn_agreementbookingdate_ActivityPointers)
- [msdyn_agreementbookingincident_ActivityPointers](#BKMK_msdyn_agreementbookingincident_ActivityPointers)
- [msdyn_agreementbookingproduct_ActivityPointers](#BKMK_msdyn_agreementbookingproduct_ActivityPointers)
- [msdyn_agreementbookingservice_ActivityPointers](#BKMK_msdyn_agreementbookingservice_ActivityPointers)
- [msdyn_agreementbookingservicetask_ActivityPointers](#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)
- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementinvoicedate_ActivityPointers](#BKMK_msdyn_agreementinvoicedate_ActivityPointers)
- [msdyn_agreementinvoiceproduct_ActivityPointers](#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)
- [msdyn_agreementinvoicesetup_ActivityPointers](#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)
- [msdyn_bookingalertstatus_ActivityPointers](#BKMK_msdyn_bookingalertstatus_ActivityPointers)
- [msdyn_bookingrule_ActivityPointers](#BKMK_msdyn_bookingrule_ActivityPointers)
- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_fieldservicesetting_ActivityPointers](#BKMK_msdyn_fieldservicesetting_ActivityPointers)
- [msdyn_incidenttypecharacteristic_ActivityPointers](#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers)
- [msdyn_incidenttypeproduct_ActivityPointers](#BKMK_msdyn_incidenttypeproduct_ActivityPointers)
- [msdyn_incidenttypeservice_ActivityPointers](#BKMK_msdyn_incidenttypeservice_ActivityPointers)
- [msdyn_inventoryadjustment_ActivityPointers](#BKMK_msdyn_inventoryadjustment_ActivityPointers)
- [msdyn_inventoryadjustmentproduct_ActivityPointers](#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers)
- [msdyn_inventoryjournal_ActivityPointers](#BKMK_msdyn_inventoryjournal_ActivityPointers)
- [msdyn_inventorytransfer_ActivityPointers](#BKMK_msdyn_inventorytransfer_ActivityPointers)
- [msdyn_payment_ActivityPointers](#BKMK_msdyn_payment_ActivityPointers)
- [msdyn_paymentdetail_ActivityPointers](#BKMK_msdyn_paymentdetail_ActivityPointers)
- [msdyn_paymentmethod_ActivityPointers](#BKMK_msdyn_paymentmethod_ActivityPointers)
- [msdyn_paymentterm_ActivityPointers](#BKMK_msdyn_paymentterm_ActivityPointers)
- [msdyn_postalcode_ActivityPointers](#BKMK_msdyn_postalcode_ActivityPointers)
- [msdyn_productinventory_ActivityPointers](#BKMK_msdyn_productinventory_ActivityPointers)
- [msdyn_purchaseorder_ActivityPointers](#BKMK_msdyn_purchaseorder_ActivityPointers)
- [msdyn_purchaseorderbill_ActivityPointers](#BKMK_msdyn_purchaseorderbill_ActivityPointers)
- [msdyn_purchaseorderproduct_ActivityPointers](#BKMK_msdyn_purchaseorderproduct_ActivityPointers)
- [msdyn_purchaseorderreceipt_ActivityPointers](#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)
- [msdyn_purchaseorderreceiptproduct_ActivityPointers](#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)
- [msdyn_purchaseordersubstatus_ActivityPointers](#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)
- [msdyn_quotebookingincident_ActivityPointers](#BKMK_msdyn_quotebookingincident_ActivityPointers)
- [msdyn_quotebookingproduct_ActivityPointers](#BKMK_msdyn_quotebookingproduct_ActivityPointers)
- [msdyn_quotebookingservice_ActivityPointers](#BKMK_msdyn_quotebookingservice_ActivityPointers)
- [msdyn_quotebookingservicetask_ActivityPointers](#BKMK_msdyn_quotebookingservicetask_ActivityPointers)
- [msdyn_resourceterritory_ActivityPointers](#BKMK_msdyn_resourceterritory_ActivityPointers)
- [msdyn_rma_ActivityPointers](#BKMK_msdyn_rma_ActivityPointers)
- [msdyn_rmaproduct_ActivityPointers](#BKMK_msdyn_rmaproduct_ActivityPointers)
- [msdyn_rmareceipt_ActivityPointers](#BKMK_msdyn_rmareceipt_ActivityPointers)
- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmasubstatus_ActivityPointers](#BKMK_msdyn_rmasubstatus_ActivityPointers)
- [msdyn_rtv_ActivityPointers](#BKMK_msdyn_rtv_ActivityPointers)
- [msdyn_rtvproduct_ActivityPointers](#BKMK_msdyn_rtvproduct_ActivityPointers)
- [msdyn_rtvsubstatus_ActivityPointers](#BKMK_msdyn_rtvsubstatus_ActivityPointers)
- [msdyn_shipvia_ActivityPointers](#BKMK_msdyn_shipvia_ActivityPointers)
- [msdyn_systemuserschedulersetting_ActivityPointers](#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)
- [msdyn_timegroup_ActivityPointers](#BKMK_msdyn_timegroup_ActivityPointers)
- [msdyn_timegroupdetail_ActivityPointers](#BKMK_msdyn_timegroupdetail_ActivityPointers)
- [msdyn_timeoffrequest_ActivityPointers](#BKMK_msdyn_timeoffrequest_ActivityPointers)
- [msdyn_warehouse_ActivityPointers](#BKMK_msdyn_warehouse_ActivityPointers)
- [msdyn_workorder_ActivityPointers](#BKMK_msdyn_workorder_ActivityPointers)
- [msdyn_workordercharacteristic_ActivityPointers](#BKMK_msdyn_workordercharacteristic_ActivityPointers)
- [msdyn_workorderincident_ActivityPointers](#BKMK_msdyn_workorderincident_ActivityPointers)
- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderresourcerestriction_ActivityPointers](#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)
- [msdyn_workorderservice_ActivityPointers](#BKMK_msdyn_workorderservice_ActivityPointers)
- [msdyn_workorderservicetask_ActivityPointers](#BKMK_msdyn_workorderservicetask_ActivityPointers)

### <a name="BKMK_msdyn_agreement_ActivityPointers"></a> msdyn_agreement_ActivityPointers

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_ActivityPointers](msdyn_agreement.md#BKMK_msdyn_agreement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_ActivityPointers"></a> msdyn_agreementbookingdate_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_ActivityPointers](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_ActivityPointers"></a> msdyn_agreementbookingincident_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_ActivityPointers](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_ActivityPointers"></a> msdyn_agreementbookingproduct_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_ActivityPointers](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_ActivityPointers"></a> msdyn_agreementbookingservice_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_ActivityPointers](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_ActivityPointers"></a> msdyn_agreementbookingservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_ActivityPointers](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_ActivityPointers](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_ActivityPointers"></a> msdyn_agreementinvoicedate_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_ActivityPointers](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_ActivityPointers"></a> msdyn_agreementinvoiceproduct_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_ActivityPointers](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ActivityPointers"></a> msdyn_agreementinvoicesetup_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_ActivityPointers](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_ActivityPointers"></a> msdyn_bookingalertstatus_ActivityPointers

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_ActivityPointers](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_ActivityPointers"></a> msdyn_bookingrule_ActivityPointers

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_ActivityPointers](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_ActivityPointers](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_ActivityPointers"></a> msdyn_fieldservicesetting_ActivityPointers

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_ActivityPointers](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_ActivityPointers"></a> msdyn_incidenttypecharacteristic_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_ActivityPointers](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_ActivityPointers](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_ActivityPointers](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_ActivityPointers"></a> msdyn_inventoryadjustment_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_ActivityPointers](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers"></a> msdyn_inventoryadjustmentproduct_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_ActivityPointers](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_ActivityPointers"></a> msdyn_inventoryjournal_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_ActivityPointers](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_ActivityPointers"></a> msdyn_inventorytransfer_ActivityPointers

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_ActivityPointers](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_ActivityPointers"></a> msdyn_payment_ActivityPointers

One-To-Many Relationship: [msdyn_payment msdyn_payment_ActivityPointers](msdyn_payment.md#BKMK_msdyn_payment_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_ActivityPointers"></a> msdyn_paymentdetail_ActivityPointers

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_ActivityPointers](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_ActivityPointers"></a> msdyn_paymentmethod_ActivityPointers

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_ActivityPointers](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_ActivityPointers"></a> msdyn_paymentterm_ActivityPointers

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_ActivityPointers](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_ActivityPointers"></a> msdyn_postalcode_ActivityPointers

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_ActivityPointers](msdyn_postalcode.md#BKMK_msdyn_postalcode_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_ActivityPointers"></a> msdyn_productinventory_ActivityPointers

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_ActivityPointers](msdyn_productinventory.md#BKMK_msdyn_productinventory_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_ActivityPointers"></a> msdyn_purchaseorder_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_ActivityPointers](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_ActivityPointers](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_ActivityPointers"></a> msdyn_purchaseorderproduct_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_ActivityPointers](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_ActivityPointers](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_ActivityPointers](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ActivityPointers"></a> msdyn_purchaseordersubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_ActivityPointers](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_ActivityPointers](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_ActivityPointers](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_ActivityPointers"></a> msdyn_quotebookingservice_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_ActivityPointers](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_ActivityPointers](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_ActivityPointers"></a> msdyn_resourceterritory_ActivityPointers

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_ActivityPointers](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

One-To-Many Relationship: [msdyn_rma msdyn_rma_ActivityPointers](msdyn_rma.md#BKMK_msdyn_rma_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_ActivityPointers"></a> msdyn_rmaproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_ActivityPointers](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_ActivityPointers"></a> msdyn_rmareceipt_ActivityPointers

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_ActivityPointers](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_ActivityPointers](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_ActivityPointers"></a> msdyn_rmasubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_ActivityPointers](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_ActivityPointers](msdyn_rtv.md#BKMK_msdyn_rtv_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_ActivityPointers"></a> msdyn_rtvproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_ActivityPointers](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_ActivityPointers"></a> msdyn_rtvsubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_ActivityPointers](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_ActivityPointers"></a> msdyn_shipvia_ActivityPointers

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_ActivityPointers](msdyn_shipvia.md#BKMK_msdyn_shipvia_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_ActivityPointers"></a> msdyn_systemuserschedulersetting_ActivityPointers

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_ActivityPointers](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_ActivityPointers"></a> msdyn_timegroup_ActivityPointers

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_ActivityPointers](msdyn_timegroup.md#BKMK_msdyn_timegroup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_ActivityPointers"></a> msdyn_timegroupdetail_ActivityPointers

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_ActivityPointers](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_ActivityPointers"></a> msdyn_timeoffrequest_ActivityPointers

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_ActivityPointers](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_ActivityPointers"></a> msdyn_warehouse_ActivityPointers

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_ActivityPointers](msdyn_warehouse.md#BKMK_msdyn_warehouse_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_ActivityPointers](msdyn_workorder.md#BKMK_msdyn_workorder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_ActivityPointers"></a> msdyn_workordercharacteristic_ActivityPointers

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_ActivityPointers](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_ActivityPointers](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_ActivityPointers](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_ActivityPointers](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_ActivityPointers](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_ActivityPointers](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_activity_pointer_msdyn_bookingalert"></a> activity_pointer_msdyn_bookingalert

Many-To-One Relationship: [msdyn_bookingalert activity_pointer_msdyn_bookingalert](msdyn_bookingalert.md#BKMK_activity_pointer_msdyn_bookingalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_bookingalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activitypointer?displayProperty=fullName>
