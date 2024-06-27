---
title: Process a return
description: Learn about how to process a return in Dynamics 365 Field Service
ms.date: 06/26/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Process a return (RMA and RTV)

To process a return of a product or customer asset, create a return merchandise authorization (RMA) and then an RMA receipt. In addition, if the return is going to a vendor, create a return to vendor (RTV). Learn more about [returns](inventory-purchasing-returns-overview.md#returns).
  
## Create an RMA  
  
1. In Field Service, change to the **Inventory** area. Under **Inventory**, select **RMAs**, and then select **New**.
  
1. Enter the following information:

   - **Work Order**: If the product was used in a work order, choose the work order. The related **Service Account** is automatically filled in.  

   - **Substatus**: If you want an RMA substatus such as exchange, repair, retire, or upgrade, choose one or create a new one.

   - **Ship Via**: If you want to track how the return is transported such as freight shipping, USPS Ground, or FedEx, choose one or create a new one.

1. Select **Save**.

:::image type="content" source="media/inventory-rma.svg" alt-text="Screenshot of an RMA.":::
  
### Add RMA products

 Once an RMA is created, add the products to be returned. There are two ways to add RMA products — either manually or by choosing a product that was used on a work order.  

#### Add products manually

1. In the RMA record, go to the **Product** section, and then select **Add RMA Product Record**.

1. Use the tooltips to help fill in your information, and then select **Save & Close**.  

#### Add products used in a work order

A work order must be associated with the RMA.  
  
1. In the RMA record, on the command bar at the top, select **Add WO Products**.  
  
1. Use the tooltips to help fill in your information about the products being returned. Then, select **Ok**.  

## Create an RMA receipt

Once the RMA products are received, create an RMA receipt.
  
1. From the RMA, select **Related** > **Receipts**.
  
1. Select **New RMA Receipt**.  
  
1. Use the tooltips to help fill in your information. Then, select **Save & Close**.
  
### Add RMA receipt products  
  
1. From the RMA receipt record, select **Related** > **Recipt Products** section.  
  
1. Select **New RMA Receipt Product**.  
  
1. Enter the **RMA Product** and **Quantity** received.  
  
1. Select **Save * Close**.  

For products that are tracked in inventory and for returns going to warehouses, an inventory journal is created automatically in the background that increases the "On Hand" warehouse quantity by the RMA receipt product quantity.

## Create an RTV (optional)

If the return is going back to the vendor, create an RTV.
  
1. In the RMA record, on the command bar at the top, select **Create RTV.**
  
1. Review the details, and then select **OK**.  
  
1.  A dialog box opens, confirming the RTV has been created.  
  
4.  To see the RTV record, from the main menu go to **Field Services** > **Inventory tab** > **RTVs**.  
  
5.  Choose the RTV record that you created to open the record.  
  
6.  To track the return, mark when it was approved, shipped, and received.  
  
7.  To credit the customer, go to the RMA, and then click **RMA Product**.  
  
8. Set **Credit to Account** to **Yes**.  
  
9. Select **Save**.  
  
10. To issue a credit memo, go back to the RMA, and then to **RMA Receipts**.  
  
11. Select the RMA receipt.  
  
12. On the command bar at the top, select **Credit to Customer**.  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
