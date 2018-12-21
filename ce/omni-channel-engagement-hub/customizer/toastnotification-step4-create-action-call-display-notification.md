---
title: "Create an action call to display the notification"
description: "Learn how to create action calls that can be used to show notifications in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/21/2018
ms.service: 
ms.topic: article
ms.assetid: 72569407-76f3-4d44-b598-68c75c4ba64f
ms.custom: 
---
# Step 4: Create an action call to display the notification 

1.  Sign in to Dynamics 365.

2.  Go to **Settings** &gt; **Unified Service Desk**. 

3.  Select **Action Calls** and select **+ New**. 

4.  In the new page, specify the following details. 

| Field           | Value                            |
|-----------------|----------------------------------|
| Name            | CloseUSDToastNotification        |
| Hosted Control  | Omni-channel Toast Notification  |
| Action          | Close                            |

5.  Save the action call.

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image4](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image4.png) -->

Similarly, create the following action calls by following the steps 1-4.

| Field           | Value                                        |
|-----------------|----------------------------------------------|
| Name            | ShowCaseEntityNotification                   |
| Order           | 10                                           |
| Hosted Control  | Omni-channel Toast Notification              |
| Action          | Show                                         |
| data            | formname=CaseEntityNotification              
                                                
  top=85                                        
                                                
  left=95                                       
                                                
  timeout=60                                    
                                                
  stack=true                                    
                                                
  stackHeight=50                                
                                                
  EntityDisplayName=\[\[EntityDisplayName\]+\]  
                                                
  EntityLogicalName=\[\[EntityLogicalName\]+\]  
                                                
  EntityId=\[\[EntityId\]+\]                    
                                                
  ConversationId=\[\[ConversationId\]+\]        |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image5](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image5.png)  -->

| Field           | Value                          |
|-----------------|--------------------------------|
| Name            | Expand Right Pane              |
| Hosted Control  | Custom Panel                   |
| Action          | SetVisualProperty              |
| data            | elementName=RightPanelExpander 
                                  
  propertyname=IsExpanded         
                                  
  value=true                      
                                  
  left=95                         
                                  
  timeout=60                      
                                  
  stack=true                      |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image6](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image6.png)  -->

| Field           | Value                 |
|-----------------|-----------------------|
| Name            | CreateCustomerSession |
| Order           | 10                    |
| Hosted Control  | CRM Global Manager    |
| Action          | SetVisualProperty     |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image7](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image7.png)  -->

| Field           | Value                                  |
|-----------------|----------------------------------------|
| Name            | Set Entity Session Property in Context |
| Order           | 11                                     |
| Hosted Control  | CRM Global Manager                     |
| Action          | CopyToContext                          |
| Data            | ISENTITYSESSION=True                   
                                          
  CRMCONTACTID=010101                     |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image8](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image8.png)  -->

| Field           | Value                                                                                                                                                                                                                    |
|-----------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name            | CollapseLeftPanel                                                                                                                                                                                                        |
| Order           | 12                                                                                                                                                                                                                       |
| Hosted Control  | Custom Panel                                                                                                                                                                                                             |
| Action          | SetVisualProperty                                                                                                                                                                                                        |
| Data            | elementname=LeftPanelParent                                                                                                                                                                                              
                                                                                                                                                                                                                            
  propertyname=Visibility                                                                                                                                                                                                   
                                                                                                                                                                                                                            
  value=$Expression('\[\[$Context.IsCaseSession\]+\]'=='True' || '\[\[$Context.ISENTITYSESSION\]+\]'=='True' || '\[\[$Session.IsGlobal\]+\]'=='True' || '\[\[$Context.cticallincoming\]+\]'=='1'? "Collapsed" : "Visible")  |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image9](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image9.png)  -->

| Field           | Value                                  |
|-----------------|----------------------------------------|
| Name            | Load Form for Case Entity              |
| Order           | 30                                     |
| Hosted Control  | FOO Entity Page                        |
| Action          | Open\_CRM\_Page                        |
| Data            | LogicalName=\[\[EntityLogicalName\]+\] 
                                          
  id=\[\[EntityId\]+\]                    |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image10](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image10.png)  -->

| Field           | Value                                       |
|-----------------|---------------------------------------------|
| Name            | OCSetSessionTabIdForEntitySession           |
| Order           | 45                                          |
| Hosted Control  | OmniChannelHostedControl                    |
| Action          | OCSetSessionTabIdForEntitySession           |
| Data            | ConversationId=\[\[ConversationId\]\]       
                                               
  SessionTabId=\[\[$Session.ActiveSession\]\]  |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image11](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image11.png)  -->

| Field           | Value                       |
|-----------------|-----------------------------|
| Name            | OCSessionTimeout            |
| Order           | 16                          |
| Hosted Control  | OmniChannelHostedControl    |
| Action          | OCSessionTimeout            |
| Data            | ConversationId=\[\[cid\]\]  |

<!-- Update images: ![MarkdownConversionFile_Omni channel Engagement Hub Guide   Copy image12](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide---Copy-image12.png)   -->

> [!div class="nextstepaction"]
> [Step 5: Add the action calls to the events](toastnotification-step5-add-action-calls-events.md)

## See also

[Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)

[Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)

[Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)

[Step 3: Create events](toastnotification-step3-create-the-events.md)

[Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

[Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)