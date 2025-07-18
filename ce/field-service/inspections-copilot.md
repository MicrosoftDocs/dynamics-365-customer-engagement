---
title: Create inspections with Copilot
description: Learn how to create inspections from existing documents with Copilot in Dynamics 365 Field Service.
ms.date: 04/30/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
ms.collection: bap-ai-copilot
---

# Create inspections with Copilot (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Service organizations often have numerous procedures, forms, and checklists stored in various formats like paper or PDF files. With Copilot in Field Service, makers can quickly digitize these documents and integrate them into Field Service work orders.

Copilot converts the uploaded documents into draft inspection templates that can be edited and published for technicians to fill in when completing work order tasks in the Field Services mobile app.

> [!VIDEO c1acf14d-6352-4621-b039-150dd4e96b38]

> [!IMPORTANT]
>
> - This is a preview feature.
> - Preview features aren't meant for production use and may have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback.
> - Users can provide feedback for inspection builder by default. Environment administrators can switch the feedback mechanism on or off for each individual environment from the organization table. The tenant-level Copilot feedback setting in Power Platform admin center currently has no effect on this feature. To make sure user feedback is disabled across a tenant, you must switch it off for each environment.
> - This feature is not currently available for Power Platform or Dynamics 365 environments that are hosted in the United Kingdom and Italy.

## Enable the inspection builder

To enable this feature for users in a environment, an administrator has to enable it.

1. In Dynamics 365 Field Service, change to the **Settings** area.

1. Go to **Field Service Settings** > **Features** > **Copilot in Field Service**.

1. Turn on  **Create inspection templates (Preview)**.

## Create a new inspection template with Copilot

1. In Dynamics 365 Field Service, change to the **Settings** area.

1. Go to **Work Orders** > **Inspection Templates** and select **Create with Copilot**.

1. Choose if you want to **Create from images** or **Create from PDF**.

   :::image type="content" source="media/inspection-create-copilot.png" alt-text="Screenshot of the Create with Copilot option for Field Service inspections.":::

1. Select the images or PDF file to upload. You can add up to three images or PDFs with up to three pages. Copilot then converts your content to a draft inspection.

1. Review the draft inspection and adjust as you see fit. For more information about inspection questions and options, see [Add inspections to work orders](inspections.md).

1. Save the inspection and add the inspection to a [service task type](inspections.md#associate-the-inspection-to-a-service-task-type) or [work order](inspections.md#add-the-inspection-to-a-work-order).

Similar to manually created inspections, technicians can now complete the surveys when completing a job.

## Responsible AI

For more information, see [FAQ about creating inspection templates with Copilot in Field Service (preview)](faqs-inspection-designer.md).
