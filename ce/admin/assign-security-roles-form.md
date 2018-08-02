---
title: "Assign security roles to a form for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: c15c1d80-6ad0-4eea-b89b-82cbf3d429b4
caps.latest.revision: 22
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Assign security roles to a form to more finely control access

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Control form and field access by assigning different security roles to different forms you create.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security concepts for Microsoft Dynamics 365](security-concepts.md)  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3. Choose **Customize the System**.  
  
4. Enable security roles.  
  
   1.  Under **Components**, expand **Entities**, and then expand the entity you want.  
  
   2.  Choose **Forms**. In the list, choose a form to edit it if it has a form type of Main.  
  
   3.  On the **Home** tab, in the **Form** group, choose **Enable Security Roles**.  
  
5. Assign security roles.  
  
   1.  In the **Assign Security Roles** dialog box, select the security roles to which this form will be available.  
  
   2.  To make this the fallback form, select the **Enabled for fallback** check box.  
  
        At least one form per entity must be a fallback form (the form that is displayed to a user when no other form is available for that user's security role).  
  
   3.  Choose **OK**.  
  
6. Preview the main form.  
  
   1.  On the **Home** tab, choose **Preview**, and then select **Create Form**, **Update Form**, or **Read-Only Form**.  
  
   2.  To close the **Preview** form, on the **File** menu, choose **Close**.  
  
7. When you’re ready to save your data, choose **Save and Close**.  
  
8. Publish your customization.  
  
   -   To publish just the edited component, choose **Save** > **Publish** on the **Home** tab.  
  
   -   To publish all unpublished components at one time, choose **Publish All Customizations**.  
  
> [!NOTE]
> [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]
