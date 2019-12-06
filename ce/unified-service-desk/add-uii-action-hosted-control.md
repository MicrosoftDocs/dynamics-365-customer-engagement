---
title: "Add a UII action to a hosted control | MicrosoftDocs"
description: "Learn about adding User Interface Integration (UII) actions to a hosted control type to provide new functionality."
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
# Add a UII action to a hosted control
As new versions of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] are developed, new [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] actions might get added to a hosted control type to provide new functionality. However, the new [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] actions for a hosted control type will only be available out-of-box for the new instances of the hosted control type. If you have existing instances of a hosted control type in your configuration, the new [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] actions won’t become available by default. You will have to manually add the [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action to the hosted control record (instance) to be able to use the action in your action calls.  
  
> [!NOTE]
>  You must manually add the [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action to a hosted control instance only if it is supported for the type of hosted control instance. Otherwise, the action won’t work for the hosted control instance.  
  
 To add a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action to an existing hosted control instance:  
  
1. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
2. Click **Hosted Controls**.  
  
3. Search for the hosted control record that you want to add a [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action to, and then click the hosted control name to open its definition.  
  
4. On the hosted control definition page, click the arrow next to the hosted control name, and then click **UII Actions**.  
  
5. Click **Add New UII Action**.  
  
6. On the **New UII Action** page, specify the name of the [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action in the **Name** field, and then click **Save and Close**. You don’t have to specify any other value on this page.  
  
   ![Add a UII action to a hosted control](../unified-service-desk/media/usd-new-uii-action-hc.png "Add a UII action to a hosted control")  
  
    The new [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action gets added to the hosted control instance, and can be used in your action calls.  
  
### See also  
 [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md)   
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)
