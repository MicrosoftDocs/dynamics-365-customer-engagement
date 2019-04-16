---
title: "Social Engagement Readme"
description: "Important and late-breaking information about Microsoft Social Engagement"
keywords: readme, known issues, information
ms.date: 04/16/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
  - Social Engagement
ms.assetid: e32849dd-2e8d-4cf0-8561-e3c865120d57
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

# [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Readme

This document provides important, late-breaking information about [!INCLUDE [pn-social-engagement-long](../includes/pn-social-engagement-long.md)].

## Resources

Visit the [Social Engagement Help Center](http://go.microsoft.com/fwlink/?LinkID=394325) on Microsoft Docs to find help content for admins and users.

Do you have an idea how to further improve the service or app? Go to the [Ideas forum for Social Engagement](https://experience.dynamics.com/ideas/list/?forum=0a0bebf4-8bef-e511-80ba-00155d03a726) and let us know. For questions and feedback in general, please go to the [Community forum](https://community.dynamics.com/crm/f/752).

## Integration scenarios - known issues

### Can’t open links when you use the Social Selling Assistant from the Dynamics 365 for tablets app

You can access the Social Selling Assistant app from both the Dynamics 365 for Customer Engagement web
client and the tablets app. However, the following restrictions apply:

-   Links contained in the social posts cannot be opened. As a workaround, use
    the **Copy to clipboard** action to copy the link to the post. Then paste
    the link into any Internet browser on your device to view the original post
    from which the links can be opened.

-   Copyright and Translation Guide links in the page footer cannot be opened.
    However, you can access these links from the Dynamics 365 for Customer Engagement web client or in
    [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

### Microsoft Dynamics 365 for Customer Engagement domains must be added to Allowed Domains to enable integration

For the integration between Customer Engagement apps and [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)],
your [Microsoft Dynamics 365 for Customer Engagement domains must be added as allowed domains in
Microsoft Social
Engagement](connect-other-domains.md).
This will ensure that only the Dynamics 365 for Customer Engagement domains you own can make requests to
your data.

If you are a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] administrator, you can do this by going to
**Settings** \> **Allowed Domains**. Add only your owned Dynamics 365 for Customer Engagement domains as
allowed domains to enable communication with [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

> [!NOTE]
> Prior to the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2016 Update 1.12, we allowed
all \*.dynamics.com domains to communicate with [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] by default.
This is no longer supported.

### When you authenticate, pop-up windows are blocked in the browser

Pop-up blockers and feedback latency can negatively affect your experience when
you try to add social profiles, add Twitter rules in **Search Setup**, and
authenticate to your Microsoft Dynamics 365 for Customer Engagement instance.

When [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] tries to open a pop-up window, in most cases it will be
suppressed by your browser’s pop-up blocker. Please look for any notifications
about blocked pop-up windows.

If you’re using Internet Explorer, check the options that are set on **Tabbed
Browsing Settings** (**Tools** \> **Internet options** \> **General** \>
**Tabs**). For **When a pop-up is encountered**, choose either **Let Internet
Explorer decide how pop-ups should open** or **Always open pop-ups in a new
window**. If the option is set to **Always open pop-ups in a new tab**, linking
to Dynamics 365 for Customer Engagement apps will not work.

Note that any of these pop-ups might take a while to appear. Also, when you add
a social profile, the **Social Profiles** page might take a few seconds to list
the new profile. If you continue to see no feedback, refresh the page and start
over.

### NAV integration and Microsoft Edge browser cause IFrame to stop loading

When you use the Microsoft Edge browser with Dynamics NAV, there's an unsolved
issue with the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] widget. When looking for a
non-existing ID, the widget will stop loading. As a workaround, we suggest that
you reload the page and make sure you have a valid Search topic ID. To do that,
look for the Search topic in the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Analytics page's
URL.

## Display of content - known issues

### Organization logo from LinkedIn not shown in Social Engagement

Starting April 15 2019, due to a change on the LinkedIn API, the organization logo from LinkedIn pages can't be displayed in Social Engagement.

### Blog content delivered in some cases in JSON format

For some blogs coming through WordPress, the format of the text is not delivered
in the usual format, but instead in JSON format, which diminishes the readability
of the content considerably.

### A YouTube author name might be replaced with a YouTube channel name

Due to a change in the YouTube API, in some cases, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]
cannot provide the YouTube author name. For those cases, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] tries
to find the name of the YouTube channel where the video was posted, and it uses
the YouTube channel name for the author name.

### YouTube videos in tweets are not always rendered in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

In the case where a video is shared directly from YouTube to Twitter, the video
is not rendered in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Instead the link to the video is
displayed in the respective tweet.

### A News post might not contain an original URL

In addition to online news, the [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] **News** source includes
publications that are not publicly available on the web. In that case, no link
to the original source is available for the post.

### Not all posts contain location data

Location data is supported on all **News** posts, and partially on **Twitter**
and **Forums**. The **Location** page displays only posts that contain location
information, which might cover a subset of your data.

### No author details for authors of Twitter retweets and Facebook shares

Even though there is an author detail icon next to the name of an author whose
post has been retweeted or shared, there is no author detail available for such
an author. The UI will show the message: “No author details are available”.

### Unknown Facebook authors

Due to a change in the Facebook API, author information is no longer shared from
pages you don't own. You can still get author information for posts on Facebook
pages you own by adding them as social profiles. [Learn more about unknown
Facebook
authors.](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/facebook-pages-data-acquisition)

### Unknown Instagram authors

Instagram authors are currently listed as "Unknown Author" in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. This is a temporary issue and will be fixed with one of the upcoming releases. 

## Search setup - known issues

### Creating a stream with % in keywords will fail

When you try to create a stream in Social Center based on a search rule with keywords including the **%** character, its creation will fail. Please avoid creating streams based on keywords rules including the % character. Alternatively, consider removing the % character from the keyword rule before creating the stream.

### Changing search topic category not reflected in the UI   

When the category on an existing search topic is changed, the search topic still shows the previously selected category. Although the changes are saved, you need to refresh the browser to see the change reflected correctly. 

### Retweets not acquired if keyword is after the 140th character

If a retweet is longer than 140 characters and the matching search term of a keyword rule appears after the 140th character, the retweet isn't acquired by the system.

### Deleted searches are counted in the quota total

If you [delete a search
topic](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/create-delete-search-topic),
the referred topic will not be displayed in your search topics page or on the
**Quota Manager** page. However, posts that are already acquired for this topic
are still counted toward your quota for the current month. The total number of
posts on the **Quota Manager** page might be higher than the sum of all search
topics.

### The Private Messages search rule requires Twitter account authentication in Search Setup

A social profile added for **Private Messages** acquisition shows up in **Search
Setup** under **Private Messages** only if a user has [authenticated a Twitter
account in the Twitter
rule](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/add-rules-search-topic#add-a-private-messages-rule)
in **Search Setup**.

### Facebook Acquisition Notification in Analytics does not always disappear

In some cases, the notification in Analytics that tells [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] users
that they do not have a valid token for Facebook Pages acquisition is wrongly
displayed.

If you see this message, we recommend you go to Social Profiles and check whether
your acquisition tokens are valid. If they are valid, you can ignore the
Analytics notification.

### Some Disqus posts are not acquired due to a missing URL in the post

In some cases, Disqus posts are missing a URL. This can happen if posts are
created through an API or through private channels. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] cannot
acquire messages that are missing a URL.

### Private messages and public messages from Facebook Pages and Twitter not always acquired

In some cases, private messages and public messages from Facebook Pages and
Twitter are not acquired in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. This can happen when a message
was written in a non-supported language of [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] or if the language
was not detected at all.

## Localization - known issues

### Localization of map labels is not available for Greek

The Bing Maps embedded in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] do not support localization of map
labels for Greek.

### Error messages for private messages aren't translated

On private message attachments, the error messages for an attachment that couldn't be retrieved or was deleted are not translated. These translations will be available with the next release. 

## General known issues

### Facebook video URL can expire

Due to changes from Facebook, some videos provided in Microsoft Social
Engagement are not playing anymore in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. This is due
to an expiration of the video URL. There is no workaround available to change
the expiration. You can view the video directly from the Facebook post.

### Analytics does not display social profiles added in the same session until you refresh your browser

If you add a social profile and then go straight to **Analytics**, the social
profile is not immediately displayed as a source to publish in publish actions.

To resolve this, manually refresh your browser after adding a social profile.

### Authorization of Twitter and Facebook profiles does not work on Windows phone

When you authorize a social profile on Twitter and Facebook, a pop-up window
requires you to provide the credentials for your social profile. Windows phone
does not support the opening of additional windows. We recommend that you set up
your social profiles by using a desktop environment.

### Sharing with all users for social profiles and streams has high-visibility consequences

Owners of social profiles and streams have the option to choose **Shared** and
share content and publish actions with all users. These are the implications of
taking this action:

-   For a social profile: Every user with the Interaction role "Manager" or
    "Responder" will be able to use the social profile in the publish actions
    within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

-   For a stream: Every user will see this stream on their Social Center page.
    Because there is no way to hide a stream, we recommend that you use this
    option with restraint.

### Notifications that trigger multiple actions might overlap

When you perform multiple actions within a short time frame, notification
messages might overlap. Although notifications disappear automatically, we
recommend that you close them manually so that you can see each notification and
take action as needed.

### Quota notification in Search Setup can be hidden and is hard to show again

When you go to the **Search Setup** area, you might see the quota warning
notification that your solution might be or is already above quota. You can hide
this notification by selecting the **Close** (X) button in the upper right
corner. Once it’s closed, you can only get it back by refreshing your browser’s
session with [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

### [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] stops responding after you select the Include button

In Microsoft Edge or Internet Explorer, if you select too many authors and then
select **Include**, the Authors widget in Full view mode might stop responding.
The workaround is to refresh your browser, select fewer authors, and select 
**Include** again.

### Facebook pages can’t be authenticated in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

Authenticating and reauthenticating Facebook pages as social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] might fail in some cases due to a Facebook authentication issue. Currently there is no workaround available for this issue. 

### Facebook page access tokens expire daily

Currently the Facebook page access tokens are expiring daily and you need to reauthenticate them. Due to issues with reauthentication of Facebook pages, in some cases a reauthentication will not be possible. 
