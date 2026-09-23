---
title: Set up the mobile offline profile
description: Learn how to configure the mobile offline profile to work with the Dynamics 365 Field Service mobile app when no network is available.
ms.date: 09/14/2026
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
ai-usage: ai-assisted
---

# Set up the mobile offline profile

Field Service technicians often work in areas with no internet connection, such as remote places or underground. They still need to access their data. The Field Service mobile app comes with an out-of-the-box profile with recommended default settings. The advantages of running the mobile app fully offline include:

- **Consistent performance**: Technicians interact with the app in the same way regardless of their device connectivity.
- **Seamless and uninterrupted experience**: Data synchronization occurs in the background without disrupting the technician's workflow.

The default offline profile, Field Service Mobile - Offline Profile, has common Field Service tables preconfigured for offline use and recommended filters to limit downloaded data. It has predetermined sync intervals for each table based on typical usage patterns. Use the default offline profile, or create a copy and customize it.

For a guided walkthrough, watch the following video.
>
> [!VIDEO 02bf237b-8c58-4513-bd4e-1c66b7163793]

Administrators control what data the Field Service mobile app downloads by using the offline profile. In the offline profile, you can:

- Define tables that are available offline and how often they sync.
- Define filters for each table. For example, by default the offline profile downloads bookings that start within the next seven days.
- Set up item association by creating relationships between tables. You don't need to create a filter for every table because associated tables follow the filters defined on the related table.

## Data in the default offline profile

The default **Field Service Mobile - Offline Profile** includes the following core transaction tables:

- Bookable Resource Booking
- Work Order
- Work Order Incident
- Work Order Product
- Work Order Service
- Work Order Service Task
- Work Order Not-To-Exceed
- Work Order Resolution

The booking filter downloads active bookings assigned to the current user if the booking starts or ends today or within the next seven days. The default profile relates bookings to work orders and work orders to their incidents, products, services, service tasks, not-to-exceed records, and resolutions.

The default solution sets a five-minute sync interval for bookings, work orders, incidents, products, services, service tasks, and not-to-exceed records. Administrators can change these intervals. Field Service updates can change the default profile, so review the profile in your environment for the current tables, filters, relationships, and intervals.

## Prerequisites

- You have admin privileges in Dynamics 365 Field Service.
- You have access to Power Apps.
- [Review the best practices for using the offline profile](best-practices-limitations-offline-profile.md).

## Set up the default mobile offline profile

1. Sign in to Power Apps at [Power Apps](https://make.powerapps.com/) and select your environment.

1. Select **Apps**, and then open **Field Service Mobile**.

1. Select **Settings**, and then select the **General** tab.

1. Scroll to **Can be used offline** and turn it on.

1. Under **Select offline mode and profile**, select which users should have access to the mobile app offline:

   - **Default (recommended)**: All users who have access to the app can also use it in offline mode.
   - **Restricted to selected users (requires admin privileges)**: Only selected users can use the app in offline mode.

1. Select the ellipsis (**&hellip;**) next to **Field Service Mobile - Offline Profile**, and then select **Edit selected profile**.

   :::image type="content" source="../media/fs-mobile-power-apps-edit-offline-profile.png" alt-text="Screenshot of Power Apps Field Service mobile app settings, with the default offline profile selected and Edit selected profile highlighted.":::

1. If you chose to restrict access to selected users, [add those users now](/power-apps/mobile/setup-mobile-offline#add-users-to-an-offline-profile). Otherwise, go to the next step.

1. Review the **Data for offline use**. For each table:

   - Select a table, and then select **Edit**.

      :::image type="content" source="../media/fs-mobile-power-apps-offline-table-edit.png" alt-text="Screenshot of the Bookable Resource Booking table offline data settings in the Field Service mobile app offline profile.":::

   - Select the rows or filters, relationships, files, and images to make available offline. For more information, see [Apply filters](/power-apps/mobile/setup-mobile-offline#add-a-table-to-an-offline-profile-and-apply-filters).

     **Advanced option**: To boost offline performance of large datasets, power users can review and manually edit Fetch XML for your offline filters. Select **Edit filter** to adjust filters through the [FetchXML editor for offline profiles](/power-apps/mobile/fetchxml-editor).

   - Select the sync frequency.

     The default offline profile is updated periodically as part of Field Service updates. If you edit a table's offline sync filter, the sync filter isn't updated. Table sync filters that you didn't edit are updated, but the updates are unpublished. Administrators can review the updates and choose whether to apply them or continue with the previous sync filters. This process only applies to sync filters. Relationships receive updates while keeping your specific changes.

   - Select **Save**.

1. [Add a table to the offline profile](/power-apps/mobile/setup-mobile-offline#add-a-table-to-an-offline-profile-and-apply-filters) if needed.

1. Save the offline profile. If you made changes, publish the app.

If different user roles need different sync settings or offline tables, you can [create more offline profiles](/power-apps/mobile/setup-mobile-offline#set-up-a-mobile-offline-profile). For example, a Field Service manager might need to view a broader scope of work orders than the ones that are assigned to a field technician. If you create an offline profile, add it to the Field Service mobile app in the app designer.

### Optimize columns in the offline profile

You can optimize the mobile offline profile by selectively enabling columns to include with a sync. For guidance and best practices, see [Optimize data downloaded to improve sync time and usage](/power-apps/mobile/mobile-offline-guidelines#optimize-data-downloaded-to-improve-sync-time-and-usage).

> [!CAUTION]
> If an offline profile filter references a lookup table that you don't include in the offline profile, related data isn't available offline. The result might be errors or blank screens for technicians. Include all tables referenced by lookup filters in the offline profile.

## Move a mobile offline profile between environments

To control changes and keep your offline profiles in sync, your organization might require that you update profiles in one environment and then move them into other environments. Be aware that publishing changes to an offline profile creates an [active solution layer](/power-apps/maker/data-platform/solution-layers). Review your solution management and layering strategy when updating profiles across environments.

### Add an offline profile to a solution

1. Sign in to [Power Apps](https://make.powerapps.com/), and select your environment.

1. [Create a new solution](/power-apps/maker/data-platform/create-solution) or open an existing solution.

1. In the solution, select **Objects** from the left navigation pane.

1. On the command bar, select **Add existing** > **More** > **Offline profile**.

1. In the dialog box, select one or more offline profiles, and then select **Add**.

### Export the solution

1. Go to the solution's **Overview** page, or to the list of solutions.

1. Select **Export** on the command bar.

1. Follow the prompts to complete the solution export.

### Import into the target environment

1. In the target environment, import the exported solution.

1. Complete the import process and publish customizations if prompted.

1. Confirm that the mobile offline profile is available and functioning as expected in the target environment.

## Verify and manage profile assignments

If a technician reports missing data or unexpected behavior in the mobile app, they might be assigned to the wrong offline profile. The following table lists common symptoms and how to resolve them.

| Symptom | Resolution |
|---|---|
| Technician sees limited or no data offline | Verify the user is assigned to the correct profile. In [Power Apps](https://make.powerapps.com/), open **Field Service Mobile** settings, edit the offline profile. Confirm that the user appears under **Users with this profile**. If the profile has restrictive filters, broaden them as needed. Learn more in [Set up mobile offline](/power-apps/mobile/setup-mobile-offline#add-users-to-a-mobile-offline-profile). |
| Technician sees data from other regions or teams | Remove the user from the current profile and add them to the correct one. In [Power Apps](https://make.powerapps.com/), edit the offline profile, remove the user from **Users with this profile**, then open the correct profile and add them. Save and publish the app. Learn more in [Troubleshoot common issues in the Field Service mobile app](/troubleshoot/dynamics-365/field-service/mobile-app/mobile-app-common-issues). |
| Forms or views are missing fields offline | Edit the offline profile and add the missing tables or columns. Save and publish the app. Learn more in [Offline profile guidelines](/power-apps/mobile/mobile-offline-guidelines). |

The user's device syncs with the updated profile data during the next sync cycle.

Learn more in [Troubleshoot offline sync errors](/troubleshoot/power-platform/power-apps/mobile-apps/mobile-offline-troubleshooting).

## Best practices for offline mode

Review the following blog posts about using offline profiles in the Field Service mobile app, including best practices and advanced scenarios.

- [Best Practices for Offline Mode in the Field Service mobile app – Part 1](https://www.microsoft.com/en-us/dynamics-365/blog/administrator/2023/11/06/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-1/)
- [Best Practices for Offline Mode in the Field Service mobile app – Part 2](https://www.microsoft.com/en-us/dynamics-365/blog/administrator/2023/11/08/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-2/)
- [Best Practices for Offline Mode in the Field Service mobile app – Part 3](https://www.microsoft.com/en-us/dynamics-365/blog/it-professional/2023/11/10/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-3/)

## Next step

- [Configure offline sync](offline-data-sync.md)

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
