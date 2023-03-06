---
title: Add text message option to custom forms
description: "Add the text messages (SMS) option to your custom forms in Dynamics 365 Sales."
ms.date: 02/23/2023
ms.topic: how to
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Add text message option to custom forms

Add the text messaging to phone number fields in custom forms, allowing sellers to send text messages directly from within the form.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Add text message option

1. Sign in to your sales app and go to **Advanced Settings** > **Settings** > **Customizations** > **Customize the System**.

2. Under **Components** > **Entities**, choose an entity and then select **Forms**.

3. From the list of forms, select the form to which you want to add the text message option. 

4. Under the **Summary** section, double-click the phone field such as, **Business phone** or **Mobile phone**. 

5. In the **Field Properties** dialog, go to the **Controls** tab and the select **Add control**.

6. In the **Add Control** dialog, select and add the **Sales phone number control** option.  
    The **Sales phone number control** option is added to the list of controls.

7. Select the devices (**Web**, **Tablet**, and **Phone**) you want the control to appear on.

8. Save and publish the form.  
    The customizations are published. The text message option is available for the phone number field you've selected in your custom form. The following image shows an example of including the text message option in the **Business Phone** section of the **Information** form for contacts.

    :::image type="content" source="media/sms-add-option-custom-forms.png" alt-text="Screenshot of the text message option added to the business phone in the information form.":::

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Engage with customers through text messages](sms-intro.md)  
[Configure SMS provider](configure-sms-provider.md)   
