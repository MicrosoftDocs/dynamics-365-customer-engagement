---
title: Enable self-service settings
description: Enable self-service settings for customer actions in conversations to help agents understand customer issues and provide personalized service.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/18/2023
---

# Enable self-service settings for customer actions in a conversation summary

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability.md)]

The self-service feature displays information about the recent actions that a customer performs before starting a conversation with an agent. This information helps agents understand customer issues and provide a personalized service for enhanced customer satisfaction.

The data about the recent actions is stored in an entity for the conversation that has been closed. A record is created for each self-service action and [action type](../use/oc-customer-summary.md#view-self-service). To learn more, see [msdyn_visitorjourney Entity Reference](../develop/reference/entities/msdyn_visitorjourney.md).

Enabling the self-service feature is a two-step process as follows:
1. Add a code snippet in the self-service portal that is configured for your organization. For the sample code and to learn more, see [Pass self service history as context](../develop/reference/methods/setContextProvider.md#pass-customers-self-service-as-context).
2. Update the settings in the Customer Service admin center or Contact Center admin center app.

## Enable self service

You can enable the self service feature in the Customer Service admin center or Contact center admin center app.

1. Add the code snippet in the customer self-service portal.

1. In the site map of admin center, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.

1. In the **Self service** section, select **Manage**. The **Omnichannel Configuration . Self service settings** page is displayed.      

1. Set the **Self service** toggle to **Yes**.

   > [!div class='mx-imgBorder']
   > ![Enable self service.](../media/enable-self-service.png "Enable self service")
 
1. Select **Save**. The **Self service** tab will appear for the agent when a chat is started with a customer.

### Related information

[Self service](../use/oc-customer-summary.md#view-self-service)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
