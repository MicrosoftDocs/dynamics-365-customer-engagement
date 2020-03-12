---
title: "Delete Omnichannel solutions | MicrosoftDocs"
description: "Learn how to delete an Omnichannel solution from an organization."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Delete solutions

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Delete Omnichannel for Customer Service solutions

When you remove Omnichannel for Customer Service from your organization, the Omnichannel solutions are not deleted. If you want to delete Omnichannel solutions from your organization, you must use the following sequence. 

1. Sign in to your https://<YourOrgURL>.dynamics.com/apps environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

3.	Go to Dynamics 365 **Settings** > **Solutions**.

2.	On the **Solutions** page, select each solution from the list below, one at a time, in sequence, and then select Delete.

    1. `OmnichannelPrimeChatAnchor`
    2. `OmnichannelPrimeSMSAnchor`
    3. `OmnichannelPrimeFacebookAnchor`
    4. `msdyn_OmnichannelSBRPatch_managed`
    5. `OmnichannelSBR`
    6. `msdyn_CIFrameworkPatch`
    7. `msdyn_OmnichannelEngagementHubPatch`
    8. `msdyn_OmnichannelBotEnablerPatch`
    9. `msdyn_OmnichannelPrimePatch`
    10. `msdyn_OmnichannelSMSPatch`
    11. `msdyn_OmnichannelChatPatch`
    12. `msdyn_OmnichannelFacebookPatch`
    13. `OmnichannelEngagementHubPreview`
    14. `msdyn_OmnichannelBasePatch`
    15. `OmnichannelPrime`
    16. `OmnichannelSMS`
    17. `OmnichannelChat`
    18. `OmnichannelFacebook`
    19. `OmnichannelBotEnabler`
    20. `OmnichannelBase`
    21. `ScenariosAndChannels`
    22. `ChannelAPIIntegrationFramework`
    
3.	A confirmation message appears, prompting you to uninstall the managed solution. Select **OK**.

Once all the above solutions are deleted, Omnichannel for Customer Service solutions are completely deleted from your organization.

## Delete OmnichannelCustomerServiceHub solution

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear in the **Solutions** page of your Common Data Service platform. After the upgrade is complete, you must delete the solution from the previous release if the upgrade does not delete. In addition, if your organization is using **Customer Service Hub** app, then you must delete the app from the channel configuration in the **Channel Integration Framework** app.

The following steps describe how to delete the solution from your organization.

1. Sign in to your https://<YourOrgURL>.dynamics.com/apps environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

3.	Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, select the **OmnichannelCustomerServiceHub** solution and then choose **Delete**. 

5. A confirmation message appears prompting you to uninstall the managed solution. Choose **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete Omnichannel Solution](../media/oceh-admin-delete-solution.png "Delete Omnichannel Solution")  

You have deleted the **OmnichannelCustomerServiceHub** solution from your organization.

## Remove Customer Service Hub from channel provider configuration

The steps describe how to delete the solution from your organization.

1. Sign in to the Common Data Service platform.

2. Select the drop-down button on Dynamics 365 and select **Channel Integration Framework**.
   
3. Select the record that is related to Omnichannel.
   
4. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.
   
5. Select **Save** to save the record.

## See also

- [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)
- [Omnichannel for Customer Service on Unified Service Desk](omnichannel-customer-service-unified-service-desk.md)
- [Deploy Unified Service Desk - Omnichannel for Customer Service package](omnichannel-customer-service-package.md)
