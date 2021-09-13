---
title: "FAQs for Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: "Frequently asked questions about Dynamics 365 Channel Integration Framework and its APIs for Dynamics 365."
ms.date: 09/09/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# FAQs for Dynamics 365 Channel Integration Framework

## General FAQs

### What is Dynamics 365 Channel Integration Framework?

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Unified Interface apps Dynamics 365 using a browser-based JavaScript API library.

### Can I integrate a two-way communication channel?

Yes, you can integrate two-way communication that enables you to set the context of inbound and/or outbound calling according to your business and process workflows.

### Can I synchronize user presence across different providers?

User presence synchronization across providers is not supported.

### Does Dynamics 365 Channel Integration Framework work with Unified Interface apps?

Dynamics 365 Channel Integration Framework works only with Unified Interface apps. As of now, Dynamics 365 Channel Integration Framework does not support the legacy web client.

### Is Dynamics 365 Channel Integration Framework a softphone?

No, Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party channel providers (softphones, chat, and SMS) with Dynamics 365 Unified Interface apps.

### Does Dynamics 365 Channel Integration Framework make calls or send messages?

No, Dynamics 365 Channel Integration Framework provides an extensible framework to configure the channel provider to make inbound or outbound calls or messages.

### Is Dynamics 365 Channel Integration Framework a server-side API?

No, Dynamics 365 Channel Integration Framework provides a JavaScript library that exposes APIs that you can use to perform the following operations:
- Create, retrieve, update, and delete entity records.
- Get and set Click-to-Act functionality.
- Search among records of a particular entity type.
- Get and set the panel width, and so on.

More information: [Microsoft.CIFramework methods (CIF JavaScript API reference)](reference/microsoft-ciframework.md)

### Does Dynamics 365 Channel Integration Framework manage call or chat sessions?

No, Dynamics 365 Channel Integration Framework does not manage call or chat sessions.

### Is Dynamics 365 Channel Integration Framework dependent on operating systems and browsers?

No, Dynamics 365 Channel Integration Framework is agnostic to operating systems and web browsers; you can integrate cloud-based channels of your choice that are best for your organization's requirements.

### Which web browsers does Dynamics 365 Channel Integration Framework support?

Dynamics 365 Channel Integration Framework supports Microsoft Edge and Google Chrome.

> [!NOTE]
> The widget domain needs to be granted permission to use appropriate media like pop-ups and microphone as required. For Microsoft Edge to permanently grant the required permissions, the required domain needs to be accessed via a regular window; permanent exception cannot be granted when the domain is accessed in private mode.

### Are there any browsers that Dynamics 365 Channel Integration Framework does not support?

Dynamics 365 Channel Integration Framework does not support Internet Explorer and Firefox browsers.

### Can partners package solutions that have a dependency on the Dynamics 365 Channel Integration Framework solution, together with the Dynamics 365 Channel Integration Framework solution?

No, the Dynamics 365 Channel Integration Framework solution should not be bundled with another solution. Partners can create solutions that add a check to their package looking for the Dynamics 365 Channel Integration Framework solution (also mentioning the minimum supported version), which causes the installation to fail in case the Dynamics 365 Channel Integration Framework solution is not present.

Also, you can add Configuration Experience to the acquired flow that'll allow the solution to detect the state of the target instance, and decide how to install. This will also let the solution perform any additional setup or license acquisition remotely, before installation.

## Dynamics 365 Channel Integration Framework 1.0 FAQs

### What happens when you select a role from under Select roles for the Channel?

When you select a particular security role for the channel provider from under the **Select roles for the Channel** dropdown list, the security role provides certain access rights to the channel provider. If no role is selected, the channel provider can only be accessed by System Administrators and Customizers.

> [!IMPORTANT]
> When you select a role in the **Select roles for the Channel** list, it does not filter out users with just the System Administrator role. The System Administrator and Customizer roles will always have access to the channel provider. When you assign a System Administrator role to a user, the other users who have been assigned the System Administrator role earlier will not lose access unless you explicitly revoke system administrator rights from a user.

### Can I load the Dynamics 365 Channel Integration Framework 1.0 communication widget in Omnichannel for Customer Service?

No, that is not supported.

## Dynamics 365 Channel Integration Framework 2.0 FAQs

### What are the new changes to the Channel Integration Framework app?

Channel Integration Framework model-driven app is only applicable to configure channel providers for single session Dynamics 365 model-driven apps. The templates (Session, Notification, and Application tab) will not be available in the Channel Integration Framework app.

### My organization is using Channel Integration Framework 1.0. Does the change impact my organization?

No. There is no impact on Channel Integration Framework 1.0 users. You can continue to use the Channel Integration Framework app to configure channel providers for single session Dynamics 365 model-driven app.

### Where do I configure voice channel provider for multi-session apps?

Organizations can configure voice channel providers from the [App profile manager](../../app-profile-manager/overview.md).

### My organization is using voice channel configured using Channel Integration Framework 2.0. Does the change impact my organization?

Yes. From your channel provider record, you'll not be able to see the following two grids:

- Select the Unified Interface Apps for the Channel
- Select the Roles for the Channel
	
### How do I choose the Unified Interface apps for the voice channel provider record?

You don't need to choose the Unified Interface apps. The telephony channel providers are associated with app profiles, which works in the context of the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace.
	
### How do I select roles for the voice channel provider record?

Telephony channel providers are associated with app profiles, which in turn are assigned to users in your organization. With the new changes, you need to assign the app profiles to the users who should have access to the telephony channel provider.

### Will my existing communication widget, built using Dynamics 365 Channel Integration Framework 1.0 APIs, continue to work with the Dynamics 365 Channel Integration Framework 2.0 app?

Yes. Dynamics 365 Channel Integration Framework 1.0 APIs will continue to be available and supported for the single-session Unified Interface apps like Customer Service Hub and Sales Hub. Even with the Dynamics 365 Channel Integration Framework 2.0 app, they will continue to work.

### How do I use the multi-session experiences for my contact center with a third-party provider's communication widget?

Dynamics 365 Channel Integration Framework 2.0 works only with multi-session apps such as Omnichannel for Customer Service. You can integrate any third-party telephony provider with Omnichannel for Customer Service using the Channel Integration Framework 2.0 APIs. 

For information on selecting versions, see [Choose between version 1.0 and version 2.0](choose-between-versions.md).

For information on license, see [Dynamics 365 Customer Service pricing overview](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing) and [Dynamics 365 Customer Service pricing plan](https://dynamics.microsoft.com/en-us/pricing/customer-service/#plans).

### How can third party telephony providers start their default session?

You can invoke the [Microsoft.CIFramework.setMode(1)](reference/microsoft-ciframework/setmode.md) method from your provider code to make the panel visible. This can be added at the end of your initialization code, so that the widget is visible right from the time the channel provider is loaded. Beyond that point, you can listen to the [onSessionClosed](/dynamics365/customer-service/dynamics365/channel-integration-framework/referen/v2/reference/events/onSessionClosed) event to show the provider widget when the last session is closed. This way you can make sure that the channel provider widget is visible all the time whether or not a session is open.

### My organization uses multiple channel providers. How can I start a default session? Also, why is the widget not visible in the home session?

If there are multiple channel providers in your organization, the widget will not be visible in the home session, as the home session isn't associated with any provider. Note that the [setMode](reference/microsoft-ciframework/setmode.md) API is not supported in the home page. So, in such a scenario, you must create a default session to show a dialer experience in the communication widget, conversation dashboards in the application tab, and so on. 
To create a default session, do the following:
1. Use the [createSession](reference/microsoft-ciframework/createSession.md) API to create a session with relevant application tabs and load them together with the widget.
2. Use the [Microsoft.CIFramework.setMode(1)](reference/microsoft-ciframework/setmode.md) method in your provider code, at the end of the initialization section. This ensure that the widget is visible right from the time the channel provider is loaded.
### Why do tabs reload when an agent switches session tabs or switches from session tab to widget?

This is to make sure that the updated data is available for the agent at all times.

### Is it possible to integrate custom messaging channel providers?

Yes, you can integrate custom messaging channels using Direct Line bot. More information: [Bring your own channel](../../customer-service/bring-your-own-channel.md)

### Is it possible to view the existing channel providers from Channel Integration Framework 2.0 model-driven app?

No, you'll have to navigate to Channel Integration Framework 2.0 from app profile manager to view your existing channel providers. More information: [Configure channel provider using app profile manager](v2/configure-channel-provider-app-profile-manager.md)

### See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)<br />
[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)<br />
[System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)<br />
[Known issues of Dynamics 365 Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2171869)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
