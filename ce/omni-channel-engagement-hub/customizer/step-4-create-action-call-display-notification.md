---
title: "Create an action call to display the notification"
description: 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: ffd0550b-260d-4f23-bab5-c757a258cac1
ms.custom: 
---
# Step 4: Create an action call to display the notification

1.  Sign in to Dynamics 365.

2.  Go to **Settings** &gt; **Unified Service Desk**.

3.  Select **Action Calls** and select **+ New**.

4.  In the new page, specify the following details.

| **Field**      | **Value**                       |
|----------------|---------------------------------|
| Name           | CloseUSDPopUpNotification       |
| Hosted Control | Omni-channel Popup Notification |
| Action         | Close                           |

1.  Save the action call.

Similarly, create the following action calls by following the steps 1-4.

| Field          | Value                                                        |
|----------------|--------------------------------------------------------------|
| Name           | ShowSimpleChatRequestScreenPop                               |
| Hosted Control | Omni-channel Popup Notification                              |
| Action         | Show                                                         |
| Data           | formname=SimpleChatRequestPopUpForm                          
                                                                
  top=10                                                        
                                                                
  left=98                                                       
                                                                
  timeout=120                                                   
                                                                
  stack=true                                                    
                                                                
  stackHeight=50                                                
                                                                
  cid=\[\[ConversationId\]+\]                                   
                                                                
  from=\[\[From\]+\]                                            
                                                                
  isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\]  
                                                                
  jobTitle=\[\[contact\_jobtitle\_0\]+\]                        
                                                                
  email=\[\[contact\_emailaddress1\_0\]+\]                      
                                                                
  state=\[\[contact\_Address1\_Stateorprovince\_0\]+\]          
                                                                
  city=\[\[contact\_Address1\_City\_0\]+\]                      
                                                                
  position=absolute                                             
                                                                
  isAccept=TRUE                                                 
                                                                
  isReject=TRUE                                                 |
| Condition      | \[\[RequestType\]\] == "1"                                   |

| Field          | Value                           |
|----------------|---------------------------------|
| Name           | Expand Right Pane               |
| Hosted Control | Omni-channel Popup Notification |
| Action         | SetVisualProperty               |
| Data           | elementName=RightPanelExpander  
                                   
  propertyname=IsExpanded          
                                   
  value=true                       |

![expand right panel action call](media/oc-usd-crm-expand-right-panel-actioncall.png "Expand right panel action call")  

| Field          | Value                 |
|----------------|-----------------------|
| Name           | CreateCustomerSession |
| Order          | 10                    |
| Hosted Control | CRM Global Manager    |
| Action         | CreateSession         |

![create customer session action call for crm global manager hosted control](media/oc-usd-crm-create-customer-session-actioncall-crmglobalmanager.png "Create customer session action call for CRM global manager hosted control")  

| Field          | Value                        |
|----------------|------------------------------|
| Name           | Omni-channel Presence Status |
| Hosted Control | OmniChannelHostedControl     |
| Action         | OCPresenceUpdate             |

![omni-channel presence statuses action call](media/oc-usd-crm-presence-status-actioncall.png "Omni-channel presence statuses action call")  

| Field          | Value                                       |
|----------------|---------------------------------------------|
| Name           | OCSessionAccepted                           |
| Order          | 15                                          |
| Hosted Control | OmniChannelHostedControl                    |
| Action         | OCSessionAccepted                           |
| Data           | ConversationId=\[\[cid\]\]                  
                                               
  SessionTabId=\[\[$Session.ActiveSession\]\]  
                                               
  From=\[\[from\]\]                            |

![omni-channel session accepted action call](media/oc-usd-crm-session-accepted-actioncall.png "Omni-channel session accepted action call")  

| Field          | Value                           |
|----------------|---------------------------------|
| Name           | ExecuteKBSearchOnDataAvailable  |
| Order          | 20                              |
| Hosted Control | CRM Global Manager              |
| Action         | ExecuteOnDataAvailable          |
| Data           | milliseconds=5000               
                                   
  \[\[$Context.PRECHATANSWER3\]\]  |

| Field          | Value            |
|----------------|------------------|
| Name           | FireSessionTimer |
| Order          | 20               |
| Hosted Control | SessionTimer     |
| Action         | FireEvent        |

![kb article search action call](media/oc-usd-crm-kb-search-actioncall.png "KB article search action call")  

| Field          | Value                     |
|----------------|---------------------------|
| Name           | Load Default Agent Script |
| Order          | 150                       |
| Hosted Control | Agent Script HC           |
| Action         | GotoTask                  |
| Data           | Welcome Script            |

![load default agent script action call](media/oc-usd-crm-default-agent-script-actioncall.png "Load default agent script action call")  

| Field          | Value                                                                                                       |
|----------------|-------------------------------------------------------------------------------------------------------------|
| Name           | Load Agent Session Search Page With Condition                                                               |
| Order          | 20                                                                                                          |
| Hosted Control | AgentSessionSearchPage                                                                                      |
| Action         | Navigate                                                                                                    |
| Data           | url=/main.aspx?pagetype=control&controlName=MscrmControls.OCSearchRuntime.OCSearchRuntimeControl&navbar=off 
                                                                                                               
  HideNavigationBar=true                                                                                       |
| Condition      | '\[\[isUniqueContactRecognized\]\]'=='False'                                                                |

![load agent session search page action call](media/oc-usd-crm-agent-session-search-page-actioncall.png "Load agent session search page action call")  

| Field          | Value                                                                                                                                              |
|----------------|----------------------------------------------------------------------------------------------------------------------------------------------------|
| Name           | Load Agent Session Overview Page                                                                                                                   |
| Order          | 200                                                                                                                                                |
| Hosted Control | Session Overview                                                                                                                                   |
| Action         | Navigate                                                                                                                                           |
| Data           | url=/main.aspx?navbar=off&cmdbar=false&pagetype=entityrecord&etn=msdyn\_ocliveworkitem&formid=5fe86453-73ea-4821-b6dd-ddc06e1755a1&bodyOnly=true\# 
                                                                                                                                                      
  Hidenav=true                                                                                                                                        |

![load agent session overview page action call](media/oc-usd-crm-agent-session-overview-page-actioncall.png "Load agent session overview page action call")  

| Field          | Value              |
|----------------|--------------------|
| Name           | Focus on Overview  |
| Order          | 220                |
| Hosted Control | CRM Global Manager |
| Action         | ShowTab            |
| Data           | Session Overview   |

![change focus on the overview page action call](media/oc-usd-crm-focus-overview-page-actioncall.png "Change focus on the overview page action call")  

| Field          | Value                      |
|----------------|----------------------------|
| Name           | OCSessionRejected          |
| Order          | 16                         |
| Hosted Control | OmniChannelHostedControl   |
| Action         | OCSessionRejected          |
| Data           | ConversationId=\[\[cid\]\] |

![omni-channel session rejected action call](media/oc-usd-crm-session-rejected-actioncall.png "Omni-channel session rejected action call")  

| Field          | Value                      |
|----------------|----------------------------|
| Name           | OCSessionTimeout           |
| Order          | 16                         |
| Hosted Control | OmniChannelHostedControl   |
| Action         | OCSessionTimeout           |
| Data           | ConversationId=\[\[cid\]\] |

![omni-channel session timeout action call](media/oc-usd-crm-session-timeout-actioncall.png "Omni-channel session timeout action call")  

