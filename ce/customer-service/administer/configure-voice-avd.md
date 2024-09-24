---
title: Use Azure Virtual Desktop to access voice channel
description: Learn how to configure the Microsoft Remote Desktop client in your agents remote desktop to enable agents to connect to the voice channel using Azure Virtual Desktop.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 08/26/2024
ms.custom: bap-template 
---

# Use Azure Virtual Desktop to access voice channel

You can configure the Microsoft Remote Desktop client in your agents' remote desktops. This enables agents to connect to the voice channel using the Azure Virtual Desktop. 

## Prerequisites

- [Connect to Azure Virtual Desktop with the Remote Desktop client for Windows](/azure/virtual-desktop/users/connect-windows?pivots=remote-desktop-msi#download-and-install-the-remote-desktop-client-msi) to ensure that agents have Azure Virtual Desktop installed on their remote desktop.
- Ensure that [Insider release](/azure/virtual-desktop/users/client-features-windows?pivots=remote-desktop-msi#enable-insider-releases) is enabled for the remote desktop client.
- [Install the multimedia redirection extension](/azure/virtual-desktop/multimedia-redirection) on the agents' browsers. Supported browsers are Microsoft Edge and Google Chrome.

### Access remote desktop

Ensure agents perform the following steps to access the voice channel from the remote desktop, once it is installed:

1. Restart the remote desktop client and the agent's device.
1. Ensure that agents see **Remote Desktop(Insider)** is displayed on the remote desktop client.
1. Select the **ellipsis** (…) and then select **Subscribe**. 
1. Agents will see **SessionDesktop** once they are subscribed. Agents will then be able to sign in the Azure Virtual Desktop to use the voice channel.

## Agent experience when local machine disconnects from the Azure Virtual Desktop instance

Agents can communicate with customers on the phone to resolve issues using the voice channel through the Azure Virtual Desktop. The following table describes the scenarios in which the local machine disconnects from the Azure Virtual Desktop instance.

| **Scenario**                                                                 | **Notifications**                                  | **Ongoing Phone Call**                                                                                                      | **Ongoing Non-Phone Call**                                                                                                 | **Active Consult (Primary Agent Disconnected)**                                                                               | **Active Consult (Secondary Agent Disconnected)**                                                                          | **Transfer**                                                                                      |
|------------------------------------------------------------------------------|---------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------|
| Agent is disconnected from the Azure Virtual Desktop.                        | Notifications aren't delivered to agent.          | The ongoing call remains assigned to the agent. The customer hears a message that the agent is disconnected and will rejoin the call shortly, followed by wait music. | Non-voice conversations remain assigned to the agent. If the agent is in a chat that is converted to a voice or video call, the voice or video call ends. | The secondary agent hears a message that the primary agent is disconnected.                                                   | The call ends for the secondary agent.                                                                                       | N/A                                                                                                     |
| Agent reconnects to the Azure Virtual Desktop instance in less than 30 seconds. | Incoming notifications are displayed to the agent. | Agent is reconnected to the call. The call status, such as hold or mute, remains unchanged.                                  | The agent rejoins the conversation.                                                                                         | Primary agent rejoins the call. The call status remains unchanged.                                                           | The call ends for the secondary agent.                                                                                       | Call is transferred. The agent is connected to the call if the transfer fails.                                                |
| Agent takes more than 30 seconds but less than 2.5 minutes to reconnect.     | Incoming notifications are displayed to the agent. | The call is rerouted.                                                                                                        | Agent rejoins the conversation.                                                                                            | Call gets rerouted to a different agent and the consult ends. The customer remains on hold.                                  | Call ends for the secondary agent.                                                                                           | Call is rerouted if the transfer fails.                                                                                       |
| Agent takes more than 2.5 minutes to reconnect.                              | Incoming notifications are displayed when the agent reconnects. | Call is rerouted.                                                                                                            | Conversation is rerouted.                                                                                                   | N/A                                                                                                                          | Consult ends for the secondary agent.                                                                                       | Call is rerouted.                                                                                                             |

## Best practices

- Ensure that the agents using the Azure Virtual Desktop have the latest version of the multimedia redirection extension installed on their browsers. If they fon't have the latest version, agents will see error messages whenever they are in a call.