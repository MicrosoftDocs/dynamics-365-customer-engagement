---
title: "Support for multiple channel providers with Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Use this topic to understand how you can add multiple channel providers in Omnichannel for Customer Service using Dynamics 365 Channel Integration Framework 2.0."
ms.date: 09/21/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Support for multiple channel providers

With Dynamics 365 Channel Integration Framework 2.0, organizations can configure multiple channel providers (first-party chat and third-party telephony providers) in the Omnichannel for Dynamics 365 Customer Service app. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels (such as first-party chat and third-party telephony providers), where each of these sessions belongs to a different provider. Agents can switch across these sessions as needed. Omnichannel for Customer Service brings one provisioned channel provider configuration, however, you can add other channel provider records and configure them. 

## Considerations

Here are a few things to note when you create or start sessions:

- Sessions started using Dynamics 365 Channel Integration Framework 2.0 APIs are associated with the channel provider. Providers are notified about events for the session started by them.

- Providers can open new tabs only in the sessions they have started.

- Providers cannot programmatically switch sessions or close sessions. 

- Agents can manually switch and close sessions. As a best practice, we recommended that sessions are started after taking agent consent using a toast notification.

- If a provider session is not in focus, and there is a new event in that session (for example, a new unread message from a customer), then you can use the [requestFocusSession API](reference/microsoft-ciframework/requestfocussession.md) to show the agent that the session that's not in focus requires attention.

## Start a home (default) session when your organization uses multiple channel providers

If you have multiple channel providers in your organization, the chat widget won't be visible in the home session, as the home session isn't associated with any provider. Also, the [setMode](reference/microsoft-ciframework/setmode.md) method is not supported in the home page. So, in such a scenario, you must create a default session to show a dialer experience in the chat widget, conversation dashboards in the application tab, and so on. 

To create a default session, do the following:
1. Use the [createSession](../reference/microsoft-ciframework/createsession) method to create a session with relevant application tabs and load them together with the widget.
2. Use the [Microsoft.CIFramework.setMode(1)](../reference/microsoft-ciframework/setmode.md) method in your provider code, at the end of the initialization section. This ensures that the widget is visible right from the time the channel provider is loaded.

## Start a home (default) session when your organization uses a third-party telephony provider

If your organization uses a third-party telephony provider, then you can use the setMode method to start a home session.

Call the [Microsoft.CIFramework.setMode(1)](../reference/microsoft-ciframework/setMode.md) method from your provider code to make the communication panel visible. You can add the method at the end of your initialization code, so that the widget is visible right from the time the channel provider is loaded. 

In addition to this, you can listen to the [onSessionClosed](../reference/events/onsessionclosed) event to show the channel provider widget when the last session is closed. This way you can make sure that the channel provider widget is visible all the time whether a session is open or not.

### See also

[What's new in Dynamics 365 Channel Integration Framework](../whats-new-channel-integration-framework.md)  
[Configure channel providers in Dynamics 365 Channel Integration Framework 1.0](../configure-channel-provider-channel-integration-framework.md)  
[Bring your own custom messaging channel](../../bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
