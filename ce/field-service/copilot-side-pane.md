---
title: Use Copilot in the Dynamics 365 Field Service web application
description: Learn how to use Copilot to summarize records, catch up on recent changes, and prepare for onsite jobs.
ms.date: 03/22/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: mhart
ms.collection: bap-ai-copilot
---

# Use Copilot in the Dynamics 365 Field Service web application (preview)

[!INCLUDE [preview-disclaimer](../includes/public-preview-banner.md)]

Copilot is a next-generation AI assistant that helps you be more productive and efficient in your daily work the Dynamics 365 Field Service web app. Copilot can summarize information about your work order and service accounts, help you catch up on recent changes to your records, prepare for onsite visits, and answer questions about related information. It has a chat interface that dispatchers and technicians can use Copilot through conversation in natural language.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

An administrator has to enable the copilot feature for all users in the environment from the Power Platform admin center. For more information, see [Enable copilot for model-driven apps feature for your environment](/power-apps/maker/model-driven-apps/add-ai-copilot#enable-copilot-for-model-driven-apps-feature-for-your-environment).

## Open Copilot

1. Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the right side of your app. Select the icon again to minimize the copilot pane.

1. Select the sparkle icon (:::image type="icon" source="../sales/media/sparkle-icon.png" border="false":::) to get a list of suggested requests, or *prompts*, that Copilot can help you with.

## Chat with Copilot

Use predefined prompts to get the most out of Copilot. The following list provides a quick reference to predefined prompts.

- List work orders for {service account name}.
- Summarize work order {work order number}.
- Who's the main contact for {service account name}?
- When was the asset {asset name} last serviced?  

## Region availability and languages supported

To use this capability, your environment must be in the US region and have its language set to en-US.

You must allow data movement across regions for Generative AI features as a prerequisite for running copilot in Power Apps. This step is especially important if your organization and your environment are in different regions. For more information, see [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).

## See also

- [Enable copilots and generative AI features](/power-platform/admin/geographical-availability-copilot)
- [Add copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-ai-copilot)
- [FAQ for Copilot in model-driven apps](/power-apps/maker/common/faqs-copilot-model-driven-app)