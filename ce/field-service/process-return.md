---
title: Process a return (RMA and RTV)
description: Learn how to process a return in Dynamics 365 Field Service.
ms.date: 07/07/2026
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Process a return (RMA and RTV)

To process a return of a product or customer asset, create a return merchandise authorization (RMA) and then an RMA receipt. In addition, if the return goes to a vendor, create a return to vendor (RTV). [Learn more about returns.](inventory-purchasing-returns-overview.md#returns)

## Create an RMA

1. In Dynamics 365 Field Service, select the **Inventory** area.

1. Under **Inventory**, select **RMAs** and then select **New**.

1. Enter the following information:

    - **Work Order**: If the product was used on a work order, select the work order. The related service account is automatically filled in.
    - **Substatus**: If you want an RMA substatus, select or create one. Examples of substatuses include exchange, repair, retire, and upgrade.
    - **Ship Via**: If you want to track the method of transport for the return, select or create one. Examples of methods of transport include freight shipping, USPS Ground, and FedEx.

1. Enter optional information if available such as tracking numbers.

1. Select **Save**.

   :::image type="content" source="media/inventory-rma.png" alt-text="Screenshot of an RMA.":::

### Add RMA products

After you create an RMA, add the products that someone can return. You can manually add RMA products, or you can add products that were used on a work order.

#### Add products manually

1. In the RMA record, on the **Products** tab, select **Add New RMA Product**.

1. Enter the following information:

    - **Quantity**: Enter the quantity of the product that is being returned.
    - **Product**: Select the product that is being returned.
    - **Processing Action**: Select what should happen to the returned item after it's received.
        - **Create RTV**: The product is sent back to the supplier or manufacturer. Indicate the vendor in the **Vendor** field.
        - **Return to warehouse**: The product is returned to inventory in a warehouse. Indicate the warehouse in the **Return to Warehouse** field.
        - **Change Asset Ownership**: The asset belongs to a different account. Indicate the new account in the **Change Ownership** field.

1. Select **Save & Close**.

#### Add products used on a work order

> [!NOTE]
> You can use this method only if a work order is associated with the RMA.

1. In the RMA record, on the command bar at the top, select **Add Work Order Product**.

1. Enter the following information:

    - **Work Order Product**: Select the product that was used on the work order.
    - **Quantity to Return**: Enter the quantity of the product that was used on the work order that is being returned.
    - **Processing Action**: Select what should happen to the returned item after it's received.
        - **Create RTV**: The product is sent back to the supplier or manufacturer. Indicate the vendor in the **Vendor** field.
        - **Return to warehouse**: The product is returned to inventory in a warehouse. Indicate the warehouse in the **Return to Warehouse** field.
        - **Change Asset Ownership**: The asset belongs to a different account. Indicate the new account in the **Change Ownership** field.

1. Select **OK** and then confirm.

1. Select **Save & Close**.

## Create an RMA receipt

After the appropriate user receives the RMA products, create an RMA receipt.

1. Open the RMA record, select **Related** > **Receipts**.

1. Select **New RMA Receipt**.

1. Enter a name for the receipt and the date the product is received.

1. Select **Save**.

### Add RMA receipt products

1. In the RMA receipt record, select **Related** > **Receipt Products**.

1. Select **New RMA Receipt Product**.

1. Enter the following information:

   - **RMA Product**: the product that is received.
   - **Quantity**: the quantity that is received.

1. Select **Save & Close**.

For products that are tracked in inventory, and for returns that go to warehouses, the system automatically creates an inventory journal. This inventory journal increases the on-hand quantity in the warehouse by the quantity of the RMA receipt product.

## Create an RTV (optional)

If the return goes back to the vendor, create an RTV.

1. In the RMA record, on the command bar at the top, select **Create RTV**.

1. Review the details, and then select **OK** and confirm.

1. To view the RTV record, on the main menu, go to **Field Services** > **Inventory** > **RTVs**.

1. Select the RTV record that you created to open it.

1. To track the return, update the **System Status** value when the return is approved, shipped, and received.

### Credit the customer (optional)

1. Open the RMA, and then select **Related** > **Receipts**.

1. Edit the receipt and update the **RMA Product** value.

1. Set the **Credit to Account** field to *Yes*, and then select **Save**.

    :::image type="content" source="media/inventory-rma-product-credit-customer.svg" alt-text="Screenshot of an RMA product, showing a credit to the customer.":::

1. To issue a credit memo, return the RMA, and then go to **RMA Receipts**.

1. Select the RMA receipt.

1. On the command bar at the top, select **Credit To Customer**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
