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

Configure the Microsoft Remote Desktop client in your agents remote desktop. This enables agents to connect to the voice channel using the Azure Virtual Desktop. 

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

# AVD Agent Availability

| AVD Agent Availability (A1)                | New Incoming Items                                 | Existing Live Work Items                                                                                       |
|--------------------------------------------|---------------------------------------------------|---------------------------------------------------------------------------------------------------------------|
|                                            | **Phone Call**                                      | **Non-Phone Call**                                                                                                 | **Active Consult (Primary agent is disconnected)**                                                                               | **Active Consult - secondary agent**                                                                          | **Transfer**                                                                                      |
| When an agent is disconnected from the Azure Virtual Desktop.    | Notifications aren't delivered to agent's Azure Virtual Desktop remote instance. | The ongoing call remains assigned to the agent and the customer hears a message that the agent is disconnected and will rejoin the call shortly and wait music. | Non-voice conversations remain assigned to agent. If the agent is in a chat conversation that is converted to a voice or video, then the voice or video call ends. | The secondary agent hears a message that the primary agent is disonnected.                                                   | The call ends for the secondary agent.         |                                                              |
| Agent is disconnected and reconnects to the Azure Virtual Desktop instance in less than 30 seconds. | Incoming notifications are displayed to the agent.  | Agent is reconnected to the call. The call status, such as hold or mute remains from what it was before the disconnection.                   | The primary agent is reconnected to the conversation.                                                              | Primary agent rejoins the call. The call status remains the same from what it was before the disconnection.             | The call ends for the secondary agent.                  | Call is transferred. The agent is reconnected to the call if the transfer fails.                                                                      |
| Agent takes more than 30 seconds to reconnect to the Azure Virtual Desktop instancs but reconnects within 2.5 mins | Incoming notifications are displayed to the reconnected agent. | The call is rerouted.                                             | Agent rejoins the conversation.                                                                                                         | Call gets rerouted to a different agent and the consult ends. The customer remains on hold                           | Call ends for the secondary agent.                                  | Call rerouted if transfer fails.                                                                                 |
| Agent takes more than 2.5 mins to reconnect to the Azure Virtual Desktop.   | Incoming notifications are displayed when the agent reconnects.  | Call is rerouted.                                                                                              | Conversation is rerouted                                                                                               | N/A                                                                                                             | Consult ends for the secondary agent.                                          | Call is rerouted.                                      |