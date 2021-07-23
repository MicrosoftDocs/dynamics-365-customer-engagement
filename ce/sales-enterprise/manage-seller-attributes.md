---
title: "Manage seller attributes in assignment rules for lead routing | MicrosoftDocs"
description: "Manage seller attributes in assignment rules for lead routing by creating, editing, and deleting in sales accelerator (Dynamics 365 Sales)."
ms.date: 05/14/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Manage seller attributes in assignment rules

Seller attributes help you define skills of sellers such as languages, location, country, and skills. After you define attributes, you can use these attributes while configuring the rules to automatically assign leads to sellers.

As an administrator or a sequence manager, you can create attributes and add values. For example, you want to group sellers according to the languages they know. Create an attribute with the name **Languages**, and add values for the attribute such as English, French, and Spanish. Assign the language attribute to sellers, and then an assignment rule can be configured to assign leads automatically to sellers who know the required language.

You can use the attribute designer to:

- [Create an attribute](#create-an-attribute).
- [Edit an attribute](#edit-an-attribute).
- [Delete an attribute](#delete-an-attribute).

## Create an attribute

1. Sign in to your Dynamics 365 Sales Hub app.   

2. Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.

3. Under **Sales accelerator**, select **Assignment rules (preview)**.

4. On the **Assignment rules** page in the **Seller attributes** section, select **Manage**.

   >[!div class="mx-imgBorder"]
   >![Select Manage in the Seller attributes section](media/sa-ar-seller-attributes-section-select-manage.png "Select Manage in the Seller attributes section")

5. On the **Seller attributes** page, select **+ New seller attribute**.

    >[!div class="mx-imgBorder"]
    >![Select New seller attribute](media/sa-ar-seller-attributes-select-new-seller-attribute.png "Select New seller attribute")

6. In the **Create new seller attribute** dialog, enter the information as follows:

   >[!div class="mx-imgBorder"]
   >![Create new seller attribute](media/sa-ar-create-new-seller-attribute.png "Create new seller attribute")   

    - **Seller attribute name**: Enter a name for the attribute. For example, **Language**.

    - **Data field linked to attribute**: Select a data field, and add values in the **Attribute values** field.
 
       - If you select a field that's related to the Lead form, the values that are related to the field are automatically added to the attribute values. For example, when you select the field as Budget, the values that are defined for the field in the lead form are added to the attribute values. You can remove the values and also add values.

        >[!div class="mx-imgBorder"]
        >![Select an attribute from the Lead form](media/sa-ar-new-attribute-lead-related.png "Select an attribute from the Lead form")      

       - If you select **Do not link with fields**, you must enter the attribute values manually.

        >[!div class="mx-imgBorder"]
        >![Enter attribute value manually](media/sa-ar-new-attribute-manual-value.png "Enter attribute value manually")
 
7.	Select **Create seller attribute**.

The attribute is created and added to the list.

## Edit an attribute

1. Sign in to your Dynamics 365 Sales Hub app.   

2. Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.

3. Under **Sales accelerator**, select **Assignment rules (preview)**.

4. On the **Assignment rules** page in the **Seller attributes** section, select **Manage**.

5. On the **Seller attributes** page, select the pencil icon corresponding to the attribute that you want to edit.

   >[!div class="mx-imgBorder"]
   >![Select the pencil icon to edit an attribute](media/sa-ar-attribute-select-edit.png "Select the pencil icon to edit an attribute")

6. In the edit dialog, edit the values you want, and then select **Update seller attribute**.

   >[!div class="mx-imgBorder"]
   >![Edit attribute dialog](media/sa-ar-attribute-edit-attribute.png "Edit attribute dialog")
 
The attribute is updated.

## Delete an attribute

1.	Sign in to your Dynamics 365 Sales Hub app.

2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.

3.	Under **Sales accelerator**, select **Assignment rules (preview)**.

4.	On the **Assignment rules** page in the **Seller attributes** section, select **Manage**.

5.	On the **Seller attributes** page, select the delete icon corresponding to the attribute.

    >[!div class="mx-imgBorder"]
    >![Delete an attribute](media/sa-ar-delete-seller-attribute.png "Delete an attribute")  

6.	In the confirmation message, select **Delete permanently**.

    >[!div class="mx-imgBorder"]
    >![Delete attribute confirmation message](media/sa-ar-delete-attribute-confirmation.png "Delete attribute confirmation message")  

The attribute is deleted from the application.

### See also

[Manage assignment rules for lead routing](create-manage-assignment-rules-lead-routing.md)    
[Create and activate an assignment rule](create-and-activate-assignment-rule.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
