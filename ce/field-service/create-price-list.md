---
title: "Create a price list (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
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
ms.assetid: e8ecd5c3-002a-4482-b265-72e061d12132
caps.latest.revision: 16
ms.author: krbjoran
manager: shellyha
---
# Create a price list (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Price lists in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] define pricing levels. When you use a price list, you can specify how much a customer is charged for your product and services. The price list is noted on the account, work order, agreement, or the individual product or service. 
  
<a name="BKMK_CreateNewPriceList"></a>   
## Create a new price list  
  
1.  From the top menu, click **Field Service** > **Administration**, and then choose **Price Lists**.  
  
2.  On the **Active Price Lists** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then click **Save**.  
  
<a name="BKMK_AddFieldSvcPriceListItems"></a>   
## Add [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] price list items  
 [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] price list items let you associate service (or labor) type productsfrom the product catalogwith a price list, with properties that are relevant to labor products.  
  
1.  From the top menu, click the drop-down arrow next to the price list name that you created, and then click **Field Service Price List Item**.  
  
2.  Click **Add New Field Service Price List Item**.  
  
3.  Use the tooltips to help fill in your information:  
  
    -   Name the price list  
  
    -   Select the Product/Service this applies to from the drop-down list.  
  
         If this price list item is a service you can:  
  
        -   Select **Duration Round To**  
  
        -   Select **Duration Rounding Policy**  
  
        -   Choose **Yes** or **No** for **Flat Fee**  
  
        -   Choose **Minimum Charge Amount**  
  
        -   Choose **Minimum Charge Duration**  
  
4.  Click **Save & Close**.  
  
<a name="BKMK_AddPriceListItems"></a>   
## Add price list items  
 Create a price list item for each unit in which the product is available. For example, if the product is available as a single item (each), in a dozen, and in a gross, create three price list items. This lets you order the product in any quantity you want, using the same price list. You can add price list items from the product form also.  
  
1.  In the price list record, in the **Price List Items** section, click the **Add Price List Item record**.  
  
2.  Use the tooltips to help fill in your information:  
  
    -   In the **Product** and **Unit** field, select the product and unit for which you're creating this price list item.  
  
    -   To offer a discount on the combination of the product and unit, select a **Discount List**.  
  
    -   In the **Quantity Selling Option** drop-down list, select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of **Quote Product**, **Order Product**, and **Invoice Product** records.  
  
        - **No Control**. [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] doesn't enforce a quantity selling option.  
  
        - **Whole**. Selling a partial product isn't allowed. For example, digital cameras cannot be sold in fractions.  
  
        - **Whole and Fractional**. The product can be sold in both whole and fractional units. For example, wood chips can be sold in cubic yards, or in fractions of a cubic yard.  
  
    -   In the **Pricing Method** drop-down list, select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost.  
  
    -   If you selected **Currency Amount** as the pricing method, in the Amount field, type the amount at which the product will be sold.  
  
    -   -OR-  
  
         If you selected any value other than **Currency Amount**, you can set up a rounding policy. For example, if you want per-unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, select the rounding policy to round the price up, and then set the price to end in a certain amount, like 99 cents.  
  
        - **None**. Prices are not rounded.  
  
        - **Up**. Prices are roundedup to the nearest rounding amount.  
  
        - **Down**. Prices are roundeddown to the nearest rounding amount.  
  
        - **To Nearest**. Prices are rounded to the nearest rounding amount.  
  
    -   In the **Rounding Options** drop-down list, select **Ends In** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.  
  
    -   In the **Rounding Amount**field, enter the amount.  
  
3.  Click **Save**.  
  
<a name="BKMK_AddTerritoryRelationships"></a>   
## Add territory relationships  
 Add default price lists for territories or customer segments. This makes it easier for your [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] team to see the default price list for the area they are working in. You can have one price list as the default for multiple territories.  
  
1.  In the price list record, in the **Territory Relationships** section, click **+Add Connection record**.  
  
2.  In the **Connections** form, in **Name**, click the **Lookup** button, and then select a territory.  
  
3.  Click **Save & Close**.  
  
4.  In the price list form, click the **Auto Save** button.  
  
### See also    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Create a product or service](../field-service/create-product-or-service.md)   
 [Set up purchase order sub-statuses](../field-service/set-up-purchase-order-sub-statuses.md)   
 [Create a warehouse](../field-service/create-warehouse.md)   
 [Create ship via](../field-service/create-ship-via.md)   
 [Create an RMA sub-status](../field-service/create-rma-sub-status.md)   
 [Set up RTV sub-statuses](../field-service/set-up-rtv-sub-statuses.md)   
 [Process a return](../field-service/process-return.md)<br>
 [User's Guide](../field-service/user-guide.md)
