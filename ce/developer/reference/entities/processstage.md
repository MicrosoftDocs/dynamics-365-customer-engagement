---
title: "Process Stage (ProcessStage) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Process Stage (ProcessStage) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Process Stage (ProcessStage) table/entity reference (Microsoft Dynamics 365)

Stage associated with a process.

> [!NOTE]
> The Microsoft Dynamics 365 Process Stage (ProcessStage) table extends the [Microsoft Dataverse Process Stage (ProcessStage) table](/power-apps/developer/data-platform/reference/entities/processstage).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_leadtoopportunitysalesprocess_activestageid](#BKMK_lk_leadtoopportunitysalesprocess_activestageid)
- [lk_msdyn_iottocaseprocess_activestageid](#BKMK_lk_msdyn_iottocaseprocess_activestageid)
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
- [processstage_msdyn_iotalert](#BKMK_processstage_msdyn_iotalert)
- [processstage_opportunity](#BKMK_processstage_opportunity)
- [processstage_productpricelevels](#BKMK_processstage_productpricelevels)
- [processstage_products](#BKMK_processstage_products)
- [processstage_quotes](#BKMK_processstage_quotes)
- [processstage_salesliteratures](#BKMK_processstage_salesliteratures)
- [processstage_salesorders](#BKMK_processstage_salesorders)

### <a name="BKMK_lk_leadtoopportunitysalesprocess_activestageid"></a> lk_leadtoopportunitysalesprocess_activestageid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_activestageid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`processstage_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_activestageid"></a> lk_msdyn_iottocaseprocess_activestageid

Many-To-One Relationship: [msdyn_iottocaseprocess lk_msdyn_iottocaseprocess_activestageid](msdyn_iottocaseprocess.md#BKMK_lk_msdyn_iottocaseprocess_activestageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`activestageid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_iottocaseprocess_activestageid`|
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

### <a name="BKMK_processstage_msdyn_iotalert"></a> processstage_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert processstage_msdyn_iotalert](msdyn_iotalert.md#BKMK_processstage_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_iotalert`|
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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.processstage?displayProperty=fullName>
