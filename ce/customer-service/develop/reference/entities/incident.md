---
title: "Case (Incident) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Case (Incident) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Case (Incident) table/entity reference

Service request case associated with a contract.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Case (Incident) table extends the [Microsoft Dynamics 365 Case (Incident) table](/dynamics365/developer/entities//incident).


## Messages

The following table lists the messages for the Case (Incident) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_GetCaseSuggestions`<br />Event: True |**msdyn_GetCaseSuggestions action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

Changes from [ExchangeRate (Microsoft Dynamics 365)](/dynamics365/developer/entities//incident#BKMK_ExchangeRate)

|Property|Value|
|---|---|
|MinValue|1E-12|
|Precision|12|


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


## Customized relationships

### Customized One-to-Many relationships

#### <a name="BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid"></a> msdyn_incident_msdyn_originatingqueue_createdincidentid

Changes from [msdyn_incident_msdyn_originatingqueue_createdincidentid (Microsoft Dynamics 365)](/dynamics365/developer/entities//incident#BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid)

|Property|Value|
|---|---|
|AssociatedMenuConfiguration|Label: ``|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

