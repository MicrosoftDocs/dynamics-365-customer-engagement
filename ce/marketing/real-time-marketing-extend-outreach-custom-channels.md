---
title: "Preview: Manually add a custom channel (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to extend your outreach by manually adding a custom channel in Dynamics 365 Marketing."
ms.date: 11/03/2022
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

# Preview: Manually add a custom channel

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.


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
> ![custom channel solution](media/real-time-marketing-custom-channel-solution.png "custom channel solution")

The implementation requirements for channels of SMS and Custom type differ as follows:

| **Component**                                                    | **SMS**                                                                          | **Custom**                                                |   |   |   |   |
|--------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|---------------------------------------------------------------------|---|---|---|---|
|    <br>Extended configuration entity for the Channel Instance            |    <br>Required                                                                            |    <br>Required                                                     |   |   |   |   |
|    <br>Extended configuration entity for the Channel Instance account    |    <br>Required                                                                            |    <br>Not supported currently                                      |   |   |   |   |
|    <br>Message parts                                                     |    <br>Required, should contain only a single message part with   “msdyn_name” = “text”    |    <br>Required                                                     |   |   |   |   |
|    <br>Localization for Admin UI                                         |    <br>Optional                                                                            |    <br>Optional                                                     |   |   |   |   |
|    <br>Message editor UI                                                 |    <br>Not allowed, native Marketing SMS editor is used                                    |    <br>Optional, generic Marketing editor is used if not defined    |   |   |   |   |
|    <br>Custom APIs                                                       |    <br>Required                                                                            |    <br>Required                                                     |   |   |   |   |
|    <br>Channel Definition                                                |    <br>Required                                                                            |    <br>Required                                                     |   |   |   |   |

#### Sample solutions  
The samples below include unpacked solutions for Dataverse and plugins projects.
To pack and import these solutions, first build the plugin project. The project will then copy the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](https://learn.microsoft.com/en-us/power-platform/alm/solution-packager-tool)


SampleSmsChannel.zip

SampleCustomChannel.zip