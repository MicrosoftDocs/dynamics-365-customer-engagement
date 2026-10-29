---
title: Review the plan and generate service events (preview)
description: Maintenance plans in Dynamics 365 Field Service let you review inherited template values before generating service events. Learn how to adjust maintenance schedules and services per asset.
ms.date: 10/29/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
---

# Review the plan and generate service events

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Review an asset's maintenance plan after you apply a template to the asset. Make asset-specific changes before you generate the forecasted service events.  

Review an asset's maintenance plan at any time to review forecasted service events, make changes, and regenerate service events as necessary.  

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- [Apply a template to the asset](asset-maintenance-setup-maintenance-plan.md#apply-the-template-to-an-asset).

- For forecasting future usage-based maintenance dates, ensure the asset has [sufficient usable service meter units (SMU) history](asset-maintenance-service-history.md#prepare-smu-history-for-an-asset).

## Review and adjust the maintenance plan

1. In Field Service, select **Assets**.

1. Open the asset, select the **Maintenance** tab, and then select **View plan**.

1. Review the plan-level values inherited from the template and make any asset-specific changes.

1. From the maintenance plan, select the **Maintenance Schedules** tab.

1. Review each maintenance schedule and make any asset-specific changes. Learn more in [Asset maintenance schedule types](asset-maintenance-schedule-types.md) and [Add a maintenance schedule](asset-maintenance-setup-maintenance-plan.md#add-a-maintenance-schedule).

   - Expand each maintenance schedule to view its details. You can edit or delete a schedule.
   - Edit or delete a service within a schedule.
   - Add a new schedule.

1. Save the changes.

## Generate service events

A scheduled job runs once per day to evaluate maintenance plans. The daily job creates or updates eligible forecast service events and generates work orders for events that enter the configured work-generation window. The work-generation window is based on the [maintenance generation settings](asset-maintenance-install.md#configure-maintenance-generation-settings).

You can also generate service events manually.

### Generate service events manually

To evaluate a plan immediately instead of waiting for the next daily run, manually generate the service events. Manually generate service events after changing the maintenance plan to recalculate eligible forecast service events.

> [!NOTE]
> Regeneration doesn't change due dates that you manually override or details for work orders that are already generated.

1. Open the maintenance plan for the asset (**Assets** > **Maintenance** > **View plan**), and select **Generate occurrences** in the command bar.

   :::image type="content" source="media/asset-maintenance-assets-generate-occurrences.png" alt-text="Screenshot of an asset's maintenance plan highlighting the Generate occurrences button.":::

1. After the generation finishes, review the summary and select **OK**. Then, go back to the **Maintenance** tab of the asset. The system shows the service history and schedules under **Service events**.

   :::image type="content" source="media/asset-maintenance-assets-service-events.png" alt-text="Screenshot of the asset's Maintenance tab showing the generated service events." lightbox="media/asset-maintenance-assets-service-events.png":::

## Review forecast service events

Review the maintenance planned for an asset and make adjustments as needed.

1. From the **Maintenance** tab of an asset, review the planned and forecasted service events.

   - Use the agenda view for a chronological list of upcoming service events.
   - Use the calendar view to see service events for a specific day.
   - Use search to find specific service events.

1. To see the plan template and the maintenance schedule that generated a particular service event, select **More info**.

1. To take action on a service event, select the event and choose the appropriate option, such as overriding the due date or skipping the activity. Learn more in [Manage maintenance service events](asset-maintenance-manage-details.md).

## Stop generating work orders

To stop generating work orders for a service event, remove the event from the plan or move the asset outside the active window.

## Deactivate a maintenance plan

If you no longer want a maintenance plan for an asset, deactivate it. If you want to change to a different maintenance plan for an asset, first deactivate the current plan and then [apply a new template](asset-maintenance-setup-maintenance-plan.md#apply-the-template-to-an-asset).

1. In Field Service, select **Maintenance Plans**.

1. Select the maintenance plan you want to deactivate.

1. Select **Deactivate**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
