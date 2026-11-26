---
title: Uninstall omnichannel solutions
description: Learn how to uninstall omnichannel solutions in Dynamics 365 Customer Service.
ms.date: 09/30/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Uninstall omnichannel solutions

Uninstalling Dynamics 365 Contact Center from your organization doesn't remove the omnichannel solutions. To remove omnichannel solutions from your organization, uninstall them in the order listed in the table in the **Uninstall solutions** section.

## Prerequisite

Before you uninstall omnichannel solutions, [turn off channels](/dynamics365/contact-center/implement/provision-channels#turn-off-channels).

## Considerations

Some solutions are shared across apps. Don't remove shared solutions if apps you plan to keep require them.

For example, unified routing in Customer Service might depend on unified routing components in Dynamics 365 Contact Center solutions. Don't uninstall these shared solutions because removing them might affect unified routing in Customer Service.

Don't remove the following solutions, which are preinstalled in your Customer Service organization:

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

1. Sign in to your environment at `https://<org>.dynamics.com/apps`.

1. On the command bar, select **Settings** > **Advanced Settings**. The **Settings** page opens in a new browser tab.

1. Go to Dynamics 365 **Settings** > **Solutions**.

1. On the **Solutions** page, select the **Managed** tab.

1. On the **Managed** tab, select each solution in the order listed in the following table, and then select **Delete** to remove it. Remove one solution at a time.

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
    |	52	| `OmnichannelTelephony`	                |	Delete all related workstreams before you delete `OmnichannelTelephony`.	| 

1. When prompted to confirm that you want to uninstall the managed solution, select **OK**.

## Uninstall Omnichannel historical analytics solutions

1. Disable Omnichannel historical analytics in the **Insights** section of Copilot Service admin center. Learn more in [Configure Omnichannel historical analytics reports](/dynamics365/customer-service/oc-historical-analytics-reports).

1. On the **Solutions** page, uninstall the following solutions one at a time, in the order listed:
   1. `msdyn_InsightsAnalyticsOCConfiguration`
   1. `msdyn_DataInsightsAndAnalyticsForOC`

## Uninstall the OmnichannelCustomerServiceHub solution

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear on the **Solutions** page of Microsoft Dataverse. After the upgrade finishes, uninstall any solutions from the previous release that the upgrade doesn't remove. If your organization uses the **Customer Service Hub** app, you must remove it from the channel configuration in the **Channel Integration Framework** app.

1. Sign in to your `https://<org>.dynamics.com/apps` environment.

1. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed on a new browser tab.

1. Go to Dynamics 365 **Settings** > **Solutions**.

1. On the **Solutions** page, go to the **Managed** tab.

1. On the **Managed** tab, select the **OmnichannelCustomerServiceHub** solution, and then select **Delete**.

1. When prompted to confirm that you want to uninstall the managed solution, select **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete OmnichannelCustomerServiceHub solution.](../media/oceh-admin-delete-solution.png "Confirmation dialog for deleting the OmnichannelCustomerServiceHub solution")

You have deleted the **OmnichannelCustomerServiceHub** solution from your organization.

## Remove Customer Service Hub from channel provider configuration

Follow these steps to remove Customer Service Hub from the channel provider configuration.

1. Sign in to the Dynamics 365 environment.

1. Open the Dynamics 365 menu and select **Channel Integration Framework**.

1. Select the record associated with Omnichannel.

1. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.

1. Select **Save**.

## Related information

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Provision channels in the admin app](/dynamics365/contact-center/implement/provision-channels)  
[Deploy Unified Service Desk - Omnichannel for Customer Service package](../../unified-service-desk/oc-usd/omnichannel-customer-service-package.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
