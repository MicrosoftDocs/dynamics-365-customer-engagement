---
title: Best practices for setting up the voice channel
description: Learn about the best practices for setting up the voice channel.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: best-practice
ms.collection:
ms.date: 06/30/2025
ms.custom: bap-template
---

# Best practices for setting up the voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use the information in this article to set up the hardware and software for an optimal performance of the voice channel in your contact center. The requirements might vary based on the overall configuration and size of your contact center.

## Hardware configuration

For optimized voice communication, make sure of the following settings:

- **Network configuration**: A stable Internet connection is crucial for uninterrupted calls. Use a wired Ethernet connection or a stable wireless network with sufficient bandwidth. For minimum and recommended bandwidth speeds, refer [system requirements](/dynamics365/contact-center/implement/system-requirements-contact-center).

- **Compatible headsets**: For clear communication, use USB headsets with noise-canceling microphones. If you rely on laptop speakers and microphone, you're likely to experience background noise in calls and meetings.

- **Use devices correctly**:
  - Test your microphone and speaker settings.
  - Place your microphone close to your mouth to capture your voice clearly. Adjust the sensitivity to remove unwanted echo.
  - Adjust speaker volume to a comfortable level to prevent audio distortion.
  - Minimize background noise.

## Software configuration

The software settings to ensure seamless integration are as follows:

**Firewall and security**: [Add the URLs and IP addresses to the allowlist](/dynamics365/contact-center/implement/system-requirements-contact-center#allow-access-to-websites) to allow communication between your system and the Omnichannel servers and prevent any security-related issues during your interactions. Make sure that the firewall configuration aligns with the [guidelines](/azure/communication-services/concepts/voice-video-calling/network-requirements#firewall-configuration) in Azure Communication Services.

**Telemetry insights**: Within the same geo/region location, network latencies are usually less than 150 ms. Enable [telemetry insights](/dynamics365/guidance/implementation-portal/telemetry-insights) to understand where delays come from. These insights can also be used to evaluate the performance of form load and API throttling.

**Desktop companion application**: If representatives experience a delay in joining calls after accepting the notification, they can install and use the [Desktop companion application](/dynamics365/contact-center/administer/install-manage-desktop-app) to join calls and maintain connectivity.

### Related information

[Network recommendations](/azure/communication-services/concepts/voice-video-calling/network-requirements)  
[Best practices for configuring AI agents](../administer/configure-bot-best-practices.md)  
