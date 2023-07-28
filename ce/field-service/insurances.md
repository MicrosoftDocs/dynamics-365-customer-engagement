---
title: Create insurances (preview)
description: Create an insurance in Field Service to protect from financial loss.
ms.date: 06/23/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Create insurances (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

An insurance policy protects from financial loss in exchange for a fee. An insurance provider agrees to compensate the insurance holder in the event of a certain loss or damage. Insurances are contracts, represented by a policy, in which a policy holder gets protection for a fee from an insurance company.

In Dynamics 365 Field Service, insurances are records that relate to accounts and define the policy holder, insurance carrier, policy number, and the start/end date of the insurance contract.

## Enable insurances

Before users can work with insurance, a Field Service administrator has to enable the feature after [updating to the early access release](/dynamics365/get-started/release-schedule).

In Field Service, change to the **Settings** area. Under **General**, select **Field Service Settings**. On the **Features** tab, set **Insurances** to **On**.

## Create an insurance

1. In Field Service, change to the **Service** area.
1. Under **Service Delivery**, select **Insurance**.
1. Select **New** to create an insurance record and enter the information for the insurance.
1. Save the record.

:::image type="content" source="media/insurance.svg" alt-text="Screenshot of an insurance record.":::

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
