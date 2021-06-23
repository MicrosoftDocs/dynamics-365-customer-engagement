---
title: "Configure and use custom channel (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Provides information on how to install custom channel from AppSource to your Dynamics 365 Marketing instance."
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Configure and use custom channel

This step is typically performed by administrators of your Dynamics 365 Marketing instance.

To configure a custom channel in your instance of Dynamics 365 Marketing, administrators can:

1. Search for the required custom channel on [Microsoft AppSource](https://appsource.microsoft.com).
2. For a custom channel, select **Get it now** or **Free trial** depending on the pricing of the custom channel.
3. If you are signed into AppSource using your work or school account that you have registered with Microsoft while signing up for Dynamics 365 Marketing, you will be prompted to accept the license agreement for the custom channel. Otherwise, you will be prompted to sign in using your work or school account. After signing in, you will be prompted to accept the license agreement for the custom channel. Click **Continue** to accept and proceed.
4. The next page will let you select the instance where you want to add the custom channel. Select the appropriate instance, select the check boxes to accept Microsoft legal terms and privacy notices, and click **Agree** to install.

Installing a custom channel installs a [managed solution](/powerapps/developer/common-data-service/introduction-solutions#managed-and-unmanaged-solutions) for the custom channel in your instance. After the custom channel is installed in your instance, users will see the new custom channel tile in their customer journey designer when they create a customer journey.

![Custom Content tiles](../media/marketing-custom-channel-tile.png)

For information about creating a customer journey, see the following topics in the Marketing User Guide:
- [Create a simple customer journey with email messaging](../../marketing/create-simple-customer-journey.md)
- [Create an interactive customer journey with conditions and signup](../../marketing/create-interactive-customer-journey.md)

### See also

[Remove custom channel](remove-custom-channel.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]