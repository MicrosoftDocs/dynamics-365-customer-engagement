---
title: "Preview: Customize Add Products dialog box | MicrosoftDocs"
description: "Customize the Add Products dialog box so that sellers can see important product details while adding products to opportunity, quote, order, or invoice records in Dynamics 365 Sales."
ms.date: 05/12/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdyn_salespro
  - D365-Entity-opportunityproduct
  - D365-Entity-quotedetail
  - D365-Entity-salesorderdetail
  - D365-Entity-invoicedetail
  - D365-UI-*
  - Dynamics 365
  - Sales
---
# Customize the Add Products dialog box in Sales Professional

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> Customizations described in this topic must be done within a custom solution. For more information see, [Why you shouldn't use the default solutions to manage customizations](/power-platform/alm/use-solutions-for-your-customizations#why-you-shouldnt-use-the-default-solutions-to-manage-customizations)
  
As a system administrator, you can customize the **Add products** dialog box by adding information that will help your salespeople to identify and select products quickly.
 
> [!NOTE]
> The customizations are only applicable for the enhanced experience. Make sure that you've [enabled the Add products preview](enable-enhanced-add-product-experience-sp.md) feature.

You can either add more columns to the grid or add more attributes to the **Product** column. Attributes in the **Product** column help sellers get more information *before* choosing a product. So, if you want to add a category or product ID to help distinguish products from each other, add it to the **Product** column. On the other hand, if sellers need to perform an action *after* selecting a product&mdash;for example, choosing delivery priority (a custom attribute)&mdash;add that attribute to the grid.

>[!IMPORTANT]
>- The enhanced experience for adding products is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>- [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>- [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Add or remove columns in the grid

By default, the **Add products** dialog box displays the following columns in the grid:

- Product name
- Unit
- Price per unit
- Quantity

**To add or remove columns in the grid**

1. Sign in to Power Apps and open the view editor. For step-by-step instructions, see [Choose and configure columns in views](powerapps/maker/model-driven-apps/choose-and-configure-columns/choose-and-configure-columns#open-the-view-editor).  
1. Select the following tables and views to configure the Add products dialog box for opportunity, quote, order, and invoice:
   
    |Table Name  |View Name  |
    |---------|---------|
    |Opportunity Product     |Opportunity products Add Products         |
    |Quote Product     | Quote products Add Products        |
    |Order Product     | Order products Add Products         |
    |Invoice Product     |Invoice products Add Products          |

2. Add or remove columns as per your requirement. For step-by-step instructions, see [Choose and configure columns in views](/powerapps/maker/model-driven-apps/choose-and-configure-columns/choose-and-configure-columns#add-columns-to-views).
1. Publish the customization.  
     The changes should now be visible in the Add products dialog of the corresponding entity. See, [Add products to an opportunity by using the enhanced experience (Sales Professional)](add-products-enhanced-experience-sp.md)
   

## Add or edit attributes in the Product column

By default, the **Product** column in the Add product dialog includes the product name and ID. You can customize this column to add other attributes to help you better distinguish the products. For example, you can add the product category to differentiate products as shown in the following image:

![Screenshot showing additional details in the Product column of the Add products dialog](media/ProductColumn.png)

**Note**: The **Product** column can display up to three attributes, apart from the product name.  


**To add or edit product attributes:**

1. Open Power Apps, and select the **Product Lookup View** in the **Product** table.  

1. Add or remove columns as per your requirement. For step-by-step instructions, see [Choose and configure columns in views](/powerapps/maker/model-driven-apps/choose-and-configure-columns/choose-and-configure-columns#add-columns-to-views).  

1. Save and publish the customization.
     The changes should now be visible in the Product column of the Add products dialog for all entities. See, [Add products to an opportunity by using the enhanced experience (Sales Professional)](add-products-enhanced-experience-sp.md)  

## Customize the fields to search  

By default, the search field in the Add products dialog searches the product name, ID, and description. You can expand the search to include other text-based fields too. For example, you can add the Vendor Name field to the search scope.

**To customize the fields to search:**

1. Open Power Apps and navigate to **Tables** in the left pane.

2. Search for the **Product** entity and open it.

3. Select the **Views** tab and open the **Quick Find All Products** view. 

4. In the right pane, go to the **Find by** section and select **Edit find table columns**. Select the fields you want to include in search.
    > [!NOTE] 
    > Select only the text-based fields.

    >[!div class="mx-imgBorder"]
    >![Image of the Find by section in the right pane with the Edit find table column highlighted](media\sales-hub-quick-find-view.png "Image of the Find by section in the right pane with the Edit find table column highlighted")

5. Select **Publish** to save and publish changes to the view.
    The changes are applicable to the product search in the Add products dialog of opportunity, quote, order, and invoice.

6. To verify the changes, open an opportunity and select **Add products**.

7. Search for a keyword and verify whether the search is returning matches from the newly added fields.

### See also

[Create a solution](/powerapps/maker/data-platform/create-solution)  
[Choose and configure columns in model-driven app views](/powerapps/maker/model-driven-apps/choose-and-configure-columns)  
[Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience-sp.md)  
[Add products to quotes, orders, or invoices](add-products-qoi-enhanced-sp.md)
