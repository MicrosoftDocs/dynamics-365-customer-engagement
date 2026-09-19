---
title: "User Settings (UserSettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the User Settings (UserSettings) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# User Settings (UserSettings) table/entity reference (Microsoft Dynamics 365)

User's preferred settings.

> [!NOTE]
> The Microsoft Dynamics 365 User Settings (UserSettings) table extends the [Microsoft Dataverse User Settings (UserSettings) table](/power-apps/developer/data-platform/reference/entities/usersettings).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_DisplayDensity"></a> DisplayDensity

|Property|Value|
|---|---|
|Description|**Control how compact or spacious the interface feels. This affects spacing, padding, and font sizes across the application.**|
|DisplayName|**Display Density**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`displaydensity`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`usersettings_displaydensity`|

#### DisplayDensity Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**Comfortable**|
|2|**Cozy**|
|3|**Compact**|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.usersettings?displayProperty=fullName>
