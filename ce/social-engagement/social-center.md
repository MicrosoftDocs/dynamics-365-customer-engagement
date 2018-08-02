---
title: "Streams in Social Center of Microsoft Social Engagement | Microsoft Docs"
description: "Get started to work efficiently in Social Center."
keywords: "social center, streams, post list, social engagement, engagement"
ms.date: 06/13/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 4388d9c3-ff21-bdb5-7757-69093b2576ef
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom:
  - dyn365-socialengagement
---

# Keep track of live data streams with Social Center
Social media runs at a fast pace. To keep up and collaborate efficiently, your personal streams come in handy. Manage your streams, share them with other users, and stay informed in real time on new and updated posts. New posts are posts that were recently picked up by a search topic and processed to appear in a solution. Fresh posts are posts whose metadata has been changed recently (for example, a label was added or a post received a reply). Streams use filters to define the data set and surface the most relevant posts.  

 
 To see your streams, go to **Social Center**.  
  
 Streams in Social Center are user-specific, meaning that every user sees only streams they own or that are shared with them. Depending on your interaction role, you can create, edit, share, or delete streams, or interact with posts from your streams. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](user-roles.md), [Drive business objectives using posts](publish-react-posts.md)  
  
 Streams show posts from the last 14 days. To review older posts that match a stream's filters, click **Open earlier posts in Analytics** ![More options with current filters](media/more-options-with-current-filters-icon.png "More options with current filters") at the bottom of the stream. This opens the same data set with an extended time frame in Analytics. Or you can change the time frame for the posts to display however you want. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Open a data set in other areas of Social Engagement](more-options-with-data-set.md)  
  
> [!NOTE]
>  If you have a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Professional user license, you can have up to two streams in Social Center. Streams shared with you and streams you own both count toward that limit. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate Social Engagement with Office 365](manage-licenses.md)  
  
<a name="ConfigureStream"></a>   
## Configure a stream  
 Create new streams to keep track of the posts that are most important to you. Each stream is based on a data set you define when you configure the stream. See in real time how new posts are coming in, and then work with these posts directly from your streams.  
  
 For example, you can create a stream called **Inbox** that checks all search topics for posts that are assigned to you. In other words, an Assignee filter with the value of the currently signed-in user is applied to all search topics. Posts that match this filter show up in the stream.  
  
### Configure a stream  
  
1.  Go to **Social Center**.  
  
2.  Scroll to the stream on the far right side, and then click the **Add Stream** button ![Add button](media/add-icon.png "Add button").  
  
3.  Provide a name for your stream.  
  
4.  You can also choose how you want the stream to handle posts that no longer match the defined data set:  
  
    -   Click **Automatically hide posts** if you want to work with an up-to-date stream. When a post is updated so it doesn't match the stream’s data set anymore, it will disappear without any notification.  
  
    -   Click **Notify me when hiding posts** if you want to get a heads up if a post no longer matches your data set and is about to be hidden from the stream.  
  
5.  Choose a color and adjust your sorting options. (Optional)  
  
6.  Select users from your organization you want to share this stream with under **Sharing**. (Optional)  
  
7.  In the **Filters** section, define the data set to show in this stream. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use filters to see relevant data](use-filters.md)  
  
8.  Click the **Save** button ![Save button](media/save-icon.png "Save button").  
  
<a name="ShareStream"></a>   
## Share a stream  
 Share streams you own to enable seamless collaboration within your organization’s teams. You need to have a Manager [interaction role](user-roles.md) to manage the sharing of streams.  
  
 Users or groups you share the stream with will always see the data the way you have configured it. If you change the data set for a shared stream, the displayed data will also change for the users the stream is shared with.  
  
### Share a stream you own  
  
1.  Go to **Social Center**.  
  
2.  Scroll to the stream you want to share.  
  
3.  In the stream header area, click **More options** ![More options](media/more-options-icon.png "More options"), and then click **settings** ![Configuration button](media/settings-icon.png "Configuration button").  
  
4.  Under **Sharing**, click the **Add** button ![Add button](media/add-icon.png "Add button").  
  
5.  In the **Share** dialog box, choose **User** or **Group** in the **Type** drop-down list.  
  
     For more information about groups, see [Work with Office 365 Groups in Social Engagement](office-365-groups-social-engagement.md).  
  
6.  Select users or groups from your organization you want to share this stream with, and then click **Add**.  
  
7.  Click the **Save** button ![Save button](media/save-icon.png "Save button").  
  
> [!IMPORTANT]
>  When you select **Shared with all users**, all users in your organization will see this stream on their Social Center page. Because there is no way to hide a stream, we recommend that you use this option with restraint.  
  
<a name="EditStream"></a>   
## Edit a stream  
 Update the configuration of a stream if you want to refine the data to be shown in the stream, or change its settings.  
  
### Edit a stream you own  
  
1.  Go to **Social Center**.  
  
2.  Find the stream you want to edit.  
  
3.  In the stream header area, click **More options** ![More options](media/more-options-icon.png "More options"), and then click **settings** ![Configuration button](media/settings-icon.png "Configuration button").  
  
4.  Edit your stream according to your requirements.  
  
5.  Click the **Save** button ![Save button](media/save-icon.png "Save button").  
  
> [!IMPORTANT]
>  Editing the data set of a stream that you share with other users directly affects the data they see in their shared streams. Your changes are reflected when you save your changes, and other users connected to the same stream are notified that the configuration changed.  
  
<a name="DeleteStream"></a>   
## Delete a stream  
 You might want to delete a stream from Social Center, for example a stream that was useful for a certain event but you no longer need. If you delete a stream you share with other users, keep in mind that it will be deleted for them too. Before deleting the stream, make sure your co-workers are aware of your plans.  
  
### Delete a stream you own  
  
1.  Go to **Social Center**.  
  
2.  Find the stream you want to delete.  
  
3.  In the stream header area, click **More options** ![More options](media/more-options-icon.png "More options"), and then click **settings** ![Configuration button](media/settings-icon.png "Configuration button").  
  
4.  Click the **Delete** button ![Delete button](media/trashbin-icon.png "Delete button").  
  
5.  Confirm your deletion.  
  
<a name="NextSteps"></a>   
## Next Steps  
  
-   Assign posts to others, add labels, tag them, or edit sentiment values. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with posts](work-with-posts.md)  
  
-   Publish new posts or reply to posts directly from within the application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Drive business objectives using posts](publish-react-posts.md)  
  
### See also  

[Engage on social networks](engage-on-social-networks.md)   
[Get relevant data using filters](use-filters.md)   
[Work with posts](work-with-posts.md)   
[Drive business objectives using posts](publish-react-posts.md)
