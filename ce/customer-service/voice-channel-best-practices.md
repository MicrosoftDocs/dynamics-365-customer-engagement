---
title: Best practices for setting up the voice channel
description: Learn about the best practices for setting up the voice channel in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 08/16/2023
ms.custom: bap-template
---

# Best practices for setting up the voice channel

Use the information in this article to set up the hardware and software for an optimal performance of the voice channel in Omnichannel for Customer Service. The requirements might vary based on the overall configuration and size of your contact center.

## Hardware configuration

For optimized voice communication, make sure of the following settings:

- **Network configuration**: A stable Internet connection is crucial for uninterrupted calls. Use a wired Ethernet connection or a stable wireless network with sufficient bandwidth. For minimum and recommended bandwidth speeds, see [system requirements](system-requirements-omnichannel.md).

- **Compatible headsets**: For clear communication, use USB headsets with noise-canceling microphones. If you rely on laptop speakers and microphone, you're likely to experience background noise in calls and meetings.

- **Use devices correctly**:
  - Test your microphone and speaker settings.
  - Place your microphone close to your mouth to capture your voice clearly. Adjust the sensitivity to remove unwanted echo.
  - Adjust speaker volume to a comfortable level to prevent audio distortion.
  - Minimize background noise.

## Software configuration

The software settings to ensure seamless integration are as follows:

**Firewall and security**: [Add the URLs and IP addresses to the allowlist](system-requirements-omnichannel.md#allow-access-to-websites) to allow communication between your system and the Omnichannel servers and prevent any security-related issues during your interactions. Make sure that the firewall configuration aligns with the [guidelines](/azure/communication-services/concepts/voice-video-calling/network-requirements#firewall-configuration) in Azure Communication Services.

### See also

[Network recommendations](/azure/communication-services/concepts/voice-video-calling/network-requirements)