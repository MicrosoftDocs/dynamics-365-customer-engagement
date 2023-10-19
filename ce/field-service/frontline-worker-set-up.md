---
title: Set up frontline workers in your Dynamics 365 Field Service organization (contains video)
description: Learn how to set up frontline workers through the Dynamics 365 Field Service get started page
ms.author: jacoh
author: jasonccohen
ms.date: 04/01/2021
ms.topic: conceptual
---

# Set up frontline workers in your organization

Frontline workers in Dynamics 365 Field Service are people in your organization who are primarily scheduled for onsite jobs and who use the Dynamics 365 Field Service mobile app for their work. Set up frontline workers to ensure they can immediately engage on work order. Technically, frontline workers are a *bookable resource* record in Field Service.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWN1Bb]

On the [**Get started** page](field-service-get-started.md), admins can use a single form to set up frontline workers in their organizations to quickly get up and running.

## Prerequisites

- Your organization's global admin or system admin must have a Microsoft 365 [administrator account](/microsoft-365/admin/add-users/about-admin-roles).
- Each frontline worker must have a Field Service license assigned through the [Microsoft 365 admin center](https://admin.microsoft.com). [Learn how to assign licenses](/microsoft-365/admin/manage/assign-licenses-to-users).

## Set up frontline workers

1. In Field Service, change to the **Service** area and go to **Get started**.

1. In the **Set up your frontline workers** section, select **Set Up**.

1. In the **Quick Set Up: Frontline Workers** form fill in the following details:

   - **Users**: Choose one or more frontline worker. When you choose more than one user, they all get the same properties assigned as defined in the following sections.
   - **Characteristics**: Choose [skills and qualifications](set-up-characteristics.md) for your frontline workers.
   - **Territories**: Choose which [territories](set-up-territories.md) your frontline workers belong to.
   - **Time Zone**: Select the default time zone for the frontline workers.
   - **Security Role** choose the [security role](/power-platform/admin/security-roles-privileges) for your frontline workers. You can add multiple security roles, including custom security roles.
   - **Field Security Profile** choose the [column-level security profile to control access](/power-platform/admin/field-level-security) for your frontline workers. You can add multiple field security profiles, including custom field security profiles.
   - **Mobile Offline Profile** sets the [default mobile offline profile](mobile-power-app-system-offline.md) your frontline workers. Only published mobile offline profiles show in the list.

1. Select the checkbox to send an email to newly created frontline workers with a link to download the mobile app. Admins cannot send an email to their frontline workers if they do not have their mailbox approved by the global admin; For more information, [learn to add and approve email addresses](frontline-worker-set-up-email-approval.md).

## View a list of all frontline workers 

1. From the **Home** or **Get Started** page, go to the **Set up your frontline workers** section, and select **View All**.

2. View a list of all of their frontline workers, including their name, e-mail address, and home address. 

## View and update the details of individual frontline workers on the bookable resource form

1. After selecting an individual from the **List View** of all frontline workers, admins can see the details for this worker on the bookable resource form. 

> ![Screenshot of Selecting a user in Field Service.](./media/bookable_resource_form.PNG)

2. On the **General** tab, admins can view and update this worker's e-mail address, home address, and more. 

> ![Screenshot of selecting permissions in Field Service.](./media/br_form_permissions.PNG)

3. After selecting the **Permissions** option on the top of the bookable resource page, admins can view and update this worker's permissions, such as security role, field security role, and mobile offline profile. 

> ![Screenshot of view or update permissions in Field Service.](./media/br_form_edit_permissions.PNG)

For more information about setting up the Bookable Resource form, learn more [here](set-up-bookable-resources.md).
