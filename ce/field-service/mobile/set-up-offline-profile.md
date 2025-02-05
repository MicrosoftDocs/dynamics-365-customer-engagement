---
title: Set up the mobile offline profile
description: Learn how to configure the mobile offline profile to work with the Dynamics 365 Field Service mobile app when no network is available.
ms.date: 02/05/2025
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Set up the mobile offline profile

Field Service technicians often work in areas with no internet connection, like remote places or underground. It’s crucial that they can still access their data. The Field Service mobile app comes with an out-of-the-box profile with recommended default settings. The advantages of running the mobile app fully offline include:

- Consistent performance. Technicians interact with the app in the same way regardless of their device connectivity.
- Seamless and uninterrupted experience. Data synchronization occurs in the background without disrupting the technician's workflow.

The default offline profile, Field Service Mobile - Offline Profile, has common Field Service tables preconfigured for offline use and recommended filters to limit the data that gets downloaded. It has predetermined sync intervals for each table, based on typical usage patterns. We recommend you use the default offline profile, but you can copy the default profile and build on the copied profile.

Administrators control what data the Field Service mobile app downloads with the offline profile. In the offline profile, you can:

- Define tables that are available offline and how often they sync.
- Define filters for each table. For example, by default the offline profile downloads bookings that start within the next seven days.
- Set up item association by creating relationships between tables. Item association saves time because not every table needs a filter. Associated tables follow the filters that are set on the related table.

For a guided walkthrough, check out the following video.
>
> [!VIDEO 02bf237b-8c58-4513-bd4e-1c66b7163793]

## Prerequisites

- You have admin privileges in Dynamics 365 Field Service.
- You have access to Power Apps.
- [Review the best practices for using the offline profile](best-practices-limitations-offline-profile.md).

## Set up the default mobile offline profile

1. Sign in to Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/), and select your environment.

1. Select **Apps**, and then open **Field Service Mobile**.

1. Select **Settings**, and then select the **General** tab.

1. Scroll to **Can be used offline** and toggle it on.

1. Under **Select offline mode and profile**, choose which users should have access to the mobile app offline:

   - **Default (recommended)**: All your users who have access to the app can also use it in offline mode.
   - **Restricted to selected users (requires admin privileges)**: Restrict access to the app in offline mode to certain users.

1. Select the ellipsis (**&hellip;**) next to **Field Service Mobile - Offline Profile**, and then select **Edit selected profile**.

   :::image type="content" source="../media/fs-mobile-power-apps-edit-offline-profile.png" alt-text="Screenshot of Power Apps Field Service mobile app settings, with the default offline profile selected and Edit selected profile highlighted.":::

1. If you chose to restrict access to selected users, [add those users now](/power-apps/mobile/setup-mobile-offline#add-users-to-an-offline-profile). Otherwise, go to the next step.

1. Review the **Data for offline use**. For each table:

   - Select a table, and then select **Edit**.

      :::image type="content" source="../media/fs-mobile-power-apps-offline-table-edit.png" alt-text="Screenshot of the Bookable Resource Booking table offline data settings in the Field Service mobile app offline profile.":::

   - Select the rows or filters, relationships, files, and images to make available offline.

   - Select the sync frequency.

     The default offline profile is updated periodically as part of Field Service updates. If you edit a table's offline sync filter, the sync filter isn't updated. Table sync filters that haven't been edited are updated, but the updates are unpublished. Administrators can review the updates and decide to take them or continue with the previous sync filters. This only applies to sync filters. Relationships receive updates while keeping your specific changes.

   - Select **Save**.

1. [Add a table to the offline profile](/power-apps/mobile/setup-mobile-offline#add-a-table-to-an-offline-profile-and-apply-filters) if needed.

1. Save the offline profile. If you made changes, publish the application.

If you have user roles that need different sync settings or tables available offline, you can [create more offline profiles](/power-apps/mobile/setup-mobile-offline#set-up-a-mobile-offline-profile). For example, a Field Service manager might need to view a broader scope of work orders than the ones that are assigned to a field technician. If you create an offline profile, remember to add it to the Field Service mobile app in the app designer.

### Optimize columns included within the offline profile (Preview)

You can optimize the mobile offline profile by selectively enabling columns to include with a sync. For guidance and best practices, see [Optimize downloaded data with Offline Table Column Selection (Preview)](/power-apps/mobile/mobile-offline-guidelines#optimize-downloaded-data-with-offline-table-column-selection-preview).

## Move a mobile offline profile between environments

To control changes and keep your offline profiles in sync, your organization might require that you make changes to the profiles in one environment and then move them into other environments.

1. Sign in to Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/), and select your environment.

1. Select **Apps**, and then open **Field Service Mobile**.

1. Select **Settings**, and then select the **General** tab.

1. Scroll to **Select offline mode and profile**.

1. Select the ellipsis  (**&hellip;**) next to **Field Service Mobile - Offline Profile**, and then select **Copy selected profile**.

1. Modify the copied profile as needed.

1. [Create a managed solution](/power-platform/alm/solution-concepts-alm) that includes the mobile offline profile.

1. Export the managed solution from the original environment.

1. Import the managed solution into the new environment.

## Best practices for offline mode

Review the following blog posts about using the offline profiles in the Field Service mobile app, including best practices and advanced scenarios.

- [Best Practices for Offline Mode in the Field Service mobile app – Part 1](https://www.microsoft.com/en-us/dynamics-365/blog/administrator/2023/11/06/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-1/)
- [Best Practices for Offline Mode in the Field Service mobile app – Part 2](https://www.microsoft.com/en-us/dynamics-365/blog/administrator/2023/11/08/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-2/)
- [Best Practices for Offline Mode in the Field Service mobile app – Part 3](https://www.microsoft.com/en-us/dynamics-365/blog/it-professional/2023/11/10/best-practices-for-offline-mode-in-the-field-service-mobile-app-part-3/)

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
