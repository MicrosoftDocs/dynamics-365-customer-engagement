---
title: Use Copilot in the Dynamics 365 Field Service web application
description: Learn how to use Copilot to summarize records, catch up on recent changes, and prepare for onsite jobs.
ms.date: 04/29/2026
ms.update-cycle: 180-days
ms.topic: how-to
author: JonBaker007
ms.author: jobaker
ms.reviewer: v-wendysmith
ms.collection: bap-ai-copilot
ms.custom: ignite-2024
---

# Use Copilot in the Dynamics 365 Field Service web application

Copilot is a next-generation AI assistant that helps you be more productive and efficient in your daily work in the Dynamics 365 Field Service web app. Copilot can summarize information about your work order and service accounts, help you catch up on recent changes to your records, prepare for onsite visits, and answer questions about related information. It has a chat interface that dispatchers and technicians can use to interact with Copilot in natural language. Copilot comes with the Dynamics 365 Field Service web app, no other license required.

## Prerequisites

Copilot is enabled by default in Dynamics 365 Field Service environments. If Copilot isn't available, an administrator can verify the setting in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). Learn more in [Add Copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-ai-copilot).

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

Tailor the copilot pane for your business needs by using the customization capabilities of Copilot Studio. Enrich the copilot chat user experience with more knowledge from your public website, key company files, or company SharePoints. Add more topics and customize them to use various trigger types or initiate actions like flows, connectors, and Dataverse plug-ins. Learn more at [Customize Copilot chat using Copilot Studio (preview)](/power-apps/maker/model-driven-apps/customize-copilot-chat).

The out-of-the-box Field Service app module includes a preconfigured agent for the Copilot chat called *Copilot in Power Apps - Field Service*. For an example of customizing Copilot chat, go to [Streamline inventory visibility in Field Service](/dynamics365/guidance/resources/field-service-streamline-inventory-visibility).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Region availability and languages supported

You might need to allow data movement across regions for Generative AI features as a prerequisite for running copilot in Power Apps. This step is especially important if your organization and your environment are in different regions. For more information, see [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).

For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## Resolve common Copilot issues

If Copilot isn't working as expected in your Field Service environment, check the following common causes.

### Copilot icon doesn't appear

- Copilot is enabled by default in Dynamics 365 Field Service environments. If the icon is missing, a maker might have disabled it at the app level. Learn more in [Add Copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-ai-copilot).
- Verify that the user has the required security role to access Copilot. Users need at least the **Field Service - Dispatcher** or **Field Service - Resource** role.

### Copilot isn't generating responses

- **Data Loss Prevention (DLP) policies** might block the required connectors. Verify that Dataverse and HTTP connectors aren't blocked for your environment. Learn more in [Manage data policies](/power-platform/admin/prevent-data-loss).
- **Data movement across regions** must be enabled if your tenant and environment are in different regions. Learn more in [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).
- Verify that the environment is in a [supported region](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

### Copilot provides incorrect or limited answers

- Copilot works with data the signed-in user has access to. Ensure that the user has the right permissions to view the records they're asking about.
- If Copilot doesn't recognize a prompt, try rephrasing it or select **View Prompts** for predefined prompt examples.

## Related information

- [Enable copilots and generative AI features](/power-platform/admin/geographical-availability-copilot)
- [Add copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-ai-copilot)
- [FAQ for Copilot in model-driven apps](/power-apps/maker/common/faqs-copilot-model-driven-app)
