---
title: Configure the mobile offline profile
description: Learn how to configure the mobile offline profile to work with the Dynamics 365 Field Service mobile app when no network is available.
ms.date: 12/18/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Configure the mobile offline profile

Field Service provides an out-of-the-box offline profile called Field Service Mobile - Offline Profile with recommended default settings for Field Service record types. Learn more about Offline profile guidance.

Administrators control what data the Field Service mobile app downloads with the offline profile. Within the offline profile, you can:

- Define record types that are available offline and their sync interval.
- Define filters for each record type. For example, by default the offline profile downloads bookings that start within the next seven days to the device.
- Set up item association by creating relationships between tables. Item association saves time because not every record type needs a filter. You can associate related record types that follow filters set on the related record type.

## Prerequisites

You have admin privileges in Dynamics 365 Field Service.

## Customize the default mobile offline profile

1. Review the [guidance for the offline profile](mobile-power-app-system-offline.md#implementation-guidance-for-the-offline-profile).

1. Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.

1. Select **Settings** at the top.

1. Select **Users + permissions** > **Mobile configuration**.

1. Open the **Field Service Mobile - Offline Profile**.

1. [Add users and teams](/power-apps/mobile/setup-mobile-offline#add-users-to-an-offline-profile). You can only add a user or a team to one offline profile one at a time.

   When you add a team to the profile, the users within that team show under the team, while individual users show directly in the offline profile. Organizations with many users should use teams to help ease maintenance of user access.

   <!--- Do they have to add users or only if they don't use the default profile? --->

   The security role for users and teams needs read permission for the *UserMobileOfflineProfileMembership* and *TeamMobileOfflineProfileMembership* privileges.

1. Review the **Data available offline**. Select **Manage**.

   1. Select a table and select **Edit**.

      > [!div class="mx-imgBorder"]
      > ![Screenshot of the Power Platform admin center, showing the edit bookable resource booking entity options.](./media/mobile-offline-mop-latest.png)

   1. View the filters, relationships, and sync interval.

      For example, the **Bookable Resource Booking** (booking) table has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or today.

      > [!div class="mx-imgBorder"]
      > ![Screenshot of the Power Platform admin center, showing the set filter logic.](./media/mobile-2020-offline-ppac-brb-custom-filter.png)

   1. If necessary, make changes. To add a table, see [Add a table to an offline profile](/power-apps/mobile/setup-mobile-offline#add-a-table-to-an-offline-profile-and-apply-filters).

      > [!NOTE]
      > The default offline profile is updated periodically as part of Field Service updates. If you edited the offline sync filter of a table, the table's sync filter won't receive updates; other table sync filters that haven't been edited will receive updates in an unpublished state. Administrators can review the updates and decide if they want to take the update or continue with the previous sync filters. This only applies to sync filters. Relationships will receive updates while keeping your specific changes.

1. Save and publish the offline profile.

## Add the offline profile to the Field Service Mobile app

1. Go to your Dynamics 365 apps and find the Field Service Mobile app module. Open the app designer.

   <!---How? --->

1. Go to **Properties** and add the offline profile you published if it's not already there. Remember to save and publish your changes if you add an offline profile.

> [!NOTE]
> Field Service customers can create additional offline profiles to enable scenarios where different user roles have different sync settings or tables available to them. For example, a Field Service manager may require seeing a broader scope of work orders that may not be assigned to the current operator of the mobile app. If you create a new offline profile, you'll need to add it to the Field Service mobile app in the app designer as well.

Sign into your mobile app, then go to **Settings** > **Offline Setting** to see the status of downloaded data.

If data isn't downloading, try signing out and signing back in. If offline data is still not downloading, make sure the user you're signing into the mobile app as uses a **Published** mobile offline profile.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
