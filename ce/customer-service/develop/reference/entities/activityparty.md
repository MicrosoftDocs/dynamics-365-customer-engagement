---
title: "Activity Party (ActivityParty) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Activity Party (ActivityParty) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Activity Party (ActivityParty) table/entity reference (Microsoft Dynamics 365 Customer Service)

Person or group associated with an activity. An activity can have multiple activity parties.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Activity Party (ActivityParty) table extends the [Microsoft Dynamics 365 Activity Party (ActivityParty) table](/dynamics365/developer/reference/entities/activityparty).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_bookingalert_activity_parties"></a> msdyn_bookingalert_activity_parties

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_activity_parties](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_bookingalert_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activityparty?displayProperty=fullName>
