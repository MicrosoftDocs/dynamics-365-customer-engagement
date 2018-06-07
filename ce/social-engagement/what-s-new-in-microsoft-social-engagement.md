---
title: "What's new in Microsoft Social Engagement | Microsoft Docs"
description: "Learn about the recent changes and new features in Social Engagement."
keywords: "news, product updates, product improvements, service updates"
ms.date: 06/13/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: e8941c81-866f-4363-8ca1-fc035f9a3844
author: m-hartmann
ms.author: mhart
manager: sakudes
ms.custom:
  - dyn365-socialengagement
---

<!--Note to author: Metadata guidance says applies_to: should list at least two, such as Dynamics 365 (online) and Dynamics 365 Version 9.x-->

# What&#39;s new in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

Welcome to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. Here's a list of features we added recently.

If you're new to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], see [Get started with Social Engagement](get-started.md).

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

For important, late-breaking information and a list of known issues, see the [Social Engagement Readme](http://go.microsoft.com/fwlink/p/?LinkID=393612).

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.6

### Change of permissions for newly invited users

When an administrator [assigns a Social Engagement license](assign-user-roles.md) to a user, this user will get Power Analyst and Responder permissions. This enables users to create search topics and engage in conversations with other authors. Administrators can [change the permissions](user-roles.md) at any time according to their business requirements. 

### Reduction of retention time for Social Content to 15 months

On June 16, 2018, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] will reduce the [retention time of Social Content](data-retention-social-engagement.md) to 15 months. This means that posts older than 15 months won’t be available in your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution anymore. If you need to keep track of older data for reporting purposes, you can [export the data](analyze-social-data-using-widgets.md#export-data-from-widgets) before it gets deleted automatically. 

### Disabling TLS 1.0 and TLS 1.1 in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]

The [Transport Layer Security (TLS) protocol](https://msdn.microsoft.com/en-us/library/windows/desktop/ms721627(v=vs.85).aspx#_security_transport_layer_security_protocol_gly) is most widely recognized as the protocol that provides secure HTTP (HTTPS) for connections between web browsers and web servers. The TLS 1.0 protocol version was defined in 1999. While no longer the default security protocol in use by modern operating systems, TLS 1.0 is still supported for backward compatibility. The same applies for TLS 1.1. 
[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] will remove the support of TLS 1.0 and TLS 1.1 in order to align with [!INCLUDE [cc-microsoft](../includes/cc-microsoft.md)] compliance requirements and security best practices.

#### What is the impact?

After [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] disables TLS 1.0 and TLS 1.1, any connections to the service that rely on those versions will fail.

#### How to avoid interruptions in the user experience

We recommend switching to a browser supporting TLS 1.2.
All major browser (Edge, Internet Explorer, Firefox, Chrome, Safari, Opera) releases after April 2016 support TLS 1.2.

| Browser |  | Version| Remarks |
|---------|---|--------|---------|
|Microsoft Edge| equals or higher |12.10240| Compatible by [default](https://developer.microsoft.com/en-us/microsoft-edge/platform/status/tls12/?q=TLS%201.2)|
|Internet Explorer | | 11 | Enabled by default, Desktop & Mobile |
|Firefox | equals or higher | 27 | [Release notes](http://website-archive.mozilla.org/www.mozilla.org/firefox_releasenotes/en-US/firefox/27.0/releasenotes/?flang=es-MX), all operating systems  |
|Chrome | equals or higher| 29 | [Details](https://bugs.chromium.org/p/chromium/issues/detail?id=90392#c28), all operating systems |
|Safari | equals or higher | 7 | |
|Opera  | equals or higher | 12 | [Release notes](https://blogs.opera.com/security/2016/02/opera-12-and-opera-mail-security-update/) |
|Android OS Browser |equals or higher |  Android 5.0 (Lollipop) | Compatible by default |
|Mobile Safari | equals or higher | 5 for iOS 5 or higher| Compatible by default |

#### Related information

[TLS 1.2 support at Microsoft](https://blogs.microsoft.com/microsoftsecure/2017/06/20/tls-1-2-support-at-microsoft/)

## [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] 2018 Update 1.5

### Attachments in private messages now show in the post list

Social Engagement now shows attached images and videos in private messages on Facebook and direct messages on Twitter directly in the post list. To see the attachments, open the post details of a direct message that contains attachments. 

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

As of February 6, 2018, [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] updated its API to pull data for [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] pages. After that date, author information for [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] posts is only available for pages that have been added as a social profile to your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution. The content of posts and comments, as well as enrichments such as sentiment, continue to be available for posts and comments without author information. We recommend you add page access tokens for every [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] page as a result of this change.   

[Read more about the experience for Facebook Pages in Social Engagement.](facebook-pages-data-acquisition.md)

### Service and product improvements

For a detailed list of improvements and bug fixes for the latest release, see our [blog](https://blogs.msdn.microsoft.com/crm/tag/social-engagement-kb-articles/).

#### See also

[Get started with Social Engagement](get-started.md)  
[E-books and videos](http://go.microsoft.com/fwlink/p/?LinkId=400708)
