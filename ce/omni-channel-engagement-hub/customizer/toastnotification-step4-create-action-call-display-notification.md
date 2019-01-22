---
title: "Create an action call to display the notification | MicrosoftDocs"
description: "Learn how to create action calls that can be used to show notifications in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 72569407-76f3-4d44-b598-68c75c4ba64f
ms.custom: 
---
# Step 4: Create an action call to display the notification 

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**. 

3. Select **Action Calls** and select **+ New**. 

4. On the page for the new action call, specify the following details. 

 | Field           | Value                            |
 |-----------------|----------------------------------|
 | Name            | CloseUSDToastNotification        |
 | Hosted Control  | Omni-channel Toast Notification  |
 | Action          | Close                            |

5. Save the action call.

 > [!div class=mx-imgBorder]
 > ![Create close toast notification action call](../media/oc-usd-close-toastnotification-actioncall.png "Create close toast notification action call")

6. Repeat steps 3 through 5 to create the following additional action calls.

 | Field           | Value                                        |
 |-----------------|----------------------------------------------|
 | Name            | ShowCaseEntityNotification                   |
 | Order           | 10                                           |
 | Hosted Control  | Omni-channel Toast Notification              |
 | Action          | Show                                         |
 | data            | formname=CaseEntityNotification <br> top=85 <br> left=95 <br> timeout=60 <br> stack=true <br> stackHeight=50 <br> EntityDisplayName=\[\[EntityDisplayName\]+\] <br> EntityLogicalName=\[\[EntityLogicalName\]+\] <br> EntityId=\[\[EntityId\]+\] <br> ConversationId=\[\[ConversationId\]+\] |

 > [!div class=mx-imgBorder]
 > ![Show case entity toast notification action call](../media/oc-usd-show-case-entity-toastnotification-actioncall.png "Show case entity toast notification action call")

 | Field           | Value                          |
 |-----------------|--------------------------------|
 | Name            | Expand Right Pane              |
 | Hosted Control  | Custom Panel                   |
 | Action          | SetVisualProperty              |
 | data            | elementName=RightPanelExpander <br> propertyname=IsExpanded <br> value=true <br> left=95 <br> timeout=60 <br> stack=true                      |
 > [!div class=mx-imgBorder]
 > ![Expand right panel action call](../media/oc-usd-expan-right-panel-actioncall.png "Expand right panel action call")

 | Field           | Value                 |
 |-----------------|-----------------------|
 | Name            | CreateCustomerSession |
 | Order           | 10                    |
 | Hosted Control  | CRM Global Manager    |
 | Action          | SetVisualProperty     |

 > [!div class=mx-imgBorder]
 > ![Create customer session action call](../media/oc-usd-create-customer-session-actioncall.png "Create customer session action call")

 | Field           | Value                                  |
 |-----------------|----------------------------------------|
 | Name            | Set Entity Session Property in Context |
 | Order           | 11                                     |
 | Hosted Control  | CRM Global Manager                     |
 | Action          | CopyToContext                          |
 | Data            | ISENTITYSESSION=True <br> CRMCONTACTID=010101                     |

 > [!div class=mx-imgBorder]
 > ![Set entity session property context action call](../media/oc-usd-set-entity-session-property-context-actioncall.png "Set entity session property context action call")

 | Field           | Value            |
 |-----------------|------------------|
| Name            | CollapseLeftPanel |
| Order           | 12                |
| Hosted Control  | Custom Panel      |
| Action          | SetVisualProperty |
| Data            | elementname=LeftPanelParent <br>  propertyname=Visibility <br> value=$Expression('\[\[$Context.IsCaseSession\]+\]'=='True' || '\[\[$Context.ISENTITYSESSION\]+\]'=='True' || '\[\[$Session.IsGlobal\]+\]'=='True' || '\[\[$Context.cticallincoming\]+\]'=='1'? "Collapsed" : "Visible")  |

 > [!div class=mx-imgBorder]
 > ![Collapse left panel action call](../media/oc-usd-collapse-left-panel-actioncall.png "Collapse left panel action call")

 | Field           | Value                                  |
 |-----------------|----------------------------------------|
 | Name            | Load Form for Case Entity              |
 | Order           | 30                                     |
 | Hosted Control  | FOO Entity Page                        |
 | Action          | Open\_CRM\_Page                        |
 | Data            | LogicalName=\[\[EntityLogicalName\]+\] <br> id=\[\[EntityId\]+\]                    |

 > [!div class=mx-imgBorder]
 > ![Load form for case entity action call](../media/oc-usd-load-case-entity-actioncall.png "Load form for case entity action call")

 | Field           | Value                                       |
 |-----------------|---------------------------------------------|
 | Name            | OCSetSessionTabIdForEntitySession           |
 | Order           | 45                                          |
 | Hosted Control  | OmniChannelHostedControl                    |
 | Action          | OCSetSessionTabIdForEntitySession           |
 | Data            | ConversationId=\[\[ConversationId\]\] <br> SessionTabId=\[\[$Session.ActiveSession\]\]  |

 > [!div class=mx-imgBorder]
 > ![Set session tab id for entity session action call](../media/oc-usd-set-session-tabid-entity-session-actioncall.png "Set session tab id for entity session action call")

 | Field           | Value                       |
 |-----------------|-----------------------------|
 | Name            | OCSessionTimeout            |
 | Order           | 16                          |
 | Hosted Control  | OmniChannelHostedControl    |
 | Action          | OCSessionTimeout            |
 | Data            | ConversationId=\[\[cid\]\]  |

 > [!div class=mx-imgBorder]
 > ![Session timeout action call](../media/oc-usd-session-timeout-actioncall.png "Session timeout action call")

> [!div class="nextstepaction"]
> [Next topic: Step 5: Add the action calls to the events](toastnotification-step5-add-action-calls-events.md)

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create events](toastnotification-step3-create-the-events.md)
- [Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)
