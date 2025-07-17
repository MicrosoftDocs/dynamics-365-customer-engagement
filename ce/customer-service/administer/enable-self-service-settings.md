---
title: Enable self-service settings
description: Enable self-service settings for customer actions in conversations to help representatives understand customer issues and provide personalized service.
ms.date: 07/17/2025
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

The self-service feature displays information about the recent actions that a customer performs before starting a conversation with a customer service representative (service representative or representative). This information helps service representatives understand customer issues and provide a personalized service for enhanced customer satisfaction.

The data about the recent actions is stored in an entity for the conversation that has been closed. A record is created for each self-service action and [action type](../use/oc-customer-summary.md#view-self-service). Learn more in [Self service (msdyn_visitorjourney) table](../../developer/reference/entities/msdyn_visitorjourney.md).

## Prerequisites

Make sure that a developer has added a code snippet to retrieve the steps customers have done and [pass history as context](../develop/reference/methods/setContextProvider.md) in the self-service portal that is configured for your organization.

## Enable self service

You can enable the self service feature in the Copilot Service admin center app.

1. In the site map of admin center, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.

1. In the **Self service** section, select **Manage**. The **Omnichannel Configuration . Self service settings** page appears.    

1. Set the **Self service** toggle to **Yes**.

1. Select **Save**. The **Self service** tab appears for the representative when a customer starts a chat.

### Related information

[Self service](../use/oc-customer-summary.md#view-self-service)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
