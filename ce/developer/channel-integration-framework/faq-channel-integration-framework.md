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
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 25004203-DE03-4DEC-BE4A-E4E89784A4F3
author: susikka
ms.author: susikka
manager: shujoshi
---

# Frequently asked questions (FAQs) for Dynamics 365 Channel Integration Framework (CIF)

## What is Dynamics 365 Channel Integration Framework?
Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface Apps using a browser-based JavaScript API library.

## Can I integrate a two-way communication channel?
Yes, you can integrate two-way communication that enables you to set the context of inbound and/or outbound according to your business and process workflows.

## Does Channel Integration Framework work with Unified Interface Apps?
Yes, Channel Integration Framework works only with Unified Interface Apps. As of now, Channel Integration Framework does not support Web Client.

## Is Channel Integration Framework a softphone?
No, Channel Integration Framework provides an extensible framework to integrate third-party channel providers (softphones, chat, and SMS) with Dynamics 365 Unified Interface Apps.

## Does Channel Integration Framework make calls or send messages?
No, Channel Integration Framework provides an extensible framework to configure the channel provider to make inbound or/and outbound calls or messages.

## Is Channel Integration Framework a server-side API?
No, Channel Integration Framework provides a JavaScript library that exposes APIs that you can consume to perform the following operations:
- Create, retrieve, update, and delete entity records
- Getting and setting Click-to-Act functionality
- Search among records of a particular entity type
- Getting and setting the panel width and so on

More information: [Microsoft.CIFramework methods (CIF JavaScript API reference)](reference/microsoft-ciframework.md).

## Does Channel Integration Framework manage call or chat sessions?
No, Channel Integration Framework does not manage call or chat sessions.

## Is Channel Integration Framework dependent on operating systems and browsers?
No, Channel Integration Framework is operating system and web browser agnostic and lets you integrate the cloud-based channels of your choice that are best for organization requirements.

## Which web browsers does Channel Integration Framework support?
Channel Integration Framework is supported on Microsoft Edge and Google Chrome. 

> [!NOTE]
> The widget domain needs to be accorded permission to use appropriate media like pop-ups and microphone as required. For Microsoft Edge to permanently accord the required permissions, the required domain needs to be accessed via a regular window; permanent exception cannot be granted when the domain is accessed in private mode.

## Are there any browsers that Channel Integration Framework does not support?
Yes, Channel Integration Framework does not support Internet Explorer and Firefox browsers.

## Can partners package solutions that have a dependency on the Channel Integration Framework (CIF) solution, together with the CIF solution?
No, the Channel Integration Framework (CIF) solution should not be bundled with another solution. Partners can create solutions that add a check to their package looking for the Channel Integration Framework (CIF) solution (also mentioning the minimum supported version), which causes installation to fail in case the CIF solution is not present.

Also, you can add Configuration Experience to the acquire flow that will allow the solution to detect the state of the target instance, and decide how to install. This will also let the solution do any additional setup or license acquisition remotely before installing.

## What happens when you select a role from under Select roles for the Channel ?

When you select a particular security role for the channel provider from under the **Select roles for the Channel** dropdown, the security role provides certain access rights to the channel provider. In case no role is selected, the channel provider can only be accessed by System Administrators and Customizers.

> [!IMPORTANT]
> When you select a role in the **Select roles for the Channel** list, it does not filter out users with just the System Administrator role. The System Administrator and Customizer roles will always have access to the channel provider. When you assign a System Administrator role to a user, the other users who have been assigned System Administrator role earlier will not lose access unless you explicitly revoke System administrator rights from a user.

## See also

[Dynamics 365 Channel Integration Framework Guide](index.md)<br />
[Overview of Channel Integration Framework](overview-channel-integration-framework.md)<br />
[System requirements of Channel Integration Framework](system-requirements-channel-integration-framework.md)