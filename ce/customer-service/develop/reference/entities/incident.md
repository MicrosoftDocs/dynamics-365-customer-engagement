---
title: "Case (Incident) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Case (Incident) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Case (Incident) table/entity reference (Microsoft Dynamics 365 Customer Service)

Service request case associated with a contract.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Case (Incident) table extends the [Microsoft Dynamics 365 Case (Incident) table](/dynamics365/developer/reference/entities/incident).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_incident_msdyn_bookingalerts"></a> incident_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert incident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_incident_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

