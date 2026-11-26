---
title: Configure support for single and multiple channel providers with Dynamics 365 Channel Integration Framework 2.0 
description: Use this article to understand how you can configure single and multiple channel providers in Omnichannel for Customer Service using Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template

---

# Configure support for single and multiple channel providers

With Dynamics 365 Channel Integration Framework 2.0, organizations can configure single and multiple channel providers (first-party chat and non-Microsoft telephony providers) in the Omnichannel for Dynamics 365 Customer Service app. This enables customer service representatives (service representative or representative) to simultaneously work on multiple sessions catering to different customers on different channels where each of these sessions belongs to a different provider. Representatives can switch across these sessions as needed. Omnichannel for Customer Service brings one provisioned channel provider configuration, however, you can add other channel provider records and configure them. 

## Considerations

Here are a few things to note when you create or start sessions when you have multiple channel providers in your organization:

- Sessions that are started by using Dynamics 365 Channel Integration Framework 2.0 APIs are associated with the channel provider. Providers are notified about events for the session started by them.

- Providers can open new tabs only in the sessions they initiate.

- Providers can't programmatically switch sessions or close sessions. 

- Representatives can manually switch and close sessions. As a best practice, we recommended that sessions are started after taking representative consent using a toast notification.

- If a provider session isn't in focus, and there's a new event in that session such as a new unread message from a customer, then you can use the [requestFocusSession API](../develop/reference/microsoft-ciframework/requestfocussession.md) to show the representative that the session that's not in focus requires attention.

## Start a home (default) session when your organization uses a single channel provider

If your organization uses a single channel provider, then you can use the `setMode` method to start a home session.

 To make the communication panel visible, call the [Microsoft.CIFramework.setMode(1)](../develop/reference/microsoft-ciframework/setMode.md) method from your provider code. You can add the method at the end of your initialization code, so that the widget is visible right from the time the channel provider is loaded. 

You can also listen for the [onSessionClosed](../develop/reference/events/onSessionClosed.md) event to show the communication widget when the last session is closed. This way you can make sure that the communication widget is visible all the time whether a session is open or not.

## Start a home (default) session when your organization uses multiple channel providers

When you have multiple channel providers in your organization, the communication widget isn't visible in the home session, as the home session isn't associated with any specific channel provider. Also, the [setMode](../develop/reference/microsoft-ciframework/setMode.md) method isn't supported in the home page. So, you must create a default session to show a dialer experience in the widget, conversation dashboards in application tab, and so on. 

To create a default session, do the following actions:
1. Use the [createSession](../develop/reference/microsoft-ciframework/createsession.md) method to create a session with relevant application tabs and load them together with the widget.
2. Use the [Microsoft.CIFramework.setMode(1)](../develop/reference/microsoft-ciframework/setMode.md) method in your provider code, at the end of the initialization section. This ensures that the widget is visible right from the time the channel provider is loaded.



### Related information

[What's new in Dynamics 365 Channel Integration Framework](../../whats-new-channel-integration-framework.md)  
[Configure channel providers in Dynamics 365 Channel Integration Framework 1.0](../../v1/administer/configure-channel-provider-channel-integration-framework.md)  
[Bring your own custom messaging channel](../../../customer-service/develop/bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
