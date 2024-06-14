---
title: Disable customer asset validation on work orders (contains video)
description: Learn how to allow customer assets on work orders that aren't related to the service account in Dynamics 365 Field Service.
ms.date: 06/13/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Disable customer asset validation on work orders

Normally, work orders can include only [customer assets](assets.md) that are related to the service account. You can disable customer asset validation and allow work orders to include assets that are related to other accounts. For example, in a rent or lease scenario, a service provider might own an asset, but work orders refer to the customer who's using it.

1. In Field Service, select the **Settings** area. Under **General**, select **Field Service Settings**.

1. In the **Work Order / Booking** tab, turn on the following settings:

   - **Disable Customer Asset Validation**: allow work orders to search all assets, not just assets related to the service account.

   - **Suggest Reparenting Customer Assets**: allow work order owners to change the service account of the work order to match the account of the customer asset.

    :::image type="content" source="media/customer-asset-settings-validation.svg" alt-text="Screenshot of the Field Service settings page.":::

1. Select **Save**.

### See also

- [Create assets in Dynamics 365 Field Service](assets.md)
- [Video how to disable customer asset validation and suggest account reparenting](https://youtu.be/kFgGuO_36oI)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
