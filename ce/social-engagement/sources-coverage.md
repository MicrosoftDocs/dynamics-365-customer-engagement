---
title: "Sources coverage in Microsoft Social Engagement | Microsoft Docs"
description: "Learn what's included in the sources available in Social Engagement."
keywords: sources, blogs, custom sources, Disqus, Facebook, Twitter, LinkedIn, Reddit, YouTube, forums, Instagram, news
ms.date: 01/23/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
  - Social Engagement
ms.assetid: 050283f4-bc5b-42e1-9885-ebdcfd786521
author: m-hartmann
ms.author: mhart
manager: sakudes
ms.custom: 
  - dyn365-socialengagement
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365SE
---

# Find out what&#39;s covered by sources

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] provides a number of sources so you can keep track of conversations on your social media. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] covers multiple sources where you can [track public posts](set-up-searches.md), and publish messages and replies. All sources can be [filtered](use-filters.md) in Analytics for an up-close look at your data. Find out what is covered by using the following available sources.

## Blogs

Create [keyword rules](add-rules-search-topic.md#addKeywordsRule) for full coverage for blog posts from Tumblr, broad coverage of blog posts from WordPress, and for blog posts from a third aggregated blog source, including a variety of blogs that range from blog aggregators like Blogger.com to small single-site blogs. If you want to update existing search topics to include the extended coverage of the blog's source, you can edit your existing keyword search rules.

## Custom sources

Get full coverage of public RSS or Atom feeds added in your custom source groups. Gather all posts from a previously created group of custom sources by creating a [custom source rule](add-rules-search-topic.md#customSourceRule). You can also create a keyword rule to filter by keywords.

## Disqus

Posts and comments published on Disqus are available for [keyword searches](add-rules-search-topic.md#addKeywordsRule).

## Facebook

Monitor posts and comments on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages without age restriction or geographical restriction that are added to your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page rules. You can also gather private messages, including attachments, for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages if you add a social profile and explicitly allow the acquisition of private messages.

> [!NOTE]
> [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] groups, [unpublished page posts](https://www.facebook.com/business/help/835452799843730) (formerly known as dark posts), ads, and status updates are not available for monitoring or engagement at this time. As of February 6, 2018, author information for Facebook posts is only available if you add a Facebook page profile for every page you own and keep their interaction tokens valid. 

To add a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page rule, see [Add a Facebook pages rule](add-rules-search-topic.md#addFacebookRule).

To add a private messages rule for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, see [Add a private messages rule](add-rules-search-topic.md#privateMessagesRule).

## Forums
[Keyword rules](add-rules-search-topic.md#addKeywordsRule) for forums are available to give you broad coverage of forum posts and comments.

## Instagram

After you add a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] & [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] acquisition account as a [social profile](manage-social-profiles.md) in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], you can configure [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] account search rules for your search topics. These rules will acquire posts and comments from [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] business accounts you own. Learn more about [data acquisition on Instagram](instagram-data-acquisition.md).

> [!NOTE]
> [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] is a listening source only. You will not be able to engage on [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. 

## [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)]

Create [LinkedIn page rules](add-rules-search-topic.md#linkedin-page-rule) to gather posts and comments on your own [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages, also known as [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Company Pages. After a page admin has added the social profile and shared it with other users, they can like posts and reply to posts and comments on behalf of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page from within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

## News

Create [keyword rules](add-rules-search-topic.md#addKeywordsRule) for news posts from news publishers. This source can find posts in English, French, German, Spanish, and Portuguese. News posts are available for search topic rules.

## Reddit

Posts and comments published on Reddit are available for [keyword searches](add-rules-search-topic.md#addKeywordsRule).

## Twitter

Gain full coverage of public tweets on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] by creating a search topic with a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile rule or a keyword rule. You can also gather direct messages, including attachments, if you add a social profile and explicitly allow the acquisition of private messages.

To add a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] rule, see [Add a Twitter rule](add-rules-search-topic.md#addTwitterRule).

To add a private messages rule, see [Add a private messages rule](add-rules-search-topic.md#privateMessagesRule).

## Videos

Video posts and comments published on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] that mention a configured search term and match the configured search languages are available for [keyword searches](add-rules-search-topic.md#addKeywordsRule).

Video posts and comments on specific [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels are available in [YouTube rules](add-rules-search-topic.md). Please keep in mind that videos often get a lot of comments, which can cause you to exceed your monthly post quota.

## Limitations for data acquisition

Some of the supported sources have restrictions on posts that we can acquire. These limitations are as follows.

**Facebook pages**
- Comments on Facebook posts aren't acquired if the parent post was published more than 7 days ago.
- Comments or replies to comments aren't acquired. Only comments to original posts get acquired.  
- We can't acquire posts and comments for events, groups, or other similar entities on Facebook.
- We can't search for keywords on Facebook.
- Dark posts and sponsored posts aren't supported and don't get acquired.

**Twitter**
- If an author quotes another tweet, this retweet will not be displayed as a quoted tweet in our user interface. However, the quoted tweets are acquired.

**YouTube**
- Comments on videos aren't acquired if the video was published more than 30 days ago.
- Comments on videos are acquired with some delay if the video was published more than a day ago.
- Searching very uncommon words or phrases might yield zero results because the search is based on a dictionary of words.

**LinkedIn** 
- Posts and comments on LinkedIn pages with low volume are acquired with a delay due to rate limits. The system prioritizes LinkedIn pages with a high volume for data acquisition.

**Custom sources**
- RSS feeds exist in various flavors, and there's no strict standard. The system might ignore posts that contain unknown fields or lack required fields such as the author of a post.

**Disqus**
- We receive some posts without a URL. These posts will be discarded by the system.

**General limitations**
- Chronological ordering of posts and comments in the post list isn't guaranteed.
- Language detection differs across sources. Posts in languages that we don't support aren't acquired.

## Privacy notice

[!include[cognitive services privacy token](../includes/cc-privacy-mse-ms-cognitive-services.md)]

### See also  
[Set up searches to listen to social media conversations](set-up-searches.md)   
[Refine your search rules to find relevant content](refine-search-rules.md)
