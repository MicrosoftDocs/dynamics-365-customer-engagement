---
title: "Create Omnichannel Alert Notification-related action calls | MicrosoftDocs"
description: "Learn how to create Omnichannel Alert Notification-related action calls that can be used to show notifications in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 3: Create Omnichannel Alert Notification related-action calls

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create Omnichannel Alert Notification-related actions calls.

## Prerequisites 

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md) and [Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md). The configurations that you completed are required for this topic.
 
- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create action calls

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details.

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Close Omnichannel Alert Notification       |
 | General        | Hosted Control | Omnichannel Alert Notification |
 | General        | Action         | Close                           |

6. Save the action call.

7. Repeat steps 1 through 5 to create the following additional action calls. 

## Show Simple Chat Request Alert Notification

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Show Simple Chat Request Alert Notification |
 | General        | Hosted Control | Omnichannel Alert Notification |
 | General        | Action         | Show               |
 | General        | Data           | formname=SimpleChatRequestPopUpForm <br>  top=10 <br> left=98 <br> timeout=120 <br> stack=true <br> stackHeight=50 <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> position=absolute <br> isAccept=TRUE <br> isReject=TRUE |
 | Advanced        | Condition | \[\[RequestType\]\] == "1" |

## Show Chat Transfer Request Alert Notification

 | Tab | Field | Value |
 |------------------|------------------|------------------|
 | General | Name           | Show Chat Transfer Request Alert Notification  |
 | General | Hosted Control | Omnichannel Alert Notification |
 | General | Action         | Show | 
 | General | Data | formname=ChatTransferRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> cid=\[\[ConversationId\]+\] <br> showWarning=\[\[showWarning\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
  | Advanced | Condition | \[\[RequestType\]\] == "3" && "\[\[ParticipantInitiatorType\]+\]" != "AutoAssign" |

## Show Consult Request Alert Notification

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name           | Show Consult Request Alert Notification  |
  | General | Hosted Control | Omnichannel Alert Notification |
  | General | Action         | Show | 
  | General | Data | formname=ConsultRequestPopUpForm <br> top=8 <br> left=85 <br> timeout=120 <br> stack=true <br> showWarning=\[\[showWarning\]+\] <br> stackHeight=100 <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
  | Advanced | Condition | \[\[RequestType\]\] == "2" |

<!--## Show Simple Chat Request From Supervisor Alert Notification

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name           | Show Simple Chat Request From Supervisor Alert Notification  |
  | General | Hosted Control | Omnichannel Alert Notification |
  | General | Action         | Show | 
  | General | Data | formname=SimpleChatRequestFromSupervisorForm <br> top=8  <br> left=85 <br> timeout=120 <br> stack=true <br> stackHeight=100 <br> showWarning=\[\[showWarning\]+\] <br> channelIcon=\[\[channelIcon\]+\] <br> channelName=\[\[channelName\]+\] <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> CanActivateSession=\[\[CanActivateSession\]+\] <br> SessionTabId=\[\[SessionTabId\]+\] <br> placementmode=absolute <br> isAccept=TRUE <br> isReject=TRUE |
  | Advanced | Condition | \[\[RequestType\]\] == "1" && "\[\[ParticipantInitiatorType\]\]" == "Supervisor" | -->

## Expand Right Pane**

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Expand Right Pane               |
 | General        | Hosted Control | Omnichannel Popup Notification |
 | General        | Action         | SetVisualProperty               |
 | General        | Data           | elementName=RightPanelExpander<br>propertyname=IsExpanded<br>value=true |

## Create Customer Session

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Create Customer Session |
 | General        | Order          | 10                    |
 | General        | Hosted Control | CRM Global Manager    |
 | General        | Action         | CreateSession         |
 | Advanced       | Condition |  \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\]  && '\[\[CanActivateSession\]+\]' != 'True' |

## Omnichannel Activate Session

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Omnichannel Activate Session |
 | General        | Hosted Control | Session Tabs    |
 | General        | Action         | SwitchSession         |
 | General        | Data |  sessionid=\[\[SessionTabId\]+\] |
 | Advanced       | Condition |  '\[\[CanActivateSession\]+\]' == 'True' |

## Omnichannel Rehydrate Conversation

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Omnichannel Rehydrate Conversation |
 | General        | Hosted Control | Communication Panel    |
 | General        | Action         | OmnichannelSwitchSessionsTabs         |
 | General        | Data |  SessionTabId=\[\[SessionTabId\]+\] |
 | Advanced       | Condition |  '\[\[CanActivateSession\]+\]' == 'True' |

## Set IsCaseSession to False

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Set IsCaseSession to False |
 | General        | Data | 10 |
 | General        | Hosted Control | CRM Global Manager   |
 | General        | Action         | CopyToContext         |
 | General        | Data |  IsCaseSession=False |
 | Advanced       | Condition |  \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

## Omnichannel Session Accepted

 | Tab            | Field          | Value                                       |
 |----------------|----------------|---------------------------------------------|
 | General        | Name           | Omnichannel Session Accepted               |
 | General        | Order          | 15                                          |
 | General        | Hosted Control | Communication Panel                         |
 | General        | Action         | OmnichannelSessionAccepted                  |
 | General        | Data           | ConversationId=\[\[cid\] <br> SessionTabId=\[\[$Session.ActiveSession\]\] <br> From=\[\[from\]\] <br> CanActivateSession=\[\[CanActivateSession\]+\] |
 | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] \|\| '\[\[CanActivateSession\]+\]' == 'True' |

## Omnichannel Presence status**

 | Tab            | Field          | Value                        |
 |----------------|----------------|------------------------------|
 | General        | Name           | Omnichannel Presence Status |
 | General        | Hosted Control | Communication Panel     |
 | General        | Action         | OmnichannelPresenceUpdate             |

## ExecuteKBSearchOnDataAvailable**


 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | ExecuteKBSearchOnDataAvailable  |
 | General        | Order          | 20                              |
 | General        | Hosted Control | CRM Global Manager              |
 | General        | Action         | ExecuteOnDataAvailable          |
 | General        | Data           | milliseconds=5000 <br> \[\[$Context.PRECHATANSWER3\]\]  |

## Load Default Agent Script**

 | Tab            | Field          | Value                     |
 |----------------|----------------|---------------------------|
 | General        | Name           | Load Default Agent Script |
 | General        | Order          | 150                       |
 | General        | Hosted Control | Agent Script HC           |
 | General        | Action         | GotoTask                  |
 | General        | Data           | Welcome Script            |

## Load Agent Session Search Page

 | Tab           | Field        | Value        |
 |---------------|-----------------|------------------------------------------------------|
 | General        | Name           | Load Agent Session Search Page |
 | General        | Order          | 20                                           |
 | General        | Hosted Control | Omnichannel Advanced Search |
 | General        | Action         | Navigate |
 | General        | Data           | url=/main.aspx?pagetype=control&controlName=MscrmControls.OCSearchRuntime.OCSearchRuntimeControl&navbar=off|

## Load Agent Customer Summary Page

 | Tab            | Field          | Value    |
 |----------------|----------------|---------------------------------------------|
 | General        | Name           | Load Agent Customer Summary Page  |
 | General        | Order          | 200           |
 | General        | Hosted Control | Customer Summary |
 | General        | Action         | Navigate   |
 | General        | Data           | url=/main.aspx?navbar=off&cmdbar=false&pagetype=entityrecord&etn=msdyn\_ocliveworkitem&formid=5fe86453-73ea-4821-b6dd-ddc06e1755a1&bodyOnly=true\# <br> Hidenav=true |

## Focus on Customer Summary

 | Tab            | Field          | Value              |
 |----------------|----------------|--------------------|
 | General        | Name           | Focus on Customer Summary  |
 | General        | Order          | 220                |
 | General        | Hosted Control | CRM Global Manager |
 | General        | Action         | ShowTab            |
 | General        | Data           | Customer Summary   |

## Omnichannel Session Rejected

 | Tab            | Field          | Value                      |
 |----------------|----------------|----------------------------|
 | General        | Name           | Omnichannel Session Rejected          |
 | General        | Order          | 16                         |
 | General        | Hosted Control | Communication Panel   |
 | General        | Action         | OmnichannelSessionRejected          |
 | General        | Data           | ConversationId=\[\[cid\]\] |

## Omnichannel Session Timeout

 | Tab            | Field          | Value                      |
 |----------------|----------------|----------------------------|
 | General        | Name           | Omnichannel Session Timeout           |
 | General        | Order          | 16                         |
 | General        | Hosted Control | Communication Panel    |
 | General        | Action         | OmnichannelSessionTimeout           |
 | General        | Data           | ConversationId=\[\[cid\]\] |


> [!div class="nextstepaction"]
> [Next topic: Step 4: Attach the Omnichannel Alert Notification-related action calls to the events](alertnotification-step4-add-action-calls-events.md)

## See also

- [Configure notification for agents](configure-notification-screen-pop-agents.md)
- [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Alert Notification hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 5: Add the hosted control, events, and action calls to configurations](alertnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]