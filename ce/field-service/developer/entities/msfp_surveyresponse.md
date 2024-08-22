---
title: "Customer Voice survey response (msfp_surveyresponse) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer Voice survey response (msfp_surveyresponse) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer Voice survey response (msfp_surveyresponse) table/entity reference

Response to a survey.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Customer Voice survey response (msfp_surveyresponse) table extends the [Microsoft Dynamics 365 Customer Voice survey response (msfp_surveyresponse) table](/dynamics365/developer/entities/msfp_surveyresponse).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/entities/msfp_surveyresponse#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_msfp_surveyresponses](#BKMK_msdyn_agreement_msfp_surveyresponses)
- [msdyn_agreementbookingdate_msfp_surveyresponses](#BKMK_msdyn_agreementbookingdate_msfp_surveyresponses)
- [msdyn_agreementbookingincident_msfp_surveyresponses](#BKMK_msdyn_agreementbookingincident_msfp_surveyresponses)
- [msdyn_agreementbookingproduct_msfp_surveyresponses](#BKMK_msdyn_agreementbookingproduct_msfp_surveyresponses)
- [msdyn_agreementbookingservice_msfp_surveyresponses](#BKMK_msdyn_agreementbookingservice_msfp_surveyresponses)
- [msdyn_agreementbookingservicetask_msfp_surveyresponses](#BKMK_msdyn_agreementbookingservicetask_msfp_surveyresponses)
- [msdyn_agreementbookingsetup_msfp_surveyresponses](#BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses)
- [msdyn_agreementinvoicedate_msfp_surveyresponses](#BKMK_msdyn_agreementinvoicedate_msfp_surveyresponses)
- [msdyn_agreementinvoiceproduct_msfp_surveyresponses](#BKMK_msdyn_agreementinvoiceproduct_msfp_surveyresponses)
- [msdyn_agreementinvoicesetup_msfp_surveyresponses](#BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses)
- [msdyn_bookingalertstatus_msfp_surveyresponses](#BKMK_msdyn_bookingalertstatus_msfp_surveyresponses)
- [msdyn_bookingrule_msfp_surveyresponses](#BKMK_msdyn_bookingrule_msfp_surveyresponses)
- [msdyn_bookingtimestamp_msfp_surveyresponses](#BKMK_msdyn_bookingtimestamp_msfp_surveyresponses)
- [msdyn_fieldservicesetting_msfp_surveyresponses](#BKMK_msdyn_fieldservicesetting_msfp_surveyresponses)
- [msdyn_incidenttypecharacteristic_msfp_surveyresponses](#BKMK_msdyn_incidenttypecharacteristic_msfp_surveyresponses)
- [msdyn_incidenttypeproduct_msfp_surveyresponses](#BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses)
- [msdyn_incidenttypeservice_msfp_surveyresponses](#BKMK_msdyn_incidenttypeservice_msfp_surveyresponses)
- [msdyn_inventoryadjustment_msfp_surveyresponses](#BKMK_msdyn_inventoryadjustment_msfp_surveyresponses)
- [msdyn_inventoryadjustmentproduct_msfp_surveyresponses](#BKMK_msdyn_inventoryadjustmentproduct_msfp_surveyresponses)
- [msdyn_inventoryjournal_msfp_surveyresponses](#BKMK_msdyn_inventoryjournal_msfp_surveyresponses)
- [msdyn_inventorytransfer_msfp_surveyresponses](#BKMK_msdyn_inventorytransfer_msfp_surveyresponses)
- [msdyn_payment_msfp_surveyresponses](#BKMK_msdyn_payment_msfp_surveyresponses)
- [msdyn_paymentdetail_msfp_surveyresponses](#BKMK_msdyn_paymentdetail_msfp_surveyresponses)
- [msdyn_paymentmethod_msfp_surveyresponses](#BKMK_msdyn_paymentmethod_msfp_surveyresponses)
- [msdyn_paymentterm_msfp_surveyresponses](#BKMK_msdyn_paymentterm_msfp_surveyresponses)
- [msdyn_postalcode_msfp_surveyresponses](#BKMK_msdyn_postalcode_msfp_surveyresponses)
- [msdyn_productinventory_msfp_surveyresponses](#BKMK_msdyn_productinventory_msfp_surveyresponses)
- [msdyn_purchaseorder_msfp_surveyresponses](#BKMK_msdyn_purchaseorder_msfp_surveyresponses)
- [msdyn_purchaseorderbill_msfp_surveyresponses](#BKMK_msdyn_purchaseorderbill_msfp_surveyresponses)
- [msdyn_purchaseorderproduct_msfp_surveyresponses](#BKMK_msdyn_purchaseorderproduct_msfp_surveyresponses)
- [msdyn_purchaseorderreceipt_msfp_surveyresponses](#BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses)
- [msdyn_purchaseorderreceiptproduct_msfp_surveyresponses](#BKMK_msdyn_purchaseorderreceiptproduct_msfp_surveyresponses)
- [msdyn_purchaseordersubstatus_msfp_surveyresponses](#BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses)
- [msdyn_quotebookingincident_msfp_surveyresponses](#BKMK_msdyn_quotebookingincident_msfp_surveyresponses)
- [msdyn_quotebookingproduct_msfp_surveyresponses](#BKMK_msdyn_quotebookingproduct_msfp_surveyresponses)
- [msdyn_quotebookingservice_msfp_surveyresponses](#BKMK_msdyn_quotebookingservice_msfp_surveyresponses)
- [msdyn_quotebookingservicetask_msfp_surveyresponses](#BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses)
- [msdyn_resourceterritory_msfp_surveyresponses](#BKMK_msdyn_resourceterritory_msfp_surveyresponses)
- [msdyn_rma_msfp_surveyresponses](#BKMK_msdyn_rma_msfp_surveyresponses)
- [msdyn_rmaproduct_msfp_surveyresponses](#BKMK_msdyn_rmaproduct_msfp_surveyresponses)
- [msdyn_rmareceipt_msfp_surveyresponses](#BKMK_msdyn_rmareceipt_msfp_surveyresponses)
- [msdyn_rmareceiptproduct_msfp_surveyresponses](#BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses)
- [msdyn_rmasubstatus_msfp_surveyresponses](#BKMK_msdyn_rmasubstatus_msfp_surveyresponses)
- [msdyn_rtv_msfp_surveyresponses](#BKMK_msdyn_rtv_msfp_surveyresponses)
- [msdyn_rtvproduct_msfp_surveyresponses](#BKMK_msdyn_rtvproduct_msfp_surveyresponses)
- [msdyn_rtvsubstatus_msfp_surveyresponses](#BKMK_msdyn_rtvsubstatus_msfp_surveyresponses)
- [msdyn_shipvia_msfp_surveyresponses](#BKMK_msdyn_shipvia_msfp_surveyresponses)
- [msdyn_systemuserschedulersetting_msfp_surveyresponses](#BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses)
- [msdyn_timegroup_msfp_surveyresponses](#BKMK_msdyn_timegroup_msfp_surveyresponses)
- [msdyn_timegroupdetail_msfp_surveyresponses](#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)
- [msdyn_timeoffrequest_msfp_surveyresponses](#BKMK_msdyn_timeoffrequest_msfp_surveyresponses)
- [msdyn_warehouse_msfp_surveyresponses](#BKMK_msdyn_warehouse_msfp_surveyresponses)
- [msdyn_workorder_msfp_surveyresponses](#BKMK_msdyn_workorder_msfp_surveyresponses)
- [msdyn_workordercharacteristic_msfp_surveyresponses](#BKMK_msdyn_workordercharacteristic_msfp_surveyresponses)
- [msdyn_workorderincident_msfp_surveyresponses](#BKMK_msdyn_workorderincident_msfp_surveyresponses)
- [msdyn_workorderproduct_msfp_surveyresponses](#BKMK_msdyn_workorderproduct_msfp_surveyresponses)
- [msdyn_workorderresourcerestriction_msfp_surveyresponses](#BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses)
- [msdyn_workorderservice_msfp_surveyresponses](#BKMK_msdyn_workorderservice_msfp_surveyresponses)
- [msdyn_workorderservicetask_msfp_surveyresponses](#BKMK_msdyn_workorderservicetask_msfp_surveyresponses)
- [msfp_surveyresponse_transactioncurrency_transactioncurrencyid](#BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid)

### <a name="BKMK_msdyn_agreement_msfp_surveyresponses"></a> msdyn_agreement_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_msfp_surveyresponses](msdyn_agreement.md#BKMK_msdyn_agreement_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_msfp_surveyresponses"></a> msdyn_agreementbookingdate_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_msfp_surveyresponses](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_msfp_surveyresponses"></a> msdyn_agreementbookingincident_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_msfp_surveyresponses](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_msfp_surveyresponses"></a> msdyn_agreementbookingproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_msfp_surveyresponses](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_msfp_surveyresponses"></a> msdyn_agreementbookingservice_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_msfp_surveyresponses](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_msfp_surveyresponses"></a> msdyn_agreementbookingservicetask_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_msfp_surveyresponses](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses"></a> msdyn_agreementbookingsetup_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_msfp_surveyresponses](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_msfp_surveyresponses"></a> msdyn_agreementinvoicedate_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_msfp_surveyresponses](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_msfp_surveyresponses"></a> msdyn_agreementinvoiceproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_msfp_surveyresponses](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses"></a> msdyn_agreementinvoicesetup_msfp_surveyresponses

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_msfp_surveyresponses](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_msfp_surveyresponses"></a> msdyn_bookingalertstatus_msfp_surveyresponses

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msfp_surveyresponses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msfp_surveyresponses"></a> msdyn_bookingrule_msfp_surveyresponses

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msfp_surveyresponses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_msfp_surveyresponses"></a> msdyn_bookingtimestamp_msfp_surveyresponses

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_msfp_surveyresponses](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_msfp_surveyresponses"></a> msdyn_fieldservicesetting_msfp_surveyresponses

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_msfp_surveyresponses](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_msfp_surveyresponses"></a> msdyn_incidenttypecharacteristic_msfp_surveyresponses

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_msfp_surveyresponses](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses"></a> msdyn_incidenttypeproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_msfp_surveyresponses](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_msfp_surveyresponses"></a> msdyn_incidenttypeservice_msfp_surveyresponses

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_msfp_surveyresponses](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_msfp_surveyresponses"></a> msdyn_inventoryadjustment_msfp_surveyresponses

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_msfp_surveyresponses](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msfp_surveyresponses"></a> msdyn_inventoryadjustmentproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_msfp_surveyresponses](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_msfp_surveyresponses"></a> msdyn_inventoryjournal_msfp_surveyresponses

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_msfp_surveyresponses](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_msfp_surveyresponses"></a> msdyn_inventorytransfer_msfp_surveyresponses

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_msfp_surveyresponses](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_msfp_surveyresponses"></a> msdyn_payment_msfp_surveyresponses

One-To-Many Relationship: [msdyn_payment msdyn_payment_msfp_surveyresponses](msdyn_payment.md#BKMK_msdyn_payment_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_msfp_surveyresponses"></a> msdyn_paymentdetail_msfp_surveyresponses

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_msfp_surveyresponses](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_msfp_surveyresponses"></a> msdyn_paymentmethod_msfp_surveyresponses

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_msfp_surveyresponses](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_msfp_surveyresponses"></a> msdyn_paymentterm_msfp_surveyresponses

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_msfp_surveyresponses](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_msfp_surveyresponses"></a> msdyn_postalcode_msfp_surveyresponses

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_msfp_surveyresponses](msdyn_postalcode.md#BKMK_msdyn_postalcode_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_msfp_surveyresponses"></a> msdyn_productinventory_msfp_surveyresponses

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_msfp_surveyresponses](msdyn_productinventory.md#BKMK_msdyn_productinventory_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_msfp_surveyresponses"></a> msdyn_purchaseorder_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_msfp_surveyresponses](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_msfp_surveyresponses"></a> msdyn_purchaseorderbill_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_msfp_surveyresponses](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_msfp_surveyresponses"></a> msdyn_purchaseorderproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_msfp_surveyresponses](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses"></a> msdyn_purchaseorderreceipt_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_msfp_surveyresponses](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msfp_surveyresponses"></a> msdyn_purchaseorderreceiptproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_msfp_surveyresponses](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses"></a> msdyn_purchaseordersubstatus_msfp_surveyresponses

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_msfp_surveyresponses](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_msfp_surveyresponses"></a> msdyn_quotebookingincident_msfp_surveyresponses

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_msfp_surveyresponses](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_msfp_surveyresponses"></a> msdyn_quotebookingproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_msfp_surveyresponses](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_msfp_surveyresponses"></a> msdyn_quotebookingservice_msfp_surveyresponses

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_msfp_surveyresponses](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses"></a> msdyn_quotebookingservicetask_msfp_surveyresponses

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_msfp_surveyresponses](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msfp_surveyresponses"></a> msdyn_resourceterritory_msfp_surveyresponses

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msfp_surveyresponses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_msfp_surveyresponses"></a> msdyn_rma_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rma msdyn_rma_msfp_surveyresponses](msdyn_rma.md#BKMK_msdyn_rma_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_msfp_surveyresponses"></a> msdyn_rmaproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_msfp_surveyresponses](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_msfp_surveyresponses"></a> msdyn_rmareceipt_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_msfp_surveyresponses](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses"></a> msdyn_rmareceiptproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_msfp_surveyresponses](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_msfp_surveyresponses"></a> msdyn_rmasubstatus_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_msfp_surveyresponses](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_msfp_surveyresponses"></a> msdyn_rtv_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_msfp_surveyresponses](msdyn_rtv.md#BKMK_msdyn_rtv_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_msfp_surveyresponses"></a> msdyn_rtvproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_msfp_surveyresponses](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_msfp_surveyresponses"></a> msdyn_rtvsubstatus_msfp_surveyresponses

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_msfp_surveyresponses](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_msfp_surveyresponses"></a> msdyn_shipvia_msfp_surveyresponses

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_msfp_surveyresponses](msdyn_shipvia.md#BKMK_msdyn_shipvia_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses"></a> msdyn_systemuserschedulersetting_msfp_surveyresponses

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msfp_surveyresponses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msfp_surveyresponses"></a> msdyn_timegroup_msfp_surveyresponses

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msfp_surveyresponses](msdyn_timegroup.md#BKMK_msdyn_timegroup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_surveyresponses"></a> msdyn_timegroupdetail_msfp_surveyresponses

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msfp_surveyresponses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_msfp_surveyresponses"></a> msdyn_timeoffrequest_msfp_surveyresponses

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_msfp_surveyresponses](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_msfp_surveyresponses"></a> msdyn_warehouse_msfp_surveyresponses

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_msfp_surveyresponses](msdyn_warehouse.md#BKMK_msdyn_warehouse_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_msfp_surveyresponses"></a> msdyn_workorder_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_msfp_surveyresponses](msdyn_workorder.md#BKMK_msdyn_workorder_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_msfp_surveyresponses"></a> msdyn_workordercharacteristic_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_msfp_surveyresponses](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_msfp_surveyresponses"></a> msdyn_workorderincident_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_msfp_surveyresponses](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_msfp_surveyresponses"></a> msdyn_workorderproduct_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_msfp_surveyresponses](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses"></a> msdyn_workorderresourcerestriction_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_msfp_surveyresponses](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_msfp_surveyresponses"></a> msdyn_workorderservice_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_msfp_surveyresponses](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_msfp_surveyresponses"></a> msdyn_workorderservicetask_msfp_surveyresponses

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_msfp_surveyresponses](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid"></a> msfp_surveyresponse_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msfp_surveyresponse_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

