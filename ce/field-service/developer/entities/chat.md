---
title: "Teams chat (chat) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Teams chat (chat) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Teams chat (chat) table/entity reference (Microsoft Dynamics 365 Field Service)

For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Teams chat (chat) table extends the [Microsoft Dynamics 365 Teams chat (chat) table](/dynamics365/developer/entities/chat).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreement_chats](#BKMK_msdyn_agreement_chats)
- [msdyn_agreementbookingdate_chats](#BKMK_msdyn_agreementbookingdate_chats)
- [msdyn_agreementbookingincident_chats](#BKMK_msdyn_agreementbookingincident_chats)
- [msdyn_agreementbookingproduct_chats](#BKMK_msdyn_agreementbookingproduct_chats)
- [msdyn_agreementbookingservice_chats](#BKMK_msdyn_agreementbookingservice_chats)
- [msdyn_agreementbookingservicetask_chats](#BKMK_msdyn_agreementbookingservicetask_chats)
- [msdyn_agreementbookingsetup_chats](#BKMK_msdyn_agreementbookingsetup_chats)
- [msdyn_agreementinvoicedate_chats](#BKMK_msdyn_agreementinvoicedate_chats)
- [msdyn_agreementinvoiceproduct_chats](#BKMK_msdyn_agreementinvoiceproduct_chats)
- [msdyn_agreementinvoicesetup_chats](#BKMK_msdyn_agreementinvoicesetup_chats)
- [msdyn_bookingalertstatus_chats](#BKMK_msdyn_bookingalertstatus_chats)
- [msdyn_bookingrule_chats](#BKMK_msdyn_bookingrule_chats)
- [msdyn_bookingtimestamp_chats](#BKMK_msdyn_bookingtimestamp_chats)
- [msdyn_fieldservicesetting_chats](#BKMK_msdyn_fieldservicesetting_chats)
- [msdyn_incidenttypecharacteristic_chats](#BKMK_msdyn_incidenttypecharacteristic_chats)
- [msdyn_incidenttypeproduct_chats](#BKMK_msdyn_incidenttypeproduct_chats)
- [msdyn_incidenttypeservice_chats](#BKMK_msdyn_incidenttypeservice_chats)
- [msdyn_inventoryadjustment_chats](#BKMK_msdyn_inventoryadjustment_chats)
- [msdyn_inventoryadjustmentproduct_chats](#BKMK_msdyn_inventoryadjustmentproduct_chats)
- [msdyn_inventoryjournal_chats](#BKMK_msdyn_inventoryjournal_chats)
- [msdyn_inventorytransfer_chats](#BKMK_msdyn_inventorytransfer_chats)
- [msdyn_payment_chats](#BKMK_msdyn_payment_chats)
- [msdyn_paymentdetail_chats](#BKMK_msdyn_paymentdetail_chats)
- [msdyn_paymentmethod_chats](#BKMK_msdyn_paymentmethod_chats)
- [msdyn_paymentterm_chats](#BKMK_msdyn_paymentterm_chats)
- [msdyn_postalcode_chats](#BKMK_msdyn_postalcode_chats)
- [msdyn_productinventory_chats](#BKMK_msdyn_productinventory_chats)
- [msdyn_purchaseorder_chats](#BKMK_msdyn_purchaseorder_chats)
- [msdyn_purchaseorderbill_chats](#BKMK_msdyn_purchaseorderbill_chats)
- [msdyn_purchaseorderproduct_chats](#BKMK_msdyn_purchaseorderproduct_chats)
- [msdyn_purchaseorderreceipt_chats](#BKMK_msdyn_purchaseorderreceipt_chats)
- [msdyn_purchaseorderreceiptproduct_chats](#BKMK_msdyn_purchaseorderreceiptproduct_chats)
- [msdyn_purchaseordersubstatus_chats](#BKMK_msdyn_purchaseordersubstatus_chats)
- [msdyn_quotebookingincident_chats](#BKMK_msdyn_quotebookingincident_chats)
- [msdyn_quotebookingproduct_chats](#BKMK_msdyn_quotebookingproduct_chats)
- [msdyn_quotebookingservice_chats](#BKMK_msdyn_quotebookingservice_chats)
- [msdyn_quotebookingservicetask_chats](#BKMK_msdyn_quotebookingservicetask_chats)
- [msdyn_resourceterritory_chats](#BKMK_msdyn_resourceterritory_chats)
- [msdyn_rma_chats](#BKMK_msdyn_rma_chats)
- [msdyn_rmaproduct_chats](#BKMK_msdyn_rmaproduct_chats)
- [msdyn_rmareceipt_chats](#BKMK_msdyn_rmareceipt_chats)
- [msdyn_rmareceiptproduct_chats](#BKMK_msdyn_rmareceiptproduct_chats)
- [msdyn_rmasubstatus_chats](#BKMK_msdyn_rmasubstatus_chats)
- [msdyn_rtv_chats](#BKMK_msdyn_rtv_chats)
- [msdyn_rtvproduct_chats](#BKMK_msdyn_rtvproduct_chats)
- [msdyn_rtvsubstatus_chats](#BKMK_msdyn_rtvsubstatus_chats)
- [msdyn_shipvia_chats](#BKMK_msdyn_shipvia_chats)
- [msdyn_systemuserschedulersetting_chats](#BKMK_msdyn_systemuserschedulersetting_chats)
- [msdyn_timegroup_chats](#BKMK_msdyn_timegroup_chats)
- [msdyn_timegroupdetail_chats](#BKMK_msdyn_timegroupdetail_chats)
- [msdyn_timeoffrequest_chats](#BKMK_msdyn_timeoffrequest_chats)
- [msdyn_warehouse_chats](#BKMK_msdyn_warehouse_chats)
- [msdyn_workorder_chats](#BKMK_msdyn_workorder_chats)
- [msdyn_workorderincident_chats](#BKMK_msdyn_workorderincident_chats)
- [msdyn_workorderproduct_chats](#BKMK_msdyn_workorderproduct_chats)
- [msdyn_workorderresourcerestriction_chats](#BKMK_msdyn_workorderresourcerestriction_chats)
- [msdyn_workorderservice_chats](#BKMK_msdyn_workorderservice_chats)
- [msdyn_workorderservicetask_chats](#BKMK_msdyn_workorderservicetask_chats)

### <a name="BKMK_msdyn_agreement_chats"></a> msdyn_agreement_chats

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_chats](msdyn_agreement.md#BKMK_msdyn_agreement_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_chats"></a> msdyn_agreementbookingdate_chats

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_chats](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_chats"></a> msdyn_agreementbookingincident_chats

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_chats](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_chats"></a> msdyn_agreementbookingproduct_chats

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_chats](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_chats"></a> msdyn_agreementbookingservice_chats

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_chats](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_chats"></a> msdyn_agreementbookingservicetask_chats

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_chats](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_chats"></a> msdyn_agreementbookingsetup_chats

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_chats](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_chats"></a> msdyn_agreementinvoicedate_chats

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_chats](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_chats"></a> msdyn_agreementinvoiceproduct_chats

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_chats](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_chats"></a> msdyn_agreementinvoicesetup_chats

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_chats](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_chats"></a> msdyn_bookingalertstatus_chats

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_chats](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_chats"></a> msdyn_bookingrule_chats

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_chats](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_chats"></a> msdyn_bookingtimestamp_chats

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_chats](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_chats"></a> msdyn_fieldservicesetting_chats

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_chats](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_chats"></a> msdyn_incidenttypecharacteristic_chats

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_chats](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_chats"></a> msdyn_incidenttypeproduct_chats

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_chats](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_chats"></a> msdyn_incidenttypeservice_chats

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_chats](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_chats"></a> msdyn_inventoryadjustment_chats

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_chats](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_chats"></a> msdyn_inventoryadjustmentproduct_chats

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_chats](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_chats"></a> msdyn_inventoryjournal_chats

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_chats](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_chats"></a> msdyn_inventorytransfer_chats

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_chats](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_chats"></a> msdyn_payment_chats

One-To-Many Relationship: [msdyn_payment msdyn_payment_chats](msdyn_payment.md#BKMK_msdyn_payment_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_chats"></a> msdyn_paymentdetail_chats

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_chats](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_chats"></a> msdyn_paymentmethod_chats

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_chats](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_chats"></a> msdyn_paymentterm_chats

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_chats](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_chats"></a> msdyn_postalcode_chats

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_chats](msdyn_postalcode.md#BKMK_msdyn_postalcode_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_chats"></a> msdyn_productinventory_chats

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_chats](msdyn_productinventory.md#BKMK_msdyn_productinventory_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_chats"></a> msdyn_purchaseorder_chats

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_chats](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_chats"></a> msdyn_purchaseorderbill_chats

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_chats](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_chats"></a> msdyn_purchaseorderproduct_chats

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_chats](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_chats"></a> msdyn_purchaseorderreceipt_chats

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_chats](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_chats"></a> msdyn_purchaseorderreceiptproduct_chats

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_chats](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_chats"></a> msdyn_purchaseordersubstatus_chats

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_chats](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_chats"></a> msdyn_quotebookingincident_chats

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_chats](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_chats"></a> msdyn_quotebookingproduct_chats

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_chats](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_chats"></a> msdyn_quotebookingservice_chats

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_chats](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_chats"></a> msdyn_quotebookingservicetask_chats

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_chats](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_chats"></a> msdyn_resourceterritory_chats

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_chats](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_chats"></a> msdyn_rma_chats

One-To-Many Relationship: [msdyn_rma msdyn_rma_chats](msdyn_rma.md#BKMK_msdyn_rma_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_chats"></a> msdyn_rmaproduct_chats

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_chats](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_chats"></a> msdyn_rmareceipt_chats

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_chats](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_chats"></a> msdyn_rmareceiptproduct_chats

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_chats](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_chats"></a> msdyn_rmasubstatus_chats

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_chats](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_chats"></a> msdyn_rtv_chats

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_chats](msdyn_rtv.md#BKMK_msdyn_rtv_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_chats"></a> msdyn_rtvproduct_chats

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_chats](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_chats"></a> msdyn_rtvsubstatus_chats

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_chats](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_chats"></a> msdyn_shipvia_chats

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_chats](msdyn_shipvia.md#BKMK_msdyn_shipvia_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_chats"></a> msdyn_systemuserschedulersetting_chats

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_chats](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_chats"></a> msdyn_timegroup_chats

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_chats](msdyn_timegroup.md#BKMK_msdyn_timegroup_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_chats"></a> msdyn_timegroupdetail_chats

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_chats](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_chats"></a> msdyn_timeoffrequest_chats

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_chats](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_chats"></a> msdyn_warehouse_chats

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_chats](msdyn_warehouse.md#BKMK_msdyn_warehouse_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_chats"></a> msdyn_workorder_chats

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_chats](msdyn_workorder.md#BKMK_msdyn_workorder_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_chats"></a> msdyn_workorderincident_chats

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_chats](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_chats"></a> msdyn_workorderproduct_chats

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_chats](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_chats"></a> msdyn_workorderresourcerestriction_chats

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_chats](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_chats"></a> msdyn_workorderservice_chats

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_chats](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_chats"></a> msdyn_workorderservicetask_chats

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_chats](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.chat?displayProperty=fullName>
