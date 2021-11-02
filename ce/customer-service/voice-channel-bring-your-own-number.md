---
title: "Bring your own phone numbers | MicrosoftDocs"
description: "Use this topic to understand how you can bring your own phone numbers from any carrier to Dynamics 365 via Azure direct routing."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Bring your own phone numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[Azure direct routing (preview)](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing) enables you to connect your existing telephony infrastructure with Azure so that you can retain your existing carrier and phone numbers, and streamline inter-office call transfers.

## Prerequisites

To bring in your own phone numbers from any carrier via Azure direct routing, you must first connect to an Azure Communication Services resource. You must then set up Azure direct routing for the connected Azure resource.

Before you bring in your own number, you must be familiar with the following:
- [Understand Azure Communication Services](/azure/communication-services/overview)
- [Understand Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

Also, ensure you have set up the following:
- [Azure direct routing infrastructure](/azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)
- [Get a certified Session Border Controller (SBC)](/azure/communication-services/concepts/telephony-sms/certified-session-border-controllers)
- [Connect the SBC to Azure Communication Services](/azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

## Bring your own phone number via Azure direct routing

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Advanced**.

2. Select **Add Number** next to **Bring your own number via Azure Direct Routing (preview)**.

3. In the **Add your own phone number** dialog, enter the following details:

    - **Phone number**: Indicates the phone number that you own and have configured in your SBC.

    - **Carrier**: Indicates the carrier to which the phone number belongs. If the carrier doesn’t exist yet, you can create a new record.

    - **Country/Region**: Select the country or region the phone number belongs to.

    - **Number type**: Select whether toll-free or a local phone number.

    - **Calling plans**: Select whether you can make or receive calls on the phone number.
        > [!Note]
        > SMS is not supported with Azure direct routing (preview).

4. Select **Add number**.

The new phone number will be displayed in the Phone numbers list and is ready for setup. You can now [connect it to a voice workstream](voice-channel-route-queues.md), [configure outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling), or even [assign it to an agent](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-agents).
  
### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-create-new-use-existing-resource.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
