---
title: Set up frontline workers in your Dynamics 365 Field Service organization
description: Learn how to set up frontline workers through the Dynamics 365 Field Service get started page
author: xonatia
ms.service: dynamics-365-customerservice
ms.reviewer: krbjoran
ms.custom:
  - dyn365-fieldservice
ms.date: 04/01/2021
ms.topic: overview
 - field-service
ms.author: xolee
search.app:
  - D365CE
  - D365FS
---

# Set up frontline workers in your organization

Frontline workers in Dynamics 365 Field Service are people in your organization who are primarily scheduled for onsite jobs and who use the Dynamics 365 Field Service mobile app for their work. Quickly getting frontline workers set up in Field Service is critical in order to ensure they can immediately start fixing problems at customer locations and completing service calls. 

Admins can now use a single form to set up frontline workers in their organizations with all the required permissions frontline workers need to quickly get up and running with the Field Service mobile app and be scheduled for work orders. 

With a single form, admins can: 

1. Set up one or more frontline workers in their organization with the appropriate [characteristics (skills and certifications)](https://docs.microsoft.com/dynamics365/field-service/set-up-characteristics), [territories](https://docs.microsoft.com/dynamics365/field-service/set-up-territories), time zone, [security roles](https://docs.microsoft.com/dynamics365/field-service/view-user-accounts-security-roles), [field security profiles](https://docs.microsoft.com/dynamics365/field-service/view-user-accounts-security-roles), and [mobile offline profile](https://docs.microsoft.com/dynamics365/field-service/mobile-power-app-system-offline). 
2. View and update the defaulted security role, field security profile, and mobile offline profile set for their frontline workers, which controls the data their frontline workers can see and access. Admins can  update these permissions or add any custom security roles, field security profiles, or mobile offline profile.
3. Automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile app. 

After setting up one or more frontline workers, admins can then:

1. View a list of all of their frontline workers, including names, e-mail addresses, and home addresses. 
2. View and update details for individual frontline workers on the bookable resource form, including their home address, security role, field security profile, and mobile offline profile. 

> [!NOTE]
> Bing Maps has been enabled for new organizations. One-click directions has been enabled for all frontline workers. For mor information, see: [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement). 

## Prerequisites 
- Your organization's global admin or system admin must have a Microsoft 365 [administrator account](https://www.microsoft.com/microsoft-365/business/office-365-administration?rtc=1). For more information, learn more about [admin permissions](https://docs.microsoft.com/microsoft-365/admin/add-users/about-admin-roles?view=o365-worldwide).
- Each frontline worker must have a Dynamics 365 Field Service license assigned through the [Microsoft Admin Center](https://admin.microsoft.com). 

## Definitions 

**Frontline workers**: People in your organization who are primarily scheduled for onsite jobs, and who use the Field Service mobile app for their work.

**Characteristics**: Defines a frontline worker's areas of expertise or certifications.

**Territories**: Defines a frontline worker's geographical regions, such as city, state, county, or postal code, to inform scheduling.

**Security Role**: Controls the types of data and record types a frontline worker can access and edit. This role should be defaulted to **Field Service - Resource**.

**Field Security Profile**: Controls which fields a frontline worker sees for a record type. This profile should be defaulted to **Field Service - Resource**.

**Mobile Offline Profile**: Controls what data is downloaded to the Dynamics 365 Field Service mobile application in offline mode. Unpublished profiles will not appear until published. This profile should be defaulted to **Field Service Mobile - Offline Profile**. 

## Get started 

1. On the **Home** tab or **Get Started** tab, admins can set up their frontline workers in their organization.

> ![Screenshot of the get started page in Field Service.](./media/getstarted.png)

## Use the form 

1. In the **Set up your frontline workers** section, select **Set Up**. 

> ![Screenshot of selecting Set Up button in Field Service.](./media/getstarted_setup.png)

2. The **Quick Set Up: Frontline Workers** form will appear. 

> ![Screenshot of Quick Create: Set Up Frontline Workers form in Field Service.](./media/setup_form.PNG)

3. In the **Users** section, admins can type in and select **one or more frontline workers** in their organizations. 

 > [!NOTE]
 > If setting up multiple frontline workers on this form, all of them will have properties, such as characterisitics, territories, time zone, security role, field security profile, and mobile offline profile. Batched properties allow you to group your frontline workers by these properties. 

> ![Screenshot of adding frontline workers in Field Service.](./media/setup_form_add_users.png)

4. Type and select the **Characteristics** for your frontline workers. This field is optional. 

> ![Screenshot of adding characteristics in Field Service.](./media/setup_form_characteristics.PNG)

4a. If the **Characteristics** do not exist, select the drop-down and select **+ New Characteristics**. A new form will appear and admins can define and create a new characteristics for their frontline workers. Admins *will not* lose their work on the **Quick Set Up: Frontline Workers** form.

1. Type and select the **Territories** that your frontline workers belong to. This field is optional. 

> ![Screenshot of adding territories in Field Service.](./media/quicksetup_territories.PNG)

5a. If the **Territories** do not exist, select the drop-down and select **+ New Territories**. A pop-up form will appear and admins must leave the current form to create new territories for their frontline workers. Admins *will* lose their work on the **Quick Set Up: Frontline Workers** form. 

>[!Important]
> To ensure no work is lost, admins should set up new territories outside of the quick-create form. For more information about setting up territories, see: [setting up territories without this form](https://docs.microsoft.com/dynamics365/field-service/set-up-territories)

6. View or update the defaulted **Time Zone** for your frontline workers.

7. View or update the defaulted **Security Role** for your frontline workers. Admins may add multiple security roles, including any custom security roles, to this field. This field is required. 

> ![Screenshot of adding security roles in Field Service.](./media/quicksetup_securityroles.PNG)

8. View or update the default **Field Security Profile** for your frontline workers. Admins may add multiple field security profiles, including any custom field security profiles, to this field. This field is required. 

> [!NOTE]
> In order to view all of the field security profiles in the dropdown, select the **Search icon** > **Change View** > **Only my records checkbox** > **Back button**.

> ![Screenshot of adding field security profiles in Field Service.](./media/setup_form_fs_profile.PNG)

9. View or update the defaulted **Mobile Offline Profile** for your frontline workers. Admins can only add *one* mobile offline profile, including any custom mobile offline profile, to this field. This field is required. 

 > [!NOTE]
 > Unpublished mobile offline profiles will not appear until published; [learn more here](https://docs.microsoft.com/dynamics365/field-service/mobile-power-app-system-offline).

> ![Screenshot of adding mobile offline profiles in Field Service.](./media/setup_form_mop.PNG)

10.  Automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile app.

> ![Screenshot of frontline worker email template in Field Service.](./media/email_template.PNG)

 > [!NOTE]
 > Admins cannot send an email to their frontline workers if they do not have their mailbox approved by the global admin; For more information, [learn to add and approve email addresses](frontline-worker-set-up-email-approval.md).
 > ![Screenshot of unable to send email notification in Field Service.](./media/setup_form_unable_to_send_email.PNG).

## View a list of all frontline workers 

1. From the **Home** or **Get Started** page, go to the **Set up your frontline workers** section, and select **View All**.

> ![Screenshot of view all frontline Workers in Field Service.](./media/setup_form_view_all.PNG)

2. View a list of all of their frontline workers, including their name, e-mail address, and home address. 

> ![Screenshot of list view of all frontline workers in Field Service.](./media/all_flws.PNG)

## View and update the details of individual frontline workers on the bookable resource form

1. After selecting an individual from the **List View** of all frontline workers, admins can see the details for this worker on the bookable resource form. 

> ![Screenshot of Selecting a user in Field Service.](./media/bookable_resource_form.PNG)

2. On the **General** tab, admins can view and update this worker's e-mail address, home address, and more. 

> ![Screenshot of selecting permissions in Field Service.](./media/br_form_permissions.PNG)

3. After selecting the **Permissions** option on the top of the bookable resource page, admins can view and update this worker's permissions, such as security role, field security role, and mobile offline profile. 

> ![Screenshot of view or update permissions in Field Service.](./media/br_form_edit_permissions.PNG)
