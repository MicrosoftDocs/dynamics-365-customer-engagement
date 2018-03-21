---
title: "Add form navigation for related entities (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
author: "rdubois-msft"
ms.assetid: b4098c96-bce1-4f57-804f-8694e6254e81
caps.latest.revision: 15
ms.author: "rdubois"
manager: "brycho"
---
# Add form navigation for related entities

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

In the form Navigation Pane, you can add links to related entities. When a user clicks one of these links in a record, the associated view for the entity is displayed.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    ### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  Under **Components**, expand **Entities**, expand the entity you want to work with, and then choose **Forms**.  
  
5.  In the list, locate an entry with the form type of Main, and then double-click or tap to edit it.  
  
6.  To add a link to a related entity, on **Home** tab, in the **Select** group, choose **Navigation**.  
  
     The **Relationship Explorer** pane displays on the right side of the form editor.  
  
7.  In the **Relationship Explorer** pane, in the **Filter** list, select one of the following options:  
  
    - **Available Relationships**. Lists all the entities that can be related to the entity the form is associated with.  
  
    - **1:N Relationships**. Lists entities that can be related in a 1:N relationship to the entity the form is associated with.  
  
    - **N:N Relationships**. Lists entities that can be related in a N:N relationship to the entity the form is associated with.  
  
    > [!NOTE]
    >  If no related entities show up in the **Relationship Explorer** pane, you cannot create a link on this form to a related entity.  
  
8.  Select the related entity you want to link to, drag it to the Navigation Pane, and then drop it where you want it to be displayed.  
  
    > [!TIP]
    >  You can also create a new relationship by choosing **New 1:N** or **New N:N** in the **Relationship Explorer** pane. For more information, see [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)  
  
9. To edit the properties for this or any other related entity link, in the Navigation Pane, select the link, and then on the **Home** tab, choose **Change Properties**.  
  
10. In the **Relationship Properties** dialog box, on the **Display** tab, type a new display label.  
  
11. On the **Name** tab, choose **Edit** to view or edit the details associated with the relationship record.  
  
12. Choose **OK**.  
  
13. Preview how the main form will appear and how events will function:  
  
    1.  On the **Home** tab, choose **Preview**, and then select **Create Form**, **Update Form**, or **Read-Only Form**.  
  
    2.  To close the **Preview** form, on the **File** menu, choose **Close**.  
  
14. When you finish editing the form, choose **Save and Close** to close the form.  
  
15. When your customizations are complete, publish them:  
  
    -   To publish customizations for only the component that you are currently editing, in the Navigation Pane, choose the entity you have been working on, and then choose **Publish**.  
  
    -   To publish customizations for all unpublished components at one time, in the Navigation Pane, choose **Entities**, and then on the command bar, choose **Publish All Customizations**.  
  
> [!NOTE]
> [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]  
  
### See also  
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)
