---
title: "Organization table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Organization table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Organization table/entity reference (Microsoft Dynamics 365 Customer Service)

Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Organization table extends the [Microsoft Dynamics 365 Organization table](/dynamics365/developer/reference/entities/organization).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_SchedulingEngine"></a> SchedulingEngine

Changes from [SchedulingEngine (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/organization#BKMK_SchedulingEngine)

#### SchedulingEngine Choices/Options

|Value|Label|
|---|---|
|192350000|**(Deprecated) Universal Resource Scheduling**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [organization_msdyn_organizationalunit](#BKMK_organization_msdyn_organizationalunit)
- [organization_msdyn_schedulingparameter](#BKMK_organization_msdyn_schedulingparameter)

### <a name="BKMK_organization_msdyn_organizationalunit"></a> organization_msdyn_organizationalunit

Many-To-One Relationship: [msdyn_organizationalunit organization_msdyn_organizationalunit](msdyn_organizationalunit.md#BKMK_organization_msdyn_organizationalunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_organizationalunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_schedulingparameter"></a> organization_msdyn_schedulingparameter

Many-To-One Relationship: [msdyn_schedulingparameter organization_msdyn_schedulingparameter](msdyn_schedulingparameter.md#BKMK_organization_msdyn_schedulingparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_schedulingparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.organization?displayProperty=fullName>
