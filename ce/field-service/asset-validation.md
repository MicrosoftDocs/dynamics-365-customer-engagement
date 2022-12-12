---
title: "Validate customer assets on work orders"
description: Learn how to configure the system to validate customer assets on work orders in Dynamics 365 Field Service.
ms.date: 12/08/2022
ms.reviewer: mhart
ms.topic: article
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Validate customer assets on work orders

You can configure the system to allow [customer assets](assets.md) on work order that are related to accounts other than the work order service account.

This configuration can be useful in the following scenarios:

- Rent or lease: A service provider owns the asset and work orders refer to the customer who is currently using the asset.

- [Warranty](warranties.md): A consumer owns the asset and work orders should relate to the manufacturer account who is responsible for the warranty.

1. In Field Service, change to the **Settings** area.

1. Go to **General** > **Field Service Settings**.

1. In the **Work Order / Booking** section, set **Disable Customer Asset Validation** to _Yes_. This setting enables the search across all assets in the system, not just assets related to the service account of a work order.

1. Set **Suggest Reparenting Customer Assets** to _Yes_ to give work order owners the option change the service account of the work order to match the account of the customer asset.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Field Service settings.](./media/customer-asset-settings-validation.png)

1. **Save** your changes.

For more information, see the video: ![Video symbol](../field-service/media/video-icon.png "Video symbol") [Disable customer asset validations and suggest account reparenting](https://youtu.be/kFgGuO_36oI)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
