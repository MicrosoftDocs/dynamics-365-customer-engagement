---
title: "Configure and manage category for knowledge articles for a portal | MicrosoftDocs"
description: "Instructions to create and manage a category for knowledge article."
ms.custom: 
  - dyn365-portal
ms.date: 12/03/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 29c93300-516a-4d61-a3a1-363f7d2c1466
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---
# Configure and manage category for knowledge articles

This section helps you understand how to create a new category for knowledge articles and associate it with an article. You will also learn how to enable ratings for a knowledge article.

## Create a new category for knowledge articles

1. Sign in to Dynamics 365 Portals.

2. Go to **Settings** > **Service Management**. 

3. In the **Knowledge Base Management** section, select **Categories**. 

4. Select **New**. 

5. Enter a name and description for your category. 

6. Choose a parent category. If you want this to be a top-level category, leave this field blank.

## Associate a category with a knowledge article

1. In Customer Service Hub, go to **Service** > **Knowledge Articles**.

2. Open a knowledge article.

3. On the command bar, select **Associate Category**. The Associate Category window appears.

4. In the **Select Category to Associate with** field, select the category you want to associate to the article, and then select **Associate**.

   ![Associate a category to a knowledge article](media/kb-associate-category.png "Associate a category to a knowledge article")

> [!NOTE]
> You can also add related articles, related products, and keywords to a knowledge article. For more information on managing knowledge articles, see [manage knowledge articles](../customer-service/customer-service-hub-user-guide-knowledge-article.md).

## Remove a category from an article

1. In Customer Service Hub, open the knowledge article from which you want to remove a category.

2. On the **Summary** tab, under **Related information**, select **Related Categories**.

    ![View associated categories to a knowledge article](media/kb-related-categories.png "View associate categories to a knowledge article")

3. Select the category you want to remove.

4. From **More Commands**, select **Remove**.

    ![Delete an associated category from a knowledge article](media/kb-remove-category.png "Delete an associated category from a knowledge article")

## Delete a knowledge category

1. Sign in to Dynamics 365 Portals.

2. Go to **Settings** > **Service Management**. 

3. In the **Knowledge Base Management** section, select **Categories**. 

4. Choose the category from the list view, and then select **Delete** on the command bar.

>[!Note] 
> Knowledge articles associated with the category will be disassociated after the category is deleted.

## Enable ratings for a knowledge article

1. Sign in to the portal and go to knowledge article.

2. Edit the article from the inline editor.

3. On the **Options** tab, select **Enable Ratings**.

### See also
[Get started with the portal content editor](get-started-portal-content-editor.md)  
[Add dynamic content and create custom templates](custom-templates-dynamic-content.md)  

