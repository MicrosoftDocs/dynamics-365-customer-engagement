---
title: "Manage social profiles in Social Engagement | Microsoft Docs"
description: "Learn how to add, edit, share, or remove a social profile in Social Engagement."
keywords: "social profile, tokens, shared profile"
ms.date: 02/27/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: b84d4554-04b9-49fb-9f63-3ea913ef64fb
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Manage social profiles

*Social profiles* are the profiles on social networks that you authenticate by using [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)]. These profiles represent your organization or business on social media. You use them to interact with posts on your behalf from within the application.  
  
To [publish or react to posts](publish-react-posts.md), you need active social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. To add, edit, share, or remove a social profile, go to **Settings** > **Social Profiles**. 
  
Data acquisition and acquisition of private messages from your social profiles require [access tokens](manage-access-tokens.md), and you need to explicitly allow data acquisition before you can view or interact with any posts. No posts are published on your profiles unless you decide to take action on a post within [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

> [!IMPORTANT]
>  -   All social profiles are user-specific. You can interact only by using owned profiles or profiles that are shared with you. You must have an [interaction role](user-roles.md) of **Responder** or **Manager** to work with social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
>  -   A social profile can have multiple owners. Every owner has the same level of access privileges to the social profile. 
>  -   Make sure you have the correct credentials before you attempt to add a social profile or [claim ownership](#claim-ownership-of-a-social-profile) for an existing profile.  

## Types of social profiles you can manage

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] lets you [publish or react to posts](publish-react-posts.md) with social profiles for a subset of the [sources](sources-coverage.md) that are available when [setting up searches](set-up-searches.md).

Currently, you can add the following social profiles: 

- **[!INCLUDE[tn-twitter](../includes/tn-twitter.md)] user**: Publish new posts and interact with posts on [!INCLUDE[tn-twitter](../includes/tn-twitter.md)]. Optionally, you can allow data acquisition for direct messages sent to this profile to allow other users create search rules that acquire gather these direct messages. 

- **[!INCLUDE[tn-facebook](../includes/tn-facebook.md)] user**: Interact with posts on [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] with a [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] user profile.

- **[!INCLUDE[tn-facebook](../includes/tn-facebook.md)] Page**: Interact with posts on [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] with a [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] Page profile. To add this type of profile, you need to have admin permissions to create posts as the Page, or to send messages as the page. Get in touch with the admin of the [!INCLUDE[tn-facebook](../includes/tn-facebook.md)] Page to adjust these settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Facebook Help Center: Page Roles](http://go.microsoft.com/fwlink/p/?LinkID=723360)

- **[!INCLUDE[tn-instagram](../includes/tn-instagram.md)] account**: Interact with posts on [!INCLUDE[tn-instagram](../includes/tn-instagram.md)]. At least one active social profile for [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] is required to gather data from [!INCLUDE[tn-instagram](../includes/tn-instagram.md)] feeds.

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] user**: Share posts on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] with a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile. 

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page**: Reply to and like posts on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages with a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] organization page profile. To add this type of profile, you need to be an [Organization Page Administrator](https://www.linkedin.com/help/linkedin/answer/4783) on the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] page. At least one active social profile for [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages is required to gather data from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages.

- **[!INCLUDE[tn-youtube](../includes/tn-youtube.md)] user**: Interact with posts on [!INCLUDE[tn-youtube](../includes/tn-youtube.md)] with a [!INCLUDE[tn-youtube](../includes/tn-youtube.md)] user profile.

With a **Responder** or **Manager** user role, you can add, share, and delete social profiles you own.    
To learn more about social profiles for data acquisition, see [Manage access tokens](manage-access-tokens.md).

## Ownership status of social profiles

**Settings** > **Social Profiles** lists the different types of ownership for a social profile and lets you check the [health state of your social profiles](social-profiles-health-state.md) and [access tokens](manage-access-tokens.md).
  
- **Owned profiles**: Profiles that you added to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. These can be personal profiles or profiles that you set up and manage for your organization. Social profiles can have multiple owners.
  
  > [!CAUTION]
  >  If you are an owner of a profile that has multiple owners, you can delete the profile. Always be careful not to delete any profiles that are in use.  
  
- **Shared profiles**: Profiles that are owned by other [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] users, but shared with you. You can post on social media by using these profiles, but you won't be able to manage them unless you successfully [claim ownership](#claim-ownership-of-a-social-profile) of them.
  
- **Profiles without owners**: Profiles that were added to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] but currently don't have owners. You can’t use these profiles for posting on social media. At least one [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] user needs to [claim ownership](#claim-ownership-of-a-social-profile) of these profiles for them to be available.  

## Add a social profile

Adding social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] is an important step if you want to react to a post directly from within the application. You can engage with your audience through social profiles that you own or that are shared with you. Additionally, for some social profiles, you can explicitly allow data acquisition, so the system can gather private messages or direct messages.

> [!TIP]
>  Common browsers block pop-ups by default. You should explicitly allow your browser to show pop-ups in the domain for your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] application. This ensures that the authentication dialog boxes load properly. If it doesn't, you won’t be able to add or reauthorize social profiles.  

### Add a social profile to Social Engagement

Before you can work with a social profile, or use its token for data acquisition, the owner of a social profile needs to add it to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

1. Go to **Settings** > **Social Profiles**.  
  
2. Select **Add profile** (![Add button](media/add-icon.png "Add button")).  
  
3. In the list, select the type of social profile you want to add.  
  
4. In the authentication dialog box, sign in with your credentials and authorize [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].    

   When you add a social profile for a page you administer, a list will show with all the pages that you can add. Find the pages you want to add, select the **Add** symbol (![Add button](media/add-icon.png "Add button")) and select **Save** to confirm your selection. 
  
You can now reply and like on behalf of the organization page, but you can’t write new posts.  
Optionally, you can share this social profile with other users in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

## Share a social profile with other users

To let other users of your organization post on behalf of a social profile that you own, you can share it with them. After you share a social profile, other users can select the social profile when interacting with a post. You can also share a social profile with an [Office 365 group](office-365-groups-social-engagement.md). By sharing a social profile, you let other users post on behalf of the social profile to social networks. Choose your sharing options wisely to avoid unwanted posts on social networks.  
  
### Share a social profile  
  
1. Go to **Settings** > **Social Profiles**.  
  
2. In the list of **Owned Profiles**, select the social profile that you want to share. The profile details pane opens.  
  
3. In the profile details pane, under **Sharing / Owners**, select **Add**.  
  
4. Start typing the name of the user or group you want to share the profile with, and then select it from the list.  
  
   > [!CAUTION]
   > When you select **Shared with all users**, all users with a **Responder** or **Manager** interaction role will be able to use the social profile for publishing actions (such as replying, commenting, sharing, retweeting, and liking) within [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)].  
  
5. Click the **Add** button to confirm your selection.  

6. Select the Save symbol at the bottom of the profile details pane to apply your changes.
  
### Stop sharing a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles**, select the social profile that you want to stop sharing.  
  
3.  In the profile details pane, under **Sharing / Owners**, select the Remove symbol for each user or group you want to stop sharing with.  
  
4.  Select the Save symbol at the bottom of the profile details pane to apply your changes.  
  
## Delete a social profile  
  
You can delete a social profile that you own. You can also delete a social profile that has multiple owners. Always be careful not to delete any profiles that are in use by other [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] users. If a profile is shared with you, you can post on social media by using this profile, but you can’t remove it.
  
1. Go to **Settings** > **Social Profiles**.  
  
2. In the list of **Owned Profiles**, select the social profile that you want to delete.  
  
3. In the profile details pane, select the **Delete** (![Delete button](media/trashbin-icon.png "Delete button")) symbol.

4. Click **Confirm** to delete the profile.

> [!NOTE]  
> If you allowed data acquisition for private messages, all acquired private messages are hidden for all users but persist in the database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Data retention in Social Engagement](data-retention-social-engagement.md)  
  
## Claim ownership of a social profile  

If you know the credentials to a social profile, you can claim ownership for it. It's handy, for example, when the original owner of a shared profile is removed from the organization and someone else will take ownership for it. Once you successfully claimed ownership, you can start managing the social profile. 
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the **Shared Profiles** or **Profiles without owners** list, select the social profile that you want to claim ownership of.  
  
3.  In the profile details pane, select the **Reauthenticate your token** (![Claim ownership button in Social Engagement](media/claim-ownership-icon.png "Claim ownership button in Social Engagement")) symbol.  
  
4.  To claim ownership, enter the required credentials in the dialog box.  

> [!NOTE]
> While adding or reauthenticating a social profile for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] data acquisition, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] might encounter an error due to rate limits on our [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] connector app. Please wait about 15 minutes before trying to add or reauthenticate your profile.

## Acquisition token status of social profiles

- **Profiles for acquisition**: [!INCLUDE[tn_facebook](../includes/tn-facebook.md)], [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] require at least one valid access token to acquire data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](manage-access-tokens.md)  
  
- **Profiles for private messages acquisition**: You can acquire private messages from your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] accounts if you have at least one valid access token. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](manage-access-tokens.md)  
  
## Privacy notice

[!include[cognitive services privacy token](../includes/cc-privacy-mse-ms-cognitive-services.md)]

### See also 
 
 [Engage on social networks](engage-on-social-networks.md)   
 [Check the health state of your social profiles](social-profiles-health-state.md)   
 [Manage access tokens](manage-access-tokens.md)   
 [Set up searches to listen to social media conversations](set-up-searches.md)