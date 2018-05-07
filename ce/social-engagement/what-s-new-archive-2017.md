---
title: "Archive - Social Engagement 2017 Update x.x | Microsoft Docs"
description: "Archive of What's New updates for Social Engagement releases in 2017."
keywords: "release notes, 2017, what's new"
ms.date: 01/30/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: dc269cf9-1f86-4f9d-bf50-c1977db83027
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom: dyn365-socialengagement
---

# Microsoft Social Engagement 2017 Updates

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.11

### Support for [!INCLUDE[tn-twitter](../includes/tn-twitter.md)]'s extended tweet length

With this update, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] supports the new tweet length that was [recently released by Twitter](https://blog.twitter.com/official/en_us/topics/product/2017/tweetingmadeeasier.html). When tweeting, you'll benefit from the increased 280-character limit. Temporarily, tweets with Japanese, Korean, and Chinese characters will not be accurately reflected in the character limit. If your tweet is too long, you will receive an error message and you can shorten it.  
  
By early 2018, we plan to update our service to use the new [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] logic for any language and character set.

### New table and pattern view for charts in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

A new table view on all existing charts in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] is now available. This means that every user can decide whether they want to explore the data represented as charts or as tables.   
You can either turn on the table view on single charts or you can enable the table view globally for your user profile in **Settings > User Preferences** under **Chart data representation mode**. 

Additionally, we're introducing a new style for charts with colored areas. You can choose to render the charts with a fill pattern or a solid color.
To switch between fill pattern and solid color, go to **Settings > User Preferences** and update the **Chart filling mode**.


### Redesigned activity map and pause functionality

We're introducing new pause functionality to the activity map feature. This enables you to choose whether you want to get live updates on the map, or not. When turned off, posts will stop updating automatically and you can view and explore a snapshot in more detail. New posts will appear again when live updates are turned on and new posts are available.   

In addition to that, the activity map has received a couple of visual updates, such as bigger dots on the map and updated visuals in the activity map header. 

### New field in the JSON payload for Azure Event Hubs: post.profile.uri

Social Engagement includes a feature that allows users to send posts to [Azure Event Hubs](https://azure.microsoft.com/services/event-hubs/) using Automation Rules. As part of evolving functionality, Social Engagement is updating the [JSON payload](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/event-hubs-json-reference-social-engagement) by replacing the post.profile.id field with a new post.profile.uri field. 
Moving forward, post.profile.uri will also include a source-based identifier as part of the field value (for example: mse-tw://#12345678).

Please make sure you follow the timeline outlined [in this blog post](https://blogs.msdn.microsoft.com/crm/2017/11/27/deprecation-of-post-profile-id-object-in-social-engagement-json-payload/) to avoid breaking your apps and intermittent data loss. 

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.10

### Updated user experience for activity maps

To make activity maps more accessible to everyone, we introduced shapes as an additional way to display information on maps. Sentiment values and the age of posts are now expressed in colors and shapes. 

### Update to alert emails

Alert emails now provide a link to the Analytics area in the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] app, where you can see the posts that match the data set that triggered the alert. Post content is no longer delivered as part of the email message. These links now also reflect changed alert configurations and deleted alerts.


### New video training on Microsoft Virtual Academy

Learn how to build search topics and navigate [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to get the most out of it. Plus, examine different strategies for managing your social presence.
Explore the social engagement circle and social strategy, and look at brand reputation and social business opportunities. Look at post consumption and analytics, configure automation options, and much more.

[Learn more in the Microsoft Social Engagement course on MVA.](https://go.microsoft.com/fwlink/p/?linkid=861639)


### New social post packs for Microsoft Social Engagement

In addition to the 10,000 monthly post package for Microsoft Social Engagement, new packages with 100,000 and 1,000,000 monthly posts are now available as part of the [Microsoft Products and Services Agreement (MPSA)](https://www.microsoft.com/Licensing/worldwide.aspx). The MPSA is a transactional licensing agreement for commercial, government, and academic organizations that have 250 or more users or devices.

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).


## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.9

### User experience cleanup for Search Setup and Settings

**Settings** and **Search Setup** now follow common patterns in how you confirm web forms. It's clearer where to change the name of a search topic category or a search topic in the second panel instead of the overview panel. Quota information is now shown in the first panel to make sure all users have immediate access to it on any device.

### Post list improved for easy access to post details

To simplify how you open the details view of a post, we added a small header to each post that identifies the type of post it is and provides an **Open** control that you use to see post details. As before, you can't open the details view for posts listed in the threads section of post details&mdash;those posts don't show the **Open** control.

### Post details improved to distinguish a child post from its parent post

Whenever you open a post that has a parent post, you can switch to that parent post by selecting the content. Based on feedback, and to further improve keyboard navigation, we now show headings for each section by using an expand/collapse control. When selected, it will expand or collapse that part of the post details view.

### Twitter data use license requirements 

Your use of [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] data in the [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] product is subject to the [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] Terms of Services (ToS). We recommend you review these terms carefully, as failure to observe these terms can result in a loss of access to [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] data in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. For easy reference, a link to the [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] ToS is included in the footer of every page in the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] service.  

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.8

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] extends listening and engagement capabilities to [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages you administer, so you can interact with your company's audience and analyze the data from your pages directly in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. 

### Listening and engagement on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] now lets you search for all posts and comments on your own [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages, also known as [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Company Pages. You can add any [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages you administer as social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. After a page admin has added the page and shared it with other users, they can like posts and reply to posts and comments on behalf of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a LinkedIn Page rule](./add-rules-search-topic.md#linkedin-page-rule)

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.7

### Listening and engagement on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)]

Get in touch with your audience on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] directly from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Users with at least a Responder interaction role can now rate and reply to videos and comments on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)]. You'll need to add a social profile for [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] under **Settings** > **Social Profiles**, or get a [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] profile shared with you before you can interact in this source.

Additionally, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] extended the listening capabilities and is now capable of acquiring video posts and comments on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels. Any user with permission to create search rules can create [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] rules under any search topic and add [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels to gather posts and comments. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a YouTube rule](add-rules-search-topic.md#add-a-includetnyoutubeincludestn-youtubemd-rule)

Keyword-based searches on the video source continue to reside under the [keywords rule](add-rules-search-topic.md#add-a-keywords-rule) and now also contain comments for actively discussed video posts. 

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.6

### Improved base model for sentiment analysis

To improve and refine the base sentiment model, we've modified the machine learning process and added training data. You don't have to do anything to benefit from these improvements. If you activated [adaptive learning](adaptive-learning.md) for your organization, all the edits you've made to sentiment values will automatically be applied to the improved base model.

### Improved load-balancing for data acquisition

Performance and reliability are key to providing a stable data acquisition pipeline that can handle massive amounts of data all day, every day. Emerging trends or events often generate a significant number of posts on social media. To make the data acquisition service even more reliable and stable, we've improved the way the system handles these varying volumes of data.

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.5

### Service and product improvements

We've addressed service and product improvements with this release. For changes we've made to the user experience, please see [this detailed blog post](https://blogs.msdn.microsoft.com/crm/2017/06/09/whats-new-in-microsoft-social-engagement-2017-update-1-5/).

Additionally, we've continued our ongoing investment to make [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] more accessible. With the current release, the Social Selling Assistant within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] supports keyboard navigation and screen readers on mobile and desktop devices.

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.4

### Engagement Analytics with [!INCLUDE[Power BI](../includes/pn-power-bi.md)]

We've added an Engagement Analytics report to our recently introduced [!INCLUDE[Power BI](../includes/pn-power-bi.md)] content pack for [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Along with the previously released Engagement Performance and Team Performance reports, the Engagement Analytics report gives you more insights about your engagement on social media by using metrics based on location, sentiment, tags, and authors. The data model is also enhanced to include these additional dimensions, giving you more power to explore and analyze your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] data. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get the Microsoft Social Engagement content pack for Power BI](get-content-pack-for-power-bi.md) 

### Improved usability in Social Selling Assistant

The Social Selling Assistant user experience got its first polishing pass, and now the **Done** button appears next to the other actions at the bottom of the card. 

We aligned the forms in Social Selling Assistant configuration and the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Settings page **User Preferences** with industry standards. Now when those forms are edited, the **Save** and **Cancel** buttons appear at the bottom of the input form. Additionally, the main navigation contains a direct link to the Post view in Analytics, filtered for private messages, so you can get to your customers' messages in a single click. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with the Social Selling Assistant](work-with-social-selling-assistant.md) 

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.3

### [!INCLUDE[Power BI](../includes/pn-microsoft-power-bi.md)] content pack for [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] introduces the [!INCLUDE[Power BI](../includes/pn-microsoft-power-bi.md)] content pack to get insights about your engagement and team performance on social media. This content pack is designed specifically for community managers, providing performance metrics for engagement actions taken from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Track metrics, such as the number of actions taken and average response times, and get visibility into the performance of each member of your team. [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] automatically creates the dashboard and generates reports that give you a great starting point for exploring and analyzing your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] data. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get the Social Engagement content pack for Power BI](get-content-pack-for-power-bi.md) 

### Conversation view for private messages and Twitter replies

Starting with this update, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] shows you any conversation that involves private messages (on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] or [!INCLUDE[tn_twitter](../includes/tn-twitter.md)]) or [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] replies between a customer and one of your social profiles. The back and forth conversation between two authors shows the latest post at the top along with the two authors, including the one who belongs to your team and answered as your social profile. This view also shows all the team members who answered as that social profile.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the conversations with an author](posts-conversations.md#conversationView)

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.2

### Get insights with the Social Selling Assistant

The [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Social Selling Assistant introduces Get Insights, a new recommendation type you can use to get recommendations for posts about your customers, competitors, and other topics of interest so you can stay on top of the latest developments.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Personalize the Social Selling Assistant](personalize-social-selling-assistant.md), [Empower your salespeople with the Social Selling Assistant](social-selling-assistant-overview.md)

### Engagement history contains user information

The engagement action history now shows the name and profile picture of the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] user who performed the action in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish and react to posts](publish-react-posts.md)

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2017 Update 1.1

### Sell more with the Social Selling Assistant

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] introduces the Social Selling Assistant to empower your salespeople to sell more by using social media. With this application, your salespeople get personalized, smart recommendations for posts to share on their social networks to increase their social presence, gain trust from their followers, and generate more leads.

You can access the Social Selling Assistant from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] and install it from Microsoft AppSource into your [!INCLUDE[Dynamics 365 for Sales](../includes/pn-ms-dyn-365-for-sales.md)] application. The AppSource app adds a new dashboard that contains the Social Selling Assistant. Salespeople can access this dashboard from the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web client, and from [!INCLUDE[pn_dyn_365_tablets](../includes/pn-dyn-365-tablets.md)]. [!INCLUDE[pn_dyn_365_phones](../includes/pn-dyn-365-phones.md)] is currently not supported.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Empower your salespeople with the Social Selling Assistant](social-selling-assistant-overview.md)

### User interface now available in Japanese and Chinese (traditional)

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] introduces the user interface in Japanese and Chinese (traditional) languages. You can change the language of your user interface under **Settings** > **Personal Settings** > **Your Preferences**. The localization of the user interface also includes the respective calendars for Japanese and Chinese (traditional) languages.

### Share a post to [!include[LinkedIn](../includes/pn-linkedin.md)]

With this release, you can add your personal [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] account as a social profile and share any public post in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to your professional network on [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)]. Your [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] social profile will be available for the post action **Post Link**. When you share to [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)], you can choose between two visibility options: show the post to everyone on [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] or to your network only. This post action is available across all [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] services, including the newly released Social Selling Assistant. To start sharing, go to **Settings** > **Social Profiles**, select **Add Profile**, select **[!include[LinkedIn](../includes/pn-linkedin.md)] Profile**, and then follow the steps.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage social profiles](manage-social-profiles.md)

### See also
[What's new archive 2016](what-s-new-archive-2016.md)
[What's new archive 2015](what-s-new-archive-2015.md)
