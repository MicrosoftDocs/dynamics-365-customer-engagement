---
title: Enable address suggestions
description: Enable address suggestions to auto-populate the address fields in contact, lead, and account forms based on a location selected in the Bing Map.  
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: get-started 
ms.date: 06/14/2023
ms.custom: bap-template
---

## Enable address suggestions

Enable address suggestions to help sellers save time and reduce errors while entering address information. When a seller starts typing in the address field, a list of possible addresses based on the entered text are displayed. Once the seller selects the correct address from the list of suggestions, the address fields in the form are filled out automatically. This feature is available for contact, lead, and account forms.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## To enable address suggestions

1. In the Sales Hub app, select **Settings**, **Advanced Settings**.
1. Select **Administration**, **System Settings**.
1. In the **General** tab, under **Enable Bing Maps**, select **Yes**.
1. Save the changes.
1. Select the Change area in the Sales Hub app, and then select **App Settings**.
1. Go to **General Settings** > **Productivity Tools** > **Enable address suggestions**.
1. Turn on the toggle and save the changes.
1. Verify the changes by opening a contact, lead, or account form.
    You'll see a new **Address** field and a Bing map after all the address fields as shown in the following image.
    :::image type="content" source="media/address-suggestion-field.png" alt-text="Screenshot of the new address field in a form":::


## Auto-populate address fields with address suggestions

1. Open a contact, lead, or account form that has address fields.
1. Scroll down to the **Address** field and start typing the address.
1. Select an address from the list of suggestions and press the Enter key.
    The address fields are auto-populated with the details in the selected address.