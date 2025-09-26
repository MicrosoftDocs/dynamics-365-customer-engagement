---
title: Uninstall omnichannel solutions
description: Perform the steps mentioned in this article to remove omnichannel solutions in Customer Service.
ms.date: 09/26/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Uninstall omnichannel solutions

When you uninstall Omnichannel for Customer Service from your organization, the omnichannel solutions are not removed. If you want to remove omnichannel solutions from your organization, you must use the same order as mentioned in the following table.

## Prerequisite

You must have removed [Omnichannel for Customer Service](/dynamics365/contact-center/implement/provision-channels#turn-off-channels).

## Considerations

Some solutions are shared across apps, and you shouldn't remove them unless you intend to uninstall those apps too; skip those solutions if they are required.
For example, if you plan to remove omnichannel solutions from your organization, you must remember that the unified routing part of Omnichannel for Customer Service solutions might be used in unified routing for Customer Service. Therefore, you must make sure that you don't uninstall or delete the common solutions because it might affect the way unified routing works in Customer Service.

You must not remove the following out-of-the-box solutions that come preinstalled in your Customer Service organization.
- msdyn_UnifiedRoutingForEntity
- UnifiedRouting
- MLDecisionEngine
- msdyn_OmnichannelSharedBase
- msdyn_OmnichannelBase
- msdyn_OmnichannelBaseApp
- msdyn_D365CTQMIProd
- msdyn_D365CTQMITest
- msdyn_D365CTQMIGCC
- OCBaseURBase
- AgentAvailabilityStatus
- AgentGroupManager
- AssignmentSQLCacheSyncPluginManager
- msdyn_OmnichannelSBR
- msdyn_OmnichannelSBRPatch
- OCISBR
- OCIER
- OCSR
- OOBLanguageAndRegion
- msdyn_CCASentimentRoutingAI
- msdyn_ConversationInsight
- msdyn_ProductivityMacrosApplicationOC
- msdyn_ContactCenterManagementPermissions__Public
- msdyn_OmnichannelBotEnabler
- msdyn_OmnichannelBotExtension
- msdyn_OmnichannelConversationExtension
- msdyn_OmnichannelPrime
- msdyn_OmnichannelComponentDeprecation
- msdyn_OmnichannelPrimeAnchor
- msdyn_OmnichannelAutomatedMessages
- msdyn_OmnichannelChatConfiguration
- msdyn_OmnichannelSpamConfig
- msdyn_OmnichannelRichmessages
- msdyn_OmnichannelPaymentConfig
- msdyn_OmnichannelAuthenticationConfig
- msdyn_OmnichannelBotChannelConfiguration
- msdyn_OmnichannelMessaging
- msdyn_ContactCenterEnablementPermissions__Public
- msdyn_ContactCenterEnablement

## Uninstall solutions

1. Sign in to your `https://<org>.dynamics.com/apps` environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

3. Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, go to the **Managed** tab.

5. In the **Managed** tab, select each solution from the following list, and then select **Delete** to remove them one at a time.

    | Order |	Solution name	                                | Note	|
    |-------|-------------------------------------------------- |-------|
    |	1	| `ProductivityToolsAnchor`	                        |		|
    |	2	| `msdyn_OmnichannelProductivityToolsSettings`	    |		|
    |	3	| `Omsdyn_Smartassist_managed`                    	|Required for Customer Service Hub and Copilot Service workspace|
    |	4	| `msdyn_ProductivityPaneControl_managed`	        |		|
    |	5	| `msdyn_AgentGuidance_managed`	                    |		|
    |	6	| `msdyn_Agentscript_managed`	                    | Required for Customer Service Hub and Copilot Service workspace |
    |	7	| `OmnichannelPrimeChatAnchor`	                        |		|
    |	8	| `OmnichannelPrimeSMSAnchor`	    |		|
    |	9	| `OmnichannelPrimeFacebookAnchor`                    	|  |
    |	10	| `OmnichannelPrimeTeams`	        |		|
    |	11	| `OmnichannelPrimeSocialChannelsAnchor`	                    |		|
    |	12	| `OmnichannelPrimeOutboundAnchor`	                    |  |
    |	13	| `OmnichannelPrimeTelephony`                    	|		|
    |	14	| `msdyn_CustomerServiceworkspaceChannels`	                    |		|
    |	15	| `msdyn_OmnichannelFacebookPatch` 	                |		|
    |	16	| `OmnichannelOutbound` 	                        |		|
    |	17	| `msdyn_OmnichannelTeamsPatch`	        |		|
    |	18	| `OmnichannelTeams`	                |		|
    |   19  | `msdyn_OmnichannelSocialChannelsPatch`                      |       |
    |	20	|	 `OmnichannelSocialChannels`       |		|
    |	21	|	 `OmnichannelChat`	        |		|
    |	22	|	 `OmnichannelFacebook`	            |		|
    |	23	|	 `OmnichannelConfiguration`	                |		|
    |	24	|	 `msdyn_OmnichannelSharedCommunicationBase`	                |		|
    |	25	|	 `msdyn_OmnichannelSharedSMS`	            |		|
    |	26	|	 `msdyn_OmnichannelEngagementHubDeprecation`	                        |		|
    |	27	|	 `msdyn_OmnichannelMessagingBase`	                            |		|
    |	28	|	 `msdyn_OmnichannelBaseApp`                            	|		|
    |	29	|	 `msdyn_OmnichannelPrimeProactiveAIAnchor`                    |		|
    |	30	|	 `msdyn_OmnichannelCCaaSPESApi`	                            |		|
    |	31	|	 `Omsdyn_OmnichannelPESPermissions__Test`	                        |		|
    |	32	|	 `msdyn_OmnichannelProactiveEngagement`	            |		|
    |	33  |   `msdyn_OmnichannelCCaaSVoiceAPI`                          |  |
    |	34	|	 `msdyn_OmnichannelSporch__Test`	                        |		|
    |	35	|	 `msdyn_OmnichannelVoiceRuntime__Test` 	                    |		|
    |	36	|	 `msdyn_AdaptationManagementPermissions__Test`                    	|		|
    |	37	| `msdyn_AdaptationManagementPrimeAnchor`	                        |		|
    |	38	| `msdyn_OmnichannelEngagementHubPatch`	    |		|
    |	39	| `msdyn_MarchPermissions__Test`                    	|  |
    |	40	| `msdyn_AdaptationManagement`	        |		|
    |	41	| `msdyn_OmnichannelSMSPatch`	                    |		|
    |	42	| `OmnichannelSMS`	                    |  |
    |	43	| `Omsdyn_OmnichannelMessagingApplicationUsers__Test`                    	|		|
    |	44	| `OmnichannelEngagementHubPreview`	                    |		|
    |	45	| `msdyn_CCASentimentAI` 	                |		|
    |	46	| `msdyn_ConversationSummarizationAIRealtime` 	                        |		|
    |	47	| `msdyn_UnifiedRoutingForCS`	        |		|
    |	48	| `ScenariosAndChannels`	                |		|
    |	49	| `msdyn_InboxForOC` 	                        |		|
    |	50	| `msdyn_ChannelExperienceAppConfigurations`	        |		|
    |	51	| `OmnichannelCommunicationBase`	                |		|
    |	52	| `OmnichannelTelephony`	                |	You must delete all the related workstreams before you delete OmnichannelTelephony	| 
6. Select **OK** on the confirmation message that prompts you to uninstall the managed solution.

## Uninstall Omnichannel historical analytics solutions

1. Disable Omnichannel historical analytics in the Insights section of Copilot Service admin center. Learn more in [Configure Omnichannel historical analytics reports](/dynamics365/customer-service/oc-historical-analytics-reports).

2. On the **Solutions** page, select and uninstall the following solutions, one at a time, in the following order:
   1. `msdyn_InsightsAnalyticsOCConfiguration`
   2. `msdyn_DataInsightsAndAnalyticsForOC`

## Uninstall OmnichannelCustomerServiceHub solution

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear on the **Solutions** page of Microsoft Dataverse. After the upgrade is complete, you must uninstall those solutions from the previous release if the upgrade does not remove them. Also, if your organization is using the **Customer Service Hub** app, then you must uninstall the app from the channel configuration in the **Channel Integration Framework** app.

1. Sign in to your `https://<org>.dynamics.com/apps` environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed on a new browser tab.

3. Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, go to the **Managed** tab.

5. In the **Managed** tab, select the **OmnichannelCustomerServiceHub** solution, and then select **Delete**.

6. A confirmation message appears that prompts you to uninstall the managed solution. Select **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete Omnichannel Solution.](../media/oceh-admin-delete-solution.png "Delete Omnichannel Solution")

You have deleted the **OmnichannelCustomerServiceHub** solution from your organization.

## Remove Customer Service Hub from channel provider configuration

Do the following steps to remove the Customer Service Hub solution from your organization.

1. Sign in to the Dynamics 365 instance.

2. Select the dropdown button on Dynamics 365 and select **Channel Integration Framework**.

3. Select the record that is related to Omnichannel.

4. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.

5. Select **Save** to save the record.

### Related information

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Provision channels in the admin app](/dynamics365/contact-center/implement/provision-channels)  
[Deploy Unified Service Desk - Omnichannel for Customer Service package](../../unified-service-desk/oc-usd/omnichannel-customer-service-package.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
