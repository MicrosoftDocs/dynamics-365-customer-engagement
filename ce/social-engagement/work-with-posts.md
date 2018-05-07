---
title: "Work with posts in Social Engagement | Microsoft Docs"
description: "Learn how to interact with posts and how to perform internal actions."
keywords: "publish, sentiment, tag, assign"
ms.date: 10/17/2017
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: bf6392aa-e9e1-44b6-8f80-f17c21caa793
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom:
  - dyn365-socialengagement
---

# Work with posts
Wherever you work in [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)], your analysis is usually based on the posts in your data set. It’s important to understand what customers and prospects are talking about, so it’s critical to know about the actual contents of the posts.  
  
<a name="sentiment"></a>   
## Change a post’s sentiment value in Analytics and Social Center  
 In some cases the sentiment algorithm annotates a post’s sentiment differently from your perception of the tone. Adjust the sentiment value of posts if you disagree with a system-rated sentiment value. Confirm the system-rated sentiment value if you agree with it.  
  
 Sentiment calculations can improve based on the users’ edits to sentiment values if the Administrator enabled adaptive learning. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Adaptive learning based on changes to organization’s sentiment values](adaptive-learning.md)  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
     --OR--  
  
     Go to the post in your stream.  
  
2.  Select the post you want to edit and expand the contents.  
  
3.  Click the smiley face to see the sentiment value selection.  
  
4.  Edit or confirm the sentiment value of the post.  
  
> [!NOTE]
>  Editing or confirming a sentiment value will treat the post’s sentiment value as manually-edited in the **Data Coverage** widget in **Analytics** > **Sentiment**.  
  
> [!TIP]
>  You can confirm or edit the sentiment value of several posts at the same time when viewing them from a stream or in the post list in Analytics. To confirm or edit the sentiment value, select the check box on the left side of each post that you want to edit, and then click **Edit Sentiment**.  
  
<a name="labels"></a>   
## Add a label to a post in Analytics or Social Center  
 Outline workflows and track the status of a post by attaching a label to the post. You can also filter by labels in Analytics to find posts with specific labels or exclude posts with specific labels. Administrators define the labels to choose from in **Settings** > **Global Settings** > **Labels**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage global settings](manage-global-settings.md)  
  
> [!NOTE]
>  You must have at least a Responder interaction role to perform this task.  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
     --OR--  
  
     Go to the post in your stream.  
  
2.  Select the posts for which you want to add or change a label.  
  
3.  Click **Set Label**, and then select the label from the list.  
  
> [!TIP]
>  You can change the label of a post at any time by overriding the existing label.  
>   
>  To remove a label from a post, click **Set Label** and then click **Clear Label**.  
  
<a name="assignTo"></a>   
## Assign a post to other users in Analytics and Social Center  
 Bring a post to a specific user’s attention and surface it in the user’s Inbox stream. Every user of your [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] solution can have posts assigned. Additionally, you can assign posts to a group. You must have at least a Responder interaction role to perform this task.  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
     --OR--  
  
     Go to the post in your stream.  
  
2.  Select the post you want to assign or reassign.  
  
3.  Click **Assign this post** ![User symbol](media/user-avatar-icon.png "User symbol").  
  
4.  In the **set assignee** menu, select **User** or **Group** in the **All user type** drop-down list.  
  
5.  Start typing and select the user or a group from the list.  
  
> [!TIP]
>  To see the posts assigned to a user or a group, apply an **Assignee** filter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get to know your filters](understand-filters.md)  
>   
>  For more information about groups, see [Work with Office 365 Groups in Social Engagement](office-365-groups-social-engagement.md).  
  
<a name="Add_a_custom_tag"></a>   
## Add or remove tags  
 Social engagement allows intention tags and custom tags to be added to posts. Intention tags are predefined tags that are automatically added once a post is acquired. Custom tags are different from intention tags because they are not predefined and need to be manually added. Custom tags can't be automatically added to posts unless they are promoted to auto tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tag posts with intention tags and custom tags](tags.md)  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
     --OR--  
  
2.  Go to **Social Center** to see your streams.  
  
3.  Click a post to see post details, and next to the custom tags symbol ![Tag symbol in Social Engagement](media/tag-symbol.png "Tag symbol in Social Engagement"), click **Add** ![Add button](media/add-icon.png "Add button"). Start typing to enter the  tag that you want to add, and then click **Confirm**.  
  
4.  To remove tags,  click **remove** ![Delete button](media/delete-icon.png "Delete button") next to the tag you want to remove.  
  
<a name="delete"></a>   
## Delete posts  
 You may find posts in your data set that match one of your search topics but are irrelevant in your context. It’s easy to remove those posts. Reduce unwanted noise by deleting posts from your solution’s database. Once a post is deleted, it can’t be restored and it will no longer count against your solution’s monthly post quota.  
  
> [!NOTE]
>  -   You can’t undo this action, and Support can’t restore deleted posts.  
> -   Deleting a post also deletes associated data like notes, sentiment edits, user assignments, labels, or information about linked [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records assigned to a post.  
> -   Please be aware that tweets which are deleted on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] will also be deleted in [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] to meet the expectation and intent of users. The information if a tweet was deleted on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] and in [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] will not be disclosed.  
  
 You must have at least a Power Analyst Analytics role to perform this task.  
  
### Delete posts in Analytics  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
2.  Select the post you want to delete.  
  
3.  Click **Remove**, and then confirm your selection.  
  
### Delete posts in streams  
  
1.  Go to **Social Center**.  
  
2.  Choose your stream and a post in it.  
  
3.  Click the post to expand the contents.  
  
4.  Click **Remove** and then confirm your selection.  
  
<a name="link_post"></a>   
## Link a post from Social Engagement to Dynamics 365  
 [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] allows users to create a link from a post in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to an entity in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] instance. When you link a post in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance, it creates a social activity. Your administrator can define rules to process this social activity in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](create-dynamics-365-record-from-social-post.md)  
  
<a name="privacy"></a>   
### Privacy notice  
 [!INCLUDE[cc_privacy_msl_social_services_content](../includes/cc-privacy-msl-social-services-content.md)]  
  
### See Also  
 [Drive business objectives using posts](publish-react-posts.md)   
 [Analyze social data using widgets](analyze-social-data-using-widgets.md)   
 [Keep track of live data streams with Social Center](social-center.md)
