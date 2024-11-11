---
title: Create products or services for work orders
description: Learn how to create products or services for work orders in Dynamics 365 Field Service.
ms.date: 08/01/2024
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---

# Create products or services for work orders

Dynamics 365 Field Service uses the Dynamics 365 [product catalog](../sales-enterprise/set-up-product-catalog-walkthrough.md) and [price lists](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md) for on-site service. Field technicians can use the same products for work orders that salespeople use for opportunities, quotes, and orders.

- **Product** is an item a field technician might record while completing a work order for which the client might be billed. Products can be physical items, like a battery or a part, or might be nonphysical components, like an oil change or an estimate. Both physical and nonphysical products are measured and sold in quantity of units. Many physical items are tracked as inventory. Nonphysical items aren't tracked as inventory.

- **Service** is work that a field technician performs and might bill the client for. Service is measured in time duration.

If a field technician uses a product or performs a service while on the job, they can then enter the work into the Field Service mobile app. Used products and performed services can be invoiced to customers based on the applicable price list or entitlement. Used products can be deducted from inventory levels either in the Field Service inventory module, Dynamics 365 Finance & Operations, or an external Enterprise resource planning (ERP) system.

> [!NOTE]
> Field Service doesn't support product bundles.

In this article, learn how to create products and services, add them to work orders, and review inventory settings.

## Create a product or service

1. In Field Service, change to the **Settings** area.

1. In the **General** section, select **Products**.

1. Select **Add Product** to create a new product.

1. Provide a **Name** and a **ProductID**.

1. Fill in other fields.

   - **Valid From** and **Valid To**: How long a product is valid for. There's no business logic associated with these fields, except that the **Valid To** date must be later than the **Valid From** date. If necessary, you can implement your own business logic. For example, run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.
   - **Unit Group**: A collection of units in which a product is sold, and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you might have a unit group called "Seeds" and define its primary unit as "packet."  
   - **Default Unit**: Quantities or measurements that you sell your products in. For example, if you add seeds as a product, you can sell them in packets, boxes, or pallets. Each becomes a unit of the product. If seeds are mostly sold in packets, select packets as the unit. For more information on units and unit groups, go to [Create a unit group and add units to that group (Sales app)](../sales-enterprise/create-unit-group-add-units-that-group.md).  

   - **Decimals Supported**: Number of decimal places to use for monetary amounts.

   :::image type="content" source="media/work-order-product-create.svg" alt-text="Screenshot of a product in the product details section.":::

1. In the **Field Service** section, choose a **Field Service Product Type** which is required to add a product or service to a work order.

   - **Inventory**: Products that are inventoried and have quantities tracked in a warehouse.  
   - **Non-inventory**: Items that are typically not inventoried. For example, stickers or zip ties.  
   - **Service**: Used to create service products, which represent the work that you sell to your customers. The quantity of service products is measured with a duration of time. Only service products can be associated with a work order as a service.

1. Fill in other fields.

   - **Convert to Customer Asset**: **Yes** indicates a customer asset record is automatically created when this product is used on a work order. Allows for tracking service history.
   - **List Price**: A default price of this product or service. This price is used if the product isn't added to a price list. For services, this price represents an hourly rate.
   - **Default vendor**: A vendor where this product was purchased from.
   - **Taxable**: Whether the product or service is taxable. This setting applies only if the work order is taxable. If the work order isn't taxable, work order products and services aren't considered taxable either, regardless of this setting.
  
1. Select **Save** to apply your changes.

1. In the **Product Details** section, enter a **Default Price list**. Select **Save**.

1. Optionally, [link knowledge articles to the product](field-service-km-link.md#link-related-entities-to-knowledge-articles). Learn more: [Knowledge management overview](field-service-km-overview.md).

## Add products and services to a price list

You can add products and services as price list items to the [price list](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md) of your choice.

:::image type="content" source="media/work-order-products-price-list-items.svg" alt-text="Screenshot of a list of price list items.":::

For more information, go to [Create a price list (Project Service)](/dynamics365/project-operations/psa/create-price-list).

## Add a product or service to a work order

After [creating a work order](create-work-order.md), you can add products and services to it. Work order products and services are typically added to work orders via work order incident types. For more information, go to [Create work order templates with incident types](configure-incident-types.md).

1. Open an existing work order.

1. In the **Products and services** section, select **Add product**.

   :::image type="content" source="media/work-order-product-add.svg" alt-text="Screenshot of a work order, showing the products section.":::

   OR

   Select **Services**, and then select **Add service**.

1. On the **General** tab, enter the following information:

   - **Product/Service** Choose a product or service, or create a new one.
   - **Line Status**: When a product or service is added to a work order, the system creates a new *Work Order Product* or *Work Order Service* record. By default, the status of that record is *Estimated*. When a field technician actually uses the product or performs the service, they change the status to *Used*. You can now bill the client for the used product or service.
   - **Taxable**: Set to **Yes** if you want the work order sales tax added to the price.
   - **Estimate Quantity/Duration**: Number of units or hours expected to complete the job.
   - **Warehouse**: If the product is allocated or used, enter the warehouse it came from. The field technician can also enter the warehouse after using the product when on site.
   - **Allocated**: Set to **Yes** if you want to set aside units of this product from a warehouse before actually using and removing them from inventory.

   Price information is taken from the price list first, then the product record, and calculated based on the quantity.

1. Select the **Product Relates To** tab.

     Work order products can be related to different aspects of the work order. The system automatically fills in values from existing related records. You can also fill in the fields manually to relate records. For example, if the product or service is added from a work order incident type, the system fills in the related incident. If the work order incident type relates to a specific customer asset, it lists that asset.

1. Select the **Other** tab and enter the following information:

   - **Price List**: Change the price list of a product or service from the work order price list, if necessary.
   - **Currency**: Override the default currency, if necessary.
   - **Disable Entitlement**: Disable entitlements, which are automatically applied based on factors like service account and incident type. For more information, go to [Entitlements for work orders](work-order-entitlements.md).
   - **Entitlement**: Choose the entitlement that applies to the product or service.
   - **Line Order**: Numerical value that defines in which order the products are shown on the work order. You can override the default value to change the order. The system tries to avoid duplicates.

1. Select **Save & Close**.

## Use products and services

Work order products and services aren't required. Field technicians can edit the quantity or add new items from the product catalog. Administrators use [security roles and field security profiles](users-licenses-permissions.md) to specify what users can edit, create, and delete.

On a work order product record, field technicians set the **Line Status** of a work order product to **Used**. They also enter a **Quantity**, which represents how many units were used and a **Quantity To Bill**.

For inventory items, technicians enter the warehouse it comes from to update the inventory. The system defaults to the warehouse value on the **Bookable Resource** associated with the user who creates the work order product record.

For noninventory items, technicians can mark the item as used and a quantity for reporting purposes.

On a work order service record, technicians set the **Line Status** to **Used** and enter a **Duration** and **Duration to Bill**.

As products and services are used, the subtotal based on price and quantity to bill is calculated on the work order.

Cost calculations populate after syncing or in online mode. Calculations don't update in offline mode.

When the work order is complete and the **System Status** is **Closed - Posted**, the system generates an invoice that includes used work order products and services.

:::image type="content" source="media/work-order-product-inv-adj.svg" alt-text="Screenshot of an invoice in Dynamics 365 Field Service.":::

## Add and use product inventory

If you manage the inventory of products in Field Service, you can use inventory adjustments to change the quantities in the product inventory. For more information, go to [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md).

## Review inventory settings

When creating products, [consider the product catalog settings](../sales/configure-product-catalog-settings.md).

In Field Service, review the following settings and change them if needed.

1. Select the **Settings** area and select **Field Service Settings**.

1. In the **Other** area, choose whether to **Auto Allocate Estimated Products**. By default, work order products aren't allocated from inventory.

1. In the **Purchase** area, set the **Use Of Products out of Stock**.

   - **Restrict** to prevent using a work order product when inventory in the specified warehouse is 0.
   - **Confirm** to display a warning message when there's an attempt to use a work order product and inventory is 0. This setting is helpful for situations where inventory levels are inaccurate or managed in an outside system.

[!INCLUDE[footer-include](../includes/footer-banner.md)]