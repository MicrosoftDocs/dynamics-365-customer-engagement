---
title: "Connect to Azure Communication Services | MicrosoftDocs"
description: "Get an overview about connecting to Azure Communication Services. The article also includes procedures to sync from Azure and disconnect from Azure Communication Services."
ms.date: 08/02/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The voice channel in Omnichannel for Customer Service is built over Azure Communication Services. This capability lets you provision phone numbers for your business by connecting to Azure Communication Services. However, to acquire phone numbers, you must first establish connection with Azure Communication Services. You can do this in the following ways:

- [Quickstart: Connect using a new Azure resource](voice-channel-connect-new-resource.md)
- [Advanced: Connect using an existing Azure resource](voice-channel-connect-existing-resource.md)

You can also [import phone numbers](voice-channel-sync-from-acs.md) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md).

> [!Note]
>
> - After you've connected to a resource in a Power Platform environment, the phone numbers purchased via the resource that are linked to the Power Platform environment can't be transferred or migrated to another environment.
> - One Dynamics 365 organization is mapped to one Azure Communication Services resource.
> - We recommend that you [test your network](https://azurecommdiagnostics.net) before connecting to Azure Communication Services.

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Connect using an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Import phone numbers](voice-channel-sync-from-acs.md)   
[Disconnect from Azure Communication Services](voice-channel-disconnect-from-acs.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
