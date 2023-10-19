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



7. View or update the defaulted **Security Role** for your frontline workers. Admins may add multiple security roles, including any custom security roles, to this field. This field is required. 

8. View or update the default **Field Security Profile** for your frontline workers. Admins may add multiple field security profiles, including any custom field security profiles, to this field. This field is required. 

> [!NOTE]
> In order to view all of the field security profiles in the dropdown, select the **Search icon** > **Change View** > **Only my records checkbox** > **Back button**.


9. View or update the defaulted **Mobile Offline Profile** for your frontline workers. Admins can only add *one* mobile offline profile, including any custom mobile offline profile, to this field. This field is required. 

 > [!NOTE]
 > Unpublished mobile offline profiles will not appear until published; [learn more here](mobile-power-app-system-offline.md).

## Send frontline workers an email with link to download app 

10.  Automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile app by leaving the **checkbox** selected on the **Quick Set Up: Frontline Workers** form. This email is not editable. 

 > [!NOTE]
 > Admins cannot send an email to their frontline workers if they do not have their mailbox approved by the global admin; For more information, [learn to add and approve email addresses](frontline-worker-set-up-email-approval.md).

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
