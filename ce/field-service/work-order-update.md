---
title: AI-powered work order update (preview)
description: AI-powered work order update helps technicians use Copilot in Dynamics 365 Field Service to update work orders using text or speech.
ms.date: 09/16/2026
ms.update-cycle: 180-days
ms.topic: how-to
author: JonBaker007
ms.author: jobaker
ms.reviewer: puneetsingh
ms.custom:
  - bap-template
ms.collection: bap-ai-copilot
---

# AI-powered work order update (preview)

<!--- Also update faqs-work-order-update.md and responsible-ai-overview.md--->

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The AI-powered work order update in Dynamics 365 Field Service helps technicians use text or speech to describe completed work in the new Field Service mobile app experience. Copilot recommends changes to work order fields and applies them after confirmation.  

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The work order update feature follows the [responsible AI guidelines](faqs-work-order-update.md) and avoids information that violates certain restrictions.

## Prerequisites

- For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

- You must have a paid Field Service environment. Copilot isn't available in trial environments.

- You [enabled the new mobile experience](mobile/set-up-field-service-mobile.md#refreshed-mobile-user-experience).

## Enable Copilot to update work orders

An administrator can enable this feature. Open the **Field Service Mobile** app module and change to the **Settings** area. Go to **Mobile settings** > **Features** and enable the **Work order update** toggle.

## Work order fields that the feature updates

Copilot can update the following fields on a work order from the new user experience in the mobile app:

- Booking status

- Booking times

- Work order service task completion

- Work order product quantity

- Work order product line status

- Work order service duration

- Work order service line status

## Open Copilot from the mobile app

Open a booking in the new mobile user experience and select the Copilot icon. Select the **Update** option to start describing your update.

:::image type="content" source="media/copilot-update.png" alt-text="Screenshot of a mobile device showing the Copilot control with options to Summarize and Update work orders.":::

Review the suggested updates and confirm them as you see fit.

## Related information

- [AI-powered work order update FAQ](faqs-work-order-update.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
