---
title: "Note (Annotation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Note (Annotation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Note (Annotation) table/entity reference

Note that is attached to one or more objects, including other notes.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Note (Annotation) table extends the [Microsoft Dynamics 365 Note (Annotation) table](/dynamics365/developer/entities/annotation).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/annotation#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_Annotations](#BKMK_msdyn_3dmodel_Annotations)
- [msdyn_actual_Annotations](#BKMK_msdyn_actual_Annotations)
- [msdyn_agreement_Annotations](#BKMK_msdyn_agreement_Annotations)
- [msdyn_agreementbookingdate_Annotations](#BKMK_msdyn_agreementbookingdate_Annotations)
- [msdyn_agreementbookingincident_Annotations](#BKMK_msdyn_agreementbookingincident_Annotations)
- [msdyn_agreementbookingproduct_Annotations](#BKMK_msdyn_agreementbookingproduct_Annotations)
- [msdyn_agreementbookingservice_Annotations](#BKMK_msdyn_agreementbookingservice_Annotations)
- [msdyn_agreementbookingservicetask_Annotations](#BKMK_msdyn_agreementbookingservicetask_Annotations)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementinvoicedate_Annotations](#BKMK_msdyn_agreementinvoicedate_Annotations)
- [msdyn_agreementinvoiceproduct_Annotations](#BKMK_msdyn_agreementinvoiceproduct_Annotations)
- [msdyn_agreementinvoicesetup_Annotations](#BKMK_msdyn_agreementinvoicesetup_Annotations)
- [msdyn_agreementsubstatus_Annotations](#BKMK_msdyn_agreementsubstatus_Annotations)
- [msdyn_bookingalert_Annotations](#BKMK_msdyn_bookingalert_Annotations)
- [msdyn_bookingalertstatus_Annotations](#BKMK_msdyn_bookingalertstatus_Annotations)
- [msdyn_bookingjournal_Annotations](#BKMK_msdyn_bookingjournal_Annotations)
- [msdyn_bookingrule_Annotations](#BKMK_msdyn_bookingrule_Annotations)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_fieldservicesetting_Annotations](#BKMK_msdyn_fieldservicesetting_Annotations)
- [msdyn_incidenttype_Annotations](#BKMK_msdyn_incidenttype_Annotations)
- [msdyn_incidenttypecharacteristic_Annotations](#BKMK_msdyn_incidenttypecharacteristic_Annotations)
- [msdyn_incidenttypeproduct_Annotations](#BKMK_msdyn_incidenttypeproduct_Annotations)
- [msdyn_incidenttypeservice_Annotations](#BKMK_msdyn_incidenttypeservice_Annotations)
- [msdyn_incidenttypessetup_Annotations](#BKMK_msdyn_incidenttypessetup_Annotations)
- [msdyn_inspectionattachment_Annotations](#BKMK_msdyn_inspectionattachment_Annotations)
- [msdyn_insurance_Annotations](#BKMK_msdyn_insurance_Annotations)
- [msdyn_inventoryadjustment_Annotations](#BKMK_msdyn_inventoryadjustment_Annotations)
- [msdyn_inventoryadjustmentproduct_Annotations](#BKMK_msdyn_inventoryadjustmentproduct_Annotations)
- [msdyn_inventoryjournal_Annotations](#BKMK_msdyn_inventoryjournal_Annotations)
- [msdyn_inventorytransfer_Annotations](#BKMK_msdyn_inventorytransfer_Annotations)
- [msdyn_organizationalunit_Annotations](#BKMK_msdyn_organizationalunit_Annotations)
- [msdyn_payment_Annotations](#BKMK_msdyn_payment_Annotations)
- [msdyn_paymentdetail_Annotations](#BKMK_msdyn_paymentdetail_Annotations)
- [msdyn_paymentmethod_Annotations](#BKMK_msdyn_paymentmethod_Annotations)
- [msdyn_paymentterm_Annotations](#BKMK_msdyn_paymentterm_Annotations)
- [msdyn_postalcode_Annotations](#BKMK_msdyn_postalcode_Annotations)
- [msdyn_priority_Annotations](#BKMK_msdyn_priority_Annotations)
- [msdyn_productinventory_Annotations](#BKMK_msdyn_productinventory_Annotations)
- [msdyn_purchaseorder_Annotations](#BKMK_msdyn_purchaseorder_Annotations)
- [msdyn_purchaseorderbill_Annotations](#BKMK_msdyn_purchaseorderbill_Annotations)
- [msdyn_purchaseorderproduct_Annotations](#BKMK_msdyn_purchaseorderproduct_Annotations)
- [msdyn_purchaseorderreceipt_Annotations](#BKMK_msdyn_purchaseorderreceipt_Annotations)
- [msdyn_purchaseorderreceiptproduct_Annotations](#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)
- [msdyn_purchaseordersubstatus_Annotations](#BKMK_msdyn_purchaseordersubstatus_Annotations)
- [msdyn_quotebookingincident_Annotations](#BKMK_msdyn_quotebookingincident_Annotations)
- [msdyn_quotebookingproduct_Annotations](#BKMK_msdyn_quotebookingproduct_Annotations)
- [msdyn_quotebookingservice_Annotations](#BKMK_msdyn_quotebookingservice_Annotations)
- [msdyn_quotebookingservicetask_Annotations](#BKMK_msdyn_quotebookingservicetask_Annotations)
- [msdyn_requirementcharacteristic_Annotations](#BKMK_msdyn_requirementcharacteristic_Annotations)
- [msdyn_requirementresourcecategory_Annotations](#BKMK_msdyn_requirementresourcecategory_Annotations)
- [msdyn_requirementresourcepreference_Annotations](#BKMK_msdyn_requirementresourcepreference_Annotations)
- [msdyn_requirementstatus_Annotations](#BKMK_msdyn_requirementstatus_Annotations)
- [msdyn_resourcepaytype_Annotations](#BKMK_msdyn_resourcepaytype_Annotations)
- [msdyn_resourcerequirement_Annotations](#BKMK_msdyn_resourcerequirement_Annotations)
- [msdyn_resourcerequirementdetail_Annotations](#BKMK_msdyn_resourcerequirementdetail_Annotations)
- [msdyn_resourceterritory_Annotations](#BKMK_msdyn_resourceterritory_Annotations)
- [msdyn_rma_Annotations](#BKMK_msdyn_rma_Annotations)
- [msdyn_rmaproduct_Annotations](#BKMK_msdyn_rmaproduct_Annotations)
- [msdyn_rmareceipt_Annotations](#BKMK_msdyn_rmareceipt_Annotations)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmasubstatus_Annotations](#BKMK_msdyn_rmasubstatus_Annotations)
- [msdyn_rtv_Annotations](#BKMK_msdyn_rtv_Annotations)
- [msdyn_rtvproduct_Annotations](#BKMK_msdyn_rtvproduct_Annotations)
- [msdyn_rtvsubstatus_Annotations](#BKMK_msdyn_rtvsubstatus_Annotations)
- [msdyn_servicetasktype_Annotations](#BKMK_msdyn_servicetasktype_Annotations)
- [msdyn_shipvia_Annotations](#BKMK_msdyn_shipvia_Annotations)
- [msdyn_systemuserschedulersetting_Annotations](#BKMK_msdyn_systemuserschedulersetting_Annotations)
- [msdyn_taxcode_Annotations](#BKMK_msdyn_taxcode_Annotations)
- [msdyn_taxcodedetail_Annotations](#BKMK_msdyn_taxcodedetail_Annotations)
- [msdyn_timeentry_Annotations](#BKMK_msdyn_timeentry_Annotations)
- [msdyn_timegroup_Annotations](#BKMK_msdyn_timegroup_Annotations)
- [msdyn_timegroupdetail_Annotations](#BKMK_msdyn_timegroupdetail_Annotations)
- [msdyn_timeoffrequest_Annotations](#BKMK_msdyn_timeoffrequest_Annotations)
- [msdyn_transactionorigin_Annotations](#BKMK_msdyn_transactionorigin_Annotations)
- [msdyn_warehouse_Annotations](#BKMK_msdyn_warehouse_Annotations)
- [msdyn_workorder_Annotations](#BKMK_msdyn_workorder_Annotations)
- [msdyn_workorderincident_Annotations](#BKMK_msdyn_workorderincident_Annotations)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderresourcerestriction_Annotations](#BKMK_msdyn_workorderresourcerestriction_Annotations)
- [msdyn_workorderservice_Annotations](#BKMK_msdyn_workorderservice_Annotations)
- [msdyn_workorderservicetask_Annotations](#BKMK_msdyn_workorderservicetask_Annotations)
- [msdyn_workordersubstatus_Annotations](#BKMK_msdyn_workordersubstatus_Annotations)

### <a name="BKMK_msdyn_3dmodel_Annotations"></a> msdyn_3dmodel_Annotations

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_Annotations](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_Annotations"></a> msdyn_actual_Annotations

One-To-Many Relationship: [msdyn_actual msdyn_actual_Annotations](msdyn_actual.md#BKMK_msdyn_actual_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreement_Annotations"></a> msdyn_agreement_Annotations

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Annotations](msdyn_agreement.md#BKMK_msdyn_agreement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Annotations"></a> msdyn_agreementbookingdate_Annotations

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Annotations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Annotations"></a> msdyn_agreementbookingincident_Annotations

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Annotations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Annotations"></a> msdyn_agreementbookingproduct_Annotations

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Annotations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Annotations"></a> msdyn_agreementbookingservice_Annotations

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Annotations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Annotations"></a> msdyn_agreementbookingservicetask_Annotations

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Annotations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Annotations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Annotations"></a> msdyn_agreementinvoicedate_Annotations

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Annotations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Annotations"></a> msdyn_agreementinvoiceproduct_Annotations

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Annotations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Annotations"></a> msdyn_agreementinvoicesetup_Annotations

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Annotations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementsubstatus_Annotations"></a> msdyn_agreementsubstatus_Annotations

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_Annotations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalert_Annotations"></a> msdyn_bookingalert_Annotations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_Annotations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Annotations"></a> msdyn_bookingalertstatus_Annotations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Annotations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingjournal_Annotations"></a> msdyn_bookingjournal_Annotations

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_Annotations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Annotations"></a> msdyn_bookingrule_Annotations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Annotations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Annotations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Annotations"></a> msdyn_fieldservicesetting_Annotations

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Annotations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttype_Annotations"></a> msdyn_incidenttype_Annotations

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_Annotations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Annotations"></a> msdyn_incidenttypecharacteristic_Annotations

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Annotations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Annotations"></a> msdyn_incidenttypeproduct_Annotations

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Annotations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Annotations"></a> msdyn_incidenttypeservice_Annotations

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Annotations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypessetup_Annotations"></a> msdyn_incidenttypessetup_Annotations

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_Annotations](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inspectionattachment_Annotations"></a> msdyn_inspectionattachment_Annotations

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_Annotations](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_insurance_Annotations"></a> msdyn_insurance_Annotations

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_Annotations](msdyn_insurance.md#BKMK_msdyn_insurance_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Annotations"></a> msdyn_inventoryadjustment_Annotations

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Annotations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Annotations"></a> msdyn_inventoryadjustmentproduct_Annotations

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Annotations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Annotations"></a> msdyn_inventoryjournal_Annotations

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Annotations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Annotations"></a> msdyn_inventorytransfer_Annotations

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Annotations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_organizationalunit_Annotations"></a> msdyn_organizationalunit_Annotations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_Annotations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_Annotations"></a> msdyn_payment_Annotations

One-To-Many Relationship: [msdyn_payment msdyn_payment_Annotations](msdyn_payment.md#BKMK_msdyn_payment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Annotations"></a> msdyn_paymentdetail_Annotations

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Annotations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Annotations"></a> msdyn_paymentmethod_Annotations

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Annotations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Annotations"></a> msdyn_paymentterm_Annotations

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Annotations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Annotations"></a> msdyn_postalcode_Annotations

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Annotations](msdyn_postalcode.md#BKMK_msdyn_postalcode_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_priority_Annotations"></a> msdyn_priority_Annotations

One-To-Many Relationship: [msdyn_priority msdyn_priority_Annotations](msdyn_priority.md#BKMK_msdyn_priority_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Annotations"></a> msdyn_productinventory_Annotations

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Annotations](msdyn_productinventory.md#BKMK_msdyn_productinventory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Annotations"></a> msdyn_purchaseorder_Annotations

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Annotations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Annotations"></a> msdyn_purchaseorderbill_Annotations

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Annotations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Annotations"></a> msdyn_purchaseorderproduct_Annotations

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Annotations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Annotations"></a> msdyn_purchaseorderreceipt_Annotations

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Annotations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Annotations"></a> msdyn_purchaseorderreceiptproduct_Annotations

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Annotations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Annotations"></a> msdyn_purchaseordersubstatus_Annotations

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Annotations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Annotations"></a> msdyn_quotebookingincident_Annotations

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Annotations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Annotations"></a> msdyn_quotebookingproduct_Annotations

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Annotations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Annotations"></a> msdyn_quotebookingservice_Annotations

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Annotations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Annotations"></a> msdyn_quotebookingservicetask_Annotations

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Annotations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_Annotations"></a> msdyn_requirementcharacteristic_Annotations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_Annotations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_Annotations"></a> msdyn_requirementresourcecategory_Annotations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_Annotations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_Annotations"></a> msdyn_requirementresourcepreference_Annotations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_Annotations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementstatus_Annotations"></a> msdyn_requirementstatus_Annotations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_Annotations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcepaytype_Annotations"></a> msdyn_resourcepaytype_Annotations

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_Annotations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirement_Annotations"></a> msdyn_resourcerequirement_Annotations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_Annotations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_Annotations"></a> msdyn_resourcerequirementdetail_Annotations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_Annotations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Annotations"></a> msdyn_resourceterritory_Annotations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Annotations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Annotations"></a> msdyn_rma_Annotations

One-To-Many Relationship: [msdyn_rma msdyn_rma_Annotations](msdyn_rma.md#BKMK_msdyn_rma_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Annotations"></a> msdyn_rmaproduct_Annotations

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Annotations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Annotations"></a> msdyn_rmareceipt_Annotations

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Annotations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Annotations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Annotations"></a> msdyn_rmasubstatus_Annotations

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Annotations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Annotations"></a> msdyn_rtv_Annotations

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Annotations](msdyn_rtv.md#BKMK_msdyn_rtv_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Annotations"></a> msdyn_rtvproduct_Annotations

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Annotations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Annotations"></a> msdyn_rtvsubstatus_Annotations

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Annotations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_servicetasktype_Annotations"></a> msdyn_servicetasktype_Annotations

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_Annotations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Annotations"></a> msdyn_shipvia_Annotations

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Annotations](msdyn_shipvia.md#BKMK_msdyn_shipvia_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Annotations"></a> msdyn_systemuserschedulersetting_Annotations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Annotations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taxcode_Annotations"></a> msdyn_taxcode_Annotations

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_Annotations](msdyn_taxcode.md#BKMK_msdyn_taxcode_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taxcodedetail_Annotations"></a> msdyn_taxcodedetail_Annotations

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_Annotations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeentry_Annotations"></a> msdyn_timeentry_Annotations

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_Annotations](msdyn_timeentry.md#BKMK_msdyn_timeentry_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Annotations"></a> msdyn_timegroup_Annotations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Annotations](msdyn_timegroup.md#BKMK_msdyn_timegroup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Annotations"></a> msdyn_timegroupdetail_Annotations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Annotations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Annotations"></a> msdyn_timeoffrequest_Annotations

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Annotations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_transactionorigin_Annotations"></a> msdyn_transactionorigin_Annotations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_Annotations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Annotations"></a> msdyn_warehouse_Annotations

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Annotations](msdyn_warehouse.md#BKMK_msdyn_warehouse_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Annotations"></a> msdyn_workorder_Annotations

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Annotations](msdyn_workorder.md#BKMK_msdyn_workorder_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Annotations"></a> msdyn_workorderincident_Annotations

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Annotations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Annotations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Annotations"></a> msdyn_workorderresourcerestriction_Annotations

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Annotations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Annotations"></a> msdyn_workorderservice_Annotations

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Annotations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Annotations"></a> msdyn_workorderservicetask_Annotations

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Annotations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordersubstatus_Annotations"></a> msdyn_workordersubstatus_Annotations

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_Annotations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.annotation?displayProperty=fullName>
