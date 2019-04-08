---
title: "Steps or procedure to configure communication panel for agents | MicrosoftDocs"
description: "Learn steps to configure communication panel for agents using Omni-channel Engagement Hub."
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

    | Tab     | **Field**                           | **Value**                       |
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

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Launch Communication Panel      |
    | Hosted Control | Communication Panel |
    | Action         | default             |

6. Save the action call.

7. Repeat steps 3 through 6 to create the following additional action calls.

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Omni-channel Clear Entity List      |
    | Order | 1 |
    | Hosted Control | CRM Global Manager |
    | Action         | ClearEntityList    |


    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Omni-channel Fetch Live Work Streams      |
    | Order | 2 | 
    | Hosted Control | CRM Global Manager |
    | Action         | DoSearch    |
    | Data | name=LiveWorkStreamSearch <br>global=True |

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Order | 2 | 
    | Name           | Omni-channel Fetch Service End Point     |
    | Hosted Control | CRM Global Manager |
    | Action         | DoSearch    |
    | Data | name=ServiceEndPointSearch <br>global=True |

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Omni-channel Save Configuration Data     |
    | Order | 3 |
    | Hosted Control | Communication Panel |
    | Action         | OmnichannelSaveConfigurationData    |

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Update Omni-channel Configuration     |
    | Hosted Control | CRM Global Manager |
    | Action         | SaveSetting    | 
    | Data | name=OmniChannelConfig<br>value=[[OCConfig]+] |

    | **Field**      | **Value**                       |
    |----------------|---------------------------------|
    | Name           | Omni-channel AAD Authentication Failed     |
    | Hosted Control | Communication Panel |
    | Action         | OmnichannelAADAuthenticationFailure | 
    | Data | PostData=[[PostData]+] |

## Step 3.  Attach the Action Calls to Events

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and select the event to which you want to add the action call. Select **DesktopReady**.

5. Select **Add an Exisiting Action Call**. The **Lookup Records** pane appears.

    ![Select Add an Exisiting Action Call option from the event page](../media/oc-usd-cp-desktopready-add.png "Add an exisiting action call") 

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Launch Communication Panel** in the search box and select the action from the list, and then select **Add**. The action call is added to the **DesktopReady** event.

    ![Enter the action call name in the search box, select the action call and select add](../media/oc-usd-cp-desktopready-search-add.png "Search and add the action call")

7. Select **Save**.

8. Repeat steps 4 through 7 to create the following action calls to the events.

    | Event | Action Call |
    |-------|-------------|
    | OmnichannelFetchConfigurationData | <ul> <li> Omni-channel Clear Entity List </li> <li>Omni-channel Fetch Live Work Streams </li> <li> Omni-channel Fetch Service End Point </li> <li>Omni-channel Save Configuration Data </li> |
    | OmnichannelUpdateConfigurationContext | Update Omni-channel Configuration |
    | AADAuthenticationFailed | Omni-channel AAD Authentication Failed |

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