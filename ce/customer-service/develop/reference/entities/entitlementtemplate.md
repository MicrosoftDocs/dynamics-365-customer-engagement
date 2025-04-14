---
title: "Entitlement Template (EntitlementTemplate) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Entitlement Template (EntitlementTemplate) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Entitlement Template (EntitlementTemplate) table/entity reference (Microsoft Dynamics 365 Customer Service)

Contains predefined customer support terms that can be used to created entitlements for customers.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Entitlement Template (EntitlementTemplate) table extends the [Microsoft Dynamics 365 Entitlement Template (EntitlementTemplate) table](/dynamics365/developer/reference/entities/entitlementtemplate).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_entitlementtemplate_msdyn_bookingalerts"></a> entitlementtemplate_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert entitlementtemplate_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlementtemplate_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

