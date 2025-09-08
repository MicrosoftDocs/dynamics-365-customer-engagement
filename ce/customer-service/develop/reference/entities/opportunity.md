---
title: "Opportunity table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Opportunity table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Opportunity table/entity reference (Microsoft Dynamics 365 Customer Service)

Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Opportunity table extends the [Microsoft Dynamics 365 Opportunity table](/dynamics365/developer/reference/entities/opportunity).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [opportunity_msdyn_bookingalerts](#BKMK_opportunity_msdyn_bookingalerts)
- [opportunity_msdyn_ocoutboundmessages](#BKMK_opportunity_msdyn_ocoutboundmessages)
- [opportunity_msdyn_ocvoicemails](#BKMK_opportunity_msdyn_ocvoicemails)

### <a name="BKMK_opportunity_msdyn_bookingalerts"></a> opportunity_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert opportunity_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_opportunity_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msdyn_ocoutboundmessages"></a> opportunity_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage opportunity_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_opportunity_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msdyn_ocvoicemails"></a> opportunity_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail opportunity_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_opportunity_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

