---
title: Create and manage categories (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and manage categories for Customer Service.
ms.date: 01/19/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-category
 - D365-UI-*
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement
---

# Create and manage categories

Using the **Categories** entity, you can create hierarchical categorical data to help group records. Categorizing entity records in Dynamics 365 Customer Service helps you tag the records so that you can easily search them. Use the entity to create and manage a logical structure of categories in Dynamics 365 Customer Service, and then associate entity records to one or more categories.

Categories are useful for reporting, sorting, segmenting, and categorization of records.

## Create a category

To create a category:

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  

    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub site map, go to **Service Management** and select **Categories** in **Knowledge Base Management**.

3. Select **New**.  
 
4. Type or change the information in the text boxes.

   - In the **General** section, fill in the required details:
  
     - **Title**: Provide a title for the category.
     - **Description**: Give a detailed description of the category.
     - **Display Order**: Provide a position where the category can be displayed in the hierarchical order.
     - **Parent Category**: Select an existing category to become the parent category. You can create a new category by selecting **New**.
     - **Category Number**: The category number is displayed for category reference. To view this, first save the record by selecting **Save** on the command bar.

   - In the **Associated Categories** section:

     - View all the **Child Categories** for a particular category.
     - Create a new category by selecting **Add New Category**.

## Manage categories

- To see the hierarchy of a particular record and its parent and child category associations, select a category from the list and select **View Hierarchy**.
- To assign the category to a particular owner, select **Assign** on the command bar.
- To delete a category, select the category from the list and select **Delete** on the command bar.
- To edit a category, select the category in the **Title** column. You can also select the category in the list and select **Edit** on the command bar.

> [!NOTE]
> The **Categories lookup view** in the advanced settings of Dynamics 365 isn't customizable.

### See also

[Use the Category entity to categorize records](../customerengagement/on-premises/developer/use-category-entity-categorize-dynamics-365-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
