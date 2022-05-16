---
title: "Connect to Azure Communication Services | MicrosoftDocs"
description: "Get an overview about connecting to Azure Communication Services. The article also includes procedures to sync from Azure and disconnect from Azure Communication Services."
ms.date: 05/09/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

The voice channel in Omnichannel for Customer Service is built over Azure Communication Services. This capability lets you provision phone numbers for your business by connecting to Azure Communication Services. However, to acquire phone numbers, you must first establish connection with Azure Communication Services. You can do this in the following ways:

- [Quickstart: Connect to a new Azure resource](voice-channel-connect-new-resource.md)
- [Advanced: Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)

You can also [import phone numbers](#sync-from-azure) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md).

> [!Note]
> 
> - After you've connected to a resource in a Dynamics 365 environment, the phone numbers purchased via the resource that are linked to the Dynamics 365 environment can't be transferred or migrated to another environment.
> - One Dynamics 365 organization is mapped to one Azure Communication Services resource.

## Sync from Azure

You can import phone numbers that you purchased or acquired earlier via Azure Communication Services resources into Omnichannel for Customer Service. 

**To sync from Azure**

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    - In the site map, select **Phone numbers** in **General settings**.

2. Select **Advanced** on the menu.

3. Select **Sync** for **Sync from Azure**. A dialog requesting you to confirm the sync action is displayed.
4. Select **Sync**.

   After you perform the sync, all the phone numbers that were acquired previously are listed on the **Phone numbers** page with the numbers that have been acquired in Omnichannel for Customer Service.
 
## Disconnect from Azure Communication Services resource

If you're no longer using an Azure Communication Services resource or want to connect to a different resource, you can disconnect the current resource, and later reconnect to a new or existing resource by selecting the **Get started** button.

To permanently release or remove one or more phone numbers from your organization, see [Release phone numbers](voice-channel-manage-phone-numbers.md#release-phone-numbers).

> [!Important]
> When you disconnect a resource, all phone numbers associated with it are also released from Dynamics 365; therefore, disconnect a resource only when you no longer need it.

**To disconnect from an Azure Communication Services resource**

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Phone numbers** in **General settings**.

1. Select **Advanced** on the menu. The **Manage Azure Communication Services** dialog opens.
2. Select **Disconnect** for **Disconnect from Azure**. A dialog requesting you to confirm the disconnection is displayed. 
3. Select **Disconnect** again.
   Any phone numbers associated with the resource will no longer be displayed on the **Phone numbers** page.

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect to a new Azure resource](voice-channel-connect-new-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
