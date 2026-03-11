---
title: Configure the Sales Close Agent - Research (preview)
description: Learn how to set up and configure the Sales Close Agent - Research in Dynamics 365 Sales.
ms.date: 03/09/2026
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Setup and configure the Sales Close Agent - Research (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can configure the Sales Close Agent - Research in Dynamics 365 Sales to help sales professionals gain insights and recommendations for the opportunities they're working on. The agent automatically gathers information from various sources, providing a streamlined research experience, stakeholder and competitor intelligence, and actionable risk mitigation strategies. Learn more in [Sales Close Agent](sales-close-agent.md).

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Plan your implementation

Before you set up the agent, consider the following:

- **Pick one product line.** The products should be handled by a single sales team. If your company sells multiple products through different sales teams, start with one product line.
- **Define an opportunity segment.** Determine the segment of opportunities for the agent to handle. For example, only opportunities that are **Hot** with an estimated revenue of $100,000 or more.
- **Predictive scoring dependency.** The agent uses the machine learning model in predictive opportunity scoring for risk assessment. If you didn't configure scoring in your environment, it's configured automatically when you start the agent.

## Prerequisites

Ensure that you meet the following prerequisites before configuring the agent.

- Complete the [common prerequisites applicable to all sales agents](prerequisites-for-all-agents.md).
- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).  
- Configure [Bing search and Microsoft 365 services](configure-requirements-for-sales-close-agent-research.md) before you set up the agent.  
- Allow the following connectors in your organization's data policies for the agent to use various knowledge sources. 

    | Connector | Why is it required? |
    |-----------|---------------------|
    | Knowledge source with public websites and data | Access public data for enrichment. |
    | Microsoft Copilot Studio | Core platform for building and deploying the agent. |
    | Knowledge source with SharePoint or OneDrive | Required only if the agent uses internal documents on SharePoint or OneDrive. |
    | Knowledge source with documents | Required only if the agent uses internal documents. |
    | Direct Line channels in Copilot Studio | Required for the agent to connect to Microsoft Copilot Studio. |

    Learn more in [Manage data policies](/power-platform/admin/prevent-data-loss?tabs=new).

## Grant permissions to sellers <a name="grant-permissions"></a>

By default, the **Salesperson** and **Sales Manager** security roles have the necessary permissions. If you're using a custom security role, ensure sellers have the following minimum permissions:

| Purpose | Access level - Permissions | Entities |
|---------|----------------------------|----------|
| Consent to use Microsoft 365 emails for opportunity research | Basic-level - Read | prvReadconnector |

## Setup the Sales Close Agent - Research

Before you start, ensure you have [planned your implementation](#plan-your-implementation) and met [all prerequisites](#prerequisites). Use the following steps to configure the Sales Close Agent - Research:

1. [Open the Sales Close Agent - Research settings page](open-sales-close-agent-research-settings.md).
1. [Configure the agent profile](configure-sales-close-agent-research-profile.md) for agent such as name and language.
1. [Configure company info](configure-sales-close-agent-research-company-info.md) for agent to understand value proposition and curate research insights.
1. [Configure refresh frequency](configure-sales-close-agent-research-refresh-frequency.md) to specify how often the agent refreshes research data.
1. [Set selection criteria for opportunities](configure-sales-close-agent-research-selection-criteria.md) to define which opportunities the agent should research.
1. [Configure importance and risk assessment](configure-sales-close-agent-research-opportunity-assessment.md) to select the fields the agent uses to assess opportunity importance and risk.
1. [Configure knowledge sources](configure-sales-close-agent-research-knowledge-sources.md) to add public and internal knowledge sources for the agent to generate insights.
1. [Configure advanced settings (optional)](configure-sales-close-agent-research-advanced-settings.md) to customize risk and importance criteria.
1. [Start the agent](start-sales-close-agent-research.md) to begin researching opportunities and generating insights.









<a name="configure-server-side-synchronization"></a>
### (Optional) Configure server-side synchronization

Configure server-side synchronization if you want the agent to access only the emails and meetings synced to Dynamics 365 Sales. Alternatively, you can enable Microsoft 365 Services for the agent to read emails directly from sellers' Microsoft 365 mailboxes (configured in [Step 3](#step-3-create-the-agent-and-verify-readiness)).

If both are enabled, the agent reads emails from both sources.

1. [Create an email server profile for Exchange Online](/power-platform/admin/connect-exchange-online?tabs=new#create-an-email-server-profile-for-exchange-online).
1. [Configure default email processing and synchronization](/power-platform/admin/connect-exchange-online?tabs=new#configure-default-email-processing-and-synchronization).
1. [Configure mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#configure-mailboxes) of sellers who own the opportunities and [approve their mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#approve-mailboxes). When the configuration is successful, the **Incoming Email Status** and **Outgoing Email Status** for the mailbox are set to **Success**.
    :::image type="content" source="mailbox-status.png" alt-text="Screenshot of a user mailbox in Dynamics 365 Sales with status indicators.":::
1. Make sure that the personalization option for email tracking is set to an appropriate value. Perform *ONE* of the following actions:
    - Notify the sellers to set the tracking option in the Sales Hub app from **Settings** > **Personalization settings** > **Emails** > **Track**.
      :::image type="content" source="media/email-track-personal-options.png" alt-text="Screenshot of the Personalization settings page in Dynamics 365 Sales with the All email messages option selected.":::
    - Use the **User Settings Utility** in [XRMToolBox](/power-apps/developer/data-platform/community-tools) to select multiple sellers and set the `Track email messages` setting to an appropriate tracking option.
      :::image type="content" source="media/xrmtoolbox-email-tracking.png" alt-text="Screenshot of the User Settings Utility in XRMToolBox with the Track email messages option set to All email messages.":::

<a name="verify-prerequisites"></a>
## Step 3: Create the agent and verify readiness

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.
1. Go to **General Settings** > **Dynamics 365 AI hub**. If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. Learn more in [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md).
1. Select **Create and manage agents** under **Agent manager**.
1. On the **AI agents** page, select **Create** and then in the **Create an AI agent** dialog, select **Sales Close Agent**.
1. In the **Scenario** section, select **Research** and then scroll down to the **Prerequisites** section. Ensure that all the prerequisites are met. If any prerequisite isn't marked as **Done**, select the appropriate call-to-action:
   - **Bing search**: Select **Accept terms** to open the Power Platform admin center and accept the terms for Bing search.
   - **Microsoft 365 Services**: (Optional) To allow the agent to read emails directly from the sellers' Microsoft 365 mailboxes, select **Mark as done** and then select **Apply changes**. Sellers are also prompted to provide consent when they first access the Opportunity research page. If you want to [use server-side synchronization](#configure-server-side-synchronization) for reading emails, don't select the checkbox.

     To configure and use Microsoft 365 Services, you need:
     - At least *ONE* of the following roles: Global administrator, Dynamics 365 administrator, or tenant administrator.
     - At least *ONE* of the following licenses: Microsoft 365/Office 365, Power Automate Premium, or Dynamics 365 Sales Enterprise Edition.

     > [!NOTE]
     > The agent reads emails of the opportunity owner to generate insights. However, the insights are visible to all users who can access the opportunity.

1. Select **Continue** to proceed to the agent configuration page.

   :::image type="content" source="media/opportunity-research-agent-settings.png" alt-text="Screenshot of the Sales Close Agent - Research settings page.":::

## Step 4: Define the agent and company profile

1. In the **Agent profile** tab, specify the following details:
   1. Enter a meaningful name for the agent, such as *Opportunity Research*. This name identifies the agent in Dynamics 365 Sales and Copilot Studio.
   1. Select the agent's language. The agent uses this language to generate research insights. [What happens when the agent's language is different from user's preferred language?](opportunity-research-agent-faqs.md#agent-language-difference)

1. In the **Company info** tab:
   1. Enter your company name and website URL.
   1. Enter the value proposition of the products associated with the opportunities the agent handles.

      A clear value proposition helps the agent focus its account research on the most relevant information. For example, instead of "We sell coffee machines to businesses," specify "Our smart vending machine offers a variety of premium blends, customizable to your taste, with zero wait time, and minimal maintenance."

## Step 5: Set selection criteria for opportunities

1. In the **Selection criteria** tab, specify the following information:
   - **Segment name:** Enter a name for the segment, such as *Microsoft 365 Opportunities*. The segment name is only used to identify the opportunities the agent handles (it doesn't use the segmentation feature in Dynamics 365 Sales).
   - **Description:** Enter a description, such as *Opportunities related to Microsoft 365 products*.
   - **Filter conditions:** Define the filter conditions. Opportunities that are **open** and match these conditions are handled by the agent. For example:
     - Rating equals **Hot**
     - Est. revenue greater than or equal to $100,000
     - Status equals **Open**

1. To have the agent research opportunities created in the past, select the **Consider opportunities created in the last** checkbox and specify a look-back period in days. Otherwise, the agent only considers opportunities created after it's turned on.

1. Select **Preview** to view a sample of matching opportunities and verify that the agent is picking the right ones.

   > [!NOTE]
   > If you haven't specified a look-back period, the preview is empty because the agent only considers opportunities created after it's turned on.

   :::image type="content" source="media/opportunity-research-agent-selection-criteria.png" alt-text="Screenshot of the Selection criteria tab for Sales Close Agent - Research.":::

## Step 6: Set refresh frequency

In the **Refresh frequency** tab, specify how often the agent refreshes research data. The default is **Medium**.

| Frequency | Refresh interval | Best for |
|-----------|-----------------|----------|
| **High** | Every day | Businesses that always need the latest information. Consumes more capacity. |
| **Medium** | Every three days | Most businesses that need regular updates without daily overhead. |
| **Low** | Every seven days | Businesses that don't need frequent updates and want to conserve capacity. |

## Step 7: Configure importance and risk assessment

In the **Opportunity assessment** tab, select the fields the agent uses to assess importance and risk. In addition to these fields, the agent uses signals such as customer interactions and stakeholder engagement. You can customize the thresholds in the **Advanced** section. Learn more in [Configure risk and importance criteria](opportunity-research-agent-advanced-settings.md).

- **Monetary value:** Select the field that represents the monetary value, such as **Est. revenue**.
- **Estimated close date:** Select the field that represents the estimated close date, such as **Est. close date**.

## Step 8: Configure knowledge sources

By default, the agent generates insights from public web sources. Add more knowledge sources for richer, more relevant insights.

> [!IMPORTANT]
> Ensure that the knowledge sources you want the agent to use are in a SharePoint folder. Other file sources such as OneDrive aren't supported.

### Account insights

1. In the **Research insights** section, go to **Company insights** > **Knowledge sources for insight**.

   > [!NOTE]
   > If the Sales Qualification Agent and Sales Close Agent - Research are in the same environment, they share the same knowledge sources for account insights. Changes to one agent's knowledge sources are reflected in the other.

1. Select **Add** or **Manage** to open the **D365 Sales Agent - Research agent** knowledge page in Copilot Studio.
1. Add knowledge sources you refer to while researching accounts, such as specific websites, internal documents, or knowledge bases.

   When you upload files from SharePoint in Copilot Studio, select the **SharePoint** option in the **Featured** section. Don't use the **SharePoint** option under the **Upload file** section, as this blocks the agent from processing leads.

   :::image type="content" source="media/sales-qualification-agent-knowledge-source-sharepoint.png" alt-text="Screenshot showing the correct SharePoint option to select in Copilot Studio":::

1. Test the agent's output:
   1. Scroll up to the **How this works** section and copy the test snippet under Step 2.
   1. Open Copilot Studio and paste the JSON snippet in the **Test your agent** chat window.
   1. Modify the `companyName` and `accountDomain` values to one of your accounts and select **Send**.
   1. Review the response to ensure the agent uses the knowledge sources you added.

1. In Copilot Studio, select **Publish** to publish the changes.

### Competitor insights

Add internal knowledge sources such as battle cards, positioning briefs, and product comparisons to help sellers understand the competitive landscape.

> [!NOTE]
> You can only upload slide decks or documents as knowledge sources for competitor insights.

1. In the **Research insights** section, go to **Competitor insights**.
1. Under **Key competitors**, select **+ Competitor** to add competitors for the product line. The agent first looks for competitors in the opportunity and customer conversations and then uses the competitors you specify here.
1. Select **Add** or **Manage** to open the **D365 Sales Agent - Competitors** agent's knowledge page in Copilot Studio.
1. Select **Add knowledge** > **Upload file** and select the documents.
1. To group related documents (for example, all documents about one competitor), select **Upload** > **Upload as a group**.

   :::image type="content" source="media/group-upload-copilot-studio.png" alt-text="Screenshot of the Group upload option in Copilot Studio.":::

   You can also group individual documents after uploading by selecting a document and choosing **Create file group**.

### Best practices for knowledge sources

- **Keep descriptions specific.** "Dataverse table with Assets Under Management by client" is more helpful than "Finance table."
- **Limit public sites.** Too many broad domains dilute relevance; add only the sites that best match your industry.
- **Review security.** The agent only presents data that the signed-in seller is permitted to access.
- **Monitor capacity.** Large files and frequent refreshes consume AI credits. Track usage in Power Platform admin center.

### Configure advanced settings (optional)

Under the **Advanced** section, you can configure risk and importance criteria for the opportunities. Learn more in [Configure risk and importance criteria](opportunity-research-agent-advanced-settings.md).

## Step 9: Start the agent

Start the agent only after you configure and verify all settings. The agent begins processing matching opportunities immediately.

1. Select **Start agent** on the agent settings page.

The agent status is set to **On** on the **AI agents** page. The agent starts processing opportunities and generating research insights. This process might take some time depending on the number of opportunities and the complexity of the knowledge sources.

> [!NOTE]
> If starting the agent fails due to unknown issues, contact Microsoft support.

## Related information

- [Work on opportunities handled by the Sales Close Agent - Research (preview)](use-opportunity-research-agent.md)
- [FAQs about Sales Close Agent - Research (preview)](faqs-about-opportunity-research.md)