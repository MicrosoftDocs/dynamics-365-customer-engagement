---
title: "Use the Category entity to categorize records (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about categorizing the entity records using category entity."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service:
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ee0b24ea-c0f5-4f6a-bd66-53b7617f62cc
author: KumarVivek
ms.author: kvivek
search.audienceType: 
  - developer

---
# Use the Category entity to categorize Customer Engagement (on-premises) records

Categorizing entity records helps you tag the records so that you can easily search them. Use the `Category` entity to create and manage a hierarchical structure of categories in Customer Engagement (on-premises), and then associate entity records to one or more categories.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]  
  
 A category can have multiple child categories, but a child category can have only one parent category. Deleting a parent `Category` record automatically deletes all its child records and entity associations. You define a parent category for a category using the `Category.ParentCategoryId` attribute.  
  
 Use the `Category.SequenceNumber` attribute to programmatically define the display order for categories in the hierarchy.  When you a add a new category using the web client, it is automatically added after the last category in the hierarchy. You can also use the `Category.CategoryNumber` attribute to programmatically set or update a number for category to help you easily distinguish a group of categories. Category number can be set to any value programmatically, but is automatically set when you create a category using the web client based on the auto-numbering prefix specified by the administrator for categories in the web client (**Settings** > **Administration** > **Auto-Numbering** > **Categories** tab).  
  
 You can associate `Category` records with system and custom entity records by using relationships and connections. A category record can be associated with different entity records. For example, you can programmatically associate a `Category` record with an `Account`, `Contact` and `Incident` records.  
  
 By default, there is a many-to-many relationship available between the `Category` and `KnowledgeArticle` entity, and the entity record associations are stored in the `KnowledgeArticlesCategories` entity.  
  
## In This Section  
 [Category Entity](entities/category.md)  
  
### See also  
 [Work with knowledge articles in Customer Engagement (on-premises)](work-knowledge-articles.md)   
 [Service entities in Customer Engagement (on-premises)](service-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]