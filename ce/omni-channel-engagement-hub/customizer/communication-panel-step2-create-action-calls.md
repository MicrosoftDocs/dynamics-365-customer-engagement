---
title: "Create a communication panel related action calls | MicrosoftDocs"
description: "Learn how to set up the communication panel related action calls for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: F0089899-0939-4D11-AAF7-D7FE1D53D3CA
ms.custom: 
---

# Step 2:  Create action calls related to a communication panel

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic demonstrates how to create communication panel-related action calls in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) and [Step 1: Create communication panel hosted control](communication-panel-step1-create-hosted-control.md). The configurations that you completed are required for this topic.

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)
  
  
## Create action calls

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details:

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Launch Communication Panel      |
    | General | Hosted Control | Communication Panel |
    | General | Action         | default             |

6. Save the action call.

7. Repeat steps 3 through 6 to create the following additional action calls.

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Clear Entity List      |
    | General | Order | 1 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ClearEntityList    |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Fetch Live Work Streams      |
    | General | Order | 2 | 
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch    |
    | General | Data | name=LiveWorkStreamSearch <br>global=True |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Fetch Service End Point     |
    | General | Order | 2 | 
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch    |
    | General | Data | name=ServiceEndPointSearch <br>global=True |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Save Configuration Data 
    | General | Order | 3 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveConfigurationData    |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Update Omni-channel Configuration |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SaveSetting    | 
    | General | Data | name=OmniChannelConfig<br>value=\[\[OCConfig\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel AAD Authentication Failed     |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelAADAuthenticationFailure | 
    | General | Data | PostData=\[\[PostData\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General  | Name           | Omni-channel Activate Session   |
    | General  | Hosted Control | Session Tabs |
    | General  | Action         | SwitchSession | 
    | General  | Data | sessionid=\[\[SessionTabId\]+\] |
    | Advanced | Condition | '\[\[CanActivateSession\]+\]' == 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Rehydrate Conversation   |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSwitchSessionsTabs | 
    | General | Data | SessionTabId=\[\[SessionTabId\]+\] |
    | Advanced | Condition | '\[\[CanActivateSession\]+\]' == 'True' |
    
    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Create Customer Session   |
    | General | Order          | 10  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CreateSession | 
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\]  && '\[\[CanActivateSession\]+\]' != 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Session Assignment Toast Notification   |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | formname=ToastNotification <br>top=85<br>left=82<br>timeout=7<br>stack=true<br>stackHeight=56<br>placementmode=absolute<br>ToastNotificationText=\[\[$Resources.SessionAssignmentToastNotification\]+\]<br>NotificationIcon=new_omni_toast_tick_icon |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] >= \[\[$Global.maxNumberOfSessions\]+\] && '\[\[CanActivateSession\]+\]' != 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Set IsCaseSession to False   |
    | General | Order | 11 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | IsCaseSession=False |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Session Accepted   |
    | General | Order | 15 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSessionAccepted | 
    | General | Data | ConversationId=\[\[cid\]\]<br>SessionTabId=\[\[$Session.ActiveSession\]\]<br>From=\[\[from\]\]<br>CanActivateSession=\[\[CanActivateSession\]+\] |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] ||  '\[\[CanActivateSession\]+\]' == 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Close Toast Notification  |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Close | 

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Expand Right Pane   |
    | General | Hosted Control | Custom Panel |
    | General | Action         | SetVisualProperty | 
    | General | Data | elementName=RightPanelExpander <br> propertyname=IsExpanded <br> value=true |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Create Customer Session   |
    | General | Order | 10 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | OmnichannelSessionAccepted | 
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\]  && '\[\[CanActivateSession\]+\]' != 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Session Error Toast Notification   |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | formname=ToastNotification <br> top=85 <br> left=82 <br> timeout=7 <br> stack=true <br> stackHeight=56 <br> placementmode=absolute <br> ToastNotificationText=\[\[$Resources.SessionErrorToastNotificationText\]+\] <br> NotificationIcon=new_omni_toast_error_icon |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] >= \[\[$Global.maxNumberOfSessions\]+\] && '\[\[CanActivateSession\]+\]' != 'True' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Set Entity Session Property in Context   |
    | General | Order | 11 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | ISENTITYSESSION=True <br> CRMCONTACTID=010101  |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Collapse Left Panel   |
    | General | Order | 12 |
    | General | Hosted Control | Custom Panel |
    | General | Action         | SetVisualProperty | 
    | General | Data | elementname=LeftPanelParent<br>propertyname=Visibility<br> value=$Expression('\[\[$Context.IsCaseSession\]+\]'=='True' \|\| '\[\[$Context.ISENTITYSESSION\]+\]'=='True' \|\| '\[\[$Session.IsGlobal\]+\]'=='True' \|\| '\[\[$Context.cticallincoming\]+\]'=='1'? "Collapsed" : "Visible") |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Case session Agent Script  |
    | General | Order | 20 |
    | General | Hosted Control | Agent Script |
    | General | Action         | GotoTask | 
    | General | Data | Case Resolution Script |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] | 

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Case session Agent Script   |
    | General | Order | 20 |
    | General | Hosted Control | Agent Script |
    | General | Action         | GotoTask | 
    | General | Data | Case Resolution Script |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Form for entity |
    | General | Order | 30 |
    | General | Hosted Control | Entity Page |
    | General | Action         | Open_CRM_Page | 
    | General | Data | LogicalName=\[\[EntityLogicalName\]+\] <br> id=\[\[EntityId\]+\] |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           |  Omni-channel Set Session Tab Id For Entity Session  |
    | General | Order | 40 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSetSessionTabIdForEntitySession | 
    | General | Data | ConversationId=\[\[ConversationId\]\] <br> SessionTabId=\[\[$Session.ActiveSession\]\] |
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Focus on KB Search  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ShowTab | 
    | General | Data | KB Search |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Display Message Action  |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DisplayMessage | 
    | General | Data | text=An error occurred in the communication panel. Restart Unified Service Desk and try again. (Error Code - \[\[TEXT\]+\]) <br> caption=Error |   

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel End Conversation  |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelEndConversation | 
    | General | Data | ChatPayLoad=\[\[PostData\]\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Presence Status Update  |
    | General | Order | 240 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OCPresenceUpdate | 
    | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] <= \[\[$Global.maxNumberOfSessions\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Incoming Session Request  |
    | General | Order | 17 |    
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelIncomingSessionRequest | 
    | General | Data | ChatPayLoad=\[\[PostData\]\] |         

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Chat Transfer Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | formname=ChatTransferRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> cid=\[\[ConversationId\]+\] <br> showWarning=\[\[showWarning\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
    | Advanced | Condition | \[\[RequestType\]\] == "3" && "\[\[ParticipantInitiatorType\]+\]" != "AutoAssign" |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Consult Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | formname=ConsultRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> showWarning=\[\[showWarning\]+\] <br> stackHeight=100 <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
    | Advanced | Condition | \[\[RequestType\]\] == "2" |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Simple Chat Request Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | formname=SimpleChatRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> showWarning=\[\[showWarning\]+\] <br> channelIcon=\[\[channelIcon\]+\] <br> channelName=\[\[channelName\]+\] <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
    | Advanced | Condition | (\[\[RequestType\]\] == "1" && "\[\[ParticipantInitiatorType\]+\]" != "Supervisor") || (\[\[RequestType\]\] == "3" && "\[\[ParticipantInitiatorType\]+\]" == "AutoAssign") |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Simple Chat Request From Supervisor Alert Notification  |
    | General | Hosted Control | Omni-channel Alert Notification |
    | General | Action         | Show | 
    | General | Data | formname=SimpleChatRequestFromSupervisorForm <br> top=8  <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> showWarning=\[\[showWarning\]+\] <br> channelIcon=\[\[channelIcon\]+\] <br> channelName=\[\[channelName\]+\] <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
    | Advanced | Condition | \[\[RequestType\]\] == "1" && "\[\[ParticipantInitiatorType\]\]" == "Supervisor" |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Supervisor Dashboard  |
    | General | Hosted Control | Supervisor Dashboard |
    | General | Action         | Navigate | 
    | General | Data | url=https://app.powerbi.com/groups/615cd3a0-1220-4a6e-b611-45b88532bfdf/dashboards/1dfe8823-0e81-4f23-a81d-8bb1069ea059?chromeless=1&nosignupcheck=1 |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Agent Home Page  |
    | General | Order | 1 |
    | General | Hosted Control | Omni-channel Agent Dashboard |
    | General | Action         | Navigate | 
    | General | Data | url=/main.aspx?pagetype=dashboard&id=e8fb53c5-2f79-e811-8162-000d3aa3ef73&_canOverride=false <br> HideNavigationBar=True |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Communication Panel Loaded  |
    | General | Order | 17 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelConversationControlReady |     

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Load Supervisor Conversations |
    | General | Order | 19 |
    | General | Hosted Control | Supervisor Conversations |
    | General | Action         | Navigate | 
    | General | Data | "url=/main.aspx?pagetype=dashboard&id=7a33c42b-02f9-e811-8161-000d3afe51f1&type=system <br> hideNavigationBar=true" |       
    
    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Copy Contact Ids To Context |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | contactIds = \[\[contact\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Fetch Context Contacts |
    | General | Order | 3 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch | 
    | General | Data | ContextContactSearch <br> global=True |
    | Advanced | Condition |  $Expression('\[\[$Context.contactIds\]+\]' == '' ? "false" : "true") |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Save Context Entities |
    | General | Order | 4 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveContextEntities | 
    | General | Data | LiveWorkItemId = \[\[LiveWorkItemId\]+\] <br> SessionId = \[\[SessionId\]+\] <br> RequestType = \[\[RequestType\]+\] <br> LiveWorkStreamId = \[\[LiveWorkStreamId\]+\] <br> ChatId=\[\[ChatId\]+\] |    

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Clear Context Entities |
    | General | Order | 1 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ClearEntityList | 
    | General | Data | global=True |    

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Copy Contact Ids To Context |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | CopyToContext | 
    | General | Data | contactIds = \[\[contact\]+\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Fetch Context Contacts |
    | General | Order | 3 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | DoSearch | 
    | General | Data | ContextContactSearch <br> global=True |
    | Advanced | Condition | $Expression('\[\[$Context.contactIds\]+\]' == '' ? "false" : "true") |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Save Context Entities on Update |
    | General | Order | 4 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSaveUpdatedContextEntities | 
    | General | Data | LiveWorkItemId=\[\[LiveWorkItemId\]+\] | 

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Initialize Omni-channel Context - Window Variable - Customer Summary |
    | General | Order | 5 |
    | General | Hosted Control | Customer Summary |
    | General | Action         | RunScript | 
    | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('\[\[$Settings.OmniChannelConfig\]+\]'); <br> var session = {"LiveWorkItemId" : "\[\[$Context.LiveWorkItemId\]+\]", "OCSessionId" : "\[\[$Context.OCSessionId\]+\]", "LiveWorkStreamId" : "\[\[$Context.LiveWorkStreamId\]+\]", "LiveWorkItemContext" : '\[\[$Context.LiveWorkItemContext\]\]', "SessionInfo": '\[\[$Context.SessionInfo\]+\]'}; <br> ocConfig.config.sessionParams = session; <br> window.ocContext = ocConfig; <br> } <br> initOCContext(); |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Refresh Customer Summary Controls |
    | General | Order | 6 |
    | General | Hosted Control | Customer Summary |
    | General | Action         | RunScript | 
    | General | Data | function refreshControls() { <br> MscrmControls.FormInitiator.FormInitiatorControl.updateLinkedRecords(); <br> } <br> refreshControls(); |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Notify Communication Panel Error |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelNotifyConversationControlError | 
    | General | Data | PostData=\[\[PostData\]+\] |  

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Proxy Response |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelProxyResponse | 
    | General | Data | ChatPayLoad=\[\[PostData\]\] |  

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Session Transfer Initiated |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelSessionTransferInitiated | 
    | General | Data | ChatPayLoad=\[\[PostData\]\] |      

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Focus on Omni-channel Agent Dashboard |
    | General | Order | 2 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | ShowTab | 
    | General | Data | Omni-channel Agent Dashboard |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Update Old Presence Status In Settings |
    | General | Order | 10 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | appname=$GlobalDictionary <br> param=OCOLDPRESENCESTATE <br> value=\[\[$GlobalDictionary.OCCURRENTPRESENCESTATE\]\] <br> global=true |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Update Current Presence Status In Settings |
    | General | Order | 20 |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | appname=$GlobalDictionary <br> param=OCCURRENTPRESENCESTATE  <br> value=\[\[CURRENT_PRESENCE_STATE\]+\]  <br> global=true |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Update All Presence Status In Settings |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | appname=$GlobalDictionary <br> param=OCALLPRESENCESTATE  <br> value=\[\[CURRENT_PRESENCE_STATE\]+\]  <br> global=true |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Case Entity Notification |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | formname=EntityNotification <br> top=85 <br> left=82 <br> timeout=60 <br> stack=true <br> stackHeight=56 <br> EntityDisplayName=\[\[EntityDisplayName\]+\] <br> EntityLogicalName=\[\[EntityLogicalName\]+\] <br> EntityId=\[\[EntityId\]+\] <br> ConversationId=\[\[ConversationId\]+\] <br> placementmode=absolute <br> NotificationIcon=new_omni_foonotification_case_icon |
    | Advanced | Condition | '\[\[EntityLogicalName\]+\]' == 'incident' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Show Defaut Entity Notification |
    | General | Order | 10 |
    | General | Hosted Control | Omni-channel Toast Notification |
    | General | Action         | Show | 
    | General | Data | formname=EntityNotification <br> top=85 <br> left=82 <br> timeout=60 <br> stack=true <br> stackHeight=56 <br> EntityDisplayName=\[\[EntityDisplayName\]+\] <br> EntityLogicalName=\[\[EntityLogicalName\]+\] <br> EntityId=\[\[EntityId\]+\] <br> ConversationId=\[\[ConversationId\]+\] <br> placementmode=absolute <br> NotificationIcon=new_omni_foonotification_default_icon |
    | Advanced | Condition | '\[\[EntityLogicalName\]+\]' != 'incident' |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Unread Message Action |
    | General | Order | 10 |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelUnreadMessage | 
    | General | Data | ChatPayLoad=\[\[PostData\]\] |

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Omni-channel Upadte Presence |
    | General | Hosted Control | Communication Panel |
    | General | Action         | OmnichannelUpdatePresence | 
    | General | Data | ChatPayLoad=\[\[PostData\]+\] |  

    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Update Session Count In Dictionary |
    | General | Hosted Control | CRM Global Manager |
    | General | Action         | SetReplacementParameter | 
    | General | Data | appname=$GlobalDictionary <br> param=CurrentSessionCount <br> value=\[\[CurrentSessionCount\]+\] <br> global=true |

> [!div class="nextstepaction"]
> [Next topic: Step 3: Attach communication panel-related action calls to events](communication-panel-step3-attach-action-calls-events.md)

## See also

- [Step 1: Create communication panel hosted control](communication-panel-step1-create-hosted-control.md)
- [Step 4: Add hosted control, action calls, and events to configurations](communication-panel-step4-add-hosted-control-action-calls-events-configurations.md)
