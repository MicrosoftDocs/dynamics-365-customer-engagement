---
title: Disable customer asset validation on work orders (contains video)
description: Learn how to allow customer assets on work orders that aren't related to the service account in Dynamics 365 Field Service.
ms.date: 07/01/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Disable customer asset validation on work orders

Usually, work orders can include only [customer assets](assets.md) that are related to the service account. However, you can disable customer asset validation and allow work orders to include assets that are related to other accounts. For example, in a rent or lease scenario, a service provider might own an asset, but work orders refer to the customer who uses that asset.

1. In Dynamics 365 Field Service, select the **Settings** area.
1. Under **General**, select **Field Service Settings**.
1. On the **Work Order / Booking** tab, turn on the following settings:

    - **Disable Customer Asset Validation**: Allow work orders to search all assets, not just assets that are related to the service account.
    - **Suggest Reparenting Customer Assets**: Allow work order owners to change the service account of the work order so that it matches the account of the customer asset.

    :::image type="content" source="media/customer-asset-settings-validation.svg" alt-text="Screenshot of the Field Service settings page, with the Disable Customer Asset Validation and Suggest Reparenting Customer Assets options highlighted.":::

1. Select **Save**.

## Related information

- [Create assets in Dynamics 365 Field Service](assets.md)
- [Video: Disable Customer Asset validations and suggest account re-parenting](https://youtu.be/kFgGuO_36oI)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
