---
title: "Create a user-defined event | MicrosoftDocs"
description: "Unified Service Desk provides you with predefined events for hosted controls based on the type of the hosted control. Apart from these predefined events, you can also create your own events in Unified Service Desk, which are called user-defined events. You can use the FireEvent action or the event moniker to run user-defined events."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Create a user-defined event

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides you with predefined events for hosted controls based on the type of the hosted control. Apart from these predefined events, you can also create your own events in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], which are called user-defined events. You can use the **FireEvent** action or the event moniker to run user-defined events.  

<a name="FireEvent"></a>   
## Use the FireEvent action  
 All of the predefined and custom [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted control types, except for the **CCA Hosted Application** have a special UII action called **FireEvent**. You can call this action to initiate a user-defined event from that control. This is a convenient way to group multiple action calls into a single call, effectively creating a function within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. It is also a reasonable way to test events and their action sequences before deployment.  

 The first parameter to the **FireEvent** is the name of the event:  

```  
name=MyEvent  
```  

 All subsequent name/value pairs become the parameters to the event and thus can be used as replacement parameters within the actions that are called as a result. For example, if you pass the following parameter list:  

```  
name=MyEvent  
var1=[[account.name]]  
```  

 This will fire the custom event **MyEvent** event enabling the ability to create an action call that uses the `var1` parameter as follows:  

```  
Hosted Control=Some Hosted Control  
UII Action=Some action on the Hosted Control  
Data=[[var1]]  
```  

 This passes the event parameter as a data parameter to the hosted control action. In this example, that means the data parameter to the hosted control will be the account.name value from the session.  

<a name="EventMoniker"></a>   
## Use the event moniker  
 You can create a custom event on a hosted control, and then call it using the following event moniker syntax:  

```  
https://event/?EventName=<EVENT_NAME>&key=value&key=value&…  
```  

 In the syntax, you specify the `key=value` pair to pass parameter list to be used when the event is triggered.  

 Consider an example where you want to raise a user-defined event whenever the title of the case on the case form changes in Microsoft Dataverse. To do this:  

1. Create a new event, called `TitleChanged`, for the **Incident** hosted control in Dataverse.  

2. Create an action call, called `Action Call for Title Change`, with the following values:  


   |     Field      |                                                                                                                         Value                                                                                                                         |
   |----------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |      Name      |                                                                                                             Action Call for Title Change                                                                                                              |
   | Hosted Control |                                                                                                                       Incident                                                                                                                        |
   |     Action     |                                                                                                                     RunXrmCommand                                                                                                                     |
   |      Data      | function titleChangeReaction()  {<br /> window.open("<https://event/?EventName=TitleChanged&NewTitle="+encodeURIComponent(Xrm.Page.getAttribute("title").getValue(>)));<br /> }<br /> Xrm.Page.getAttribute("title").addOnChange(titleChangeReaction); |


3. Add the new action call that you created to the **BrowserDocumentComplete** event of the **Incident** hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add action calls to an event](../unified-service-desk/add-action-calls-event.md)  

    When the `TitleChanged` event is triggered, the following request is raised: `https://event/?EventName=TitleChanged&NewTitle=<NEW_TITLE>`  

    This will cause the `TitleChanged` event to be triggered with the following data parameter: `NewTitle=<NEW_TITLE>`  

   If you use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] in Dataverse to invoke an event in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using the event moniker (`https://event/?EventName=<EVENT_NAME>&key=value&key=value&…`), you can use the `window.IsUSD` property to determine whether the [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] code is running under [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] when the event is invoked. The following code sample can be included in your [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] code to ensure that the event is invoked only when the calling [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] is running within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  

```  
if ((window.IsUSD != null) && (window.IsUSD == true))  
{  
   window.open(https://event/?EventName=<EVENT_NAME>&key=value&key=value&…);  
}  
```  

### See also  
 [Events](../unified-service-desk/events.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)   
 [MSDN: Use JavaScript with Microsoft Dynamics CRM](/previous-versions/dynamicscrm-2016/developers-guide/hh771584(v=crm.8))


[!INCLUDE[footer-include](../includes/footer-banner.md)]