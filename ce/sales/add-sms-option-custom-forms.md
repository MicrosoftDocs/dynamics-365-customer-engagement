---
title: Add text message option to custom forms
description: Add the text messages (SMS) option to your custom forms in Dynamics 365 Sales.
ms.date: 09/20/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Add text message option to custom forms

Add the text messaging to phone number fields in custom forms, allowing sellers to send text messages directly from within the form.

## Add text message option

1. Sign in to your sales app and go to **Advanced Settings** > **Settings** > **Customizations** > **Customize the System**.  
1. Under **Components** > **Entities**, choose an entity and then select **Forms**.  
1. From the list of forms, select the form to which you want to add the text message option.  
1. Under the **Summary** section, double-click the phone field, such as **Business phone** or **Mobile phone**.  
1. In the **Field Properties** dialog, go to the **Controls** tab and then select **Add control**.  
1. In the **Add Control** dialog, select and add the **Sales phone number control** option.  
    The **Sales phone number control** option is added to the list of controls.
1. Select the devices (**Web**, **Tablet**, and **Phone**) you want the control to appear on.  
1. Save and publish the form.  
   The customizations are published. The text message option is available for the phone number field you've selected in your custom form. The following image shows an example of including the text message option in the **Business Phone** section of the **Information** form for contacts.  
    :::image type="content" source="media/sms-add-option-custom-forms.png" alt-text="Screenshot of the text message option added to the business phone in the information form.":::  

## Related information

[Engage with customers through text messages](sms-intro.md)  
[Configure SMS provider](configure-sms-provider.md)  
