---
title: Create and manager categories (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create and manage categories for Customer Service for Dynamics 365
keywords: Create and manage categories; Dynamics 365; Customer Service Hub; Service manager
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 10494df7-b60f-4394-81de-1c602a5874cc
ms.custom: dyn365-customerservice
---

# Create and manage categories

Using **Categories** entity, you can create hierarchical categorical data to help group records. Categorizing entity records in Dynamics 365 helps you tag the records so that you can easily search them. Use the entity to create and manage a logical structure of categories in Dynamics 365, and then associate entity records to one or more categories.

Categories are useful for reporting, sorting, segmenting, and categorization of records. 

## Create categories

Follow the procedure given below to create a category:

1.  Ensure that you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.  
  
    **Check your security role**  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. In the Customer Service Hub sitemap, go to **Service Management** > **Categories**. <br>

    - The **All Categories** view is displayed. You can switch between various views using the drop-down. 
    - Select **Show Chart** in the command bar to see the chart view. <br>

3. To create a new category, select **New**.  
  
    > [!NOTE]
    > To edit a category, double-click the category in the category list that you want to edit. You can also select the category in the list and select **Edit** in the command bar.

4. Type or change information in the text boxes.  
  
   Hover tips provide hints about what to enter.  

   In the **General** section, fill in the required details:
  
   - **Title**: Provide a title for the category
   - **Description**: Give a detailed description for the category
   - **Display Order**: Provide a position where the category can be displayed in the hierarchical order
   - **Parent Category**: Select an existing category to become the parent category
   - **Category Number**: The category number is displayed for category reference. To view this, first save the record by selecting **Save** on the command bar

   In the **Associated Categories** section:

   - View all the **Child Categories** for a particular category here
   - Quickly create a new category by selecting **Add New Category**


## Additional actions

- Select **Assign** on the command bar to assign the category to a particular owner.
- To delete a category, select the category from the list and select **Delete** on the command bar.


### See also

[Use the Category entity to categorize Dynamics 365 records](../developer/use-category-entity-categorize-dynamics-365-records.md)