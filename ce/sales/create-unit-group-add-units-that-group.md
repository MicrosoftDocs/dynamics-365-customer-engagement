---
title: "Create a unit group and add units to that group (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define the quantities or measurements that you sell your products or services in by using units in Dynamics 365 Sales."
ms.date: 10/26/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-uom
  - D365-Entity-uomschedule
  - D365-Entity-discount
  - D365-Entity-pricelevel
  - D365-Entity-productpricelevel
  - D365-Entity-discounttype
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Create a unit group and add units to that group 

Define the quantities or measurements that you sell your products or services in by using units in Dynamics 365 Sales.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager, Sales Professional Manager, or Vice President of Sales <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## What are unit groups and units?

Units are the quantities or measurements that you sell your products or services in. For example, if you sell gardening supplies, you might sell seeds in units of packets, boxes, and pallets. A unit group is a collection of these different units.  
  
 In [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], you first create a unit group and then create units within that group. Let's look at both of these tasks, using seeds as our example.  
 
## Create a unit group and add units

1. Depending on the sales app that you're using, do one of the following:
 
    -  If you're using the Sales Hub app, 
  
        1. Select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") at the lower-left corner of the site map, and then select **App Settings**. 
    
        1. In the **Product Catalog** area, select **Unit Groups**. 
  
   - If you're using the Sales Professional app, 

       - Select **Unit Groups** from the site map.

4. To create a new unit group, on the command bar, select **New**.

5.	Fill in your information, and select **OK**:

    a.	**Name**. Type a meaningful name for the unit group. In our example, you would type "Televisions."

    b.	**Primary Unit**. Type the lowest common unit of measure that the product will be sold in. In our example, you would type "Piece." Other examples could include box, cartons, ounces, hours, or tons, depending on your product.

    > [!div class="mx-imgBorder"]
    > ![Create unit group dialog box.](media/create-unit-group-dialog-box.png "Create unit group dialog box")
 
      > [!NOTE]
      > You cannot delete the primary unit in a unit group.

6.	To add units to the unit group, select the **Related** tab, and then select **Units**.

    > [!div class="mx-imgBorder"]
    > ![Units option on the Related tab.](media/units-option-on-related-tab.png "Units option on the Related tab")
 
7.	On the **Units** tab, you’ll see that the primary unit is already added. Select **Add New Unit**.

8.	In the **Quick Create: Unit** form, fill in the following, and select **Save**:

    a.	**Name**. Type a meaningful name for the unit. In our example, you would type "box."

    b.	**Quantity**. Type the quantity that this unit will contain. For example, if a box contains 2 pieces, you would type "2."

    c.	**Base Unit**. Select a base unit. The base unit will establish the lowest unit of measurement for the unit you're creating. Using our example, you would select "Piece."

    > [!div class="mx-imgBorder"]	
      ![Quick create: Unit form.](media/quick-create-form-unit.png "Quick create: Unit form")

  
## Typical next steps  
 ![Right arrow button](media/walkthrough-orange-right-arrow.png "Right arrow button") [Create a product](create-product-sales.md)  
  
 \- OR -  
  
 ![Right arrow button](media/walkthrough-orange-right-arrow.png "Right arrow button") [Create product bundles to sell multiple items together](create-product-bundles-sell-multiple-items-together.md)  
  
 ![Home button](media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

[!INCLUDE[footer-include](../includes/footer-banner.md)]
