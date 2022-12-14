---
title: "Manually add a custom channel (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to extend your outreach by manually adding a custom channel in Dynamics 365 Marketing."
ms.date: 12/13/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Manually add a custom channel

Marketing currently offers three types of native channels: **Email**, **Push** and **SMS**. To create a different type or channel or use an SMS provider that isn't supported natively, you need to develop and install a custom channel solution. 

## Custom channel structure

Custom channels can be implemented as part of a Dataverse solution. The steps and actions required to create a custom channel are listed below:

1.	Define your extended configuration entity for Channel Instance 
2.	Define your extended configuration entity for the Channel Instance account   - SMS only
3.	Define your Message parts ([solution aware component](https://dynamicscrm.visualstudio.com/OneCRM/_wiki/wikis/OneCRM.wiki/30527/Solution-Aware-Entities))
4.	Define your localization for the Admin UI - Optional
5.	Define the Message editor UI - Optional
6.	Define your Custom APIs
7.	Define your Channel Definition ([solution aware component](https://dynamicscrm.visualstudio.com/OneCRM/_wiki/wikis/OneCRM.wiki/30527/Solution-Aware-Entities))

Marketing already provides base components for the custom channel creation: the **required entities** like msdyn_chaneldefinition, msdyn_channelmessagepart, msdyn_channelocale, msdyn_channelinstanceaccout and msdyn_channelinstance. Along with the entity metadata, it provides **Custom APIs** that should be called from your custom solution’s plugins in order to proxy the data to Dataverse.

The overview diagram below shows main components of Marketing and custom channel solution, so as how they interact with each other:

> [!div class="mx-imgBorder"]
> [ ![Custom channel solution diagram](media/real-time-marketing-custom-channel-solution-small.png) ](media/real-time-marketing-custom-channel-solution.png#lightbox)

The implementation requirements for channels of SMS and Custom type differ as follows:

| **Component**                                                    | **SMS**                                                                          | **Custom**                                                |
|--------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|---------------------------------------------------------------------|
|    <br>Extended configuration entity for the Channel Instance            |    <br>Required                                                                            |    <br>Required                                                     |
|    <br>Extended configuration entity for the Channel Instance account    |    <br>Required                                                                            |    <br>Not supported currently                                      |
|    <br>Message parts                                                     |    <br>Required, should contain only a single message part with   “msdyn_name” = “text”    |    <br>Required                                                     |
|    <br>Localization for Admin UI                                         |    <br>Optional                                                                            |    <br>Optional                                                     |
|    <br>Message editor UI                                                 |    <br>Not allowed, native Marketing SMS editor is used                                    |    <br>Optional, generic Marketing editor is used if not defined    |
|    <br>Custom APIs                                                       |    <br>Required                                                                            |    <br>Required                                                     |
|    <br>Channel Definition                                                |    <br>Required                                                                            |    <br>Required                                                     |

## Sample solutions

The samples below include unpacked solutions for Dataverse and plugins projects. To pack and import these solutions, first build the plugin project. The project will then copy the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

- [SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel-2022.12.zip)
- [SampleCustomChannel.zip](https://download.microsoft.com/download/5/8/6/586e2d47-ac82-48e9-9cc4-066c141e0649/SampleCustomChannel-2022.12.zip)

### How to build the plugins project and pack the solution

1. Build the plugins project with MSBuild or Visual Studio. Building the project will create a dll in the PluginAssemblies folder inside the Dataverse solution folder.
1. Pack the unmanaged folder with the Solution Packager using either:
    - [pac cli](/power-platform/developer/cli/reference/solution#pac-solution-pack) (**preferred**)
    - [Solution packager](/dynamics365/customerengagement/on-premises/developer/compress-extract-solution-file-solutionpackager)  

    `pac solution pack --zipfile C:\tmp\SampleCustomChannelSolution.zip -f src\Solutions\Samples\SampleCustomChannel\SampleCustomChannel.Solution\unmanaged --packagetype Both`
