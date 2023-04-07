---
title: "Revise products (Dynamics 365 Sales) | MicrosoftDocs"
description: "Keep the product inventory updated by quickly revising the products in Dynamics 365 Sales."
ms.date: 02/10/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
---
# Revise products 

Keep the product inventory updated by quickly revising properties for the products as required, and republishing the information so that your sales agents can see the latest changes to the inventory.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|



## Revise a product

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
2. Select the site map ![Site Map icon.](media/site-map-icon.png "site map icon"), and then select **Products**. 
    
3. Open an active product, bundle, or family you want to change, and on the command bar, select **Revise**.  

   > [!div class="mx-imgBorder"]
   > ![Revise Product button on the Product form.](media/revise-product.png "Revise Product button on the Product form")
  
4. In the **Confirm Revise** dialog box, select **Confirm**.

   ![Confirm revision of product.](media/confirm-revise.png "Confirm revision of product")

    This will change the product status to **Under Revision**.  
  
5. Change the product properties, as required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](use-properties-describe-product.md)  
  
6. After you're done making the changes, on the command bar, select **Publish** or **Publish Hierarchy**.  
  
   > [!TIP]
   > 
   >  If some of the product properties-related information that you changed doesn't align with the customer or business needs, revert the changes and continue with the last active version of the product. To do this, select **Revert**. This changes the status of the product back to **Active**.  
  
   Revising a family sets all the products and bundles under it to the **Under Revision** state.   

 
## Typical next steps  
 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Retire a product](retire-product.md)  
  ![Home button](media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  
 [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
