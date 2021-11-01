---
title: "Integrate third-party IVR systems with voice channel | MicrosoftDocs"
description: "Use this topic to understand how you can integrate third-party IVR systems with the Omnichannel for Customer Service voice channel and set up contextual call transfer via Azure direct routing."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Integrate third-party IVR systems with voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[Azure direct routing (preview)](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing) lets you integrate third-party interactive voice response (IVR) systems with Omnichannel for Customer Service voice channel, and perform a contextual call transfer between them.

## Prerequisites

Before you proceed with this section, you must be familiar with the following:
- [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)
- [Azure direct routing infrastructure requirements](/azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)
- [Session Border Controllers and voice routing](/azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

## Set up contextual call transfer using Azure direct routing

This section lists the high level steps you must  perform to enable contextual call transfer between third-party IVRs and the voice channel.

**To set up contextual call transfer**

1. Set up Azure direct routing and connect a Session Border Controller (SBC), that’s linked to the third-party IVR, with Azure Communication Services resource, that’s in turn connected to the Omnichannel for Customer Service.

2. Follow the steps in the section [Bring your own phone number](voice-channel-bring-your-own-number.md) to register the phone number that’s assigned to the third-party IVR with Omnichannel for Customer Service.

3. To initiate a call transfer from the IVR, issue an SIP (Session Initiation Protocol) REFER request to the Azure Communication Services resource. This will transfer the call to the Azure resource that's connected to Omnichannel for Customer Service.

4. To include context in the payload, populate the SIP UUI (User-to-User Information) header with context data, as follows: "userToUserInformation": "param1=value1;param2=value2".  

5. Create context variables with the same names as the SIP UUI header as follows:

    1. In the site map of Omnichannel admin center, under **General settings**, select **Workstreams**.
       A list of workstreams including voice workstreams is displayed.
    2. Select a voice workstream and then select **Edit** to configure the workstream
    3. In the **Advanced settings** area, select **Add context variable**.
    4. In the **Edit** dialog that opens, select **Add**, and then select **Add context variable**.
    5. Enter the values for **Name** and **Type**. Ensure that the names of the context variables match exactly with the param names in the SIP UUI header.
    6. Select **Create**.
    
        The SIP UUI payload is automatically converted into context data that can be used in the voice channel for routing and to show relevant information to the agent.

You can now call the phone number assigned to the third-party IVR and achieve a contextual call transfer with the Omnichannel for Customer Service voice channel.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-create-new-use-existing-resource.md)  
[Bring your own phone numbers](voice-channel-bring-your-own-number.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
