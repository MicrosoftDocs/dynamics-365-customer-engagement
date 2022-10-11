---
title: "Voicemail to manage call overflow of voice calls | MicrosoftDocs"
description: "Learn how to configure call overflow for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/15/2022
ms.topic: article

---

# Configure voicemail to manage overflow of voice calls (preview)

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

When an incoming call reaches the voice queue and the queue is in one of the following conditions, you can redirect the caller to leave a voicemail for the agent.

- Exceeds a defined number of calls that are waiting in the queue
- Is received during the after hours of the call center operations
- Exceeds the estimated wait time

For information on how to configure the conditions and actions, see [Manage overflow of work items in queues](manage-overflow.md).

You can also configure overflow override in the route-to-queue rule of a workstream.

The salient features of voicemail are as follows:

- Voicemails can be recorded for up to five minutes only.
- If you don't want to use the out-of-the-box prompt for the voicemail, you can customize it in the automated message or workstream settings.
- Voicemails will always be transcribed irrespective of whether you have enabled the voice call transcription.
- Supervisors can view the voicemails on the **Omnichannel Ongoing Conversations Dashboard**.

## Configure voicemail views in Inbox for agents

1. In Customer Service admin center, in the sitemap, select **Workspaces** under **Agent experience**.

1. Select **Manage** for **Agent experience profiles**, and select the profile that you want to edit.

1. Edit the Inbox, and enable it.

1. Select **Add**.

1. On the **Add a new view** dialog, enter the following details:

     - **Name**: Name for the view.
     - **Agent visibility**: Select Show.
     - **Record type**: Select **Voicemail**.

1. In the **Settings** dropdown list, select one or all of the following:
     - Assigned
     - Unassigned
     - Resolved

### See also

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
