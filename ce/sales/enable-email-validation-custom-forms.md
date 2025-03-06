---
title: Enable email validation for custom forms
description: Discover how to enable email validation for custom forms in Sales Hub, ensuring primary email addresses of contacts and leads are valid.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 06/28/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:06/25/2024
---

# Enable email validation for custom forms

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The email validation feature in Dynamics 365 Sales helps validate the primary email address of contact and lead records. By default, this feature is enabled for the main lead and contact forms in the Sales Hub app. However, if you've customized the main lead form, you must manually enable email validation.

> [!NOTE]
> These customizations can be applied only to main forms of the `Contact` and `Lead` tables.

## Enable email validation

You can add the following customizations for email validation:

- To validate email addresses while an email is being composed, [add an event handler to the OnLoad event](#add-an-event-handler-to-the-onload-event). If an email address isn't valid, a validation message is displayed.
- To add an email validation icon to the email address field, [add the email control to the custom form](#add-the-email-control).

### Add an event handler to the OnLoad event

> [!NOTE]
> This example uses the `Contact` table. Use the same basic steps to add an event handler to the `OnLoad` event for the main lead form.

1. Sign in to the [Power Apps portal](https://make.powerapps.com/).
1. Search for and select your organization's environment.
1. In the site map, select **Tables**, and then select the `Contact` table.
1. In the **Data experiences** section, select **Forms**, and then select your custom contact form of the *Main* type.
1. In the **Main form** pane that opens on the right, select the **Events** tab.
1. In the **On Load** section, select **+ Event Handler**.
1. In the **Configure Event** dialog box, select **+ Add library**.
1. Add the `DataHygiene/Data/salesdatahygiene_form_notification_library.js` library, and then select it in the list.
1. In the **Function** field, enter *Mscrm.LeadHygiene.DataHygieneNotificationLibrary.emailAddressValidationFormOnLoad*.
1. Select the **Pass execution context as first parameter** checkbox.
1. Select **Done**.

    :::image type="content" source="media/ev-add-onload-event-library.png" alt-text="Screenshot of the event configuration for the event handler for email validation.":::

1. Save and publish the form.

    In the **Handlers** section, notice that the required event handler has been added to the form. Ensure that the email validation feature is enabled. [Learn how to enable email validation.](enable-email-validation.md)

### Add the email control

You must add the email control only to the primary email address field.

> [!NOTE]
> This example uses the `Contact` table. You can use the same steps to add the email control for the main lead form.

1. Open the contact form as described in the [Add an event handler to the OnLoad event](#add-an-event-handler-to-the-onload-event) section.
1. In the **New Contact** form, in the **Contact Information** section, select **Email**.
1. On the **Properties** tab, in the **Components** section, select **+ Component**.
1. In the **Add component** dialog box, add the **ValidatedField_Control** component, and then select it.
1. Select the options for web, mobile, and tablet, and then select **Done**.

    > [!NOTE]
    > Verify that the **Show component on** options for **Email address (default)** are removed.

1. Save and publish the form.

The email control is added to the email address field. Ensure that the email validation feature is enabled. [Learn how to enable email validation.](enable-email-validation.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Enable email validation](enable-email-validation.md)  
[Work with invalid email addresses](work-invalid-email-addresses.md)
