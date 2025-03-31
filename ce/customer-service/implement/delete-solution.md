---
title: Uninstall solutions in Omnichannel for Customer Service
description: Perform the steps mentioned in this article to remove solutions in Omnichannel for Customer Service.
ms.date: 03/17/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Uninstall solutions in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

When you uninstall Omnichannel for Customer Service from your organization, the omnichannel solutions are not removed. If you want to remove omnichannel solutions from your organization, you must use the same order as mentioned in the following table.

## Prerequisite

You must have removed [Omnichannel for Customer Service](/dynamics365/contact-center/implement/provision-channels#turn-off-channels).

> [!IMPORTANT]
> Some solutions are shared across apps, and you shouldn't remove them unless you intend to uninstall those apps too; skip those solutions if they are required.
>
> For example, if you plan to remove omnichannel solutions from your organization, you must remember that the unified routing part of Omnichannel for Customer Service solutions might be used in unified routing for Customer Service. Therefore, you must ensure that you don't uninstall or delete the common solutions because it might affect the way unified routing works in Customer Service.

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
    |	3	| `msdyn_Smartassist_managed`                    	| Required for Customer Service Hub and Customer Service workspace |
    |	4	| `msdyn_ProductivityPaneControl_managed`	        |		|
    |	5	| `msdyn_AgentGuidance_managed`	                    |		|
    |	6	| `msdyn_Agentscript_managed`	                    | Required for Customer Service Hub and Customer Service workspace |
    |	7	| `OmnichannelPrimeChatAnchor`                    	|		|
    |	8	| `OmnichannelPrimeSMSAnchor`	                    |		|
    |	9	| `OmnichannelPrimeFacebookAnchor` 	                |		|
    |	10	| `OmnichannelPrimeTeams` 	                        |		|
    |	11	| `OmnichannelPrimeSocialChannelsAnchor`	        |		|
    |	12	| `OmnichannelPrimeOutboundAnchor`	                |		|
    |   13  |  `OmnichannelPrimeTelephony`                      |       |
    |	14	|	 `msdyn_CustomerServiceworkspaceChannels`       |		|
    |	15	|	 `msdyn_OmnichannelEngagementHubPatch`	        |		|
    |	16	|	 `OmnichannelEngagementHubPreview`	            |		|
    |	17	|	 `msdyn_OmnichannelPrimePatch`	                |		|
    |	18	|	 `msdyn_OmnichannelSMSPatch`	                |		|
    |	19	|	 `msdyn_OmnichannelFacebookPatch`	            |		|
    |	20	|	 `OmnichannelOutbound`	                        |		|
    |	21	|	 `OmnichannelSMS`	                            |		|
    |	22	|	 `OmnichannelTeams`                            	|		|
    |	23	|	 `OmnichannelSocialChannels`                    |		|
    |	24	|	 `OmnichannelChat`	                            |		|
    |	25	|	 `OmnichannelFacebook`	                        |		|
    |	26	|	 `msdyn_OmnichannelBotEnablerPatch`	            |		|
    |	37  |   `OmnichannelTelephony`                          | You must delete all the related workstreams before you delete OmnichannelTelephony |
    |	28	|	 `ScenariosAndChannels`	                        |		|
    |	30	|	 `OmnichannelIntelligence` 	                    |		|
    |	31	|	 `OmnichannelConfiguration`                    	|		|

6. Select **OK** on the confirmation message that prompts you to uninstall the managed solution.

## Uninstall Omnichannel historical analytics solutions

1. Disable Omnichannel historical analytics in the Insights section of Customer Service admin center. Learn more in [Configure Omnichannel historical analytics reports](/dynamics365/customer-service/oc-historical-analytics-reports).

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
[Omnichannel for Customer Service on Unified Service Desk](../../unified-service-desk/oc-usd/omnichannel-customer-service-unified-service-desk.md)  
[Deploy Unified Service Desk - Omnichannel for Customer Service package](../../unified-service-desk/oc-usd/omnichannel-customer-service-package.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
