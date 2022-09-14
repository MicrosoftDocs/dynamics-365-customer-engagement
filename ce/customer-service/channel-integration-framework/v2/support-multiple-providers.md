---
title: "Support for multiple channel providers with Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Use this topic to understand how you can add multiple channel providers in Omnichannel for Customer Service using Dynamics 365 Channel Integration Framework 2.0."
ms.date: 12/31/2018
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

Here are the key features of this capability:

-   Sessions started using Dynamics 365 Channel Integration Framework 2.0 APIs are associated with the channel provider. Providers are notified about events on the session started by them.

-   Providers can open new tabs only in the sessions they have started.

-   Providers cannot programmatically switch sessions or close sessions. Agents can manually switch and close sessions.

-   If a provider session is not in focus, and there is a new event in that session (for example, a new unread message from a customer), then you can use the ***requestFocusSession*** API to show the agent that the session that's not in focus requires attention.

> [!NOTE]
> As a best practice, we recommended that sessions are started after taking agent consent using a toast notification.

### See also

[What's new in Dynamics 365 Channel Integration Framework](../whats-new-channel-integration-framework.md)  
[Configure channel providers in Dynamics 365 Channel Integration Framework 1.0](../configure-channel-provider-channel-integration-framework.md)  
[Bring your own custom messaging channel](../../bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
