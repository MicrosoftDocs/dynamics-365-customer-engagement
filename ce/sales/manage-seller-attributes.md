---
title: "Manage seller attributes in assignment rules for lead and opportunity routing"
description: "Manage seller attributes in assignment rules for lead and opportunity routing by creating, editing, and deleting in sales accelerator (Dynamics 365 Sales)."
ms.date: 03/11/2022
ms.topic: article
author: udaykirang
ms.author: udag
---
# Manage seller attributes in assignment rules 

Seller attributes help you define skills of sellers such as languages, location, country, and skills. After you define attributes, you can use these attributes while configuring the rules to automatically assign leads to sellers.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Manage seller attributes

As an administrator or a sequence manager, you can create attributes and add values. For example, you want to group sellers according to the languages they know. Create an attribute with the name **Languages**, and add values for the attribute such as English, French, and Spanish. Assign the language attribute to sellers, and then an assignment rule can be configured to assign leads automatically to sellers who know the required language.

You can use the attribute designer to:

- [Create an attribute](#create-an-attribute).
- [Edit an attribute](#edit-an-attribute).
- [Delete an attribute](#delete-an-attribute).

## Create an attribute

1.	Sign in to your Dynamics 365 Sales Hub app.    
2.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.   
3.	Under **Sales accelerator**, select **Assignment rules**.    
4.	From the **Team** tab, select **Manage attributes**.    

   >[!div class="mx-imgBorder"]
   >![Select Manage attributes](media/sa-ar-seller-attributes-section-select-manage.png "Select Manage attributes")

5. On the **Manage attributes** page, select **New seller attribute**.

    >[!div class="mx-imgBorder"]
    >![Select New seller attribute](media/sa-ar-seller-attributes-select-new-seller-attribute.png "Select New seller attribute")

6. In the **Create new seller attribute** dialog, enter the information as follows:

   >[!div class="mx-imgBorder"]
   >![Create new seller attribute](media/sa-ar-create-new-seller-attribute.png "Create new seller attribute")   

    - **Seller attribute name**: Enter a name for the attribute. For example, **Language**.   
    - **Set attribute values**: Select how you want to enter the values for the attribute.      
        - **Pull from a data field**: The attribute values are fetched from a data field with an option set that is selected from the **Search data field** dropdown list. The list displays fields of type option set that is available lead, opportunity, and mutual. For example, when you select the field as **Budget** from **Mutual fields (same option set)**, the values that are defined for the field in both lead and opportunity form are added to the attribute values. You can remove the values and also add values.

        >[!div class="mx-imgBorder"]
        >![Select the budget field to add values to the attribute](media/sa-ar-new-attribute-lead-related.png "Select the budget field to add values to the attribute")      

       - **Do not link with fields**: Enter the attribute values manually.

        >[!div class="mx-imgBorder"]
        >![Enter attribute value manually](media/sa-ar-new-attribute-manual-value.png "Enter attribute value manually")
 
7.	Select **Create seller attribute**.

The attribute is created and added to the list.

## Edit an attribute

1. Sign in to your Dynamics 365 Sales Hub app.    
2. Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.   
3. Under **Sales accelerator**, select **Team settings**.   
4. On the **Team settings** page, select **Manage attributes**.   
5. On the **Manage attributes** page, select the pencil icon corresponding to the attribute that you want to edit.   

   >[!div class="mx-imgBorder"]
   >![Select the pencil icon to edit an attribute](media/sa-ar-attribute-select-edit.png "Select the pencil icon to edit an attribute")

6. In the edit dialog, edit the values you want, and then select **Update seller attribute**.

   >[!div class="mx-imgBorder"]
   >![Edit attribute dialog](media/sa-ar-attribute-edit-attribute.png "Edit attribute dialog")   
 
The attribute is updated.

## Delete an attribute

1.	Sign in to your Dynamics 365 Sales Hub app.   
2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.    
3. Under **Sales accelerator**, select **Team settings**.   
4. On the **Team settings** page, select **Manage attributes**.   
5.	On the **Manage attributes** page, select the delete icon corresponding to the attribute.

    >[!div class="mx-imgBorder"]
    >![Delete an attribute](media/sa-ar-delete-seller-attribute.png "Delete an attribute")  

6.	In the confirmation message, select **Delete permanently**.

    >[!div class="mx-imgBorder"]
    >![Delete attribute confirmation message](media/sa-ar-delete-attribute-confirmation.png "Delete attribute confirmation message")  

The attribute is deleted from the application.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Manage assignment rules](create-manage-assignment-rules.md)    
[Create and activate an assignment rule](create-and-activate-assignment-rule.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
