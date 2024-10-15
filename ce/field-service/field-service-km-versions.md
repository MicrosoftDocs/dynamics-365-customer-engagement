---
title: Manage article versions
description: Learn how to manage new versions of knowledge articles in Dynamics 365 Field Service. 
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.date: 10/15/2024
ms.custom: bap-template
---

# Manage article versions

Article versioning helps you manage updates to your knowledge articles without disrupting the live or published articles. By creating major and minor versions of a knowledge article, you can keep your articles up to date with the latest information while keeping track of changes throughout the lifecycle of your products and services. An example of a major version is when your documentation changes to detail a new feature or functionality, while a minor version might be a change to the user interface with no change to functionality.  
  
This capability helps you to keep accurate records of the features your organization provides and go back to previous versions if you need to.

## Create a new version
  
1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.  
1. Select the article you want to create a new version for.  
1. From the command bar, select **Create Major Version** or **Create Minor Version**.  

    The new version of your article contains all of the same content, information, and permissions as the current version. The **Version Major** or **Version Minor** field automatically updates to reflect the new version number.  
  
    > [!NOTE]
    > You won’t be able to make any changes to the **Major Version Number**, **Minor Version Number**, **Language**, or **Article Public Number** fields when creating a new major or minor version of an article.  
  
1. After you have reviewed the article, make any changes that you want to the new version. You can update the article title, content, keywords, and description to reflect any changes to your products, features, or services.  
  
## Review and publish your new version  

When you're done making changes, you can push the new version of your article through your standard article workflow. When you're finished reviewing and are ready to publish, on the command bar, select the vertical ellipsis &vellip; > **Publish**, and then choose how and when you want to publish your new version. You can publish your new version immediately, schedule it to publish at a future date, or leave it as a draft to manually publish later. Learn more: [Publish knowledge articles](field-service-km-publish.md)
  
## Manage article versions

Managing your article versions means publishing and archiving different versions of each article to provide the most accurate information to your customers and internal employees. Keep in mind that only one version of an article can be published at a time. It’s important to keep track of the changes that are made to each version and publish them when it's appropriate.

You can delete or archive a previous version. Deleting an article version is permanent and can’t be undone. You can't go back to that version of the article, so ensure that you don’t need any of the information. It’s a good idea to create a local backup of any versions you delete.

Archived versions are read-only. You can view all archived versions by changing the view on the **Knowledge Articles** page to **Archived Articles**.
  
1. In the knowledge article, select the **Summary** tab.  
  
1. In the **Related Information** section, select the **Related Versions** icon to display a list of all major and minor versions of the article.  
  
1. In the **Related versions** list, select the version you want to manage.  
  
1. From the command bar, select **Send to Trash** to delete the version or **Archive** to archive the version. 
  
1. When prompted, select **OK**.  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
