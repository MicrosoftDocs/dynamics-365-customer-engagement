---
title: "Work with tags | Microsoft Docs"
 
description:

ms.custom: ""

ms.date: 2017-05-19
ms.reviewer: ""
ms.service: mse
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: 1cf877c0-f5a0-43fc-9bf0-1c5ef12359e1
caps.latest.revision: 27
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Work with tags
Intention tags and custom tags are two ways [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] allows you to prioritize and filter your posts. When authors publish posts on social media, they usually have a messaging purpose in mind. The larger the number of posts, the more work intensive and time consuming it gets to read through all of these posts and identify those relevant for your business—for example, to find out if authors are asking a question that you want to answer, or if they are complaining about a service that you want to follow up on. In [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], once a post is acquired from a search topic, we take some of the workload off your desk. Acquired posts are analyzed by the machine-learning based algorithm to detect authors’ intentions or you can add your own custom tags and later promote them to auto tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with posts](../social-engagement/work-with-posts.md)  
  
<a name="intention_analysis"></a>   
## How intention analysis works  
 Intention analysis is applied to posts when they are picked up by a search topic. Posts are scored against the algorithm and, if applicable, marked with the intentions identified. A post can have multiple intention tags, but more commonly there’s just one.  
  
 The following intention tags ![Tag symbol in Social Engagement](../social-engagement/media/tag-symbol.png "Tag symbol in Social Engagement") are used by [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
|||  
|-|-|  
|**Intention tag**|**What the author expresses**|  
|Purchase|Interest in buying a product or service|  
|Complaint|Frustration about a product or service|  
|Information request|A need for additional information about a service or product|  
|Support request|A need for help and support in using a service or product|  
  
> [!NOTE]
>  Intention analysis is available for [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] posts found on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] and [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] in the English language.  
  
 Intention tags ![Tag symbol in Social Engagement](../social-engagement/media/tag-symbol.png "Tag symbol in Social Engagement") are predefined in [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. The machine learning service makes predictions on whether posts relate to one of the supported intention tags. We recommend that you remove or add intention tags from posts if they aren’t accurate to improve machine learning. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with posts](../social-engagement/work-with-posts.md)  
  
<a name="add_custom"></a>   
## Add custom tags  
 [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] lets you add one or more custom tags to posts. You can then filter posts to match specific custom tags. Custom tags are different from intention tags because they are not predefined tags and they are not automatically added once a post is acquired. Each post acquired needs a custom tag manually added. Users can define streams by assigning custom tags.  
  
> [!NOTE]
>  Only Managers and Responders can create a new custom tag, but any user role can add or remove tags on posts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](../social-engagement/user-roles.md)  
  
1.  Click **Posts** on the right side of any Analytics page to see the posts list.  
  
     --OR--  
  
     Go to **Social Center** to see your streams.  
  
2.  Click a post, and then next to the custom tags symbol ![Tag symbol in Social Engagement](../social-engagement/media/tag-symbol.png "Tag symbol in Social Engagement") , click **Add** ![Add button](../social-engagement/media/add-icon.png "Add button") . Start typing to enter the custom tag that you want to add,  and then press **Enter** to select the tag.  
  
3.  Click **Confirm**.  
  
    > [!NOTE]
    >  The maximum amount of custom tags you can add per post is 20 tags. To add more tags, you must first remove other tags.  
  
> [!NOTE]
>  To configure a tag for the Social Selling Assistant, see [Configure a custom tag to promote posts](../social-engagement/configure-social-selling-assistant.md#configure-a-custom-tag-to-promote-posts).  
  
<a name="promote_customtags"></a>   
## Promote custom tags to auto tags  
 Enable adaptive learning on your custom tags by adding them to your list of auto tags. [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] applies adaptive learning on auto tags to predict tags for new incoming posts.  The system learns from posts when the user makes edits and actions on tags.  Custom tags use text analytics and Azure Machine Learning techniques to learn patterns from posts that are manually tagged by the user. As more labeled posts becomes available, the service can continually learn and improve quality. Labeled posts  include tags that are added by the user manually, tags that are added by the system and confirmed by the user, or tags that are added by the system and removed by the user. New incoming posts can be scored automatically by the service and leveraged/tracked throughout [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. To improve your workflows and increase efficiency, you can leverage auto tagged posts in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] as email alerts, streams, activity maps, and automation rules. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Route posts using automation rules](../social-engagement/automation-rules.md)  
  
> [!NOTE]
>  Only Admins can promote custom tags to auto tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](../social-engagement/user-roles.md)  
  
### Add a custom tag to your auto tags list  
  
1.  Go to **Settings** > **Global Settings**  
  
2.  In the Global Settings pane, click **Auto Tags**.  
  
3.  Under Auto Tags, click **Add tag** ![Add button](../social-engagement/media/add-icon.png "Add button")  
  
    > [!NOTE]
    >  You can maintain up to five auto tags simultaneously.  
  
4.  In the **Add Auto Tag** pane, enter a tag to search and select existing custom tags to be turned into auto tags.  
  
5.  Click **Save** to apply your changes.  
  
6.  In your list of custom tags, select the tag, and then in the **Tag Details** pane, set **Auto tagging** to **On**.  
  
     --OR--  
  
     In your list of custom tags, set **Auto tagging** to **On** next to the custom tag title.  
  
    > [!NOTE]
    >  It may take up to six hours for posts to start being automatically tagged.  
  
### Tag details view  
 You can check the quality of your auto tags at any time to ensure a high quality model. It's important to understand that quality varies over time and you should turn auto tagging  on only after your quality is acceptable. To achieve acceptable quality, Social Engagement recommends that you have at least 50 posts tagged first.     To check the quality of your auto tags, click the tag name in the list. In the Tag Details pane, you can see the quality, quality history, and tagged posts history of that auto tag.  
  
 **Quality**: The quality indicates whether the score of your selected tags exceeds or doesn't meet the minimum quality requirements.  
  
 **Quality History**: The quality history chart shows the quality of the auto tag from the past 30 days.  
  
 **Tagged posts history**: The Tagged posts history chart shows how many tags have been automatically tagged and how many have been manually edited since turning auto tagging on.  
  
### Remove auto tags  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the Global Settings pane, click **Auto Tags**.  
  
3.  In the Auto Tags panel, click **Remove**, and then click **Confirm**.  
  
    > [!NOTE]
    >  Removed tags will remain visible on previous posts, but auto scoring will stop for incoming posts.  
  
## Manage your tags  
  
#### Delete tags  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the Global Settings pane, click **Custom Tags**.  
  
3.  In the Custom Tags panel, next to the tag name, click **Delete** ![Delete button](../social-engagement/media/trashbin-icon.png "Delete button"), and then click **Confirm**.  
  
#### Rename tags  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the Global Settings pane, click **Custom Tags**.  
  
3.  In the Custom Tags panel, click **Edit** ![Edit button](../social-engagement/media/edit-icon.png "Edit button") next to the tag name, and then start typing in the edit box.  
  
4.  Click **Confirm** ![Apply button](../social-engagement/media/check-icon.png "Apply button")  
  
## Find posts with  tags  
 To quickly find posts with tags ![Tag symbol in Social Engagement](../social-engagement/media/tag-symbol.png "Tag symbol in Social Engagement"), use the  Tags filter when building a data set. You can also create automated rules to monitor your intention tags and custom tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use filters to see relevant data](../social-engagement/use-filters.md "Use filters to see relevant data") , [Route posts using automation rules](../social-engagement/automation-rules.md "Route posts using automation rules")  
  
### See Also  
 [Manage global settings](../social-engagement/manage-global-settings.md)   
 [Work with posts](../social-engagement/work-with-posts.md)
