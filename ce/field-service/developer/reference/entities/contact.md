---
title: "Contact table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Contact table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Contact table/entity reference (Microsoft Dynamics 365 Field Service)

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Contact table extends the [Microsoft Dynamics 365 Contact table](/dynamics365/developer/reference/entities/contact).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with contact.**|
|DisplayName|**Segment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [contact_msdyn_bookingalerts](#BKMK_contact_msdyn_bookingalerts)
- [msdyn_contact_msdyn_actual_ContactCustomer](#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)
- [msdyn_contact_msdyn_actual_ContactVendor](#BKMK_msdyn_contact_msdyn_actual_ContactVendor)
- [msdyn_contact_msdyn_rma_RequestedByContact](#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)
- [msdyn_contact_msdyn_rtv_VendorContact](#BKMK_msdyn_contact_msdyn_rtv_VendorContact)
- [msdyn_contact_msdyn_workorder_ReportedByContact](#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)

### <a name="BKMK_contact_msdyn_bookingalerts"></a> contact_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert contact_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_contact_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactCustomer"></a> msdyn_contact_msdyn_actual_ContactCustomer

Many-To-One Relationship: [msdyn_actual msdyn_contact_msdyn_actual_ContactCustomer](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_contactcustomer`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_actual_ContactCustomer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactVendor"></a> msdyn_contact_msdyn_actual_ContactVendor

Many-To-One Relationship: [msdyn_actual msdyn_contact_msdyn_actual_ContactVendor](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_contactvendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_actual_ContactVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_rma_RequestedByContact"></a> msdyn_contact_msdyn_rma_RequestedByContact

Many-To-One Relationship: [msdyn_rma msdyn_contact_msdyn_rma_RequestedByContact](msdyn_rma.md#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_requestedbycontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_rma_RequestedByContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billing Account<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_rtv_VendorContact"></a> msdyn_contact_msdyn_rtv_VendorContact

Many-To-One Relationship: [msdyn_rtv msdyn_contact_msdyn_rtv_VendorContact](msdyn_rtv.md#BKMK_msdyn_contact_msdyn_rtv_VendorContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_vendorcontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_rtv_VendorContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Vendor Contact<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

Many-To-One Relationship: [msdyn_workorder msdyn_contact_msdyn_workorder_ReportedByContact](msdyn_workorder.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_reportedbycontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_workorder_ReportedByContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.contact?displayProperty=fullName>
