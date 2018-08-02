---
title: "Manage global settings for Social Engagement | Microsoft Docs"
description: "Learn about how to configure global settings that apply to all users of Social Engagement."
keywords: "administrator, settings, configuration"
ms.date: 10/17/2017
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 97fcbd04-f3ce-4591-9e17-4ac08017258c
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom:
  - dyn365-socialengagement
---

# Manage global settings
Define system settings that apply to the entire organization, like solution name, search topic parameters, location groups, labels for Social Center, or a custom link to a privacy statement. Set default values like date and time format, default screen language, or color theme for your [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] solution, letting your users start efficiently with your organizational requirements.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin](../includes/proc-permissions-social-listening-admin.md)]  
  
 If you aren’t an administrator, you can only override the default values for how [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] is displayed for you in **Settings** > **Personal Settings** > **Your Preferences**. More information: [Edit your user preferences](user-preferences.md#EditPrefs)  
  
<a name="Edit_solution_name"></a>   
## Edit the solution name  
 Your solution name is used for reference in various areas of the application, for example on the nav bar, or when generating alerts and notification emails, or exporting the content.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Default Preferences**.  
  
3.  Enter the new name for your solution in the **Name** text box, and then click **Save** ![Save button](media/save-icon.png "Save button").  
  
<a name="Edit_the_defautl_screen_language"></a>   
## Edit the default screen language  
 You can set the default language of the user interface for all users of your solution.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Default Preferences**.  
  
3.  Select the screen language from the **Screen language** drop-down list.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
## Edit the default time frame  
 Set the default time frame for the Analytics area. Any time you go to Analytics, you’ll see the data for the selected default time frame.  
  
 Choose from these options:  
  
- **Today**: Posts that were found on the current calendar day.  
  
- **Last Week**: Posts that were found in the past 7 calendar days.  
  
- **Last Month**: Posts that were found in the past 30 calendar days.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Default Preferences**.  
  
3.  Select the time frame from the **Default time frame** drop-down list.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
<a name="edit_the_default_date_and_time"></a>   
## Edit the default date and time format  
 You can use the available date and time format or customize it. All charts and analysis will show the selected date and time format.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Default Preferences**.  
  
3.  Select the date format from the **Date format** section.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
## Edit the number format  
 Choose the number format that meets your requirements. All charts and analysis will show the selected number format.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Default Preferences**.  
  
3.  Select the preferred number format in the **Number format** drop-down list.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
<a name="Add_or_remove_search_languages"></a>   
## Add or remove search languages  
 You can select the languages you want to have available when you set up or edit a keyword search rule in a search topic.  
  
### Add search languages  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Search Languages**.  
  
    > [!TIP]
    >  The more search languages you add, the more posts your keyword search rules may find. For more information on the supported languages, download the [Microsoft Social Engagement Translation Guide](http://go.Microsoft.com/fwlink/p/?LinkID=391086).  
  
3.  In the **Search Languages** pane, select the check boxes for the languages you want to enable in **Search Setup**.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
### Remove search languages  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Search Languages**.  
  
3.  In the **Search Languages** pane, clear the check boxes for the languages you want to disable in **Search Setup**.  
  
    > [!CAUTION]
    >  Removing search languages may affect existing search topics and rules as follows:  
    >   
    >  - **Search rule gets updated:** The removed search language is removed from search rules with multiple active search languages.  
    >  - **Search rule gets deleted:** If the search rule consists only of the removed search language, the rule is removed from the search topic.  
    >  - **Search topic gets deleted:** This occurs if the search topic consists only of search rules in the removed language.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
<a name="Define_defaults_for_new_search_topics"></a>   
## Define defaults for new search topics  
 If you’re an administrator, you can define defaults for new search topics. Select the sources and languages that are selected by default for new search topics. Users that create new search topics can either use your provided defaults for their search topics or override your settings when they set up search topics.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Search Setup Defaults**.  
  
3.  Under **Search Setup Defaults**, select the sources and languages that you want to provide as default values for new search topics.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
## Link to a custom privacy statement  
 As an administrator, you can decide whether to show or hide the link to a privacy statement for your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Privacy**.  
  
3.  Select the **Show link to privacy statement** check box.  
  
     Or, if you want to hide the link, clear the **Show link to privacy statement** check box.  
  
4.  Enter the URL of the privacy statement in the **URL** input field.  
  
5.  Click **Save** ![Save button](media/save-icon.png "Save button") to apply your changes.  
  
> [!TIP]
>  You may need to go to another page or refresh the application in your browser to see the updated link.  
  
## Turn adaptive learning on  
 The calculation of sentiment values for posts can learn from your users’ edits to sentiment values. As an administrator, you can choose if you want to enable adaptive learning for your organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Adaptive learning for your organization’s sentiment value edits](adaptive-learning.md)  
  
## Manage labels for posts  
 Define labels to classify posts. Labels are a quick and easy way to assign a status to a post,  and let you add visual markers for a post.  
  
> [!NOTE]
>  Users must have a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Enterprise User License and at least a Responder Engagement Role to assign labels to posts.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Labels**.  
  
3.  In the **Labels** pane, click **Add Label** ![Add button](media/add-icon.png "Add button").  
  
4.  Select a color from the **Color** drop-down list, add a description for your label in the **Description** text box, and then click **Save** to apply your changes to the label.  
  
> [!TIP]
>  You can use the chevron controls next to the label description to rearrange the order of the labels.  
  
 To change an existing label, edit the color or the description in the labels list, and then click **Save** to apply your changes.  
  
 To remove a status label, click **Delete** ![Delete button](media/delete-icon.png "Delete button") next to the label description, and then confirm your deletion.  
  
## Create and manage location groups  
 Add location groups as quick filters to narrow the data set for locations that are most relevant in your context. Location groups are subsets of available countries/regions for location analysis in [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)]. You can create custom location groups or use the predefined ones.  
  
### Find available location groups  
  
-   To give you a set of location groups to start with, predefined location groups are automatically created.  
  
-   To see the list of locations groups, go to **Settings** > **Global Settings** > **Location Groups**.  
  
### Create a custom location group  
 Create a custom location group to use as a filter for alerts and analysis. [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Location Groups**.  
  
3.  In the **Location Groups** pane, click the **Add** button ![Add button](media/add-icon.png "Add button").  
  
4.  In the **Group Details** pane, enter a name for the location group.  
  
5.  In the input field, start typing the name of the location you want to add to this location group until it shows up in the list. Choose the name of the location to add it to the location group.  
  
6.  Repeat step 4 until you have added all required locations.  
  
7.  Click **Save** ![Save button](media/save-icon.png "Save button") to create the location group.  
  
> [!TIP]
>  To add a larger set of locations, you can add existing location groups to a custom location group.  
  
### Edit a custom location group  
 You can add or remove locations from a custom location group at any time.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
>   
>  Administrators can edit all custom location groups. Power Analysts can only edit custom location groups they own.  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Location Groups**.  
  
3.  In the list of location groups, select the location group you want to edit.  
  
4.  In the **Group Details** pane, add or remove locations until the configuration meets your requirements.  
  
5.  Click the **Save** button ![Save button](media/save-icon.png "Save button") to confirm your edits.  
  
### Delete a custom location group  
 You can delete custom location groups that are no longer required. Predefined location groups can’t be deleted. [!INCLUDE[proc_permissions_social_listening_admin_power_analyst](../includes/proc-permissions-social-listening-admin-power-analyst.md)]  
  
1.  Go to **Settings** > **Global Settings**.  
  
2.  In the **Global Settings** pane, click **Location Groups**.  
  
3.  In the list of location groups, select the location group, and then click **Delete** ![Delete button](media/trashbin-icon.png "Delete button").  
  
4.  In the overlay notification, review the information, and then click **OK** to confirm your deletion.  
  
> [!NOTE]
> Administrators can delete all custom location groups. Power Analysts can only delete custom location groups they own. Location groups are deleted irreversibly, but you can re-create them if required.  
>  
> Alerts that have the deleted location group in the filter will automatically be set to inactive, and alert owners will be notified by email. Alerts won’t reactivate if you re-create a location group with the same name.  
  
## Promote custom tags to auto tags  
 Add custom tags to your auto tags list. You can add up to five custom tags to your list. Custom tags added to this list will be promoted to auto tags and will be automatically added to posts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tag posts with intention tags and custom tags](tags.md)  
  
### See Also  
 [Set up searches to listen to social media conversations](set-up-searches.md)   
 [Get started with Social Engagement](get-started.md)   
 [Set your preferences for the user interface](user-preferences.md)
 
