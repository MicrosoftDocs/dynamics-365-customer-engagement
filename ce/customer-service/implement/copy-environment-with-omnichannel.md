---
title: Copy environment with Omnichannel for Customer Service
description: Learn how to copy a Dynamics 365 Customer Service environment in which Omnichannel for Customer Service is provisioned.
author: neeranelli
ms.author: nenellim
ms.reviewer: 
ms.topic: how-to
ms.collection: 
ms.date: 03/26/2024
ms.custom: bap-template
---

# Copy environment with Omnichannel for Customer Service

Use the information in this article to learn how to copy a Dynamics 365 Customer Service environment in which Omnichannel for Customer Service is provisioned. The environment with Omnichannel for Customer Service integrates with several external services and channels like WhatsApp, Twilio, and Azure Communication Services. The endpoints and other parameters for these integrations are stored in Dataverse entities. These parameters are also copied when you copy the environment into another environment.

You can use the environment management operations like copy, which is a standard feature of model-driven apps. However, you'll need to perform specific steps to make sure that the copied environment in the target works correctly. For example, if you have digital messaging channels, you'll need to delete them and provision again.


## Prerequisites

The source and target environments must have the same configurations as follows:

- [Omnichannel for Customer Service is provisioned in both environments](omnichannel-provision-license.md).
- The source and target environments have the same set of channels enabled.
- [If unified routing is in use, make sure that it's turned on in both the source and target environments](../administer/provision-unified-routing.md).

## Copy the environment from source

Do the steps in [Copy an environment](/power-platform/admin/copy-environment) to choose one of the following options:

- Copy option&mdash;minimal copy. Schemas and customizations only are copied. The source data isn't copied to target. You can create the channels and workstreams and no corrections are needed.
- Copy option&mdash;full copy. A few corrections are needed in the target environment before you can start using it. More information: **Configure target environment after copying from source**

## Configure target environment after copying from source

After the copy environment process is complete, the target environment is accessible and the presence loads, perform the steps outlined in this section in the target environment.

> [!NOTE]
> The system can take up to one hour for updating the Omnichannel for Customer Service data in the target environment.

### Manage users

[Review and update the users, role mappings, and capacity profiles](../administer/users-user-profiles.md) in the target environment if required.

### Review queues

Review the queues and update the agent memberships for agent assignments to happen as required. More information:

- [Create and manage queues for cases](../administer/set-up-queues-manage-activities-cases.md)
- [Create and manage queues for unified routing](../administer/queues-omnichannel.md)
 
### Review live Chat channel

The Live Chat widget snippets are regenerated in the target environment to match the parameters in the target environment.

- If you want to configure your website or portal to send chats to the target environment, make sure that you copy the newly-generated scripts from the target environment and update your website code to use the new scripts.
- Review and make sure that the user features and chat settings are updated for the chat channel configuration in the target.
 

### Review and recreate channel configurations

For the channels that exist in your target environment, perform the steps as follows:

1. Delete the existing channel or page and dissociate the channel from the corresponding channel-specific workstream.
1. Configure the channel again and update the channel-specific workstream with the newly configured channel.

The following table lists the channels and the associated procedures to configure them.

| Channel                      | Action         |
|------------------------------|----------------|
| Voice                | [Configure a new voice channel](../administer/voice-channel-inbound-calling.md) |
| WhatsApp                     | [Configure a new WhatsApp channel](../administer/configure-whatsapp-channel.md).|
| Facebook                     | [Configure a new Facebook channel](../administer/configure-facebook-channel.md). <br> **Note:** Delete the existing channel only to remove it from the workstream. |
| LINE                         | [Configure a LINE channel](../administer/configure-line-channel.md)                 |
| Apple Messages for Business  | [Configure an Apple Messages for Business channel](../administer/configure-apple-business-messages-channel.md) |
| Google’s Business Messages   | [Configure a Google’s Business Messages channel](../administer/configure-google-business-messages-channel.md) |
| Microsoft Teams   | [Configure a Microsoft Teams channel](../administer/configure-microsoft-teams.md) |
| WeChat   | [Configure a WeChat channel](../administer/configure-wechat-channel.md) |
| Custom channels   | [Configure a custom channel](../develop/bring-your-own-channel.md) |
| SMS using Azure Communication Services   | [Configure an SMS channel using Azure Communication Services](../administer/configure-sms-channel-acs.md) |
| SMS for TeleSign   | [Configure an SMS channel for TeleSign](../administer/configure-sms-channel.md) |
| SMS for Twilio   | [Configure an SMS channel for Twilio](../administer/configure-sms-channel-twilio.md) |


### Review Copilot Studio bots

1.	Delete the Copilot Studio bots from all existing workstreams and the environment.
2.	[Create a bot](../administer/manage-your-bots.md#add-a-bot) or connect a previously configured bot specific to the target environment and configure with channel workstreams.
3.	Make sure that you update the existing workstreams to use the new bot.

> [!NOTE]
> If you want to continue to use the same Copilot Studio bot in the new target environment, reconnect the Copilot Studio bot in the new environment and then follow [these](/microsoft-copilot-studio/configuration-hand-off-omnichannel?tabs=webApp#manage-your-copilots-omnichannel-capabilities) steps to disconnect and reconnect Omnichannel for Customer Service. If you reconnect the Copilot with another environment will break the source environment.

### Azure Bots

[Configure the Bot user in the Omnichannel for Customer Service environment](../administer/configure-bot-azure.md#integrate-azure-bots-with-omnichannel-for-customer-service).
 
### Review real-time analytics

To make sure that [real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md) have the updated information for the target environment, on the real-time analytics page in Customer Service admin center, turn off the **Enable Omnichannel real-time analytics** toggle and turn it back on.


### Review historical analytics

To make sure that [historical analytics reports](../administer/oc-historical-analytics-reports.md) have the updated information for the target environment, on the historical analytics page in Customer Service admin center, turn off the **Enable Omnichannel historical analytics report** toggle and turn it back on.


### See also

[Export and import app configuration data](export-import-omnichannel-data.md)  

