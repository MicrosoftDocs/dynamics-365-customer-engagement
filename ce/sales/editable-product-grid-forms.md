---
title: "Add editable Products grid to forms (Dynamics 365 Sales) | MicrosoftDocs"
description: "Editable Products grid helps sales users to make changes to the product details inline in Dynamics 365 Sales."
ms.date: 11/21/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - "dyn365-sales"
---
# Add editable Products grid to Opportunity, Quote, Order, and Invoice forms 

Editable products grid on the Opportunity, Quote, Order, or Invoice forms lets sellers to edit product details inline, without having to open individual product records to update. 

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|



## Enable editable Products grid

Currently, the preconfigured Products grid is available only on apps built on the Unified Interface framework and is optimized to work on the web.

The product editable grid is added out-of-the-box to the **Product Line Items** section of the Opportunity form of type **Main**. For Quote, Order, or Invoice, it is added to the Products section of the forms of type **Main**. 

If you’re upgrading to the latest version and you’ve made customizations to the **Product Line Items** or **Products** sections of these forms, your customizations will prevail, and the product editable grid won’t be added to the forms by default. You must manually enable the product editable grid, though the product grid configurations for the editable grid already will be defined. If there are no customizations to these sections, the Products grid will be automatically configured and enabled after the upgrade. 

To enable the editable products grid on the Opportunity, Quote, Order, or Invoice form:

1. In the sales app, go to **Settings** > **Advanced Settings**.  

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.  
1. In the left pane, expand **Tables** and then the entity you want, and select **Forms**.  

    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then the entity you want, and select **Forms**.  

1. In the list of forms, open the form of type **Main**.  

1. Depending on the table type, select properties:  
    - For Opportunity, select the products area.  
    :::image type="Opportunity Products area in the Product Line Items section" source="media/opportunity-products-area-product-line-items-section.png" alt-text="Opportunity Products area in the Product Line Items section":::  
    - For Quote, Order, or Invoice, select the **Products** area.  
    :::image type="Products area" source="media/products-area.png" alt-text="Products area in the Products section":::  
1. In the right pane, go to the **Components** section and select the devices on which you want the editable grid to be available.  
    Currently, the editable grid is optimized to work on the web.  
    :::image type="Editable grid control in the Set Properties dialog box" source="media/editable-grid-set-properties-dialog-box.png" alt-text="Editable grid control in the Set Properties dialog box":::  
    Notice that the properties of the editable grid such as Grid view or Nested grid view are preconfigured by default.
1. Save and publish the form.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information  

[Make model-driven app views editable using the editable grid control](/powerapps/maker/model-driven-apps/make-grids-lists-editable-custom-control)
