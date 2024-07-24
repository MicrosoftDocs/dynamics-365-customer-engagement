---
title: "Chatbot (bot) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Chatbot (bot) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Chatbot (bot) table/entity reference

Represents a Power Virtual Agents Chatbot. https://powerva.microsoft.com/

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Chatbot (bot) table extends the [Microsoft Dataverse Chatbot (bot) table](/power-apps/developer/data-platform/reference/entities/bot).


## Messages

The following table lists the messages for the Chatbot (bot) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_UpdateSurveyBotTopics`<br />Event: True |**msdyn_UpdateSurveyBotTopics action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_SupportedLanguages"></a> SupportedLanguages

Changes from [SupportedLanguages (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bot#BKMK_SupportedLanguages)

|Property|Value|
|---|---|
|DefaultFormValue||


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bot_msfp_survey_microsoftcopilotstudiobot](#BKMK_msdyn_bot_msfp_survey_microsoftcopilotstudiobot)
- [msdyn_msdyn_botsession_botid_bot](#BKMK_msdyn_msdyn_botsession_botid_bot)

### <a name="BKMK_msdyn_bot_msfp_survey_microsoftcopilotstudiobot"></a> msdyn_bot_msfp_survey_microsoftcopilotstudiobot

Many-To-One Relationship: [msfp_survey msdyn_bot_msfp_survey_microsoftcopilotstudiobot](msfp_survey.md#BKMK_msdyn_bot_msfp_survey_microsoftcopilotstudiobot)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_survey`|
|ReferencingAttribute|`msdyn_microsoftcopilotstudiobot`|
|ReferencedEntityNavigationPropertyName|`msdyn_bot_msfp_survey_microsoftcopilotstudiobot`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_botsession_botid_bot"></a> msdyn_msdyn_botsession_botid_bot

Many-To-One Relationship: [msdyn_botsession msdyn_msdyn_botsession_botid_bot](msdyn_botsession.md#BKMK_msdyn_msdyn_botsession_botid_bot)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_botsession`|
|ReferencingAttribute|`msdyn_botid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_botsession_botid_bot`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.bot?displayProperty=fullName>
