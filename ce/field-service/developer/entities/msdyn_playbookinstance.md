---
title: "Playbook (msdyn_playbookinstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Playbook (msdyn_playbookinstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Playbook (msdyn_playbookinstance) table/entity reference

Actual instance of a playbook template once it is launched.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Playbook (msdyn_playbookinstance) table extends the [Microsoft Dynamics 365 Playbook (msdyn_playbookinstance) table](/dynamics365/developer/entities/msdyn_playbookinstance).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_playbookcategory_msdyn_playbookinstance](#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)
- [msdyn_playbooktemplate_msdyn_playbookinstance](#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)

### <a name="BKMK_msdyn_playbookcategory_msdyn_playbookinstance"></a> msdyn_playbookcategory_msdyn_playbookinstance

One-To-Many Relationship: [msdyn_playbookcategory msdyn_playbookcategory_msdyn_playbookinstance](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookcategory`|
|ReferencedAttribute|`msdyn_playbookcategoryid`|
|ReferencingAttribute|`msdyn_categoryid`|
|ReferencingEntityNavigationPropertyName|`msdyn_categoryid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_playbooktemplate_msdyn_playbookinstance"></a> msdyn_playbooktemplate_msdyn_playbookinstance

One-To-Many Relationship: [msdyn_playbooktemplate msdyn_playbooktemplate_msdyn_playbookinstance](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbooktemplate`|
|ReferencedAttribute|`msdyn_playbooktemplateid`|
|ReferencingAttribute|`msdyn_playbooktemplateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_playbooktemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_playbookinstance_msdyn_bookingalerts"></a> msdyn_playbookinstance_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_playbookinstance_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

