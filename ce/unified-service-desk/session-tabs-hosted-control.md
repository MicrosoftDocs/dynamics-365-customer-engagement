---
title: "Session Tabs (Hosted Control) in Unified Service Desk | MicrosoftDocs"
description: "Learn about Session Tabs type of hosted control in Unified Service Desk."
ms.custom: dyn365-USD
ms.date: 11/12/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 590fe7cf-9281-41ee-ba7e-c0914ef9e44a
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

# Session Tabs (Hosted Control)
Use **Session Tabs** type of hosted control to display customer information in a session tab in your agent application. The hosted control can read the session lines configuration for the session name configuration, and can evaluate which session line should be used to create the session name. An instance of this hosted control type must be available in your agent application for the session tabs to be displayed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Session management in Unified Service Desk](../unified-service-desk/session-management-unified-service-desk.md)  
  
<a name="Create"></a>   
## Create a session tab hosted control

 While creating a new hosted control, the fields in the **New Hosted Control** screen vary based on the type of hosted control you want to create. Select **Session Tabs** from the **USD Component Type** drop-down list in the **New Hosted Control** screen. 

 To create the session tabs hosted control, follow these steps:
 
 1. Sign in to the Unified Service Desk Administrator app.

 2. Select **Hosted Controls** under **Basic Settings**.

 3. Select **+ New**.

 4. Specify a name for the Hosted Control.

 5. Select **Extensions** tab.

 6. Update the XML in the **Extensions XML**. To learn more, see [Chat indicator XML](#chat-indicator-xml).

 7. Select **Save**.

 For detailed information about creating a hosted control, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).

### Chat indicator XML 

When you want to indicate that there is a new message on the session tab, you can use the chat indicator XML to show visual cues to the agents.

The `ChatAgentIndicator` and `ChatCustomerIndicator` actions depend on chat indicator content in extension XML defined in session tabs type of hosted control.

- List of time spans for which indicator needs be shown with given color code.
- Whether indicator need to blink once all the time spans are over. If blink node is available, the indicator will blink for 25secs. 

In the XML, you can define the start time and end time with the hexadecimal color code. During this time span, the system displays the indicator to the agent with the specified color. Also, you can define multiple time spans to show different status. If you want the indicator to blink after the end time of all the time spans, then you can define the blink node, which blinks for 25 seconds.

**Chat indicator XML syntax**

```XML
<chatIndicator>
<timespan start="startTime_Sec" end="endTime_sec" color="ColorCode"/>
<timespan start="startTime_Sec" end="endTime_sec" color="ColorCode"/>
<blink/>
</chatIndicator>
```

**For example:**

```XML
<chatIndicator> 
<timespan start="0" end="15" color="#F2C624"/>
<timespan start="16" end="30" color="#FF0000"/>
<blink/>
</chatIndicator>
```

- From zeroth to 15th second, the indicator shows yellow color. 
- From 16th to 30th second, the indicator shows red color. 
- From 31st second, the indicator blinks until 56th second.

<a name="Actions"></a>   
## Predefined UII actions  
 These are the predefined actions for this hosted control type.  
  
### ChatAgentIndicator  
 This action is used to indicate that the system is waiting for the agent to take action. It will also show the progress indicator time, and reset to 0.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session. The ID can also be retrieved from the context using the replacement parameter: [[context.sessionid]]|  
  
### ChatCustomerIndicator  
 This action is used to indicate that the system is waiting for the customer to take action. It will also show the progress indicator time and reset to 0.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session. The ID can also be retrieved from the context using the replacement parameter: [[context.sessionid]]|  
  
### CloseSession  
 This action will close a session. Before the session closes, the **SessionClosing** event is fired, followed by the **SessionClosed** event.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session that you want to close. You should specify this parameter to ensure that the required session is closed. If this parameter is not supplied, this action closes the current session.|  
  
### FireEvent  
 Fires a user-defined event from this hosted control.  
  
|Parameter|Description|  
|---------------|-----------------|  
|name|Name of the user-defined event.|  
  
 All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).  
  
### HideChatIndicator  
 This action is used to hide the chat indicator.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session. The ID can also be retrieved from the context using the replacement parameter: [[context.sessionid]]|  
  
### HideProgressIndicator  
 This action is used to hide the progress indicator.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session for which you want to hide the progress indicator. The ID can also be retrieved from the context using the replacement parameter: [[context.sessionid]]|  
  
<a name="RealignWindow"></a>   
### RealignWindow  
[!INCLUDE[cc_RealignWindow_Action](../includes/cc-realignwindow-action.md)]
  
### ResetProgressIndicator  
 This action is used to reset the progress timer on the session tab. The progress indicator runs for 3 minutes.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session for which you want to reset the progress indicator. The ID can also be retrieved from the context using the replacement parameter: [[context.sessionid]]|

### SwitchSession  
 This action is used to switch the session between the local sessions. Also, switch from local to global session.
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the global or local session. The global session ID can also be retrieved from the context using the replacement parameter: [[$Session.Global]g]</br>For example: `sessionid=[[$Session.Global]g]`| 
  
<a name="Events"></a>   
## Predefined events  
 The following predefined events are associated with this hosted control type. You can also create user-defined events for a hosted control. For information, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).  
  
### SessionClosed  
 Occurs after the session is closed.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionId|This is the ID of the session that was closed.|  
|IsGlobal|In the **Global Manager** version of this event, the IsGlobal flag is also passed. If the global session is closed, the flag would be **True**, Otherwise, **False**.|  
  
### SessionCloseRequested  
 Occurs when the "X" is clicked on a session tab in the agent application. If this event is not handled, the system will automatically close the session. If the event is handled, the system will not automatically close the session, and you must attach an action call to this event that calls the **CloseSession** action on your **Session Tabs** hosted control to explicitly close the session.  
  
### SessionClosing  
 Occurs  before a session is closed.  
  
|Parameter|Description|  
|---------------|-----------------|  
|SessionID|This is the ID of the session that is closed.|  
  
### See also  
 [Session management in Unified Service Desk](../unified-service-desk/session-management-unified-service-desk.md)   
 [Session Lines (Hosted Control)](../unified-service-desk/session-lines-hosted-control.md)   
 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough-5-display-enhanced-session-information-displaying-session-name-overview-data.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   
