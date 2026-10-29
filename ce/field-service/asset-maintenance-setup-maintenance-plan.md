---
title: Create maintenance plan templates for assets (preview)
description: Maintenance plan template guidance explains how to build reusable schedules for similar assets and apply them to customer assets.
ms.date: 10/28/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom: 
    - ai-gen-docs-bap
    - ai-seo-date: 09/25/2026
ai-usage: ai-assisted
---

# Create a maintenance plan template (preview) 

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Use a maintenance plan template to define a reusable maintenance strategy for similar assets in Dynamics 365 Field Service. A template combines maintenance schedules, services, and work order defaults for a specific asset category, manufacturer, model, or SKU.

After you create a template, apply it to an asset to create an asset-specific maintenance plan. The plan uses the asset’s in-service date, time zone, and service meter unit (SMU) history to forecast maintenance and generate future service events.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Start maintenance plan template

A template is optional. You can create a maintenance plan directly for an asset and add its maintenance schedules, services, and positions manually.

1. In the Field Service app, switch to the **Settings** area.

1. Under **Service Delivery**, select **Maintenance Plan Templates** and then select **New**.

1. On the **General** tab, enter a name for the template and an optional description.

1. To help identify and filter the assets for which the template is intended, select an **Asset Category**, **Manufacturer**, or **Model** under **Criteria**. This step is optional. The system doesn’t enforce these criteria when applying the template to an asset.

1. Enter the values that you want to include in the generated work orders under **Maintenance Work Order Defaults**:

   - Service Account
   - Billing Account
   - Price List
   - Sales Tax Code
   - Taxable

1. Select **Save**.

## Add a maintenance schedule

Add a maintenance schedule to define when and how often maintenance should occur for the assets associated with the template. You can create multiple schedules if needed to cover different maintenance intervals or types.

1. On the maintenance plan template, select the **Maintenance Schedules** tab.

1. Select **Add Maintenance Schedule**.

   :::image type="content" source="media/asset-maintenance-schedule.png" alt-text="Screenshot of the Add maintenance schedule form showing calendar, usage milestone, and sequential service pattern options." lightbox="media/asset-maintenance-schedule.png":::

1. Enter the following information:

   - **Schedule name**: Name for the schedule such as *Monthly service*, *Engine rebuild*, *Inspections*.

   - **Work order creation lead times (days)** (optional): Number of calendar days in advance to create the work order. Leave blank to use the organization lead time set in [Configure maintenance generation settings](asset-maintenance-install.md#configure-maintenance-generation-settings).

   - **Forecast horizon (days)** (optional): Number of calendar days the system creates service events. To give planners time to review forecast events before work orders are created, set the forecast horizon greater than the **Work order creation lead times (days)**. Leave blank to use the organization forecast horizon set in [Configure maintenance generation settings](asset-maintenance-install.md#configure-maintenance-generation-settings).

1. Choose the type of schedule. Learn more in [Asset maintenance schedule types](asset-maintenance-schedule-types.md).

   | Schedule type | Use it for | Example |
   | --- | --- | ------------------ |
   | Calendar recurrence | Maintenance that follows a fixed calendar schedule. | Every Thursday of the month. |
   | Total life or usage milestone | Maintenance based on the total life or total usage of the asset. | Every 3,000 SMU or two years in service. |
   | Sequential service pattern | Maintenance intervals that repeat relative to the preceding service in a sequence. | Every 500 SMU from the preceding service. |

1. Select **Next**.

### Calendar recurrence

For each type of calendar recurrence schedule, perform the following steps.

1. Select **Add service**.

1. Enter the following information for the service to include in the generated work orders:

   - **Service Name**: Name for the service such as *Monthly service* or *Quarterly service*.

   - **Work Order Type**: The [category of work](create-work-order-types.md) to use for the service. For example, *Maintenance*.

   - **Primary Incident Type**: The [specific issue or request of work](incident-type-overview.md) that the service addresses.

1. Repeat the previous steps for each service. For example, set up a monthly schedule and a quarterly schedule as separate services.

   :::image type="content" source="media/asset-maintenance-schedule-calendar-service.png" alt-text="Screenshot showing the Services page with monthly and quarterly maintenance services configured." lightbox="media/asset-maintenance-schedule-calendar-service.png":::

1. Select **Next**.

1. Enter the schedule details to determine how often and when to generate work orders for service. You can specify the frequency, start date, and any exceptions to the schedule.

1. To establish the cadence of work, add steps assigning a service to each step. To skip a particular occurrence, select **Add step** and then select **No service** for that occurrence.

   For example, select the monthly service for the first and second steps in the sequence. Select the quarterly service for the third step.

   :::image type="content" source="media/asset-maintenance-schedule-calendar-1.png" alt-text="Screenshot of a calendar recurrence schedule in a maintenance plan template." lightbox="media/asset-maintenance-schedule-calendar-1.png":::

1. Select **Next**.

1. Enter the number of cycles you want to preview. The preview shows how the schedule plays out over multiple iterations before you save it.

1. Go back and make any necessary changes.

1. When you're satisfied with the schedule, select **Save schedule**.

1. [Add any other schedules](#add-a-maintenance-schedule) to this maintenance plan template. Then, select **Save & Close**.

### Total life or usage milestone

For each type of maintenance based on the total life or total usage of the asset, perform the following steps.

1. Select **Add service**.

1. Enter the following information for the service to include in the generated work orders:

   - **Service Name**: Name for the service such as *Brake service*.

   - **Work Order Type**: The [category of work](create-work-order-types.md) to use for the service. For example, *Maintenance*.

   - **Primary Incident Type**: The [specific issue or request of work](incident-type-overview.md) that the service addresses.

1. Repeat the previous steps for each service.

1. Select **Next**.

1. Determine if the service is recurring or one-time.

   - If the service is recurring, select **Recurring** and go to the next step.

   - If the service is one-time:

     - Select whether the service applies at a **Total SMU** and indicate the value or **After time in service** and indicate the number of days, months, or years.
     - To trigger based on which interval comes first, select both **Total SMU** and **After time in service**.
     - Skip the next step.

1. For recurring service, enter the following details.

   - **Every SMU**: Specifies the recurring SMU interval between maintenance occurrences. For example, at 30,000 SMU.

   - **Every time interval**: Indicates the amount of time that must pass after the asset is in service before the service is performed. For example, after 36 months in service.

   - **Stop**: Indicates the point at which the service should no longer be performed. For example, never or after 2 occurrences.

   - **Start point** (optional): Defines when the first maintenance milestone occurs. Use **Start SMU** to specify the starting SMU value, **Start time** to specify the starting time, or both based on which interval occurs first. Leave blank to start at the first interval.

   :::image type="content" source="media/asset-maintenance-schedule-total-life.png" alt-text="Screenshot of a total life or usage schedule in a maintenance plan template." lightbox="media/asset-maintenance-schedule-total-life.png":::

1. Select how you want to preview the schedule, by SMU or by time in service. The preview shows how the schedule plays out over multiple iterations before you save it.

1. Go back and make any necessary changes.

1. When you're satisfied with the schedule, select **Save schedule**.

Use a sequential service pattern for maintenance tasks that you need to perform in a specific order. This pattern ensures that each service happens in the correct sequence relative to other services in the maintenance plan. For example, you want to rotate tires every 5,000 SMUs and install new tires after rotating them twice.

### Sequential service pattern

Use a sequential service pattern for maintenance tasks that you need to perform in a specific order. This pattern ensures that each service happens in the correct sequence relative to other services in the maintenance plan. For example, you want to rotate tires every 5,000 SMUs and install new tires after rotating them twice.

1. Select **Add service**.

1. Enter the following information for the service to include in the generated work orders:

   - **Service Name**: Name for the service such as *Rotate tires* or *Install new tires*.

   - **Work Order Type**: The [category of work](create-work-order-types.md) to use for the service. For example, *Maintenance*.

   - **Primary Incident Type**: The [specific issue or request of work](incident-type-overview.md) that the service addresses.

1. Repeat the previous steps for each service. For example, add a *Rotate tires* service after the *Install new tires* service.

1. Select **Next**.

1. Enter the sequence details for the service, specifying the order in which it should be performed relative to other services in the maintenance plan.

   - **Advance the sequence by**: Indicates whether to advance the sequence by a specific number of SMUs or days relative to the previous service in the sequence.

   - **Delayed start**: Indicates whether to start immediately or wait until a specific SMU value before starting this service. If you select a specific SMU value, you can also select if you want to start after a certain number of days, whichever occurs first.

   - **Recurring**: Indicates whether this service should repeat after the specified milestone. If you select recurring, indicate when the recurrence should stop.

   :::image type="content" source="media/asset-maintenance-schedule-sequential-top.png" alt-text="Screenshot of the top half of the Sequential Service schedule.":::

1. Arrange the services in the desired sequence by dragging and dropping them into the correct order. Each position represents the interval from the previous position. You can add the same service to multiple positions. The complete cycle is the sum of all intervals.

1. Indicate the number of SMUs or days or whichever occurs first for the next occurrence of each service. For example, arrange the services as *Install new tires* > *Rotate tires* > *Rotate tires*. Set the interval between each position to 5,000 SMU and set the restart interval to 5,000 SMU. The total cycle time is 15,000 SMU.

1. If this schedule is **Recurring**, select when the pattern should repeat.

   :::image type="content" source="media/asset-maintenance-schedule-sequential-bottom.png" alt-text="Screenshot of the bottom half of the Sequential Service schedule." lightbox="media/asset-maintenance-schedule-sequential-bottom.png":::

1. Select **Next**.

1. When you're satisfied with the schedule, select **Save schedule**.

   :::image type="content" source="media/asset-maintenance-schedule-sequential-preview.png" alt-text="Screenshot of the preview of the Sequential Service schedule." lightbox="media/asset-maintenance-schedule-sequential-preview.png":::

1. Go back and make any necessary changes.

1. When you're satisfied with the schedule, select **Save schedule**.

1. [Add any other schedules](#add-a-maintenance-schedule) to this maintenance plan template. Then, select **Save & Close**.

## Apply the template to an asset

[Prepare the asset with sufficient SMU history](asset-maintenance-service-history.md#prepare-smu-history-for-an-asset) to ensure accurate forecasting of usage-based maintenance. Then, apply the maintenance plan template to the asset.

1. In the Field Service app, switch to the **Service** area, and select **Assets**.

1. Open the customer asset that you want to maintain.

1. Select the **Maintenance** tab.

1. Select **Apply Template**.

1. Find the template you want to apply. Choose a template view, filter criteria, or search by keyword.

1. Select the template, and then select **Next**.

1. Enter the asset’s **In-Service Date** and **Maintenance Time Zone**. These values establish the starting point from which the plan calculates maintenance.

1. Select **Apply**.

1. Select **View plan** and confirm that it contains the maintenance schedule from the template.

   The new maintenance plan is independent of the template. Changes to the template don’t update this plan. Make asset-specific changes directly on the plan. Learn more in [Review the plan and generate service events](asset-maintenance-review-maintenance-plan.md).

1. Select **Save & Close**.

## Next step

- [Review the plan and generate service events](asset-maintenance-review-maintenance-plan.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
