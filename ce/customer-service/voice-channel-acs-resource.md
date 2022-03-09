---
title: "Connect to Azure Communication Services | MicrosoftDocs"
description: "Use this topic to understand how to connect to Azure Communication Services using new or existing Azure resources."
ms.date: 03/11/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

The voice channel in Omnichannel for Customer Service is built over Azure Communication Services. This capability lets you provision phone numbers for your business by connecting to Azure Communication Services. However, to acquire phone numbers, you must first establish connection with Azure Communication Services. You can do this in the following ways:

- [Quickstart: Connect to a new Azure resource](voice-channel-connect-new-resource.md)
- [Advanced: Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)

You can import phone numbers that you previously provisioned or ported via your Azure Communication Services resource into Omnichannel for Customer Service. To do this, see [Sync from Azure](#sync-from-azure)

You can also connect your existing telephony infrastructure with Azure and bring in your existing carrier and phone numbers. To do this, see [Bring your own carrier](voice-channel-bring-your-own-number.md)

> [!Note]
> After you've connected to a resource in a Dynamics 365 environment, the phone numbers purchased via that resource that are linked to the Dynamics 365 environment can't be transferred or migrated to another environment.

### Sync from Azure

You can import phone numbers that you purchased or acquired earlier via Azure Communication Services resources into Omnichannel for Customer Service. To do this, select the **Sync from Azure** button.
This ensures that all of the phone numbers acquired previously display on the **Phone numbers** page along with the numbers acquired from within Omnichannel for Customer Service. 

### Disconnect from Azure Communication Services resource

If you're no longer using an Azure Communication Services resource or want to connect to a different resource, you can disconnect the current resource, and later reconnect to a new or existing resource by selecting the **Get started** button.

To permanently release or remove one or more phone numbers from your organization, see [Release phone numbers](voice-channel-manage-phone-numbers.md#release-phone-numbers).

> [!Important]
> Disconnecting a resource also releases any phone numbers associated with that resource from Dynamics 365; so, disconnect a resource only if you're sure you no longer need it.

**To disconnect from an Azure Communication Services resource**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Advanced**. The **Manage Azure Communication Services** dialog opens.
2. Select **Disconnect**. A dialog requesting you to confirm the disconnection is displayed. 
3. Select **Disconnect** again if you're sure you want to disconnect from the Azure Communication Services resource.
   You've now disconnected the resource from Omnichannel for Customer Service. Any phone numbers associated with the resource will no longer be displayed on the **Phone numbers** page in Customer Service admin center (preview) or Omnichannel admin center.

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect to a new Azure resource](voice-channel-connect-new-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
