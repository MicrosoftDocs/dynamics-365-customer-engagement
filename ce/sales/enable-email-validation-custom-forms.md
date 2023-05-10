---
title: Enable email validation for custom forms
description: Learn how to enable email validation for custom forms in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/10/2023
ms.custom: bap-template 
---

# Enable email validation for custom forms

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The email validation feature in Dynamics 365 Sales helps you to validate primary email addresses of contact and lead records. This feature is enabled by default for the main lead and contact forms in the Sales Hub app. If you have customized the main lead form, you need to enable email validation manually.  

>[!NOTE]
>The customizations can only be applied to main forms of Contact and Lead tables.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How to enable email validation

You can add the following customization for email validation:  
- To validate email addresses while composing an email, add an event handler to the OnLoad event. If the email address is invalid, a validation message will be displayed. More information: [Add an event handler to the OnLoad event](#add-an-event-handler-to-the-onload-event).
- To add an email validation icon to the email field, add the email control to the custom form. More information: [Add email control](#add-email-control).

### Add an event handler to the OnLoad event

>[!NOTE]
>In this example, we're using the **Contact** table. You can use the same steps to add an event handler to the **OnLoad** event for the main lead forms.

1. Sign in to the [Power Apps](https://make.powerapps.com/) portal.  
1. Search for and select your organization's environment.   
1. From the site map, select **Tables** and then select the contact table..  
1. Under the **Data experiences** section, select **Forms** and then select your custom contact form of type Main.  
1. On the Main form pane that opens on the right side, select the **Events** tab.   
1. Under the **On Load** section, select **+ Event Handler**.   
1. On the **Configure Event** dialog box, select **+ Add library**.
1. Add the **DataHygiene/Data/salesdatahygiene_form_notification_library.js** library and then select it from the list.  
1. In the **Function** name field, enter the **Mscrm.LeadHygiene.DataHygieneNotificationLibrary.emailAddressValidationFormOnLoad** value.
1. Enable **Pass execution context as first parameter**.
1. Select **Done**.  

    :::image type="content" source="media/ev-add-onload-event-library.png" alt-text="Screenshot of the event configuration for event handler for email validation.":::

1. Save and publish the form.

    Under the **Handlers** section, you can see the required event handler is added to the form. If the email validation feature is currently disabled, enable it. For more information, see [Enable email validation](enable-email-validation.md).

### Add email control 

You must add the email control only to the primary email address field.

>[!NOTE]
>In this example, we're using the **Contact** table. You can use the same steps to add the email control for the main lead forms.

1. Open the contact form as described in the [Add an event handler to the OnLoad event](#add-an-event-handler-to-the-onload-event) section.
1. On the New Contact form, Under the **CONTACT INFORMATION** section, select **Email**.
1. In the **Properties** tab, under the **Components** section, select **+ Component**.
1. On the **Add component** dialog box, add the **ValidatedField_Control** component and then select it. 
1. Select the options for web, mobile, and tablet and then select **Done**.  
    >[!NOTE]
    >Verify that the **Show component on** options for **Email address (default)** are removed.
1. Save and publish the form.  

The email control is added to the email field. If the email validation feature is currently disabled, enable it. For more information, see [Enable email validation](enable-email-validation.md).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable email validation](enable-email-validation.md)  
[Work with invalid email addresses](work-invalid-email-addresses.md)  
