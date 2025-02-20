---
title: "Bookable Resource Category (BookableResourceCategory) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Category (BookableResourceCategory) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Category (BookableResourceCategory) table/entity reference (Microsoft Dynamics 365 Field Service)

Categorize resources that have capacity into categories such as roles.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource Category (BookableResourceCategory) table extends the [Microsoft Dynamics 365 Bookable Resource Category (BookableResourceCategory) table](/dynamics365/developer/reference/entities/bookableresourcecategory).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory"></a> msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory

Many-To-One Relationship: [msdyn_requirementresourcecategory msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory](msdyn_requirementresourcecategory.md#BKMK_msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`msdyn_resourcecategory`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

