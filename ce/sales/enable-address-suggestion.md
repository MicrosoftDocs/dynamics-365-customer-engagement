---
title: Enable address suggestions
description: Learn how to enable the address suggestion feature in Dynamics 365 Sales to help sellers save time and reduce errors when they enter address information.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to
ms.collection: get-started
ms.date: 06/26/2023
ms.custom:
 - bap-template
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:08/30/2023
---

# Enable address suggestions

Enable the address suggestion feature in Dynamics 365 Sales to help sellers save time and reduce errors when they enter the addresses of their contacts, leads, and accounts. When a seller starts typing in the address field, Bing Maps suggests a list of addresses that match what the seller is typing. When the seller selects an address in the list, the address fields in the form are filled automatically. You need to enable Bing Maps before you can enable address suggestions.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br/>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br/> More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Enable Bing Maps

When you enable Bing Maps in the Sales settings, sellers can see the address of their accounts, contacts, and leads on a map and get directions. You must enable Bing Maps before you can enable the address suggestion feature in Sales.

Bing Maps is enabled by default in new environments that are located outside the European Union (EU). To opt in to use Bing Maps, EU customers must view the privacy notice and consent to share data with an external system.

> [!IMPORTANT]
> By connecting to a mapping service, you consent to allow the system&mdash;including systems in Government Cloud environments&mdash;to share your data. "Mapping service" refers to Bing Maps or any other third-party mapping service that's designated by you or your operating system. Data that's shared with external systems outside of your Microsoft Dynamics 365 environment includes, but is not limited to, addresses and coordinates. Your use of the mapping service is also subject to the service's separate terms of use. Data imported from external systems into Microsoft Dynamics 365 are subject to the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement).

1. In the Sales Hub app, select **Settings** (the gear icon in the upper-right corner of the window) > **Advanced Settings**.
   > [!NOTE]
   > The **Advanced Settings** page is moving from the web client to an Unified Interface app. If your organization has enabled the public preview of the **Advanced settings redirection** feature, you’ll see the settings open in the Power Platform Environment Settings app. Find more information about the app and navigation path in [Advanced settings in the new experience](advanced-settings-new-experience.md).

1. Select **Administration** > **System Settings** > **General**.

1. Under **Enable Bing Maps**, select **Yes**.

1. Save the changes.

## Enable the address suggestion feature

1. In the Sales Hub app at the bottom of the left side panel, select **App Settings**.

1. Go to **General Settings** > **Productivity tools** > **Enable address suggestions**.

1. Turn on the toggle and select **Save**.

To verify the changes, open a contact, lead, or account form. You should see a new **Address** field and a Bing map after all the individual address fields. The field suggests addresses as you type and populates address fields when you select an address

> [!NOTE]
> If your organization is using Dynamics 365 Field Service and has [enabled address suggestions](/dynamics365/field-service/field-service-maps-address-locations#enable-address-suggestions), then the address suggestions for the main contact and account forms are controlled by the Field Service settings.

