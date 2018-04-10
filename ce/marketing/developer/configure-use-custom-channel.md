---
title: "Configure and use custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Provides information on how to install custom channel from AppSource to your Dynamics 365 instance."
ms.custom: ""
ms.date: 04/01/2018
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9dacec8b-7b41-4cc2-be2d-d30929627bfc
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Configure and use custom channel

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

This step is typically performed by administrators of your Dynamics 365 instance.

To configure a custom channel in your instance of Dynamics 365 for Marketing, administrators can:
1. Search for the required custom channel on [Microsoft AppSource](https://appsource.microsoft.com).
2. For a custom channel, select **Get it now** or **Free trial** depending on the pricing of the custom channel.
3. If you are signed into AppSource using your work or school account that you have registered with Microsoft while signing up for Dynamics 365, you will be prompted to accept the license agreement for the custom channel. Otherwise, you will be prompted to sign in using your work or school account. After signing in, you will be prompted to accept the license agreement for the custom channel. Click **Continue** to accept accept and proceed.
4. The next page will let you select the Dynamics 365 instance where you want to add the custom channel. Select the appropriate instance, select the checkboxes to accept Microsoft legal terms and privacy notices, and click **Agree** to install.

Installing a custom channel installs a [managed solution](../../developer/introduction-solutions.md#unmanaged-and-managed-solutions) for the custom channel in your Dynamics 365 instance. After the custom channel is installed in your Dynamics 365 instance, users will see the new custom channel tile in their customer journey designer when they create a customer journey.

![Custom Content tiles](../media/marketing-custom-channel-tile.png)

For information about creating a customer journey, see the following topics in the Marketing User Guide:
- [Create a simple customer journey with email messaging](../../marketing/create-simple-customer-journey.md)
- [Create an interactive customer journey with triggers and signup](../../marketing/create-interactive-customer-journey.md)

### See also

[Remove custom channel](remove-custom-channel.md)





  