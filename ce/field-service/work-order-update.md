---
title: AI-powered work order update (preview)
description: Update work orders with the help of Copilot in Dynamics 365 Field Service.
ms.date: 11/12/2024
ms.topic: how-to
author: JonBaker007
ms.author: jobaker
ms.reviewer: mhart
ms.custom:
  - bap-template
ms.collection: bap-ai-copilot 
---

# AI-powered work order update (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

With the help of Copilot in Dynamics 365 Field Service, technicians can update work orders in the new user experience of the Field Service mobile app. This AI-powered feature allows frontline workers describe work performed in natural language using standard text or speech-to-text capabilities. Based on their input, Copilot recommends updates to fields on the work order, and updates them after confirmation.  

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The work order update feature adheres to [responsible AI guidelines](faqs-work-order-update.md) and avoids information that violates certain restrictions.

## Prerequisites

- The feature is disabled by default for environments in the United Kingdom. An administrator must [enable it](#enable-copilot-to-update-work-order). For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

- You must have a paid Field Service environment. Copilot isn't available in trial environments.

- You must [update your environment](update-field-service.md) at least to the latest 2023 wave 2 build.

- You [enabled the new mobile experience](mobile/set-up-field-service-mobile.md).

## Enable Copilot to update work order

A user with administrator permissions can enable this feature. Open the **Field Service Mobile** app module and change to the **Settings** area. Go to **Mobile settings** > **Features** and enable the **Copilot for New Mobile Experience** toggle.

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

Open a booking in the new mobile user experience and select the Copilot icon. Select the Update option to start describing your update.

:::image type="content" source="media/copilot_portrait.png" alt-text="Mobile device showing the Copilot control with options to Summarize and Update work orders.":::

Review the suggested updates and confirm them as you see fit.
