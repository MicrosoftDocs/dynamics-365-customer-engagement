---
title: "Create or edit a hosted control | MicrosoftDocs"
description: "Learn about creating or editing an existing hosted control."
ms.custom: 
  - dyn365-USD
ms.date: 08/23/2017
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Create or edit a hosted control
You create or edit an existing hosted control using the Common Data Service platform. The controls in the new hosted control page differ based on the type of hosted control you create.  
  
1. Sign in to the Common Data Service platform.  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3. Click **Hosted Controls**. The page displays available hosted controls.  
  
   ![Hosted controls list in Unified Service Desk](../unified-service-desk/media/crm-itpro-usd-hostedcontrollist.png "Hosted controls list in Unified Service Desk")  
  
4. On the hosted control page:  
  
   1.  To create a hosted control, click **New**.  
  
   2.  To edit a hosted control, either click on the hosted control name in the **Name** column, or select the hosted control record in the list, and then click **Edit**.  
  
5. Depending on what you selected, a new hosted control page or the existing hosted control page is displayed.  
  
   ![New hosted control in Unified Service Desk](../unified-service-desk/media/crm-itpro-usd-newhostedcontrol.PNG "New hosted control in Unified Service Desk")  
  
6. Under the **General** area, specify or change a name, sort order, and display name for the hosted control. Note that fields marked with a red asterisk are required.  
  
   1.  Specify a **Name** for your hosted control. Each hosted application must have a unique name.  
  
   2.  Specify an integer value in the **Sort Order** field for your hosted control. The sort order value specifies the order in which the hosted applications are retrieved and displayed in the agent application.  
  
   3.  By default, the name of the current user is displayed in the **Owner** field. Set another user as the owner of this hosted control, if required.  
  
7. Under the **Unified Service Desk** area, select a hosted control type from the **USD Component Type** list. The fields in the **New Hosted Control** page change based on the type of hosted control you select. For information about the various types of hosted control and the respective fields, see [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md).  
  
8. Click **Save** to create or update the hosted control.  
  
   After you have created a new hosted control, you can view, add, or remove actions and events to the hosted control.  
  
### See also  
 [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md)   
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)
