---
title: "Email thread (msdyn_emailthread) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Email thread (msdyn_emailthread) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Email thread (msdyn_emailthread) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Email thread (msdyn_emailthread) table extends the [Microsoft Dynamics 365 Email thread (msdyn_emailthread) table](/dynamics365/developer/reference/entities/msdyn_emailthread).


## Messages

The following table lists the messages for the Email thread (msdyn_emailthread) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_emailthread_msdyn_bookingalerts](#BKMK_msdyn_emailthread_msdyn_bookingalerts)
- [msdyn_emailthread_msdyn_ocoutboundmessages](#BKMK_msdyn_emailthread_msdyn_ocoutboundmessages)
- [msdyn_emailthread_msdyn_ocvoicemails](#BKMK_msdyn_emailthread_msdyn_ocvoicemails)

### <a name="BKMK_msdyn_emailthread_msdyn_bookingalerts"></a> msdyn_emailthread_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_emailthread_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_emailthread_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailthread_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailthread_msdyn_ocoutboundmessages"></a> msdyn_emailthread_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_emailthread_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyn_emailthread_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailthread_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailthread_msdyn_ocvoicemails"></a> msdyn_emailthread_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_emailthread_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyn_emailthread_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailthread_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

