---
title: "Publish a product or bundle to make it available for selling (Dynamics 365 Sales) | MicrosoftDocs"
description: "Publish a product or bundle in Dynamics 365 Sales to make it available to the sales agents so they can build orders or create opportunities for customers."
ms.date: 10/26/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
---
# Publish a product, family, or bundle to make it available for selling 

Publishing a product or bundle makes the product available for selling in Dynamics 365 Sales. Sellers can choose only published products and bundles when creating opportunities, quotes, and so on.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager, Sales Professional Manager, or Vice President of Sales <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Publish a product, family, or bundle

By default, product records are created in a draft state, and are available to your sales agents only after you publish it. For products that don't have a parent product family, you can create them directly in an active state using a system setting, so that you don't have to publish them after creation. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Sales tab](/power-platform/admin/system-settings-dialog-box-sales-tab)  

> [!NOTE]
> - You can only publish a product or bundle with a parent family if the parent product family is active.
> - Product families are only supported for Sales Enterprise and Sales Premium.  

1. Depending on the sales app that you're using, do one of the following:
 
    -  If you're using the Sales Hub app, 
        1. Select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") at the lower-left corner of the site map, and then select **App Settings**. 
        1. In the **Product Catalog** area, select **Families and Products**. 
   - If you're using the Sales Professional app,
       - Select **Products** from the site map.  
  
3. Select the product, bundle, or family you want to publish, and on the command bar, select **Publish**. 

    > [!div class="mx-imgBorder"]
    > ![Product form with the Publish button.](media/publish-product.png "Product form with the Publish button")

   This will change the product status to **Active** and make it available for selling.

> [!TIP]
> 
> You can't publish multiple product records at the same time. To publish all child products and families of a parent family at once, open the family, and choose **Publish** > **Publish Hierarchy**. For product records that don't belong to a product family, publish them individually after creating or editing them to make them available to your sales agents.
  
 
## Typical next steps  
 ![Right arrow button](media/walkthrough-orange-right-arrow.png "Right arrow button") [Revise a product](revise-product.md)  
  
 ![Right arrow button](media/walkthrough-orange-right-arrow.png "Right arrow button") [Retire a product](retire-product.md)  
  
 ![Home button](media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md) 
  
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  
 [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
