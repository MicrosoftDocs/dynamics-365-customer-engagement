---
title: Use Copilot in the Dynamics 365 Field Service web application
description: Learn how to use Copilot to summarize records, catch up on recent changes, and prepare for onsite jobs.
ms.date: 07/31/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: JonBaker007
ms.author: jobaker
ms.reviewer: v-wendysmith
ms.collection: bap-ai-copilot
ms.custom: ignite-2024
---

# Use Copilot in the Dynamics 365 Field Service web application

Copilot is a next-generation AI assistant that helps you be more productive and efficient in your daily work the Dynamics 365 Field Service web app. Copilot can summarize information about your work order and service accounts, help you catch up on recent changes to your records, prepare for onsite visits, and answer questions about related information. It has a chat interface that dispatchers and technicians can use to interact with Copilot in natural language. Copilot comes with the Dynamics 365 Field Service web app, no other license required.

## Prerequisites

An administrator has to enable the copilot feature for all users in the environment from the Power Platform admin center. For more information, see [Enable copilot for model-driven apps feature for your environment](/power-apps/maker/model-driven-apps/add-ai-copilot#enable-copilot-for-model-driven-apps-feature-for-your-environment).

## Open Copilot

To open the copilot pane, select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the app header.

Select the icon again to minimize the copilot pane.

:::image type="content" source="media/copilot-side-pane-web.svg" alt-text="Screenshot of Copilot in Field Service answering questions of a user in the Field Service web app.":::

## Chat with Copilot

You can ask Copilot questions in natural language about the data and information stored in the system. When you start a new chat session in the copilot pane, you find a couple of example scenarios to get started quickly.

:::image type="content" source="media/copilot-side-pane-prompt-guide.png" alt-text="Screenshot of the copilot pane with prompt suggestions and callouts.":::

Alternatively, you can select **View Prompts** in the side pane to see a library of predefined prompts that get copilot to work for you quickly. For example:

- List work orders for {service account name}.
- Who is booked for work order {work order number}?
- What are the products used on work order {work order number}?

## Customize Copilot chat (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Tailor the copilot pane for your business needs by using the customization capabilities of Copilot Studio. Enrich the copilot chat user experience with more knowledge from your public website, key company files, or company Sharepoints. Add more topics and customize them to use various trigger types or initiate actions like flows, connectors, and Dataverse plug-ins. Learn more at [Customize Copilot chat using Copilot Studio (preview)](/power-apps/maker/model-driven-apps/customize-copilot-chat).

The out-of-the-box Field Service app module includes a preconfigured agent for the Copilot chat called *Copilot in Power Apps - Field Service*. For an example of customizing Copilot chat, go to [Streamline inventory visibility in Field Service](/dynamics365/guidance/resources/field-service-streamline-inventory-visibility).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Region availability and languages supported

You might need to allow data movement across regions for Generative AI features as a prerequisite for running copilot in Power Apps. This step is especially important if your organization and your environment are in different regions. For more information, see [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).

For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## See also

- [Enable copilots and generative AI features](/power-platform/admin/geographical-availability-copilot)
- [Add copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-ai-copilot)
- [FAQ for Copilot in model-driven apps](/power-apps/maker/common/faqs-copilot-model-driven-app)
