---
title: "Enable an entity for feedback (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "jimholtz"
ms.assetid: 5b25cf09-d43b-4165-9eaa-7549f4855e7c
caps.latest.revision: 13
ms.author: "rdubois"
manager: "brycho"
---
# Enable an entity for feedback/ratings

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Let customers write feedback for any entity record, or rate entity records within a defined rating range by enabling entities for feedback.  
  
 For example, you can enable feedback or ratings on the Case entity to receive feedback on the support experience the customer received. When several customers are rating a record, the ratings can be consolidated for each record through a custom rollup field.   In a sales scenario, you can enable the Product entity for feedback to get users' feedback on the products you sell.  
  
 By default, feedback is enabled for the Knowledge Article entity and the rollup field that stores the rating is added to knowledge article form.  
  
> [!IMPORTANT]
>  This feature was introduced in [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] and in [!INCLUDE[pn_crm_8_1_0_op_subsequent](../includes/pn-crm-8-1-0-op-subsequent.md)] (on-premises).  
>   
>  Interested in getting this feature? [Find your Dynamics 365 administrator or support person.](../basics/find-administrator-support.md)  
  
## Enable feedback  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    ### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  Under **Components**, expand **Entities**, and then click the entity you want to enable feedback for.  
  
5.  Under **Communication & Collaboration**, select the **Feedback** check box.  
  
6.  Publish your customizations:  
  
    -   To publish customizations for only the component you are currently editing, on the nav bar or in the navigation pane, click or tap the entity you have been working on, and then click or tap **Publish**.  
  
    -   To publish customizations for all unpublished components at one time, in the navigation pane, click or tap **Entities**, and then on the Actions toolbar, click or tap **Publish All Customizations**.  
  
 After you enable an entity for feedback, a regarding relationship is created between the entity and the Feedback entity.  
  
> [!IMPORTANT]
>  Once you enable an entity for feedback, you can't disable it.  
  
## Add a subgrid for feedback on the entity form  
 By default, users must go to the list of associated records of the record you want to add feedback to. To make it easier for users to add feedback, you may want to add a feedback subgrid to the form of the entity you are enabling feedback for.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    ### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  Under **Components**, expand **Entities**, and then expand the entity you've enabled for feedback.  
  
5.  Click **Forms**.  
  
6.  Open the form of type **Main** or **Main - Interactive experience**.  
  
     The Main - Interactive experience form is used in the interactive service hub.  
  
7.  Select the section you want to insert the subgrid in, and on the Insert tab, in the Control group, click **Sub-Grid**.  
  
8.  In the Set Properties dialog box, fill in the name and label for the subgrid.  
  
9. In the Data Source section, select the information:  
  
    - **Records**. Select **Only Related Records**.  
  
    - **Entity**. Select **Feedback (Regarding)**.  
  
    - **Default View**. Select a default view for the list.  
  
10. Publish your customizations:  
  
    -   To publish customizations for only the component you are currently editing, on the nav bar or in the navigation pane, click or tap the entity you have been working on, and then click or tap **Publish**.  
  
    -   To publish customizations for all unpublished components at one time, in the navigation pane, click or tap **Entities**, and then on the Actions toolbar, click or tap **Publish All Customizations**.  
  
## Add a rollup field  to the entity form to show the ratings  
 Depending on how you want to calculate the rating for the entity, you can create a rollup field that calculates the rating, and then add it to the form of the entity you're enabling for feedback. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define rollup fields](../customize/define-rollup-fields.md)  
  
### See also  
 [Submit feedback or ratings for Dynamics 365 records](../basics/submit-feedback-ratings.md)
