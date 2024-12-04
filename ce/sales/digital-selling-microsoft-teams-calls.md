---
title: Microsoft Teams calls with conversation intelligence
description: Learn how to use Microsoft Teams dialer and conversation intelligence with the Dynamics 365 Sales Enterprise license.
ms.date: 02/02/2024
ms.topic: how-to
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
ms.owner: shujoshi
ms.custom: bap-template
---

# Microsoft Teams calls with conversation intelligence

Set up integrated Teams calls with conversation intelligence so your sellers can call customers directly from Dynamics 365 and get real-time insights, rich call summaries, and more.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Overview

Microsoft Teams dialer helps sellers to be more productive and get work done more effectively by calling customers directly from within the Dynamics 365 Sales Hub app. More information: [Call using Microsoft Teams](call-using-microsoft-teams.md)

Conversation intelligence uses analytics and data science to gather data from sellers' call recordings and Dynamics 365 Sales. Conversation intelligence analyzes the data to provide you with the information and insights to intelligently manage your sales team and proactively coach sellers. More information: [Overview of Conversation Intelligence](dynamics365-sales-insights-app.md)

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQzQl]

## Licensing options

With the Sales Enterprise license, you get unlimited number of conversation intelligence hours (call processing and recording) and Teams calling hours.  

## Set up Microsoft Teams calls with conversation intelligence

1. On the **Sales settings** page, under **Conversation intelligence**, select **Quick setup**.

    > [!NOTE]
    > To use Teams calls, sellers will need valid licenses for Microsoft Teams, Phone System, and Calling Plan or Direct Routing, in addition to assigned phone numbers. [Learn more](https://go.microsoft.com/fwlink/?linkid=2180901)

2. Turn on **Teams calls**.  
    
    By default, the following options are turned on:
    - **Answer incoming calls in Dynamics 365**
        Allows sellers to receive Teams calls in Dynamics 365 Sales. If you turn it off, sellers can only make outgoing Teams calls from within Dynamics 365.
    - **Internal call will ring only in the Teams app, not in Dynamics 365**
        Indicates that calls from internal users won't ring and won't be tracked in Dynamics 365. In this case, calls from external contacts will ring in Dynamics 365 and internal calls will ring only in Teams. You can clear the checkbox if you want sellers to receive both external and internal calls in Dynamics 365.  
    - In the **Enable for** section, select one of the following options to provide permissions to users to view Microsoft Teams dialer:
        - **All security roles**: Select this option to provide access to view Microsoft Teams dialer to users in all the security roles in your organization.
        - **Specific security roles**: Select this option to specify security roles when you want to give access to view Microsoft Teams dialer to specific users.

3. Turn on the **Recording with real-time transcription and insights** toggle to allow sellers to record calls by using the Teams dialer and get the most out of every call with advanced conversation intelligence capabilities such as AI-powered insights, rich call summaries, and more.

    - In the **Enable for** section, select one of the following options to provide permissions to users to record calls:
        - **All security roles**: Select this option to allow call recording by all the security roles in your organization.
        - **Specific security roles**: Select this option to allow call recording only by specific security roles.
    
    > [!TIP]
    > - To implement the call recording capability in your entire organization, select **All security roles**.
    > - For a phased implementation in your organization, create different security roles for each group of users and then assign the security role accordingly.

4. Select **Update**.

After settings are enabled, sellers can make Teams calls to their customers from within the Dynamics 365 Sales Hub app. They can also record the calls and apply conversation intelligence capabilities to get the most out of every call.

> [!NOTE]
> You can also enable Teams calling for other apps from the **Advanced settings** option on the **Microsoft Teams calls** setup page. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)

## Advanced settings

If you want to make advanced configurations for Teams calls and conversation intelligence settings, select **Go to advanced conversation intelligence settings** at the top of the quick setup panel. For information about advanced configurations, go to [First-run setup experience of Microsoft Teams for conversation intelligence](fre-setup-ci-sales-app.md).

:::image type="content" source="media/ds-ci-advanced-setup.png" alt-text="Advanced settings link in quick setup panel for Teams calls + conversation intelligence.":::

## Turn off Teams calls and conversation intelligence

1. Select **Go to advanced conversation intelligence settings** at the top of the quick setup panel.

2. Turn off the **Teams calls** and **Recording with real-time transcription and insights** toggles.

    > [!NOTE]
    > If you turn off **Teams calls**, **Recording with real-time transcription and insights** will also be turned off. However, you can turn off only conversation intelligence (call recording) and leave the Teams calling option on.

3. Select **Update**.
 
## Related information

[Sales accelerator](digital-selling-sales-accelerator.md)   
[Microsoft Teams collaboration](digital-selling-teams-collab.md)       
[Lead and opportunity scoring](digital-selling-scoring.md)    

