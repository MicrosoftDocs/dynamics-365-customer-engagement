---
title: "Using and extending Price lists for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/23/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: e8ecd5c3-002a-4482-b265-72e061d12132
caps.latest.revision: 16
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
# Using and extending Price lists for Field Service

Field Service uses and extends Dynamics 365 price lists and product catalog. This means products and services are added to work orders with appropriate pricing.  

In this article let's explore creating products, services, and price lists to use on work orders.

## Prerequisites 

Using Dynamics price lists product catalog for Field Service is available for all version of Dynamics 365 Field Service

Basic knowledge of Dynamics 365 [product catalog](https://docs.microsoft.com/en-us/dynamics365/sales-enterprise/set-up-product-catalog-walkthrough) and [price lists](https://docs.microsoft.com/en-us/dynamics365/sales-enterprise/create-price-lists-price-list-items-define-pricing-products) is encouraged. 

## Create products and services

First create Field Service products and services that can be added to work orders. This is done by creating products and entering a Field Service Product Type.


For more explicit instructions, see the topic on [creating Field Service products and services](./create-product-or-service.md). 


In summary, go to **Field Service app > Settings > Products > +New** and use the tooltips to add basic details about the product or service.

For this exercise in using Field Service Price List Items to extend price lists, start by creating a service.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/price-list-service-create.png)

In the Field Service section, enter a **Field Service Product Type** = service.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-service.png)

- **Inventory**: This option is used for products of high value, or products that are inventoried and have quantities tracked in a warehouse.  
  
- **Non-inventory**: This option is used for low-value items that are typically not inventoried. Examples of this are consumables like stickers or zip ties.  
  
- **Service**: The service option is used to create service products, which is the labor that you sell to your customers. The quantity of service products is measured with a duration of time. Only service products can be associated with a work order as a service. 

Here are examples of inventory and non-inventory products.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-field-service.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create-non-inventory.png)

> [!Note]
> It's important to add a List Price to the product that will be used as a back up for when this product may be used on a work order but does not belong to the work order's price list as a price list item or field service price list item, as described later in this article.

After saving, enter a **Default Price list** in the product details section, then **Save** again.


## Create price list  
  
1.  From the top menu, click **Field Service** > **Administration**, and then choose **Price Lists**.  
  
2.  On the **Active Price Lists** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then click **Save**.  

Next, add the products and services as price list items to the price lists of your choice.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-products-price-list-items.png)

For more information see the topic on [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [creating a price list (Project Service Automation)](../project-service/create-price-list.md). 


## Add price list items  
 Create a price list item for each unit in which the product is available. For example, if the product is available as a single item (each), in a dozen, and in a gross, create three price list items. This lets you order the product in any quantity you want, using the same price list. You can add price list items from the product form also.  
  
1. In the price list record, in the **Price List Items** section, click the **Add Price List Item record**.  
  
2. Use the tooltips to help fill in your information:  
  
   - In the **Product** and **Unit** field, select the product and unit for which you're creating this price list item.  
  
   - To offer a discount on the combination of the product and unit, select a **Discount List**.  
  
   - In the **Quantity Selling Option** drop-down list, select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of **Quote Product**, **Order Product**, and **Invoice Product** records.  
  
     - **No Control**. [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] doesn't enforce a quantity selling option.  
  
     - **Whole**. Selling a partial product isn't allowed. For example, digital cameras cannot be sold in fractions.  
  
     - **Whole and Fractional**. The product can be sold in both whole and fractional units. For example, wood chips can be sold in cubic yards, or in fractions of a cubic yard.  
  
   - In the **Pricing Method** drop-down list, select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost.  
  
   - If you selected **Currency Amount** as the pricing method, in the Amount field, type the amount at which the product will be sold.  
  
   - -OR-  
  
      If you selected any value other than **Currency Amount**, you can set up a rounding policy. For example, if you want per-unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, select the rounding policy to round the price up, and then set the price to end in a certain amount, like 99 cents.  
  
     - **None**. Prices are not rounded.  
  
     - **Up**. Prices are roundedup to the nearest rounding amount.  
  
     - **Down**. Prices are roundeddown to the nearest rounding amount.  
  
     - **To Nearest**. Prices are rounded to the nearest rounding amount.  
  
   - In the **Rounding Options** drop-down list, select **Ends In** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.  
  
   - In the **Rounding Amount**field, enter the amount.  
  
3. Click **Save**.  
  

## Add Field Service Price list items

You can add additional pricing options for services by creating Field Service Price List Items. A service is defined as a product record where Field Service Product Type = Service.

From the Price List go to **Related > Field Service Price List Items**

  
Click **Add New Field Service Price List Item**.  
  
Use the tooltips to help fill in your information:  

### Flat Fee

Makes a service a fixed price regardless of duration

### Minimum Charge Duration

First X amount of time free

### Minimum Charge Amount

Sets minimum amount for a visit. Value will be added on to final price regardless of amount charged.

### Duration Rounding Policy & Duration Rounding To

Allows you to round service duration and choose the granularity. As an example, if a service duration is 94 minutes, you can automatically round it to 90 minutes, 95 minutes, remain as 94 minutes or other options.

          
> [!Note]
> By leaving the Product / Service lookup blank, the above options will apply to all services added to the work order with the chosen price list. THis is helpful if for example, you want to add a minimum charge amount to all services in the price list, you do not need to add all services as Field Service Price List Items, saving time.
 

**Save & Close**.  

## Add price lists to work orders

Price lists in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] define pricing levels. When you use a price list, you can specify how much a customer is charged for your product and services. The price list is noted on the account, work order, agreement, or the individual product or service. 
  
## Additional notes

- You can add a Field Service Price List Item even if the product or service is not a price list item. In this case the list price on the product record will be used for calculations.


### Add territory relationships  
 Add default price lists for territories or customer segments. This makes it easier for your [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] team to see the default price list for the area they are working in. You can have one price list as the default for multiple territories.  
  
1. In the price list record, in the **Territory Relationships** section, click **+Add Connection record**.  
  
2. In the **Connections** form, in **Name**, click the **Lookup** button, and then select a territory.  
  
3.  Click **Save & Close**.  
  
4.  In the price list form, click the **Auto Save** button.  
  
### See also    
  
 [Create a product or service](../field-service/create-product-or-service.md)   
 [Getting started with Field Service](../field-service/user-guide.md)
 [Create work order templates with incident types](../field-service/configure-incident-types.md)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-product-create.png)