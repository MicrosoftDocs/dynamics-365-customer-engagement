---
title: Disable customer asset validation on work orders (contains video)
description: Learn how to allow customer assets on work orders that aren't related to the service account in Dynamics 365 Field Service.
ms.date: 01/24/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
search.app: 
  - D365CE
  - D365FS
---

# Disable customer asset validation on work orders

Normally, work orders can include only [customer assets](assets.md) that are related to the service account. You can disable customer asset validation and allow work orders to include assets that are related to other accounts. For example, in a rent or lease scenario, a service provider may own an asset, but work orders refer to the customer who's using it.

1. In Field Service, select the **Settings** area. Under **General**, select **Field Service Settings**.

1. In the **Work Order / Booking** tab, turn on **Disable Customer Asset Validation** to allow work orders to search all assets, not just assets related to the service account.

1. Turn on **Suggest Reparenting Customer Assets** to allow work order owners to change the service account of the work order to match the account of the customer asset.

    :::image type="content" source="media/customer-asset-settings-validation.png" alt-text="Screenshot of the Field Service settings page.":::

1. Select **Save**.

Watch a brief video on how to [disable customer asset validation and suggest account reparenting](https://youtu.be/kFgGuO_36oI).

### See also

[Create assets in Dynamics 365 Field Service](assets.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
