---
title: Create and manage categories
description: Know how to create and manage categories for Customer Service.
ms.date: 06/21/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
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

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


Using the **Categories** entity, you can create hierarchical categorical data to help group records. Categorizing entity records in the application helps you tag the records so that you can easily search them. Use the entity to create and manage a logical structure of categories in Dynamics 365 Customer Service, and then associate entity records to one or more categories.

Categories are useful for reporting, sorting, segmenting, and categorization of records.

## Create a category

 [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)] 

  #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  


1. In the site map of Customer Service admin center or Contact Center admin center, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
1. In the **Categories** section, select **Manage**. The **All Categories** view is displayed. You can switch between various system views using the dropdown list.
  
1. On the command bar, select **New** to create a new category record.  
 
1. Enter the required information.

   1. In the **General** section, fill in the required details:
  
     - **Title**: Provide a title for the category.
     - **Description**: Give a detailed description of the category.
     - **Display Order**: Provide a position where the category can be displayed in the hierarchical order.
     - **Parent Category**: Select an existing category to become the parent category. You can create a new category by selecting **New**.
     - **Category Number**: The category number is displayed for category reference. To view this, first save the record by selecting **Save** on the command bar.

   b. In the **Associated Categories** section:

     - View all the **Child Categories** for a particular category.
     - Create a new category by selecting **Add New Category**.

---   

## Manage categories

- To see the hierarchy of a particular record and its parent and child category associations, select a category from the list and select **View Hierarchy**.
- To assign the category to a particular owner, select **Assign** on the command bar.
- To delete a category, select the category from the list and select **Delete** on the command bar.
- To edit a category, select the category in the **Title** column. You can also select the category in the list and select **Edit** on the command bar.

> [!NOTE]
> The **Categories lookup view** in the advanced settings of Dynamics 365 isn't customizable.

### Related information

[Use the Category entity to categorize records](../../customerengagement/on-premises/developer/use-category-entity-categorize-dynamics-365-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
