---
title: "Create a product or service (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: dyn365-fieldservice 
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: e6acfdb3-1580-4052-8895-8efbf98dfae8
caps.latest.revision: 15
ms.author: krbjoran
manager: shellyha
---
# Create a product or service (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The Product entity in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] contains information about products that may be sold to customers. Typical information stored in this entity are model number, manufacturer, warranty information, price, cost, etc. Products are usually added to work orders when an incident is added. Products added to a work order initially have a status of "estimated" and can be marked as "used," indicating that they were sold and billed to a client.  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Product**.  
  
2.  Click **Add Product**.  
  
3.  Fill in your information:  
  
    - **Unit Group**: Select a unit group. A unit group is a collection of various units a product is sold in, and defines how individual items are grouped into larger quantities. For example, if you're adding seeds as a product, you may have created a unit group called "Seeds", and defined its primary unit as "packet".  
  
    - **Unit**: Select the most common unit in which the product will be sold. Units are the quantities or measurements that you sell your products in. For example, if you've added seeds as a product, you can sell them in packets, boxes, or pallets. Each of these becomes a unit of the product. If seeds are mostly sold in packets, select packets as the unit.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a unit group and add units to that group (Sales app)](../sales-enterprise/create-unit-group-add-units-that-group.md)  
  
> [!NOTE]
> The **Valid From** and **Valid To** fields define how long a product is valid for. There's no business logic associated with these fields, except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in, or by using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.  
  
4.  Click **Save**.  
  
5.  In the **Product Properties** section, click **+Add Properties Record,** and then select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product (Sales app)](../sales-enterprise/use-properties-describe-product.md)  
  
6.  In the **Additional Details** section, click **+Add Price List Item record**, and then create a price list item for each unit the product is available in. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a price list (Project Service Automation)](../project-service/create-price-list.md)  
  
7.  In the **Product Relationships** section, click **+Add Product Relationship record**, and then select a related product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define related products to increase chances of sales (Sales app)](../sales-enterprise/define-related-products-increase-chances-sales.md)  
  
8.  In the **Field Service** section, fill in your information to define if what you are creating is a product or a service:  
  
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
  
### See also 
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Create a price list](../field-service/create-price-list.md)   
 [Set up purchase order sub-statuses](../field-service/set-up-purchase-order-sub-statuses.md)   
 [Create a warehouse](../field-service/create-warehouse.md)   
 [Create ship via](../field-service/create-ship-via.md)   
 [Create an RMA sub-status](../field-service/create-rma-sub-status.md)   
 [Set up RTV sub-statuses](../field-service/set-up-rtv-sub-statuses.md)   
 [Process a return](../field-service/process-return.md)
 [User's Guide](../field-service/user-guide.md)  
