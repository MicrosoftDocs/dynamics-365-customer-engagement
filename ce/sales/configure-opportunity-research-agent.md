---
title: Configure  the Opportunity Research Agent
description: Learn how to set up and configure the Opportunity Research Agent in Dynamics 365 Sales.
ms.date: 07/09/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure the Opportunity Research Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can configure the Opportunity Research Agent in Dynamics 365 Sales to help sales professionals gain insights and recommendations for the opportunities they are working on. The agent automatically gathers information from various sources, providing a streamlined research experience, stakeholder and competitor intelligence, and actionable risk mitigation strategies. Learn more in [Opportunity Research Agent overview](opportunity-research-agent.md).

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]


## Step 1: Plan your implementation

As the agent consumes capacity, it is important to plan and configure it to handle the right opportunities. Here are some considerations to keep in mind before you set up the Opportunity Research Agent: 

- Determine the products that you want the Opportunity Research Agent to handle. The products should be handled by a single sales team. If your company sells multiple products through different sales teams, pick one product line.

- Determine the segment of opportunities that you want the Opportunity Research Agent to handle. For example, you might want it to handle only the opportunities that are **Hot** and of high value.
- Identify the sellers who will work on the segment of opportunities that the agent will research on. The agent uses the sellers' emails and meetings to gather insights and update sales records. Ensure that server-side synchronization is configured for their mailboxes. Follow these steps to configure server-side synchronization:
  - [Create an email server profile for Exchange Online](/power-platform/admin/connect-exchange-online?tabs=new#create-an-email-server-profile-for-exchange-online).
  - [Configure default email processing and synchronization](/power-platform/admin/connect-exchange-online?tabs=new#configure-default-email-processing-and-synchronization).
  - [Configure mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#configure-mailboxes) of sellers who own the opportunities and [approve the mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#approve-mailboxes). When the configuration is successful, the **Incoming Email Status** and **Outgoing Email Status** for the mailbox are set to **Success**.
    :::image type="content" source="mailbox-status.png" alt-text="Screenshot of a user mailbox in Dynamics 365 Sales with status indicators.":::

    > [!IMPORTANT]
    >- Make sure that the personalization option for emails is set to **All email messages** in the sellers' personalization settings. By default, this option is set to **Email messages in response to Dynamics 365 email**. Sellers can change this setting from the **Settings** > **Personalization settings** > **Emails**  > **Track** in Dynamics 365 Sales.  
    >- :::image type="content" source="media/email-track-personal-options.png" alt-text="Screenshot of the Personalization settings page in Dynamics 365 Sales with the All email messages option selected.":::
    >- You can either notify the sellers to set this option or use the **User Settings Utility** in [XRMToolBox](/power-apps/developer/data-platform/community-tools) to select multiple sellers and set the `Track email messages` setting to **All email messages**.

- The agent uses the machine learning model in predictive opportunity scoring for risk assessment. If you haven't configured scoring in your environment, it's configured automatically when you start the agent.
- Modify Data Loss Prevention (DLP) policies to allow external connections. Learn more in [Configure data loss prevention policies for agents](/microsoft-copilot-studio/admin-data-loss-prevention).

- If you're using a custom security role for your sales team that'll be using the agent, ensure that the role has Organization-level `Read` access to the following entities to view the research insights:
  - Opportunity Research Result (msdyn_OpportunityResearchResult)
  - Opportunity Research Indicator (msdyn_OpportunityResearchIndicator)


## Step 2: Verify prerequisites

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Go to **General Settings** > **Dynamics 365 AI hub**.
1. Select **Create and manage agents** under **Agent manager**.
1. On the **AI agents** page, select **Prerequisites** and ensure that all prerequisites are met. 
   :::image type="content" source="media/opportunity-research-agent-prerequisites.png" alt-text="Screenshot of the Prerequisites page for Opportunity Research Agent."::: 
1. If any of them is not marked as **Done**, select the appropriate call-to-action to complete the prerequisite:
   - **Microsoft Copilot Studio capacity**: Select **Set up** to open the Power Platform admin center and set up capacity. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).
   - **Bing search**: Select **Accept terms** to open the Power Platform admin center and allow Bing search under **Generative AI features** > **Bing search**.
   - **Move data across regions**: Select **Accept terms** to open the Power Platform admin center and allow data movement under **Generative AI features** > **Move data across regions**.

1. After all the prerequisites are met, select **Create** and then select **Choose** under **Opportunity Research Agent**.
  The Opportunity Research Agent settings page opens.
  :::image type="content" source="media/opportunity-research-agent-settings.png" alt-text="Screenshot of the Opportunity Research Agent settings page.":::

1. On the **Automation level** section, select **Research**.
1. Scroll down to the **Prerequisites** section and confirm that server-side synchronization is configured for the mailboxes of sellers who will use the agent. The agent can't verify this automatically. So, select **Mark as done** only if it is configured as described in the [Plan your implementation](#step-1-plan-your-implementation) section.

1. On the **Prerequisites** tab, confirm whether server-side synchronization is configured for sellers who will use the agent. The agent can't verify this automatically. So, select **Mark as done** only if it is configured.

## Step 3: Configure the agent

After verifying the prerequisites, define the agent and company profile, selection criteria for opportunities, refresh frequency, fields for importance and risk assessment, and knowledge sources for generating research insights.

### Configure agent and company profile

1. In the **Agent profile** tab, enter a meaningful name for the agent, such as "Opportunity Research Agent for Microsoft 365". This name is used to identify the agent in Dynamics 365 Sales and Copilot Studio.

1. In the **Company info** tab, enter the following information:
    1. Enter your company name and website URL. 
    1. Enter the value proposition of the products associated with the opportunities that the agent will handle. For example, "Microsoft 365 is a cloud-based productivity suite that includes Office applications, email, and collaboration tools."
    The agent uses the company information to gather insights about the company and its products.


### Configure selection criteria for opportunities

1. In the **Selection criteria** tab, specify the following information:
   - **Segment name:** Enter a name for the segment that the agent will handle, such as "Microsoft 365 Opportunities". The agent doesn't use the segmentation feature in Dynamics 365 Sales. The segment name is only used to identify the opportunities that the agent will handle.

   - **Description:** Enter a description for the segment, such as "Opportunities related to Microsoft 365 products".
   - **Filter conditions:** Define the filter conditions for the segment. Opportunities that match these conditions will be handled by the agent. For example, to handle only the opportunities that are **Hot** and of high value, you can specify the following conditions:
     - Rating equals **Hot**.
     - Est. revenue greater than or equal to $100,000.
     - Status equals **Open**.

1. After starting the agent for the first time, the agent filters opportunities created in the last 30 days by default and then applies the filter conditions that you specified. To select a smaller duration, select the check box **Consider opportunities created in the last** and specify the number of days.
1. Select **Simulate** to view a limited set of opportunities that match the filter conditions. This helps you verify that the agent is picking the right opportunities.
  :::image type="content" source="media/opportunity-research-agent-selection-criteria.png" alt-text="Screenshot of the Selection criteria tab for Opportunity Research Agent.":::



### Configure refresh frequency

 the **Refresh frequency** tab, specify how frequently you want the agent to refresh the research data for the opportunities. The frequency is set to **Medium** by default, which is ideal for most businesses. You can refresh the research data more or less often based on how quickly your market and competitive landscape change and the available Copilot Studio capacity.

- **High:** Data is refreshed every day. This option is ideal for businesses that always need the latest information, but it consumes more capacity.
- **Medium:** Data is refreshed every three days. This option is suitable for businesses that need regular updates but don't require daily insights. It balances performance and data accuracy.
- **Low:** Data is refreshed every seven days. This option consumes the least capacity and is suitable for businesses that don't need frequent updates and want to save capacity.


### Configure fields for importance and risk assessment

In the **Opportunity assessment** tab, specify the fields that the agent will use to assess the importance and risk of the opportunities. 

- **Monetary value:** Select the field that represents the monetary value of the opportunity, such as **Est. revenue**. This field determines the importance of the opportunity.
- **Estimated close date**: Select the field that represents the estimated close date of the opportunity, such as **Est. close date**. This field helps the agent assess the urgency of the opportunity and identify potential risks.

### Configure knowledge for generating research insights

1. In the **Research insights** tab, specify the knowledge sources that the agent must use to generate research insights for the opportunities. 
   > [!NOTE]
   > The Sales Qualification Agent and Opportunity Research Agent share the same knowledge sources for account insights. The knowledge sources that you add to or remove from one of the agents will be reflected in the other agent as well. If you see knowledge sources already, it's possible that those are configured for the Sales Qualification Agent. Do not remove them unless you want to remove them from both agents.

1. Under **Company insights**, select **Manage** to add reliable knowledge sources that you want the agent to use to gather insights about the account associated with the opportunity.
   The D365 Sales Agent - Research agent's **Knowledge** page opens in Copilot Studio.
1. Under **Competitors**, select **Manage** to add the competitors that you want the agent to consider while generating insights. The agent uses this information to provide competitive intelligence and help sellers understand the competitive landscape. By default, the agent collects insights from public web sources. However, you can also add knowledge sources that are specific to your organization, such as battle cards and positioning documents.
1. Select **Manage** to add or remove knowledge sources for competitor insights. 
   The **D365 Sales Agent - Competitors** agent's **Knowledge** page opens in Copilot Studio. 
   Learn more about creating knowledge sources in [Knowledge sources overview](/microsoft-copilot-studio/knowledge-copilot-studio).
> [!NOTE]
> If you have multiple documents, be sure to group the documents after uploading them to the knowledge source. Learn more in Copilot Studio documentation.

## Step 4: Start or stop the agent

Start the agent only after you have configured all the settings and verified that they are correct. The agent will begin processing the opportunities that match the selection criteria right after you start it.

Select **Start agent** on the **Opportunity Research Agent** settings page.
The agent is started and its status is set to **On** on the **AI agents** page. The agent starts processing the opportunities that match the selection criteria and generates research insights based on the configured knowledge sources. This process might take some time, depending on the number of opportunities and the complexity of the knowledge sources.
