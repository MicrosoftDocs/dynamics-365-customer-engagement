---
title: "Create an action calls to show the notifications | MicrosoftDocs"
description: "Learn how to create action calls that can be used to show notifications in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: ffd0550b-260d-4f23-bab5-c757a258cac1
ms.custom: 
---
# Step 4: Create Omni-channel Alert Notification related-action call

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details.

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Close Omni-channel Alert Notification       |
 | General        | Hosted Control | Omni-channel Alert Notification |
 | General        | Action         | Close                           |

5. Save the action call.

6. Repeat steps 1 through 5 to create the following additional action calls.
 

##  Show Simple Chat Request Alert Notification**

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Show Simple Chat Request Alert Notification |
 | General        | Hosted Control | Omni-channel Alert Notification |
 | General        | Action         | Show               |
 | General        | Data           | formname=SimpleChatRequestPopUpForm <br>  top=10 <br> left=98 <br> timeout=120 <br> stack=true <br> stackHeight=50 <br> cid=\[\[ConversationId\]+\] <br> from=\[\[From\]+\] <br> isUniqueContactRecognized=\[\[IsUniqueContactRecognized\]+\] <br> jobTitle=\[\[contact_jobtitle_0\]+\] <br> email=\[\[contact_emailaddress1_0\]+\] <br> state=\[\[contact_Address1_Stateorprovince_0\]+\] <br> city=\[\[contact_Address1_City_0\]+\] <br> position=absolute <br> isAccept=TRUE <br> isReject=TRUE |
 | Advanced        | Condition | /[/[RequestType/]/] == "1"< |

## Expand Right Pane**

 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | Expand Right Pane               |
 | General        | Hosted Control | Omni-channel Popup Notification |
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

## Omni-channel Activate Session

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Omni-channel Activate Session |
 | General        | Hosted Control | Session Tabs    |
 | General        | Action         | SwitchSession         |
 | General        | Data |  sessionid=\[\[SessionTabId\]+\] |
 | Advanced       | Condition |  '\[\[CanActivateSession\]+\]' == 'True' |

## Omni-channel Rehydrate Conversation

 | Tab            | Field          | Value                 |
 |----------------|----------------|-----------------------|
 | General        | Name           | Omni-channel Rehydrate Conversation |
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

## Omni-channel Session Accepted

 | Tab            | Field          | Value                                       |
 |----------------|----------------|---------------------------------------------|
 | General        | Name           | Omni-channel Session Accepted               |
 | General        | Order          | 15                                          |
 | General        | Hosted Control | Communication Panel                         |
 | General        | Action         | OmnichannelSessionAccepted                  |
 | General        | Data           | ConversationId=\[\[cid\\] <br> SessionTabId=\[\[$Session.ActiveSession\]\] <br> From=\[\[from\]\] <br> CanActivateSession=\[\[CanActivateSession\]+\] |
 | Advanced | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] ||  '\[\[CanActivateSession\]+\]' == 'True' |

## Omni-channel Presence status**

 | Tab            | Field          | Value                        |
 |----------------|----------------|------------------------------|
 | General        | Name           | Omni-channel Presence Status |
 | General        | Hosted Control | OmniChannelHostedControl     |
 | General        | Action         | OCPresenceUpdate             |

## ExecuteKBSearchOnDataAvailable**


 | Tab            | Field          | Value                           |
 |----------------|----------------|---------------------------------|
 | General        | Name           | ExecuteKBSearchOnDataAvailable  |
 | General        | Order          | 20                              |
 | General        | Hosted Control | CRM Global Manager              |
 | General        | Action         | ExecuteOnDataAvailable          |
 | General        | Data           | milliseconds=5000 <br> \[\[$Context.PRECHATANSWER3\]\]  |

## FireSessionTimer**

 | Tab            | Field          | Value            |
 |----------------|----------------|------------------|
 | General        | Name           | FireSessionTimer |
 | General        | Order          | 20               |
 | General        | Hosted Control | SessionTimer     |
 | General        | Action         | FireEvent        |

## Load Default Agent Script**

 | Tab            | Field          | Value                     |
 |----------------|----------------|---------------------------|
 | General        | Name           | Load Default Agent Script |
 | General        | Order          | 150                       |
 | General        | Hosted Control | Agent Script HC           |
 | General        | Action         | GotoTask                  |
 | General        | Data           | Welcome Script            |

## Load Agent Session Search Page With Condition**

 | Tab           | Field        | Value        |
 |---------------|---------------|------------------------------------------------------|
 | General        | Name          | Load Agent Session Search Page With Condition |
 | General        | Order         | 20                                           |
 | General        | Hosted Control| AgentSessionSearchPage |
 | General        | Action         | Navigate |
 | General        | Data           | url=/main.aspx?pagetype=control&controlName=MscrmControls.OCSearchRuntime.OCSearchRuntimeControl&navbar=off|
 | Advanced       | Condition      | '\[\[isUniqueContactRecognized\]\]'=='False' |

## Load Agent Session Overview Page**

 | Tab            | Field          | Value    |
 |----------------|----------------|---------------------------------------------|
 | General        | Name           | Load Agent Session Overview Page  |
 | General        | Order          | 200           |
 | General        | Hosted Control | Session Overview  |
 | General        | Action         | Navigate   |
 | General        | Data           | url=/main.aspx?navbar=off&cmdbar=false&pagetype=entityrecord&etn=msdyn\_ocliveworkitem&formid=5fe86453-73ea-4821-b6dd-ddc06e1755a1&bodyOnly=true\# <br> Hidenav=true |

## Focus on Overview**

 | Tab            | Field          | Value              |
 |----------------|----------------|--------------------|
 | General        | Name           | Focus on Overview  |
 | General        | Order          | 220                |
 | General        | Hosted Control | CRM Global Manager |
 | General        | Action         | ShowTab            |
 | General        | Data           | Session Overview   |

## Omni-channel Session Rejected

 | Tab            | Field          | Value                      |
 |----------------|----------------|----------------------------|
 | General        | Name           | Omni-channel Session Rejected          |
 | General        | Order          | 16                         |
 | General        | Hosted Control | Communication Panel   |
 | General        | Action         | OmnichannelSessionRejected          |
 | General        | Data           | ConversationId=\[\[cid\]\] |

## Omni-channel Session Timeout

 | Tab            | Field          | Value                      |
 |----------------|----------------|----------------------------|
 | General        | Name           | Omni-channel Session Timeout           |
 | General        | Order          | 16                         |
 | General        | Hosted Control | Communication Panel    |
 | General        | Action         | OmnichannelSessionTimeout           |
 | General        | Data           | ConversationId=\[\[cid\]\] |


> [!div class="nextstepaction"]
> [Next topic: Step 5: Add the action calls to the events](alertnotification-step5-add-action-calls-events.md)

## See also

- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)
- [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 3: Create events](alertnotification-step3-create-the-events.md)
- [Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](alertnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
