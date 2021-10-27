---
title: "Integrate third-party IVR with the voice channel: Azure Direct Routing | MicrosoftDocs"
description: "Use this topic to understand how you can integrate third-party IVRs with the Omnichannel for Customer Service voice channel and set up contextual communication via Azure Direct Routing."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Integrate third-party IVRs with voice channel: Azure Direct Routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Azure Direct Routing lets you integrate third-party IVRs with Omnichannel for Customer Service voice channel, and perform a contextual communication between them.

Before you proceed with this section, you must be familiar with the following:
- [Azure direct routing infrastructure requirements](../../azure/communication-services/concepts/telephony-sms/direct-routing-infrastructure)
- [Session Border Controllers and voice routing](../../azure/communication-services/concepts/telephony-sms/direct-routing-provisioning)

Follow these steps to set up contextual communication between the voice channel and third-party IVRs.

1. Set up Azure Direct Routing to connect Session Border Controllers (SBCs) linked to the third-party IVR to Dynamics 365. 

2. Register the phone number that’s assigned to the third-party IVR into Dynamics 365 by [bringing your own number](voice-channel-bring-your-own-number.md).  

3. At the point of transfer in the IVR, issue a SIP (Session Initiation Protocol) REFER request to the Azure Communication Services resource. This will transfer the call to the Azure resource that's connected to Dynamics 365. 

4. To include context in the payload, populate the SIP UUI (User-to-User Information) header with context data, as follows: "userToUserInformation": "param1=value1;param2=value2".  

5. Create context variables following the same names as the SIP UUI header. The SIP UUI payload is automatically converted into context data that can be used in the voice channel for routing and showing relevant information to the agent.

    a. Go to the voice workstream > **Context variables** > **Add context variables**.
    
    b. Ensure the names of the context variables match exactly with the param names in the SIP UUI header.
  
### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-create-new-use-existing-resource.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
