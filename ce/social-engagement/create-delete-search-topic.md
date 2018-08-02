---
title: "Manage search topics in Social Engagement | Microsoft Docs"
description: "Learn how to create a new search topic or delete an existing one in Social Engagement."
keywords: "searches, search topic, search rules, gather data"
ms.date: 10/17/2017
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 9167aafd-1882-4187-add5-4bd874d3c21b
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom:
  - dyn365-socialengagement
---

# Create or delete a search topic
It’s important to start with a clear idea of what kind of online information you want to listen to. Set up new search topics and add at least one rule to each of them to find out what your audience is discussing in their public social media posts. You can also edit search topics you’ve created or delete them if they are no longer relevant.  
  
> [!TIP]
>  This topic is part of a walkthrough on how you can set up searches. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up searches to listen to social media conversations](set-up-searches.md)  
  
## Create a search topic  
 > [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)] [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](user-roles.md)  
  
1.  Go to **Search Setup**.  
  
2.  In the **Search Topics** pane, click **Add Search Topic** ![Add button](media/add-icon.png "Add button") to open the **New Search topic** page.  
  
3.  Provide a name for your search topic in the **Name** text box and verify the category of your topic.  
  
    > [!NOTE]
    >  You can add search topic names that contain up to 35 characters. The search topic names are only for your reference; they aren’t included in the actual search. Search topic names are like titles for your search topics so you can quickly relate to and use or reuse them.  
  
4.  If you want another user to be the owner of this search topic, click **Edit Owner** ![Edit button](media/edit-icon.png "Edit button") next the search topic owner and enter the user name in the search box or click the name in the list below.  
  
5.  Under **Rules**, click **Add Rule** ![Add button](media/add-icon.png "Add button") to open the **Add Rule** page.  
  
6.  Select the rule type you want to create, and then provide the required information. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find out what's covered by sources](sources-coverage.md)  
  
7.  Click **Continue** to estimate the number of results and see a preview of posts matching this rule.  
  
8.  Add another search rule to your topic (optional).  
  
9. In the **Search Topics** pane, click **Save** ![Save button](media/save-icon.png "Save button") to store the search topic and start the data acquisition.  
  
    > [!NOTE]
    >  It will take some time for the first posts to be acquired for your newly-created topic. The delay also depends on how much volume your topic in general has. For example, a topic with high volume will give you results faster than a topic with lower volume. Make sure to check in Analytics and set your time frame to **Today** if you have set up a new topic and are expecting posts.  
  
## Edit a search topic  
To help you find relevant posts and be up to date with the business requirements, you can change your search topics and the associated rules at any time. We strongly recommend updating the rules in a search topic from time to time to make sure you’re gathering only relevant information.  
  
> [!NOTE]
>  Administrators can edit every search topic in the solution, while Power Analysts can only edit the search topics they own.  
  
1.  Go to **Search Setup**.  
  
2.  In the list of search topics, click the topic you want to edit.  
  
3.  In the list of rules, click the rule you want to edit.  
  
4.  Validate the updated rule, and then click **Save** ![Save button](media/save-icon.png "Save button") to update the search topic.  
  
<a name="manage_ownership"></a>   
## Manage ownership of a search topic  
Administrators in your organization can change the owner of a search topic to ensure every search topic is owned by the appropriate user. Users with the Power Analyst role are only allowed to edit owned search topics, but Administrators can empower these users by giving them ownership of search topics they manage, or create a search topic on behalf of other users.  
  
1.  Go to **Search Setup**.  
  
2.  In the list of search topics, click  the topic you want to edit.  
  
3.  In the search topic settings pane, click **Edit Owner** ![Edit button](media/edit-icon.png "Edit button") next the search topic owner.  
  
    > [!NOTE]
    >  You must have an Administrator role to edit the owner of a search topic.  
  
4.  Enter the user name in the search box or click the name in the list below it.  
  
5.  Click **Save** ![Save button](media/save-icon.png "Save button") to update the search topic.  
  
## Delete a search topic  
  
> [!IMPORTANT]
>  As an Administrator, you can delete search topics at any time. Power Analysts can only delete search topics they own.  
  
1.  Go to **Search Setup**.  
  
2.  In the list of search topics, click the **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") by the topic you want to delete, and then confirm the deletion.  
  
    > [!NOTE]
    >  Deleting a search topic has the following effects:  
    >   
    >  -  Data acquisition for the deleted topic stops immediately.  
    > -   An automated email notification is sent to the user who created the search topic.  
    > -   The search topic is no longer visible in the user interface.  
    > -   Alerts and streams based on this topic are deactivated.  
    > -   The quota will remain the same even if the search topic has been deleted. You need to add the keywords contained in a deleted topic to the Block Content so your deleted search topics will no longer affect the quota. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage your post quota](manage-post-quota.md)  
  
### Privacy notices  
 [!INCLUDE[cc_privacy_msl_social_services_content](../includes/cc-privacy-msl-social-services-content.md)]  
  
 [!INCLUDE[cc_privacy_msl_index_cached_data](../includes/cc-privacy-msl-index-cached-data.md)]  
  
 [!INCLUDE[cc_privacy_mse_bing_social_check](../includes/cc-privacy-mse-bing-social-check.md)]  
  
### See Also  
 [Set up searches to listen to social media conversations](set-up-searches.md)   
 [Add rules to a search topic](add-rules-search-topic.md)
 
