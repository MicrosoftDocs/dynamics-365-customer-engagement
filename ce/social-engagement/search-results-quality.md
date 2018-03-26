---
title: "Manage the quality of your search results in Social Engagement | Microsoft Docs"
description: "Learn how to increase the quality of your search results."
keywords: "block content, block authors"
ms.date: 02/01/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 302a0005-c7b0-4247-8d2d-663685716b75
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Manage the quality of your search results
You can perform quality management over the entire application by blocking irrelevant posts and sources.  
  
> [!NOTE]
>  As an Administrator or a Power Analyst, you can add terms to the list of blocked content to delete the matching posts in your analysis, or block entire domains from the data acquisition and delete already-acquired posts from these domains. Deleted posts are deducted from your monthly post quota.  
  
> [!TIP]
>  This topic is part of a walkthrough on how you can set up searches. More information: [Set up searches to listen to social media conversations](set-up-searches.md)  
  
## Block domains from your sources  
 To improve the quality of your organization’s data, you can block URLs that aren’t required. You can add URLs and partial URLs to a blocked sources list that will be excluded from data acquisition and analysis. Posts that were already acquired from a source on your blocked list are deleted from the database four hours after you add the domain to the list. In the meantime, posts from this source are hidden.  
  
 For example, you find multiple posts from a specific blog with irrelevant content or spam. Instead of deleting every post manually from your analysis, you can add the blog URL to the blocked sources list. Even if future posts on that blog match your keywords, they won’t show up in your analysis.  
  
 When you're not interested in posts from a specific domain, add the domain to the list of blocked domains.  
  
> [!IMPORTANT]
>  You must remove a source from the blocked list to restart the data acquisition for that source.  
  
### View blocked domains  
 Every user can review the list of blocked domains to find out which URLs are blocked from data acquisition.  
  
1.  Go to **Search Setup** > **Blocked Content**.  
  
2.  Review the list in the **DOMAINS** pane.  
  
### Block a domain from your searches  
 When you’re not interested in posts from a specific domain, add the domain to the list of blocked sources.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
  
> [!IMPORTANT]
>  When you add a domain to the list of blocked domains, posts from this domain will be hidden in Analytics for four hours and be irreversibly deleted afterward.  
  
1.  Go to **Search setup** > **Blocked Content**.  
  
2.  In the **DOMAINS** pane, enter the domain or partial domain in the field.  
  
3.  Click the **Add** button ![New or Add button](media/plus-icon.png "New or Add button").  
  
> [!WARNING]
>  Blocking a top-level domain also excludes all of its subdomains. For example, if you exclude `contoso.com`, the subdomain `shop.contoso.com` is also excluded.  
>   
>  Blocking domains can have a severe impact on the data you already acquired. When you add a domain to the list of blocked content, all posts found on the blocked domain, including subdomains, will be removed from your database after a grace period of four hours.  
  
### Remove a domain from the list of blocked sources  
 Reactivate the data acquisition from a blocked source by removing the domain from the list.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
  
1.  Go to **Search setup** > **Blocked Content**.  
  
2.  Find the source you want to remove from the list and re-enable for data acquisition, and then click the **Delete** button ![Delete button](media/trashbin-icon.png "Delete button").  
  
3.  In the confirmation message, click **CONFIRM**.  
  
4.  The data acquisition for the selected domain will restart.  
  
## Block keywords and terms from your searches  
 Exclude a specific term (word or phrase) by adding it to the blocked content list. Terms on the blocked content list cause matching posts to be deleted from the database. Because terms on the blocked content list act as a global exclusion, it’s a very efficient way to improve the quality of your data. However, be cautious of unintentionally deleting relevant posts.  
  
 Posts that don't show up in Analytics because of your blocked content settings don't count toward your post quota.  
  
 For example, if you’re listening to multiple search topics about cars, but don’t want to see any posts that mention the keyword “insurance,” you can add this term to the blocked content list. This deletes all posts that mention “insurance,” and posts that contain this term are no longer acquired by your search topics.  
  
### View excluded keywords  
 Every user can review the list of blocked content to find out which words or phrases are blocked from data acquisition.  
  
1.  Go to **Search setup** > **Blocked Content**.  
  
2.  Review the list of excluded keywords below the text input field.  
  
### Block keywords from your search results  
 Acting as global exclusions, keywords and phrases you add to the list of blocked content will be deleted from your analysis, and already-acquired posts  removed from the database.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
  
> [!IMPORTANT]
>  When you add a keyword to the list of blocked keywords, posts matching this keyword will be hidden in Analytics for four hours and be irreversibly deleted  afterward.  
  
1.  Go to **Search setup** > **Blocked Content**.  
  
2.  Type the term in the input field.  
  
3.  Click the **Add** button ![New or Add button](media/plus-icon.png "New or Add button").  
  
### Remove a keyword from blocked content  
 Remove a global exclusion and restart the data acquisition for posts matching this keyword by removing a keyword from the blocked content list.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)] Data acquisition restarts after removing a keyword from the list of blocked content. Posts aren’t acquired retroactively.  
  
1.  Go to **Search Setup** > **Blocked Content**.  
  
2.  Identify the list entry you want to remove from the blocked content, and then  click the **Delete** button ![Delete button](media/trashbin-icon.png "Delete button").  
  
3.  In the confirmation message, click **CONFIRM**.  
  
## Manage the data acquisition volume  
  
-   Optimize your search topics regularly. Review the rules to make sure that only relevant data is selected. Validate your rules before saving the search topic to get an idea of how many posts you’re expecting for the configuration you provided.  
  
-   Maintain a list of blocked sources to delete matching posts and avoid any posts appearing in your results from the listed domains. When you add a source to the list of blocked sources, posts from this source will be hidden in Analytics for four hours and be irreversibly deleted afterward.  
  
-   Maintain a list of blocked terms to delete matching posts and avoid any posts appearing in your results that match the listed terms. When you add a term to the list of blocked terms, posts matching this term will be hidden in Analytics for four hours and be irreversibly deleted afterward.  
  
-   Exclude authors who publish irrelevant posts that match one of your search topics.  
  
-   Get additional post quota. Ask your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] admin to add more posts to your solution’s quota in the [Office 365 admin center](https://portal.office.com/).  
  
### Privacy notice  
 [!INCLUDE[cc_privacy_msl_social_services_content](../includes/cc-privacy-msl-social-services-content.md)]  
  
### See Also  
 [Set up searches to listen to social media conversations](set-up-searches.md)   
 [Refine your search rules](refine-search-rules.md)
 
