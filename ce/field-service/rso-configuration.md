---
title: Resource Scheduling Optimization configuration in Dynamics 365 Field Service
description: Learn how to configure Resource Scheduling Optimization in Dynamics 365 Field Service
author: AnilMur
ms.author: anilmur
ms.date: 01/29/2025
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Resource Scheduling Optimization configuration

Perform these configuration steps after [successful deployment](rso-deployment.md) of the Resource Scheduling Optimization solution.

## Enable Resource Scheduling Optimization

1. First, make sure that [maps are configured for your environment](field-service-maps-address-locations.md#connect-to-maps). Review the privacy considerations for sending data between services.

1. Go to **Resource Scheduling Optimization** > **Administration** > **Scheduling Parameters** > **Resource Scheduling Optimization** tab.

   :::image type="content" source="media/rso-settings-enable.png" alt-text="Screenshot of Resource Scheduling Optimization tab.":::

   - Set **Enable Resource Scheduling Optimization** to **Yes**.

   - Set **Default Goal**. A default goal tells Resource Scheduling Optimization what to prioritize by default and it's relevant for [single resource optimization](rso-single-resource-optimization.md). If no default goal exists, [create an optimization goal](rso-optimization-goal.md). Users can still choose different goals when they start an optimization request.

## Add required security roles to users who configure and run Resource Scheduling Optimization

Ensure that Resource Scheduling Optimization can optimize work order-related requirements and bookings:

1. Go to **Settings** > **Advanced Settings** > **Security** > **Users**. And assign the security role *Field Service - Administrator* to the Resource Scheduling Optimization application user.

1. Go to **Security** > **Field Security Profiles**. Select **Resource Scheduling Optimization – Administrator** and add the Resource Scheduling Optimization application user to the field security profile.
  
Enable dispatchers to interact with Resource Scheduling Optimization:

1. Go to **Settings** > **Security** > **Users**.

1. Locate the user or team of dispatchers.

1. Select **Manage Roles**.

1. Assign a security role.

1. Select **Save**.

1. Go to **Settings** > **Security** > **Field Security Profiles**.

1. Open **Resource Scheduling Optimization - Dispatcher** and add the user or team to the profile and then select **Save**.

## Prepare resources for optimizations

The settings described in this section apply to all optimization scopes.

1. Go to **Resource Scheduling Optimization** > **Resources**. Open the **Scheduling Summary** view. Select one or more resource records and select **Edit**.

1. In the Resource Scheduling Optimization tab, set **Optimize Schedule** to **Yes** and **Save** the records. Enabling the setting doesn't automatically schedule requirements to the selected resource. It enables Resource Scheduling Optimization to consider the resource during schedule optimization runs.

   :::image type="content" source="media/resource-enable-rso.png" alt-text="Screenshot of enabling Resource Scheduling Optimization for a resource.":::

1. After enabling the resources for schedule optimization, specify the address for the organizational unit or resource address, depending on their start and end location.
  
1. Go to **Resource Scheduling Optimization** > **Settings** > **Administration** > **Enable Resource Scheduling for Entities**.

1. Double-click an enabled entity to configure booking setup metadata. In the **Resource Scheduling Optimization** section, set the **Default Scheduling Method** to **Optimize** and **Save** the changes. For example, you can enable it for the work order entity. The system sets every new work order and related resource requirement to optimize automatically.

   :::image type="content" source="media/rso-entity-default-scheduling-method.png" alt-text="Screenshot showing the Booking Setup Metadata, with Default Scheduling Method set to Optimize.":::

1. For existing resource requirement records, update the resource requirements scheduling method. Go to **Resource Scheduling Optimization** > **Resource Requirements** and open the **Unscheduled Work Order Requirements** view. Select the records to optimize, and select **Edit**.

   - On the **Resource Scheduling Optimization** tab, set the **Scheduling Method** to **Optimize**.

   - On the Scheduling tab, make sure the location is **On Site** or **Location Agnostic**. If **On Site** is the requirement, you must specify the address.  

   - On the **General** tab, check that **From Date** and **To Date** fall into the time window you want to schedule. You can use the bulk edit feature to update values for selected records as well.

1. Go to **Resource Scheduling Optimization** > **Settings** > **Booking Statuses**. Select a booking status and choose the **Scheduling Method**.

   :::image type="content" source="media/rso-booking-statuses.png" alt-text="Screenshot showing active booking statuses.":::

   - **Optimize**: Allows the system to freely move this booking to optimize scheduling.
   - **Do Not Move**: The system doesn't change the booking. Resource Scheduling Optimization preserves the estimated arrival time and assigned resource. The start time and estimated travel duration can be changed if the earlier booking is in a new location. It's similar to a user setting the booking to **Locked to resource + time**.
   - **Ignore**: Resource Scheduling Optimization ignores this booking for both, location and time. Use this setting when the booking status is proposed or canceled.

    > [!NOTE]
    > Booking statuses with no specified scheduling method are treated as Do Not Move.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
