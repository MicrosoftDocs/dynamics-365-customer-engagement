---
title: "Custom API Request Parameter (CustomAPIRequestParameter) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Custom API Request Parameter (CustomAPIRequestParameter) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Custom API Request Parameter (CustomAPIRequestParameter) table/entity reference

Entity that defines a request parameter for a custom API

> [!NOTE]
> The Microsoft Dynamics 365 Custom API Request Parameter (CustomAPIRequestParameter) table extends the [Microsoft Dataverse Custom API Request Parameter (CustomAPIRequestParameter) table](/power-apps/developer/data-platform/reference/entities/customapirequestparameter).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [IsOptional](#BKMK_IsOptional)
- [LogicalEntityName](#BKMK_LogicalEntityName)
- [Type](#BKMK_Type)

### <a name="BKMK_IsOptional"></a> IsOptional

Changes from [IsOptional (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/customapirequestparameter#BKMK_IsOptional)

|Property|Value|
|---|---|
|IsValidForUpdate|False|


### <a name="BKMK_LogicalEntityName"></a> LogicalEntityName

Changes from [LogicalEntityName (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/customapirequestparameter#BKMK_LogicalEntityName)

|Property|Value|
|---|---|
|IsValidForUpdate|False|


### <a name="BKMK_Type"></a> Type

Changes from [Type (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/customapirequestparameter#BKMK_Type)

|Property|Value|
|---|---|
|IsValidForUpdate|False|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter](#BKMK_msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter)
- [msdynmkt_customapirequestparameter_eventparameter](#BKMK_msdynmkt_customapirequestparameter_eventparameter)

### <a name="BKMK_msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter"></a> msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter

Many-To-One Relationship: [msdyn_customapirulesetconfiguration msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter](msdyn_customapirulesetconfiguration.md#BKMK_msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`msdyn_customapirequestparameter`|
|ReferencedEntityNavigationPropertyName|`msdyn_customapirequestparameter_msdyn_customapirulesetconfiguration_CustomAPIRequestParameter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_customapirequestparameter_eventparameter"></a> msdynmkt_customapirequestparameter_eventparameter

Many-To-One Relationship: [msdynmkt_eventparametermetadata msdynmkt_customapirequestparameter_eventparameter](msdynmkt_eventparametermetadata.md#BKMK_msdynmkt_customapirequestparameter_eventparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventparametermetadata`|
|ReferencingAttribute|`msdynmkt_customapirequestparameterid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_customapirequestparameter_eventparameter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.customapirequestparameter?displayProperty=fullName>
