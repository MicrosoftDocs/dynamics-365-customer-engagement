---
title: "Create products or services for Work Orders | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/16/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: e6acfdb3-1580-4052-8895-8efbf98dfae8
caps.latest.revision: 15
ms.author: krbjoran
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Create products or services for Work Orders

Field Service utilizes the Dynamics 365 product catalog for on site service. This means the same list of products sales persons use for Opportunities, Quotes, and Orders; field technicians can use on work orders.

By using the Product entity you can create products and services to add to work orders.

- **Products** represent physical items a field technician may use while completing a work order and may bill the client for, measured in quantity of units.
- **Services** represent labor a field technician may perform and may bill the client for, measured in time duration. 

After products and services are added to work orders, field technicians may use the products or perform the services during the on site service and will mark so in the Field Service Mobile app. Used products and services can be invoiced to customers based on the applicable price list or entitlement. Used products can be deducted from inventory levels either in the Field Service inventory module, Dynamics 365 Finance & Operations, or an external ERP system.

In this article, let's explore creating products and services, adding and using them on work orders, and invoicing and inventory considerations.

## Prerequisites

Using the product catalog for Field Service is available for all version of Dynamics 365 Field Service

Basic knowledge of Dynamics 365 [product catalog](https://docs.microsoft.com/en-us/dynamics365/sales-enterprise/set-up-product-catalog-walkthrough) and [price lists](https://docs.microsoft.com/en-us/dynamics365/sales-enterprise/create-price-lists-price-list-items-define-pricing-products) is encouraged. 


## Create a product or service

Go to Field Service > Products 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-field-service.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-service.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-non-inventory.png)






1. From the main menu, click **Field Service** > **Administration**, and then choose **Product**.  
  
2. Click **Add Product**.  
  
3. Fill in your information:  
  
   - **Unit Group**: Select a unit group. A unit group is a collection of various units a product is sold in, and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds", and defined its primary unit as "packet".  
  
   - **Unit**: Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you've added seeds as a product, you can sell them in packets, boxes, or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select packets as the unit.  
  
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a unit group and add units to that group (Sales app)](../sales-enterprise/create-unit-group-add-units-that-group.md)  
  
> [!NOTE]
> The **Valid From** and **Valid To** fields define how long a product is valid for. There's no business logic associated with these fields, except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in, or by using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.  
  
4. Click **Save**.  
  
5. In the **Product Properties** section, click **+Add Properties Record,** and then select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product (Sales app)](../sales-enterprise/use-properties-describe-product.md)  
  
6. In the **Additional Details** section, click **+Add Price List Item record**, and then create a price list item for each unit the product is available in. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a price list (Project Service Automation)](../project-service/create-price-list.md)  
  
7. In the **Product Relationships** section, click **+Add Product Relationship record**, and then select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales (Sales app)](../sales-enterprise/define-related-products-increase-chances-sales.md)  
  
8. In the **Field Service** section, fill in your information to define if what you are creating is a product or a service:  
  
   - **[!INCLUDE[pn_field_service](../includes/pn-field-service.md)] product type**  
  
       - **Inventory**: This option is used for products of high value, or products that are inventoried and have quantities tracked in a warehouse.  
  
       - **Non-inventory**: This option is used for low-value items that are typically not inventoried. Examples of this are consumables like stickers or zip ties.  
  
       - **Service**: The service option is used to create service products, which is the labor that you sell to your customers. The quantity of service products is measured with a duration of time. Only service products can be associated with a work order as a service.  
  
   - **UPC code**: Set up a UPC code. This is often used as the barcode value for the product, so when mobile users scan the matching barcode, the product is found.  
  
   - **Default vendor**: Enter a vendor.  
  
   - **Taxable**: Choose whether the product or service is taxable.  
  
9. Click **Save**.  
  
10. After you're done adding all the details,  review everything to ensure that it is correct. On the command bar, click **Preview**. The **Properties Preview** dialog box lets you verify how the product properties will appear to sales agents when they're selling the product or bundle.  
  
After you're done verifying everything, click **Done**.  

- price list
- price list item


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-products-price-list-items.png)



## Add a product or service to a work order

When a product or service is added to a work order, a new Work Order Product or Work Order Service record is created. It is given a status of **Estimated** by default, which means it has not been utilized yet. When a field technician actually uses the product or performs the service, he or she will change the work order product or service status to **Used** from the mobile device. Even after the product or service is used, field technicians and back office workers still have the option to bill the client or not.

- manual
  - inventory
  - non inventory
  - service
- incident


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-add.png)
- add or edit quanity
- add or edit price list


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-relates-to.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-service-add.png)

- add or edit duration
- add or edit price list

## Estimate vs Used



## Use and consume products and services

- FSM


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-services-mobile.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-service-add-mobile.png)


- calculations

> [!Note]
> calculations happen in online mode or on sync



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-add-mobile.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-mobile-subtotal.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-add-mobile-non-inventory.png)

- invoice  
Used products and services will appear on the invoice generated from the closed-posted work order and the price of each

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-invoice.png)

## Add and consume product inventory (Optional)

- warehouse
- inventory adjustment


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-inv-adj.png)

- inventory adjustment product


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-inv-adj-product.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-inventory.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-allocated.png)
- add quantity

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-add-mobile-warehouse.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-inv-journals.png)

## Configuration considerations

System Settings on the Sales tab related to Product setup. 
Product in Active Status upon creation.  Best practice is to set this to Yes.
Minimum # of Products in a Bundle.
Max # of Properties allowed for a Product or Bundle. 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-system-settings.png)


FS settings
- allocated by default


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-allocate-auto.png)

- use inventory past 0


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-use-product-out-stock.png)

## Additional notes


  
### See also  
 - [Create a price list](../field-service/create-price-list.md)    
 - [Create a warehouse](../field-service/create-warehouse.md)   

