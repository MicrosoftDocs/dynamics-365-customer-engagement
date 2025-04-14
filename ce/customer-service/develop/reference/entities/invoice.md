---
title: "Invoice table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Invoice table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Invoice table/entity reference (Microsoft Dynamics 365 Customer Service)

Order that has been billed.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Invoice table extends the [Microsoft Dynamics 365 Invoice table](/dynamics365/developer/reference/entities/invoice).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [invoice_msdyn_bookingalerts](#BKMK_invoice_msdyn_bookingalerts)
- [msdyn_invoice_msdyn_actual_Invoice](#BKMK_msdyn_invoice_msdyn_actual_Invoice)

### <a name="BKMK_invoice_msdyn_bookingalerts"></a> invoice_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert invoice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_invoice_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_invoice_msdyn_actual_Invoice"></a> msdyn_invoice_msdyn_actual_Invoice

Many-To-One Relationship: [msdyn_actual msdyn_invoice_msdyn_actual_Invoice](msdyn_actual.md#BKMK_msdyn_invoice_msdyn_actual_Invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencedEntityNavigationPropertyName|`msdyn_invoice_msdyn_actual_Invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

