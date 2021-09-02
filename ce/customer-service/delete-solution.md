---
title: "Delete Omnichannel solutions | MicrosoftDocs"
description: "Perform the steps mentioned in the topic to delete an Omnichannel solution from your organization."
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

1. Sign in to your `https://<org>.dynamics.com/apps` environment.

2. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

3. Go to Dynamics 365 **Settings** > **Solutions**.

4. On the **Solutions** page, select each solution from the following list and then select **Delete** to delete them one at a time.

| Order |	Solution name	                                    | Note	|
|-------|---------------------------------------------------    |-------|
|	1	|	 `ProductivityToolsAnchor`	                        |		|
|	2	|	  `msdyn_OmnichannelProductivityToolsSettings`	    |		|
|	3	|	  `msdyn_Smartassist_managed`                    	|		|
|	4	|	  `msdyn_ProductivityPaneControl_managed`	        |		|
|	5	|	  `msdyn_AgentGuidance_managed`	                    |		|
|	6	|	  `msdyn_Agentscript_managed`	                    |		|
|	7	|	  `msdyn_ProductivityMacros_managed`               	|		|
|	8	|	  `OmnichannelPrimeChatAnchor`                    	|		|
|	9	|	  `OmnichannelPrimeSMSAnchor`	                    |		|
|	10	|	 `OmnichannelPrimeFacebookAnchor` 	                |		|
|	11	|	 `OmnichannelPrimeTeams` 	                        |		|
|	12	|	 `OmnichannelPrimeSocialChannelsAnchor`	            |		|
|	13	|	 `OmnichannelPrimeOutboundAnchor`	                |		|
|	14	|	 `OmnichannelPrimeAnchor`	                        |		|
|	15	|	 `msdyn_CustomerServiceworkspaceChannels`	        |		|
|	16	|	 `msdyn_OmnichannelEngagementHubPatch`	            |		|
|	17	|	 `OmnichannelEngagementHubPreview`	                |		|
|	18	|	 `msdyn_OmnichannelPrimePatch`	                    |		|
|	19	|	 `OmnichannelPrime`	                                |		|
|	20	|	 `msdyn_OmnichannelSMSPatch`	                    |		|
|	21	|	 `msdyn_OmnichannelChatPatch`	                    |		|
|	22	|	 `msdyn_OmnichannelFacebookPatch`	                |		|
|	23	|	 `OmnichannelOutbound`	                            |		|
|	24	|	 `OmnichannelSMS`	                                |		|
|	25	|	 `OmnichannelTeams`                                	|		|
|	26	|	 `OmnichannelSocialChannels`	                    |		|
|	27	|	 `OmnichannelChat`	                                |		|
|	28	|	 `OmnichannelFacebook`	                            |		|
|	29	|	 `msdyn_OmnichannelBotEnablerPatch`	                |		|
|	30	|	 `OmnichannelBotEnabler`	                        |		|
|	31	|	 `msdyn_UnifiedRoutingForCS`	                    |		|
|	32	|	 `UnifiedRoutingPrimeAnchor`	                    |		|
|	33	|	 `msdyn_OmnichannelSBRPatch_managed`	            |		|
|	34	|	 `OmnichannelSBR`                                	|		|
|	35	|	 `OCBaseURBase`	                                    |		|    
|	36	|	 `msdyn_OmnichannelBasePatch`	                    |		|
|	37	|	 `OmnichannelBase`	                                |		|
|	38	|	 `MLDecisionEngine`	                                |		|
|	39	|	 `UnifiedRouting`	                                |		|
|	40	|	 `msdyn_UnifiedRoutingForEntity`	                |		|
|	41	|	 `DecisionEngine`	                                |		|
|	42	|	 `msdynce_AnyEntityRoutingRulePatch202001_managed`	|		|
|	43	|	 `msdynce_AnyEntityRoutingRule`	                    |		|
|	44	|	 `ScenariosAndChannels`	                            |		|
|	45	|	 `msdyn_CIFrameworkPatch`	                        |		|
|	46	|	 `ChannelAPIIntegrationFramework`	                |		|
|	47	|	 `OmnichannelIntelligence` 	                        |		|
|	48	|	 `OmnichannelConfiguration`                        	|		|
|	49	|	 `msdyn_MacrosDataOmnichannel`	                    |		|
||||

5. A confirmation message appears that prompts you to uninstall the managed solution. Select **OK**.

> [!Important]
> When you plan to remove Omnichannel solutions from your organization, you must remember that the unified routing part of Omnichannel for Customer Service solutions might be used in unified routing for Customer Service. So you must ensure that you don't uninstall or delete the common solutions as it might affect the way unified routing works in Customer Service. You can find the common solutions in the internal TSG above.
> Add the extra steps to remove Unified Routing for Entity which are required - note is added to TSG.
> 
> After deleting the "UnifiedRouting" solution, delete the records in order from Advanced find for below entities else Dependency Details > would appear as shown below while removing next solution i.e. msdyn_UnifiedRoutingForEntity

> Entity = Master Entity Routing Configurations, Record Name = Case routing hub
> Entity = Decision Rule Sets, Record Name = Case decision ruleset
> Entity = Decision contracts, Record Name = Case decision contract

## Delete Omnichannel historical analytics solutions

Do the following to delete the solutions for Omnichannel historical analytics:

1. Disable Omnichannel historical analytics in the Insights section of Omnichannel admin center. More information: [Configure Omnichannel historical analytics reports](/oc-historical-analytics-reports.md)

1. On the **Solutions** page, select and delete the following solutions:
    1. `msdyn_InsightsAnalyticsOCConfiguration`
    1. `msdyn_DataInsightsAndAnalyticsForOC`

## Delete OmnichannelCustomerServiceHub solution

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear on the **Solutions** page of your Microsoft Dataverse. After the upgrade is complete, you must delete those solutions from the previous release if the upgrade does not delete it. In addition, if your organization is using the **Customer Service Hub** app, then you must delete the app from the channel configuration in the **Channel Integration Framework** app.

**To delete the OmnichannelCustomerServiceHub solution from your organization**

1. Sign in to your `https://<org>.dynamics.com/apps` environment.

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

2. Select the dropdown button on Dynamics 365 and select **Channel Integration Framework**.

3. Select the record that is related to Omnichannel.

4. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.

5. Select **Save** to save the record.

### See also

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Omnichannel for Customer Service on Unified Service Desk](../unified-service-desk/oc-usd/omnichannel-customer-service-unified-service-desk.md)  
[Deploy Unified Service Desk - Omnichannel for Customer Service package](../unified-service-desk/oc-usd/omnichannel-customer-service-package.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
