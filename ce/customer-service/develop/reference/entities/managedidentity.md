---
title: "Managed Identity (ManagedIdentity) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Managed Identity (ManagedIdentity) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Managed Identity (ManagedIdentity) table/entity reference (Microsoft Dynamics 365 Customer Service)

Contains data to represent an Azure Active Directory Application used to connect to secure web-hosted resources.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Managed Identity (ManagedIdentity) table extends the [Microsoft Dynamics 365 Managed Identity (ManagedIdentity) table](/dynamics365/developer/reference/entities/managedidentity).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_IdentityType"></a> IdentityType

Changes from [IdentityType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/managedidentity#BKMK_IdentityType)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_managedidentity_msdyn_occustommessagingchannel_managedidentityid"></a> managedidentity_msdyn_occustommessagingchannel_managedidentityid

Many-To-One Relationship: [msdyn_occustommessagingchannel managedidentity_msdyn_occustommessagingchannel_managedidentityid](msdyn_occustommessagingchannel.md#BKMK_managedidentity_msdyn_occustommessagingchannel_managedidentityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`managedidentityid`|
|ReferencedEntityNavigationPropertyName|`managedidentity_msdyn_occustommessagingchannel_managedidentityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.managedidentity?displayProperty=fullName>
