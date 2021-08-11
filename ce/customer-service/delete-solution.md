---
title: "Delete Omnichannel solutions | MicrosoftDocs"
description: "Perform the steps mentioned in the topic to delete an Omnichannel solution from your organization"
ms.date: 08/11/2021
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Delete solutions

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Delete Omnichannel for Customer Service solutions

When you remove Omnichannel for Customer Service from your organization, the Omnichannel solutions are not deleted. If you want to delete Omnichannel solutions from your organization, you must use the following sequence. 

1. Sign in to your https://<org>.dynamics.com/apps environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

3. Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, select each solution from the list below, one at a time, in sequence, and then select **Delete**.

    1.  `ProductivityToolsAnchor`
    2.  `msdyn_OmnichannelProductivityToolsSettings`
    3.  `msdyn_Smartassist_managed`
    4.  `msdyn_ProductivityPaneControl_managed`
    5.  `msdyn_AgentGuidance_managed`
    6.  `msdyn_Agentscript_managed`
    7.  `msdyn_ProductivityMacros_managed`
    8.  `OmnichannelPrimeChatAnchor`
    9.  `OmnichannelPrimeSMSAnchor`
    10. `OmnichannelPrimeFacebookAnchor` 
    11. `OmnichannelPrimeTeams` 
    12. `OmnichannelPrimeSocialChannelsAnchor`
    13. `OmnichannelPrimeOutboundAnchor`
    14. `OmnichannelPrimeAnchor`
    1. `msdyn_CustomerServiceworkspaceChannels`
    1. `msdyn_OmnichannelEngagementHubPatch`
    1. `OmnichannelEngagementHubPreview`
    1. `msdyn_OmnichannelPrimePatch`
    1. `OmnichannelPrime`
    1. `msdyn_OmnichannelSMSPatch`
    1. `msdyn_OmnichannelChatPatch`
    1. `msdyn_OmnichannelFacebookPatch`
    1. `OmnichannelOutbound`
    1. `OmnichannelSMS`
    1. `OmnichannelTeams`
    1. `OmnichannelSocialChannels`
    1. `OmnichannelChat`
    1. `OmnichannelFacebook`
    1. `msdyn_OmnichannelBotEnablerPatch`
    1. `OmnichannelBotEnabler`
    1. `msdyn_UnifiedRoutingForCS`
    1. `UnifiedRoutingPrimeAnchor`
    1. `msdyn_OmnichannelSBRPatch_managed`
    1. `OmnichannelSBR`
    1. `OCBaseURBase`
    1. `msdyn_OmnichannelBasePatch`
    1. `OmnichannelBase`
    1. `MLDecisionEngine`
    1. `UnifiedRouting`
    1. `msdyn_UnifiedRoutingForEntity`
    1. `DecisionEngine`
    1. `msdynce_AnyEntityRoutingRulePatch202001_managed`
    1. `msdynce_AnyEntityRoutingRule`
    1. `ScenariosAndChannels`
    1. `msdyn_CIFrameworkPatch`
    1. `ChannelAPIIntegrationFramework`
    1. `OmnichannelIntelligence` 
    1. `OmnichannelConfiguration`
    1. `msdyn_MacrosDataOmnichannel`

5. A confirmation message appears that prompts you to uninstall the managed solution. Select **OK**.

After all the solutions are deleted, Omnichannel for Customer Service solutions are completely deleted from your organization.

## Delete OmnichannelCustomerServiceHub solution

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear on the **Solutions** page of your Microsoft Dataverse. After the upgrade is complete, you must delete the solution from the previous release if the upgrade does not delete it. In addition, if your organization is using **Customer Service Hub** app, then you must delete the app from the channel configuration in the **Channel Integration Framework** app.

The following steps describe how to delete the solution from your organization.

1. Sign in to your https://<org>.dynamics.com/apps environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed on a new browser tab.

3. Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, select the **OmnichannelCustomerServiceHub** solution, and then select **Delete**.

5. A confirmation message appears that prompts you to uninstall the managed solution. Select **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete Omnichannel Solution.](media/oceh-admin-delete-solution.png "Delete Omnichannel Solution")  

You have deleted the **OmnichannelCustomerServiceHub** solution from your organization.

## Remove Customer Service Hub from channel provider configuration

The following steps describe how to delete the solution from your organization.

1. Sign in to the Dynamics 365 instance.

2. Select the drop-down button on Dynamics 365 and select **Channel Integration Framework**.

3. Select the record that is related to Omnichannel.

4. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.

5. Select **Save** to save the record.

### See also

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Omnichannel for Customer Service on Unified Service Desk](../unified-service-desk/oc-usd/omnichannel-customer-service-unified-service-desk.md)  
[Deploy Unified Service Desk - Omnichannel for Customer Service package](../unified-service-desk/oc-usd/omnichannel-customer-service-package.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
