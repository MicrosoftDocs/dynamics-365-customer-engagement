---
title: "Integrate a third-party IVR system with voice channel | MicrosoftDocs"
description: "Use this article to understand how you can integrate third-party IVR systems with Omnichannel for Customer Service voice channel and set up contextual call transfer via Azure direct routing."
ms.date: 12/27/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: gandhamm
ms.author: mgandham
---

# Integrate a third-party IVR system with voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[Azure direct routing (preview)](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing) lets you integrate a third-party interactive voice response (IVR) system with Omnichannel for Customer Service voice channel, and perform a contextual call transfer between them.

## Prerequisites

Before you proceed with this section, you must be familiar with the following concepts.
- [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)
- [Azure direct routing infrastructure requirements](/azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)
- [Session Border Controllers and voice routing](/azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

## Set up contextual call transfer using Azure direct routing

This section lists the high-level steps you must perform to enable contextual call transfer between a third-party IVR system and the voice channel.

1. Set up Azure direct routing and connect a Session Border Controller (SBC), which is linked to the third-party IVR system, with Azure Communication Services resource, which is in turn connected to Omnichannel for Customer Service.


2. Follow the steps in the section [Bring your own phone number](voice-channel-bring-your-own-number.md) to register the phone number that’s assigned to the third-party IVR system with Omnichannel for Customer Service.

3. To transfer a call from the IVR system, issue an SIP (Session Initiation Protocol) INVITE request to the Azure Communication Services resource that'll transfer the call to the Azure resource that's connected to Omnichannel for Customer Service.

4. To include context in the payload, populate the SIP UUI (User-to-User Information) header with context data: "User-to-User": "param1=value1;param2=value2". For SIP UUI header with context data, the following formats are supported:

      - Plain text or string. Seperate the key value pairs by a semicolon.
         For example, <i>"sipkey1=sipval1;sipkey2=sipval2"</i>
      - Hex encoding format. Specify the encoding key word. For example,
        <i> "7369706B6579313D73697076616C313B7369706B6579323D73697076616C32;encoding=hex"</i>
       
5. Create context variables with the same names as the SIP UUI header.

    1. In Customer Service admin center, go to **Customer support** > **Workstreams**. If you're using Omnichannel admin center, go to **General settings** > **Workstreams**.
       A list of workstreams including voice workstreams is displayed.
    2. Select a voice workstream and then select **Edit** to configure the workstream.
    3. In the **Advanced settings** area, select **Add context variable**.
    4. In the **Edit** dialog that opens, select **Add**, and then select **Add context variable**.
    5. Enter the values for **Name** and **Type**. Ensure that the names of the context variables match exactly with the param names in the SIP UUI header.
    6. Select **Create**.
    
    The SIP UUI payload is automatically converted into context data that can be used in the voice channel for routing and to show relevant information to the agent.

You can now call the phone number assigned to the third-party IVR system and achieve a contextual call transfer with the voice channel.

> [!NOTE]
> Call record and transcriptions from the third-party IVR call with the customer aren't available for agents.


### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
