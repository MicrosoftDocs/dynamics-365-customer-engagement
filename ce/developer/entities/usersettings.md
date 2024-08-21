---
title: "User Settings (UserSettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the User Settings (UserSettings) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# User Settings (UserSettings) table/entity reference

User's preferred settings.

> [!NOTE]
> The Microsoft Dynamics 365 User Settings (UserSettings) table extends the [Microsoft Dataverse User Settings (UserSettings) table](/power-apps/developer/data-platform/reference/entities/usersettings).


## Messages

The following table lists the messages for the User Settings (UserSettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_user_settings_preferred_solution"></a> user_settings_preferred_solution

Changes from [user_settings_preferred_solution (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/usersettings#BKMK_user_settings_preferred_solution)

|Property|Value|
|---|---|
|CascadeConfiguration|Archive: `RemoveLink`|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.usersettings?displayProperty=fullName>
