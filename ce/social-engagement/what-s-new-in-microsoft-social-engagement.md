---
title: "What's new in Microsoft Social Engagement | Microsoft Docs"
description: "Learn about the recent changes and new features in Social Engagement."
keywords: "news, product updates, product improvements, service updates"
ms.date: 10/03/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: e8941c81-866f-4363-8ca1-fc035f9a3844
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# What&#39;s new in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]

Welcome to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. Here's a list of features we added recently.

If you're new to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], see [Get started with Social Engagement](../social-engagement/get-started.md).

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

For important, late-breaking information and a list of known issues, see the [Social Engagement Readme](http://go.microsoft.com/fwlink/p/?LinkID=393612).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.9

### User experience clean-up for Search Setup and Settings

**Settings** and **Search Setup** now follow common patterns in how you confirm the web forms. It's clearer where to change the name of a search topic category or a search topic in the second panel instead of the overview panel. Quota information is now shown in the first panel to make sure all users have immediate access to them on any device.

### Post list improved to be clearer

With the goal of simplifying how to open the post details view of a post, we added a small header to each post stating its type and providing an **Open** control which lets you see post details. As previously, opening post details isn’t supported for the post list in the threads section of post details. Those posts don’t show the **Open** control.

### Post details improved to distinguish main from parent post

Whenever you open a post which has a parent post, the UI allowed to switch to that parent post by selecting the content. Based on feedback and to further improve keyboard navigation, we changed post details to show headings for each section with a expand/collapse control. When seelcted, it will expand or collapse that part of the post details view.

### Updated license related to Twitter data use

The use of [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] data in [!INCLUDE[pn-netbreeze-long](../includes/pn-netbreeze-long.md)] now underlies the [!INCLUDE[tn-twitter](../includes/tn-twitter.md)] Terms of Services. This is exposed in the footer of every page of the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] app. The provided link points to [!INCLUDE[tn-twitter](../includes/tn-twitter.md)]'s Terms of Services. 

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.8

[!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] extends listening and engagement capabilities to [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages you administer, so you can interact with your company's audience and analyze the data from your pages directly in [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. 

### Listening and engagement on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages

[!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] now lets you search for all posts and comments on your own [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages, also known as [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Company Pages. You can add any [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages you administer as social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. After a page admin has added the page and shared it with other users, they can like posts and reply to posts and comments on behalf of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a LinkedIn Page rule](./add-rules-search-topic.md#linkedin-page-rule)

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.7

### Listening and engagement on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)]

Get in touch with your audience on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] directly from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. Users with at least a Responder interaction role can now rate and reply to videos and comments on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)]. You'll need to add a social profile for [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] under **Settings** > **Social Profiles**, or get a [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] profile shared with you before you can interact on this source.

Additionally, [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] extended the listening capabilities and is now capable of acquiring video posts and comments on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels. Any user with permission to create search rules can create [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] rules under any search topic and add [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels to gather posts and comments from. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a YouTube rule](../social-engagement/add-rules-search-topic.md#add-a-includetnyoutubeincludestn-youtubemd-rule)

Keyword-based searches on the video source continue to reside under the [keywords rule](../social-engagement/add-rules-search-topic.md#add-a-keywords-rule) and now also contain comments for actively discussed video posts. 

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.6

### Improved base model for sentiment analysis

To improve and refine the base sentiment model, we've modified the machine learning process and added training data. You don't have to do anything to benefit from these improvements. If you activated [adaptive learning](../social-engagement/adaptive-learning.md) for your organization, all the edits you've made to sentiment values will automatically be applied to the improved base model.

### Improved load-balancing for data acquisition

Performance and reliability are key to providing a stable data acquisition pipeline that can handle massive amounts of data all day, every day. Emerging trends or events often generate a significant number of posts on social media. To make the data acquisition service even more reliable and stable, we've improved the way the system handles these varying volumes of data.

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.5

### Service and product improvements

We've addressed service and product improvements with this release. For changes we've made to the user experience, please see [this detailed blog post](https://blogs.msdn.microsoft.com/crm/2017/06/09/whats-new-in-microsoft-social-engagement-2017-update-1-5/).

Additionally, we've continued our ongoing investment to make [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] more accessible. With the current release, Social Selling Assistant within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] supports keyboard navigation and screen readers on mobile and desktop devices.

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.4

### Engagement Analytics with [!INCLUDE[Power BI](../includes/pn-power-bi.md)]

We've added an Engagement Analytics report to our recently introduced [!INCLUDE[Power BI](../includes/pn-power-bi.md)] content pack for [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. Along with the previously released Engagement Performance and Team Performance reports, the Engagement Analytics report gives you additional insights about your engagement on social media by using metrics based on location, sentiment, tags, and authors. The data model is also enhanced to include these additional dimensions, giving you more power to explore and analyze your [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] data. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get the Microsoft Social Engagement content pack for Power BI](../social-engagement/get-content-pack-for-power-bi.md) 

### Improved usability in Social Selling Assistant

The Social Selling Assistant user experience got its first polishing pass, and now the **Done** button appears next to the other actions at the bottom of the card. 

We aligned the forms in Social Selling Assistant configuration and the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] Settings page **User Preferences** with industry standards. Now when those forms are edited, the **Save** and **Cancel** buttons appear at the bottom of the input form. Additionally, the main navigation contains a direct link to the Post view in Analytics, filtered for private messages, so you can get to your customers' messages in a single click. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with the Social Selling Assistant](../social-engagement/work-with-social-selling-assistant.md) 

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.3

### [!INCLUDE[Power BI](../includes/pn-microsoft-power-bi.md)] content pack for [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]

[!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] introduces the [!INCLUDE[Power BI](../includes/pn-microsoft-power-bi.md)] content pack to get insights about your engagement and team performance on social media. This content pack is designed specifically for community managers, providing performance metrics for engagement actions taken from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. Track metrics, such as the number of actions taken and average response times, and get visibility into the performance of each member of your team. [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] automatically creates the dashboard and generates reports that give you a great starting point for exploring and analyzing your [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] data. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get the Social Engagement content pack for Power BI](../social-engagement/get-content-pack-for-power-bi.md) 

### Conversation view for private messages and Twitter replies

Starting with this update, [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] shows you any conversation that involves private messages (on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] or [!INCLUDE[tn_twitter](../includes/tn-twitter.md)]) or [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] replies between a customer and one of your social profiles. The back and forth conversation between two authors shows the latest post at the top along with the two authors, including the one who belongs to your team and answered as your social profile. This view also shows all the team members who answered as that social profile.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See the conversations with an author](../social-engagement/posts-conversations.md#conversationView)

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.2

### Get insights with the Social Selling Assistant

The [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] Social Selling Assistant introduces Get Insights, a new recommendation type you can use to get recommendations for posts about your customers, competitors, and other topics of interest so you can stay on top of the latest developments.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Personalize the Social Selling Assistant](../social-engagement/personalize-social-selling-assistant.md), [Empower your salespeople with the Social Selling Assistant](../social-engagement/social-selling-assistant-overview.md)

### Engagement history contains user information

The engagement action history now shows the name and profile picture of the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] user who performed the action in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish and react to posts](../social-engagement/publish-react-posts.md)

## [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] 2017 Update 1.1

### Sell more with the Social Selling Assistant

[!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] introduces the Social Selling Assistant to empower your salespeople to sell more by leveraging social media. With this application, your salespeople get personalized and smart recommendations for posts to share on their social networks to increase their social presence, gain trust from their followers, and generate more leads.

You can access the Social Selling Assistant from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] and install it from Microsoft AppSource into your [!INCLUDE[Dynamics 365 for Sales](../includes/pn-ms-dyn-365-for-sales.md)] application. The AppSource app adds a new dashboard that contains the Social Selling Assistant. Salespeople can access this dashboard from the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web client, and from [!INCLUDE[pn_dyn_365_tablets](../includes/pn-dyn-365-tablets.md)]. [!INCLUDE[pn_dyn_365_phones](../includes/pn-dyn-365-phones.md)] is currently not supported.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Empower your salespeople with the Social Selling Assistant](../social-engagement/social-selling-assistant-overview.md)

### User interface is now available in Japanese and Chinese (traditional)

[!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] introduces the user interface in Japanese and Chinese (traditional) languages. Users can change the language of the user interface under **Settings** > **Personal Settings** > **Your Preferences**. The localization of the user interface also includes the respective calendars for Japanese and Chinese (traditional) languages.

### Share a post to [!include[LinkedIn](../includes/pn-linkedin.md)]

With this release, you can add your personal [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] account as a social profile and share any public post in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to your professional network on [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)]. Your [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] social profile will be available for the post action **Post Link**. When you share to [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)], you can choose between two visibility options: show the post to everyone on [!INCLUDE[pn_LinkedIn](../includes/pn-linkedin.md)] or to your network only. This post action is available across all [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] services, including the newly released Social Selling Assistant. To start sharing, go to **Settings** > **Social Profiles**, select **Add Profile**, select **[!include[LinkedIn](../includes/pn-linkedin.md)] Profile**, and then follow the steps.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage social profiles](../social-engagement/manage-social-profiles.md)

#### See also

[Get started with Social Engagement](../social-engagement/get-started.md)  
[E-books and videos](http://go.microsoft.com/fwlink/p/?LinkId=400708)
