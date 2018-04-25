---
title: "What's new in Microsoft Social Engagement | Microsoft Docs"
description: "Learn about the recent changes and new features in Social Engagement."
keywords: "news, product updates, product improvements, service updates"
ms.date: 04/25/2018
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

# What&#39;s new in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

Welcome to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Here's a list of features we added recently.

If you're new to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], see [Get started with Social Engagement](get-started.md).

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

For important, late-breaking information and a list of known issues, see the [Social Engagement Readme](http://go.microsoft.com/fwlink/p/?LinkID=393612).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.5

### Attachments in private messages now show in the post list

Social Engagement now shows attached images and videos in private messages on Facebook and direct messages on Twitter directly in the post list. To see the attachments, open the posts details of a direct message that contains attachments. 

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.4

### Refreshed visuals for Social Insights in Dynamics 365 Customer Engagement

The integration of Social Insights in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-shortest.md)] forms and dashboards now comes with new and updated visuals. The existing charts and visuals now reflect the latest user interface of [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] and inherit several settings from [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Due to this change, we have deprecated some widgets such as Analytics Summary. You can reconfigure to remove or replace such widgets. 
The steps to [set up and configure Social Insights in Dynamics 365](integrate-social-engagement-dynamics-365.md) are now available in the help center. 

### See which Facebook page a post is coming from and reply consistently

The post list in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] now shows on which [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] page each post and comment was posted. Engaging on your [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] page is now easier because the social profile matching this page will already be selected when you write a reply. 

### Instagram account rules are no longer possible

Due to changes on the [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] API, we are experiencing a downgrade on data acquisition for [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. We are currently receiving lower volumes of [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] posts for hashtag search rules, and no comments to [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] posts at all. Additionally, we are not receiving posts or comments for [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] account search rules. At this time, the search rules only return partial author information.

Existing search rules for [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] accounts don't return results anymore. Keyword search rules with [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] hashtags continue to work as expected.

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.3

### Exclude option for author tags filter

The [author tags filter](understand-filters.md#author-tags) now lets you exclude specific author tags from your data set. 

### Usability improvements extended tweet length

Twitter extended its support for longer messages in November 2017. For most languages, the limits were the same. This update adds support for Korean, Thai, and Simplified Chinese. 

### Introducing compliance stream for Twitter, Tumblr, and WordPress

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] now supports retroactive deletion of posts that were acquired and then deleted in the source. Posts from Twitter, Tumblr, and WordPress are now removed from [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] when the author removes them from the source.

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.2

### Let us know what you think about [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

With this update, we introduced a feedback dialog that is presented to a sample of users when they sign in to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. We encourage everyone to provide feedback that will help us shape the service and align our priorities for future updates.

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.1

### Improved accessibility across all interfaces

With this update, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] is more accessible for all users. These changes include support for keyboard navigation, screen reader support, and overall improvements to the user experience.

New capabilities for all users:

- You can choose to represent the data from widgets in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] in a chart or a data table.
- You can choose to render the charts with a fill pattern or solid colors. When selecting the fill patterns, data on maps will be represented in different shapes and will not rely exclusively on color.
- You can navigate the maps in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] with a keyboard by selecting a tab to reach the first data point on a map.
- In activity maps, you can choose between a visual map and a data table. The map allows navigation by keyboard in cardinal directions.
- You will experience improved navigation for post lists and post details

To learn more, see our dedicated [documentation on accessibility for Microsoft Social Engagement](accessibility.md).

### Administrators now enabled to remove alert recipients

With an administrator configuration role in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], you can now remove recipients from alerts that were configured by other users. You can search for a specific email address and then [remove the recipient from all alerts](email-alerts.md) that send email to that address. Additionally, you can export a list of alerts this recipient receives.

### Changes for author information from [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] pages

Starting February 6, 2018, [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] updates its API to pull data for [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] pages. After that date, author information for [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] posts will only be available for pages that have been added as a social profile to your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution. The content of posts and comments, as well as enrichments such as sentiment, will continue to be available for posts and comments without author information. We recommend you add page access tokens for every [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] page before this change on February 6.    
[Read more about the experience for Facebook Pages in Social Engagement.](facebook-pages-data-acquisition.md)

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

#### See also

[Get started with Social Engagement](get-started.md)  
[E-books and videos](http://go.microsoft.com/fwlink/p/?LinkId=400708)
