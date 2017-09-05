---
title: "Configure toolbars in your application | MicrosoftDocs"
description: "Learn about configuring toolbars in your application."
ms.custom: ""
ms.date: "2017-08-23"
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 61cf4cb9-71ed-40c8-bbfa-c846c45cfb74
caps.latest.revision: 5
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Configure toolbars in your application
You can configure toolbars in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to create or manage buttons in an existing toolbar, or create new toolbars altogether. For an overview of toolbars, see [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md).  
  
<a name="Create"></a>   
## Create a toolbar  
 Before creating a toolbar, ensure that there is a toolbar container hosted control already configured. For more information, see [Toolbar Container (Hosted Control)](../unified-service-desk/toolbar-container-hosted-control.md).  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3.  Click **Toolbars**.  
  
4.  On the toolbars page, click **New** on the command bar.  
  
5.  On the **New Toolbar** page, and.  
  
    1.  Type a name for the new toolbar.  
  
    2.  Type a title for the toolbar, which is displayed on the left edge of the toolbar strip.  
  
    3.  Click **Save** to enable the **Buttons** area.  
  
6.  Under the **Buttons** area, click **+** to create a button to be placed on the toolbar.  
  
7.  On the **New Toolbar Button** page:  
  
    1.  Specify the name of the button.  
  
    2.  Specify the name of the image file for the toolbar button.  
  
    3.  In the **ButtonText** field, type the label of the button.  
  
    4.  To control the left to right order in which the buttons are displayed on the toolbar, specify an integer value in the **Order** field. The buttons are arranged from left to right in the ascending order.  
  
    5.  Click **Save** to enable the **Actions** area.  
  
8.  Under the **Actions** area, click **+** to add an action call to the button.  
  
9. In the search box in Under the **Actions** area, type the name of the action call that you want to attach to the button. If you want to attach the button to a new action call, click **New**, and then add create an action call and then add it to the UII action. For more information, see [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md).  
  
10. For additional button on the toolbar, follow steps 6-9.  
  
11. After adding buttons and action calls to a toolbar, attach the toolbar to a toolbar container. This is done to specify the location of the new toolbar on the desktop of in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. With the toolbar definition open, click the down arrow next to the toolbar name, and then select **Hosted Controls**.  
  
12. On the next page, click **Add Existing Hosted Application**.  
  
13. In the search box, type the name of the toolbar container hosted control, click search, and then select the hosted control.  
  
14. Click **Save**.  
  
<a name="EditToolbar"></a>   
## Add/remove button from existing toolbar  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3.  Click **Toolbars**.  
  
4.  On the toolbars page, click the name of the toolbar that you want to modify.  
  
5.  The next page displays the toolbar definition.  
  
    1.  Add more buttons using the **Buttons** area. For more information, see steps 6-10 as in the previous section.  
  
    2.  Modify an existing button by clicking the button name under the **Buttons**, This opens the button definition page where you can change information about the button, such as bname, button text (lable), order, and action call.  
  
    3.  Click **Save** to save the changes.  
  
### See also  
 [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md)   
 [Configure your agent application using Unified Service Desk](../unified-service-desk/configure-agent-application-unified-service-desk.md)