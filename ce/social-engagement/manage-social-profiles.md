---
title: "Manage social profiles | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-02-15"
ms.reviewer: ""
ms.service: "mse"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Social Engagement"
ms.assetid: b84d4554-04b9-49fb-9f63-3ea913ef64fb
caps.latest.revision: 67
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Manage social profiles
In [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)], social profiles are the profiles on social networks that you authenticate with [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. These profiles represent your organization or business on social media. You use them to interact with posts on your behalf from within the application.  
  
 By using these social profiles you can reply, comment, like a post, or share any appropriate messages on social media. Currently, you can authenticate [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles, [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profiles, and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] accounts for use from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
 Data acquisition and acquisition of private messages from your social profiles require access tokens, and you need to explicitly allow data acquisition before you can view or interact with any posts. No posts are posted on your profiles unless you decide to take action on a post within Social Engagement. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
> [!IMPORTANT]
>  -   All social profiles are user specific. You can interact only by using  profiles that you  own or  profiles that are shared with you. You must have an Interaction role of **Responder** or **Manager** to work with social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
> -   Make sure you have the correct credentials before you attempt to add a social profile or claim ownership for an existing profile.  
> -   You can own social profiles by adding them to the solution. You can share the owned profiles with other users, and stop sharing them or delete them when you don't need them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work), [Delete a social profile](../social-engagement/manage-social-profiles.md#deleteasocialprofile)  
> -   You can delete both the profiles you own and  the profiles with multiple owners. If a profile is shared with you, you can post on social media by using this profile, but you can’t remove it from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work)  
> -   A social profile can have multiple owners. Every owner has the same level of access privileges.  
  
## Types of social profiles you can manage  
 To add, edit, share, or remove a social profile, go to Settings > Social Profiles. From here you can also check the health state of your social profiles and access tokens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Check the health state of your social profiles](../social-engagement/social-profiles-health-state.md)  
  
- **Owned profiles**: Profiles that you added to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. These can be personal profiles or  profiles that you set up for your organization.  You can share these profiles with other [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] users, stop sharing these profiles at any time, remove your ownership for these profiles, and also delete them when you don't need them. Social profiles can have multiple owners. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work), [Delete a social profile](../social-engagement/manage-social-profiles.md#deleteasocialprofile)  
  
    > [!CAUTION]
    >  As an owner, you can delete a profile with multiple owners. Always be careful not to delete any profiles that are in use.  
  
- **Shared profiles**: Profiles that are owned by other [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] users, but shared with you. You can publish on social media by using these profiles, but you won't be able to delete or share these with any other users. If you need to, you can claim ownership of these profiles and then share them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Claim ownership for a social profile](../social-engagement/manage-social-profiles.md#claimownership)  
  
- **Profiles without owners**: Profiles that were added to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] but currently don't have owners. You can’t use these profiles for posting on social media. At least one [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] user needs to claim  ownership of these profiles for them to be available. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Claim ownership for a social profile](../social-engagement/manage-social-profiles.md#claimownership)  
  
- **Profiles for acquisition**: [!INCLUDE[tn_facebook](../includes/tn-facebook.md)][!INCLUDE[tn_twitter](../includes/tn-twitter.md)], and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] require at least one valid  access token to acquire data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
- **Profiles for private messages acquisition**: You can acquire private messages from your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages  and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] accounts if you have at least one valid access token. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
<a name="addsocialprofile"></a>   
## Add a social profile for Twitter or Facebook  
  
> [!TIP]
>  Common browsers block pop-ups by default. You should explicitly allow your browser to show pop-ups in the domain for your [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] application. This ensures that the authentication dialog box from [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] or [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] loads properly. If it doesn't, you won’t be able to add or re-authorize social profiles.  
  
 Adding social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] is an important step if you want to react to a post directly from within the application. You can engage with your audience through social profiles that you own or that are shared with you. By default, the process of adding a social profile doesn’t acquire any data. You must explicitly allow the data acquisition on the social profile to gather private messages or direct messages.[!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Tokens for interactions with posts](../social-engagement/manage-access-tokens.md#interaction_token)  
  
 You can add a social profile for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles, and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profiles. [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles are personal profiles for individual people. [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages  are represented and managed by people with [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles. People with [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles can manage multiple [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages.  
  
> [!NOTE]
>  When you plan to engage with a social profile in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], make sure that you have the appropriate permissions for that profile. For [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, you need to have admin permissions to create posts as the page, or to send messages as the page. Get in touch with the admin of the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to adjust these settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Facebook Help Center: Page Roles](http://go.microsoft.com/fwlink/p/?LinkID=723360)  
  
<a name="addfacebookpage"></a>   
#### Add a Facebook page to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click the **Add social profile** button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  In the list, click **Facebook page**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the user name and password for the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
    > [!NOTE]
    >  You must be an administrator for this [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to authenticate it.  
  
5.  After successful authentication, you can select from the list of [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages that the authenticated user administers. After you add the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page, you can find it on the **Social Profiles** page under **Owned profiles**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  
6.  Optionally, you can allow Power Analysts and Administrators to create rules for the direct messages from this social profile in a search topic.  
  
#### Add a Facebook profile to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click the **Add social profile** button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  In the list, click **Facebook user**, and then click **Add**.  
  
4.  In the authentication dialog box that appears, enter the user name and password for the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] user profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After successful authentication, you can find the profile on the **Social Profiles** page under **Owned profiles**.  
  
#### Add a Twitter profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click the **Add**  button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  In the list, click **Twitter Account**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the user name and password for the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After successful authentication,  you’ll find the profile on the **Social Profiles** page under **Owned profiles**.  
  
6.  Optionally, you can allow Power Analysts and Administrators to create rules for the direct messages from this social profile in a search topic. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  
## Add a social profile for Instagram  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click the **Add social profile**  button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  In the list, click  **Instagram Account,** and then click **Add.**  
  
4.  In the authentication dialog box, enter the user name and password for the [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] profile you want to enable in Social Engagement.  
  
5.  Upon successful authentication, you'll find the profile on the  **Social Profiles** page, under **Owned profiles**.  
  
<a name="add_LinkedIn_profile"></a>   
## Add a LinkedIn profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click the **Add**  button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  In the list, click **LinkedIn Account**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the user name and password for the  LinkedIn profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After successful authentication,  you’ll find the profile on the **Social Profiles** page under **Owned profiles**.  
  
<a name="Let_others_work"></a>   
## Let other users work with your social profile  
 To let other users of your organization’s solution post on behalf of a social profile that you own, you can share it with them. Once you share a social profile, other users can select the social profile when interacting with a post. You can also share a social profile with a group. For more information about groups, see [Work with Office 365 Groups in Social Engagement](../social-engagement/office-365-groups-social-engagement.md).  
  
> [!IMPORTANT]
>  Make sure you share the profiles with users who have a user role of Manager or Responder and are authorized to view or access the social profile feature. Sharing is only available if the social profile allows interactions with posts. Every user who this social profile is shared with can use this profile to publish actions through tokens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
<a name="shareasocialprofile"></a>   
#### Share a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles**, select the social profile that you want to share.  
  
3.  In the profile details, click **Add**.  
  
4.  Start typing the name of the user you want to share the profile with, and then select it from the list.  
  
     To share the profile with all users in your organization who have access to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], select the **Shared with all users** check box.  
  
    > [!IMPORTANT]
    >  By sharing a social profile, you let other users post on behalf of the social profile to social networks. Choose your sharing options wisely to avoid unwanted posts on social networks.  
    >   
    >  When you select **Shared with all users**, all users with a Responder or Manager interaction role will be able to use the social profile for publishing actions (such as replying, commenting, sharing, retweeting, and liking) within [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)].  
  
5.  Confirm your selection.  
  
<a name="stopshareing"></a>   
#### Stop sharing a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles**, select the social profile that you want to stop sharing.  
  
3.  In the profile details, clear the check box for each user you want to stop sharing with.  
  
4.  Confirm your selection.  
  
<a name="deleteasocialprofile"></a>   
## Delete a social profile  
  
> [!CAUTION]
>  You can delete a social profile that you own. You can also delete a social profile that has multiple owners. Always be careful not to delete any profiles that are in use by other [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] users.  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles/Profiles without owners**, find the social profile that you want to delete.  
  
3.  Click **Delete** ![Delete button](../social-engagement/media/trashbin-icon.png "Delete button") next to the social profile name, and then click Save.  
  
 If you allowed data acquisition for private messages, all acquired private messages are hidden for all users but persist in the database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  
<a name="claimownership"></a>   
## Claim ownership of a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Shared Profiles/Profiles without owners**, select the social profile that you want to claim ownership of.  
  
3.  In the profile details pane, click **Claim ownership** ![Claim ownership button in Social Engagement](../social-engagement/media/claim-ownership-icon.png "Claim ownership button in Social Engagement").  
  
4.  To claim ownership, enter the required credentials in the pop-up window.  
  
## See Also  
 [Engage on social networks](../social-engagement/engage-on-social-networks.md)   
 [Check the health state of your social profiles](../social-engagement/social-profiles-health-state.md)   
 [Manage access tokens](../social-engagement/manage-access-tokens.md)   
 [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md)