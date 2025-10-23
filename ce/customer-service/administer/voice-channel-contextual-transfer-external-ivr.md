---
title: Integrate a non-Microsoft IVR system with voice channel
description: Use this article to understand how you can integrate non-Microsoft IVR systems with the voice channel and set up contextual call transfer via Azure direct routing.
ms.date: 05/15/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Integrate a non-Microsoft IVR system with voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing) lets you integrate a non-Microsoft interactive voice response (IVR) system with the voice channel, and perform a contextual call transfer between them.

## Prerequisites

Before you proceed with this section, you must be familiar with the following concepts.
- [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)
- [Azure direct routing infrastructure requirements](/azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)
- [Session Border Controllers and voice routing](/azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

## Set up contextual call transfer using Azure direct routing

This section lists the high-level steps you must perform to enable contextual call transfer between a non-Microsoft IVR system and the voice channel.

1. Set up Azure direct routing and connect a Session Border Controller (SBC), which is linked to the non-Microsoft IVR system, with Azure Communication Services resource, which is in turn connected to the application.

1. Follow the steps in the section [Bring your own phone number](voice-channel-bring-your-own-number.md) to register the phone number that’s assigned to the non-Microsoft IVR system with the application.

1. To transfer a call from the IVR system, issue an SIP (Session Initiation Protocol) INVITE request to the Azure Communication Services resource that will transfer the call to the Azure resource that's connected to th application.

1. To include context in the payload, populate the SIP UUI (User-to-User Information) header with context data: "User-to-User": "param1=value1;param2=value2". For SIP UUI header with context data, the following formats are supported:

      **Plain text**: Key/value pairs separated by semicolons  
      - Example: User-to-User: `sipkey1=sipval1;sipkey2=sipval2 `

      **Hex with explicit encoding**: Hex encode the ASCII payload and add ;encoding=hex  
      - Example: User-to-User: `7369706B6579313D73697076616C313B7369706B6579323D73697076616C32;encoding=hex`

      **Hex with protocol discriminator**: Hex encode the payload and append ;pd=4   
      - Example: User-to-User: `3530303131323233333434353b363738393b3132;pd=4`
 
1. Create context variables with the same names as the SIP UUI header.

    1. In Copilot Service admin center, go to **Customer support** > **Workstreams**. A list of workstreams including voice workstreams is displayed.
    1. Select a voice workstream and then select **Edit** to configure the workstream.
    1. In the **Advanced settings** area, select **Add context variable**.
    1. In the **Edit** dialog that opens, select **Add**, and then select **Add context variable**.
    1. Enter the values for **Name** and **Type**. Ensure that the names of the context variables match exactly with the param names in the SIP UUI header.
    1. Select **Create**.
    
    The SIP UUI payload is automatically converted into context data that can be used in the voice channel for routing and to show relevant information to the customer service representative.

You can now call the phone number assigned to the non-Microsoft IVR system and achieve a contextual call transfer with the voice channel.

> [!NOTE]
> Call record and transcriptions from the non-Microsoft IVR call with the customer aren't available for service representatives.

### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
