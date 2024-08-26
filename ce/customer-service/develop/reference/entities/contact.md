---
title: "Contact table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Contact table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Contact table/entity reference (Microsoft Dynamics 365 Customer Service)

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Contact table extends the [Microsoft Dynamics 365 Contact table](/dynamics365/developer/entities/contact).


## Messages

The following table lists the messages for the Contact table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `adx_SendEmailConfirmationToContact`<br />Event: True |<xref:Microsoft.Dynamics.CRM.adx_SendEmailConfirmationToContact?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `adx_SendEmailTwoFactorCodeToContact`<br />Event: True |<xref:Microsoft.Dynamics.CRM.adx_SendEmailTwoFactorCodeToContact?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `adx_SendPasswordResetToContact`<br />Event: True |<xref:Microsoft.Dynamics.CRM.adx_SendPasswordResetToContact?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msdyn_GDPROptoutContact`<br />Event: True |**msdyn_GDPROptoutContact action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [contact_msdyn_bookingalerts](#BKMK_contact_msdyn_bookingalerts)
- [msdyn_contact_msdyn_actual_ContactCustomer](#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)
- [msdyn_contact_msdyn_actual_ContactVendor](#BKMK_msdyn_contact_msdyn_actual_ContactVendor)

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



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.contact?displayProperty=fullName>
