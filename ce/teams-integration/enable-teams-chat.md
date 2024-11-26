---
title: "Enable or disable Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Enable Teams chat to help users effectively collaborate on their Dynamics 365 customer engagement records without having to leave the application."
ms.date: 11/26/2024
ms.topic: article
author: sbmjais
ms.author: shjais
---

# Work with Microsoft Teams chat in Dynamics 365

You can configure the ability for sellers and agents to chat in Microsoft Teams from within the customer engagement apps such as Sales Hub, Customer Service Hub, and custom apps. This helps in effective collaboration on the sales records without having to leave the application. 

When Teams chat is enabled in Dynamics 365, you can also enable Teams chat sync to create a record in Dynamics 365 for each chat that is created in Teams.

## Enable or disable Microsoft Teams chat in Dynamics 365

You can configure the ability for sellers and agents to chat in Microsoft Teams from within the customer engagement apps such as Sales Hub, Customer Service Hub, and custom apps. This helps in effective collaboration on the sales records without having to leave the application.

When the feature is enabled, while working on Dynamics 365 records, sellers or agents can start a new chat or connect an existing chat to a record, and thus collaborate efficiently without switching context or leaving the application. Connecting all the associated chats to a record helps in maintaining all the chats related to the record in one place. You can also configure an optional introduction message that can be used to provide further context when collaborating on Teams.

For app specific information about the feature, select the appropriate link below:

- Dynamics 365 Sales: [Enable or disable Microsoft Teams chat in Sales Hub](../sales/teams-integration/enable-teams-chat.md)
- Dynamics 365 Customer Service: [Configure Microsoft Teams chat in Customer Service](../customer-service/configure-teams-chat.md)
- Dynamics 365 Marketing: [Collaborate using built-in Microsoft Teams chat](../marketing/teams-chat.md)
- Dynamics 365 Field Service: [Collaborate on work orders with Microsoft Teams](../field-service/field-service-teams-collaboration.md)

## Preview: Configure Microsoft Teams chat sync

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

Teams chat sync enhances the Teams chat integration capability in Dynamics 365. When you enable it, sellers and agents can easily find Teams chats that are related to a Dynamics 365 record. Related Teams chats appear in the [timeline control](/power-apps/maker/model-driven-apps/set-up-timeline-control) and activities grids, just like other activities, such as emails, meetings, and phone calls.

When Teams chat sync is enabled:

- New connected Teams chats are created as Teams chat activity records in Dynamics 365.
- Teams chat activity records appear in the timeline.
- Changes to a chat in Teams are synced to the corresponding Teams chat activity record in Dynamics 365. For details about what data is synced, go to [Synchronization of chat data from Teams to Dynamics 365](#synchronization-of-chat-data-from-teams-to-dynamics-365).
- When you connect a Teams chat to a Dynamics 365 record, a Teams app named Dataverse Chat Sync is installed in the chat. This app enables Dataverse to be notified when the chat is updated.

> [!NOTE]
> - You can enable Teams chat sync only if Teams chat in Dynamics 365 is enabled.
> - Activity entities, including the Teams Chat activity, can't currently be associated with other activity entities. For example, a Teams Chat activity row can't be associated with (regarding) another activity row, such as a task or meeting activity. You can still create linked chats that are associated with activity entities such as emails, meetings, or tasks. However, those linked chats won't be created as activity records that appear in the timeline.

### Enable Teams chat sync

You must be a global administrator (tenant administrator) to enable Teams chat sync.

1. In the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), select an environment.
2. On the command bar, select **Settings** \> **Integration** \> **Teams integration settings**.
3. On the **Microsoft Teams collaboration and chat** page, turn on **Sync Teams chat data with Dynamics 365 records**.

### Synchronization of chat data from Teams to Dynamics 365

The following table lists the data that is synced from Teams chats to the corresponding Teams chat activity rows (records) in Dynamics 365.

| Teams chat | Teams chat activity in Dynamics 365 |
|------------|-------------------------------------|
| The topic (subject) of the chat | The `subject` attribute in the Teams chat activity row |
| The person who last updated the chat in Teams | The `modifiedinteamsby` attribute in the Teams chat activity row |
| The date and time when the chat was last updated by a user in Teams | The `modifiedinteamson` attribute in the Teams chat activity row |
| Members of the chat | In the [ActivityParty](/power-apps/developer/data-platform/activityparty-entity) table, each user in the chat has a reference that has a party type value of *12* (*Chat Participant*). |
| The unique identifier (ID) of the chat in Teams | The `teamschatid` attribute in the Teams chat activity row |

Additional data, such as chat message text and shared files, isn't synced from Teams to Dynamics 365.

### When changes aren't synced

A connected Teams chat won't sync changes if any of these conditions are true:

- The Teams chat was connected to a Dynamics 365 record before Teams chat sync was enabled. Only newly connected chats sync changes.
- The Teams chat activity record is no longer active. Like other activity records, Teams chat activities can be marked as completed, which means they are no longer in an active state. Only chat activities that are in an active state sync changes.
- The Teams chat hasn't been updated for seven days. If a chat hasn't been updated for seven days, Dataverse will no longer receive notifications when the chat is updated. This limit might change in the future.
