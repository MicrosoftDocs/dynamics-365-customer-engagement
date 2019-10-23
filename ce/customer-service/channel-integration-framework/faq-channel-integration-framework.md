---
title: "FAQs for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
description: "Frequently asked questions about the Channel Integration Framework (CIF) and its APIs for Dynamics 365."
keywords: ""
ms.date: 02/14/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 25004203-DE03-4DEC-BE4A-E4E89784A4F3
author: susikka
ms.author: susikka
manager: shujoshi
---

# Frequently asked questions (FAQs) for Dynamics 365 Channel Integration Framework

### What is Dynamics 365 Channel Integration Framework?
Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface Apps using a browser-based JavaScript API library.

### Can I integrate a two-way communication channel?
Yes, you can integrate two-way communication that enables you to set the context of inbound and/or outbound according to your business and process workflows.

### Does Channel Integration Framework work with Unified Interface Apps?
Yes, Channel Integration Framework works only with Unified Interface Apps. As of now, Channel Integration Framework does not support Web Client.

### Is Channel Integration Framework a softphone?
No, Channel Integration Framework provides an extensible framework to integrate third-party channel providers (softphones, chat, and SMS) with Dynamics 365 Unified Interface Apps.

### Does Channel Integration Framework make calls or send messages?
No, Channel Integration Framework provides an extensible framework to configure the channel provider to make inbound or/and outbound calls or messages.

### Is Channel Integration Framework a server-side API?
No, Channel Integration Framework provides a JavaScript library that exposes APIs that you can consume to perform the following operations:
- Create, retrieve, update, and delete entity records
- Getting and setting Click-to-Act functionality
- Search among records of a particular entity type
- Getting and setting the panel width and so on

More information: [Microsoft.CIFramework methods (CIF JavaScript API reference)](reference/microsoft-ciframework.md).

### Does Channel Integration Framework manage call or chat sessions?
No, Channel Integration Framework does not manage call or chat sessions.

### Is Channel Integration Framework dependent on operating systems and browsers?
No, Channel Integration Framework is operating system and web browser agnostic and lets you integrate the cloud-based channels of your choice that are best for organization requirements.

### Which web browsers does Channel Integration Framework support?
Channel Integration Framework is supported on Microsoft Edge and Google Chrome. 

> [!NOTE]
> The widget domain needs to be accorded permission to use appropriate media like pop-ups and microphone as required. For Microsoft Edge to permanently accord the required permissions, the required domain needs to be accessed via a regular window; permanent exception cannot be granted when the domain is accessed in private mode.

### Are there any browsers that Channel Integration Framework does not support?
Yes, Channel Integration Framework does not support Internet Explorer and Firefox browsers.

### Can partners package solutions that have a dependency on the Channel Integration Framework (CIF) solution, together with the CIF solution?
No, the Channel Integration Framework (CIF) solution should not be bundled with another solution. Partners can create solutions that add a check to their package looking for the Channel Integration Framework (CIF) solution (also mentioning the minimum supported version), which causes installation to fail in case the CIF solution is not present.

Also, you can add Configuration Experience to the acquire flow that will allow the solution to detect the state of the target instance, and decide how to install. This will also let the solution do any additional setup or license acquisition remotely before installing.

### What happens when you select a role from under Select roles for the Channel?

When you select a particular security role for the channel provider from under the **Select roles for the Channel** dropdown, the security role provides certain access rights to the channel provider. In case no role is selected, the channel provider can only be accessed by System Administrators and Customizers.

> [!IMPORTANT]
> When you select a role in the **Select roles for the Channel** list, it does not filter out users with just the System Administrator role. The System Administrator and Customizer roles will always have access to the channel provider. When you assign a System Administrator role to a user, the other users who have been assigned System Administrator role earlier will not lose access unless you explicitly revoke System administrator rights from a user.

### Can I load the Channel Integration Framework version 1.0 communication widget in Omnichannel for Customer Service?

No, that is not supported.

## Channel Integration Framework version 2.0 FAQs

### How do I join Channel Integration Framework version 2.0 preview program?

The preview program is available at the Insider Portal with the name **Channel Integration Framework - V2**. You need to register as a Dynamics Insider at https://experience.dynamics.com/insider to avail this program.

### Will there be a separate AppSource offer for Channel Integration Framework version 2.0 ?

During the preview program, the Channel Integration Framework version 2.0 will be available via the flighting program. The flights will have to be enabled by the administrators on their organizations. The instructions for the same are available in the insider program. However, with the general availablity, the Channel Integration Framework version 2.0 and version 1.0 APIs will be available through a single app. 

### Will my existing communication widget, built using Channel Integration Framework version 1.0 APIs, continue to work with the version 2.0 app?

Yes. Channel Integration Framework version 1.0 APIs will continue to be available and supported for the single-session unified interface apps like Customer Service Hub and Sales Hub. Even with Channel Integration Framework version 2.0 app, they will continue to work as earlier.

### I want to use the multi-session experiences for my contact center with a third party provider's communication widget built using the Channel Integration Framework version 2.0 APIs. What licenses do I need to purchase for that?

During the preview period you can get the Omnichannel for Customer Service using the chat for [Dynamics 365 trial](https://trials.dynamics.com) and use the Channel Integration Framework version 2.0 preview with the same. 

## See also

[Overview of Channel Integration Framework](overview-channel-integration-framework.md)<br />
[System requirements of Channel Integration Framework](system-requirements-channel-integration-framework.md)