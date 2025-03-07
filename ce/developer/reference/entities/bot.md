---
title: "Copilot (bot) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Copilot (bot) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Copilot (bot) table/entity reference (Microsoft Dynamics 365)

Represents a copilot created in Copilot Studio. https://copilotstudio.microsoft.com/

> [!NOTE]
> The Microsoft Dynamics 365 Copilot (bot) table extends the [Microsoft Dataverse Copilot (bot) table](/power-apps/developer/data-platform/reference/entities/bot).


## Messages

The following table lists the messages for the Copilot (bot) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_UpdateSurveyBotTopics`<br />Event: True |**msdyn_UpdateSurveyBotTopics action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bot_msdyn_microsoftcopilotstudiobot](#BKMK_bot_msdyn_microsoftcopilotstudiobot)
- [msdyn_bot_msfp_survey_microsoftcopilotstudiobot](#BKMK_msdyn_bot_msfp_survey_microsoftcopilotstudiobot)
- [msdyn_msdyn_botsession_botid_bot](#BKMK_msdyn_msdyn_botsession_botid_bot)

### <a name="BKMK_bot_msdyn_microsoftcopilotstudiobot"></a> bot_msdyn_microsoftcopilotstudiobot

Many-To-One Relationship: [msdyn_customerfeedbacksurvey bot_msdyn_microsoftcopilotstudiobot](msdyn_customerfeedbacksurvey.md#BKMK_bot_msdyn_microsoftcopilotstudiobot)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurvey`|
|ReferencingAttribute|`msdyn_microsoftcopilotstudiobot`|
|ReferencedEntityNavigationPropertyName|`bot_msdyn_microsoftcopilotstudiobot`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.bot?displayProperty=fullName>
