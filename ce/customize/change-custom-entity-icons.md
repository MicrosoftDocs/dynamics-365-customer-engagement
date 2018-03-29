---
title: "Change custom entity icons (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
ms.assetid: 477f9792-8207-49ef-8968-45274b5355a8
caps.latest.revision: 19
ms.author: "rdubois"
manager: "brycho"
tags: 
 - "Links to topic not migrated"
---
# Change icons for custom entities

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

When you create a custom entity, it is automatically assigned a default icon, and all custom entities by default use the same icon. If your organization has several custom entities, it can be helpful to change the icon associated with one or more custom entities to help users differentiate them.  
  
> [!NOTE]
>  You can’t modify the icons assigned to system entities.  
  
 You can upload two types of entity icons for each custom entity:  
  
- **Icon in web application**. This icon should be:  
  
    -   16 x 16 pixels in size.  
  
    -   In .gif, .png, or .jpg format.  
  
    -   No larger than 10 kilobytes.  
  
- **Icon for entity forms**. This icon should be:  
  
    -   32 x 32 pixels in size.  
  
    -   16 colors.  
  
    -   In .ico format.  
  
    -   No larger than 10 kilobytes.  
  
<!--Topic referenced not migrated
> [!IMPORTANT]
>  Before you begin this task, be sure that you have uploaded as web resources any custom icons that you intend to assign. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or edit a form web resource](add-edit-form-web-resource.md)   -->
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    ### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Click **Customize the System**.  
  
4.  Expand **Entities** if necessary, select the custom entity you want to update the icon for, and then on the command bar, click **Update Icons**.  
  
5.  In the **Select New Icons** dialog box, under **Icon in Web application** or **Icon for Entity Forms**, to the right of **New Icon**, click the **Browse** button ![Lookup button](../customize/media/lookup-button-4.gif "Lookup button"), select the appropriate image file, and then click **OK**.  
  
6.  On the command bar, on the **File** menu, click **Save**.  
  
7.  When your customizations are complete, publish them:  
  
    -   To publish customizations for only the component that you are currently editing, in the Navigation Pane, select the entity you have been working on, and then click **Publish**.  
  
    -   To publish customizations for all unpublished components at one time, in the Navigation Pane, click **Entities**, and then on the command bar, click **Publish All Customizations**.  
  
     New icons might not display in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] until you close and reopen the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] client.  
  
> [!NOTE]
>  Publishing customizations can interfere with normal system operation. We recommend you schedule publishing when it’s least disruptive to users.  
  
## Community tools

**Iconator** is a tool that XrmToolbox community developed for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement. Please see the [Developer tools](../developer/developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also  
 [Create and edit entities](../customize/create-edit-entities.md)
