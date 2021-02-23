---
title: Create and manage categories (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and manage categories for Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage categories

Using the **Categories** entity, you can create hierarchical categorical data to help group records. Categorizing entity records in Dynamics 365 Customer Service helps you tag the records so that you can easily search them. Use the entity to create and manage a logical structure of categories in Dynamics 365 Customer Service, and then associate entity records to one or more categories.

Categories are useful for reporting, sorting, segmenting, and categorization of records. 

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, categories in service management are available in the Customer Service Hub. We recommend that you create and manage categories using the new experience.

## Create a category

Follow the procedure given below to create a category:

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  

    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Categories**.

    > [!NOTE]
    > In the Customer Service app, [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)] and select **Categories**.

3. To create a new category, select **New**.  
  
    > [!NOTE]
    > To edit a category, double-click the category in the category list that you want to edit. You can also select the category in the list and select **Edit** in the command bar.

4. Type or change information in the text boxes.  
  
   Hover tips provide hints about what to enter.  

   In the **General** section, fill in the required details:
  
   - **Title**: Provide a title for the category
   - **Description**: Give a detailed description of the category
   - **Display Order**: Provide a position where the category can be displayed in the hierarchical order
   - **Parent Category**: Select an existing category to become the parent category. You can create a new category by selecting **New**.
   - **Category Number**: The category number is displayed for category reference. To view this, first save the record by selecting **Save** on the command bar

   In the **Associated Categories** section:

   - View all the **Child Categories** for a particular category here
   - Quickly create a new category by selecting **Add New Category**


## Additional actions

- Select a category from the list and select **View Hierarchy**. You can see the hierarchy of a particular record, and its parent and child category associations.
- Select **Assign** on the command bar to assign the category to a particular owner.
- To delete a category, select the category from the list and select **Delete** on the command bar.


### See also

[Use the Category entity to categorize records](../developer/use-category-entity-categorize-dynamics-365-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]