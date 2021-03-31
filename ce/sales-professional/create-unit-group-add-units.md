---
title: "Create a unit group and add units in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Use units in Dynamics 365 Sales Professional to define the quantities or measurements in which your products are available."
ms.date: 10/01/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
searchScope:
  - D365-App-msdyn_salespro
  - D365-Entity-product
  - D365-Entity-pricelevel
  - D365-Entity-productpricelevel
  - D365-Entity-uom
  - D365-Entity-uomschedule
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create a unit group and add units

Units are the quantities or measurements that you sell your products or services in. For example, if you sell gardening supplies, you might sell seeds in units of packets, boxes, and pallets. A unit group is a collection of these different units.

1.  Make sure that you have the System Administrator or Sales Professional Manager role or equivalent permissions.

2.  In the site map, select **Units**.

3.  Select **New**.

    The **Create Unit Group** dialog box opens.

    > [!div class="mx-imgBorder"]
    > ![Create unit group dialog box](media/create-unit-group-dialog-box.png "Create unit group dialog box")

4.  Fill in your information, and select **OK**:

    - **Name**. Enter a meaningful name for the unit group. In our example, you would type "Televisions."

    - **Primary Unit**. Enter the lowest common unit of measure that the product will be sold in. In our example, you would type "Piece." Other examples could include box, cartons, ounces, hours, or tons, depending on your product.

5.  To add units to the unit group, open the unit group you just created, select the **Related** tab, and then select **Units**.

    > [!div class="mx-imgBorder"]
    > ![Units option on the Related menu](media/related-tab-units-option.png "Units option on the Related menu")

 
6.  On the **Units** tab, you’ll see that the primary unit is already added. Select **Add New Unit**.

    > [!div class="mx-imgBorder"]
    > ![Add New Unit button](media/unit-tab-add-new-unit-button.png "Add New Unit button")

7.  In the **Quick Create: Unit** form, fill in the following, and select
    **Save**:

    - **Name**. Enter a meaningful name for the unit. In our example, you would enter "box."

    - **Quantity**. Enter the quantity that this unit will contain. For example, if a box contains two pieces, you would type "2."

    - **Base Unit**. Select a base unit. The base unit will establish the lowest unit of measurement for the unit you're creating. Using our example, you would select "Piece."

      > [!div class="mx-imgBorder"]
      > ![Quick Create form for Unit](media/unit-quick-create-form.png "Quick create form for Unit")


### See also

[Create a price list](create-price-list.md)  
[Create a product](create-products.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]