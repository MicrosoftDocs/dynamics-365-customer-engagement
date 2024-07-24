---
title: "Process Stage (ProcessStage) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Process Stage (ProcessStage) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Process Stage (ProcessStage) table/entity reference

Stage associated with a process.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Process Stage (ProcessStage) table extends the [Microsoft Dataverse Process Stage (ProcessStage) table](/power-apps/developer/data-platform/reference/entities/processstage).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid](#BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid)
- [lk_leadtoopportunitysalesprocess_activestageid](#BKMK_lk_leadtoopportunitysalesprocess_activestageid)
- [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid](#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid)
- [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid)
- [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid](#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid)
- [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid](#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid)
- [lk_msdyn_iottocaseprocess_activestageid](#BKMK_lk_msdyn_iottocaseprocess_activestageid)
- [lk_msdyncrm_leadtoopportunity_activestageid](#BKMK_lk_msdyncrm_leadtoopportunity_activestageid)
- [lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid](#BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid)
- [lk_opportunitysalesprocess_activestageid](#BKMK_lk_opportunitysalesprocess_activestageid)
- [lk_phonetocaseprocess_activestageid](#BKMK_lk_phonetocaseprocess_activestageid)
- [msdyn_processstage_msdyn_timespent_stage](#BKMK_msdyn_processstage_msdyn_timespent_stage)
- [processstage_BookableResource](#BKMK_processstage_BookableResource)
- [processstage_BookableResourceBooking](#BKMK_processstage_BookableResourceBooking)
- [processstage_BookableResourceBookingHeader](#BKMK_processstage_BookableResourceBookingHeader)
- [processstage_BookableResourceCharacteristic](#BKMK_processstage_BookableResourceCharacteristic)
- [processstage_campaignactivities](#BKMK_processstage_campaignactivities)
- [processstage_campaignresponses](#BKMK_processstage_campaignresponses)
- [processstage_campaigns](#BKMK_processstage_campaigns)
- [processstage_competitors](#BKMK_processstage_competitors)
- [processstage_Entitlement](#BKMK_processstage_Entitlement)
- [processstage_incident](#BKMK_processstage_incident)
- [processstage_invoices](#BKMK_processstage_invoices)
- [processstage_lead](#BKMK_processstage_lead)
- [processstage_lists](#BKMK_processstage_lists)
- [processstage_msdyn_agreement](#BKMK_processstage_msdyn_agreement)
- [processstage_msdyn_agreementbookingsetup](#BKMK_processstage_msdyn_agreementbookingsetup)
- [processstage_msdyn_agreementinvoicesetup](#BKMK_processstage_msdyn_agreementinvoicesetup)
- [processstage_msdyn_iotalert](#BKMK_processstage_msdyn_iotalert)
- [processstage_msdyn_purchaseorder](#BKMK_processstage_msdyn_purchaseorder)
- [processstage_msdyn_purchaseorderbill](#BKMK_processstage_msdyn_purchaseorderbill)
- [processstage_msdyn_purchaseorderreceipt](#BKMK_processstage_msdyn_purchaseorderreceipt)
- [processstage_msdyn_quotebookingsetup](#BKMK_processstage_msdyn_quotebookingsetup)
- [processstage_msdyn_timeentry](#BKMK_processstage_msdyn_timeentry)
- [processstage_msdyn_timegroup](#BKMK_processstage_msdyn_timegroup)
- [processstage_msdyn_timegroupdetail](#BKMK_processstage_msdyn_timegroupdetail)
- [processstage_msdyn_workorder](#BKMK_processstage_msdyn_workorder)
- [processstage_msevtmgt_Event](#BKMK_processstage_msevtmgt_Event)
- [processstage_msevtmgt_Speaker](#BKMK_processstage_msevtmgt_Speaker)
- [processstage_opportunity](#BKMK_processstage_opportunity)
- [processstage_productpricelevels](#BKMK_processstage_productpricelevels)
- [processstage_products](#BKMK_processstage_products)
- [processstage_quotes](#BKMK_processstage_quotes)
- [processstage_salesliteratures](#BKMK_processstage_salesliteratures)
- [processstage_salesorders](#BKMK_processstage_salesorders)

### <a name="BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid"></a> lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid

Many-To-One Relationship: [adx_bpf_c2857b638fa7473d8e2f112c232cebd8 lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid](adx_bpf_c2857b638fa7473d8e2f112c232cebd8.md#BKMK_lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_activestageid"></a> lk_leadtoopportunitysalesprocess_activestageid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_activestageid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`processstage_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid"></a> lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid

Many-To-One Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid"></a> lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid

Many-To-One Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid"></a> lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid

Many-To-One Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid"></a> lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid

Many-To-One Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_activestageid"></a> lk_msdyn_iottocaseprocess_activestageid

Many-To-One Relationship: [msdyn_iottocaseprocess lk_msdyn_iottocaseprocess_activestageid](msdyn_iottocaseprocess.md#BKMK_lk_msdyn_iottocaseprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_iottocaseprocess_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyncrm_leadtoopportunity_activestageid"></a> lk_msdyncrm_leadtoopportunity_activestageid

Many-To-One Relationship: [msdyncrm_leadtoopportunity lk_msdyncrm_leadtoopportunity_activestageid](msdyncrm_leadtoopportunity.md#BKMK_lk_msdyncrm_leadtoopportunity_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadtoopportunity`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyncrm_leadtoopportunity_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid"></a> lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid

Many-To-One Relationship: [msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md#BKMK_lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_opportunitysalesprocess_activestageid"></a> lk_opportunitysalesprocess_activestageid

Many-To-One Relationship: [opportunitysalesprocess lk_opportunitysalesprocess_activestageid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`processstage_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_phonetocaseprocess_activestageid"></a> lk_phonetocaseprocess_activestageid

Many-To-One Relationship: [phonetocaseprocess lk_phonetocaseprocess_activestageid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`phonetocaseprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`processstage_phonetocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_processstage_msdyn_timespent_stage"></a> msdyn_processstage_msdyn_timespent_stage

Many-To-One Relationship: [msdyn_timespent msdyn_processstage_msdyn_timespent_stage](msdyn_timespent.md#BKMK_msdyn_processstage_msdyn_timespent_stage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`msdyn_stage`|
|ReferencedEntityNavigationPropertyName|`msdyn_processstage_msdyn_timespent_stage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_BookableResource"></a> processstage_BookableResource

Many-To-One Relationship: [bookableresource processstage_BookableResource](bookableresource.md#BKMK_processstage_BookableResource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_BookableResource`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

Many-To-One Relationship: [bookableresourcebooking processstage_BookableResourceBooking](bookableresourcebooking.md#BKMK_processstage_BookableResourceBooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_BookableResourceBooking`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_BookableResourceBookingHeader"></a> processstage_BookableResourceBookingHeader

Many-To-One Relationship: [bookableresourcebookingheader processstage_BookableResourceBookingHeader](bookableresourcebookingheader.md#BKMK_processstage_BookableResourceBookingHeader)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_BookableResourceBookingHeader`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_BookableResourceCharacteristic"></a> processstage_BookableResourceCharacteristic

Many-To-One Relationship: [bookableresourcecharacteristic processstage_BookableResourceCharacteristic](bookableresourcecharacteristic.md#BKMK_processstage_BookableResourceCharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_BookableResourceCharacteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_campaignactivities"></a> processstage_campaignactivities

Many-To-One Relationship: [campaignactivity processstage_campaignactivities](campaignactivity.md#BKMK_processstage_campaignactivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_campaignactivities`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_campaignresponses"></a> processstage_campaignresponses

Many-To-One Relationship: [campaignresponse processstage_campaignresponses](campaignresponse.md#BKMK_processstage_campaignresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_campaignresponses`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

Many-To-One Relationship: [campaign processstage_campaigns](campaign.md#BKMK_processstage_campaigns)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_campaigns`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_competitors"></a> processstage_competitors

Many-To-One Relationship: [competitor processstage_competitors](competitor.md#BKMK_processstage_competitors)

|Property|Value|
|---|---|
|ReferencingEntity|`competitor`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_competitors`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_Entitlement"></a> processstage_Entitlement

Many-To-One Relationship: [entitlement processstage_Entitlement](entitlement.md#BKMK_processstage_Entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_Entitlement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_incident"></a> processstage_incident

Many-To-One Relationship: [incident processstage_incident](incident.md#BKMK_processstage_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_invoices"></a> processstage_invoices

Many-To-One Relationship: [invoice processstage_invoices](invoice.md#BKMK_processstage_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_invoices`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_lead"></a> processstage_lead

Many-To-One Relationship: [lead processstage_lead](lead.md#BKMK_processstage_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_lead`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_lists"></a> processstage_lists

Many-To-One Relationship: [list processstage_lists](list.md#BKMK_processstage_lists)

|Property|Value|
|---|---|
|ReferencingEntity|`list`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_lists`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_agreement"></a> processstage_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement processstage_msdyn_agreement](msdyn_agreement.md#BKMK_processstage_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_agreement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup processstage_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_processstage_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_agreementbookingsetup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_agreementinvoicesetup"></a> processstage_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup processstage_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_processstage_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_agreementinvoicesetup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_iotalert"></a> processstage_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert processstage_msdyn_iotalert](msdyn_iotalert.md#BKMK_processstage_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_iotalert`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_purchaseorder"></a> processstage_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder processstage_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_processstage_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_purchaseorder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_purchaseorderbill"></a> processstage_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill processstage_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_processstage_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_purchaseorderbill`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_purchaseorderreceipt"></a> processstage_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt processstage_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_processstage_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_purchaseorderreceipt`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup processstage_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_processstage_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_quotebookingsetup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_timeentry"></a> processstage_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry processstage_msdyn_timeentry](msdyn_timeentry.md#BKMK_processstage_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_timeentry`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_timegroup"></a> processstage_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup processstage_msdyn_timegroup](msdyn_timegroup.md#BKMK_processstage_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_timegroup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_timegroupdetail"></a> processstage_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail processstage_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_processstage_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_timegroupdetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_workorder"></a> processstage_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder processstage_msdyn_workorder](msdyn_workorder.md#BKMK_processstage_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_workorder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msevtmgt_Event"></a> processstage_msevtmgt_Event

Many-To-One Relationship: [msevtmgt_event processstage_msevtmgt_Event](msevtmgt_event.md#BKMK_processstage_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msevtmgt_Event`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msevtmgt_Speaker"></a> processstage_msevtmgt_Speaker

Many-To-One Relationship: [msevtmgt_speaker processstage_msevtmgt_Speaker](msevtmgt_speaker.md#BKMK_processstage_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msevtmgt_Speaker`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_opportunity"></a> processstage_opportunity

Many-To-One Relationship: [opportunity processstage_opportunity](opportunity.md#BKMK_processstage_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_opportunity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

Many-To-One Relationship: [productpricelevel processstage_productpricelevels](productpricelevel.md#BKMK_processstage_productpricelevels)

|Property|Value|
|---|---|
|ReferencingEntity|`productpricelevel`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_productpricelevels`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_products"></a> processstage_products

Many-To-One Relationship: [product processstage_products](product.md#BKMK_processstage_products)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_products`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_quotes"></a> processstage_quotes

Many-To-One Relationship: [quote processstage_quotes](quote.md#BKMK_processstage_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_quotes`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_salesliteratures"></a> processstage_salesliteratures

Many-To-One Relationship: [salesliterature processstage_salesliteratures](salesliterature.md#BKMK_processstage_salesliteratures)

|Property|Value|
|---|---|
|ReferencingEntity|`salesliterature`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_salesliteratures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_salesorders"></a> processstage_salesorders

Many-To-One Relationship: [salesorder processstage_salesorders](salesorder.md#BKMK_processstage_salesorders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_salesorders`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.processstage?displayProperty=fullName>
