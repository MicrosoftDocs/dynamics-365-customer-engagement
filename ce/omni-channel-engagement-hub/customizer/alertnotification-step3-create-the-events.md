---
title: "Create the events"
description: 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 09f35941-3c5b-4076-99a2-66032b0c6d4f
ms.custom: 
---
# Step 3: Create the events

Create the following events:

-   CreateCustomerSession

-   IncomingRequestRejected

-   TimedOut

-   Omni-channel Context Fetch

1.  Sign in to Dynamics 365.

2.  Go to **Settings** &gt; **Unified Service Desk**.

3.  Select **Events** and select **+ New**.

4.  In the new event page, specify the following details.

| **Field**          | **Value**                       |
|--------------------|---------------------------------|
| Name               | CreateCustomerSession           |
| Hosted Application | Omni-channel Popup Notification |

![create customer session event](../media/oc-usd-crm-create-customer-session-event.png "Create customer session action call")

1.  Save the event.

    Repeat the steps from 3 - 5 to create **IncomingRequestRejected**, **TimedOut**, and **Omni-channel Context Fetch** events.

    For the Omni-channel Context Fetch event, specify the following details.

| **Field**          | **Value**                  |
|--------------------|----------------------------|
| Name               | Omni-channel Context Fetch |
| Hosted Application | OmniChannelHostedControl   |

![omni-channel context fetch event](../media/oc-usd-crm-context-fetch-event.png "Omni-channel context fetch action call")  

