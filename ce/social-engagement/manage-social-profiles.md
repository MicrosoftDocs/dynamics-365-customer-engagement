---
title: "Manage social profiles | Microsoft Docs"
description: "Learn how to add, edit, share, or remove a social profile in Social Engagement."
ms.date: 08/22/2017
ms.service: mse
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: b84d4554-04b9-49fb-9f63-3ea913ef64fb
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---

# Manage social profiles
*Social profiles* are the profiles on social networks that you authenticate by using [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. These profiles represent your organization or business on social media. You use them to interact with posts on your behalf from within the application.  
  
[//]: # (Is there a reason not to mention LinkedIn and YouTube here?)
 By using these social profiles you can reply, comment, like a post, or share messages on social media. Currently, you can authenticate [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles, [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profiles, and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] accounts for use from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
 Data acquisition and acquisition of private messages from your social profiles require access tokens, and you need to explicitly allow data acquisition before you can view or interact with any posts. No posts are posted on your profiles unless you decide to take action on a post within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](../social-engagement/manage-access-tokens.md)  

 [//]: # (Suggest moving the last bullet so you explain that profiles can have multiple owners before you talk about deleting that type of profile.) 
> [!IMPORTANT]
>  -   All social profiles are user-specific. You can interact only by using owned profiles or profiles that are shared with you. You must have an interaction role of **Responder** or **Manager** to work with social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
>  -   Make sure you have the correct credentials before you attempt to add a social profile or claim ownership for an existing profile.  
>  -   You can own social profiles by adding them to the solution. You can share the profiles you own with other users, and stop sharing them or delete them when you don't need them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work), [Delete a social profile](../social-engagement/manage-social-profiles.md#deleteasocialprofile)  
>  -   A social profile can have multiple owners. Every owner has the same level of access privileges.  
>  -   You can delete both the profiles you own and any profile where you are one of its multiple owners. If a profile is shared with you, you can post on social media by using this profile, but you can’t remove it from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work)  
  
## Types of social profiles you can manage  
 To add, edit, share, or remove a social profile, go to **Settings** > **Social Profiles**. From here you can also check the health state of your social profiles and access tokens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Check the health state of your social profiles](../social-engagement/social-profiles-health-state.md)  
  
- **Owned profiles**: Profiles that you added to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. These can be personal profiles or profiles that you set up for your organization. You can share these profiles with other [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] users, stop sharing these profiles at any time, remove your ownership from these profiles, and delete them when you don't need them. Social profiles can have multiple owners. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Let other users work with your social profile](../social-engagement/manage-social-profiles.md#Let_others_work), [Delete a social profile](../social-engagement/manage-social-profiles.md#deleteasocialprofile)  
  
    > [!CAUTION]
    >  If you are an owner of a profile that has multiple owners, you can delete the profile. Always be careful not to delete any profiles that are in use.  
  
- **Shared profiles**: Profiles that are owned by other [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] users, but shared with you. You can publish on social media by using these profiles, but you won't be able to delete or share them with any other users. If you need to, you can claim ownership of these profiles and then share them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Claim ownership for a social profile](../social-engagement/manage-social-profiles.md#claimownership)  
  
- **Profiles without owners**: Profiles that were added to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] but currently don't have owners. You can’t use these profiles for posting on social media. At least one [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] user needs to claim ownership of these profiles for them to be available. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Claim ownership for a social profile](../social-engagement/manage-social-profiles.md#claimownership)  
  
- **Profiles for acquisition**: [!INCLUDE[tn_facebook](../includes/tn-facebook.md)], [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] require at least one valid access token to acquire data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
- **Profiles for private messages acquisition**: You can acquire private messages from your [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] accounts if you have at least one valid access token. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
<a name="addsocialprofile"></a>   
## Add a social profile for Twitter or Facebook  

[//]: # (Some of the content in this introduction seems to apply to all social profiles, not just Facebook and Twitter. Perhaps it was written before the other types of profiles were added? It also seems a bit repetitive, except for the Tip. Also, the combination of H2s and H3s is awkward, and the headings aren't parallel. Suggest renaming this H2 to something more general like "Adding social profiles." Move the Tip after the second paragraph. Delete the third paragraph. Move the Note to the beginning of the section under the H3 "Add a Facebook page to your social profiles." Make all the subsequent procedures H3s.)  
> [!TIP]
>  Common browsers block pop-ups by default. You should explicitly allow your browser to show pop-ups in the domain for your [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] application. This ensures that the authentication dialog box from [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] or [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] loads properly. If it doesn't, you won’t be able to add or re-authorize social profiles.  
  
 Adding social profiles in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] is an important step if you want to react to a post directly from within the application. You can engage with your audience through social profiles that you own or that are shared with you. By default, the process of adding a social profile doesn’t acquire any data. You must explicitly allow the data acquisition on the social profile to gather private messages or direct messages. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tokens for interactions with posts](../social-engagement/manage-access-tokens.md#interaction_token)  
  
 You can add a social profile for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles, and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profiles. [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles are personal profiles for individual people. [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages are represented and managed by people with [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles. People with [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles can manage multiple [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages.  
  
> [!NOTE]
>  When you plan to engage with a social profile in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], make sure that you have the appropriate permissions for that profile. For [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, you need to have admin permissions to create posts as the page, or to send messages as the page. Get in touch with the admin of the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to adjust these settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Facebook Help Center: Page Roles](http://go.microsoft.com/fwlink/p/?LinkID=723360)  
  
[//]: # (Step 5 in this procedure is slightly different from the steps under "Add a LinkedIn Organization Page to your social profiles" and I wonder if they should be more alike. By "you can select from the list of Facebook pages...", are you setting up one more step? When you say "after you add the Facebook page...," do you mean that the user needs to select **Save** like they do in the LinkedIn Org Page procedure?)
[//]: # (Also in step 5, I'm a bit mystified by the "More information" link to the topic about data retention; I think it's misplaced. I changed step 6 to flat prose because it isn't a step or an optional step in the process of adding a Facebook page profile. However, it seems like a good place to put a cross-reference. Suggest "Add rules to a search topic." I suspect the cross-ref to the data retention topic was meant to go here because there's a similar construction in the "Add a Twitter account..." topic. Which please see.)
<a name="addfacebookpage"></a>   
### Add a Facebook page to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add social profile** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click **Facebook page**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the username and password for the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
    > [!NOTE]
    >  You must be an administrator for this [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to authenticate it.  
  
5.  After the profile is successfully authenticated, you can select from the list of [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages that the authenticated user administers. After you add the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page, you can find it on the **Social Profiles** page under **Owned profiles**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  
You can allow Power Analysts and Administrators to create rules for direct messages from this social profile in a search topic. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add rules to a search topic](../social-engagement/add-rules-search-topics.md) 
  
### Add a Facebook user to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add social profile** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click **Facebook user**, and then click **Add**.  
  
4.  In the authentication dialog box that appears, enter the username and password for the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] user profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After the profile is successfully authenticated, you'll find it on the **Social Profiles** page under **Owned profiles**.  
  
[//]: # (For the following H3s, I used "account" rather than "user" because that seems to be what the UI says. Although, see related query about @username in "Add rules to a search topic." Also I wanted these headings all to be parallel, since they're all similar in intent.)
[//]: # (In most of the procedures below, the button in step 2 is called simply "Add", but above it's called "Add social profile." Shouldn't they be the same?)
[//]: # (Same comment about step 6 applies. I don't see that the data retention topic is the most relevant one in this context, but I could certainly be wrong.)
### Add a Twitter account to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click **Twitter Account**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the username and password for the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After the profile is successfully authenticated, you’ll find it on the **Social Profiles** page under **Owned profiles**.  
  
You can allow Power Analysts and Administrators to create rules for the direct messages from this social profile in a search topic. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  
## Add an Instagram account to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add social profile** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click  **Instagram Account,** and then click **Add.**  
  
4.  In the authentication dialog box, enter the username and password for the [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] profile you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After the profile is successfully authenticated, you'll find it on the **Social Profiles** page under **Owned profiles**.  
  
<a name="add_LinkedIn_profile"></a>   
## Add a LinkedIn account to your social profiles  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click **LinkedIn Account**, and then click **Add**.  
  
4.  In the authentication dialog box, enter the username and password for the LinkedIn profile that you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  After the profile is successfully authenticated, you’ll find it on the **Social Profiles** page under **Owned profiles**.  

<a name="linkedin-page-profile"></a> 
## Add a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page to your social profiles

Before you can acquire [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] data and reply or like on behalf of a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page from within [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], you need to add the organization page to your social profiles. To authenticate the organization page as a social profile, you need to be an [Organization Page Administrator](https://www.linkedin.com/help/linkedin/answer/4783) of the page on [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)].

1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, click **LinkedIn Page**, and then click **Add**.  
  
4.  In the authentication dialog box, authorize [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
    This will list all organization pages you administer.
  
5.  Select the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Page from the list.

6.  Select **Save** to create the social profile.

You can now reply and like on behalf of the organization page, but you can’t write new posts.  
Optionally, you can [share this social profile](#shareasocialprofile) with other users in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].


## Add a [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] account to your social profiles

1.  Go to **Settings** > **Social Profiles**.  
  
2.  Click **Add social profile** (![Add button](../social-engagement/media/add-icon.png "Add button")).  
  
3.  In the list, select **[!INCLUDE[tn_youtube](../includes/tn-youtube.md)] Account,** and then click **Add.**
  
4.  In the authentication dialog box, enter the username and password for the [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] profile you want to enable in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
5.  Upon successful authentication, you'll find the profile on the  **Social Profiles** page, under **Owned profiles**.  
  
<a name="Let_others_work"></a>   
## Let other users work with your social profile  
 To let other users of your organization’s solution post on behalf of a social profile that you own, you can share it with them. After you share a social profile, other users can select the social profile when interacting with a post. You can also share a social profile with a group. More information about groups: [Work with Office 365 Groups in Social Engagement](../social-engagement/office-365-groups-social-engagement.md)  
  
> [!IMPORTANT]
>  Make sure you share the profiles with users who have a user role of Manager or Responder and are authorized to view or access the social profile feature. Sharing is only available if the social profile allows interactions with posts. Every user who this social profile is shared with can use this profile to publish actions through tokens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access tokens](../social-engagement/manage-access-tokens.md)  
  
[//]: # (In the "Claim ownership..." topic, you called it the "profile details pane," so I used that term in the other procedures too. I assume this isn't the literal name of the pane, right? If it is, it of course should be **Profile Details** pane.)
<a name="shareasocialprofile"></a>   
### Share a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles**, select the social profile that you want to share.  
  
3.  In the profile details pane, click **Add**.  
  
4.  Start typing the name of the user you want to share the profile with, and then select it from the list.  
  
     To share the profile with all users in your organization who have access to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], select the **Shared with all users** check box.  
  
    > [!IMPORTANT]
    >  By sharing a social profile, you let other users post on behalf of the social profile to social networks. Choose your sharing options wisely to avoid unwanted posts on social networks.  
    >   
    >  When you select **Shared with all users**, all users with a **Responder** or **Manager** interaction role will be able to use the social profile for publishing actions (such as replying, commenting, sharing, retweeting, and liking) within [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)].  
  
5.  Confirm your selection.  
  
<a name="stopshareing"></a>   
### Stop sharing a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles**, select the social profile that you want to stop sharing.  
  
3.  In the profile details pane, clear the check box for each user you want to stop sharing with.  
  
4.  Confirm your selection.  
  
[//]: # (In step 2, if you're really talking about one list or another, can you please list them that way? That is, "In the **Owned profiles** or **Profiles without owners** list, find the..." Same idea in the next procedure. Style guide doesn't like us to use the slash instead of "or".)
[//]: # (I suggest moving the Caution after step 3. Cautions, Tips, and Notes aren't classically the first thing you find in a section.)
[//]: # (This is a perfect place for the cross-reference to the data retention topic! I've got no objections.)
<a name="deleteasocialprofile"></a>   
## Delete a social profile  
  
> [!CAUTION]
>  You can delete a social profile that you own. You can also delete a social profile that has multiple owners. Always be careful not to delete any profiles that are in use by other [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] users.  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Owned Profiles/Profiles without owners**, find the social profile that you want to delete.  
  
3.  Click **Delete** (![Delete button](../social-engagement/media/trashbin-icon.png "Delete button")) next to the social profile name, and then click **Save**.  
  
 If you allowed data acquisition for private messages, all acquired private messages are hidden for all users but persist in the database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Data retention in Social Engagement](../social-engagement/data-retention-social-engagement.md)  
  

<a name="claimownership"></a>   
## Claim ownership of a social profile  
  
1.  Go to **Settings** > **Social Profiles**.  
  
2.  In the list of **Shared Profiles/Profiles without owners**, select the social profile that you want to claim ownership of.  
  
3.  In the profile details pane, click **Claim ownership** (![Claim ownership button in Social Engagement](../social-engagement/media/claim-ownership-icon.png "Claim ownership button in Social Engagement")).  
  
4.  To claim ownership, enter the required credentials in the dialog box.  

## Privacy notice

[!include[cognitive services privacy token](../includes/cc-privacy-mse-ms-cognitive-services.md)]

### See also  
 [Engage on social networks](../social-engagement/engage-on-social-networks.md)   
 [Check the health state of your social profiles](../social-engagement/social-profiles-health-state.md)   
 [Manage access tokens](../social-engagement/manage-access-tokens.md)   
 [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md)
