---
title: "Bring your own phone number: Azure direct routing | MicrosoftDocs"
description: "Use this topic to understand how you can bring your own phone numbers in Omnichannel for Customer Service via Azure direct routing."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
<!--  

a.	Bring your own number via Azure direct routing[Neeraja]  Delta from private preview refresh; link to ACS docs and add a couple of steps with screenshots. This is part of number management. 

-->
# Bring your own number: Azure direct routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To use the voice channel in Omnichannel for Customer Services, customers must acquire new phone numbers from [Azure Communication Services](/azure/communication-services/overview). Azure Communication Services, however, provides numbers only in the United States with Microsoft as the carrier for the voice data.

[Azure direct routing (preview)](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing) enables you to connect your existing telephony infrastructure to Azure.
So, if you have non-US based phone numbers, or want to retain your existing numbers (for example, 1800-WALMART) and carriers (such as AT&T, Verizon, TATA, British Telecom), you can do so using Azure direct routing.

## Prerequisites

To bring in your own number via Azure direct routing, you must first connect to an Azure Communications Service resource. You must then set up Azure direct routing for the connected Azure resource.

[!Note]
> This feature is not available in trial mode.

Before you bring in your own number, do the following:

- [Understand Azure direct routing](/azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)

- [Get a certified SBC](/azure/communication-services/concepts/telephony-sms/certified-session-border-controllers)

- [Connect the SBC to Azure Communication Services](/azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

## Bring your own number via Azure direct routing

1. Open Omnichannel admin center and under **General settings**, select **Phone numbers**, and then select **Advanced**.

2. Select **Add Number** next to **Bring your own number via Azure Direct Routing (preview)**.

3. In the **Add phone number** dialog, enter the following details:

- **Phone number**: Number that you own that you’ve configured in your SBC.

- **Carrier**: Denote which carrier the phone number belongs to. If the carrier doesn’t exist yet, you can create a new record.

- **Country/Region**: Select the Country/Region this phone numbers belongs to.

- **Number type**: Select if it’s toll free or a local phone number.

- **Calling plans**: Select if the phone number can make or receive calls.
    > [!Note]
    > SMS is not supported with Azure direct routing.

4. Select **Add Number**.

The new phone number will be displayed in the Phone numbers list and is ready for setup. You can now [connect it to a voice workstream](voice-channel-route-queues), [configure outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling), or even [assign it to an agent](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-agents). 
  
### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-create-new-use-existing-resource.md)  
[Integrate third-party IVRs with voice channel: Azure direct routing](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
