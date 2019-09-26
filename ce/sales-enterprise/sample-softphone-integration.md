---
title: "Sample softphone integration with Dynamics 365 Sales (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the sample to learn how to integrate a softphone dialer in Dynamics 365 Sales."
keywords: "Opportunity, Close, Closing, Customization, dialog box, quick create, custom fields,"
ms.date: 10/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
ms.assetid: 
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Sample softphone integration with Dynamics 365 Sales

An integrated softphone dialer provides a simple and integrated way to call customers from within Microsoft Dynamics 365 Sales. The communications that take place are captured as phone call activity in Dynamics 365 Sales.  

Organizations can integrate a softphone dialer from their telephony provider in Dynamics 365 Sales using the Channel Integration Framework. Once integrated, sales reps can quickly call their contacts by selecting a phone number right from their app.  

This topic describes how to install the *sample* app and test the calling capabilities. 


> [!IMPORTANT]

> This sample code currently has limited availability.
> The sample code for softphone integration with Dynamics 365 using Channel Integration Framework is made available so customers can get early access and provide feedback. The sample code is not meant for production use and may have limited or restricted functionality.
> Microsoft doesn't provide support for this sample code for production use and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. This is subject to supplemental terms of use  

## Integrate and configure the sample softphone dialer

To configure the sample,

1. Get the Channel Integration Framework from Microsoft AppSource. For more information on the prerequisites and instructions to get Channel Integration Framework, see [Get Channel Integration Framework](../customer-service/channel-integration-framework/get-channel-integration-framework.md).

2. Import the “msdyn_CIFramework_managed.zip” managed solution from the [Download Center](https://go.microsoft.com/fwlink/p/?linkid=2104591). More information: [Import, update, and upgrade a solution](../customize/import-update-upgrade-solution.md).

3. Integrate the sample app (available here) available on the [Download Center](https://go.microsoft.com/fwlink/p/?linkid=2104590) using Channel integration framework. More information: [Sample softphone integration using Channel Integration Framework](../customer-service/channel-integration-framework/sample-softphone-integration.md).

    > [!IMPORTANT]
    > You must use the sample app from the [Download Center](https://go.microsoft.com/fwlink/p/?linkid=2104590), and not the one that's mentioned in the [Sample softphone integration using Channel Integration Framework](../customer-service/channel-integration-framework/sample-softphone-integration.md) topic.

4. Configure the channel provider for your Dynamics 365 Sales organization. More information: [How to configure a channel provider for your Dynamics 365 organization](../customer-service/channel-integration-framework/configure-channel-provider-channel-integration-framework.md).
 
After you're done with the configuration, any contact on an opportunity record, which  has a cell phone number defined will show a phone icon.

![Phone icon besides the contact of an opportunity](media/phone-icon-opportunity-contact.png "Phone icon besides the contact of an opportunity")

When users select this icon, the sample softphone dialer opens and calls the number. 

![Sample softphone dialer calling a contact](media/dialer-calling-cell-number.png "Sample softphone dialer calling a contact")

All details regarding the call such as the duration, phone number, and notes are automatically captured in the call summary and the phone call activity record, and the record is associated with the opportunity record the call was initiated from.

![Call summary](media/call-summary.png "Call summary")

![Call summary added to phone call activity](media/phone-call-activity-details.png "Call summary added to phone call activity")


### See also

[Get Channel Integration Framework](../customer-service/channel-integration-framework/get-channel-integration-framework.md)  
[Sample softphone integration using Channel Integration Framework](../customer-service/channel-integration-framework/sample-softphone-integration.md)  
[How to configure a channel provider for your Dynamics 365 organization](../customer-service/channel-integration-framework/configure-channel-provider-channel-integration-framework.md)