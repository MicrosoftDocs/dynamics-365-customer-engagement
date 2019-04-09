---
title: "Steps or procedure to configure communication panel for agents | MicrosoftDocs"
description: "Learn the steps to configure communication panel for agents using Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 4396B2D0-20DE-4B88-A87C-DC197F14F6CF
ms.custom: 
---

# Steps for configuring communication panel

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The steps for configuring Communication panel in Unified Service Desk involves multiple steps:

## Step 1.  Create hosted control

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** and select **+ New**.

5. On the page for new hosted control, specify the following.

    | Tab     | Field                           | Value                       |
    |---------|-------------------------------------|---------------------------------|
    | General | Name                                | Communication Panel |
    | General | Unified Service Desk Component Type | USD Hosted Control |
    | General | Application is Global               | Select the checkbox  |
    | General | Display Group              | LeftPanelFill |
    | General | Application is Dynamics               | yes |
    | Hosting | Assembly URI               | `USDConfiguration.ChatControl` |
    | Hosting | Assembly Type             | `USDConfiguration.ChatControl.OmniChannelHost` |

6.  Save the hosted control.

## Step 2.  Create action calls

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details.

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Launch Communication Panel      |
    | General | Hosted Control | Communication Panel |
    | General | Action         | default             |

6. Save the action call.

7. Repeat steps 3 through 6 to create the following additional action calls.

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Clear Entity List      |
    | General | Order | 1 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ClearEntityList    |


    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Fetch Live Work Streams      |
    | General | Order | 2 | 
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch    |
    | General | Data | name=LiveWorkStreamSearch <br>global=True |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Fetch Service End Point     |
    | General | Order | 2 | 
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch    |
    | General | Data | name=ServiceEndPointSearch <br>global=True |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Save Configuration Data     |
    | General | Order | 3 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveConfigurationData    |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Update Omni-channel Configuration     |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SaveSetting    | 
    | General | Data | name=OmniChannelConfig<br>value=[[OCConfig]+] |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel AAD Authentication Failed     |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelAADAuthenticationFailure | 
    | General | Data | PostData=[[PostData]+] |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Activate Session   |
    | General | Hosted Control | Session Tabs |
    | General | Action         | SwitchSession | 
    | General | Data | sessionid=[[SessionTabId]+] |
    | Advanced | Condition | '[[CanActivateSession]+]' == 'True' |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Rehydrate Conversation   |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSwitchSessionsTabs | 
    | General | Data | SessionTabId=[[SessionTabId]+] |
    | Advanced | Condition | '[[CanActivateSession]+]' == 'True' |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Create Customer Session   |
    | General | Order          | 10  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CreateSession | 
    | Advanced | Condition | [[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]  && '[[CanActivateSession]+]' != 'True' |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Session Assignment Toast Notification   |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | formname=ToastNotification <br>top=85<br>left=82<br>timeout=7<br>stack=true<br>stackHeight=56<br>placementmode=absolute<br>ToastNotificationText=[[$Resources.SessionAssignmentToastNotification]+]<br>NotificationIcon=new_omni_toast_tick_icon |
    | Advanced | Condition | [[$GlobalDictionary.CurrentSessionCount]+] >= [[$Global.maxNumberOfSessions]+] && '[[CanActivateSession]+]' != 'True' |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Set IsCaseSession to False   |
    | General | Order | 11 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | `IsCaseSession=False` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Session Accepted   |
    | General | Order | 15 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSessionAccepted | 
    | General | Data | `ConversationId=[[cid]]<br>SessionTabId=[[$Session.ActiveSession]]<br>From=[[from]]<br>CanActivateSession=[[CanActivateSession]+]` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+] ||  '[[CanActivateSession]+]' == 'True'` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Close Toast Notification  |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Close | 

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Expand Right Pane   |
    | General | Hosted Control | Custom Panel |
    | General | Action         | SetVisualProperty | 
    | General | Data | `elementName=RightPanelExpander <br> propertyname=IsExpanded <br> value=true` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Create Customer Session   |
    | General | Order | 10 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | OmnichannelSessionAccepted | 
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]  && '[[CanActivateSession]+]' != 'True'` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Session Error Toast Notification   |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | `formname=ToastNotification <br> top=85 <br> left=82 <br> timeout=7 <br> stack=true <br> stackHeight=56 <br> placementmode=absolute <br> ToastNotificationText=[[$Resources.SessionErrorToastNotificationText]+] <br> NotificationIcon=new_omni_toast_error_icon` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] >= [[$Global.maxNumberOfSessions]+] && '[[CanActivateSession]+]' != 'True'` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Set Entity Session Property in Context   |
    | General | Order | 11 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | `ISENTITYSESSION=True <br> CRMCONTACTID=010101` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Collapse Left Panel   |
    | General | Order | 20 |
    | General | Hosted Control | Agent Script |
    | General | Action         | GotoTask | 
    | General | Data | `Case Resolution Script` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` | 

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Collapse Left Panel   |
    | General | Order | 12 |
    | General | Hosted Control | Custom Panel |
    | General | Action         | SetVisualProperty | 
    | General | Data | `elementname=LeftPanelParent <br> propertyname=Visibility  <br> value=$Expression('[[$Context.IsCaseSession]+]'=='True' || '[[$Context.ISENTITYSESSION]+]'=='True' || '[[$Session.IsGlobal]+]'=='True' || '[[$Context.cticallincoming]+]'=='1'? "Collapsed" : "Visible")` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Load Case session Agent Script   |
    | General | Order | 20 |
    | General | Hosted Control | Agent Script |
    | General | Action         | GotoTask | 
    | General | Data | `Case Resolution Script` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Load Form for entity |
    | General | Order | 30 |
    | General | Hosted Control | Entity Page |
    | General | Action         | Open_CRM_Page | 
    | General | Data | `LogicalName=[[EntityLogicalName]+] <br> id=[[EntityId]+]` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           |  Omni-channel Set Session Tab Id For Entity Session  |
    | General | Order | 40 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSetSessionTabIdForEntitySession | 
    | General | Data | `ConversationId=[[ConversationId]] <br> SessionTabId=[[$Session.ActiveSession]]` |
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] < [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Focus on KB Search  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ShowTab | 
    | General | Data | `KB Search` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Display Message Action  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DisplayMessage | 
    | General | Data | `text=An error occurred in the communication panel. Restart Unified Service Desk and try again. (Error Code - [[TEXT]+]) <br> caption=Error` |   

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel End Conversation  |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelEndConversation | 
    | General | Data | `ChatPayLoad=[[PostData]]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Presence Status Update  |
    | General | Order | 240 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OCPresenceUpdate | 
    | Advanced | Condition | `[[$GlobalDictionary.CurrentSessionCount]+] <= [[$Global.maxNumberOfSessions]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Incoming Session Request  |
    | General | Order | 17 |    
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelIncomingSessionRequest | 
    | General | Data | `ChatPayLoad=[[PostData]]` |         

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Chat Transfer Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | `formname=ChatTransferRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> cid=[[ConversationId]+] <br> showWarning=[[showWarning]+] <br> from=[[From]+] <br> isUniqueContactRecognized=[[IsUniqueContactRecognized]+] <br> jobTitle=[[contact_jobtitle_0]+] <br> email=[[contact_emailaddress1_0]+] <br> state=[[contact_Address1_Stateorprovince_0]+] <br> city=[[contact_Address1_City_0]+] <br> CanActivateSession=[[CanActivateSession]+] <br> SessionTabId=[[SessionTabId]+] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE` |
    | Advanced | Condition | `[[RequestType]] == "3" && "[[ParticipantInitiatorType]+]" != "AutoAssign"` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Consult Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | `formname=ConsultRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> showWarning=[[showWarning]+] <br> stackHeight=100 <br> cid=[[ConversationId]+] <br> from=[[From]+] <br> isUniqueContactRecognized=[[IsUniqueContactRecognized]+] <br> jobTitle=[[contact_jobtitle_0]+] <br> email=[[contact_emailaddress1_0]+] <br> state=[[contact_Address1_Stateorprovince_0]+] <br> city=[[contact_Address1_City_0]+] <br> CanActivateSession=[[CanActivateSession]+] <br> SessionTabId=[[SessionTabId]+] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE` |
    | Advanced | Condition | `[[RequestType]] == "2"` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Simple Chat Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | `formname=SimpleChatRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> showWarning=[[showWarning]+] <br> channelIcon=[[channelIcon]+] <br> channelName=[[channelName]+] <br> cid=[[ConversationId]+] <br> from=[[From]+] <br> isUniqueContactRecognized=[[IsUniqueContactRecognized]+] <br> jobTitle=[[contact_jobtitle_0]+] <br> email=[[contact_emailaddress1_0]+] <br> state=[[contact_Address1_Stateorprovince_0]+] <br> city=[[contact_Address1_City_0]+] <br> CanActivateSession=[[CanActivateSession]+] <br> SessionTabId=[[SessionTabId]+] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE` |
    | Advanced | Condition | `([[RequestType]] == "1" && "[[ParticipantInitiatorType]+]" != "Supervisor") || ([[RequestType]] == "3" && "[[ParticipantInitiatorType]+]" == "AutoAssign")` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Simple Chat Request From Supervisor Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | `formname=SimpleChatRequestFromSupervisorForm <br> top=8  <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> showWarning=[[showWarning]+] <br> channelIcon=[[channelIcon]+] <br> channelName=[[channelName]+] <br> cid=[[ConversationId]+] <br> from=[[From]+] <br> isUniqueContactRecognized=[[IsUniqueContactRecognized]+] <br> jobTitle=[[contact_jobtitle_0]+] <br> email=[[contact_emailaddress1_0]+] <br> state=[[contact_Address1_Stateorprovince_0]+] <br> city=[[contact_Address1_City_0]+] <br> CanActivateSession=[[CanActivateSession]+] <br> SessionTabId=[[SessionTabId]+] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE` |
    | Advanced | Condition | `[[RequestType]] == "1" && "[[ParticipantInitiatorType]]" == "Supervisor"` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Load Supervisor Dashboard  |
    | General | Hosted Control | Supervisor Dashboard |
    | General | Action         | Navigate | 
    | General | Data | `url=https://app.powerbi.com/groups/615cd3a0-1220-4a6e-b611-45b88532bfdf/dashboards/1dfe8823-0e81-4f23-a81d-8bb1069ea059?chromeless=1&nosignupcheck=1` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Load Agent Home Page  |
    | General | Order | 1 |
    | General | Hosted Control | Omni-channel Agent Dashboard |
    | General | Action         | Navigate | 
    | General | Data | `url=/main.aspx?pagetype=dashboard&id=e8fb53c5-2f79-e811-8162-000d3aa3ef73&_canOverride=false <br> HideNavigationBar=True` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Communication Panel Loaded  |
    | General | Order | 17 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelConversationControlReady |     

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Load Supervisor Conversations |
    | General | Order | 19 |
    | General | Hosted Control | Supervisor Conversations |
    | General | Action         | Navigate | 
    | General | Data | `"url=/main.aspx?pagetype=dashboard&id=7a33c42b-02f9-e811-8161-000d3afe51f1&type=system <br> hideNavigationBar=true"` |       
    
    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Copy Contact Ids To Context |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | `contactIds = [[contact]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Fetch Context Contacts |
    | General | Order | 3 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch | 
    | General | Data | `ContextContactSearch <br> global=True` |
    | Advanced | Condition |  `$Expression('[[$Context.contactIds]+]' == '' ? "false" : "true")` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Save Context Entities |
    | General | Order | 4 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveContextEntities | 
    | General | Data | `LiveWorkItemId = [[LiveWorkItemId]+] <br> SessionId = [[SessionId]+] <br> RequestType = [[RequestType]+] <br> LiveWorkStreamId = [[LiveWorkStreamId]+] <br> ChatId=[[ChatId]+]` |    

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Clear Context Entities |
    | General | Order | 1 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ClearEntityList | 
    | General | Data | `global=True` |    

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Copy Contact Ids To Context |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | `contactIds = [[contact]+]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Fetch Context Contacts |
    | General | Order | 3 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch | 
    | General | Data | `ContextContactSearch <br> global=True` |
    | Advanced | Condition | `$Expression('[[$Context.contactIds]+]' == '' ? "false" : "true")` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Save Context Entities on Update |
    | General | Order | 4 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveUpdatedContextEntities | 
    | General | Data | `LiveWorkItemId=[[LiveWorkItemId]+]` | 

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Initialize Omni-channel Context - Window Variable - Customer Summary |
    | General | Order | 5 |
    | General | Hosted Control | Customer Summary |
    | General | Action         | RunScript | 
    | General | Data | `function initOCContext() { <br> var ocConfig = JSON.parse('[[$Settings.OmniChannelConfig]+]'); <br> var session = {"LiveWorkItemId" : "[[$Context.LiveWorkItemId]+]", "OCSessionId" : "[[$Context.OCSessionId]+]", "LiveWorkStreamId" : "[[$Context.LiveWorkStreamId]+]", "LiveWorkItemContext" : '[[$Context.LiveWorkItemContext]]', "SessionInfo": '[[$Context.SessionInfo]+]'}; <br> ocConfig.config.sessionParams = session; <br> window.ocContext = ocConfig; <br> } <br> initOCContext();` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Refresh Customer Summary Controls |
    | General | Order | 6 |
    | General | Hosted Control | Customer Summary |
    | General | Action         | RunScript | 
    | General | Data | `function refreshControls() { <br> MscrmControls.FormInitiator.FormInitiatorControl.updateLinkedRecords(); <br> } <br> refreshControls();` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Notify Communication Panel Error |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelNotifyConversationControlError | 
    | General | Data | `PostData=[[PostData]+]` |  

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Proxy Response |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelProxyResponse | 
    | General | Data | `ChatPayLoad=[[PostData]]` |  

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Session Transfer Initiated |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSessionTransferInitiated | 
    | General | Data | `ChatPayLoad=[[PostData]]` |      

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Focus on Omni-channel Agent Dashboard |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ShowTab | 
    | General | Data | `Omni-channel Agent Dashboard` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Update Old Presence Status In Settings |
    | General | Order | 10 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | `appname=$GlobalDictionary <br> param=OCOLDPRESENCESTATE <br> value=[[$GlobalDictionary.OCCURRENTPRESENCESTATE]] <br> global=true` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Update Current Presence Status In Settings |
    | General | Order | 20 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | `appname=$GlobalDictionary <br> param=OCCURRENTPRESENCESTATE  <br> value=[[CURRENT_PRESENCE_STATE]+]  <br> global=true` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Update All Presence Status In Settings |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | `appname=$GlobalDictionary <br> param=OCALLPRESENCESTATE  <br> value=[[CURRENT_PRESENCE_STATE]+]  <br> global=true` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Case Entity Notification |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | `formname=EntityNotification <br> top=85 <br> left=82 <br> timeout=60 <br> stack=true <br> stackHeight=56 <br> EntityDisplayName=[[EntityDisplayName]+] <br> EntityLogicalName=[[EntityLogicalName]+] <br> EntityId=[[EntityId]+] <br> ConversationId=[[ConversationId]+] <br> placementmode=absolute <br> NotificationIcon=new_omni_foonotification_case_icon` |
    | Advanced | Condition | `'[[EntityLogicalName]+]' == 'incident'` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Show Defaut Entity Notification |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | `formname=EntityNotification <br> top=85 <br> left=82 <br> timeout=60 <br> stack=true <br> stackHeight=56 <br> EntityDisplayName=[[EntityDisplayName]+] <br> EntityLogicalName=[[EntityLogicalName]+] <br> EntityId=[[EntityId]+] <br> ConversationId=[[ConversationId]+] <br> placementmode=absolute <br> NotificationIcon=new_omni_foonotification_default_icon` |
    | Advanced | Condition | `'[[EntityLogicalName]+]' != 'incident'` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Unread Message Action |
    | General | Order | 10 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelUnreadMessage | 
    | General | Data | `ChatPayLoad=[[PostData]]` |

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Omni-channel Upadte Presence |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelUpdatePresence | 
    | General | Data | `ChatPayLoad=[[PostData]+]` |  

    | Tab | Field      | Value                       |
    |---------|----------------|---------------------------------|
    | General | Name           | Update Session Count In Dictionary |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | `appname=$GlobalDictionary <br> param=CurrentSessionCount <br> value=[[CurrentSessionCount]+] <br> global=true` |  

## Step 3.  Attach the Action Calls to Events

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and select the event to which you want to add the action call. Select **DesktopReady**.

5. Select **Add an Existing Action Call**. The **Lookup Records** pane appears.

    ![Select Add an Exisiting Action Call option from the event page](../media/oc-usd-cp-desktopready-add.png "Add an exisiting action call") 

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Launch Communication Panel** in the search box and select the action from the list, and then select **Add**. The action call is added to the **DesktopReady** event.

    ![Enter the action call name in the search box, select the action call and select add](../media/oc-usd-cp-desktopready-search-add.png "Search and add the action call")

7. Select **Save**.

8. Repeat steps 4 through 7 to create the following action calls to the events.

    | Event | Action Call |
    |-------|-------------|
    | OmnichannelFetchConfigurationData | <ul> <li> Omni-channel Clear Entity List </li> <li>Omni-channel Fetch Live Work Streams </li> <li> Omni-channel Fetch Service End Point </li> <li>Omni-channel Save Configuration Data </li> |
    | OmnichannelUpdateConfigurationContext | <ul>Update Omni-channel Configuration</ul> |
    | AADAuthenticationFailed | <ul>Omni-channel AAD Authentication Failed</ul> |
    | CreateCustomerSession | <ul> <li>Omni-channel Activate Session</li> <li>Omni-channel Rehydrate Conversation</li> <li>Create Customer Session</li> <li>Show Session Assignment Toast Notification</li> <li>Set IsCaseSession to False</li> <li>Omni-channel Session Accepted</li> </ul> |
    | CreateEntitySession | <ul> <li>Close Toast Notification</li> <li>Expand Right Pane</li> <li>Create Customer Session</li> <li>Show Session Error Toast Notification</li> <li>Set Entity Session Property in Context</li> <li>Collapse Left Panel</li> <li>Load Case Session Agent Script</li> <li>Load Form for Entity</li> <li>Omni-channel Set Session Tab Id for Entity</li> <li>Session</li> </ul>|
    | DisplayKBSearchControl | <ul> <li> Expand Right Pane </li> <li>Focus on KB Search</li> </ul> |
    | DisplayMessage | <ul>Display Message Action</ul> |
    | EndConversation | <ul> <li>Omni-channel End Conversation</li> <li>Omni-channel Presence Status Update</li> </ul> |
    | IncomingChatRequest | <ul>Omni-channel Incoming Session Request</ul> |
    | OmnichannelContextFetch | <ul> <li>Show Chat Transfer Request Alert Notification </li> <li>Show Consult Request Alert Notification</li> <li>Show Simple Chat Request Alert Notification</li> <li>Show Simple Chat Request From Supervisor Alert Notification</li>  |
    | Omni-channel Conversation Control Ready | <ul> <li>Load Supervisor Dashboard</li> <li>Load Agent Home Page</li> <li>Omni-channel Communication Panel Loaded</li> <li>Load Supervisor Conversations</li> </ul> |
    | OmnichannelFetchContextEntities | <ul> <li>Omni-channel Clear Context Entities</li> <li>Omni-channel Copy Contact Ids To Context</li> <li>Omni-channel Fetch Context Contacts</li> <li>Omni-channel Save Context Entities</li></ul> |
    | OmnichannelFetchContextEntitiesOnUpdate | <ul> <li>Omni-channel Clear Context Entities</li> <li>Omni-channel Copy Contact Ids To Context</li> <li>Omni-channel Fetch Context Contacts</li> <li>Omni-channel Save Context Entities on Update</li> <li>Initialize Omni-channel Context - Window Variable - Customer Summary</li> <li>Refresh Customer Summary Controls</li> </ul> |
    | OmnichannelNotifyConversationControlError | <ul> Omni-channel Notify Communication Panel Error </ul> |
    | OmnichannelProxyHttpResponse | <ul>Omni-channel Proxy Response</ul> |
    | OmnichannelSessionTransferInitiated | <ul>Omni-channel Session Transfer Initiated</ul> |
    | OmnichannelSwitchToGlobalSession | <ul>Focus on Omni-channel Agent Dashboard</ul> |
    | OmnichannelUpdatePresenceGlobalContext | <ul> <li>Update Old Presence Status In Settings</li> <li>Update Current Presence Status In Settings</li></ul> |
    | OmnichannelUpdatePresenceParameters | <ul> <li>Update Current Presence Status In Settings</li> <li>Update All Presence State In Settings</li> </ul> |
    | ShowEntityNotification | <ul> <li>ShowCaseEntityNotification</li> <li>ShowDefaultEntityNotification</li> </ul> |
    | UnreadMessage | <ul> Omni-channel Unread Message Action </ul> |
    | UpdatePresence | <ul> Omni-channel Update Presence </ul> |
    | UpdateSessionCount | <ul> Update Session Count in Dictionary </ul> |

## Step 4.  Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**

4. Selelct **Configuration** and select a configuration from the list.

5. On the navigation bar, select the down arrow next to **Configuration**, and then select **Action Calls**.

6. On the next page, select **Add Existing Action Call**, type the name of the action in the search bar and then press **Enter** or select the search icon.

7. Add the Action calls that are shown in the search results.

8. Repeat steps 4 through 7 to add the hosted controls and the events by selecting the down arrow next to Configuration, and selecting Hosted Controls and Events, respectively.

9. When you've finished, select **Save**.