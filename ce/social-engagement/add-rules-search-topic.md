---
title: "Add rules to a Social Engagement search topic | Microsoft Docs"
description: "Learn how to add more rules to a search topic to gather additional data."
keywords: "search topic, search rule, Social Engagement"
ms.date: 02/15/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 9d65050a-4d34-4d87-8361-1954114da289
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Add rules to a search topic
Search topics define the data that's available for your analysis. You can add an unlimited number of search rules to a search topic. Each rule selects posts that will be available for the analysis of the data set. You can update your search topics at any time, and add more rules or change existing ones.

[!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] supports the following search rules. 
You need to be a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Administrator or Power Analyst to create or modify search topics.

- **[Keywords rule](#add-a-keywords-rule)** ![Keywords symbol](media/keywords-search-rule-icon.png "Keywords symbol"): Gather posts based on a query that consists of keywords, inclusions, and exclusions.

- **[Facebook pages rule](#add-a-facebook-pages-rule)** ![Facebook symbol](media/facebook-source-icon.png "Facebook symbol"): Gather all public posts and comments from a specific [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page.

- **[Twitter rule](#add-a-twitter-rule)** ![Twitter symbol](media/twitter-icon.png "Twitter symbol"): Capture mentions, replies, tweets, or retweets from a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] account.

- **[Instagram rule](#add-an-instagram-rule)** ![Instagram symbol](media/instagram-icon.png "Instagram symbol"): Gather posts and comments from [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] accounts.

- **[Private messages rule](#add-a-private-messages-rule)** ![Private messages symbol](media/private-message-icon.png "Private messages symbol"): Get private messages that were sent to a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile or [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page that has been authenticated in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] and [allows private message acquisition](manage-access-tokens.md#tokens-for-data-acquisition).

- **[Custom sources rule](#add-a-custom-sources-rule)** ![Custom sources symbol](media/custom-sources-icon.png "Custom sources symbol"): Gather posts from public RSS feeds in your custom source groups.

- **[YouTube rule](#add-a-includetnyoutubeincludestn-youtubemd-rule)** ![YouTube symbol](media/video-icon.png "YouTube symbol"): Gather video posts and comments from [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels.

- **[LinkedIn page rule](#linkedin-page-rule)**: Gather posts from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages.
  
> [!TIP]
>  This topic is part of a walkthrough about how to set up searches. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up searches to listen to social media conversations](set-up-searches.md)  
  
> [!VIDEO https://www.youtube.com/embed/3HoeVROsJZk]
  
## Add a rule to a search topic  
To enable searches and collect posts, add one or more rules to a search topic.  

> [!IMPORTANT]
>  Your keywords, inclusions, and exclusions can each extend up to 128 characters. You can add up to 15 keywords and inclusions per search rule and up to 25 exclusions per search rule.  
>   
>  Adding a rule usually leads to more posts resulting from your searches. The increased number of posts will count against your post quota. You'll need to validate every search topic that you changed before you can save it. It's a good idea to frequently review the results of a new or updated search topic to confirm that it collects relevant data and complies with your quota limits. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage your post quota](manage-post-quota.md)  
  
### Add a new rule  
  
1.  Go to **Search Setup**.  
  
2.  In the list of search topics, select the search topic to add a rule to.  
  
3.  Click **Add rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** pane.  
  
4.  Select the rule type that you want to add.  
  
5.  Define the values as required for the new rule.  
  
6.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
    > [!IMPORTANT]
    >  The solution checks the quota availability for the new rule and prompts you accordingly. If your quota can't accommodate the new rule, you can't save it.  
  
7.  In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your search topic, or click **Add** to add another rule to your topic.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Download the e-book](http://go.microsoft.com/fwlink/p/?LinkID=394392)  

<a name="addKeywordsRule"></a>   
## Add a keywords rule  
 Create rules from keywords, inclusions, and exclusions and define the sources and languages that you want the rule to search on. This is the most common way to define a rule in a search topic, and it usually results in a large number of posts.  
  
### Add a new keywords rule  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic that you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Keywords rule**.  
  
5.  Enter the keywords; select the inclusions, exclusions, and the filters that you want to use when searching for posts.  
  
6.  Select **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
    > [!IMPORTANT]
    >  The solution checks the quota availability for the new rule and prompts you accordingly. If your quota can't accommodate the new rule, you can't save it.  
  
7.  In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your rule.  
  
### Add keywords to search for  
Keywords define the terms and phrases to listen for. Keywords are exact, but not case-sensitive. We recommend that you include variations of keywords. For example, if your keyword is **phone** and the term that appears in a post is **phones**, your result won't be selected by the search rule and the result won't show up in your analysis. For each keyword, the comma serves as an OR. If you add more than one search term, your search rule looks for at least one of the listed terms. To increase the likelihood of getting the results you want, think about adding acronyms and common contractions.  
  
It's important to review keywords regularly. If your keywords yield too many results, consider narrowing the search rule by adding inclusions and exclusions, or reducing the number of keywords.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Refine your search rules](refine-search-rules.md)  
  
For example, let's assume that you want to listen to posts about a product that Contoso manufactures. You could add the keywords to a search rule like this: **Product name, #prodname, Name of the product**. All posts that mention one of these keywords will result from the search rule.  
  
### Add inclusions to a keywords rule  
Narrow your search by adding inclusions so that you get a much higher quality selection of posts. Think of inclusions as the word AND. Your search will be filtered so that posts are selected only if they contain at least one of the keywords *and* at least one of the inclusions. Inclusions aren't case-sensitive.  
  
When listening to posts about a product, you want to make sure that posts relate to a product in the manufacturer's portfolio. Consider adding different spellings of the brand or company name. For example, to find posts that mention Contoso's product you might add something like this to the inclusions: **#contoso, Contoso, @contoso**. All posts that mention one of the keywords and one of the inclusions will now be found by this search rule.  
  
When you set up your search rule, you can choose from the following options to decide how close a keyword and an inclusion must appear in a post:  
  
- **Sentence**: Keywords and inclusions must appear in the same sentence.  
  
- **Paragraph**: Keywords and inclusions must appear in the same paragraph.  
  
- **Post**: Keywords and inclusions must appear in the same post.  
  
It's a good idea to start with the default option (**Paragraph**). If your search topic yields too many irrelevant results, narrow it by selecting the **Sentence** option. Note that this may also remove relevant posts because all combinations of inclusions and keywords outside of a sentence will no longer be picked up by the keywords rule.  

Inclusions are a great way to reduce the number of posts resulting from your search and make sure you stay within your quota.  
  
### Exclude terms from a keywords rule  
Sometimes a specific word or phrase can overwhelm your results with irrelevant posts. With exclusions, you can narrow your searches and improve your results. Enter the terms you want to exclude and separate them by commas, and your searches will ignore posts that contain those terms. Exclusions aren't case-sensitive. For every term that you add to the exclusions, your search will be filtered so that no post will be selected if it matches one of the keywords but contains any of your exclusions. Think of exclusions as the words AND NOT.  
  
For example, let's assume that you're not interested in discounts or offers around Contoso's product. To avoid results that contain either **discounts** or **offers**, add those terms to the search rule's exclusions. All posts that mention at least one of the exclusions in the same post as a keyword will no longer be included in the results from this rule.  
  
To exclude multiple terms, the exclusions must be added to the same search rule. If one rule searches for **Contoso** while excluding **discounts** and another rule searches for **Contoso** while excluding **offers**, the search topic will only exclude all posts mentioning **Contoso** that contain both **discounts** and **offers**. If the rule searches for **Contoso** while excluding **discounts, offers**, the search topic will exclude all posts mentioning **Contoso** that contain either **discounts** or **offers**, which is what you want.  
  
> [!TIP]
>  You can exclude terms from all active search rules in one step by adding a term to the list of blocked content. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the quality of your search results](search-results-quality.md)  
  
Exclusions are a great way to reduce the number of posts that result from your search and make sure you stay within your post quota. However, you should choose your exclusions carefully to avoid missing relevant posts.  
  
### Handle special characters in keywords, inclusions, and exclusions  
Exact searches are critical to successful social listening. Special characters are often used in brand or product names in the form of connectors. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] interprets the special characters +, &, /,  and - as separate entities in a search rule.  
  
For example, searching for the term **City Power & Light** will result in posts that mention this term with all combinations of white space. Posts that contain any of the following terms (not case-sensitive) will be picked up by the search:  
  
-   City Power & Light (white space before and after the special character)  
  
-   City Power& Light (white space after the special character)  
  
-   City Power &Light (white space before the special character)  
  
-   City Power&Light (no white space before or after the special character)  
  
#### Additional special characters  
Authors on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] and [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] regularly use #hashtags and @mentions. [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] authors also will use $stocktweets. Use those special characters if you want to search explicitly for #hashtags, $stocktweets, or @mentions. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] interprets those terms as unique entities when they're added to a search rule.  
  
For example, searching for the term **#contoso** will only find results that contain the exact match of the hashtag.  
  
### Limitations on topic names, keywords, inclusions, and exclusions  
Although you can create an unlimited number of search rules per search topic, there are limits on the length and number of terms:  
  
-   Maximum length, in characters, of search topic names: 35  
  
-   Maximum length, in characters, per keyword, inclusion, or exclusion: 128  
  
-   Maximum number of keywords per search rule: 15  
  
-   Maximum number of inclusions per search rule: 15  
  
-   Maximum number of exclusions per search rule: 25  
  
<a name="addFacebookRule"></a>   
## Add a Facebook pages rule  
Keep track of all conversations that happen on a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page. Usually, you follow conversations on a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page in full context and don't look only at specific posts. If you add a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to a search topic, you can make sure that all posts on the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page (such as posts from the audience and the page, or comments from the page and the audience) are captured for further processing in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
  
### Add a new Facebook pages rule  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic that you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Facebook pages rule**.  
  
5.  In the input field, enter a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page URL or search for a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page with a keyword.  
  
6.  In the list of results, select the [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page to add.  
  
     or  
  
     Select a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page from the social profiles that you added.  
  
    > [!NOTE]
    >  You can also add multiple [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] profiles or pages to a rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each page.  
  
7.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
8.  In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your rule.  
  
<a name="addTwitterRule"></a>   
## Add a Twitter rule  
Follow conversations on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] and add a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] rule to see tweets, mentions, replies, or retweets in a search topic.  
  
### Add a new Twitter rule  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Twitter rule**.  
  
5.  In the search field, enter the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] @username that you want to track.  
  
    If you don't have a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile added to your social profiles, you need to sign in to [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] first to perform searches on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)].  
  
6.  In the list of results, select the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile to add.  
  
     or 
  
     Select a [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile from social profiles that have already been added. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage social profiles](manage-social-profiles.md)  
  
    > [!NOTE]
    >  You can also add multiple [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profiles to a rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each profile.  
  
7.  Select the message types that you want to add to this rule.  
  
8.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
9. In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your rule.  
  
<a name="instagram_rule"></a>   
## Add an Instagram rule  
Create rules to gather posts from [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] accounts.  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Instagram rule**.  
  
5.  In the search field, enter the [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] @username that you want to track.  
  
    > [!NOTE]
    >  You can also add multiple [!INCLUDE[tn_instagram](../includes/tn-instagram.md)] accounts to a rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each profile.  
  
6.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
<a name="privateMessagesRule"></a>   
## Add a private messages rule  
To see the details of private messages that [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] users send or receive on an added social profile, create a private messages rule in a search topic. You can create a private messages rule for every social profile if the owner of the social profile allows the data acquisition of private messages.  
  
> [!IMPORTANT]
> If you add a private messages rule, all private messages (except where the message is an image only) that were sent to the selected profile are visible in your organization's [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution. All users of the solution will be able to see the private messages and their replies if they are sent through [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
> When you add a new private messages rule, all private messages from the past 3 days get acquired by [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] and thus count toward your monthly post quota. 
  
### Add a new private messages rule  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Private messages rule**.  
  
5.  Select the social profile for which you want the private messages to be available in Analytics. Keep in mind that you can only choose from social profiles whose owners explicitly allowed data acquisition for private messages. You can also add multiple social profiles to a private messages rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each profile.  
  
    > [!NOTE]
    > If the system can't identify a language in a private message, or if an identified language isn't supported by [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], these private messages will be mapped to the first selected search language in **Global Settings** > **Search Languages**. You can't change the identified language of a post. 
    > Text content is critical for language recognition. Private messages that contain an image only don't get acquired by [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].

  
6.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  
  
7.  In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your rule.  
  
<a name="customSourceRule"></a>   
## Add a custom sources rule 

Create rules to gather posts from custom sources. You can also create keyword rules that match keywords in custom source posts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a keywords rule](add-rules-search-topic.md#addKeywordsRule)  
  
### Add a new custom sources rule  
  
1.  Go to **Search Setup**.  
  
2.  Select the search topic you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **Custom sources rule** in the **Add Rule** pane to add the rule to the search topic.  
  
5.  In the list of results, select a custom source group, and then click **Continue**.  
  
    > [!NOTE]
    >  You can also add multiple custom sources to a custom sources rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each profile.  
  
6.  In the search topic pane, click **Save** (![Save button](media/save-icon.png "Save button")) to activate your rule. 

## Add a [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] rule

Gather video posts and comments from [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels.

> [!NOTE]
> After adding a new [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] rule, it might take several hours until the first videos and comments are acquired. The data acquisition of comments is focused on videos that have had user activity in the last month.

1.  Go to **Search Setup**.  
  
2.  Select the search topic you want to add the rule to, or create a new search topic.  
  
3.  Under **Rules**, click **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4.  Click **YouTube rule**.  
  
5.  In the search field, enter the [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channel name that you want to track or select a [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] profile from the list.
  
    > [!NOTE]
    >  You can also add multiple [!INCLUDE[tn_youtube](../includes/tn-youtube.md)] channels to a rule in one step by clicking **Add** (![Add button](media/add-icon.png "Add button")) next to each channel.  
  
6.  Click **Continue** in the **Add Rule** pane to add the rule to the search topic.  

<a name="linkedin-page-rule"></a> 
## Add a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] page rule

Gather posts and comments from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages that you administer.

1. Go to **Search Setup**.  
  
2. Select the search topic you want to add the rule to, or create a new search topic.  
  
3. Under **Rules**, select **Add new rule** (![Add button](media/add-icon.png "Add button")) to open the **Add Rule** page.  
  
4. Select **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] page rule**.  
  
5. Select the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Organization Pages you want to keep track of, and then select **Add** to add them to the search rule.    
  
   > [!NOTE]
   > You need to have [organization pages added to your social profiles](./manage-social-profiles.md) to add them to a rule.  
  
6. Select **Continue** in the **Add Rule** pane to add the rule to the search topic.

7. In the **Search Topic** pane, select **Save** to apply the changes and start data acquisition.
  
## Privacy notices  
[!INCLUDE[cc_privacy_msl_social_services_content](../includes/cc-privacy-msl-social-services-content.md)]  
  
[!INCLUDE[cc_privacy_msl_index_cached_data](../includes/cc-privacy-msl-index-cached-data.md)]  
  
[!INCLUDE[cc_privacy_mse_bing_social_check](../includes/cc-privacy-mse-bing-social-check.md)]  

[!include[cognitive services privacy token](../includes/cc-privacy-mse-ms-cognitive-services.md)]

### See also  
[Set up searches to listen to social media conversations](set-up-searches.md)   
[Create or delete a search topic](create-delete-search-topic.md)   
[Manage your post quota](manage-post-quota.md)   
[Get started with Social Engagement](get-started.md)
 
