---
title: Copy an environment with omnichannel capabilities
description: Follow these steps to create a copy of a Dynamics 365 environment that includes omnichannel capabilities.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: 
ms.date: 09/09/2026
ms.custom: bap-template
ai.usage: ai-assisted
---

# Copy an environment with omnichannel capabilities

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

Omnichannel capabilities in Dynamics 365 Contact Center and Dynamics 365 Customer Service let you integrate external services and channels such as WhatsApp, Twilio, and Azure Communication Services. The integration parameters are stored in Dataverse tables. To create a copy of an environment that contains omnichannel capabilities, use the standard copy feature of model-driven apps. The integration parameters are copied to the new environment. However, you need to perform some extra steps to ensure that the copied environment works correctly.

## Copy the environment from the source

[Copy an environment](/power-platform/admin/copy-environment) and choose one of the following copy options:

- **Minimal copy**. Schemas and customizations only are copied. The source data isn't copied. [Turn off the channels](/dynamics365/contact-center/implement/provision-channels#turn-off-channels) and turn them back on. You can then create the channels and workstreams in the target environment, and no corrections are needed.
- **Full copy**. Everything in the source is copied. Review and update the target environment before you start using it.

## Configure the target environment after the copy

When the copy is complete, channels enabled in the source environment are provisioned in the target environment. Configuration such as workstreams, queues, security roles, queue memberships, and capacity-related settings are copied with the environment. Review this configuration before you enable the target environment for production use.

- Review users, security role assignments, queue memberships, and capacity profiles in the target environment.
- Confirm that copied workstreams and queues contain the correct target-environment configuration.
- Update each channel that uses an environment-specific resource, account, phone number, agent, or website integration.
- Test routing and conversation handling in the target environment before you make it available to users.

> [!NOTE]
> Copy operation of record-routing configuration isn't currently supported. Configure and validate record routing or unified routing separately in the target environment.

### Voice channel with Azure Communication Services

If the source environment has a voice channel, the target environment is provisioned for voice. However, Azure Communication Services resources and phone numbers are specific to an environment. Connect the target environment to its own Azure Communication Services resource, assign a phone number, and associate the number with the appropriate workstream.

> [!IMPORTANT]
> When you copy an environment with a configured voice channel, the Azure Communication Services resource is also copied. You can use one resource in one environment only. Therefore, disconnect the Azure Communication Services resource in the target environment. Otherwise, it can cause issues with the voice channel setup in both the source and target environments.

### Voice channel with Teams Phone

For a voice channel that uses Teams Phone, configure a target-specific Teams phone number and the required integration identifiers. Then associate the newly configured number with the copied workstream and test inbound calling.

### Chat channel

A new chat widget configuration is generated for the target environment. Replace the source-environment widget snippet on your website or portal with the snippet generated in the target environment. Review the chat settings and test the widget before you use it.

### Microsoft Teams channel

The copied messaging account can continue to reference the agent or application from the source environment. To prevent cross-environment dependencies, recreate the Microsoft Teams channel configuration in the target environment.

1. Delete or disconnect the copied messaging account in the target environment.
1. Create a messaging account and channel configuration for the target environment.
1. Associate the new channel configuration with the copied workstream.
1. Configure the target-environment agent for the Microsoft Teams channel, including the required app features, scopes, and authentication settings.
1. Add the agent to Microsoft Teams and verify that conversations are routed correctly.

For configuration instructions, see [Configure a Microsoft Teams channel](../administer/configure-microsoft-teams.md).

### Channel resources

- [Configure a new voice channel](../administer/voice-channel-inbound-calling.md)
- [Disconnect from Azure Communication Services resources](../administer/voice-channel-disconnect-from-acs.md)
- [Connect to a different Azure Communication Services resource](../administer/voice-channel-acs-resource.md)
- [Configure a new WhatsApp channel](../administer/configure-whatsapp-channel.md)
- [Configure a new Facebook channel](../administer/configure-facebook-channel.md)
- [Configure a LINE channel](../administer/configure-line-channel.md)
- [Configure an Apple Messages for Business channel](../administer/configure-apple-messages-for-business-channel.md)
- [Configure a Microsoft Teams channel](../administer/configure-microsoft-teams.md)
- [Configure a custom channel](../develop/bring-your-own-channel.md)
- [Configure an SMS channel using Azure Communication Services](../administer/configure-sms-channel-acs.md)
- [Configure an SMS channel for Twilio](../administer/configure-sms-channel-twilio.md)

## Configure Copilot agents in the target environment

Agent configuration is copied to the target environment, and a target-environment agent can be provisioned with the copied capabilities. Review the agent, connections, authentication, and workstream associations in the target environment before you use it.

1. Open the copied agent in the target environment and confirm that its capabilities and connections are valid.
1. Update any connection, authentication, or environment-specific setting that still references the source environment.
1. Confirm that each workstream is associated with the intended target-environment agent.
1. Publish the agent and test escalation and routing scenarios.

To create or add a different agent, see [Add an agent](../administer/manage-your-bots.md#add-an-agent), and then update the relevant workstreams.

## Configure real-time and historical analytics

1. To make sure that [real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md) reflect information in the target environment, on the real-time analytics page in the Copilot Service admin center, turn off **Enable Omnichannel real-time analytics**, and then turn it back on.

1. To make sure that [historical analytics reports](../administer/oc-historical-analytics-reports.md) reflect information in the target environment, on the historical analytics page in the Copilot Service admin center, turn off **Enable Omnichannel historical analytics report**, and then turn it back on.

## Related information

[Export and import app configuration data](export-import-omnichannel-data.md)  
