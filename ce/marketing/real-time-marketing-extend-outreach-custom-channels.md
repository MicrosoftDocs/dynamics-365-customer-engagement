---
title: Manually add a custom channel
description: Learn how to manually add a custom outreach channel in Dynamics 365 Marketing.
ms.date: 07/27/2023
ms.custom: 
  - bap-template
ms.topic: overview
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Manually add a custom channel

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Dynamics 365 Marketing supports **Email**, **Push**, and **SMS** channels natively. To use a type of channel or an SMS provider that isn't supported natively, you can [install a custom channel](real-time-marketing-create-custom-channels.md). If the channel isn't already provided in AppSource, you can create and install it manually.

## Custom channel structure

Custom channels can be implemented as part of a Dataverse solution. The following steps and actions are required to create a custom channel:

1. [Define an extended configuration entity for the channel instance](real-time-marketing-define-custom-channel-instance.md)
1. [Define an extended configuration entity for the channel instance account](real-time-marketing-define-channel-instance-account.md) (SMS only)
1. [Define the message parts](real-time-marketing-custom-channel-message-parts.md) (solution-aware component)
1. [Define the localization for the admin interface](real-time-marketing-custom-channel-localization-admin.md) (optional)
1. [Define the message editor interface](real-time-marketing-custom-channel-message-editor.md) (optional)
1. [Define custom APIs](real-time-marketing-custom-channel-custom-api.md)
1. [Define the custom channel](real-time-marketing-define-channel-definition.md) (solution-aware component)

Marketing provides base components for creating a custom channel, including custom APIs and required entities like msdyn_channeldefinition, msdyn_channelmessagepart, msdyn_channellocale, msdyn_channelinstanceaccount and msdyn_channelinstance.

The following diagram illustrates the main components of a native Marketing channel and a custom channel solution:

:::image type="content" source="media/real-time-marketing-custom-channel-solution.png" alt-text="Diagram showing the structure of a native Marketing and a custom channel solution." lightbox="media/real-time-marketing-custom-channel-solution.png":::

The following table describes the implementation requirements for SMS and custom channels.

| **Component** | **SMS** | **Custom** |
| --- | --- | --- |
| Extended configuration entity for the channel instance | Required | Required |
| Extended configuration entity for the channel instance account | Required | Not supported |
| Message parts | Required; should contain only a single message part with "msdyn_name" = "text" | Required |
| Localization for admin UI | Optional | Optional |
| Message editor UI | Not allowed; native Marketing SMS editor is used | Optional; generic Marketing editor is used if not defined |
| Custom APIs | Required | Required |
| Channel definition | Required | Required |

## Sample solutions

The following samples include unpacked solutions for Dataverse and plugins projects. To pack and import the solutions, first build the plugin project. The project copies the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)
- [SampleCustomChannel.zip](https://download.microsoft.com/download/0/e/6/0e669f80-c626-4df9-b181-3c14cb9bc4a7/SampleCustomChannel.zip)

### How to build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio.

    Building the project creates a DLL in the PluginAssemblies folder inside the Dataverse solution folder.

1. Pack the unmanaged folder with the Solution Packager using either:

    - [pac CLI](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)  

    `pac solution pack --zipfile C:\tmp\SampleCustomChannelSolution.zip -f src\Solutions\Samples\SampleCustomChannel\SampleCustomChannel.Solution\unmanaged --packagetype Both`

[!INCLUDE [footer-include](../includes/footer-banner.md)]
