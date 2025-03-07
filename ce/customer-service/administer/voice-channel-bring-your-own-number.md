---
title: Bring your own carrier
description: Use this article to understand how you can bring your own carrier to Dynamics 365 via Azure Direct Routing.
ms.date: 12/14/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template

---

# Bring your own carrier

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Azure Communication Services direct routing enables you to connect your existing telephony infrastructure with Azure so that you can retain your existing carrier and phone numbers, and streamline inter-office call transfers.

## Prerequisites

- Connect to an Azure Communication Services resource to bring in your carrier via direct routing. You must then set up direct routing for the connected Azure resource.
- Be familiar with the following concepts:
  - [Azure Communication Services](/azure/communication-services/overview)
  - [Azure Communication Services direct routing](/azure/communication-services/concepts/telephony/telephony-concept#azure-direct-routing)
- Ensure that the following settings are in place to enable your carrier to work with Azure Communication Services.
  - Check your [direct routing infrastructure requirements](/azure/communication-services/concepts/telephony/direct-routing-infrastructure).
  - [Get a certified Session Border Controller (SBC)](/azure/communication-services/concepts/telephony/certified-session-border-controllers).
  - [Connect the SBC to Azure Communication Services](/azure/communication-services/concepts/telephony/direct-routing-provisioning).
  - Ensure that the SBC responds with a Session Initiation Protocol (SIP) status code in the 100s to the invite request from direct routing. SIP status codes beginning with 4, 5, or 6 indicate failures.
  - Ensure that the phone number of your Dynamics 365 organization is encoded in E.164 format so that the calls can be forwarded by your SBC.
  - Deploy the SBC and DNS server in the same region. Azure Communication Services hosts group calls in the region where the DNS server is deployed. If the SBC and DNS server are in different regions, users can experience a delay. Ensure that your DNS server is not delegated to a sub domain.

## Bring your own phone number via direct routing

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Phone numbers**.

1. Select **Advanced** on the menu.

1. Select **Add Number** for **Bring your own number via Azure Direct Routing**.

1. In the **Add your own phone number** dialog, enter the following details.
    - **Phone number**: Indicates the phone number that you own and have configured in your SBC.
    - **Carrier**: Indicates the carrier to which the phone number belongs. If the carrier doesn’t exist yet, you can create a new record.
    - **Country/Region**: Select the country or region the phone number belongs to.
    - **Number type**: Select whether toll-free or a local phone number.
    - **Calling plans**: Select whether you can make or receive calls on the phone number.
        > [!Note]
        > SMS is not supported with direct routing.

1. Select **Add number**.

The new phone number will be displayed in the **Phone numbers** list and is ready for setup. You can now [connect it to a voice workstream](voice-channel-inbound-calling.md), [configure outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling), or even [assign it to a customer service representative](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-representatives).

## SBC best practices

-	For Microsoft Teams and Azure Communication Services direct routing, you might use the same port number, but you must use a different fully qualified domain name (FQDN).
- To avoid call timeout, ensure that the following settings for Secure Real-time Transport Protocol (SRTP) are configured:
  - Reset SRTP Upon Re-key = Disable
  - Generate SRTP Keys = Only if Required
- Ensure that you have sufficient transcoding licenses if your service provider and Azure Communication Services don't support the same codec.

  
### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
