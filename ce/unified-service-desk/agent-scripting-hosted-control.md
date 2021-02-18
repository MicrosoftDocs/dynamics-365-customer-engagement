---
title: "Agent Scripting (Hosted Control) | MicrosoftDocs"
description: "Learn about using Agent Scripting type of hosted control to define a call script that provides instructions to the call center agent to guide them during a customer interaction for a given session."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
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
# Agent Scripting (Hosted Control)

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Use **Agent Scripting** type of hosted control to define a call script that provides instructions to the call center agent to guide them during a customer interaction for a given session. For more information, see [Guide customer interactions with agent scripts](../unified-service-desk/guide-customer-interactions-agent-scripts.md).

<a name="AgentScripting"></a>
## Create an Agent Scripting hosted control

 While creating a new hosted control, the fields in the **New Hosted Control** screen vary based on the type of hosted control you want to create. This section provides information about the specific fields that are unique to the **Agent Scripting** hosted control type. For detailed information about creating a hosted control, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).

  
 In the **New Hosted Control** screen, under the **Unified Service Desk** area, select **Agent Scripting** from the **Unified Service Desk Component Type** drop-down list. The WorkflowPanel is the most common panel for this hosted control type, and the same is displayed in the **Display Group** field. For information about various panels available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Panels, panel types, and panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md). For information about other **General** fields, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).  
  
<a name="actions"></a>   
## Predefined UII actions  
 The following actions are supported for this type of hosted control.  
  
### Back  
 Return to the previous step in the history.  
  
<a name="Close"></a>   
### Close  
 This action is used to close the hosted control.  
  
### FireEvent  
 Fires a user-defined event from this hosted control.  
  
|Parameter|Description|  
|---------------|-----------------|  
|name|Name of the user-defined event.|  
  
 All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).  
  
<a name="GoToTask"></a>   
### GoToTask  
 This action displays the specified agent task. The available agent task names can be seen in the **Agent Scripts** section in Microsoft Dataverse (**Settings** > **Agent Scripts**).  
  
|Parameter|Description|  
|---------------|-----------------|  
||Specify the name of the agent task to display in the **Data** field.|  
  
### GoToTaskByContext  
 This action is deprecated. Use the **GoToTask** action.  
  
### GotoTaskByDnis  
 This action is deprecated. Use the **GoToTask** action.  
  
<a name="MoveToPanel"></a>   
### MoveToPanel  
 This action is used to move hosted controls between panels at runtime.  
  
|Parameter|Description|  
|---------------|-----------------|  
|app|Name of the hosted control to be moved.|  
|panel|Target panel for the hosted control.|  
  
### New_CRM_Page  
 Creates a page for creating a Dataverse record of the specified entity, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the page to create the entity record is displayed.  
  
|Parameter|Description|  
|---------------|-----------------|  
|LogicalName|The logical name of the entity for creating a new instance.|  
  
> [!NOTE]
>  The rest of the parameters should consist of name=value pairs. These are the additional pre-populated values in the form for creating a new record for the specified entity. For more information about using this action, see step 4 in [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough-configure-agent-scripting-agent-application.md).

### Open_CRM_Page
 Opens an existing instance of the entity specified and identified by the ID, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the popup should be displayed.

|Parameter|Description|
|---------------|-----------------|
|LogicalName|The logical name of the entity to open.|
|id|The ID of the entity record to open.|

### Popup
 Pops up a URL from the hosted control and runs the window navigation rules against it for routing the popup to the appropriate location.

|Parameter|Description|
|---------------|-----------------|
|url|Routes a popup from this hosted control using this URL as if it were a popup requested from the displayed control.|
|frame|The frame from which this popup originated.|

<a name="RealignWindow"></a>
### RealignWindow
[!INCLUDE[cc_RealignWindow_Action](../includes/cc-realignwindow-action.md)]

<a name="SetSize"></a>
### SetSize
 This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.

|Parameter|Description|
|---------------|-----------------|
|width|The width of the hosted control.|
|height|The height of the hosted control.|

<a name="ShowSendButton"></a>
### ShowSendButton
 This action displays the **Send** button on the agent script in the client application. This button is typically used for chat sessions, and when the user clicks the button, the [SendClicked](../unified-service-desk/agent-scripting-hosted-control.md#SendClicked) event is fired, which is used to write the script text to the chat window.

<a name="events"></a>
## Predefined events
 The following predefined events are associated with this hosted control type.

### AllAnswersVisited
 Occurs when all answers for the current task have been clicked. This is useful for checklists. Basically each answer points back to the same task. So when you click the buttons, they will display check boxes next to them. Once all are checked, this event is fired.

|Parameter|Description|
|---------------|-----------------|
|task|Name of the task for which all the answers have been clicked.|
|id|ID of the task for which all the answers have been clicked.|

<a name="SendClicked"></a>
### SendClicked
 Occurs when the **Send** button on the agent script in the client application is clicked. To display the **Send** Button, you should call the [ShowSendButton](../unified-service-desk/agent-scripting-hosted-control.md#ShowSendButton) action.

### TaskUpdated
 Occurs each time an agent script is reached, whether by the user clicking an answer, or by some component calling one of the actions on this hosted control.

|Parameter|Description|
|---------------|-----------------|
|task|Name of the agent script task that was reached. For the main menu, which isn't a listed task in the configuration of agent scripts, an event is fired with this parameter set to "[Main Menu]".|

### See also
 [Guide customer interactions with agent scripts](../unified-service-desk/guide-customer-interactions-agent-scripts.md)
 [Configure and manage agent scripts](../unified-service-desk/configure-manage-agent-scripts.md)
 [UII actions](../unified-service-desk/uii-actions.md)
 [Events](../unified-service-desk/events.md)
 [View predefined actions and events for a hosted control](../unified-service-desk/view-predefined-actions-events-hosted-control.md)
 [View embedded help for actions and events](../unified-service-desk/view-embedded-help-for-actions-and-events.md)
 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough-configure-agent-scripting-agent-application.md)
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)
 [Administration Guide for Unified Service Desk for Microsoft Dynamics CRM](https://go.microsoft.com/fwlink/p/?LinkID=394402)


[!INCLUDE[footer-include](../includes/footer-banner.md)]