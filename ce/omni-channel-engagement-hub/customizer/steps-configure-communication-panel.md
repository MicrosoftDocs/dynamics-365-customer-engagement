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

# Walkthrough - configure communication panel for agents

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The steps for configuring Communication panel in Unified Service Desk involves multiple steps:

## Step 1.  Create hosted control

1.  Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2.  Go to **Settings** > **Unified Service Desk**.

3.  Select **Hosted Controls** and select **+ New**.

4.  On the page for new hosted control, specify the following.

| **Field**                           | **Value**                       |
|-------------------------------------|---------------------------------|
| Name                                | Communication Panel |
| Unified Service Desk Component Type | USD Hosted Control              |
| Application is Global               | Select the checkbox             |
| Display Group              | LeftPanelFill            |
| Application is Dynamics               | yes            |

5.  Save the hosted control.

## Step 2.  Create action calls

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Action Calls** and select **+ New**.

4. In the new page, specify the following details.

 | **Field**      | **Value**                       |
 |----------------|---------------------------------|
 | Name           | Launch Communication Panel      |
 | Hosted Control | Communication Panel |
 | Action         | default             |

5. Save the action call.

6. Repeat steps 3 through 5 to create the following additional action calls.

 | **Field**      | **Value**                       |
 |----------------|---------------------------------|
 | Name           | Omni-channel Clear Entity List      |
 | Hosted Control | CRM Global Manager |
 | Action         | ClearEntityList    |


 | **Field**      | **Value**                       |
 |----------------|---------------------------------|
 | Name           | Omni-channel Fetch Live Work Streams      |
 | Hosted Control | CRM Global Manager |
 | Action         | DoSearch    |
 | Data | name=LiveWorkStreamSearch <br>global=True |

 | **Field**      | **Value**                       |
 |----------------|---------------------------------|
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

## Step 3.  Create events

## Step 4.  Attach the Action Calls to Events

## Step 5.  Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations

> [!div class="nextstepaction"]
> [Next topic:]()