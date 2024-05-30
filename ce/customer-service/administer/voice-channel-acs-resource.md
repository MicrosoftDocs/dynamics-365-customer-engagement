---
title: Connect to Azure Communication Services
description: Learn how to connect to Azure Communication Services by using a new or existing resource to configure the voice channel.
ms.date: 05/31/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/29/2023
---

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The voice channel in Omnichannel for Customer Service is built over Azure Communication Services. This capability lets you provision phone numbers for your business by connecting to Azure Communication Services. However, to acquire phone numbers, you must first establish connection with Azure Communication Services. You can this in the following ways:

- Connect using a new Azure resource
- Connect using an existing Azure resource

 You can also [import phone numbers](voice-channel-sync-from-acs.md) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md).

> [!Note]
>
> - After you've connected to a resource in a Power Platform environment, the phone numbers purchased via the resource that are linked to the Power Platform environment can't be transferred or migrated to another environment.
> - You can't reuse Azure Communication Services resources across multiple instances. Map one Omnichannel for Customer Service instance only with one Azure Communication Services resource for optimal performance and to avoid issues.
> - We recommend that you [test your network](https://azurecommdiagnostics.net) before connecting to Azure Communication Services.

## Next Steps

[Connect to Azure resource](config-acs-voice.md)  

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Connect using an existing Azure resource](voice-channel-connect-new-resource.md)  
[Import phone numbers](voice-channel-sync-from-acs.md)   
[Disconnect from Azure Communication Services](voice-channel-disconnect-from-acs.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
