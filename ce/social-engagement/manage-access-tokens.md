---
title: "Manage access tokens in Social Engagement | Microsoft Docs"
description: "Learn how to manage tokens for social profiles in Social Engagement."
keywords: "tokens, oauth, validation"
ms.date: 02/20/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: d4d0e9fd-4d8c-4323-9f11-88f82913156b
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Manage access tokens

[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] requires you to provide access tokens in order to acquire data from some sources and interact with posts using social profiles. Access tokens enable data acquisition and can be easily supplied by [adding a social profile](manage-social-profiles.md) in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] where users sign in to social media accounts. We recommend that multiple users add tokens to guarantee a faster data acquisition and reduce the risk of data acquisition stopping due to expired access tokens.  
  
> [!NOTE]
> The data acquired through a user's token is not shared with any other [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solutions.  
  
[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] provides acquisition tokens (to acquire data on behalf of a user from a social media site) and interaction tokens (to post on behalf of a user to a social media site). The following table shows the tokens available tokens for social profiles.  
  
|||  
|-|-|  
|**Type of social profile**|**Type of token**|  
|[!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profile|**Acquisition token**: Acquire public data from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages<br /><br /> **Interaction token**: Publish and reply to posts on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages|  
|[!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page|**Interaction token**: Acquire private messages from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, publish and reply to posts, and acquire author information for posts and comments.|  
|[!INCLUDE[tn_instagram](../includes/tn-instagram.md)] account|**Acquisition token**: Acquire public data from [!INCLUDE[tn_instagram](../includes/tn-instagram.md)].|  
|[!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile|**Interaction token**: Acquire private messages from a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile, and publish and reply to posts.|  
|[!INCLUDE[tn_youtube](../includes/tn-youtube.md)] account|**Interaction token**: Comment and rate video posts and reply to comments on [!INCLUDE[tn_youtube](../includes/tn-youtube.md)].|  
  
## Tokens for data acquisition  

Adding tokens for data acquisition allows you to acquire posts from some sources. It’s important to understand that acquiring these posts is a two-step process. After you add tokens to allow the data acquisition, you also need to [create a search rule](add-rules-search-topic.md) in a search topic in order to start acquiring direct messages or posts from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)].  
  
### Add a Facebook acquisition token and allow data acquisition  

You need [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] acquisition profiles to acquire data from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages.  You need to authenticate access tokens by logging into your account and allowing data acquisition to acquire public posts from a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page.  
  
> [!NOTE]
> Provided tokens will expire after 60 days. [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] will notify you to reauthenticate your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profile through emails sent from socialengagement@microsoft.com and through notifications in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  

> [!IMPORTANT]
> While adding or reauthenticating a social profile for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] data acquisition, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] might encounter an error due to rate limits on our [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] connector app. Please wait about 15 minutes before trying to add or reauthenticate your profile.
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile, and then in the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page/profile details panel, select **Reauthenticate your token** ![Reauthenticate tokens button in Social Engagement](media/reatuthenticate-icon.png "Reauthenticate tokens button in Social Engagement") under **Allow data acquisition**, and enter your log-in credentials.  
  
3.  Under **Use for search acquisition**, select the drop-down arrow next to the search acquisition symbol ![Keywords symbol](media/keywords-search-rule-icon.png "Keywords symbol") and select the checkbox next to **Allow** to acquire data from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages. The token will become active after you select the check box.  
  
4.  Select **Save**.  
  
### Add an Instagram token and allow data acquisition  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile ([!INCLUDE[tn_instagram](../includes/tn-instagram.md)] account) and in the [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] account details panel, select **Reauthenticate your token** ![Reauthenticate tokens button in Social Engagement](media/reatuthenticate-icon.png "Reauthenticate tokens button in Social Engagement") and enter your log-in credentials.

    > [!NOTE]
    > If your organization owns multiple instances of [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], please add a unique [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] profile for every instance. We can't acquire data if an [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] profile is used in another [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] instance.
  
  
3.  Under **Use for search acquisition**, select the drop-down arrow next to the search acquisition symbol ![Keywords symbol](media/keywords-search-rule-icon.png "Keywords symbol") and select the check box next to **Allow** to acquire data from [!INCLUDE[tn_instagram](../includes/tn-instagram.md)]. The token will become active after you select the check box.  
  
4.  Select **Save**.  
  
## Tokens for interactions with posts 

Adding tokens for interactions with posts allows you to acquire private messages from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], as well as publish and reply to posts. Additionally, you'll need an active [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page interaction token to be able to pull author information for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages you own. An interaction token is needed for every [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page separately. If no interaction token is provided, post and comments from users on the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page will surface in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] without author information.    
You can check your token health states to make sure your tokens aren't expired. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Check the health state of your social profiles](social-profiles-health-state.md)  
  
> [!NOTE]
>  View your social profiles page to add a token. If you don't see the social profile in question, you can add a social profile and add tokens directly.  
  
### Add a Facebook user token to interact with posts  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile, and then in the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] user details panel, under **Allow Interactions**, select **Reauthenticate your token** ![Reauthenticate tokens button in Social Engagement](media/reatuthenticate-icon.png "Reauthenticate tokens button in Social Engagement") and enter your log-in credentials.  
  
3.  Select **Save**.  
  
### Add a Facebook page token and allow data acquisition for private messages  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile, and in the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page details panel, select **Reauthenticate your token** ![Reauthenticate tokens button in Social Engagement](media/reatuthenticate-icon.png "Reauthenticate tokens button in Social Engagement") and enter your  credentials.  
  
3.  Under **Acquisition of private messages**, select the drop-down arrow next to the private messages symbol ![Private messages symbol](media/private-message-icon.png "Private messages symbol") , and then select the check box next to **Allow** to acquire privates messages to and from your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] account. The token will become active after you select the check box.  
  
4.  Select **Save**.  
  
### Add a Twitter token and allow data acquisition for private messages  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile, and then in the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile details panel, select **Reauthenticate your token** ![Reauthenticate tokens button in Social Engagement](media/reatuthenticate-icon.png "Reauthenticate tokens button in Social Engagement") under **Allow interactions**, then enter your  credentials.    Under Acquisition of Private Messages, select the drop-down arrow next to the private messages symbol ![Private messages symbol](media/private-message-icon.png "Private messages symbol") and select the check box next to **Allow** to acquire private messages to and from your [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] account. The token will become active after you select the check box.  
  
3.  Select **Save**.  
  
## Reauthenticate a token 

Expired tokens must be reauthenticated to continue data acquisition and interactions with posts.  You can also check the health state of your tokens in your lists of social profiles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Check the health state of your social profiles](social-profiles-health-state.md)  
  
1.  Select the appropriate social profile and select **Reauthenticate your token** ![Claim ownership button in Social Engagement](media/claim-ownership-icon.png "Claim ownership button in Social Engagement").  
  
2.  Enter the appropriate credentials.  
  
## Delete tokens  

You can remove tokens from social profiles you own.
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Select the appropriate social profile, and in the social profile panel select the **Delete your token** button ![Delete button](media/delete-icon.png "Delete button") next to the token you want to delete.  
  
3.  Select **Save**.  

## Privacy notice

[!include[cognitive services privacy token](../includes/cc-privacy-mse-ms-cognitive-services.md)]

### See Also  
 [Engage on social networks](engage-on-social-networks.md)   
 [Set up searches to listen to social media conversations](set-up-searches.md)   
 [Manage social profiles](manage-social-profiles.md)