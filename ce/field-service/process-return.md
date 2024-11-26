---
title: Process a return (RMA and RTV)
description: Learn how to process a return in Dynamics 365 Field Service.
ms.date: 07/01/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Process a return (RMA and RTV)

To process a return of a product or customer asset, create a return merchandise authorization (RMA) and then an RMA receipt. In addition, if the return is going to a vendor, create a return to vendor (RTV). [Learn more about returns.](inventory-purchasing-returns-overview.md#returns)

## Create an RMA

1. In Dynamics 365 Field Service, select the **Inventory** area.
1. Under **Inventory**, select **RMAs**.
1. Select **New**.
1. Enter the following information:

    - **Work Order**: If the product was used on a work order, select the work order. The related service account is automatically filled in.
    - **Substatus**: If you want an RMA substatus, select or create one. Examples of substatuses include exchange, repair, retire, and upgrade.
    - **Ship Via**: If you want to track the method of transport for the return, select or create one. Examples of methods of transport include freight shipping, USPS Ground, and FedEx

1. Select **Save**.

:::image type="content" source="media/inventory-rma.svg" alt-text="Screenshot of an RMA.":::

### Add RMA products

After you create an RMA, add the products that can be returned. You can manually add RMA products, or you can add products that were used on a work order.

#### Add products manually

1. In the RMA record, in the **Product** section, select **Add RMA Product Record**.
1. Use the tooltips to help fill in your information.
1. Select **Save & Close**.

#### Add products used on a work order

> [!NOTE]
> You can use this method only if a work order is associated with the RMA.

1. In the RMA record, on the command bar at the top, select **Add WO Products**.
1. Use the tooltips to help fill in information about the products that are being returned.
1. Select **OK**.

## Create an RMA receipt

After the RMA products are received, create an RMA receipt.

1. In the RMA record, select **Related** > **Receipts**.
1. Select **New RMA Receipt**. 
1. Use the tooltips to help fill in your information.
1. Select **Save & Close**.

### Add RMA receipt products

1. In the RMA receipt record, select **Related** > **Receipt Products**.
1. Select **New RMA Receipt Product**.
1. In the **RMA Product** field, enter the product that was received.
1. In the **Quantity** field, enter the quantity that was received.
1. Select **Save & Close**.

For products that are tracked in inventory, and for returns that are going to warehouses, an inventory journal is automatically created. This inventory journal increases the on-hand quantity in the warehouse by the quantity of the RMA receipt product.

## Create an RTV (optional)

If the return is going back to the vendor, create an RTV.

1. In the RMA record, on the command bar at the top, select **Create RTV**.
1. Review the details, and then select **OK**.
1. To view the RTV record, on the main menu, go to **Field Services** > **Inventory** > **RTVs**.
1. Select the RTV record that you created to open it.
1. To track the return, update the **System Status** value when the return is approved, shipped, and received.
1. To credit the customer, open the RMA, and then edit the **RMA Product** value.
1. Set the **Credit to Account** field to *Yes*, and then select **Save**.

    :::image type="content" source="media/inventory-rma-product-credit-customer.svg" alt-text="Screenshot of an RMA product, showing a credit to the customer.":::

1. To issue a credit memo, return the RMA, and then go to **RMA Receipts**.
1. Select the RMA receipt.
1. On the command bar at the top, select **Credit to Customer**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
