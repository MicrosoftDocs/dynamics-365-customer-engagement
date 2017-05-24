---
title: "View posts and conversations in Social Engagement | Microsoft Docs"
 
description:

ms.custom: ""

ms.date: 2017-05-19
ms.reviewer: ""
ms.service: mse
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: 864f81b7-bf35-4302-8da5-585c71cba333
caps.latest.revision: 4
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# View posts and conversations in Social Engagement
[!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] provides two ways to access the list of posts that match a given data set. You can either work with the post list or with a stream, depending on your requirements and preferences.  
  
<a name="access"></a>   
## Access posts in Analytics and Social Center  
 To show the post list, click **Posts** on the right side of any Analytics page or Activity map. Posts in the post list within Analytics don’t get updated automatically. You need to refresh the page to see the latest updates. However, you’ll get notified when another user changes a value of the same post that you’re working on. For example, if another user already changed a sentiment value, your planned update may no longer be required.  
  
 Or go to **Social Center** to access your streams. Choose the stream you want to work with. If you select a post in your streams, you can expand the contents (if applicable) to read the post.  
  
 To quickly see new posts that match a pre-defined data set, set up a stream in **Social Center**. Fresh and updated posts are automatically pushed to your client, to make sure you’re always on top of the information. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Keep track of live data streams with Social Center](../social-engagement/social-center.md)  
  
 In the post list, you find the posts and the main actions to work with posts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Engage on social networks](../social-engagement/engage-on-social-networks.md), [Work with posts](../social-engagement/work-with-posts.md)  
  
 If you select a post, it shows the single post pane, providing a full view of the contents with all available actions.  
  
 The details of a post are displayed depending on the interactions from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. By default, posts show the single post pane which focuses on displaying a post and its threads. It gives you access to all its content and (if available) also the parent post. If there are direct interactions between an author and one of the social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], you'll find the conversation view. It is optimized to show the interactions between customers and your owned social profiles.  
  
 Posts in post list which opens a conversation view:  
  
-   Any private message.  
  
-   A [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] reply if that reply involves one of the social profiles in your tenant.  
  
    > [!NOTE]
    >  This can include all social profiles not just the ones shared to the current user.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the conversations with an author](#conversationView)  
  
 Any other post in the post list will open the single post pane with post details. For example, If a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] reply involves authors which aren’t social profiles in your tenant, then they show in the single post pane. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the publish history of a post in Social Engagement](#publishHistory)  
  
<a name="Threads"></a>   
## See threads of replies and retweets on Twitter  
 When you view the details of a post, all [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] replies reference the tweet the post refers to. Every [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] reply has a parent post, which you may interact with, depending on whether that tweet was acquired through your search topics.  
  
 [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] supports two types of threads for a tweet: retweets and replies.  
  
 For [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] replies, you see the thread of all replies acquired in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] that reply to the parent post. Replies to replies or entire conversations aren’t covered in the threads.  
  
 For retweets, you see the thread of all retweets of a parent tweet.  
  
<a name="publishHistory"></a>   
## See the engagement action history of a post in Social Engagement  
 Communicate consistently and find out if another user has already taken action on a post that you plan to interact with.  
  
 When a user takes a publish action on a post in the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] application, this action is visible to other users as the publish history. The publish history contains the social profile along with the users who posted using this social profile the timestamp, the type, and the published content of the action.  
  
 This helps avoid unwanted duplications. For example, if somebody on your team has already replied to a question, your planned answer might no longer be necessary.  
  
 To see the publish history on a post in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], two prerequisites apply:  
  
1.  The post you plan to interact with has been acquired by one of the search topics.  
  
2.  Earlier interactions on this post were performed in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
 To see posts with engagement action history, look for posts that have a number appended to the action button.  
  
 If another user changes a value on a post you’re working on, you’ll be notified through the user interface that the post was refreshed, and you’ll see the most recent version. Make sure your planned action still makes sense when you try to perform it.  
  
 To build custom [!INCLUDE[pn_microsoft_power_bi](../includes/pn-microsoft-power-bi.md)] reports about how efficiently your team engages on social media, see [Get the Power BI content pack for Microsoft Social Engagement](../social-engagement/get-content-pack-for-power-bi.md).  
  
<a name="conversationView"></a>   
### See the conversations with an author  
 When you engage in a private conversation or reply on Twitter using a social profile in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], these posts allow you to see the full conversation.  
  
 ![Conversation view of a post with several replies and direct messages.](../social-engagement/media/conversation-view-callouts.png "Conversation view of a post with several replies and direct messages.")  
  
1.  Addressee of the conversation. In many cases, this is a customer requesting information or help.  
  
2.  Owned social profiles that participate in a conversation. Team members that used the social profile to interact with an author are listed below the profile.  
  
3.  Type of posts that are part of this conversation.  
  
4.  Timestamp of the interaction.  
  
 To show you and your team all sent messages, the Conversation view even shows you messages sent from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] which haven’t yet been acquired.  
  
 Example: Say you and your college currently respond to customer queries on social media. Given you open the conversation with a customer and answer from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], your colleague sees the message you just sent regardless of how fast [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] acquires this post through configured searches. As soon as that post is acquired by one of your searches, you can access the details for that post. In the conversation view all actions on individual post like assigning, labeling and tagging aren’t available. To get access to those you can open the single post pane for the individual post and perform your action in the post details.  
  
> [!NOTE]
>  The information depends on the number of posts you have loaded in the conversation view. To increase the number. scroll to the bottom of the view where you’ll can load additional posts.  
>   
>  Publish actions taken before mid-March 2017 are indicated  with an appended  star symbol ![Asterisk icon](../social-engagement/media/asterisk-icon.png "Asterisk icon").  
  
<a name="parts"></a>   
## Parts of a post  
 On the left side of a post, you’ll find a symbol that indicates the post’s source, the profile picture (if available), and the name of the post’s author.  
  
 In the center of the post list, you’ll find the title and content of a post. Select a post to see its details. Click the **expand** button ![Expand button](../social-engagement/media/expand-content-icon.png "Expand button") next to the post’s content excerpt to expand the post and read its content.  
  
 You’ll find additional metadata and controls for the posts:  
  
- **Sentiment value:** See which sentiment value the application calculated for a post. You can manually update a sentiment value by selecting a different value from the drop-down list. Fragments of a post that were rated positive are highlighted in green and negative fragments are highlighted in red.  
  
- **Remove post**: Deletes the post from your solution’s database.  
  
- **Copy internal URL (![Copy button.](../social-engagement/media/copy-url-icon.png "Copy button."))**: Generates an internal link to this post in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. Copy this URL to your clipboard and share it with other users of [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to point them at a specific post.  
  
- **Reach**: This indicates the potential size of an author’s network and connections on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] or the influence of a News source. The higher the number of an author’s reach, the more likely that this is an influential author. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get relevant data using filters](../social-engagement/use-filters.md)  
  
- **Date and time of publication**: The date and time when the post was published by the author. Redirects you to the original URL where the post was found. This lets you see the post in the context of the site or social network it originated from.  
  
- **Post location**: The geographical location information (latitude/longitude) that a user shared when publishing the post (if available). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the locations for the posts](../social-engagement/analytics-location.md)  
  
- **Author location**: The geographical information that a user shared on a profile (if available). For example, this can be the location of a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] user as it’s been entered in the user’s [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the locations for the posts](../social-engagement/analytics-location.md)  
  
- **Author details**: The details about a user’s [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile. The author name, username, profile picture, location, website, and bio are provided if the author has been active in the last 30 days. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get details on specific authors](../social-engagement/author-details.md "Get details on specific authors")
