---
title: Enable address suggestions
description: Enable address suggestions to auto-populate the address fields in contact, lead, and account forms based on a location selected in the Bing Map.  
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: get-started 
ms.date: 06/26/2023
ms.custom: bap-template
---

# Enable address suggestions

Enable address suggestions to help sellers save time and reduce errors while entering address information in the contact, lead, and account form. When a seller starts typing in the address field, Bing Maps displays a list of possible addresses based on the entered text. Once the seller selects the correct address from the list of suggestions, the address fields in the form are filled automatically.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Enable Bing Maps

Enabling maps lets sellers see a map view on account, contact, and lead forms. Enabling Bing Maps is also mandatory for getting address suggestions.

Bing Maps is enabled by default for new environments outside the EU. EU customers can opt in to use Bing Maps with the privacy notice and consent to share data with an external system.

> [!IMPORTANT]
> By connecting to a mapping service, you are allowing the system to share your data. Data includes - but is not limited to - addresses and coordinates, with external systems outside of your Microsoft Dynamics 365 environment. ("Mapping service" refers to Bing Maps or other third-party mapping service designated by you or your operating system). This also applies to Government Cloud environments. Your use of the mapping service will also be subject to their separate terms of use. Data imported from such external systems into Microsoft Dynamics 365 are subject to the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement).

1. In the Sales Hub app, select **Settings** > **Advanced Settings**.

1. Select **Administration** > **System Settings**.
1. In the **General** tab, under **Enable Bing Maps**, select **Yes**.
1. Save the changes.


## Enable address suggestions for Sales forms

1. Select the Change area in the Sales Hub app, and then select **App Settings**.

1. Go to **General Settings** > **Productivity Tools** > **Enable address suggestions**.
1. Turn on the toggle and save the changes.
1. Verify the changes by opening a contact, lead, or account form.
    You'll see a new **Address** field and a Bing map after all the address fields. The field suggests addresses as you type and will populate address fields once you select an address, as shown in the following image.  
    :::image type="content" source="media/address-suggestion-field.png" alt-text="Screenshot of the Address suggestion field and the Bing map.":::

> [!NOTE]
> If your organization is using Dynamics 365 Field Service and has [enabled address suggestions](/dynamics365/field-service/field-service-maps-address-locations#enable-address-suggestions), then the address suggestions for the main contact, account forms will be controlled by the Field Service settings.  