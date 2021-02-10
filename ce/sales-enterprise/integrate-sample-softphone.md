---
title: "Integrate a sample softphone dialer with Dynamics 365 Sales | MicrosoftDocs"
description: "Learn how to integrate a sample softphone dialer with Dynamics 365 Sales  ."
ms.date: 04/01/2020
ms.service: crm-online
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Integrate a sample softphone dialer with Dynamics 365 Sales

A softphone dialer provides a simple and integrated way to call customers from within Dynamics 365 Sales. When a phone call is made, a Phone Call activity is created in Dynamics 365 Sales. The Phone Call activity captures details such as subject, phone number, and the name of the contacts who made and received the call.

Organizations can integrate a softphone dialer from their telephony provider in Dynamics 365 Sales by using Dynamics 365 Channel Integration Framework. After the softphone dialer is integrated, sales reps can quickly call their contacts with a single click or a tap from within a Sales Hub app that has had the Sales accelerator features enabled.  

> [!IMPORTANT]
> - The sample code for softphone integration with Dynamics 365 by using Dynamics 365 Channel Integration Framework is made available so customers can get early access and provide feedback. The sample code isn't meant for production use, and might have limited or restricted functionality.
> - Microsoft doesn't provide support for this sample code. Dynamics 365 Technical Support won't be able to help you with issues or questions. This is subject to [separate supplemental terms of use](https://go.microsoft.com/fwlink/p/?LinkId=511446).

**To integrate and configure the sample softphone dialer**

1. Get Dynamics 365 Channel Integration Framework from Microsoft AppSource. More information: [How to get Dynamics 365 Channel Integration Framework](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/get-channel-integration-framework)

2. Integrate the sample Azure web app (ChannelIntegrationFramework_Sample.zip) on the [Download Center](https://go.microsoft.com/fwlink/p/?linkid=2104590) by using Dynamics 365 Channel Integration Framework. More information: [Sample softphone integration using Dynamics 365 Channel Integration Framework](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/sample-softphone-integration)

    > [!IMPORTANT]
    > You must use the sample Azure web app (ChannelIntegrationFramework_Sample.zip) from the [Download Center link](https://go.microsoft.com/fwlink/p/?linkid=2104590), and not the link that's mentioned in the "Sample softphone integration using Dynamics 365 Channel Integration Framework" article.

3.  Configure the channel provider for your Dynamics 365 Sales organization. More information: [How to configure a channel provider for your Dynamics 365 organization](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/configure-channel-provider-channel-integration-framework)

> [!IMPORTANT]
> A Phone Call activity is created before a phone call is initiated from the softphone dialer. As an existing customer of Dynamics 365 Channel Integration Framework, if you've configured or implemented your system to create a Phone Call activity within the softphone dialer, you must remove the configuration or implementation to avoid creating duplicate Phone Call activities.

### See also

[Connect with customers by using a record or the Up next widget ](connect-with-customers.md)
