---
title: "Add the Knowledge Base Search control to Dynamics 365 Customer Engagement forms | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2f43c2cb-684a-4388-a22b-6d891e4b8a19
caps.latest.revision: 26
ms.author: "anjgup"
manager: "sakudes"
---
# Add the Knowledge Base Search control to forms
Add a **Knowledge Base Search** control to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] forms to make it easy for users in your organization to find knowledge articles so they can answer common customer questions and resolve their issues right from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] records, without having to switch to a different application.  
  
 You can configure the Knowledge Base Search control to:  
  
-   Show automatic suggestions in search results based on certain fields, or based on text analytics. The text analytics feature in only available for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
-   Define filters that users can use on search results.  
  
-   Choose from a set of predefined contextual actions the users can take on an article  
  
-   Add the control on any section of any entitythat is enabled for knowledge management, including the activity wall, and also in custom entities. The control can be added to both the Main and Main - Interactive experience forms. The control is added by default to the Case form of type Main - Interactive experience.  
  
    > [!NOTE]
    >  The Knowledge Base Search control can be used on [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] and [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)]. However, some actions like Pop Out, Email Link, and Email Content aren't supported.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports two knowledge management solutions:  
  
-   Native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management: This option is available for  Dynamics 365 online  users. For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organizations, the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge solution is introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)].  
  
- [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase: This option is available only for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users. This feature was introduced in [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)].  
  
     Interested in getting this feature? [Find your Dynamics 365 administrator or support person](http://go.microsoft.com/fwlink/p/?LinkID=513070).  
  
 Depending on the knowledge solution you choose while setting up knowledge management, some of the settings for the Knowledge Base Search control will change.  
  
<a name="BKMK_Prereqs"></a>   
## Prerequisites  
 Before you add the Knowledge Base Search control, make sure to:  
  
-   Set up knowledge management in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connect Dynamics 365 to Parature Knowledge base](../admin/set-up-knowledge-management.md)  
  
-   Select the entity you want to enable knowledge management on while setting up knowledge management.  
  
<a name="BKMK_AddSearchControl"></a>   
## Add the Knowledge Base Search control to the Main forms for use in the Dynamics 365 web application  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  In the solution explorer, choose the entity you want to add the search control to, and under **Communication & Collaboration**, make sure the **Knowledge Management** check box is selected.  
  
 ![Setting to enable knowledge management on account](../admin/media/customization-account.png "Setting to enable knowledge management on account")  
  
5.  Expand the entity you’re adding the search control to, and click **Forms**.  
  
6.  Choose the entity form of type **Main**.  
  
 ![Customize the account form of type Main](../admin/media/customization-account.png "Customize the account form of type Main")  
  
7.  Select the area where you want to place the search control, and on the **Insert** tab, click **Knowledge Base Search**.  
  
     If the option to add Knowledge Base Search is disabled, it could be because knowledge management isn’t set up or isn’t enabled for the entity you’re adding the search control to.  
  
8.  In the **Set Properties** dialog box, on the **Display** tab, specify the following.  
  
 ![Set properties for Knowledge Base Search control](../admin/media/set-kb-control-properties.png "Set properties for Knowledge Base Search control")  
  
    1.  In the **Name** section, enter a name and label for the control.  
  
    2.  In the **Filter Data** section:  
  
        1.  In the **Filter search results by** drop-down list, select the set of article states that you want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to search in.  
  
            -   If you’re using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge solution, you can choose from all draft articles, all approved articles, or all published articles.  
  
            -   If you’re using the [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase, you can choose from all articles, all draft articles, or all published articles.  
  
        2.  To let users select a different filter on search results so they can see other types of articles, select the **Users can change filters** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record.  
  
        3.  If you want users to see search results only for articles in a specific language, in the **Set Default Language** drop-down list, select a default language.  
  
            > [!NOTE]
            >  This option is available only when you're using the native [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] knowledge management solution.  
  
            -   If you select **User's Default Language**, search results will be filtered based on the signed-in user's default language.  
  
            -   If the language you select isn't an active language, the search results will be filtered using the signed in user's default language.  
  
            -   If you select **User's Default Language**, and if the user's default language isn't an active language, the first active language available alphabetically is used as the default filter.  
  
        4.  To let users select a different language filter on search results so they can see other articles in other languages, select the **Users can change Language Filter** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record.  
  
    3.  In the **Additional Options** section:  
  
        1.  If you want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to suggest articles automatically based on the value in certain fields of the entity, click **Turn on automatic suggestions**.  
  
        2.  If you’ve enabled automatic suggestion, select the field for the entity that [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will use to suggest article results in the **Give knowledge base (KB) suggestions using** drop-down list.  
  
             For example, if you’re adding the search control to the `Account` entity, and want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to automatically show search results that contain the account name, select **Account Name** in the drop-down list.  
  
            > [!NOTE]
            >  This drop-down list can include all fields that are text, multi-line text, or lookup type fields.  
  
             If you are a [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] user and your organization is using native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management as the knowledge solution, you can also use text analytics to show suggested articles. To do this, select **Text Analytics** from the **Give knowledge base (KB) suggestions using** drop-down list.  
  
        3.  If you want the article rating to appear for each article in the search results, select the **Enable ratings on KB article search results based on the specified field** check box, and then select the field from the drop-down list.  
  
        4.  In **Select primary customer**, select who the email will be sent to when a customer service rep sends the article link in email. This drop-down list includes all fields for the entity that are enabled for email, for example account or contact. When the customer service rep chooses to send a link to the article to the customer, the **To** field is automatically populated with the value of the field that you select here.  
  
        5.  In **Number of results**, select how many articles to show in the search results at first.  
  
        6.  In the **Actions** drop-down list, select whether you want to make all the default actions available to CSRs or only selected ones. If you choose **Show Selected Actions**, select the actions you want to show.  
  
             The following actions are available:  
  
            -   Link the KB article. Lets users link the knowledge article to the record they're viewing the knowledge article search results in.  
  
            -   Unlink.  Lets users unlink the knowledge article from the primary record .  
  
            -   Copy link. Lets users copy the external URL of the article so they  can share it  over channels like chat or email. If you're using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, the **Copy Link** option is available only for published articles.  
  
            -   Link KB article and email link. Lets users associate an article with the primary  record and share the article link with the customer through email.  
  
            -   Link article and email content. Lets users associate an article with a case and share the article content  through email.  
  
            -   Pop out. Lets users open the article in a new window.  
  
9. Choose **Set**.  
  
<a name="bkmk_ActivityWall"></a>   
## Add the search control to the activity wall of the Main form in the Dynamics 365 web application  
 By default, the Knowledge Base Search control is added to the social pane of the case form.  
  
1.  Open the entity form you want to add the search control to.  
  
2.  In the form, in the **Social Pane** section, double-click the **Notes Properties** box.  
  
 ![Add Knowledge Base Search control to social pane](../admin/media/customization-social-pane.png "Add Knowledge Base Search control to social pane")  
  
3.  In the **Activities Tab Properties** dialog box, select the **Show Knowledge Base Search Control** check box.  
  
     As soon as you select the check box, a new tab “Knowledge Base Search” is added to the **Activity Tab Properties** dialog box.  
  
 ![Set properties of Activities tab](../admin/media/customization-activities-tab-properties.png "Set properties of Activities tab")  
  
4.  Choose the **Knowledge Base Search** tab.  
  
5.  Follow steps 8 and 9 as described previously.  
  
> [!TIP]
>  You can set up the Knowledge Base Search tab as the default tab so whenever users open the form, the Knowledge Base tab is open on the activity wall. To do this, in the **Activity Tab Properties** dialog box, in the **Default tab** section, select **Knowledge Base Search**.  
  
<a name="bkmk_InteractiveForm"></a>   
## Add the search control to a reference panel in an interactive form  
 You can add the Knowledge Base search control to any section of the Main - Interactive experience form. Main - Interactive experience forms are used in the interactive service hub.  The Knowledge Base Search control is already added by default to the reference panel of the Case form of type Main - Interactive experience. When you add the Knowledge Base Search control to a reference panel, it appears as a vertical tab at runtime.  
  
> [!IMPORTANT]
>  Because the interactive service hub does not support [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base,. make sure you choose native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge solution so users can search for records in the interactive service hub. If you choose [!INCLUDE[pn_parature](../includes/pn-parature.md)] while setting up knowledge management, users will see an error in the Knowledge Base Search pane at runtime.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  In the solution explorer, choose the entity you want to add the search control to, and under **Communication & Collaboration**, make sure the **Knowledge Management** check box is selected.  
  
5.  Expand the entity you’re adding the search control to, and then click **Forms**.  
  
6.  Choose the entity form of type **Main - Interactive experience**.  
  
 ![Main InteractionCentric form in the list of forms](../admin/media/main-interaction-centric-form.png "Main InteractionCentric form in the list of forms")  
  
7.  In the form, select the section you want to add the control to, and on the **Insert** tab, click **Knowledge Base Search**.  
  
8.  In the **Set Properties** dialog box, on the **Display** tab, specify the following.  
  
 ![Set properties for Knowledge Base Search control](../admin/media/set-kb-control-properties.png "Set properties for Knowledge Base Search control")  
  
    1.  In the **Name** section, enter a name and label for the control.  
  
    2.  In the **Filter Data** section:  
  
        1.  In the **Filter search results by** drop-down list, select the set of article states that want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to search in.  
  
             If you choose native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management as your solution, you can choose to show all draft articles, all approved articles, or all published articles.  
  
             This will be used as the default filter for the search results shown to the users.  
  
        2.  To let users select a different filter on search results so they can see other types of articles, select the **Users can change filters** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record.  
  
        3.  If you want users to see search results only for articles in a specific language, in the **Set Default Language** drop-down list, select a default language.  
  
            > [!NOTE]
            >  This option is available only when you're using the native [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] knowledge management solution.  
  
            -   If you select **User's Default Language**, search results will be filtered based on the signed-in user's default language.  
  
            -   If the language that you select isn't an active language, the search results will be filtered using the signed in user's default language.  
  
            -   If you select **User's Default Language**, and if the user's default language isn't an active language, the first active language available alphabetically is used as a default filter.  
  
        4.  To let users select a different language filter on search results so they can see other articles in other languages, select the **Users can change Language Filter** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record.  
  
    3.  In the **Additional Options** section:  
  
        1.  If you want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to suggest articles automatically based on the value in certain fields of the entity, select **Turn on automatic suggestions**.  
  
        2.  If you’ve enabled automatic suggestions, select the field of the entity that [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will use to suggest article results in the **Give knowledge base (KB) suggestions using** drop-down list.  
  
             For example, if you’re adding the search control to the `Account` entity, and want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to automatically show search results that contain the account name, select **Account Name** in the drop-down list.  
  
            > [!NOTE]
            >  This drop-down list can include all the fields that are text, multi-line text, or lookup type fields.  
  
             Although you’ll see an option to choose **Text Analytics** in the **Give knowledge base (KB) suggestions using** drop-down list, it is not supported, and will not work at runtime.  
  
        3.  If you want the article rating to appear for each article in in the search results, select the **Enable ratings on KB article search results based on the specified field**, check box, and then select the field from the drop-down list.  
  
        4.  In **Select primary customer**, select who the email will be sent to when a customer service rep chooses to send the article link in an email. This drop-down list includes all fields for the entity that are enabled for email, for example account or contact. When the customer service rep chooses to send an article link to the customer, the **To** field is automatically populated with the value of the field you select here.  
  
        5.  In **Number of results**, select how many articles to show in the search results at first.  
  
        6.  In the **Actions** drop-down list, select whether you want to make all default actions available to CSRs or only selected ones. If you choose **Show Selected Actions**, select the actions you would like to show.  
  
             The following actions are available:  
  
            -   Link the KB article. Lets users link the knowledge article to the record they're viewing the knowledge article search results in.  
  
            -   Unlink. Lets users unlink the knowledge article from the primary record .  
  
            -   Copy link. Lets users copy the external URL of the article so they  can share it over channels like chat or email. If you're using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, the **Copy Link** option is available only for published articles.  
  
            -   Link KB article and email link. Lets users associate an article with the primary  record and share the article link through email.  
  
            -   Link article and email content. Lets users associate an article with a case and share the article content through email.  
  
            -   Pop out. Lets users open the article in a new window.  
  
            > [!NOTE]
            >  Although, the Pop out option is available for selection in the drop-down list, it isn’t supported at runtime in the interactive service hub.  
  
### See also  
 [Connect Dynamics 365 to Parature Knowledge base](../admin/set-up-knowledge-management.md)