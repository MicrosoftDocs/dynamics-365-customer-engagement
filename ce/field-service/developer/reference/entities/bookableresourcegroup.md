---
title: "Bookable Resource Group (BookableResourceGroup) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Group (BookableResourceGroup) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Group (BookableResourceGroup) table/entity reference (Microsoft Dynamics 365 Field Service)

Associates resources with resource groups that they are a member of.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource Group (BookableResourceGroup) table extends the [Microsoft Dynamics 365 Bookable Resource Group (BookableResourceGroup) table](/dynamics365/developer/reference/entities/bookableresourcegroup).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_CrewMemberType](#BKMK_msdyn_CrewMemberType)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)

### <a name="BKMK_msdyn_CrewMemberType"></a> msdyn_CrewMemberType

|Property|Value|
|---|---|
|Description|**Indicates whether crew member is a leader or member.**|
|DisplayName|**Crew Member Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crewmembertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_crewmembertype`|

#### msdyn_CrewMemberType Choices/Options

|Value|Label|
|---|---|
|192350000|**Leader**|
|192350001|**Member**|
|192350002|**None**|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

