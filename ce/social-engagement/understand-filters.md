---
title: "Get to know your filters | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-18"
ms.reviewer: ""
ms.service: "mse"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Social Engagement"
ms.assetid: ba690f72-43cd-4fdb-a400-b3a9e3eb2f22
caps.latest.revision: 18
ms.author: "dechang"
---
# Get to know your filters
You can edit or remove filters from your analysis at any time, and the charts, lists, and key performance indicators (KPIs) will adapt to your selection. Filters that you define remain on the different pages of Analytics and adapt if you drill down into more detailed analysis. Different filters are available for different interaction areas. Click the Filter button ![Filter button](../social-engagement/media/filters-icon.png "Filter button") to expand and see options that are available for each filter.  
  
> [!NOTE]
>  You'll only see available filters when you configure your data sets. Some filters aren't available in an area because they are based on metadata that you change after the post's acquisition, either manually or through workflows. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Avoid conflicting filter combinations](../social-engagement/use-filters.md#conflicting_filters)  
  
## Keywords  
 Add keywords that must appear in posts to make them available for analysis. You can add entire phrases or single terms. If you add a comma-separated list of phrases or terms, the commas are treated as Boolean OR connectors and will add multiple keywords filters. Common characters are accepted, as well as the special characters @, #, and $.    Your analysis narrows your results to posts that contain the keywords that you’ve entered in your keyword filter.  
  
## Sources  
 Select the provided sources or custom sources that are active in your current analysis. Your analysis shows results from the sources that you selected in your filter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Find out what's covered by sources](../social-engagement/sources-coverage.md)  
  
## Languages  
 Choose from the list of active search languages to focus your analysis on one or more languages. Your analysis shows results from the languages that you selected in your filter.  
  
## Sentiment  
 Filter your posts by sentiment value. You can select positive, negative, or neutral.  
  
## Sentiment status  
 Select between system-rated and manually-edited sentiment values. Distinguish whether a sentiment value was calculated by the sentiment algorithm or  edited by a user. Confirming or changing a sentiment value for a post is considered to be a manual edit. You can limit your data set to see only posts with the selected sentiment status.  
  
## Reach  
 [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] takes an author’s [!INCLUDE[tn_klout](../includes/tn-klout.md)] score into account to determine the potential size of an author’s influence, based on data that the [!INCLUDE[tn_klout](../includes/tn-klout.md)] service gathers from various social media networks. [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] maps the author’s [!INCLUDE[tn_klout](../includes/tn-klout.md)] score to reach values that allow segmentation of authors’ reaches for [!INCLUDE[tn_twitter](../includes/tn-twitter.md)].  
  
 Choose a value from 1 to 5, where 1 is the lowest reach and 5 is the highest reach.  
  
 **Reach 1**: [!INCLUDE[tn_klout](../includes/tn-klout.md)] score 0 to 9  
  
 **Reach 2**: [!INCLUDE[tn_klout](../includes/tn-klout.md)] score 10 to 19  
  
 **Reach 3**: [!INCLUDE[tn_klout](../includes/tn-klout.md)] score 20 to 39  
  
 **Reach 4**: [!INCLUDE[tn_klout](../includes/tn-klout.md)] score 40 to 49  
  
 **Reach 5**: [!INCLUDE[tn_klout](../includes/tn-klout.md)] score 50 to 99  
  
 For News sources, the reach in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] is calculated as a normalized static metric, based on a source's site traffic and its social outreach (primarily [!INCLUDE[tn_facebook](../includes/tn-facebook.md)]). The calculated value gets mapped to the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] reach score like the [!INCLUDE[tn_klout](../includes/tn-klout.md)] score.    Your analysis narrows your results to posts that come from authors with the reach that you defined in your filter.  
  
## Location  
 To filter your data for posts from specific locations, add locations or location groups to this filter. To see the list of available locations, start typing the first letters in the input field. You can add filters to the level of countries/regions. Filtering at the city level is not supported.    Your analysis narrows your results to posts that contain location data and where the location data corresponds with the filter that you added.  
  
## Location type  
 Choose the type of location data that you want to include in your current data set. Analyze posts that have been published in a certain country or region (post location) or by authors from a certain country or region (author location). Select post location, author location, or both.    If you select both location types in the filter and a post contains both types, it will account for the post location over the author location. If only one location type is selected, the same post will show up in either selection.  
  
> [!NOTE]
>  Some posts may have no location assigned if a location wasn’t shared by the author.  
  
## Authors  
 Filter posts by author names. Any author name is available for filtering if the author published at least one post. Start typing the author name  to see suggested author names from your solution’s database.    When you filter by author, only posts from the selected authors remain in your data set and widgets display.  
  
## Post type  
 Select from Post, Reply, Share, or Private message to narrow your data set to see the results for the selected post types.  
  
 **Post**: Single posts that were published as status updates.  
  
 **Reply**: Posts that reference a parent post (reply on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], comment on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)]).  
  
 **Share**: All posts in your data set that are shares on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] or retweets on [!INCLUDE[tn_twitter](../includes/tn-twitter.md)].  
  
 **Private message**: All posts that are direct messages sent to a social profile. Additionally, the acquisition of private messages must be allowed in the social profile and a private messages rule must be set up to capture them.[!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Add a private messages rule](../social-engagement/add-rules-search-topic.md#privateMessagesRule)  
  
## Contributor  
 Narrow your data set to show posts that are coming from either the owner or audience of a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page. You can choose to see posts from [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages that were either published by the owner of a [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page or from other people posting on this [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] page.  
  
<a name="assignee_filter"></a>   
## Assignee  
 The assignee filter narrows your data set to show only posts that are assigned to the selected user or group. You can enter any user or group that is assigned a post in [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)]. Start typing a name to see suggestions. You can also specify whether you want to include posts assigned to any groups that the Assignee is a member of.  
  
## Labels  
 Narrow your data set to see only posts that are assigned the selected labels. You can also exclude labels when you apply the labels filter to find posts that don't have a specific label. Any label that an administrator defined in **Settings** > **Global Settings** > **Labels** is available as a filter value.  
  
## Link to Dynamics 365  
 Find posts that either are or aren’t linked to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record.  
  
## Tags  
 Find posts that match one of the available intention tags or custom tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Tag posts with intention tags and custom tags](../social-engagement/tags.md)  
  
## See Also  
 [Use filters to see relevant data](../social-engagement/use-filters.md)   
 [Perform visual filtering on widgets](../social-engagement/visual-filtering-widgets.md)