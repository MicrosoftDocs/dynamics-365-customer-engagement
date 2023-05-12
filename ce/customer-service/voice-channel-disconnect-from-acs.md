---
title: "Disconnect from Azure Communication Services resource | MicrosoftDocs"
description: "This article explains how you can disconnect an Azure resource from Azure Communication Services resource."
ms.date: 06/09/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Disconnect from Azure Communication Services resource

If you're no longer using an Azure Communication Services resource or want to connect to a different resource, you can disconnect the current resource, and later reconnect to a new or existing resource by selecting the **Get started** button.

To permanently release or remove one or more phone numbers from your organization, see [Release phone numbers](voice-channel-manage-phone-numbers.md#release-phone-numbers).

> [!Important]
> When you disconnect a resource, all phone numbers associated with it are also released from Dynamics 365; therefore, disconnect a resource only when you no longer need it.

**To disconnect from an Azure Communication Services resource**

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.   
    2. Select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    In the site map, select **Phone numbers** in **General settings**.
2. Select **Advanced** on the menu. The **Manage Azure Communication Services** dialog opens.
3. Select **Disconnect** for **Disconnect from Azure**. A dialog requesting you to confirm the disconnection is displayed. 
4. Select **Disconnect** again.
   Any phone numbers associated with the resource will no longer be displayed on the **Phone numbers** page.

### See also
 
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Import phone numbers](voice-channel-sync-from-acs.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

